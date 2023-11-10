Public Class User
    ' Definir la clase User fuera de FormUsers
    Private _Name As String
    Private _LastName As String
    Private _Phone As String
    Private _Address As String
    Private _Sex As String
    Private _Status As String
    Private _Study As String
    Private _Birthdate As Date
    Private _codeIdent As Integer
    Private _codeIdentNew As Integer

    Public Sub New()

    End Sub
    ' Constructor para 
    Public Sub New(codeIdent As Integer, name As String, lastName As String, phone As String, address As String, birthdate As Date, sex As String, status As String, study As String)
        Me.CodeIdent = codeIdent
        Me.Name = name
        Me.LastName = lastName
        Me.Phone = phone
        Me.Address = address
        Me.Birthdate = birthdate
        Me.Sex = sex
        Me.Status = status
        Me.Study = study
    End Sub

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _Phone
        End Get
        Set(value As String)
            _Phone = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property

    Public Property Sex As String
        Get
            Return _Sex
        End Get
        Set(value As String)
            _Sex = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _Status
        End Get
        Set(value As String)
            _Status = value
        End Set
    End Property

    Public Property Study As String
        Get
            Return _Study
        End Get
        Set(value As String)
            _Study = value
        End Set
    End Property

    Public Property Birthdate As Date
        Get
            Return _Birthdate
        End Get
        Set(value As Date)
            _Birthdate = value
        End Set
    End Property

    Public Property CodeIdent As Integer
        Get
            Return _codeIdent
        End Get
        Set(value As Integer)
            _codeIdent = value
        End Set
    End Property

    Public Property CodeIdentNew As Integer
        Get
            Return _codeIdentNew
        End Get
        Set(value As Integer)
            _codeIdentNew = value
        End Set
    End Property
End Class