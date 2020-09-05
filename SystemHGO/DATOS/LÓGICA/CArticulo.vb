Public Class CArticulo
    Dim idArticulo, idProveedor, idCategoria As Integer
    Dim Nombre As String

    Public Property _idArticulo
        Get
            Return idArticulo
        End Get
        Set(ByVal value)
            idArticulo = value
        End Set
    End Property

    Public Property _Nombre
        Get
            Return Nombre
        End Get
        Set(ByVal value)
            Nombre = value
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

    Public Property _idCategoria
        Get
            Return idCategoria
        End Get
        Set(ByVal value)
            idCategoria = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idArticulo As Integer, ByVal Nombre As String, ByVal idProveedor As Integer, ByVal idCategoria As Integer)
        _idArticulo = idArticulo
        _Nombre = Nombre
        _idProveedor = idProveedor
        _idCategoria = idCategoria
    End Sub
End Class
