Public Class form_compras
    Dim dicFornecedor As New Dictionary(Of String, Integer)
    Dim dicFornecedorinverido As New Dictionary(Of Integer, String)
    Dim bancodados As New BdClass

    Private Sub cmbfornecedor()
        Dim fornecedores As New DataTable
        fornecedores = bancodados.Pesquisa("SELECT IdForncedor, NomeFantasia FROM fornecedores")
        cmb_Fornecedor.Items.Add("")
        For Each fornecedor As DataRow In fornecedores.Rows
            dicFornecedor.Add(fornecedor.Item(1).ToString, fornecedor.Item(0))
            dicFornecedorinverido.Add(fornecedor.Item(0).ToString, fornecedor.Item(1))
            cmb_Fornecedor.Items.Add(fornecedor.Item(1).ToString)
        Next fornecedor
    End Sub


    Private Sub prenchedata()
        Dim strquery As String = "SELECT * FROM compras "
        Dim contadorpesquisa As Integer = 0
        If txt_Id.Text <> "" Then
            If contadorpesquisa = 0 Then
                strquery += " WHERE IdCompras = " & txt_Id.Text
                contadorpesquisa += 1
            Else
                contadorpesquisa += 1
                strquery += " AND IdCompras = " & txt_Id.Text
            End If

        End If

        If cmb_Fornecedor.Text <> "" Then
            If contadorpesquisa = 0 Then
                contadorpesquisa += 1
                strquery += " WHERE IdForncedor = " & dicFornecedor.Item(cmb_Fornecedor.Text)
            Else
                contadorpesquisa += 1
                strquery += " AND IdForncedor = " & dicFornecedor.Item(cmb_Fornecedor.Text)
            End If

        End If
        If txt_numeroPedido.Text <> "" Then
            If contadorpesquisa = 0 Then
                contadorpesquisa += 1
                strquery += " WHERE NumeroPedido = " & txt_numeroPedido.Text
            Else
                contadorpesquisa += 1
                strquery += " AND  NumeroPedido = " & txt_numeroPedido.Text
            End If

        End If
        If dtp_inicial.Checked Then
            If Not dtp_final.Checked Then
                If contadorpesquisa = 0 Then
                    contadorpesquisa += 1
                    strquery += " WHERE DataCompra =  #" & Format(dtp_inicial.Value, "MM/dd/yyyy") & "#"
                Else
                    contadorpesquisa += 1
                    strquery += " And DataCompra = #" & Format(dtp_inicial.Value, "MM/dd/yyyy") & "#"
                End If
            Else
                If contadorpesquisa = 0 Then
                    contadorpesquisa += 1
                    strquery += " WHERE DataCompra BETWEEN #" & Format(dtp_inicial.Value, "MM/dd/yyyy") & "#" & " AND #" & Format(dtp_final.Value, "MM/dd/yyyy") & "#"
                Else
                    contadorpesquisa += 1
                    strquery += " AND DataCompra BETWEEN #" & Format(dtp_inicial.Value, "MM/dd/yyyy") & "#" & " AND #" & Format(dtp_final.Value, "MM/dd/yyyy") & "#"
                End If

            End If


        End If

        dgv_produtosCompra.DataSource = bancodados.Pesquisa(strquery)



        For Each coluna As DataGridViewColumn In dgv_produtosCompra.Columns
            'MsgBox(coluna.Index)
            Select Case coluna.Index
                Case 0
                    coluna.HeaderText = "ID"
                    coluna.Name = "id"
                    coluna.Width = 25
                Case 1
                    coluna.HeaderText = "Fornecedor"
                    coluna.Name = "fornecedor"
                    coluna.Width = 250

                Case 2
                    coluna.HeaderText = "Nº Pedido"
                    coluna.Name = "npedido"
                    coluna.Width = 50
                Case 3
                    coluna.HeaderText = "Dta Compra"
                    coluna.Name = "dtacompra"
                    coluna.Width = 80
                Case 4
                    coluna.HeaderText = "Valor"
                    coluna.Name = "valor"
                    coluna.Width = 50
                Case 5
                    coluna.HeaderText = "Impostos"
                    coluna.Name = "impostos"
                    coluna.Width = 50
                Case 6
                    coluna.HeaderText = "Observação"
                    coluna.Name = "obs"
                    coluna.Width = 350
            End Select

        Next coluna



        '  For Each compra As DataGridViewRow In dgv_produtosCompra.Rows
        'compra.Cells("Fornecedor").Value = dicFornecedorinverido(compra.Cells("Fornecedor").Value)
        'Next
    End Sub

    Private Sub form_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bancodados.Abreconexao()
        cmbfornecedor()
        prenchedata()
        bnt_Edita.Visible = False
        bnt_Exclui.Visible = False
        dgv_produtosCompra.AllowUserToAddRows = False

    End Sub

    Private Sub bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        frm_novaCompra.Visible = True
    End Sub

    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()
    End Sub

    Private Sub dgv_produtosCompra_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtosCompra.CellDoubleClick

    End Sub

    Private Sub bnt_pesquisa_Click(sender As Object, e As EventArgs) Handles bnt_pesquisa.Click
        prenchedata()
    End Sub
End Class