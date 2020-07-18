Public Class CHITIETBAOCAOTONDTO
    Private _imachitietphieubaocaoton As Integer
    Private _imasach As Integer
    Private _strmabaocaoton As Integer
    Private _itondau As Integer
    Private _itonphatsinh As Integer
    Private _itoncuoi As Integer

    Public Sub New(maChiTietBaoCaoTon As Integer, maSach As Integer, maBaoCaoTon As Integer, tonDau As Integer, tonPhatSinh As Integer, tonCuoi As Integer)
        Me.Imachitietphieubaocaoton = maChiTietBaoCaoTon
        Me.Imasach = maSach
        Me.Strmabaocaoton = maBaoCaoTon
        Me.Itondau = tonDau
        Me.Itonphatsinh = tonPhatSinh
        Me.Itoncuoi = tonCuoi
    End Sub
    Public Property Imachitietphieubaocaoton As Integer
        Get
            Return _imachitietphieubaocaoton
        End Get
        Set(value As Integer)
            _imachitietphieubaocaoton = value
        End Set
    End Property

    Public Property Imasach As Integer
        Get
            Return _imasach
        End Get
        Set(value As Integer)
            _imasach = value
        End Set
    End Property

    Public Property Strmabaocaoton As Integer
        Get
            Return _strmabaocaoton
        End Get
        Set(value As Integer)
            _strmabaocaoton = value
        End Set
    End Property

    Public Property Itondau As Integer
        Get
            Return _itondau
        End Get
        Set(value As Integer)
            _itondau = value
        End Set
    End Property

    Public Property Itonphatsinh As Integer
        Get
            Return _itonphatsinh
        End Get
        Set(value As Integer)
            _itonphatsinh = value
        End Set
    End Property

    Public Property Itoncuoi As Integer
        Get
            Return _itoncuoi
        End Get
        Set(value As Integer)
            _itoncuoi = value
        End Set
    End Property





End Class
