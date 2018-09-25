<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DespesasGerais
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_despesa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_datadepagamento = New System.Windows.Forms.DateTimePicker()
        Me.bnt_novadespes = New System.Windows.Forms.Button()
        Me.bnt_pesquisar = New System.Windows.Forms.Button()
        Me.txt_numerodespesa = New System.Windows.Forms.TextBox()
        Me.dtp_datavencimento = New System.Windows.Forms.DateTimePicker()
        Me.cmb_tipodespesa = New System.Windows.Forms.ComboBox()
        Me.bnt_fechar = New System.Windows.Forms.Button()
        Me.dgv_listadespesa = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_listadespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Despesa"
        '
        'txt_despesa
        '
        Me.txt_despesa.Location = New System.Drawing.Point(87, 166)
        Me.txt_despesa.Name = "txt_despesa"
        Me.txt_despesa.Size = New System.Drawing.Size(280, 20)
        Me.txt_despesa.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Tipo de despesa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Nº despesa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Data de Pagamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Data de Vencimento"
        '
        'dtp_datadepagamento
        '
        Me.dtp_datadepagamento.Checked = False
        Me.dtp_datadepagamento.CustomFormat = "dd/MM/yyyy"
        Me.dtp_datadepagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datadepagamento.Location = New System.Drawing.Point(515, 164)
        Me.dtp_datadepagamento.Name = "dtp_datadepagamento"
        Me.dtp_datadepagamento.ShowCheckBox = True
        Me.dtp_datadepagamento.Size = New System.Drawing.Size(99, 20)
        Me.dtp_datadepagamento.TabIndex = 48
        '
        'bnt_novadespes
        '
        Me.bnt_novadespes.Location = New System.Drawing.Point(407, 7)
        Me.bnt_novadespes.Name = "bnt_novadespes"
        Me.bnt_novadespes.Size = New System.Drawing.Size(113, 84)
        Me.bnt_novadespes.TabIndex = 47
        Me.bnt_novadespes.Text = "Nova Despesa"
        Me.bnt_novadespes.UseVisualStyleBackColor = True
        '
        'bnt_pesquisar
        '
        Me.bnt_pesquisar.Location = New System.Drawing.Point(657, 137)
        Me.bnt_pesquisar.Name = "bnt_pesquisar"
        Me.bnt_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisar.TabIndex = 46
        Me.bnt_pesquisar.Text = "Pesquisar"
        Me.bnt_pesquisar.UseVisualStyleBackColor = True
        '
        'txt_numerodespesa
        '
        Me.txt_numerodespesa.Location = New System.Drawing.Point(301, 129)
        Me.txt_numerodespesa.Name = "txt_numerodespesa"
        Me.txt_numerodespesa.Size = New System.Drawing.Size(100, 20)
        Me.txt_numerodespesa.TabIndex = 45
        '
        'dtp_datavencimento
        '
        Me.dtp_datavencimento.Checked = False
        Me.dtp_datavencimento.CustomFormat = "dd/MM/yyyy"
        Me.dtp_datavencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datavencimento.Location = New System.Drawing.Point(515, 138)
        Me.dtp_datavencimento.Name = "dtp_datavencimento"
        Me.dtp_datavencimento.ShowCheckBox = True
        Me.dtp_datavencimento.Size = New System.Drawing.Size(99, 20)
        Me.dtp_datavencimento.TabIndex = 44
        '
        'cmb_tipodespesa
        '
        Me.cmb_tipodespesa.FormattingEnabled = True
        Me.cmb_tipodespesa.Location = New System.Drawing.Point(109, 123)
        Me.cmb_tipodespesa.Name = "cmb_tipodespesa"
        Me.cmb_tipodespesa.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipodespesa.TabIndex = 43
        '
        'bnt_fechar
        '
        Me.bnt_fechar.Location = New System.Drawing.Point(672, 421)
        Me.bnt_fechar.Name = "bnt_fechar"
        Me.bnt_fechar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fechar.TabIndex = 42
        Me.bnt_fechar.Text = "Fechar"
        Me.bnt_fechar.UseVisualStyleBackColor = True
        '
        'dgv_listadespesa
        '
        Me.dgv_listadespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listadespesa.Location = New System.Drawing.Point(20, 210)
        Me.dgv_listadespesa.Name = "dgv_listadespesa"
        Me.dgv_listadespesa.Size = New System.Drawing.Size(763, 205)
        Me.dgv_listadespesa.TabIndex = 41
        '
        'DespesasGerais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_despesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_datadepagamento)
        Me.Controls.Add(Me.bnt_novadespes)
        Me.Controls.Add(Me.bnt_pesquisar)
        Me.Controls.Add(Me.txt_numerodespesa)
        Me.Controls.Add(Me.dtp_datavencimento)
        Me.Controls.Add(Me.cmb_tipodespesa)
        Me.Controls.Add(Me.bnt_fechar)
        Me.Controls.Add(Me.dgv_listadespesa)
        Me.Name = "DespesasGerais"
        Me.Text = "Despesas"
        CType(Me.dgv_listadespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txt_despesa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_datadepagamento As DateTimePicker
    Friend WithEvents bnt_novadespes As Button
    Friend WithEvents bnt_pesquisar As Button
    Friend WithEvents txt_numerodespesa As TextBox
    Friend WithEvents dtp_datavencimento As DateTimePicker
    Friend WithEvents cmb_tipodespesa As ComboBox
    Friend WithEvents bnt_fechar As Button
    Friend WithEvents dgv_listadespesa As DataGridView
End Class
