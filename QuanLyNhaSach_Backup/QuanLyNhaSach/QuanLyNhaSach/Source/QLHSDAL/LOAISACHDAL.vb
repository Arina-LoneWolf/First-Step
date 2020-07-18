Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility
Public Class LOAISACHDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function nextmtl(ByRef inextmtl As Integer)
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maLoaiSach] "
        query &= "FROM [tblLoaiSach] "
        query &= "ORDER BY [maLoaiSach] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("maLoaiSach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    inextmtl = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    inextmtl = 1
                    Return New Result(False, "Lấy ID kế tiếp của loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

#Region "them xoa sua"
    Public Function insert(theloai As THELOAIDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiSach] ([maloaisach], [tenloaisach])"
        query &= "VALUES (@maloaisach,@tenloaisach)"

        Dim inextID = 0
        Dim result As Result
        result = nextmtl(inextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        theloai.Imaloaisach = inextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", theloai.Imaloaisach)
                    .Parameters.AddWithValue("@tenloaisach", theloai.Strtenloaisach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(theloai As THELOAIDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaiSach] SET"
        query &= " [TENLOAISACH] = @tenloaisach "
        query &= "WHERE "
        query &= " [MALOAISACH] = @maloaisach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", theloai.Imaloaisach)
                    .Parameters.AddWithValue("@tenloaisach", theloai.Strtenloaisach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(imaloaisach As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaiSach] "
        query &= " WHERE "
        query &= " [maloaisach] = @maloaisach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaisach", imaloaisach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listtheloai As List(Of THELOAIDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblLoaiSach]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtheloai.Clear()
                        While reader.Read()
                            listtheloai.Add(New THELOAIDTO(reader("maloaisach"), reader("tenloaisach")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALLByID(ByRef listtheloai As List(Of THELOAIDTO), ID As Integer) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblLoaiSach]"
        query &= " Where [maLoaiSach] = @ID"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID", ID)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listtheloai.Clear()
                        While reader.Read()
                            listtheloai.Add(New THELOAIDTO(reader("maloaisach"), reader("tenloaisach")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

#End Region
End Class
