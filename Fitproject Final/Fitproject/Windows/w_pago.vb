Public Class w_pago
    Dim pago As New c_factura
    Dim total As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub tb_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_buscar.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub tb_resto_KeyPress(sender As Object, e As KeyPressEventArgs)
        f_validar_form.Validar_numeros(e)
    End Sub

    Private Sub tb_efectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_efectivo.KeyPress
        f_validar_form.Validar_numeros(e)
        If e.KeyChar = Chr(13) Then

            e.Handled = True

        End If
    End Sub





    Private Sub bt_consultar_pagos_Click(sender As Object, e As EventArgs) Handles bt_consultar_pagos.Click
        w_consultar_pago.Show()
        Me.Close()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim fila As DataGridViewRow = New DataGridViewRow()

        If tb_buscar.Text <> "" Then
            If pago.MostrarDetalle_dni(dg_pago, tb_buscar.Text) = False Then
                bt_buscar.Enabled = True
            Else
                bt_buscar.Enabled = False
                For Each fila In dg_pago.Rows
                    total += Convert.ToDouble(fila.Cells("pr_actividad").Value)
                Next
                tb_total.Text = Convert.ToString(total)
                If tb_total.Text <> "" Then
                    tb_efectivo.Enabled = True
                End If
            End If
        End If

    End Sub



    Private Sub tb_efectivo_TextChanged(sender As Object, e As EventArgs) Handles tb_efectivo.TextChanged
        Dim ll_total As Decimal
        Dim ll_efectivo As Decimal



        If tb_efectivo.Text <> "" And tb_total.Text <> "" Then
            ll_efectivo = CType(tb_efectivo.Text, Decimal)
            ll_total = CType(tb_total.Text, Decimal)
            tb_cambio.Text = ll_efectivo - ll_total
        End If



    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim aux As Decimal

        If tb_total.Text = "" Then
            MessageBox.Show("Seleccione un socio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf tb_cambio.Text = "" Then
            MessageBox.Show("Ingrese el monto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf tb_total.Text <> "" And tb_efectivo.Text <> "" Or tb_efectivo.Text <> Nothing Then
            aux = CType(tb_cambio.Text, Decimal)
            If aux < 0 Then
                MessageBox.Show("Monto insuficiente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Dim id_socio As Integer = dg_pago.CurrentRow.Cells("id_socio").Value
                Dim fila As DataGridViewRow = New DataGridViewRow()
                ' Guardar Datos

                Try
                    Using bd As New taller2Entities
                        ' CABECERA
                        Dim bd_factura As New factura
                        bd_factura.id_socio = id_socio
                        bd_factura.fe_factura = Date.Today
                        bd_factura.fe_vencimiento = DateAdd(DateInterval.Day, 28, Date.Today)
                        bd_factura.id_tipo = 1
                        bd_factura.monto = total
                        bd.factura.Add(bd_factura)
                        bd.SaveChanges()
                        ' DETALLE
                        Dim li_factura = (From f In bd.factura
                                          Select f.id_factura).Max
                        Dim bd_factura_detalle As New factura_detalle

                        For Each fila In dg_pago.Rows
                            bd_factura_detalle.id_factura = li_factura
                            bd_factura_detalle.id_actividades = fila.Cells("id_actividad").Value
                            bd.factura_detalle.Add(bd_factura_detalle)
                            bd.SaveChanges()
                        Next



                        MessageBox.Show("Se registro el pago exitosamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Cargo las variables de la factura
                        w_comp.fecha = Date.Today
                        w_comp.id = id_socio
                        ' Reinicio la Ventana
                        w_reset.origen = "w_pago"
                        w_reset.sn_reset = "S"
                        Me.Close()
                        w_reset.Show()


                    End Using

                Catch ex As Exception

                    MessageBox.Show("Error al acceder a los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            End If
        End If
    End Sub


End Class