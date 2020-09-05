Public Class CEmpresa
    Dim idEmpresa As Integer
    Dim Nombre, RazonSocial, RFC, Direccion, Telefono1, telefono2 As String

    Public Property _idEmpresa
        Get
            Return idEmpresa
        End Get
        Set(ByVal value)
            idEmpresa = value
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

    Public Property _RFC
        Get
            Return RFC
        End Get
        Set(ByVal value)
            RFC = value
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

    Public Property _Telefono1
        Get
            Return Telefono1
        End Get
        Set(ByVal value)
            Telefono1 = value
        End Set
    End Property

    Public Property _Telefono2
        Get
            Return telefono2
        End Get
        Set(ByVal value)
            telefono2 = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idEmpresa As Integer, ByVal Nombre As String, ByVal RazonSocial As String, ByVal RFC As String, ByVal Direccion As String, ByVal Telefono1 As String, ByVal Telefono2 As String)
        _idEmpresa = idEmpresa
        _Nombre = Nombre
        _RazonSocial = RazonSocial
        _RFC = RFC
        _Direccion = Direccion
        _Telefono1 = Telefono1
        _Telefono2 = telefono2
    End Sub
End Class
