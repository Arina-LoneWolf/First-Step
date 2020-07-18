Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class BAOCAOTONBUS
    Private bctDAL As BAOCAOTONDAL

    Public Sub New()
        bctDAL = New BAOCAOTONDAL()
    End Sub

    Public Sub New(connectionString As String)
        bctDAL = New BAOCAOTONDAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return bctDAL.getNextID(nextID)
    End Function

    Public Function insert(bct As BAOCAOTONDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.insert(bct)
    End Function

    Public Function update(bct As BAOCAOTONDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.update(bct)
    End Function

    Public Function delete(mabct As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.delete(mabct)
    End Function

    Public Function selectAll(ByRef listbct As List(Of BAOCAOTONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.selectALL(listbct)
    End Function

    Public Function selectAll_byMaBaoCaoTon(maBaoCaoTon As Integer, ByRef listbct As List(Of BAOCAOTONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.selectALL_byMaBaoCaoTon(maBaoCaoTon, listbct)
    End Function

    Public Function selectAll_byThang(thang As Integer, ByRef listbct As List(Of BAOCAOTONDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bctDAL.selectALL_byThang(thang, listbct)
    End Function

End Class
