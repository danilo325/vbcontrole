Public Class NovoRomneio

    Dim AcessoRomaneio As New AcessoRomaneio
    Friend dadosbd As New BdClass
    'Inicia as colunas para o data gridview
    Dim comboProdutos As New DataGridViewComboBoxColumn
    Dim txtidproduto, txtqtdsaida, txtqtdretorno, txtqtdfinalisa As New DataGridViewTextBoxColumn

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
            '  insertquey += dadosbd.Pesquisa("SELECT * FROM vendedores WHERE NomeVendedor LIKE '" & cmb_vendedor.Text & "'").Rows(0).Item(0).ToString & ","
        Else
            MsgBox("É necessario o nome de um vendedor")
            cmb_vendedor.SelectAll()
        End If
        romaneio.Data = Format(dtp_dataRomaneio.Value, "dd/MM/yyyy")
        'insertquey += "'" & Format(dtp_dataRomaneio.Value, "dd/MM/yyyy") & "'," 'Formata a data para inserir no banco

        If txt_VCheque.Text <> "" Then
            romaneio.VCheques = txt_VCheque.Text
            'insertquey += txt_VCheque.Text.Replace(",", ".") & ","
        Else
            romaneio.VCheques = 0
        End If
        If txt_VDinheiro.Text <> "" Then
            romaneio.VDinheiro = txt_VDinheiro.Text
            'insertquey += txt_VDinheiro.Text.Replace(",", ".") & ","
        Else
            romaneio.VDinheiro = 0
            ' MsgBox("Coloque um valor para Dinheiro")
        End If
        If txt_VMoeda.Text <> "" Then
            romaneio.VMoedas = txt_VMoeda.Text
            'insertquey += txt_VMoeda.Text.Replace(",", ".") & ","
        Else
            romaneio.VMoedas = 0
            'MsgBox("Coloque um valor para Moeda")
        End If
        If txt_VBoleto.Text <> "" Then
            romaneio.VBoletos = txt_VBoleto.Text
            '  insertquey += txt_VBoleto.Text.Replace(",", ".") & ","
        Else
            romaneio.VBoletos = 0
            'MsgBox("Coloque um valor para Boleto")
        End If
        If txt_VFiado.Text <> "" Then
            romaneio.VFiado = txt_VFiado.Text
            'insertquey += txt_VFiado.Text.Replace(",", ".") & ","
        Else
            romaneio.VFiado = 0
            ' MsgBox("Coloque um valor para fiado")
        End If

        If txt_obs.Text <> "" Then
            romaneio.Observacao = txt_obs.Text
        Else
            romaneio.Observacao = " "
        End If
        romaneio.ListaProdutos = New DataTable

        romaneio.ListaProdutos.Columns.Add("Idromaneio")
        romaneio.ListaProdutos.Columns.Add("Idproduto")
        romaneio.ListaProdutos.Columns.Add("QtdprodutoS")
        romaneio.ListaProdutos.Columns.Add("QtdprodutoR")
        romaneio.ListaProdutos.Columns.Add("Qtdproduto")


        For Each produto As DataGridViewRow In dgv_ProdutosRomaneio.Rows
            romaneio.ListaProdutos.Rows.Add(lbl_idromaneio.Text, produto.Cells("id"), produto.Cells("qtdsaida"), produto.Cells("qtdretorno"), produto.Cells("qtdfinalisa"))
        Next produto
        'insertquey += "'" & txt_obs.Text & "')"

        ' dadosbd.Pesquisa(insertquey) 'executa a query e insere o romaneio no banco


        ' id = dadosbd.ultimo_id("romaneio", "IdRomaneio") 'pega o valor do id gerado pelo novo romaneio
        '#################################################################################################################################

        Dim produtosromaneio As String = "" 'string que guarda a query para de inserçao dos produtos na tabela produtosRomaneio
        Dim idprod As Integer 'Utilizadas para armazenar o id
        Dim qtdprod As Double ' e a quantidade dos produtos
        Dim prod As New DataTable 'Guarda o resultado da query produtos
        Dim qtd As Double
        '################################################################################################################################
        'Aqui nicia  a alteração das quantidades do produto no estoque
        '################################################################################################################################
        Try
            For Each dado As DataGridViewRow In dgv_ProdutosRomaneio.Rows
                If Not dado.IsNewRow Then ' Verifica se a linha é uma nova linha


                    prod = dadosbd.Pesquisa("SELECT IdProduto,Qtd FROM produto WHERE Descricao = '" & dado.Cells(0).Value.ToString & "'") ' Captura os valores de id e quantidade dos produtos
                    idprod = prod.Rows(0).Item(0) 'Guarda o Id do produto
                    qtdprod = prod.Rows(0).Item(1) 'Guarda a Quantidade do produto

                    If qtdprod >= dado.Cells(1).Value Then ' verifica se tem produto no estoque
                        'insere os produtos na tabela produtos romaneio
                        produtosromaneio = "INSERT INTO produtosRomaneio(IdRomaneio,IdProduto,QtdProduto) VALUES (" & id & "," &
                  idprod & "," & dado.Cells(1).Value.ToString.Replace(",", ".") & ")"
                        dadosbd.Pesquisa(produtosromaneio) ' executa a inserção
                        'atualiza o valor das quantidades do produto
                        qtd = dado.Cells(1).Value
                        MsgBox(qtdprod & " | " & qtd & " | " & qtdprod - qtd)
                        dadosbd.Pesquisa("UPDATE produto SET Qtd = '" & (qtdprod - qtd) & "' WHERE IdProduto = " & idprod) ' Faz a atualizaçõa no banco de dados

                        'MsgBox("UPDATE produto SET Qtd = " & qtdprod - dado.Cells(1).Value.ToString.Replace(",", ".") & " WHERE IdProduto = " & idprod)
                    Else
                        MsgBox("Não tem produto suficiente no estoque")
                        dado.Cells(1).ErrorText = "Não temos esta quantia de produto no estoque"
                    End If


                End If
            Next dado
            'Limpa os valores dos campos do formulário
            dtp_dataRomaneio.Value = Today
            txt_obs.Text = ""
            txt_VBoleto.Text = ""
            txt_VCheque.Text = ""
            txt_VDinheiro.Text = ""
            txt_VFiado.Text = ""
            txt_VMoeda.Text = ""
            dgv_ProdutosRomaneio.Rows.Clear()

            cmb_vendedor.ResetText()
            MsgBox("Romaneio gravado")
        Catch ex As Exception
            MsgBox("Problema ao gravar os dados no banco de dados ")
        End Try

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

        If lbl_estado.Text = "estado" Then
            lbl_estado.Text = "Saida"
            bnt_mudaestado.Visible = False
            txtqtdretorno.Visible = False
            txtqtdfinalisa.Visible = False
            txtqtdsaida.Visible = True
            txt_VBoleto.Enabled = False
            txt_VCheque.Enabled = False
            txt_VDinheiro.Enabled = False
            txt_VMoeda.Enabled = False
            txt_VFiado.Enabled = False
            lbl_valorTotal.Text = 0

        ElseIf lbl_estado.Text = "Saida" Then
            bnt_mudaestado.Text = "Fazer Retorno"
            bnt_mudaestado.Visible = True
            txtqtdretorno.Visible = False
            txtqtdsaida.Visible = True
            txtqtdfinalisa.Visible = False
            txt_VBoleto.Enabled = False
            txt_VCheque.Enabled = False
            txt_VDinheiro.Enabled = False
            txt_VMoeda.Enabled = False
            txt_VFiado.Enabled = False
            lbl_valorTotal.Text = 0


        ElseIf lbl_estado.Text = "Retorno" Then
            bnt_mudaestado.Text = "Finalizar"
            txtqtdretorno.Visible = True
            txtqtdsaida.Visible = True
            txt_VBoleto.Enabled = False
            txt_VCheque.Enabled = False
            txt_VDinheiro.Enabled = False
            txt_VMoeda.Enabled = False
            txt_VFiado.Enabled = False
            lbl_valorTotal.Text = 0
        ElseIf lbl_estado.Text = "Finalizado" Then

            txtqtdretorno.Visible = True
            txtqtdsaida.Visible = True

        End If
        Label1.Visible = False
        lbl_idromaneio.Text = dadosbd.tt2() + 1
    End Sub
    'chama a função grava dados 
    Private Sub bnt_inclui_Click(sender As Object, e As EventArgs) Handles bnt_inclui.Click
        gravaDados()
    End Sub

    Private Sub dgv_ProdutosRomaneio_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ProdutosRomaneio.CellEndEdit

    End Sub
End Class