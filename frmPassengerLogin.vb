Public Class frmPassengerLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtPassengerID.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter both Passenger ID and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader

        If OpenDatabaseConnectionSQLServer() = False Then
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                            "The application will now close.",
                            Me.Text + " Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        strSelect = "SELECT intPassengerID FROM TPassengers WHERE strPassengerLoginID = '" & txtPassengerID.Text & "' AND strPassengerPassword = '" & txtPassword.Text & "'"

        Try
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.HasRows Then
                ' If a Passenger is found, store the Passenger ID in a global variable
                drSourceTable.Read()
                SelectedPassengerID = drSourceTable.GetInt32(0)

                ' Navigate to frmCustomerMainMenu
                Dim CustomerMainMenu As New frmCustomerMainMenu()
                CustomerMainMenu.Show()
                Me.Hide() ' Hide the login form
            Else
                ' If no Passenger is found, display an error message
                MessageBox.Show("ID and/or Password are not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error accessing database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close data reader and connection
            If drSourceTable IsNot Nothing Then
                drSourceTable.Close()
            End If
            CloseDatabaseConnection()
        End Try
    End Sub
    Private Sub btnNewPassenger_Click(sender As Object, e As EventArgs) Handles btnNewPassenger.Click
        Dim frmAddCustomers As New frmAddCustomers
        frmAddCustomers.ShowDialog()
    End Sub
End Class