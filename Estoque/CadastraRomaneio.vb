Public Class CadastraRomaneio

    Private dadosromaneio As New AcessoRomaneio
    Private dadosconex As New BdClass
    Private dicprodnome As New Dictionary(Of String, Integer)
    Private dicprodid As New Dictionary(Of Integer, String)
    Private idproduto, quantidade As New DataGridViewTextBoxColumn
    Private nome As New DataGridViewComboBoxColumn

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="celula"></param>
    ''' <param name="e"></param>
    Private Sub VerificaCelulas(dtg As DataGridView, e As DataGridViewCellEventArgs) Handles dgv_produto.CellEndEdit
        Dim celula As DataGridViewCell = dtg.Item(e.ColumnIndex, e.RowIndex)
        If Not dgv_produto.Rows(celula.RowIndex).IsNewRow Then
            If celula.ColumnIndex = 0 Then
                If dicprodid.ContainsKey(If(Integer.TryParse(celula.Value, 1), celula.Value, 0)) Then
                    dgv_produto.Item(1, celula.RowIndex).Value = dicprodid(celula.Value)
                Else
                    celula.Value = ""
                    MsgBox("O id digitado não representa nenhum produto")
                End If
            ElseIf celula.ColumnIndex = 1 Then
                If celula.Value.ToString <> "" Then
                    dgv_produto.Item(0, celula.RowIndex).Value = dicprodnome(celula.Value)
                    celula.ErrorText = ""
                    dgv_produto.Item(0, celula.RowIndex).ErrorText = ""
                Else
                    celula.ErrorText = "É necessario escolher um produto"
                    celula.Selected = True
                End If
            Else
                If Not IsNumeric(celula.Value) Then
                    celula.ErrorText = "Somente números"
                Else
                    celula.ErrorText = ""
                End If

            End If
            End If

    End Sub

    Private Function VerificaProdutos() As Boolean
        Dim temalgoerrado = False
        For Each produto As DataGridViewRow In dgv_produto.Rows
            If Not produto.IsNewRow Then


                If IsDBNull(produto.Cells(0).Value) Or Not IsNumeric(produto.Cells(0).Value) Then
                    produto.Cells(0).ErrorText = "Somente numeros que representem produtos"
                    temalgoerrado = True
                Else
                    If Not dicprodid.ContainsKey(produto.Cells(0).Value) Then
                        produto.Cells(0).ErrorText = "Somente numeros que representem produtos"
                        temalgoerrado = True
                    End If
                End If
                If String.IsNullOrEmpty(produto.Cells(1).Value) Or Not dicprodnome.ContainsKey(If(produto.Cells(1).Value <> "", produto.Cells(1).Value, 0)) Then
                    produto.Cells(1).ErrorText = "Verifique este valor"
                    temalgoerrado = True
                End If
                If IsDBNull(produto.Cells(2).Value) Or Not IsNumeric(produto.Cells(2).Value) Then
                    produto.Cells(2).ErrorText = "Somente numeros"
                    temalgoerrado = True
                End If
            End If
        Next produto

        Return temalgoerrado
    End Function


    Public Sub Cadastra()
        If cbm_vendedores.SelectedValue = 0 Then

            MsgBox("É preciso escolher um vendedor")
            Return
        End If
        If VerificaProdutos() Then
            MsgBox("Verifique os valores dos produtos")
            Return
        End If

        dadosromaneio.IncluiRomaneio(lbl_id.Text, cbm_vendedores.SelectedValue, dtp_data.Value, dgv_produto, "Saida", If(String.IsNullOrEmpty(txt_obs.Text), Nothing, txt_obs.Text))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastra()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CadastraRomaneio_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            dadosconex.Abreconexao()
            lbl_id.Text = dadosconex.tt2() + 1
            dadosconex.FechaConexao()

            With cbm_vendedores
                .DataSource = dadosromaneio.ListaVendedor
                .DisplayMember = "NomeVendedor"
                .ValueMember = "IdVendedor"
                .Text = ""
                .SelectedValue = 0
            End With

            For Each pro As DataRow In dadosromaneio.VerificaProdutos().Rows
                dicprodid.Add(pro("IdProduto"), pro("Descricao"))
                dicprodnome.Add(pro("Descricao"), pro("IdProduto"))
            Next pro

            With nome
                .DataSource = dadosromaneio.VerificaProdutos
                .DisplayMember = "Descricao"
                '  .ValueMember = "IdProduto"
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

        Catch ex As Exception
            MsgBox("Problema " & ex.ToString)
        End Try
    End Sub
End Class