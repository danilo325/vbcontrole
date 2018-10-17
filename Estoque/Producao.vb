Public Class Producao
    Private IdProducao, ProdutoEntra, QuantidadeEntra, ProdutoSai, QuantidadeSai, Data, Obs As New DataGridViewTextBoxColumn
    Private dicioProdu As New Dictionary(Of String, Integer)
    Private dados As New AcessoDados

    Private Sub bnt_pesquisa_Click(sender As Object, e As EventArgs) Handles bnt_pesquisa.Click

        dados.PreencheProducao(dgv_producao, txt_idproducao.Text, dicioProdu.Item(cmb_materiaPrima.Text), dicioProdu(cmb_produzido.Text))
    End Sub

    Private Sub PreencheDic()
        For Each prod As DataRow In dados.DiciProduto.Rows
            dicioProdu.Add(prod(1).ToString, prod(0))
        Next prod
    End Sub
    Private Sub Producao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With IdProducao
            .HeaderText = "ID"
            .Name = "id"
            .ToolTipText = "Identificador único da produção."
        End With

        With ProdutoEntra
            .HeaderText = "Materia Prima"
            .Name = "materiaprima"
            .ToolTipText = "Identifica o produto utilizado como materia prima."
        End With

        With ProdutoSai
            .HeaderText = "Produzido"
            .Name = "produzido"
            .ToolTipText = "Diz qual produto foi produzido"
        End With
        With QuantidadeEntra
            .HeaderText = "Qtd Materia Prima"
            .Name = "qtdentra"
            .ToolTipText = "Diz o quanto de materia prima foi utilizado"
        End With
        With QuantidadeSai
            .HeaderText = "Qtd Produzida"
            .Name = "qtdsai"
            .ToolTipText = "Diz o quanto foi produzido"
        End With
        With Data
            .HeaderText = "Data Produção"
            .Name = "dtproducao"
            .ToolTipText = "Mostra a data da produçao"
        End With
        With Obs
            .HeaderText = "Obs"
            .Name = "obs"
            .ToolTipText = "Alguma informação relevante para a produçaõ"
        End With
        Try


            dgv_producao.Columns.AddRange(IdProducao, Data, ProdutoEntra, QuantidadeEntra, ProdutoSai, QuantidadeSai, Obs)
            dados.PreencheProducao(dgv_producao)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()
    End Sub
End Class