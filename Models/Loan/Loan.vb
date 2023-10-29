Public Class Loan
    Private _loanId As Integer
    Private _bookId As Integer
    Private _loanDate As Date
    Private _dueDate As Date
    Private _userId As Integer
    Private _loanType As String
    Private _librarianId As Integer
    Private _delivered As String
    Private _ticket As Single?

    Public Sub New()
    End Sub


    ' insert
    Public Sub New(bookId As Integer, loanDate As Date, dueDate As Date, userId As Integer, loanType As String, librarianId As Integer, delivered As String, ticket As Single?)
        Me.BookId = bookId
        Me.LoanDate = loanDate
        Me.DueDate = dueDate
        Me.UserId = userId
        Me.LoanType = loanType
        Me.LibrarianId = librarianId
        Me.Delivered = delivered
        Me.Ticket = ticket
    End Sub

    ' modify
    Public Sub New(loanId As Integer, bookId As Integer, loanDate As Date, dueDate As Date, userId As Integer, loanType As String, librarianId As Integer, delivered As String, ticket As Single?)
        Me.LoanId = loanId
        Me.BookId = bookId
        Me.LoanDate = loanDate
        Me.DueDate = dueDate
        Me.UserId = userId
        Me.LoanType = loanType
        Me.LibrarianId = librarianId
        Me.Delivered = delivered
        Me.Ticket = ticket
    End Sub

    Public Property LoanId As Integer
        Get
            Return _loanId
        End Get
        Set(value As Integer)
            _loanId = value
        End Set
    End Property
    Public Property BookId As Integer
        Get
            Return _bookId
        End Get
        Set(value As Integer)
            _bookId = value
        End Set
    End Property

    Public Property LoanDate As Date
        Get
            Return _loanDate
        End Get
        Set(value As Date)
            _loanDate = value
        End Set
    End Property

    Public Property DueDate As Date
        Get
            Return _dueDate
        End Get
        Set(value As Date)
            _dueDate = value
        End Set
    End Property

    Public Property UserId As Integer
        Get
            Return _userId
        End Get
        Set(value As Integer)
            _userId = value
        End Set
    End Property

    Public Property LoanType As String
        Get
            Return _loanType
        End Get
        Set(value As String)
            _loanType = value
        End Set
    End Property

    Public Property LibrarianId As Integer
        Get
            Return _librarianId
        End Get
        Set(value As Integer)
            _librarianId = value
        End Set
    End Property

    Public Property Delivered As String
        Get
            Return _delivered
        End Get
        Set(value As String)
            _delivered = value
        End Set
    End Property

    Public Property Ticket As Single?
        Get
            Return _ticket
        End Get
        Set(value As Single?)
            _ticket = value
        End Set
    End Property

End Class
