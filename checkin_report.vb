Public Class checkin_report

    Private Sub checkin_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'databaseDataSet.tblTransaction' table. You can move, or remove it, as needed.
        Me.tblTransactionTableAdapter.Fill(Me.databaseDataSet.tblTransaction)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class