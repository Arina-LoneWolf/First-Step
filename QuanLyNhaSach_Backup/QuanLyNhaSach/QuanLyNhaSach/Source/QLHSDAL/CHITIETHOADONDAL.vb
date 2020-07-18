Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class CHITIETHOADONDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maChiTietHoaDon]"
        query &= "FROM [QLNS].[dbo].[tblChiTietHoaDon]"
        query &= "ORDER BY [maChiTietHoaDon] DESC"

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
                            idOnDB = reader("maChiTietHoaDon")
                        End While
                    End If
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của chi tiết hóa đơn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(cthd As CHITIETHOADON) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maSach], [soLuongBan], [donGiaBan], [thanhTien])"
        query &= "VALUES (@maCTHD, @maHD, @maSach, @slBan, @dgBan, @thanhTien)"

        Dim nextID As Integer
        Dim result As Result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If

        cthd.MaChiTietPhieuNhap1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maCTHD", cthd.MaChiTietPhieuNhap1)
                    .Parameters.AddWithValue("@maHD", cthd.MaPhieuNhap1)
                    .Parameters.AddWithValue("@maSach", cthd.MaSach1)
                    .Parameters.AddWithValue("@slBan", cthd.SoLuongBan1)
                    .Parameters.AddWithValue("@dgBan", cthd.DonGiaBan1)
                    .Parameters.AddWithValue("@thanhTien", cthd.ThanhTien1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm CTHD không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(cthd As CHITIETHOADON) As Result
        Dim query As String = String.Empty
        query &= "UPDATE [tblChiTietHoaDon] SET"
        query &= "[maHoaDon] = @maHD,"
        query &= "[maSach] = @maSach"
        query &= "[soLuongBan] = @slBan"
        query &= "[donGiaBan] = @dgBan"
        query &= "[thanhTien] = @thanhTien"
        query &= "WHERE [maChiTietHoaDon] = @maCTHD"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maCTHD", cthd.MaChiTietPhieuNhap1)
                    .Parameters.AddWithValue("@maHD", cthd.MaPhieuNhap1)
                    .Parameters.AddWithValue("@maSach", cthd.MaSach1)
                    .Parameters.AddWithValue("@slBan", cthd.SoLuongBan1)
                    .Parameters.AddWithValue("@dgBan", cthd.DonGiaBan1)
                    .Parameters.AddWithValue("@thanhTien", cthd.ThanhTien1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Cập nhật CTHD không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(imaCTHD As Integer) As Result
        Dim query As String = String.Empty
        query &= "DELETE FROM [tblChiTietHoaDon]"
        query &= "WHERE [maChiTietHoaDon] = @maCTHD"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maCTHD", imaCTHD)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Xóa CTHD không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listCTHD As List(Of CHITIETHOADON)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblChiTietHoaDon]"

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
                        listCTHD.Clear()
                        While reader.Read()
                            listCTHD.Add(New CHITIETHOADON(reader("maChiTietHoaDon"), reader("maHoaDon"), reader("maSach"), reader("soLuongBan"), reader("donGiaBan"), reader("thanhTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả CTHD không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll_ByID(id As Integer, ByRef listCTHD As List(Of CHITIETHOADON)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblChiTietHoaDon]"
        query &= "WHERE [maChiTietHoaDon] = @maCTHD"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maCTHD", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTHD.Clear()
                        While reader.Read()
                            listCTHD.Add(New CHITIETHOADON(reader("maChiTietHoaDon"), reader("maHoaDon"), reader("maSach"), reader("soLuongBan"), reader("donGiaBan"), reader("thanhTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả CTHD không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
