<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoan
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
        Me.TicketTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeliveredCmb = New System.Windows.Forms.ComboBox()
        Me.IdLibrarianTxt = New System.Windows.Forms.TextBox()
        Me.DateDue = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateLoan = New System.Windows.Forms.DateTimePicker()
        Me.DeliveredLbl = New System.Windows.Forms.Label()
        Me.TypeLoanCmb = New System.Windows.Forms.ComboBox()
        Me.IdUserTxt = New System.Windows.Forms.TextBox()
        Me.IdBookTxt = New System.Windows.Forms.TextBox()
        Me.TypeLoanLbl = New System.Windows.Forms.Label()
        Me.LibrarianLbl = New System.Windows.Forms.Label()
        Me.UserLbl = New System.Windows.Forms.Label()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.BookIdLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GridLoan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GridLoan)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1589, 582)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TicketTxt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DeliveredCmb)
        Me.Panel2.Controls.Add(Me.IdLibrarianTxt)
        Me.Panel2.Controls.Add(Me.DateDue)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DateLoan)
        Me.Panel2.Controls.Add(Me.DeliveredLbl)
        Me.Panel2.Controls.Add(Me.TypeLoanCmb)
        Me.Panel2.Controls.Add(Me.IdUserTxt)
        Me.Panel2.Controls.Add(Me.IdBookTxt)
        Me.Panel2.Controls.Add(Me.TypeLoanLbl)
        Me.Panel2.Controls.Add(Me.LibrarianLbl)
        Me.Panel2.Controls.Add(Me.UserLbl)
        Me.Panel2.Controls.Add(Me.DateLbl)
        Me.Panel2.Controls.Add(Me.BookIdLbl)
        Me.Panel2.Location = New System.Drawing.Point(46, 204)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1095, 316)
        Me.Panel2.TabIndex = 21
        '
        'TicketTxt
        '
        Me.TicketTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketTxt.Location = New System.Drawing.Point(779, 72)
        Me.TicketTxt.Name = "TicketTxt"
        Me.TicketTxt.Size = New System.Drawing.Size(216, 27)
        Me.TicketTxt.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(673, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Ticket $:"
        '
        'DeliveredCmb
        '
        Me.DeliveredCmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeliveredCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeliveredCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveredCmb.FormattingEnabled = True
        Me.DeliveredCmb.Items.AddRange(New Object() {"Yes", "No"})
        Me.DeliveredCmb.Location = New System.Drawing.Point(779, 28)
        Me.DeliveredCmb.Name = "DeliveredCmb"
        Me.DeliveredCmb.Size = New System.Drawing.Size(145, 28)
        Me.DeliveredCmb.TabIndex = 42
        '
        'IdLibrarianTxt
        '
        Me.IdLibrarianTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLibrarianTxt.Location = New System.Drawing.Point(127, 270)
        Me.IdLibrarianTxt.Name = "IdLibrarianTxt"
        Me.IdLibrarianTxt.Size = New System.Drawing.Size(216, 27)
        Me.IdLibrarianTxt.TabIndex = 41
        '
        'DateDue
        '
        Me.DateDue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDue.Location = New System.Drawing.Point(127, 125)
        Me.DateDue.Name = "DateDue"
        Me.DateDue.Size = New System.Drawing.Size(364, 27)
        Me.DateDue.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Due Date:"
        '
        'DateLoan
        '
        Me.DateLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLoan.Location = New System.Drawing.Point(127, 70)
        Me.DateLoan.Name = "DateLoan"
        Me.DateLoan.Size = New System.Drawing.Size(364, 27)
        Me.DateLoan.TabIndex = 33
        '
        'DeliveredLbl
        '
        Me.DeliveredLbl.AutoSize = True
        Me.DeliveredLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveredLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.DeliveredLbl.Location = New System.Drawing.Point(673, 28)
        Me.DeliveredLbl.Name = "DeliveredLbl"
        Me.DeliveredLbl.Size = New System.Drawing.Size(91, 22)
        Me.DeliveredLbl.TabIndex = 30
        Me.DeliveredLbl.Text = "Delivered:"
        '
        'TypeLoanCmb
        '
        Me.TypeLoanCmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TypeLoanCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeLoanCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLoanCmb.FormattingEnabled = True
        Me.TypeLoanCmb.Items.AddRange(New Object() {"Individual", "Interlibrary", "Intercampus", "Network", "Collective"})
        Me.TypeLoanCmb.Location = New System.Drawing.Point(127, 220)
        Me.TypeLoanCmb.Name = "TypeLoanCmb"
        Me.TypeLoanCmb.Size = New System.Drawing.Size(216, 28)
        Me.TypeLoanCmb.TabIndex = 28
        '
        'IdUserTxt
        '
        Me.IdUserTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdUserTxt.Location = New System.Drawing.Point(127, 172)
        Me.IdUserTxt.Name = "IdUserTxt"
        Me.IdUserTxt.Size = New System.Drawing.Size(216, 27)
        Me.IdUserTxt.TabIndex = 27
        '
        'IdBookTxt
        '
        Me.IdBookTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IdBookTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdBookTxt.Location = New System.Drawing.Point(127, 20)
        Me.IdBookTxt.Name = "IdBookTxt"
        Me.IdBookTxt.Size = New System.Drawing.Size(216, 27)
        Me.IdBookTxt.TabIndex = 26
        '
        'TypeLoanLbl
        '
        Me.TypeLoanLbl.AutoSize = True
        Me.TypeLoanLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLoanLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.TypeLoanLbl.Location = New System.Drawing.Point(12, 223)
        Me.TypeLoanLbl.Name = "TypeLoanLbl"
        Me.TypeLoanLbl.Size = New System.Drawing.Size(101, 22)
        Me.TypeLoanLbl.TabIndex = 25
        Me.TypeLoanLbl.Text = "Type Loan:"
        '
        'LibrarianLbl
        '
        Me.LibrarianLbl.AutoSize = True
        Me.LibrarianLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibrarianLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.LibrarianLbl.Location = New System.Drawing.Point(12, 275)
        Me.LibrarianLbl.Name = "LibrarianLbl"
        Me.LibrarianLbl.Size = New System.Drawing.Size(107, 22)
        Me.LibrarianLbl.TabIndex = 24
        Me.LibrarianLbl.Text = "ID Librarian:"
        '
        'UserLbl
        '
        Me.UserLbl.AutoSize = True
        Me.UserLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.UserLbl.Location = New System.Drawing.Point(12, 172)
        Me.UserLbl.Name = "UserLbl"
        Me.UserLbl.Size = New System.Drawing.Size(75, 22)
        Me.UserLbl.TabIndex = 23
        Me.UserLbl.Text = "ID User:"
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.DateLbl.Location = New System.Drawing.Point(12, 71)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(98, 22)
        Me.DateLbl.TabIndex = 22
        Me.DateLbl.Text = "Loan Date:"
        '
        'BookIdLbl
        '
        Me.BookIdLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BookIdLbl.AutoSize = True
        Me.BookIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookIdLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.BookIdLbl.Location = New System.Drawing.Point(12, 20)
        Me.BookIdLbl.Name = "BookIdLbl"
        Me.BookIdLbl.Size = New System.Drawing.Size(78, 22)
        Me.BookIdLbl.TabIndex = 20
        Me.BookIdLbl.Text = "ID Book:"
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
        'GridLoan
        '
        Me.GridLoan.AllowUserToAddRows = False
        Me.GridLoan.AllowUserToDeleteRows = False
        Me.GridLoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLoan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLoan.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridLoan.Location = New System.Drawing.Point(46, 12)
        Me.GridLoan.Name = "GridLoan"
        Me.GridLoan.ReadOnly = True
        Me.GridLoan.RowHeadersWidth = 51
        Me.GridLoan.RowTemplate.Height = 24
        Me.GridLoan.Size = New System.Drawing.Size(1496, 155)
        Me.GridLoan.TabIndex = 0
        '
        'FormLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1589, 582)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLoan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridLoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateLoan As DateTimePicker
    Friend WithEvents DeliveredLbl As Label
    Friend WithEvents TypeLoanCmb As ComboBox
    Friend WithEvents IdUserTxt As TextBox
    Friend WithEvents IdBookTxt As TextBox
    Friend WithEvents TypeLoanLbl As Label
    Friend WithEvents LibrarianLbl As Label
    Friend WithEvents UserLbl As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents BookIdLbl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents GridLoan As DataGridView
    Friend WithEvents DateDue As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents IdLibrarianTxt As TextBox
    Friend WithEvents DeliveredCmb As ComboBox
    Friend WithEvents TicketTxt As TextBox
    Friend WithEvents Label2 As Label
End Class
