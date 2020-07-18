Public Class CHITIETPHIEUNHAPDTO
    Private _imachitietphieunhap As Integer
    Private _imaphieunhap As Integer
    Private _imasach As Integer
    Private _isoluongnhap As Integer
    Private _itacgia As String
    Private _idongia As Integer
    Private _itheloai As String
    Private _itensach As String
    Public Sub New()
        Imachitietphieunhap = 0
        Imaphieunhap = 0
        Imasach = 0
        Isoluongnhap = 0
        Idongia = 0
    End Sub
    Public Sub New(maChiTietPhieuNhap As Integer, maPhieuNhap As Integer, maSach As Integer, soLuongNhap As Integer, tacGia As String, donGia As Integer, theLoai As String, tenSach As String)
        Me.Imachitietphieunhap = maChiTietPhieuNhap
        Me.Imaphieunhap = maPhieuNhap
        Me.Imasach = maSach
        Me.Isoluongnhap = soLuongNhap
        Me.Itacgia = tacGia
        Me.Idongia = donGia
        Me.Itheloai = theLoai
        Me.ItenSach = tenSach
    End Sub

    Public Property Imachitietphieunhap As Integer
        Get
            Return _imachitietphieunhap
        End Get
        Set(value As Integer)
            _imachitietphieunhap = value
        End Set
    End Property

    Public Property Imaphieunhap As Integer
        Get
            Return _imaphieunhap
        End Get
        Set(value As Integer)
            _imaphieunhap = value
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

    Public Property Isoluongnhap As Integer
        Get
            Return _isoluongnhap
        End Get
        Set(value As Integer)
            _isoluongnhap = value
        End Set
    End Property
    Public Property Itacgia As String
        Get
            Return _itacgia
        End Get
        Set(value As String)
            _itacgia = value
        End Set
    End Property
    Public Property Idongia As String
        Get
            Return _idongia
        End Get
        Set(value As String)
            _idongia = value
        End Set
    End Property
    Public Property Itheloai As String
        Get
            Return _itheloai
        End Get
        Set(value As String)
            _itheloai = value
        End Set
    End Property
    Public Property ItenSach As String
        Get
            Return _itensach
        End Get
        Set(value As String)
            _itensach = value
        End Set
    End Property
End Class
