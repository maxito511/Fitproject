Public Class w_consultar_pago
    Dim pago As New c_factura
    Private Sub w_consultar_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pago.MostrarPagos(dg_pago)
    End Sub

    Private Sub bt_cerrar_Click(sender As Object, e As EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If rb_dni.Checked = True Then
            pago.Filtrar_dni(dg_pago, TextBox1.Text)
        ElseIf rb_nomyape.Checked = True Then
            pago.Filtrar_nomyape(dg_pago, TextBox1.Text)
        ElseIf rb_tipo.Checked = True Then
            pago.Filtrar_nomyape(dg_pago, TextBox1.Text)
        End If
    End Sub

    Private Sub bt_quitar_Click(sender As Object, e As EventArgs) Handles bt_quitar.Click
        TextBox1.Text = ""
        pago.MostrarPagos(dg_pago)
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        If rb_fecha.Checked = True Then
            pago.filtrar_fe_pago(dg_pago, dt_desde.Value.Date, dt_hasta.Value.Date)
        End If
    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click
        w_pago.Show()
        Me.Close()
    End Sub
End Class