Public Class frmEmployeeLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtEmployeeID.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter both Employee ID and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Query the EMPLOYEES table based on the provided credentials
        Dim strSelect As String = "SELECT intEmployeeID, strEmployeeRole FROM TEmployees WHERE strEmployeeLoginID = '" & txtEmployeeID.Text & "' AND strEmployeePassword = '" & txtPassword.Text & "'"
        Dim cmdSelect As New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        Dim drSourceTable As OleDb.OleDbDataReader

        Try
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                            "The application will now close.",
                            Me.Text + " Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

            cmdSelect.Connection = m_conAdministrator

            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.Read() Then
                Dim employeeRole As String = drSourceTable("strEmployeeRole")
                ' Display a welcome message based on the employee role
                MessageBox.Show("Welcome, " & employeeRole & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Navigate to the respective main menu form based on the employee role
                Select Case employeeRole
                    Case "Admin"
                        Dim frmAdminMainMenu As New frmAdminMainMenu
                        frmAdminMainMenu.ShowDialog()
                    Case "Pilot"
                        Dim frmPilotMainMenu As New frmPilotMainMenu
                        frmPilotMainMenu.ShowDialog()
                    Case "Attendant"
                        Dim frmAttendantMainMenu As New frmAttendantMainMenu
                        frmAttendantMainMenu.ShowDialog()
                End Select

                Me.Hide()
            Else
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
End Class