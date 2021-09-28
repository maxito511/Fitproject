Public Class w_modificar_socio
    Dim act As New c_actividades
    Dim ll_dni As Long
    Private Sub w_modificar_socio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ls_de_actividad As String
        Dim ll_idact As Long

        ' almacena la fila a modificar
        ll_dni = w_consultar_socio.dg_consulta_socio.CurrentRow.Cells("dni").Value


        'Cargo las actividades en el listbox
        act.MostrarActividades_clb(lb_actividades)



        Try
            Using conexion As New taller2Entities

                Dim datos_socio = (From s In conexion.socios
                                   Where s.dni = ll_dni
                                   Select s).First


                tb_apellido.Text = datos_socio.apellido
                tb_nombre.Text = datos_socio.nombre
                tb_direccion.Text = datos_socio.direccion
                tb_telefono.Text = datos_socio.telefono
                tb_email.Text = datos_socio.email


                For i = 0 To lb_actividades.Items.Count - 1
                    ls_de_actividad = lb_actividades.Items(i)
                    Dim result = (From a In conexion.actividades Where a.de_actividad = ls_de_actividad Select a.id_actividad).First
                    ll_idact = result
                    If i + 1 = ll_idact Then
                        lb_actividades.SetSelected(i, True)
                    Else
                        lb_actividades.SetSelected(i, False)
                    End If

                Next

            End Using



        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        If MessageBox.Show("¿Seguro que desea cancelar?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    'AQUI ACTUALIZA LOS DATOS

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        Dim ll_tel As Long
        Dim resultado As Integer

        If MessageBox.Show("¿Seguro que desea guardar los Cambios?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then



        ElseIf tb_apellido.Text = "" Then
            MessageBox.Show("Complete APELLIDO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_apellido.BackColor = Color.AntiqueWhite

        ElseIf tb_nombre.Text = "" Then
            MessageBox.Show("Complete NOMBRE", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_nombre.BackColor = Color.AntiqueWhite

        ElseIf lb_actividades.SelectedItems.Count = 0 Then
            MessageBox.Show("Seleccione una actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            tb_apellido.BackColor = Color.White
            tb_nombre.BackColor = Color.White
            If tb_telefono.Text = "" Then
                tb_telefono.Text = 0
            End If

            ll_tel = CType(tb_telefono.Text, Long)

        End If


        Try
            Using bd As New taller2Entities

                Dim bd_socio = (From a In bd.socios Where a.dni = ll_dni Select a).First
                bd_socio.apellido = tb_apellido.Text
                bd_socio.nombre = tb_nombre.Text
                bd_socio.direccion = tb_direccion.Text
                bd_socio.telefono = ll_tel

                'Elimino las actividades para luego cargarlas
                bd_socio.actividades.Clear()

                'cargo las actividades
                Dim ls_de_actividad As String

                For i = 0 To lb_actividades.SelectedItems.Count - 1
                    ls_de_actividad = lb_actividades.SelectedItems(i)
                    resultado = act.idActividades_lb(ls_de_actividad)
                    bd_socio.actividades.Add((From a In bd.actividades Where a.id_actividad = resultado Select a).First)

                Next


                ' guardo los cambios
                bd.SaveChanges()

                MessageBox.Show("Los cambios han sido guardados con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                tb_apellido.Text = ""
                tb_nombre.Text = ""
                tb_telefono.Text = ""
                tb_direccion.Text = ""
                tb_email.Text = ""
                lb_actividades.ClearSelected()

                Me.Close()

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al acceder a los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




    End Sub
End Class