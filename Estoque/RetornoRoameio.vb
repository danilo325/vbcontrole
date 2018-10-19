Public Class RetornoRoameio
    Private dadosromaneio As New AcessoRomaneio
    Private dadosconex As New BdClass
    Private dicprodnome As New Dictionary(Of String, Integer)
    Private dicprodid As New Dictionary(Of Integer, String)
    Private idproduto, quantidadeS, QuantidadeR, QuantidadeV As New DataGridViewTextBoxColumn
    Private nome As New DataGridViewComboBoxColumn
    Private linhaantiga As New DataGridView

    Private Sub RetornoRoameio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each pro As DataRow In dadosromaneio.VerificaProdutos().Rows
                dicprodid.Add(pro("IdProduto"), pro("Descricao"))
                dicprodnome.Add(pro("Descricao"), pro("IdProduto"))
            Next pro

            With nome
                .DataSource = dadosromaneio.VerificaProdutos
                .DisplayMember = "Descricao"
                ' .ValueMember = "IdProduto"
                .AutoComplete = True
                .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox

                .HeaderText = "Descrição"
                .Name = "descricao"
            End With
            With QuantidadeV
                .HeaderText = "Quantidade Vendida"
                .Name = "qtdv"
            End With

            With idproduto
                .HeaderText = "Id Produto"
                .Name = "idproduto"

            End With
            With quantidadeS
                .HeaderText = " qtd Saida"
                .Name = "qtds"
            End With
            With QuantidadeR
                .HeaderText = " qtd Retorno"
                .Name = "qtdr"
            End With

            dgv_produto.Columns.AddRange(idproduto, nome, quantidadeS, QuantidadeR, QuantidadeV)


            For Each produto As DataGridViewRow In Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.Rows
                If Not produto.IsNewRow Then
                    dgv_produto.Rows.Add(dicprodnome(produto.Cells(1).Value), produto.Cells(1).Value, produto.Cells(2).Value)
                End If

            Next
            idproduto.ReadOnly = True
            nome.ReadOnly = True
            quantidadeS.ReadOnly = True
        Catch ex As Exception
            MsgBox("Problema " & ex.ToString)
        End Try
    End Sub

    Private Sub dgv_produto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produto.CellEndEdit

        Dim est As Double = dgv_produto.Rows(e.RowIndex).Cells("qtds").Value - dgv_produto.Rows(e.RowIndex).Cells("qtdr").Value
        dgv_produto.Rows(e.RowIndex).Cells("qtdv").Value = est
        dadosromaneio.RetornoRomaneio(lbl_id.Text, dgv_produto.Rows(e.RowIndex).Cells("idproduto").Value, dgv_produto.Rows(e.RowIndex).Cells("qtdr").Value, est, dgv_produto.Rows(e.RowIndex).Cells("qtds").Value - dgv_produto.Rows(e.RowIndex).Cells("qtdv").Value)
    End Sub
End Class