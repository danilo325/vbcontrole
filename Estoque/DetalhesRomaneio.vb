Imports System.Windows.Forms

Public Class Dia_DetalhesRomaneio

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dia_DetalhesRomaneio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case lbl_status.Text
            Case "Saida"
                bnt_modifica.Text = "A Saida"
                bnt_retorn.Text = "Retorno"
            Case "Retorno"
                bnt_modifica.Text = "A Retorno"
                bnt_retorn.Text = "Finalzar"
            Case "Finalizado"
                bnt_modifica.Text = "M Romaneio"
                bnt_retorn.Enabled = False
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnt_modifica.Click


        'NovoRomneio.txt_VBoleto.Text = txt_VBoleto.Text
        'NovoRomneio.txt_VCheque.Text = txt_VCheque.Text
        'NovoRomneio.txt_VMoeda.Text = txt_VMoeda.Text
        'NovoRomneio.txt_VDinheiro.Text = txt_VDinheiro.Text
        'NovoRomneio.txt_VFiado.Text = txt_VFiado.Text
        'NovoRomneio.lbl_estado.Text = lbl_status.Text
        'NovoRomneio.lbl_idromaneio.Text = lbl_idromaneio.Text
        'NovoRomneio.lbl_valorTotal.Text = lbl_valorTotal.Text
        ' NovoRomneio.cmb_vendedor.Text = txt_NomeVendedor.Text
        'NovoRomneio.Visible = True

        ' EditaRomaneioSaida.lbl_id.Text = lbl_idromaneio.Text
        Select Case lbl_status.Text
            Case "Saida"
                EditaRomaneioSaida.lbl_id.Text = lbl_idromaneio.Text
                EditaRomaneioSaida.cbm_vendedores.Text = txt_NomeVendedor.Text
                EditaRomaneioSaida.dtp_data.Value = dtp_dataRomaneio.Value
                EditaRomaneioSaida.Visible = True
            Case "Retorno"
                EditaRomaneioRetorno.lbl_id.Text = lbl_idromaneio.Text
                EditaRomaneioRetorno.cbm_vendedores.Text = txt_NomeVendedor.Text
                EditaRomaneioRetorno.dtp_data.Value = dtp_dataRomaneio.Value
                EditaRomaneioRetorno.Visible = True

            Case "Finaliza"
                FinalizaRomaneio.lbl_idromaneio.Text = lbl_idromaneio.Text
                FinalizaRomaneio.txt_NomeVendedor.Text = txt_NomeVendedor.Text
                FinalizaRomaneio.dtp_dataRomaneio.Value = dtp_dataRomaneio.Value
                For Each coluna As DataGridViewColumn In dgv_ProdutosRomaneio.Columns
                    FinalizaRomaneio.dgv_ProdutosRomaneio.Columns.Add(coluna.Clone)
                Next



                For Each linha As DataGridViewRow In dgv_ProdutosRomaneio.Rows
                    If Not linha.IsNewRow Then
                        FinalizaRomaneio.dgv_ProdutosRomaneio.Rows.Add(linha.Cells("IdRomaneio").Value, linha.Cells(1).Value, linha.Cells(2).Value, linha.Cells(3).Value, linha.Cells(4).Value)
                    End If
                Next


                FinalizaRomaneio.Visible = True

        End Select


    End Sub

    Private Sub bnt_retorn_Click(sender As Object, e As EventArgs) Handles bnt_retorn.Click

        Select Case lbl_status.Text
            Case "Saida"
                bnt_retorn.Text = "Retornar"
                RetornoRoameio.lbl_id.Text = lbl_idromaneio.Text
                RetornoRoameio.cbm_vendedores.Text = txt_NomeVendedor.Text
                RetornoRoameio.dtp_data.Value = dtp_dataRomaneio.Value

                RetornoRoameio.Visible = True
            Case "Retorno"
                bnt_retorn.Text = "Finalizar"
                FinalizaRomaneio.lbl_idromaneio.Text = lbl_idromaneio.Text
                FinalizaRomaneio.txt_NomeVendedor.Text = txt_NomeVendedor.Text
                FinalizaRomaneio.dtp_dataRomaneio.Value = dtp_dataRomaneio.Value
                For Each coluna As DataGridViewColumn In dgv_ProdutosRomaneio.Columns
                    FinalizaRomaneio.dgv_ProdutosRomaneio.Columns.Add(coluna.Clone)
                Next



                For Each linha As DataGridViewRow In dgv_ProdutosRomaneio.Rows
                    If Not linha.IsNewRow Then
                        FinalizaRomaneio.dgv_ProdutosRomaneio.Rows.Add(linha.Cells("IdRomaneio").Value, linha.Cells(1).Value, linha.Cells(2).Value, linha.Cells(3).Value, linha.Cells(4).Value)
                    End If
                Next


                FinalizaRomaneio.Visible = True

            Case "Finaliza"
                bnt_retorn.Text = "Finalizado"
                bnt_retorn.Enabled = False

        End Select




    End Sub
End Class
