Public Class MACHITIETPHIEUNHAPDTO
    Private machitietphieunhap As Integer
    Private maphieunhap As Integer
    Private soluongnhap As Integer
    Private masach As Integer
    Public Sub New()
    End Sub
    Public Sub New(machitietphieunhap As Integer, maphieunhap As Integer, soluongnhap As Integer, masach As Integer)
        Me.Machitietphieunhap1 = machitietphieunhap
        Me.Maphieunhap1 = maphieunhap
        Me.Soluongnhap1 = soluongnhap
        Me.Masach1 = masach
    End Sub

    Public Property Machitietphieunhap1 As Integer
        Get
            Return machitietphieunhap
        End Get
        Set(value As Integer)
            machitietphieunhap = value
        End Set
    End Property

    Public Property Maphieunhap1 As Integer
        Get
            Return maphieunhap
        End Get
        Set(value As Integer)
            maphieunhap = value
        End Set
    End Property

    Public Property Soluongnhap1 As Integer
        Get
            Return soluongnhap
        End Get
        Set(value As Integer)
            soluongnhap = value
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
