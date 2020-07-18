Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class CHITIETHOADONBUS
    Private cthdDAL As CHITIETHOADONDAL

    Public Sub New()
        cthdDAL = New CHITIETHOADONDAL()
    End Sub

    Public Sub New(connectionString As String)
        cthdDAL = New CHITIETHOADONDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return cthdDAL.getNextID(nextID)
    End Function

    Public Function insert(cthd As CHITIETHOADON) As Result
        Return cthdDAL.insert(cthd)
    End Function

    Public Function update(cthd As CHITIETHOADON) As Result
        Return cthdDAL.update(cthd)
    End Function

    Public Function delete(id As Integer) As Result
        Return cthdDAL.delete(id)
    End Function

    Public Function selectAll(ByRef listCTHD As List(Of CHITIETHOADON)) As Result
        Return cthdDAL.selectAll(listCTHD)
    End Function

    Public Function selectAll_ByID(id As Integer, ByRef listCTHD As List(Of CHITIETHOADON)) As Result
        Return cthdDAL.selectAll_ByID(id, listCTHD)
    End Function
End Class
