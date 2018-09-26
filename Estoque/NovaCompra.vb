﻿Public Class frm_novaCompra
    Dim comboproduto As New DataGridViewComboBoxColumn
    Dim textcolqtd, textcolComNota, textColValor, textcolImposto As New DataGridViewTextBoxColumn
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


    Private Sub dgv_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_fretePlaca_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_obsChapa_TextChanged(sender As Object, e As EventArgs) Handles txt_obsChapa.TextChanged

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
        Dim qtdcompras As Integer = 0
        Dim strGrava As String = "INSERT INTO compras (IdForncedor ,NumeroPedido,DataCompra,ValorCompra,ImpostoCompra,ObsCompra) VALUES ("
        strGrava += dicFornecedor.Item(cmb_fornecedor.Text) & ","
        strGrava += txt_numeroPedido.Text & ","
        strGrava += "'" & Format(dtp_data.Value, "dd/MM/yyyy") & "',"
        strGrava += txt_valorTotal.Text & ","
        strGrava += txt_valorImposto.Text & ","
        strGrava += "'" & txt_obs.Text & "')"
        bancodados.Pesquisa(strGrava)
        idcompra = bancodados.Pesquisa("SELECT MAX(IdCompras) FROM compras").Rows(0).Item(0)

        strGrava = "INSERT INTO transporteCompra (IdCompra, Tipo, Valor,Obs) VALUES ( " &
            idcompra & ",'" & cmb_tipoTrasporte.Text & "'," & txt_freteValor.Text & ",'" & txt_freteObs.Text & "')"
        bancodados.Pesquisa(strGrava)
        strGrava = "INSERT INTO chapa (IdTansporte, Valor,Obs) VALUES ( " &
            bancodados.Pesquisa("SELECT MAX(Id) FROM transporteCompra").Rows(0).Item(0) & "," & txt_valorChapa.Text & ",'" & txt_obsChapa.Text & "')"
        bancodados.Pesquisa(strGrava)

        For Each prod As DataGridViewRow In dgv_produtos.Rows
            If Not prod.IsNewRow Then

                bancodados.Pesquisa("UPDATE produto SET Qtd =" & (bancodados.Pesquisa("SELECT Qtd FROM produto WHERE IdProduto =" & dicProdutos.Item(prod.Cells(0).Value.ToString)).Rows(0).Item(0) + prod.Cells(1).Value) & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))

                bancodados.Pesquisa("INSERT INTO produtosCompra VALUES ( " & idcompra & "," & dicProdutos.Item(prod.Cells(0).Value.ToString) &
                                    "," & prod.Cells(1).Value.ToString & "," & prod.Cells(2).Value.ToString & "," & prod.Cells(3).Value.ToString & "," &
                                     prod.Cells(4).Value.ToString & ")")
                qtdcompras += prod.Cells(1).Value
            End If
        Next prod
        For Each prod As DataGridViewRow In dgv_produtos.Rows
            Dim vci As Integer = 0

            If Not prod.IsNewRow Then
                If prod.Cells(4).Value > 0 Then
                    vci = (prod.Cells(1).Value / prod.Cells(4).Value)
                End If
                Dim vdec As Decimal = FormatNumber((prod.Cells(3).Value + vci + ((FormatNumber(txt_freteValor.Text.ToString, 2) + FormatNumber(txt_valorChapa.Text.ToString, 2)) / qtdcompras)), 2)
                MsgBox(vdec)
                MsgBox("UPDATE produto SET Pcusto =" & vdec & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
                ' bancodados.Pesquisa("UPDATE produto SET Pcusto =" & bancodados.Pesquisa("SELECT Pcusto FROM produto WHERE IdProduto =" & dicProdutos.Item(prod.Cells(0).Value.ToString)).Rows(0).Item(0) + prod.Cells(3).Value & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
                bancodados.Pesquisa("UPDATE produto SET Pcusto =" & vdec & " WHERE IdProduto = " & dicProdutos.Item(prod.Cells(0).Value.ToString))
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

        dgv_produtos.Columns.Add(comboproduto)
        dgv_produtos.Columns.Add(textcolqtd)
        dgv_produtos.Columns.Add(textcolComNota)
        dgv_produtos.Columns.Add(textColValor)
        dgv_produtos.Columns.Add(textcolImposto)
        cmb_tipoTrasporte.Items.Add("")
        cmb_tipoTrasporte.Items.Add("Frete")
        cmb_tipoTrasporte.Items.Add("Proprio")

    End Sub
End Class