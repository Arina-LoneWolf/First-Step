Public Class CHITIETPHIEUHOADONDTO
    Private machitietphieuhoadon As Integer
    Private maphieuhoadon As Integer
    Private soluongban As Integer
    Private masach As Integer
    Public Sub New()

    End Sub
    Public Sub New(machitietphieuhoadon As Integer, maphieuhoadon As Integer, soluongban As Integer, masach As Integer)
        Me.Machitietphieuhoadon1 = machitietphieuhoadon
        Me.Maphieuhoadon1 = maphieuhoadon
        Me.Soluongban1 = soluongban
        Me.Masach1 = masach
    End Sub

    Public Property Machitietphieuhoadon1 As Integer
        Get
            Return machitietphieuhoadon
        End Get
        Set(value As Integer)
            machitietphieuhoadon = value
        End Set
    End Property

    Public Property Maphieuhoadon1 As Integer
        Get
            Return maphieuhoadon
        End Get
        Set(value As Integer)
            maphieuhoadon = value
        End Set
    End Property

    Public Property Soluongban1 As Integer
        Get
            Return soluongban
        End Get
        Set(value As Integer)
            soluongban = value
        End Set
    End Property

    Public Property Masach1 As Integer
        Get
            Return masach
        End Get
        Set(value As Integer)
            masach = value
        End Set
    End Property
End Class
