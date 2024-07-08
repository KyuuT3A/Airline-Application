<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignPilotToFutureFlights
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
        Me.lblFlights1 = New System.Windows.Forms.Label()
        Me.lblPilot1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cboFlights = New System.Windows.Forms.ComboBox()
        Me.cboPilots = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblFlights1
        '
        Me.lblFlights1.AutoSize = True
        Me.lblFlights1.Location = New System.Drawing.Point(27, 91)
        Me.lblFlights1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFlights1.Name = "lblFlights1"
        Me.lblFlights1.Size = New System.Drawing.Size(37, 13)
        Me.lblFlights1.TabIndex = 11
        Me.lblFlights1.Text = "Flights"
        '
        'lblPilot1
        '
        Me.lblPilot1.AutoSize = True
        Me.lblPilot1.Location = New System.Drawing.Point(27, 32)
        Me.lblPilot1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPilot1.Name = "lblPilot1"
        Me.lblPilot1.Size = New System.Drawing.Size(32, 13)
        Me.lblPilot1.TabIndex = 10
        Me.lblPilot1.Text = "Pilots"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(195, 135)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 36)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(57, 133)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 40)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cboFlights
        '
        Me.cboFlights.FormattingEnabled = True
        Me.cboFlights.Location = New System.Drawing.Point(127, 88)
        Me.cboFlights.Margin = New System.Windows.Forms.Padding(1)
        Me.cboFlights.Name = "cboFlights"
        Me.cboFlights.Size = New System.Drawing.Size(187, 21)
        Me.cboFlights.TabIndex = 7
        '
        'cboPilots
        '
        Me.cboPilots.FormattingEnabled = True
        Me.cboPilots.Location = New System.Drawing.Point(128, 29)
        Me.cboPilots.Margin = New System.Windows.Forms.Padding(1)
        Me.cboPilots.Name = "cboPilots"
        Me.cboPilots.Size = New System.Drawing.Size(187, 21)
        Me.cboPilots.TabIndex = 6
        '
        'frmAssignPilotToFutureFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 209)
        Me.Controls.Add(Me.lblFlights1)
        Me.Controls.Add(Me.lblPilot1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cboFlights)
        Me.Controls.Add(Me.cboPilots)
        Me.Name = "frmAssignPilotToFutureFlights"
        Me.Text = "Assign Pilot To Future Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFlights1 As Label
    Friend WithEvents lblPilot1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cboFlights As ComboBox
    Friend WithEvents cboPilots As ComboBox
End Class
