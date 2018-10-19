<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditaRomaneioSaida
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
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.cbm_vendedores = New System.Windows.Forms.ComboBox()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.dgv_produto = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_id.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_id.Location = New System.Drawing.Point(80, 15)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 19
        Me.lbl_id.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Data do romaneio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Vendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(555, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Obs."
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(600, 12)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(155, 89)
        Me.txt_obs.TabIndex = 14
        '
        'cbm_vendedores
        '
        Me.cbm_vendedores.FormattingEnabled = True
        Me.cbm_vendedores.Location = New System.Drawing.Point(77, 68)
        Me.cbm_vendedores.Name = "cbm_vendedores"
        Me.cbm_vendedores.Size = New System.Drawing.Size(179, 21)
        Me.cbm_vendedores.TabIndex = 13
        '
        'dtp_data
        '
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(386, 70)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(98, 20)
        Me.dtp_data.TabIndex = 12
        '
        'dgv_produto
        '
        Me.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produto.Location = New System.Drawing.Point(12, 126)
        Me.dgv_produto.Name = "dgv_produto"
        Me.dgv_produto.Size = New System.Drawing.Size(776, 269)
        Me.dgv_produto.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cadastra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditaRomaneioSaida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.cbm_vendedores)
        Me.Controls.Add(Me.dtp_data)
        Me.Controls.Add(Me.dgv_produto)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EditaRomaneioSaida"
        Me.Text = "EditaRomaneioSaida"
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents cbm_vendedores As ComboBox
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents dgv_produto As DataGridView
    Friend WithEvents Button1 As Button
End Class
