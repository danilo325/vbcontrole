<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Romaneios
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
        Me.bnt_fecha = New System.Windows.Forms.Button()
        Me.dgv_romaneios = New System.Windows.Forms.DataGridView()
        Me.bnt_Exclui = New System.Windows.Forms.Button()
        Me.bnt_Edita = New System.Windows.Forms.Button()
        Me.bnt_Inclui = New System.Windows.Forms.Button()
        Me.dtp_inicial = New System.Windows.Forms.DateTimePicker()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_final = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_vendedor = New System.Windows.Forms.ComboBox()
        Me.bnt_pesquisa = New System.Windows.Forms.Button()
        CType(Me.dgv_romaneios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnt_fecha
        '
        Me.bnt_fecha.Location = New System.Drawing.Point(713, 415)
        Me.bnt_fecha.Name = "bnt_fecha"
        Me.bnt_fecha.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fecha.TabIndex = 0
        Me.bnt_fecha.Text = "Fehar"
        Me.bnt_fecha.UseVisualStyleBackColor = True
        '
        'dgv_romaneios
        '
        Me.dgv_romaneios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_romaneios.Location = New System.Drawing.Point(12, 179)
        Me.dgv_romaneios.Name = "dgv_romaneios"
        Me.dgv_romaneios.Size = New System.Drawing.Size(776, 230)
        Me.dgv_romaneios.TabIndex = 1
        '
        'bnt_Exclui
        '
        Me.bnt_Exclui.Location = New System.Drawing.Point(471, 32)
        Me.bnt_Exclui.Name = "bnt_Exclui"
        Me.bnt_Exclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Exclui.TabIndex = 24
        Me.bnt_Exclui.Text = "Exclui"
        Me.bnt_Exclui.UseVisualStyleBackColor = True
        '
        'bnt_Edita
        '
        Me.bnt_Edita.Location = New System.Drawing.Point(334, 32)
        Me.bnt_Edita.Name = "bnt_Edita"
        Me.bnt_Edita.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Edita.TabIndex = 23
        Me.bnt_Edita.Text = "Edita"
        Me.bnt_Edita.UseVisualStyleBackColor = True
        '
        'bnt_Inclui
        '
        Me.bnt_Inclui.Location = New System.Drawing.Point(197, 32)
        Me.bnt_Inclui.Name = "bnt_Inclui"
        Me.bnt_Inclui.Size = New System.Drawing.Size(75, 57)
        Me.bnt_Inclui.TabIndex = 22
        Me.bnt_Inclui.Text = "Inclui"
        Me.bnt_Inclui.UseVisualStyleBackColor = True
        '
        'dtp_inicial
        '
        Me.dtp_inicial.Checked = False
        Me.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicial.Location = New System.Drawing.Point(552, 126)
        Me.dtp_inicial.Name = "dtp_inicial"
        Me.dtp_inicial.ShowCheckBox = True
        Me.dtp_inicial.Size = New System.Drawing.Size(103, 20)
        Me.dtp_inicial.TabIndex = 27
        Me.dtp_inicial.Value = New Date(2018, 9, 19, 16, 1, 43, 0)
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(80, 126)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(490, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Data inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Id"
        '
        'dtp_final
        '
        Me.dtp_final.Checked = False
        Me.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_final.Location = New System.Drawing.Point(552, 153)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.ShowCheckBox = True
        Me.dtp_final.Size = New System.Drawing.Size(103, 20)
        Me.dtp_final.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(494, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Data final"
        '
        'cmb_vendedor
        '
        Me.cmb_vendedor.FormattingEnabled = True
        Me.cmb_vendedor.Location = New System.Drawing.Point(300, 129)
        Me.cmb_vendedor.Name = "cmb_vendedor"
        Me.cmb_vendedor.Size = New System.Drawing.Size(184, 21)
        Me.cmb_vendedor.TabIndex = 34
        '
        'bnt_pesquisa
        '
        Me.bnt_pesquisa.Location = New System.Drawing.Point(683, 150)
        Me.bnt_pesquisa.Name = "bnt_pesquisa"
        Me.bnt_pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisa.TabIndex = 35
        Me.bnt_pesquisa.Text = "Pesquisar"
        Me.bnt_pesquisa.UseVisualStyleBackColor = True
        '
        'romaneios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bnt_pesquisa)
        Me.Controls.Add(Me.cmb_vendedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_final)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.dtp_inicial)
        Me.Controls.Add(Me.bnt_Exclui)
        Me.Controls.Add(Me.bnt_Edita)
        Me.Controls.Add(Me.bnt_Inclui)
        Me.Controls.Add(Me.dgv_romaneios)
        Me.Controls.Add(Me.bnt_fecha)
        Me.Name = "romaneios"
        Me.Text = "Romaneios"
        CType(Me.dgv_romaneios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bnt_fecha As Button
    Friend WithEvents dgv_romaneios As DataGridView
    Friend WithEvents bnt_Exclui As Button
    Friend WithEvents bnt_Edita As Button
    Friend WithEvents bnt_Inclui As Button
    Friend WithEvents dtp_inicial As DateTimePicker
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_final As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_vendedor As ComboBox
    Friend WithEvents bnt_pesquisa As Button
End Class
