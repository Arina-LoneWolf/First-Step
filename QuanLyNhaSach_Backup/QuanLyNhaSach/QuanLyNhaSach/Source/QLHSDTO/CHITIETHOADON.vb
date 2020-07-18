Public Class CHITIETHOADON
    Private maChiTietPhieuNhap As Integer
    Private maPhieuNhap As Integer
    Private maSach As Integer
    Private soLuongBan As Integer
    Private donGiaBan As Integer
    Private thanhTien As Integer
    Public Sub New()

    End Sub
    Public Sub New(maChiTietPhieuNhap As Integer, maPhieuNhap As Integer, maSach As Integer, soLuongBan As Integer, donGiaBan As Integer, thanhTien As Integer)
        Me.maChiTietPhieuNhap = maChiTietPhieuNhap
        Me.maPhieuNhap = maPhieuNhap
        Me.maSach = maSach
        Me.soLuongBan = soLuongBan
        Me.donGiaBan = donGiaBan
        Me.thanhTien = thanhTien

    End Sub

    Public Property MaChiTietPhieuNhap1 As Integer
        Get
            Return maChiTietPhieuNhap
        End Get
        Set(value As Integer)
            maChiTietPhieuNhap = value
        End Set
    End Property

    Public Property MaPhieuNhap1 As Integer
        Get
            Return maPhieuNhap
        End Get
        Set(value As Integer)
            maPhieuNhap = value
        End Set
    End Property

    Public Property MaSach1 As Integer
        Get
            Return maSach
        End Get
        Set(value As Integer)
            maSach = value
        End Set
    End Property

    Public Property SoLuongBan1 As Integer
        Get
            Return soLuongBan
        End Get
        Set(value As Integer)
            soLuongBan = value
        End Set
    End Property

    Public Property DonGiaBan1 As Integer
        Get
            Return donGiaBan
        End Get
        Set(value As Integer)
            donGiaBan = value
        End Set
    End Property

    Public Property ThanhTien1 As Integer
        Get
            Return thanhTien
        End Get
        Set(value As Integer)
            thanhTien = value
        End Set
    End Property
End Class
