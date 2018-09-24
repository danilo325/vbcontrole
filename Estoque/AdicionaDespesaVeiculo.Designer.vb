<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdicionaDespesaVeiculo
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
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_datadespesa = New System.Windows.Forms.DateTimePicker()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.cmb_veiculo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Tipo de Despesa"
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(161, 89)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 33)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Gravar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Observação"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Valor despesa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Data da despesa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Despesa para "
        '
        'dtp_datadespesa
        '
        Me.dtp_datadespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datadespesa.Location = New System.Drawing.Point(151, 177)
        Me.dtp_datadespesa.Name = "dtp_datadespesa"
        Me.dtp_datadespesa.Size = New System.Drawing.Size(110, 20)
        Me.dtp_datadespesa.TabIndex = 27
        Me.dtp_datadespesa.Value = New Date(2018, 9, 21, 14, 14, 56, 0)
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(161, 139)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor.TabIndex = 26
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(114, 240)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(325, 95)
        Me.txt_obs.TabIndex = 25
        '
        'cmb_veiculo
        '
        Me.cmb_veiculo.FormattingEnabled = True
        Me.cmb_veiculo.Location = New System.Drawing.Point(151, 27)
        Me.cmb_veiculo.Name = "cmb_veiculo"
        Me.cmb_veiculo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_veiculo.TabIndex = 20
        '
        'AdicionaDespesaVeiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_datadespesa)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.cmb_veiculo)
        Me.Name = "AdicionaDespesaVeiculo"
        Me.Text = "Nova Despesa Veiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_datadespesa As DateTimePicker
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents cmb_veiculo As ComboBox
End Class
