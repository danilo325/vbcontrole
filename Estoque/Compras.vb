Public Class form_compras
    Dim dicFornecedor As New Dictionary(Of String, Integer)
    Dim bancodados As New BdClass

    Private Sub cmbfornecedor()
        Dim fornecedores As New DataTable
        fornecedores = bancodados.Pesquisa("SELECT IdForncedor, NomeFantasia FROM fornecedores")
        cmb_Fornecedor.Items.Add("")
        For Each fornecedor As DataRow In fornecedores.Rows
            dicFornecedor.Add(fornecedor.Item(1).ToString, fornecedor.Item(0))
            cmb_Fornecedor.Items.Add(fornecedor.Item(1).ToString)
        Next fornecedor
    End Sub
    Private Sub prenchedata()
        Dim strquery As String = "SELECT * FROM compras "
        Dim contadorpesquisa As Integer = 0
        If txt_Id.Text <> "" Then
            If contadorpesquisa = 0 Then
                strquery += " WHERE IdCompras = " & txt_Id.Text
            Else
                strquery += " AND IdCompras = " & txt_Id.Text
            End If

        End If

        If cmb_Fornecedor.Text <> "" Then
            If contadorpesquisa = 0 Then
                strquery += " WHERE IdFornecedor = " & dicFornecedor.Values(cmb_Fornecedor.Text)
            Else
                strquery += " AND IdFornecedor = " & dicFornecedor.Values(cmb_Fornecedor.Text)
            End If

        End If
        If txt_numeroPedido.Text <> "" Then
            If contadorpesquisa = 0 Then
                strquery += " WHERE NumeroPedido = " & txt_numeroPedido.Text
            Else
                strquery += " AND  NumeroPedido = " & txt_numeroPedido.Text
            End If

        End If
        '  If dtp_inicial.Value.ToString <> "" Then
        '     If dtp_final.Value.ToString <> "" Then
        '        dtp_final.Value = dtp_inicial.Value
        '    End If

        '    If contadorpesquisa = 0 Then
        '        strquery += " WHERE DataCompra BETWEEN " & dtp_inicial.Value.ToString & " AND " & dtp_final.Value.ToString
        '    Else
        '        strquery += " AND DataCompra BETWEEN " & dtp_inicial.Value.ToString & " AND " & dtp_final.Value.ToString
        '    End If

        ' End If
        dgv_produtosCompra.DataSource = bancodados.Pesquisa(strquery)
    End Sub

    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bancodados.Abreconexao()
        cmbfornecedor()
        ' dtp_inicial.Value = ""
        'dtp_inicial.Value = ""
        prenchedata()
    End Sub

    Private Sub bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        frm_novaCompra.Visible = True
    End Sub
End Class