Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class PHIEUNHAPBUS
    Private dgDAL As PHIEUNHAPDAL
    Public Sub New()
        dgDAL = New PHIEUNHAPDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New PHIEUNHAPDAL(connectionString)
    End Sub
    'Public Function isValidName(hs As DOCGIADTO) As Boolean

    '    If (hs.HoTen1.Length < 1) Then
    '        Return False
    '    End If

    '    Return True
    'End Function
    Public Function insert(hs As PHIEUNHAPDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(hs)
    End Function
    Public Function update(hs As PHIEUNHAPDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(hs)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiHS As List(Of PHIEUNHAPDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL(listLoaiHS)
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef listHocSinh As List(Of PHIEUNHAPDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL_ByType(maLoai, listHocSinh)
    End Function
    Public Function buildmaHS(ByRef nextMahs As Integer) As Result
        Return dgDAL.buildmaPN(nextMahs)
    End Function
    Public Function getnextID(ByRef inextid As Integer)
        Return dgDAL.NextMPN(inextid)
    End Function
End Class
