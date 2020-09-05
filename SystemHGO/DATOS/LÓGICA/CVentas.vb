Public Class CVentas
    Dim idVenta, idCliente As Integer
    Dim Fecha As Date
    Dim Folio, TVenta As String

    Public Property _idVenta
        Get
            Return idVenta
        End Get
        Set(ByVal value)
            idVenta = value
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

    Public Property _Fecha
        Get
            Return Fecha
        End Get
        Set(ByVal value)
            Fecha = value
        End Set
    End Property

    Public Property _Folio
        Get
            Return Folio
        End Get
        Set(ByVal value)
            Folio = value
        End Set
    End Property

    Public Property _TVenta
        Get
            Return TVenta
        End Get
        Set(ByVal value)
            TVenta = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idVenta As Integer, ByVal Folio As String, ByVal Fecha As Date, ByVal idCliente As Integer, ByVal TVenta As String)
        _idVenta = idVenta
        _Folio = Folio
        _Fecha = Fecha
        _idCliente = idCliente
        _TVenta = TVenta
    End Sub
End Class
