Public Class ListaAbastecimento
    Dim dicveiculoas As New Dictionary(Of String, Integer)
    Dim dado As New BdClass
    Private Sub ListaAbastecimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_dataabastecimentof.Checked = False
        dtp_dataabastecimentoi.Checked = False
        dado.Abreconexao()
        pesquisa()
        comboveiculos()
    End Sub
    Private Sub pesquisa()
        Dim str As String = "SELECT * FROM abastecimentos "
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
        If txt_numeropeido.Text <> "" Then
            If maisdeum Then
                str += " AND NumeroPedido = " & txt_numeropeido.Text
                maisdeum = True
            Else
                maisdeum = True
                str += " WHERE NumeroPedido = " & txt_numeropeido.Text
            End If
        End If
        If dtp_dataabastecimentoi.Checked Then
            If maisdeum Then
                str += " AND Data = '" & Format(dtp_dataabastecimentoi.Value, "dd/MM/yyyy") & "'"
                maisdeum = True
            Else
                maisdeum = True
                str += " WHERE Data = '" & Format(dtp_dataabastecimentoi.Value, "dd/MM/yyyy") & "'"
            End If
        End If
        MsgBox(str)
        dgv_listaabastecimento.DataSource = dado.Pesquisa(str)

    End Sub
    Private Sub comboveiculos()
        cmb_veiculos.Items.Add("")
        Dim veiculos As DataTable = dado.Pesquisa("SELECT id , Apelido FROM Veiculos")
        For Each veiculo As DataRow In veiculos.Rows
            dicveiculoas.Add(veiculo.Item(1), veiculo.Item(0))
            cmb_veiculos.Items.Add(veiculo.Item(1))
        Next veiculo

    End Sub

    Private Sub bnt_pesquisar_Click(sender As Object, e As EventArgs) Handles bnt_pesquisar.Click
        pesquisa()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NovoAbastecimento.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class