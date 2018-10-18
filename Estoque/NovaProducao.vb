Public Class NovaProducao
    Private dados As New AcessoDados

    Private IdProducao, QuantidadeEntra, QuantidadeSai, Data, Obs As New DataGridViewTextBoxColumn

    Private Sub bnt_gravar_Click(sender As Object, e As EventArgs) Handles bnt_gravar.Click
        For Each produ As DataGridViewRow In dgv_producao.Rows
            If Not produ.IsNewRow Then
                dados.GravaProducao(produ.Cells(0).Value, produ.Cells(1).Value, produ.Cells(2).Value, produ.Cells(3).Value, produ.Cells(4).Value, produ.Cells(5).Value)
            End If
        Next produ
    End Sub

    Private ProdutoEntra, ProdutoSai As New DataGridViewComboBoxColumn

    Private Sub NovaProducao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With IdProducao
            .HeaderText = "ID"
            .Name = "id"
            .ToolTipText = "Identificador único da produção."
        End With

        With ProdutoEntra
            .DataSource = dados.DiciProduto
            .DisplayMember = "Descricao"
            .ValueMember = "IdProduto"
            .HeaderText = "Materia Prima"
            .Name = "materiaprima"
            .ToolTipText = "Identifica o produto utilizado como materia prima."
        End With

        With ProdutoSai
            .DataSource = dados.DiciProduto
            .DisplayMember = "Descricao"
            .ValueMember = "IdProduto"
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
        dgv_producao.Columns.AddRange(Data, ProdutoEntra, QuantidadeEntra, ProdutoSai, QuantidadeSai, Obs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_producao.CellContentClick

    End Sub


End Class