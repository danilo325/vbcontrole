<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoAbastecimento
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
        Me.cmb_veiculo = New System.Windows.Forms.ComboBox()
        Me.txt_qtdlitros = New System.Windows.Forms.TextBox()
        Me.txt_npedido = New System.Windows.Forms.TextBox()
        Me.cmb_combustivel = New System.Windows.Forms.ComboBox()
        Me.txt_valorlitro = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.txt_valortotal = New System.Windows.Forms.TextBox()
        Me.dtp_dataabasteci = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_local = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_veiculo
        '
        Me.cmb_veiculo.FormattingEnabled = True
        Me.cmb_veiculo.Location = New System.Drawing.Point(124, 65)
        Me.cmb_veiculo.Name = "cmb_veiculo"
        Me.cmb_veiculo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_veiculo.TabIndex = 0
        '
        'txt_qtdlitros
        '
        Me.txt_qtdlitros.Location = New System.Drawing.Point(452, 76)
        Me.txt_qtdlitros.Name = "txt_qtdlitros"
        Me.txt_qtdlitros.Size = New System.Drawing.Size(121, 20)
        Me.txt_qtdlitros.TabIndex = 1
        '
        'txt_npedido
        '
        Me.txt_npedido.Location = New System.Drawing.Point(124, 23)
        Me.txt_npedido.Name = "txt_npedido"
        Me.txt_npedido.Size = New System.Drawing.Size(121, 20)
        Me.txt_npedido.TabIndex = 2
        '
        'cmb_combustivel
        '
        Me.cmb_combustivel.FormattingEnabled = True
        Me.cmb_combustivel.Location = New System.Drawing.Point(124, 115)
        Me.cmb_combustivel.Name = "cmb_combustivel"
        Me.cmb_combustivel.Size = New System.Drawing.Size(121, 21)
        Me.cmb_combustivel.TabIndex = 3
        '
        'txt_valorlitro
        '
        Me.txt_valorlitro.Location = New System.Drawing.Point(452, 129)
        Me.txt_valorlitro.Name = "txt_valorlitro"
        Me.txt_valorlitro.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorlitro.TabIndex = 4
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(410, 194)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(325, 95)
        Me.txt_obs.TabIndex = 5
        '
        'txt_valortotal
        '
        Me.txt_valortotal.Location = New System.Drawing.Point(124, 206)
        Me.txt_valortotal.Name = "txt_valortotal"
        Me.txt_valortotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_valortotal.TabIndex = 6
        '
        'dtp_dataabasteci
        '
        Me.dtp_dataabasteci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dataabasteci.Location = New System.Drawing.Point(463, 23)
        Me.dtp_dataabasteci.Name = "dtp_dataabasteci"
        Me.dtp_dataabasteci.ShowCheckBox = True
        Me.dtp_dataabasteci.Size = New System.Drawing.Size(200, 20)
        Me.dtp_dataabasteci.TabIndex = 7
        Me.dtp_dataabasteci.Value = New Date(2018, 9, 21, 14, 14, 56, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Veículo abastecido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Valor por litro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantos litros "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Número do pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Qual combustível"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Data do abastecimento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Valor total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Observação"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(655, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Gravar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_local
        '
        Me.txt_local.Location = New System.Drawing.Point(124, 157)
        Me.txt_local.Name = "txt_local"
        Me.txt_local.Size = New System.Drawing.Size(100, 20)
        Me.txt_local.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Local abastecimento"
        '
        'NovoAbastecimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_local)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_dataabasteci)
        Me.Controls.Add(Me.txt_valortotal)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.txt_valorlitro)
        Me.Controls.Add(Me.cmb_combustivel)
        Me.Controls.Add(Me.txt_npedido)
        Me.Controls.Add(Me.txt_qtdlitros)
        Me.Controls.Add(Me.cmb_veiculo)
        Me.Name = "NovoAbastecimento"
        Me.Text = "Novo Abastecimento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_veiculo As ComboBox
    Friend WithEvents txt_qtdlitros As TextBox
    Friend WithEvents txt_npedido As TextBox
    Friend WithEvents cmb_combustivel As ComboBox
    Friend WithEvents txt_valorlitro As TextBox
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents txt_valortotal As TextBox
    Friend WithEvents dtp_dataabasteci As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_local As TextBox
    Friend WithEvents Label9 As Label
End Class
