<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedores
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
        Me.bnt_Exclui = New System.Windows.Forms.Button()
        Me.bnt_Edita = New System.Windows.Forms.Button()
        Me.bnt_Inclui = New System.Windows.Forms.Button()
        Me.bnt_Fechar = New System.Windows.Forms.Button()
        Me.bnt_Pesquisa = New System.Windows.Forms.Button()
        Me.dgv_Vendedores = New System.Windows.Forms.DataGridView()
        Me.txt_IdVendedor = New System.Windows.Forms.TextBox()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.txt_Fone = New System.Windows.Forms.TextBox()
        Me.txt_Cpf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_Vendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnt_Exclui
        '
        Me.bnt_Exclui.Location = New System.Drawing.Point(485, 17)
        Me.bnt_Exclui.Name = "bnt_Exclui"
        Me.bnt_Exclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Exclui.TabIndex = 37
        Me.bnt_Exclui.Text = "Exclui"
        Me.bnt_Exclui.UseVisualStyleBackColor = True
        '
        'bnt_Edita
        '
        Me.bnt_Edita.Location = New System.Drawing.Point(348, 17)
        Me.bnt_Edita.Name = "bnt_Edita"
        Me.bnt_Edita.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Edita.TabIndex = 36
        Me.bnt_Edita.Text = "Edita"
        Me.bnt_Edita.UseVisualStyleBackColor = True
        '
        'bnt_Inclui
        '
        Me.bnt_Inclui.Location = New System.Drawing.Point(211, 17)
        Me.bnt_Inclui.Name = "bnt_Inclui"
        Me.bnt_Inclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Inclui.TabIndex = 35
        Me.bnt_Inclui.Text = "Inclui"
        Me.bnt_Inclui.UseVisualStyleBackColor = True
        '
        'bnt_Fechar
        '
        Me.bnt_Fechar.Location = New System.Drawing.Point(680, 411)
        Me.bnt_Fechar.Name = "bnt_Fechar"
        Me.bnt_Fechar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Fechar.TabIndex = 34
        Me.bnt_Fechar.Text = "Fecha"
        Me.bnt_Fechar.UseVisualStyleBackColor = True
        '
        'bnt_Pesquisa
        '
        Me.bnt_Pesquisa.Location = New System.Drawing.Point(696, 139)
        Me.bnt_Pesquisa.Name = "bnt_Pesquisa"
        Me.bnt_Pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Pesquisa.TabIndex = 33
        Me.bnt_Pesquisa.Text = "Pesquisa"
        Me.bnt_Pesquisa.UseVisualStyleBackColor = True
        '
        'dgv_Vendedores
        '
        Me.dgv_Vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Vendedores.Location = New System.Drawing.Point(20, 176)
        Me.dgv_Vendedores.Name = "dgv_Vendedores"
        Me.dgv_Vendedores.Size = New System.Drawing.Size(772, 229)
        Me.dgv_Vendedores.TabIndex = 23
        '
        'txt_IdVendedor
        '
        Me.txt_IdVendedor.Location = New System.Drawing.Point(62, 112)
        Me.txt_IdVendedor.Name = "txt_IdVendedor"
        Me.txt_IdVendedor.Size = New System.Drawing.Size(100, 20)
        Me.txt_IdVendedor.TabIndex = 38
        '
        'txt_Nome
        '
        Me.txt_Nome.Location = New System.Drawing.Point(62, 143)
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(229, 20)
        Me.txt_Nome.TabIndex = 39
        '
        'txt_Fone
        '
        Me.txt_Fone.Location = New System.Drawing.Point(357, 150)
        Me.txt_Fone.Name = "txt_Fone"
        Me.txt_Fone.Size = New System.Drawing.Size(100, 20)
        Me.txt_Fone.TabIndex = 40
        '
        'txt_Cpf
        '
        Me.txt_Cpf.Location = New System.Drawing.Point(355, 108)
        Me.txt_Cpf.Name = "txt_Cpf"
        Me.txt_Cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_Cpf.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Id" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Nome"
        '
        'Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Cpf)
        Me.Controls.Add(Me.txt_Fone)
        Me.Controls.Add(Me.txt_Nome)
        Me.Controls.Add(Me.txt_IdVendedor)
        Me.Controls.Add(Me.bnt_Exclui)
        Me.Controls.Add(Me.bnt_Edita)
        Me.Controls.Add(Me.bnt_Inclui)
        Me.Controls.Add(Me.bnt_Fechar)
        Me.Controls.Add(Me.bnt_Pesquisa)
        Me.Controls.Add(Me.dgv_Vendedores)
        Me.Name = "Vendedores"
        Me.Text = "Vendedores"
        CType(Me.dgv_Vendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bnt_Exclui As Button
    Friend WithEvents bnt_Edita As Button
    Friend WithEvents bnt_Inclui As Button
    Friend WithEvents bnt_Fechar As Button
    Friend WithEvents bnt_Pesquisa As Button
    Friend WithEvents dgv_Vendedores As DataGridView
    Friend WithEvents txt_IdVendedor As TextBox
    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents txt_Fone As TextBox
    Friend WithEvents txt_Cpf As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
