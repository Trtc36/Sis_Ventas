Public Class CCliente
    Dim idCliente As Integer
    Dim Nombre, ApellidoP, ApellidoM, CURP, RFC, Direccion, Colonia, Ciudad, Estado, CP

    Public Property _idCliente
        Get
            Return idCliente
        End Get
        Set(ByVal value)
            idCliente = value
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

    Public Property _ApellidoP
        Get
            Return ApellidoP
        End Get
        Set(ByVal value)
            ApellidoP = value
        End Set
    End Property

    Public Property _ApellidoM
        Get
            Return ApellidoM
        End Get
        Set(ByVal value)
            ApellidoM = value
        End Set
    End Property

    Public Property _CURP
        Get
            Return CURP
        End Get
        Set(ByVal value)
            CURP = value
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

    Public Property _Colonia
        Get
            Return Colonia
        End Get
        Set(ByVal value)
            Colonia = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal idCliente As Integer, ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal CURP As String, ByVal RFC As String, ByVal Direccion As String, ByVal Colonia As String, ByVal Ciudad As String, ByVal Estado As String, ByVal CP As String)
        _idCliente = idCliente
        _Nombre = Nombre
        _ApellidoP = ApellidoP
        _ApellidoM = ApellidoM
        _CURP = CURP
        _RFC = RFC
        _Direccion = Direccion
        _Colonia = Colonia
        _Ciudad = Ciudad
        _Estado = Estado
        _CP = CP
    End Sub
End Class
