Public Class FormContainer
    Private Sub FormContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formBook As New FormBook With {
            .MdiParent = Me,
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None,
            .Dock = DockStyle.Fill
        }
        PanelContainer.Controls.Add(formBook)
        formBook.Show()
    End Sub

    Private Sub FormContainer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ClosingMessage() Then
            e.Cancel = True
        End If
        FormPresentation.Close()
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