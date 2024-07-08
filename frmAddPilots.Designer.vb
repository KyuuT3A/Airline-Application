<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPilots
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cboPilotRole = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblDateOfLicense = New System.Windows.Forms.Label()
        Me.lblDateOfTermination = New System.Windows.Forms.Label()
        Me.lblPilotRole = New System.Windows.Forms.Label()
        Me.lblDateofHire = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmployeePassword = New System.Windows.Forms.TextBox()
        Me.txtEmployeeLoginID = New System.Windows.Forms.TextBox()
        Me.lblEmployeePassword = New System.Windows.Forms.Label()
        Me.lblEmployeeLoginID = New System.Windows.Forms.Label()
        Me.dtmDateOfHire = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateofTermination = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateofLicense = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExit.Location = New System.Drawing.Point(28, 359)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 34)
        Me.btnExit.TabIndex = 125
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(218, 359)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(105, 34)
        Me.btnSubmit.TabIndex = 124
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cboPilotRole
        '
        Me.cboPilotRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboPilotRole.FormattingEnabled = True
        Me.cboPilotRole.Location = New System.Drawing.Point(164, 169)
        Me.cboPilotRole.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPilotRole.Name = "cboPilotRole"
        Me.cboPilotRole.Size = New System.Drawing.Size(158, 24)
        Me.cboPilotRole.TabIndex = 123
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmployeeID.Location = New System.Drawing.Point(164, 92)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(158, 23)
        Me.txtEmployeeID.TabIndex = 119
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(164, 58)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(158, 23)
        Me.txtLastName.TabIndex = 118
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(164, 25)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(158, 23)
        Me.txtFirstName.TabIndex = 117
        '
        'lblDateOfLicense
        '
        Me.lblDateOfLicense.AutoSize = True
        Me.lblDateOfLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDateOfLicense.Location = New System.Drawing.Point(25, 249)
        Me.lblDateOfLicense.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateOfLicense.Name = "lblDateOfLicense"
        Me.lblDateOfLicense.Size = New System.Drawing.Size(110, 17)
        Me.lblDateOfLicense.TabIndex = 116
        Me.lblDateOfLicense.Text = "Date Of License"
        '
        'lblDateOfTermination
        '
        Me.lblDateOfTermination.AutoSize = True
        Me.lblDateOfTermination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDateOfTermination.Location = New System.Drawing.Point(25, 209)
        Me.lblDateOfTermination.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateOfTermination.Name = "lblDateOfTermination"
        Me.lblDateOfTermination.Size = New System.Drawing.Size(136, 17)
        Me.lblDateOfTermination.TabIndex = 115
        Me.lblDateOfTermination.Text = "Date Of Termination"
        '
        'lblPilotRole
        '
        Me.lblPilotRole.AutoSize = True
        Me.lblPilotRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPilotRole.Location = New System.Drawing.Point(25, 169)
        Me.lblPilotRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPilotRole.Name = "lblPilotRole"
        Me.lblPilotRole.Size = New System.Drawing.Size(68, 17)
        Me.lblPilotRole.TabIndex = 114
        Me.lblPilotRole.Text = "Pilot Role"
        '
        'lblDateofHire
        '
        Me.lblDateofHire.AutoSize = True
        Me.lblDateofHire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDateofHire.Location = New System.Drawing.Point(25, 129)
        Me.lblDateofHire.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateofHire.Name = "lblDateofHire"
        Me.lblDateofHire.Size = New System.Drawing.Size(84, 17)
        Me.lblDateofHire.TabIndex = 113
        Me.lblDateofHire.Text = "Date of Hire"
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblEmployeeID.Location = New System.Drawing.Point(25, 92)
        Me.lblEmployeeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(87, 17)
        Me.lblEmployeeID.TabIndex = 112
        Me.lblEmployeeID.Text = "Employee ID"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLastName.Location = New System.Drawing.Point(25, 58)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 111
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(25, 25)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblFirstName.TabIndex = 110
        Me.lblFirstName.Text = "First Name"
        '
        'txtEmployeePassword
        '
        Me.txtEmployeePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmployeePassword.Location = New System.Drawing.Point(178, 319)
        Me.txtEmployeePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployeePassword.Name = "txtEmployeePassword"
        Me.txtEmployeePassword.Size = New System.Drawing.Size(144, 23)
        Me.txtEmployeePassword.TabIndex = 129
        '
        'txtEmployeeLoginID
        '
        Me.txtEmployeeLoginID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmployeeLoginID.Location = New System.Drawing.Point(178, 281)
        Me.txtEmployeeLoginID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployeeLoginID.Name = "txtEmployeeLoginID"
        Me.txtEmployeeLoginID.Size = New System.Drawing.Size(144, 23)
        Me.txtEmployeeLoginID.TabIndex = 128
        '
        'lblEmployeePassword
        '
        Me.lblEmployeePassword.AutoSize = True
        Me.lblEmployeePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblEmployeePassword.Location = New System.Drawing.Point(25, 323)
        Me.lblEmployeePassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeePassword.Name = "lblEmployeePassword"
        Me.lblEmployeePassword.Size = New System.Drawing.Size(135, 17)
        Me.lblEmployeePassword.TabIndex = 127
        Me.lblEmployeePassword.Text = "Employee Password"
        '
        'lblEmployeeLoginID
        '
        Me.lblEmployeeLoginID.AutoSize = True
        Me.lblEmployeeLoginID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblEmployeeLoginID.Location = New System.Drawing.Point(25, 287)
        Me.lblEmployeeLoginID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeLoginID.Name = "lblEmployeeLoginID"
        Me.lblEmployeeLoginID.Size = New System.Drawing.Size(126, 17)
        Me.lblEmployeeLoginID.TabIndex = 126
        Me.lblEmployeeLoginID.Text = "Employee Login ID"
        '
        'dtmDateOfHire
        '
        Me.dtmDateOfHire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmDateOfHire.Location = New System.Drawing.Point(164, 129)
        Me.dtmDateOfHire.Name = "dtmDateOfHire"
        Me.dtmDateOfHire.Size = New System.Drawing.Size(111, 20)
        Me.dtmDateOfHire.TabIndex = 130
        '
        'dtmDateofTermination
        '
        Me.dtmDateofTermination.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmDateofTermination.Location = New System.Drawing.Point(166, 209)
        Me.dtmDateofTermination.Name = "dtmDateofTermination"
        Me.dtmDateofTermination.Size = New System.Drawing.Size(109, 20)
        Me.dtmDateofTermination.TabIndex = 131
        '
        'dtmDateofLicense
        '
        Me.dtmDateofLicense.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmDateofLicense.Location = New System.Drawing.Point(166, 245)
        Me.dtmDateofLicense.Name = "dtmDateofLicense"
        Me.dtmDateofLicense.Size = New System.Drawing.Size(109, 20)
        Me.dtmDateofLicense.TabIndex = 132
        '
        'frmAddPilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 413)
        Me.Controls.Add(Me.dtmDateofLicense)
        Me.Controls.Add(Me.dtmDateofTermination)
        Me.Controls.Add(Me.dtmDateOfHire)
        Me.Controls.Add(Me.txtEmployeePassword)
        Me.Controls.Add(Me.txtEmployeeLoginID)
        Me.Controls.Add(Me.lblEmployeePassword)
        Me.Controls.Add(Me.lblEmployeeLoginID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cboPilotRole)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblDateOfLicense)
        Me.Controls.Add(Me.lblDateOfTermination)
        Me.Controls.Add(Me.lblPilotRole)
        Me.Controls.Add(Me.lblDateofHire)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "frmAddPilots"
        Me.Text = "Add Pilots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cboPilotRole As ComboBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblDateOfLicense As Label
    Friend WithEvents lblDateOfTermination As Label
    Friend WithEvents lblPilotRole As Label
    Friend WithEvents lblDateofHire As Label
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtEmployeePassword As TextBox
    Friend WithEvents txtEmployeeLoginID As TextBox
    Friend WithEvents lblEmployeePassword As Label
    Friend WithEvents lblEmployeeLoginID As Label
    Friend WithEvents dtmDateOfHire As DateTimePicker
    Friend WithEvents dtmDateofTermination As DateTimePicker
    Friend WithEvents dtmDateofLicense As DateTimePicker
End Class
