Public Class w_agregar_usuario
    Dim usuario As New c_usuarios
    Public id_origen As Integer
    Dim ll_id As Long
    Dim sn_activo As Char
    Dim ls_tipo As String

    Private Sub tb_DNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_DNI.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub tb_Apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Apellido.KeyPress
        f_validar_form.Validar_letras(e)
    End Sub

    Private Sub tb_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Nombre.KeyPress
        f_validar_form.Validar_letras(e)
    End Sub

    Private Sub tb_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Telefono.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub tb_email_Leave(sender As Object, e As EventArgs) Handles tb_Email.Leave
        If tb_Email.Text <> "" And (f_validar_form.Valida_email(tb_Email.Text) = False) Then
            MessageBox.Show("Email Invalido.", "")
            tb_Email.Focus()
        End If

    End Sub

    Private Sub bt_Cancelar_Click(sender As Object, e As EventArgs) Handles bt_Cancelar.Click
        If tb_DNI.Text <> "" Or tb_Apellido.Text <> "" Or tb_Nombre.Text <> "" Or tb_Telefono.Text <> "" Or tb_Direccion.Text <> "" Or tb_nombre_usuario.Text <> "" Or tb_contraseña.Text <> "" Then

            If MessageBox.Show("¿Seguro desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Me.Close()

            End If

        End If

        Me.Close()


    End Sub

    Private Sub bt_consultar_usuarios_Click(sender As Object, e As EventArgs) Handles bt_consultar_usuarios.Click
        w_consultar_usuario.Show()
        Me.Close()
    End Sub

    Private Sub w_agregar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' USUARIO NUEVO
        If id_origen = 1 Then
            cb_activo.Visible = False
            bt_Agregar.Visible = True
            bt_guardar.Visible = False

        End If

        ' MODIFICACION
        If id_origen = 2 Then
            ' bloqueo los botones que no uso
            bt_Agregar.Visible = False
            bt_guardar.Visible = True
            ' almacena la fila a modificar
            ll_id = w_consultar_usuario.dg_consulta_usuario.CurrentRow.Cells("id").Value





            Try
                Using conexion As New taller2Entities

                    Dim datos_usuario = (From s In conexion.usuario
                                         Where s.id_usuario = ll_id
                                         Select s).First
                    tb_DNI.Text = datos_usuario.dni
                    tb_DNI.Enabled = False
                    tb_Apellido.Text = datos_usuario.apellido
                    tb_Nombre.Text = datos_usuario.nombre
                    tb_Direccion.Text = datos_usuario.direccion
                    tb_Telefono.Text = datos_usuario.telefono
                    tb_Email.Text = datos_usuario.email
                    sn_activo = datos_usuario.sn_activo
                    tb_nombre_usuario.Text = datos_usuario.us_login
                    tb_contraseña.Text = datos_usuario.us_pass
                    cb_tipo.Text = datos_usuario.us_descrip

                End Using



            Catch ex As Exception
                'MessageBox.Show("Error al acceder a los datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If


    End Sub

    Private Sub bt_Agregar_Click(sender As Object, e As EventArgs) Handles bt_Agregar.Click
        If cb_activo.Checked = True Then
            sn_activo = "S"
        Else
            sn_activo = "N"
        End If
        Dim ll_tel As Long

        If tb_DNI.Text = "" Then
            MessageBox.Show("Complete DNI", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_DNI.BackColor = Color.AntiqueWhite
        ElseIf tb_Apellido.Text = "" Then
            MessageBox.Show("Complete APELLIDO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_Apellido.BackColor = Color.AntiqueWhite
        ElseIf tb_Nombre.Text = "" Then
            MessageBox.Show("Complete NOMBRE", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_Nombre.BackColor = Color.AntiqueWhite
        ElseIf tb_Telefono.Text = "" Then
            MessageBox.Show("Complete TELEFONO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_Telefono.BackColor = Color.AntiqueWhite
        ElseIf tb_Direccion.Text = "" Then
            MessageBox.Show("Complete DIRECCION", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_Direccion.BackColor = Color.AntiqueWhite
        ElseIf tb_nombre_usuario.Text = "" Then
            MessageBox.Show("Complete USUARIO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_nombre_usuario.BackColor = Color.AntiqueWhite
        ElseIf tb_contraseña.Text = "" Then
            MessageBox.Show("Complete CONTRASEÑA", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_contraseña.BackColor = Color.AntiqueWhite

        Else
            tb_DNI.BackColor = Color.White
            tb_Apellido.BackColor = Color.White
            tb_Nombre.BackColor = Color.White
            tb_Telefono.BackColor = Color.White
            tb_Direccion.BackColor = Color.White
            tb_nombre_usuario.BackColor = Color.White
            tb_contraseña.BackColor = Color.White

            If tb_Telefono.Text = "" Then
                tb_Telefono.Text = 0
            End If

            If usuario.verificar_dni(tb_DNI.Text) <> 1 Then
                MessageBox.Show("El DNI ya fue REGISTRADO", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf usuario.verificar_nombre_de_usuario(tb_nombre_usuario.Text) <> 1 Then

                MessageBox.Show("El nombre de usuario ya esta en uso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                ll_tel = CType(tb_Telefono.Text, Long)


                'Pregunta si desea agregar un nuevo usuario'

                If cb_tipo.SelectedItem.ToString = "ADMINISTRADOR" Then
                    ls_tipo = "A"
                ElseIf cb_tipo.SelectedItem.ToString = "SUPERVISOR" Then
                    ls_tipo = "S"
                Else
                    ls_tipo = "V"
                End If
                If MessageBox.Show("¿Desea agregar un nuevo usuario?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

                    Try
                        Using bd As New taller2Entities
                            Dim bd_usuario As New usuario
                            bd_usuario.us_login = tb_nombre_usuario.Text
                            bd_usuario.us_pass = tb_contraseña.Text
                            bd_usuario.us_tipo = ls_tipo
                            bd_usuario.us_descrip = cb_tipo.SelectedItem.ToString()
                            bd_usuario.dni = tb_DNI.Text
                            bd_usuario.apellido = tb_Apellido.Text
                            bd_usuario.nombre = tb_Nombre.Text
                            bd_usuario.direccion = tb_Direccion.Text
                            bd_usuario.telefono = ll_tel
                            bd_usuario.email = tb_Email.Text
                            bd_usuario.sn_activo = sn_activo

                            bd.usuario.Add(bd_usuario)
                            bd.SaveChanges()

                            MessageBox.Show("Usuario agregado con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            tb_DNI.Text = ""
                            tb_Apellido.Text = ""
                            tb_Nombre.Text = ""
                            tb_Telefono.Text = ""
                            tb_Direccion.Text = ""
                            tb_Email.Text = ""
                            tb_nombre_usuario.Text = ""
                            tb_contraseña.Text = ""
                            cb_tipo.SelectedValue = -1


                        End Using

                    Catch ex As Exception

                        MessageBox.Show("Error al acceder a los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try

                End If
            End If
        End If

    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim ll_tel As Long


        If cb_activo.Checked = True Then
            sn_activo = "S"
        Else
            sn_activo = "N"
        End If

        If MessageBox.Show("¿Seguro que desea guardar los Cambios?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Cancel Then
            Return
        Else


            If tb_Apellido.Text = "" Then
                MessageBox.Show("Complete APELLIDO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_Apellido.BackColor = Color.AntiqueWhite
                Return

            ElseIf tb_Nombre.Text = "" Then
                MessageBox.Show("Complete NOMBRE", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_Nombre.BackColor = Color.AntiqueWhite
                Return

            ElseIf tb_Telefono.Text = "" Then
                MessageBox.Show("Complete TELEFONO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_Telefono.BackColor = Color.AntiqueWhite
                Return

            ElseIf tb_Direccion.Text = "" Then
                MessageBox.Show("Complete DIRECCION", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_Direccion.BackColor = Color.AntiqueWhite
                Return

            ElseIf tb_nombre_usuario.Text = "" Then
                MessageBox.Show("Complete USUARIO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_nombre_usuario.BackColor = Color.AntiqueWhite
                Return

            ElseIf tb_contraseña.Text = "" Then
                MessageBox.Show("Complete CONTRASEÑA", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_contraseña.BackColor = Color.AntiqueWhite
                Return

            Else
                tb_Apellido.BackColor = Color.White
                tb_Nombre.BackColor = Color.White
                tb_Telefono.BackColor = Color.White
                tb_Direccion.BackColor = Color.White
                tb_nombre_usuario.BackColor = Color.White
                tb_contraseña.BackColor = Color.White

                If tb_Telefono.Text = "" Then
                    tb_Telefono.Text = 0
                End If

                ll_tel = CType(tb_Telefono.Text, Long)

            End If

            If cb_tipo.SelectedItem.ToString = "ADMINISTRADOR" Then
                ls_tipo = "A"
            ElseIf cb_tipo.SelectedItem.ToString = "SUPERVISOR" Then
                ls_tipo = "S"
            Else
                ls_tipo = "V"
            End If


            Try
                Using bd As New taller2Entities
                    Dim bd_usuario = (From a In bd.usuario Where a.id_usuario = ll_id Select a).First
                    bd_usuario.us_login = tb_nombre_usuario.Text
                    bd_usuario.us_pass = tb_contraseña.Text
                    bd_usuario.us_tipo = ls_tipo
                    bd_usuario.us_descrip = cb_tipo.SelectedItem.ToString()
                    bd_usuario.dni = tb_DNI.Text
                    bd_usuario.apellido = tb_Apellido.Text
                    bd_usuario.nombre = tb_Nombre.Text
                    bd_usuario.direccion = tb_Direccion.Text
                    bd_usuario.telefono = ll_tel
                    bd_usuario.email = tb_Email.Text
                    bd_usuario.sn_activo = sn_activo


                    bd.SaveChanges()


                    tb_Apellido.Text = ""
                    tb_Nombre.Text = ""
                    tb_Telefono.Text = ""
                    tb_Direccion.Text = ""
                    tb_Email.Text = ""


                End Using

                w_consultar_usuario.bt_quitar.PerformClick()
                Me.Close()
                MessageBox.Show("Los cambios han sido guardados con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error Al completar Los datos. Verifique", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End Try
        End If
    End Sub

    Private Sub cb_mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_mostrar.CheckedChanged
        If cb_mostrar.Checked = True Then
            tb_contraseña.PasswordChar = ""
        Else
            tb_contraseña.PasswordChar = "•"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(cb_tipo.SelectedItem.ToString())
    End Sub
End Class