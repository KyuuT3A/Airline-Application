Public Class frmUpdateAttendantProfile
    Private Sub frmUpdateAttendantProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = String.Empty
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dt As DataTable = New DataTable
        Dim dtr As DataTable = New DataTable
        Try
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "the application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

            strSelect = "SELECT strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination " &
                                      "FROM TAttendants " &
                                      "WHERE intAttendantID = " & SelectedAttendantID
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' populate the text boxes with the data.
            If drSourceTable.Read() Then
                txtFirstName.Text = drSourceTable("strFirstName").ToString()
                txtLastName.Text = drSourceTable("strLastName").ToString()
                txtEmployeeID.Text = drSourceTable("strEmployeeID").ToString()
                txtDateOfHire.Text = drSourceTable("dtmDateofHire").ToString()
                txtDateOfTermination.Text = drSourceTable("dtmDateofTermination").ToString()
                txtEmployeeLoginID.Text = drSourceTable("strEmployeeLoginID").ToString()
                txtEmployeePassword.Text = drSourceTable("strEmployeePassword").ToString()
            End If
            drSourceTable.Close()
            CloseDatabaseConnection()
        Catch exError As Exception
            MessageBox.Show(exError.Message)
        End Try
    End Sub
    Private Function GetAndValidate(ByVal strFirstName As String, ByVal strLastname As String, ByVal strEmployeeID As String, ByVal strtDateOfHire As String, ByVal strDateOfTermination As String, ByVal strEmployeeLogin As String, ByVal strEmployeePassword As String) As Boolean
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If GetAndValidate(txtFirstName.Text, txtLastName.Text, txtEmployeeID.Text, txtDateOfHire.Text, txtDateOfTermination.Text, txtEmployeeLoginID.Text, txtEmployeePassword.Text) Then
            Try
                ' Construct the SQL update query to update pilot's information
                Dim strUpdateQuery As String = "UPDATE TAttendants SET " &
                    "strEmployeeLoginID = ?, " &
                    "strEmployeePassword = ? " &
                    "WHERE intAttendantID = ?"
                ' Open database connection
                If OpenDatabaseConnectionSQLServer() Then
                    ' Execute the update query
                    Using cmdUpdate As New OleDb.OleDbCommand(strUpdateQuery, m_conAdministrator)
                        cmdUpdate.Parameters.AddWithValue("@EmployeeLoginID", txtEmployeeLoginID.Text)
                        cmdUpdate.Parameters.AddWithValue("@EmployeePassword", txtEmployeePassword.Text)
                        cmdUpdate.Parameters.AddWithValue("@AttendantID", SelectedAttendantID)

                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    ' Display success message
                    MessageBox.Show("Update successful")
                Else
                    MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                ' Close database connection
                CloseDatabaseConnection()
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class