Public Class frmCustomerMainMenu
    Private Sub btnUpdateCustomerProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomerProfile.Click
        Dim frmUpdateCustomerProfile As New frmUpdateCustomerProfile
        frmUpdateCustomerProfile.ShowDialog()

    End Sub

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Dim frmBookFlights As New frmBookFlights
        frmBookFlights.ShowDialog()

    End Sub

    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        Dim frmShowPastFlights As New frmShowPastFlights
        frmShowPastFlights.ShowDialog()

    End Sub

    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        Dim frmShowFutureFlights As New frmShowFutureFlights
        frmShowFutureFlights.ShowDialog()

    End Sub

    Private Sub frmCustomerMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class