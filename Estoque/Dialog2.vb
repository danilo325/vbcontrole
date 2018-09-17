Imports System.Windows.Forms

Public Class dia_incluiFornecedor

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim query As String = ""
        Dim con As Integer = 0

        If (dgv_incluiFornecedor.Rows.Count - 1 > 0) Then

            For i As Integer = 0 To dgv_incluiFornecedor.Rows.Count - 2
                con += 1
                query = "INSERT INTO produto (RasaoSocial,NomeFantasia,Cnpj,FormaDePagamento,ObsFornece) VALUES ("

                For celula As Integer = 0 To dgv_incluiFornecedor.Rows(i).Cells.Count - 1


                    If dgv_incluiFornecedor.Rows(i).Cells(celula).Value.ToString = "" Then


                        MsgBox("O campo " & dgv_incluiFornecedor.Columns(celula).HeaderText & " deve ser preenchido")
                        Exit Sub
                    End If


                    Select Case celula

                        Case 4
                            query += "'" & dgv_incluiFornecedor.Rows(i).Cells(celula).Value.ToString & "'"
                        Case Else

                            query += "'" & dgv_incluiFornecedor.Rows(i).Cells(celula).Value.ToString & "',"
                    End Select


                Next celula
                query += ")"
                MsgBox(query)
                'fornecedores.database.Pesquisa(query)

            Next

        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dia_inclui_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim nomeFantasia As New DataGridViewTextBoxColumn
        Dim rasaoSocial As New DataGridViewTextBoxColumn
        Dim cnpj As New DataGridViewTextBoxColumn
        Dim formapagamento As New DataGridViewTextBoxColumn
        Dim obs As New DataGridViewTextBoxColumn

        nomeFantasia.HeaderText = "Nome Fantasia"
        nomeFantasia.Name = "nomeFantasia"
        rasaoSocial.HeaderText = "Rasão Social"
        rasaoSocial.Name = "rasaoSocial"
        cnpj.HeaderText = "CNPJ"
        cnpj.Name = "cnpj"
        formapagamento.HeaderText = "Forma Pagamento"
        formapagamento.Name = "forma pagamento"
        obs.HeaderText = "OBS"
        obs.Name = "obs"
        dgv_incluiFornecedor.Columns.AddRange(nomeFantasia, rasaoSocial, cnpj, formapagamento, obs)






    End Sub
End Class
