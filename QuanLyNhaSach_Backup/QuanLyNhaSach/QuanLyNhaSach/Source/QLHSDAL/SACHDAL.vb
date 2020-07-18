Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility
Public Class SACHDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    ' Tu dong tao maSach
    Public Function NextMS(ByRef inextMS As Integer)
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MASACH] "
        query &= "FROM [tblSach] "
        query &= "ORDER BY [MASACH] DESC "

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
                            idOnDB = reader("MASACH")
                        End While
                    End If
                    ' new ID = current ID + 1
                    inextMS = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    inextMS = 1
                    Return New Result(False, "Lấy ID kế tiếp của sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function
#Region "Thêm xóa sửa Sách"


    Public Function insert(sach As SACHDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblSach] ([maSach], [tenSach], [maLoaiSach], [tacGia], [donGia],[soLuongTon])"
        query &= "VALUES (@masach,@tensach,@maloaisach,@tacgia,@dongia,@soluongton)"

        'get nextms
        Dim inextMS = 0
        Dim result As Result
        result = NextMS(inextMS)
        If (result.FlagResult = False) Then
            Return result
        End If
        sach.Imasach = inextMS
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", sach.Imasach)
                    .Parameters.AddWithValue("@tensach", sach.Strtensach)
                    .Parameters.AddWithValue("@maloaisach", sach.Imaloaisach)
                    .Parameters.AddWithValue("@tacgia", sach.Strtacgia)
                    .Parameters.AddWithValue("@dongia", sach.Idongia)
                    .Parameters.AddWithValue("@soluongton", sach.Isoluongton)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(sach As SACHDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblSach] SET"
        query &= " [tenSach] = @tensach "
        query &= " ,[maLoaiSach] = @maloaisach "
        query &= " ,[tacGia] = @tacgia "
        query &= " ,[soLuongTon] = @soluong "
        query &= " ,[donGia] = @dongia "
        query &= "WHERE "
        query &= " [masach] = @masach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", sach.Imasach)
                    .Parameters.AddWithValue("@tensach", sach.Strtensach)
                    .Parameters.AddWithValue("@maloaisach", sach.Imaloaisach)
                    .Parameters.AddWithValue("@tacgia", sach.Strtacgia)
                    .Parameters.AddWithValue("@soluong", sach.Isoluongton)
                    .Parameters.AddWithValue("@dongia", sach.Idongia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(imasach As Integer)
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblSACH] "
        query &= " WHERE "
        query &= " [masach] = @masach "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", imasach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


#End Region

#Region "Lọc danh sách sách theo MS, tên sách , thể loại,tác giả, số lượng tồn,tổng số lượng bán, tổng tiền bán,đơn giá"
    Public Function getallsach(ByRef listSach As List(Of SACHDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblSACH]"


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
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New SACHDTO(reader("MASACH"), reader("TENSACH"), reader("MALOAISACH"), reader("TACGIA"), reader("DONGIA"), reader("SOLUONGTON")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

#End Region

#Region "Lọc danh sách sách theo ID"
    Public Function selectAll_ByType(id As String, ByRef listSach As List(Of SACHDTO))
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblSach]"
        query &= "WHERE [maSach] = @maSach"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maSach", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If (reader.HasRows = True) Then
                        listSach.Clear()
                        While (reader.Read())
                            listSach.Add(New SACHDTO(reader("MASACH"), reader("TENSACH"), reader("MALOAISACH"), reader("TACGIA"), reader("DONGIA"), reader("SOLUONGTON")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
#End Region

#Region "Lọc danh sách sách theo tên"
    Public Function selectAll_ByName(name As String, ByRef listSach As List(Of SACHDTO))
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblSach]"
        query &= "WHERE [tenSach] = @tenSach"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenSach", name)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If (reader.HasRows = True) Then
                        listSach.Clear()
                        While (reader.Read())
                            listSach.Add(New SACHDTO(reader("MASACH"), reader("TENSACH"), reader("MALOAISACH"), reader("TACGIA"), reader("DONGIA"), reader("SOLUONGTON")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
#End Region
End Class