Imports MySql.Data.MySqlClient

Public Class LoanDAO
    Inherits Conexion

    Public dataSet As New DataSet
    Public Sub InsertLoan(ByVal loan As Loan)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters
                Dim sql As String = "insertar_prestamo"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters
                    command.Parameters.AddWithValue("@p_cod_libro", loan.BookId)
                    command.Parameters.AddWithValue("@p_fecha_pres", loan.LoanDate)
                    command.Parameters.AddWithValue("@p_fecha_ent", loan.DueDate)
                    command.Parameters.AddWithValue("@p_cod_ident", loan.UserId)
                    command.Parameters.AddWithValue("@p_tipo_prestamo", loan.LoanType)
                    command.Parameters.AddWithValue("@p_cod_bibliotecario", loan.LibrarianId)
                    command.Parameters.AddWithValue("@p_entregado", loan.Delivered)
                    command.Parameters.AddWithValue("@p_multa", loan.Ticket)

                    ' Execute query
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Loan inserted correctly")
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub

    Public Sub ConsultLoan()
        Try
            ' create sql query
            Dim sql As String = "call seleccionar_prestamos();"
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
End Class
