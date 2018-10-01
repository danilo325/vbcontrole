Public Class c



    ' Private Function pegados() As DataTable
    'Dim tabeladados As DataTable
    ' dados.Abreconexao()
    ' tabeladados = dados.Pesquisa("SELECT IdProduto,Descricao, Grupo, Qtd, Unidade, Pcusto FROM produto")

    'eturn tabeladados
    '   End Function

    Public Shared Function getDados() As List(Of Class1)
        Dim dados As New BdClass
        Dim tabeladados As DataTable
        dados.Abreconexao()
        tabeladados = dados.Pesquisa("SELECT IdProduto,Descricao, Grupo, Qtd, Unidade, Pcusto FROM produto")
        Dim lista As New List(Of Class1)
        For Each data As DataRow In tabeladados.Rows
            lista.Add(New Class1() With {
            .Id = data.Item(0),
            .Descricao = data.Item(1),
            .Grupo = data.Item(2),
            .Unidade = data.Item(4),
            .Pcusto = data.Item(5),
            .Quantidade = data.Item(3)
                      }
             )

        Next data
        Return lista
    End Function
End Class
