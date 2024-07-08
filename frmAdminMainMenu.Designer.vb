<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnManagePilots = New System.Windows.Forms.Button()
        Me.btnManageAttendants = New System.Windows.Forms.Button()
        Me.btnCreateFutureFlights = New System.Windows.Forms.Button()
        Me.btnAddPilotForm = New System.Windows.Forms.Button()
        Me.btnUpdatePilotForm = New System.Windows.Forms.Button()
        Me.btnUpdateAttendantProfile = New System.Windows.Forms.Button()
        Me.btnAddAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManagePilots
        '
        Me.btnManagePilots.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnManagePilots.Location = New System.Drawing.Point(24, 139)
        Me.btnManagePilots.Name = "btnManagePilots"
        Me.btnManagePilots.Size = New System.Drawing.Size(229, 38)
        Me.btnManagePilots.TabIndex = 4
        Me.btnManagePilots.Text = "Manage Pilots"
        Me.btnManagePilots.UseVisualStyleBackColor = True
        '
        'btnManageAttendants
        '
        Me.btnManageAttendants.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnManageAttendants.Location = New System.Drawing.Point(281, 139)
        Me.btnManageAttendants.Name = "btnManageAttendants"
        Me.btnManageAttendants.Size = New System.Drawing.Size(229, 38)
        Me.btnManageAttendants.TabIndex = 5
        Me.btnManageAttendants.Text = "Manage Attendants"
        Me.btnManageAttendants.UseVisualStyleBackColor = True
        '
        'btnCreateFutureFlights
        '
        Me.btnCreateFutureFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCreateFutureFlights.Location = New System.Drawing.Point(154, 200)
        Me.btnCreateFutureFlights.Name = "btnCreateFutureFlights"
        Me.btnCreateFutureFlights.Size = New System.Drawing.Size(229, 38)
        Me.btnCreateFutureFlights.TabIndex = 6
        Me.btnCreateFutureFlights.Text = "Create Future Flights"
        Me.btnCreateFutureFlights.UseVisualStyleBackColor = True
        '
        'btnAddPilotForm
        '
        Me.btnAddPilotForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddPilotForm.Location = New System.Drawing.Point(24, 27)
        Me.btnAddPilotForm.Name = "btnAddPilotForm"
        Me.btnAddPilotForm.Size = New System.Drawing.Size(229, 38)
        Me.btnAddPilotForm.TabIndex = 7
        Me.btnAddPilotForm.Text = "Add Pilots"
        Me.btnAddPilotForm.UseVisualStyleBackColor = True
        '
        'btnUpdatePilotForm
        '
        Me.btnUpdatePilotForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnUpdatePilotForm.Location = New System.Drawing.Point(24, 81)
        Me.btnUpdatePilotForm.Name = "btnUpdatePilotForm"
        Me.btnUpdatePilotForm.Size = New System.Drawing.Size(229, 38)
        Me.btnUpdatePilotForm.TabIndex = 8
        Me.btnUpdatePilotForm.Text = "Update Pilot Form"
        Me.btnUpdatePilotForm.UseVisualStyleBackColor = True
        '
        'btnUpdateAttendantProfile
        '
        Me.btnUpdateAttendantProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnUpdateAttendantProfile.Location = New System.Drawing.Point(281, 81)
        Me.btnUpdateAttendantProfile.Name = "btnUpdateAttendantProfile"
        Me.btnUpdateAttendantProfile.Size = New System.Drawing.Size(229, 38)
        Me.btnUpdateAttendantProfile.TabIndex = 10
        Me.btnUpdateAttendantProfile.Text = "Update Attendant Form"
        Me.btnUpdateAttendantProfile.UseVisualStyleBackColor = True
        '
        'btnAddAttendant
        '
        Me.btnAddAttendant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddAttendant.Location = New System.Drawing.Point(281, 27)
        Me.btnAddAttendant.Name = "btnAddAttendant"
        Me.btnAddAttendant.Size = New System.Drawing.Size(229, 38)
        Me.btnAddAttendant.TabIndex = 9
        Me.btnAddAttendant.Text = "Add Attendants"
        Me.btnAddAttendant.UseVisualStyleBackColor = True
        '
        'frmAdminMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 261)
        Me.Controls.Add(Me.btnUpdateAttendantProfile)
        Me.Controls.Add(Me.btnAddAttendant)
        Me.Controls.Add(Me.btnUpdatePilotForm)
        Me.Controls.Add(Me.btnAddPilotForm)
        Me.Controls.Add(Me.btnCreateFutureFlights)
        Me.Controls.Add(Me.btnManageAttendants)
        Me.Controls.Add(Me.btnManagePilots)
        Me.Name = "frmAdminMainMenu"
        Me.Text = "Admin Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnManagePilots As Button
    Friend WithEvents btnManageAttendants As Button
    Friend WithEvents btnCreateFutureFlights As Button
    Friend WithEvents btnAddPilotForm As Button
    Friend WithEvents btnUpdatePilotForm As Button
    Friend WithEvents btnUpdateAttendantProfile As Button
    Friend WithEvents btnAddAttendant As Button
End Class
