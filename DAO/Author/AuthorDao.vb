Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class AuthorDAO
    Inherits Conexion

    Public dataSet As New DataSet

    ''' <summary>
    ''' Method for insert author in db
    ''' OJO - los parametros deben deben ser escritos exactamente a como estan declarados en el procedure
    ''' </summary>
    ''' <param name="author">recibimos el objeto de Author, de esta forma pasamos los parametros al command y ejecutar el procedure sin problema</param>
    Public Sub InsertAuthor(ByVal author As Author)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "insertar_autor"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for insert_autor
                    command.Parameters.AddWithValue("@nombre", author.Name)
                    command.Parameters.AddWithValue("@pais", author.Country)

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
    Public Sub ModifyAuthor(ByVal author As Author)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "modificar_autor"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for modificar_autor
                    command.Parameters.AddWithValue("@codigo", author.Code)
                    command.Parameters.AddWithValue("@nombre", author.Name)
                    command.Parameters.AddWithValue("@pais", author.Country)

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

    Public Sub DeleteAuthor(ByVal code As Integer)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "borrar_autor"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for borrar_autor
                    command.Parameters.AddWithValue("@autor", code)
                    ' Execute query
                    command.ExecuteNonQuery()
                    MessageBox.Show("Author Deleted!")
                End Using
                Dim query As String = "ALTER TABLE autor AUTO_INCREMENT = " & code
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

    ''' <summary>
    ''' Method for consult all the authors in database.
    ''' </summary>
    Public Sub ConsultAuthor()
        Try
            ' create sql query
            Dim sql As String = "call seleccionar_autores();"
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

    ''' <summary>
    ''' Method for load country combobox
    ''' </summary>
    Public Sub LoadComboBox()
        Try
            ' Define the SQL query to call the stored procedure 'seleccionar_paises'
            Dim sql As String = "call seleccionar_paises()"

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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="code">obtenemos un codigo por el cual haremos una busqueda para editar los datos</param>
    ''' <returns>retornamos un objeto de tipo Author, para poder manipularlo en el formulario</returns>
    Public Function GetAuthorById(ByVal code As Integer) As Author
        Try
            Dim sql As String = "ver_autor"
            dataSet.Tables.Clear()

            Using cx As MySqlConnection = Me.Connect()
                Using command As New MySqlCommand(sql, cx)

                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@autor", code)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim author As New Author With {
                                .code = CInt(reader("cod_autor")),
                                .Name = reader("nombre_autor").ToString(),
                                .Country = CInt(reader("cod_pais"))
                            }
                            Return author
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

End Class
