<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaFrota
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
        Me.dgv_veiculos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgv_veiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_veiculos
        '
        Me.dgv_veiculos.AllowUserToDeleteRows = False
        Me.dgv_veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_veiculos.Location = New System.Drawing.Point(12, 142)
        Me.dgv_veiculos.Name = "dgv_veiculos"
        Me.dgv_veiculos.ReadOnly = True
        Me.dgv_veiculos.Size = New System.Drawing.Size(776, 274)
        Me.dgv_veiculos.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 92)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Abastecimentos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(327, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 92)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Despesas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(470, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 92)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Manutenção"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListaFrota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_veiculos)
        Me.Name = "ListaFrota"
        Me.Text = "ListaFrota"
        CType(Me.dgv_veiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_veiculos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
