Public Class FormLoan
    Private Sub FormLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        Try
            Dim loanDao As New LoanDAO()
            loanDao.ConsultLoan()
            GridLoan.DataSource = loanDao.dataSet.Tables(0)
            GridLoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub CleanFields()
        IdBookTxt.Text = ""
        DateLoan.Value = Date.Now
        DateDue.Value = Date.Now
        IdUserTxt.Text = ""
        TypeLoanCmb.SelectedIndex = -1
        IdLibrarianTxt.Text = ""
        DeliveredCmb.SelectedIndex = -1
        TicketTxt.Text = ""
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ValidateInputs()
        If MessageBox.Show("Do you want to save the record?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim bookId As Integer
            Dim userId As Integer
            Dim librarianId As Integer
            Dim validatedValues = ValidateIntegers(IdBookTxt, IdUserTxt, IdLibrarianTxt)
            If validatedValues IsNot Nothing Then
                bookId = validatedValues.Item1
                userId = validatedValues.Item2
                librarianId = validatedValues.Item3
            End If

            Dim loanDate As Date = DateLoan.Value.Date
            Dim dueDate As Date = DateDue.Value.Date
            If loanDate < DateTime.Today OrElse dueDate < DateTime.Today Then
                MessageBox.Show("The loan and return dates cannot be earlier than the current day.")
                Return
            End If

            Dim loanType As String = TypeLoanCmb.SelectedItem.ToString()
            Dim delivered As String = DeliveredCmb.SelectedItem.ToString()
            Dim ticket As Single? = If(String.IsNullOrEmpty(TicketTxt.Text), Nothing, CSng(TicketTxt.Text))

            Dim loan As New Loan(bookId, loanDate, dueDate, userId, loanType, librarianId, delivered, ticket)

            Dim loanDao As New LoanDAO()
            loanDao.InsertLoan(loan)
            ShowData()
            CleanFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub ValidateInputs()
        Dim controls As New Dictionary(Of Control, String) From {
            {IdBookTxt, "Enter the book id"},
            {IdUserTxt, "Enter the user id"},
            {TypeLoanCmb, "Select a Loan Type"},
            {IdLibrarianTxt, "Enter the librarian id"},
            {DeliveredCmb, "Select delivered value"}
        }

        For Each control In controls
            If TypeOf control.Key Is TextBox Then
                If control.Key.Text = "" Then
                    MessageBox.Show(control.Value)
                    control.Key.Focus()
                    Exit Sub
                End If
            ElseIf TypeOf control.Key Is ComboBox Then
                Dim comboBox = CType(control.Key, ComboBox)
                If comboBox.SelectedIndex = -1 Then
                    MessageBox.Show(control.Value)
                    comboBox.Focus()
                    Exit Sub
                End If
            ElseIf TypeOf control.Key Is DateTimePicker Then
                If control.Key.Text = "" Then
                    MessageBox.Show(control.Value)
                    control.Key.Focus()
                    Exit Sub
                End If
            End If
        Next
    End Sub
    Private Function ValidateIntegers(ByVal txtBook As TextBox, ByVal txtUser As TextBox, ByVal txtLibrarian As TextBox) As Tuple(Of Integer, Integer, Integer)
        Dim bookId As Integer
        If Not Integer.TryParse(txtBook.Text, bookId) OrElse bookId < 1 Then
            MessageBox.Show("The book id must be an integer greater than 0.")
            Return Nothing
        End If

        Dim userId As Integer
        If Not Integer.TryParse(txtUser.Text, userId) OrElse userId < 1 Then
            MessageBox.Show("The user id must be an integer greater than 0.")
            Return Nothing
        End If

        Dim librarianId As Integer
        If Not Integer.TryParse(txtLibrarian.Text, librarianId) OrElse librarianId < 1 Then
            MessageBox.Show("The librarian id must be an integer greater than 0.")
            Return Nothing
        End If

        ' Devuelve los valores validados.
        Return New Tuple(Of Integer, Integer, Integer)(bookId, userId, librarianId)
    End Function

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CleanFields()
    End Sub
End Class