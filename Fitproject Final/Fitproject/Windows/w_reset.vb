Public Class w_reset
    Public sn_reset As Char
    Public origen As String
    Private Sub w_reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If origen = "w_pago" And sn_reset = "S" Then
            w_pago.Show()
            w_comp.Show()
            Me.Close()
        End If
    End Sub
End Class