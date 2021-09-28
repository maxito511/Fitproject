<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_agregar_socio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(w_agregar_socio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_activo = New System.Windows.Forms.CheckBox()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lb_actividades = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pb_image = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebCam1 = New WebCAM.WebCam()
        Me.bt_capturar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.rb_mujer = New System.Windows.Forms.RadioButton()
        Me.rb_hombre = New System.Windows.Forms.RadioButton()
        Me.date_nac = New System.Windows.Forms.DateTimePicker()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.tb_direc = New System.Windows.Forms.TextBox()
        Me.tb_tel = New System.Windows.Forms.TextBox()
        Me.tb_nomb = New System.Windows.Forms.TextBox()
        Me.tb_ape = New System.Windows.Forms.TextBox()
        Me.tb_dni = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cb_activo)
        Me.GroupBox1.Controls.Add(Me.bt_guardar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lb_actividades)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.bt_capturar)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.bt_agregar)
        Me.GroupBox1.Controls.Add(Me.rb_mujer)
        Me.GroupBox1.Controls.Add(Me.rb_hombre)
        Me.GroupBox1.Controls.Add(Me.date_nac)
        Me.GroupBox1.Controls.Add(Me.tb_email)
        Me.GroupBox1.Controls.Add(Me.tb_direc)
        Me.GroupBox1.Controls.Add(Me.tb_tel)
        Me.GroupBox1.Controls.Add(Me.tb_nomb)
        Me.GroupBox1.Controls.Add(Me.tb_ape)
        Me.GroupBox1.Controls.Add(Me.tb_dni)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 496)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'cb_activo
        '
        Me.cb_activo.AutoSize = True
        Me.cb_activo.Checked = True
        Me.cb_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_activo.Location = New System.Drawing.Point(64, 323)
        Me.cb_activo.Name = "cb_activo"
        Me.cb_activo.Size = New System.Drawing.Size(57, 19)
        Me.cb_activo.TabIndex = 26
        Me.cb_activo.Text = "Activo"
        Me.cb_activo.UseVisualStyleBackColor = True
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(85, 457)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 25
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.UseVisualStyleBackColor = True
        Me.bt_guardar.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "CONSULTAR SOCIOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lb_actividades
        '
        Me.lb_actividades.FormattingEnabled = True
        Me.lb_actividades.ItemHeight = 15
        Me.lb_actividades.Location = New System.Drawing.Point(64, 348)
        Me.lb_actividades.Name = "lb_actividades"
        Me.lb_actividades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lb_actividades.Size = New System.Drawing.Size(251, 94)
        Me.lb_actividades.TabIndex = 23
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(352, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(274, 234)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.pb_image)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(266, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Foto"
        '
        'pb_image
        '
        Me.pb_image.BackgroundImage = CType(resources.GetObject("pb_image.BackgroundImage"), System.Drawing.Image)
        Me.pb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_image.Location = New System.Drawing.Point(4, 0)
        Me.pb_image.Name = "pb_image"
        Me.pb_image.Size = New System.Drawing.Size(256, 206)
        Me.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_image.TabIndex = 7
        Me.pb_image.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.WebCam1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(266, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Camara"
        '
        'WebCam1
        '
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(0, 3)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(272, 208)
        Me.WebCam1.TabIndex = 21
        '
        'bt_capturar
        '
        Me.bt_capturar.Location = New System.Drawing.Point(553, 292)
        Me.bt_capturar.Name = "bt_capturar"
        Me.bt_capturar.Size = New System.Drawing.Size(75, 23)
        Me.bt_capturar.TabIndex = 17
        Me.bt_capturar.Text = "Capturar"
        Me.bt_capturar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(375, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Examinar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(544, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt_agregar
        '
        Me.bt_agregar.Location = New System.Drawing.Point(64, 457)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_agregar.TabIndex = 19
        Me.bt_agregar.Text = "AGREGAR"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'rb_mujer
        '
        Me.rb_mujer.AutoSize = True
        Me.rb_mujer.Location = New System.Drawing.Point(190, 255)
        Me.rb_mujer.Name = "rb_mujer"
        Me.rb_mujer.Size = New System.Drawing.Size(57, 19)
        Me.rb_mujer.TabIndex = 15
        Me.rb_mujer.Text = "Mujer"
        Me.rb_mujer.UseVisualStyleBackColor = True
        '
        'rb_hombre
        '
        Me.rb_hombre.AutoSize = True
        Me.rb_hombre.Checked = True
        Me.rb_hombre.Location = New System.Drawing.Point(114, 255)
        Me.rb_hombre.Name = "rb_hombre"
        Me.rb_hombre.Size = New System.Drawing.Size(70, 19)
        Me.rb_hombre.TabIndex = 14
        Me.rb_hombre.TabStop = True
        Me.rb_hombre.Text = "Hombre"
        Me.rb_hombre.UseVisualStyleBackColor = True
        '
        'date_nac
        '
        Me.date_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_nac.Location = New System.Drawing.Point(163, 292)
        Me.date_nac.Name = "date_nac"
        Me.date_nac.Size = New System.Drawing.Size(98, 21)
        Me.date_nac.TabIndex = 16
        Me.date_nac.Value = New Date(2017, 9, 13, 0, 0, 0, 0)
        '
        'tb_email
        '
        Me.tb_email.Location = New System.Drawing.Point(114, 215)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(213, 21)
        Me.tb_email.TabIndex = 13
        '
        'tb_direc
        '
        Me.tb_direc.Location = New System.Drawing.Point(114, 172)
        Me.tb_direc.Name = "tb_direc"
        Me.tb_direc.Size = New System.Drawing.Size(213, 21)
        Me.tb_direc.TabIndex = 12
        '
        'tb_tel
        '
        Me.tb_tel.Location = New System.Drawing.Point(114, 132)
        Me.tb_tel.MaxLength = 12
        Me.tb_tel.Name = "tb_tel"
        Me.tb_tel.Size = New System.Drawing.Size(100, 21)
        Me.tb_tel.TabIndex = 11
        '
        'tb_nomb
        '
        Me.tb_nomb.Location = New System.Drawing.Point(114, 93)
        Me.tb_nomb.Name = "tb_nomb"
        Me.tb_nomb.Size = New System.Drawing.Size(213, 21)
        Me.tb_nomb.TabIndex = 10
        '
        'tb_ape
        '
        Me.tb_ape.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tb_ape.Location = New System.Drawing.Point(114, 53)
        Me.tb_ape.Name = "tb_ape"
        Me.tb_ape.Size = New System.Drawing.Size(213, 21)
        Me.tb_ape.TabIndex = 9
        '
        'tb_dni
        '
        Me.tb_dni.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tb_dni.Location = New System.Drawing.Point(114, 21)
        Me.tb_dni.MaxLength = 8
        Me.tb_dni.Name = "tb_dni"
        Me.tb_dni.Size = New System.Drawing.Size(100, 21)
        Me.tb_dni.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sexo: (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Fecha de Nacimiento: (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección: (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono: (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre: (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido: (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI: (*)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'w_agregar_socio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 520)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_agregar_socio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Socio :."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date_nac As DateTimePicker
    Friend WithEvents tb_email As TextBox
    Friend WithEvents tb_direc As TextBox
    Friend WithEvents tb_tel As TextBox
    Friend WithEvents tb_nomb As TextBox
    Friend WithEvents tb_ape As TextBox
    Friend WithEvents tb_dni As TextBox
    Friend WithEvents pb_image As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rb_mujer As RadioButton
    Friend WithEvents rb_hombre As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bt_agregar As Button
    Friend WithEvents bt_capturar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents WebCam1 As WebCAM.WebCam
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lb_actividades As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents cb_activo As CheckBox
End Class
