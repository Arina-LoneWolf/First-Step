Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class BAOCAOCONGNOBUS
    Private bccnDAL As BAOCAOCONGNODAL

    Public Sub New()
        bccnDAL = New BAOCAOCONGNODAL()
    End Sub

    Public Sub New(connectionString As String)
        bccnDAL = New BAOCAOCONGNODAL(connectionString)
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return bccnDAL.getNextID(nextID)
    End Function
    Public Function insert(bccn As BAOCAOCONGNODTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.insert(bccn)
    End Function

    Public Function update(bccn As BAOCAOCONGNODTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.update(bccn)
    End Function

    Public Function delete(maBaoCaoCongNo As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.delete(maBaoCaoCongNo)
    End Function

    Public Function selectAll(ByRef listBaoCaoCongNo As List(Of BAOCAOCONGNODTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.selectALL(listBaoCaoCongNo)
    End Function

    Public Function selectAll_byMaBaoCaoCongNo(maBaoCaoCongNo As Integer, ByRef listBaoCaoCongNo As List(Of BAOCAOCONGNODTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.selectAll_byMaBaoCaoCongNo(maBaoCaoCongNo, listBaoCaoCongNo)
    End Function

    Public Function selectAll_byThang(thang As Integer, ByRef listBaoCaoCongNo As List(Of BAOCAOCONGNODTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccnDAL.selectAll_byThang(thang, listBaoCaoCongNo)
    End Function
End Class
