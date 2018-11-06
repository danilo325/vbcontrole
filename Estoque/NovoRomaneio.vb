Public Class NovoRomneio

    Dim AcessoRomaneio As New AcessoRomaneio
    Friend dadosbd As New BdClass
    'Inicia as colunas para o data gridview
    Dim comboProdutos As New DataGridViewComboBoxColumn
    Dim txtidproduto, txtqtdsaida, txtqtdretorno, txtqtdfinalisa As New DataGridViewTextBoxColumn
    Dim dadosamtes As New DataGrid
    'fecha a janela assim que se clica no botão fechar
    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()
    End Sub

    'Grava os dados digitados no formulário 
    Private Sub gravaDados()
        Dim romaneio As New Romaneio

        Dim id As Integer
        'String da query SQL para inserir no banco
        Dim insertquey As String = "INSERT INTO romaneio (IdVendedor, DataRomaneio, ValorCheques,ValoDinheiro,ValorMoedas,ValorBoleto,ValorFiado,ObsRomaneio) VALUES ("

        'Verifica se algum campo está vazio
        If cmb_vendedor.Text <> "" Then
            romaneio.Vendedor = cmb_vendedor.Text

        Else
            MsgBox("É necessario o nome de um vendedor")
            cmb_vendedor.SelectAll()
            Return
        End If
        romaneio.Data = Format(dtp_dataRomaneio.Value, "dd/MM/yyyy")


        If txt_VCheque.Text <> "" Then
            romaneio.VCheques = txt_VCheque.Text

        Else
            romaneio.VCheques = 0
        End If
        If txt_VDinheiro.Text <> "" Then
            romaneio.VDinheiro = txt_VDinheiro.Text

        Else
            romaneio.VDinheiro = 0
            ' MsgBox("Coloque um valor para Dinheiro")
        End If
        If txt_VMoeda.Text <> "" Then
            romaneio.VMoedas = txt_VMoeda.Text

        Else
            romaneio.VMoedas = 0

        End If
        If txt_VBoleto.Text <> "" Then
            romaneio.VBoletos = txt_VBoleto.Text

        Else
            romaneio.VBoletos = 0

        End If
        If txt_VFiado.Text <> "" Then
            romaneio.VFiado = txt_VFiado.Text

        Else
            romaneio.VFiado = 0

        End If

        If txt_obs.Text <> "" Then
            romaneio.Observacao = txt_obs.Text
        Else
            romaneio.Observacao = " "
        End If
        romaneio.Status = lbl_estado.Text
        romaneio.ListaProdutos = New DataTable

        romaneio.ListaProdutos.Columns.Add("Idromaneio")
        romaneio.ListaProdutos.Columns.Add("Idproduto")
        romaneio.ListaProdutos.Columns.Add("QtdprodutoS")
        romaneio.ListaProdutos.Columns.Add("QtdprodutoR")
        romaneio.ListaProdutos.Columns.Add("Qtdproduto")


        For Each produto As DataGridViewRow In dgv_ProdutosRomaneio.Rows
            If Not produto.IsNewRow Then
                romaneio.ListaProdutos.Rows.Add(lbl_idromaneio.Text, produto.Cells("id").Value, produto.Cells("qtdsaida").Value, produto.Cells("qtdretorno").Value, produto.Cells("qtdfinalisa").Value)
            End If
        Next produto
        AcessoRomaneio.GravaRomaneio(romaneio)






        '#################################################################################################################################

        '  Dim produtosromaneio As String = "" 'string que guarda a query para de inserçao dos produtos na tabela produtosRomaneio
        'Dim idprod As Integer 'Utilizadas para armazenar o id
        ' Dim qtdprod As Double ' e a quantidade dos produtos
        ''Dim prod As New DataTable 'Guarda o resultado da query produtos
        ' Dim qtd As Double
        '################################################################################################################################
        'Aqui nicia  a alteração das quantidades do produto no estoque
        '################################################################################################################################





    End Sub
    'Gera os dados para o combobox dosvendedores
    Private Sub comboVendedores()
        Dim nomes As DataTable = dadosbd.Pesquisa("SELECT NomeVendedor FROM vendedores")
        cmb_vendedor.Items.Add("")
        For Each nome As DataRow In nomes.Rows
            cmb_vendedor.Items.Add(nome.Item(0).ToString)
        Next
    End Sub
    'gera o combobox de produtos para a coluna do datagridview
    Private Sub comboproutos()
        Dim produtos As DataTable = dadosbd.Pesquisa("SELECT Descricao FROM produto")
        comboProdutos.Items.Add("")

        For Each nome As DataRow In produtos.Rows
            comboProdutos.Items.Add(nome.Item(0).ToString)
        Next
    End Sub
    Private Sub AtiualizavalorToal()
        Dim vcheque As Double = If(String.IsNullOrEmpty(txt_VCheque.Text), 0, If(IsNumeric(txt_VCheque.Text), Double.Parse(txt_VCheque.Text), 0))
        Dim vdinheiro As Double = If(String.IsNullOrEmpty(txt_VDinheiro.Text), 0, If(IsNumeric(txt_VDinheiro.Text), Double.Parse(txt_VDinheiro.Text), 0))
        Dim vmoeda As Double = If(String.IsNullOrEmpty(txt_VMoeda.Text), 0, If(IsNumeric(txt_VMoeda.Text), Double.Parse(txt_VMoeda.Text), 0))
        Dim vboleto As Double = If(String.IsNullOrEmpty(txt_VBoleto.Text), 0, If(IsNumeric(txt_VBoleto.Text), Double.Parse(txt_VBoleto.Text), 0))
        Dim vtotal As Double = vcheque + vdinheiro + vboleto + vmoeda
        lbl_valorTotal.Text = "R$ " & FormatNumber(vtotal, -1)
    End Sub


    Private Sub txt_VCheque_TextChanged(sender As Object, e As EventArgs) Handles txt_VCheque.TextChanged
        AtiualizavalorToal()
    End Sub

    Private Sub txt_VDinheiro_TextChanged(sender As Object, e As EventArgs) Handles txt_VDinheiro.TextChanged
        AtiualizavalorToal()
    End Sub

    Private Sub txt_VMoeda_TextChanged(sender As Object, e As EventArgs) Handles txt_VMoeda.TextChanged
        AtiualizavalorToal()
    End Sub

    Private Sub txt_VBoleto_TextChanged(sender As Object, e As EventArgs) Handles txt_VBoleto.TextChanged
        AtiualizavalorToal()
    End Sub

    Private Sub NovoRomneio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dadosbd.Abreconexao()
        comboVendedores()
        comboproutos()

        comboProdutos.Name = "cbprodutos"
        comboProdutos.HeaderText = "Nome Produto"
        comboProdutos.ToolTipText = "A descrição do produto"

        txtqtdsaida.Name = "qtdsaida"
        txtqtdsaida.HeaderText = "Qtd saida"
        txtqtdsaida.ToolTipText = "Quantidade de produtos que sairam no romaneio"

        txtqtdretorno.HeaderText = "Qtd Retorno"
        txtqtdretorno.Name = "qtdretorno"
        txtqtdretorno.ToolTipText = "Quantidade de produtos que retornaram"

        txtqtdfinalisa.HeaderText = "Qtd vendas"
        txtqtdfinalisa.Name = "qtdfinalisa"
        txtqtdfinalisa.ToolTipText = "Quantidade de produtos que foram vendidos"

        txtidproduto.HeaderText = "ID"
        txtidproduto.Name = "id"
        txtidproduto.ToolTipText = "Identificador do produto no sistema"

        dgv_ProdutosRomaneio.Columns.AddRange(txtidproduto, comboProdutos, txtqtdsaida, txtqtdretorno, txtqtdfinalisa)
        If lbl_idromaneio.Text = "ID" Then
            lbl_idromaneio.Text = dadosbd.tt2() + 1
        End If

        lbl_estado.Text = "Finalizado"
        Label1.Visible = False

        lbl_valorTotal.Text = 0

    End Sub


    'chama a função grava dados 
    Private Sub bnt_inclui_Click(sender As Object, e As EventArgs) Handles bnt_inclui.Click
        gravaDados()
    End Sub

    Private Sub dgv_ProdutosRomaneio_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ProdutosRomaneio.CellEndEdit
        Dim linha As Integer = e.RowIndex
        Dim coluna As Integer = e.ColumnIndex
        Dim detalhesproduto As DataTable

        If coluna = 0 Then
            If Not IsNothing(dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value) Then
                If dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value.ToString <> "" And IsNumeric(dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value.ToString) Then
                    detalhesproduto = AcessoRomaneio.VerificaProdutos(Integer.Parse(dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value))
                    If detalhesproduto.Rows.Count = 0 Then
                        dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value = ""
                        dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Selected = True
                        MsgBox("O ID de produto digitado não existe", MsgBoxStyle.DefaultButton1)
                        Return
                    End If
                    dgv_ProdutosRomaneio.Rows(linha).Cells(coluna + 1).Value = detalhesproduto.Rows(0).Item(1).ToString
                End If
            End If
        End If

            If coluna = 1 Then
            If dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value.ToString <> "" Then
                detalhesproduto = AcessoRomaneio.VerificaProdutos(dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value.ToString)
                If detalhesproduto.Rows.Count = 0 Then
                    dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Value = ""
                    dgv_ProdutosRomaneio.Rows(linha).Cells(coluna).Selected = True
                    MsgBox("O Nome do produto digitado não existe", MsgBoxStyle.DefaultButton1)
                    Return
                End If
                dgv_ProdutosRomaneio.Rows(linha).Cells(coluna - 1).Value = detalhesproduto.Rows(0).Item(0).ToString
            End If
        End If



        If coluna = 2 Then
            MsgBox(linha)

        End If
        If coluna = 3 Then

        End If
    End Sub
End Class