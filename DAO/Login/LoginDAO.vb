Imports MySql.Data.MySqlClient

Public Class LoginDAO
    Inherits Conexion

    'Public Function ConsultUser(ByVal user As User) As Boolean
    '    Try
    '        Dim sql As String = "consultar_login"

    '        Using cx As MySqlConnection = Me.Connect()
    '            Using command As New MySqlCommand(sql, cx)

    '                command.CommandType = CommandType.StoredProcedure
    '                command.Parameters.AddWithValue("@pusuario", user.UserName)
    '                command.Parameters.AddWithValue("@pclave", user.PassWord)
    '                Using reader As MySqlDataReader = command.ExecuteReader()
    '                    If reader.HasRows Then
    '                        Return True
    '                    End If
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As MySqlException
    '        MessageBox.Show("Error executing SQL query: " & ex.Message)
    '        Return Nothing
    '    Catch ex As Exception
    '        MessageBox.Show("General error: " & ex.Message)
    '        Return Nothing
    '    End Try
    '    Return False
    'End Function

End Class
