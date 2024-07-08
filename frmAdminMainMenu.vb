Public Class frmAdminMainMenu
    Private Sub btnManagePilots_Click(sender As Object, e As EventArgs) Handles btnManagePilots.Click
        Dim frmManagePilots As New frmManagePilots
        frmManagePilots.ShowDialog()
    End Sub

    Private Sub btnManageAttendants_Click(sender As Object, e As EventArgs) Handles btnManageAttendants.Click
        Dim frmManageAttendants As New frmManageAttendants
        frmManageAttendants.ShowDialog()
    End Sub

    Private Sub btnCreateFutureFlights_Click(sender As Object, e As EventArgs) Handles btnCreateFutureFlights.Click
        Dim frmCreateFutureFlights As New frmCreateFutureFlights_Admin_
        frmCreateFutureFlights_Admin_.ShowDialog()

    End Sub
    Private Sub btnAddPilotForm_Click(sender As Object, e As EventArgs) Handles btnAddPilotForm.Click
        Dim frmAddPilots As New frmAddPilots
        frmAddPilots.ShowDialog()
    End Sub

    Private Sub btnUpdatePilotForm_Click(sender As Object, e As EventArgs) Handles btnUpdatePilotForm.Click
        Dim frmUpdatePilotProfile As New frmUpdatePilotProfile
        frmUpdatePilotProfile.ShowDialog()
    End Sub

    Private Sub btnAddAttendant_Click(sender As Object, e As EventArgs) Handles btnAddAttendant.Click
        Dim frmAddAttendants As New frmAddAttendants
        frmAddAttendants.ShowDialog()
    End Sub

    Private Sub btnUpdateAttendantProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateAttendantProfile.Click
        Dim frmUpdateAttendantProfile As New frmUpdateAttendantProfile
        frmUpdateAttendantProfile.ShowDialog()
    End Sub
End Class