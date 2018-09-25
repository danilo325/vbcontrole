Public Class NovaDespesaGeral
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
    Private Sub gravadados()
        Dim str As String = "INSERT INTO Despesas ( Despesa, TipoDespesa,Valor,Vencimento,Pagamento,Obs) VALUES ("
        str += "'" & txt_despesa.Text & "',"
        str += dicdispesas.Item(cmb_tipodespesa.Text) & ","
        str += txt_valor.Text & ","
        str += "'" & Format(dtp_datadevencimento.Value, "dd/MM/yyyy") & "',"
        str += "'" & Format(dtp_datadepagamento.Value, "dd/MM/yyyy") & "',"
        str += "'" & txt_obs.Text & "')"
        dados.Pesquisa(str)
    End Sub
    Private Sub NovaDespesaGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        combotipodespsas()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gravadados()
    End Sub
End Class