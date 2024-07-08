<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateFutureFlights_Admin_
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
        Me.lblFlightDate = New System.Windows.Forms.Label()
        Me.lblFlightNumber = New System.Windows.Forms.Label()
        Me.lblTimeOfDeparture = New System.Windows.Forms.Label()
        Me.lblToAirport = New System.Windows.Forms.Label()
        Me.lblFromAirport = New System.Windows.Forms.Label()
        Me.lblTimeOfLanding = New System.Windows.Forms.Label()
        Me.dtmFlightDate = New System.Windows.Forms.DateTimePicker()
        Me.dtmTimeOfDeparture = New System.Windows.Forms.DateTimePicker()
        Me.dtmTimeOfLanding = New System.Windows.Forms.DateTimePicker()
        Me.cboAirport = New System.Windows.Forms.ComboBox()
        Me.cboAirports = New System.Windows.Forms.ComboBox()
        Me.lblMilesFlown = New System.Windows.Forms.Label()
        Me.txtMilesFlown = New System.Windows.Forms.TextBox()
        Me.cboPlaneID = New System.Windows.Forms.ComboBox()
        Me.lblPlaneID = New System.Windows.Forms.Label()
        Me.btnAddFutureFlight = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtFlightNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFlightDate
        '
        Me.lblFlightDate.AutoSize = True
        Me.lblFlightDate.Location = New System.Drawing.Point(24, 32)
        Me.lblFlightDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFlightDate.Name = "lblFlightDate"
        Me.lblFlightDate.Size = New System.Drawing.Size(58, 13)
        Me.lblFlightDate.TabIndex = 0
        Me.lblFlightDate.Text = "Flight Date"
        '
        'lblFlightNumber
        '
        Me.lblFlightNumber.AutoSize = True
        Me.lblFlightNumber.Location = New System.Drawing.Point(24, 72)
        Me.lblFlightNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFlightNumber.Name = "lblFlightNumber"
        Me.lblFlightNumber.Size = New System.Drawing.Size(72, 13)
        Me.lblFlightNumber.TabIndex = 1
        Me.lblFlightNumber.Text = "Flight Number"
        '
        'lblTimeOfDeparture
        '
        Me.lblTimeOfDeparture.AutoSize = True
        Me.lblTimeOfDeparture.Location = New System.Drawing.Point(24, 113)
        Me.lblTimeOfDeparture.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeOfDeparture.Name = "lblTimeOfDeparture"
        Me.lblTimeOfDeparture.Size = New System.Drawing.Size(92, 13)
        Me.lblTimeOfDeparture.TabIndex = 2
        Me.lblTimeOfDeparture.Text = "Time of Departure"
        '
        'lblToAirport
        '
        Me.lblToAirport.AutoSize = True
        Me.lblToAirport.Location = New System.Drawing.Point(24, 236)
        Me.lblToAirport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToAirport.Name = "lblToAirport"
        Me.lblToAirport.Size = New System.Drawing.Size(53, 13)
        Me.lblToAirport.TabIndex = 5
        Me.lblToAirport.Text = "To Airport"
        '
        'lblFromAirport
        '
        Me.lblFromAirport.AutoSize = True
        Me.lblFromAirport.Location = New System.Drawing.Point(24, 194)
        Me.lblFromAirport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFromAirport.Name = "lblFromAirport"
        Me.lblFromAirport.Size = New System.Drawing.Size(63, 13)
        Me.lblFromAirport.TabIndex = 4
        Me.lblFromAirport.Text = "From Airport"
        '
        'lblTimeOfLanding
        '
        Me.lblTimeOfLanding.AutoSize = True
        Me.lblTimeOfLanding.Location = New System.Drawing.Point(24, 155)
        Me.lblTimeOfLanding.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeOfLanding.Name = "lblTimeOfLanding"
        Me.lblTimeOfLanding.Size = New System.Drawing.Size(85, 13)
        Me.lblTimeOfLanding.TabIndex = 3
        Me.lblTimeOfLanding.Text = "Time Of Landing"
        '
        'dtmFlightDate
        '
        Me.dtmFlightDate.CustomFormat = "yyyy-MM-dd "
        Me.dtmFlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmFlightDate.Location = New System.Drawing.Point(128, 32)
        Me.dtmFlightDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtmFlightDate.Name = "dtmFlightDate"
        Me.dtmFlightDate.Size = New System.Drawing.Size(92, 20)
        Me.dtmFlightDate.TabIndex = 6
        '
        'dtmTimeOfDeparture
        '
        Me.dtmTimeOfDeparture.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtmTimeOfDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmTimeOfDeparture.Location = New System.Drawing.Point(128, 113)
        Me.dtmTimeOfDeparture.Margin = New System.Windows.Forms.Padding(2)
        Me.dtmTimeOfDeparture.Name = "dtmTimeOfDeparture"
        Me.dtmTimeOfDeparture.Size = New System.Drawing.Size(147, 20)
        Me.dtmTimeOfDeparture.TabIndex = 8
        '
        'dtmTimeOfLanding
        '
        Me.dtmTimeOfLanding.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtmTimeOfLanding.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmTimeOfLanding.Location = New System.Drawing.Point(128, 155)
        Me.dtmTimeOfLanding.Margin = New System.Windows.Forms.Padding(2)
        Me.dtmTimeOfLanding.Name = "dtmTimeOfLanding"
        Me.dtmTimeOfLanding.Size = New System.Drawing.Size(147, 20)
        Me.dtmTimeOfLanding.TabIndex = 9
        '
        'cboAirport
        '
        Me.cboAirport.FormattingEnabled = True
        Me.cboAirport.Location = New System.Drawing.Point(128, 194)
        Me.cboAirport.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAirport.Name = "cboAirport"
        Me.cboAirport.Size = New System.Drawing.Size(92, 21)
        Me.cboAirport.TabIndex = 10
        '
        'cboAirports
        '
        Me.cboAirports.Location = New System.Drawing.Point(128, 236)
        Me.cboAirports.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAirports.Name = "cboAirports"
        Me.cboAirports.Size = New System.Drawing.Size(92, 21)
        Me.cboAirports.TabIndex = 0
        '
        'lblMilesFlown
        '
        Me.lblMilesFlown.AutoSize = True
        Me.lblMilesFlown.Location = New System.Drawing.Point(24, 280)
        Me.lblMilesFlown.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMilesFlown.Name = "lblMilesFlown"
        Me.lblMilesFlown.Size = New System.Drawing.Size(62, 13)
        Me.lblMilesFlown.TabIndex = 11
        Me.lblMilesFlown.Text = "Miles Flown"
        '
        'txtMilesFlown
        '
        Me.txtMilesFlown.Location = New System.Drawing.Point(128, 280)
        Me.txtMilesFlown.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMilesFlown.Name = "txtMilesFlown"
        Me.txtMilesFlown.Size = New System.Drawing.Size(76, 20)
        Me.txtMilesFlown.TabIndex = 12
        '
        'cboPlaneID
        '
        Me.cboPlaneID.FormattingEnabled = True
        Me.cboPlaneID.Location = New System.Drawing.Point(128, 321)
        Me.cboPlaneID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPlaneID.Name = "cboPlaneID"
        Me.cboPlaneID.Size = New System.Drawing.Size(92, 21)
        Me.cboPlaneID.TabIndex = 13
        '
        'lblPlaneID
        '
        Me.lblPlaneID.AutoSize = True
        Me.lblPlaneID.Location = New System.Drawing.Point(26, 321)
        Me.lblPlaneID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlaneID.Name = "lblPlaneID"
        Me.lblPlaneID.Size = New System.Drawing.Size(48, 13)
        Me.lblPlaneID.TabIndex = 14
        Me.lblPlaneID.Text = "Plane ID"
        '
        'btnAddFutureFlight
        '
        Me.btnAddFutureFlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAddFutureFlight.Location = New System.Drawing.Point(26, 361)
        Me.btnAddFutureFlight.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddFutureFlight.Name = "btnAddFutureFlight"
        Me.btnAddFutureFlight.Size = New System.Drawing.Size(110, 40)
        Me.btnAddFutureFlight.TabIndex = 15
        Me.btnAddFutureFlight.Text = "Add Future Flight"
        Me.btnAddFutureFlight.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnClose.Location = New System.Drawing.Point(163, 361)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 40)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtFlightNumber
        '
        Me.txtFlightNumber.Location = New System.Drawing.Point(128, 72)
        Me.txtFlightNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFlightNumber.Name = "txtFlightNumber"
        Me.txtFlightNumber.Size = New System.Drawing.Size(76, 20)
        Me.txtFlightNumber.TabIndex = 18
        '
        'frmCreateFutureFlights_Admin_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 432)
        Me.Controls.Add(Me.txtFlightNumber)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddFutureFlight)
        Me.Controls.Add(Me.lblPlaneID)
        Me.Controls.Add(Me.cboPlaneID)
        Me.Controls.Add(Me.txtMilesFlown)
        Me.Controls.Add(Me.lblMilesFlown)
        Me.Controls.Add(Me.cboAirports)
        Me.Controls.Add(Me.cboAirport)
        Me.Controls.Add(Me.dtmTimeOfLanding)
        Me.Controls.Add(Me.dtmTimeOfDeparture)
        Me.Controls.Add(Me.dtmFlightDate)
        Me.Controls.Add(Me.lblToAirport)
        Me.Controls.Add(Me.lblFromAirport)
        Me.Controls.Add(Me.lblTimeOfLanding)
        Me.Controls.Add(Me.lblTimeOfDeparture)
        Me.Controls.Add(Me.lblFlightNumber)
        Me.Controls.Add(Me.lblFlightDate)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCreateFutureFlights_Admin_"
        Me.Text = "Create Future Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFlightDate As Label
    Friend WithEvents lblFlightNumber As Label
    Friend WithEvents lblTimeOfDeparture As Label
    Friend WithEvents lblToAirport As Label
    Friend WithEvents lblFromAirport As Label
    Friend WithEvents lblTimeOfLanding As Label
    Friend WithEvents dtmFlightDate As DateTimePicker
    Friend WithEvents dtmTimeOfDeparture As DateTimePicker
    Friend WithEvents dtmTimeOfLanding As DateTimePicker
    Friend WithEvents cboAirport As ComboBox
    Friend WithEvents cboAirports As ComboBox
    Friend WithEvents lblMilesFlown As Label
    Friend WithEvents txtMilesFlown As TextBox
    Friend WithEvents cboPlaneID As ComboBox
    Friend WithEvents lblPlaneID As Label
    Friend WithEvents btnAddFutureFlight As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtFlightNumber As TextBox
End Class
