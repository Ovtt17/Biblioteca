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

    Public Sub DeleteBookAuthor(oldAuthor As BookAuthor)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "borrar_relacion_libro_autor"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for borrar_autor
                    command.Parameters.AddWithValue("@libro", oldAuthor.BookCode)
                    command.Parameters.AddWithValue("@autor", oldAuthor.AuthorCode)
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

    Public Function GetBookAuthorsById(code As Integer) As List(Of BookAuthor)
        Dim authors As New List(Of BookAuthor)
        Try
            Dim sql As String = "call ver_relacion_libro_autor(@cod_libro);"
            Using cx As MySqlConnection = Me.Connect()
                Using command As New MySqlCommand(sql, cx)
                    command.Parameters.AddWithValue("@cod_libro", code)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim bookAuthor As New BookAuthor With {
                                .BookCode = CInt(reader("cod_libro")),
                                .AuthorName = CStr(reader("nombre_autor")),
                                .AuthorCode = CInt(reader("cod_autor"))
                            }
                            authors.Add(bookAuthor)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
        Return authors
    End Function
End Class
