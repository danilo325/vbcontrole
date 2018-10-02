Public Class novaPerda
    Dim dado As New BdClass
    Dim dicpro As New Dictionary(Of String, Integer)

    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()

    End Sub
    Private Sub comboprodutos()
        For Each produto As DataRow In dado.Pesquisa("SELECT Descricao,IdProduto FROM produto").Rows
            cmb_produto.Items.Add(produto.Item(0))
            dicpro.Add(produto.Item(0), produto.Item(1))
        Next produto
    End Sub

    Private Sub grava()
        Dim strgrava As String
        Dim vanterior As Double
        strgrava = "INSERT INTO perdasProduto VALUES  ( " & dicpro(cmb_produto.Text) & ", " & txt_qtdPerca.Text.ToString.Replace(",", ".") & ", '" &
        Format(dtp_dataperca.Value, " dd/MM/yyyy") & "', '" & txt_observacao.ToString & "')"
        MsgBox(strgrava)
        dado.Pesquisa(strgrava)
        vanterior = dado.Pesquisa("SELECT Qtd FROM produto WHERE IdProduto = " & dicpro(cmb_produto.Text)).Rows(0).Item(0)
        MsgBox("UPDATE produto SET Qtd = '" & vanterior - txt_qtdPerca.Text & "' WHERE  IdProduto =" & dicpro(cmb_produto.Text))
        dado.Pesquisa("UPDATE produto SET Qtd = '" & vanterior - txt_qtdPerca.Text & "' WHERE  IdProduto =" & dicpro(cmb_produto.Text))
    End Sub

    Private Sub novaPerda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dado.Abreconexao()
        comboprodutos()

    End Sub

    Private Sub bnt_grava_Click(sender As Object, e As EventArgs) Handles bnt_grava.Click
        grava()
    End Sub
End Class