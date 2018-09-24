Public Class NovaManutencao
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
        'Dim str As String = ("INSERT INTO manutencaoVeiculos (IdVeiculo,Local,Manutencao,Data,Valor,Obs) VALUES (" &
        Dim str As String = ("INSERT INTO manutencaoVeiculos (Idveiculo, LocalManutencao, Manutencao) VALUES ( " & dicveiculo.Item(cmb_veiculo.Text) & ",'" & txt_local.Text & "','" & txt_obs.Text & "')")
        MsgBox(str)
        dados.Pesquisa(str)
        ' MsgBox(str)
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gravadados()
    End Sub

    Private Sub NovaManutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.Abreconexao()
        comboveiculos()
    End Sub
End Class