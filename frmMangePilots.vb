Public Class frmManagePilots
    Private Sub btnAddPilots_Click(sender As Object, e As EventArgs) Handles btnAddPilots.Click
        Dim frmAddPilots As New frmAddPilots
        frmAddPilots.ShowDialog()

    End Sub

    Private Sub btnDeletePilots_Click(sender As Object, e As EventArgs) Handles btnDeletePilots.Click
        Dim frmDeletePilots As New frmDeletePilots
        frmDeletePilots.ShowDialog()

    End Sub

    Private Sub btnAddPilotToFutureFlights_Click(sender As Object, e As EventArgs) Handles btnAddPilotToFutureFlights.Click
        Dim frmAddPilotToFutureFlights As New frmAssignPilotToFutureFlights
        frmAddPilotToFutureFlights.ShowDialog()

    End Sub
End Class