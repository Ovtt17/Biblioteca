<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContainer
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
        Me.PanelOptions = New System.Windows.Forms.Panel()
        Me.PanelEditorial = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelBibliotecario = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelUser = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelAuthor = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelBook = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PanelOptions.SuspendLayout()
        Me.PanelEditorial.SuspendLayout()
        Me.PanelBibliotecario.SuspendLayout()
        Me.PanelUser.SuspendLayout()
        Me.PanelAuthor.SuspendLayout()
        Me.PanelBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelOptions
        '
        Me.PanelOptions.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelOptions.Controls.Add(Me.PanelEditorial)
        Me.PanelOptions.Controls.Add(Me.PanelBibliotecario)
        Me.PanelOptions.Controls.Add(Me.PanelUser)
        Me.PanelOptions.Controls.Add(Me.PanelAuthor)
        Me.PanelOptions.Controls.Add(Me.PanelBook)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelOptions.Location = New System.Drawing.Point(0, 0)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(307, 746)
        Me.PanelOptions.TabIndex = 0
        '
        'PanelEditorial
        '
        Me.PanelEditorial.BackColor = System.Drawing.Color.Navy
        Me.PanelEditorial.Controls.Add(Me.Label5)
        Me.PanelEditorial.Location = New System.Drawing.Point(3, 426)
        Me.PanelEditorial.Name = "PanelEditorial"
        Me.PanelEditorial.Size = New System.Drawing.Size(304, 56)
        Me.PanelEditorial.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(105, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Editorial"
        '
        'PanelBibliotecario
        '
        Me.PanelBibliotecario.BackColor = System.Drawing.Color.Navy
        Me.PanelBibliotecario.Controls.Add(Me.Label4)
        Me.PanelBibliotecario.Location = New System.Drawing.Point(3, 339)
        Me.PanelBibliotecario.Name = "PanelBibliotecario"
        Me.PanelBibliotecario.Size = New System.Drawing.Size(304, 56)
        Me.PanelBibliotecario.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(86, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bibliotecario"
        '
        'PanelUser
        '
        Me.PanelUser.BackColor = System.Drawing.Color.Navy
        Me.PanelUser.Controls.Add(Me.Label3)
        Me.PanelUser.Location = New System.Drawing.Point(0, 260)
        Me.PanelUser.Name = "PanelUser"
        Me.PanelUser.Size = New System.Drawing.Size(304, 56)
        Me.PanelUser.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(118, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Users"
        '
        'PanelAuthor
        '
        Me.PanelAuthor.BackColor = System.Drawing.Color.Navy
        Me.PanelAuthor.Controls.Add(Me.Label2)
        Me.PanelAuthor.Location = New System.Drawing.Point(0, 178)
        Me.PanelAuthor.Name = "PanelAuthor"
        Me.PanelAuthor.Size = New System.Drawing.Size(304, 56)
        Me.PanelAuthor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(118, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Authors"
        '
        'PanelBook
        '
        Me.PanelBook.BackColor = System.Drawing.Color.Navy
        Me.PanelBook.Controls.Add(Me.Label1)
        Me.PanelBook.Location = New System.Drawing.Point(3, 102)
        Me.PanelBook.Name = "PanelBook"
        Me.PanelBook.Size = New System.Drawing.Size(304, 56)
        Me.PanelBook.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(115, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Books"
        '
        'PanelContainer
        '
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(307, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1589, 746)
        Me.PanelContainer.TabIndex = 1
        '
        'FormContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 746)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelOptions)
        Me.IsMdiContainer = True
        Me.Name = "FormContainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormContainer"
        Me.PanelOptions.ResumeLayout(False)
        Me.PanelEditorial.ResumeLayout(False)
        Me.PanelEditorial.PerformLayout()
        Me.PanelBibliotecario.ResumeLayout(False)
        Me.PanelBibliotecario.PerformLayout()
        Me.PanelUser.ResumeLayout(False)
        Me.PanelUser.PerformLayout()
        Me.PanelAuthor.ResumeLayout(False)
        Me.PanelAuthor.PerformLayout()
        Me.PanelBook.ResumeLayout(False)
        Me.PanelBook.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOptions As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PanelEditorial As Panel
    Friend WithEvents PanelBibliotecario As Panel
    Friend WithEvents PanelUser As Panel
    Friend WithEvents PanelAuthor As Panel
    Friend WithEvents PanelBook As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
