Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class CHITIETBAOCAOCONGNODAL

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
        query &= "SELECT TOP 1 [maChiTietBaoCaoCongNo]"
        query &= "FROM [QLNS].[dbo].[tblChiTietBaoCaoCongNo]"
        query &= "ORDER BY [maChiTietBaoCaoCongNo] DESC "

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
                            idOnDB = reader("maChiTietBaoCaoCongNo")
                        End While
                    End If
                    'new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()

                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(ctbccn As CHITIETBAOCAOCONGNODTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblChiTietBaoCaoCongNo]([maChiTietBaoCaoCongNo],[maKH],[maBaoCaoCongNo],[noDau],[noPhatSinh],[noCuoi])"
        query &= "VALUES (@maChiTietBaoCaoCongNo,@maKH,@maBaoCaoCongNo,@noDau,@noPhatSinh,@noCuoi)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        ctbccn.MaChiTietBaoCaoCongNo1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoCongNo", ctbccn.MaChiTietBaoCaoCongNo1)
                    .Parameters.AddWithValue("@maKH", ctbccn.MaKH1)
                    .Parameters.AddWithValue("@maBaoCaoCongNo", ctbccn.MaBaoCaoCongNo1)
                    .Parameters.AddWithValue("@noDau", ctbccn.NoDau1)
                    .Parameters.AddWithValue("@noPhatSinh", ctbccn.NoPhatSinh1)
                    .Parameters.AddWithValue("@noCuoi", ctbccn.NoCuoi1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(ctbccn As CHITIETBAOCAOCONGNODTO) As Result

        Dim query As String = String.Empty

        query &= " UPDATE [dbo].[tblChiTietBaoCaoCongNo] SET "
        query &= " [maKH] = @maKH"
        query &= " ,[maBaoCaoCongNo] = @maBaoCaoCongNo"
        query &= " ,[noDau] = @noDau"
        query &= " ,[noPhatSinh] = @noPhatSinh"
        query &= " ,[noCuoi] = @noCuoi"
        query &= " WHERE "
        query &= " [maChiTietBaoCaoCongNo] = @maChiTietBaoCaoCongNo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoCongNo", ctbccn.MaChiTietBaoCaoCongNo1)
                    .Parameters.AddWithValue("@maKH", ctbccn.MaKH1)
                    .Parameters.AddWithValue("@maBaoCaoCongNo", ctbccn.MaBaoCaoCongNo1)
                    .Parameters.AddWithValue("@noDau", ctbccn.NoDau1)
                    .Parameters.AddWithValue("@noPhatSinh", ctbccn.NoPhatSinh1)
                    .Parameters.AddWithValue("@noCuoi", ctbccn.NoCuoi1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật báo chi tiết cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listBaoCaoCongNo As List(Of CHITIETBAOCAOCONGNODTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [QLNS].[dbo].[tblChiTietBaoCaoCongNo]"


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
                            listBaoCaoCongNo.Add(New CHITIETBAOCAOCONGNODTO(reader("maChiTietBaoCaoCongNo"), reader("maKH"), reader("maBaoCaoCongNo"), reader("noDau"), reader("noPhatSinh"), reader("noCuoi")))
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

    Public Function selectALL_byMaBaoCao(maBaoCao As Integer, ByRef listCTBaoCaoCongNo As List(Of CHITIETBAOCAOCONGNODTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [QLNS].[dbo].[tblChiTietBaoCaoCongNo]"
        query &= " WHERE [maChiTietBaoCaoCongNo] = @maChiTietBaoCaoCongNo"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoCongNo", maBaoCao)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTBaoCaoCongNo.Clear()
                        While reader.Read()
                            listCTBaoCaoCongNo.Add(New CHITIETBAOCAOCONGNODTO(reader("maChiTietBaoCaoCongNo"), reader("maKH"), reader("maBaoCaoCongNo"), reader("noDau"), reader("noPhatSinh"), reader("noCuoi")))
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


    Public Function delete(mactbccn As Integer) As Result

        Dim query As String = String.Empty
        query &= " FROM [QLNS].[dbo].[tblChiTietBaoCaoCongNo] "
        query &= " WHERE "
        query &= " WHERE [maChiTietBaoCaoCongNo] = @maChiTietBaoCaoCongNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maChiTietBaoCaoCongNo", mactbccn)
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
