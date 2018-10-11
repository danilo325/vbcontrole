Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
''' <summary>
''' Classe permite o acesso ao banco de dados
''' </summary>
Public Class AcessoRomaneio
    Dim Da As New OleDbDataAdapter
    Dim Dt As DataTable
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
            MsgBox("Problemas com a conexao do banco. " & ex.ToString)
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
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo busca todos Romaneios dentro do banco de dados e devolve uma lista de romaneios
    ''' </summary>
    ''' <returns><c>Lisrt(Of Romaneios)</c> lista de objetos da classe Romaneio</returns>
    Public Function CarregaRomaneios() As List(Of Romaneio)
        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM romaneio "
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With
        Catch ex As Exception
            Dt = Nothing
            MsgBox("Erro ao carregar os romaneios " & ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        Return GeraListaRomaneio(Dt)
    End Function

    ''' <summary>
    ''' Função baseada no Carregaromaneios que possui parametros de pesquisa para filtrar os romaneios
    ''' </summary>
    ''' <param name="idromaneio"><c>Integer</c> o indentificador unico do romaneio</param>
    ''' <param name="idvendedor"><c>Integer</c> o indentificado unico do vendedor</param>
    ''' <param name="datainicial"><c>String</c> string que representa a data e precisa estar no formato #MM/dd/yyyy# </param>
    ''' <param name="datafinal"><c>String</c> string que representa a data e precisa estar no formato #MM/dd/yyyy# </param></param>
    ''' <returns><c>Lisrt(Of Romaneios)</c> lista de objetos da classe Romaneio</returns>
    Public Function PesquisaRomaneio(idromaneio As Integer, idvendedor As Integer, datainicial As String, datafinal As String) As List(Of Romaneio)
        Dim query As String = ""
        Dim soum As Boolean = True
        Dt = New DataTable
        Cn = GetConexaoDB()
        If idromaneio > 0 Then
            If soum Then
                query += "WHERE IdRomaneio = " & idromaneio
                soum = False
            Else
                query += " AND IdRomaneio = " & idromaneio
            End If
        End If
        If idvendedor > 0 Then
            If soum Then
                query += "WHERE IdVendedor = " & idvendedor
                soum = False
            Else
                query += " AND IdVendedor = " & idvendedor
            End If
        End If
        If datainicial <> "" Then
            If datafinal <> "" Then
                If soum Then
                    query += "WHERE DataRomaneio BETWEEN " & datainicial & " AND " & datafinal
                    soum = False
                Else
                    query += " AND DataRomaneio BETWEEN " & datainicial & " AND " & datafinal
                End If
            Else
                If soum Then
                    query += "WHERE DataRomaneio =" & datainicial
                    soum = False
                Else
                    query += " AND DataRomaneio =" & datainicial
                End If
            End If
        End If

        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM romaneio " & query
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With
        Catch ex As Exception
            Dt = Nothing
            MsgBox("Erro ao carregar os romaneios " & ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        Return GeraListaRomaneio(Dt)
    End Function

    ''' <summary>
    ''' Metodo que busca o nome do vendedor através do Id do vendedor
    ''' </summary>
    ''' <param name="idvendedor"><c>Integer</c> identifcicador unico do vendedor</param>
    ''' <returns><c>String</c> Contendo o nome do vendedor</returns>
    Private Function NomeVendedor(idvendedor As Integer) As String
        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT NomeVendedor FROM vendedores WHERE IdVendedor = " & idvendedor
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
            Dt = Nothing

            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        Return Dt.Rows(0).Item("NomeVendedor").ToString
    End Function

    ''' <summary>
    ''' Busca na tabela produtosRomaneio a lista de produtos do romaneio
    ''' </summary>
    ''' <param name="idromaneio"><c>Integer</c> identificador unico do romaneio</param>
    ''' <returns><c>DataTable</c> contendo todos os produtos do romaneio</returns>
    Private Function ListaProdutos(idromaneio As Integer) As DataTable
        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM produtosRomaneio WHERE IdRomaneio = " & idromaneio
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With

        Catch ex As Exception
            Dt = Nothing
            MsgBox("Problemas ao recuperar lista de produtos do Romaneio ID" & idromaneio & ex.ToString)
            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        Return Dt
    End Function

    Private Function GetIdVendedor(nome As String) As Integer
        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT IdVendedor FROM vendedores WHERE NomeVendedor ='" & nome & "'"
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With

        Catch ex As Exception
            Dt = Nothing
            MsgBox("Problemas ao recuperar o id do vendedor no momento de gravar o romaneio" & ex.ToString)
            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        Return Dt.Rows(0).Item(0)
    End Function

    ''' <summary>
    ''' Gera uma <c>List(Of Romaneio)</c> e preenche os valores das propriedades dos Objetos romaneios atraves dos dados
    ''' do <c>DataTable</c> retornado da busca no banco de dados
    ''' </summary>
    ''' <param name="tabela"><c>DataTable</c> com informações do banco de dados</param>
    ''' <returns><c>List(Of Romaneio)</c> contendo os objetos com suas propriedades devidamente preenchidas</returns>
    Private Function GeraListaRomaneio(tabela As DataTable) As List(Of Romaneio)
        Dim lista As New List(Of Romaneio)

        Try


            For Each linha As DataRow In tabela.Rows

                lista.Add(New Romaneio(
                      linha.Item("IdRomaneio"),
                      NomeVendedor(CInt(linha.Item("IdVendedor"))),
                      0,
                     linha.Item("DataRomaneio"),
                      linha.Item("ValorCheques"),
                      linha.Item("ValoDinheiro"),
                      linha.Item("ValorMoedas"),
                      linha.Item("ValorBoleto"),
                      linha.Item("ValorFiado"),
                      linha.Item("ObsRomaneio"),
                      linha.Item("ValorTotal"),
                      linha.Item("Estado"),
                      ListaProdutos(linha.Item("IdRomaneio"))
                      ))

            Next linha
        Catch ex As Exception
            MsgBox("Problemas ao capturar a lista de romaneio" & ex.ToString, MsgBoxStyle.Critical)
        End Try
        Return lista
    End Function



    Public Function VerificaProdutos(produto As Integer) As DataTable
        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT IdProduto,Descricao,Qtd FROM produto WHERE IdProduto =" & produto
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With

        Catch ex As Exception
            Dt = Nothing
            MsgBox("Problemas ao recuperar o id do produto no momento de gravar o romaneio" & ex.ToString)
            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        Return Dt
    End Function

    Public Function VerificaProdutos(produto As Integer, conexao As OleDbConnection) As DataTable
        Dt = New DataTable
        Cn = conexao
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT IdProduto,Descricao,Qtd FROM produto WHERE IdProduto =" & produto
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With

        Catch ex As Exception
            Dt = Nothing
            MsgBox("Problemas ao recuperar o id do produto no momento de gravar o romaneio" & ex.ToString)
            Return Nothing

        End Try
        Return Dt
    End Function

    Public Function VerificaProdutos(produto As String) As DataTable
        MsgBox(produto)
        Dt = New DataTable
        Cn = GetConexaoDB()
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT IdProduto,Descricao,Qtd FROM produto WHERE Descricao = '" & produto & "'"
                .Connection = Cn
            End With
            With Da
                .SelectCommand = Cmd
                .Fill(Dt)
            End With

        Catch ex As Exception
            Dt = Nothing
            MsgBox("Problemas ao recuperar o id do produto no momento de gravar o romaneio" & ex.ToString)
            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        Return Dt
    End Function


    Public Function GravaRomaneio(romaneio As Romaneio) As Boolean
        Dim query As String = "INSERT INTO romaneio(IdVendedor,DataRomaneio,ValorCheques,ValoDinheiro,ValorMoedas,ValorBoleto,ValorFiado,ObsRomaneio,Estado) Values(" &
            "'" & GetIdVendedor(romaneio.Vendedor) & "'," &
            "'" & romaneio.Data & "'," &
            "'" & romaneio.VCheques.ToString.Replace(".", ",") & "'," &
            "'" & romaneio.VDinheiro.ToString.Replace(".", ",") & "'," &
            "'" & romaneio.VMoedas.ToString.Replace(".", ",") & "'," &
            "'" & romaneio.VBoletos.ToString.Replace(".", ",") & "'," &
            "'" & romaneio.VFiado.ToString.Replace(".", ",") & "'," &
            "'" & romaneio.Observacao & "'," &
            "'" & romaneio.Status & "')"

        Cn = GetConexaoDB()

        Try
            Cmd = New OleDbCommand(query, Cn)

            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            CloseConexao(Cn)
        End Try
        GravaProdutosRomaneio(romaneio.ListaProdutos)
        Return True
    End Function

    Public Function GravaProdutosRomaneio(produtos As DataTable) As Boolean
        Dim strquery As String = ""
        Cn = GetConexaoDB()
        Try
            For Each produto As DataRow In produtos.Rows
                Dim a As Integer = VerificaProdutos(Integer.Parse(produto.Item(1)), Cn).Rows(0).Item(2)
                strquery = "UPDATE produto SET Qtd = '" & a - produto.Item(2) & "' WHERE IdProduto = " & produto.Item(1)

                MsgBox(strquery)
                Cmd = New OleDbCommand(strquery, Cn)
                Da.SelectCommand = Cmd
                Cmd.ExecuteNonQuery()





            Next
            For Each produto As DataRow In produtos.Rows
                strquery = "INSERT INTO produtosRomaneio(IdRomaneio, Idproduto,QtdProdutoS) VALUES(" &
                 "'" & produto.Item(0) & "','" & produto.Item(1) & "','" & produto.Item(2) & "')"

                MsgBox(strquery)
                Cmd = New OleDbCommand(strquery, Cn)
                'Da.SelectCommand = Cmd
                Cmd.ExecuteNonQuery()





            Next
        Catch ex As Exception
            MsgBox("Problemas para aramzenar os produtos \n" & ex.ToString, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConexao(Cn)
        End Try
        Return True
    End Function
End Class
