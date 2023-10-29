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
            ' llamada del procedimiento
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

                Dim sql As String = "Modificar_Usuario"

                Using command As New MySqlCommand(sql, cx)
                    command.CommandType = CommandType.StoredProcedure

                    ' Parámetros para el procedimiento almacenado
                    command.Parameters.AddWithValue("@cod_ident_usuario", user.codeIdent)
                    command.Parameters.AddWithValue("@nuevo_nombre", user.Name)
                    command.Parameters.AddWithValue("@nuevo_apellido", user.LastName)
                    command.Parameters.AddWithValue("@nuevo_telefono", user.Phone)
                    command.Parameters.AddWithValue("@nueva_direccion", user.Address)
                    command.Parameters.AddWithValue("@nueva_fecha_nacimiento", user.Birthdate)
                    command.Parameters.AddWithValue("@nuevo_sexo", user.Sex)
                    command.Parameters.AddWithValue("@nuevo_estado_civil", user.Status)
                    command.Parameters.AddWithValue("@nuevo_centro_estudio", user.Study)


                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al ejecutar la consulta SQL: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error general: " & ex.Message)
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

    Public Function GetUser(ByVal code As Integer) As User
        Try
            Dim sql As String = "ver_Usuario"

            Using cx As MySqlConnection = Me.Connect()
                Using command As New MySqlCommand(sql, cx)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@codigo", code)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim user As New User With {
                                .codeIdent = CInt(reader("cod_ident")),
                                .Name = reader("nombres").ToString(),
                                .LastName = reader("apellidos").ToString(),
                                .Phone = reader("telefono").ToString(),
                                .Address = reader("direccion").ToString(),
                                .Birthdate = CDate(reader("fecha_nac")),
                                .Sex = reader("sexo").ToString(),
                                .Status = reader("estado_civil").ToString(),
                                .Study = reader("centro_estudio").ToString()
                            }
                            Return user
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al ejecutar la consulta SQL: " & ex.Message)
            Return Nothing
        Catch ex As Exception
            MessageBox.Show("Error general: " & ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function



End Class
