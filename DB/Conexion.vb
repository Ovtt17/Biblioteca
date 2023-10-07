Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Conexion

    Private Const ConnectionString As String = "Server=127.168.1.19;Database=biblioteca;User ID=Maria_Bustamante;Pwd=Maria1234;"
    Public Function Connect()
        Try
            Dim cx = New MySqlConnection(ConnectionString)
            cx.Open()
            Return cx
        Catch ex As Exception
            Throw New Exception("Error while connecting: " & ex.Message)
        End Try
    End Function
End Class
