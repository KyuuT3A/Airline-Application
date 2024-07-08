Public Class frmManageAttendants
    Private Sub btnAddAttendants_Click(sender As Object, e As EventArgs) Handles btnAddAttendants.Click
        Dim frmAddAttendants As New frmAddAttendants
        frmAddAttendants.ShowDialog()

    End Sub

    Private Sub btnDeleteAttendants_Click(sender As Object, e As EventArgs) Handles btnDeleteAttendants.Click
        Dim frmDeleteAttendants As New frmDeleteAttendants
        frmDeleteAttendants.ShowDialog()

    End Sub

    Private Sub btnAddAttendantsToFutureFlights_Click(sender As Object, e As EventArgs) Handles btnAddAttendantsToFutureFlights.Click
        Dim frmAddAttendantToFutureFlights As New frmAssignAttendantToFutureFlights
        frmAssignAttendantToFutureFlights.ShowDialog()

    End Sub

    Private Sub frmManageAttendants_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class