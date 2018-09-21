<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedores
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
        Me.dgv_fornecedor = New System.Windows.Forms.DataGridView()
        Me.bnt_Fechar = New System.Windows.Forms.Button()
        Me.bnt_Exclui = New System.Windows.Forms.Button()
        Me.bnt_Edita = New System.Windows.Forms.Button()
        Me.bnt_Inclui = New System.Windows.Forms.Button()
        Me.txt_rasaosoc = New System.Windows.Forms.TextBox()
        Me.lbl_rasaosocial = New System.Windows.Forms.Label()
        Me.lbl_formaPagamento = New System.Windows.Forms.Label()
        Me.txt_fomapagamento = New System.Windows.Forms.TextBox()
        Me.lbl_cnpj = New System.Windows.Forms.Label()
        Me.txt_cnpj = New System.Windows.Forms.TextBox()
        Me.lbl_nomeFantasia = New System.Windows.Forms.Label()
        Me.txt_nomeFantasia = New System.Windows.Forms.TextBox()
        Me.lbl_idFornecedor = New System.Windows.Forms.Label()
        Me.txt_idFornecedor = New System.Windows.Forms.TextBox()
        Me.bnt_pesquisa = New System.Windows.Forms.Button()
        CType(Me.dgv_fornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_fornecedor
        '
        Me.dgv_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fornecedor.Location = New System.Drawing.Point(9, 155)
        Me.dgv_fornecedor.Name = "dgv_fornecedor"
        Me.dgv_fornecedor.Size = New System.Drawing.Size(899, 255)
        Me.dgv_fornecedor.TabIndex = 0
        '
        'bnt_Fechar
        '
        Me.bnt_Fechar.Location = New System.Drawing.Point(807, 416)
        Me.bnt_Fechar.Name = "bnt_Fechar"
        Me.bnt_Fechar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Fechar.TabIndex = 19
        Me.bnt_Fechar.Text = "Fecha"
        Me.bnt_Fechar.UseVisualStyleBackColor = True
        '
        'bnt_Exclui
        '
        Me.bnt_Exclui.Location = New System.Drawing.Point(559, 12)
        Me.bnt_Exclui.Name = "bnt_Exclui"
        Me.bnt_Exclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Exclui.TabIndex = 24
        Me.bnt_Exclui.Text = "Exclui"
        Me.bnt_Exclui.UseVisualStyleBackColor = True
        '
        'bnt_Edita
        '
        Me.bnt_Edita.Location = New System.Drawing.Point(422, 12)
        Me.bnt_Edita.Name = "bnt_Edita"
        Me.bnt_Edita.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Edita.TabIndex = 23
        Me.bnt_Edita.Text = "Edita"
        Me.bnt_Edita.UseVisualStyleBackColor = True
        '
        'bnt_Inclui
        '
        Me.bnt_Inclui.Location = New System.Drawing.Point(285, 12)
        Me.bnt_Inclui.Name = "bnt_Inclui"
        Me.bnt_Inclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Inclui.TabIndex = 22
        Me.bnt_Inclui.Text = "Inclui"
        Me.bnt_Inclui.UseVisualStyleBackColor = True
        '
        'txt_rasaosoc
        '
        Me.txt_rasaosoc.Location = New System.Drawing.Point(73, 112)
        Me.txt_rasaosoc.Name = "txt_rasaosoc"
        Me.txt_rasaosoc.Size = New System.Drawing.Size(100, 20)
        Me.txt_rasaosoc.TabIndex = 25
        '
        'lbl_rasaosocial
        '
        Me.lbl_rasaosocial.AutoSize = True
        Me.lbl_rasaosocial.Location = New System.Drawing.Point(1, 115)
        Me.lbl_rasaosocial.Name = "lbl_rasaosocial"
        Me.lbl_rasaosocial.Size = New System.Drawing.Size(70, 13)
        Me.lbl_rasaosocial.TabIndex = 26
        Me.lbl_rasaosocial.Text = "Rasão Social"
        '
        'lbl_formaPagamento
        '
        Me.lbl_formaPagamento.AutoSize = True
        Me.lbl_formaPagamento.Location = New System.Drawing.Point(640, 88)
        Me.lbl_formaPagamento.Name = "lbl_formaPagamento"
        Me.lbl_formaPagamento.Size = New System.Drawing.Size(93, 13)
        Me.lbl_formaPagamento.TabIndex = 36
        Me.lbl_formaPagamento.Text = "Forma Pagamento"
        '
        'txt_fomapagamento
        '
        Me.txt_fomapagamento.Location = New System.Drawing.Point(739, 85)
        Me.txt_fomapagamento.Name = "txt_fomapagamento"
        Me.txt_fomapagamento.Size = New System.Drawing.Size(100, 20)
        Me.txt_fomapagamento.TabIndex = 35
        '
        'lbl_cnpj
        '
        Me.lbl_cnpj.AutoSize = True
        Me.lbl_cnpj.Location = New System.Drawing.Point(382, 120)
        Me.lbl_cnpj.Name = "lbl_cnpj"
        Me.lbl_cnpj.Size = New System.Drawing.Size(34, 13)
        Me.lbl_cnpj.TabIndex = 38
        Me.lbl_cnpj.Text = "CNPJ"
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Location = New System.Drawing.Point(422, 113)
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(100, 20)
        Me.txt_cnpj.TabIndex = 37
        '
        'lbl_nomeFantasia
        '
        Me.lbl_nomeFantasia.AutoSize = True
        Me.lbl_nomeFantasia.Location = New System.Drawing.Point(345, 88)
        Me.lbl_nomeFantasia.Name = "lbl_nomeFantasia"
        Me.lbl_nomeFantasia.Size = New System.Drawing.Size(78, 13)
        Me.lbl_nomeFantasia.TabIndex = 40
        Me.lbl_nomeFantasia.Text = "Nome Fantasia"
        '
        'txt_nomeFantasia
        '
        Me.txt_nomeFantasia.Location = New System.Drawing.Point(422, 85)
        Me.txt_nomeFantasia.Name = "txt_nomeFantasia"
        Me.txt_nomeFantasia.Size = New System.Drawing.Size(100, 20)
        Me.txt_nomeFantasia.TabIndex = 39
        '
        'lbl_idFornecedor
        '
        Me.lbl_idFornecedor.AutoSize = True
        Me.lbl_idFornecedor.Location = New System.Drawing.Point(52, 73)
        Me.lbl_idFornecedor.Name = "lbl_idFornecedor"
        Me.lbl_idFornecedor.Size = New System.Drawing.Size(19, 13)
        Me.lbl_idFornecedor.TabIndex = 42
        Me.lbl_idFornecedor.Text = "Id "
        '
        'txt_idFornecedor
        '
        Me.txt_idFornecedor.Location = New System.Drawing.Point(73, 69)
        Me.txt_idFornecedor.Name = "txt_idFornecedor"
        Me.txt_idFornecedor.Size = New System.Drawing.Size(100, 20)
        Me.txt_idFornecedor.TabIndex = 41
        '
        'bnt_pesquisa
        '
        Me.bnt_pesquisa.Location = New System.Drawing.Point(764, 126)
        Me.bnt_pesquisa.Name = "bnt_pesquisa"
        Me.bnt_pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisa.TabIndex = 43
        Me.bnt_pesquisa.Text = "Pesquisa"
        Me.bnt_pesquisa.UseVisualStyleBackColor = True
        '
        'Fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 450)
        Me.Controls.Add(Me.bnt_pesquisa)
        Me.Controls.Add(Me.lbl_idFornecedor)
        Me.Controls.Add(Me.txt_idFornecedor)
        Me.Controls.Add(Me.lbl_nomeFantasia)
        Me.Controls.Add(Me.txt_nomeFantasia)
        Me.Controls.Add(Me.lbl_cnpj)
        Me.Controls.Add(Me.txt_cnpj)
        Me.Controls.Add(Me.lbl_formaPagamento)
        Me.Controls.Add(Me.txt_fomapagamento)
        Me.Controls.Add(Me.lbl_rasaosocial)
        Me.Controls.Add(Me.txt_rasaosoc)
        Me.Controls.Add(Me.bnt_Exclui)
        Me.Controls.Add(Me.bnt_Edita)
        Me.Controls.Add(Me.bnt_Inclui)
        Me.Controls.Add(Me.bnt_Fechar)
        Me.Controls.Add(Me.dgv_fornecedor)
        Me.Name = "Fornecedores"
        Me.Text = "Fornecedores"
        CType(Me.dgv_fornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_fornecedor As DataGridView
    Friend WithEvents bnt_Fechar As Button
    Friend WithEvents bnt_Exclui As Button
    Friend WithEvents bnt_Edita As Button
    Friend WithEvents bnt_Inclui As Button
    Friend WithEvents txt_rasaosoc As TextBox
    Friend WithEvents lbl_rasaosocial As Label
    Friend WithEvents lbl_formaPagamento As Label
    Friend WithEvents txt_fomapagamento As TextBox
    Friend WithEvents lbl_cnpj As Label
    Friend WithEvents txt_cnpj As TextBox
    Friend WithEvents lbl_nomeFantasia As Label
    Friend WithEvents txt_nomeFantasia As TextBox
    Friend WithEvents lbl_idFornecedor As Label
    Friend WithEvents txt_idFornecedor As TextBox
    Friend WithEvents bnt_pesquisa As Button
End Class
