Public Class User
    ' Definir la clase User fuera de FormUsers
    Public Name As String
    Public LastName As String
    Public Phone As String
    Public Address As String
    Public Sex As String
    Public Status As String
    Public Study As String
    Public Birthdate As Date
    Public codeIdent As Integer

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
End Class