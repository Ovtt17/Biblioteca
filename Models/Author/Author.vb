Public Class Author
    Private codeAuthor As Integer
    Private nameAuthor As String
    Private countryAuthor As Integer

    Public Sub New()
    End Sub

    Public Sub New(name As String, country As Integer)
        Me.nameAuthor = name
        Me.countryAuthor = country
    End Sub

    Public Sub New(code As Integer, name As String, country As Integer)
        Me.Code = code
        Me.Name = name
        Me.Country = country
    End Sub

    Public Property Code As Integer
        Get
            Return codeAuthor
        End Get
        Set(value As Integer)
            codeAuthor = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return nameAuthor
        End Get
        Set(value As String)
            nameAuthor = value
        End Set
    End Property

    Public Property Country As Integer
        Get
            Return countryAuthor
        End Get
        Set(value As Integer)
            countryAuthor = value
        End Set
    End Property

End Class
