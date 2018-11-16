Public Class HistoricoProduto
    Private _idProduto As Integer
    Private _data As Date
    Private _tipo As String
    Private _modificacao As String
    Private _valorAntigo As Double
    Private _valorNovo As Double
    Private Enum TipoModificacao
        Criacao = 1
        Entrada =  2 
        Saída = 3
        Modificacao= 4
    End Enum


    Public Property HistoricoIdProduto() As Integer
        Get
            Return _idProduto
        End Get
        Set(value As Integer)
            _idProduto = value
        End Set
    End Property

    Public Property HistoricoData() As Date
        Get
            Return _data

        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property
    Public Property HistoricoTipo() As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property HistoricoModificação() As String
        Get
            Return _modificacao
        End Get
        Set(value As String)
            _modificacao = value
        End Set
    End Property

    Public Property HistoricoValorAntigo() As Double
        Get
            Return _valorAntigo
        End Get
        Set(value As Double)
            _valorAntigo = value
        End Set
    End Property
    Public Property HistoricoValorNovo() As Double
        Get
            Return _valorNovo
        End Get
        Set(value As Double)
            _valorNovo = value
        End Set
    End Property
End Class
