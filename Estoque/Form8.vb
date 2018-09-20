Public Class frm_novaCompra
    Dim comboproduto As New DataGridViewComboBoxColumn
    Dim textcolqtd, textcolComNota, textColValor As New DataGridViewTextBoxColumn
    Dim dicProdutos, dicFornecedor As New Dictionary(Of String, Integer)
    Dim bancodados As New BdClass



    Private Sub ComboProdutos()
        comboproduto.Items.Add("")
        Dim produtos As DataTable = bancodados.Pesquisa("SELECT IdProduto, Descricao FROM produto")
        For Each produto As DataRow In produtos.Rows
            dicProdutos.Add(produto.Item(1).ToString, produto.Item(0))
            comboproduto.Items.Add(produto.Item(1).ToString)
        Next produto

    End Sub



    Private Sub bnt_grava_Click(sender As Object, e As EventArgs) Handles bnt_grava.Click
        gravainfo()
    End Sub

    Private Sub ComboFornecedor()
        cmb_fornecedor.Items.Add("")
        Dim fornecedores As DataTable = bancodados.Pesquisa("SELECT IdForncedor, NomeFantasia FROM fornecedores")
        For Each fornecedor As DataRow In fornecedores.Rows
            dicFornecedor.Add(fornecedor.Item(1), fornecedor.Item(0))
            cmb_fornecedor.Items.Add(fornecedor.Item(1))
        Next fornecedor
    End Sub
    Private Sub gravainfo()
        Dim idcompra As Integer = 0

        Dim strGrava As String = "INSERT INTO compras (IdForncedor ,NumeroPedido,DataCompra,ValorCompra,ImpostoCompra,ObsCompra) VALUES ("
        strGrava += dicFornecedor.Item(cmb_fornecedor.Text) & ","
        strGrava += txt_numeroPedido.Text & ","
        strGrava += "'" & Format(dtp_data.Value, "dd/MM/yyyy") & "',"
        strGrava += txt_valorTotal.Text & ","
        strGrava += txt_valorImposto.Text & ","
        strGrava += "'" & txt_obs.Text & "')"
        bancodados.Pesquisa(strGrava)
        idcompra = bancodados.Pesquisa("SELECT MAX(IdCompras) FROM compras").Rows(0).Item(0)

        For Each prod As DataGridViewRow In dgv_produtos.Rows
            If Not prod.IsNewRow Then
                bancodados.Pesquisa("INSERT INTO produtosCompra VALUES ( " & idcompra & "," & dicProdutos.Item(prod.Cells(0).Value.ToString) &
                                    "," & prod.Cells(1).Value.ToString & "," & prod.Cells(2).Value.ToString & "," & prod.Cells(3).Value.ToString &
                                      ")")
            End If
        Next prod

    End Sub

    Private Sub frm_novaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bancodados.Abreconexao()
        ComboProdutos()
        ComboFornecedor()
        comboproduto.AutoComplete = True
        comboproduto.HeaderText = "Produto"
        comboproduto.Name = "produto"
        textcolComNota.HeaderText = "Com Nota"
        textcolComNota.Name = "ComNota"
        textColValor.HeaderText = "Valor Produto"
        textColValor.Name = "valor"
        textcolqtd.HeaderText = "Quantidade"
        textcolqtd.Name = "quantiade"

        dgv_produtos.Columns.Add(comboproduto)
        dgv_produtos.Columns.Add(textcolqtd)
        dgv_produtos.Columns.Add(textcolComNota)
        dgv_produtos.Columns.Add(textColValor)
    End Sub
End Class