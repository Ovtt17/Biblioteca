Imports MySql.Data.MySqlClient

Public Class FormEditorial
    Private editorialEditable As Editorial
    Private Sub FormEditorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show data on the form
        Showdata()
        LoadCombobox()
    End Sub

    Private Sub LoadCombobox()
        ' Define and execute the SQL query to select countries
        Try
            Dim editorialDao As New EditorialDAO()
            editorialDao.LoadComboBox()
            If editorialDao.dataSet.Tables(0).Rows.Count > 0 Then
                ' Configure the ComboBox with the query results
                With Me.CountryCmb
                    .DataSource = Nothing
                    .Items.Clear()
                    .DataSource = editorialDao.dataSet.Tables(0)
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
    ''' A method for displaying all the editorials in the DataGridView based on the editorial.
    ''' </summary>
    Private Sub Showdata()
        Try
            Dim editorialDao As New EditorialDAO()
            editorialDao.ConsultEditorial()
            GridEditorial.DataSource = editorialDao.dataSet.Tables(0)
            GridEditorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
        Dim rot As String
        ' Check if the NameTxt TextBox is empty or null.
        ' If it is, display an error message instructing the user to input the editorial's name.
        If String.IsNullOrEmpty(NameTxt.Text.Trim()) Then
            MessageBox.Show("Please enter the editorial's name.")
            NameTxt.Focus()
            Exit Sub
        ElseIf CountryCmb.SelectedIndex = -1 Then
            MessageBox.Show("Please select a country for the editorial")
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
            Dim editorialDao As New EditorialDAO()
            ' Verify if editorial is editable or not
            If (BtnSave.Text = "Edit") Then
                editorialEditable.Name = Me.NameTxt.Text
                editorialEditable.Country = Me.CountryCmb.SelectedIndex + 1
                editorialDao.ModifyEditorial(editorialEditable)
                rot = "Modified"
            Else
                ' In Case it's not editable, insert a new one
                editorialDao.InsertEditorial(New Editorial(NameTxt.Text, CountryCmb.SelectedIndex + 1))
                rot = "Saved"
            End If
            MessageBox.Show($"Editorial {rot} Corretly.")
            ' Load table again
            Showdata()
            ' Clean all the fields to add new editorials
            CleanField()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GridEditorial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridEditorial.CellClick
        Try
            Dim code As Integer = CInt(GridEditorial.CurrentRow.Cells(0).Value)
            Dim editorialDAO As New EditorialDAO()
            editorialEditable = editorialDAO.Row(code)
            If editorialEditable IsNot Nothing Then
                Me.NameTxt.Text = editorialEditable.Name
                Me.CountryCmb.SelectedValue = editorialEditable.Country
                Me.BtnSave.Text = "Edit"
            Else
                MessageBox.Show("The editorial with the provided code was not found.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As InvalidCastException
            MessageBox.Show("La celda está vacía. Debes seleccionar donde haya algo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim currentRow As Integer = CInt(GridEditorial.CurrentRow.Cells(0).Value)
        If NameTxt.Text Is Nothing Or CountryCmb.SelectedIndex = -1 Then
            MessageBox.Show("Select an editorial to delete it")
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete the selected editorial?", "Library System",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim editorialDao As New EditorialDAO()
        Try
            editorialDao.DeleteEditorial(currentRow)
            ' Load table again
            Showdata()
            ' Clean all the fields to add new authors
            CleanField()
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FormPresentation.Close()
    End Sub
End Class