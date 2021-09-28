Public Class w_login
    Dim ls_tipo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub bt_ingresar_Click(sender As Object, e As EventArgs) Handles bt_ingresar.Click
        ' campos no vacios
        If tb_user.Text = "" Or tb_pass.Text = "" Then
            MessageBox.Show("Es necesario completar todos los campos", "INICIO DE SESIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' si existe usuario entra
        If f_validar_login.ValidarUsuario(tb_user.Text, tb_pass.Text) = 1 Then
            Me.Hide()
            w_main.Show()
            tb_pass.Clear()
        End If
    End Sub

    Private Sub tb_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_user.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else e.Handled = False
        End If
    End Sub

    Private Sub tb_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_pass.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else e.Handled = False
        End If
    End Sub


    Private Sub cb_mostrarpass_CheckedChanged(sender As Object, e As EventArgs) Handles cb_mostrarpass.CheckedChanged
        If cb_mostrarpass.Checked = True Then
            tb_pass.PasswordChar = ""
        Else
            tb_pass.PasswordChar = "•"
        End If


    End Sub

    Private Sub tb_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_pass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                bt_ingresar.PerformClick()
        End Select
    End Sub


End Class