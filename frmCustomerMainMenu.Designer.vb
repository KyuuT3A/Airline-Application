<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMainMenu
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
        Me.btnUpdateCustomerProfile = New System.Windows.Forms.Button()
        Me.btnShowFutureFlights = New System.Windows.Forms.Button()
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.btnShowPastFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdateCustomerProfile
        '
        Me.btnUpdateCustomerProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnUpdateCustomerProfile.Location = New System.Drawing.Point(44, 24)
        Me.btnUpdateCustomerProfile.Name = "btnUpdateCustomerProfile"
        Me.btnUpdateCustomerProfile.Size = New System.Drawing.Size(218, 43)
        Me.btnUpdateCustomerProfile.TabIndex = 0
        Me.btnUpdateCustomerProfile.Text = "Update Customer Profile"
        Me.btnUpdateCustomerProfile.UseVisualStyleBackColor = True
        '
        'btnShowFutureFlights
        '
        Me.btnShowFutureFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnShowFutureFlights.Location = New System.Drawing.Point(44, 169)
        Me.btnShowFutureFlights.Name = "btnShowFutureFlights"
        Me.btnShowFutureFlights.Size = New System.Drawing.Size(218, 43)
        Me.btnShowFutureFlights.TabIndex = 1
        Me.btnShowFutureFlights.Text = "Show Future Flights"
        Me.btnShowFutureFlights.UseVisualStyleBackColor = True
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddFlight.Location = New System.Drawing.Point(44, 71)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(218, 43)
        Me.btnAddFlight.TabIndex = 3
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'btnShowPastFlights
        '
        Me.btnShowPastFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnShowPastFlights.Location = New System.Drawing.Point(44, 120)
        Me.btnShowPastFlights.Name = "btnShowPastFlights"
        Me.btnShowPastFlights.Size = New System.Drawing.Size(218, 43)
        Me.btnShowPastFlights.TabIndex = 2
        Me.btnShowPastFlights.Text = "Show Past Flight"
        Me.btnShowPastFlights.UseVisualStyleBackColor = True
        '
        'frmCustomerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 245)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.btnShowPastFlights)
        Me.Controls.Add(Me.btnShowFutureFlights)
        Me.Controls.Add(Me.btnUpdateCustomerProfile)
        Me.Name = "frmCustomerMainMenu"
        Me.Text = "Customer Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdateCustomerProfile As Button
    Friend WithEvents btnShowFutureFlights As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnShowPastFlights As Button
End Class
