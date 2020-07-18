Public Class QUYDINHDTO
    Private id As Integer
    Private luongNhapToiThieu As Integer
    Private luongTonToiDa As Integer
    Private tienNoToiDa As Integer
    Private luongTonToiThieu As Integer
    Private apDung As String

    Public Sub New()
        Id1 = 0
        LuongNhapToiThieu1 = 0
        LuongTonToiDa1 = 0
        TienNoToiDa1 = 0
        LuongTonToiThieu1 = 0
    End Sub
    Public Sub New(id As Integer, luongNhapToiThieu As Integer, luongTonToiDa As Integer, tienNoToiDa As Integer, luongTonToiThieu As Integer, apDung As String)
        Me.id = id
        Me.luongNhapToiThieu = luongNhapToiThieu
        Me.luongTonToiDa = luongTonToiDa
        Me.tienNoToiDa = tienNoToiDa
        Me.luongTonToiThieu = luongTonToiThieu
        Me.apDung = apDung
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property LuongNhapToiThieu1 As Integer
        Get
            Return luongNhapToiThieu
        End Get
        Set(value As Integer)
            luongNhapToiThieu = value
        End Set
    End Property

    Public Property LuongTonToiDa1 As Integer
        Get
            Return luongTonToiDa
        End Get
        Set(value As Integer)
            luongTonToiDa = value
        End Set
    End Property

    Public Property TienNoToiDa1 As Integer
        Get
            Return tienNoToiDa
        End Get
        Set(value As Integer)
            tienNoToiDa = value
        End Set
    End Property

    Public Property LuongTonToiThieu1 As Integer
        Get
            Return luongTonToiThieu
        End Get
        Set(value As Integer)
            luongTonToiThieu = value
        End Set
    End Property

    Public Property ApDung1 As String
        Get
            Return apDung
        End Get
        Set(value As String)
            apDung = value
        End Set
    End Property
End Class
