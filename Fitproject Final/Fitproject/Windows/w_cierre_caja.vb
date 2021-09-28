Imports Microsoft.Reporting.WinForms
Public Class w_cierre_caja
    Private Sub w_cierre_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_desde.Value = Date.Today
        dt_hasta.Value = Date.Today
        'TODO: esta línea de código carga datos en la tabla 'cierre_caja_Dataset.pagos' Puede moverla o quitarla según sea necesario.
        Me.pagosTableAdapter.Fill(Me.cierre_caja_Dataset.pagos)

        '   Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim reporte As New c_reportes
        Dim ds As DataSet
        ds = reporte.cierre_diario(dt_desde.Value, dt_hasta.Value)
        Dim rds As New ReportDataSource("cierre_caja", ds.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Dim desde = New ReportParameter("desde", dt_desde.Value.ToString)
        Dim hasta = New ReportParameter("hasta", dt_hasta.Value.ToString)
        Me.ReportViewer1.LocalReport.SetParameters(desde)
        Me.ReportViewer1.LocalReport.SetParameters(hasta)
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class