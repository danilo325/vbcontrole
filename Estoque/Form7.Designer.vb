<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_compras
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
        Me.dgv_produtosCompra = New System.Windows.Forms.DataGridView()
        Me.bnt_fecha = New System.Windows.Forms.Button()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_numeroPedido = New System.Windows.Forms.TextBox()
        Me.dtp_inicial = New System.Windows.Forms.DateTimePicker()
        Me.dtp_final = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Fornecedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bnt_Exclui = New System.Windows.Forms.Button()
        Me.bnt_Edita = New System.Windows.Forms.Button()
        Me.bnt_Inclui = New System.Windows.Forms.Button()
        Me.bnt_pesquisa = New System.Windows.Forms.Button()
        CType(Me.dgv_produtosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_produtosCompra
        '
        Me.dgv_produtosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtosCompra.Location = New System.Drawing.Point(12, 138)
        Me.dgv_produtosCompra.Name = "dgv_produtosCompra"
        Me.dgv_produtosCompra.Size = New System.Drawing.Size(903, 279)
        Me.dgv_produtosCompra.TabIndex = 0
        '
        'bnt_fecha
        '
        Me.bnt_fecha.Location = New System.Drawing.Point(816, 423)
        Me.bnt_fecha.Name = "bnt_fecha"
        Me.bnt_fecha.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fecha.TabIndex = 1
        Me.bnt_fecha.Text = "Fecha"
        Me.bnt_fecha.UseVisualStyleBackColor = True
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(61, 107)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_Id.Size = New System.Drawing.Size(76, 20)
        Me.txt_Id.TabIndex = 2
        '
        'txt_numeroPedido
        '
        Me.txt_numeroPedido.Location = New System.Drawing.Point(555, 100)
        Me.txt_numeroPedido.Name = "txt_numeroPedido"
        Me.txt_numeroPedido.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeroPedido.TabIndex = 5
        '
        'dtp_inicial
        '
        Me.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicial.Location = New System.Drawing.Point(728, 78)
        Me.dtp_inicial.Name = "dtp_inicial"
        Me.dtp_inicial.Size = New System.Drawing.Size(84, 20)
        Me.dtp_inicial.TabIndex = 12
        '
        'dtp_final
        '
        Me.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_final.Location = New System.Drawing.Point(728, 104)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.Size = New System.Drawing.Size(84, 20)
        Me.dtp_final.TabIndex = 13
        '
        'cmb_Fornecedor
        '
        Me.cmb_Fornecedor.FormattingEnabled = True
        Me.cmb_Fornecedor.Location = New System.Drawing.Point(227, 104)
        Me.cmb_Fornecedor.Name = "cmb_Fornecedor"
        Me.cmb_Fornecedor.Size = New System.Drawing.Size(225, 21)
        Me.cmb_Fornecedor.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fornecedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nº pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(664, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Data Inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(670, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Data final"
        '
        'bnt_Exclui
        '
        Me.bnt_Exclui.Location = New System.Drawing.Point(556, 12)
        Me.bnt_Exclui.Name = "bnt_Exclui"
        Me.bnt_Exclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Exclui.TabIndex = 27
        Me.bnt_Exclui.Text = "Exclui"
        Me.bnt_Exclui.UseVisualStyleBackColor = True
        '
        'bnt_Edita
        '
        Me.bnt_Edita.Location = New System.Drawing.Point(419, 12)
        Me.bnt_Edita.Name = "bnt_Edita"
        Me.bnt_Edita.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Edita.TabIndex = 26
        Me.bnt_Edita.Text = "Edita"
        Me.bnt_Edita.UseVisualStyleBackColor = True
        '
        'bnt_Inclui
        '
        Me.bnt_Inclui.Location = New System.Drawing.Point(282, 12)
        Me.bnt_Inclui.Name = "bnt_Inclui"
        Me.bnt_Inclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Inclui.TabIndex = 25
        Me.bnt_Inclui.Text = "Inclui"
        Me.bnt_Inclui.UseVisualStyleBackColor = True
        '
        'bnt_pesquisa
        '
        Me.bnt_pesquisa.Location = New System.Drawing.Point(840, 107)
        Me.bnt_pesquisa.Name = "bnt_pesquisa"
        Me.bnt_pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisa.TabIndex = 36
        Me.bnt_pesquisa.Text = "Pesquisar"
        Me.bnt_pesquisa.UseVisualStyleBackColor = True
        '
        'form_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 450)
        Me.Controls.Add(Me.bnt_pesquisa)
        Me.Controls.Add(Me.bnt_Exclui)
        Me.Controls.Add(Me.bnt_Edita)
        Me.Controls.Add(Me.bnt_Inclui)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Fornecedor)
        Me.Controls.Add(Me.dtp_final)
        Me.Controls.Add(Me.dtp_inicial)
        Me.Controls.Add(Me.txt_numeroPedido)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.bnt_fecha)
        Me.Controls.Add(Me.dgv_produtosCompra)
        Me.Name = "form_compras"
        Me.Text = " "
        CType(Me.dgv_produtosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_produtosCompra As DataGridView
    Friend WithEvents bnt_fecha As Button
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents txt_numeroPedido As TextBox
    Friend WithEvents dtp_inicial As DateTimePicker
    Friend WithEvents dtp_final As DateTimePicker
    Friend WithEvents cmb_Fornecedor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bnt_Exclui As Button
    Friend WithEvents bnt_Edita As Button
    Friend WithEvents bnt_Inclui As Button
    Friend WithEvents bnt_pesquisa As Button
End Class
