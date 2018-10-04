Public Class NovoAbastecimento
    Dim dados As New BdClass
    Dim dicveiculo, diccombustivel As New Dictionary(Of String, Integer)

    Private Sub dtp_dataabasteci_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dataabasteci.ValueChanged

    End Sub
    Private Sub comboveiculos()
        Dim veiculos As DataTable = dados.Pesquisa("SELECT id, placa FROM Veiculos")
        cmb_veiculo.Items.Add("")
        For Each veiculo As DataRow In veiculos.Rows
            dicveiculo.Add(veiculo.Item(1), veiculo.Item(0))
            cmb_veiculo.Items.Add(veiculo.Item(1))
        Next veiculo

    End Sub
    Private Sub gravadados()
        Dim str As String = ("INSERT INTO abastecimentos (IdVeicuo,NumeroPedido,LocalAbastecimento,Combustivel,Qtd,ValorLitro,ValorTotal,Data,Obs) VALUES (" &
                       dicveiculo.Item(cmb_veiculo.Text) & ", " & txt_npedido.Text & ",'" & txt_local.Text & "'," & diccombustivel(cmb_combustivel.Text) &
                       ",'" & txt_qtdlitros.Text & "','" & txt_valorlitro.Text & "','" & txt_valortotal.Text & "','" & Format(dtp_dataabasteci.Value, "dd/MM/yyyy") & "','" &
                       txt_obs.Text & "')")
        MsgBox(str)
        dados.Pesquisa(str)
        MsgBox(str)
    End Sub
    Private Sub combocombustivel()
        Dim combustiveis As DataTable = dados.Pesquisa("SELECT Id, Nome FROM tiposCombustivel")
        cmb_combustivel.Items.Add("")
        For Each combustivel As DataRow In combustiveis.Rows
            diccombustivel.Add(combustivel.Item(1), combustivel.Item(0))
            cmb_combustivel.Items.Add(combustivel.Item(1))
        Next combustivel
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gravadados()
    End Sub

    Private Sub NovoAbastecimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        comboveiculos()
        combocombustivel()
    End Sub
End Class