<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomers
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
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtPassengerPassword = New System.Windows.Forms.TextBox()
        Me.txtPassengerLoginID = New System.Windows.Forms.TextBox()
        Me.lblPassengerPassword = New System.Windows.Forms.Label()
        Me.lblPassengerLoginID = New System.Windows.Forms.Label()
        Me.lblPassengerDateofBirth = New System.Windows.Forms.Label()
        Me.dteDateofBirth = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExit.Location = New System.Drawing.Point(29, 459)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 71
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(206, 459)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(85, 35)
        Me.btnSubmit.TabIndex = 70
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cboState
        '
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(179, 176)
        Me.cboState.Margin = New System.Windows.Forms.Padding(2)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(112, 24)
        Me.cboState.TabIndex = 69
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(179, 288)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(112, 23)
        Me.txtEmail.TabIndex = 68
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(179, 250)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(112, 23)
        Me.txtPhoneNumber.TabIndex = 67
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtZip.Location = New System.Drawing.Point(179, 216)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(112, 23)
        Me.txtZip.TabIndex = 66
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCity.Location = New System.Drawing.Point(179, 136)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(112, 23)
        Me.txtCity.TabIndex = 65
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAddress.Location = New System.Drawing.Point(179, 99)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(112, 23)
        Me.txtAddress.TabIndex = 64
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(179, 65)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(112, 23)
        Me.txtLastName.TabIndex = 63
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(179, 32)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(112, 23)
        Me.txtFirstName.TabIndex = 62
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(26, 292)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 61
        Me.lblEmail.Text = "Email"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(26, 256)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblPhoneNumber.TabIndex = 60
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblZip.Location = New System.Drawing.Point(26, 216)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(28, 17)
        Me.lblZip.TabIndex = 59
        Me.lblZip.Text = "Zip"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblState.Location = New System.Drawing.Point(26, 176)
        Me.lblState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 17)
        Me.lblState.TabIndex = 58
        Me.lblState.Text = "State"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCity.Location = New System.Drawing.Point(26, 136)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 17)
        Me.lblCity.TabIndex = 57
        Me.lblCity.Text = "City"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAddress.Location = New System.Drawing.Point(26, 99)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 56
        Me.lblAddress.Text = "Address"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLastName.Location = New System.Drawing.Point(26, 65)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 55
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(26, 32)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblFirstName.TabIndex = 54
        Me.lblFirstName.Text = "First Name"
        '
        'txtPassengerPassword
        '
        Me.txtPassengerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassengerPassword.Location = New System.Drawing.Point(179, 367)
        Me.txtPassengerPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassengerPassword.Name = "txtPassengerPassword"
        Me.txtPassengerPassword.Size = New System.Drawing.Size(112, 23)
        Me.txtPassengerPassword.TabIndex = 75
        '
        'txtPassengerLoginID
        '
        Me.txtPassengerLoginID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassengerLoginID.Location = New System.Drawing.Point(179, 329)
        Me.txtPassengerLoginID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassengerLoginID.Name = "txtPassengerLoginID"
        Me.txtPassengerLoginID.Size = New System.Drawing.Size(112, 23)
        Me.txtPassengerLoginID.TabIndex = 74
        '
        'lblPassengerPassword
        '
        Me.lblPassengerPassword.AutoSize = True
        Me.lblPassengerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassengerPassword.Location = New System.Drawing.Point(26, 371)
        Me.lblPassengerPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerPassword.Name = "lblPassengerPassword"
        Me.lblPassengerPassword.Size = New System.Drawing.Size(141, 17)
        Me.lblPassengerPassword.TabIndex = 73
        Me.lblPassengerPassword.Text = "Passenger Password"
        '
        'lblPassengerLoginID
        '
        Me.lblPassengerLoginID.AutoSize = True
        Me.lblPassengerLoginID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassengerLoginID.Location = New System.Drawing.Point(26, 335)
        Me.lblPassengerLoginID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerLoginID.Name = "lblPassengerLoginID"
        Me.lblPassengerLoginID.Size = New System.Drawing.Size(132, 17)
        Me.lblPassengerLoginID.TabIndex = 72
        Me.lblPassengerLoginID.Text = "Passenger Login ID"
        '
        'lblPassengerDateofBirth
        '
        Me.lblPassengerDateofBirth.AutoSize = True
        Me.lblPassengerDateofBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassengerDateofBirth.Location = New System.Drawing.Point(26, 413)
        Me.lblPassengerDateofBirth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerDateofBirth.Name = "lblPassengerDateofBirth"
        Me.lblPassengerDateofBirth.Size = New System.Drawing.Size(87, 17)
        Me.lblPassengerDateofBirth.TabIndex = 76
        Me.lblPassengerDateofBirth.Text = "Date of Birth"
        '
        'dteDateofBirth
        '
        Me.dteDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDateofBirth.Location = New System.Drawing.Point(179, 413)
        Me.dteDateofBirth.Name = "dteDateofBirth"
        Me.dteDateofBirth.Size = New System.Drawing.Size(112, 20)
        Me.dteDateofBirth.TabIndex = 77
        '
        'frmAddCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 532)
        Me.Controls.Add(Me.dteDateofBirth)
        Me.Controls.Add(Me.lblPassengerDateofBirth)
        Me.Controls.Add(Me.txtPassengerPassword)
        Me.Controls.Add(Me.txtPassengerLoginID)
        Me.Controls.Add(Me.lblPassengerPassword)
        Me.Controls.Add(Me.lblPassengerLoginID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "frmAddCustomers"
        Me.Text = "Add Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtPassengerPassword As TextBox
    Friend WithEvents txtPassengerLoginID As TextBox
    Friend WithEvents lblPassengerPassword As Label
    Friend WithEvents lblPassengerLoginID As Label
    Friend WithEvents lblPassengerDateofBirth As Label
    Friend WithEvents dteDateofBirth As DateTimePicker
End Class
