Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class UserDAO
    Inherits Conexion
    Public dataSet As New DataSet

    Public Sub ConsulUser()
        Try
            ' create sql query
            Dim sql As String = "call seleccionar_usuario();"
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

    Public Sub EnterUser(ByVal user As User)
        Try

            Using cx As MySqlConnection = Me.Connect()
                Dim sql As String = "CALL Insertar_Usuario(@codIdent, @Name, @LastName, @Phone, @Address, @BirthDate, @Sex, @Status, @Study)"
                Using command As New MySqlCommand(sql, cx)
                    command.Parameters.AddWithValue("@codIdent", user.codeIdent)
                    command.Parameters.AddWithValue("@Name", user.Name)
                    command.Parameters.AddWithValue("@LastName", user.LastName)
                    command.Parameters.AddWithValue("@Phone", user.Phone)
                    command.Parameters.AddWithValue("@Address", user.Address)
                    command.Parameters.AddWithValue("@BirthDate", user.Birthdate)
                    command.Parameters.AddWithValue("@Sex", user.Sex)
                    command.Parameters.AddWithValue("@Status", user.Status)
                    command.Parameters.AddWithValue("@Study", user.Study)


                    command.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try

    End Sub
    Public Sub ModifyUser(ByVal user As User)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "modificar_autor"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for modificar_autor
                    command.Parameters.AddWithValue("@codigo", user.codeIdent)
                    command.Parameters.AddWithValue("@nombre", user.Name)
                    command.Parameters.AddWithValue("@Segundo Nombre", user.LastName)
                    command.Parameters.AddWithValue("@Telefono", user.Phone)
                    command.Parameters.AddWithValue("@Direccion", user.Address)
                    command.Parameters.AddWithValue("BirthDate", user.Birthdate)
                    command.Parameters.AddWithValue("@Sex", user.Sex)
                    command.Parameters.AddWithValue("@Estado Civil", user.Status)
                    command.Parameters.AddWithValue("@Educacion", user.Study)


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

    Public Sub DeleteUser(currentRow As Integer)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "borrar_usuario"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for borrar_autor
                    command.Parameters.AddWithValue("@Codigo", currentRow)
                    ' Execute query
                    command.ExecuteNonQuery()
                    MessageBox.Show("User Deleted!")
                End Using
                Dim query As String = "ALTER TABLE usuario AUTO_INCREMENT = " & currentRow
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

    Public Function Row(ByVal code As Integer) As Editorial
        Try
            Dim sql As String = "ver_editorial"
            dataSet.Tables.Clear()

            Using cx As MySqlConnection = Me.Connect()
                Using command As New MySqlCommand(sql, cx)

                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@editorial", code)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim editorial As New Editorial With {
                                .Code = CInt(reader("cod_editorial")),
                                .Name = reader("nombre_editorial").ToString(),
                                .Country = CInt(reader("cod_pais"))
                            }
                            Return editorial
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
