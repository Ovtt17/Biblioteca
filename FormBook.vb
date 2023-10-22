Imports System.Xml

Public Class FormBook
    Private Sub FormBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show data on the form
        ShowData()
        LoadComboBoxes()
    End Sub
    Private Sub ShowData()
        Try
            Dim bookDao As New BookDAO()
            bookDao.ConsultBook()
            GridBook.DataSource = bookDao.dataSet.Tables(0)
            GridBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadComboBoxes()
        Try
            Dim bookDao As New BookDAO()
            ' Define the SQL query to call the stored procedure 'seleccionar_paises'
            Dim sqlEditorial As String = "call seleccionar_editoriales();"
            bookDao.LoadComboBox(sqlEditorial)
            If bookDao.dataSet.Tables(0).Rows.Count > 0 Then
                With Me.EditorialCmb
                    .DataSource = Nothing
                    .Items.Clear()
                    .DataSource = bookDao.dataSet.Tables(0)
                    .DisplayMember = "editorial"
                    .ValueMember = "codigo"
                    .SelectedIndex = -1
                End With
            End If
            Dim sqlAuthor As String = "call seleccionar_autores();"
            bookDao.LoadComboBox(sqlAuthor)
            If bookDao.dataSet.Tables(0).Rows.Count > 0 Then
                With Me.AuthorsCmb
                    .DataSource = Nothing
                    .Items.Clear()
                    .DataSource = bookDao.dataSet.Tables(0)
                    .DisplayMember = "autor"
                    .ValueMember = "codigo"
                    .SelectedIndex = -1
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AddAuthorBtn_Click(sender As Object, e As EventArgs) Handles AddAuthorBtn.Click
        If AuthorsCmb.SelectedIndex = -1 Then
            MessageBox.Show("Select an Author.")
            AuthorsCmb.Focus()
            Exit Sub
        End If
        AuthorsList.Items.Add(AuthorsCmb.Text + "-" + AuthorsCmb.SelectedValue.ToString)
        AuthorsCmb.SelectedIndex = -1
    End Sub

    Private Sub RemoveAuthorBtn_Click(sender As Object, e As EventArgs) Handles RemoveAuthorBtn.Click
        If AuthorsList.SelectedIndex <> -1 Then
            AuthorsList.Items.RemoveAt(AuthorsList.SelectedIndex)
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CleanFields()
    End Sub

    Private Sub CleanFields()
        TitleTxt.Clear()
        EditorialCmb.SelectedIndex = -1
        DateTimer.Text = CStr(Now)
        ExamplesTxt.Clear()
        PageNumberTxt.Clear()
        LanguageCmb.SelectedIndex = -1
        EditionCmb.SelectedIndex = -1
        TitleTxt.Focus()
        AuthorsCmb.SelectedIndex = -1
        AuthorsList.Items.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ValidateInputs()
        If MessageBox.Show("Do you want to save the record?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim rot As String
            Dim bookDao As New BookDAO()

            Dim title As String = TitleTxt.Text
            Dim editorial As Integer = EditorialCmb.SelectedIndex + 1
            Dim publicationDate As Date = DateTimer.Value.Date
            Dim examples As Integer = Integer.Parse(ExamplesTxt.Text)
            Dim pages As Integer = Integer.Parse(PageNumberTxt.Text)
            Dim language As String = LanguageCmb.SelectedItem.ToString()
            Dim edition As Integer = EditionCmb.SelectedIndex

            Dim book As New Book(title, editorial, publicationDate, examples, pages, language, edition)

            Dim bookId = bookDao.InsertBook(book)

            Try
                Dim a() As String
                Dim total As Integer = AuthorsList.Items.Count - 1
                For i = 0 To total
                    a = Split(AuthorsList.Items(i).ToString, "-")
                    Dim authorId As Integer = CInt(a(1))
                    Dim bookAuthor As New BookAuthor(bookId, authorId)

                    Dim bookAuthorDao As New BookAuthorDAO()
                    bookAuthorDao.InsertBookAuthor(bookAuthor)

                Next
            Catch ex As Exception

            End Try
            rot = "Saved"
            'If (BtnSave.Text = "Edit") Then
            '    bookEditable.Name = Me.NameTxt.Text

            '    bookDao.(authorEditable)
            '    rot = "Modified"
            'End If

            MessageBox.Show($"Book {rot} Corretly.")
            ' Load table again
            ShowData()
            ' Clean all the fields to add new authors
            CleanFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ValidateInputs()
        Dim controls As New Dictionary(Of Control, String) From {
            {TitleTxt, "Enter the book bookTitle"},
            {EditorialCmb, "Select the publisher"},
            {DateTimer, "Select the publication date"},
            {ExamplesTxt, "Enter the number of copies"},
            {PageNumberTxt, "Enter the number of pages"},
            {LanguageCmb, "Select the bookLanguage"},
            {EditionCmb, "Select the bookEdition"}
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
End Class