<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignAttendantToFutureFlights
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
        Me.lblAttendant1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cboFlights = New System.Windows.Forms.ComboBox()
        Me.cboAttendants = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblFlights1
        '
        Me.lblFlights1.AutoSize = True
        Me.lblFlights1.Location = New System.Drawing.Point(21, 92)
        Me.lblFlights1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFlights1.Name = "lblFlights1"
        Me.lblFlights1.Size = New System.Drawing.Size(37, 13)
        Me.lblFlights1.TabIndex = 17
        Me.lblFlights1.Text = "Flights"
        '
        'lblAttendant1
        '
        Me.lblAttendant1.AutoSize = True
        Me.lblAttendant1.Location = New System.Drawing.Point(21, 33)
        Me.lblAttendant1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAttendant1.Name = "lblAttendant1"
        Me.lblAttendant1.Size = New System.Drawing.Size(32, 13)
        Me.lblAttendant1.TabIndex = 16
        Me.lblAttendant1.Text = "Pilots"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(189, 136)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(51, 134)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 40)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cboFlights
        '
        Me.cboFlights.FormattingEnabled = True
        Me.cboFlights.Location = New System.Drawing.Point(121, 89)
        Me.cboFlights.Margin = New System.Windows.Forms.Padding(1)
        Me.cboFlights.Name = "cboFlights"
        Me.cboFlights.Size = New System.Drawing.Size(187, 21)
        Me.cboFlights.TabIndex = 13
        '
        'cboAttendants
        '
        Me.cboAttendants.FormattingEnabled = True
        Me.cboAttendants.Location = New System.Drawing.Point(122, 30)
        Me.cboAttendants.Margin = New System.Windows.Forms.Padding(1)
        Me.cboAttendants.Name = "cboAttendants"
        Me.cboAttendants.Size = New System.Drawing.Size(187, 21)
        Me.cboAttendants.TabIndex = 12
        '
        'frmAssignAttendantToFutureFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 219)
        Me.Controls.Add(Me.lblFlights1)
        Me.Controls.Add(Me.lblAttendant1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cboFlights)
        Me.Controls.Add(Me.cboAttendants)
        Me.Name = "frmAssignAttendantToFutureFlights"
        Me.Text = "Assign Attendant To Future Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFlights1 As Label
    Friend WithEvents lblAttendant1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cboFlights As ComboBox
    Friend WithEvents cboAttendants As ComboBox
End Class
