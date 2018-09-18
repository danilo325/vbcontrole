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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub dgv_ProdutosRomaneio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ProdutosRomaneio.CellContentClick

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub lbl_idromaneio_Click(sender As Object, e As EventArgs) Handles lbl_idromaneio.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_VCheque_TextChanged(sender As Object, e As EventArgs) Handles txt_VCheque.TextChanged

    End Sub

    Private Sub txt_VDinheiro_TextChanged(sender As Object, e As EventArgs) Handles txt_VDinheiro.TextChanged

    End Sub

    Private Sub txt_VMoeda_TextChanged(sender As Object, e As EventArgs) Handles txt_VMoeda.TextChanged

    End Sub

    Private Sub txt_VBoleto_TextChanged(sender As Object, e As EventArgs) Handles txt_VBoleto.TextChanged

    End Sub

    Private Sub txt_VFiado_TextChanged(sender As Object, e As EventArgs) Handles txt_VFiado.TextChanged

    End Sub

    Private Sub txt_NomeVendedor_TextChanged(sender As Object, e As EventArgs) Handles txt_NomeVendedor.TextChanged

    End Sub

    Private Sub dtp_dataRomaneio_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dataRomaneio.ValueChanged

    End Sub

    Private Sub lbl_valorTotal_Click(sender As Object, e As EventArgs) Handles lbl_valorTotal.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
