Imports QLHSDAL
Imports QLHSDTO
Imports Utility

Public Class CHITIETPHIEUNHAPBUS
    Private dgDAL As CHITIETPHIEUNHAPDAL
    Public Sub New()
        dgDAL = New CHITIETPHIEUNHAPDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New CHITIETPHIEUNHAPDAL(connectionString)
    End Sub
    Public Function insertct(ctpn As CHITIETPHIEUNHAPDTO) As Result
        Return dgDAL.insertct(ctpn)
    End Function
    Public Function getnextID(ByRef inextid As Integer)
        Return dgDAL.NextMCTPN(inextid)
    End Function
End Class
