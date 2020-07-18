Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class CHITIETBAOCAOCONGNOBUS
    Private ctbccnDAL As CHITIETBAOCAOCONGNODAL

    Public Sub New()
        ctbccnDAL = New CHITIETBAOCAOCONGNODAL()
    End Sub

    Public Sub New(connectionString As String)
        ctbccnDAL = New CHITIETBAOCAOCONGNODAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ctbccnDAL.getNextID(nextID)
    End Function

    Public Function insert(ctbccn As CHITIETBAOCAOCONGNODTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.insert(ctbccn)
    End Function

    Public Function update(ctbccn As CHITIETBAOCAOCONGNODTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.update(ctbccn)
    End Function

    Public Function delete(mactbccn As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.delete(mactbccn)
    End Function

    Public Function selectAll(ByRef listctbccn As List(Of CHITIETBAOCAOCONGNODTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.selectALL(listctbccn)
    End Function

    Public Function selectAll_byMaBaoCao(maBaoCao As Integer, ByRef listctbccn As List(Of CHITIETBAOCAOCONGNODTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctbccnDAL.selectALL_byMaBaoCao(maBaoCao, listctbccn)
    End Function


End Class
