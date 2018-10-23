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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GravaRetorno()
    End Sub

    Private Function VerificaCelulas(celula As DataGridViewCell) As Boolean
        If IsDBNull(celula.Value) Then
            celula.Value = 0
            celula.ErrorText = ""
            celula.ToolTipText = "O valor da celula foi colocado como 0"

        Else
            If Not IsNumeric(celula.Value) Then
                celula.ErrorText = "Por favor digitar somente numeros"
                celula.ToolTipText = ""
                Return False
            Else
                If celula.Value > dgv_produto.Rows(celula.RowIndex).Cells(celula.ColumnIndex - 1).Value Then
                    celula.ErrorText = " A quantidade de retorno não pode ser maior que a saida"
                    celula.ToolTipText = ""
                    Return False
                End If
            End If
        End If
        celula.ErrorText = ""
        celula.ToolTipText = ""
        Return True

    End Function


    Private Sub GravaRetorno()
        Dim ok As Boolean = False
        For Each produto As DataGridViewRow In dgv_produto.Rows
            If Not produto.IsNewRow Then
                If Not VerificaCelulas(produto.Cells("qtdr")) Then
                    Return
                End If
            End If
        Next produto

        For Each produto As DataGridViewRow In dgv_produto.Rows
            If Not produto.IsNewRow Then
                Dim est As Double = dgv_produto.Rows(produto.Index).Cells("qtds").Value - dgv_produto.Rows(produto.Index).Cells("qtdr").Value
                dadosromaneio.RetornoRomaneio(lbl_id.Text, dgv_produto.Rows(produto.Index).Cells("idproduto").Value, dgv_produto.Rows(produto.Index).Cells("qtdr").Value, est, dgv_produto.Rows(produto.Index).Cells("qtdv").Value)
            End If
        Next produto

    End Sub
    Private Sub dgv_produto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produto.CellEndEdit
        If VerificaCelulas(dgv_produto.Rows(e.RowIndex).Cells("qtdr")) Then
            dgv_produto.Rows(e.RowIndex).Cells("qtdv").Value = dgv_produto.Rows(e.RowIndex).Cells("qtds").Value - dgv_produto.Rows(e.RowIndex).Cells("qtdr").Value
        End If

    End Sub
End Class