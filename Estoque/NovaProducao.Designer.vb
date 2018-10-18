<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovaProducao
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
        Me.dgv_producao = New System.Windows.Forms.DataGridView()
        Me.bnt_gravar = New System.Windows.Forms.Button()
        CType(Me.dgv_producao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_producao
        '
        Me.dgv_producao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_producao.Location = New System.Drawing.Point(12, 26)
        Me.dgv_producao.Name = "dgv_producao"
        Me.dgv_producao.Size = New System.Drawing.Size(766, 200)
        Me.dgv_producao.TabIndex = 0
        '
        'bnt_gravar
        '
        Me.bnt_gravar.Location = New System.Drawing.Point(650, 262)
        Me.bnt_gravar.Name = "bnt_gravar"
        Me.bnt_gravar.Size = New System.Drawing.Size(75, 23)
        Me.bnt_gravar.TabIndex = 1
        Me.bnt_gravar.Text = "Gravar"
        Me.bnt_gravar.UseVisualStyleBackColor = True
        '
        'NovaProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 358)
        Me.Controls.Add(Me.bnt_gravar)
        Me.Controls.Add(Me.dgv_producao)
        Me.Name = "NovaProducao"
        Me.Text = "Nova Produção"
        CType(Me.dgv_producao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_producao As DataGridView
    Friend WithEvents LiderBancoDadosDataSet As Estoque.LiderBancoDadosDataSet
    Friend WithEvents bnt_gravar As Button
End Class
