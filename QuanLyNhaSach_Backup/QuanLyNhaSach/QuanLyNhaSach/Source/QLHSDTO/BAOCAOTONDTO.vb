Public Class BAOCAOTONDTO
    Private maBaoCaoTon As Integer
    Private thang As DateTime

    Public Sub New()
    End Sub
    Public Sub New(maBaoCaoTon As Integer, thang As DateTime)
        Me.maBaoCaoTon = maBaoCaoTon
        Me.thang = thang
    End Sub

    Public Property MaBaoCaoTon1 As Integer
        Get
            Return maBaoCaoTon
        End Get
        Set(value As Integer)
            maBaoCaoTon = value
        End Set
    End Property

    Public Property Thang1 As Date
        Get
            Return thang
        End Get
        Set(value As Date)
            thang = value
        End Set
    End Property
End Class

