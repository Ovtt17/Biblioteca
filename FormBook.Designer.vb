<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBook
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RemoveAuthorBtn = New System.Windows.Forms.Button()
        Me.AddAuthorBtn = New System.Windows.Forms.Button()
        Me.AuthorsList = New System.Windows.Forms.ListBox()
        Me.AuthorsCmb = New System.Windows.Forms.ComboBox()
        Me.AuthorsLbl = New System.Windows.Forms.Label()
        Me.DateTimer = New System.Windows.Forms.DateTimePicker()
        Me.EditorialCmb = New System.Windows.Forms.ComboBox()
        Me.PageNumberTxt = New System.Windows.Forms.TextBox()
        Me.PageNumberLbl = New System.Windows.Forms.Label()
        Me.EditionCmb = New System.Windows.Forms.ComboBox()
        Me.LanguageCmb = New System.Windows.Forms.ComboBox()
        Me.ExamplesTxt = New System.Windows.Forms.TextBox()
        Me.TitleTxt = New System.Windows.Forms.TextBox()
        Me.LanguageLbl = New System.Windows.Forms.Label()
        Me.EditionLbl = New System.Windows.Forms.Label()
        Me.ExamplesLbl = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.EditorialLbl = New System.Windows.Forms.Label()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GridBook = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GridBook)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1589, 582)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.RemoveAuthorBtn)
        Me.Panel2.Controls.Add(Me.AddAuthorBtn)
        Me.Panel2.Controls.Add(Me.AuthorsList)
        Me.Panel2.Controls.Add(Me.AuthorsCmb)
        Me.Panel2.Controls.Add(Me.AuthorsLbl)
        Me.Panel2.Controls.Add(Me.DateTimer)
        Me.Panel2.Controls.Add(Me.EditorialCmb)
        Me.Panel2.Controls.Add(Me.PageNumberTxt)
        Me.Panel2.Controls.Add(Me.PageNumberLbl)
        Me.Panel2.Controls.Add(Me.EditionCmb)
        Me.Panel2.Controls.Add(Me.LanguageCmb)
        Me.Panel2.Controls.Add(Me.ExamplesTxt)
        Me.Panel2.Controls.Add(Me.TitleTxt)
        Me.Panel2.Controls.Add(Me.LanguageLbl)
        Me.Panel2.Controls.Add(Me.EditionLbl)
        Me.Panel2.Controls.Add(Me.ExamplesLbl)
        Me.Panel2.Controls.Add(Me.DateLbl)
        Me.Panel2.Controls.Add(Me.EditorialLbl)
        Me.Panel2.Controls.Add(Me.TitleLbl)
        Me.Panel2.Location = New System.Drawing.Point(46, 204)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1095, 316)
        Me.Panel2.TabIndex = 21
        '
        'RemoveAuthorBtn
        '
        Me.RemoveAuthorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveAuthorBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveAuthorBtn.Location = New System.Drawing.Point(1038, 137)
        Me.RemoveAuthorBtn.Name = "RemoveAuthorBtn"
        Me.RemoveAuthorBtn.Size = New System.Drawing.Size(45, 45)
        Me.RemoveAuthorBtn.TabIndex = 38
        Me.RemoveAuthorBtn.Text = "-"
        Me.RemoveAuthorBtn.UseVisualStyleBackColor = True
        '
        'AddAuthorBtn
        '
        Me.AddAuthorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AddAuthorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddAuthorBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAuthorBtn.Location = New System.Drawing.Point(1038, 74)
        Me.AddAuthorBtn.Name = "AddAuthorBtn"
        Me.AddAuthorBtn.Size = New System.Drawing.Size(45, 45)
        Me.AddAuthorBtn.TabIndex = 37
        Me.AddAuthorBtn.Text = "+"
        Me.AddAuthorBtn.UseVisualStyleBackColor = True
        '
        'AuthorsList
        '
        Me.AuthorsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorsList.FormattingEnabled = True
        Me.AuthorsList.ItemHeight = 20
        Me.AuthorsList.Location = New System.Drawing.Point(772, 125)
        Me.AuthorsList.Name = "AuthorsList"
        Me.AuthorsList.Size = New System.Drawing.Size(233, 144)
        Me.AuthorsList.TabIndex = 36
        '
        'AuthorsCmb
        '
        Me.AuthorsCmb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AuthorsCmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AuthorsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AuthorsCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorsCmb.FormattingEnabled = True
        Me.AuthorsCmb.Location = New System.Drawing.Point(772, 74)
        Me.AuthorsCmb.Name = "AuthorsCmb"
        Me.AuthorsCmb.Size = New System.Drawing.Size(233, 28)
        Me.AuthorsCmb.TabIndex = 35
        '
        'AuthorsLbl
        '
        Me.AuthorsLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AuthorsLbl.AutoSize = True
        Me.AuthorsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorsLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.AuthorsLbl.Location = New System.Drawing.Point(678, 75)
        Me.AuthorsLbl.Name = "AuthorsLbl"
        Me.AuthorsLbl.Size = New System.Drawing.Size(77, 22)
        Me.AuthorsLbl.TabIndex = 34
        Me.AuthorsLbl.Text = "Authors:"
        '
        'DateTimer
        '
        Me.DateTimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimer.Location = New System.Drawing.Point(127, 124)
        Me.DateTimer.Name = "DateTimer"
        Me.DateTimer.Size = New System.Drawing.Size(364, 27)
        Me.DateTimer.TabIndex = 33
        '
        'EditorialCmb
        '
        Me.EditorialCmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditorialCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EditorialCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorialCmb.FormattingEnabled = True
        Me.EditorialCmb.Location = New System.Drawing.Point(127, 76)
        Me.EditorialCmb.Name = "EditorialCmb"
        Me.EditorialCmb.Size = New System.Drawing.Size(216, 28)
        Me.EditorialCmb.TabIndex = 32
        '
        'PageNumberTxt
        '
        Me.PageNumberTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageNumberTxt.Location = New System.Drawing.Point(508, 171)
        Me.PageNumberTxt.Name = "PageNumberTxt"
        Me.PageNumberTxt.Size = New System.Drawing.Size(90, 27)
        Me.PageNumberTxt.TabIndex = 31
        '
        'PageNumberLbl
        '
        Me.PageNumberLbl.AutoSize = True
        Me.PageNumberLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageNumberLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.PageNumberLbl.Location = New System.Drawing.Point(366, 172)
        Me.PageNumberLbl.Name = "PageNumberLbl"
        Me.PageNumberLbl.Size = New System.Drawing.Size(125, 22)
        Me.PageNumberLbl.TabIndex = 30
        Me.PageNumberLbl.Text = "Page Number:"
        '
        'EditionCmb
        '
        Me.EditionCmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EditionCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditionCmb.FormattingEnabled = True
        Me.EditionCmb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.EditionCmb.Location = New System.Drawing.Point(127, 273)
        Me.EditionCmb.Name = "EditionCmb"
        Me.EditionCmb.Size = New System.Drawing.Size(216, 28)
        Me.EditionCmb.TabIndex = 29
        '
        'LanguageCmb
        '
        Me.LanguageCmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LanguageCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LanguageCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanguageCmb.FormattingEnabled = True
        Me.LanguageCmb.Items.AddRange(New Object() {"Inglés", "Chino mandarín", "Hindi", "Español", "Francés", "Árabe estándar moderno", "Bengalí", "Portugués", "Ruso", "Urdu", "Indonesio", "Alemán", "Japonés", "Maratí", "Telugú"})
        Me.LanguageCmb.Location = New System.Drawing.Point(127, 220)
        Me.LanguageCmb.Name = "LanguageCmb"
        Me.LanguageCmb.Size = New System.Drawing.Size(216, 28)
        Me.LanguageCmb.TabIndex = 28
        '
        'ExamplesTxt
        '
        Me.ExamplesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamplesTxt.Location = New System.Drawing.Point(127, 172)
        Me.ExamplesTxt.Name = "ExamplesTxt"
        Me.ExamplesTxt.Size = New System.Drawing.Size(216, 27)
        Me.ExamplesTxt.TabIndex = 27
        '
        'TitleTxt
        '
        Me.TitleTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TitleTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTxt.Location = New System.Drawing.Point(99, 15)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(607, 27)
        Me.TitleTxt.TabIndex = 26
        '
        'LanguageLbl
        '
        Me.LanguageLbl.AutoSize = True
        Me.LanguageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanguageLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.LanguageLbl.Location = New System.Drawing.Point(12, 223)
        Me.LanguageLbl.Name = "LanguageLbl"
        Me.LanguageLbl.Size = New System.Drawing.Size(95, 22)
        Me.LanguageLbl.TabIndex = 25
        Me.LanguageLbl.Text = "Language:"
        '
        'EditionLbl
        '
        Me.EditionLbl.AutoSize = True
        Me.EditionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditionLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.EditionLbl.Location = New System.Drawing.Point(12, 275)
        Me.EditionLbl.Name = "EditionLbl"
        Me.EditionLbl.Size = New System.Drawing.Size(70, 22)
        Me.EditionLbl.TabIndex = 24
        Me.EditionLbl.Text = "Edition:"
        '
        'ExamplesLbl
        '
        Me.ExamplesLbl.AutoSize = True
        Me.ExamplesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamplesLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.ExamplesLbl.Location = New System.Drawing.Point(12, 172)
        Me.ExamplesLbl.Name = "ExamplesLbl"
        Me.ExamplesLbl.Size = New System.Drawing.Size(93, 22)
        Me.ExamplesLbl.TabIndex = 23
        Me.ExamplesLbl.Text = "Examples:"
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.DateLbl.Location = New System.Drawing.Point(12, 125)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(53, 22)
        Me.DateLbl.TabIndex = 22
        Me.DateLbl.Text = "Date:"
        '
        'EditorialLbl
        '
        Me.EditorialLbl.AutoSize = True
        Me.EditorialLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorialLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.EditorialLbl.Location = New System.Drawing.Point(12, 74)
        Me.EditorialLbl.Name = "EditorialLbl"
        Me.EditorialLbl.Size = New System.Drawing.Size(80, 22)
        Me.EditorialLbl.TabIndex = 21
        Me.EditorialLbl.Text = "Editorial:"
        '
        'TitleLbl
        '
        Me.TitleLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.TitleLbl.Location = New System.Drawing.Point(12, 20)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(50, 22)
        Me.TitleLbl.TabIndex = 20
        Me.TitleLbl.Text = "Title:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnNew)
        Me.GroupBox1.Location = New System.Drawing.Point(1281, 204)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(261, 316)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Orange
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnClose.Location = New System.Drawing.Point(32, 239)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(210, 42)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackColor = System.Drawing.Color.Crimson
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnDelete.Location = New System.Drawing.Point(32, 171)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(210, 42)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.Purple
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSave.Location = New System.Drawing.Point(32, 102)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(210, 42)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNew.BackColor = System.Drawing.Color.Green
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.FlatAppearance.BorderSize = 0
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnNew.Location = New System.Drawing.Point(32, 27)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(210, 42)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'GridBook
        '
        Me.GridBook.AllowUserToAddRows = False
        Me.GridBook.AllowUserToDeleteRows = False
        Me.GridBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBook.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridBook.Location = New System.Drawing.Point(46, 12)
        Me.GridBook.Name = "GridBook"
        Me.GridBook.ReadOnly = True
        Me.GridBook.RowHeadersWidth = 51
        Me.GridBook.RowTemplate.Height = 24
        Me.GridBook.Size = New System.Drawing.Size(1496, 155)
        Me.GridBook.TabIndex = 0
        '
        'FormBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1589, 582)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBooks"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridBook As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RemoveAuthorBtn As Button
    Friend WithEvents AddAuthorBtn As Button
    Friend WithEvents AuthorsList As ListBox
    Friend WithEvents AuthorsCmb As ComboBox
    Friend WithEvents AuthorsLbl As Label
    Friend WithEvents DateTimer As DateTimePicker
    Friend WithEvents EditorialCmb As ComboBox
    Friend WithEvents PageNumberTxt As TextBox
    Friend WithEvents PageNumberLbl As Label
    Friend WithEvents EditionCmb As ComboBox
    Friend WithEvents LanguageCmb As ComboBox
    Friend WithEvents ExamplesTxt As TextBox
    Friend WithEvents TitleTxt As TextBox
    Friend WithEvents LanguageLbl As Label
    Friend WithEvents EditionLbl As Label
    Friend WithEvents ExamplesLbl As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents EditorialLbl As Label
    Friend WithEvents TitleLbl As Label
End Class
