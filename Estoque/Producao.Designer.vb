<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producao
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
        Me.dgv_producao = New System.Windows.Forms.DataGridView()
        Me.bnt_inclui = New System.Windows.Forms.Button()
        Me.txt_idproducao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_materiaPrima = New System.Windows.Forms.ComboBox()
        Me.dtp_incial = New System.Windows.Forms.DateTimePicker()
        Me.dtp_final = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_produzido = New System.Windows.Forms.ComboBox()
        Me.bnt_pesquisa = New System.Windows.Forms.Button()
        Me.bnt_fecha = New System.Windows.Forms.Button()
        CType(Me.dgv_producao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_producao
        '
        Me.dgv_producao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_producao.Location = New System.Drawing.Point(12, 123)
        Me.dgv_producao.Name = "dgv_producao"
        Me.dgv_producao.Size = New System.Drawing.Size(776, 276)
        Me.dgv_producao.TabIndex = 0
        '
        'bnt_inclui
        '
        Me.bnt_inclui.Location = New System.Drawing.Point(526, 12)
        Me.bnt_inclui.Name = "bnt_inclui"
        Me.bnt_inclui.Size = New System.Drawing.Size(89, 47)
        Me.bnt_inclui.TabIndex = 1
        Me.bnt_inclui.Text = "Nova Produção"
        Me.bnt_inclui.UseVisualStyleBackColor = True
        '
        'txt_idproducao
        '
        Me.txt_idproducao.Location = New System.Drawing.Point(102, 14)
        Me.txt_idproducao.Name = "txt_idproducao"
        Me.txt_idproducao.Size = New System.Drawing.Size(63, 20)
        Me.txt_idproducao.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id Produção"
        '
        'cmb_materiaPrima
        '
        Me.cmb_materiaPrima.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_materiaPrima.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_materiaPrima.FormattingEnabled = True
        Me.cmb_materiaPrima.Location = New System.Drawing.Point(102, 44)
        Me.cmb_materiaPrima.Name = "cmb_materiaPrima"
        Me.cmb_materiaPrima.Size = New System.Drawing.Size(168, 21)
        Me.cmb_materiaPrima.TabIndex = 4
        '
        'dtp_incial
        '
        Me.dtp_incial.Checked = False
        Me.dtp_incial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_incial.Location = New System.Drawing.Point(398, 15)
        Me.dtp_incial.Name = "dtp_incial"
        Me.dtp_incial.ShowCheckBox = True
        Me.dtp_incial.Size = New System.Drawing.Size(95, 20)
        Me.dtp_incial.TabIndex = 7
        '
        'dtp_final
        '
        Me.dtp_final.Checked = False
        Me.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_final.Location = New System.Drawing.Point(398, 44)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.ShowCheckBox = True
        Me.dtp_final.Size = New System.Drawing.Size(95, 20)
        Me.dtp_final.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Data produção inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Produzido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Matria Prima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Data produção final"
        '
        'cmb_produzido
        '
        Me.cmb_produzido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_produzido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_produzido.FormattingEnabled = True
        Me.cmb_produzido.Location = New System.Drawing.Point(102, 83)
        Me.cmb_produzido.Name = "cmb_produzido"
        Me.cmb_produzido.Size = New System.Drawing.Size(168, 21)
        Me.cmb_produzido.TabIndex = 13
        '
        'bnt_pesquisa
        '
        Me.bnt_pesquisa.Location = New System.Drawing.Point(418, 83)
        Me.bnt_pesquisa.Name = "bnt_pesquisa"
        Me.bnt_pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisa.TabIndex = 14
        Me.bnt_pesquisa.Text = "Pesquisa"
        Me.bnt_pesquisa.UseVisualStyleBackColor = True
        '
        'bnt_fecha
        '
        Me.bnt_fecha.Location = New System.Drawing.Point(713, 415)
        Me.bnt_fecha.Name = "bnt_fecha"
        Me.bnt_fecha.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fecha.TabIndex = 15
        Me.bnt_fecha.Text = "fechar"
        Me.bnt_fecha.UseVisualStyleBackColor = True
        '
        'Producao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bnt_fecha)
        Me.Controls.Add(Me.bnt_pesquisa)
        Me.Controls.Add(Me.cmb_produzido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_final)
        Me.Controls.Add(Me.dtp_incial)
        Me.Controls.Add(Me.cmb_materiaPrima)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_idproducao)
        Me.Controls.Add(Me.bnt_inclui)
        Me.Controls.Add(Me.dgv_producao)
        Me.Name = "Producao"
        Me.Text = "Producao"
        CType(Me.dgv_producao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_producao As DataGridView
    Friend WithEvents bnt_inclui As Button
    Friend WithEvents txt_idproducao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_materiaPrima As ComboBox
    Friend WithEvents dtp_incial As DateTimePicker
    Friend WithEvents dtp_final As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_produzido As ComboBox
    Friend WithEvents bnt_pesquisa As Button
    Friend WithEvents bnt_fecha As Button
End Class
