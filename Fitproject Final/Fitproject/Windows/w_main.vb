Public Class w_main
    Dim sn_acceso
    Private Sub w_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Recibo el tipo de usuario
        If f_validar_login.is_tipo = "S" Then
            lb_main.Text = "SUPERVISOR"
            ParametrosToolStripMenuItem.Visible = False
        ElseIf f_validar_login.is_tipo = "V" Then
            lb_main.Text = "VENDEDOR"
            ParametrosToolStripMenuItem.Visible = False
            ToolStripMenuItem9.Visible = False
            ToolStripMenuItem12.Visible = False
            w_consultar_entrenador.bt_Nuevo.Enabled = False
            w_consultar_entrenador.bt_Modificar.Enabled = False
            w_consultar_entrenador.bt_eliminar.Enabled = False
            w_consultar_actividad.bt_Nuevo.Enabled = False
            w_consultar_actividad.bt_Modificar.Enabled = False
            w_consultar_actividad.bt_eliminar.Enabled = False
        Else
            lb_main.Text = "ADMINISTRADOR"
            ToolStripMenuItem4.Visible = False
            ToolStripMenuItem8.Visible = False
            ToolStripMenuItem11.Visible = False
            ToolStripMenuItem14.Visible = False

        End If

        ' es para poder cambiar el color
        Dim ctl As Control
        Dim ctlMDI As MdiClient


        For Each ctl In Me.Controls

        Next

        Try

            ctlMDI = CType(ctl, MdiClient)
            ctlMDI.BackColor = Me.BackColor


        Catch exc As InvalidCastException


        End Try
    End Sub

    Private Sub NuevoSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles  ToolStripMenuItem15.Click
        w_agregar_socio.MdiParent = Me
        w_agregar_socio.id_origen = 1
        w_agregar_socio.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        w_login.Close()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        w_consultar_socio.MdiParent = Me
        w_consultar_socio.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        w_agregar_entrenador.MdiParent = Me
        w_agregar_entrenador.id_origen = 1
        w_agregar_entrenador.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        w_consultar_entrenador.MdiParent = Me
        w_consultar_entrenador.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        w_agregar_actividad.MdiParent = Me
        w_agregar_actividad.id_origen = 1
        w_agregar_actividad.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        w_consultar_actividad.MdiParent = Me
        w_consultar_actividad.Show()
    End Sub

    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarUsuarioToolStripMenuItem.Click
        w_login.Show()
        Me.Close()
    End Sub

    Private Sub ConfigurarParametrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarParametrasToolStripMenuItem.Click
        w_parametros.MdiParent = Me
        w_parametros.id_origen = 1
        w_parametros.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        w_consultar_pago.MdiParent = Me
        w_consultar_pago.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        w_pago.MdiParent = Me
        w_pago.Show()
    End Sub

    Private Sub TipoDePagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDePagosToolStripMenuItem.Click
        w_tipo_pagos.MdiParent = Me
        w_tipo_pagos.Show()
    End Sub

    Private Sub nuevo_usuarioToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles nuevo_usuarioToolStripMenuItem17.Click
        w_agregar_usuario.MdiParent = Me
        w_agregar_usuario.id_origen = 1
        w_agregar_usuario.Show()
    End Sub

    Private Sub consulta_usuarioToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles consulta_usuarioToolStripMenuItem18.Click
        w_consultar_usuario.MdiParent = Me
        w_consultar_usuario.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        w_cierre_caja.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        w_acercade.MdiParent = Me
        w_acercade.Show()
    End Sub

    Private Sub CrearBackUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearBackUpToolStripMenuItem.Click
        w_acceso.MdiParent = Me
        w_acceso.Show()
    End Sub
End Class