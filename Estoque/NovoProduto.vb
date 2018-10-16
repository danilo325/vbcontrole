Public Class NovoProduto
    Dim bancodados As New AcessoDados
    Private Sub bnt_Cancela_Click(sender As Object, e As EventArgs) Handles bnt_Cancela.Click
        Me.Close()
    End Sub

    Private Sub bnt_Limpa_Click(sender As Object, e As EventArgs) Handles bnt_Limpa.Click
        txt_Descricao.Clear()
        txt_PrecoCusto.Clear()
        txt_Quantidade.Clear()
        txt_Unidade.Clear()
        cmb_Grupo.ResetText()
        chk_Ativo.Checked = False
        chk_Produzido.Checked = False

    End Sub

    Public Function VerificaEntradas() As Boolean
        Dim mensage As String = ""
        Dim temerro As Boolean = False
        Try
            If IsNothing(txt_Descricao.Text) Or txt_Descricao.Text = "" Then
                txt_Descricao.ForeColor = Color.Red
                mensage += " Não se pode deixar a descrição vazio."
                temerro = True
            Else
                txt_Descricao.ForeColor = DefaultBackColor
                txt_Descricao.CharacterCasing = CharacterCasing.Upper
            End If
            If IsNothing(txt_Unidade.Text) Or txt_Unidade.Text = "" Then
                txt_Unidade.ForeColor = Color.Red
                mensage += " Não se pode deixar a Unidade vazio."
                temerro = True
            Else
                txt_Unidade.ForeColor = DefaultBackColor
                txt_Unidade.CharacterCasing = CharacterCasing.Upper
            End If
            If IsNothing(cmb_Grupo.Text) Or cmb_Grupo.Text = "" Then
                cmb_Grupo.ForeColor = Color.Red
                mensage += " Não se pode deixar a Grupo vazio."
                temerro = True
            Else
                cmb_Grupo.ForeColor = DefaultBackColor

            End If
            If IsNothing(txt_Unidade.Text) Or txt_Unidade.Text = "" Then
                txt_Quantidade.Text = 0
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If temerro Then
            MsgBox(mensage)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        If VerificaEntradas() Then
            Dim prod As New Produto(txt_Descricao.Text, cmb_Grupo.SelectedValue, Double.Parse(txt_Quantidade.Text), txt_Unidade.Text, Double.Parse(txt_PrecoCusto.Text), chk_Produzido.Checked, chk_Ativo.Checked)
            Try
                bancodados.IncluiProduto(prod)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub NovoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'LiderBancoDadosDataSet.gruposProduto'. Você pode movê-la ou removê-la conforme necessário.
        'Me.GruposProdutoTableAdapter.Fill(Me.LiderBancoDadosDataSet.gruposProduto)

    End Sub
End Class