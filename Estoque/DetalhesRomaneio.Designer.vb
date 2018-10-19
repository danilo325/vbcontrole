<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dia_DetalhesRomaneio
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dgv_ProdutosRomaneio = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_idromaneio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_VCheque = New System.Windows.Forms.TextBox()
        Me.txt_VDinheiro = New System.Windows.Forms.TextBox()
        Me.txt_VMoeda = New System.Windows.Forms.TextBox()
        Me.txt_VBoleto = New System.Windows.Forms.TextBox()
        Me.txt_VFiado = New System.Windows.Forms.TextBox()
        Me.txt_NomeVendedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp_dataRomaneio = New System.Windows.Forms.DateTimePicker()
        Me.lbl_valorTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.bnt_modifica = New System.Windows.Forms.Button()
        Me.bnt_retorn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_ProdutosRomaneio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(770, 386)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'dgv_ProdutosRomaneio
        '
        Me.dgv_ProdutosRomaneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ProdutosRomaneio.Location = New System.Drawing.Point(21, 172)
        Me.dgv_ProdutosRomaneio.Name = "dgv_ProdutosRomaneio"
        Me.dgv_ProdutosRomaneio.Size = New System.Drawing.Size(895, 190)
        Me.dgv_ProdutosRomaneio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Romaneio:"
        '
        'lbl_idromaneio
        '
        Me.lbl_idromaneio.AutoSize = True
        Me.lbl_idromaneio.BackColor = System.Drawing.Color.Bisque
        Me.lbl_idromaneio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idromaneio.Location = New System.Drawing.Point(93, 22)
        Me.lbl_idromaneio.Name = "lbl_idromaneio"
        Me.lbl_idromaneio.Size = New System.Drawing.Size(34, 25)
        Me.lbl_idromaneio.TabIndex = 3
        Me.lbl_idromaneio.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "V. Cheque"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "V. Dinheiro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "V. Moeda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "V. Boleto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(578, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "V. Fiado"
        '
        'txt_VCheque
        '
        Me.txt_VCheque.Location = New System.Drawing.Point(81, 102)
        Me.txt_VCheque.Name = "txt_VCheque"
        Me.txt_VCheque.Size = New System.Drawing.Size(63, 20)
        Me.txt_VCheque.TabIndex = 10
        '
        'txt_VDinheiro
        '
        Me.txt_VDinheiro.Location = New System.Drawing.Point(216, 98)
        Me.txt_VDinheiro.Name = "txt_VDinheiro"
        Me.txt_VDinheiro.Size = New System.Drawing.Size(63, 20)
        Me.txt_VDinheiro.TabIndex = 11
        '
        'txt_VMoeda
        '
        Me.txt_VMoeda.Location = New System.Drawing.Point(353, 102)
        Me.txt_VMoeda.Name = "txt_VMoeda"
        Me.txt_VMoeda.Size = New System.Drawing.Size(63, 20)
        Me.txt_VMoeda.TabIndex = 12
        '
        'txt_VBoleto
        '
        Me.txt_VBoleto.Location = New System.Drawing.Point(478, 102)
        Me.txt_VBoleto.Name = "txt_VBoleto"
        Me.txt_VBoleto.Size = New System.Drawing.Size(63, 20)
        Me.txt_VBoleto.TabIndex = 13
        '
        'txt_VFiado
        '
        Me.txt_VFiado.Location = New System.Drawing.Point(630, 102)
        Me.txt_VFiado.Name = "txt_VFiado"
        Me.txt_VFiado.Size = New System.Drawing.Size(63, 20)
        Me.txt_VFiado.TabIndex = 14
        '
        'txt_NomeVendedor
        '
        Me.txt_NomeVendedor.Location = New System.Drawing.Point(108, 66)
        Me.txt_NomeVendedor.Name = "txt_NomeVendedor"
        Me.txt_NomeVendedor.Size = New System.Drawing.Size(245, 20)
        Me.txt_NomeVendedor.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Data"
        '
        'dtp_dataRomaneio
        '
        Me.dtp_dataRomaneio.Location = New System.Drawing.Point(272, 22)
        Me.dtp_dataRomaneio.Name = "dtp_dataRomaneio"
        Me.dtp_dataRomaneio.Size = New System.Drawing.Size(158, 20)
        Me.dtp_dataRomaneio.TabIndex = 17
        '
        'lbl_valorTotal
        '
        Me.lbl_valorTotal.AutoSize = True
        Me.lbl_valorTotal.BackColor = System.Drawing.Color.Bisque
        Me.lbl_valorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valorTotal.Location = New System.Drawing.Point(768, 144)
        Me.lbl_valorTotal.Name = "lbl_valorTotal"
        Me.lbl_valorTotal.Size = New System.Drawing.Size(41, 25)
        Me.lbl_valorTotal.TabIndex = 18
        Me.lbl_valorTotal.Text = "VT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(693, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Valor Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(681, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Status"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(724, 22)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(45, 13)
        Me.lbl_status.TabIndex = 21
        Me.lbl_status.Text = "Label11"
        '
        'bnt_modifica
        '
        Me.bnt_modifica.Location = New System.Drawing.Point(727, 51)
        Me.bnt_modifica.Name = "bnt_modifica"
        Me.bnt_modifica.Size = New System.Drawing.Size(75, 23)
        Me.bnt_modifica.TabIndex = 22
        Me.bnt_modifica.Text = "Modifica"
        Me.bnt_modifica.UseVisualStyleBackColor = True
        '
        'bnt_retorn
        '
        Me.bnt_retorn.Location = New System.Drawing.Point(630, 51)
        Me.bnt_retorn.Name = "bnt_retorn"
        Me.bnt_retorn.Size = New System.Drawing.Size(75, 23)
        Me.bnt_retorn.TabIndex = 23
        Me.bnt_retorn.Text = "Retorno"
        Me.bnt_retorn.UseVisualStyleBackColor = True
        '
        'Dia_DetalhesRomaneio
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(928, 427)
        Me.Controls.Add(Me.bnt_retorn)
        Me.Controls.Add(Me.bnt_modifica)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_valorTotal)
        Me.Controls.Add(Me.dtp_dataRomaneio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_NomeVendedor)
        Me.Controls.Add(Me.txt_VFiado)
        Me.Controls.Add(Me.txt_VBoleto)
        Me.Controls.Add(Me.txt_VMoeda)
        Me.Controls.Add(Me.txt_VDinheiro)
        Me.Controls.Add(Me.txt_VCheque)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_idromaneio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_ProdutosRomaneio)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dia_DetalhesRomaneio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalhes Romaneio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_ProdutosRomaneio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dgv_ProdutosRomaneio As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_idromaneio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_VCheque As TextBox
    Friend WithEvents txt_VDinheiro As TextBox
    Friend WithEvents txt_VMoeda As TextBox
    Friend WithEvents txt_VBoleto As TextBox
    Friend WithEvents txt_VFiado As TextBox
    Friend WithEvents txt_NomeVendedor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtp_dataRomaneio As DateTimePicker
    Friend WithEvents lbl_valorTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents bnt_modifica As Button
    Friend WithEvents bnt_retorn As Button
End Class
