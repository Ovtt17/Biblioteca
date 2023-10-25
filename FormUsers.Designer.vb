<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsers
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.codidenttxt = New System.Windows.Forms.TextBox()
        Me.codIdetlb = New System.Windows.Forms.Label()
        Me.statuscmb = New System.Windows.Forms.ComboBox()
        Me.sexcmb = New System.Windows.Forms.ComboBox()
        Me.studytxt = New System.Windows.Forms.TextBox()
        Me.studylb = New System.Windows.Forms.Label()
        Me.statuslb = New System.Windows.Forms.Label()
        Me.sexlb = New System.Windows.Forms.Label()
        Me.Datelb = New System.Windows.Forms.Label()
        Me.Addrlb = New System.Windows.Forms.Label()
        Me.addrtxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.name2txt = New System.Windows.Forms.TextBox()
        Me.phonelb = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.lastnamelb = New System.Windows.Forms.Label()
        Me.namelb = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GridUser = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GridUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1589, 582)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.codidenttxt)
        Me.Panel2.Controls.Add(Me.codIdetlb)
        Me.Panel2.Controls.Add(Me.statuscmb)
        Me.Panel2.Controls.Add(Me.sexcmb)
        Me.Panel2.Controls.Add(Me.studytxt)
        Me.Panel2.Controls.Add(Me.studylb)
        Me.Panel2.Controls.Add(Me.statuslb)
        Me.Panel2.Controls.Add(Me.sexlb)
        Me.Panel2.Controls.Add(Me.Datelb)
        Me.Panel2.Controls.Add(Me.Addrlb)
        Me.Panel2.Controls.Add(Me.addrtxt)
        Me.Panel2.Controls.Add(Me.phonetxt)
        Me.Panel2.Controls.Add(Me.name2txt)
        Me.Panel2.Controls.Add(Me.phonelb)
        Me.Panel2.Controls.Add(Me.NameTxt)
        Me.Panel2.Controls.Add(Me.lastnamelb)
        Me.Panel2.Controls.Add(Me.namelb)
        Me.Panel2.Location = New System.Drawing.Point(72, 232)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 316)
        Me.Panel2.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(603, 90)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(307, 26)
        Me.DateTimePicker1.TabIndex = 61
        '
        'codidenttxt
        '
        Me.codidenttxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.codidenttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codidenttxt.Location = New System.Drawing.Point(177, 54)
        Me.codidenttxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.codidenttxt.Name = "codidenttxt"
        Me.codidenttxt.Size = New System.Drawing.Size(234, 30)
        Me.codidenttxt.TabIndex = 60
        '
        'codIdetlb
        '
        Me.codIdetlb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.codIdetlb.AutoSize = True
        Me.codIdetlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codIdetlb.ForeColor = System.Drawing.SystemColors.Window
        Me.codIdetlb.Location = New System.Drawing.Point(62, 57)
        Me.codIdetlb.Name = "codIdetlb"
        Me.codIdetlb.Size = New System.Drawing.Size(37, 25)
        Me.codIdetlb.TabIndex = 59
        Me.codIdetlb.Text = "ID:"
        '
        'statuscmb
        '
        Me.statuscmb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statuscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statuscmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuscmb.FormattingEnabled = True
        Me.statuscmb.Items.AddRange(New Object() {"S", "C"})
        Me.statuscmb.Location = New System.Drawing.Point(629, 184)
        Me.statuscmb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.statuscmb.Name = "statuscmb"
        Me.statuscmb.Size = New System.Drawing.Size(259, 33)
        Me.statuscmb.TabIndex = 58
        '
        'sexcmb
        '
        Me.sexcmb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sexcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexcmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexcmb.FormattingEnabled = True
        Me.sexcmb.Items.AddRange(New Object() {"M", "F"})
        Me.sexcmb.Location = New System.Drawing.Point(629, 134)
        Me.sexcmb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sexcmb.Name = "sexcmb"
        Me.sexcmb.Size = New System.Drawing.Size(259, 33)
        Me.sexcmb.TabIndex = 57
        '
        'studytxt
        '
        Me.studytxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studytxt.Location = New System.Drawing.Point(629, 243)
        Me.studytxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studytxt.Name = "studytxt"
        Me.studytxt.Size = New System.Drawing.Size(259, 30)
        Me.studytxt.TabIndex = 56
        '
        'studylb
        '
        Me.studylb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studylb.AutoSize = True
        Me.studylb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studylb.ForeColor = System.Drawing.SystemColors.Window
        Me.studylb.Location = New System.Drawing.Point(488, 248)
        Me.studylb.Name = "studylb"
        Me.studylb.Size = New System.Drawing.Size(133, 25)
        Me.studylb.TabIndex = 55
        Me.studylb.Text = "Study Centro:"
        '
        'statuslb
        '
        Me.statuslb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statuslb.AutoSize = True
        Me.statuslb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslb.ForeColor = System.Drawing.SystemColors.Window
        Me.statuslb.Location = New System.Drawing.Point(488, 192)
        Me.statuslb.Name = "statuslb"
        Me.statuslb.Size = New System.Drawing.Size(116, 25)
        Me.statuslb.TabIndex = 54
        Me.statuslb.Text = "Civil Status:"
        '
        'sexlb
        '
        Me.sexlb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sexlb.AutoSize = True
        Me.sexlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexlb.ForeColor = System.Drawing.SystemColors.Window
        Me.sexlb.Location = New System.Drawing.Point(494, 137)
        Me.sexlb.Name = "sexlb"
        Me.sexlb.Size = New System.Drawing.Size(53, 25)
        Me.sexlb.TabIndex = 53
        Me.sexlb.Text = "Sex:"
        '
        'Datelb
        '
        Me.Datelb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Datelb.AutoSize = True
        Me.Datelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelb.ForeColor = System.Drawing.SystemColors.Window
        Me.Datelb.Location = New System.Drawing.Point(494, 90)
        Me.Datelb.Name = "Datelb"
        Me.Datelb.Size = New System.Drawing.Size(95, 25)
        Me.Datelb.TabIndex = 52
        Me.Datelb.Text = "Brithdate:"
        '
        'Addrlb
        '
        Me.Addrlb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Addrlb.AutoSize = True
        Me.Addrlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addrlb.ForeColor = System.Drawing.SystemColors.Window
        Me.Addrlb.Location = New System.Drawing.Point(494, 44)
        Me.Addrlb.Name = "Addrlb"
        Me.Addrlb.Size = New System.Drawing.Size(91, 25)
        Me.Addrlb.TabIndex = 51
        Me.Addrlb.Text = "Address:"
        '
        'addrtxt
        '
        Me.addrtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addrtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addrtxt.Location = New System.Drawing.Point(629, 44)
        Me.addrtxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addrtxt.Name = "addrtxt"
        Me.addrtxt.Size = New System.Drawing.Size(259, 30)
        Me.addrtxt.TabIndex = 50
        '
        'phonetxt
        '
        Me.phonetxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.phonetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonetxt.Location = New System.Drawing.Point(177, 215)
        Me.phonetxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(234, 30)
        Me.phonetxt.TabIndex = 49
        '
        'name2txt
        '
        Me.name2txt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.name2txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name2txt.Location = New System.Drawing.Point(177, 161)
        Me.name2txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.name2txt.Name = "name2txt"
        Me.name2txt.Size = New System.Drawing.Size(234, 30)
        Me.name2txt.TabIndex = 48
        '
        'phonelb
        '
        Me.phonelb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phonelb.AutoSize = True
        Me.phonelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonelb.ForeColor = System.Drawing.SystemColors.Window
        Me.phonelb.Location = New System.Drawing.Point(68, 215)
        Me.phonelb.Name = "phonelb"
        Me.phonelb.Size = New System.Drawing.Size(75, 25)
        Me.phonelb.TabIndex = 47
        Me.phonelb.Text = "Phone:"
        '
        'NameTxt
        '
        Me.NameTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(177, 108)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(234, 30)
        Me.NameTxt.TabIndex = 46
        '
        'lastnamelb
        '
        Me.lastnamelb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastnamelb.AutoSize = True
        Me.lastnamelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnamelb.ForeColor = System.Drawing.SystemColors.Window
        Me.lastnamelb.Location = New System.Drawing.Point(62, 164)
        Me.lastnamelb.Name = "lastnamelb"
        Me.lastnamelb.Size = New System.Drawing.Size(112, 25)
        Me.lastnamelb.TabIndex = 45
        Me.lastnamelb.Text = "Last Name:"
        '
        'namelb
        '
        Me.namelb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.namelb.AutoSize = True
        Me.namelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelb.ForeColor = System.Drawing.SystemColors.Window
        Me.namelb.Location = New System.Drawing.Point(62, 113)
        Me.namelb.Name = "namelb"
        Me.namelb.Size = New System.Drawing.Size(112, 25)
        Me.namelb.TabIndex = 44
        Me.namelb.Text = "First Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnNew)
        Me.GroupBox1.Location = New System.Drawing.Point(1287, 232)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(279, 316)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Orange
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnClose.Location = New System.Drawing.Point(28, 243)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(228, 42)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackColor = System.Drawing.Color.Crimson
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnDelete.Location = New System.Drawing.Point(28, 175)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(228, 42)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.Purple
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSave.Location = New System.Drawing.Point(28, 106)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(228, 42)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNew.BackColor = System.Drawing.Color.Green
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnNew.Location = New System.Drawing.Point(28, 31)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(228, 42)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'GridUser
        '
        Me.GridUser.AllowUserToAddRows = False
        Me.GridUser.AllowUserToDeleteRows = False
        Me.GridUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUser.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridUser.Location = New System.Drawing.Point(25, 11)
        Me.GridUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridUser.Name = "GridUser"
        Me.GridUser.ReadOnly = True
        Me.GridUser.RowHeadersWidth = 51
        Me.GridUser.RowTemplate.Height = 24
        Me.GridUser.Size = New System.Drawing.Size(1541, 191)
        Me.GridUser.TabIndex = 24
        '
        'FormUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1589, 582)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUsers"
        Me.Text = "FormUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents GridUser As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents codidenttxt As TextBox
    Friend WithEvents codIdetlb As Label
    Friend WithEvents statuscmb As ComboBox
    Friend WithEvents sexcmb As ComboBox
    Friend WithEvents studytxt As TextBox
    Friend WithEvents studylb As Label
    Friend WithEvents statuslb As Label
    Friend WithEvents sexlb As Label
    Friend WithEvents Datelb As Label
    Friend WithEvents Addrlb As Label
    Friend WithEvents addrtxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents name2txt As TextBox
    Friend WithEvents phonelb As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents lastnamelb As Label
    Friend WithEvents namelb As Label
End Class
