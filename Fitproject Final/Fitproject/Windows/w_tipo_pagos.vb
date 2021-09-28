Public Class w_tipo_pagos
    Dim tipos As New c_tipoPago
    Private Sub w_tipo_pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipos.MostrarTipos(dg_tipos)
    End Sub

    Private Sub bt_cerrar_Click(sender As Object, e As EventArgs) Handles bt_cerrar.Click
        Me.Close()
    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        Dim descrip As New c_tipoPago(tb_agregar.Text)
        If descrip.Agregar() = True Then
            tb_agregar.Text = ""
            MessageBox.Show("Se agrego un NUEVO tipo de pago", "Descripción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tipos.MostrarTipos(dg_tipos)
        End If
    End Sub

    Private Sub tb_agregar_TextChanged(sender As Object, e As EventArgs) Handles tb_agregar.TextChanged

    End Sub
End Class