Public Class frmAddCustomers
    Private Sub frmAddCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim dts As DataTable = New DataTable
            Dim objParam As OleDb.OleDbParameter
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            cmdSelect = New OleDb.OleDbCommand("uspSelectStates", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)
            cboState.ValueMember = "intStateID"
            cboState.DisplayMember = "strState"
            cboState.DataSource = dts
            drSourceTable.Close()
            CloseDatabaseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function GetAndValidate(ByVal strFirstName As String, ByVal strLastname As String, ByVal strAddress As String, ByVal strCity As String, ByVal strState As String, ByVal strZip As String, ByVal strPhoneNumber As String, ByVal strEmail As String, ByVal strPassengerLogin As String, ByVal strPassengerPassword As String, ByVal dtmDateofBirth As DateTime) As Boolean
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
        If txtAddress.Text.Trim = String.Empty Then
            txtAddress.Focus()
            MessageBox.Show("Address is Required")
            Return False
        End If
        If txtCity.Text.Trim = String.Empty Then
            txtCity.Focus()
            MessageBox.Show("City is Required")
            Return False
        End If
        If txtZip.Text.Trim().Length() <> 5 Then
            txtZip.Focus()
            MessageBox.Show("Zip Code is Required and must be 5 digits")
            Return False
        End If
        If cboState.Text.Trim = String.Empty Then
            cboState.Focus()
            MessageBox.Show("Select a State")
            Return False
        End If
        If txtPhoneNumber.Text.Trim().Length() <> 10 Then
            txtPhoneNumber.Focus()
            MessageBox.Show("Phone Number is Required and must be 10 digits")
            Return False
        End If
        If txtEmail.Text.Contains("@") Then
            If Not txtEmail.Text.Contains(".") Then
                txtEmail.Focus()
                MessageBox.Show("A valid Email Address is required")
                Return False
            End If
        Else
            txtEmail.Focus()
            MessageBox.Show("A valid Email Address is required")
            Return False
        End If
        If txtPassengerLoginID.Text.Trim = String.Empty Then
            txtPassengerLoginID.Focus()
            MessageBox.Show("Login ID is Required")
            Return False
        End If
        If txtPassengerPassword.Text.Trim = String.Empty Then
            txtPassengerPassword.Focus()
            MessageBox.Show("Password is Required")
            Return False
        End If
        If dtmDateofBirth = DateTime.MinValue Then
            MessageBox.Show("Passenger Date of Birth is Required")
            Return False
        End If
        Return True

    End Function
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastname As String
        Dim strAddress As String
        Dim strCity As String
        Dim intState As Integer
        Dim strZip As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim strPassengerLogin As String
        Dim strPassengerPassword As String
        Dim dtmDateofBirth As DateTime
        Dim intPKID As Integer
        Dim blnValidated As Boolean = True
        Dim cmdAddPassenger As New OleDb.OleDbCommand()
        Dim intRowsAffected As Integer
        'validate data is enter
        If GetAndValidate(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCity.Text, cboState.Text, txtZip.Text, txtPhoneNumber.Text, txtEmail.Text, txtPassengerLoginID.Text, txtPassengerPassword.Text, dteDateofBirth.Value) Then
            Try

                strFirstName = txtFirstName.Text
                strLastname = txtLastName.Text
                strAddress = txtAddress.Text
                strCity = txtCity.Text
                intState = cboState.SelectedValue
                strZip = txtZip.Text
                strPhoneNumber = txtPhoneNumber.Text
                strEmail = txtEmail.Text
                strPassengerLogin = txtPassengerLoginID.Text
                strPassengerPassword = txtPassengerPassword.Text


                If OpenDatabaseConnectionSQLServer() = False Then
                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'close the form/application
                    Me.Close()
                End If
                ' text to call stored proc
                cmdAddPassenger.CommandText = "EXECUTE uspAddPassenger '" & intPKID & "','" & strFirstName & "','" & strLastname & "','" & strAddress & "','" & strCity & "','" & intState & "','" & strZip & "','" & strPhoneNumber & "','" & strEmail & "','" & strPassengerLogin & "','" & strPassengerPassword & "','" & dtmDateofBirth & "'"
                cmdAddPassenger.CommandType = CommandType.StoredProcedure
                ' Pass new fields as parameters to stored procedure
                cmdAddPassenger.Parameters.AddWithValue("@strPassengerLoginID", strPassengerLogin)
                cmdAddPassenger.Parameters.AddWithValue("@strPassengerPassword", strPassengerPassword)
                cmdAddPassenger.Parameters.AddWithValue("@dtmPassengerDateofBirth", dtmDateofBirth)
                ' Call stored proc which will insert the record 
                cmdAddPassenger = New OleDb.OleDbCommand(cmdAddPassenger.CommandText, m_conAdministrator)
                ' this return is the # of rows affected
                intRowsAffected = cmdAddPassenger.ExecuteNonQuery()
                CloseDatabaseConnection()

                If intRowsAffected > 0 Then
                    MessageBox.Show("Insert successful " & strLastname & " has been added.")
                Else
                    MessageBox.Show("Insert failed")
                End If
                Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class