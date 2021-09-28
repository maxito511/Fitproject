Public Class w_acceso
    Public ii_acceso As Integer
    Private Sub bt_enviar_Click(sender As Object, e As EventArgs) Handles bt_enviar.Click
        If f_validar_login.ValidarAcceso(tb_pass.Text) > 0 Then
            w_backup.MdiParent = w_main
            w_backup.Show()
            Me.Close()
        Else
            tb_pass.Clear()
            MessageBox.Show("Acceso Denegado", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class