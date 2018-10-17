<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovoProduto
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
        Me.txt_Descricao = New System.Windows.Forms.TextBox()
        Me.txt_Quantidade = New System.Windows.Forms.TextBox()
        Me.txt_PrecoCusto = New System.Windows.Forms.TextBox()
        Me.txt_Unidade = New System.Windows.Forms.TextBox()
        Me.cmb_Grupo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_Produzido = New System.Windows.Forms.CheckBox()
        Me.chk_Ativo = New System.Windows.Forms.CheckBox()
        Me.bnt_Inclui = New System.Windows.Forms.Button()
        Me.bnt_Limpa = New System.Windows.Forms.Button()
        Me.bnt_Cancela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Descricao
        '
        Me.txt_Descricao.Location = New System.Drawing.Point(94, 50)
        Me.txt_Descricao.Name = "txt_Descricao"
        Me.txt_Descricao.Size = New System.Drawing.Size(284, 20)
        Me.txt_Descricao.TabIndex = 0
        '
        'txt_Quantidade
        '
        Me.txt_Quantidade.Location = New System.Drawing.Point(93, 189)
        Me.txt_Quantidade.Name = "txt_Quantidade"
        Me.txt_Quantidade.Size = New System.Drawing.Size(100, 20)
        Me.txt_Quantidade.TabIndex = 1
        '
        'txt_PrecoCusto
        '
        Me.txt_PrecoCusto.Location = New System.Drawing.Point(94, 236)
        Me.txt_PrecoCusto.Name = "txt_PrecoCusto"
        Me.txt_PrecoCusto.Size = New System.Drawing.Size(100, 20)
        Me.txt_PrecoCusto.TabIndex = 2
        '
        'txt_Unidade
        '
        Me.txt_Unidade.Location = New System.Drawing.Point(93, 133)
        Me.txt_Unidade.Name = "txt_Unidade"
        Me.txt_Unidade.Size = New System.Drawing.Size(100, 20)
        Me.txt_Unidade.TabIndex = 3
        '
        'cmb_Grupo
        '
        Me.cmb_Grupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Grupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Grupo.FormattingEnabled = True
        Me.cmb_Grupo.Location = New System.Drawing.Point(94, 93)
        Me.cmb_Grupo.Name = "cmb_Grupo"
        Me.cmb_Grupo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Grupo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Descrição"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quantidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Unidade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Preço de Custo"
        '
        'chk_Produzido
        '
        Me.chk_Produzido.AutoSize = True
        Me.chk_Produzido.Location = New System.Drawing.Point(272, 101)
        Me.chk_Produzido.Name = "chk_Produzido"
        Me.chk_Produzido.Size = New System.Drawing.Size(73, 17)
        Me.chk_Produzido.TabIndex = 10
        Me.chk_Produzido.Text = "Produzido"
        Me.chk_Produzido.UseVisualStyleBackColor = True
        '
        'chk_Ativo
        '
        Me.chk_Ativo.AutoSize = True
        Me.chk_Ativo.Location = New System.Drawing.Point(272, 140)
        Me.chk_Ativo.Name = "chk_Ativo"
        Me.chk_Ativo.Size = New System.Drawing.Size(50, 17)
        Me.chk_Ativo.TabIndex = 11
        Me.chk_Ativo.Text = "Ativo"
        Me.chk_Ativo.UseVisualStyleBackColor = True
        '
        'bnt_Inclui
        '
        Me.bnt_Inclui.Location = New System.Drawing.Point(118, 292)
        Me.bnt_Inclui.Name = "bnt_Inclui"
        Me.bnt_Inclui.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Inclui.TabIndex = 12
        Me.bnt_Inclui.Text = "Inclui"
        Me.bnt_Inclui.UseVisualStyleBackColor = True
        '
        'bnt_Limpa
        '
        Me.bnt_Limpa.Location = New System.Drawing.Point(360, 292)
        Me.bnt_Limpa.Name = "bnt_Limpa"
        Me.bnt_Limpa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bnt_Limpa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Limpa.TabIndex = 13
        Me.bnt_Limpa.Text = "Limpa"
        Me.bnt_Limpa.UseVisualStyleBackColor = True
        '
        'bnt_Cancela
        '
        Me.bnt_Cancela.Location = New System.Drawing.Point(602, 292)
        Me.bnt_Cancela.Name = "bnt_Cancela"
        Me.bnt_Cancela.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Cancela.TabIndex = 14
        Me.bnt_Cancela.Text = "Cancela"
        Me.bnt_Cancela.UseVisualStyleBackColor = True
        '
        'NovoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bnt_Cancela)
        Me.Controls.Add(Me.bnt_Limpa)
        Me.Controls.Add(Me.bnt_Inclui)
        Me.Controls.Add(Me.chk_Ativo)
        Me.Controls.Add(Me.chk_Produzido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Grupo)
        Me.Controls.Add(Me.txt_Unidade)
        Me.Controls.Add(Me.txt_PrecoCusto)
        Me.Controls.Add(Me.txt_Quantidade)
        Me.Controls.Add(Me.txt_Descricao)
        Me.Name = "NovoProduto"
        Me.Text = "NovoProduto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Descricao As TextBox
    Friend WithEvents txt_Quantidade As TextBox
    Friend WithEvents txt_PrecoCusto As TextBox
    Friend WithEvents txt_Unidade As TextBox
    Friend WithEvents cmb_Grupo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_Produzido As CheckBox
    Friend WithEvents chk_Ativo As CheckBox
    Friend WithEvents bnt_Inclui As Button
    Friend WithEvents bnt_Limpa As Button
    Friend WithEvents bnt_Cancela As Button
End Class
