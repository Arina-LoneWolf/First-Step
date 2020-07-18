Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class PHIEUNHAPDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function buildmaPN(ByRef nextmaPN As String) As Result 'ex: 18222229

        nextmaPN = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextmaPN = x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaPhieuNhap] "
        query &= "From [tblPhieuNhapSach] "
        query &= "Order By [MaPhieuNhap] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("MaPhieuNhap")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextmaPN = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextmaPN = nextmaPN + tmp
                        System.Console.WriteLine(nextmaPN)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Doc gia kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(hs As PHIEUNHAPDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuNhap] ([maPhieuNhap], [ngayNhap]) "
        query &= "VALUES (@maPhieuNhap, @ngayNhap)"

        'get madocgia
        Dim nextmadocgia = 1
        NextMPN(nextmadocgia)

        hs.Imaphieunhap = nextmadocgia

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuNhap", hs.Imaphieunhap)
                    .Parameters.AddWithValue("@ngayNhap", hs.Datengaynhap)


                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phiếu nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listHocSinh As List(Of PHIEUNHAPDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [madocgia], [hoten], [diachi], [ngaysinh],[ngaylapthe]"
        query &= "FROM [tblPhieuNhapSach]"


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
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phiếu nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByType(maLoai As Integer, ByRef listHocSinh As List(Of PHIEUNHAPDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [madocgia], [maloaihocsinh], [hoten], [diachi], [ngaysinh],[ngayhethan]"
        query &= "FROM [tblPhieuNhapSach] "
        query &= "WHERE [maloaihocsinh] = @maloaihocsinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaihocsinh", maLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phiếu nhập sách theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function update(hs As PHIEUNHAPDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuNhapSach] SET"
        query &= " ,[NgayNhapSach] = @ngaynhapsach "
        query &= " ,[TenSach] = @tensach "
        query &= " ,[TheLoai] = @theloai "
        query &= " ,[TacGia] = @tacgia "
        query &= " ,[SoLuongNhap] = @soluongnhap "
        query &= " WHERE "
        query &= " [MaPhieuNhapSach] = @maphieunhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật phiếu nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(maPhieu As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuNhapSach] "
        query &= " WHERE "
        query &= " [MaPhieuNhapSach] = @maphieunhap"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", maPhieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phiếu nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function NextMPN(ByRef inextMPN As Integer) 'Lay ma phiếu nhập
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maPhieuNhap] "
        query &= "FROM [tblPhieuNhap] "
        query &= "ORDER BY [maPhieuNhap] DESC "

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
                            idOnDB = reader("maPhieuNhap")
                        End While
                    End If
                    ' new ID = current ID + 1
                    inextMPN = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    inextMPN = 1
                    Return New Result(False, "Lấy ID kế tiếp của phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

End Class
