Public Class Bibliotecario
    Private _code As Integer
    Private _fname As String
    Private _lname As String
    Private _address As String
    Private _position As String
    ' Constructor por defecto
    Public Sub New()

    End Sub
    ' Constructor para insertar
    Public Sub New(fname As String, lname As String, address As String, position As String)
        Me.Fname = fname
        Me.Lname = lname
        Me.Address = address
        Me.Position = position
    End Sub
    ' Constructor para modificar
    Public Sub New(code As Integer, fname As String, lname As String, address As String, position As String)
        Me.Code = code
        Me.Fname = fname
        Me.Lname = lname
        Me.Address = address
        Me.Position = position
    End Sub

    Public Property Code As Integer
        Get
            Return _code
        End Get
        Set(value As Integer)
            _code = value
        End Set
    End Property

    Public Property Fname As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property

    Public Property Lname As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Position As String
        Get
            Return _position
        End Get
        Set(value As String)
            _position = value
        End Set
    End Property
End Class
