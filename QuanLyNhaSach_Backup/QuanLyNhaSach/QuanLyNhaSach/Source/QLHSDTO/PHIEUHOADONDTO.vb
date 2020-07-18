Public Class PHIEUHOADONDTO
    Private maphieuhoadon As Integer
    Private ngaylaphoadon As DateTime
    Private makhachhang As Integer
    Public Sub New()
    End Sub
    Public Sub New(maphieuhoadon As Integer, ngaylaphoadon As DateTime, makhachhang As Integer)
        Me.Maphieuhoadon1 = maphieuhoadon
        Me.Ngaylaphoadon1 = ngaylaphoadon
        Me.Makhachhang1 = makhachhang
    End Sub

    Public Property Maphieuhoadon1 As Integer
        Get
            Return maphieuhoadon
        End Get
        Set(value As Integer)
            maphieuhoadon = value
        End Set
    End Property

    Public Property Ngaylaphoadon1 As Date
        Get
            Return ngaylaphoadon
        End Get
        Set(value As Date)
            ngaylaphoadon = value
        End Set
    End Property

    Public Property Makhachhang1 As Integer
        Get
            Return makhachhang
        End Get
        Set(value As Integer)
            makhachhang = value
        End Set
    End Property
End Class
