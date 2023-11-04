<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookConsult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBookConsult))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LanguageCmb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditorialCmb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCleanFields = New System.Windows.Forms.Button()
        Me.AuthorCmb = New System.Windows.Forms.ComboBox()
        Me.TitleCmb = New System.Windows.Forms.ComboBox()
        Me.LabelFilter = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridBookConsult = New System.Windows.Forms.DataGridView()
        Me.BtnExcel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GridBookConsult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnExcel)
        Me.Panel1.Controls.Add(Me.LanguageCmb)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.EditorialCmb)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnCleanFields)
        Me.Panel1.Controls.Add(Me.AuthorCmb)
        Me.Panel1.Controls.Add(Me.TitleCmb)
        Me.Panel1.Controls.Add(Me.LabelFilter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GridBookConsult)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1571, 583)
        Me.Panel1.TabIndex = 0
        '
        'LanguageCmb
        '
        Me.LanguageCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LanguageCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LanguageCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanguageCmb.FormattingEnabled = True
        Me.LanguageCmb.Items.AddRange(New Object() {"Inglés", "Chino mandarín", "Hindi", "Español", "Francés", "Árabe estándar moderno", "Bengalí", "Portugués", "Ruso", "Urdu", "Indonesio", "Alemán", "Japonés", "Maratí", "Telugú"})
        Me.LanguageCmb.Location = New System.Drawing.Point(161, 522)
        Me.LanguageCmb.Name = "LanguageCmb"
        Me.LanguageCmb.Size = New System.Drawing.Size(423, 33)
        Me.LanguageCmb.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Language:"
        '
        'EditorialCmb
        '
        Me.EditorialCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EditorialCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EditorialCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditorialCmb.FormattingEnabled = True
        Me.EditorialCmb.Location = New System.Drawing.Point(161, 471)
        Me.EditorialCmb.Name = "EditorialCmb"
        Me.EditorialCmb.Size = New System.Drawing.Size(423, 33)
        Me.EditorialCmb.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Editorial:"
        '
        'BtnCleanFields
        '
        Me.BtnCleanFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCleanFields.BackColor = System.Drawing.Color.Green
        Me.BtnCleanFields.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCleanFields.FlatAppearance.BorderSize = 0
        Me.BtnCleanFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCleanFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCleanFields.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnCleanFields.Location = New System.Drawing.Point(1310, 461)
        Me.BtnCleanFields.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCleanFields.Name = "BtnCleanFields"
        Me.BtnCleanFields.Size = New System.Drawing.Size(210, 50)
        Me.BtnCleanFields.TabIndex = 10
        Me.BtnCleanFields.Text = "Clean Filters"
        Me.BtnCleanFields.UseVisualStyleBackColor = False
        '
        'AuthorCmb
        '
        Me.AuthorCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AuthorCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AuthorCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorCmb.FormattingEnabled = True
        Me.AuthorCmb.Location = New System.Drawing.Point(161, 409)
        Me.AuthorCmb.Name = "AuthorCmb"
        Me.AuthorCmb.Size = New System.Drawing.Size(423, 33)
        Me.AuthorCmb.TabIndex = 7
        '
        'TitleCmb
        '
        Me.TitleCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TitleCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TitleCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleCmb.FormattingEnabled = True
        Me.TitleCmb.Location = New System.Drawing.Point(161, 347)
        Me.TitleCmb.Name = "TitleCmb"
        Me.TitleCmb.Size = New System.Drawing.Size(423, 33)
        Me.TitleCmb.TabIndex = 6
        '
        'LabelFilter
        '
        Me.LabelFilter.AutoSize = True
        Me.LabelFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFilter.ForeColor = System.Drawing.Color.White
        Me.LabelFilter.Location = New System.Drawing.Point(29, 412)
        Me.LabelFilter.Name = "LabelFilter"
        Me.LabelFilter.Size = New System.Drawing.Size(83, 25)
        Me.LabelFilter.TabIndex = 3
        Me.LabelFilter.Text = "Author:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title:"
        '
        'GridBookConsult
        '
        Me.GridBookConsult.AllowUserToAddRows = False
        Me.GridBookConsult.AllowUserToDeleteRows = False
        Me.GridBookConsult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBookConsult.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridBookConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBookConsult.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridBookConsult.Location = New System.Drawing.Point(24, 58)
        Me.GridBookConsult.Name = "GridBookConsult"
        Me.GridBookConsult.ReadOnly = True
        Me.GridBookConsult.RowHeadersWidth = 51
        Me.GridBookConsult.RowTemplate.Height = 24
        Me.GridBookConsult.Size = New System.Drawing.Size(1496, 240)
        Me.GridBookConsult.TabIndex = 1
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.BackColor = System.Drawing.Color.Transparent
        Me.BtnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcel.FlatAppearance.BorderSize = 0
        Me.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.Location = New System.Drawing.Point(1444, 11)
        Me.BtnExcel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(76, 42)
        Me.BtnExcel.TabIndex = 15
        Me.BtnExcel.UseVisualStyleBackColor = False
        '
        'FormBookConsult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1571, 583)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBookConsult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBookSearch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridBookConsult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridBookConsult As DataGridView
    Friend WithEvents LabelFilter As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AuthorCmb As ComboBox
    Friend WithEvents TitleCmb As ComboBox
    Friend WithEvents BtnCleanFields As Button
    Friend WithEvents LanguageCmb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EditorialCmb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnExcel As Button
End Class
