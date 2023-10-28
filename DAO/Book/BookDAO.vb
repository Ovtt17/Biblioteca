Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class BookDAO
    Inherits Conexion
    Public dataSet As New DataSet


    Public Function InsertBook(ByVal book As Book) As Integer
        Dim lastInsertedId As Integer
        Try
            Using cx As MySqlConnection = Me.Connect()
                Dim sql As String = "CALL Insertar_libro(@titulo, @cod_editorial, @fecha_pub, @ejemplares, @n_pag, @idioma, @edicion)"
                Using command As New MySqlCommand(sql, cx)
                    command.Parameters.AddWithValue("@titulo", book.Title)
                    command.Parameters.AddWithValue("@cod_editorial", book.EditorialC)
                    command.Parameters.AddWithValue("@fecha_pub", book.DatePublished)
                    command.Parameters.AddWithValue("@ejemplares", book.Examples)
                    command.Parameters.AddWithValue("@n_pag", book.PageNumbers)
                    command.Parameters.AddWithValue("@idioma", book.Language)
                    command.Parameters.AddWithValue("@edicion", book.Edition)
                    command.ExecuteNonQuery()

                    ' Obtener el último ID insertado
                    command.CommandText = "SELECT LAST_INSERT_ID()"
                    lastInsertedId = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
        Return lastInsertedId
    End Function

    Public Sub ModifyBook(ByVal book As Book)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "modificar_libro"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for modificar_libro
                    command.Parameters.AddWithValue("@_codigo", book.Id)
                    command.Parameters.AddWithValue("@_titulo", book.Title)
                    command.Parameters.AddWithValue("@_cod_editorial", book.EditorialC)
                    command.Parameters.AddWithValue("@_fecha_pub", book.DatePublished)
                    command.Parameters.AddWithValue("@_ejemplares", book.Examples)
                    command.Parameters.AddWithValue("@_n_pag", book.PageNumbers)
                    command.Parameters.AddWithValue("@_idioma", book.Language)
                    command.Parameters.AddWithValue("@_edicion", book.Edition)

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

    Public Function GetBookById(ByVal code As Integer) As Book
        Try
            Dim sql As String = "call ver_libro(@cod_libro);"
            Using cx As MySqlConnection = Me.Connect()
                Using command As New MySqlCommand(sql, cx)
                    command.Parameters.AddWithValue("@cod_libro", code)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim book As New Book With {
                                .Id = CInt(reader("cod_libro")),
                                .Title = reader("titulo").ToString(),
                                .EditorialC = CInt(reader("cod_editorial")),
                                .DatePublished = CDate(reader("fecha_pub")),
                                .Examples = CInt(reader("ejemplares")),
                                .PageNumbers = CInt(reader("n_pag")),
                                .Language = reader("idioma").ToString(),
                                .Edition = CInt(reader("edicion"))
                            }
                            Return book
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
            Return Nothing
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function
    Public Sub ConsultBook()
        Try
            ' create sql query
            Dim sql As String = "call seleccionar_libros();"
            ' clear data.
            dataSet.Tables.Clear()
            ' Open connection
            Using cx As MySqlConnection = Me.Connect()
                ' fill table using results from database
                Using da As New MySqlDataAdapter(sql, cx)
                    da.Fill(dataSet)
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadComboBox(ByVal sql As String)
        Try

            ' Clear any existing data in the dataSet object
            dataSet.Tables.Clear()

            ' Open a new database connection using the Connect method of the current class
            Using cx As MySqlConnection = Me.Connect()

                ' Create a new MySqlDataAdapter object with the SQL query and the database connection
                Using dataAdapter As New MySqlDataAdapter(sql, cx)

                    ' Create a new MySqlCommandBuilder that can generate SQL commands
                    ' that are used to reconcile changes made to the DataSet with the database
                    Using cmb As New MySqlCommandBuilder(dataAdapter)

                        ' Execute the SQL query and fill the DataSet with the results
                        dataAdapter.Fill(dataSet)
                    End Using
                End Using
            End Using

            ' Catch any MySqlException that might occur during the execution of the code
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)

            ' Catch any other general exceptions that might occur during the execution of the code
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try

    End Sub

    Public Sub DeleteBook(currentRow As Integer)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "borrar_libro"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for borrar_autor
                    command.Parameters.AddWithValue("@codigo", currentRow)
                    ' Execute query
                    command.ExecuteNonQuery()
                End Using
                Dim query As String = "ALTER TABLE autor AUTO_INCREMENT = " & currentRow
                Using command As New MySqlCommand(query, cx)
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
