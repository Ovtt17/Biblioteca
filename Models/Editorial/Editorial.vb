Public Class Editorial
    Private codeEditorial As Integer
    Private nameEditorial As String
    Private codeCountry As Integer

    Public Sub New()
    End Sub
    ' constructor for inserting
    Public Sub New(nameEditorial As String, codeCountry As Integer)
        Me.Name = nameEditorial
        Me.Country = codeCountry
    End Sub

    ' constructor for modifying
    Public Sub New(codeEditorial As Integer, nameEditorial As String, codeCountry As Integer)
        Me.Code = codeEditorial
        Me.Name = nameEditorial
        Me.Country = codeCountry
    End Sub

    ' Getters and Setters
    Public Property Code As Integer
        Get
            Return codeEditorial
        End Get
        Set(value As Integer)
            codeEditorial = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return nameEditorial
        End Get
        Set(value As String)
            nameEditorial = value
        End Set
    End Property

    Public Property Country As Integer
        Get
            Return codeCountry
        End Get
        Set(value As Integer)
            codeCountry = value
        End Set
    End Property
End Class

