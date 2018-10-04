Public Class NovoRomneio

    Friend dadosbd As New BdClass
    'Inicia as colunas para o data gridview
    Dim comboProdutos As New DataGridViewComboBoxColumn
    Dim txtproduto As New DataGridViewTextBoxColumn

    'fecha a janela assim que se clica no botão fechar
    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()
    End Sub

    'Grava os dados digitados no formulário 
    Private Sub gravaDados()
        Dim id As Integer
        'String da query SQL para inserir no banco
        Dim insertquey As String = "INSERT INTO romaneio (IdVendedor, DataRomaneio, ValorCheques,ValoDinheiro,ValorMoedas,ValorBoleto,ValorFiado,ObsRomaneio) VALUES ("

        'Verifica se algum campo está vazio
        If cmb_vendedor.Text <> "" Then
            insertquey += dadosbd.Pesquisa("SELECT * FROM vendedores WHERE NomeVendedor LIKE '" & cmb_vendedor.Text & "'").Rows(0).Item(0).ToString & ","
        Else
            MsgBox("É necessario o nome de um vendedor")
            cmb_vendedor.SelectAll()
        End If

        insertquey += "'" & Format(dtp_dataRomaneio.Value, "dd/MM/yyyy") & "'," 'Formata a data para inserir no banco

        If txt_VCheque.Text <> "" Then
            insertquey += txt_VCheque.Text.Replace(",", ".") & ","
        Else
            MsgBox("Coloque um valor para cheque")
        End If
        If txt_VDinheiro.Text <> "" Then
            insertquey += txt_VDinheiro.Text.Replace(",", ".") & ","
        Else
            MsgBox("Coloque um valor para Dinheiro")
        End If
        If txt_VMoeda.Text <> "" Then
            insertquey += txt_VMoeda.Text.Replace(",", ".") & ","
        Else
            MsgBox("Coloque um valor para Moeda")
        End If
        If txt_VBoleto.Text <> "" Then
            insertquey += txt_VBoleto.Text.Replace(",", ".") & ","
        Else
            MsgBox("Coloque um valor para Boleto")
        End If
        If txt_VFiado.Text <> "" Then
            insertquey += txt_VFiado.Text.Replace(",", ".") & ","
        Else
            MsgBox("Coloque um valor para fiado")
        End If
        insertquey += "'" & txt_obs.Text & "')"

        dadosbd.Pesquisa(insertquey) 'executa a query e insere o romaneio no banco


        id = dadosbd.ultimo_id("romaneio", "IdRomaneio") 'pega o valor do id gerado pelo novo romaneio
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
        comboProdutos.HeaderText = "Produto"
        txtproduto.Name = "cbprodutos"
        txtproduto.HeaderText = "Produto"
        dgv_ProdutosRomaneio.Columns.Add(comboProdutos)
        dgv_ProdutosRomaneio.Columns.Add(txtproduto)
        Label1.Visible = False
        lbl_idromaneio.Visible = False





    End Sub
    'chama a função grava dados 
    Private Sub bnt_inclui_Click(sender As Object, e As EventArgs) Handles bnt_inclui.Click
        gravaDados()
    End Sub
End Class