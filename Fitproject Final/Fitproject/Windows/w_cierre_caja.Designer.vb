<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_cierre_caja
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.pagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cierre_caja_Dataset = New Fitproject.cierre_caja_Dataset()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pagosTableAdapter = New Fitproject.cierre_caja_DatasetTableAdapters.pagosTableAdapter()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.pagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cierre_caja_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pagosBindingSource
        '
        Me.pagosBindingSource.DataMember = "pagos"
        Me.pagosBindingSource.DataSource = Me.cierre_caja_Dataset
        '
        'cierre_caja_Dataset
        '
        Me.cierre_caja_Dataset.DataSetName = "cierre_caja_Dataset"
        Me.cierre_caja_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "cierre_caja"
        ReportDataSource3.Value = Me.pagosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Fitproject.r_cierre_caja.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 98)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(727, 565)
        Me.ReportViewer1.TabIndex = 0
        '
        'pagosTableAdapter
        '
        Me.pagosTableAdapter.ClearBeforeFill = True
        '
        'bt_buscar
        '
        Me.bt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.bt_buscar.Location = New System.Drawing.Point(331, 21)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(75, 26)
        Me.bt_buscar.TabIndex = 3
        Me.bt_buscar.Text = "BUSCAR"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "REPORTE DE PAGOS"
        '
        'dt_desde
        '
        Me.dt_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(214, 61)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(85, 22)
        Me.dt_desde.TabIndex = 5
        Me.dt_desde.Value = New Date(2017, 11, 1, 0, 0, 0, 0)
        '
        'dt_hasta
        '
        Me.dt_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(367, 60)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(87, 22)
        Me.dt_hasta.TabIndex = 6
        Me.dt_hasta.Value = New Date(2017, 11, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DESDE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(305, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "HASTA:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_buscar)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 56)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Por Fechas"
        '
        'w_cierre_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 675)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt_hasta)
        Me.Controls.Add(Me.dt_desde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "w_cierre_caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Pagos"
        CType(Me.pagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cierre_caja_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pagosBindingSource As BindingSource
    Friend WithEvents cierre_caja_Dataset As cierre_caja_Dataset
    Friend WithEvents pagosTableAdapter As cierre_caja_DatasetTableAdapters.pagosTableAdapter
    Friend WithEvents bt_buscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
