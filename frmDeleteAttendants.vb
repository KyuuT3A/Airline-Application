Public Class frmDeleteAttendants
    Private Sub frmDeleteAttendants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dt As DataTable = New DataTable
        Try
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            ' Build the select statement
            strSelect = "SELECT intAttendantID, strFirstName + ' ' + strLastName as AttendantName FROM TAttendants"
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            ' load table from data reader
            dt.Load(drSourceTable)
            cboAttendant.ValueMember = "intAttendantID"
            cboAttendant.DisplayMember = "AttendantName"
            cboAttendant.DataSource = dt
            ' Select the first item in the list by default
            If cboAttendant.Items.Count > 0 Then cboAttendant.SelectedIndex = 0
            ' Clean up
            drSourceTable.Close()
            ' close the database connection
            CloseDatabaseConnection()
        Catch excError As Exception
            MessageBox.Show(excError.Message)

        End Try
    End Sub
    Private Sub btnDeleteAttendant_Click(sender As Object, e As EventArgs) Handles btnDeleteAttendant.Click
        Dim intPKID As Integer = SelectedAttendantID
        Dim result As DialogResult
        Dim cmdDeleteAttendant As New OleDb.OleDbCommand()
        Dim intRowsAffected As Integer
        Try
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            result = MessageBox.Show("Are you sure you want to Delete Attendant: " & cboAttendant.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                    Exit Sub
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
            End Select
            ' text to call stored proc
            cmdDeleteAttendant.CommandText = "EXECUTE uspDeleteAttendant " & intPKID
            cmdDeleteAttendant.CommandType = CommandType.StoredProcedure
            ' Call stored proc which will insert the record 
            cmdDeleteAttendant = New OleDb.OleDbCommand(cmdDeleteAttendant.CommandText, m_conAdministrator)
            ' this return is the # of rows affected
            intRowsAffected = cmdDeleteAttendant.ExecuteNonQuery()
            ' close database connection
            CloseDatabaseConnection()
            ' have to let the user know what happened 
            If intRowsAffected > 0 Then
                MessageBox.Show("Delete successful " & cboAttendant.Text & " has been deleted.")
            Else
                MessageBox.Show("Delete failed")
            End If
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class