
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class AcessoDados
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim isTran As Boolean
    Private trans As OleDbTransaction
    Dim connStr As String

    Public Shared Function GetConnectionString(ByVal StrConnection As String) As String
        Dim retorno As New String("")
        If String.IsNullOrEmpty(StrConnection) Then

            Try
                retorno = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LiderBancoDados.accdb"
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Return retorno
    End Function
    Private Function Connect() As Boolean
        Dim constr As String
        Dim bln As Boolean
        If conn Is Nothing Then
            constr = GetConnectionString("conexao")
            If constr <> String.Empty Then
                bln = True
                conn.ConnectionString = constr
            Else
                bln = False
            End If
        End If
        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Return bln
    End Function
    Public Sub CloseConn()
        If Not conn Is Nothing Then
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End If
    End Sub

    Public Function ExevuteQuery(ByVal strCmdTxt As String) As Boolean
        Dim intRows As Integer
        If conn.State = ConnectionState.Closed Then
            Connect()
        End If

        cmd.CommandText = strCmdTxt
        cmd.CommandType = CommandType.Text
        If Not isTran Then
            intRows = cmd.ExecuteNonQuery
            conn.Close()
        Else
            cmd.Transaction = trans
            intRows = cmd.ExecuteNonQuery
        End If
        If intRows > 0 Then
            ExevuteQuery = True
        Else
            ExevuteQuery = False
        End If
    End Function

    Public Function ExecuteAndGetReader(ByVal strCmdTxt As String) As OleDbDataReader
        If conn.State = ConnectionState.Closed Then
            Connect()
        End If
        cmd.CommandText = strCmdTxt
        cmd.CommandType = CommandType.Text

        If Not isTran Then
            ExecuteAndGetReader = cmd.ExecuteReader
        Else
            cmd.Transaction = trans
            ExecuteAndGetReader = cmd.ExecuteReader
        End If
    End Function
    Public Sub New()
        If Not Connect() Then
            Exit Sub
        End If
    End Sub

    Public Sub BeginTransaction()
        If isTran Then Return
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        trans = conn.BeginTransaction
        isTran = True
    End Sub

    Public Sub CoommitTransaction()
        If Not isTran Then Return
        trans.Commit()
        conn.Close()
        trans = Nothing
        isTran = False
    End Sub
End Class
