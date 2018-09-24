<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaAbastecimento
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
        Me.dgv_listaabastecimento = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_veiculos = New System.Windows.Forms.ComboBox()
        Me.dtp_dataabastecimentoi = New System.Windows.Forms.DateTimePicker()
        Me.txt_numeropeido = New System.Windows.Forms.TextBox()
        Me.bnt_pesquisar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtp_dataabastecimentof = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv_listaabastecimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_listaabastecimento
        '
        Me.dgv_listaabastecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaabastecimento.Location = New System.Drawing.Point(12, 215)
        Me.dgv_listaabastecimento.Name = "dgv_listaabastecimento"
        Me.dgv_listaabastecimento.Size = New System.Drawing.Size(763, 205)
        Me.dgv_listaabastecimento.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(664, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_veiculos
        '
        Me.cmb_veiculos.FormattingEnabled = True
        Me.cmb_veiculos.Location = New System.Drawing.Point(68, 135)
        Me.cmb_veiculos.Name = "cmb_veiculos"
        Me.cmb_veiculos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_veiculos.TabIndex = 2
        '
        'dtp_dataabastecimentoi
        '
        Me.dtp_dataabastecimentoi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_dataabastecimentoi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dataabastecimentoi.Location = New System.Drawing.Point(497, 132)
        Me.dtp_dataabastecimentoi.Name = "dtp_dataabastecimentoi"
        Me.dtp_dataabastecimentoi.ShowCheckBox = True
        Me.dtp_dataabastecimentoi.Size = New System.Drawing.Size(99, 20)
        Me.dtp_dataabastecimentoi.TabIndex = 4
        '
        'txt_numeropeido
        '
        Me.txt_numeropeido.Location = New System.Drawing.Point(292, 135)
        Me.txt_numeropeido.Name = "txt_numeropeido"
        Me.txt_numeropeido.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeropeido.TabIndex = 5
        '
        'bnt_pesquisar
        '
        Me.bnt_pesquisar.Location = New System.Drawing.Point(673, 133)
        Me.bnt_pesquisar.Name = "bnt_pesquisar"
        Me.bnt_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisar.TabIndex = 6
        Me.bnt_pesquisar.Text = "Pesquisar"
        Me.bnt_pesquisar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(399, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 84)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Novo Abastecimento"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtp_dataabastecimentof
        '
        Me.dtp_dataabastecimentof.CustomFormat = "dd/MM/yyyy"
        Me.dtp_dataabastecimentof.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dataabastecimentof.Location = New System.Drawing.Point(497, 154)
        Me.dtp_dataabastecimentof.Name = "dtp_dataabastecimentof"
        Me.dtp_dataabastecimentof.ShowCheckBox = True
        Me.dtp_dataabastecimentof.Size = New System.Drawing.Size(99, 20)
        Me.dtp_dataabastecimentof.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(436, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Data inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Data final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nº pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Veiculo"
        '
        'ListaAbastecimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_dataabastecimentof)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bnt_pesquisar)
        Me.Controls.Add(Me.txt_numeropeido)
        Me.Controls.Add(Me.dtp_dataabastecimentoi)
        Me.Controls.Add(Me.cmb_veiculos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_listaabastecimento)
        Me.Name = "ListaAbastecimento"
        Me.Text = "Lista Abastecimento"
        CType(Me.dgv_listaabastecimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_listaabastecimento As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents cmb_veiculos As ComboBox
    Friend WithEvents dtp_dataabastecimentoi As DateTimePicker
    Friend WithEvents txt_numeropeido As TextBox
    Friend WithEvents bnt_pesquisar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dtp_dataabastecimentof As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
