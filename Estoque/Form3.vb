Public Class home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Estoque.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Fornecedores.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Vendedores.Visible = True
    End Sub
End Class