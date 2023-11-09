Imports System.Windows.Automation.Peers
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

    Public Sub ModifyLoan(loanEditable As Loan)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "modificar_prestamo"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for modificar_prestamo
                    command.Parameters.AddWithValue("@_cod_prestamo", loanEditable.LoanId)
                    command.Parameters.AddWithValue("@_cod_libro", loanEditable.BookId)
                    command.Parameters.AddWithValue("@_fecha_pres", loanEditable.LoanDate)
                    command.Parameters.AddWithValue("@_fecha_ent", loanEditable.DueDate)
                    command.Parameters.AddWithValue("@_cod_ident", loanEditable.UserId)
                    command.Parameters.AddWithValue("@_tipo_prestamo", loanEditable.LoanType)
                    command.Parameters.AddWithValue("@_cod_bibliotecario", loanEditable.LibrarianId)
                    command.Parameters.AddWithValue("@_entregado", loanEditable.Delivered)
                    command.Parameters.AddWithValue("@_multa", loanEditable.Ticket)

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

    Public Sub DeleteLoan(currentRow As Integer)
        Try
            Using cx As MySqlConnection = Me.Connect()
                ' sql script only contains the name, then put the parameters 
                Dim sql As String = "borrar_prestamo"

                ' Create a MySqlCommand object with the SQL query and the database connection.
                Using command As New MySqlCommand(sql, cx)
                    ' Specify command type
                    command.CommandType = CommandType.StoredProcedure
                    ' Add Parameters for borrar_autor
                    command.Parameters.AddWithValue("@codigo", currentRow)
                    ' Execute query
                    command.ExecuteNonQuery()
                End Using
                Dim query As String = "ALTER TABLE prestamo AUTO_INCREMENT = " & currentRow
                Using command As New MySqlCommand(query, cx)
                    ' Execute query
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Book Deleted!")
            End Using
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
                    da.Fill(dataSet, "loans")
                End Using

                sql = "select cod_libro from libro order by cod_libro;"
                Using da As New MySqlDataAdapter(sql, cx)
                    da.Fill(dataSet, "bookId")
                End Using

                sql = "select cod_ident from usuario order by cod_ident;"
                Using da As New MySqlDataAdapter(sql, cx)
                    da.Fill(dataSet, "userId")
                End Using

                sql = "select cod_bibliotecario from bibliotecario order by cod_bibliotecario;"
                Using da As New MySqlDataAdapter(sql, cx)
                    da.Fill(dataSet, "librarianId")
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub

    Public Function GetLoanById(currentRow As Integer) As Loan
        Try
            Dim sql As String = "ver_prestamo"
            Using cx As MySqlConnection = Me.Connect()
                Using command As New MySqlCommand(sql, cx)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@codigo", currentRow)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim loan As New Loan With {
                                .LoanId = currentRow,
                                .BookId = CInt(reader("cod_libro")),
                                .LoanDate = CDate(reader("fecha_pres")),
                                .DueDate = CDate(reader("fecha_ent")),
                                .UserId = CInt(reader("cod_ident")),
                                .LoanType = CStr(reader("tipo_prestamo")),
                                .LibrarianId = CInt(reader("cod_bibliotecario")),
                                .Delivered = CStr(reader("entregado")),
                                .Ticket = CSng(reader("multa"))
                            }
                            Return loan
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
        Return Nothing
    End Function

    Public Sub ConsultLoanByRangeDate(dateStar As Date, dateEnd As Date, overdueLoan As Boolean)
        Try
            Using conn As MySqlConnection = Me.Connect()
                Dim sql As String = "buscar_prestamos_por_fecha"
                dataSet.Tables.Clear()
                Using dataAdapter As New MySqlDataAdapter(sql, conn)
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@fecha_inicio", dateStar)
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@fecha_fin", dateEnd)
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@buscar_vencidos", overdueLoan)
                    dataAdapter.Fill(dataSet)
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub
End Class
