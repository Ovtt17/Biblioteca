Public Class FormPresentation
    Dim contador As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            contador += 5
            ProgressBar1.Value = contador
        Else
            Me.Hide()
            FormLogin.Show()
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub FormPresentation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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