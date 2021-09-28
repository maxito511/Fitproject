<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_consultar_usuario
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
        Me.cb_ver_todos = New System.Windows.Forms.CheckBox()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_Modificar = New System.Windows.Forms.Button()
        Me.bt_Nuevo = New System.Windows.Forms.Button()
        Me.dg_consulta_usuario = New System.Windows.Forms.DataGridView()
        Me.login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_nombre_usuario = New System.Windows.Forms.RadioButton()
        Me.rb_dni = New System.Windows.Forms.RadioButton()
        Me.tb_Buscar = New System.Windows.Forms.TextBox()
        Me.bt_quitar = New System.Windows.Forms.Button()
        Me.bt_Cerrar = New System.Windows.Forms.Button()
        CType(Me.dg_consulta_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_ver_todos
        '
        Me.cb_ver_todos.AutoSize = True
        Me.cb_ver_todos.Location = New System.Drawing.Point(627, 84)
        Me.cb_ver_todos.Name = "cb_ver_todos"
        Me.cb_ver_todos.Size = New System.Drawing.Size(75, 17)
        Me.cb_ver_todos.TabIndex = 14
        Me.cb_ver_todos.Text = "Ver Todos"
        Me.cb_ver_todos.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(182, 328)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.bt_eliminar.TabIndex = 13
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'bt_Modificar
        '
        Me.bt_Modificar.Location = New System.Drawing.Point(91, 328)
        Me.bt_Modificar.Name = "bt_Modificar"
        Me.bt_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Modificar.TabIndex = 12
        Me.bt_Modificar.Text = "Modificar"
        Me.bt_Modificar.UseVisualStyleBackColor = True
        '
        'bt_Nuevo
        '
        Me.bt_Nuevo.Location = New System.Drawing.Point(9, 328)
        Me.bt_Nuevo.Name = "bt_Nuevo"
        Me.bt_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.bt_Nuevo.TabIndex = 11
        Me.bt_Nuevo.Text = "Nuevo"
        Me.bt_Nuevo.UseVisualStyleBackColor = True
        '
        'dg_consulta_usuario
        '
        Me.dg_consulta_usuario.AllowUserToResizeColumns = False
        Me.dg_consulta_usuario.AllowUserToResizeRows = False
        Me.dg_consulta_usuario.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_consulta_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_consulta_usuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.login, Me.tipo, Me.dni, Me.apellido, Me.nombre, Me.direccion, Me.telefono, Me.email, Me.id, Me.activo})
        Me.dg_consulta_usuario.Location = New System.Drawing.Point(10, 107)
        Me.dg_consulta_usuario.Name = "dg_consulta_usuario"
        Me.dg_consulta_usuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dg_consulta_usuario.RowHeadersVisible = False
        Me.dg_consulta_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_consulta_usuario.Size = New System.Drawing.Size(704, 196)
        Me.dg_consulta_usuario.TabIndex = 10
        '
        'login
        '
        Me.login.DataPropertyName = "us_login"
        Me.login.HeaderText = "Usuario"
        Me.login.Name = "login"
        Me.login.Width = 80
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "us_descrip"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 80
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.Width = 80
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.Width = 80
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 80
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 80
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.Width = 80
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "E-mail"
        Me.email.Name = "email"
        Me.email.Width = 80
        '
        'id
        '
        Me.id.DataPropertyName = "id_usuario"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'activo
        '
        Me.activo.DataPropertyName = "sn_activo"
        Me.activo.HeaderText = "Activo"
        Me.activo.Name = "activo"
        Me.activo.Width = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_nombre_usuario)
        Me.GroupBox1.Controls.Add(Me.rb_dni)
        Me.GroupBox1.Controls.Add(Me.tb_Buscar)
        Me.GroupBox1.Controls.Add(Me.bt_quitar)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 74)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'rb_nombre_usuario
        '
        Me.rb_nombre_usuario.AutoSize = True
        Me.rb_nombre_usuario.Location = New System.Drawing.Point(66, 15)
        Me.rb_nombre_usuario.Name = "rb_nombre_usuario"
        Me.rb_nombre_usuario.Size = New System.Drawing.Size(114, 17)
        Me.rb_nombre_usuario.TabIndex = 1
        Me.rb_nombre_usuario.Text = "Nombre de usuario"
        Me.rb_nombre_usuario.UseVisualStyleBackColor = True
        '
        'rb_dni
        '
        Me.rb_dni.AutoSize = True
        Me.rb_dni.Checked = True
        Me.rb_dni.Location = New System.Drawing.Point(16, 15)
        Me.rb_dni.Name = "rb_dni"
        Me.rb_dni.Size = New System.Drawing.Size(44, 17)
        Me.rb_dni.TabIndex = 0
        Me.rb_dni.TabStop = True
        Me.rb_dni.Text = "DNI"
        Me.rb_dni.UseVisualStyleBackColor = True
        '
        'tb_Buscar
        '
        Me.tb_Buscar.Location = New System.Drawing.Point(16, 38)
        Me.tb_Buscar.Name = "tb_Buscar"
        Me.tb_Buscar.Size = New System.Drawing.Size(232, 20)
        Me.tb_Buscar.TabIndex = 2
        '
        'bt_quitar
        '
        Me.bt_quitar.Location = New System.Drawing.Point(254, 35)
        Me.bt_quitar.Name = "bt_quitar"
        Me.bt_quitar.Size = New System.Drawing.Size(75, 23)
        Me.bt_quitar.TabIndex = 3
        Me.bt_quitar.Text = "Quitar Filtro"
        Me.bt_quitar.UseVisualStyleBackColor = True
        '
        'bt_Cerrar
        '
        Me.bt_Cerrar.Location = New System.Drawing.Point(639, 333)
        Me.bt_Cerrar.Name = "bt_Cerrar"
        Me.bt_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Cerrar.TabIndex = 15
        Me.bt_Cerrar.Text = "Salir"
        Me.bt_Cerrar.UseVisualStyleBackColor = True
        '
        'w_consultar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 368)
        Me.Controls.Add(Me.bt_Cerrar)
        Me.Controls.Add(Me.cb_ver_todos)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_Modificar)
        Me.Controls.Add(Me.bt_Nuevo)
        Me.Controls.Add(Me.dg_consulta_usuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_consultar_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "w_consultar_usuario"
        CType(Me.dg_consulta_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_ver_todos As CheckBox
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_Modificar As Button
    Friend WithEvents bt_Nuevo As Button
    Friend WithEvents dg_consulta_usuario As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_nombre_usuario As RadioButton
    Friend WithEvents rb_dni As RadioButton
    Friend WithEvents tb_Buscar As TextBox
    Friend WithEvents bt_quitar As Button
    Friend WithEvents login As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
    Friend WithEvents bt_Cerrar As Button
End Class
