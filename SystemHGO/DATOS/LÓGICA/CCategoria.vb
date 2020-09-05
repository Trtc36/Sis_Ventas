Public Class CCategoria
    Dim idCategoria As Integer
    Dim Nombre, Descripcion As String

    Public Property _idCategoria
        Get
            Return idCategoria
        End Get
        Set(ByVal value)
            idCategoria = value
        End Set
    End Property

    Public Property _Nombre
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value
        End Set
    End Property

    Public Property _Descripcion
        Get
            Return Descripcion
        End Get
        Set(ByVal value)
            Descripcion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idCategoria As Integer, ByVal Nombre As String, ByVal Descripcion As String)
        _idCategoria = idCategoria
        _Nombre = Nombre
        _Descripcion = Descripcion
    End Sub
End Class
