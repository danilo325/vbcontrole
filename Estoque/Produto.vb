''' <summary>
''' Define os métodos e propriedades que o produto possui
''' </summary>
Public Class Produto
    Public Property IdProduto As Integer
    Public Property Descricao As String
    Public Property Grupo As Integer
    Public Property Quantidade As Double
    Public Property Unidade As String
    Public Property Pcusto As Double
    Public Property Pvenda As Double
    Public Property Produzido As Boolean
    Public Property Ativo As Boolean

    Public Sub New(
                  desc As String, grupo As Integer, quantidade As Double,
                  unidade As String, pcusto As Double, produzido As Boolean, ativo As Boolean
                   )
        Me.Descricao = desc
        Me.Grupo = grupo
        Me.Quantidade = quantidade
        Me.Unidade = unidade
        Me.Pcusto = pcusto
        Me.Produzido = produzido
        Me.Ativo = ativo

    End Sub
    Public Sub New()

    End Sub


End Class
