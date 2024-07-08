Public Class frmCreateFutureFlights_Admin_
    Private Sub frmCreateFutureFlights_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim dtToAirport As DataTable = New DataTable
            Dim dtFromAirport As DataTable = New DataTable
            Dim dtPlaneID As DataTable = New DataTable
            Dim objParam As OleDb.OleDbParameter
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

            ' Retrieve all the records for (TO) airport
            strSelect = "SELECT intAirportID, strAirportCode FROM TAirports "
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtToAirport.Load(drSourceTable)
            cboAirport.ValueMember = "intAirportID"
            cboAirport.DisplayMember = "strAirportCode"
            cboAirport.DataSource = dtToAirport

            ' Retrieve all the records for (FROM) airport
            strSelect = "SELECT intAirportID, strAirportCode FROM TAirports "
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtFromAirport.Load(drSourceTable)
            cboAirports.ValueMember = "intAirportID"
            cboAirports.DisplayMember = "strAirportCode"
            cboAirports.DataSource = dtFromAirport

            ' Retrieve all the records for PlaneID
            strSelect = "SELECT intPlaneID, strPlaneNumber FROM TPlanes "
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtPlaneID.Load(drSourceTable)
            cboPlaneID.ValueMember = "intPlaneID"
            cboPlaneID.DisplayMember = "strPlaneNumber"
            cboPlaneID.DataSource = dtPlaneID

            drSourceTable.Close()
            CloseDatabaseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dtmFlightDate_ValueChanged(sender As Object, e As EventArgs) Handles dtmFlightDate.ValueChanged
        ' Set dtmTimeOfDeparture and dtmTimeOfArrival to the flight date
        dtmTimeOfDeparture.Value = New DateTime(dtmFlightDate.Value.Year, dtmFlightDate.Value.Month, dtmFlightDate.Value.Day, 0, 0, 0)
        dtmTimeOfLanding.Value = New DateTime(dtmFlightDate.Value.Year, dtmFlightDate.Value.Month, dtmFlightDate.Value.Day, 23, 59, 59)
    End Sub
    Private Function GetAndValidate(ByVal strFlightNumber As String, ByVal strMilesFlown As String, ByVal strToAirports As String, ByVal strFromAirports As String, ByVal strPlaneID As String, ByVal dtmFlightDate As DateTime) As Boolean
        If txtFlightNumber.Text.Trim = String.Empty Then
            txtFlightNumber.Focus()
            MessageBox.Show("Flight Number is Required")
            Return False
        End If
        If cboAirport.Text.Trim = String.Empty Then
            cboAirport.Focus()
            MessageBox.Show("Select Your Airport")
            Return False
        End If
        If cboAirports.Text.Trim = String.Empty Then
            cboAirports.Focus()
            MessageBox.Show("Select Your Airport to")
            Return False
        End If
        If txtMilesFlown.Text.Trim() = String.Empty Then
            txtMilesFlown.Focus()
            MessageBox.Show("Miles Flown is required ")
            Return False
        End If
        If cboPlaneID.Text.Trim = String.Empty Then
            cboPlaneID.Focus()
            MessageBox.Show("Select Your Plane")
            Return False
        End If
        ' Convert the selected date to a DateTime object for comparison
        Dim selectedDate As New DateTime(dtmFlightDate.Year, dtmFlightDate.Month, dtmFlightDate.Day)

        Dim compareDate As New DateTime(2024, 4, 5)

        ' Check if the selected date is after the specified date
        If selectedDate <= compareDate Then
            MessageBox.Show("Flight Date must be after May 4th, 2024.")
            Return False
        End If


        Return True
    End Function
    Private Sub btnAddFutureFlight_Click(sender As Object, e As EventArgs) Handles btnAddFutureFlight.Click

        Try
            If GetAndValidate(txtFlightNumber.Text, txtMilesFlown.Text, cboAirport.Text, cboAirports.Text, cboPlaneID.Text, dtmFlightDate.Value) Then


                Dim dteFlightDate As Date = New Date(dtmFlightDate.Value.Year, dtmFlightDate.Value.Month, dtmFlightDate.Value.Day, dtmTimeOfDeparture.Value.Hour, dtmTimeOfDeparture.Value.Minute, 0)
                Dim dteTimeOfDeparture As Date = New Date(dtmFlightDate.Value.Year, dtmFlightDate.Value.Month, dtmFlightDate.Value.Day, dtmTimeOfDeparture.Value.Hour, dtmTimeOfDeparture.Value.Minute, 0)
                Dim dteTimeOfArrival As Date = New Date(dtmFlightDate.Value.Year, dtmFlightDate.Value.Month, dtmFlightDate.Value.Day, dtmTimeOfLanding.Value.Hour, dtmTimeOfLanding.Value.Minute, 0)

                Dim strFlightNumber As String = txtFlightNumber.Text
                Dim strFromAirports As String = cboAirport.SelectedValue
                Dim strToAirports As String = cboAirports.SelectedValue
                Dim strMilesFlown As String = txtMilesFlown.Text
                Dim strPlaneID As String = cboPlaneID.SelectedValue



                If OpenDatabaseConnectionSQLServer() = False Then
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If

                Dim strSelect As String = "SELECT MAX(intFlightID) + 1 AS intNextPrimaryKey FROM TFlights"
                Dim cmdSelect As OleDb.OleDbCommand = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                Dim drSourceTable As OleDb.OleDbDataReader = cmdSelect.ExecuteReader

                drSourceTable.Read()

                Dim intNextPrimaryKey As Integer
                If drSourceTable.IsDBNull(0) = True Then
                    intNextPrimaryKey = 1
                Else
                    intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))
                End If

                ' build insert statement
                Dim strInsert As String = "INSERT INTO TFlights (intFlightID, dtmFlightDate, strFlightNumber, dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID) " &
                                        "VALUES (" & intNextPrimaryKey & ",'" & dteFlightDate.ToString("yyyy-MM-dd HH:mm:ss") & "','" & strFlightNumber & "','" & dteTimeOfDeparture.ToString("yyyy-MM-dd HH:mm:ss") & "','" & dteTimeOfArrival.ToString("yyyy-MM-dd HH:mm:ss") & "','" & strFromAirports & "','" & strToAirports & "','" & strMilesFlown & "', '" & strPlaneID & "')"

                Dim cmdInsert As OleDb.OleDbCommand = New OleDb.OleDbCommand(strInsert, m_conAdministrator)
                Dim intRowsAffected As Integer = cmdInsert.ExecuteNonQuery()

                If intRowsAffected > 0 Then
                    MessageBox.Show("Future Flight has been added")
                End If
                CloseDatabaseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class