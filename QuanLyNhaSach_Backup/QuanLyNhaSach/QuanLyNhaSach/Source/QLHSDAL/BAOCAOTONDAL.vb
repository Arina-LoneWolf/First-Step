Imports System.Configuration
Imports System.Data.SqlClient
Imports QLHSDTO
Imports Utility

Public Class BAOCAOTONDAL

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
        query &= "SELECT TOP 1 [maBaoCaoTon]"
        query &= "FROM [QLNS].[dbo].[tblBaoCaoTon]"
        query &= "ORDER BY [maBaoCaoTon] DESC "

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
                            idOnDB = reader("maBaoCaoTon")
                        End While
                    End If
                    'new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()

                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của báo cáo tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function insert(bct As BAOCAOTONDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblBaoCaoTon]([maBaoCaoTon],[thang])"
        query &= "VALUES (@maBaoCaoTon,@thang)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        bct.MaBaoCaoTon1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoTon", bct.MaBaoCaoTon1)
                    .Parameters.AddWithValue("@thang", bct.Thang1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm báo cáo tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(bct As BAOCAOTONDTO) As Result

        Dim query As String = String.Empty

        query &= " UPDATE [dbo].[tblBaoCaoTon] SET"
        query &= " [thang] = @thang "
        query &= "WHERE "
        query &= " [maBaoCaoTon] = @maBaoCaoTon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoTon", bct.MaBaoCaoTon1)
                    .Parameters.AddWithValue("@thang", bct.Thang1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật báo cáo tồn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listBaoCaoTon As List(Of BAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblBaoCaoTon]"


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
                        listBaoCaoTon.Clear()
                        While reader.Read()
                            listBaoCaoTon.Add(New BAOCAOTONDTO(reader("maBaoCaoTon"), reader("thang")))
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
    Public Function selectALL_byMaBaoCaoTon(maBaoCaoTon As Integer, ByRef listBaoCaoTon As List(Of BAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblBaoCaoTon]"
        query &= " WHERE "
        query &= " [maBaoCaoTon] = @maBaoCaoTon"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoTon", maBaoCaoTon)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoTon.Clear()
                        While reader.Read()
                            listBaoCaoTon.Add(New BAOCAOTONDTO(reader("maBaoCaoTon"), reader("thang")))
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
    Public Function selectALL_byThang(thang As Integer, ByRef listBaoCaoTon As List(Of BAOCAOTONDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [dbo].[tblBaoCaoTon]"
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
                        listBaoCaoTon.Clear()
                        While reader.Read()
                            listBaoCaoTon.Add(New BAOCAOTONDTO(reader("maBaoCaoTon"), reader("thang")))
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
    Public Function delete(mabct As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [dbo].[tblBaoCaoTon] "
        query &= " WHERE "
        query &= " [maBaoCaoTon] = @maBaoCaoTon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maBaoCaoTon", mabct)
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
