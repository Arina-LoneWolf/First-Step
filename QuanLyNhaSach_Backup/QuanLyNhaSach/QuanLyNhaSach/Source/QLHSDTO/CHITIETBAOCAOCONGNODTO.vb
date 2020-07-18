Public Class CHITIETBAOCAOCONGNODTO
    Private maChiTietBaoCaoCongNo As Integer
    Private maKH As Integer
    Private maBaoCaoCongNo As Integer
    Private noDau As String
    Private noPhatSinh As String
    Private noCuoi As String
    Public Sub New()

    End Sub
    Public Sub New(maChiTietBaoCaoCongNo As Integer, maKH As Integer, maBaoCaoCongNo As Integer, noDau As String, noPhatSinh As String, noCuoi As String)
        Me.maChiTietBaoCaoCongNo = maChiTietBaoCaoCongNo
        Me.maKH = maKH
        Me.maBaoCaoCongNo = maBaoCaoCongNo
        Me.noDau = noDau
        Me.noPhatSinh = noPhatSinh
        Me.noCuoi = noCuoi
    End Sub

    Public Property MaChiTietBaoCaoCongNo1 As Integer
        Get
            Return maChiTietBaoCaoCongNo
        End Get
        Set(value As Integer)
            maChiTietBaoCaoCongNo = value
        End Set
    End Property

    Public Property MaKH1 As Integer
        Get
            Return maKH
        End Get
        Set(value As Integer)
            maKH = value
        End Set
    End Property

    Public Property MaBaoCaoCongNo1 As Integer
        Get
            Return maBaoCaoCongNo
        End Get
        Set(value As Integer)
            maBaoCaoCongNo = value
        End Set
    End Property

    Public Property NoDau1 As String
        Get
            Return noDau
        End Get
        Set(value As String)
            noDau = value
        End Set
    End Property

    Public Property NoPhatSinh1 As String
        Get
            Return noPhatSinh
        End Get
        Set(value As String)
            noPhatSinh = value
        End Set
    End Property

    Public Property NoCuoi1 As String
        Get
            Return noCuoi
        End Get
        Set(value As String)
            noCuoi = value
        End Set
    End Property
End Class
