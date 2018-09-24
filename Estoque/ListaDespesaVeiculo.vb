Public Class ListaDespesaVeiculo
    Dim dicveiculoas As New Dictionary(Of String, Integer)
    Dim dado As New BdClass
    Private Sub comboveiculos()
        cmb_veiculos.Items.Add("")
        Dim veiculos As DataTable = dado.Pesquisa("SELECT id , Apelido FROM Veiculos")
        For Each veiculo As DataRow In veiculos.Rows
            dicveiculoas.Add(veiculo.Item(1), veiculo.Item(0))
            cmb_veiculos.Items.Add(veiculo.Item(1))
        Next veiculo

    End Sub
    Private Sub pesquisa()
        Dim str As String = "SELECT * FROM despesasVeicuos "
        Dim maisdeum As Boolean = False

        If cmb_veiculos.Text <> "" Then
            If maisdeum Then
                str += " AND IdVeiculo = " & dicveiculoas.Item(cmb_veiculos.Text)
                maisdeum = True
            Else
                maisdeum = True
                str += " WHERE IdVeiculo = " & cmb_veiculos.Text
            End If

        End If
        If txt_numerodespesa.Text <> "" Then
            If maisdeum Then
                str += " AND Id = " & txt_numerodespesa.Text
                maisdeum = True
            Else
                maisdeum = True
                str += " WHERE Id = " & txt_numerodespesa.Text
            End If
        End If
        If txt_tipodespesa.Text <> "" Then
            If maisdeum Then
                str += " AND TipoDespesa LIKE %" & txt_tipodespesa.Text & "%"
                maisdeum = True
            Else
                maisdeum = True
                str += " WHERE  TipoDespesa LIKE %" & txt_tipodespesa.Text & "%"
            End If
        End If
        If dtp_datadespesai.Checked Then
            If maisdeum Then
                str += " AND Data = '" & Format(dtp_datadespesai.Value, "dd/MM/yyyy") & "'"
                maisdeum = True
            Else
                maisdeum = True
                str += " WHERE Data = '" & Format(dtp_datadespesai.Value, "dd/MM/yyyy") & "'"
            End If
        End If
        MsgBox(str)
        dgv_listadespesa.DataSource = dado.Pesquisa(str)

    End Sub


    Private Sub bnt_pesquisar_Click(sender As Object, e As EventArgs) Handles bnt_pesquisar.Click
        pesquisa()
    End Sub

    Private Sub bnt_fechar_Click(sender As Object, e As EventArgs) Handles bnt_fechar.Click
        Me.Close()
    End Sub

    Private Sub ListaDespesaVeiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dado.Abreconexao()
        comboveiculos()
        pesquisa()

    End Sub

    Private Sub bnt_novadespesa_Click(sender As Object, e As EventArgs) Handles bnt_novadespesa.Click
        AdicionaDespesaVeiculo.Visible = True
    End Sub
End Class