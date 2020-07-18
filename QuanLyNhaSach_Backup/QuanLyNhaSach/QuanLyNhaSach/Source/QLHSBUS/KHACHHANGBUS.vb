Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class KHACHHANGBUS
    Private khDAL As KHACHHANGDAL
    Public Sub New()
        khDAL = New KHACHHANGDAL
    End Sub

    Public Sub New(connectionString As String)
        khDAL = New KHACHHANGDAL(connectionString)
    End Sub
    Public Function isValidName(kh As KHACHHANGDTO) As Boolean
        If (kh.HoTenKH1.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Function IsValidEmailFormat(ByVal adr As String) As Boolean
        Try
            Dim Email As New System.Net.Mail.MailAddress(adr)
        Catch
            Return False
        End Try
        Return True
    End Function

    Public Function insert(kh As KHACHHANGDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.insert(kh)
    End Function
    Public Function update(kh As KHACHHANGDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.update(kh)
    End Function
    Public Function delete(makh As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.delete(makh)
    End Function
    Public Function selectAll(ByRef listkh As List(Of KHACHHANGDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.selectALL(listkh)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return khDAL.getNextID(nextID)
    End Function

    Public Function selectALL_ByType(makh As Integer, ByRef listkh As List(Of KHACHHANGDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return khDAL.selectALL_ByType(makh, listkh)
    End Function

    Public Function selectALL_ByName(name As String, ByRef listkh As List(Of KHACHHANGDTO)) As Result
        Return khDAL.selectALL_ByName(name, listkh)
    End Function
End Class
