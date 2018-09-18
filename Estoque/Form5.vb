Public Class romaneios
    Friend dbdata As New BdClass
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_romaneios.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnt_pesquisa.Click

    End Sub

    Private Sub romaneios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbdata.Abreconexao()
        dgv_romaneios.DataSource = dbdata.Pesquisa("SELECT * FROM romaneio")


    End Sub

    Private Sub bnt_Exclui_Click(sender As Object, e As EventArgs) Handles bnt_Exclui.Click
        Dim query As String
        Dim mensagem As String = ""
        Dim queryprodutos As String
        query = "DELETE FROM romaneio WHERE IdRomaneio IN ("
        If (dgv_romaneios.SelectedRows.Count > 0) Then 'Garanti que tenha pelomenos uma linha selecionada

            For Each linha As DataGridViewRow In dgv_romaneios.SelectedRows
                query += linha.Cells(0).Value.ToString & ","
                queryprodutos += linha.Cells(0).Value.ToString & ","
                mensagem += linha.Cells(1).Value.ToString & "\n"

            Next linha
            query += ")"
            MsgBox("Os produtos \n " & mensagem & "\n serão apagados")
            dbdata.Pesquisa("DELETE FROM produtosRomaneio WHERE IdRomaneio IN (" & queryprodutos & ")")


            dbdata.Pesquisa(query)

            dgv_romaneios.DataSource = dbdata.Pesquisa("SELECT * FROM romaneio ")
        Else
            MsgBox("É necessário selecionar aomenos uma linha")
        End If
    End Sub

    Private Sub dgv_romaneios_DoubleClick(sender As Object, e As EventArgs) Handles dgv_romaneios.DoubleClick
        Dim info As DataTable
        Dim indexlinha As Integer = dgv_romaneios.SelectedCells(0).RowIndex
        info = dbdata.Pesquisa("SELECT* FROM romaneio WHERE IdRomaneio = " & dgv_romaneios.Rows(indexlinha).Cells(0).Value)
        Dia_DetalhesRomaneio.lbl_idromaneio.Text = info.Rows(0).Item(0).ToString
        Dia_DetalhesRomaneio.txt_NomeVendedor.Text = dbdata.Pesquisa("SELECT NomeVendedor FROM vendedores WHERE IdVendedor =" & info.Rows(0).Item(1)).Rows(0).Item(0).ToString
        Dia_DetalhesRomaneio.dtp_dataRomaneio.Value = info.Rows(0).Item(2)
        Dia_DetalhesRomaneio.txt_VCheque.Text = info.Rows(0).Item(3).ToString
        Dia_DetalhesRomaneio.txt_VDinheiro.Text = info.Rows(0).Item(4).ToString
        Dia_DetalhesRomaneio.txt_VMoeda.Text = info.Rows(0).Item(5).ToString
        Dia_DetalhesRomaneio.txt_VBoleto.Text = info.Rows(0).Item(6).ToString
        Dia_DetalhesRomaneio.txt_VFiado.Text = info.Rows(0).Item(7).ToString
        Dia_DetalhesRomaneio.lbl_valorTotal.Text = "R$ " & info.Rows(0).Item(9).ToString
        Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.DataSource = dbdata.Pesquisa("SELECT* FROM produtosRomaneio WHERE IdRomaneio = " & dgv_romaneios.Rows(indexlinha).Cells(0).Value)
        Dia_DetalhesRomaneio.dgv_ProdutosRomaneio.AllowUserToAddRows = False

        Dia_DetalhesRomaneio.Visible = True

    End Sub

    Private Sub bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        NovoRomneio.Visible = True

    End Sub
End Class