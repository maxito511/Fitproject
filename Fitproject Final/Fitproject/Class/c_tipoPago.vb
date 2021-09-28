Public Class c_tipoPago
    Private descripcion As String

#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal p_descrip As String)
        descripcion = p_descrip
    End Sub

#End Region

#Region "Get"
    Public Function GetDescripcion()
        Return descripcion
    End Function
#End Region

#Region "Metodos"
    ' Muestra tipos de pagos
    Public Sub MostrarTipos(ByVal dg_tipos As DataGridView)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.tipo_pago
                              Select q.id_tipo, q.descripcion).ToList
                dg_tipos.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    ' Agregar
    Public Function Agregar() As Boolean
        Try
            Using AGR As New taller2Entities
                Dim datos As New tipo_pago
                With datos
                    .descripcion = GetDescripcion()
                End With
                AGR.tipo_pago.Add(datos)
                AGR.SaveChanges()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
