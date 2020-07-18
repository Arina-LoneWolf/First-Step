Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class SACHBUS
    Private sachDAL As SACHDAL
    Public Sub New()
        sachDAL = New SACHDAL
    End Sub


    'kiem tra ten
    Public Function isValicdname(sach As SACHDTO)
        If (sach.Strtensach.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function insert(sach As SACHDTO) As Result
        Return sachDAL.insert(sach)
    End Function
    Public Function delete(sach As SACHDTO) As Result
        Return sachDAL.delete(sach.Imasach)
    End Function
    Public Function update(sach As SACHDTO) As Result
        Return sachDAL.update(sach)
    End Function
    Public Function selectAll(ByRef listSach As List(Of SACHDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sachDAL.getallsach(listSach)
    End Function

    Public Function getnextID(ByRef inextid As Integer)
        Return sachDAL.NextMS(inextid)
    End Function

    Public Function selectAll_ByType(id As String, ByRef listSach As List(Of SACHDTO))
        Return sachDAL.selectAll_ByType(id, listSach)
    End Function

    Public Function selectAll_ByName(name As String, ByRef listSach As List(Of SACHDTO))
        Return sachDAL.selectAll_ByName(name, listSach)
    End Function
End Class
