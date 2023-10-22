Imports MySql.Data.MySqlClient

Public Class BookAuthorDAO
    Inherits Conexion
    Public Sub InsertBookAuthor(ByVal ba As BookAuthor)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters
                Dim sql As String = "call insertar_relacion_libro_autor(@cod_libro, @cod_autor);"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Add Parameters for insert_autor
                    command.Parameters.AddWithValue("@cod_libro", ba.BookCode)
                    command.Parameters.AddWithValue("@cod_autor", ba.AuthorCode)

                    ' Execute query
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub
End Class
