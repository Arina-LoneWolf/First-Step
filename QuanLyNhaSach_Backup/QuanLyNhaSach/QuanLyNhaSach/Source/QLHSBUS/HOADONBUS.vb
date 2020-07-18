Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class HOADONBUS
    Private hdDAL As HOADONDAL

    Public Sub New()
        hdDAL = New HOADONDAL()
    End Sub

    Public Sub New(connectionString As String)
        hdDAL = New HOADONDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return hdDAL.getNextID(nextID)
    End Function

    Public Function insert(hoadon As HOADONDTO) As Result
        Return hdDAL.insert(hoadon)
    End Function

    Public Function update(hoadon As HOADONDTO) As Result
        Return hdDAL.update(hoadon)
    End Function

    Public Function delete(id As Integer) As Result
        Return hdDAL.delete(id)
    End Function

    Public Function selectAll(ByRef listHD As List(Of HOADONDTO)) As Result
        Return hdDAL.selectAll(listHD)
    End Function

    Public Function selectAll_ByID(id As Integer, ByRef listHD As List(Of HOADONDTO)) As Result
        Return hdDAL.selectAll_ByID(id, listHD)
    End Function

    Public Function selectAllID(listIdHD As List(Of Integer)) As Result
        Return hdDAL.selectAllID(listIdHD)
    End Function
End Class
