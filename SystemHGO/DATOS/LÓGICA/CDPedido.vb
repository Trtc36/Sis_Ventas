Public Class CDPedido
    Dim idDPedido, idArticulo, Cantidad, idPedido As Integer
    Dim PrecioUnitario As Double

    Public Property _idDPedido
        Get
            Return idDPedido
        End Get
        Set(ByVal value)
            idDPedido = value
        End Set
    End Property

    Public Property _idArticulo
        Get
            Return idArticulo
        End Get
        Set(ByVal value)
            idArticulo = value
        End Set
    End Property

    Public Property _Cantidad
        Get
            Return Cantidad
        End Get
        Set(ByVal value)
            Cantidad = value
        End Set
    End Property

    Public Property _PrecioUnitario
        Get
            Return PrecioUnitario
        End Get
        Set(ByVal value)
            PrecioUnitario = value
        End Set
    End Property

    Public Property _idPedido
        Get
            Return idPedido
        End Get
        Set(ByVal value)
            idPedido = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idDPedido As Integer, ByVal idArticulo As Integer, ByVal Cantidad As Integer, ByVal PrecioUnitario As Double, ByVal idPedido As Integer)
        _idDPedido = idDPedido
        _idArticulo = idArticulo
        _Cantidad = Cantidad
        _PrecioUnitario = PrecioUnitario
        _idPedido = idPedido
    End Sub
End Class
