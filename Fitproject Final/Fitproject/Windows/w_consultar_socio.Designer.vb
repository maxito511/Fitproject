<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_consultar_socio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(w_consultar_socio))
        Me.tb_buscar = New System.Windows.Forms.TextBox()
        Me.dg_consulta_socio = New System.Windows.Forms.DataGridView()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.gb_buscar = New System.Windows.Forms.GroupBox()
        Me.rb_apeynom = New System.Windows.Forms.RadioButton()
        Me.bt_quitar = New System.Windows.Forms.Button()
        Me.rb_dni = New System.Windows.Forms.RadioButton()
        Me.dg_act_socio = New System.Windows.Forms.DataGridView()
        Me.act = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.pb_socio = New System.Windows.Forms.PictureBox()
        Me.bt_update = New System.Windows.Forms.Button()
        Me.cb_todos = New System.Windows.Forms.CheckBox()
        Me.bt_excel = New System.Windows.Forms.Button()
        CType(Me.dg_consulta_socio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_buscar.SuspendLayout()
        CType(Me.dg_act_socio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_socio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_buscar
        '
        Me.tb_buscar.Location = New System.Drawing.Point(21, 40)
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(234, 20)
        Me.tb_buscar.TabIndex = 0
        '
        'dg_consulta_socio
        '
        Me.dg_consulta_socio.AllowUserToAddRows = False
        Me.dg_consulta_socio.AllowUserToResizeColumns = False
        Me.dg_consulta_socio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_consulta_socio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_consulta_socio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_consulta_socio.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_consulta_socio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dg_consulta_socio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dg_consulta_socio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_consulta_socio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.apellido, Me.nombre, Me.direccion, Me.telefono, Me.Fecha, Me.email, Me.id, Me.activo})
        Me.dg_consulta_socio.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dg_consulta_socio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dg_consulta_socio.Location = New System.Drawing.Point(12, 102)
        Me.dg_consulta_socio.MultiSelect = False
        Me.dg_consulta_socio.Name = "dg_consulta_socio"
        Me.dg_consulta_socio.RowHeadersVisible = False
        Me.dg_consulta_socio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_consulta_socio.Size = New System.Drawing.Size(662, 237)
        Me.dg_consulta_socio.TabIndex = 2
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dni.Width = 80
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.apellido.Width = 90
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombre.Width = 90
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.direccion.Width = 90
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.telefono.Width = 80
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "fe_nacimiento"
        Me.Fecha.HeaderText = "Fecha nacimiento"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.Width = 80
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "E-mail"
        Me.email.Name = "email"
        Me.email.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.email.Width = 80
        '
        'id
        '
        Me.id.DataPropertyName = "id_socio"
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(792, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 345)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'bt_modificar
        '
        Me.bt_modificar.Location = New System.Drawing.Point(94, 345)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(75, 35)
        Me.bt_modificar.TabIndex = 4
        Me.bt_modificar.Text = "Modificar"
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'gb_buscar
        '
        Me.gb_buscar.Controls.Add(Me.rb_apeynom)
        Me.gb_buscar.Controls.Add(Me.bt_quitar)
        Me.gb_buscar.Controls.Add(Me.rb_dni)
        Me.gb_buscar.Controls.Add(Me.tb_buscar)
        Me.gb_buscar.Location = New System.Drawing.Point(12, 5)
        Me.gb_buscar.Name = "gb_buscar"
        Me.gb_buscar.Size = New System.Drawing.Size(351, 74)
        Me.gb_buscar.TabIndex = 6
        Me.gb_buscar.TabStop = False
        Me.gb_buscar.Text = "Buscar"
        '
        'rb_apeynom
        '
        Me.rb_apeynom.AutoSize = True
        Me.rb_apeynom.Location = New System.Drawing.Point(81, 19)
        Me.rb_apeynom.Name = "rb_apeynom"
        Me.rb_apeynom.Size = New System.Drawing.Size(111, 17)
        Me.rb_apeynom.TabIndex = 8
        Me.rb_apeynom.Text = "Apellido o Nombre"
        Me.rb_apeynom.UseVisualStyleBackColor = True
        '
        'bt_quitar
        '
        Me.bt_quitar.Location = New System.Drawing.Point(261, 37)
        Me.bt_quitar.Name = "bt_quitar"
        Me.bt_quitar.Size = New System.Drawing.Size(78, 23)
        Me.bt_quitar.TabIndex = 2
        Me.bt_quitar.Text = "Quitar Filtro"
        Me.bt_quitar.UseVisualStyleBackColor = True
        '
        'rb_dni
        '
        Me.rb_dni.AutoSize = True
        Me.rb_dni.Checked = True
        Me.rb_dni.Location = New System.Drawing.Point(21, 19)
        Me.rb_dni.Name = "rb_dni"
        Me.rb_dni.Size = New System.Drawing.Size(44, 17)
        Me.rb_dni.TabIndex = 7
        Me.rb_dni.TabStop = True
        Me.rb_dni.Text = "DNI"
        Me.rb_dni.UseVisualStyleBackColor = True
        '
        'dg_act_socio
        '
        Me.dg_act_socio.AllowUserToAddRows = False
        Me.dg_act_socio.AllowUserToDeleteRows = False
        Me.dg_act_socio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_act_socio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_act_socio.ColumnHeadersVisible = False
        Me.dg_act_socio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.act})
        Me.dg_act_socio.Enabled = False
        Me.dg_act_socio.Location = New System.Drawing.Point(680, 5)
        Me.dg_act_socio.Name = "dg_act_socio"
        Me.dg_act_socio.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_act_socio.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_act_socio.RowHeadersVisible = False
        Me.dg_act_socio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dg_act_socio.Size = New System.Drawing.Size(187, 154)
        Me.dg_act_socio.TabIndex = 7
        '
        'act
        '
        Me.act.DataPropertyName = "de_actividad"
        Me.act.HeaderText = "Actividad"
        Me.act.Name = "act"
        Me.act.ReadOnly = True
        Me.act.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Actividades: "
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(175, 345)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(75, 35)
        Me.bt_eliminar.TabIndex = 9
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'pb_socio
        '
        Me.pb_socio.BackgroundImage = CType(resources.GetObject("pb_socio.BackgroundImage"), System.Drawing.Image)
        Me.pb_socio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_socio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_socio.Location = New System.Drawing.Point(680, 180)
        Me.pb_socio.Name = "pb_socio"
        Me.pb_socio.Size = New System.Drawing.Size(187, 159)
        Me.pb_socio.TabIndex = 11
        Me.pb_socio.TabStop = False
        '
        'bt_update
        '
        Me.bt_update.Location = New System.Drawing.Point(533, 357)
        Me.bt_update.Name = "bt_update"
        Me.bt_update.Size = New System.Drawing.Size(75, 23)
        Me.bt_update.TabIndex = 12
        Me.bt_update.Text = "Actualizar"
        Me.bt_update.UseVisualStyleBackColor = True
        Me.bt_update.Visible = False
        '
        'cb_todos
        '
        Me.cb_todos.AutoSize = True
        Me.cb_todos.Location = New System.Drawing.Point(599, 79)
        Me.cb_todos.Name = "cb_todos"
        Me.cb_todos.Size = New System.Drawing.Size(75, 17)
        Me.cb_todos.TabIndex = 13
        Me.cb_todos.Text = "Ver Todos"
        Me.cb_todos.UseVisualStyleBackColor = True
        '
        'bt_excel
        '
        Me.bt_excel.BackgroundImage = CType(resources.GetObject("bt_excel.BackgroundImage"), System.Drawing.Image)
        Me.bt_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_excel.Location = New System.Drawing.Point(680, 346)
        Me.bt_excel.Name = "bt_excel"
        Me.bt_excel.Size = New System.Drawing.Size(38, 35)
        Me.bt_excel.TabIndex = 14
        Me.bt_excel.UseVisualStyleBackColor = True
        '
        'w_consultar_socio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 393)
        Me.Controls.Add(Me.bt_excel)
        Me.Controls.Add(Me.cb_todos)
        Me.Controls.Add(Me.bt_update)
        Me.Controls.Add(Me.pb_socio)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg_act_socio)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dg_consulta_socio)
        Me.Controls.Add(Me.gb_buscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_consultar_socio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Consultar Socio :."
        CType(Me.dg_consulta_socio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_buscar.ResumeLayout(False)
        Me.gb_buscar.PerformLayout()
        CType(Me.dg_act_socio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_socio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_buscar As TextBox
    Friend WithEvents dg_consulta_socio As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents bt_modificar As Button
    Friend WithEvents gb_buscar As GroupBox
    Friend WithEvents bt_quitar As Button
    Friend WithEvents rb_apeynom As RadioButton
    Friend WithEvents rb_dni As RadioButton
    Friend WithEvents dg_act_socio As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents pb_socio As PictureBox
    Friend WithEvents bt_update As Button
    Friend WithEvents act As DataGridViewTextBoxColumn
    Friend WithEvents cb_todos As CheckBox
    Friend WithEvents bt_excel As Button
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
End Class
