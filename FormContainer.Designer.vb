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
        Me.EditorialBtn = New System.Windows.Forms.Button()
        Me.BibliotecarioBtn = New System.Windows.Forms.Button()
        Me.UsersBtn = New System.Windows.Forms.Button()
        Me.AuthorBtn = New System.Windows.Forms.Button()
        Me.BookBtn = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.BookCountrybtn = New System.Windows.Forms.Button()
        Me.PanelOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelOptions
        '
        Me.PanelOptions.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelOptions.Controls.Add(Me.BookCountrybtn)
        Me.PanelOptions.Controls.Add(Me.EditorialBtn)
        Me.PanelOptions.Controls.Add(Me.BibliotecarioBtn)
        Me.PanelOptions.Controls.Add(Me.UsersBtn)
        Me.PanelOptions.Controls.Add(Me.AuthorBtn)
        Me.PanelOptions.Controls.Add(Me.BookBtn)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelOptions.Location = New System.Drawing.Point(0, 0)
        Me.PanelOptions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(230, 473)
        Me.PanelOptions.TabIndex = 0
        '
        'EditorialBtn
        '
        Me.EditorialBtn.BackColor = System.Drawing.Color.Navy
        Me.EditorialBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditorialBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorialBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.EditorialBtn.Location = New System.Drawing.Point(0, 332)
        Me.EditorialBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EditorialBtn.Name = "EditorialBtn"
        Me.EditorialBtn.Size = New System.Drawing.Size(230, 47)
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
        Me.BibliotecarioBtn.Location = New System.Drawing.Point(0, 261)
        Me.BibliotecarioBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BibliotecarioBtn.Name = "BibliotecarioBtn"
        Me.BibliotecarioBtn.Size = New System.Drawing.Size(230, 47)
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
        Me.UsersBtn.Location = New System.Drawing.Point(2, 193)
        Me.UsersBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UsersBtn.Name = "UsersBtn"
        Me.UsersBtn.Size = New System.Drawing.Size(228, 47)
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
        Me.AuthorBtn.Location = New System.Drawing.Point(0, 124)
        Me.AuthorBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AuthorBtn.Name = "AuthorBtn"
        Me.AuthorBtn.Size = New System.Drawing.Size(230, 47)
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
        Me.BookBtn.Location = New System.Drawing.Point(0, 58)
        Me.BookBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BookBtn.Name = "BookBtn"
        Me.BookBtn.Size = New System.Drawing.Size(230, 47)
        Me.BookBtn.TabIndex = 0
        Me.BookBtn.Text = "Books"
        Me.BookBtn.UseVisualStyleBackColor = False
        '
        'PanelContainer
        '
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(230, 0)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(798, 473)
        Me.PanelContainer.TabIndex = 1
        '
        'BookCountrybtn
        '
        Me.BookCountrybtn.BackColor = System.Drawing.Color.Navy
        Me.BookCountrybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookCountrybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookCountrybtn.ForeColor = System.Drawing.SystemColors.Control
        Me.BookCountrybtn.Location = New System.Drawing.Point(0, 395)
        Me.BookCountrybtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BookCountrybtn.Name = "BookCountrybtn"
        Me.BookCountrybtn.Size = New System.Drawing.Size(230, 47)
        Me.BookCountrybtn.TabIndex = 5
        Me.BookCountrybtn.Text = "Book By Country"
        Me.BookCountrybtn.UseVisualStyleBackColor = False
        '
        'FormContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 473)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelOptions)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents BookCountrybtn As Button
End Class
