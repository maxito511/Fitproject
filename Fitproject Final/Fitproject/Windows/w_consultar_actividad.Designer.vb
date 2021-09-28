<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class w_consultar_actividad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tb_Buscar = New System.Windows.Forms.TextBox()
        Me.bt_quitar = New System.Windows.Forms.Button()
        Me.dg_consulta_actividades = New System.Windows.Forms.DataGridView()
        Me.bt_Nuevo = New System.Windows.Forms.Button()
        Me.bt_Modificar = New System.Windows.Forms.Button()
        Me.bt_Cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_hasta = New System.Windows.Forms.TextBox()
        Me.tb_desde = New System.Windows.Forms.TextBox()
        Me.bt_filtrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_precio = New System.Windows.Forms.RadioButton()
        Me.rb_entrenador = New System.Windows.Forms.RadioButton()
        Me.rb_horas = New System.Windows.Forms.RadioButton()
        Me.rb_actividad = New System.Windows.Forms.RadioButton()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.cb_ver_todos = New System.Windows.Forms.CheckBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn_activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_consulta_actividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_Buscar
        '
        Me.tb_Buscar.Location = New System.Drawing.Point(24, 74)
        Me.tb_Buscar.Name = "tb_Buscar"
        Me.tb_Buscar.Size = New System.Drawing.Size(288, 20)
        Me.tb_Buscar.TabIndex = 0
        '
        'bt_quitar
        '
        Me.bt_quitar.Location = New System.Drawing.Point(318, 72)
        Me.bt_quitar.Name = "bt_quitar"
        Me.bt_quitar.Size = New System.Drawing.Size(75, 22)
        Me.bt_quitar.TabIndex = 1
        Me.bt_quitar.Text = "Quitar Filtro"
        Me.bt_quitar.UseVisualStyleBackColor = True
        '
        'dg_consulta_actividades
        '
        Me.dg_consulta_actividades.AllowUserToResizeColumns = False
        Me.dg_consulta_actividades.AllowUserToResizeRows = False
        Me.dg_consulta_actividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_consulta_actividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.id, Me.sn_activo})
        Me.dg_consulta_actividades.Location = New System.Drawing.Point(12, 177)
        Me.dg_consulta_actividades.Name = "dg_consulta_actividades"
        Me.dg_consulta_actividades.RowHeadersVisible = False
        Me.dg_consulta_actividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_consulta_actividades.Size = New System.Drawing.Size(403, 193)
        Me.dg_consulta_actividades.TabIndex = 2
        '
        'bt_Nuevo
        '
        Me.bt_Nuevo.Location = New System.Drawing.Point(12, 376)
        Me.bt_Nuevo.Name = "bt_Nuevo"
        Me.bt_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.bt_Nuevo.TabIndex = 3
        Me.bt_Nuevo.Text = "Nuevo"
        Me.bt_Nuevo.UseVisualStyleBackColor = True
        '
        'bt_Modificar
        '
        Me.bt_Modificar.Location = New System.Drawing.Point(97, 376)
        Me.bt_Modificar.Name = "bt_Modificar"
        Me.bt_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Modificar.TabIndex = 4
        Me.bt_Modificar.Text = "Modificar"
        Me.bt_Modificar.UseVisualStyleBackColor = True
        '
        'bt_Cerrar
        '
        Me.bt_Cerrar.Location = New System.Drawing.Point(340, 376)
        Me.bt_Cerrar.Name = "bt_Cerrar"
        Me.bt_Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Cerrar.TabIndex = 5
        Me.bt_Cerrar.Text = "Cerrar"
        Me.bt_Cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_hasta)
        Me.GroupBox1.Controls.Add(Me.tb_desde)
        Me.GroupBox1.Controls.Add(Me.bt_filtrar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rb_precio)
        Me.GroupBox1.Controls.Add(Me.tb_Buscar)
        Me.GroupBox1.Controls.Add(Me.rb_entrenador)
        Me.GroupBox1.Controls.Add(Me.rb_horas)
        Me.GroupBox1.Controls.Add(Me.rb_actividad)
        Me.GroupBox1.Controls.Add(Me.bt_quitar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'tb_hasta
        '
        Me.tb_hasta.Enabled = False
        Me.tb_hasta.Location = New System.Drawing.Point(166, 48)
        Me.tb_hasta.Name = "tb_hasta"
        Me.tb_hasta.Size = New System.Drawing.Size(37, 20)
        Me.tb_hasta.TabIndex = 12
        '
        'tb_desde
        '
        Me.tb_desde.Enabled = False
        Me.tb_desde.Location = New System.Drawing.Point(73, 48)
        Me.tb_desde.Name = "tb_desde"
        Me.tb_desde.Size = New System.Drawing.Size(39, 20)
        Me.tb_desde.TabIndex = 11
        '
        'bt_filtrar
        '
        Me.bt_filtrar.Location = New System.Drawing.Point(209, 48)
        Me.bt_filtrar.Name = "bt_filtrar"
        Me.bt_filtrar.Size = New System.Drawing.Size(75, 21)
        Me.bt_filtrar.TabIndex = 10
        Me.bt_filtrar.Text = "Filtrar"
        Me.bt_filtrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desde:"
        '
        'rb_precio
        '
        Me.rb_precio.AutoSize = True
        Me.rb_precio.Location = New System.Drawing.Point(312, 20)
        Me.rb_precio.Name = "rb_precio"
        Me.rb_precio.Size = New System.Drawing.Size(55, 17)
        Me.rb_precio.TabIndex = 5
        Me.rb_precio.TabStop = True
        Me.rb_precio.Text = "Precio"
        Me.rb_precio.UseVisualStyleBackColor = True
        '
        'rb_entrenador
        '
        Me.rb_entrenador.AutoSize = True
        Me.rb_entrenador.Location = New System.Drawing.Point(99, 19)
        Me.rb_entrenador.Name = "rb_entrenador"
        Me.rb_entrenador.Size = New System.Drawing.Size(77, 17)
        Me.rb_entrenador.TabIndex = 4
        Me.rb_entrenador.TabStop = True
        Me.rb_entrenador.Text = "Entrenador"
        Me.rb_entrenador.UseVisualStyleBackColor = True
        '
        'rb_horas
        '
        Me.rb_horas.AutoSize = True
        Me.rb_horas.Location = New System.Drawing.Point(190, 19)
        Me.rb_horas.Name = "rb_horas"
        Me.rb_horas.Size = New System.Drawing.Size(108, 17)
        Me.rb_horas.TabIndex = 3
        Me.rb_horas.TabStop = True
        Me.rb_horas.Text = "Horas Semanales"
        Me.rb_horas.UseVisualStyleBackColor = True
        '
        'rb_actividad
        '
        Me.rb_actividad.AutoSize = True
        Me.rb_actividad.Location = New System.Drawing.Point(24, 20)
        Me.rb_actividad.Name = "rb_actividad"
        Me.rb_actividad.Size = New System.Drawing.Size(69, 17)
        Me.rb_actividad.TabIndex = 2
        Me.rb_actividad.TabStop = True
        Me.rb_actividad.Text = "Actividad"
        Me.rb_actividad.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(187, 376)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.bt_eliminar.TabIndex = 7
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'cb_ver_todos
        '
        Me.cb_ver_todos.AutoSize = True
        Me.cb_ver_todos.Location = New System.Drawing.Point(324, 144)
        Me.cb_ver_todos.Name = "cb_ver_todos"
        Me.cb_ver_todos.Size = New System.Drawing.Size(75, 17)
        Me.cb_ver_todos.TabIndex = 8
        Me.cb_ver_todos.Text = "Ver Todos"
        Me.cb_ver_todos.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "de_actividad"
        Me.Column1.HeaderText = "ACTIVIDAD"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "duracion"
        Me.Column2.HeaderText = "HORAS SEMANALES"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "pr_actividad"
        Me.Column4.HeaderText = "PRECIO"
        Me.Column4.Name = "Column4"
        '
        'id
        '
        Me.id.DataPropertyName = "id_actividad"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'sn_activo
        '
        Me.sn_activo.DataPropertyName = "sn_activo"
        Me.sn_activo.HeaderText = "Activo"
        Me.sn_activo.Name = "sn_activo"
        '
        'w_consultar_actividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 439)
        Me.Controls.Add(Me.cb_ver_todos)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_Cerrar)
        Me.Controls.Add(Me.bt_Modificar)
        Me.Controls.Add(Me.bt_Nuevo)
        Me.Controls.Add(Me.dg_consulta_actividades)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_consultar_actividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Actividad"
        CType(Me.dg_consulta_actividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Buscar As TextBox
    Friend WithEvents bt_quitar As Button
    Friend WithEvents dg_consulta_actividades As DataGridView
    Friend WithEvents bt_Nuevo As Button
    Friend WithEvents bt_Modificar As Button
    Friend WithEvents bt_Cerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_precio As RadioButton
    Friend WithEvents rb_entrenador As RadioButton
    Friend WithEvents rb_horas As RadioButton
    Friend WithEvents rb_actividad As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_filtrar As Button
    Friend WithEvents tb_hasta As TextBox
    Friend WithEvents tb_desde As TextBox
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents cb_ver_todos As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents sn_activo As DataGridViewTextBoxColumn
End Class
