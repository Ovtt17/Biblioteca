Public Class BookConsult
    Private _title As String
    Private _author As String
    Private _editorial As String
    Private _language As String

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Author As String
        Get
            Return _author
        End Get
        Set(value As String)
            _author = value
        End Set
    End Property

    Public Property Editorial As String
        Get
            Return _editorial
        End Get
        Set(value As String)
            _editorial = value
        End Set
    End Property

    Public Property Language As String
        Get
            Return _language
        End Get
        Set(value As String)
            _language = value
        End Set
    End Property
End Class
