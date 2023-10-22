Imports MySql.Data.MySqlClient

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
End Class
