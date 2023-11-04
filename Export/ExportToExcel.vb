Imports Microsoft.Office.Interop
Public Class ExportToExcel
    Public Sub ExportData(ByVal dataGridView As DataGridView)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("sheet1"), Excel.Worksheet)

        For i = 0 To dataGridView.RowCount - 1
            For j = 0 To dataGridView.ColumnCount - 1
                For k As Integer = 1 To dataGridView.Columns.Count
                    xlWorkSheet.Cells(1, k) = dataGridView.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dataGridView.Rows(i).Cells(j).Value.ToString()
                Next
            Next
        Next

        CType(xlWorkSheet.Rows(1), Excel.Range).Font.Bold = True
        CType(xlWorkSheet.Rows(1), Excel.Range).HorizontalAlignment = 3
        CType(xlWorkSheet.Columns, Excel.Range).AutoFit()

        xlWorkSheet.Columns.AutoFit()
        ' Crear un SaveFileDialog y establecer sus propiedades
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "Excel files (*.xlsx)|*.xlsx",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            xlWorkSheet.SaveAs(saveFileDialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlWorkSheet)

            MsgBox("You can find the file at " & saveFileDialog.FileName)
        End If
    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class
