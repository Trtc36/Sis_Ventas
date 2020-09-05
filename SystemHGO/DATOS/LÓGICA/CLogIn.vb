Public Class CLogIn
    Private usuario As String
    Private password As String
    Private rol As String
    Private tipopermiso As String

    Public Property _usuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property

    Public Property _password
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Property _rol
        Get
            Return rol
        End Get
        Set(value)
            rol = value
        End Set
    End Property

    Public Property _tipopermiso
        Get
            Return tipopermiso
        End Get
        Set(value)
            tipopermiso = value
        End Set
    End Property

    Public Sub New()
    End Sub
End Class
