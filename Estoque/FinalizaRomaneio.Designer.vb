<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalizaRomaneio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_valorTotal = New System.Windows.Forms.Label()
        Me.dtp_dataRomaneio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_NomeVendedor = New System.Windows.Forms.TextBox()
        Me.txt_VFiado = New System.Windows.Forms.TextBox()
        Me.txt_VBoleto = New System.Windows.Forms.TextBox()
        Me.txt_VMoeda = New System.Windows.Forms.TextBox()
        Me.txt_VDinheiro = New System.Windows.Forms.TextBox()
        Me.txt_VCheque = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_idromaneio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_ProdutosRomaneio = New System.Windows.Forms.DataGridView()
        Me.Process1 = New System.Diagnostics.Process()
        Me.errofinaliza = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bnt_finaliza = New System.Windows.Forms.Button()
        CType(Me.dgv_ProdutosRomaneio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errofinaliza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(697, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Valor Total"
        '
        'lbl_valorTotal
        '
        Me.lbl_valorTotal.AutoSize = True
        Me.lbl_valorTotal.BackColor = System.Drawing.Color.Bisque
        Me.lbl_valorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valorTotal.Location = New System.Drawing.Point(772, 177)
        Me.lbl_valorTotal.Name = "lbl_valorTotal"
        Me.lbl_valorTotal.Size = New System.Drawing.Size(41, 25)
        Me.lbl_valorTotal.TabIndex = 37
        Me.lbl_valorTotal.Text = "VT"
        '
        'dtp_dataRomaneio
        '
        Me.dtp_dataRomaneio.Location = New System.Drawing.Point(276, 55)
        Me.dtp_dataRomaneio.Name = "dtp_dataRomaneio"
        Me.dtp_dataRomaneio.Size = New System.Drawing.Size(158, 20)
        Me.dtp_dataRomaneio.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(228, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Data"
        '
        'txt_NomeVendedor
        '
        Me.txt_NomeVendedor.Location = New System.Drawing.Point(112, 99)
        Me.txt_NomeVendedor.Name = "txt_NomeVendedor"
        Me.txt_NomeVendedor.Size = New System.Drawing.Size(245, 20)
        Me.txt_NomeVendedor.TabIndex = 34
        '
        'txt_VFiado
        '
        Me.txt_VFiado.Location = New System.Drawing.Point(634, 135)
        Me.txt_VFiado.Name = "txt_VFiado"
        Me.txt_VFiado.Size = New System.Drawing.Size(63, 20)
        Me.txt_VFiado.TabIndex = 33
        '
        'txt_VBoleto
        '
        Me.txt_VBoleto.Location = New System.Drawing.Point(482, 135)
        Me.txt_VBoleto.Name = "txt_VBoleto"
        Me.txt_VBoleto.Size = New System.Drawing.Size(63, 20)
        Me.txt_VBoleto.TabIndex = 32
        '
        'txt_VMoeda
        '
        Me.txt_VMoeda.Location = New System.Drawing.Point(357, 135)
        Me.txt_VMoeda.Name = "txt_VMoeda"
        Me.txt_VMoeda.Size = New System.Drawing.Size(63, 20)
        Me.txt_VMoeda.TabIndex = 31
        '
        'txt_VDinheiro
        '
        Me.txt_VDinheiro.Location = New System.Drawing.Point(220, 131)
        Me.txt_VDinheiro.Name = "txt_VDinheiro"
        Me.txt_VDinheiro.Size = New System.Drawing.Size(63, 20)
        Me.txt_VDinheiro.TabIndex = 30
        '
        'txt_VCheque
        '
        Me.txt_VCheque.Location = New System.Drawing.Point(85, 135)
        Me.txt_VCheque.Name = "txt_VCheque"
        Me.txt_VCheque.Size = New System.Drawing.Size(63, 20)
        Me.txt_VCheque.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(582, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "V. Fiado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "V. Boleto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "V. Moeda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "V. Dinheiro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "V. Cheque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nome Vendedor"
        '
        'lbl_idromaneio
        '
        Me.lbl_idromaneio.AutoSize = True
        Me.lbl_idromaneio.BackColor = System.Drawing.Color.Bisque
        Me.lbl_idromaneio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idromaneio.Location = New System.Drawing.Point(97, 55)
        Me.lbl_idromaneio.Name = "lbl_idromaneio"
        Me.lbl_idromaneio.Size = New System.Drawing.Size(34, 25)
        Me.lbl_idromaneio.TabIndex = 22
        Me.lbl_idromaneio.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID Romaneio:"
        '
        'dgv_ProdutosRomaneio
        '
        Me.dgv_ProdutosRomaneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ProdutosRomaneio.Location = New System.Drawing.Point(25, 205)
        Me.dgv_ProdutosRomaneio.Name = "dgv_ProdutosRomaneio"
        Me.dgv_ProdutosRomaneio.Size = New System.Drawing.Size(895, 190)
        Me.dgv_ProdutosRomaneio.TabIndex = 20
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'errofinaliza
        '
        Me.errofinaliza.ContainerControl = Me
        '
        'bnt_finaliza
        '
        Me.bnt_finaliza.Location = New System.Drawing.Point(815, 415)
        Me.bnt_finaliza.Name = "bnt_finaliza"
        Me.bnt_finaliza.Size = New System.Drawing.Size(75, 23)
        Me.bnt_finaliza.TabIndex = 39
        Me.bnt_finaliza.Text = "Finalizar"
        Me.bnt_finaliza.UseVisualStyleBackColor = True
        '
        'FinalizaRomaneio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 450)
        Me.Controls.Add(Me.bnt_finaliza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_valorTotal)
        Me.Controls.Add(Me.dtp_dataRomaneio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_NomeVendedor)
        Me.Controls.Add(Me.txt_VFiado)
        Me.Controls.Add(Me.txt_VBoleto)
        Me.Controls.Add(Me.txt_VMoeda)
        Me.Controls.Add(Me.txt_VDinheiro)
        Me.Controls.Add(Me.txt_VCheque)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_idromaneio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_ProdutosRomaneio)
        Me.Name = "FinalizaRomaneio"
        Me.Text = "FinalizaRomaneio"
        CType(Me.dgv_ProdutosRomaneio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errofinaliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_valorTotal As Label
    Friend WithEvents dtp_dataRomaneio As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_NomeVendedor As TextBox
    Friend WithEvents txt_VFiado As TextBox
    Friend WithEvents txt_VBoleto As TextBox
    Friend WithEvents txt_VMoeda As TextBox
    Friend WithEvents txt_VDinheiro As TextBox
    Friend WithEvents txt_VCheque As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_idromaneio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_ProdutosRomaneio As DataGridView
    Friend WithEvents Process1 As Process
    Friend WithEvents errofinaliza As ErrorProvider
    Friend WithEvents bnt_finaliza As Button
End Class
