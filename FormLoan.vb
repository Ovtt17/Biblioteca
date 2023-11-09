Public Class FormLoan
    Private loanEditable As Loan
    Private Sub FormLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        Try
            Dim loanDao As New LoanDAO()
            loanDao.ConsultLoan()
            GridLoan.DataSource = loanDao.dataSet.Tables("loans")
            GridLoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            LoadComboboxes(loanDao.dataSet)

            RemoveEventHandlers()
            Dim monthAgo As Date = Date.Now.AddMonths(-12)
            DateStartFilter.Value = monthAgo.Date
            DateEndFilter.Value = Date.Now
            OverdueLoanCheck.Checked = False
            AddEventHandlers()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadComboboxes(dataSet As DataSet)
        If dataSet.Tables("bookId").Rows.Count > 0 Then
            ' Configure the ComboBox with the query results
            With Me.BookIdCmb
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = dataSet.Tables("bookId")
                .DisplayMember = "cod_libro"
                .ValueMember = "cod_libro"
                .SelectedIndex = -1
            End With
        End If
        If dataSet.Tables("userId").Rows.Count > 0 Then
            ' Configure the ComboBox with the query results
            With Me.UserIdCmb
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = dataSet.Tables("userId")
                .DisplayMember = "cod_ident"
                .ValueMember = "cod_ident"
                .SelectedIndex = -1
            End With
        End If
        If dataSet.Tables("librarianId").Rows.Count > 0 Then
            ' Configure the ComboBox with the query results
            With Me.LibrarianIdCmb
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = dataSet.Tables("librarianId")
                .DisplayMember = "cod_bibliotecario"
                .ValueMember = "cod_bibliotecario"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub RemoveEventHandlers()
        RemoveHandler DateEndFilter.ValueChanged, AddressOf DateEndFilter_ValueChanged
        RemoveHandler DateStartFilter.ValueChanged, AddressOf DateEndFilter_ValueChanged
        RemoveHandler OverdueLoanCheck.CheckedChanged, AddressOf OverdueLoanCheck_CheckedChanged
    End Sub

    Private Sub AddEventHandlers()
        AddHandler DateEndFilter.ValueChanged, AddressOf DateEndFilter_ValueChanged
        AddHandler DateStartFilter.ValueChanged, AddressOf DateEndFilter_ValueChanged
        AddHandler OverdueLoanCheck.CheckedChanged, AddressOf OverdueLoanCheck_CheckedChanged
    End Sub

    Private Sub CleanFields()
        BookIdCmb.SelectedIndex = -1
        DateLoan.Value = Date.Now
        DateDue.Value = Date.Now
        UserIdCmb.SelectedIndex = -1
        TypeLoanCmb.SelectedIndex = -1
        LibrarianIdCmb.SelectedIndex = -1
        DeliveredCmb.SelectedIndex = -1
        TicketTxt.Text = ""
        BtnSave.Text = "Save"
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not ValidateInputs() Then
            Exit Sub
        End If
        If MessageBox.Show("Do you want to save the record?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim loanDao As New LoanDAO()

            Dim bookId As Integer = CInt(BookIdCmb.SelectedValue)
            Dim userId As Integer = CInt(UserIdCmb.SelectedValue)
            Dim librarianId As Integer = CInt(LibrarianIdCmb.SelectedValue)

            Dim loanDate As Date = DateLoan.Value.Date
            Dim dueDate As Date = DateDue.Value.Date
            If loanDate > dueDate Then
                MessageBox.Show("The loan date cannot be later than due day.")
                Exit Sub
            End If

            Dim loanType As String = TypeLoanCmb.SelectedItem.ToString()
            Dim delivered As String = DeliveredCmb.SelectedItem.ToString()
            Dim ticket As Single? = If(String.IsNullOrEmpty(TicketTxt.Text), Nothing, CSng(TicketTxt.Text))

            If (BtnSave.Text = "Edit") Then
                loanEditable.BookId = bookId
                loanEditable.LoanDate = loanDate
                loanEditable.DueDate = dueDate
                loanEditable.UserId = userId
                loanEditable.LoanType = loanType
                loanEditable.LibrarianId = librarianId
                loanEditable.Delivered = delivered
                loanEditable.Ticket = ticket
                loanDao.ModifyLoan(loanEditable)
            Else
                If loanDate < DateTime.Today OrElse dueDate < DateTime.Today Then
                    MessageBox.Show("The loan and return dates cannot be earlier than current day.")
                    Exit Sub
                End If
                loanDao.InsertLoan(New Loan(bookId, loanDate, dueDate, userId, loanType, librarianId, delivered, ticket))
            End If

            ShowData()
            CleanFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim controls As New Dictionary(Of Control, String) From {
        {BookIdCmb, "Select a Book Id"},
        {UserIdCmb, "Select an User Id"},
        {LibrarianIdCmb, "Select a Librarian Id"},
        {TypeLoanCmb, "Select a Loan Type"},
        {DeliveredCmb, "Select delivered value"}
    }

        For Each control In controls
            If TypeOf control.Key Is TextBox Then
                If control.Key.Text = "" Then
                    MessageBox.Show(control.Value)
                    control.Key.Focus()
                    Return False
                End If
            ElseIf TypeOf control.Key Is ComboBox Then
                Dim comboBox = CType(control.Key, ComboBox)
                If comboBox.SelectedIndex = -1 Then
                    MessageBox.Show(control.Value)
                    comboBox.Focus()
                    Return False
                End If
            End If
        Next

        Return True
    End Function

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CleanFields()
    End Sub

    Private Sub GridLoan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridLoan.CellClick
        Dim currentRow As Integer = CInt(GridLoan.CurrentRow.Cells(0).Value)
        Try
            Dim loanDao As New LoanDAO()
            loanEditable = loanDao.GetLoanById(currentRow)
            If loanEditable IsNot Nothing Then
                BookIdCmb.SelectedValue = loanEditable.BookId
                DateLoan.Value = loanEditable.LoanDate
                DateDue.Value = loanEditable.DueDate
                UserIdCmb.SelectedValue = loanEditable.UserId
                TypeLoanCmb.SelectedItem = loanEditable.LoanType
                LibrarianIdCmb.SelectedValue = loanEditable.LibrarianId

                Dim valorBuscado As String = loanEditable.Delivered
                ' Busca el índice del ítem en el ComboBox
                Dim indice As Integer = DeliveredCmb.FindStringExact(valorBuscado)
                ' Si el ítem se encontró en el ComboBox, selecciona el ítem
                If indice <> -1 Then
                    DeliveredCmb.SelectedIndex = indice
                End If
                TicketTxt.Text = loanEditable.Ticket.ToString()
            End If

            BtnSave.Text = "Edit"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim currentRow As Integer = CInt(GridLoan.CurrentRow.Cells(0).Value)
        If Not ValidateInputs() Then
            Exit Sub ' or return False if this is a Function
        End If
        If MessageBox.Show("Do you want to delete the selected loan?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim loanDAO As New LoanDAO()
            loanDAO.DeleteLoan(currentRow)
            ' Load table again
            ShowData()
            ' Clean all the fields to add new authors
            CleanFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub DateEndFilter_ValueChanged(sender As Object, e As EventArgs) Handles DateEndFilter.ValueChanged, DateStartFilter.ValueChanged
        FilteredConsult()
    End Sub
    Private Sub OverdueLoanCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OverdueLoanCheck.CheckedChanged
        FilteredConsult()
    End Sub
    Private Sub FilteredConsult()
        Try
            Dim dao As New LoanDAO()
            Dim dateStart As Date = DateStartFilter.Value.Date
            Dim dateEnd As Date = DateEndFilter.Value.Date
            Dim overdueLoan As Boolean = OverdueLoanCheck.Checked
            dao.ConsultLoanByRangeDate(dateStart, dateEnd, overdueLoan)
            GridLoan.DataSource = dao.dataSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnCleanFilters_Click(sender As Object, e As EventArgs) Handles BtnCleanFilters.Click
        ShowData()
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Dim export As New ExportToExcel()
        export.ExportData(GridLoan)
    End Sub
End Class