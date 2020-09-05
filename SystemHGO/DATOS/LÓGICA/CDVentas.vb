Public Class CDVentas
    Dim idDVentas, idVenta, idArticulo, idSucursal, Cantidad, Confirmacion As Integer
    Dim Precio As Double
    Dim FechaEntrega As Date

    Public Property _idDVentas
        Get
            Return idDVentas
        End Get
        Set(ByVal value)
            idDVentas = value
        End Set
    End Property

    Public Property _idVenta
        Get
            Return idVenta
        End Get
        Set(ByVal value)
            idVenta = value
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

    Public Property _idSucursal
        Get
            Return idSucursal
        End Get
        Set(ByVal value)
            idSucursal = value
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

    Public Property _Precio
        Get
            Return Precio
        End Get
        Set(ByVal value)
            Precio = value
        End Set
    End Property

    Public Property _FechaEntrega
        Get
            Return FechaEntrega
        End Get
        Set(ByVal value)
            FechaEntrega = value
        End Set
    End Property

    Public Property _Confirmacion
        Get
            Return Confirmacion
        End Get
        Set(ByVal value)
            Confirmacion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idDVenta As Integer, ByVal idVenta As Integer, ByVal idArticulo As Integer, ByVal idSucursal As Integer, ByVal Cantidad As Integer, ByVal Precio As Double, ByVal FechaEntrega As Date, ByVal Confirmacion As Integer)
        _idDVentas = idDVenta
        _idVenta = idVenta
        _idArticulo = idArticulo
        _idSucursal = idSucursal
        _Cantidad = Cantidad
        _Precio = Precio
        _FechaEntrega = FechaEntrega
        _Confirmacion = Confirmacion
    End Sub
End Class
