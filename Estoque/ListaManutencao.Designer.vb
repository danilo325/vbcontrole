﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaManutencao
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
        Me.txt_tipodespesa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_datadespesaf = New System.Windows.Forms.DateTimePicker()
        Me.bnt_novamanutencao = New System.Windows.Forms.Button()
        Me.bnt_pesquisar = New System.Windows.Forms.Button()
        Me.txt_numeromanutencao = New System.Windows.Forms.TextBox()
        Me.dtp_datadespesai = New System.Windows.Forms.DateTimePicker()
        Me.cmb_veiculos = New System.Windows.Forms.ComboBox()
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
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Tipo despesa"
        '
        'txt_tipodespesa
        '
        Me.txt_tipodespesa.Location = New System.Drawing.Point(87, 166)
        Me.txt_tipodespesa.Name = "txt_tipodespesa"
        Me.txt_tipodespesa.Size = New System.Drawing.Size(280, 20)
        Me.txt_tipodespesa.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Veiculo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nº Manutenção"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(393, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Data inicial"
        '
        'dtp_datadespesaf
        '
        Me.dtp_datadespesaf.Checked = False
        Me.dtp_datadespesaf.CustomFormat = "dd/MM/yyyy"
        Me.dtp_datadespesaf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datadespesaf.Location = New System.Drawing.Point(454, 137)
        Me.dtp_datadespesaf.Name = "dtp_datadespesaf"
        Me.dtp_datadespesaf.ShowCheckBox = True
        Me.dtp_datadespesaf.Size = New System.Drawing.Size(99, 20)
        Me.dtp_datadespesaf.TabIndex = 34
        '
        'bnt_novamanutencao
        '
        Me.bnt_novamanutencao.Location = New System.Drawing.Point(407, 7)
        Me.bnt_novamanutencao.Name = "bnt_novamanutencao"
        Me.bnt_novamanutencao.Size = New System.Drawing.Size(113, 84)
        Me.bnt_novamanutencao.TabIndex = 33
        Me.bnt_novamanutencao.Text = "Nova Manutenção"
        Me.bnt_novamanutencao.UseVisualStyleBackColor = True
        '
        'bnt_pesquisar
        '
        Me.bnt_pesquisar.Location = New System.Drawing.Point(657, 137)
        Me.bnt_pesquisar.Name = "bnt_pesquisar"
        Me.bnt_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisar.TabIndex = 32
        Me.bnt_pesquisar.Text = "Pesquisar"
        Me.bnt_pesquisar.UseVisualStyleBackColor = True
        '
        'txt_numeromanutencao
        '
        Me.txt_numeromanutencao.Location = New System.Drawing.Point(275, 131)
        Me.txt_numeromanutencao.Name = "txt_numeromanutencao"
        Me.txt_numeromanutencao.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeromanutencao.TabIndex = 31
        '
        'dtp_datadespesai
        '
        Me.dtp_datadespesai.Checked = False
        Me.dtp_datadespesai.CustomFormat = "dd/MM/yyyy"
        Me.dtp_datadespesai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datadespesai.Location = New System.Drawing.Point(454, 115)
        Me.dtp_datadespesai.Name = "dtp_datadespesai"
        Me.dtp_datadespesai.ShowCheckBox = True
        Me.dtp_datadespesai.Size = New System.Drawing.Size(99, 20)
        Me.dtp_datadespesai.TabIndex = 30
        '
        'cmb_veiculos
        '
        Me.cmb_veiculos.FormattingEnabled = True
        Me.cmb_veiculos.Location = New System.Drawing.Point(65, 129)
        Me.cmb_veiculos.Name = "cmb_veiculos"
        Me.cmb_veiculos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_veiculos.TabIndex = 29
        '
        'bnt_fechar
        '
        Me.bnt_fechar.Location = New System.Drawing.Point(672, 421)
        Me.bnt_fechar.Name = "bnt_fechar"
        Me.bnt_fechar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fechar.TabIndex = 28
        Me.bnt_fechar.Text = "Fechar"
        Me.bnt_fechar.UseVisualStyleBackColor = True
        '
        'dgv_listadespesa
        '
        Me.dgv_listadespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listadespesa.Location = New System.Drawing.Point(20, 210)
        Me.dgv_listadespesa.Name = "dgv_listadespesa"
        Me.dgv_listadespesa.Size = New System.Drawing.Size(763, 205)
        Me.dgv_listadespesa.TabIndex = 27
        '
        'ListaManutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_tipodespesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_datadespesaf)
        Me.Controls.Add(Me.bnt_novamanutencao)
        Me.Controls.Add(Me.bnt_pesquisar)
        Me.Controls.Add(Me.txt_numeromanutencao)
        Me.Controls.Add(Me.dtp_datadespesai)
        Me.Controls.Add(Me.cmb_veiculos)
        Me.Controls.Add(Me.bnt_fechar)
        Me.Controls.Add(Me.dgv_listadespesa)
        Me.Name = "ListaManutencao"
        Me.Text = "Lista Manutanção"
        CType(Me.dgv_listadespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txt_tipodespesa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_datadespesaf As DateTimePicker
    Friend WithEvents bnt_novamanutencao As Button
    Friend WithEvents bnt_pesquisar As Button
    Friend WithEvents txt_numeromanutencao As TextBox
    Friend WithEvents dtp_datadespesai As DateTimePicker
    Friend WithEvents cmb_veiculos As ComboBox
    Friend WithEvents bnt_fechar As Button
    Friend WithEvents dgv_listadespesa As DataGridView
End Class
