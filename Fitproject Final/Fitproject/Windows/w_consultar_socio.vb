Public Class w_consultar_socio
    Dim socio As New c_socio
    Dim dv As DataView
    Private Sub w_consultar_socio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        socio.MostrarSocio(dg_consulta_socio)
    End Sub


    Private Sub bt_quitar_Click(sender As Object, e As EventArgs) Handles bt_quitar.Click
        tb_buscar.Text = ""
        socio.MostrarSocio(dg_consulta_socio)
    End Sub

    Private Sub tb_buscar_TextChanged(sender As Object, e As EventArgs) Handles tb_buscar.TextChanged
        If rb_dni.Checked Then
            socio.Filtrar_dni(dg_consulta_socio, tb_buscar.Text)
        ElseIf rb_apeynom.Checked Then
            socio.Filtrar_nomyape(dg_consulta_socio, tb_buscar.Text)
        End If
    End Sub

    Private Sub tb_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_buscar.KeyPress
        If rb_dni.Checked Then
            f_validar_form.Validar_numeros(e)
        ElseIf rb_apeynom.Checked Then
            f_validar_form.Validar_letras(e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub dg_consulta_socio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_consulta_socio.CellClick
        Dim ll_id As Long = dg_consulta_socio.CurrentRow.Cells("id").Value

        'If dg_consulta_socio.Columns(e.ColumnIndex).Name = "actividades" Then
        Try
            Using bd As New taller2Entities
                ' consulta para cargar las actividades 
                Dim act = (From s In bd.socios
                           Where s.id_socio = ll_id
                           From a In s.actividades
                           Select New With {
                                             a.de_actividad
                                            }).ToList
                dg_act_socio.DataSource = act
                ' consulta para cargar el picture box
                Dim pb = (From s In bd.socios
                          Where s.id_socio = ll_id
                          Select s.imagen).First
                ' convertimo el valor en byte
                Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(pb, Byte()) 'Conbertimos la imagen cargada en el datatable a Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
                    pb_socio.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    pb_socio.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                pb_socio.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.

            End Using
        Catch ex As Exception

            End Try
        dg_act_socio.ClearSelection()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        w_agregar_socio.id_origen = 1
        w_agregar_socio.Show()
        Me.Close()
    End Sub

    Private Sub bt_modificar_Click(sender As Object, e As EventArgs) Handles bt_modificar.Click
        w_agregar_socio.id_origen = 2 ' MODIFICACION
        w_agregar_socio.Show()
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        Dim ll_id As Long = dg_consulta_socio.CurrentRow.Cells("id").Value
        Try
            Using bd As New taller2Entities
                If MessageBox.Show("¿Seguro desea eliminar el socio?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Dim bd_socio = (From a In bd.socios Where a.id_socio = ll_id Select a).First
                    bd_socio.sn_activo = "N"
                    bd.SaveChanges()
                    MessageBox.Show("Socio eliminado con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception

            MessageBox.Show("Error Al eliminar el Socios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        socio.MostrarSocio(dg_consulta_socio)
    End Sub

    Private Sub bt_update_Click(sender As Object, e As EventArgs) Handles bt_update.Click
        ' ACTUALIZO LOS SOCIOS
        socio.MostrarSocio(dg_consulta_socio)

        Dim ll_id As Long = dg_consulta_socio.CurrentRow.Cells("id").Value

        ' ACTUALIZO LAS ACTIVIDADES 
        Try
            Using bd As New taller2Entities
                ' consulta para cargar las actividades 
                Dim act = (From s In bd.socios
                           Where s.id_socio = ll_id
                           From a In s.actividades
                           Select New With {
                                             a.de_actividad
                                            }).ToList
                dg_act_socio.DataSource = act
                ' consulta para cargar el picture box
                Dim pb = (From s In bd.socios
                          Where s.id_socio = ll_id
                          Select s.imagen).First
                ' convertimo el valor en byte
                Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                Dim imageBuffer() As Byte = CType(pb, Byte()) 'Conbertimos la imagen cargada en el datatable a Bytes.
                ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
                pb_socio.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                pb_socio.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                pb_socio.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.

            End Using
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dg_consulta_socio_DoubleClick(sender As Object, e As EventArgs) Handles dg_consulta_socio.DoubleClick
        Me.bt_modificar.PerformClick()
    End Sub

    Private Sub cb_todos_CheckedChanged(sender As Object, e As EventArgs) Handles cb_todos.CheckedChanged
        If cb_todos.Checked = True Then
            socio.MostrarSocioTodos(dg_consulta_socio)
        Else
            socio.MostrarSocio(dg_consulta_socio)
        End If
    End Sub

    'Private Sub bt_excel_Click(sender As Object, e As EventArgs) Handles bt_excel.Click
    '    Dim xlApp As Microsoft.Office.Interop.Excel.Application
    '    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    '    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
    '    Dim misValue As Object = System.Reflection.Missing.Value
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim k As Integer
    '    xlApp = New Microsoft.Office.Interop.Excel.Application
    '    xlWorkBook = xlApp.Workbooks.Add(misValue)
    '    xlWorkSheet = xlWorkBook.Sheets("sheet1")


    '    For i = 0 To dg_act_socio.RowCount - 1
    '        For j = 0 To dg_act_socio.ColumnCount - 1
    '            For k = 1 To dg_act_socio.Columns.Count
    '                xlWorkSheet.Cells(1, k) = dg_act_socio.Columns(k - 1).HeaderText
    '                xlWorkSheet.Cells(i + 2, j + 1) = dg_act_socio(j, i).Value
    '            Next
    '        Next
    '    Next
    'End Sub

End Class