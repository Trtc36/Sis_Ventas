Public Class CContado
    Dim idContado, idVenta As Integer
    Dim Subtotal, IVA, Total, Descuento, TotalPago As Double

    Public Property _idContado
        Get
            Return idContado
        End Get
        Set(ByVal value)
            idContado = value
        End Set
    End Property

    Public Property _Subtotal
        Get
            Return Subtotal
        End Get
        Set(ByVal value)
            Subtotal = value
        End Set
    End Property

    Public Property _IVA
        Get
            Return IVA
        End Get
        Set(ByVal value)
            IVA = value
        End Set
    End Property

    Public Property _Total
        Get
            Return Total
        End Get
        Set(ByVal value)
            Total = value
        End Set
    End Property

    Public Property _Descuento
        Get
            Return Descuento
        End Get
        Set(ByVal value)
            Descuento = value
        End Set
    End Property

    Public Property _TotalPago
        Get
            Return TotalPago
        End Get
        Set(ByVal value)
            TotalPago = value
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

    Public Sub New(ByVal idContado As Integer, ByVal Subtotal As Double, ByVal IVA As Double, ByVal Total As Double, ByVal Descuento As Double, ByVal TotalPago As Double, idVenta As Integer)
        _idContado = idContado
        _Subtotal = Subtotal
        _IVA = IVA
        _Total = Total
        _Descuento = Descuento
        _TotalPago = TotalPago
        _idVenta = idVenta
    End Sub
End Class
