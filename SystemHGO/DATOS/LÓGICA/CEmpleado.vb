Public Class CEmpleado
    Dim idEmpleado, idPuesto As Integer
    Dim noEmpleado, Nombre, ApellidoP, ApellidoM, CURP, RFC, Direccion, Colonia, CP, Ciudad, Estado, Tel, Mail As String

    'Setter y Getter
    Public Property _idEmpleado
        Get
            Return idEmpleado
        End Get
        Set(ByVal value)
            idEmpleado = value
        End Set
    End Property

    Public Property _idPuesto
        Get
            Return idPuesto
        End Get
        Set(ByVal value)
            idPuesto = value
        End Set
    End Property

    Public Property _noEmpleado
        Get
            Return noEmpleado
        End Get
        Set(ByVal value)
            noEmpleado = value
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

    Public Property _Telefono
        Get
            Return Tel
        End Get
        Set(ByVal value)
            Tel = value
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

    'Constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idEmpleado As Integer, ByVal NoEMpleado As String, ByVal Nombre As String, ByVal ApellidoP As String, ByVal ApellidoM As String, ByVal CURP As String, ByVal RFC As String, ByVal Direccion As String, ByVal Colonia As String, ByVal Ciudad As String, ByVal Estado As String, ByVal CP As String, ByVal Telefono As String, ByVal Mail As String, ByVal idPuesto As Integer)
        _idEmpleado = idEmpleado
        _noEmpleado = NoEMpleado
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
        _Telefono = Telefono
        _Mail = Mail
        _idPuesto = idPuesto
    End Sub

End Class
