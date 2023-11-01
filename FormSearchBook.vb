Public Class FormSearchBook

    Private Sub FormSearchBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Showdata()
        LoadCombobox()
    End Sub

    Private Sub LoadCombobox()
        ' Define and execute the SQL query to select countries
        Try
            Dim searchbokDao As New SearchBookDAO()
            searchbokDao.LoadComboBox()
            If searchbokDao.dataSet.Tables(0).Rows.Count > 0 Then
                ' Configure the ComboBox with the query results
                With Me.CountryCmb
                    .DataSource = Nothing
                    .Items.Clear()
                    .DataSource = searchbokDao.dataSet.Tables(0)
                    .DisplayMember = "nombre_pais"
                    .ValueMember = "cod_pais"
                    .SelectedIndex = -1
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Showdata()
        Try
            Dim bookDao As New BookDAO()
            bookDao.ConsultBook()
            GridSearch.DataSource = bookDao.dataSet.Tables(0)
            GridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If CountryCmb.SelectedIndex <> -1 Then
            Dim pais As Integer = CInt(CountryCmb.SelectedValue)
            Try
                Dim searchbookDao As New SearchBookDAO()
                searchbookDao.SearchBook(pais)
                GridSearch.DataSource = searchbookDao.dataSet.Tables(0)
                GridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
End Class