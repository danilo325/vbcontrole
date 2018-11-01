Public Class EditaRomaneioSaida
    Private dadosromaneio As New AcessoRomaneio
    Private dadosconex As New BdClass
    Private dicprodnome As New Dictionary(Of String, Integer)
    Private dicprodid As New Dictionary(Of Integer, String)
    Private idproduto, quantidade As New DataGridViewTextBoxColumn
    Private nome As New DataGridViewComboBoxColumn
    Private linhaantiga As New DataGridView
    Private numerodelinhas As Integer = 0

    Private Sub EditaRomaneioSaida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            With idproduto
                .HeaderText = "Id Produto"
                .Name = "idproduto"

            End With
            With quantidade
                .HeaderText = " Quantidade"
                .Name = "qtd"
            End With

            dgv_produto.Columns.AddRange(idproduto, nome, quantidade)
            linhaantiga.Columns.AddRange(idproduto.Clone, nome.Clone, quantidade.Clone)

            For Each produto As DataGridViewRow In Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.Rows
                If Not produto.IsNewRow Then
                    dgv_produto.Rows.Add(dicprodnome(produto.Cells(1).Value), produto.Cells(1).Value, produto.Cells(2).Value)

                End If

            Next
            For Each produto As DataGridViewRow In dgv_produto.Rows
                If Not produto.IsNewRow Then
                    produto.Cells(0).ReadOnly = True
                    produto.Cells(1).ReadOnly = True

                End If

            Next
            ' idproduto.ReadOnly = True
            '  nome.ReadOnly = True
        Catch ex As Exception
            MsgBox("Problema " & ex.ToString)
        End Try
        numerodelinhas = dgv_produto.Rows.Count

    End Sub


    Private Sub dgv_produto_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_produto.CellBeginEdit
        Try
            linhaantiga.Rows.Add(dgv_produto.Rows(e.RowIndex).Cells(0).Value, dgv_produto.Rows(e.RowIndex).Cells(1).Value, dgv_produto.Rows(e.RowIndex).Cells(2).Value)

        Catch ex As Exception
            MsgBox("Ops linha antiga " & ex.ToString)
        End Try

    End Sub

    Private Sub bnt_addProduto_Click(sender As Object, e As EventArgs) Handles bnt_addProduto.Click

        NovoProdutoRomaneioSaida.Show()
    End Sub

    Private Sub dgv_produto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produto.CellEndEdit
        Dim resultado As Double = 0
        Try
            '  MsgBox("linha " & e.RowIndex & "coluna" & e.ColumnIndex)
            '  MsgBox("opasasasas " & numerodelinhas)

            If e.RowIndex > numerodelinhas - 2 Then
                If e.ColumnIndex = 0 Then
                    dgv_produto.Item(1, e.RowIndex).Value = dicprodid.Item(dgv_produto.Item(0, e.RowIndex).Value)
                ElseIf e.ColumnIndex = 1 Then
                    dgv_produto.Item(0, e.RowIndex).Value = dicprodnome.Item(dgv_produto.Item(1, e.RowIndex).Value)
                End If
                If Not String.IsNullOrEmpty(dgv_produto.Item(0, e.RowIndex).Value) And Not String.IsNullOrEmpty(dgv_produto.Item(1, e.RowIndex).Value) And Not String.IsNullOrEmpty(dgv_produto.Item(2, e.RowIndex).Value) Then
                    MsgBox("opasasasas " & numerodelinhas)
                    If dadosromaneio.AcrescentaProdutoRomaneio(dgv_produto.Rows(e.RowIndex).Cells(0).Value, lbl_id.Text, dgv_produto.Rows(e.RowIndex).Cells(2).Value) Then
                        dgv_produto.Rows(e.RowIndex).Cells(0).ReadOnly = True
                        dgv_produto.Rows(e.RowIndex).Cells(1).ReadOnly = True
                        numerodelinhas = dgv_produto.Rows.Count
                    End If
                End If
            Else

                If linhaantiga.Rows(0).Cells(2).Value <> dgv_produto.Rows(e.RowIndex).Cells(2).Value Then
                    resultado = dgv_produto.Rows(e.RowIndex).Cells(2).Value - linhaantiga.Rows(0).Cells(2).Value
                    '  MsgBox("veja " & dgv_produto.Rows(e.RowIndex).Cells(2).Value & " - " & linhaantiga.Rows(0).Cells(2).Value & " = " & resultado)
                    dadosromaneio.ModificaProdutoSaida(lbl_id.Text, linhaantiga.Rows(0).Cells(0).Value, dgv_produto.Rows(e.RowIndex).Cells(2).Value, resultado)
                End If
            End If
        Catch ex As Exception
            MsgBox("Atualziando " & ex.ToString)
        Finally
            linhaantiga.Rows.Clear()
        End Try


    End Sub


End Class