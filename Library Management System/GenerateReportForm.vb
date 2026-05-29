Imports System.Data
Imports SqlCommand = Microsoft.Data.Sqlite.SqliteCommand
Imports SqlConnection = Microsoft.Data.Sqlite.SqliteConnection
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class GenerateReportForm
    Private MyCn As New SqlConnection(Database.ConnectionString)

    Private Sub GenerateReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturnedData()
    End Sub

    Private Sub LoadReturnedData()
        Try
            MyCn.Open()

            Dim query As String = "SELECT borrowing_id, borrower_id, borrower_name, book_id, book_name, price, return_date FROM returned WHERE return_date BETWEEN @startDate AND @endDate"

            Dim cmd As New SqlCommand(query, MyCn)
            cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.Date)
            cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1))

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvReturned.DataSource = table

            Dim total As Decimal = 0
            For Each row As DataRow In table.Rows
                total += Convert.ToDecimal(row("price"))
            Next
            lblTotalProfit.Text = "TOTAL PROFIT: $" & total.ToString("F2")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MyCn.Close()
        End Try
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Try
            Dim doc As New Document()
            Dim savePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReturnedBooksReport.pdf")
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            doc.Add(New Paragraph("Returned Books Report", titleFont))
            doc.Add(New Paragraph(" "))

            Dim dateRangeFont = FontFactory.GetFont(FontFactory.HELVETICA, 12)
            doc.Add(New Paragraph("Report from " & dtpStartDate.Value.ToString("yyyy-MM-dd") & " to " & dtpEndDate.Value.ToString("yyyy-MM-dd"), dateRangeFont))
            doc.Add(New Paragraph(" "))

            Dim table As New PdfPTable(dgvReturned.Columns.Count)

            For Each column As DataGridViewColumn In dgvReturned.Columns
                table.AddCell(New Phrase(column.HeaderText))
            Next

            For Each row As DataGridViewRow In dgvReturned.Rows
                If Not row.IsNewRow Then
                    For Each cell As DataGridViewCell In row.Cells
                        table.AddCell(New Phrase(cell.Value?.ToString()))
                    Next
                End If
            Next

            doc.Add(table)
            doc.Add(New Paragraph(" "))

            Dim profitFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            doc.Add(New Paragraph(lblTotalProfit.Text, profitFont))

            doc.Close()

            MessageBox.Show("PDF report generated on Desktop!")
        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message)
        End Try
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReturnedData()
    End Sub
End Class
