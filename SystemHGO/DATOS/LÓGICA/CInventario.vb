Public Class CInventario
    Dim idInventario, idArticulo, idProveedor, idSucursal As Integer
    Dim Fecha As Date

    Public Property _idInventario
        Get
            Return idInventario
        End Get
        Set(ByVal value)
            idInventario = value
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

    Public Property _idProveedor
        Get
            Return idProveedor
        End Get
        Set(ByVal value)
            idProveedor = value
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

    Public Property _Fecha
        Get
            Return Fecha
        End Get
        Set(ByVal value)
            Fecha = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idInventario As Integer, ByVal idArticulo As Integer, ByVal IdProveedor As Integer, ByVal idSucursal As Integer, ByVal Fecha As Date)
        _idInventario = idInventario
        _idArticulo = idArticulo
        _idProveedor = IdProveedor
        _idSucursal = idSucursal
        _Fecha = Fecha
    End Sub
End Class
