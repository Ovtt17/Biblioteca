<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPresentation
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
        Me.components = New System.ComponentModel.Container()
        Me.TitleTxt = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TitleTxt
        '
        Me.TitleTxt.AutoSize = True
        Me.TitleTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxt.ForeColor = System.Drawing.SystemColors.Control
        Me.TitleTxt.Location = New System.Drawing.Point(409, 233)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(442, 69)
        Me.TitleTxt.TabIndex = 0
        Me.TitleTxt.Text = "Library System"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(382, 342)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(503, 34)
        Me.ProgressBar1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormPresentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1274, 667)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TitleTxt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPresentation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleTxt As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
