Public Class frmBookFlights
    Private selectedFlightID As Integer
    Dim dblBaseCost As Double = 250.0
    Dim dblAdditionalCost As Double = 50.0 'Total miles greater then 750
    Private Sub frmBookFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize labels with empty strings
        lblReservedSeats.Text = ""
        lblDesignatedSeats.Text = ""

        Try
            ' Populate combo box with flights
            LoadFlights()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LoadFlights()
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dtF As DataTable = New DataTable

        Try
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Close the form/application
                Me.Close()
            End If

            strSelect = "SELECT intFlightID, strFlightNumber, dtmFlightDate FROM TFlights WHERE dtmFlightDate >= GETDATE() ORDER BY dtmFlightDate"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtF.Load(drSourceTable)

            cboFlights.ValueMember = "intFlightID"
            cboFlights.DisplayMember = "dtmFlightDate"
            cboFlights.DataSource = dtF

            ' Clear the selected index to ensure nothing is selected by default
            cboFlights.SelectedIndex = -1

            ' Hide the radio buttons and labels initially
            radReservedSeat.Visible = False
            radDesignatedSeat.Visible = False
            lblReservedSeats.Visible = False
            lblDesignatedSeats.Visible = False

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboFlights_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFlights.SelectedIndexChanged
        Dim dblReservedSeats As Double = 0.0
        Dim dblDesignatedSeats As Double = 0.0
        Dim dtF As DataTable = New DataTable
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim intFlightID As Integer

        ' Make the radio buttons visible
        radReservedSeat.Visible = True
        radDesignatedSeat.Visible = True
        lblReservedSeats.Visible = True
        lblDesignatedSeats.Visible = True

        Try
            If cboFlights.SelectedItem IsNot Nothing Then
                If OpenDatabaseConnectionSQLServer() = False Then
                    MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' close the form/application
                    Me.Close()
                End If

                ' Retrieve the selected flight ID
                intFlightID = Convert.ToInt32(cboFlights.SelectedValue)
                selectedFlightID = Convert.ToInt32(cboFlights.SelectedValue)
                ' Add debugging statement
                ' Console.WriteLine("Selected flight ID: " & intFlightID)
                Dim strPlaneType As String = ""
                Dim strDestinationAirport As String = ""
                Dim intPreviousFlights As Integer
                Dim dblDeductionPercentage As Double

                strSelect = "SELECT TF.intMilesFlown, " &
                            "COUNT(TFP.intFlightID) AS ReservedSeatCount, " &
                            "COUNT(DISTINCT TFP.intFlightID) AS PreviousFlights, " &
                            "PT.strPlaneType, TF.intToAirportID, " &
                            "P.strLastname, P.dtmPassengerDateofBirth, " &
                            "FLOOR(DATEDIFF(DAY, P.dtmPassengerDateofBirth, GetDate()) / 365.25) AS Age " &
                            "FROM TFlights AS TF " &
                            "INNER JOIN TPlanes AS TP ON TF.intPlaneID = TP.intPlaneID " &
                            "INNER JOIN TPlaneTypes AS PT ON TP.intPlaneTypeID = PT.intPlaneTypeID " &
                            "INNER JOIN TFlightPassengers AS TFP ON TF.intFlightID = TFP.intFlightID " &
                            "INNER JOIN TPassengers AS P ON TFP.intPassengerID = P.intPassengerID " &
                            "WHERE TF.intFlightID = " & intFlightID & " " &
                            "GROUP BY TF.intMilesFlown, PT.strPlaneType, TF.intToAirportID, P.strLastname, P.dtmPassengerDateofBirth"



                cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdSelect.ExecuteReader

                If drSourceTable.Read() Then
                    ' Define variables to hold database values
                    Dim intMilesFlown As Integer
                    Dim intReservedSeatCount As Integer
                    Dim dblBaseSeatCost As Double

                    ' Read and parse database values
                    If Integer.TryParse(drSourceTable("intMilesFlown").ToString(), intMilesFlown) AndAlso
                       Integer.TryParse(drSourceTable("ReservedSeatCount").ToString(), intReservedSeatCount) Then

                        ' Successfully parsed values, continue processing
                        strPlaneType = drSourceTable("strPlaneType").ToString()
                        strDestinationAirport = drSourceTable("intToAirportID").ToString()

                        ' Calculate base cost
                        dblBaseSeatCost = dblBaseCost
                        If intMilesFlown > 750 Then
                            dblBaseSeatCost += dblAdditionalCost
                        End If

                        If intReservedSeatCount > 8 Then
                            dblBaseSeatCost += 100.0
                        ElseIf intReservedSeatCount < 4 Then
                            dblBaseSeatCost -= 50.0
                        End If

                        Select Case strPlaneType
                            Case "Airbus A350"
                                dblBaseSeatCost += 35.0
                            Case "Boeing 747-8"
                                dblBaseSeatCost -= 25.0
                        End Select

                        If strDestinationAirport = "MIA" Then
                            dblBaseSeatCost += 15.0
                        End If

                        If radReservedSeat.Checked Then
                            ' Add $125.00 for reserved seat
                            dblReservedSeats = dblReservedSeats + 125.0
                        Else
                            ' Designated seat cost is the same
                            dblDesignatedSeats = dblDesignatedSeats
                        End If

                        ' Apply deductions based on passenger age
                        Dim intAge As Integer = Convert.ToInt32(drSourceTable("Age"))
                        Dim dblAgeDeduction As Double = 0.0

                        If intAge >= 65 Then
                            ' Deduct 20% for passengers aged 65 or older
                            dblAgeDeduction = dblBaseSeatCost * 0.2
                        ElseIf intAge <= 5 Then
                            ' Deduct 65% for passengers aged 5 or younger
                            dblAgeDeduction = dblBaseSeatCost * 0.65
                        End If

                        intPreviousFlights = Convert.ToInt32(drSourceTable("PreviousFlights"))
                        If intPreviousFlights > 5 And intPreviousFlights <= 10 Then
                            dblDeductionPercentage = 0.1 ' Deduct 10% for 6 to 10 previous flights
                        ElseIf intPreviousFlights > 10 Then
                            dblDeductionPercentage = 0.2 ' Deduct 20% for more than 10 previous flights
                        End If
                        dblBaseSeatCost -= dblBaseSeatCost * dblDeductionPercentage

                        'Console.WriteLine("Base seat cost: " & dblBaseSeatCost)
                        'Console.WriteLine("Reserved seat count: " & intReservedSeatCount)
                        'Console.WriteLine("Plane type: " & strPlaneType)
                        'Console.WriteLine("Destination airport: " & strDestinationAirport)
                        'Console.WriteLine("Age: " & intAge)
                        'Console.WriteLine("Previous flights: " & intPreviousFlights)
                        'Console.WriteLine("Deduction percentage: " & dblDeductionPercentage)

                        ' Display the calculated base seat cost
                        lblReservedSeats.Text = (dblReservedSeats + dblBaseSeatCost - dblAgeDeduction).ToString("F2")
                        lblDesignatedSeats.Text = (dblDesignatedSeats + dblBaseSeatCost - dblAgeDeduction).ToString("F2")

                    End If
                    drSourceTable.Close()
                    CloseDatabaseConnection()
                Else

                    ' If no flight is selected, hide the radio buttons and label
                    radReservedSeat.Visible = False
                    radDesignatedSeat.Visible = False
                    lblReservedSeats.Visible = False
                    lblDesignatedSeats.Visible = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim result As DialogResult

        Dim strSelect As String
        Dim strInsert As String
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dt As DataTable = New DataTable
        Dim intNextPrimaryKey As Integer
        Dim intRowsAffected As Integer
        Dim cmdSelect As OleDb.OleDbCommand
        Dim cmdInsert As OleDb.OleDbCommand
        Try
            result = MessageBox.Show("Are you sure you want to book this flight?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then


                If OpenDatabaseConnectionSQLServer() = False Then
                    MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' close the form/application
                    Me.Close()
                End If
                strSelect = "SELECT ISNULL(MAX(intFlightPassengerID), 0) + 1 AS intNextPrimaryKey FROM TFlightPassengers"

                cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdSelect.ExecuteReader
                ' Read result( highest ID )
                drSourceTable.Read()
                ' Null? (empty table)
                If drSourceTable.IsDBNull(0) = True Then

                    ' Yes, start numbering at 1
                    intNextPrimaryKey = 1
                Else
                    ' No, get the next highest ID
                    intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))
                End If

                ' Build insert statement
                strInsert = "INSERT INTO TFlightPassengers (intFlightPassengerID, intFlightID, intPassengerID, strSeat, intFlightCost) " &
                            "VALUES (" & intNextPrimaryKey & ", " & selectedFlightID & ", " & SelectedCustomerID & ", '1A', 2350)"


                MessageBox.Show(strInsert)
                ' use insert command with sql string and connection object
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)
                ' execute query to insert data
                intRowsAffected = cmdInsert.ExecuteNonQuery()
                ' If not 0 insert successful
                If intRowsAffected > 0 Then
                    MessageBox.Show("Flight booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' close new player form
                End If
                ' Close the database connection
                CloseDatabaseConnection()
                ' Close the form
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class



