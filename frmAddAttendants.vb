Public Class frmAddAttendants
    Private Sub frmAddAttendants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then
                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' and close the form/application
                Me.Close()
            End If
            ' close the database connection
            CloseDatabaseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function GetAndValidate(ByVal strFirstName As String, ByVal strLastname As String, ByVal strEmployeeID As String, ByVal strDateOfHire As String, ByVal strDateOfTermination As String, ByVal strEmployeeLogin As String, ByVal strEmployeePassword As String) As Boolean
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
        If txtDateOfHire.Text.Trim = String.Empty Then
            txtDateOfHire.Focus()
            MessageBox.Show("Date of Hire is Required")
            Return False
        End If
        If txtDateOfTermination.Text.Trim = String.Empty Then
            txtDateOfTermination.Focus()
            MessageBox.Show("Date of Termination is Required")
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
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If GetAndValidate(txtFirstName.Text, txtLastName.Text, txtEmployeeID.Text, txtDateOfHire.Text, txtDateOfTermination.Text, txtEmployeeLoginID.Text, txtEmployeePassword.Text) Then
            Try
                Dim intNextPrimaryKey As Integer = GetNextPrimaryKey()
                If intNextPrimaryKey > 0 Then
                    Dim strFirstName As String = txtFirstName.Text
                    Dim strLastname As String = txtLastName.Text
                    Dim strEmployeeID As String = txtEmployeeID.Text
                    Dim strDateOfHire As String = txtDateOfHire.Text
                    Dim strDateOfTermination As String = txtDateOfTermination.Text
                    Dim strEmployeeLogin As String = txtEmployeeLoginID.Text
                    Dim strEmployeePassword As String = txtEmployeePassword.Text


                    Dim strInsertAttendant As String = $"INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination) VALUES({intNextPrimaryKey}, '{strFirstName}', '{strLastname}', '{strEmployeeID}', '{strDateOfHire}', '{strDateOfTermination}')"
                    Dim strInsertEmployee As String = $"INSERT INTO TEmployees (intEmployeeID, strEmployeeLoginID, strEmployeePassword, strEmployeeRole) VALUES ({intNextPrimaryKey}, '{strEmployeeLogin}', '{strEmployeePassword}', 'Attendant')"

                    If OpenDatabaseConnectionSQLServer() Then
                        Using cmdInsertAttendant As New OleDb.OleDbCommand(strInsertAttendant, m_conAdministrator)
                            cmdInsertAttendant.ExecuteNonQuery()
                        End Using
                        Using cmdInsertEmployee As New OleDb.OleDbCommand(strInsertEmployee, m_conAdministrator)
                            cmdInsertEmployee.ExecuteNonQuery()
                        End Using
                    End If
                    MessageBox.Show("Attendant has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Adding Attendant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseDatabaseConnection()
            End Try
        End If
    End Sub
    Private Function GetNextPrimaryKey() As Integer
        Try
            Dim strSelect As String = "SELECT MAX(intAttendantID) + 1 AS intNextPrimaryKey " &
                            " FROM TAttendants"
            If OpenDatabaseConnectionSQLServer() Then
                Using cmdSelect As New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                    Dim intNextPrimaryKey As Object = cmdSelect.ExecuteScalar()
                    If intNextPrimaryKey IsNot DBNull.Value AndAlso IsNumeric(intNextPrimaryKey) Then
                        Return CInt(intNextPrimaryKey)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Getting Next Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseDatabaseConnection()
        End Try
        Return 0
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class