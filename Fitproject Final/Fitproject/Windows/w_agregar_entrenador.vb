Public Class w_agregar_entrenador

    Dim entrenador As New c_entrenador
    Public id_origen As Integer
    Dim ll_dni As Long
    Dim sn_activo As Char
    Dim modifico As Boolean = False ' utilizo para ver si se agrego una foto o no para que no se pise
    Dim act As New c_actividades
    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.


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

    Private Sub bt_Cancelar_Click(sender As Object, e As EventArgs) Handles bt_salir.Click
        If tb_DNI.Text <> "" Or tb_Apellido.Text <> "" Or tb_Nombre.Text <> "" Or tb_Telefono.Text <> "" Then
            Dim result As Integer
            result = MessageBox.Show("¿Seguro desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If result = 6 Then
                Me.Close()

            Else
                Return
            End If
        Else
            Me.Close()
        End If


    End Sub

    Private Sub bt_consultar_entrenadores_Click(sender As Object, e As EventArgs) Handles bt_consultar_entrenadores.Click
        w_consultar_entrenador.Show()
        Me.Close()
    End Sub

    Private Sub w_agregar_entrenador_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' USUARIO NUEVO
        If id_origen = 1 Then
            act.MostrarActividades_clb(lb_actividades)
            cb_activo.Visible = False
            bt_Agregar.Visible = True
            bt_guardar.Visible = False
        End If

        ' MODIFICACION
        If id_origen = 2 Then
            Dim ls_de_actividad As String
            Dim li_idact As Integer
            ' bloqueo los botones que no uso
            bt_Agregar.Visible = False
            bt_guardar.Visible = True
            ' almacena la fila a modificar
            ll_dni = w_consultar_entrenador.dg_consulta_entrenador.CurrentRow.Cells("dni").Value


            'Cargo las actividades en el listbox
            act.MostrarActividades_clb(lb_actividades)



            Try
                Using conexion As New taller2Entities

                    Dim datos_entrenador = (From s In conexion.entrenadores
                                            Where s.dni = ll_dni
                                            Select s).First

                    tb_DNI.Text = datos_entrenador.dni
                    tb_DNI.Enabled = False
                    tb_Apellido.Text = datos_entrenador.apellido
                    tb_Nombre.Text = datos_entrenador.nombre
                    tb_Direccion.Text = datos_entrenador.direccion
                    tb_Telefono.Text = datos_entrenador.telefono
                    tb_Email.Text = datos_entrenador.email
                    date_nac.Value = datos_entrenador.fe_nacimiento
                    sn_activo = datos_entrenador.sn_activo

                    If datos_entrenador.sexo = "F" Then rb_mujer.Checked = True

                    'For i = 0 To lb_actividades.Items.Count - 1
                    '    ls_de_actividad = lb_actividades.Items(i)
                    '    Dim result = (From s In conexion.socios
                    '                  Where s.dni = ll_dni
                    '                  From a In s.actividades
                    '                  Where a.de_actividad = ls_de_actividad
                    '                  )
                    '    lb_actividades.SetSelected(i, True)
                    'Next

                End Using



            Catch ex As Exception
                'MessageBox.Show("No se encontro imagen", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        Dim resultado As Integer

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

        ElseIf lb_actividades.SelectedItems.Count = 0 Then
            MessageBox.Show("Seleccione una actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            tb_DNI.BackColor = Color.White
            tb_Apellido.BackColor = Color.White
            tb_Nombre.BackColor = Color.White
            tb_Telefono.BackColor = Color.White
            tb_Direccion.BackColor = Color.White

            If tb_Telefono.Text = "" Then
                tb_Telefono.Text = 0
            End If

            If entrenador.verificar_dni(tb_DNI.Text) <> 1 Then
                MessageBox.Show("El DNI ya fue REGISTRADO", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim sex As Char
                If rb_hombre.Checked = True Then
                    sex = "M"
                Else
                    sex = "F"
                End If

                ll_tel = CType(tb_Telefono.Text, Long)


                'Pregunta si desea agregar un nuevo entrenador'

                If MessageBox.Show("¿Desea agregar un nuevo entrenador?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

                    Try
                        Using bd As New taller2Entities
                            Dim bd_entrenador As New entrenadores
                            bd_entrenador.dni = tb_DNI.Text
                            bd_entrenador.apellido = tb_Apellido.Text
                            bd_entrenador.nombre = tb_Nombre.Text
                            bd_entrenador.direccion = tb_Direccion.Text
                            bd_entrenador.telefono = ll_tel
                            bd_entrenador.email = tb_Email.Text
                            bd_entrenador.fe_nacimiento = date_nac.Value
                            bd_entrenador.sexo = sex
                            bd_entrenador.sn_activo = sn_activo

                            Dim ls_de_actividad As String

                            For i = 0 To lb_actividades.SelectedItems.Count - 1
                                ls_de_actividad = lb_actividades.SelectedItems(i)
                                resultado = act.idActividades_lb(ls_de_actividad)
                                bd_entrenador.actividades.Add((From a In bd.actividades Where a.id_actividad = resultado Select a).First)

                            Next


                            bd.entrenadores.Add(bd_entrenador)
                            bd.SaveChanges()

                            MessageBox.Show("Entrenador agregado con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            tb_DNI.Text = ""
                            tb_Apellido.Text = ""
                            tb_Nombre.Text = ""
                            tb_Telefono.Text = ""
                            tb_Direccion.Text = ""
                            tb_Email.Text = ""
                            date_nac.Value = Date.Now
                            lb_actividades.ClearSelected()
                            rb_mujer.Checked = False
                            rb_hombre.Checked = True

                        End Using

                    Catch ex As Exception

                        MessageBox.Show("Error al acceder a los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try

                End If
            End If
        End If

    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim sex As Char
        Dim ll_tel As Long
        Dim resultado As Integer

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

            ElseIf tb_nombre.Text = "" Then
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

            ElseIf lb_actividades.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione una actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return

            Else
                tb_Apellido.BackColor = Color.White
                tb_Nombre.BackColor = Color.White
                tb_Telefono.BackColor = Color.White
                tb_Direccion.BackColor = Color.White

                If rb_hombre.Checked = True Then
                    sex = "M"
                Else
                    sex = "F"
                End If

                If tb_Telefono.Text = "" Then
                    tb_Telefono.Text = 0
                End If

                ll_tel = CType(tb_Telefono.Text, Long)

            End If



            Try
                Using bd As New taller2Entities
                    Dim bd_entrenador = (From a In bd.entrenadores Where a.dni = ll_dni Select a).First
                    bd_entrenador.dni = tb_DNI.Text
                    bd_entrenador.apellido = tb_Apellido.Text
                    bd_entrenador.nombre = tb_Nombre.Text
                    bd_entrenador.direccion = tb_Direccion.Text
                    bd_entrenador.telefono = ll_tel
                    bd_entrenador.email = tb_Email.Text
                    bd_entrenador.fe_nacimiento = date_nac.Value
                    bd_entrenador.sexo = sex
                    bd_entrenador.sn_activo = sn_activo


                    Dim ls_de_actividad As String

                    bd_entrenador.actividades.Clear()

                    For i = 0 To lb_actividades.SelectedItems.Count - 1
                        ls_de_actividad = lb_actividades.SelectedItems(i)
                        resultado = act.idActividades_lb(ls_de_actividad)
                        bd_entrenador.actividades.Add((From a In bd.actividades Where a.id_actividad = resultado Select a).First)
                    Next

                    bd.SaveChanges()

                    tb_Apellido.Text = ""
                    tb_Nombre.Text = ""
                    tb_Telefono.Text = ""
                    tb_Direccion.Text = ""
                    tb_Email.Text = ""
                    lb_actividades.ClearSelected()

                End Using

                If Me.id_origen = 2 Then w_consultar_entrenador.dg_actividades_entrenador.ClearSelection()
                w_consultar_entrenador.bt_quitar.PerformClick()
                Me.Close()
                MessageBox.Show("Los cambios han sido guardados con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error Al completar Los datos. Verifique", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End Try
        End If
    End Sub

End Class