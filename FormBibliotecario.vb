Imports MySql.Data.MySqlClient

Public Class FormBibliotecario

    Private bibliotecarioEditable As Bibliotecario

    Private Sub FormBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Showdata()

    End Sub

    Private Sub Showdata()
        Try
            Dim bibliotecarioDao As New BibliotecarioDAO()
            bibliotecarioDao.ConsultBibliotecario()
            GridBibliotecario.DataSource = bibliotecarioDao.dataSet.Tables(0)
            GridBibliotecario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CleanField()
    End Sub

    Private Sub CleanField()
        Me.FNameTxt.Text = ""
        Me.LNameTxt.Text = ""
        Me.AddressTxt.Text = ""
        Me.PositionTxt.Text = ""
        Me.BtnSave.Text = "Guardar"
        Me.FNameTxt.Focus()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim rot As String
        ' Check if the NameTxt TextBox is empty or null.
        ' If it is, display an error message instructing the user to input the librarian nameLibrarian.
        If String.IsNullOrEmpty(FNameTxt.Text.Trim()) Then
            MessageBox.Show("Please enter the librarian name.")
            FNameTxt.Focus()
            Exit Sub
        ElseIf LNameTxt.Text = "" Then
            MessageBox.Show("Please enter a last name for the librarian")
            LNameTxt.Focus()
            Exit Sub
        ElseIf AddressTxt.Text = "" Then
            MessageBox.Show("Please enter a Address for the librarian")
            AddressTxt.Focus()
            Exit Sub
        ElseIf PositionTxt.Text = "" Then
            MessageBox.Show("Please enter a Position for the librarian")
            PositionTxt.Focus()
        End If

        ' confirm the recording data
        If MessageBox.Show("Do you want to save the record?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            ' Create DAO instance
            Dim bibliotecarioDao As New BibliotecarioDAO()
            ' Verify if bibliotecario is editable or not
            If (BtnSave.Text = "Edit") Then
                bibliotecarioEditable.Fname = Me.FNameTxt.Text.Trim()
                bibliotecarioEditable.Lname = Me.LNameTxt.Text.Trim()
                bibliotecarioEditable.Address = Me.AddressTxt.Text.Trim()
                bibliotecarioEditable.Position = Me.PositionTxt.Text.Trim()
                bibliotecarioDao.ModifyBibliotecario(bibliotecarioEditable)
                rot = "Modified"
            Else
                ' In Case it's not editable, insert a new one
                Dim bibliotecario As New Bibliotecario(FNameTxt.Text.Trim(), LNameTxt.Text.Trim(), AddressTxt.Text.Trim(), PositionTxt.Text.Trim())
                bibliotecarioDao.InsertBibliotecario(bibliotecario)
                rot = "Saved"
            End If
            MessageBox.Show($"Bibliotecario {rot} Corretly.")
            ' Load table again
            Showdata()
            ' Clean all the fields to add new librarian
            CleanField()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim currentRow As Integer = CInt(GridBibliotecario.CurrentRow.Cells(0).Value)
        If FNameTxt.Text Is Nothing Or LNameTxt.Text = "" Or AddressTxt.Text = "" Or PositionTxt.Text = "" Then
            MessageBox.Show("Select an librarian to delete it")
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete the record?", "Library System",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim bibliotecarioDao As New BibliotecarioDAO()
        Try
            bibliotecarioDao.DeleteBibliotecario(currentRow)
            ' Load table again
            Showdata()
            ' Clean all the fields to add new librarian
            CleanField()
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("General Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub GridBibliotecario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBibliotecario.CellClick
        Try
            Dim code As Integer = CInt(GridBibliotecario.CurrentRow.Cells(0).Value)
            Dim bibliotecarioDAO As New BibliotecarioDAO()
            bibliotecarioEditable = bibliotecarioDAO.Row(code)
            If bibliotecarioEditable IsNot Nothing Then
                Me.FNameTxt.Text = bibliotecarioEditable.Fname
                Me.LNameTxt.Text = bibliotecarioEditable.Lname
                Me.AddressTxt.Text = bibliotecarioEditable.Address
                Me.PositionTxt.Text = bibliotecarioEditable.Position

                Me.BtnSave.Text = "Edit"
            Else
                MessageBox.Show("The librarian with the provided code was not found.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As InvalidCastException
            MessageBox.Show("La celda está vacía. Debes seleccionar donde haya algo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class