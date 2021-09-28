Public Class w_agregar_actividad
    Public id_origen As Integer
    Dim ll_id As Long
    Dim sn_activo As Char
    Private Sub tb_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Nombre.KeyPress
        f_validar_form.Validar_letras(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_duracion.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_precio.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub bt_Cancelar_Click(sender As Object, e As EventArgs) Handles bt_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub w_agregar_actividad_load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' USUARIO NUEVO
        If id_origen = 1 Then
            bt_Agregar.Visible = True
            bt_guardar.Visible = False
            cb_activo.Visible = False
        End If


        ' MODIFICACION
        If id_origen = 2 Then
            ' bloqueo los botones que no uso
            bt_Agregar.Visible = False
            bt_guardar.Visible = True
            ' almacena la fila a modificar
            ll_id = w_consultar_actividad.dg_consulta_actividades.CurrentRow.Cells("id").Value

            Try
                Using conexion As New taller2Entities

                    Dim datos_actividades = (From s In conexion.actividades
                                             Where s.id_actividad = ll_id
                                             Select s).First

                    tb_Nombre.Text = datos_actividades.de_actividad
                    tb_duracion.Text = datos_actividades.duracion
                    tb_precio.Text = datos_actividades.pr_actividad
                    sn_activo = datos_actividades.sn_activo

                End Using



            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If





    End Sub

    Private Sub bt_Agregar_Click(sender As Object, e As EventArgs) Handles bt_Agregar.Click

        sn_activo = "S"

        If MessageBox.Show("Seguro desea agregar una nueva actividad", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Try
                Using con As New taller2Entities
                    Dim act = New actividades

                    If tb_Nombre.Text = "" Then
                        MessageBox.Show("Complete Nombre de la actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        tb_Nombre.BackColor = Color.AntiqueWhite
                    ElseIf tb_duracion.Text = "" Then
                        MessageBox.Show("Complete Duracion de la actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        tb_duracion.BackColor = Color.AntiqueWhite
                    ElseIf tb_precio.Text = "" Then
                        MessageBox.Show("Complete Precio de la actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        tb_precio.BackColor = Color.AntiqueWhite
                    End If


                    act.de_actividad = tb_Nombre.Text
                    act.duracion = tb_duracion.Text
                    act.pr_actividad = tb_precio.Text
                    act.sn_activo = sn_activo

                    con.actividades.Add(act)
                    con.SaveChanges()

                    MessageBox.Show("Actividad agregada con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    tb_Nombre.Text = ""
                    tb_duracion.Text = ""
                    tb_precio.Text = ""

                End Using

            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        If cb_activo.Checked = True Then
            sn_activo = "S"
        Else
            sn_activo = "N"
        End If

        If MessageBox.Show("Seguro desea guardar los nuevos cambios?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Return
        Else

            Try
                Using con As New taller2Entities
                    Dim act = New actividades

                    If tb_Nombre.Text = "" Then
                        MessageBox.Show("Complete Nombre de la actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        tb_Nombre.BackColor = Color.AntiqueWhite
                    ElseIf tb_duracion.Text = "" Then
                        MessageBox.Show("Complete Duracion de la actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        tb_duracion.BackColor = Color.AntiqueWhite
                    ElseIf tb_precio.Text = "" Then
                        MessageBox.Show("Complete Precio de la actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        tb_precio.BackColor = Color.AntiqueWhite
                    Else
                        tb_Nombre.BackColor = Color.White
                        tb_duracion.BackColor = Color.White
                        tb_precio.BackColor = Color.White
                    End If



                    act.de_actividad = tb_Nombre.Text
                    act.duracion = tb_duracion.Text
                    act.pr_actividad = tb_precio.Text
                    act.sn_activo = sn_activo

                    con.SaveChanges()



                    tb_Nombre.Text = ""
                    tb_duracion.Text = ""
                    tb_precio.Text = ""

                End Using

                MessageBox.Show("Los cambios han sido guardados con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                w_consultar_actividad.bt_quitar.PerformClick()
                Me.Close()


            Catch ex As Exception

            End Try
        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w_consultar_actividad.Show()
        Me.Close()
    End Sub
End Class