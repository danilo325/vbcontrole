<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Class1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        'Me.LiderBancoDadosDataSet = New Estoque.LiderBancoDadosDataSet()
        Me.comprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.comprasTableAdapter = New Estoque.LiderBancoDadosDataSetTableAdapters.comprasTableAdapter()
        Me.produtosCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.produtosCompraTableAdapter = New Estoque.LiderBancoDadosDataSetTableAdapters.produtosCompraTableAdapter()
        '  CType(Me.Class1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '  CType(Me.LiderBancoDadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produtosCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Class1BindingSource
        '
        Me.Class1BindingSource.DataSource = GetType(System.Void)
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetCompras"
        ReportDataSource1.Value = Me.comprasBindingSource
        ReportDataSource2.Name = "DataSetProdutosCompras"
        ReportDataSource2.Value = Me.produtosCompraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Estoque.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 290)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'LiderBancoDadosDataSet
        '
        ' Me.LiderBancoDadosDataSet.DataSetName = "LiderBancoDadosDataSet"
        'Me.LiderBancoDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'comprasBindingSource
        '
        Me.comprasBindingSource.DataMember = "compras"
        '   Me.comprasBindingSource.DataSource = Me.LiderBancoDadosDataSet
        '
        'comprasTableAdapter
        '
        '   Me.comprasTableAdapter.ClearBeforeFill = True
        '
        'produtosCompraBindingSource
        '
        Me.produtosCompraBindingSource.DataMember = "produtosCompra"
        '   Me.produtosCompraBindingSource.DataSource = Me.LiderBancoDadosDataSet
        '
        'produtosCompraTableAdapter
        '  '
        '  Me.produtosCompraTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Class1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '  CType(Me.LiderBancoDadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produtosCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Class1BindingSource As BindingSource
    Friend WithEvents comprasBindingSource As BindingSource
    '  Friend WithEvents LiderBancoDadosDataSet As Estoque.LiderBancoDadosDataSet
    Friend WithEvents produtosCompraBindingSource As BindingSource
    'Friend WithEvents comprasTableAdapter As Estoque.LiderBancoDadosDataSetTableAdapters.comprasTableAdapter
    'Friend WithEvents produtosCompraTableAdapter As Estoque.LiderBancoDadosDataSetTableAdapters.produtosCompraTableAdapter
End Class
