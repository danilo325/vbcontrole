Public Class NovoProduto
    Dim bancodados As New AcessoDados
    Dim dicgrupo As New Dictionary(Of String, Integer)
    Private sinalerro As New ErrorProvider
    Private Sub bnt_Cancela_Click(sender As Object, e As EventArgs) Handles bnt_Cancela.Click
        Me.Close()
    End Sub

    Private Sub LimpaCampos()
        txt_Descricao.Clear()
        txt_PrecoCusto.Clear()
        txt_Quantidade.Clear()
        txt_Unidade.Clear()
        cmb_Grupo.ResetText()
        chk_Ativo.Checked = True
        chk_Produzido.Checked = False
    End Sub
    Private Sub bnt_Limpa_Click(sender As Object, e As EventArgs) Handles bnt_Limpa.Click
        LimpaCampos()
    End Sub

    Public Function VerificaEntradas() As Boolean
        Dim mensage As String = ""
        Dim temerro As Boolean = False
        Try
            'Verifica o campo descrição
            If IsNothing(txt_Descricao.Text) Or txt_Descricao.Text = "" Then
                txt_Descricao.ForeColor = Color.Red
                mensage += " Não se pode deixar a descrição vazio."
                temerro = True
                sinalerro.SetError(txt_Descricao, "Campo não pode ficar vazio")
            Else
                txt_Descricao.ForeColor = DefaultForeColor
                txt_Descricao.CharacterCasing = CharacterCasing.Upper
                sinalerro.SetError(txt_Descricao, String.Empty)
            End If
            'Verifica o campo Unidade
            If IsNothing(txt_Unidade.Text) Or txt_Unidade.Text = "" Then
                txt_Unidade.ForeColor = Color.Red
                mensage += " Não se pode deixar a Unidade vazio."
                temerro = True
                sinalerro.SetError(txt_Unidade, "Não pode deixar este campo vazio")
            Else
                txt_Unidade.ForeColor = DefaultForeColor
                txt_Unidade.CharacterCasing = CharacterCasing.Upper
                sinalerro.SetError(txt_Unidade, String.Empty)
            End If
            'Verifica o campo Grupo
            If IsNothing(cmb_Grupo.Text) Or cmb_Grupo.Text = "" Then
                cmb_Grupo.ForeColor = Color.Red
                mensage += " Não se pode deixar a Grupo vazio."
                temerro = True
                sinalerro.SetError(cmb_Grupo, "Não se pode deixar o campo vazio")
            ElseIf Not dicgrupo.ContainsKey(cmb_Grupo.Text) Then
                sinalerro.SetError(cmb_Grupo, "O grupo escolhido não existe")
                mensage += " Escolha um grupo válido."
                temerro = True
            Else
                cmb_Grupo.ForeColor = DefaultForeColor
                sinalerro.SetError(cmb_Grupo, String.Empty)
            End If
            'Verifica o campo Quantidade
            If IsNothing(txt_Quantidade.Text) Or txt_Quantidade.Text = "" Then
                txt_Quantidade.Text = 0
            ElseIf Not IsNumeric(txt_Quantidade.Text) Then
                temerro = True
                mensage += "A quantidade deve ser um valor numérico"
                sinalerro.SetError(txt_Quantidade, "O valor da quantidade não é válido")
            Else
                sinalerro.SetError(txt_Quantidade, String.Empty)
            End If
            'Verifica o campo preço de custo
            If IsNothing(txt_PrecoCusto.Text) Or txt_PrecoCusto.Text = "" Then
                txt_PrecoCusto.Text = 0
            ElseIf Not IsNumeric(txt_PrecoCusto.Text) Then
                temerro = True
                mensage += "O preço de custo deve ser um valor numérico"
                sinalerro.SetError(txt_PrecoCusto, "O preço de custo não é válido")
            Else
                sinalerro.SetError(txt_PrecoCusto, String.Empty)
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
            Dim prod As New Produto(txt_Descricao.Text, dicgrupo.Item(cmb_Grupo.Text), Double.Parse(txt_Quantidade.Text), txt_Unidade.Text, Double.Parse(txt_PrecoCusto.Text), chk_Produzido.Checked, chk_Ativo.Checked)
            Try
                bancodados.IncluiProduto(prod)
            Catch ex As Exception
                MsgBox("Foram encontrados problemas para conectar ao banco de dados." & vbCrLf & ex.ToString)
                Return
            End Try
            MsgBox("O produto " & txt_Descricao.Text & " foi criado com sucesso")
            LimpaCampos()
        End If

    End Sub

    Private Sub NovoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each prod As DataRow In bancodados.ComboGruposProduto.Rows
                dicgrupo.Add(prod(1).ToString, prod(0))

                cmb_Grupo.Items.Add(prod(1).ToString)
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        chk_Ativo.Checked = True
        'TODO: esta linha de código carrega dados na tabela 'LiderBancoDadosDataSet.gruposProduto'. Você pode movê-la ou removê-la conforme necessário.
        'Me.GruposProdutoTableAdapter.Fill(Me.LiderBancoDadosDataSet.gruposProduto)

    End Sub
End Class