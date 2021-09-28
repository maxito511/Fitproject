Public Class c_entrenador
#Region "Atributos"
    Private id_socio As Integer
    Private dni As Integer
    Private nombre As String
    Private apellido As String
    Private telefono As Integer
    Private direccion As String
    Private email As String
    Private fe_nacimiento As Date
    Private sexo As Char
#End Region

#Region "Constructores"
    Public Sub New()
    End Sub

#End Region

#Region "Metodos"
    ' Muestra todos los entrenadores
    Public Sub MostrarEntrenador(ByVal dg_entrenador As DataGridView)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.entrenadores
                              Where q.sn_activo = "S"
                              Select q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.sexo, q.sn_activo, q.id_entrenador).ToList
                dg_entrenador.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'Muestra todos los entrenadores activos o no
    Public Sub MostrarEntrenadorTodos(ByVal dg_socio As DataGridView)
        Dim fe_actual As Date = Date.Today
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.entrenadores
                              Select q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.sexo, q.sn_activo, q.id_entrenador).ToList
                dg_socio.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub


    ' Muestra filtro por Nombre o Apellido
    Public Sub Filtrar_nomyape(ByVal dg_entrenador As DataGridView, ByVal nomyape As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.entrenadores
                              Where q.apellido = nomyape Or q.nombre = nomyape
                              Select q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.sexo, q.sn_activo, q.id_entrenador).ToList
                dg_entrenador.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub
    ' Muestra Filtro por dni
    Public Sub Filtrar_dni(ByVal dg_entrenador As DataGridView, ByVal la_dni As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.entrenadores
                              Where q.dni = la_dni
                              Select q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.sexo, q.sn_activo, q.id_entrenador).ToList
                dg_entrenador.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'Verifica existencia de DNI
    Public Function verificar_dni(ByVal la_dni As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.socios
                              Where q.dni = la_dni).Count
                If result > 0 Then
                    Return -1
                Else
                    Return 1
                End If
            End Using
        Catch ex As Exception
            Return -1
        End Try
    End Function

#End Region
End Class
