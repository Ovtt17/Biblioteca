﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearchBook
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CountryLbl = New System.Windows.Forms.Label()
        Me.CountryCmb = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.GridSearch = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.GridSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.CountryLbl)
        Me.Panel1.Controls.Add(Me.CountryCmb)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.GridSearch)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 485)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Orange
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnClose.Location = New System.Drawing.Point(654, 342)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(130, 37)
        Me.BtnClose.TabIndex = 13
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'CountryLbl
        '
        Me.CountryLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CountryLbl.AutoSize = True
        Me.CountryLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.CountryLbl.Location = New System.Drawing.Point(115, 294)
        Me.CountryLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CountryLbl.Name = "CountryLbl"
        Me.CountryLbl.Size = New System.Drawing.Size(68, 20)
        Me.CountryLbl.TabIndex = 12
        Me.CountryLbl.Text = "Country:"
        '
        'CountryCmb
        '
        Me.CountryCmb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CountryCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryCmb.FormattingEnabled = True
        Me.CountryCmb.Items.AddRange(New Object() {"NICARAGUA", "EL SALVADOR", "COSTA RICA"})
        Me.CountryCmb.Location = New System.Drawing.Point(221, 291)
        Me.CountryCmb.Margin = New System.Windows.Forms.Padding(2)
        Me.CountryCmb.Name = "CountryCmb"
        Me.CountryCmb.Size = New System.Drawing.Size(370, 28)
        Me.CountryCmb.TabIndex = 11
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackColor = System.Drawing.Color.Green
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnSearch.Location = New System.Drawing.Point(654, 284)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(130, 34)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'GridSearch
        '
        Me.GridSearch.AllowUserToAddRows = False
        Me.GridSearch.AllowUserToDeleteRows = False
        Me.GridSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSearch.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridSearch.Location = New System.Drawing.Point(12, 11)
        Me.GridSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.GridSearch.Name = "GridSearch"
        Me.GridSearch.ReadOnly = True
        Me.GridSearch.RowHeadersWidth = 51
        Me.GridSearch.RowTemplate.Height = 24
        Me.GridSearch.Size = New System.Drawing.Size(988, 185)
        Me.GridSearch.TabIndex = 2
        '
        'FormSearchBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 434)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSearchBook"
        Me.Text = "FormSearchBook"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridSearch As DataGridView
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CountryCmb As ComboBox
    Friend WithEvents CountryLbl As Label
    Friend WithEvents BtnClose As Button
End Class