Public Class frmMainLogin
    Private Sub btnPassengerLogin_Click(sender As Object, e As EventArgs) Handles btnPassengerLogin.Click
        Dim frmPassengerLogin As New frmPassengerLogin
        frmPassengerLogin.ShowDialog()
    End Sub

    Private Sub btnEmployeeLogin_Click(sender As Object, e As EventArgs) Handles btnEmployeeLogin.Click
        Dim frmEmployeeLogin As New frmEmployeeLogin
        frmEmployeeLogin.ShowDialog()
    End Sub
End Class