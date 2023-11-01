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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserNameTxt = New System.Windows.Forms.TextBox()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ConsultBooksBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 442)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'UserNameTxt
        '
        Me.UserNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTxt.Location = New System.Drawing.Point(354, 366)
        Me.UserNameTxt.Name = "UserNameTxt"
        Me.UserNameTxt.Size = New System.Drawing.Size(298, 38)
        Me.UserNameTxt.TabIndex = 2
        '
        'PassTxt
        '
        Me.PassTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTxt.HideSelection = False
        Me.PassTxt.Location = New System.Drawing.Point(354, 436)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTxt.Size = New System.Drawing.Size(298, 38)
        Me.PassTxt.TabIndex = 3
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.LoginBtn.Location = New System.Drawing.Point(244, 555)
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
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.CancelBtn.Location = New System.Drawing.Point(475, 555)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(145, 51)
        Me.CancelBtn.TabIndex = 5
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'ConsultBooksBtn
        '
        Me.ConsultBooksBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ConsultBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConsultBooksBtn.FlatAppearance.BorderSize = 0
        Me.ConsultBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConsultBooksBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultBooksBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.ConsultBooksBtn.Location = New System.Drawing.Point(736, 32)
        Me.ConsultBooksBtn.Name = "ConsultBooksBtn"
        Me.ConsultBooksBtn.Size = New System.Drawing.Size(145, 88)
        Me.ConsultBooksBtn.TabIndex = 6
        Me.ConsultBooksBtn.Text = "Consult Books"
        Me.ConsultBooksBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(301, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 280)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(916, 644)
        Me.Controls.Add(Me.PictureBox1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
