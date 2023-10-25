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
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.EditorialBtn = New System.Windows.Forms.Button()
        Me.BibliotecarioBtn = New System.Windows.Forms.Button()
        Me.UsersBtn = New System.Windows.Forms.Button()
        Me.AuthorBtn = New System.Windows.Forms.Button()
        Me.BookBtn = New System.Windows.Forms.Button()
        Me.PanelOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelOptions
        '
        Me.PanelOptions.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelOptions.Controls.Add(Me.EditorialBtn)
        Me.PanelOptions.Controls.Add(Me.BibliotecarioBtn)
        Me.PanelOptions.Controls.Add(Me.UsersBtn)
        Me.PanelOptions.Controls.Add(Me.AuthorBtn)
        Me.PanelOptions.Controls.Add(Me.BookBtn)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelOptions.Location = New System.Drawing.Point(0, 0)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(307, 582)
        Me.PanelOptions.TabIndex = 0
        '
        'PanelContainer
        '
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(307, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1589, 582)
        Me.PanelContainer.TabIndex = 1
        '
        'EditorialBtn
        '
        Me.EditorialBtn.BackColor = System.Drawing.Color.Navy
        Me.EditorialBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditorialBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorialBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.EditorialBtn.Location = New System.Drawing.Point(0, 408)
        Me.EditorialBtn.Name = "EditorialBtn"
        Me.EditorialBtn.Size = New System.Drawing.Size(307, 58)
        Me.EditorialBtn.TabIndex = 4
        Me.EditorialBtn.Text = "Editorial"
        Me.EditorialBtn.UseVisualStyleBackColor = False
        '
        'BibliotecarioBtn
        '
        Me.BibliotecarioBtn.BackColor = System.Drawing.Color.Navy
        Me.BibliotecarioBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BibliotecarioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BibliotecarioBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.BibliotecarioBtn.Location = New System.Drawing.Point(0, 321)
        Me.BibliotecarioBtn.Name = "BibliotecarioBtn"
        Me.BibliotecarioBtn.Size = New System.Drawing.Size(307, 58)
        Me.BibliotecarioBtn.TabIndex = 3
        Me.BibliotecarioBtn.Text = "Bibliotecario"
        Me.BibliotecarioBtn.UseVisualStyleBackColor = False
        '
        'UsersBtn
        '
        Me.UsersBtn.BackColor = System.Drawing.Color.Navy
        Me.UsersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsersBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.UsersBtn.Location = New System.Drawing.Point(3, 238)
        Me.UsersBtn.Name = "UsersBtn"
        Me.UsersBtn.Size = New System.Drawing.Size(304, 58)
        Me.UsersBtn.TabIndex = 2
        Me.UsersBtn.Text = "Users"
        Me.UsersBtn.UseVisualStyleBackColor = False
        '
        'AuthorBtn
        '
        Me.AuthorBtn.BackColor = System.Drawing.Color.Navy
        Me.AuthorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AuthorBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.AuthorBtn.Location = New System.Drawing.Point(0, 152)
        Me.AuthorBtn.Name = "AuthorBtn"
        Me.AuthorBtn.Size = New System.Drawing.Size(307, 58)
        Me.AuthorBtn.TabIndex = 1
        Me.AuthorBtn.Text = "Authors"
        Me.AuthorBtn.UseVisualStyleBackColor = False
        '
        'BookBtn
        '
        Me.BookBtn.BackColor = System.Drawing.Color.Navy
        Me.BookBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.BookBtn.Location = New System.Drawing.Point(0, 71)
        Me.BookBtn.Name = "BookBtn"
        Me.BookBtn.Size = New System.Drawing.Size(307, 58)
        Me.BookBtn.TabIndex = 0
        Me.BookBtn.Text = "Books"
        Me.BookBtn.UseVisualStyleBackColor = False
        '
        'FormContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 582)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelOptions)
        Me.IsMdiContainer = True
        Me.Name = "FormContainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormContainer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOptions As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents EditorialBtn As Button
    Friend WithEvents BibliotecarioBtn As Button
    Friend WithEvents UsersBtn As Button
    Friend WithEvents AuthorBtn As Button
    Friend WithEvents BookBtn As Button
End Class
