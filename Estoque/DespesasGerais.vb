Public Class DespesasGerais

    Dim dados As New BdClass
    Dim dicdispesas As New Dictionary(Of String, Integer)

    Private Sub combotipodespsas()
        Dim despesas As DataTable = dados.Pesquisa("SELECT Id, Descricao FROM tiposDespesas")
        cmb_tipodespesa.Items.Add("")
        For Each despesa As DataRow In despesas.Rows
            dicdispesas.Add(despesa.Item(1), despesa.Item(0))
            cmb_tipodespesa.Items.Add(despesa.Item(1))

        Next despesa
    End Sub
    Private Sub pesquisa()
        Dim str As String = "SELECT * FROM Despesas "
        Dim controle As Boolean = False

        If txt_numerodespesa.Text <> "" Then
            If controle Then
                str += " AND Id = " & txt_numerodespesa.Text
                controle = True
            Else
                str += "WHERE Id = " & txt_numerodespesa.Text
                controle = True

            End If
        End If
        If cmb_tipodespesa.Text <> "" Then
            If controle Then
                str += " AND TipoDespesa = " & dicdispesas.Item(cmb_tipodespesa.Text)
                controle = True
            Else
                str += "WHERE TipoDespesa = " & dicdispesas.Item(cmb_tipodespesa.Text)
                controle = True

            End If
        End If
        If dtp_datavencimento.Checked Then
            If controle Then
                str += " AND Vencimento = " & Format(dtp_datavencimento.Value, "dd/MM/yyyy")

                controle = True
            Else
                str += "WHERE Vencimento = " & Format(dtp_datavencimento.Value, "dd/MM/yyyy")
                controle = True

            End If

        End If
        If dtp_datadepagamento.Checked Then
            If controle Then
                str += " AND Pagamento = " & Format(dtp_datadepagamento.Value, "dd/MM/yyyy")

                controle = True
            Else
                str += "WHERE Pagamento = " & Format(dtp_datadepagamento.Value, "dd/MM/yyyy")
                controle = True

            End If

        End If
        MsgBox(str)
        dgv_listadespesa.DataSource = dados.Pesquisa(str)

    End Sub

    Private Sub bnt_fechar_Click(sender As Object, e As EventArgs) Handles bnt_fechar.Click
        Me.Close()
    End Sub

    Private Sub DespesasGerais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        combotipodespsas()
        pesquisa()
    End Sub

    Private Sub bnt_pesquisar_Click(sender As Object, e As EventArgs) Handles bnt_pesquisar.Click
        pesquisa()
    End Sub

    Private Sub bnt_novadespes_Click(sender As Object, e As EventArgs) Handles bnt_novadespes.Click
        NovaDespesaGeral.Visible = True

    End Sub
End Class