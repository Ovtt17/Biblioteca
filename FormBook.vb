Imports System.Linq.Expressions
Imports System.Xml

Public Class FormBook
    Private bookEditable As Book
    Private authorsEditablesList As List(Of BookAuthor)
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
        Dim authorSelected As String = $"{AuthorsCmb.Text}-{AuthorsCmb.SelectedValue}"
        If AuthorsCmb.SelectedIndex = -1 Then
            MessageBox.Show("Select an Author.")
            AuthorsCmb.Focus()
            Exit Sub
        ElseIf AuthorsList.Items.Contains(authorSelected) Then
            MessageBox.Show("You've already select that author.")
            Exit Sub
        End If
        AuthorsList.Items.Add(authorSelected)
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
        BtnSave.Text = "Save"
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not ValidateInputs() Then
            Exit Sub ' or return False if this is a Function
        End If

        If MessageBox.Show("Do you want to save the record?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim rot As String
            Dim bookDao As New BookDAO()
            Dim bookAuthorDao As New BookAuthorDAO()

            Dim title As String = TitleTxt.Text.Trim()
            Dim editorial As Integer = EditorialCmb.SelectedIndex + 1
            Dim publicationDate As Date = DateTimer.Value.Date

            ' Validate examples
            Dim examples As Integer
            If Not Integer.TryParse(ExamplesTxt.Text, examples) OrElse examples < 1 Then
                MessageBox.Show("The number of examples must be an integer greater than 0.")
                Return
            End If

            ' Validate pages
            Dim pages As Integer
            If Not Integer.TryParse(PageNumberTxt.Text, pages) OrElse pages < 1 Then
                MessageBox.Show("The number of pages must be an integer greater than 0.")
                Return
            End If

            Dim language As String = LanguageCmb.SelectedItem.ToString().Trim()
            Dim edition As Integer = EditionCmb.SelectedIndex + 1

            Dim a() As String
            Dim total As Integer = AuthorsList.Items.Count - 1

            If (BtnSave.Text = "Edit") Then
                bookEditable.Title = title
                bookEditable.EditorialC = editorial
                bookEditable.DatePublished = publicationDate
                bookEditable.Examples = examples
                bookEditable.PageNumbers = pages
                bookEditable.Language = language
                bookEditable.Edition = edition
                bookDao.ModifyBook(bookEditable)
                ' Obtener los autores antiguos
                Dim oldAuthors As List(Of BookAuthor) = bookAuthorDao.GetBookAuthorsById(bookEditable.Id)

                ' Crear una lista para almacenar los nuevos autores
                Dim newAuthors As New List(Of BookAuthor)

                ' Llenar la lista de nuevos autores
                For i = 0 To total
                    a = Split(AuthorsList.Items(i).ToString, "-")
                    Dim authorId As Integer = CInt(a(1))
                    newAuthors.Add(New BookAuthor(bookEditable.Id, authorId))
                Next

                ' Para cada autor en la nueva lista
                For Each newAuthor In newAuthors
                    ' Verificar si el autor ya existe en la lista antigua
                    If Not oldAuthors.Any(Function(oldAuthor) oldAuthor.AuthorCode = newAuthor.AuthorCode) Then
                        ' Si no existe, insertar el nuevo autor en la base de datos
                        bookAuthorDao.InsertBookAuthor(newAuthor)
                    End If
                Next

                ' Para cada autor en la lista antigua
                For Each oldAuthor In oldAuthors
                    ' Verificar si el autor todavía existe en la nueva lista
                    If Not newAuthors.Any(Function(newAuthor) newAuthor.AuthorCode = oldAuthor.AuthorCode) Then
                        ' Si no existe, eliminar el autor de la base de datos
                        bookAuthorDao.DeleteBookAuthor(oldAuthor)
                    End If
                Next
                rot = "Modified"
            Else
                Dim bookId = bookDao.InsertBook(New Book(title, editorial, publicationDate, examples, pages, language, edition))
                For i = 0 To total
                    a = Split(AuthorsList.Items(i).ToString, "-")
                    Dim authorId As Integer = CInt(a(1))
                    Dim bookAuthor As New BookAuthor(bookId, authorId)
                    bookAuthorDao.InsertBookAuthor(bookAuthor)

                Next
                rot = "Saved"
            End If

            MessageBox.Show($"Book {rot} Corretly.")
            ' Load table again
            ShowData()
            ' Clean all the fields to add new authors
            CleanFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Function ValidateInputs() As Boolean
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
                    Return False
                End If
            ElseIf TypeOf control.Key Is ComboBox Then
                Dim comboBox = CType(control.Key, ComboBox)
                If comboBox.SelectedIndex = -1 Then
                    MessageBox.Show(control.Value)
                    comboBox.Focus()
                    Return False
                End If
            ElseIf TypeOf control.Key Is DateTimePicker Then
                If control.Key.Text = "" Then
                    MessageBox.Show(control.Value)
                    control.Key.Focus()
                    Return False
                End If
            End If
        Next

        Return True
    End Function

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim currentRow As Integer = CInt(GridBook.CurrentRow.Cells(0).Value)
        If Not ValidateInputs() Then
            Exit Sub ' or return False if this is a Function
        End If
        If MessageBox.Show("Do you want to delete the selected book?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Try
            Dim bookdao As New BookDAO()
            bookdao.DeleteBook(currentRow)
            MessageBox.Show("Book Deleted!")
            ' Load table again
            ShowData()
            ' Clean all the fields to add new authors
            CleanFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridBook_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBook.CellClick
        Try
            Dim code As Integer = CInt(GridBook.CurrentRow.Cells(0).Value)
            Dim bookDao As New BookDAO()
            bookEditable = bookDao.GetBookById(code)
            If bookEditable IsNot Nothing Then
                Me.TitleTxt.Text = bookEditable.Title
                Me.EditorialCmb.SelectedIndex = bookEditable.EditorialC - 1
                Me.DateTimer.Value = bookEditable.DatePublished
                Me.ExamplesTxt.Text = CStr(bookEditable.Examples)
                Me.PageNumberTxt.Text = CStr(bookEditable.PageNumbers)
                Me.LanguageCmb.SelectedItem = bookEditable.Language
                Me.EditionCmb.SelectedIndex = bookEditable.Edition - 1

                Dim bookAuthorDao As New BookAuthorDAO()
                authorsEditablesList = bookAuthorDao.GetBookAuthorsById(code)
                If authorsEditablesList IsNot Nothing Then
                    AuthorsList.Items.Clear()
                    For Each author In authorsEditablesList
                        AuthorsList.Items.Add(author.AuthorName + "-" + author.AuthorCode.ToString)
                    Next
                End If

                Me.BtnSave.Text = "Edit"
            Else
                MessageBox.Show("The book with the provided code was not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("The cell is empty. Select another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub
End Class