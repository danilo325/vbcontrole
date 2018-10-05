<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estoque
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estoque))
        Me.txt_IdProduto = New System.Windows.Forms.TextBox()
        Me.lbl_IdProduto = New System.Windows.Forms.Label()
        Me.dgv_Produtos = New System.Windows.Forms.DataGridView()
        Me.txt_DecricaoProduto = New System.Windows.Forms.TextBox()
        Me.txt_PrecoCusto = New System.Windows.Forms.TextBox()
        Me.lbl_PrecoCusto = New System.Windows.Forms.Label()
        Me.lbl_TipoProduto = New System.Windows.Forms.Label()
        Me.lbl_NomeProduto = New System.Windows.Forms.Label()
        Me.lbl_Produzido = New System.Windows.Forms.Label()
        Me.lbl_PrecoVenda = New System.Windows.Forms.Label()
        Me.txt_PrecoVenda = New System.Windows.Forms.TextBox()
        Me.cmb_TipoProduto = New System.Windows.Forms.ComboBox()
        Me.cmb_Produzido = New System.Windows.Forms.ComboBox()
        Me.cmb_Ativo = New System.Windows.Forms.ComboBox()
        Me.lbl_Ativo = New System.Windows.Forms.Label()
        Me.bnt_Pesquisa = New System.Windows.Forms.Button()
        Me.bnt_Fechar = New System.Windows.Forms.Button()
        Me.bnt_Inclui = New System.Windows.Forms.Button()
        Me.bnt_Edita = New System.Windows.Forms.Button()
        Me.bnt_Exclui = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.dgv_Produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_IdProduto
        '
        Me.txt_IdProduto.Location = New System.Drawing.Point(89, 108)
        Me.txt_IdProduto.Name = "txt_IdProduto"
        Me.txt_IdProduto.Size = New System.Drawing.Size(52, 20)
        Me.txt_IdProduto.TabIndex = 0
        '
        'lbl_IdProduto
        '
        Me.lbl_IdProduto.AutoSize = True
        Me.lbl_IdProduto.Location = New System.Drawing.Point(13, 112)
        Me.lbl_IdProduto.Name = "lbl_IdProduto"
        Me.lbl_IdProduto.Size = New System.Drawing.Size(70, 13)
        Me.lbl_IdProduto.TabIndex = 1
        Me.lbl_IdProduto.Text = "Id do produto"
        '
        'dgv_Produtos
        '
        Me.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Produtos.Location = New System.Drawing.Point(16, 182)
        Me.dgv_Produtos.Name = "dgv_Produtos"
        Me.dgv_Produtos.Size = New System.Drawing.Size(772, 229)
        Me.dgv_Produtos.TabIndex = 2
        '
        'txt_DecricaoProduto
        '
        Me.txt_DecricaoProduto.Location = New System.Drawing.Point(89, 148)
        Me.txt_DecricaoProduto.Name = "txt_DecricaoProduto"
        Me.txt_DecricaoProduto.Size = New System.Drawing.Size(225, 20)
        Me.txt_DecricaoProduto.TabIndex = 3
        '
        'txt_PrecoCusto
        '
        Me.txt_PrecoCusto.Location = New System.Drawing.Point(423, 108)
        Me.txt_PrecoCusto.Name = "txt_PrecoCusto"
        Me.txt_PrecoCusto.Size = New System.Drawing.Size(52, 20)
        Me.txt_PrecoCusto.TabIndex = 4
        '
        'lbl_PrecoCusto
        '
        Me.lbl_PrecoCusto.AutoSize = True
        Me.lbl_PrecoCusto.Location = New System.Drawing.Point(337, 112)
        Me.lbl_PrecoCusto.Name = "lbl_PrecoCusto"
        Me.lbl_PrecoCusto.Size = New System.Drawing.Size(80, 13)
        Me.lbl_PrecoCusto.TabIndex = 6
        Me.lbl_PrecoCusto.Text = "Preço de Custo"
        '
        'lbl_TipoProduto
        '
        Me.lbl_TipoProduto.AutoSize = True
        Me.lbl_TipoProduto.Location = New System.Drawing.Point(150, 112)
        Me.lbl_TipoProduto.Name = "lbl_TipoProduto"
        Me.lbl_TipoProduto.Size = New System.Drawing.Size(68, 13)
        Me.lbl_TipoProduto.TabIndex = 7
        Me.lbl_TipoProduto.Text = "Tipo Produto"
        '
        'lbl_NomeProduto
        '
        Me.lbl_NomeProduto.AutoSize = True
        Me.lbl_NomeProduto.Location = New System.Drawing.Point(12, 152)
        Me.lbl_NomeProduto.Name = "lbl_NomeProduto"
        Me.lbl_NomeProduto.Size = New System.Drawing.Size(75, 13)
        Me.lbl_NomeProduto.TabIndex = 8
        Me.lbl_NomeProduto.Text = "Nome Produto"
        '
        'lbl_Produzido
        '
        Me.lbl_Produzido.AutoSize = True
        Me.lbl_Produzido.Location = New System.Drawing.Point(500, 112)
        Me.lbl_Produzido.Name = "lbl_Produzido"
        Me.lbl_Produzido.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Produzido.TabIndex = 10
        Me.lbl_Produzido.Text = "Produzido"
        Me.lbl_Produzido.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_PrecoVenda
        '
        Me.lbl_PrecoVenda.AutoSize = True
        Me.lbl_PrecoVenda.Location = New System.Drawing.Point(333, 152)
        Me.lbl_PrecoVenda.Name = "lbl_PrecoVenda"
        Me.lbl_PrecoVenda.Size = New System.Drawing.Size(84, 13)
        Me.lbl_PrecoVenda.TabIndex = 11
        Me.lbl_PrecoVenda.Text = "Preço de Venda"
        '
        'txt_PrecoVenda
        '
        Me.txt_PrecoVenda.Location = New System.Drawing.Point(423, 148)
        Me.txt_PrecoVenda.Name = "txt_PrecoVenda"
        Me.txt_PrecoVenda.Size = New System.Drawing.Size(52, 20)
        Me.txt_PrecoVenda.TabIndex = 12
        '
        'cmb_TipoProduto
        '
        Me.cmb_TipoProduto.FormattingEnabled = True
        Me.cmb_TipoProduto.Location = New System.Drawing.Point(224, 108)
        Me.cmb_TipoProduto.Name = "cmb_TipoProduto"
        Me.cmb_TipoProduto.Size = New System.Drawing.Size(90, 21)
        Me.cmb_TipoProduto.TabIndex = 13
        '
        'cmb_Produzido
        '
        Me.cmb_Produzido.FormattingEnabled = True
        Me.cmb_Produzido.Location = New System.Drawing.Point(576, 108)
        Me.cmb_Produzido.Name = "cmb_Produzido"
        Me.cmb_Produzido.Size = New System.Drawing.Size(103, 21)
        Me.cmb_Produzido.TabIndex = 14
        '
        'cmb_Ativo
        '
        Me.cmb_Ativo.FormattingEnabled = True
        Me.cmb_Ativo.Location = New System.Drawing.Point(576, 148)
        Me.cmb_Ativo.Name = "cmb_Ativo"
        Me.cmb_Ativo.Size = New System.Drawing.Size(103, 21)
        Me.cmb_Ativo.TabIndex = 16
        '
        'lbl_Ativo
        '
        Me.lbl_Ativo.AutoSize = True
        Me.lbl_Ativo.Location = New System.Drawing.Point(500, 152)
        Me.lbl_Ativo.Name = "lbl_Ativo"
        Me.lbl_Ativo.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Ativo.TabIndex = 15
        Me.lbl_Ativo.Text = "Esta ativo"
        '
        'bnt_Pesquisa
        '
        Me.bnt_Pesquisa.Location = New System.Drawing.Point(698, 145)
        Me.bnt_Pesquisa.Name = "bnt_Pesquisa"
        Me.bnt_Pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Pesquisa.TabIndex = 17
        Me.bnt_Pesquisa.Text = "Pesquisa"
        Me.bnt_Pesquisa.UseVisualStyleBackColor = True
        '
        'bnt_Fechar
        '
        Me.bnt_Fechar.Location = New System.Drawing.Point(682, 417)
        Me.bnt_Fechar.Name = "bnt_Fechar"
        Me.bnt_Fechar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Fechar.TabIndex = 18
        Me.bnt_Fechar.Text = "Fecha"
        Me.bnt_Fechar.UseVisualStyleBackColor = True
        '
        'bnt_Inclui
        '
        Me.bnt_Inclui.Location = New System.Drawing.Point(213, 23)
        Me.bnt_Inclui.Name = "bnt_Inclui"
        Me.bnt_Inclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Inclui.TabIndex = 19
        Me.bnt_Inclui.Text = "Inclui"
        Me.bnt_Inclui.UseVisualStyleBackColor = True
        '
        'bnt_Edita
        '
        Me.bnt_Edita.Location = New System.Drawing.Point(350, 23)
        Me.bnt_Edita.Name = "bnt_Edita"
        Me.bnt_Edita.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Edita.TabIndex = 20
        Me.bnt_Edita.Text = "Edita"
        Me.bnt_Edita.UseVisualStyleBackColor = True
        '
        'bnt_Exclui
        '
        Me.bnt_Exclui.Enabled = False
        Me.bnt_Exclui.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bnt_Exclui.Location = New System.Drawing.Point(487, 23)
        Me.bnt_Exclui.Name = "bnt_Exclui"
        Me.bnt_Exclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Exclui.TabIndex = 21
        Me.bnt_Exclui.Text = "Exclui"
        Me.bnt_Exclui.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-editar-arquivo-64-2.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-fechar-janela-64.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-adicionar-64.png")
        '
        'Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bnt_Exclui)
        Me.Controls.Add(Me.bnt_Edita)
        Me.Controls.Add(Me.bnt_Inclui)
        Me.Controls.Add(Me.bnt_Fechar)
        Me.Controls.Add(Me.bnt_Pesquisa)
        Me.Controls.Add(Me.cmb_Ativo)
        Me.Controls.Add(Me.lbl_Ativo)
        Me.Controls.Add(Me.cmb_Produzido)
        Me.Controls.Add(Me.cmb_TipoProduto)
        Me.Controls.Add(Me.txt_PrecoVenda)
        Me.Controls.Add(Me.lbl_PrecoVenda)
        Me.Controls.Add(Me.lbl_Produzido)
        Me.Controls.Add(Me.lbl_NomeProduto)
        Me.Controls.Add(Me.lbl_TipoProduto)
        Me.Controls.Add(Me.lbl_PrecoCusto)
        Me.Controls.Add(Me.txt_PrecoCusto)
        Me.Controls.Add(Me.txt_DecricaoProduto)
        Me.Controls.Add(Me.dgv_Produtos)
        Me.Controls.Add(Me.lbl_IdProduto)
        Me.Controls.Add(Me.txt_IdProduto)
        Me.Name = "Estoque"
        Me.Text = "Estoque"
        CType(Me.dgv_Produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_IdProduto As TextBox
    Friend WithEvents lbl_IdProduto As Label
    Friend WithEvents dgv_Produtos As DataGridView
    Friend WithEvents txt_DecricaoProduto As TextBox
    Friend WithEvents txt_PrecoCusto As TextBox
    Friend WithEvents lbl_PrecoCusto As Label
    Friend WithEvents lbl_TipoProduto As Label
    Friend WithEvents lbl_NomeProduto As Label
    Friend WithEvents lbl_Produzido As Label
    Friend WithEvents lbl_PrecoVenda As Label
    Friend WithEvents txt_PrecoVenda As TextBox
    Friend WithEvents cmb_TipoProduto As ComboBox
    Friend WithEvents cmb_Produzido As ComboBox
    Friend WithEvents cmb_Ativo As ComboBox
    Friend WithEvents lbl_Ativo As Label
    Friend WithEvents bnt_Pesquisa As Button
    Friend WithEvents bnt_Fechar As Button
    Friend WithEvents bnt_Inclui As Button
    Friend WithEvents bnt_Edita As Button
    Friend WithEvents bnt_Exclui As Button
    Friend WithEvents ImageList1 As ImageList
End Class
