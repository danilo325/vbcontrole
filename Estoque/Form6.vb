Public Class NovoRomneio
    Friend dadosbd As New BdClass

    Dim comboProdutos As New DataGridViewComboBoxColumn
    Dim txtproduto As New DataGridViewTextBoxColumn

    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()
    End Sub
    Private Sub gravaDados()


    End Sub
    Private Sub comboVendedores()
        Dim nomes As DataTable = dadosbd.Pesquisa("SELECT NomeVendedor FROM vendedores")
        cmb_vendedor.Items.Add("")
        For Each nome As DataRow In nomes.Rows
            cmb_vendedor.Items.Add(nome.Item(0).ToString)
        Next
    End Sub
    Private Sub comboproutos()
        Dim produtos As DataTable = dadosbd.Pesquisa("SELECT Descricao FROM produto")
        comboProdutos.Items.Add("")

        For Each nome As DataRow In produtos.Rows
            comboProdutos.Items.Add(nome.Item(0).ToString)
        Next
    End Sub
    Private Sub NovoRomneio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dadosbd.Abreconexao()
        comboVendedores()
        comboproutos()
        gravaDados()
        comboProdutos.Name = "cbprodutos"
        comboProdutos.HeaderText = "Produto"
        txtproduto.Name = "cbprodutos"
        txtproduto.HeaderText = "Produto"
        ' dgv_ProdutosRomaneio.Columns.Add(comboProdutos)
        '  dgv_ProdutosRomaneio.Columns.Add(txtproduto)

        dgv_ProdutosRomaneio.DataSource = dadosbd.schemadedados()


        'MsgBox(dadosbd.Pesquisa("SELECT NEXT VALUE FOR IdProduto INTO produto").Rows(0).Item(0).ToString)
    End Sub
End Class