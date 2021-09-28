<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(w_backup))
        Me.pb_backup = New System.Windows.Forms.PictureBox()
        Me.bt_backup = New System.Windows.Forms.Button()
        CType(Me.pb_backup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_backup
        '
        Me.pb_backup.Image = CType(resources.GetObject("pb_backup.Image"), System.Drawing.Image)
        Me.pb_backup.Location = New System.Drawing.Point(41, 12)
        Me.pb_backup.Name = "pb_backup"
        Me.pb_backup.Size = New System.Drawing.Size(205, 191)
        Me.pb_backup.TabIndex = 0
        Me.pb_backup.TabStop = False
        '
        'bt_backup
        '
        Me.bt_backup.Location = New System.Drawing.Point(83, 221)
        Me.bt_backup.Name = "bt_backup"
        Me.bt_backup.Size = New System.Drawing.Size(124, 64)
        Me.bt_backup.TabIndex = 1
        Me.bt_backup.Text = "BackUp"
        Me.bt_backup.UseVisualStyleBackColor = True
        '
        'w_backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 306)
        Me.Controls.Add(Me.bt_backup)
        Me.Controls.Add(Me.pb_backup)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackUp"
        CType(Me.pb_backup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb_backup As PictureBox
    Friend WithEvents bt_backup As Button
End Class
