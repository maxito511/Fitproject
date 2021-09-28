Public Class c_usuarios

#Region "Atributos"
    Private id_usuario As Integer
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
    ' Muestra todos los usuarios activos
    Public Sub MostrarUsuarios(ByVal dg_usuario As DataGridView)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.usuario
                              Where q.sn_activo = "S"
                              Select q.us_login, q.us_descrip, q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.sn_activo, q.id_usuario).ToList
                dg_usuario.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'Muestra todos los usuarios activos o no
    Public Sub MostrarUsuarioTodos(ByVal dg_usuario As DataGridView)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.usuario
                              Select q.us_login, q.us_descrip, q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.sn_activo, q.id_usuario).ToList
                dg_usuario.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub


    ' Muestra filtro por Nombre de usuario
    Public Sub Filtrar_nombre_de_usuario(ByVal dg_usuario As DataGridView, ByVal nombre_usuario As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.usuario
                              Where q.us_login = nombre_usuario
                              Select q.us_login, q.us_descrip, q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.sn_activo, q.id_usuario).ToList
                dg_usuario.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub
    ' Muestra Filtro por dni
    Public Sub Filtrar_dni(ByVal dg_usuario As DataGridView, ByVal la_dni As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.usuario
                              Where q.dni = la_dni
                              Select q.us_login, q.us_descrip, q.dni, q.apellido, q.nombre, q.direccion, q.telefono, q.email, q.sn_activo).ToList
                dg_usuario.DataSource = result
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'Verifica existencia de DNI
    Public Function verificar_dni(ByVal la_dni As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.usuario
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

    'Verifica existencia de nombre de usuario
    Public Function verificar_nombre_de_usuario(ByVal la_nombre As String)
        Try
            Using objMostrar As New taller2Entities
                Dim result = (From q In objMostrar.usuario
                              Where q.us_login = la_nombre).Count
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
