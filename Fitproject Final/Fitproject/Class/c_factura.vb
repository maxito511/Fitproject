Public Class c_factura
#Region "Constructores"
    Public Sub New()
    End Sub

#End Region

#Region "Pagos"
    ' Muestra todos los pagos
    Public Sub MostrarPagos(ByVal dg_pago As DataGridView)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From f In objMostrar.pagos
                              Select f.id_factura, f.apellido, f.nombre, f.importe, f.fe_factura, f.fe_vencimiento).ToList
                dg_pago.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    ' Muestra filtro por Nombre o Apellido
    Public Sub Filtrar_nomyape(ByVal dg_pago As DataGridView, ByVal nomyape As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From f In objMostrar.pagos
                              Where f.apellido = nomyape Or f.nombre = nomyape
                              Select f.id_factura, f.apellido, f.nombre, f.importe, f.fe_factura, f.fe_vencimiento).ToList
                dg_pago.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub
    ' Muestra Filtro por dni
    Public Sub Filtrar_dni(ByVal dg_pago As DataGridView, ByVal la_dni As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From f In objMostrar.pagos
                              Where f.dni = la_dni
                              Select f.id_factura, f.apellido, f.nombre, f.importe, f.fe_factura, f.fe_vencimiento).ToList
                dg_pago.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    ' Muestra filtro por fecha de pago
    Public Sub filtrar_fe_pago(ByVal dg_pago As DataGridView, ByVal desde As Date, ByVal hasta As Date)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From f In objMostrar.pagos
                              Where f.fe_factura >= desde And f.fe_factura <= hasta
                              Select f.id_factura, f.apellido, f.nombre, f.importe, f.fe_factura, f.fe_vencimiento).ToList
                dg_pago.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "pagos_detalle"
    ' Muestra todos los socios
    Public Function MostrarDetalle_dni(ByVal dg_pago As DataGridView, ByVal la_dni As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From s In objMostrar.socios
                              Where s.dni = la_dni
                              From sa In s.actividades
                              Select New With {s.apellido, s.nombre, sa.de_actividad, sa.pr_actividad, s.id_socio, sa.id_actividad}).ToList


                If result.Count > 0 Then
                    dg_pago.DataSource = result
                    Return True
                Else
                    Return False
                End If

            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

End Class
