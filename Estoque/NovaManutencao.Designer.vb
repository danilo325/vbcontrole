<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovaManutencao
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_datamanutencao = New System.Windows.Forms.DateTimePicker()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.cmb_veiculo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_local = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Descrição manutenção"
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(166, 126)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(538, 67)
        Me.txt_descricao.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(687, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 33)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Gravar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Observação"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Valor manutenção"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Data da manutenção"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Manutenção para"
        '
        'dtp_datamanutencao
        '
        Me.dtp_datamanutencao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datamanutencao.Location = New System.Drawing.Point(156, 237)
        Me.dtp_datamanutencao.Name = "dtp_datamanutencao"
        Me.dtp_datamanutencao.Size = New System.Drawing.Size(110, 20)
        Me.dtp_datamanutencao.TabIndex = 42
        Me.dtp_datamanutencao.Value = New Date(2018, 9, 21, 14, 14, 56, 0)
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(166, 199)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor.TabIndex = 41
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(119, 300)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(325, 95)
        Me.txt_obs.TabIndex = 40
        '
        'cmb_veiculo
        '
        Me.cmb_veiculo.FormattingEnabled = True
        Me.cmb_veiculo.Location = New System.Drawing.Point(156, 28)
        Me.cmb_veiculo.Name = "cmb_veiculo"
        Me.cmb_veiculo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_veiculo.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Local de realizaçã"
        '
        'txt_local
        '
        Me.txt_local.Location = New System.Drawing.Point(156, 82)
        Me.txt_local.Name = "txt_local"
        Me.txt_local.Size = New System.Drawing.Size(146, 20)
        Me.txt_local.TabIndex = 50
        '
        'NovaManutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_local)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_datamanutencao)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.cmb_veiculo)
        Me.Name = "NovaManutencao"
        Me.Text = "Nova manutenção"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_datamanutencao As DateTimePicker
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents cmb_veiculo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_local As TextBox
End Class
