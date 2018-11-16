Public Class Produto
    Private _id As Integer
    Private _descricao As String
    Private _quantidade As Double
    Private _unidade As String
    Private _pcustp As Double
    Private _pvenda As Double
    Private _pcusto As Double
    Private _produzido As Boolean
    Private _ativo As Boolean
    Private _acao As Byte
    Public Property ProdutoId() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property ProdutoDescricao() As String
        Get
            Return _descricao
        End Get
        Set(value As String)
            _descricao = value
        End Set
    End Property
    Public Property ProdutoQuantidade() As Double
        Get
            Return _quantidade
        End Get
        Set(value As Double)
            _quantidade = value
        End Set
    End Property

    Public Property ProdutoUnidade() As String
        Get
            Return _unidade
        End Get
        Set(value As String)
            _unidade = value
        End Set
    End Property

    Public Property ProdutoPrecoCusto() As Double
        Get
            Return _pcusto
        End Get
        Set(value As Double)
            _pcusto = value
        End Set
    End Property

    Public Property ProdutoPrecoVenda() As Double
        Get
            Return _pvenda

        End Get
        Set(value As Double)
            _pvenda = value
        End Set
    End Property

    Public Property ProdutoProduzido() As Boolean
        Get
            Return _produzido
        End Get
        Set(value As Boolean)
            _produzido = value
        End Set
    End Property

    Public Property ProdutoAtivo() As Boolean
        Get
            Return _ativo
        End Get
        Set(value As Boolean)
            _ativo = value
        End Set
    End Property
    Public Property Acao() As Byte
        Get
            Return _acao
        End Get
        Set(value As Byte)
            _acao = value
        End Set
    End Property
End Class
