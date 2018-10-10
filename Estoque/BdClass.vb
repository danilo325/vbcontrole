Imports System.Data.OleDb

Public Class BdClass
    Private conexao As New OleDbConnection
    Private comando As OleDbCommand
    Private adaptador As OleDbDataAdapter
    Private querySql As String
    'Função utilizada para abrir a conexão com o banco de dados
    Public Function Abreconexao() As OleDbConnection
        conexao.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LiderBancoDados.accdb"
        Try

            conexao.Open()
            Return conexao

        Catch ex As Exception
            MsgBox("Erro ao conectar com banco de dados \n" & ex.ToString, MsgBoxStyle.Critical)
        End Try
        Return Nothing
    End Function
    Public Function teste() As DataTable
        Return conexao.GetSchema

    End Function
    Public Function tt2() As Integer
        Dim d As DataTable = conexao.GetSchema("indexes")
        Dim foundRow As DataRow
        Try

            Dim s As String = "primaryKeyValue"

            foundRow = d.Select("COLUMN_NAME ='IdRomaneio'").GetValue(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Return foundRow.Item("CARDINALITY")
    End Function
    Public Function ultimo_id(tb As String, col As String) As Integer
        Dim id As Integer


        comando.CommandText = "SELECT max(" & col & ") FROM " & tb

        id = Int(comando.ExecuteScalar())
        Return id
    End Function
    'com esta fnção posso enviar e executar a query do Sql 
    Public Function Pesquisa(strQuery As String) As DataTable
        Dim tabeladedados As New DataTable
        comando = New OleDbCommand(strQuery, conexao)
        Try

            adaptador = New OleDbDataAdapter(comando)

            adaptador.Fill(tabeladedados)


        Catch ex As Exception
            MsgBox("Problemas na consulta \n" & ex.ToString, MsgBoxStyle.Critical)
        End Try
        Return tabeladedados
    End Function
    Public Function geraDataSet(strq As String, dt As DataSet) As DataSet

        comando = New OleDbCommand(strq, conexao)
        Try

            adaptador = New OleDbDataAdapter(comando)

            adaptador.Fill(dt)


        Catch ex As Exception
            MsgBox("Problemas na consulta \n" & ex.ToString, MsgBoxStyle.Critical)
        End Try
        Return dt
    End Function
    'Fechar a conexão
    Public Sub FechaConexao()
        Try
            conexao.Close()
        Catch ex As Exception
            MsgBox("Problemas para fechar a conexão" & ex.ToString)
        End Try
    End Sub
End Class

