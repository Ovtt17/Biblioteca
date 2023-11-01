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

    Public Function ShowClosingDialog() As Boolean
        Dim dialog As DialogResult = MessageBox.Show("¿Realmente quieres cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Return False
        Else
            Return True
        End If
    End Function
End Class