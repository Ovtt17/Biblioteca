<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormContainer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormContainer))
        Me.PanelOptions = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoanBtn = New System.Windows.Forms.Button()
        Me.BookCountrybtn = New System.Windows.Forms.Button()
        Me.EditorialBtn = New System.Windows.Forms.Button()
        Me.BibliotecarioBtn = New System.Windows.Forms.Button()
        Me.UsersBtn = New System.Windows.Forms.Button()
        Me.AuthorBtn = New System.Windows.Forms.Button()
        Me.BookBtn = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PanelOptions.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOptions
        '
        Me.PanelOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelOptions.Controls.Add(Me.PictureBox1)
        Me.PanelOptions.Controls.Add(Me.Label1)
        Me.PanelOptions.Controls.Add(Me.LoanBtn)
        Me.PanelOptions.Controls.Add(Me.BookCountrybtn)
        Me.PanelOptions.Controls.Add(Me.EditorialBtn)
        Me.PanelOptions.Controls.Add(Me.BibliotecarioBtn)
        Me.PanelOptions.Controls.Add(Me.UsersBtn)
        Me.PanelOptions.Controls.Add(Me.AuthorBtn)
        Me.PanelOptions.Controls.Add(Me.BookBtn)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelOptions.Location = New System.Drawing.Point(0, 0)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(307, 776)
        Me.PanelOptions.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Library"
        '
        'LoanBtn
        '
        Me.LoanBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.LoanBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoanBtn.FlatAppearance.BorderSize = 0
        Me.LoanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoanBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.LoanBtn.Image = CType(resources.GetObject("LoanBtn.Image"), System.Drawing.Image)
        Me.LoanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoanBtn.Location = New System.Drawing.Point(0, 451)
        Me.LoanBtn.Name = "LoanBtn"
        Me.LoanBtn.Size = New System.Drawing.Size(307, 58)
        Me.LoanBtn.TabIndex = 5
        Me.LoanBtn.Text = "Loan"
        Me.LoanBtn.UseVisualStyleBackColor = False
        '
        'BookCountrybtn
        '
        Me.BookCountrybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BookCountrybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookCountrybtn.FlatAppearance.BorderSize = 0
        Me.BookCountrybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookCountrybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookCountrybtn.ForeColor = System.Drawing.SystemColors.Control
        Me.BookCountrybtn.Image = CType(resources.GetObject("BookCountrybtn.Image"), System.Drawing.Image)
        Me.BookCountrybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookCountrybtn.Location = New System.Drawing.Point(0, 609)
        Me.BookCountrybtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BookCountrybtn.Name = "BookCountrybtn"
        Me.BookCountrybtn.Size = New System.Drawing.Size(307, 58)
        Me.BookCountrybtn.TabIndex = 5
        Me.BookCountrybtn.Text = "Book By Country"
        Me.BookCountrybtn.UseVisualStyleBackColor = False
        '
        'EditorialBtn
        '
        Me.EditorialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.EditorialBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditorialBtn.FlatAppearance.BorderSize = 0
        Me.EditorialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorialBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorialBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.EditorialBtn.Image = CType(resources.GetObject("EditorialBtn.Image"), System.Drawing.Image)
        Me.EditorialBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditorialBtn.Location = New System.Drawing.Point(0, 689)
        Me.EditorialBtn.Name = "EditorialBtn"
        Me.EditorialBtn.Size = New System.Drawing.Size(307, 58)
        Me.EditorialBtn.TabIndex = 4
        Me.EditorialBtn.Text = "Editorial"
        Me.EditorialBtn.UseVisualStyleBackColor = False
        '
        'BibliotecarioBtn
        '
        Me.BibliotecarioBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BibliotecarioBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BibliotecarioBtn.FlatAppearance.BorderSize = 0
        Me.BibliotecarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BibliotecarioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BibliotecarioBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.BibliotecarioBtn.Image = CType(resources.GetObject("BibliotecarioBtn.Image"), System.Drawing.Image)
        Me.BibliotecarioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BibliotecarioBtn.Location = New System.Drawing.Point(0, 534)
        Me.BibliotecarioBtn.Name = "BibliotecarioBtn"
        Me.BibliotecarioBtn.Size = New System.Drawing.Size(307, 58)
        Me.BibliotecarioBtn.TabIndex = 3
        Me.BibliotecarioBtn.Text = "Librarian"
        Me.BibliotecarioBtn.UseVisualStyleBackColor = False
        '
        'UsersBtn
        '
        Me.UsersBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.UsersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsersBtn.FlatAppearance.BorderSize = 0
        Me.UsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsersBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.UsersBtn.Image = CType(resources.GetObject("UsersBtn.Image"), System.Drawing.Image)
        Me.UsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsersBtn.Location = New System.Drawing.Point(3, 371)
        Me.UsersBtn.Name = "UsersBtn"
        Me.UsersBtn.Size = New System.Drawing.Size(304, 58)
        Me.UsersBtn.TabIndex = 2
        Me.UsersBtn.Text = "Users"
        Me.UsersBtn.UseVisualStyleBackColor = False
        '
        'AuthorBtn
        '
        Me.AuthorBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.AuthorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AuthorBtn.FlatAppearance.BorderSize = 0
        Me.AuthorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AuthorBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.AuthorBtn.Image = CType(resources.GetObject("AuthorBtn.Image"), System.Drawing.Image)
        Me.AuthorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AuthorBtn.Location = New System.Drawing.Point(0, 285)
        Me.AuthorBtn.Name = "AuthorBtn"
        Me.AuthorBtn.Size = New System.Drawing.Size(307, 58)
        Me.AuthorBtn.TabIndex = 1
        Me.AuthorBtn.Text = "Authors"
        Me.AuthorBtn.UseVisualStyleBackColor = False
        '
        'BookBtn
        '
        Me.BookBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BookBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookBtn.FlatAppearance.BorderSize = 0
        Me.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.BookBtn.Image = CType(resources.GetObject("BookBtn.Image"), System.Drawing.Image)
        Me.BookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookBtn.Location = New System.Drawing.Point(0, 204)
        Me.BookBtn.Name = "BookBtn"
        Me.BookBtn.Size = New System.Drawing.Size(307, 58)
        Me.BookBtn.TabIndex = 0
        Me.BookBtn.Text = "Books"
        Me.BookBtn.UseVisualStyleBackColor = False
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(307, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1589, 776)
        Me.PanelContainer.TabIndex = 1
        '
        'FormContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 776)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelOptions)
        Me.IsMdiContainer = True
        Me.Name = "FormContainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormContainer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelOptions.ResumeLayout(False)
        Me.PanelOptions.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelOptions As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents EditorialBtn As Button
    Friend WithEvents BibliotecarioBtn As Button
    Friend WithEvents UsersBtn As Button
    Friend WithEvents AuthorBtn As Button
    Friend WithEvents LoanBtn As Button
    Friend WithEvents BookCountrybtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BookBtn As Button
End Class
