<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovaDespesaGeral
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_despesa = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_datadevencimento = New System.Windows.Forms.DateTimePicker()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.cmb_tipodespesa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_datadepagamento = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Despesa"
        '
        'txt_despesa
        '
        Me.txt_despesa.Location = New System.Drawing.Point(156, 53)
        Me.txt_despesa.Name = "txt_despesa"
        Me.txt_despesa.Size = New System.Drawing.Size(146, 20)
        Me.txt_despesa.TabIndex = 63
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(566, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 33)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Gravar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Observação"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Valor manutenção"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Data de Vencimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Tipo de despesa"
        '
        'dtp_datadevencimento
        '
        Me.dtp_datadevencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datadevencimento.Location = New System.Drawing.Point(167, 117)
        Me.dtp_datadevencimento.Name = "dtp_datadevencimento"
        Me.dtp_datadevencimento.Size = New System.Drawing.Size(110, 20)
        Me.dtp_datadevencimento.TabIndex = 55
        Me.dtp_datadevencimento.Value = New Date(2018, 9, 21, 14, 14, 56, 0)
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(156, 79)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor.TabIndex = 54
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(109, 215)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(325, 95)
        Me.txt_obs.TabIndex = 53
        '
        'cmb_tipodespesa
        '
        Me.cmb_tipodespesa.FormattingEnabled = True
        Me.cmb_tipodespesa.Location = New System.Drawing.Point(156, 10)
        Me.cmb_tipodespesa.Name = "cmb_tipodespesa"
        Me.cmb_tipodespesa.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipodespesa.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Data de Pagamento"
        '
        'dtp_datadepagamento
        '
        Me.dtp_datadepagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datadepagamento.Location = New System.Drawing.Point(167, 165)
        Me.dtp_datadepagamento.Name = "dtp_datadepagamento"
        Me.dtp_datadepagamento.Size = New System.Drawing.Size(110, 20)
        Me.dtp_datadepagamento.TabIndex = 65
        Me.dtp_datadepagamento.Value = New Date(2018, 9, 21, 14, 14, 56, 0)
        '
        'NovaDespesaGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_datadepagamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_despesa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_datadevencimento)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.cmb_tipodespesa)
        Me.Name = "NovaDespesaGeral"
        Me.Text = "Nova Despesa Geral"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txt_despesa As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_datadevencimento As DateTimePicker
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents cmb_tipodespesa As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_datadepagamento As DateTimePicker
End Class
