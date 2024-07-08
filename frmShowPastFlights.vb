Public Class frmShowPastFlights
    Private Sub frmShowPastFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lstResults.Items.Clear()
            Dim totalMilesFlown As Integer = 0 ' Variable to store the total miles flown
            ' Query to fetch the count of past flights for the selected customer
            Dim strSelectCount As String = "SELECT COUNT(*) AS TotalFlights " &
                                           "FROM TFlightPassengers " &
                                           "WHERE intPassengerID = " & SelectedCustomerID
            Dim cmdSelectCount As OleDb.OleDbCommand
            Dim drSourceTableCount As OleDb.OleDbDataReader
            ' Query to fetch details of past flights for the selected customer before 2023
            Dim strSelectFlights As String = "SELECT strFlightNumber, dtmFlightDate, dtmTimeofDeparture, dtmTimeOfLanding, intMilesFlown " &
                                             "FROM TFlights " &
                                             "WHERE intFlightID IN (SELECT intFlightID FROM TFlightPassengers WHERE intPassengerID = " & SelectedCustomerID & ") " &
                                             "AND YEAR(dtmFlightDate) < 2023"
            Dim cmdSelectFlights As OleDb.OleDbCommand
            Dim drSourceTableFlights As OleDb.OleDbDataReader
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            ' Execute the query to fetch the count of past flights
            cmdSelectCount = New OleDb.OleDbCommand(strSelectCount, m_conAdministrator)
            drSourceTableCount = cmdSelectCount.ExecuteReader()

            If drSourceTableCount.Read() Then
                Dim totalFlights As Integer = CInt(drSourceTableCount("TotalFlights"))
                lblPastFlights.Text = totalFlights.ToString()
            End If
            ' Close the data reader for the count query
            drSourceTableCount.Close()
            ' Execute the query to fetch details of past flights
            cmdSelectFlights = New OleDb.OleDbCommand(strSelectFlights, m_conAdministrator)
            drSourceTableFlights = cmdSelectFlights.ExecuteReader
            ' Add a header to the list box
            lstResults.Items.Add("Total Past Flights Info")
            lstResults.Items.Add("  ")
            lstResults.Items.Add("=======================================")
            ' Loop through the result set of past flights and populate the list box with flight details
            While drSourceTableFlights.Read()
                Dim milesFlown As Integer = CInt(drSourceTableFlights("intMilesFlown"))
                totalMilesFlown += milesFlown ' Add miles flown to the total
                lstResults.Items.Add("  ")
                lstResults.Items.Add("Flight Number: " & vbTab & drSourceTableFlights("strFlightNumber"))
                lstResults.Items.Add("Flight Date: " & vbTab & drSourceTableFlights("dtmFlightDate"))
                lstResults.Items.Add("Time of Departure: " & vbTab & drSourceTableFlights("dtmTimeofDeparture"))
                lstResults.Items.Add("Time of Landing: " & vbTab & drSourceTableFlights("dtmTimeOfLanding"))
                lstResults.Items.Add("Miles Flown: " & vbTab & milesFlown.ToString())
                lstResults.Items.Add("  ")
                lstResults.Items.Add("=======================================")
            End While
            ' Close the data reader for the past flights query
            drSourceTableFlights.Close()
            ' Display the total miles flown in the label
            lblPastFlights.Text = totalMilesFlown.ToString()
            ' Close the database connection
            CloseDatabaseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class