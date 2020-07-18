Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class PHIEUTHUTIENDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maPhieuThu]"
        query &= "FROM [tblPhieuThuTien]"
        query &= "ORDER BY [maPhieuThu] DESC"

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
                            idOnDB = reader("maPhieuThu")
                        End While
                    End If
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(phieuthu As PHIEUTHUTIENDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuThuTien] ([maPhieuThu], [maKH], [ngayThuTien], [soTienThu], [lyDoThu])"
        query &= "VALUES (@maPT, @maKH, @ngayThu, @soTienThu, @lyDo)"

        Dim nextID As Integer
        Dim result As Result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If

        phieuthu.MaPhieuThu1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPT", phieuthu.MaPhieuThu1)
                    .Parameters.AddWithValue("@maKH", phieuthu.MaKH1)
                    .Parameters.AddWithValue("@ngayThu", phieuthu.NgayThuTien1)
                    .Parameters.AddWithValue("@soTienThu", phieuthu.SoTienThu1)
                    .Parameters.AddWithValue("@lyDo", phieuthu.LyDoThu1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(id As Integer) As Result
        Dim query As String = String.Empty
        query &= "DELETE FROM [tblPhieuThuTien]"
        query &= "WHERE [maPhieuThu] = @maPT"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPT", id)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Xóa phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblPhieuThuTien]"

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
                        listPhieuThu.Clear()
                        While reader.Read()
                            listPhieuThu.Add(New PHIEUTHUTIENDTO(reader("maPhieuThu"), reader("maKH"), reader("ngayThuTien"), reader("soTienThu"), reader("lyDoThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectByID(id As Integer, ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblPhieuThuTien]"
        query &= "WHERE [maPhieuThu] = @maPT"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPT", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuThu.Clear()
                        While reader.Read()
                            listPhieuThu.Add(New PHIEUTHUTIENDTO(reader("maPhieuThu"), reader("maKH"), reader("ngayThuTien"), reader("soTienThu"), reader("lyDoThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll_ByDate(date_ As String, ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblPhieuThuTien]"
        query &= "WHERE [ngayThuTien] BETWEEN @FirstOfDay AND @LastOfDay"

        Dim date1 = date_ & " 00:00:00"
        Dim date2 = date_ & " 23:59:59"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@FirstOfDay", date1)
                    .Parameters.AddWithValue("@LastOfDay", date2)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuThu.Clear()
                        While reader.Read()
                            listPhieuThu.Add(New PHIEUTHUTIENDTO(reader("maPhieuThu"), reader("maKH"), reader("ngayThuTien"), reader("soTienThu"), reader("lyDoThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    'Chả biết sao lại lỗi luôn
    Public Function selectAll_ByDateAndID(date_ As String, id As Integer, ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblPhieuThuTien]"
        query &= "WHERE [ngayThuTien] BETWEEN @FirstOfDay AND @LastOfDay"
        query &= "AND [maPhieuThu] = @maPT"

        Dim date1 = date_ & " 00:00:00"
        Dim date2 = date_ & " 23:59:59"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@FirstOfDay", date1)
                    .Parameters.AddWithValue("@LastOfDay", date2)
                    .Parameters.AddWithValue("@maPT", id)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuThu.Clear()
                        While reader.Read()
                            listPhieuThu.Add(New PHIEUTHUTIENDTO(reader("maPhieuThu"), reader("maKH"), reader("ngayThuTien"), reader("soTienThu"), reader("lyDoThu")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy tất cả phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function


End Class