<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserNameTxt = New System.Windows.Forms.TextBox()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ConsultBooksBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'UserNameTxt
        '
        Me.UserNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTxt.Location = New System.Drawing.Point(395, 68)
        Me.UserNameTxt.Name = "UserNameTxt"
        Me.UserNameTxt.Size = New System.Drawing.Size(298, 38)
        Me.UserNameTxt.TabIndex = 2
        '
        'PassTxt
        '
        Me.PassTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTxt.HideSelection = False
        Me.PassTxt.Location = New System.Drawing.Point(395, 194)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTxt.Size = New System.Drawing.Size(298, 38)
        Me.PassTxt.TabIndex = 3
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Green
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.LoginBtn.Location = New System.Drawing.Point(215, 302)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(145, 51)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.Red
        Me.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.CancelBtn.Location = New System.Drawing.Point(462, 302)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(145, 51)
        Me.CancelBtn.TabIndex = 5
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'ConsultBooksBtn
        '
        Me.ConsultBooksBtn.BackColor = System.Drawing.Color.Green
        Me.ConsultBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConsultBooksBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultBooksBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.ConsultBooksBtn.Location = New System.Drawing.Point(723, 455)
        Me.ConsultBooksBtn.Name = "ConsultBooksBtn"
        Me.ConsultBooksBtn.Size = New System.Drawing.Size(145, 88)
        Me.ConsultBooksBtn.TabIndex = 6
        Me.ConsultBooksBtn.Text = "Consult Books"
        Me.ConsultBooksBtn.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(916, 579)
        Me.Controls.Add(Me.ConsultBooksBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PassTxt)
        Me.Controls.Add(Me.UserNameTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserNameTxt As TextBox
    Friend WithEvents PassTxt As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents ConsultBooksBtn As Button
End Class
