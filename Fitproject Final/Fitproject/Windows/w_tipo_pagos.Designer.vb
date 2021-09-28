<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_tipo_pagos
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
        Me.dg_tipos = New System.Windows.Forms.DataGridView()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.bt_cerrar = New System.Windows.Forms.Button()
        Me.tb_agregar = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dg_tipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_tipos
        '
        Me.dg_tipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descripcion})
        Me.dg_tipos.Location = New System.Drawing.Point(12, 70)
        Me.dg_tipos.Name = "dg_tipos"
        Me.dg_tipos.Size = New System.Drawing.Size(248, 214)
        Me.dg_tipos.TabIndex = 0
        '
        'bt_agregar
        '
        Me.bt_agregar.Location = New System.Drawing.Point(314, 21)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(91, 37)
        Me.bt_agregar.TabIndex = 1
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'bt_cerrar
        '
        Me.bt_cerrar.Location = New System.Drawing.Point(314, 247)
        Me.bt_cerrar.Name = "bt_cerrar"
        Me.bt_cerrar.Size = New System.Drawing.Size(91, 37)
        Me.bt_cerrar.TabIndex = 2
        Me.bt_cerrar.Text = "Cerrar"
        Me.bt_cerrar.UseVisualStyleBackColor = True
        '
        'tb_agregar
        '
        Me.tb_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_agregar.Location = New System.Drawing.Point(6, 25)
        Me.tb_agregar.Name = "tb_agregar"
        Me.tb_agregar.Size = New System.Drawing.Size(248, 21)
        Me.tb_agregar.TabIndex = 3
        '
        'id
        '
        Me.id.DataPropertyName = "id_tipo"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_agregar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Tipo de Pago"
        '
        'w_tipo_pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 296)
        Me.Controls.Add(Me.bt_cerrar)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.dg_tipos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "w_tipo_pagos"
        Me.Text = "w_tipo_pagos"
        CType(Me.dg_tipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_tipos As DataGridView
    Friend WithEvents bt_agregar As Button
    Friend WithEvents bt_cerrar As Button
    Friend WithEvents tb_agregar As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
