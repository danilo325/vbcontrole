Public Class AdicionaDespesaVeiculo
    Dim dados As New BdClass
    Dim dicveiculo As New Dictionary(Of String, Integer)
    Private Sub comboveiculos()
        Dim veiculos As DataTable = dados.Pesquisa("SELECT id, placa FROM Veiculos")
        cmb_veiculo.Items.Add("")
        For Each veiculo As DataRow In veiculos.Rows
            dicveiculo.Add(veiculo.Item(1), veiculo.Item(0))
            cmb_veiculo.Items.Add(veiculo.Item(1))
        Next veiculo

    End Sub
    Private Sub gravadados()
        Dim str As String = ("INSERT INTO despesasVeicuos (IdVeiculo,TipoDespesa,Data,Valor,Obs) VALUES (" &
                       dicveiculo.Item(cmb_veiculo.Text) & ", '" & txt_tipo.Text & "','" & Format(dtp_datadespesa.Value, "dd/MM/yyyy") & "'," & txt_valor.Text & ",'" & txt_obs.Text & "')")
        MsgBox(str)
        dados.Pesquisa(str)
        MsgBox(str)
    End Sub



    Private Sub AdicionaDespesaVeiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        comboveiculos()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gravadados()
    End Sub
End Class