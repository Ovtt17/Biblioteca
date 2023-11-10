Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class Conexion

    Private Const ConnectionString As String = "Server=localhost;Database=biblioteca;User ID=Maria_Bustamante;Pwd=Maria1234;"
    Public Function Connect() As MySqlConnection
        Dim cx = New MySqlConnection(ConnectionString)
        Try
            cx.Open()
        Catch ex As Exception
            Throw New Exception("Error while connecting: " & ex.Message)
        End Try
        Return cx
    End Function
End Class
