<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalheProduto
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lbl_idproduto = New System.Windows.Forms.Label()
        Me.lbl_avtivo = New System.Windows.Forms.Label()
        Me.lbl_pdroduzido = New System.Windows.Forms.Label()
        Me.lbl_pcusto = New System.Windows.Forms.Label()
        Me.lbl_qtd = New System.Windows.Forms.Label()
        Me.lbl_unidade = New System.Windows.Forms.Label()
        Me.lbl_grupo = New System.Windows.Forms.Label()
        Me.lbl_descricao = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_idproduto
        '
        Me.lbl_idproduto.AutoSize = True
        Me.lbl_idproduto.BackColor = System.Drawing.Color.Silver
        Me.lbl_idproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idproduto.Location = New System.Drawing.Point(84, 9)
        Me.lbl_idproduto.Name = "lbl_idproduto"
        Me.lbl_idproduto.Size = New System.Drawing.Size(52, 39)
        Me.lbl_idproduto.TabIndex = 0
        Me.lbl_idproduto.Text = "ID"
        '
        'lbl_avtivo
        '
        Me.lbl_avtivo.AutoSize = True
        Me.lbl_avtivo.Location = New System.Drawing.Point(72, 299)
        Me.lbl_avtivo.Name = "lbl_avtivo"
        Me.lbl_avtivo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_avtivo.TabIndex = 2
        Me.lbl_avtivo.Text = "Label3"
        '
        'lbl_pdroduzido
        '
        Me.lbl_pdroduzido.AutoSize = True
        Me.lbl_pdroduzido.Location = New System.Drawing.Point(72, 264)
        Me.lbl_pdroduzido.Name = "lbl_pdroduzido"
        Me.lbl_pdroduzido.Size = New System.Drawing.Size(39, 13)
        Me.lbl_pdroduzido.TabIndex = 3
        Me.lbl_pdroduzido.Text = "Label4"
        '
        'lbl_pcusto
        '
        Me.lbl_pcusto.AutoSize = True
        Me.lbl_pcusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pcusto.Location = New System.Drawing.Point(86, 176)
        Me.lbl_pcusto.Name = "lbl_pcusto"
        Me.lbl_pcusto.Size = New System.Drawing.Size(71, 25)
        Me.lbl_pcusto.TabIndex = 4
        Me.lbl_pcusto.Text = "Label5"
        '
        'lbl_qtd
        '
        Me.lbl_qtd.AutoSize = True
        Me.lbl_qtd.BackColor = System.Drawing.Color.Yellow
        Me.lbl_qtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtd.Location = New System.Drawing.Point(85, 216)
        Me.lbl_qtd.Name = "lbl_qtd"
        Me.lbl_qtd.Size = New System.Drawing.Size(95, 31)
        Me.lbl_qtd.TabIndex = 5
        Me.lbl_qtd.Text = "Label6"
        '
        'lbl_unidade
        '
        Me.lbl_unidade.AutoSize = True
        Me.lbl_unidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unidade.Location = New System.Drawing.Point(183, 222)
        Me.lbl_unidade.Name = "lbl_unidade"
        Me.lbl_unidade.Size = New System.Drawing.Size(40, 25)
        Me.lbl_unidade.TabIndex = 6
        Me.lbl_unidade.Text = "UN"
        '
        'lbl_grupo
        '
        Me.lbl_grupo.AutoSize = True
        Me.lbl_grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grupo.Location = New System.Drawing.Point(75, 140)
        Me.lbl_grupo.Name = "lbl_grupo"
        Me.lbl_grupo.Size = New System.Drawing.Size(66, 25)
        Me.lbl_grupo.TabIndex = 7
        Me.lbl_grupo.Text = "Grupo"
        '
        'lbl_descricao
        '
        Me.lbl_descricao.AutoSize = True
        Me.lbl_descricao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descricao.Location = New System.Drawing.Point(23, 63)
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.Size = New System.Drawing.Size(200, 46)
        Me.lbl_descricao.TabIndex = 8
        Me.lbl_descricao.Text = "Descrição"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Preço de Custo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Grupo:"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(383, 53)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 13
        Me.Chart1.Text = "Chart1"
        '
        'DetalheProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_descricao)
        Me.Controls.Add(Me.lbl_grupo)
        Me.Controls.Add(Me.lbl_unidade)
        Me.Controls.Add(Me.lbl_qtd)
        Me.Controls.Add(Me.lbl_pcusto)
        Me.Controls.Add(Me.lbl_pdroduzido)
        Me.Controls.Add(Me.lbl_avtivo)
        Me.Controls.Add(Me.lbl_idproduto)
        Me.Name = "DetalheProduto"
        Me.Text = "DetalheProduto"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_idproduto As Label
    Friend WithEvents lbl_avtivo As Label
    Friend WithEvents lbl_pdroduzido As Label
    Friend WithEvents lbl_pcusto As Label
    Friend WithEvents lbl_qtd As Label
    Friend WithEvents lbl_unidade As Label
    Friend WithEvents lbl_grupo As Label
    Friend WithEvents lbl_descricao As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
