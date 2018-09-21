Imports System.Windows.Forms

Public Class Dia_incluiVendedor

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim query As String = ""
        Dim con As Integer = 0

        If (dgv_Incluivendedor.Rows.Count - 1 > 0) Then

            For i As Integer = 0 To dgv_Incluivendedor.Rows.Count - 2
                con += 1
                query = "INSERT INTO vendedores (NomeVendedor,CPFVendedor,TeleforneVendedor,ComissaoVendedor,ObsVendedor) VALUES ("

                For celula As Integer = 0 To dgv_Incluivendedor.Rows(i).Cells.Count - 1


                    'If dgv_incluiFornecedor.Rows(i).Cells(celula).Value.ToString = "" Then


                    'MsgBox("O campo " & dgv_incluiFornecedor.Columns(celula).HeaderText & " deve ser preenchido")
                    'Exit Sub
                    'End If


                    Select Case celula

                        Case 4
                            query += "'" & dgv_Incluivendedor.Rows(i).Cells(celula).Value.ToString & "'"
                        Case Else

                            query += "'" & dgv_Incluivendedor.Rows(i).Cells(celula).Value.ToString & "',"
                    End Select


                Next celula
                query += ")"
                MsgBox(query)
                Vendedores.dbdata.Pesquisa(query)

            Next
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dia_incluiVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomeVendedor As New DataGridViewTextBoxColumn
        Dim cpfVendedor As New DataGridViewTextBoxColumn
        Dim telefonrVendedor As New DataGridViewTextBoxColumn
        Dim comissaoVendas As New DataGridViewTextBoxColumn
        Dim obs As New DataGridViewTextBoxColumn




        nomeVendedor.HeaderText = "Nome Vendedor"
        nomeVendedor.Name = "nomeVendedor"
        telefonrVendedor.HeaderText = "Telefone"
        telefonrVendedor.Name = "telefoneVendedor"
        obs.HeaderText = "Observação"
        obs.Name = "Obs"
        comissaoVendas.HeaderText = "Comissão"
        comissaoVendas.Name = "comissao"
        cpfVendedor.HeaderText = "CPF"
        cpfVendedor.Name = "cpf"
        dgv_Incluivendedor.Columns.AddRange(nomeVendedor, cpfVendedor, telefonrVendedor, comissaoVendas, obs)
    End Sub
End Class
