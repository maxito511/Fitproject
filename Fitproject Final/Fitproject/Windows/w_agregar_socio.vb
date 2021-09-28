Public Class w_agregar_socio
    Public id_origen As Integer
    Dim ll_dni As Long
    Dim sn_activo As Char
    Dim modifico As Boolean = False ' utilizo para ver si se agrego una foto o no para que no se pise
    Dim socio As New c_socio
    Dim act As New c_actividades
    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream.

    ' DNI
    Private Sub tb_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_dni.KeyPress
        f_validar_form.Validar_numeros(e)
    End Sub

    ' APELLIDO
    Private Sub tb_ape_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ape.KeyPress
        f_validar_form.Validar_letras(e)

    End Sub

    ' NOMBRE
    Private Sub tb_nomb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nomb.KeyPress
        f_validar_form.Validar_letras(e)
    End Sub

    ' TELEFONO
    Private Sub tb_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_tel.KeyPress
        f_validar_form.Validar_numeros(e)

    End Sub


    ' EMAIL
    Private Sub tb_email_Leave(sender As Object, e As EventArgs) Handles tb_email.Leave
        If tb_email.Text <> "" And (f_validar_form.Valida_email(tb_email.Text) = False) Then
            MessageBox.Show("Email Invalido.", "")
            tb_email.Focus()
        End If

    End Sub

    Private Sub w_agregar_socio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cb_activo.Checked = True Then
            sn_activo = "S"
        Else
            sn_activo = "N"
        End If
        ' USUARIO NUEVO

        If id_origen = 1 Then
            act.MostrarActividades_clb(lb_actividades)
            cb_activo.Visible = False
        End If

        ' MODIFICACION
        If id_origen = 2 Then
            ' bloqueo los botones que no uso
            bt_agregar.Visible = False
            bt_guardar.Visible = True
            ' almacena la fila a modificar
            ll_dni = w_consultar_socio.dg_consulta_socio.CurrentRow.Cells("dni").Value


            'Cargo las actividades en el listbox
            act.MostrarActividades_clb(lb_actividades)



            Try
                Using conexion As New taller2Entities

                    Dim datos_socio = (From s In conexion.socios
                                       Where s.dni = ll_dni
                                       Select s).First

                    tb_dni.Text = datos_socio.dni
                    tb_ape.Text = datos_socio.apellido
                    tb_nomb.Text = datos_socio.nombre
                    tb_direc.Text = datos_socio.direccion
                    tb_tel.Text = datos_socio.telefono
                    tb_email.Text = datos_socio.email
                    date_nac.Value = datos_socio.fe_nacimiento
                    If datos_socio.sexo = "F" Then rb_mujer.Checked = True
                    tb_dni.Enabled = False

                    ' CARGO EL PICTUREBOX
                    ' convertimo el valor en byte
                    Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim imageBuffer() As Byte = CType(datos_socio.imagen, Byte()) 'Conbertimos la imagen cargada en el datatable a Bytes.
                    ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
                    pb_image.BackgroundImage = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    pb_image.BackgroundImage = (Image.FromStream(ms)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.
                    pb_image.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen al todo el PictureBox.


                End Using



            Catch ex As Exception
                'MessageBox.Show("No se encontro imagen", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If


    End Sub
    ' ESTE ES EL BOTON DE CERRATE PUE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tb_dni.Text <> "" Or tb_ape.Text <> "" Or tb_nomb.Text <> "" Or tb_tel.Text <> "" Or tb_direc.Text <> "" Then
            MessageBox.Show("¿Seguro desea salir?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            Me.Close()

        Else

            Me.Close()

        End If

    End Sub
    'examinar
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Title = "Seleccione el archivo"
        OpenFileDialog1.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
        OpenFileDialog1.InitialDirectory = "C:\"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim extension As String = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            If extension = ".jpg" Or extension = ".jpeg" Or extension = ".png" Or extension = ".bmp" Then
                pb_image.Image = Image.FromFile(OpenFileDialog1.FileName)
                Dim bmp As New Bitmap(Image.FromFile(OpenFileDialog1.FileName))
                bmp = bmp.GetThumbnailImage(480, 480, Nothing, IntPtr.Zero) 'Redimencionamos pixeles deimagen (Opcional).
                pb_image.BackgroundImage = Nothing
                pb_image.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen a todo el picturebox.
                pb_image.BackgroundImage = bmp 'Cargamos la imagen al PictureBox.
                'guardo la imagen en memoria 
                pb_image.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                modifico = True
            End If
        End If
    End Sub


    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        Dim ll_tel As Long
        Dim resultado As Integer
        Dim sex As Char

        If tb_dni.Text = "" Then
            MessageBox.Show("Complete DNI", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_dni.BackColor = Color.AntiqueWhite
        ElseIf tb_ape.Text = "" Then
            MessageBox.Show("Complete APELLIDO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_ape.BackColor = Color.AntiqueWhite
        ElseIf tb_nomb.Text = "" Then
            MessageBox.Show("Complete NOMBRE", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_nomb.BackColor = Color.AntiqueWhite
        ElseIf tb_tel.Text = "" Then
            MessageBox.Show("Complete TELEFONO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_tel.BackColor = Color.AntiqueWhite
        ElseIf tb_direc.Text = "" Then
            MessageBox.Show("Complete DIRECCION", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tb_direc.BackColor = Color.AntiqueWhite

        ElseIf lb_actividades.SelectedItems.Count = 0 Then
            MessageBox.Show("Seleccione una actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            tb_dni.BackColor = Color.White
            tb_ape.BackColor = Color.White
            tb_nomb.BackColor = Color.White
            tb_tel.BackColor = Color.White
            tb_direc.BackColor = Color.White

            If tb_tel.Text = "" Then
                tb_tel.Text = 0
            End If
            If socio.verificar_dni(tb_dni.Text) <> 1 Then
                MessageBox.Show("El DNI ya fue REGISTRADO", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                If rb_hombre.Checked = True Then
                    sex = "M"
                Else
                    sex = "F"
                End If

                ll_tel = CType(tb_tel.Text, Long)

                'Pregunta si desea agregar un nuevo socio

                If MessageBox.Show("¿Desea agregar un nuevo socio?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

                    Try
                        Using bd As New taller2Entities
                            Dim bd_socio As New socios
                            bd_socio.dni = tb_dni.Text
                            bd_socio.apellido = tb_ape.Text
                            bd_socio.nombre = tb_nomb.Text
                            bd_socio.direccion = tb_direc.Text
                            bd_socio.telefono = ll_tel
                            bd_socio.email = tb_email.Text
                            bd_socio.fe_nacimiento = date_nac.Value
                            bd_socio.sexo = sex
                            bd_socio.imagen = ms.GetBuffer()
                            bd_socio.sn_activo = sn_activo

                            Dim ls_de_actividad As String

                            For i = 0 To lb_actividades.SelectedItems.Count - 1
                                ls_de_actividad = lb_actividades.SelectedItems(i)
                                resultado = act.idActividades_lb(ls_de_actividad)
                                bd_socio.actividades.Add((From a In bd.actividades Where a.id_actividad = resultado Select a).First)

                            Next

                            bd.socios.Add(bd_socio)
                            bd.SaveChanges()

                            MessageBox.Show("Socio agregado con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            tb_dni.Text = ""
                            tb_ape.Text = ""
                            tb_nomb.Text = ""
                            tb_tel.Text = ""
                            tb_direc.Text = ""
                            tb_email.Text = ""
                            date_nac.Value = Date.Now
                            lb_actividades.ClearSelected()
                            rb_mujer.Checked = False
                            rb_hombre.Checked = True

                        End Using

                    Catch ex As Exception

                        MessageBox.Show("Error al acceder a los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try

                End If
            End If
            End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w_consultar_socio.Show()
        Me.Close()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim sex As Char
        Dim ll_tel As Long
        Dim resultado As Integer


        If MessageBox.Show("¿Seguro que desea guardar los Cambios?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Cancel Then
            Return
        Else


            If tb_ape.Text = "" Then
                MessageBox.Show("Complete APELLIDO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_ape.BackColor = Color.AntiqueWhite
                Return

            ElseIf tb_nomb.Text = "" Then
                MessageBox.Show("Complete NOMBRE", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_nomb.BackColor = Color.AntiqueWhite
                Return
            ElseIf lb_actividades.SelectedItems.Count = 0 Then
                MessageBox.Show("Seleccione una actividad", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return
            ElseIf tb_tel.Text = "" Then
                MessageBox.Show("Complete TELEFONO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_tel.BackColor = Color.AntiqueWhite
                Return
            ElseIf tb_direc.Text = "" Then
                MessageBox.Show("Complete DIRECCION", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                tb_direc.BackColor = Color.AntiqueWhite
                Return

            Else
                tb_ape.BackColor = Color.White
                tb_nomb.BackColor = Color.White
                tb_tel.BackColor = Color.White
                tb_direc.BackColor = Color.White

                If rb_hombre.Checked = True Then
                    sex = "M"
                Else
                    sex = "F"
                End If

                If tb_tel.Text = "" Then
                    tb_tel.Text = 0
                End If

                ll_tel = CType(tb_tel.Text, Long)

            End If



            Try
                Using bd As New taller2Entities
                    Dim bd_socio = (From a In bd.socios Where a.dni = ll_dni Select a).First
                    bd_socio.dni = tb_dni.Text
                    bd_socio.apellido = tb_ape.Text
                    bd_socio.nombre = tb_nomb.Text
                    bd_socio.direccion = tb_direc.Text
                    bd_socio.telefono = ll_tel
                    bd_socio.email = tb_email.Text
                    bd_socio.fe_nacimiento = date_nac.Value
                    bd_socio.sexo = sex
                    bd_socio.sn_activo = sn_activo
                    If modifico = True Then bd_socio.imagen = ms.GetBuffer()

                    Dim ls_de_actividad As String

                    bd_socio.actividades.Clear()

                    For i = 0 To lb_actividades.SelectedItems.Count - 1
                        ls_de_actividad = lb_actividades.SelectedItems(i)
                        resultado = act.idActividades_lb(ls_de_actividad)
                        bd_socio.actividades.Add((From a In bd.actividades Where a.id_actividad = resultado Select a).First)
                    Next

                    bd.SaveChanges()

                    tb_ape.Text = ""
                    tb_nomb.Text = ""
                    tb_tel.Text = ""
                    tb_direc.Text = ""
                    tb_email.Text = ""
                    lb_actividades.ClearSelected()

                End Using

                If Me.id_origen = 2 Then w_consultar_socio.dg_act_socio.ClearSelection()
                w_consultar_socio.bt_quitar.PerformClick()
                Me.Close()
                MessageBox.Show("Los cambios han sido guardados con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception

                MessageBox.Show("Error Al completar Los datos. Verifique", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End Try
        End If
    End Sub

    Private Sub bt_capturar_Click(sender As Object, e As EventArgs) Handles bt_capturar.Click
        pb_image.Image = WebCam1.Imagen
        WebCam1.Stop()

    End Sub

    Private Sub WebCam1_LostFocus(sender As Object, e As EventArgs) Handles WebCam1.LostFocus
        WebCam1.Stop()
        WebCam1.Stop()
    End Sub

    Private Sub WebCam1_GotFocus(sender As Object, e As EventArgs) Handles WebCam1.GotFocus
        WebCam1.Start()
        WebCam1.Start()
    End Sub
End Class