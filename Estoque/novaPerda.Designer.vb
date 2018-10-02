<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class novaPerda
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
        Me.txt_qtdPerca = New System.Windows.Forms.TextBox()
        Me.txt_observacao = New System.Windows.Forms.TextBox()
        Me.cmb_produto = New System.Windows.Forms.ComboBox()
        Me.dtp_dataperca = New System.Windows.Forms.DateTimePicker()
        Me.bnt_grava = New System.Windows.Forms.Button()
        Me.bnt_fecha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_qtdPerca
        '
        Me.txt_qtdPerca.Location = New System.Drawing.Point(123, 97)
        Me.txt_qtdPerca.Name = "txt_qtdPerca"
        Me.txt_qtdPerca.Size = New System.Drawing.Size(104, 20)
        Me.txt_qtdPerca.TabIndex = 0
        '
        'txt_observacao
        '
        Me.txt_observacao.Location = New System.Drawing.Point(204, 155)
        Me.txt_observacao.Multiline = True
        Me.txt_observacao.Name = "txt_observacao"
        Me.txt_observacao.Size = New System.Drawing.Size(351, 124)
        Me.txt_observacao.TabIndex = 1
        '
        'cmb_produto
        '
        Me.cmb_produto.FormattingEnabled = True
        Me.cmb_produto.Location = New System.Drawing.Point(123, 28)
        Me.cmb_produto.Name = "cmb_produto"
        Me.cmb_produto.Size = New System.Drawing.Size(121, 21)
        Me.cmb_produto.TabIndex = 2
        '
        'dtp_dataperca
        '
        Me.dtp_dataperca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dataperca.Location = New System.Drawing.Point(355, 28)
        Me.dtp_dataperca.Name = "dtp_dataperca"
        Me.dtp_dataperca.Size = New System.Drawing.Size(104, 20)
        Me.dtp_dataperca.TabIndex = 3
        Me.dtp_dataperca.Value = New Date(2018, 10, 2, 0, 0, 0, 0)
        '
        'bnt_grava
        '
        Me.bnt_grava.Location = New System.Drawing.Point(504, 322)
        Me.bnt_grava.Name = "bnt_grava"
        Me.bnt_grava.Size = New System.Drawing.Size(75, 23)
        Me.bnt_grava.TabIndex = 4
        Me.bnt_grava.Text = "Gravar"
        Me.bnt_grava.UseVisualStyleBackColor = True
        '
        'bnt_fecha
        '
        Me.bnt_fecha.Location = New System.Drawing.Point(650, 322)
        Me.bnt_fecha.Name = "bnt_fecha"
        Me.bnt_fecha.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fecha.TabIndex = 5
        Me.bnt_fecha.Text = "fechar"
        Me.bnt_fecha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "O produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantidade de perda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Observacao"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data da perda"
        '
        'novaPerda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnt_fecha)
        Me.Controls.Add(Me.bnt_grava)
        Me.Controls.Add(Me.dtp_dataperca)
        Me.Controls.Add(Me.cmb_produto)
        Me.Controls.Add(Me.txt_observacao)
        Me.Controls.Add(Me.txt_qtdPerca)
        Me.Name = "novaPerda"
        Me.Text = "novaPerda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_qtdPerca As TextBox
    Friend WithEvents txt_observacao As TextBox
    Friend WithEvents cmb_produto As ComboBox
    Friend WithEvents dtp_dataperca As DateTimePicker
    Friend WithEvents bnt_grava As Button
    Friend WithEvents bnt_fecha As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
