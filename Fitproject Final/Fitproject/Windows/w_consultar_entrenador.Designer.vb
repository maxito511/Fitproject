<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_consultar_entrenador
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
        Me.tb_Buscar = New System.Windows.Forms.TextBox()
        Me.bt_quitar = New System.Windows.Forms.Button()
        Me.dg_consulta_entrenador = New System.Windows.Forms.DataGridView()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_Nuevo = New System.Windows.Forms.Button()
        Me.bt_Modificar = New System.Windows.Forms.Button()
        Me.bt_Cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_apeynom = New System.Windows.Forms.RadioButton()
        Me.rb_dni = New System.Windows.Forms.RadioButton()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.dg_actividades_entrenador = New System.Windows.Forms.DataGridView()
        Me.actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_ver_todos = New System.Windows.Forms.CheckBox()
        CType(Me.dg_consulta_entrenador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_actividades_entrenador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'dg_consulta_entrenador
        '
        Me.dg_consulta_entrenador.AllowUserToResizeColumns = False
        Me.dg_consulta_entrenador.AllowUserToResizeRows = False
        Me.dg_consulta_entrenador.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_consulta_entrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_consulta_entrenador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.apellido, Me.nombre, Me.direccion, Me.telefono, Me.email, Me.id, Me.sexo, Me.fe_nacimiento, Me.activo})
        Me.dg_consulta_entrenador.Location = New System.Drawing.Point(13, 92)
        Me.dg_consulta_entrenador.Name = "dg_consulta_entrenador"
        Me.dg_consulta_entrenador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dg_consulta_entrenador.RowHeadersVisible = False
        Me.dg_consulta_entrenador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_consulta_entrenador.Size = New System.Drawing.Size(704, 196)
        Me.dg_consulta_entrenador.TabIndex = 1
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
        Me.id.DataPropertyName = "id_entrenador"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'sexo
        '
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.Width = 80
        '
        'fe_nacimiento
        '
        Me.fe_nacimiento.DataPropertyName = "fe_nacimiento"
        Me.fe_nacimiento.HeaderText = "Fecha de Nacimiento"
        Me.fe_nacimiento.Name = "fe_nacimiento"
        Me.fe_nacimiento.Width = 80
        '
        'activo
        '
        Me.activo.DataPropertyName = "sn_activo"
        Me.activo.HeaderText = "Activo"
        Me.activo.Name = "activo"
        Me.activo.Width = 50
        '
        'bt_Nuevo
        '
        Me.bt_Nuevo.Location = New System.Drawing.Point(12, 313)
        Me.bt_Nuevo.Name = "bt_Nuevo"
        Me.bt_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.bt_Nuevo.TabIndex = 2
        Me.bt_Nuevo.Text = "Nuevo"
        Me.bt_Nuevo.UseVisualStyleBackColor = True
        '
        'bt_Modificar
        '
        Me.bt_Modificar.Location = New System.Drawing.Point(94, 313)
        Me.bt_Modificar.Name = "bt_Modificar"
        Me.bt_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Modificar.TabIndex = 3
        Me.bt_Modificar.Text = "Modificar"
        Me.bt_Modificar.UseVisualStyleBackColor = True
        '
        'bt_Cerrar
        '
        Me.bt_Cerrar.Location = New System.Drawing.Point(807, 313)
        Me.bt_Cerrar.Name = "bt_Cerrar"
        Me.bt_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Cerrar.TabIndex = 4
        Me.bt_Cerrar.Text = "Cerrar"
        Me.bt_Cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_apeynom)
        Me.GroupBox1.Controls.Add(Me.rb_dni)
        Me.GroupBox1.Controls.Add(Me.tb_Buscar)
        Me.GroupBox1.Controls.Add(Me.bt_quitar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'rb_apeynom
        '
        Me.rb_apeynom.AutoSize = True
        Me.rb_apeynom.Location = New System.Drawing.Point(66, 15)
        Me.rb_apeynom.Name = "rb_apeynom"
        Me.rb_apeynom.Size = New System.Drawing.Size(111, 17)
        Me.rb_apeynom.TabIndex = 1
        Me.rb_apeynom.Text = "Apellido o Nombre"
        Me.rb_apeynom.UseVisualStyleBackColor = True
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
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(185, 313)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.bt_eliminar.TabIndex = 5
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'dg_actividades_entrenador
        '
        Me.dg_actividades_entrenador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_actividades_entrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_actividades_entrenador.ColumnHeadersVisible = False
        Me.dg_actividades_entrenador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.actividad})
        Me.dg_actividades_entrenador.Location = New System.Drawing.Point(734, 92)
        Me.dg_actividades_entrenador.Name = "dg_actividades_entrenador"
        Me.dg_actividades_entrenador.RowHeadersVisible = False
        Me.dg_actividades_entrenador.Size = New System.Drawing.Size(148, 113)
        Me.dg_actividades_entrenador.TabIndex = 6
        '
        'actividad
        '
        Me.actividad.DataPropertyName = "de_actividad"
        Me.actividad.HeaderText = "Actividad"
        Me.actividad.Name = "actividad"
        Me.actividad.Width = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(753, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ACTIVIDADES: "
        '
        'cb_ver_todos
        '
        Me.cb_ver_todos.AutoSize = True
        Me.cb_ver_todos.Location = New System.Drawing.Point(630, 69)
        Me.cb_ver_todos.Name = "cb_ver_todos"
        Me.cb_ver_todos.Size = New System.Drawing.Size(75, 17)
        Me.cb_ver_todos.TabIndex = 8
        Me.cb_ver_todos.Text = "Ver Todos"
        Me.cb_ver_todos.UseVisualStyleBackColor = True
        '
        'w_consultar_entrenador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 354)
        Me.Controls.Add(Me.cb_ver_todos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg_actividades_entrenador)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_Cerrar)
        Me.Controls.Add(Me.bt_Modificar)
        Me.Controls.Add(Me.bt_Nuevo)
        Me.Controls.Add(Me.dg_consulta_entrenador)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_consultar_entrenador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Entrenador"
        CType(Me.dg_consulta_entrenador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_actividades_entrenador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Buscar As TextBox
    Friend WithEvents bt_quitar As Button
    Friend WithEvents dg_consulta_entrenador As DataGridView
    Friend WithEvents bt_Nuevo As Button
    Friend WithEvents bt_Modificar As Button
    Friend WithEvents bt_Cerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_apeynom As RadioButton
    Friend WithEvents rb_dni As RadioButton
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents dg_actividades_entrenador As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_ver_todos As CheckBox
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents fe_nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
    Friend WithEvents actividad As DataGridViewTextBoxColumn
End Class
