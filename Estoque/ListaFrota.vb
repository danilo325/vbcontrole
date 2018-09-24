Public Class ListaFrota
    Dim dados As New BdClass

    Private Sub ListaFrota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        dgv_veiculos.DataSource = dados.Pesquisa("SELECT * FROM Veiculos")
    End Sub

    Private Sub dgv_veiculos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_veiculos.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        NovoAbastecimento.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ListaAbastecimento.Visible = True
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) 

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListaDespesaVeiculo.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListaManutencao.Visible = True
    End Sub
End Class