Public Class CPedido
    Dim idPedido As Integer
    Dim Fecha As Date
    Dim Total As Double

    Public Property _idPedido
        Get
            Return idPedido
        End Get
        Set(ByVal value)
            idPedido = idPedido
        End Set
    End Property

    Public Property _Fecha
        Get
            Return Fecha
        End Get
        Set(ByVal value)
            Fecha = value
        End Set
    End Property

    Public Property _Total
        Get
            Return Total
        End Get
        Set(ByVal value)
            Total = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idPedido As Integer, ByVal Fecha As Date, ByVal Total As Double)
        _idPedido = idPedido
        _Fecha = Fecha
        _Total = Total
    End Sub
End Class
