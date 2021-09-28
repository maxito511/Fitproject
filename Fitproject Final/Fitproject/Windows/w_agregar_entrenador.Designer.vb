<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_agregar_entrenador
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.cb_activo = New System.Windows.Forms.CheckBox()
        Me.lb_actividades = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_consultar_entrenadores = New System.Windows.Forms.Button()
        Me.bt_salir = New System.Windows.Forms.Button()
        Me.bt_Agregar = New System.Windows.Forms.Button()
        Me.date_nac = New System.Windows.Forms.DateTimePicker()
        Me.rb_mujer = New System.Windows.Forms.RadioButton()
        Me.rb_hombre = New System.Windows.Forms.RadioButton()
        Me.tb_Email = New System.Windows.Forms.TextBox()
        Me.tb_Direccion = New System.Windows.Forms.TextBox()
        Me.tb_Telefono = New System.Windows.Forms.TextBox()
        Me.tb_Nombre = New System.Windows.Forms.TextBox()
        Me.tb_Apellido = New System.Windows.Forms.TextBox()
        Me.tb_DNI = New System.Windows.Forms.TextBox()
        Me.L_Fecha_de_nacimiento = New System.Windows.Forms.Label()
        Me.L_Sexo = New System.Windows.Forms.Label()
        Me.L_Email = New System.Windows.Forms.Label()
        Me.L_Direccion = New System.Windows.Forms.Label()
        Me.L_Telefono = New System.Windows.Forms.Label()
        Me.L_Nombre = New System.Windows.Forms.Label()
        Me.L_Apellido = New System.Windows.Forms.Label()
        Me.L_DNI = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_guardar)
        Me.GroupBox1.Controls.Add(Me.cb_activo)
        Me.GroupBox1.Controls.Add(Me.lb_actividades)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.bt_consultar_entrenadores)
        Me.GroupBox1.Controls.Add(Me.bt_salir)
        Me.GroupBox1.Controls.Add(Me.bt_Agregar)
        Me.GroupBox1.Controls.Add(Me.date_nac)
        Me.GroupBox1.Controls.Add(Me.rb_mujer)
        Me.GroupBox1.Controls.Add(Me.rb_hombre)
        Me.GroupBox1.Controls.Add(Me.tb_Email)
        Me.GroupBox1.Controls.Add(Me.tb_Direccion)
        Me.GroupBox1.Controls.Add(Me.tb_Telefono)
        Me.GroupBox1.Controls.Add(Me.tb_Nombre)
        Me.GroupBox1.Controls.Add(Me.tb_Apellido)
        Me.GroupBox1.Controls.Add(Me.tb_DNI)
        Me.GroupBox1.Controls.Add(Me.L_Fecha_de_nacimiento)
        Me.GroupBox1.Controls.Add(Me.L_Sexo)
        Me.GroupBox1.Controls.Add(Me.L_Email)
        Me.GroupBox1.Controls.Add(Me.L_Direccion)
        Me.GroupBox1.Controls.Add(Me.L_Telefono)
        Me.GroupBox1.Controls.Add(Me.L_Nombre)
        Me.GroupBox1.Controls.Add(Me.L_Apellido)
        Me.GroupBox1.Controls.Add(Me.L_DNI)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 453)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(42, 416)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 27
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'cb_activo
        '
        Me.cb_activo.AutoSize = True
        Me.cb_activo.Checked = True
        Me.cb_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_activo.Location = New System.Drawing.Point(404, 262)
        Me.cb_activo.Name = "cb_activo"
        Me.cb_activo.Size = New System.Drawing.Size(67, 19)
        Me.cb_activo.TabIndex = 26
        Me.cb_activo.Text = "ACTIVO"
        Me.cb_activo.UseVisualStyleBackColor = True
        '
        'lb_actividades
        '
        Me.lb_actividades.FormattingEnabled = True
        Me.lb_actividades.ItemHeight = 15
        Me.lb_actividades.Location = New System.Drawing.Point(404, 115)
        Me.lb_actividades.Name = "lb_actividades"
        Me.lb_actividades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lb_actividades.Size = New System.Drawing.Size(191, 109)
        Me.lb_actividades.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Actividad: (*)"
        '
        'bt_consultar_entrenadores
        '
        Me.bt_consultar_entrenadores.Location = New System.Drawing.Point(140, 417)
        Me.bt_consultar_entrenadores.Name = "bt_consultar_entrenadores"
        Me.bt_consultar_entrenadores.Size = New System.Drawing.Size(191, 23)
        Me.bt_consultar_entrenadores.TabIndex = 23
        Me.bt_consultar_entrenadores.Text = "CONSULTAR ENTRENADORES"
        Me.bt_consultar_entrenadores.UseVisualStyleBackColor = True
        '
        'bt_salir
        '
        Me.bt_salir.Location = New System.Drawing.Point(515, 416)
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Size = New System.Drawing.Size(80, 23)
        Me.bt_salir.TabIndex = 18
        Me.bt_salir.Text = "SALIR"
        Me.bt_salir.UseVisualStyleBackColor = True
        '
        'bt_Agregar
        '
        Me.bt_Agregar.Location = New System.Drawing.Point(57, 416)
        Me.bt_Agregar.Name = "bt_Agregar"
        Me.bt_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Agregar.TabIndex = 17
        Me.bt_Agregar.Text = "AGREGAR"
        Me.bt_Agregar.UseVisualStyleBackColor = True
        '
        'date_nac
        '
        Me.date_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_nac.Location = New System.Drawing.Point(211, 373)
        Me.date_nac.Name = "date_nac"
        Me.date_nac.Size = New System.Drawing.Size(95, 21)
        Me.date_nac.TabIndex = 16
        '
        'rb_mujer
        '
        Me.rb_mujer.AutoSize = True
        Me.rb_mujer.Location = New System.Drawing.Point(249, 330)
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
        Me.rb_hombre.Location = New System.Drawing.Point(158, 330)
        Me.rb_hombre.Name = "rb_hombre"
        Me.rb_hombre.Size = New System.Drawing.Size(70, 19)
        Me.rb_hombre.TabIndex = 14
        Me.rb_hombre.TabStop = True
        Me.rb_hombre.Text = "Hombre"
        Me.rb_hombre.UseVisualStyleBackColor = True
        '
        'tb_Email
        '
        Me.tb_Email.Location = New System.Drawing.Point(158, 281)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(191, 21)
        Me.tb_Email.TabIndex = 13
        '
        'tb_Direccion
        '
        Me.tb_Direccion.Location = New System.Drawing.Point(158, 232)
        Me.tb_Direccion.Name = "tb_Direccion"
        Me.tb_Direccion.Size = New System.Drawing.Size(191, 21)
        Me.tb_Direccion.TabIndex = 12
        '
        'tb_Telefono
        '
        Me.tb_Telefono.Location = New System.Drawing.Point(158, 182)
        Me.tb_Telefono.MaxLength = 12
        Me.tb_Telefono.Name = "tb_Telefono"
        Me.tb_Telefono.Size = New System.Drawing.Size(191, 21)
        Me.tb_Telefono.TabIndex = 11
        '
        'tb_Nombre
        '
        Me.tb_Nombre.Location = New System.Drawing.Point(158, 129)
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.Size = New System.Drawing.Size(191, 21)
        Me.tb_Nombre.TabIndex = 10
        '
        'tb_Apellido
        '
        Me.tb_Apellido.Location = New System.Drawing.Point(158, 78)
        Me.tb_Apellido.Name = "tb_Apellido"
        Me.tb_Apellido.Size = New System.Drawing.Size(191, 21)
        Me.tb_Apellido.TabIndex = 9
        '
        'tb_DNI
        '
        Me.tb_DNI.Location = New System.Drawing.Point(158, 31)
        Me.tb_DNI.MaxLength = 8
        Me.tb_DNI.Name = "tb_DNI"
        Me.tb_DNI.Size = New System.Drawing.Size(191, 21)
        Me.tb_DNI.TabIndex = 8
        '
        'L_Fecha_de_nacimiento
        '
        Me.L_Fecha_de_nacimiento.AutoSize = True
        Me.L_Fecha_de_nacimiento.Location = New System.Drawing.Point(18, 373)
        Me.L_Fecha_de_nacimiento.Name = "L_Fecha_de_nacimiento"
        Me.L_Fecha_de_nacimiento.Size = New System.Drawing.Size(143, 15)
        Me.L_Fecha_de_nacimiento.TabIndex = 7
        Me.L_Fecha_de_nacimiento.Text = "Fecha de Nacimiento: (*)"
        '
        'L_Sexo
        '
        Me.L_Sexo.AutoSize = True
        Me.L_Sexo.Location = New System.Drawing.Point(85, 332)
        Me.L_Sexo.Name = "L_Sexo"
        Me.L_Sexo.Size = New System.Drawing.Size(54, 15)
        Me.L_Sexo.TabIndex = 6
        Me.L_Sexo.Text = "Sexo: (*)"
        '
        'L_Email
        '
        Me.L_Email.AutoSize = True
        Me.L_Email.Location = New System.Drawing.Point(87, 284)
        Me.L_Email.Name = "L_Email"
        Me.L_Email.Size = New System.Drawing.Size(45, 15)
        Me.L_Email.TabIndex = 5
        Me.L_Email.Text = "Email: "
        '
        'L_Direccion
        '
        Me.L_Direccion.AutoSize = True
        Me.L_Direccion.Location = New System.Drawing.Point(61, 235)
        Me.L_Direccion.Name = "L_Direccion"
        Me.L_Direccion.Size = New System.Drawing.Size(78, 15)
        Me.L_Direccion.TabIndex = 4
        Me.L_Direccion.Text = "Direccion: (*)"
        '
        'L_Telefono
        '
        Me.L_Telefono.AutoSize = True
        Me.L_Telefono.Location = New System.Drawing.Point(65, 185)
        Me.L_Telefono.Name = "L_Telefono"
        Me.L_Telefono.Size = New System.Drawing.Size(74, 15)
        Me.L_Telefono.TabIndex = 3
        Me.L_Telefono.Text = "Telefono: (*)"
        '
        'L_Nombre
        '
        Me.L_Nombre.AutoSize = True
        Me.L_Nombre.Location = New System.Drawing.Point(68, 132)
        Me.L_Nombre.Name = "L_Nombre"
        Me.L_Nombre.Size = New System.Drawing.Size(71, 15)
        Me.L_Nombre.TabIndex = 2
        Me.L_Nombre.Text = "Nombre: (*)"
        '
        'L_Apellido
        '
        Me.L_Apellido.AutoSize = True
        Me.L_Apellido.Location = New System.Drawing.Point(73, 81)
        Me.L_Apellido.Name = "L_Apellido"
        Me.L_Apellido.Size = New System.Drawing.Size(70, 15)
        Me.L_Apellido.TabIndex = 1
        Me.L_Apellido.Text = "Apellido: (*)"
        '
        'L_DNI
        '
        Me.L_DNI.AutoSize = True
        Me.L_DNI.Location = New System.Drawing.Point(96, 34)
        Me.L_DNI.Name = "L_DNI"
        Me.L_DNI.Size = New System.Drawing.Size(47, 15)
        Me.L_DNI.TabIndex = 0
        Me.L_DNI.Text = "DNI: (*)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'w_agregar_entrenador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 482)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_agregar_entrenador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Entrenador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents L_Apellido As Label
    Friend WithEvents L_DNI As Label
    Friend WithEvents tb_Direccion As TextBox
    Friend WithEvents tb_Telefono As TextBox
    Friend WithEvents tb_Nombre As TextBox
    Friend WithEvents tb_Apellido As TextBox
    Friend WithEvents tb_DNI As TextBox
    Friend WithEvents L_Fecha_de_nacimiento As Label
    Friend WithEvents L_Sexo As Label
    Friend WithEvents L_Email As Label
    Friend WithEvents L_Direccion As Label
    Friend WithEvents L_Telefono As Label
    Friend WithEvents L_Nombre As Label
    Friend WithEvents tb_Email As TextBox
    Friend WithEvents rb_mujer As RadioButton
    Friend WithEvents rb_hombre As RadioButton
    Friend WithEvents date_nac As DateTimePicker
    Friend WithEvents bt_salir As Button
    Friend WithEvents bt_Agregar As Button
    Friend WithEvents bt_consultar_entrenadores As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_actividades As ListBox
    Friend WithEvents cb_activo As CheckBox
    Friend WithEvents bt_guardar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
