Public Class FinalizaRomaneio

    'Define um erro que aparece ao se digitar numeros nas caixas de texto
    Dim erroo As New ErrorProvider
    Private acesso As New AcessoRomaneio


    'Resumo:
    ' Carrega as informações iniciais do formulário
    Private Sub FinalizaRomaneio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_NomeVendedor.Enabled = False
        dtp_dataRomaneio.Enabled = False
        txt_VBoleto.Text = 0
        txt_VCheque.Text = 0
        txt_VDinheiro.Text = 0
        txt_VFiado.Text = 0
        txt_VMoeda.Text = 0

        dgv_ProdutosRomaneio.Enabled = False
    End Sub



    Private Sub txt_VBoleto_Validated(sender As Object, e As EventArgs) Handles txt_VBoleto.Validated
        VerificaCampos()
    End Sub
    Private Sub txt_VCheque_Validated(sender As Object, e As EventArgs) Handles txt_VCheque.Validated
        VerificaCampos()
    End Sub
    Private Sub txt_VDinheiro_Validated(sender As Object, e As EventArgs) Handles txt_VDinheiro.Validated
        VerificaCampos()
    End Sub

    Private Sub txt_VMoeda_Validated(sender As Object, e As EventArgs) Handles txt_VMoeda.Validated

        VerificaCampos()
    End Sub
    Private Sub txt_VFiado_Validated(sender As Object, e As EventArgs) Handles txt_VFiado.Validated
        VerificaCampos()
    End Sub


    'Resumo:
    '   Verifica se as informações do campos de valores estão preenchidos de forma correta
    Private Function VerificaCampos() As Boolean

        Dim tt As New ToolTip
        tt.IsBalloon = False

        'verifica o campo boleto
        If String.IsNullOrEmpty(txt_VBoleto.Text) Then
            tt.ForeColor = Color.Yellow
            tt.Show("Quando ficar vazio o valor será 0", txt_VBoleto, 1000, 1, 1)
            txt_VBoleto.Text = 0
        Else

            If Not IsNumeric(txt_VBoleto.Text) Then
                tt.Active = True
                'tt.IsBalloon = True
                tt.BackColor = Color.Yellow
                tt.ToolTipIcon = ToolTipIcon.Warning
                ' tt.SetToolTip(txt_VBoleto, "O valor digitado deve ser um número")
                tt.ShowAlways = True
                tt.UseAnimation = True
                tt.Show("Digite somente números", txt_VBoleto, 1000)
                erroo.SetError(txt_VBoleto, "O valor deverá ser um número")
                Return False
            Else
                erroo.SetError(txt_VBoleto, String.Empty)
                tt.RemoveAll()
            End If
        End If
        'verifica o campo cheque
        If String.IsNullOrEmpty(txt_VCheque.Text) Then
            tt.ForeColor = Color.Yellow
            tt.Show("Quando ficar vazio o valor será o", Me.txt_VCheque, 1000, 1, 1)
            txt_VCheque.Text = 0
        Else

            If Not IsNumeric(txt_VCheque.Text) Then
                tt.Active = True
                tt.IsBalloon = True
                tt.BackColor = Color.Yellow
                tt.ToolTipIcon = ToolTipIcon.Warning
                ' tt.SetToolTip(txt_VBoleto, "O valor digitado deve ser um número")
                tt.ShowAlways = True
                tt.UseAnimation = True
                tt.Show("Digite somente números", Me.txt_VCheque, 1000)
                erroo.SetError(txt_VCheque, "O valor deverá ser um número")
                Return False
            Else
                erroo.SetError(txt_VCheque, String.Empty)

            End If
        End If
        'verifica o campo dinheiro
        If String.IsNullOrEmpty(txt_VDinheiro.Text) Then
            tt.ForeColor = Color.Yellow
            tt.Show("Quando ficar vazio o valor será o", Me.txt_VDinheiro, 1000, 1, 1)
            txt_VDinheiro.Text = 0
        Else

            If Not IsNumeric(txt_VDinheiro.Text) Then
                tt.Active = True
                tt.IsBalloon = True
                tt.BackColor = Color.Yellow
                tt.ToolTipIcon = ToolTipIcon.Warning
                ' tt.SetToolTip(txt_VBoleto, "O valor digitado deve ser um número")
                tt.ShowAlways = True
                tt.UseAnimation = True
                tt.Show("Digite somente números", Me.txt_VDinheiro, 1000)
                erroo.SetError(txt_VDinheiro, "O valor deverá ser um número")
                Return False
            Else
                erroo.SetError(txt_VDinheiro, String.Empty)

            End If
        End If
        'verifca o campo fiado
        If String.IsNullOrEmpty(txt_VFiado.Text) Then
            tt.ForeColor = Color.Yellow
            tt.Show("Quando ficar vazio o valor será o", Me.txt_VFiado, 1000, 1, 1)
            txt_VFiado.Text = 0
        Else

            If Not IsNumeric(txt_VFiado.Text) Then
                tt.Active = True
                tt.IsBalloon = True
                tt.BackColor = Color.Yellow
                tt.ToolTipIcon = ToolTipIcon.Warning
                ' tt.SetToolTip(txt_VBoleto, "O valor digitado deve ser um número")
                tt.ShowAlways = True
                tt.UseAnimation = True
                tt.Show("Digite somente números", Me.txt_VFiado, 1000)
                erroo.SetError(txt_VFiado, "O valor deverá ser um número")
                Return False
            Else
                erroo.SetError(txt_VFiado, String.Empty)
            End If
        End If
        'verifica o campo moedas
        If String.IsNullOrEmpty(txt_VMoeda.Text) Then
            tt.ForeColor = Color.Yellow
            tt.Show("Quando ficar vazio o valor será o", Me.txt_VMoeda, 1000, 1, 1)
            txt_VMoeda.Text = 0
        Else

            If Not IsNumeric(txt_VMoeda.Text) Then
                tt.Active = True
                tt.IsBalloon = True
                tt.BackColor = Color.Yellow
                tt.ToolTipIcon = ToolTipIcon.Warning
                ' tt.SetToolTip(txt_VBoleto, "O valor digitado deve ser um número")
                tt.ShowAlways = True
                tt.UseAnimation = True
                tt.Show("Digite somente números", Me.txt_VMoeda, 1000)
                erroo.SetError(txt_VMoeda, "O valor deverá ser um número")
                Return False
            Else

                erroo.SetError(txt_VMoeda, String.Empty)

            End If
        End If


        Return True
    End Function

    Public Sub GravaFinaliza()
        If VerificaCampos() Then
            acesso.FinalizaRoamenio(lbl_idromaneio.Text, txt_VCheque.Text, txt_VDinheiro.Text, txt_VMoeda.Text, txt_VBoleto.Text, txt_VFiado.Text)
        End If
    End Sub

    Private Sub bnt_finaliza_Click(sender As Object, e As EventArgs) Handles bnt_finaliza.Click
        GravaFinaliza()
    End Sub
End Class