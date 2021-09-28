<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_consultar_pago
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
        Me.dg_pago = New System.Windows.Forms.DataGridView()
        Me.id_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe_vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_cerrar = New System.Windows.Forms.Button()
        Me.bt_nuevo = New System.Windows.Forms.Button()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rb_fecha = New System.Windows.Forms.RadioButton()
        Me.rb_tipo = New System.Windows.Forms.RadioButton()
        Me.rb_nomyape = New System.Windows.Forms.RadioButton()
        Me.rb_dni = New System.Windows.Forms.RadioButton()
        Me.bt_quitar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        CType(Me.dg_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_pago
        '
        Me.dg_pago.AllowUserToAddRows = False
        Me.dg_pago.AllowUserToDeleteRows = False
        Me.dg_pago.AllowUserToResizeColumns = False
        Me.dg_pago.AllowUserToResizeRows = False
        Me.dg_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_factura, Me.Apellido, Me.Nombre, Me.monto, Me.fe_factura, Me.fe_vencimiento})
        Me.dg_pago.Location = New System.Drawing.Point(12, 97)
        Me.dg_pago.Name = "dg_pago"
        Me.dg_pago.ReadOnly = True
        Me.dg_pago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_pago.Size = New System.Drawing.Size(646, 238)
        Me.dg_pago.TabIndex = 0
        '
        'id_factura
        '
        Me.id_factura.DataPropertyName = "id_factura"
        Me.id_factura.HeaderText = "Nro.Factura"
        Me.id_factura.Name = "id_factura"
        Me.id_factura.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'monto
        '
        Me.monto.DataPropertyName = "importe"
        Me.monto.HeaderText = "Total"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'fe_factura
        '
        Me.fe_factura.DataPropertyName = "fe_factura"
        Me.fe_factura.HeaderText = "Fecha Factura"
        Me.fe_factura.Name = "fe_factura"
        Me.fe_factura.ReadOnly = True
        '
        'fe_vencimiento
        '
        Me.fe_vencimiento.DataPropertyName = "fe_vencimiento"
        Me.fe_vencimiento.HeaderText = "Fecha Vencimiento"
        Me.fe_vencimiento.Name = "fe_vencimiento"
        Me.fe_vencimiento.ReadOnly = True
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Location = New System.Drawing.Point(690, 351)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cerrar.TabIndex = 1
        Me.bt_cerrar.Text = "Cerrar"
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'bt_nuevo
        '
        Me.bt_nuevo.Location = New System.Drawing.Point(12, 351)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.bt_nuevo.TabIndex = 2
        Me.bt_nuevo.Text = "Nuevo"
        Me.bt_nuevo.UseVisualStyleBackColor = True
        '
        'bt_modificar
        '
        Me.bt_modificar.Location = New System.Drawing.Point(93, 351)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(75, 23)
        Me.bt_modificar.TabIndex = 3
        Me.bt_modificar.Text = "Modificar"
        Me.bt_modificar.UseVisualStyleBackColor = True
        Me.bt_modificar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_buscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dt_hasta)
        Me.GroupBox1.Controls.Add(Me.dt_desde)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.rb_fecha)
        Me.GroupBox1.Controls.Add(Me.rb_tipo)
        Me.GroupBox1.Controls.Add(Me.rb_nomyape)
        Me.GroupBox1.Controls.Add(Me.rb_dni)
        Me.GroupBox1.Controls.Add(Me.bt_quitar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 78)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'bt_buscar
        '
        Me.bt_buscar.Location = New System.Drawing.Point(660, 43)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(75, 23)
        Me.bt_buscar.TabIndex = 15
        Me.bt_buscar.Text = "Buscar"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(603, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "HASTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DESDE"
        '
        'dt_hasta
        '
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(652, 17)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(83, 20)
        Me.dt_hasta.TabIndex = 12
        '
        'dt_desde
        '
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(514, 15)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(83, 20)
        Me.dt_desde.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 20)
        Me.TextBox1.TabIndex = 10
        '
        'rb_fecha
        '
        Me.rb_fecha.AutoSize = True
        Me.rb_fecha.Location = New System.Drawing.Point(127, 19)
        Me.rb_fecha.Name = "rb_fecha"
        Me.rb_fecha.Size = New System.Drawing.Size(55, 17)
        Me.rb_fecha.TabIndex = 9
        Me.rb_fecha.Text = "Fecha"
        Me.rb_fecha.UseVisualStyleBackColor = True
        '
        'rb_tipo
        '
        Me.rb_tipo.AutoSize = True
        Me.rb_tipo.Location = New System.Drawing.Point(310, 17)
        Me.rb_tipo.Name = "rb_tipo"
        Me.rb_tipo.Size = New System.Drawing.Size(96, 17)
        Me.rb_tipo.TabIndex = 8
        Me.rb_tipo.Text = "Forma de pago"
        Me.rb_tipo.UseVisualStyleBackColor = True
        Me.rb_tipo.Visible = False
        '
        'rb_nomyape
        '
        Me.rb_nomyape.AutoSize = True
        Me.rb_nomyape.Location = New System.Drawing.Point(57, 19)
        Me.rb_nomyape.Name = "rb_nomyape"
        Me.rb_nomyape.Size = New System.Drawing.Size(52, 17)
        Me.rb_nomyape.TabIndex = 7
        Me.rb_nomyape.Text = "Socio"
        Me.rb_nomyape.UseVisualStyleBackColor = True
        '
        'rb_dni
        '
        Me.rb_dni.AutoSize = True
        Me.rb_dni.Checked = True
        Me.rb_dni.Location = New System.Drawing.Point(7, 20)
        Me.rb_dni.Name = "rb_dni"
        Me.rb_dni.Size = New System.Drawing.Size(44, 17)
        Me.rb_dni.TabIndex = 6
        Me.rb_dni.TabStop = True
        Me.rb_dni.Text = "DNI"
        Me.rb_dni.UseVisualStyleBackColor = True
        '
        'bt_quitar
        '
        Me.bt_quitar.Location = New System.Drawing.Point(300, 49)
        Me.bt_quitar.Name = "bt_quitar"
        Me.bt_quitar.Size = New System.Drawing.Size(75, 23)
        Me.bt_quitar.TabIndex = 5
        Me.bt_quitar.Text = "Quitar Filtro"
        Me.bt_quitar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(174, 351)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.bt_eliminar.TabIndex = 5
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        Me.bt_eliminar.Visible = False
        '
        'w_consultar_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 396)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_nuevo)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.dg_pago)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_consultar_pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Pagos"
        CType(Me.dg_pago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_pago As DataGridView
    Friend WithEvents bt_cerrar As Button
    Friend WithEvents bt_nuevo As Button
    Friend WithEvents bt_modificar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents rb_fecha As RadioButton
    Friend WithEvents rb_tipo As RadioButton
    Friend WithEvents rb_nomyape As RadioButton
    Friend WithEvents rb_dni As RadioButton
    Friend WithEvents bt_quitar As Button
    Friend WithEvents bt_buscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents id_factura As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents fe_factura As DataGridViewTextBoxColumn
    Friend WithEvents fe_vencimiento As DataGridViewTextBoxColumn
End Class
