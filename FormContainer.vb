Public Class FormContainer
    Private Sub FormContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(New FormBook())
    End Sub

    Private Sub FormContainer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormPresentation.Close()
    End Sub

    Private Sub BookBtn_Click(sender As Object, e As EventArgs) Handles BookBtn.Click
        ShowForm(New FormBook())
    End Sub

    Private Sub AuthorBtn_Click(sender As Object, e As EventArgs) Handles AuthorBtn.Click
        ShowForm(New FormAuthor())
    End Sub
    Public Sub ShowForm(form As Form)
        ' Cierra todos los formularios existentes en PanelContainer
        For Each control In PanelContainer.Controls
            If TypeOf control Is Form Then
                CType(control, Form).Close()
            End If
        Next
        form.MdiParent = Me
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub UsersBtn_Click(sender As Object, e As EventArgs) Handles UsersBtn.Click
        ShowForm(New FormUsers())
    End Sub

    Private Sub BibliotecarioBtn_Click(sender As Object, e As EventArgs) Handles BibliotecarioBtn.Click
        ShowForm(New FormBibliotecario())
    End Sub

    Private Sub EditorialBtn_Click(sender As Object, e As EventArgs) Handles EditorialBtn.Click
        ShowForm(New FormEditorial())
    End Sub

    Private Sub LoanBtn_Click(sender As Object, e As EventArgs) Handles LoanBtn.Click
        ShowForm(New FormLoan())
    End Sub

    Private Sub BookCountrybtn_Click(sender As Object, e As EventArgs) Handles BookCountrybtn.Click
        ShowForm(New FormSearchBook())
    End Sub
End Class