Public Class CTelefono
    Dim idTelefono, idCliente As Integer
    Dim Telefono As String

    Public Property _idTelefono
        Get
            Return idTelefono
        End Get
        Set(ByVal value)
            idTelefono = value
        End Set
    End Property

    Public Property _idCliente
        Get
            Return idCliente
        End Get
        Set(ByVal value)
            idCliente = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal idTelefono As Integer, ByVal Telefono As String, ByVal idCliente As Integer)
        _idTelefono = idTelefono
        _Telefono = Telefono
        _idCliente = idCliente
    End Sub
End Class
