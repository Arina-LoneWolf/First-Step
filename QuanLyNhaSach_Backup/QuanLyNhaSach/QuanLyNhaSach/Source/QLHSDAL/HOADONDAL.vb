Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class HOADONDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maHoaDon]"
        query &= "FROM [QLNS].[dbo].[tblHoaDon]"
        query &= "ORDER BY [maHoaDon] DESC"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader = comm.ExecuteReader()
                    Dim idOnDB As Integer = Nothing
                    If (reader.HasRows = True) Then
                        While (reader.Read())
                            idOnDB = reader("maHoaDon")
                        End While
                    End If
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(hoadon As HOADONDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblHoaDon] ([maHoaDon], [ngayHoaDon], [maKH], [tongGiaTriHD])"
        query &= "VALUES (@maHD, @ngayHD, @maKH, @tongGT)"

        Dim nextID As Integer
        Dim result As Result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If

        hoadon.MaHD = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("maHD", hoadon.MaHD)
                    .Parameters.AddWithValue("ngayHD", hoadon.NgayHD)
                    .Parameters.AddWithValue("maKH", hoadon.MaKH)
                    .Parameters.AddWithValue("tongGT", hoadon.TongGT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(hoadon As HOADONDTO) As Result
        Dim query As String = String.Empty
        query &= "UPDATE [tblHoaDon] SET"
        query &= "[ngayHoaDon] = @ngayHD"
        query &= "[maKH] = @maKH"
        query &= "[tongGiaTriHD] = @tongGT"
        query &= "WHERE [maHoaDon] = @maHD"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("maHD", hoadon.MaHD)
                    .Parameters.AddWithValue("ngayHD", hoadon.NgayHD)
                    .Parameters.AddWithValue("maKH", hoadon.MaKH)
                    .Parameters.AddWithValue("tongGT", hoadon.TongGT)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Cập nhật hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(id As Integer) As Result
        Dim query As String = String.Empty
        query &= "DELETE FROM [tblHoaDon]"
        query &= "WHERE [maHoaDon] = @maHD"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHD", id)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Xóa hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listHD As List(Of HOADONDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblHoaDon]"

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
                        listHD.Clear()
                        While reader.Read()
                            listHD.Add(New HOADONDTO(reader("maHoaDon"), reader("ngayHoaDon"), reader("maKH"), reader("tongGiaTriHD")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll_ByID(id As Integer, ByRef listHD As List(Of HOADONDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblHoaDon]"
        query &= "WHERE [maHoaDon] = @maHD"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maHD", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHD.Clear()
                        While reader.Read()
                            listHD.Add(New HOADONDTO(reader("maHoaDon"), reader("ngayHoaDon"), reader("maKH"), reader("tongGiaTriHD")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAllID(listIdHD As List(Of Integer)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblHoaDon]"
        query &= "ORDER BY [maHoaDon] DESC"

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
                        While reader.Read()
                            listIdHD.Add(reader("maHoaDon"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
