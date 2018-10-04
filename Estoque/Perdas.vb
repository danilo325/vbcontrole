Public Class Perdas
    Dim dados As New BdClass
    Dim dicProdutos As New Dictionary(Of String, Integer)
    Dim dicidnomeprod As New Dictionary(Of Integer, String)
    Dim colId, colQtdPerda, colData, colObsPerda As New DataGridViewTextBoxColumn


    Private Sub dicionarioprodutos()
        cmb_produto.Items.Add("")
        Dim tabelaprodutos As DataTable = dados.Pesquisa("SELECT Descricao, IdProduto FROM produto ")
        For Each produto As DataRow In tabelaprodutos.Rows
            cmb_produto.Items.Add(produto.Item(0).ToString)
            dicProdutos.Add(produto.Item(0).ToString, produto.Item(1))
            dicidnomeprod.Add(produto.Item(1), produto.Item(0).ToString)
        Next
    End Sub

    Private Sub bnt_pesquisa_Click(sender As Object, e As EventArgs) Handles bnt_pesquisa.Click
        pesquisa()
    End Sub

    Private Sub bnt_inclui_Click(sender As Object, e As EventArgs) Handles bnt_inclui.Click
        novaPerda.Visible = True
    End Sub

    'Incializa os dados
    Private Sub Perdas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        dicionarioprodutos()
        colId.HeaderText = "Produto"
        colId.Name = "id"
        colQtdPerda.HeaderText = "Qtd Perda"
        colQtdPerda.Name = "perda"
        colData.HeaderText = "Data"
        colData.Name = "data"
        colObsPerda.HeaderText = "Observação"
        colObsPerda.Name = "obs"
        'dgv_perdas.Columns.AddRange(colId, colQtdPerda, colData, colObsPerda)
        pesquisa()

    End Sub
    Private Sub pesquisa()
        Dim maisdeum As Boolean = False
        Dim resulquery As DataTable
        Dim query As String = "SELECT * FROM perdasProduto "
        If cmb_produto.Text <> "" Then
            If Not maisdeum Then
                query += " WHERE IdProduto = " & dicProdutos.Item(cmb_produto.Text)
                maisdeum = True
            Else
                maisdeum = True
                query += " AND IdProduto = " & dicProdutos.Item(cmb_produto.Text)
            End If
        End If
        If dtp_incial.Checked Then
            If dtp_final.Checked Then
                If Not maisdeum Then
                    maisdeum = True
                    query += " WHERE Data BETWEEN #" & Format(dtp_incial.Value, "MM/dd/yyyy") & "# AND #" & Format(dtp_final.Value, "MM/dd/yyyy") & "#"
                Else
                    maisdeum = True
                    query += " AND Data BETWEEN #" & Format(dtp_incial.Value, "MM/dd/yyyy") & "# AND #" & Format(dtp_final.Value, "MM/dd/yyyy") & "#"
                End If
            Else
                If Not maisdeum Then
                    maisdeum = True
                    query += " WHERE Data = #" & Format(dtp_incial.Value, "MM/dd/yyyy") & "#"
                Else
                    maisdeum = True
                    query += " AND Data = #" & Format(dtp_incial.Value, "MM/dd/yyyy") & "#"
                End If

            End If
        End If
        MsgBox(query)
        resulquery = dados.Pesquisa(query)
        dgv_perdas.DataSource = resulquery
        ''im da As DataGridViewRow
        ' For Each produto As DataRow In resulquery.Rows
        'next produto
    End Sub


    Private Sub bnt_fechar_Click(sender As Object, e As EventArgs) Handles bnt_fechar.Click
        Me.Close()
    End Sub
End Class