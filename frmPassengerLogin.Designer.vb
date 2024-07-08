<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengerLogin
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
        Me.lblPassengerID = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassengerID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnNewPassenger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPassengerID
        '
        Me.lblPassengerID.AutoSize = True
        Me.lblPassengerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassengerID.Location = New System.Drawing.Point(30, 30)
        Me.lblPassengerID.Name = "lblPassengerID"
        Me.lblPassengerID.Size = New System.Drawing.Size(93, 17)
        Me.lblPassengerID.TabIndex = 0
        Me.lblPassengerID.Text = "Passenger ID"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassword.Location = New System.Drawing.Point(30, 87)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtPassengerID
        '
        Me.txtPassengerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassengerID.Location = New System.Drawing.Point(157, 30)
        Me.txtPassengerID.Name = "txtPassengerID"
        Me.txtPassengerID.Size = New System.Drawing.Size(143, 23)
        Me.txtPassengerID.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(157, 87)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(143, 23)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnLogin.Location = New System.Drawing.Point(33, 145)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(119, 43)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnNewPassenger
        '
        Me.btnNewPassenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnNewPassenger.Location = New System.Drawing.Point(181, 145)
        Me.btnNewPassenger.Name = "btnNewPassenger"
        Me.btnNewPassenger.Size = New System.Drawing.Size(119, 43)
        Me.btnNewPassenger.TabIndex = 7
        Me.btnNewPassenger.Text = "New Passenger"
        Me.btnNewPassenger.UseVisualStyleBackColor = True
        '
        'frmPassengerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 216)
        Me.Controls.Add(Me.btnNewPassenger)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPassengerID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblPassengerID)
        Me.Name = "frmPassengerLogin"
        Me.Text = "Passenger Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPassengerID As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassengerID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnNewPassenger As Button
End Class
