Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_StocksDB' table. You can move, or remove it, as needed.
        Me.OMSys_StocksDBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_StocksDB)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class