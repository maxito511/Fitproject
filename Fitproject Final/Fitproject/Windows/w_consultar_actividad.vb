Public Class w_consultar_actividad
    Dim actividad As New c_actividades
    Private Sub bt_Cerrar_Click(sender As Object, e As EventArgs) Handles bt_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub w_consultar_actividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_actividad.Checked = True
        actividad.MostrarActividades(dg_consulta_actividades)
    End Sub

    Private Sub tb_Buscar_TextChanged(sender As Object, e As EventArgs) Handles tb_Buscar.TextChanged
        If rb_actividad.Checked = True Then
            actividad.FiltroActividad(dg_consulta_actividades, tb_Buscar.Text)
        ElseIf rb_entrenador.Checked = True Then
            actividad.FiltroEntrenador(dg_consulta_actividades, tb_Buscar.Text)
        End If
    End Sub

    Private Sub rb_actividad_CheckedChanged(sender As Object, e As EventArgs) Handles rb_actividad.CheckedChanged
        If rb_actividad.Checked = True Then
            bt_filtrar.Enabled = False
            tb_desde.Enabled = False
            tb_hasta.Enabled = False
            tb_Buscar.Enabled = True
        End If
    End Sub

    Private Sub rb_entrenador_CheckedChanged(sender As Object, e As EventArgs) Handles rb_entrenador.CheckedChanged
        If rb_entrenador.Checked = True Then
            bt_filtrar.Enabled = False
            tb_desde.Enabled = False
            tb_hasta.Enabled = False
            tb_Buscar.Enabled = True
        End If
    End Sub

    Private Sub rb_horas_CheckedChanged(sender As Object, e As EventArgs) Handles rb_horas.CheckedChanged
        If rb_horas.Checked = True Then
            bt_filtrar.Enabled = True
            tb_desde.Enabled = True
            tb_hasta.Enabled = True
            tb_Buscar.Enabled = False
        End If
    End Sub

    Private Sub rb_precio_CheckedChanged(sender As Object, e As EventArgs) Handles rb_precio.CheckedChanged
        If rb_precio.Checked = True Then
            bt_filtrar.Enabled = True
            tb_desde.Enabled = True
            tb_hasta.Enabled = True
            tb_Buscar.Enabled = False
        End If
    End Sub

    Private Sub bt_quitar_Click(sender As Object, e As EventArgs) Handles bt_quitar.Click
        tb_desde.Text = ""
        tb_hasta.Text = ""
        tb_Buscar.Text = ""
        actividad.MostrarActividades(dg_consulta_actividades)
    End Sub

    Private Sub bt_filtrar_Click(sender As Object, e As EventArgs) Handles bt_filtrar.Click
        If tb_desde.Text <> "" Or tb_hasta.Text <> "" Then
            If rb_precio.Checked = True Then
                actividad.FiltroPrecio(dg_consulta_actividades, tb_desde.Text, tb_hasta.Text)
            ElseIf rb_horas.Checked = True Then
                actividad.FiltroHora(dg_consulta_actividades, tb_desde.Text, tb_hasta.Text)
            End If

        Else
            MessageBox.Show("Error, Existe una campo vacio", "Error al Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

    End Sub

    Private Sub tb_desde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_desde.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub tb_hasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_hasta.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub bt_Nuevo_Click(sender As Object, e As EventArgs) Handles bt_Nuevo.Click
        w_agregar_actividad.id_origen = 1
        w_agregar_actividad.Show()
        Me.Close()
    End Sub

    Private Sub bt_Modificar_Click(sender As Object, e As EventArgs) Handles bt_Modificar.Click
        w_agregar_actividad.id_origen = 2   'Modificacion
        w_agregar_actividad.Show()
    End Sub

    Private Sub dg_consulta_actividades_DoubleClick(sender As Object, e As EventArgs) Handles dg_consulta_actividades.DoubleClick
        Me.bt_Modificar.PerformClick()
    End Sub

    Private Sub cb_ver_todos_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ver_todos.CheckedChanged
        If cb_ver_todos.Checked = True Then
            actividad.MostrarActividadesTodas(dg_consulta_actividades)
        Else
            actividad.MostrarActividades(dg_consulta_actividades)
        End If
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        Dim ll_id As Long = dg_consulta_actividades.CurrentRow.Cells("id").Value
        Try
            Using bd As New taller2Entities
                If MessageBox.Show("¿Seguro desea eliminar la actividad?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Dim bd_actividad = (From a In bd.actividades Where a.id_actividad = ll_id Select a).First
                    bd_actividad.sn_activo = "N"
                    bd.SaveChanges()
                    MessageBox.Show("Actividad eliminada con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception

            MessageBox.Show("Error Al eliminar la actividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        actividad.MostrarActividades(dg_consulta_actividades)
    End Sub

End Class