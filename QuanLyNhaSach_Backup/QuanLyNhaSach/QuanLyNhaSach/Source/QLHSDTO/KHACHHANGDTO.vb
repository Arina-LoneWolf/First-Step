Public Class KHACHHANGDTO
    Private maKH As Integer
    Private hoTenKH As String
    Private tienNoKH As String
    Private diaChi As String
    Private email As String
    Private sdt As String
    Public Sub New()
    End Sub
    Public Sub New(maKH As Integer, hoTenKH As String, tienNOKH As String, diaChi As String, email As String, sdt As String)
        Me.maKH = maKH
        Me.hoTenKH = hoTenKH
        Me.tienNoKH = tienNOKH
        Me.diaChi = diaChi
        Me.email = email
        Me.sdt = sdt

    End Sub

    Public Property MaKH1 As Integer
        Get
            Return maKH
        End Get
        Set(value As Integer)
            maKH = value
        End Set
    End Property

    Public Property HoTenKH1 As String
        Get
            Return hoTenKH
        End Get
        Set(value As String)
            hoTenKH = value
        End Set
    End Property

    Public Property TienNoKH1 As String
        Get
            Return tienNoKH
        End Get
        Set(value As String)
            tienNoKH = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return diaChi
        End Get
        Set(value As String)
            diaChi = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Sdt1 As String
        Get
            Return sdt
        End Get
        Set(value As String)
            sdt = value
        End Set
    End Property
End Class
