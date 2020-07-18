Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class PHIEUTHUTIENBUS
    Private phieuthuDAL As PHIEUTHUTIENDAL
    Public Sub New()
        phieuthuDAL = New PHIEUTHUTIENDAL
    End Sub
    Public Sub New(connectionString As String)
        phieuthuDAL = New PHIEUTHUTIENDAL(connectionString)
    End Sub
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return phieuthuDAL.getNextID(nextID)
    End Function

    Public Function insert(phieuthu As PHIEUTHUTIENDTO) As Result
        Return phieuthuDAL.insert(phieuthu)
    End Function

    Public Function delete(id As Integer) As Result
        Return phieuthuDAL.Delete(id)
    End Function

    Public Function selectAll(ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Return phieuthuDAL.selectAll(listPhieuThu)
    End Function

    Public Function selectByID(id As Integer, ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Return phieuthuDAL.selectByID(id, listPhieuThu)
    End Function

    Public Function selectAll_ByDate(date_ As String, ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Return phieuthuDAL.selectAll_ByDate(date_, listPhieuThu)
    End Function

    Public Function selectAll_ByDateAndID(date_ As String, id As Integer, ByRef listPhieuThu As List(Of PHIEUTHUTIENDTO)) As Result
        Return phieuthuDAL.selectAll_ByDateAndID(date_, id, listPhieuThu)
    End Function
End Class