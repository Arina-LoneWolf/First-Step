Public Class PHIEUTHUTIENDTO
    Private maPhieuThu As Integer
    Private maKH As Integer
    Private ngayThuTien As DateTime
    Private soTienThu As Integer
    Private lyDoThu As String
    Public Sub New()

    End Sub
    Public Sub New(maPhieuThu As Integer, maKH As Integer, ngayThuTien As DateTime, soTienThu As Integer, lyDoThu As String)
        Me.maPhieuThu = maPhieuThu
        Me.maKH = maKH
        Me.ngayThuTien = ngayThuTien
        Me.soTienThu = soTienThu
        Me.lyDoThu = lyDoThu
    End Sub

    Public Property MaPhieuThu1 As Integer
        Get
            Return maPhieuThu
        End Get
        Set(value As Integer)
            maPhieuThu = value
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

    Public Property NgayThuTien1 As Date
        Get
            Return ngayThuTien
        End Get
        Set(value As Date)
            ngayThuTien = value
        End Set
    End Property

    Public Property SoTienThu1 As Integer
        Get
            Return soTienThu
        End Get
        Set(value As Integer)
            soTienThu = value
        End Set
    End Property

    Public Property LyDoThu1 As String
        Get
            Return lyDoThu
        End Get
        Set(value As String)
            lyDoThu = value
        End Set
    End Property
End Class
