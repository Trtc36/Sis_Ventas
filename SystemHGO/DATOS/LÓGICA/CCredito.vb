Public Class CCredito
    Dim idCredito, idVenta As Integer
    Dim Fecha As Date
    Dim SaldoInicial, Monto, SaldoFinal As Double
    Dim DiaPago As String

    Public Property _idCredito
        Get
            Return idCredito
        End Get
        Set(ByVal value)
            idCredito = value
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

    Public Property _SaldoIncial
        Get
            Return SaldoInicial
        End Get
        Set(ByVal value)
            SaldoInicial = value
        End Set
    End Property

    Public Property _Monto
        Get
            Return Monto
        End Get
        Set(ByVal value)
            Monto = value
        End Set
    End Property

    Public Property _SaldoFinal
        Get
            Return SaldoFinal
        End Get
        Set(ByVal value)
            SaldoFinal = value
        End Set
    End Property

    Public Property _DiaPago
        Get
            Return DiaPago
        End Get
        Set(ByVal value)
            DiaPago = value
        End Set
    End Property

    Public Property _idVenta
        Get
            Return idVenta
        End Get
        Set(ByVal value)
            idVenta = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idCredito As Integer, ByVal Fecha As Date, ByVal SaldoInicial As Double, ByVal Monto As Double, ByVal SaldoFinal As Double, ByVal DiaPago As String, ByVal idVenta As Integer)
        _idCredito = idCredito
        _Fecha = Fecha
        _SaldoIncial = SaldoInicial
        _Monto = Monto
        _SaldoFinal = SaldoFinal
        _DiaPago = DiaPago
        _idVenta = idVenta
    End Sub
End Class
