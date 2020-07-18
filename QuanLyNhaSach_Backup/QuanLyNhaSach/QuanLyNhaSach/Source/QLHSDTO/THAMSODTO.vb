Public Class THAMSODTO
    Private soluongnhapitnhat As Integer
    Private soluongtontoidatruocnhap As Integer
    Private sotiennotoida As Integer
    Private soluongtonsautoithieu As Integer
    Private sudungquydinh4 As Boolean

    Public Sub New()
    End Sub
    Public Sub New(soluongnhapitnhat As Integer, soluongtontoidatruocnhap As Integer, sotiennotoida As Integer, soluongtonsautoithieu As Integer, sudungquydinh4 As Boolean)
        Me.Soluongnhapitnhat1 = soluongnhapitnhat
        Me.Soluongtontoidatruocnhap1 = soluongtontoidatruocnhap
        Me.Sotiennotoida1 = sotiennotoida
        Me.Soluongtonsautoithieu1 = soluongtonsautoithieu
        Me.Sudungquydinh41 = False
    End Sub

    Public Property Soluongnhapitnhat1 As Integer
        Get
            Return soluongnhapitnhat
        End Get
        Set(value As Integer)
            soluongnhapitnhat = value
        End Set
    End Property

    Public Property Soluongtontoidatruocnhap1 As Integer
        Get
            Return soluongtontoidatruocnhap
        End Get
        Set(value As Integer)
            soluongtontoidatruocnhap = value
        End Set
    End Property

    Public Property Sotiennotoida1 As Integer
        Get
            Return sotiennotoida
        End Get
        Set(value As Integer)
            sotiennotoida = value
        End Set
    End Property

    Public Property Soluongtonsautoithieu1 As Integer
        Get
            Return soluongtonsautoithieu
        End Get
        Set(value As Integer)
            soluongtonsautoithieu = value
        End Set
    End Property

    Public Property Sudungquydinh41 As Boolean
        Get
            Return sudungquydinh4
        End Get
        Set(value As Boolean)
            sudungquydinh4 = value
        End Set
    End Property
End Class
