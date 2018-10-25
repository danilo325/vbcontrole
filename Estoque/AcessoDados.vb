Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration

''' <summary>
''' Esta classe Fara a conexão com os dados
''' </summary>
''' 
Public Class AcessoDados
    Dim Da As New OleDbDataAdapter
    Dim Dt As New DataTable
    Dim Cmd As New OleDbCommand
    Dim Cn As New OleDb.OleDbConnection

    ''' <summary>
    ''' Realiza a conexão com o banco de dados 
    ''' </summary>
    ''' <returns>OleDbConnection</returns>
    ''' 
    Public Function GetConexaoDB() As OleDbConnection
        Try
            Cn.ConnectionString = ConfigurationManager.ConnectionStrings("ConexaoEstoque").ConnectionString
            Cn.Open()
            Return Cn
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Fecha uma conexão aberta
    ''' </summary>
    ''' <param name="cn">OleDbConnection</param>
    Public Sub CloseConexao(ByVal cn As OleDbConnection)
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox("Problemas ao criar combo de produtos" & ex.ToString)
            Throw ex

        End Try
    End Sub

    ''' <summary>
    ''' Utilizado para incluir novos registros de produtos no banco de dados
    ''' </summary>
    ''' <Name></Name>
    ''' <param name="descricao"><c>String</c> que descreve o produto</param>
    ''' <param name="grupo"><c>Integer</c> que define qual grupo o prouto pertence</param>
    ''' <param name="quantidade"><c>Integer</c> diz qual a quantidade de produto exite em estoque</param>
    ''' <param name="unidade"><c>String</c> de dois caracteres que define qual é a unidade de medida</param>
    ''' <param name="pcusto"><c>Double</c> que diz qual é o preço de custo do produto</param>
    ''' <param name="pvenda"><c>Double</c> que diz qual é o preço de venda </param>
    ''' <param name="produzido"><c>Boolean</c> que diz se o produto é produzido na empresa</param>
    ''' <param name="ativo"><c>Boolean</c> diz se o produto está ativo ou não</param>
    Public Sub IncluirDados(ByVal descricao As String, ByVal grupo As Integer, ByVal quantidade As Double, ByVal unidade As String, ByVal pcusto As Double, ByVal pvenda As Double, ByVal produzido As Boolean, ByVal ativo As Boolean)
        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = "INSERT INTO produto(Descricao, Grupo,Quantidade, Unidade,Pcusto,Pvenda,Produzido,Ativo)" &
                "VALUES('" & descricao & "','" & grupo & "','" & quantidade & "','" & unidade & "','" & pcusto & "','" & pvenda & "','" & produzido & "','" & ativo & "')"
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try
    End Sub
    ''' <summary>
    ''' Metodo que pesquisa im id de produto específico no banco de dados
    ''' </summary>
    ''' <param name="id"><c>Integer</c> que diz qual id deve ser procurado</param>
    ''' <returns><c>Produto</c> é um objeto da classe <class>Produto</class></returns>
    Public Function Procurar(ByVal id As Integer) As Produto
        Dim produto As New Produto
        Try
            Cn = GetConexaoDB()
            Dim da As New OleDbDataAdapter("SELECT * FROM produto WHERE IdProduto =" & id, Cn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                produto.IdProduto = dt.Rows(0).Item("IdProduto")
                produto.Descricao = dt.Rows(0).Item("Descricao")
                produto.Grupo = dt.Rows(0).Item("Grupo")
                produto.Quantidade = dt.Rows(0).Item("Qtd")
                produto.Unidade = dt.Rows(0).Item("Unidade")
                produto.Pcusto = dt.Rows(0).Item("Pcusto")
                produto.Pvenda = dt.Rows(0).Item("Pvenda")
                produto.Produzido = dt.Rows(0).Item("Produzido")
                produto.Ativo = dt.Rows(0).Item("Ativo")
            End If
        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try
        Return produto
    End Function

    ''' <summary>
    ''' Retorna todos os produtos no banco de dados
    ''' </summary>
    ''' <returns><c>DataTable</c> que contém os produtos no banco de dados</returns>
    Public Function CarregaDados() As DataTable
        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM produto"
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With
        Catch ex As Exception
            Dt = Nothing

        Finally
            CloseConexao(Cn)
        End Try
        Return Dt
    End Function

    ''' <summary>
    ''' Deleta um produto no banco de dados que tenha o mesmo id
    ''' </summary>
    ''' <param name="id"><c>Integer</c> identificador unico do produto</param>    
    Public Sub DeletaProduto(ByVal id As Integer)
        Try
            Cn = GetConexaoDB()
            Dim MyCmd As New OleDb.OleDbCommand
            MyCmd.Connection = Cn
            MyCmd.CommandText = "DELET FROM produto WHERE IdProduto =" & id
            MyCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try
    End Sub


    Public Function Inativaproduto(idProduto As Integer) As DataTable
        Try
            Cn = GetConexaoDB()
            Dim MyCmd As New OleDb.OleDbCommand
            MyCmd.Connection = Cn
            MyCmd.CommandText = "UPDATE produto SET Ativo= False WHERE IdProduto =" & idProduto
            MyCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try

        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM produto WHERE Ativo = True"
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With
        Catch ex As Exception
            Dt = Nothing
            Throw New Exception("Problema ao listar os produtos", ex)
        Finally
            CloseConexao(Cn)
        End Try
        Return Dt
    End Function


    Public Sub IncluiProduto(produto As Produto)
        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = "INSERT INTO produto(Descricao, Grupo,Qtd, Unidade,Pcusto,Produzido,Ativo)" &
                "VALUES('" & produto.Descricao & "','" & produto.Grupo & "','" & produto.Quantidade & "','" & produto.Unidade & "','" & produto.Pcusto & "'," & produto.Produzido & "," & produto.Ativo & ")"
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try
    End Sub

    Public Function ComboGruposProduto() As DataTable
        Dim grupos As New ComboBox
        Dim dados As New DataTable
        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = "SELECT * FROM gruposProduto"
            Da.SelectCommand = Cmd
            Da.Fill(dados)

        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try


        Return dados


    End Function


    Public Function DiciProduto() As DataTable

        Dim dados As New DataTable
        Dim query As String = "SELECT IdProduto, Descricao FROM produto"

        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = query
            Da.SelectCommand = Cmd
            Da.Fill(dados)
        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try

        Return dados
    End Function



    Public Sub PreencheProducao(ByRef dgv As DataGridView, Optional id As Integer = 0, Optional idpen As Integer = 0, Optional idpsai As Integer = 0, Optional dai As String = "", Optional daf As String = "")
        Dim query As String = "SELECT * FROM producao "
        Dim soum As Boolean = True
        dgv.Rows.Clear()

        If id > 0 Then
            If soum Then
                query += "WHERE IdProducao = " & id
                soum = False
            Else
                query += " AND IdProducao = " & id
            End If

        End If

        If idpen > 0 Then
            If soum Then
                query += " WHERE ProdutoEntrada = " & idpen
                soum = False
            Else
                query += " AND ProdutoEntrada = " & idpen
            End If

        End If
        If idpsai > 0 Then
            If soum Then
                query += " WHERE ProdutoSaida = " & idpsai
                soum = False
            Else
                query += " AND ProdutoSaida = " & idpsai
            End If

        End If
        If dai <> "" Then
            If daf <> "" Then
                If soum Then
                    query += "WHERE Data BETWEEN  '#" & Format(dai, "MM/dd/yyyy") & "#' AND '#" & Format(daf, "MM/dd/yyyy") & "#"
                    soum = False
                Else
                    query += " AND Data BETWEEN  '#" & Format(dai, "MM/dd/yyyy") & "#' AND '#" & Format(daf, "MM/dd/yyyy") & "#"
                End If
            Else
                If soum Then
                    query += "WHERE  Data = '#" & Format(dai, "MM/dd/yyyy") & "#'"
                    soum = False
                Else
                    query += " AND  Data = '#" & Format(dai, "MM/dd/yyyy") & "#'"
                End If
            End If
        End If
        Dim dados As New DataTable
        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = query
            Da.SelectCommand = Cmd
            Da.Fill(dados)

        Catch ex As Exception
            Throw ex
        Finally
            CloseConexao(Cn)
        End Try
        Dim dic As New Dictionary(Of Integer, String)
        For Each p As DataRow In DiciProduto().Rows
            dic.Add(p(0), p(1))
        Next

        For Each dado As DataRow In dados.Rows
            dgv.Rows.Add(dado.Item("IdProducao"),
                         Format(dado.Item("Data"), "dd/MM/yyyy"),
                       dic.Item(dado.Item("ProdutoEntrada")),
                         dado.Item("QtdEntra"),
                       dic.Item(dado.Item("ProdutoSaida")),
                         dado.Item("QtdSai"),
                         dado.Item("ObsProducao"))

        Next dado

    End Sub


    Public Sub GravaProducao(data As Date, materiaPrima As Integer, qtdMateriaprima As Double, producao As Integer, qtdProducao As Double, Optional obs As String = "")
        Dim atualizamateriaprima As String = "UPDATE produto SET Qtd = Qtd - " & qtdMateriaprima & " WHERE IdProduto = " & materiaPrima
        Dim atualizaproducao As String = "UPDATE produto SET Qtd = Qtd + " & qtdProducao & " 
WHERE IdProduto = " & producao
        Dim gravaproducao As String = "INSERT INTO producao(ProdutoEntrada,QtdEntra,ProdutoSaida,QtdSai,Data,ObsProducao) VALUES ('" &
            materiaPrima & "','" & qtdMateriaprima & "','" & producao & "','" & qtdProducao & "','" & Format(data, "dd/MM/yyyy") & "','" & obs & "')"
        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = gravaproducao
            Cmd.ExecuteNonQuery()
            '  Cmd.CommandText = atualizamateriaprima
            'Cmd.ExecuteNonQuery()
            ' Cmd.CommandText = atualizaproducao
            ' Cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Problemas ao gravar a produção" & ex.ToString)
        Finally
            CloseConexao(Cn)
        End Try
        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = atualizamateriaprima
            Cmd.ExecuteNonQuery()
            '  Cmd.CommandText = atualizamateriaprima
            'Cmd.ExecuteNonQuery()
            ' Cmd.CommandText = atualizaproducao
            ' Cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Problemas ao gravar a produção" & ex.ToString)
        Finally
            CloseConexao(Cn)
        End Try
        Try
            Cn = GetConexaoDB()
            Cmd.Connection = Cn
            Cmd.CommandText = atualizaproducao
            Cmd.ExecuteNonQuery()
            '  Cmd.CommandText = atualizamateriaprima
            'Cmd.ExecuteNonQuery()
            ' Cmd.CommandText = atualizaproducao
            ' Cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Problemas ao gravar a produção" & ex.ToString)
        Finally
            CloseConexao(Cn)
        End Try
    End Sub
End Class