Public Class w_parametros

    Public id_origen As Integer


    Private Sub bt_cerrar_Click(sender As Object, e As EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub

    Private Sub tb_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nombre.KeyPress
        f_validar_form.Validar_letras(e)
    End Sub

    Private Sub tb_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_telefono.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub tb_cuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cuit.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub tb_localidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_localidad.KeyPress
        f_validar_form.Validar_letras(e)
    End Sub

    Private Sub tb_provincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_provincia.KeyPress
        f_validar_form.Validar_letras(e)
    End Sub

    Private Sub tb_email_Leave(sender As Object, e As EventArgs) Handles tb_email.Leave
        If tb_email.Text <> "" And (f_validar_form.Valida_email(tb_email.Text) = False) Then
            MessageBox.Show("Email Invalido.", "")
            tb_email.Focus()
        End If

    End Sub

    Private Sub w_parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' parametros actuales

        If id_origen = 1 Then
            bt_guardar.Enabled = False
            tb_nombre.Enabled = False
            tb_direccion.Enabled = False
            tb_telefono.Enabled = False
            tb_cuit.Enabled = False
            tb_localidad.Enabled = False
            tb_provincia.Enabled = False
            tb_web.Enabled = False
            tb_email.Enabled = False
            tb_user.Enabled = False
            tb_pass.Enabled = False
            cb_ver.Enabled = False



            Try
                Using conexion As New taller2Entities


                    Dim datos_parametros = (From s In conexion.empresa
                                            Select s).First

                    tb_cuit.Text = datos_parametros.id_cuit
                    tb_nombre.Text = datos_parametros.nombre
                    tb_telefono.Text = datos_parametros.telefono
                    tb_direccion.Text = datos_parametros.direccion
                    tb_localidad.Text = datos_parametros.localidad
                    tb_provincia.Text = datos_parametros.provincia
                    tb_web.Text = datos_parametros.web
                    tb_email.Text = datos_parametros.email
                    tb_user.Text = datos_parametros.us_login
                    tb_pass.Text = datos_parametros.us_pass

                End Using



            Catch ex As Exception

            End Try


        End If

        ' MODIFICACION de parametros
        If id_origen = 2 Then





            Try
                Using conexion As New taller2Entities

                    Dim datos_parametros = (From s In conexion.empresa
                                            Select s).First

                    tb_cuit.Text = datos_parametros.id_cuit
                    tb_nombre.Text = datos_parametros.nombre
                    tb_telefono.Text = datos_parametros.telefono
                    tb_direccion.Text = datos_parametros.direccion
                    tb_localidad.Text = datos_parametros.localidad
                    tb_provincia.Text = datos_parametros.provincia
                    tb_web.Text = datos_parametros.web
                    tb_email.Text = datos_parametros.email
                    tb_user.Text = datos_parametros.us_login
                    tb_pass.Text = datos_parametros.us_pass

                End Using



            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub bt_modificar_Click(sender As Object, e As EventArgs) Handles bt_modificar.Click
        id_origen = 2
        bt_guardar.Enabled = True
        bt_modificar.Enabled = False
        bt_guardar.Enabled = True
        tb_nombre.Enabled = True
        tb_direccion.Enabled = True
        tb_telefono.Enabled = True
        tb_cuit.Enabled = True
        tb_localidad.Enabled = True
        tb_provincia.Enabled = True
        tb_web.Enabled = True
        tb_email.Enabled = True
        tb_user.Enabled = True
        tb_pass.Enabled = True
        cb_ver.Enabled = True


    End Sub


    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        Dim ll_tel As Long

        If tb_cuit.Text = "" Then
            MessageBox.Show("Complete CUIT", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_cuit.BackColor = Color.AntiqueWhite
        ElseIf tb_nombre.Text = "" Then
            MessageBox.Show("Complete NOMBRE", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_nombre.BackColor = Color.AntiqueWhite
        ElseIf tb_telefono.Text = "" Then
            MessageBox.Show("Complete TELEFONO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_telefono.BackColor = Color.AntiqueWhite
        ElseIf tb_direccion.Text = "" Then
            MessageBox.Show("Complete DIRECCION", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_direccion.BackColor = Color.AntiqueWhite
        ElseIf tb_localidad.Text = "" Then
            MessageBox.Show("Complete LOCALIDAD", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_localidad.BackColor = Color.AntiqueWhite
        ElseIf tb_provincia.Text = "" Then
            MessageBox.Show("Complete PROVINCIA", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_provincia.BackColor = Color.AntiqueWhite
        ElseIf tb_web.Text = "" Then
            MessageBox.Show("Complete WEB", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_web.BackColor = Color.AntiqueWhite
        ElseIf tb_email.Text = "" Then
            MessageBox.Show("Complete EMAIL", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_email.BackColor = Color.AntiqueWhite
        ElseIf tb_pass.Text = "" Then
            MessageBox.Show("Complete CONTRASEÑA", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_pass.BackColor = Color.AntiqueWhite

        Else
            tb_cuit.BackColor = Color.White
            tb_nombre.BackColor = Color.White
            tb_telefono.BackColor = Color.White
            tb_direccion.BackColor = Color.White
            tb_localidad.BackColor = Color.White
            tb_provincia.BackColor = Color.White
            tb_web.BackColor = Color.White
            tb_email.BackColor = Color.White
            tb_user.BackColor = Color.White
            tb_pass.BackColor = Color.White


            ll_tel = CType(tb_telefono.Text, Long)


            'Pregunta si desea Guardar los Cambios'

            If MessageBox.Show("¿Desea guardar los cambios realizados?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Try
                    Using bd As New taller2Entities

                        Dim bd_empresa = (From q In bd.empresa
                                          Select q).First

                        bd_empresa.id_cuit = tb_cuit.Text
                        bd_empresa.nombre = tb_nombre.Text
                        bd_empresa.direccion = tb_direccion.Text
                        bd_empresa.telefono = ll_tel
                        bd_empresa.email = tb_email.Text
                        bd_empresa.localidad = tb_localidad.Text
                        bd_empresa.provincia = tb_provincia.Text
                        bd_empresa.web = tb_web.Text
                        bd_empresa.us_login = tb_user.Text
                        bd_empresa.us_pass = tb_pass.Text

                        'bd.empresa.Add(bd_empresa)   si agrega como nuevo tira al catch
                        bd.SaveChanges()

                        MessageBox.Show("Parametros modificados con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        tb_cuit.Text = bd_empresa.id_cuit
                        tb_nombre.Text = bd_empresa.nombre
                        tb_telefono.Text = bd_empresa.telefono
                        tb_direccion.Text = bd_empresa.direccion
                        tb_email.Text = bd_empresa.email
                        tb_localidad.Text = bd_empresa.localidad
                        tb_provincia.Text = bd_empresa.provincia
                        tb_web.Text = bd_empresa.web
                        tb_user.Text = bd_empresa.us_login
                        tb_pass.Text = bd_empresa.us_pass
                        bt_guardar.Enabled = False
                        bt_modificar.Enabled = True
                        tb_nombre.Enabled = False
                        tb_direccion.Enabled = False
                        tb_telefono.Enabled = False
                        tb_cuit.Enabled = False
                        tb_localidad.Enabled = False
                        tb_provincia.Enabled = False
                        tb_web.Enabled = False
                        tb_email.Enabled = False
                        tb_user.Enabled = False
                        tb_pass.Enabled = False
                        cb_ver.Enabled = False

                    End Using


                Catch ex As Exception

                    MessageBox.Show("Error al acceder a los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try

            End If
        End If

    End Sub

    Private Sub cb_ver_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ver.CheckedChanged
        If cb_ver.Checked = True Then
            tb_pass.PasswordChar = ""
        Else
            tb_pass.PasswordChar = "•"
        End If
    End Sub

End Class