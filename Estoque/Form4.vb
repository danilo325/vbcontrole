Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet2.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
        Me.DataTable1TableAdapter.Fill(Me.DataSet2.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class