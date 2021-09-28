Public Class w_consultar_entrenador
    Dim entrenador As New c_entrenador
    Private Sub bt_Cerrar_Click(sender As Object, e As EventArgs) Handles bt_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub tb_Buscar_TextChanged(sender As Object, e As EventArgs) Handles tb_Buscar.TextChanged
        If rb_dni.Checked Then
            entrenador.Filtrar_dni(dg_consulta_entrenador, tb_Buscar.Text)
        ElseIf rb_apeynom.Checked Then
            entrenador.Filtrar_nomyape(dg_consulta_entrenador, tb_Buscar.Text)
        End If
    End Sub

    Private Sub w_consultar_entrenador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        entrenador.MostrarEntrenador(dg_consulta_entrenador)
    End Sub

    Private Sub bt_quitar_Click(sender As Object, e As EventArgs) Handles bt_quitar.Click
        tb_Buscar.Text = ""
        entrenador.MostrarEntrenador(dg_consulta_entrenador)
    End Sub

    Private Sub bt_Nuevo_Click(sender As Object, e As EventArgs) Handles bt_Nuevo.Click
        w_agregar_entrenador.id_origen = 1
        w_agregar_entrenador.Show()
        Me.Close()
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        Dim ll_id As Long = dg_consulta_entrenador.CurrentRow.Cells("id").Value
        Try
            Using bd As New taller2Entities
                If MessageBox.Show("¿Seguro desea eliminar el entrenador?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Dim bd_entrenador = (From a In bd.entrenadores Where a.id_entrenador = ll_id Select a).First
                    bd_entrenador.sn_activo = "N"
                    bd.SaveChanges()
                    MessageBox.Show("Entrenador eliminado con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception

            MessageBox.Show("Error Al eliminar el Entrenador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        entrenador.MostrarEntrenador(dg_consulta_entrenador)
    End Sub

    Private Sub bt_Modificar_Click(sender As Object, e As EventArgs) Handles bt_Modificar.Click
        w_agregar_entrenador.id_origen = 2   'Modificacion
        w_agregar_entrenador.Show()
    End Sub

    Private Sub dg_consulta_entrenador_DoubleClick(sender As Object, e As EventArgs) Handles dg_consulta_entrenador.DoubleClick
        Me.bt_Modificar.PerformClick()
    End Sub

    Private Sub dg_consulta_entrenador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_consulta_entrenador.CellClick
        Dim ll_id As Long = dg_consulta_entrenador.CurrentRow.Cells("id").Value

        Try
            Using bd As New taller2Entities
                ' consulta para cargar las actividades 
                Dim act = (From s In bd.entrenadores
                           Where s.id_entrenador = ll_id
                           From a In s.actividades
                           Select New With {
                                             a.de_actividad
                                            }).ToList
                dg_actividades_entrenador.DataSource = act
            End Using

        Catch ex As Exception

        End Try
        dg_actividades_entrenador.ClearSelection()

    End Sub

    Private Sub cb_ver_todos_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ver_todos.CheckedChanged
        If cb_ver_todos.Checked = True Then
            entrenador.MostrarEntrenadorTodos(dg_consulta_entrenador)
        Else
            entrenador.MostrarEntrenador(dg_consulta_entrenador)
        End If
    End Sub


End Class