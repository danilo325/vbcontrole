Imports System.ComponentModel
''' <summary>
''' Classe estoque
''' Utilizada para mostrar o estoque existente no momento
''' </summary>

Public Class Estoque
    'Inicia as variáveis importantes

    Friend bancoDados As New BdClass
    Private acessodados As New AcessoDados
    Friend grupoProduto As New DataTable
    Friend dicionarioGrupo As New Dictionary(Of String, Integer)
    Friend dicionarioGrupo2 As New Dictionary(Of Integer, String)
    Dim dicionarioSimNao As New Dictionary(Of String, Boolean)
    Dim valorcelula As String
    ''' <summary>
    ''' Evento que carrega as variáveis e carrega a tela incial do estoque 
    ''' Este método é chamado asssim que o Form estoque é carregado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bancoDados.Abreconexao()
        dgv_Produtos.AllowUserToAddRows = False
        dgv_Produtos.AllowUserToDeleteRows = False

        cmb_Ativo.Items.Add("")
        cmb_Ativo.Items.Add("Sim")
        cmb_Ativo.Items.Add("Não")
        cmb_Produzido.Items.Add("")
        cmb_Produzido.Items.Add("Sim")
        cmb_Produzido.Items.Add("Não")
        Dim dicionario As New Dictionary(Of String, Integer)
        ComboGrupoProdutos()
        dgv_Produtos.DataSource = bancoDados.Pesquisa("SELECT * FROM produto WHERE Ativo = True")
        dicionarioSimNao.Add("Sim", True)
        dicionarioSimNao.Add("Não", False)
        cmb_Produzido.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_TipoProduto.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_Ativo.DropDownStyle = ComboBoxStyle.DropDownList
        dgv_Produtos.ReadOnly = True
    End Sub

    ''' <summary>
    ''' Este método retorna um combobox preebchido com os tipos de produto
    ''' </summary>
    ''' <returns></returns>
    Friend Function getGrupo() As ComboBox
        Return cmb_TipoProduto
    End Function

    ''' <summary>
    ''' Carrega os dados do banco de dados e preenche o combobox com eles
    ''' </summary>
    Private Sub ComboGrupoProdutos()
        grupoProduto = bancoDados.Pesquisa("SELECT * FROM gruposProduto")
        cmb_TipoProduto.Items.Add("Todos")
        For Each linha As DataRow In grupoProduto.Rows
            dicionarioGrupo.Add(linha(1).ToString, linha(0))
            dicionarioGrupo2.Add(linha(0), linha(1).ToString)
            cmb_TipoProduto.Items.Add(linha(1).ToString)
        Next linha
    End Sub

    Private Sub PesquisaProduto(str As String)
        Dim query As String
        query = ""
        MsgBox(str)

        If (str <> "") Then


            query = "SELECT * FROM produto WHERE "


            dgv_Produtos.DataSource = bancoDados.Pesquisa(query & str)

        Else
            dgv_Produtos.DataSource = bancoDados.Pesquisa("SELECT * FROM produto")
        End If


    End Sub

    Private Sub Estoque_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        bancoDados.FechaConexao()

    End Sub

    Private Sub Bnt_Inclui_Click(sender As Object, e As EventArgs) Handles bnt_Inclui.Click
        'dia_inclui.Visible = True
        NovoProduto.Visible = True

    End Sub

    Private Sub Bnt_Fechar_Click(sender As Object, e As EventArgs) Handles bnt_Fechar.Click
        Me.Close()
    End Sub

    Private Sub Bnt_Pesquisa_Click(sender As Object, e As EventArgs) Handles bnt_Pesquisa.Click
        Dim contador As Integer
        Dim str As String
        str = ""
        contador = 0
        If (txt_IdProduto.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND IdProduto =" & txt_IdProduto.Text
            Else
                str += "IdProduto =" & txt_IdProduto.Text

            End If
        End If
        If (txt_DecricaoProduto.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND Descricao LIKE '%" & txt_DecricaoProduto.Text & "%'"
            Else
                str += " Descricao Like '%" & txt_DecricaoProduto.Text & "%'"
            End If
        End If
        If (cmb_TipoProduto.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND Grupo = " & dicionarioGrupo.Item(cmb_TipoProduto.Text)
            Else
                str += " Grupo = " & dicionarioGrupo.Item(cmb_TipoProduto.Text)
            End If
        End If
        If (txt_PrecoCusto.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND Pcusto = " & txt_PrecoCusto.Text
            Else
                str += " Pcusto = " & txt_PrecoCusto.Text
            End If
        End If
        If (txt_PrecoVenda.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND Pvenda = " & txt_PrecoVenda.Text
            Else
                str += " PVenda = " & txt_PrecoVenda.Text
            End If
        End If
        If (cmb_Ativo.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND Ativo= " & dicionarioSimNao.Item(cmb_Ativo.Text)
            Else
                str += " Ativo = " & dicionarioSimNao.Item(cmb_Ativo.Text)
            End If
        End If

        If (cmb_Produzido.Text <> "") Then
            contador = contador + 1
            If (contador > 1) Then
                str += " AND Produzido= " & dicionarioSimNao.Item(cmb_Produzido.Text)
            Else
                str += " Produzido = " & dicionarioSimNao.Item(cmb_Produzido.Text)
            End If
        End If



        PesquisaProduto(str)


    End Sub
    Private Sub Dgv_Produtos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Produtos.CellEndEdit
        Dim str As String
        str = " UPDATE produto SET "
        ' Limpa o erro da linha no caso do usuário pressionar ESC
        MsgBox(e.ColumnIndex)
        MsgBox(e.RowIndex & "|" & e.ColumnIndex)
        Select Case e.ColumnIndex

            Case 1
                str += "Descricao = '" & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 2
                str += "Grupo = " & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            Case 3
                str += "Qtd = " & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace(",", ".")
            Case 4
                str += "Unidade = '" & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & "' "
            Case 5
                str += "Pcusto = " & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace(",", ".")
            Case 6
                str += "Pvenda = " & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            Case 7
                str += "Produzido = " & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            Case 8
                str += "Ativo = " & dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString


        End Select
        str += " WHERE IdProduto = " & dgv_Produtos.Rows(e.RowIndex).Cells(0).Value.ToString
        MsgBox(str)
        bancoDados.Pesquisa(str)

    End Sub

    Private Sub bnt_Edita_Click(sender As Object, e As EventArgs) Handles bnt_Edita.Click
        If (dgv_Produtos.ReadOnly) Then
            bnt_Edita.Text = "Sair modo ediçao"


            dgv_Produtos.ReadOnly = False
            dgv_Produtos.Columns(0).ReadOnly = True
            dgv_Produtos.Columns(0).Resizable = DataGridViewTriState.False

            dgv_Produtos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells






        Else
            bnt_Edita.Text = "editar"
            dgv_Produtos.ReadOnly = True

        End If


    End Sub

    Private Sub dgv_Produtos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_Produtos.CellBeginEdit

    End Sub

    Private Sub dgv_Produtos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Produtos.CellContentDoubleClick
        If Not dgv_Produtos.ReadOnly Then

            Select Case e.ColumnIndex
                Case 2
                    valorcelula = dicionarioGrupo.Item(dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                Case 7
                    valorcelula = dicionarioSimNao.Item(dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                Case 8
                    valorcelula = dicionarioSimNao.Item(dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                Case Else
                    valorcelula = dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            End Select

            valorcelula = dgv_Produtos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
        End If


    End Sub

    Private Sub bnt_Exclui_Click(sender As Object, e As EventArgs) Handles bnt_Exclui.Click

        If (dgv_Produtos.SelectedRows.Count > 0) Then
            For Each linha As DataGridViewRow In dgv_Produtos.SelectedRows
                If MsgBox("Deseja mesmo excluir o produto:" & vbCrLf & linha.Cells(1).Value, MsgBoxStyle.YesNo, "Deseja Excluir " & linha.Cells(1).Value) = vbYes Then
                    dgv_Produtos.DataSource = acessodados.Inativaproduto(linha.Cells(0).Value)
                End If

            Next linha

        End If
        ' Dim query As String
        'Dim mensagem As String = ""
        'query = "DELETE FROM produto WHERE IdProduto IN ("
        'If (dgv_Produtos.SelectedRows.Count > 0) Then 'Garanti que tenha pelomenos uma linha selecionada

        'For Each linha As DataGridViewRow In dgv_Produtos.SelectedRows
        'query += linha.Cells(0).Value.ToString & ","
        'mensagem += linha.Cells(1).Value.ToString & "\n"
        '
        'Next linha
        'query += ")"
        'MsgBox("Os produtos \n " & mensagem & "\n serão apagados")
        'MsgBox(query)


        'bancoDados.Pesquisa(query)
        'dgv_Produtos.DataSource = bancoDados.Pesquisa("SELECT * FROM produto WHERE Ativo = True ")
        'Else
        'MsgBox("É necessário selecionar ao menos uma linha")
        'End If

    End Sub

    Private Sub dgv_Produtos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_Produtos.CellMouseDoubleClick
        DetalheProduto.lbl_idproduto.Text = dgv_Produtos.Rows(e.RowIndex).Cells(0).Value.ToString
        DetalheProduto.lbl_descricao.Text = dgv_Produtos.Rows(e.RowIndex).Cells(1).Value.ToString
        DetalheProduto.lbl_grupo.Text = dicionarioGrupo2.Item(dgv_Produtos.Rows(e.RowIndex).Cells(2).Value)
        DetalheProduto.lbl_unidade.Text = dgv_Produtos.Rows(e.RowIndex).Cells(4).Value.ToString
        DetalheProduto.lbl_pcusto.Text = "R$ " & dgv_Produtos.Rows(e.RowIndex).Cells(5).Value.ToString
        DetalheProduto.lbl_pdroduzido.Text = dgv_Produtos.Rows(e.RowIndex).Cells(7).Value.ToString
        DetalheProduto.lbl_avtivo.Text = dgv_Produtos.Rows(e.RowIndex).Cells(8).Value.ToString
        DetalheProduto.lbl_qtd.Text = dgv_Produtos.Rows(e.RowIndex).Cells(3).Value.ToString
        DetalheProduto.Show()
    End Sub

    Friend Class LiderBancoDadosDataSet
    End Class

    Friend Class LiderBancoDadosDataSetTableAdapters
    End Class

    Private Sub bnt_producao_Click(sender As Object, e As EventArgs) Handles bnt_producao.Click
        Producao.Visible = True
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click


    End Sub

    Private Sub rel_teste_Click(sender As Object, e As EventArgs) Handles rel_teste.Click
        Form4.Visible = True
    End Sub
End Class
