Public Class construc_Puesto
    Dim idPuesto As Integer
    Dim NoPuesto, Nombre, Descripcion As String

    Public Property _idPuesto
        Get
            Return idPuesto
        End Get
        Set(ByVal value)
            idPuesto = value
        End Set
    End Property

    Public Property _NoPuesto
        Get
            Return NoPuesto
        End Get
        Set(ByVal value)
            NoPuesto = value
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

    Public Sub New(ByVal idPuesto As Integer, ByVal NoPuesto As String, ByVal Nombre As String, ByVal Descripcion As String)
        _idPuesto = idPuesto
        _NoPuesto = NoPuesto
        _Nombre = Nombre
        _Descripcion = Descripcion
    End Sub

End Class
