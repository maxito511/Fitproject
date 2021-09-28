Module f_validar_login
    Public is_user As String
    Public is_pass As String
    Public is_tipo As String

    ' Valida login
    Public Function ValidarUsuario(ByVal user As String, ByVal pass As String)
        Try
            Using validarlogin As New taller2Entities
                Dim result = (From q In validarlogin.usuario
                              Where q.us_login = user And q.us_pass = pass
                              Select q.us_tipo).First
                ' Si el resultado de la consulta es 0 entonces no existe usuario en BD
                If result.Count > 0 Then
                    is_user = user
                    is_pass = pass
                    is_tipo = result
                    Return 1
                Else
                    Return -1
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("El usuario y/o la contraseña son incorrectos", "INICIO DE SESIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return -1
        End Try
    End Function

    Public Function ValidarAcceso(ByVal pass As String)
        Try
            Using validar As New taller2Entities
                Dim result = (From q In validar.empresa
                              Where q.us_pass = pass
                              ).Count
                ' Si el resultado de la consulta es 0 entonces no existe usuario en BD
                If result = 1 Then
                    Return 1
                Else
                    Return -1
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("El usuario y/o la contraseña son incorrectos", "INICIO DE SESIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return -1
        End Try
    End Function

End Module
