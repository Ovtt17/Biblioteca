Public Class FormLogin
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim loginDao As New LoginDAO()
        Dim userName As String = UserNameTxt.Text.Trim()
        Dim password As String = PassTxt.Text
        Dim login As New Login(userName, password)
        If loginDao.ConsultUser(login) Then
            MessageBox.Show("You logged in")
            Me.Hide()
            Dim formContainer As New FormContainer()
            formContainer.Show()
        End If
    End Sub

    Private Sub ConsultBooksBtn_Click(sender As Object, e As EventArgs) Handles ConsultBooksBtn.Click

    End Sub
End Class