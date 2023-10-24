Imports MySql.Data.MySqlClient

Public Class BibliotecarioDAO
    Inherits Conexion

    Public dataSet As New DataSet

    Public Sub ConsultBibliotecario()
        Try
            ' create sql query
            Dim sql As String = "call seleccionar_bibliotecario();"
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

    Public Sub InsertBibliotecario(ByVal bibliotecario As Bibliotecario)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "insertar_bibliotecario"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for insert_autor
                    command.Parameters.AddWithValue("@nombres", bibliotecario.Fname)
                    command.Parameters.AddWithValue("@apellidos", bibliotecario.Lname)
                    command.Parameters.AddWithValue("@direccion", bibliotecario.Address)
                    command.Parameters.AddWithValue("@cargo", bibliotecario.Position)
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

    Public Sub ModifyBibliotecario(ByVal bibliotecario As Bibliotecario)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "modificar_bibliotecario"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for modificar_bibliotecario
                    command.Parameters.AddWithValue("@bibliotecario", bibliotecario.Code)
                    command.Parameters.AddWithValue("@nombres", bibliotecario.Fname)
                    command.Parameters.AddWithValue("@apellidos", bibliotecario.Lname)
                    command.Parameters.AddWithValue("@direccion", bibliotecario.Address)
                    command.Parameters.AddWithValue("@cargo", bibliotecario.Position)
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

    Public Sub DeleteBibliotecario(ByVal code As Integer)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "borrar_bibliotecario"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for borrar_bibliotecario
                    command.Parameters.AddWithValue("@bibliotecario", code)
                    ' Execute query
                    command.ExecuteNonQuery()
                    MessageBox.Show("Bibliotecario Deleted!")
                End Using
                Dim query As String = "ALTER TABLE bibliotecario AUTO_INCREMENT = " & code
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

    ''</summary>
    ''' <param name="code">obtenemos un codigo por el cual haremos una busqueda para editar los datos</param>
    ''' <returns>retornamos un objeto de tipo Author, para poder manipularlo en el formulario</returns>
    Public Function Row(ByVal code As Integer) As Bibliotecario
        Try
            Dim sql As String = "ver_bibliotecario"
            dataSet.Tables.Clear()

            Using cx As MySqlConnection = Me.Connect()
                Using command As New MySqlCommand(sql, cx)

                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@bibliotecario", code)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim bibliotecario As New Bibliotecario With {
                                .Code = CInt(reader("cod_bibliotecario")),
                                .Fname = reader("nombres").ToString(),
                                .Lname = reader("apellidos").ToString(),
                                .Address = reader("direccion").ToString(),
                                .Position = reader("cargo").ToString()
                            }
                            Return bibliotecario
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
