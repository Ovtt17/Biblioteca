Imports System.Drawing.Text
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class FormAuthor
    Private authorEditable As Author

    ''' <summary>
    ''' Event handler that is triggered when the form is loaded.
    ''' </summary>
    ''' <param nameAuthor="sender"></param>
    ''' <param nameAuthor="e"></param>

    Private Sub FormActor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show data on the form
        Showdata()
        LoadCombobox()

    End Sub

    Private Sub LoadCombobox()
        ' Define and execute the SQL query to select countries
        Try
            Dim authorDao As New AuthorDao()
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
            Dim authorDao As New AuthorDao()
            authorDao.Consult()
            GridAutor.DataSource = authorDao.dataSet.Tables(0)
            For Each column As DataGridViewColumn In GridAutor.Columns
                column.Width = 145.5
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CleanField()
    End Sub

    Private Sub CleanField()
        Me.NameTxt.Text = ""
        Me.CountryCmb.SelectedIndex = -1
        Me.BtnSave.Text = "Guardar"
        Me.NameTxt.Focus()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim code As Integer

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
            Dim authorDao As New AuthorDao()
            If (BtnSave.Text = "Edit") Then
                authorEditable.Name = Me.NameTxt.Text
                authorEditable.Country = Me.CountryCmb.SelectedIndex + 1
                authorDao.ModifyAuthor(authorEditable)
            Else
                Dim author As New Author(NameTxt.Text, CountryCmb.SelectedIndex + 1)
                authorDao.InsertAuthor(author)
            End If
            Showdata()
            CleanField()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub GridAutor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridAutor.CellContentClick
        Dim codigo As String = GridAutor.Rows(e.RowIndex).Cells(0).Value

        Try
            Dim authorDAO As New AuthorDao()
            authorEditable = authorDAO.Row(codigo)
            If authorEditable IsNot Nothing Then
                Me.NameTxt.Text = authorEditable.Name
                Me.CountryCmb.SelectedValue = authorEditable.Country
                Me.BtnSave.Text = "Edit"
            Else
                MessageBox.Show("The author with the provided code was not found.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class
