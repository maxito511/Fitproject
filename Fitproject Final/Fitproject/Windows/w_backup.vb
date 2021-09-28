Imports System.Data.SqlClient
Public Class w_backup
    Dim conexion As New SqlConnection("SERVER=.;DATABASE=taller2;Uid=sa;Pwd=admin846*")
    Private Sub bt_backup_Click(sender As Object, e As EventArgs) Handles bt_backup.Click
        Dim nombre As String = (Date.Today.Day.ToString) & "-" & (Date.Today.Month.ToString) & "-" & (Date.Today.Year.ToString) & "-" & (Date.Now.Hour.ToString) & "-" & (Date.Now.Minute.ToString) & "-" & (Date.Now.Second.ToString) & "backup.bak"
        Dim sql = "BACKUP DATABASE [taller2] TO  DISK = N'G:\Backup\" & nombre & "' WITH NOFORMAT, NOINIT,  NAME = N'taller2-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        Dim cn As SqlCommand = New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cn.ExecuteNonQuery()
            MessageBox.Show("Backup realizado con exito.", "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

End Class