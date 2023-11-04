
Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Text
Imports System.Net
Imports System.Security.Permissions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class FormUsers
    Private txtYear As Object
    Private txtMonth As Object
    Private txtDay As Object
    Private userEditable As User
    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Showdata()
    End Sub

    Private Sub Showdata()
        Try
            Dim userDAO As New UserDAO()
            userDAO.ConsulUser()
            GridUser.DataSource = userDAO.dataSet.Tables(0)
            GridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Codidenttxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codidenttxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' El carácter ingresado no puede ser escrito con letras
            e.Handled = True
        End If
    End Sub

    Private Sub Phonetxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phonetxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' El carácter ingresado no es un número 
            e.Handled = True
        End If
    End Sub
    Private Sub BtnNew_Click_1(sender As Object, e As EventArgs) Handles BtnNew.Click
        CleanField()
    End Sub
    Private Sub CleanField()
        Me.codidenttxt.Text = ""
        Me.NameTxt.Text = ""
        'e.CountryCmb.SelectedIndex = -1
        Me.BtnSave.Text = "Guardar"
        Me.NameTxt.Focus()
        Me.name2txt.Text = ""
        Me.phonetxt.Text = ""
        Me.addrtxt.Text = ""
        Me.DateTimePicker1.Text = CStr(Now)
        Me.sexcmb.SelectedIndex = -1
        Me.statuscmb.SelectedIndex = -1
        Me.studytxt.Text = ""

    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim rot As String
        ' Check if the NameTxt TextBox is empty or null.
        ' If it is, display an error message instructing the user to input the author's nameAuthor.
        If String.IsNullOrEmpty(NameTxt.Text.Trim()) Then
            MessageBox.Show("Please enter the User name.")
            NameTxt.Focus()
            Exit Sub
        ElseIf statuscmb.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Sex for the user")
            statuscmb.Focus()
            Exit Sub
        End If

        ' confirm the recording data
        If MessageBox.Show("Do you want to save the record?", "Library System",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
            Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        Try
            Dim userDao As New UserDAO()
            Dim codeident As Integer = CInt(codidenttxt.Text)
            Dim Name As String = NameTxt.Text
            Dim LastName As String = name2txt.Text
            Dim Phone As String = phonetxt.Text
            Dim Address As String = addrtxt.Text
            Dim BirthDate As Date = DateTimePicker1.Value.Date

            Dim Sex As String = sexcmb.SelectedItem.ToString
            Dim Status As String = CStr(statuscmb.SelectedItem)
            Dim Study As String = studytxt.Text



            ' Verificar si el autor es editable o no
            If (BtnSave.Text = "Edit") Then
                userEditable.codeIdent = CInt(Me.codidenttxt.Text)
                userEditable.Name = Name
                userEditable.LastName = LastName
                userEditable.Phone = Phone
                userEditable.Address = Address
                userEditable.Birthdate = BirthDate
                userEditable.Sex = Sex
                userEditable.Status = Status
                userEditable.Study = Study
                userDao.ModifyUser(userEditable)
                rot = "Modificado"
            Else
                ' En caso de que no sea editable, insertar uno nuevo
                Dim user As New User(codeident, Name, LastName, Phone, Address, BirthDate, Sex, Status, Study)
                userDao.EnterUser(user)
                rot = "Guardado"
            End If

            MessageBox.Show($"Usuario {rot} correctamente.")

            ' Cargar tabla nuevamente
            Showdata()

            ' Limpiar todos los campos para agregar nuevos autores
            CleanField()

        Catch ex As Exception
            ' Maneja cualquier excepción que pueda ocurrir
            MessageBox.Show("Se ha producido una excepción: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click_1(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim currentRow As Integer = CInt(GridUser.CurrentRow.Cells(0).Value)
        If NameTxt.Text Is Nothing Or sexcmb.SelectedIndex = -1 Then
            MessageBox.Show("Select an author to delete it")
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete the record?", "Library System",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim userDAO As New UserDAO()
        Try
            userDAO.DeleteUser(currentRow)
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

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub GridUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridUser.CellClick
        Dim code As Integer = CInt(GridUser.CurrentRow.Cells(0).Value)

        Try
            Dim userDAO As New UserDAO()
            userEditable = userDAO.GetUser(code)

            If userEditable IsNot Nothing Then
                Me.codidenttxt.Text = CStr(userEditable.codeIdent)
                Me.NameTxt.Text = userEditable.Name
                Me.name2txt.Text = userEditable.LastName
                Me.phonetxt.Text = userEditable.Phone
                Me.addrtxt.Text = userEditable.Address
                DateTimePicker1.Value = userEditable.Birthdate
                Me.sexcmb.SelectedItem = userEditable.Sex
                Me.statuscmb.SelectedItem = userEditable.Status
                Me.studytxt.Text = userEditable.Study

                ' Asigna otros valores a los controles correspondientes aquí
                Me.BtnSave.Text = "Edit"
            Else
                MessageBox.Show("El usuario con el código proporcionado no se encontró.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("La celda está vacía. Selecciona otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FinedUsersCheck_CheckedChanged(sender As Object, e As EventArgs) Handles FinedUsersCheck.CheckedChanged
        If FinedUsersCheck.Checked Then
            FinedUsers()
        Else
            Showdata()
        End If
    End Sub
    Private Sub FinedUsers()
        Try
            Dim finedusersDao As New UserDAO()
            finedusersDao.FinedUsers()
            GridUser.DataSource = finedusersDao.dataSet.Tables(0)
            GridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Dim export As New ExportToExcel()
        export.ExportData(GridUser)
    End Sub
End Class