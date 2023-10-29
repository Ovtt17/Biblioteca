Imports MySql.Data.MySqlClient

Public Class SearchBookDAO
    Inherits Conexion

    Public dataSet As New DataSet

    Public Sub SearchBook(pais As Integer)
        Try
            ' Crear la consulta SQL
            Dim sql As String = "buscar_libro_por_pais"
            ' Limpiar los datos.
            dataSet.Tables.Clear()
            ' Abrir la conexión
            Using cx As MySqlConnection = Me.Connect()
                ' Crear un nuevo comando MySQL
                Using cmd As New MySqlCommand(sql, cx)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' Agregar el parámetro a la consulta SQL
                    cmd.Parameters.AddWithValue("@pais", pais)
                    ' Llenar la tabla con los resultados de la base de datos
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dataSet)
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al ejecutar la consulta SQL: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error general: " & ex.Message)
        End Try

    End Sub




    Public Sub LoadComboBox()
        Try
            ' Define the SQL query to call the stored procedure 'seleccionar_paises'
            Dim sql As String = "call seleccionar_paises()"

            ' Clear any existing data in the dataSet object
            DataSet.Tables.Clear()

            ' Open a new database connection using the Connect method of the current class
            Using cx As MySqlConnection = Me.Connect()

                ' Create a new MySqlDataAdapter object with the SQL query and the database connection
                Using dataAdapter As New MySqlDataAdapter(sql, cx)

                    ' Create a new MySqlCommandBuilder that can generate SQL commands 
                    ' that are used to reconcile changes made to the DataSet with the database
                    Using cmb As New MySqlCommandBuilder(dataAdapter)

                        ' Execute the SQL query and fill the DataSet with the results
                        dataAdapter.Fill(DataSet)
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
