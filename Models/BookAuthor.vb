Public Class BookAuthor
    Private _bookCode As Integer
    Private _authorCode As Integer

    Public Sub New(bookCode As Integer, authorCode As Integer)
        Me.BookCode = bookCode
        Me.AuthorCode = authorCode
    End Sub

    Public Property BookCode As Integer
        Get
            Return _bookCode
        End Get
        Set(value As Integer)
            _bookCode = value
        End Set
    End Property

    Public Property AuthorCode As Integer
        Get
            Return _authorCode
        End Get
        Set(value As Integer)
            _authorCode = value
        End Set
    End Property
End Class
