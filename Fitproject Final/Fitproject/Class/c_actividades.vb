Public Class c_actividades
#Region "Constructores"
    Public Sub New()
    End Sub

#End Region
#Region "Metodos"
    ' Muestra todas las Actividades
    Public Sub MostrarActividades(ByVal dg_actividad As DataGridView)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From a In objMostrar.actividades
                              Where a.sn_activo = "S"
                              Select a.de_actividad, a.duracion, a.pr_actividad, a.id_actividad, a.sn_activo).ToList
                dg_actividad.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'Muestra todas las actividades sin discriminar las activas o no activas
    Public Sub MostrarActividadesTodas(ByVal dg_actividad As DataGridView)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From a In objMostrar.actividades
                              Select a.de_actividad, a.duracion, a.pr_actividad, a.id_actividad, a.sn_activo).ToList
                dg_actividad.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub


    Public Sub MostrarActividades_clb(ByVal dg_actividad As ListBox)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From a In objMostrar.actividades
                              Select a.de_actividad).ToList
                dg_actividad.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub


    Public Sub FiltroEntrenador(ByVal dg_filtro_entre As DataGridView, ByVal nomyape As String)
        'Try
        '    Using objMostrar As New taller2Entities
        '        Dim result = (From a In objMostrar.actividades
        '                      From e In objMostrar.entrenadores
        '                          'Where a.id_entrenador = e.id_entrenador And (e.nombre = nomyape Or e.apellido = nomyape)
        '        Select Case a.de_actividad, a.duracion, de_entrenador = e.apellido + " " + e.nombre, a.pr_actividad).ToList
        '            dg_filtro_entre.DataSource = result
        '        End Using
        'Catch ex As Exception

        'End Try
    End Sub

    ' Filtro actividad
    Public Sub FiltroActividad(ByVal dg_filtro_acti As DataGridView, ByVal acti As String)
        'Try
        '    Using objMostrar As New taller2Entities
        '        Dim result = (From a In objMostrar.actividades
        '                      From e In objMostrar.entrenadores
        '                          'Where a.id_entrenador = e.id_entrenador And a.de_actividad = acti
        '        Select Case a.de_actividad, a.duracion, de_entrenador = e.apellido + " " + e.nombre, a.pr_actividad).ToList
        '            dg_filtro_acti.DataSource = result
        '        End Using
        'Catch ex As Exception

        'End Try
    End Sub
    ' filtro por fecha de Precio
    Public Sub FiltroPrecio(ByVal dg_filtro_precio As DataGridView, ByVal desde As Decimal, ByVal hasta As Decimal)
        'Try
        '    Using objMostrar As New taller2Entities
        '        Dim result = (From a In objMostrar.actividades
        '                      From e In objMostrar.entrenadores
        '                          'Where a.id_entrenador = e.id_entrenador And a.pr_actividad >= desde And a.pr_actividad <= hasta
        '        Select Case a.de_actividad, a.duracion, de_entrenador = e.apellido + " " + e.nombre, a.pr_actividad).ToList
        '            dg_filtro_precio.DataSource = result
        '        End Using
        'Catch ex As Exception

        'End Try
    End Sub
    ' filtro por hora
    Public Sub FiltroHora(ByVal dg_filtro_hora As DataGridView, ByVal desde As Decimal, ByVal hasta As Decimal)
        'Try
        '    Using objMostrar As New taller2Entities
        '        Dim result = (From a In objMostrar.actividades
        '                      From e In objMostrar.entrenadores
        '                          'Where a.id_entrenador = e.id_entrenador And a.duracion >= desde And a.duracion <= hasta
        '        Select Case a.de_actividad, a.duracion, de_entrenador = e.apellido + " " + e.nombre, a.pr_actividad).ToList
        '            dg_filtro_hora.DataSource = result
        '        End Using
        'Catch ex As Exception

        'End Try
    End Sub

    Public Function idActividades_lb(ByVal as_actividad As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From a In objMostrar.actividades
                              From e In objMostrar.entrenadores
                              Where a.de_actividad = as_actividad
                              Select a.id_actividad).First
                Return result
            End Using
        Catch ex As Exception
            Return "Error"
        End Try
        Return True
    End Function
#End Region
End Class
