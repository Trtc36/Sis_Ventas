Public Class CProveedor
    Dim idProveedor As Integer
    Dim Nombre, RazonSocial, Direccion, Colonia, Ciudad, Estado, CP, Telefono, Celular, Mail As String

    Public Property _idProveedor
        Get
            Return idProveedor
        End Get
        Set(ByVal value)
            idProveedor = value
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

    Public Property _RazonSocial
        Get
            Return RazonSocial
        End Get
        Set(ByVal value)
            RazonSocial = value
        End Set
    End Property

    Public Property _Direccion
        Get
            Return Direccion
        End Get
        Set(ByVal value)
            Direccion = value
        End Set
    End Property

    Public Property _Colonia
        Get
            Return Colonia
        End Get
        Set(ByVal value)
            Direccion = value
        End Set
    End Property

    Public Property _Ciudad
        Get
            Return Ciudad
        End Get
        Set(ByVal value)
            Ciudad = value
        End Set
    End Property

    Public Property _Estado
        Get
            Return Estado
        End Get
        Set(ByVal value)
            Estado = value
        End Set
    End Property

    Public Property _CP
        Get
            Return CP
        End Get
        Set(ByVal value)
            CP = value
        End Set
    End Property

    Public Property _Telefono
        Get
            Return Telefono
        End Get
        Set(ByVal value)
            Telefono = value
        End Set
    End Property

    Public Property _Celular
        Get
            Return Celular
        End Get
        Set(ByVal value)
            Celular = value
        End Set
    End Property

    Public Property _Mail
        Get
            Return Mail
        End Get
        Set(ByVal value)
            Mail = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idProveedor As Integer, ByVal Nombre As String, ByVal RazonSocial As String, ByVal Direccion As String, ByVal Colonia As String, ByVal Ciudad As String, ByVal Estado As String, ByVal CP As String, ByVal Telefono As String, ByVal Celular As String, ByVal Mail As String)
        _idProveedor = idProveedor
        _Nombre = Nombre
        _RazonSocial = RazonSocial
        _Direccion = Direccion
        _Colonia = Colonia
        _Ciudad = Ciudad
        _Estado = Estado
        _CP = CP
        _Telefono = Telefono
        _Celular = Celular
        _Mail = Mail
    End Sub
End Class
