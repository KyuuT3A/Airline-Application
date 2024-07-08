Public Class frmPilotMainMenu

    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        Dim frmUpdatePilotProfile As New frmUpdatePilotProfile
        frmUpdatePilotProfile.ShowDialog()

    End Sub

    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        Dim frmPilotsPastFlights As New frmPilotsPastFlight
        frmPilotsPastFlight.ShowDialog()

    End Sub

    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        Dim frmPilotsFutureFlights As New frmPilotsFutureFlights
        frmPilotsFutureFlights.ShowDialog()
    End Sub

End Class