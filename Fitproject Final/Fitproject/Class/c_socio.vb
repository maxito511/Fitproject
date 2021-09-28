Public Class c_socio
#Region "Atributos"
    Private id_socio As Integer
    Private dni As Long
    Private apellido As String
    Private nombre As String
    Private telefono As Integer
    Private direccion As String
    Private email As String
    Private fe_nacimiento As Date
    Private sexo As Char
    Private id_actividad As Integer
#End Region

#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal p_dni As Long, ByVal p_ape As String, ByVal p_nombre As String, ByVal p_tel As Long, ByVal p_dire As String, ByVal p_email As String, ByVal p_fecha As Date, ByVal p_sexo As Char)
        dni = p_dni
        nombre = p_nombre
        apellido = p_ape
        telefono = p_tel
        direccion = p_dire
        email = p_email
        fe_nacimiento = p_fecha
        sexo = p_sexo
    End Sub

#End Region

#Region "GET"
    Public Function GetDni()
        Return dni
    End Function
    Public Function GetApe()
        Return apellido
    End Function
    Public Function Getnom()
        Return nombre
    End Function
    Public Function GetTel()
        Return telefono
    End Function
    Public Function GetDirec()
        Return direccion
    End Function
    Public Function Getemail()
        Return email
    End Function
    Public Function GetFecha()
        Return fe_nacimiento
    End Function
    Public Function GetSexo()
        Return sexo
    End Function
    Public Function GetIdAct()
        Return id_actividad
    End Function
#End Region

#Region "Metodos"
    ' Muestra los socios Activos
    Public Sub MostrarSocio(ByVal dg_socio As DataGridView)
        Dim fe_actual As Date = Date.Today
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.socios
                              Where q.sn_activo = "S"
                              Select q.apellido, q.nombre, q.dni, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.id_socio, q.sn_activo).ToList
                dg_socio.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    ' Muestra todos los socios
    Public Sub MostrarSocioTodos(ByVal dg_socio As DataGridView)
        Dim fe_actual As Date = Date.Today
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.socios
                              Select q.apellido, q.nombre, q.dni, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.id_socio, q.sn_activo).ToList
                dg_socio.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    ' Muestra filtro por Nombre o Apellido
    Public Sub Filtrar_nomyape(ByVal dg_socio As DataGridView, ByVal nomyape As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.socios
                              Where (q.apellido = nomyape Or q.nombre = nomyape)
                              Select q.apellido, q.nombre, q.dni, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.id_socio, q.sn_activo).ToList
                dg_socio.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub
    ' Muestra Filtro por dni
    Public Sub Filtrar_dni(ByVal dg_socio As DataGridView, ByVal la_dni As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.socios
                              Where q.dni = la_dni
                              Select q.apellido, q.nombre, q.dni, q.direccion, q.telefono, q.email, q.fe_nacimiento, q.id_socio, q.sn_activo).ToList
                dg_socio.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub
    ' verifica existencia del socio
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
