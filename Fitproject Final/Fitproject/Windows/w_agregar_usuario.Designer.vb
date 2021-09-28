<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_agregar_usuario
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
        Me.cb_mostrar = New System.Windows.Forms.CheckBox()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.bt_consultar_usuarios = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.tb_contraseña = New System.Windows.Forms.TextBox()
        Me.cb_activo = New System.Windows.Forms.CheckBox()
        Me.tb_Email = New System.Windows.Forms.TextBox()
        Me.tb_Direccion = New System.Windows.Forms.TextBox()
        Me.tb_Telefono = New System.Windows.Forms.TextBox()
        Me.tb_Nombre = New System.Windows.Forms.TextBox()
        Me.tb_Apellido = New System.Windows.Forms.TextBox()
        Me.tb_DNI = New System.Windows.Forms.TextBox()
        Me.L_Email = New System.Windows.Forms.Label()
        Me.L_Direccion = New System.Windows.Forms.Label()
        Me.L_Telefono = New System.Windows.Forms.Label()
        Me.L_Nombre = New System.Windows.Forms.Label()
        Me.L_Apellido = New System.Windows.Forms.Label()
        Me.L_DNI = New System.Windows.Forms.Label()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_Agregar = New System.Windows.Forms.Button()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.L_Tipo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cb_mostrar)
        Me.GroupBox1.Controls.Add(Me.bt_guardar)
        Me.GroupBox1.Controls.Add(Me.bt_consultar_usuarios)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_nombre_usuario)
        Me.GroupBox1.Controls.Add(Me.tb_contraseña)
        Me.GroupBox1.Controls.Add(Me.cb_activo)
        Me.GroupBox1.Controls.Add(Me.tb_Email)
        Me.GroupBox1.Controls.Add(Me.tb_Direccion)
        Me.GroupBox1.Controls.Add(Me.tb_Telefono)
        Me.GroupBox1.Controls.Add(Me.tb_Nombre)
        Me.GroupBox1.Controls.Add(Me.tb_Apellido)
        Me.GroupBox1.Controls.Add(Me.tb_DNI)
        Me.GroupBox1.Controls.Add(Me.L_Email)
        Me.GroupBox1.Controls.Add(Me.L_Direccion)
        Me.GroupBox1.Controls.Add(Me.L_Telefono)
        Me.GroupBox1.Controls.Add(Me.L_Nombre)
        Me.GroupBox1.Controls.Add(Me.L_Apellido)
        Me.GroupBox1.Controls.Add(Me.L_DNI)
        Me.GroupBox1.Controls.Add(Me.bt_Cancelar)
        Me.GroupBox1.Controls.Add(Me.bt_Agregar)
        Me.GroupBox1.Controls.Add(Me.cb_tipo)
        Me.GroupBox1.Controls.Add(Me.L_Tipo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 460)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del nuevo usuario"
        '
        'cb_mostrar
        '
        Me.cb_mostrar.AutoSize = True
        Me.cb_mostrar.Location = New System.Drawing.Point(487, 170)
        Me.cb_mostrar.Name = "cb_mostrar"
        Me.cb_mostrar.Size = New System.Drawing.Size(118, 17)
        Me.cb_mostrar.TabIndex = 40
        Me.cb_mostrar.Text = "Mostrar Contraseña"
        Me.cb_mostrar.UseVisualStyleBackColor = True
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(86, 398)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 39
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'bt_consultar_usuarios
        '
        Me.bt_consultar_usuarios.Location = New System.Drawing.Point(196, 398)
        Me.bt_consultar_usuarios.Name = "bt_consultar_usuarios"
        Me.bt_consultar_usuarios.Size = New System.Drawing.Size(145, 23)
        Me.bt_consultar_usuarios.TabIndex = 38
        Me.bt_consultar_usuarios.Text = "CONSULTAR USUARIOS"
        Me.bt_consultar_usuarios.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Contraseña: (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Usuario: (*)"
        '
        'tb_nombre_usuario
        '
        Me.tb_nombre_usuario.Location = New System.Drawing.Point(450, 36)
        Me.tb_nombre_usuario.Name = "tb_nombre_usuario"
        Me.tb_nombre_usuario.Size = New System.Drawing.Size(155, 20)
        Me.tb_nombre_usuario.TabIndex = 35
        '
        'tb_contraseña
        '
        Me.tb_contraseña.Location = New System.Drawing.Point(450, 134)
        Me.tb_contraseña.Name = "tb_contraseña"
        Me.tb_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_contraseña.Size = New System.Drawing.Size(155, 20)
        Me.tb_contraseña.TabIndex = 34
        '
        'cb_activo
        '
        Me.cb_activo.AutoSize = True
        Me.cb_activo.Checked = True
        Me.cb_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_activo.Location = New System.Drawing.Point(450, 322)
        Me.cb_activo.Name = "cb_activo"
        Me.cb_activo.Size = New System.Drawing.Size(65, 17)
        Me.cb_activo.TabIndex = 31
        Me.cb_activo.Text = "ACTIVO"
        Me.cb_activo.UseVisualStyleBackColor = True
        '
        'tb_Email
        '
        Me.tb_Email.Location = New System.Drawing.Point(115, 291)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(191, 20)
        Me.tb_Email.TabIndex = 30
        '
        'tb_Direccion
        '
        Me.tb_Direccion.Location = New System.Drawing.Point(115, 241)
        Me.tb_Direccion.Name = "tb_Direccion"
        Me.tb_Direccion.Size = New System.Drawing.Size(191, 20)
        Me.tb_Direccion.TabIndex = 29
        '
        'tb_Telefono
        '
        Me.tb_Telefono.Location = New System.Drawing.Point(115, 187)
        Me.tb_Telefono.MaxLength = 12
        Me.tb_Telefono.Name = "tb_Telefono"
        Me.tb_Telefono.Size = New System.Drawing.Size(191, 20)
        Me.tb_Telefono.TabIndex = 28
        '
        'tb_Nombre
        '
        Me.tb_Nombre.Location = New System.Drawing.Point(115, 134)
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.Size = New System.Drawing.Size(191, 20)
        Me.tb_Nombre.TabIndex = 27
        '
        'tb_Apellido
        '
        Me.tb_Apellido.Location = New System.Drawing.Point(115, 83)
        Me.tb_Apellido.Name = "tb_Apellido"
        Me.tb_Apellido.Size = New System.Drawing.Size(191, 20)
        Me.tb_Apellido.TabIndex = 26
        '
        'tb_DNI
        '
        Me.tb_DNI.Location = New System.Drawing.Point(115, 36)
        Me.tb_DNI.MaxLength = 8
        Me.tb_DNI.Name = "tb_DNI"
        Me.tb_DNI.Size = New System.Drawing.Size(191, 20)
        Me.tb_DNI.TabIndex = 25
        '
        'L_Email
        '
        Me.L_Email.AutoSize = True
        Me.L_Email.Location = New System.Drawing.Point(47, 294)
        Me.L_Email.Name = "L_Email"
        Me.L_Email.Size = New System.Drawing.Size(38, 13)
        Me.L_Email.TabIndex = 22
        Me.L_Email.Text = "Email: "
        '
        'L_Direccion
        '
        Me.L_Direccion.AutoSize = True
        Me.L_Direccion.Location = New System.Drawing.Point(19, 244)
        Me.L_Direccion.Name = "L_Direccion"
        Me.L_Direccion.Size = New System.Drawing.Size(68, 13)
        Me.L_Direccion.TabIndex = 21
        Me.L_Direccion.Text = "Direccion: (*)"
        '
        'L_Telefono
        '
        Me.L_Telefono.AutoSize = True
        Me.L_Telefono.Location = New System.Drawing.Point(22, 190)
        Me.L_Telefono.Name = "L_Telefono"
        Me.L_Telefono.Size = New System.Drawing.Size(65, 13)
        Me.L_Telefono.TabIndex = 20
        Me.L_Telefono.Text = "Telefono: (*)"
        '
        'L_Nombre
        '
        Me.L_Nombre.AutoSize = True
        Me.L_Nombre.Location = New System.Drawing.Point(25, 137)
        Me.L_Nombre.Name = "L_Nombre"
        Me.L_Nombre.Size = New System.Drawing.Size(60, 13)
        Me.L_Nombre.TabIndex = 19
        Me.L_Nombre.Text = "Nombre: (*)"
        '
        'L_Apellido
        '
        Me.L_Apellido.AutoSize = True
        Me.L_Apellido.Location = New System.Drawing.Point(30, 86)
        Me.L_Apellido.Name = "L_Apellido"
        Me.L_Apellido.Size = New System.Drawing.Size(60, 13)
        Me.L_Apellido.TabIndex = 18
        Me.L_Apellido.Text = "Apellido: (*)"
        '
        'L_DNI
        '
        Me.L_DNI.AutoSize = True
        Me.L_DNI.Location = New System.Drawing.Point(53, 39)
        Me.L_DNI.Name = "L_DNI"
        Me.L_DNI.Size = New System.Drawing.Size(42, 13)
        Me.L_DNI.TabIndex = 17
        Me.L_DNI.Text = "DNI: (*)"
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Location = New System.Drawing.Point(530, 398)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Cancelar.TabIndex = 10
        Me.bt_Cancelar.Text = "SALIR"
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_Agregar
        '
        Me.bt_Agregar.Location = New System.Drawing.Point(115, 398)
        Me.bt_Agregar.Name = "bt_Agregar"
        Me.bt_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Agregar.TabIndex = 9
        Me.bt_Agregar.Text = "AGREGAR"
        Me.bt_Agregar.UseVisualStyleBackColor = True
        '
        'cb_tipo
        '
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"ADMINISTRADOR", "SUPERVISOR", "VENDEDOR"})
        Me.cb_tipo.Location = New System.Drawing.Point(450, 240)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(155, 21)
        Me.cb_tipo.TabIndex = 8
        '
        'L_Tipo
        '
        Me.L_Tipo.AutoSize = True
        Me.L_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Tipo.Location = New System.Drawing.Point(364, 241)
        Me.L_Tipo.Name = "L_Tipo"
        Me.L_Tipo.Size = New System.Drawing.Size(50, 15)
        Me.L_Tipo.TabIndex = 2
        Me.L_Tipo.Text = "Tipo: (*)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'w_agregar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_agregar_usuario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents L_Tipo As Label
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents bt_Cancelar As Button
    Friend WithEvents bt_Agregar As Button
    Friend WithEvents tb_Email As TextBox
    Friend WithEvents tb_Direccion As TextBox
    Friend WithEvents tb_Telefono As TextBox
    Friend WithEvents tb_Nombre As TextBox
    Friend WithEvents tb_Apellido As TextBox
    Friend WithEvents tb_DNI As TextBox
    Friend WithEvents L_Email As Label
    Friend WithEvents L_Direccion As Label
    Friend WithEvents L_Telefono As Label
    Friend WithEvents L_Nombre As Label
    Friend WithEvents L_Apellido As Label
    Friend WithEvents L_DNI As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nombre_usuario As TextBox
    Friend WithEvents tb_contraseña As TextBox
    Friend WithEvents cb_activo As CheckBox
    Friend WithEvents bt_consultar_usuarios As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents cb_mostrar As CheckBox
    Friend WithEvents Button1 As Button
End Class
