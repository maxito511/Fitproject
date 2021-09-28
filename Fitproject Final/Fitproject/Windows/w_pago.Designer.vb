<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class w_pago
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_buscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_pago = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.de_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pr_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_socio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.bt_consultar_pagos = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_efectivo = New System.Windows.Forms.TextBox()
        Me.tb_cambio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'tb_buscar
        '
        Me.tb_buscar.Location = New System.Drawing.Point(82, 25)
        Me.tb_buscar.MaxLength = 8
        Me.tb_buscar.Name = "tb_buscar"
        Me.tb_buscar.Size = New System.Drawing.Size(144, 20)
        Me.tb_buscar.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_buscar)
        Me.GroupBox1.Controls.Add(Me.tb_buscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese DNI"
        '
        'bt_buscar
        '
        Me.bt_buscar.Location = New System.Drawing.Point(232, 22)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(75, 23)
        Me.bt_buscar.TabIndex = 2
        Me.bt_buscar.Text = "BUSCAR"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(697, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(14, 349)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 4
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(200, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Ticket"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TOTAL: "
        '
        'dg_pago
        '
        Me.dg_pago.AllowUserToAddRows = False
        Me.dg_pago.AllowUserToDeleteRows = False
        Me.dg_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.nombre, Me.de_actividad, Me.pr_actividad, Me.id_socio, Me.id_actividad})
        Me.dg_pago.Location = New System.Drawing.Point(50, 121)
        Me.dg_pago.Name = "dg_pago"
        Me.dg_pago.ReadOnly = True
        Me.dg_pago.RowHeadersVisible = False
        Me.dg_pago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_pago.Size = New System.Drawing.Size(404, 154)
        Me.dg_pago.TabIndex = 7
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'de_actividad
        '
        Me.de_actividad.DataPropertyName = "de_actividad"
        Me.de_actividad.HeaderText = "Actividad"
        Me.de_actividad.Name = "de_actividad"
        Me.de_actividad.ReadOnly = True
        '
        'pr_actividad
        '
        Me.pr_actividad.DataPropertyName = "pr_actividad"
        Me.pr_actividad.HeaderText = "Importe"
        Me.pr_actividad.Name = "pr_actividad"
        Me.pr_actividad.ReadOnly = True
        '
        'id_socio
        '
        Me.id_socio.DataPropertyName = "id_socio"
        Me.id_socio.HeaderText = "id"
        Me.id_socio.Name = "id_socio"
        Me.id_socio.ReadOnly = True
        Me.id_socio.Visible = False
        '
        'id_actividad
        '
        Me.id_actividad.DataPropertyName = "id_actividad"
        Me.id_actividad.HeaderText = "id_actividad"
        Me.id_actividad.Name = "id_actividad"
        Me.id_actividad.ReadOnly = True
        Me.id_actividad.Visible = False
        '
        'tb_total
        '
        Me.tb_total.Enabled = False
        Me.tb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tb_total.Location = New System.Drawing.Point(602, 121)
        Me.tb_total.Multiline = True
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(125, 41)
        Me.tb_total.TabIndex = 1
        Me.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bt_consultar_pagos
        '
        Me.bt_consultar_pagos.Location = New System.Drawing.Point(95, 349)
        Me.bt_consultar_pagos.Name = "bt_consultar_pagos"
        Me.bt_consultar_pagos.Size = New System.Drawing.Size(99, 23)
        Me.bt_consultar_pagos.TabIndex = 6
        Me.bt_consultar_pagos.Text = "Consultar Pagos"
        Me.bt_consultar_pagos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ACTIVIDADES"
        '
        'tb_efectivo
        '
        Me.tb_efectivo.Enabled = False
        Me.tb_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_efectivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tb_efectivo.Location = New System.Drawing.Point(602, 189)
        Me.tb_efectivo.Multiline = True
        Me.tb_efectivo.Name = "tb_efectivo"
        Me.tb_efectivo.Size = New System.Drawing.Size(125, 31)
        Me.tb_efectivo.TabIndex = 2
        Me.tb_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_cambio
        '
        Me.tb_cambio.Enabled = False
        Me.tb_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cambio.ForeColor = System.Drawing.Color.Black
        Me.tb_cambio.Location = New System.Drawing.Point(602, 244)
        Me.tb_cambio.Multiline = True
        Me.tb_cambio.Name = "tb_cambio"
        Me.tb_cambio.Size = New System.Drawing.Size(125, 31)
        Me.tb_cambio.TabIndex = 3
        Me.tb_cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(488, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "EFECTIVO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(488, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "CAMBIO:"
        '
        'w_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 384)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_cambio)
        Me.Controls.Add(Me.tb_efectivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_consultar_pagos)
        Me.Controls.Add(Me.tb_total)
        Me.Controls.Add(Me.dg_pago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_pago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_buscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dg_pago As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_a_pagar As TextBox
    Friend WithEvents tb_pagado As TextBox
    Friend WithEvents bt_buscar As Button
    Friend WithEvents tb_total As TextBox
    Friend WithEvents bt_consultar_pagos As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_efectivo As TextBox
    Friend WithEvents tb_cambio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents de_actividad As DataGridViewTextBoxColumn
    Friend WithEvents pr_actividad As DataGridViewTextBoxColumn
    Friend WithEvents id_socio As DataGridViewTextBoxColumn
    Friend WithEvents id_actividad As DataGridViewTextBoxColumn
End Class
