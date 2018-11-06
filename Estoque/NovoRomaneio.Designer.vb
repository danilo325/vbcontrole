<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovoRomneio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_valorTotal = New System.Windows.Forms.Label()
        Me.dtp_dataRomaneio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_VFiado = New System.Windows.Forms.TextBox()
        Me.txt_VBoleto = New System.Windows.Forms.TextBox()
        Me.txt_VMoeda = New System.Windows.Forms.TextBox()
        Me.txt_VDinheiro = New System.Windows.Forms.TextBox()
        Me.txt_VCheque = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_idromaneio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_ProdutosRomaneio = New System.Windows.Forms.DataGridView()
        Me.bnt_fecha = New System.Windows.Forms.Button()
        Me.cmb_vendedor = New System.Windows.Forms.ComboBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bnt_inclui = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        CType(Me.dgv_ProdutosRomaneio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(683, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Valor Total"
        '
        'lbl_valorTotal
        '
        Me.lbl_valorTotal.AutoSize = True
        Me.lbl_valorTotal.BackColor = System.Drawing.Color.Bisque
        Me.lbl_valorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valorTotal.Location = New System.Drawing.Point(758, 142)
        Me.lbl_valorTotal.Name = "lbl_valorTotal"
        Me.lbl_valorTotal.Size = New System.Drawing.Size(41, 25)
        Me.lbl_valorTotal.TabIndex = 38
        Me.lbl_valorTotal.Text = "VT"
        '
        'dtp_dataRomaneio
        '
        Me.dtp_dataRomaneio.CustomFormat = "dd/mm/yyyy"
        Me.dtp_dataRomaneio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dataRomaneio.Location = New System.Drawing.Point(259, 11)
        Me.dtp_dataRomaneio.Name = "dtp_dataRomaneio"
        Me.dtp_dataRomaneio.Size = New System.Drawing.Size(102, 20)
        Me.dtp_dataRomaneio.TabIndex = 37
        Me.dtp_dataRomaneio.Value = New Date(2018, 11, 5, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Data"
        '
        'txt_VFiado
        '
        Me.txt_VFiado.Location = New System.Drawing.Point(588, 102)
        Me.txt_VFiado.Name = "txt_VFiado"
        Me.txt_VFiado.Size = New System.Drawing.Size(63, 20)
        Me.txt_VFiado.TabIndex = 34
        '
        'txt_VBoleto
        '
        Me.txt_VBoleto.Location = New System.Drawing.Point(462, 102)
        Me.txt_VBoleto.Name = "txt_VBoleto"
        Me.txt_VBoleto.Size = New System.Drawing.Size(63, 20)
        Me.txt_VBoleto.TabIndex = 33
        '
        'txt_VMoeda
        '
        Me.txt_VMoeda.Location = New System.Drawing.Point(337, 102)
        Me.txt_VMoeda.Name = "txt_VMoeda"
        Me.txt_VMoeda.Size = New System.Drawing.Size(63, 20)
        Me.txt_VMoeda.TabIndex = 32
        '
        'txt_VDinheiro
        '
        Me.txt_VDinheiro.Location = New System.Drawing.Point(200, 102)
        Me.txt_VDinheiro.Name = "txt_VDinheiro"
        Me.txt_VDinheiro.Size = New System.Drawing.Size(63, 20)
        Me.txt_VDinheiro.TabIndex = 31
        '
        'txt_VCheque
        '
        Me.txt_VCheque.Location = New System.Drawing.Point(65, 102)
        Me.txt_VCheque.Name = "txt_VCheque"
        Me.txt_VCheque.Size = New System.Drawing.Size(63, 20)
        Me.txt_VCheque.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(536, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "V. Fiado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "V. Boleto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "V. Dinheiro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "V. Cheque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nome Vendedor"
        '
        'lbl_idromaneio
        '
        Me.lbl_idromaneio.AutoSize = True
        Me.lbl_idromaneio.BackColor = System.Drawing.Color.Bisque
        Me.lbl_idromaneio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idromaneio.Location = New System.Drawing.Point(80, 9)
        Me.lbl_idromaneio.Name = "lbl_idromaneio"
        Me.lbl_idromaneio.Size = New System.Drawing.Size(34, 25)
        Me.lbl_idromaneio.TabIndex = 23
        Me.lbl_idromaneio.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ID Romaneio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "V. Moeda"
        '
        'dgv_ProdutosRomaneio
        '
        Me.dgv_ProdutosRomaneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ProdutosRomaneio.Location = New System.Drawing.Point(4, 179)
        Me.dgv_ProdutosRomaneio.Name = "dgv_ProdutosRomaneio"
        Me.dgv_ProdutosRomaneio.Size = New System.Drawing.Size(895, 190)
        Me.dgv_ProdutosRomaneio.TabIndex = 21
        '
        'bnt_fecha
        '
        Me.bnt_fecha.Location = New System.Drawing.Point(813, 415)
        Me.bnt_fecha.Name = "bnt_fecha"
        Me.bnt_fecha.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fecha.TabIndex = 40
        Me.bnt_fecha.Text = "Fechar"
        Me.bnt_fecha.UseVisualStyleBackColor = True
        '
        'cmb_vendedor
        '
        Me.cmb_vendedor.FormattingEnabled = True
        Me.cmb_vendedor.Location = New System.Drawing.Point(91, 65)
        Me.cmb_vendedor.Name = "cmb_vendedor"
        Me.cmb_vendedor.Size = New System.Drawing.Size(322, 21)
        Me.cmb_vendedor.TabIndex = 41
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(710, 15)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(177, 100)
        Me.txt_obs.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(628, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Observaçao"
        '
        'bnt_inclui
        '
        Me.bnt_inclui.Location = New System.Drawing.Point(652, 385)
        Me.bnt_inclui.Name = "bnt_inclui"
        Me.bnt_inclui.Size = New System.Drawing.Size(140, 53)
        Me.bnt_inclui.TabIndex = 44
        Me.bnt_inclui.Text = "Gravar Romaneio"
        Me.bnt_inclui.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(480, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Estado"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estado.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_estado.Location = New System.Drawing.Point(535, 10)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(71, 23)
        Me.lbl_estado.TabIndex = 46
        Me.lbl_estado.Text = "estado"
        '
        'NovoRomneio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bnt_inclui)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.cmb_vendedor)
        Me.Controls.Add(Me.bnt_fecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_valorTotal)
        Me.Controls.Add(Me.dtp_dataRomaneio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_VFiado)
        Me.Controls.Add(Me.txt_VBoleto)
        Me.Controls.Add(Me.txt_VMoeda)
        Me.Controls.Add(Me.txt_VDinheiro)
        Me.Controls.Add(Me.txt_VCheque)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_idromaneio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_ProdutosRomaneio)
        Me.Name = "NovoRomneio"
        Me.Text = "Novo Romaneio"
        CType(Me.dgv_ProdutosRomaneio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_valorTotal As Label
    Friend WithEvents dtp_dataRomaneio As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_VFiado As TextBox
    Friend WithEvents txt_VBoleto As TextBox
    Friend WithEvents txt_VMoeda As TextBox
    Friend WithEvents txt_VDinheiro As TextBox
    Friend WithEvents txt_VCheque As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_idromaneio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_ProdutosRomaneio As DataGridView
    Friend WithEvents bnt_fecha As Button
    Friend WithEvents cmb_vendedor As ComboBox
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents bnt_inclui As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_estado As Label
End Class
