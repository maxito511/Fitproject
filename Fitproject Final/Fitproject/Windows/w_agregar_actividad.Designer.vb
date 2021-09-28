<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_agregar_actividad
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
        Me.L_Nombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_activo = New System.Windows.Forms.CheckBox()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_Agregar = New System.Windows.Forms.Button()
        Me.tb_precio = New System.Windows.Forms.TextBox()
        Me.tb_duracion = New System.Windows.Forms.TextBox()
        Me.tb_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_Duracion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_Nombre
        '
        Me.L_Nombre.AutoSize = True
        Me.L_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Nombre.Location = New System.Drawing.Point(129, 37)
        Me.L_Nombre.Name = "L_Nombre"
        Me.L_Nombre.Size = New System.Drawing.Size(76, 16)
        Me.L_Nombre.TabIndex = 0
        Me.L_Nombre.Text = "Nombre: (*)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_activo)
        Me.GroupBox1.Controls.Add(Me.bt_guardar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.bt_Cancelar)
        Me.GroupBox1.Controls.Add(Me.bt_Agregar)
        Me.GroupBox1.Controls.Add(Me.tb_precio)
        Me.GroupBox1.Controls.Add(Me.tb_duracion)
        Me.GroupBox1.Controls.Add(Me.tb_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.L_Duracion)
        Me.GroupBox1.Controls.Add(Me.L_Nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 287)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de la Actividad"
        '
        'cb_activo
        '
        Me.cb_activo.AutoSize = True
        Me.cb_activo.Checked = True
        Me.cb_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_activo.Location = New System.Drawing.Point(230, 207)
        Me.cb_activo.Name = "cb_activo"
        Me.cb_activo.Size = New System.Drawing.Size(65, 17)
        Me.cb_activo.TabIndex = 15
        Me.cb_activo.Text = "ACTIVO"
        Me.cb_activo.UseVisualStyleBackColor = True
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(130, 247)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 14
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CONSULTAR ACTIVIDADES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Horas Semanales"
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Location = New System.Drawing.Point(556, 247)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Cancelar.TabIndex = 9
        Me.bt_Cancelar.Text = "SALIR"
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_Agregar
        '
        Me.bt_Agregar.Location = New System.Drawing.Point(120, 247)
        Me.bt_Agregar.Name = "bt_Agregar"
        Me.bt_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Agregar.TabIndex = 8
        Me.bt_Agregar.Text = "AGREGAR"
        Me.bt_Agregar.UseVisualStyleBackColor = True
        '
        'tb_precio
        '
        Me.tb_precio.Location = New System.Drawing.Point(230, 162)
        Me.tb_precio.Name = "tb_precio"
        Me.tb_precio.Size = New System.Drawing.Size(100, 20)
        Me.tb_precio.TabIndex = 6
        '
        'tb_duracion
        '
        Me.tb_duracion.Location = New System.Drawing.Point(230, 99)
        Me.tb_duracion.Name = "tb_duracion"
        Me.tb_duracion.Size = New System.Drawing.Size(100, 20)
        Me.tb_duracion.TabIndex = 5
        '
        'tb_Nombre
        '
        Me.tb_Nombre.Location = New System.Drawing.Point(230, 37)
        Me.tb_Nombre.Name = "tb_Nombre"
        Me.tb_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.tb_Nombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio: (*)"
        '
        'L_Duracion
        '
        Me.L_Duracion.AutoSize = True
        Me.L_Duracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Duracion.Location = New System.Drawing.Point(121, 99)
        Me.L_Duracion.Name = "L_Duracion"
        Me.L_Duracion.Size = New System.Drawing.Size(81, 16)
        Me.L_Duracion.TabIndex = 1
        Me.L_Duracion.Text = "Duracion: (*)"
        '
        'w_agregar_actividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 329)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_agregar_actividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Actividad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents L_Nombre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bt_Cancelar As Button
    Friend WithEvents bt_Agregar As Button
    Friend WithEvents tb_precio As TextBox
    Friend WithEvents tb_duracion As TextBox
    Friend WithEvents tb_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents L_Duracion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_activo As CheckBox
    Friend WithEvents bt_guardar As Button
End Class
