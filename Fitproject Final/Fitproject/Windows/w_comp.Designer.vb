<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class w_comp
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet_Comprobante = New Fitproject.DataSet_Comprobante()
        Me.sp_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_comprobanteTableAdapter = New Fitproject.DataSet_ComprobanteTableAdapters.sp_comprobanteTableAdapter()
        CType(Me.DataSet_Comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet_comp"
        ReportDataSource1.Value = Me.sp_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Fitproject.Report_comprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(706, 349)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet_Comprobante
        '
        Me.DataSet_Comprobante.DataSetName = "DataSet_Comprobante"
        Me.DataSet_Comprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_comprobanteBindingSource
        '
        Me.sp_comprobanteBindingSource.DataMember = "sp_comprobante"
        Me.sp_comprobanteBindingSource.DataSource = Me.DataSet_Comprobante
        '
        'sp_comprobanteTableAdapter
        '
        Me.sp_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'w_comp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 353)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "w_comp"
        Me.Text = "w_comp"
        CType(Me.DataSet_Comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_comprobanteBindingSource As BindingSource
    Friend WithEvents DataSet_Comprobante As DataSet_Comprobante
    Friend WithEvents sp_comprobanteTableAdapter As DataSet_ComprobanteTableAdapters.sp_comprobanteTableAdapter
End Class
