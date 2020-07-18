Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class BAOCAOCONGNODAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maBaoCaoCongNo] "
        query &= "FROM [QLNS].[dbo].[tblBaoCaoCongNo] "
        query &= "ORDER BY [maBaoCaoCongNo] DESC "

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
                            idOnDB = reader("maBaoCaoCongNo")
                        End While
                    End If
                    'new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()

                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function insert(bccn As BAOCAOCONGNODTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblBaoCaoCongNo]([maBaoCaoCongNo],[thang])"
        query &= "VALUES (@maBaoCaoCongNo,@thang)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        bccn.MaBaoCaoCongNo1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoCongNo", bccn.MaBaoCaoCongNo1)
                    .Parameters.AddWithValue("@thang", bccn.Thang1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(bccn As BAOCAOCONGNODTO) As Result

        Dim query As String = String.Empty

        query &= " UPDATE [dbo].[tblBaoCaoCongNo] SET "
        query &= " [thang] = @thang "
        query &= "WHERE "
        query &= " [maBaoCaoCongNo] = @maBaoCaoCongNo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoCongNo", bccn.MaBaoCaoCongNo1)
                    .Parameters.AddWithValue("@thang", bccn.Thang1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listBaoCaoCongNo As List(Of BAOCAOCONGNODTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblBaoCaoCongNo]"


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
                        listBaoCaoCongNo.Clear()
                        While reader.Read()
                            listBaoCaoCongNo.Add(New BAOCAOCONGNODTO(reader("maBaoCaoCongNo"), reader("thang")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất danh sách báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_byMaBaoCaoCongNo(maBaoCaoCongNo As Integer, ByRef listBaoCaoCongNo As List(Of BAOCAOCONGNODTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblBaoCaoCongNo]"
        query &= " WHERE "
        query &= " [maBaoCaoCongNo] = @maBaoCaoCongNo"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoCongNo", maBaoCaoCongNo)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoCongNo.Clear()
                        While reader.Read()
                            listBaoCaoCongNo.Add(New BAOCAOCONGNODTO(reader("maBaoCaoCongNo"), reader("thang")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất danh sách báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectAll_byThang(thang As Integer, ByRef listBaoCaoCongNo As List(Of BAOCAOCONGNODTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblBaoCaoCongNo]"
        query &= " WHERE "
        query &= " month([thang]) = @thang"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", thang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoCongNo.Clear()
                        While reader.Read()
                            listBaoCaoCongNo.Add(New BAOCAOCONGNODTO(reader("maBaoCaoCongNo"), reader("thang")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất danh sách báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maBaoCaoCongNo As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [dbo].[tblBaoCaoCongNo]"
        query &= " WHERE "
        query &= " [maBaoCaoCongNo] = @maBaoCaoCongNo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoCongNo", maBaoCaoCongNo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
