<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalhesCompra
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_idcompra = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_fornecedor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_npedido = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_dtacompra = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Valorcompra = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_obs = New System.Windows.Forms.Label()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_produtos
        '
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Location = New System.Drawing.Point(-2, 206)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.Size = New System.Drawing.Size(803, 236)
        Me.dgv_produtos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'lbl_idcompra
        '
        Me.lbl_idcompra.AutoSize = True
        Me.lbl_idcompra.Location = New System.Drawing.Point(93, 9)
        Me.lbl_idcompra.Name = "lbl_idcompra"
        Me.lbl_idcompra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_idcompra.Size = New System.Drawing.Size(52, 13)
        Me.lbl_idcompra.TabIndex = 2
        Me.lbl_idcompra.Text = "IdCompra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fornecedor"
        '
        'lbl_fornecedor
        '
        Me.lbl_fornecedor.AutoSize = True
        Me.lbl_fornecedor.Location = New System.Drawing.Point(93, 44)
        Me.lbl_fornecedor.Name = "lbl_fornecedor"
        Me.lbl_fornecedor.Size = New System.Drawing.Size(61, 13)
        Me.lbl_fornecedor.TabIndex = 4
        Me.lbl_fornecedor.Text = "Fornecedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nº Pedido"
        '
        'lbl_npedido
        '
        Me.lbl_npedido.AutoSize = True
        Me.lbl_npedido.Location = New System.Drawing.Point(371, 9)
        Me.lbl_npedido.Name = "lbl_npedido"
        Me.lbl_npedido.Size = New System.Drawing.Size(50, 13)
        Me.lbl_npedido.TabIndex = 6
        Me.lbl_npedido.Text = "N pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data da compra"
        '
        'lbl_dtacompra
        '
        Me.lbl_dtacompra.AutoSize = True
        Me.lbl_dtacompra.Location = New System.Drawing.Point(93, 92)
        Me.lbl_dtacompra.Name = "lbl_dtacompra"
        Me.lbl_dtacompra.Size = New System.Drawing.Size(66, 13)
        Me.lbl_dtacompra.TabIndex = 8
        Me.lbl_dtacompra.Text = "DataCompra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Valor "
        '
        'lbl_Valorcompra
        '
        Me.lbl_Valorcompra.AutoSize = True
        Me.lbl_Valorcompra.Location = New System.Drawing.Point(371, 62)
        Me.lbl_Valorcompra.Name = "lbl_Valorcompra"
        Me.lbl_Valorcompra.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Valorcompra.TabIndex = 10
        Me.lbl_Valorcompra.Text = "ValorCompra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(544, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Obs"
        '
        'lbl_obs
        '
        Me.lbl_obs.AutoSize = True
        Me.lbl_obs.Location = New System.Drawing.Point(586, 9)
        Me.lbl_obs.Name = "lbl_obs"
        Me.lbl_obs.Size = New System.Drawing.Size(29, 13)
        Me.lbl_obs.TabIndex = 12
        Me.lbl_obs.Text = "OBS"
        '
        'DetalhesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_obs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_Valorcompra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_dtacompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_npedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_fornecedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_idcompra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_produtos)
        Me.Name = "DetalhesCompra"
        Me.Text = "DetalhesCompra"
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_idcompra As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_fornecedor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_npedido As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_dtacompra As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_Valorcompra As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_obs As Label
End Class
