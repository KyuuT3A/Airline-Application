<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateCustomerProfile
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
        Me.txtPassengerPassword = New System.Windows.Forms.TextBox()
        Me.txtPassengerLoginID = New System.Windows.Forms.TextBox()
        Me.lblPassengerPassword = New System.Windows.Forms.Label()
        Me.lblPassengerLoginID = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
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
        Me.dteDateofBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblPassengerDateofBirth = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPassengerPassword
        '
        Me.txtPassengerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassengerPassword.Location = New System.Drawing.Point(181, 361)
        Me.txtPassengerPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassengerPassword.Name = "txtPassengerPassword"
        Me.txtPassengerPassword.Size = New System.Drawing.Size(112, 23)
        Me.txtPassengerPassword.TabIndex = 117
        '
        'txtPassengerLoginID
        '
        Me.txtPassengerLoginID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassengerLoginID.Location = New System.Drawing.Point(181, 323)
        Me.txtPassengerLoginID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassengerLoginID.Name = "txtPassengerLoginID"
        Me.txtPassengerLoginID.Size = New System.Drawing.Size(112, 23)
        Me.txtPassengerLoginID.TabIndex = 116
        '
        'lblPassengerPassword
        '
        Me.lblPassengerPassword.AutoSize = True
        Me.lblPassengerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassengerPassword.Location = New System.Drawing.Point(28, 365)
        Me.lblPassengerPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerPassword.Name = "lblPassengerPassword"
        Me.lblPassengerPassword.Size = New System.Drawing.Size(141, 17)
        Me.lblPassengerPassword.TabIndex = 115
        Me.lblPassengerPassword.Text = "Passenger Password"
        '
        'lblPassengerLoginID
        '
        Me.lblPassengerLoginID.AutoSize = True
        Me.lblPassengerLoginID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassengerLoginID.Location = New System.Drawing.Point(28, 329)
        Me.lblPassengerLoginID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerLoginID.Name = "lblPassengerLoginID"
        Me.lblPassengerLoginID.Size = New System.Drawing.Size(132, 17)
        Me.lblPassengerLoginID.TabIndex = 114
        Me.lblPassengerLoginID.Text = "Passenger Login ID"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExit.Location = New System.Drawing.Point(31, 452)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 34)
        Me.btnExit.TabIndex = 113
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(183, 452)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 34)
        Me.btnUpdate.TabIndex = 112
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboState
        '
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(181, 174)
        Me.cboState.Margin = New System.Windows.Forms.Padding(2)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(102, 24)
        Me.cboState.TabIndex = 111
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(181, 286)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(102, 23)
        Me.txtEmail.TabIndex = 110
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(181, 248)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(102, 23)
        Me.txtPhoneNumber.TabIndex = 109
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtZip.Location = New System.Drawing.Point(181, 214)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(102, 23)
        Me.txtZip.TabIndex = 108
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCity.Location = New System.Drawing.Point(181, 134)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(102, 23)
        Me.txtCity.TabIndex = 107
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAddress.Location = New System.Drawing.Point(181, 97)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(102, 23)
        Me.txtAddress.TabIndex = 106
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(181, 63)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(102, 23)
        Me.txtLastName.TabIndex = 105
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(181, 30)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(102, 23)
        Me.txtFirstName.TabIndex = 104
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(28, 292)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 103
        Me.lblEmail.Text = "Email"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPhoneNumber.Location = New System.Drawing.Point(28, 256)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblPhoneNumber.TabIndex = 102
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblZip.Location = New System.Drawing.Point(28, 216)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(28, 17)
        Me.lblZip.TabIndex = 101
        Me.lblZip.Text = "Zip"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblState.Location = New System.Drawing.Point(28, 176)
        Me.lblState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 17)
        Me.lblState.TabIndex = 100
        Me.lblState.Text = "State"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCity.Location = New System.Drawing.Point(28, 136)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 17)
        Me.lblCity.TabIndex = 99
        Me.lblCity.Text = "City"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAddress.Location = New System.Drawing.Point(28, 99)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 98
        Me.lblAddress.Text = "Address"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLastName.Location = New System.Drawing.Point(28, 65)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 97
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(28, 32)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblFirstName.TabIndex = 96
        Me.lblFirstName.Text = "First Name"
        '
        'dteDateofBirth
        '
        Me.dteDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDateofBirth.Location = New System.Drawing.Point(181, 402)
        Me.dteDateofBirth.Name = "dteDateofBirth"
        Me.dteDateofBirth.Size = New System.Drawing.Size(112, 20)
        Me.dteDateofBirth.TabIndex = 119
        '
        'lblPassengerDateofBirth
        '
        Me.lblPassengerDateofBirth.AutoSize = True
        Me.lblPassengerDateofBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassengerDateofBirth.Location = New System.Drawing.Point(28, 402)
        Me.lblPassengerDateofBirth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerDateofBirth.Name = "lblPassengerDateofBirth"
        Me.lblPassengerDateofBirth.Size = New System.Drawing.Size(87, 17)
        Me.lblPassengerDateofBirth.TabIndex = 118
        Me.lblPassengerDateofBirth.Text = "Date of Birth"
        '
        'frmUpdateCustomerProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 515)
        Me.Controls.Add(Me.dteDateofBirth)
        Me.Controls.Add(Me.lblPassengerDateofBirth)
        Me.Controls.Add(Me.txtPassengerPassword)
        Me.Controls.Add(Me.txtPassengerLoginID)
        Me.Controls.Add(Me.lblPassengerPassword)
        Me.Controls.Add(Me.lblPassengerLoginID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
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
        Me.Name = "frmUpdateCustomerProfile"
        Me.Text = "Update Customer Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassengerPassword As TextBox
    Friend WithEvents txtPassengerLoginID As TextBox
    Friend WithEvents lblPassengerPassword As Label
    Friend WithEvents lblPassengerLoginID As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
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
    Friend WithEvents dteDateofBirth As DateTimePicker
    Friend WithEvents lblPassengerDateofBirth As Label
End Class
