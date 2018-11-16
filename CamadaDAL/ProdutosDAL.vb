Imports System.Data
Imports System.Data.OleDb
Imports CamadaDTO
Imports System.Collections.Generic
Public Class ProdutosDAL
    Public Function DeletaAlunoPorId(ByVal _produtoId As Integer) As Boolean
        Dim strSql As String
        Dim ObjDB As AcessoDados
        strSql = "DELETE FROM produto WHERE IdProduto = " & _produtoId
        ObjDB = New AcessoDados
        ObjDB.ExevuteQuery(strSql)
        Return True
    End Function
    Public Function GetProdutos() As List(Of Produto)
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM produto"
        Dim dr As OleDbDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim lista As New List(Of Produto)
        While dr.Read
            Dim prod As Produto = New Produto
            prod.ProdutoId = If(IsDBNull(dr("IdProduto")), 0, dr("IdProduto"))
            prod.ProdutoDescricao = If(IsDBNull(dr("Descricao")), "Sem Descrição", dr("Descricao"))
            prod.ProdutoAtivo = If(IsDBNull(dr("Ativo")), Nothing, dr("Ativo"))
            prod.ProdutoQuantidade = If(IsDBNull(dr("Qtd")), 0, dr("Qtd"))
            prod.ProdutoUnidade = If(IsDBNull(dr("Unidade")), "??", dr("Unidade"))
            prod.ProdutoPrecoCusto = If(IsDBNull(dr("Pcusto")), 0, dr("Pvenda"))
            prod.ProdutoPrecoVenda = If(IsDBNull(dr("Pvenda")), 0, dr("Pvenda"))
            prod.ProdutoProduzido = If(IsDBNull(dr("Produzido")), Nothing, dr("Produzido"))
            lista.Add(prod)
        End While
        dr.Close()
        Return lista
    End Function

    Public Function GetProdutosPorID(ByRef produtoId As Integer) As Produto
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM produto WHERE IdProduto = " & produtoId
        Dim dr As OleDbDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim prod As Produto = Nothing
        While dr.Read
            prod = New Produto
            prod.ProdutoId = If(IsDBNull(dr("IdProduto")), 0, dr("IdProduto"))
            prod.ProdutoDescricao = If(IsDBNull(dr("Descricao")), "Sem Descrição", dr("Descricao"))
            prod.ProdutoAtivo = If(IsDBNull(dr("Ativo")), Nothing, dr("Ativo"))
            prod.ProdutoQuantidade = If(IsDBNull(dr("Qtd")), 0, dr("Qtd"))
            prod.ProdutoUnidade = If(IsDBNull(dr("Unidade")), "??", dr("Unidade"))
            prod.ProdutoPrecoCusto = If(IsDBNull(dr("Pcusto")), 0, dr("Pvenda"))
            prod.ProdutoPrecoVenda = If(IsDBNull(dr("Pvenda")), 0, dr("Pvenda"))
            prod.ProdutoProduzido = If(IsDBNull(dr("Produzido")), Nothing, dr("Produzido"))

        End While
        dr.Close()
        Return prod
    End Function
    Public Function SalvaProduto(ByRef _produto As Produto) As Boolean
        Dim strsql As String = ""
        Dim objDB As New AcessoDados
        If _produto.Acao = FlagAcao.insert Then
            strsql = "INSERT INTO produto (Descricao,Unidade) " & "VALUES('" & _produto.ProdutoDescricao.Trim() & "','" & _produto.ProdutoUnidade & "')"
        ElseIf _produto.Acao = FlagAcao.Update Then
            strsql = "UPDATE produto SET" & "Descricao = '" & _produto.ProdutoDescricao & "', Unidade = '" & _produto.ProdutoUnidade & "' WHERE IdProduto = " & _produto.ProdutoId
        End If
        objDB.ExevuteQuery(strsql)
        Return True
    End Function

End Class
