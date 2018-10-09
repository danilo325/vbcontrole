Public Class Romaneios
    Friend dbdata As New BdClass
    Friend vend As New Dictionary(Of String, Integer)
    Dim AcRomaneio As New AcessoRomaneio
    Dim dicProdutos As New Dictionary(Of Integer, String)
    Dim ColId As New DataGridViewTextBoxColumn
    Dim ColVendedor As New DataGridViewTextBoxColumn
    Dim ColData As New DataGridViewTextBoxColumn
    Dim ColValorTotal As New DataGridViewTextBoxColumn
    Dim ColObs As New DataGridViewTextBoxColumn
    Dim ColStatus As New DataGridViewTextBoxColumn


    Private Sub CriaDicPro()
        For Each produto As DataRow In dbdata.Pesquisa("SELECT IdProduto, Descricao FROM produto").Rows
            dicProdutos.Add(produto.Item(0), produto.Item(1).ToString)
        Next produto
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnt_pesquisa.Click
        Dim contaargumentos As Integer = 0
        Dim idromaneio, idvendedor As Integer
        Dim datainicial, datafinal As String
        If txt_id.Text <> "" Then
            idromaneio = txt_id.Text
        Else
            idromaneio = 0
        End If
        If cmb_vendedor.Text <> "" Then
            idvendedor = vend.Item(cmb_vendedor.Text)
        Else
            idvendedor = 0
        End If

        'Para a pesquisa funcionar é necessario deixar as datas no formato americano e acrescentear o caractare "#" 
        'antes e depois da data.
        If dtp_inicial.Checked Then
            datainicial = "#" & Format(dtp_inicial.Value, "MM/dd/yyyy") & "#"
        Else
            datainicial = ""
        End If

        If dtp_final.Checked Then
            datafinal = "#" & Format(dtp_final.Value, "MM/dd/yyyy") & "#"
        Else
            datafinal = ""
        End If
        PreecheDgvRomaneio(AcRomaneio.PesquisaRomaneio(idromaneio, idvendedor, datainicial, datafinal))
    End Sub

    Public Sub combovendedor()
        cmb_vendedor.Items.Add("")
        Dim vendedor As DataTable = dbdata.Pesquisa("SELECT IdVendedor, NomeVendedor FROM vendedores")
        Try
            For Each ven As DataRow In vendedor.Rows
                vend.Add(ven.Item(1).ToString, ven.Item(0).ToString)
                cmb_vendedor.Items.Add(ven.Item(1).ToString)
            Next ven
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub romaneios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbdata.Abreconexao()
        CriaDicPro()
        'dgv_romaneios.DataSource = dbdata.Pesquisa("SELECT * FROM romaneio")

        ColId.HeaderText = "Id"
        ColId.ToolTipText = "Identificador único do romaneio."
        ColId.Name = "id"

        ColVendedor.HeaderText = "Vendedor"
        ColVendedor.Name = "vendedor"
        ColVendedor.ToolTipText = " Informa o nome do vededor"

        ColData.HeaderText = " Data"
        ColData.ToolTipText = "Refere-se a data que o romoaneio foi criado"
        ColData.Name = "data"

        ColValorTotal.HeaderText = "Valor"
        ColValorTotal.ToolTipText = "O valor total do romaneioa soma de (Cheques+Dinheiro+Boletos+Moedas)"
        ColValorTotal.Name = "vtotal"

        ColObs.HeaderText = "Observação"
        ColObs.ToolTipText = "Informação pertinente ao romaneio"
        ColObs.Name = "obs"

        ColStatus.HeaderText = "Status"
        ColStatus.ToolTipText = "Mostra o Status atual do romaneio"
        ColStatus.Name = "status"

        dgv_romaneios.Columns.AddRange(ColId, ColVendedor, ColData, ColValorTotal, ColObs, ColStatus)
        PreecheDgvRomaneio(AcRomaneio.CarregaRomaneios())



        combovendedor()
        bnt_Edita.Enabled = False
        bnt_Exclui.Enabled = False
        bnt_Exclui.Visible = False
        bnt_Edita.Visible = False


    End Sub

    Private Sub PreecheDgvRomaneio(listaromaneio As List(Of Romaneio))
        dgv_romaneios.Rows.Clear()
        For Each romaneio As Romaneio In listaromaneio
            dgv_romaneios.Rows.Add(romaneio.Id, romaneio.Vendedor, romaneio.Data, "R$ " & romaneio.VToatal, romaneio.Observacao, romaneio.Status)
        Next romaneio
    End Sub
    'Remove o romaneio que possui a linha selecionada
    Private Sub bnt_Exclui_Click(sender As Object, e As EventArgs) Handles bnt_Exclui.Click
        Dim query As String
        Dim mensagem As String = ""
        Dim queryprodutos As String = ""
        query = "DELETE FROM romaneio WHERE IdRomaneio IN ("
        If (dgv_romaneios.SelectedRows.Count > 0) Then 'Garante que tenha pelomenos uma linha selecionada

            For Each linha As DataGridViewRow In dgv_romaneios.SelectedRows
                query += linha.Cells(0).Value.ToString & ","
                queryprodutos += linha.Cells(0).Value.ToString & ","
                mensagem += linha.Cells(1).Value.ToString & "\n"

            Next linha
            query += ")"
            MsgBox("Os produtos \n " & mensagem & "\n serão apagados")
            dbdata.Pesquisa("DELETE FROM produtosRomaneio WHERE IdRomaneio IN (" & queryprodutos & ")")


            dbdata.Pesquisa(query)

            dgv_romaneios.DataSource = dbdata.Pesquisa("SELECT * FROM romaneio ")
        Else
            MsgBox("É necessário selecionar aomenos uma linha")
        End If
    End Sub
    ''' <summary>
    ''' Quando acionado abre uma tela com os dados do roamaneio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgv_romaneios_DoubleClick(sender As Object, e As EventArgs) Handles dgv_romaneios.DoubleClick
        Dim ColIDRomaneio, ColProduto, ColQtdProdSaiu, ColQtdProdRetorno, ColQtdProdFinal As New DataGridViewTextBoxColumn
        ColIDRomaneio.HeaderText = "Id Romaneio"
        ColIDRomaneio.Name = "idromaneio"
        ColProduto.HeaderText = "Produto"
        ColProduto.Name = "produto"
        ColQtdProdSaiu.HeaderText = "Qtd Prod Saida"
        ColQtdProdSaiu.Name = "qtdprodsaiu"
        ColQtdProdRetorno.HeaderText = "Qtd Prod Retorno"
        ColQtdProdRetorno.Name = "qtdprodretorno"
        ColQtdProdFinal.HeaderText = "Qtd Prod Acertado"
        ColQtdProdFinal.Name = "qtdprodacertado"

        Dim romaneio As Romaneio = AcRomaneio.PesquisaRomaneio(dgv_romaneios.Rows(dgv_romaneios.SelectedCells(0).RowIndex).Cells(0).Value, 0, "", "").Item(0)
        Dia_DetalhesRomaneio.lbl_idromaneio.Text = romaneio.Id
        Dia_DetalhesRomaneio.txt_NomeVendedor.Text = romaneio.Vendedor
        Dia_DetalhesRomaneio.dtp_dataRomaneio.Value = romaneio.Data
        Dia_DetalhesRomaneio.txt_VCheque.Text = romaneio.VCheques
        Dia_DetalhesRomaneio.txt_VDinheiro.Text = romaneio.VDinheiro
        Dia_DetalhesRomaneio.txt_VMoeda.Text = romaneio.VMoedas
        Dia_DetalhesRomaneio.txt_VBoleto.Text = romaneio.VBoletos
        Dia_DetalhesRomaneio.txt_VFiado.Text = romaneio.VFiado
        Dia_DetalhesRomaneio.lbl_valorTotal.Text = "R$ " & romaneio.VToatal
        Dia_DetalhesRomaneio.lbl_status.Text = romaneio.Status
        Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.Columns.AddRange(ColIDRomaneio, ColProduto, ColQtdProdSaiu, ColQtdProdRetorno, ColQtdProdFinal)
        For Each produto As DataRow In romaneio.ListaProdutos.Rows
            Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.Rows.Add(produto.Item("IdRomaneio"), dicProdutos.Item(produto.Item("IdProduto")), produto.Item("QtdProdutoS"), produto.Item("QtdProdutoR"), produto.Item("QtdProduto"))
        Next produto

        'Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.DataSource = dbdata.Pesquisa("SELECT* FROM produtosRomaneio WHERE IdRomaneio = " & dgv_romaneios.Rows(indexlinha).Cells(0).Value)
        Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.AllowUserToAddRows = False

        Dia_DetalhesRomaneio.Visible = True

    End Sub
    'Chama o formilário de inclusão do romaneio
    Private Sub bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        NovoRomneio.Visible = True
    End Sub

    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()
    End Sub
End Class