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
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
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
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_produtos
        '
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Location = New System.Drawing.Point(12, 220)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.Size = New System.Drawing.Size(914, 198)
        Me.dgv_produtos.TabIndex = 0
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(612, 72)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(228, 101)
        Me.txt_obs.TabIndex = 2
        '
        'dtp_data
        '
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(250, 46)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(100, 20)
        Me.dtp_data.TabIndex = 3
        '
        'txt_valorImposto
        '
        Me.txt_valorImposto.Location = New System.Drawing.Point(395, 136)
        Me.txt_valorImposto.Name = "txt_valorImposto"
        Me.txt_valorImposto.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorImposto.TabIndex = 4
        '
        'txt_valorTotal
        '
        Me.txt_valorTotal.Location = New System.Drawing.Point(250, 160)
        Me.txt_valorTotal.Name = "txt_valorTotal"
        Me.txt_valorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorTotal.TabIndex = 5
        '
        'txt_numeroPedido
        '
        Me.txt_numeroPedido.Location = New System.Drawing.Point(63, 160)
        Me.txt_numeroPedido.Name = "txt_numeroPedido"
        Me.txt_numeroPedido.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeroPedido.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data da  Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fornecedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nº pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Valor total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Valor em impostos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(506, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observação"
        '
        'cmb_fornecedor
        '
        Me.cmb_fornecedor.FormattingEnabled = True
        Me.cmb_fornecedor.Location = New System.Drawing.Point(99, 101)
        Me.cmb_fornecedor.Name = "cmb_fornecedor"
        Me.cmb_fornecedor.Size = New System.Drawing.Size(166, 21)
        Me.cmb_fornecedor.TabIndex = 13
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
        'frm_novaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 450)
        Me.Controls.Add(Me.bnt_grava)
        Me.Controls.Add(Me.cmb_fornecedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_numeroPedido)
        Me.Controls.Add(Me.txt_valorTotal)
        Me.Controls.Add(Me.txt_valorImposto)
        Me.Controls.Add(Me.dtp_data)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.dgv_produtos)
        Me.Name = "frm_novaCompra"
        Me.Text = "Nova Compra"
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_produtos As DataGridView
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
End Class
