<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perdas
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
        Me.dgv_perdas = New System.Windows.Forms.DataGridView()
        Me.bnt_inclui = New System.Windows.Forms.Button()
        Me.bnt_fechar = New System.Windows.Forms.Button()
        Me.cmb_produto = New System.Windows.Forms.ComboBox()
        Me.dtp_incial = New System.Windows.Forms.DateTimePicker()
        Me.dtp_final = New System.Windows.Forms.DateTimePicker()
        Me.bnt_pesquisa = New System.Windows.Forms.Button()
        CType(Me.dgv_perdas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_perdas
        '
        Me.dgv_perdas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_perdas.Location = New System.Drawing.Point(12, 118)
        Me.dgv_perdas.Name = "dgv_perdas"
        Me.dgv_perdas.Size = New System.Drawing.Size(776, 226)
        Me.dgv_perdas.TabIndex = 0
        '
        'bnt_inclui
        '
        Me.bnt_inclui.Location = New System.Drawing.Point(353, 1)
        Me.bnt_inclui.Name = "bnt_inclui"
        Me.bnt_inclui.Size = New System.Drawing.Size(75, 53)
        Me.bnt_inclui.TabIndex = 1
        Me.bnt_inclui.Text = "Incluir perda"
        Me.bnt_inclui.UseVisualStyleBackColor = True
        '
        'bnt_fechar
        '
        Me.bnt_fechar.Location = New System.Drawing.Point(692, 350)
        Me.bnt_fechar.Name = "bnt_fechar"
        Me.bnt_fechar.Size = New System.Drawing.Size(75, 22)
        Me.bnt_fechar.TabIndex = 2
        Me.bnt_fechar.Text = "Fechar"
        Me.bnt_fechar.UseVisualStyleBackColor = True
        '
        'cmb_produto
        '
        Me.cmb_produto.FormattingEnabled = True
        Me.cmb_produto.Location = New System.Drawing.Point(73, 83)
        Me.cmb_produto.Name = "cmb_produto"
        Me.cmb_produto.Size = New System.Drawing.Size(161, 21)
        Me.cmb_produto.TabIndex = 4
        '
        'dtp_incial
        '
        Me.dtp_incial.Checked = False
        Me.dtp_incial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_incial.Location = New System.Drawing.Point(353, 61)
        Me.dtp_incial.Name = "dtp_incial"
        Me.dtp_incial.ShowCheckBox = True
        Me.dtp_incial.Size = New System.Drawing.Size(112, 20)
        Me.dtp_incial.TabIndex = 5
        Me.dtp_incial.Value = New Date(2018, 10, 2, 0, 0, 0, 0)
        '
        'dtp_final
        '
        Me.dtp_final.Checked = False
        Me.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_final.Location = New System.Drawing.Point(353, 92)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.ShowCheckBox = True
        Me.dtp_final.Size = New System.Drawing.Size(112, 20)
        Me.dtp_final.TabIndex = 6
        '
        'bnt_pesquisa
        '
        Me.bnt_pesquisa.Location = New System.Drawing.Point(677, 81)
        Me.bnt_pesquisa.Name = "bnt_pesquisa"
        Me.bnt_pesquisa.Size = New System.Drawing.Size(75, 22)
        Me.bnt_pesquisa.TabIndex = 7
        Me.bnt_pesquisa.Text = "Pesquisa"
        Me.bnt_pesquisa.UseVisualStyleBackColor = True
        '
        'Perdas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bnt_pesquisa)
        Me.Controls.Add(Me.dtp_final)
        Me.Controls.Add(Me.dtp_incial)
        Me.Controls.Add(Me.cmb_produto)
        Me.Controls.Add(Me.bnt_fechar)
        Me.Controls.Add(Me.bnt_inclui)
        Me.Controls.Add(Me.dgv_perdas)
        Me.Name = "Perdas"
        Me.Text = "Perdas"
        CType(Me.dgv_perdas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_perdas As DataGridView
    Friend WithEvents bnt_inclui As Button
    Friend WithEvents bnt_fechar As Button
    Friend WithEvents cmb_produto As ComboBox
    Friend WithEvents dtp_incial As DateTimePicker
    Friend WithEvents dtp_final As DateTimePicker
    Friend WithEvents bnt_pesquisa As Button
End Class
