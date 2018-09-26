<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_novaCompra
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
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_valorImposto = New System.Windows.Forms.TextBox()
        Me.txt_valorTotal = New System.Windows.Forms.TextBox()
        Me.txt_numeroPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_fornecedor = New System.Windows.Forms.ComboBox()
        Me.bnt_grava = New System.Windows.Forms.Button()
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
        Me.gpb_produtos = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_tipoTrasporte = New System.Windows.Forms.ComboBox()
        Me.txt_freteValor = New System.Windows.Forms.TextBox()
        Me.txt_freteObs = New System.Windows.Forms.TextBox()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_valorChapa = New System.Windows.Forms.TextBox()
        Me.txt_obsChapa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpb_produtos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(282, 19)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(228, 101)
        Me.txt_obs.TabIndex = 6
        '
        'dtp_data
        '
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(94, 45)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(100, 20)
        Me.dtp_data.TabIndex = 1
        '
        'txt_valorImposto
        '
        Me.txt_valorImposto.Location = New System.Drawing.Point(94, 120)
        Me.txt_valorImposto.Name = "txt_valorImposto"
        Me.txt_valorImposto.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorImposto.TabIndex = 4
        '
        'txt_valorTotal
        '
        Me.txt_valorTotal.Location = New System.Drawing.Point(94, 94)
        Me.txt_valorTotal.Name = "txt_valorTotal"
        Me.txt_valorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorTotal.TabIndex = 5
        '
        'txt_numeroPedido
        '
        Me.txt_numeroPedido.Location = New System.Drawing.Point(94, 19)
        Me.txt_numeroPedido.Name = "txt_numeroPedido"
        Me.txt_numeroPedido.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeroPedido.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data da  Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fornecedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nº pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Valor total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Valor em impostos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observação"
        '
        'cmb_fornecedor
        '
        Me.cmb_fornecedor.FormattingEnabled = True
        Me.cmb_fornecedor.Location = New System.Drawing.Point(94, 70)
        Me.cmb_fornecedor.Name = "cmb_fornecedor"
        Me.cmb_fornecedor.Size = New System.Drawing.Size(166, 21)
        Me.cmb_fornecedor.TabIndex = 2
        '
        'bnt_grava
        '
        Me.bnt_grava.Location = New System.Drawing.Point(792, 424)
        Me.bnt_grava.Name = "bnt_grava"
        Me.bnt_grava.Size = New System.Drawing.Size(75, 23)
        Me.bnt_grava.TabIndex = 14
        Me.bnt_grava.Text = "gravar"
        Me.bnt_grava.UseVisualStyleBackColor = True
        '
        'dgv_produtos
        '
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Location = New System.Drawing.Point(6, 19)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.Size = New System.Drawing.Size(1115, 192)
        Me.dgv_produtos.TabIndex = 0
        '
        'gpb_produtos
        '
        Me.gpb_produtos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gpb_produtos.Controls.Add(Me.dgv_produtos)
        Me.gpb_produtos.Location = New System.Drawing.Point(12, 200)
        Me.gpb_produtos.Name = "gpb_produtos"
        Me.gpb_produtos.Size = New System.Drawing.Size(1127, 218)
        Me.gpb_produtos.TabIndex = 15
        Me.gpb_produtos.TabStop = False
        Me.gpb_produtos.Text = "Produtos da compra"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.dtp_data)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_valorImposto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_fornecedor)
        Me.GroupBox1.Controls.Add(Me.txt_obs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_valorTotal)
        Me.GroupBox1.Controls.Add(Me.txt_numeroPedido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 160)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbl_tipo)
        Me.GroupBox2.Controls.Add(Me.txt_freteObs)
        Me.GroupBox2.Controls.Add(Me.txt_freteValor)
        Me.GroupBox2.Controls.Add(Me.cmb_tipoTrasporte)
        Me.GroupBox2.Location = New System.Drawing.Point(543, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 160)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações de Transporte"
        '
        'cmb_tipoTrasporte
        '
        Me.cmb_tipoTrasporte.FormattingEnabled = True
        Me.cmb_tipoTrasporte.Location = New System.Drawing.Point(71, 17)
        Me.cmb_tipoTrasporte.Name = "cmb_tipoTrasporte"
        Me.cmb_tipoTrasporte.Size = New System.Drawing.Size(97, 21)
        Me.cmb_tipoTrasporte.TabIndex = 0
        '
        'txt_freteValor
        '
        Me.txt_freteValor.Location = New System.Drawing.Point(71, 42)
        Me.txt_freteValor.Name = "txt_freteValor"
        Me.txt_freteValor.Size = New System.Drawing.Size(184, 20)
        Me.txt_freteValor.TabIndex = 1
        '
        'txt_freteObs
        '
        Me.txt_freteObs.Location = New System.Drawing.Point(71, 68)
        Me.txt_freteObs.Multiline = True
        Me.txt_freteObs.Name = "txt_freteObs"
        Me.txt_freteObs.Size = New System.Drawing.Size(184, 84)
        Me.txt_freteObs.TabIndex = 5
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(36, 18)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_tipo.TabIndex = 7
        Me.lbl_tipo.Text = "Tipo "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Valor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Observação"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_obsChapa)
        Me.GroupBox3.Controls.Add(Me.txt_valorChapa)
        Me.GroupBox3.Location = New System.Drawing.Point(842, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 160)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informação de descarga"
        '
        'txt_valorChapa
        '
        Me.txt_valorChapa.Location = New System.Drawing.Point(69, 19)
        Me.txt_valorChapa.Name = "txt_valorChapa"
        Me.txt_valorChapa.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorChapa.TabIndex = 0
        '
        'txt_obsChapa
        '
        Me.txt_obsChapa.Location = New System.Drawing.Point(69, 48)
        Me.txt_obsChapa.Multiline = True
        Me.txt_obsChapa.Name = "txt_obsChapa"
        Me.txt_obsChapa.Size = New System.Drawing.Size(146, 92)
        Me.txt_obsChapa.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Valor chapa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Obs Chapa"
        '
        'frm_novaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpb_produtos)
        Me.Controls.Add(Me.bnt_grava)
        Me.Name = "frm_novaCompra"
        Me.Text = "Nova Compra"
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpb_produtos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents txt_valorImposto As TextBox
    Friend WithEvents txt_valorTotal As TextBox
    Friend WithEvents txt_numeroPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_fornecedor As ComboBox
    Friend WithEvents bnt_grava As Button
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents gpb_produtos As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents txt_freteObs As TextBox
    Friend WithEvents txt_freteValor As TextBox
    Friend WithEvents cmb_tipoTrasporte As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_obsChapa As TextBox
    Friend WithEvents txt_valorChapa As TextBox
    Friend WithEvents Label8 As Label
End Class
