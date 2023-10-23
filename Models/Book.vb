Public Class Book
    Private bookId As Integer
    Private bookTitle As String
    Private editorialCode As Integer
    Private editorialName As String
    Private bookDatePublished As Date
    Private bookExamples As Integer
    Private bookPageNumbers As Integer
    Private bookLanguage As String
    Private bookEdition As Integer

    ' constructor for inserting
    Public Sub New(title As String, editorialCode As Integer, datePublished As Date, examples As Integer, pageNumbers As Integer, language As String, edition As Integer)
        Me.bookTitle = title
        Me.editorialCode = editorialCode
        Me.bookDatePublished = datePublished
        Me.bookExamples = examples
        Me.bookPageNumbers = pageNumbers
        Me.bookLanguage = language
        Me.bookEdition = edition
    End Sub

    Public Sub New()
    End Sub

    Public Property Id As Integer
        Get
            Return bookId
        End Get
        Set(value As Integer)
            bookId = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return bookTitle
        End Get
        Set(value As String)
            bookTitle = value
        End Set
    End Property

    Public Property EditorialC As Integer
        Get
            Return editorialCode
        End Get
        Set(value As Integer)
            editorialCode = value
        End Set
    End Property

    Public Property EditorialN As String
        Get
            Return editorialName
        End Get
        Set(value As String)
            editorialName = value
        End Set
    End Property

    Public Property DatePublished As Date
        Get
            Return bookDatePublished
        End Get
        Set(value As Date)
            bookDatePublished = value
        End Set
    End Property

    Public Property Examples As Integer
        Get
            Return bookExamples
        End Get
        Set(value As Integer)
            bookExamples = value
        End Set
    End Property

    Public Property PageNumbers As Integer
        Get
            Return bookPageNumbers
        End Get
        Set(value As Integer)
            bookPageNumbers = value
        End Set
    End Property

    Public Property Language As String
        Get
            Return bookLanguage
        End Get
        Set(value As String)
            bookLanguage = value
        End Set
    End Property

    Public Property Edition As Integer
        Get
            Return bookEdition
        End Get
        Set(value As Integer)
            bookEdition = value
        End Set
    End Property
End Class
