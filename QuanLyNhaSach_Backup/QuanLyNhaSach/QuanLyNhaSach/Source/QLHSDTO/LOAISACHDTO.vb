Public Class THELOAIDTO
    Private _imatheloai As Integer
    Private _strtenloaisach As String
    Public Sub New()
        Imaloaisach = 0
        Strtenloaisach = String.Empty
    End Sub
    Public Sub New(maloaisach As Integer, tenloaisach As String)
        Imaloaisach = maloaisach
        Strtenloaisach = tenloaisach
    End Sub
    Public Property Imaloaisach As Integer
        Get
            Return _imatheloai
        End Get
        Set(value As Integer)
            _imatheloai = value
        End Set
    End Property

    Public Property Strtenloaisach As String
        Get
            Return _strtenloaisach
        End Get
        Set(value As String)
            _strtenloaisach = value
        End Set
    End Property
End Class
