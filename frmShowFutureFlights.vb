Public Class frmShowFutureFlights
    Private Sub LoadFutureFlights()
        Try
            lstResults.Items.Clear()
            Dim totalMilesFlown As Integer
            Dim objParam As OleDb.OleDbParameter
            ' Query to fetch details of future flights for the selected customer
            'Dim strSelectFlights As String = "SELECT strFlightNumber, dtmFlightDate, dtmTimeofDeparture, dtmTimeOfLanding, intMilesFlown " &
            '                                 "FROM TFlights " &
            '                                 "WHERE dtmFlightDate > GETDATE() AND intFlightID IN (SELECT intFlightID FROM TFlightPassengers WHERE intPassengerID = " & SelectedCustomerID & ")"

            Dim cmdSelectFlights As OleDb.OleDbCommand
            Dim drSourceTableFlights As OleDb.OleDbDataReader

            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

            '(frmShowFutureFlights.vb page uspGetFutureFlightsForCustomer)
            cmdSelectFlights = New OleDb.OleDbCommand("usp_GetFutureFlightsForCustomer", m_conAdministrator)
            cmdSelectFlights.CommandType = CommandType.StoredProcedure

            objParam = cmdSelectFlights.Parameters.Add("@Customer_ID", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = SelectedCustomerID

            drSourceTableFlights = cmdSelectFlights.ExecuteReader
            lstResults.Items.Clear()

            lstResults.Items.Add("Total Future Flights Info")
            lstResults.Items.Add("  ")
            lstResults.Items.Add("=======================================")


            While drSourceTableFlights.Read()
                Dim milesFlown As Integer = CInt(drSourceTableFlights("intMilesFlown"))
                totalMilesFlown += milesFlown
                lstResults.Items.Add("  ")
                lstResults.Items.Add("Flight Number: " & vbTab & drSourceTableFlights("strFlightNumber"))
                lstResults.Items.Add("Flight Date: " & vbTab & drSourceTableFlights("dtmFlightDate"))
                lstResults.Items.Add("Time of Departure: " & vbTab & drSourceTableFlights("dtmTimeofDeparture"))
                lstResults.Items.Add("Time of Landing: " & vbTab & drSourceTableFlights("dtmTimeOfLanding"))
                lstResults.Items.Add("Miles Flown: " & vbTab & milesFlown.ToString())
                lstResults.Items.Add("  ")
                lstResults.Items.Add("=======================================")
            End While


            drSourceTableFlights.Close()


            lblFutureFlights.Text = totalMilesFlown.ToString()

            ' Close the database connection
            CloseDatabaseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmShowFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadFutureFlights()
    End Sub
End Class