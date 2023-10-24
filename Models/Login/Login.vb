Public Class Login
    Private _userName As String
    Private _passWord As String

    Public Sub New(userName As String, passWord As String)
        Me.UserName = userName
        Me.PassWord = passWord
    End Sub

    Public Property UserName As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property

    Public Property PassWord As String
        Get
            Return _passWord
        End Get
        Set(value As String)
            _passWord = value
        End Set
    End Property
End Class
