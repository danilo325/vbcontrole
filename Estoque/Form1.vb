Public Class Form1
    Private mDataSet As DataSet
    Private dados As New BdClass
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        'TODO: esta linha de código carrega dados na tabela 'LiderBancoDadosDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
        '   Me.ProdutoTableAdapter.Fill(Me.LiderBancoDadosDataSet.produto)
        mDataSet = dados.geraDataSet("SELECT * FROM produto", New DataSet("produtos"))
        Dim info As List(Of Class1) = c.getDados
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("numero", Format(Date.Today, "ddMMyy") & New Random().Next(0, 99)))

        ReportViewer1.LocalReport.DataSources.Clear()
        Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource("Cargas", info)
        ReportViewer1.LocalReport.DataSources.Add(ds)
        ds.Value = info
        ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()

        '   Me.ReportViewer1.
        '  Me.ReportViewer1.RefreshReport()

        Label1.Text = Date.Today.ToShortDateString.Replace("/", "") & New Random().Next(0, 99)
    End Sub
End Class