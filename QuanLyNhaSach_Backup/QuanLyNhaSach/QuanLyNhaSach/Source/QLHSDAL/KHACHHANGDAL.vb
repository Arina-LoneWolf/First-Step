Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class KHACHHANGDAL
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
        query &= "SELECT TOP 1 [maKH]"
        query &= "FROM [QLNS].[dbo].[tblKhachHang]"
        query &= "ORDER BY [maKH] DESC "

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
                            idOnDB = reader("maKH")
                        End While
                    End If
                    'new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()

                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(kh As KHACHHANGDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [QLNS].[dbo].[tblKhachHang]([maKH],[hoTenKH],[tienNoKH],[diaChi],[email],[sdt])"
        query &= "VALUES (@maKH,@hoTenKH,@tienNoKH,@diaChi,@email,@sdt)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        kh.MaKH1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKH", kh.MaKH1)
                    .Parameters.AddWithValue("@hoTenKH", kh.HoTenKH1)
                    .Parameters.AddWithValue("@tienNoKH", kh.TienNoKH1)
                    .Parameters.AddWithValue("@diaChi", kh.DiaChi1)
                    .Parameters.AddWithValue("@email", kh.Email1)
                    .Parameters.AddWithValue("@sdt", kh.Sdt1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(kh As KHACHHANGDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [dbo].[tblKhachHang] SET"
        query &= " [hoTenKH] = @hotenKH "
        query &= " ,[tienNoKH] = @tienNoKH "
        query &= " ,[diaChi] = @diaChi "
        query &= " ,[email] = @email "
        query &= " ,[sdt] = @sdt "
        query &= "WHERE "
        query &= " [maKH] = @maKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKH", kh.MaKH1)
                    .Parameters.AddWithValue("@hoTenKH", kh.HoTenKH1)
                    .Parameters.AddWithValue("@tienNoKH", kh.TienNoKH1)
                    .Parameters.AddWithValue("@diaChi", kh.DiaChi1)
                    .Parameters.AddWithValue("@email", kh.Email1)
                    .Parameters.AddWithValue("@sdt", kh.Sdt1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectALL(ByRef listKH As List(Of KHACHHANGDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblKhachHang]"

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
                        listKH.Clear()
                        While reader.Read()
                            listKH.Add(New KHACHHANGDTO(reader("maKH"), reader("hoTenKH"), reader("tienNoKH"), reader("diaChi"), reader("Email"), reader("Sdt")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectALL_ByType(makh As Integer, ByRef listkh As List(Of KHACHHANGDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [dbo].[tblKhachHang] "
        query &= "WHERE [maKH] = @makh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKH", makh)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listkh.Clear()
                        While reader.Read()
                            listkh.Add(New KHACHHANGDTO(reader("maKH"), reader("hoTenKH"), reader("tienNoKH"), reader("diaChi"), reader("email"), reader("sdt")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy khách hàng theo mã khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function


    Public Function SelectAll_BySdt(sdt As String, ByRef listkh As List(Of KHACHHANGDTO))
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblKhachHang]"
        query &= " WHERE "
        query &= " [sdt] = @sdt"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@sdt", sdt)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listkh.Clear()
                        While reader.Read()
                            listkh.Add(New KHACHHANGDTO(reader("maKH"), reader("hoTenKH"), reader("tienNoKH"), reader("diaChi"), reader("email"), reader("sdt")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)


    End Function

    Public Function selectALL_ByName(name As String, ByRef listkh As List(Of KHACHHANGDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblKhachHang]"
        query &= " WHERE "
        query &= " [hoTenKH] = @hoTenKH"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hoTenKH", name)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listkh.Clear()
                        While reader.Read()
                            listkh.Add(New KHACHHANGDTO(reader("maKH"), reader("hoTenKH"), reader("tienNoKH"), reader("diaChi"), reader("email"), reader("sdt")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(makh As Integer) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [dbo].[tblKhachHang] "
        query &= " WHERE "
        query &= " [maKH] = @maKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maKH", makh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
