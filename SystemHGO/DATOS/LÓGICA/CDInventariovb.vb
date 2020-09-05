Public Class CDInventariovb
    Dim idDInventario, idInventario, Cinicial, Cfinal As Integer
    Dim SaldoInicial, SaldoFinal As Double

    Public Property _idDInventario
        Get
            Return idDInventario
        End Get
        Set(ByVal value)
            idDInventario = value
        End Set
    End Property

    Public Property _idInventario
        Get
            Return idInventario
        End Get
        Set(ByVal value)
            idInventario = value
        End Set
    End Property

    Public Property _CInicial
        Get
            Return Cinicial
        End Get
        Set(ByVal value)
            Cinicial = value
        End Set
    End Property

    Public Property _SaldoInicial
        Get
            Return SaldoInicial
        End Get
        Set(ByVal value)
            SaldoInicial = value
        End Set
    End Property

    Public Property _CFinal
        Get
            Return Cfinal
        End Get
        Set(ByVal value)
            Cfinal = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal idDInventario As Integer, ByVal idInventario As Integer, ByVal CInicial As Integer, ByVal SaldoInicial As Double, ByVal CFinal As Integer, ByVal SaldoFinal As Double)
        _idDInventario = idDInventario
        _idInventario = idInventario
        _CInicial = CInicial
        _SaldoInicial = SaldoInicial
        _CFinal = CFinal
        _SaldoFinal = SaldoFinal
    End Sub
End Class
