Public Class RelProdutodia
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'SaidadeProdutosDia.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
        Me.DataTable1TableAdapter.Fill(Me.SaidadeProdutosDia.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class