Imports System.Data
Imports System.Data.SqlClient
Public Class c_reportes
    Dim conexion As New SqlConnection("SERVER=.;DATABASE=taller2;Uid=sa;Pwd=admin846*")
    Public Function cierre_diario(desde As Date, hasta As Date) As DataSet
        Dim datos As New DataTable
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String = " select id_factura,dni,apellido,nombre,importe,fe_factura from pagos where fe_factura between " & "'" & desde & "'" & "and" & "'" & hasta & "'"
        Try
            conexion.Open()
            adapter = New SqlDataAdapter(sql, conexion)
            adapter.Fill(ds)
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return ds
    End Function

End Class
