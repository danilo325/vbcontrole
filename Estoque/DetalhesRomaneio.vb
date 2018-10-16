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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        NovoRomneio.txt_VBoleto.Text = txt_VBoleto.Text
        NovoRomneio.txt_VCheque.Text = txt_VCheque.Text
        NovoRomneio.txt_VMoeda.Text = txt_VMoeda.Text
        NovoRomneio.txt_VDinheiro.Text = txt_VDinheiro.Text
        NovoRomneio.txt_VFiado.Text = txt_VFiado.Text
        NovoRomneio.lbl_estado.Text = lbl_status.Text
        NovoRomneio.lbl_idromaneio.Text = lbl_idromaneio.Text
        NovoRomneio.lbl_valorTotal.Text = lbl_valorTotal.Text
        NovoRomneio.cmb_vendedor.Text = txt_NomeVendedor.Text
        NovoRomneio.Visible = True
    End Sub
End Class
