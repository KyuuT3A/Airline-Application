Public Class frmAttendantMainMenu
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        Dim frmUpdateAttendantProfile As New frmUpdateAttendantProfile
        frmUpdateAttendantProfile.ShowDialog()
    End Sub
    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        Dim frmAttendantsPastFlights As New frmAttendantsPastFlights
        frmAttendantsPastFlights.ShowDialog()
    End Sub
    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        Dim frmAttendantsFutureFlights As New frmAttendantsFutureFlights
        frmAttendantsFutureFlights.ShowDialog()
    End Sub

End Class