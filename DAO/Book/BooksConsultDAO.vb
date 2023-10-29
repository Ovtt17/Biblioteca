Imports MySql.Data.MySqlClient

Public Class BooksConsultDAO
    Inherits Conexion

    Public dataSet As DataSet

    Public Sub New()
        dataSet = New DataSet()
    End Sub

    Public Sub ConsultBooks(bookConsult As BookConsult)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "buscar_en_libro_con_filtro"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for modificar_libro
                    command.Parameters.AddWithValue("@_titulo", bookConsult.Title)
                    command.Parameters.AddWithValue("@_autor", bookConsult.Author)
                    command.Parameters.AddWithValue("@_editorial", bookConsult.Editorial)
                    command.Parameters.AddWithValue("@_idioma", bookConsult.Language)

                    ' Create a MySqlDataAdapter object with the MySqlCommand object.
                    Using da As New MySqlDataAdapter(command)
                        ' Clear data.
                        dataSet.Tables.Clear()
                        ' Fill table using results from database
                        da.Fill(dataSet)
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try

    End Sub
    Public Sub LoadCombos(sql As String)
        Try
            ' Open a new database connection using the Connect method of the current class
            Using cx As MySqlConnection = Me.Connect()

                ' Create a new MySqlDataAdapter object with the SQL query and the database connection
                Using dataAdapter As New MySqlDataAdapter(sql, cx)

                    ' Create a new MySqlCommandBuilder that can generate SQL commands 
                    ' that are used to reconcile changes made to the DataSet with the database
                    Using cmb As New MySqlCommandBuilder(dataAdapter)
                        ' Clear the previous data
                        dataSet.Clear()
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
