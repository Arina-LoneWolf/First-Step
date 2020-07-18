Imports QLHSDAL
Imports QLHSDTO
Imports Utility
Public Class LOAISACHBUS
    Private theloaidal As LOAISACHDAL
    Public Sub New()
        theloaidal = New LOAISACHDAL()
    End Sub

    Public Sub New(connectionString As String)
        theloaidal = New LOAISACHDAL(connectionString)
    End Sub

    Public Function isValidName(theloai As THELOAIDTO) As Boolean

        If (theloai.Strtenloaisach.Length < 1) Then
            Return False
        End If
        Return True

    End Function

    Public Function insert(ls As THELOAIDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return theloaidal.insert(ls)
    End Function

    Public Function update(ls As THELOAIDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return theloaidal.update(ls)
    End Function

    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return theloaidal.delete(maLoai)
    End Function

    Public Function getNextID(ByRef inextID As Integer) As Result
        Return theloaidal.nextmtl(inextID)
    End Function

    Public Function selectall(ByRef listtheloai As List(Of THELOAIDTO)) As Result
        Return theloaidal.selectall(listtheloai)
    End Function

    Public Function selectall(ByRef listtheloai As List(Of THELOAIDTO), ID As Integer) As Result
        Return theloaidal.selectALLByID(listtheloai, ID)
    End Function
End Class
