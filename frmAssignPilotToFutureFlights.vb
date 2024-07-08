Public Class frmAssignPilotToFutureFlights
    Private Sub frmAssignPilotToFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dtPilot As DataTable = New DataTable
        Dim dtFlight As DataTable = New DataTable
        Try

            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            strSelect = "SELECT intPilotID, strFirstName + ' ' + strLastName as PilotName " &
                        "FROM TPilots "

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtPilot.Load(drSourceTable)
            cboPilots.ValueMember = "intPilotID"
            cboPilots.DisplayMember = "PilotName"
            cboPilots.DataSource = dtPilot

            strSelect = "SELECT intFlightID, dtmFlightDate, strFlightNumber  " &
                        "FROM TFlights " &
                        "WHERE YEAR(dtmFlightDate) > 2023 " &
                        "ORDER BY dtmFlightDate ASC"


            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtFlight.Load(drSourceTable)
            cboFlights.ValueMember = "intFlightID"
            cboFlights.DisplayMember = "dtmFlightDate"
            cboFlights.DataSource = dtFlight
            drSourceTable.Close()
            CloseDatabaseConnection()
        Catch excError As Exception
            MessageBox.Show(excError.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim frmPilotMainMenu As New frmPilotMainMenu
        frmPilotMainMenu.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSelect As String
        Dim strInsert As String
        Dim intPilot As Integer
        Dim intFlight As Integer

        Dim cmdSelect As OleDb.OleDbCommand
        Dim cmdInsert As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim intNextPrimaryKey As Integer
        Dim intRowsAffected As Integer

        Try
            intPilot = cboPilots.SelectedValue
            intFlight = cboFlights.SelectedValue

            ' Ask user for confirmation before assignment
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to assign this pilot to the flight?", "Confirm Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' User clicked Yes, proceed with assignment
                If OpenDatabaseConnectionSQLServer() = False Then
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                            "The application will now close.",
                                            Me.Text + " Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return ' Exit Sub to prevent further execution
                End If

                strSelect = "SELECT MAX(intPilotFlightID) + 1 AS intNextPrimaryKey FROM TPilotFlights"
                ' Execute command
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
                drSourceTable.Close()

                ' Build insert statement (columns must match DB columns in name and the # of columns)
                strInsert = "INSERT INTO TPilotFlights (intPilotFlightID, intPilotID, intFlightID) VALUES (" & intNextPrimaryKey & "," & intPilot & "," & intFlight & ")"

                ' Use insert command with SQL string and connection object
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)
                ' Execute query to insert data
                intRowsAffected = cmdInsert.ExecuteNonQuery()

                ' If not 0 insert successful
                If intRowsAffected > 0 Then
                    MessageBox.Show(cboPilots.Text & " has been added to " & cboFlights.Text, "Assignment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                CloseDatabaseConnection()
            Else
                ' User clicked No, do nothing
                MessageBox.Show("Assignment cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not (drSourceTable Is Nothing) Then
                If Not drSourceTable.IsClosed Then drSourceTable.Close()
            End If
            CloseDatabaseConnection()
        End Try
    End Sub

End Class