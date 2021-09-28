Public Class w_consultar_usuario

    Dim usuario As New c_usuarios
    Private Sub bt_Cerrar_Click(sender As Object, e As EventArgs) Handles bt_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub tb_Buscar_TextChanged(sender As Object, e As EventArgs) Handles tb_Buscar.TextChanged
        If rb_dni.Checked Then
            usuario.Filtrar_dni(dg_consulta_usuario, tb_Buscar.Text)
        ElseIf rb_nombre_usuario.Checked Then
            usuario.Filtrar_nombre_de_usuario(dg_consulta_usuario, tb_Buscar.Text)
        End If
    End Sub

    Private Sub w_consultar_entrenador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuario.MostrarUsuarios(dg_consulta_usuario)
    End Sub

    Private Sub bt_quitar_Click(sender As Object, e As EventArgs) Handles bt_quitar.Click
        tb_Buscar.Text = ""
        usuario.MostrarUsuarios(dg_consulta_usuario)
    End Sub

    Private Sub bt_Nuevo_Click(sender As Object, e As EventArgs) Handles bt_Nuevo.Click
        w_agregar_usuario.id_origen = 1
        w_agregar_usuario.Show()
        Me.Close()
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        Dim ll_id As Long = dg_consulta_usuario.CurrentRow.Cells("id").Value
        Try
            Using bd As New taller2Entities
                If MessageBox.Show("¿Seguro desea eliminar el usuario?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Dim bd_usuario = (From a In bd.usuario Where a.id_usuario = ll_id Select a).First
                    bd_usuario.sn_activo = "N"
                    bd.SaveChanges()
                    MessageBox.Show("Usuario eliminado con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception

            MessageBox.Show("Error Al eliminar el Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        usuario.MostrarUsuarios(dg_consulta_usuario)
    End Sub

    Private Sub bt_Modificar_Click(sender As Object, e As EventArgs) Handles bt_Modificar.Click
        w_agregar_usuario.id_origen = 2   'Modificacion
        w_agregar_usuario.Show()
    End Sub

    Private Sub dg_consulta_usuario_DoubleClick(sender As Object, e As EventArgs) Handles dg_consulta_usuario.DoubleClick
        Me.bt_Modificar.PerformClick()
    End Sub

    Private Sub cb_ver_todos_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ver_todos.CheckedChanged
        If cb_ver_todos.Checked = True Then
            usuario.MostrarUsuarioTodos(dg_consulta_usuario)
        Else
            usuario.MostrarUsuarios(dg_consulta_usuario)
        End If
    End Sub




End Class