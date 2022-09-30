Public Class conexionDAO

    Private users As String
    Private passwords As String
    Private nivel As String

    Public Property _users
        Get
            Return users
        End Get
        Set(value)
            users = value
        End Set
    End Property

    Public Property _passwords
        Get
            Return passwords
        End Get
        Set(value)
            passwords = value
        End Set
    End Property

    Public Property _nivel
        Get
            Return nivel
        End Get
        Set(value)
            nivel = value
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
