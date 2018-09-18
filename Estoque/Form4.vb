Public Class Vendedores
    Friend dbdata As New BdClass
    Dim valorcelula As String
    Private Sub bnt_Fechar_Click(sender As Object, e As EventArgs) Handles bnt_Fechar.Click
        Me.Close()
    End Sub

    Private Sub Vendedores_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbdata.Abreconexao()
        dgv_Vendedores.DataSource = dbdata.Pesquisa("SELECT * FROM vendedores")
        dgv_Vendedores.AllowUserToAddRows = False
        dgv_Vendedores.AllowUserToDeleteRows = False
    End Sub
    Private Sub PesquisaProduto(str As String)
        Dim query As String
        query = ""
        MsgBox(str)

        If (str <> "") Then


            query = "SELECT * FROM vendedores WHERE "


            dgv_Vendedores.DataSource = dbdata.Pesquisa(query & str)

        Else
            dgv_Vendedores.DataSource = dbdata.Pesquisa("SELECT * FROM vendedores")
        End If


    End Sub

    Private Sub bnt_Pesquisa_Click(sender As Object, e As EventArgs) Handles bnt_Pesquisa.Click
        Dim contador As Integer
        Dim str As String
        str = ""
        contador = 0
        If (txt_IdVendedor.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND IdVendedor =" & txt_IdVendedor.Text
            Else
                str += "IdVendedor =" & txt_IdVendedor.Text

            End If
        End If
        If (txt_Nome.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND NomeVendedor LIKE '" & txt_Nome.Text & "'"
            Else
                str += " NomeVendedor LIKE '" & txt_Nome.Text & "'"
            End If
        End If
        If (txt_Fone.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND TeleforneVendedor LIKE ' " & txt_Fone.Text & "'"
            Else
                str += " TeleforneVendedor LIKE '" & txt_Fone.Text & "'"
            End If
        End If
        If (txt_Cpf.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND CpfVEndedor LIKE '" & txt_Cpf.Text & "'"
            Else
                str += " CpfVEndedor LIKE '" & txt_Cpf.Text & "'"
            End If
        End If




        PesquisaProduto(str)
    End Sub

    Private Sub bnt_Exclui_Click(sender As Object, e As EventArgs) Handles bnt_Exclui.Click
        Dim query As String
        Dim mensagem As String = ""
        query = "DELETE FROM vendedores WHERE IdVendedor IN ("
        If (dgv_Vendedores.SelectedRows.Count > 0) Then 'Garanti que tenha pelomenos uma linha selecionada

            For Each linha As DataGridViewRow In dgv_Vendedores.SelectedRows
                query += linha.Cells(0).Value.ToString & ","
                mensagem += linha.Cells(1).Value.ToString & "\n"

            Next linha
            query += ")"
            MsgBox("Os vendedores \n " & mensagem & "\n serão apagados")
            MsgBox(query)


            dbdata.Pesquisa(query)
            dgv_Vendedores.DataSource = dbdata.Pesquisa("SELECT * FROM vendedores ")
        Else
            MsgBox("É necessário selecionar aomenos uma linha")
        End If

    End Sub

    Private Sub bnt_Edita_Click(sender As Object, e As EventArgs) Handles bnt_Edita.Click
        If (dgv_Vendedores.ReadOnly) Then
            bnt_Edita.Text = "Sair modo ediçao"


            dgv_Vendedores.ReadOnly = False
            dgv_Vendedores.Columns(0).ReadOnly = True
            dgv_Vendedores.Columns(0).Resizable = DataGridViewTriState.False

            dgv_Vendedores.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells






        Else
            bnt_Edita.Text = "editar"
            dgv_Vendedores.ReadOnly = True

        End If
    End Sub

    Private Sub dgv_Vendedores_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Vendedores.CellEndEdit
        Dim str As String
        str = " UPDATE vendedores SET "
        ' Limpa o erro da linha no caso do usuário pressionar ESC
        MsgBox(e.ColumnIndex)
        MsgBox(e.RowIndex & "|" & e.ColumnIndex)
        Select Case e.ColumnIndex
            Case 1
                str += "NomeVendedor = '" & dgv_Vendedores.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 2
                str += "CPFVendedor = '" & dgv_Vendedores.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 3
                str += "TelefoneVendedor = '" & dgv_Vendedores.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 4
                str += "ComissaoVendedor = '" & dgv_Vendedores.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 5
                str += "ObsVendedor = '" & dgv_Vendedores.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
        End Select
        str += " WHERE IdVendedor = " & dgv_Vendedores.Rows(e.RowIndex).Cells(0).Value.ToString
        MsgBox(str)
        dbdata.Pesquisa(str)

    End Sub

    Private Sub dgv_Vendedores_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_Vendedores.CellBeginEdit



        valorcelula = dgv_Vendedores.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString


        valorcelula = dgv_Vendedores.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
    End Sub

    Private Sub bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        Dia_incluiVendedor.Visible = True
    End Sub
End Class