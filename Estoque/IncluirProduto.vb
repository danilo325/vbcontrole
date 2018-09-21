Imports System.Windows.Forms

Public Class dia_inclui

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim query As String = ""
        Dim con As Integer = 0

        If (dgv_inclui.Rows.Count - 1 > 0) Then

            For i As Integer = 0 To dgv_inclui.Rows.Count - 2
                con += 1
                query = "INSERT INTO produto (Descricao,Grupo,Qtd,Unidade,Pcusto,Pvenda,Produzido,Ativo) VALUES ("

                For celula As Integer = 0 To dgv_inclui.Rows(i).Cells.Count - 1

                    MsgBox(i & "|" & celula)

                    If (celula <> 6 And celula <> 7) Then
                        If dgv_inclui.Rows(i).Cells(celula).Value.ToString = "" Then


                            MsgBox("O campo " & dgv_inclui.Columns(celula).HeaderText & " deve ser preenchido")
                            Exit Sub
                        End If

                    End If
                    Select Case celula
                        Case 1
                            query += Estoque.dicionarioGrupo.Item(dgv_inclui.Rows(i).Cells(celula).Value.ToString) & ","
                        Case 6
                            If (Not dgv_inclui.Rows(i).Cells(celula).Value) Then
                                query += "" & "False" & ","
                            Else
                                query += "" & "True" & ","
                            End If
                        Case 7
                            If (Not dgv_inclui.Rows(i).Cells(celula).Value) Then
                                query += "" & "False" & ""
                            Else
                                query += "" & "True" & ""
                            End If
                        Case 0, 3
                            query += "'" & dgv_inclui.Rows(i).Cells(celula).Value.ToString & "',"
                        Case Else

                            query += "" & dgv_inclui.Rows(i).Cells(celula).Value.ToString & ","
                    End Select


                Next celula
                query += ")"
                MsgBox(query)
                Estoque.bancoDados.Pesquisa(query)

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
        Dim descricao As New DataGridViewTextBoxColumn
        Dim unidade As New DataGridViewTextBoxColumn
        Dim qtd As New DataGridViewTextBoxColumn
        Dim pcusto As New DataGridViewTextBoxColumn
        Dim vcusto As New DataGridViewTextBoxColumn
        Dim ativo As New DataGridViewCheckBoxColumn
        Dim produzido As New DataGridViewCheckBoxColumn
        Dim grupo As New DataGridViewComboBoxColumn
        grupo.Items.Add("")
        For Each linha As DataRow In Estoque.grupoProduto.Rows
            grupo.Items.Add(linha(1))
        Next linha
        descricao.HeaderText = "Descriçao"
        descricao.Name = "descricao"
        unidade.HeaderText = "Unidade"
        unidade.Name = "unidade"
        qtd.HeaderText = "Qtd"
        qtd.Name = "qtd"
        pcusto.HeaderText = "P.Custo"
        pcusto.Name = "pcusto"
        vcusto.HeaderText = "V. custo"
        vcusto.Name = "vcusto"
        ativo.HeaderText = "Ativo"
        ativo.Name = "ativo"
        produzido.HeaderText = "Produzido"
        produzido.Name = "produzido"
        grupo.HeaderText = "Grupo"
        grupo.Name = "grupo"
        dgv_inclui.Columns.AddRange(descricao, grupo, qtd, unidade, pcusto, vcusto, produzido, ativo)






    End Sub
End Class
