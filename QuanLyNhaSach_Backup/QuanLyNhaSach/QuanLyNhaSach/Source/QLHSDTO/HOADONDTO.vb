Public Class HOADONDTO
    Private _imaHoaDon As Integer
    Private _strngayHoaDon As String
    Private _imaKH As Integer
    Private _itongGiaTri As Integer

    Public Sub New()

    End Sub

    Public Sub New(maHD As Integer, ngayHD As String, maKH As Integer, tongGT As Integer)
        Me._imaHoaDon = maHD
        Me._strngayHoaDon = ngayHD
        Me._imaKH = maKH
        Me._itongGiaTri = tongGT
    End Sub

    Public Property MaHD As Integer
        Get
            Return _imaHoaDon
        End Get
        Set(value As Integer)
            _imaHoaDon = value
        End Set
    End Property

    Public Property NgayHD As String
        Get
            Return _strngayHoaDon
        End Get
        Set(value As String)
            _strngayHoaDon = value
        End Set
    End Property

    Public Property MaKH As Integer
        Get
            Return _imaKH
        End Get
        Set(value As Integer)
            _imaKH = value
        End Set
    End Property

    Public Property TongGT As Integer
        Get
            Return _itongGiaTri
        End Get
        Set(value As Integer)
            _itongGiaTri = value
        End Set
    End Property
End Class
