''' <summary>
''' Classe que contem as propriedades do romaneio
''' </summary>
Public Class Romaneio
    Property Id As Integer
    Property Vendedor As String
    Property Numero As Integer 'ainda será implementado
    Property Data As String
    Property VCheques As Double
    Property VDinheiro As Double
    Property VMoedas As Double
    Property VBoletos As Double
    Property VFiado As Double
    Property Observacao As String
    Property VToatal As Double
    Property Status As String
    Property ListaProdutos As DataTable

    Public Sub New(ByVal id As Integer, ByVal vendedor As String, ByVal numero As Integer, ByRef data As String, ByVal vcheque As Double,
                   ByVal vdinheiro As Double, ByVal vmoedas As Double, ByVal vboletos As Double, ByVal vfiado As Double, ByVal obs As String, ByVal vtotal As Double,
                   ByVal status As String, ByVal listaprodutos As DataTable)

        Me.Id = id
        Me.Vendedor = vendedor
        Me.Numero = numero
        Me.VCheques = vcheque
        Me.VDinheiro = vdinheiro
        Me.VMoedas = vmoedas
        Me.VBoletos = vboletos
        Me.VFiado = vfiado
        Me.Status = status
        Me.ListaProdutos = listaprodutos
        Me.Data = data
        Me.Observacao = obs
        Me.VToatal = vtotal


    End Sub

    Public Sub New()

    End Sub



    ''' <summary>
    ''' Função que retorna a soma dos valores de cheque, dinheiro, moedas e boletos.
    ''' O valor da variavel <c>VFiado</c> já é somado ao valor de dinheiro por isso não entra na soma.
    ''' </summary>
    ''' <returns><c>Double</c> valor que representa o montante total que o romaneio gerou</returns>
    Public Function GetVTotal() As Double

        Return VCheques + VDinheiro + VMoedas + VBoletos
    End Function


End Class
