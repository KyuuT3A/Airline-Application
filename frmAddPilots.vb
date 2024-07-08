Public Class frmAddPilots
    Private Sub frmAddPilots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not OpenDatabaseConnectionSQLServer() Then
                MessageBox.Show("Database connection error. The application will now close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
            End If

            Dim strSelect As String = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"
            Dim cmdSelect As New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            Dim drSourceTable As OleDb.OleDbDataReader = cmdSelect.ExecuteReader
            Dim dtPilotRoles As New DataTable
            dtPilotRoles.Load(drSourceTable)

            cboPilotRole.ValueMember = "intPilotRoleID"
            cboPilotRole.DisplayMember = "strPilotRole"
            cboPilotRole.DataSource = dtPilotRoles

            CloseDatabaseConnection()
        Catch exError As Exception
            MessageBox.Show(exError.Message)
        End Try
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strFirstName As String
        Dim strLastname As String
        Dim strEmployeeID As String
        Dim strDateOfHire As String
        Dim strDateOfTermination As String
        Dim strDateofLicense As String
        Dim strPilotRoleID As String
        Dim blnValidated As Boolean = True
        Dim cmdSelect As OleDb.OleDbCommand
        Dim cmdInsert As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim intNextPrimaryKey As Integer
        Dim intRowsAffected As Integer

        If GetAndValidate(txtFirstName.Text, txtLastName.Text, txtEmployeeID.Text, dtmDateOfHire.Value, dtmDateofTermination.Value, dtmDateofLicense.Value, cboPilotRole.Text, txtEmployeeLoginID.Text, txtEmployeePassword.Text) Then
            Try
                'strFirstName = txtFirstName.Text
                'strLastname = txtLastName.Text
                'strEmployeeID = txtEmployeeID.Text
                'strDateOfHire = dtmDateOfHire
                'strDateOfTermination = dtmDateofTermination
                'strDateofLicense = dtmDateofLicense
                'strPilotRoleID = cboPilotRole.SelectedValue
                If Not OpenDatabaseConnectionSQLServer() Then
                    MessageBox.Show("Database connection error. The application will now close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Close()
                End If

                Dim strPilotInsert As String = "INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID) " &
                                          " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastname & "','" & strEmployeeID & "', '" & strDateOfHire & "','" & strDateOfTermination & "','" & strDateofLicense & "'," & strPilotRoleID & ")"
                Dim cmdPilotInsert As New OleDb.OleDbCommand(strPilotInsert, m_conAdministrator)

                Dim intPilotRowsAffected As Integer = cmdPilotInsert.ExecuteNonQuery()

                If intPilotRowsAffected > 0 Then
                    MessageBox.Show("Pilot has been added successfully.")

                    ' Retrieve the newly added Pilot's ID
                    Dim intPilotID As Integer
                    Dim strGetPilotID As String = "SELECT @@IDENTITY AS intPilotID"
                    Dim cmdGetPilotID As New OleDb.OleDbCommand(strGetPilotID, m_conAdministrator)
                    intPilotID = CInt(cmdGetPilotID.ExecuteScalar())

                    ' Add Pilot to Employees table
                    Dim strEmpInsert As String = $"INSERT INTO TEmployees (intEmployeeID, strEmployeeLoginID, strEmployeePassword, strEmployeeRole) VALUES ({intPilotID}, '{txtEmployeeLoginID.Text}', '{txtEmployeePassword.Text}', 'Pilot')"
                    Dim cmdEmpInsert As New OleDb.OleDbCommand(strEmpInsert, m_conAdministrator)
                    Dim empRowsAffected As Integer = cmdEmpInsert.ExecuteNonQuery()

                    If empRowsAffected > 0 Then
                        MessageBox.Show("Pilot added to Employees table.")
                    Else
                        MessageBox.Show("Failed to add Pilot to Employees table.")
                    End If
                Else
                    MessageBox.Show("Failed to add Pilot.")
                End If

                CloseDatabaseConnection()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'Try
            '    'values into string
            '    strFirstName = txtFirstName.Text
            '    strLastname = txtLastName.Text
            '    strEmployeeID = txtEmployeeID.Text
            '    strDateOfHire = dtmDateOfHire
            '    strDateOfTermination = dtmDateofTermination
            '    strDateofLicense = dtmDateofLicense
            '    strPilotRoleID = cboPilotRole.SelectedValue

            '    If OpenDatabaseConnectionSQLServer() = False Then
            '        ' No, warn the user ...
            '        MessageBox.Show(Me, "Database connection error." & vbNewLine &
            '                            "The application will now close.",
            '                            Me.Text + " Error",
            '                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        'close the form/application
            '        Me.Close()
            '    End If
            '    strSelect = "SELECT MAX(intPilotID) + 1 AS intNextPrimaryKey " &
            '                " FROM TPilots"
            '    ' Execute command
            '    cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            '    drSourceTable = cmdSelect.ExecuteReader
            '    ' Read result( highest ID )
            '    drSourceTable.Read()
            '    ' Null? (empty table)
            '    If drSourceTable.IsDBNull(0) = True Then
            '        ' Yes, start numbering at 1
            '        intNextPrimaryKey = 1
            '    Else
            '        ' No, get the next highest ID
            '        intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))
            '    End If
            '    ' build insert statement (columns must match DB columns in name and the # of columns)
            '    strInsert = "INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)" &
            '    " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastname & "','" & strEmployeeID & "', '" & strDateOfHire & "','" & strDateOfTermination & "','" & strDateofLicense & "'," & strPilotRoleID & ")"
            '    MessageBox.Show(strInsert)
            '    ' use insert command with sql string and connection object
            '    cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)
            '    ' execute query to insert data
            '    intRowsAffected = cmdInsert.ExecuteNonQuery()
            '    ' If not 0 insert successful
            '    If intRowsAffected > 0 Then
            '        MessageBox.Show("Pilot has been added")    ' let user know success
            '        ' close new player form
            '    End If
            '    ' close connection if insert didn't work
            '    CloseDatabaseConnection()
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try
        End If
    End Sub
    Private Function GetAndValidate(ByVal strFirstName As String, ByVal strLastname As String, ByVal strEmployeeID As String, ByVal dtmDateOfHire As Date, ByVal dtmDateofTermination As Date, ByVal dtmDateofLicense As Date, ByVal strPilotRoleID As String, ByVal strEmployeeLogin As String, ByVal strEmployeePassword As String) As Boolean
        If txtFirstName.Text.Trim = String.Empty Then
            txtFirstName.Focus()
            MessageBox.Show("First Name is Required")
            Return False
        End If
        If txtLastName.Text.Trim = String.Empty Then
            txtLastName.Focus()
            MessageBox.Show("Last Name is Required")
            Return False
        End If
        If txtEmployeeID.Text.Trim().Length() <> 5 Then
            txtEmployeeID.Focus()
            MessageBox.Show("Employee ID is Required and must be 5 digits")
            Return False
        End If
        Dim intEmployeeID As Integer
        If Not Integer.TryParse(txtEmployeeID.Text, intEmployeeID) Then
            txtEmployeeID.Focus()
            MessageBox.Show("Employee ID must be numeric")
            Return False
        End If
        If dtmDateOfHire = Date.MinValue Then
            MessageBox.Show("Date of Hire is Required")
            Return False
        End If
        If dtmDateofTermination = Date.MinValue Then
            MessageBox.Show("Date of Termination is Required")
            Return False
        End If
        If cboPilotRole.Text.Trim = String.Empty Then
            cboPilotRole.Focus()
            MessageBox.Show("Select a Role")
            Return False
        End If
        If dtmDateofLicense = Date.MinValue Then
            MessageBox.Show("Date of License is Required")
            Return False
        End If
        If txtEmployeeLoginID.Text.Trim = String.Empty Then
            txtEmployeeLoginID.Focus()
            MessageBox.Show("Login ID is Required")
            Return False
        End If
        If txtEmployeePassword.Text.Trim = String.Empty Then
            txtEmployeePassword.Focus()
            MessageBox.Show("Password is Required")
            Return False
        End If
        Return True
    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class