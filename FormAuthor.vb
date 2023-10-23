Imports System.Drawing.Text
Imports System.Security.Permissions
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class FormAuthor
    Private authorEditable As Author

    Private Sub FormActor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show data on the form
        Showdata()
        LoadCombobox()

    End Sub

    Private Sub LoadCombobox()
        ' Define and execute the SQL query to select countries
        Try
            Dim authorDao As New AuthorDAO()
            authorDao.LoadComboBox()
            If authorDao.dataSet.Tables(0).Rows.Count > 0 Then
                ' Configure the ComboBox with the query results
                With Me.CountryCmb
                    .DataSource = Nothing
                    .Items.Clear()
                    .DataSource = authorDao.dataSet.Tables(0)
                    .DisplayMember = "nombre_pais"
                    .ValueMember = "cod_pais"
                    .SelectedIndex = -1
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' A method for displaying all the authors in the DataGridView based on the author.
    ''' </summary>
    Private Sub Showdata()
        Try
            Dim authorDao As New AuthorDAO()
            authorDao.ConsultAuthor()
            GridAutor.DataSource = authorDao.dataSet.Tables(0)
            GridAutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CleanFields()
    End Sub

    Private Sub CleanFields()
        Me.NameTxt.Text = ""
        Me.CountryCmb.SelectedIndex = -1
        Me.BtnSave.Text = "Guardar"
        Me.NameTxt.Focus()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim rot As String
        ' Check if the NameTxt TextBox is empty or null.
        ' If it is, display an error message instructing the user to input the author's nameAuthor.
        If String.IsNullOrEmpty(NameTxt.Text.Trim()) Then
            MessageBox.Show("Please enter the author's name.")
            NameTxt.Focus()
            Exit Sub
        ElseIf CountryCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please select a country for the author")
            CountryCmb.Focus()
            Exit Sub
        End If

        ' confirm the recording data
        If MessageBox.Show("Do you want to save the record?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            ' Create DAO instance
            Dim authorDao As New AuthorDAO()
            ' Verify if author is editable or not
            If (BtnSave.Text = "Edit") Then
                authorEditable = New Author(Me.NameTxt.Text, Me.CountryCmb.SelectedIndex + 1)
                authorDao.ModifyAuthor(authorEditable)
                rot = "Modified"
            Else
                ' In Case it's not editable, insert a new one
                Dim author As New Author(NameTxt.Text, CountryCmb.SelectedIndex + 1)
                authorDao.InsertAuthor(author)
                rot = "Saved"
            End If
            MessageBox.Show($"Author {rot} Corretly.")
            ' Load table again
            Showdata()
            ' Clean all the fields to add new authors
            CleanFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim currentRow As Integer = CInt(GridAutor.CurrentRow.Cells(0).Value)
        If NameTxt.Text Is Nothing Or CountryCmb.SelectedIndex = -1 Then
            MessageBox.Show("Select an author to delete it")
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete the selected author?", "Library System",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim authorDao As New AuthorDAO()
        Try
            authorDao.DeleteAuthor(currentRow)
            ' Load table again
            Showdata()
            ' Clean all the fields to add new authors
            CleanFields()
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General Error: " & ex.Message)
        End Try

    End Sub

    Private Sub GridAutor_Click(sender As Object, e As EventArgs) Handles GridAutor.Click
        Dim code As Integer = CInt(GridAutor.CurrentRow.Cells(0).Value)

        Try
            Dim authorDAO As New AuthorDAO()
            authorEditable = authorDAO.GetAuthorById(code)
            If authorEditable IsNot Nothing Then
                Me.NameTxt.Text = authorEditable.Name
                Me.CountryCmb.SelectedValue = authorEditable.Country
                Me.BtnSave.Text = "Edit"
            Else
                MessageBox.Show("The author with the provided code was not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As InvalidCastException
            MessageBox.Show("The cell is empty. Select another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FormAuthor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ClosingMessage() Then
            e.Cancel = True
        End If
    End Sub
    Private Function ClosingMessage() As Boolean
        If MessageBox.Show("Do you want to close the app?", "Librery System",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Return False
        End If
        Return True
    End Function
End Class
