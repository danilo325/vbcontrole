Public Class fornecedores
    Friend dbase As BdClass






    Private Sub bnt_Fechar_Click(sender As Object, e As EventArgs) Handles bnt_Fechar.Click
        Me.Close()
    End Sub

    Private Sub fornecedores_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dbase.Abreconexao()
        dgv_fornecedor.DataSource = dbase.Pesquisa("SELECT* FROM fornecedores")
    End Sub

End Class