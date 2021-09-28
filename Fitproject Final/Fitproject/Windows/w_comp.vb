Imports Microsoft.Reporting.WinForms
Public Class w_comp
    Public fecha As Date
    Public id As Integer
    Private Sub w_comp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet_Comprobante.sp_comprobante' Puede moverla o quitarla según sea necesario.
        Dim p_fecha = New ReportParameter("fecha", fecha)
        Dim p_id = New ReportParameter("id", id)
        Me.ReportViewer1.LocalReport.SetParameters(p_fecha)
        Me.ReportViewer1.LocalReport.SetParameters(p_id)
        Me.sp_comprobanteTableAdapter.Fill(Me.DataSet_Comprobante.sp_comprobante, fecha, id)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class