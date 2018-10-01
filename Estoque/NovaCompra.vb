Imports System.ComponentModel

Public Class frm_novaCompra
    Dim comboproduto As New DataGridViewComboBoxColumn
    Dim textcolqtd, textcolComNota, textColValor, textcolImposto, textcolPrecoReal As New DataGridViewTextBoxColumn
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


    Private Sub dgv_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellEndEdit
        Dim celula As DataGridViewCell = dgv_produtos.CurrentCell

        If celula.ColumnIndex <> 0 Then
            If Not IsNumeric(celula.Value) Then
                MsgBox("Favor digitar somente valores numéricos", MsgBoxStyle.Exclamation)
                celula.ToolTipText = "Digite somente valores numéricos"
                celula.ErrorText = "Digite somente valores numéricos"
                bnt_grava.Enabled = False
            Else
                celula.ToolTipText = ""
                celula.ErrorText = ""
                bnt_grava.Enabled = True
            End If
        Else
            If IsNothing(celula.Value) Then
                MsgBox("Escolha um item da lista", MsgBoxStyle.Exclamation)
                celula.ToolTipText = "Escolha um item da lista"
                celula.ErrorText = "Escolha um item da lista"
                bnt_grava.Enabled = False
            Else
                celula.ToolTipText = ""
                celula.ErrorText = ""
                bnt_grava.Enabled = True
            End If
        End If

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
    'Função utilizada para validar e gerar a sql de que irá guardar as informações básicas da compra
    Private Function infocompra() As String
        Dim str As String = ""


        Return str
    End Function


    'Metodo utilizado para gravar as informações da compra
    Private Sub gravainfo()
        Dim idcompra As Integer = 0
        Dim qtdcompras As Integer = 0
        Dim strGrava As String = "INSERT INTO compras (IdForncedor ,NumeroPedido,DataCompra,ValorCompra,ImpostoCompra,ObsCompra) VALUES ("
        strGrava += dicFornecedor.Item(cmb_fornecedor.Text) & ","
        strGrava += txt_numeroPedido.Text & ","
        strGrava += "'" & Format(dtp_data.Value, "dd/MM/yyyy") & "',"
        strGrava += txt_valorTotal.Text.Replace(",", ".") & ","
        strGrava += txt_valorImposto.Text.Replace(",", ".") & ","
        strGrava += "'" & txt_obs.Text & "')"
        MsgBox(strGrava)
        bancodados.Pesquisa(strGrava)
        idcompra = bancodados.Pesquisa("SELECT MAX(IdCompras) FROM compras").Rows(0).Item(0)

        strGrava = "INSERT INTO transporteCompra (IdCompra, Tipo, Valor,Obs) VALUES ( " &
            idcompra & ",'" & cmb_tipoTrasporte.Text & "'," & txt_freteValor.Text.Replace(",", ".") & ",'" & txt_freteObs.Text & "')"
        MsgBox(strGrava)
        bancodados.Pesquisa(strGrava)
        strGrava = "INSERT INTO chapa (IdTansporte, Valor,Obs) VALUES ( " &
            bancodados.Pesquisa("SELECT MAX(Id) FROM transporteCompra").Rows(0).Item(0) & "," & txt_valorChapa.Text.Replace(",", ".") & ",'" & txt_obsChapa.Text & "')"
        bancodados.Pesquisa(strGrava)

        For Each prod As DataGridViewRow In dgv_produtos.Rows
            If Not prod.IsNewRow Then

                bancodados.Pesquisa("UPDATE produto SET Qtd =" & (bancodados.Pesquisa("SELECT Qtd FROM produto WHERE IdProduto =" & dicProdutos.Item(prod.Cells(0).Value.ToString)).Rows(0).Item(0) + prod.Cells(1).Value) & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))

                bancodados.Pesquisa("INSERT INTO produtosCompra VALUES ( " & idcompra & "," & dicProdutos.Item(prod.Cells(0).Value.ToString) &
                                    "," & prod.Cells(1).Value.ToString & "," & prod.Cells(2).Value.ToString & "," & prod.Cells(3).Value.ToString.Replace(",", ".") & "," &
                                     prod.Cells(4).Value.ToString & "," & 0 & ")")
                qtdcompras += prod.Cells(1).Value
            End If
        Next prod
        For Each prod As DataGridViewRow In dgv_produtos.Rows
            Dim vci As Integer = 0

            If Not prod.IsNewRow Then

                vci = (prod.Cells(4).Value / prod.Cells(1).Value)

                Dim vdec As Decimal = CDec((prod.Cells(3).Value + vci + ((CDbl(txt_freteValor.Text.ToString) + CDbl(txt_valorChapa.Text.ToString)) / qtdcompras)))
                MsgBox(vdec)
                MsgBox("UPDATE produtosCompra SET PrecoReal = " & vdec.ToString.Replace(",", ".") & " WHERE IdCompra = " & idcompra & " AND IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
                bancodados.Pesquisa("UPDATE produtosCompra SET PrecoReal = " & vdec.ToString.Replace(",", ".") & " WHERE IdCompra = " & idcompra & " AND IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
                MsgBox("UPDATE produto SET Pcusto =" & vdec & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
                ' bancodados.Pesquisa("UPDATE produto SET Pcusto =" & bancodados.Pesquisa("SELECT Pcusto FROM produto WHERE IdProduto =" & dicProdutos.Item(prod.Cells(0).Value.ToString)).Rows(0).Item(0) + prod.Cells(3).Value & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
                bancodados.Pesquisa("UPDATE produto SET Pcusto =" & vdec.ToString.Replace(",", ".") & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
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
        textcolImposto.HeaderText = "Imposto"
        textcolImposto.Name = "imposto"
        textcolPrecoReal.HeaderText = "V. com despesas"
        txt_freteValor.CausesValidation = True


        dgv_produtos.Columns.Add(comboproduto)
        dgv_produtos.Columns.Add(textcolqtd)
        dgv_produtos.Columns.Add(textcolComNota)
        dgv_produtos.Columns.Add(textColValor)
        dgv_produtos.Columns.Add(textcolImposto)
        dgv_produtos.Columns.Add(textcolPrecoReal)
        cmb_tipoTrasporte.Items.Add("")
        cmb_tipoTrasporte.Items.Add("Frete")
        cmb_tipoTrasporte.Items.Add("Proprio")
        textcolPrecoReal.Visible = False

    End Sub


    Private Sub txt_numeroPedido_Validated(sender As Object, e As EventArgs) Handles txt_numeroPedido.Validated
        If Not IsNumeric(txt_numeroPedido.Text) Then

            MsgBox("Favor digitar somente valores numéricos", MsgBoxStyle.Exclamation)
            txt_numeroPedido.BackColor = Color.Red
            txt_numeroPedido.Select()
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(txt_numeroPedido, "Voce digitou valores incorretos, digite somente números!")
            ToolTip1.BackColor = Color.LightSalmon

        Else
            txt_numeroPedido.BackColor = Color.White
            ToolTip1.RemoveAll()

        End If
    End Sub

    Private Sub dtp_data_Validated(sender As Object, e As EventArgs) Handles dtp_data.Validated
        If Not IsDate(dtp_data.Value) Then

            MsgBox("Favor digitar uma data correta no formato 'DIA/MES/ANO'", MsgBoxStyle.Exclamation)
            dtp_data.BackColor = Color.Red
            dtp_data.Select()
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(dtp_data, "Voce digitou valores incorretos, digite uma data no formato 'DIA/MES/ANO'!")
            ToolTip1.BackColor = Color.LightSalmon

        Else
            dtp_data.BackColor = Color.White
            ToolTip1.RemoveAll()

        End If
    End Sub

    Private Sub txt_freteValor_Validated(sender As Object, e As EventArgs) Handles txt_freteValor.Validated
        If Not IsNumeric(txt_freteValor.Text) Then

            MsgBox("Favor digitar somente valores numéricos", MsgBoxStyle.Exclamation)
            txt_freteValor.BackColor = Color.Red
            txt_freteValor.Select()
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(txt_freteValor, "Voce digitou valores incorretos, digite somente números!")
            ToolTip1.BackColor = Color.LightSalmon

        Else
            txt_freteValor.BackColor = Color.White
            ToolTip1.RemoveAll()

        End If
    End Sub

    Private Sub txt_valorChapa_Validated(sender As Object, e As EventArgs) Handles txt_valorChapa.Validated
        If Not IsNumeric(txt_valorChapa.Text) Then

            MsgBox("Favor digitar somente valores numéricos", MsgBoxStyle.Exclamation)
            txt_valorChapa.BackColor = Color.Red
            txt_valorChapa.Select()
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(txt_valorChapa, "Voce digitou valores incorretos, digite somente números!")
            ToolTip1.BackColor = Color.LightSalmon

        Else
            txt_valorChapa.BackColor = Color.White
            ToolTip1.RemoveAll()

        End If
    End Sub

    Private Sub txt_valorTotal_Validating(sender As Object, e As CancelEventArgs) Handles txt_valorTotal.Validating
        If Not IsNumeric(txt_valorTotal.Text) Then

            MsgBox("Favor digitar somente valores numéricos", MsgBoxStyle.Exclamation)
            txt_valorTotal.BackColor = Color.Red
            txt_valorTotal.Select()
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(txt_valorTotal, "Voce digitou valores incorretos, digite somente números!")
            ToolTip1.BackColor = Color.LightSalmon

        Else
            txt_valorTotal.BackColor = Color.White
            ToolTip1.RemoveAll()

        End If
    End Sub

    Private Sub txt_valorImposto_Validating(sender As Object, e As CancelEventArgs) Handles txt_valorImposto.Validating
        If Not IsNumeric(txt_valorImposto.Text) Then

            MsgBox("Favor digitar somente valores numéricos", MsgBoxStyle.Exclamation)
            txt_valorImposto.BackColor = Color.Red
            txt_valorImposto.Select()
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(txt_valorImposto, "Voce digitou valores incorretos, digite somente números!")
            ToolTip1.BackColor = Color.LightSalmon

        Else
            txt_valorImposto.BackColor = Color.White
            ToolTip1.RemoveAll()

        End If
    End Sub
End Class