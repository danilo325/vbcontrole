Public Class Fornecedores
    Friend dbase As New BdClass
    Dim valorcelula As String


    Private Sub PesquisaFornecedor(str As String)
        Dim query As String
        query = ""
        MsgBox(str)

        If (str <> "") Then


            query = "SELECT * FROM fornecedores WHERE "


            dgv_fornecedor.DataSource = dbase.Pesquisa(query & str)

        Else
            dgv_fornecedor.DataSource = dbase.Pesquisa("SELECT * FROM fornecedores")
        End If


    End Sub


    Private Sub bnt_Fechar_Click(sender As Object, e As EventArgs) Handles bnt_Fechar.Click
        Me.Close()
    End Sub


    Private Sub fornecedores_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbase.Abreconexao()
        dgv_fornecedor.AllowUserToAddRows = False
        dgv_fornecedor.AllowUserToDeleteRows = False
        dgv_fornecedor.DataSource = dbase.Pesquisa("SELECT* FROM fornecedores")
    End Sub

    Private Sub bnt_pesquisa_Click(sender As Object, e As EventArgs) Handles bnt_pesquisa.Click
        Dim contador As Integer
        Dim str As String
        str = ""
        contador = 0
        If (txt_rasaosoc.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += "AND RasaoSocial  LIKE " & txt_rasaosoc.Text & "AND"
            Else
                str += "RasaoSocial LIKE " & txt_rasaosoc.Text

            End If
        End If
        If (txt_nomeFantasia.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND NomeFantasia  LIKE " & txt_nomeFantasia.Text
            Else
                str += "NomeFantasia LIKE " & txt_nomeFantasia.Text

            End If
        End If
        If (txt_cnpj.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND Cnpj LIKE " & txt_cnpj.Text
            Else
                str += "Cnpj LIKE " & txt_cnpj.Text

            End If
        End If
        If (txt_idFornecedor.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND IdForncedor = " & txt_idFornecedor.Text
            Else
                str += " IdForncedor = " & txt_idFornecedor.Text
            End If
        End If
        If (txt_fomapagamento.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND FormaDePagamento LIKE " & txt_fomapagamento.Text
            Else
                str += "FormaDePagamento LIKE " & txt_fomapagamento.Text

            End If
        End If




        PesquisaFornecedor(str)
    End Sub

    Private Sub bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        dia_incluiFornecedor.Visible = True
    End Sub

    Private Sub bnt_Edita_Click(sender As Object, e As EventArgs) Handles bnt_Edita.Click
        If (dgv_fornecedor.ReadOnly) Then
            bnt_Edita.Text = "Sair modo ediçao"

            dgv_fornecedor.Columns(0).ReadOnly = True
            dgv_fornecedor.ReadOnly = False
            dgv_fornecedor.Columns(0).Resizable = DataGridViewTriState.False
            dgv_fornecedor.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells






        Else
            bnt_Edita.Text = "editar"
            dgv_fornecedor.ReadOnly = True

        End If
    End Sub

    Private Sub dgv_fornecedor_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_fornecedor.CellBeginEdit
        valorcelula = dgv_fornecedor.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString


        ' valorcelula = dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
    End Sub

    Private Sub dgv_fornecedor_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fornecedor.CellEndEdit
        Dim str As String
        str = " UPDATE fornecedores SET "
        ' Limpa o erro da linha no caso do usuário pressionar ESC
        MsgBox(e.ColumnIndex)
        MsgBox(e.RowIndex & "|" & e.ColumnIndex)
        Select Case e.ColumnIndex

            Case 1
                str += "RasaoSocial = '" & dgv_fornecedor.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 2
                str += "NomeFantasia = " & dgv_fornecedor.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            Case 3
                str += "Cnpj = " & dgv_fornecedor.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            Case 4
                str += "FormaDePagamento = '" & dgv_fornecedor.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 5
                str += "ObsFornecedor = " & dgv_fornecedor.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
        End Select
        str += " WHERE IdForncedor = " & dgv_fornecedor.Rows(e.RowIndex).Cells(0).Value.ToString
        MsgBox(str)
        dbase.Pesquisa(str)
    End Sub

    Private Sub bnt_Exclui_Click(sender As Object, e As EventArgs) Handles bnt_Exclui.Click
        Dim query As String
        Dim mensagem As String = ""
        query = "DELETE FROM fornecedores WHERE IdForncedor IN ("
        If (dgv_fornecedor.SelectedRows.Count > 0) Then 'Garanti que tenha pelomenos uma linha selecionada

            For Each linha As DataGridViewRow In dgv_fornecedor.SelectedRows
                query += linha.Cells(0).Value.ToString & ","
                mensagem += linha.Cells(1).Value.ToString & "\n"

            Next linha
            query += ")"
            MsgBox("Os fornecedores \n " & mensagem & "\n serão apagados")
            MsgBox(query)


            dbase.Pesquisa(query)
            dgv_fornecedor.DataSource = dbase.Pesquisa("SELECT * FROM fornecedores ")
        Else
            MsgBox("É necessário selecionar aomenos uma linha")
        End If
    End Sub
End Class