Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility
Public Class CHITIETPHIEUNHAPDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function insertct(ctpn As CHITIETPHIEUNHAPDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietPhieuNhap] ([maChiTietPhieuNhap], [maPhieuNhap], [maSach], [tenSach], [soLuongNhap], [tenLoaiSach], [tacgia], [dongia] )"
        query &= "VALUES (@maChiTietPhieuNhap, @maPhieuNhap, @maSach, @tenSach, @soLuongNhap, @tenLoaiSach, @tacGia, @donGia)"
        ' get chitietphieunhap
        Dim nextChitietphieunhap = 1
        'NextMCTPN(nextChitietphieunhap)
        'ctpn.Imachitietphieunhap = nextChitietphieunhap
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietPhieuNhap", ctpn.Imachitietphieunhap) 'dung nhung ko vao cung nhu thuc hien dc lenh
                    .Parameters.AddWithValue("@maPhieuNhap", ctpn.Imaphieunhap)                 ' conn.open() comm.executeNonQuery()
                    .Parameters.AddWithValue("@maSach", ctpn.Imasach)
                    .Parameters.AddWithValue("@tenSach", ctpn.ItenSach)
                    .Parameters.AddWithValue("@soLuongNhap", ctpn.Isoluongnhap)
                    .Parameters.AddWithValue("@tenLoaiSach", ctpn.Itheloai)
                    .Parameters.AddWithValue("@tacGia", ctpn.Itacgia)
                    .Parameters.AddWithValue("@donGia", ctpn.Idongia)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chi tiet phiếu nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function NextMCTPN(ByRef inextMCTPN As Integer) 'Lay ma phiếu nhập
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maChiTietPhieuNhap] "
        query &= "FROM [tblChiTietPhieuNhap] "
        query &= "ORDER BY [maChiTietPhieuNhap] DESC "

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
                            idOnDB = reader("maChiTietPhieuNhap")
                        End While
                    End If
                    ' new ID = current ID + 1
                    inextMCTPN = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    inextMCTPN = 1
                    Return New Result(False, "Lấy ID kế tiếp của phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function
End Class
