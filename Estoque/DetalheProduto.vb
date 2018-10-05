Public Class DetalheProduto
    Dim dados As New BdClass
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lbl_unidade.Click

    End Sub

    Private Sub DetalheProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        Dim vendido, comprado As DataTable
        vendido = dados.Pesquisa("SELECT IdRomaneio , DataRomaneio FROM romaneio WHERE DataRomaneio BETWEEN #" & Format(Date.Today.AddDays(-30), "MMyyyy") & "# AND #" & Format(Date.Today, "MMyyyy") & "#)")
        comprado = dados.Pesquisa("SELECT IdCompra,DataCompra FROM compraWHERE DataCompra BETWEEN #" & Format(Date.Today.AddDays(-30), "MMyyyy") & "# AND #" & Format(Date.Today, "MMyyyy") & "#)")



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class