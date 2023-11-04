Public Class FormBookConsult
    Private Sub FormBookConsult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandlers()
        Dim sql = "call nombre_libros()"
        LoadAndConfigureComboBox(Me.TitleCmb, sql, "titulo", "cod_libro")
        sql = "call nombre_autores()"
        LoadAndConfigureComboBox(Me.AuthorCmb, sql, "nombre_autor", "cod_autor")
        sql = "call nombre_editoriales()"
        LoadAndConfigureComboBox(Me.EditorialCmb, sql, "nombre_editorial", "cod_editorial")
        AddHandlers()
        ShowData()
    End Sub
    Private Sub RemoveHandlers()
        RemoveHandler TitleCmb.SelectedIndexChanged, AddressOf TitleCmb_SelectedIndexChanged
    End Sub

    Private Sub AddHandlers()
        AddHandler TitleCmb.SelectedIndexChanged, AddressOf TitleCmb_SelectedIndexChanged
    End Sub
    Private Sub ShowData()
        Try
            Dim bookDao As New BookDAO()
            bookDao.ConsultBook()
            GridBookConsult.DataSource = bookDao.dataSet.Tables(0)
            GridBookConsult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadAndConfigureComboBox(comboBox As ComboBox, sql As String, displayMember As String, valueMember As String)
        Try

            Dim bookFilteredDAO As New BooksConsultDAO()
            bookFilteredDAO.LoadCombos(sql)
            If bookFilteredDAO.dataSet.Tables(0).Rows.Count > 0 Then
                ConfigurarComboBox(comboBox, bookFilteredDAO.dataSet.Tables(0), displayMember, valueMember)
            End If

        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub
    Private Sub ConfigurarComboBox(comboBox As ComboBox, tabla As DataTable, displayMember As String, valueMember As String)
        With comboBox
            .DataSource = Nothing
            .Items.Clear()
            .DataSource = tabla
            .DisplayMember = displayMember
            .ValueMember = valueMember
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnCleanFields_Click(sender As Object, e As EventArgs) Handles BtnCleanFields.Click
        RemoveHandlers()
        TitleCmb.SelectedIndex = -1
        AuthorCmb.SelectedIndex = -1
        EditorialCmb.SelectedIndex = -1
        AddHandlers()
        ShowData()
    End Sub

    Private Sub TitleCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TitleCmb.SelectedIndexChanged, LanguageCmb.SelectedIndexChanged, EditorialCmb.SelectedIndexChanged, AuthorCmb.SelectedIndexChanged
        SearchBook(False)
    End Sub

    Private Sub TitleCmb_TextChanged(sender As Object, e As EventArgs) Handles TitleCmb.TextChanged, LanguageCmb.TextChanged, EditorialCmb.TextChanged, AuthorCmb.TextChanged
        SearchBook(True)
    End Sub
    Private Sub SearchBook(v As Boolean)
        Try
            Dim dao As New BooksConsultDAO()
            Dim bookConsult As New BookConsult()
            Dim rowViewTitle As DataRowView = CType(TitleCmb.SelectedItem, DataRowView)
            Dim rowViewAuthor As DataRowView = CType(AuthorCmb.SelectedItem, DataRowView)
            Dim rowViewEditorial As DataRowView = CType(EditorialCmb.SelectedItem, DataRowView)

            ' si el texto cambia, quiere decir que debemos obtener el texto
            If (v) Then
                bookConsult.Title = If(TitleCmb.Text, String.Empty)
                bookConsult.Author = If(AuthorCmb.Text, String.Empty)
                bookConsult.Editorial = If(EditorialCmb.Text, String.Empty)
                bookConsult.Language = If(LanguageCmb.Text, String.Empty)
            Else
                ' en caso de que sea falso, tenemos que obtener lo que arroja el combobox
                bookConsult.Title = If(rowViewTitle IsNot Nothing, rowViewTitle("titulo").ToString(), String.Empty)
                bookConsult.Author = If(rowViewAuthor IsNot Nothing, rowViewAuthor("nombre_autor").ToString(), String.Empty)
                bookConsult.Editorial = If(rowViewEditorial IsNot Nothing, rowViewEditorial("nombre_editorial").ToString(), String.Empty)
                bookConsult.Language = If(LanguageCmb.SelectedIndex <> -1, LanguageCmb.SelectedItem.ToString(), String.Empty)
            End If

            dao.ConsultBooks(bookConsult)
            GridBookConsult.DataSource = Nothing
            GridBookConsult.DataSource = dao.dataSet.Tables(0)
            GridBookConsult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("General error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Dim export As New ExportToExcel()
        export.ExportData(GridBookConsult)
    End Sub
End Class