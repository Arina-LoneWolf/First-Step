Public Class PHIEUNHAPDTO 'VS CHITIETPHIEUNHAP
    Private _imaphieunhap As Integer
    Private _datengaynhap As DateTime
    Private value As Date

    Public Property Imaphieunhap As Integer
        Get
            Return _imaphieunhap
        End Get
        Set(value As Integer)
            _imaphieunhap = value
        End Set
    End Property
    Public Property Datengaynhap As Date
        Get
            Return _datengaynhap
        End Get
        Set(value As Date)
            _datengaynhap = value
        End Set
    End Property
    Public Sub New()
        Imaphieunhap = 0
        Datengaynhap = value

    End Sub
    Public Sub New(maPhieuNhap As Integer, ngayNhap As DateTime)
        Me.Imaphieunhap = maPhieuNhap
        Me.Datengaynhap = ngayNhap
    End Sub
End Class
