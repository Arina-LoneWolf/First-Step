Public Class SACHDTO
    Private _imasach As Integer
    Private _strtensach As String
    Private _imaloaisach As Integer
    Private _strtacgia As String
    Private _idongia As Integer
    Private _isoluongton As Integer

    Public Property Imasach As Integer
        Get
            Return _imasach
        End Get
        Set(value As Integer)
            _imasach = value
        End Set
    End Property

    Public Property Strtensach As String
        Get
            Return _strtensach
        End Get
        Set(value As String)
            _strtensach = value
        End Set
    End Property

    Public Property Imaloaisach As Integer
        Get
            Return _imaloaisach
        End Get
        Set(value As Integer)
            _imaloaisach = value
        End Set
    End Property

    Public Property Strtacgia As String
        Get
            Return _strtacgia
        End Get
        Set(value As String)
            _strtacgia = value
        End Set
    End Property

    Public Property Idongia As Integer
        Get
            Return _idongia
        End Get
        Set(value As Integer)
            _idongia = value
        End Set
    End Property

    Public Property Isoluongton As Integer
        Get
            Return _isoluongton
        End Get
        Set(value As Integer)
            _isoluongton = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(masach As Integer, tensach As String, maloaisach As Integer, tacgia As String, dongia As Integer, soluongton As Integer)
        Me._imasach = masach
        Me._strtensach = tensach
        Me._imaloaisach = maloaisach
        Me._strtacgia = tacgia
        Me._idongia = dongia
        Me._isoluongton = soluongton
    End Sub


End Class
