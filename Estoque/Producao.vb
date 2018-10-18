Public Class Producao

    ' Cria as colunas para mostrar no DataGridView

    Private IdProducao, ProdutoEntra, QuantidadeEntra, ProdutoSai, QuantidadeSai, Data, Obs As New DataGridViewTextBoxColumn
    Private dados As New AcessoDados


    'Chama o formulário de inclusão de nova produção
    Private Sub bnt_inclui_Click(sender As Object, e As EventArgs) Handles bnt_inclui.Click
        NovaProducao.Visible = True
    End Sub


    Private Sub ValidaId() Handles txt_idproducao.TextChanged
        If Not Integer.TryParse(txt_idproducao.Text, 1) Then
            txt_idproducao.Text = ""
            MsgBox("O id é um número")
        End If
    End Sub


    Private Sub bnt_pesquisa_Click(sender As Object, e As EventArgs) Handles bnt_pesquisa.Click

        dados.PreencheProducao(dgv_producao,
                               If(txt_idproducao.Text <> "", txt_idproducao.Text, Nothing),
                               cmb_materiaPrima.SelectedValue,
                               cmb_produzido.SelectedValue,
                               If(dtp_incial.Checked, dtp_incial.Value.ToString, Nothing),
                               If(dtp_final.Checked, dtp_incial.Value.ToString, Nothing))
    End Sub



    'Carrega as informações na tela inicial 
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
            cmb_produzido.Items.Add("")
            cmb_materiaPrima.Items.Add("")

            With cmb_materiaPrima
                .DataSource = dados.DiciProduto
                .DisplayMember = "Descricao"
                .ValueMember = "IdProduto"
            End With
            With cmb_produzido
                .DataSource = dados.DiciProduto
                .DisplayMember = "Descricao"
                .ValueMember = "IdProduto"
            End With
            cmb_materiaPrima.Text = ""
            cmb_produzido.Text = ""
            cmb_produzido.SelectedValue = 0
            cmb_materiaPrima.SelectedValue = 0
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