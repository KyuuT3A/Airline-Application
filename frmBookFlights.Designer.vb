<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookFlights
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
        Me.lblFlights = New System.Windows.Forms.Label()
        Me.cboFlights = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.radDesignatedSeat = New System.Windows.Forms.RadioButton()
        Me.radReservedSeat = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblReservedSeats = New System.Windows.Forms.Label()
        Me.lblDesignatedSeats = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFlights
        '
        Me.lblFlights.AutoSize = True
        Me.lblFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblFlights.Location = New System.Drawing.Point(74, 23)
        Me.lblFlights.Name = "lblFlights"
        Me.lblFlights.Size = New System.Drawing.Size(72, 15)
        Me.lblFlights.TabIndex = 0
        Me.lblFlights.Text = "Flight Dates"
        '
        'cboFlights
        '
        Me.cboFlights.FormattingEnabled = True
        Me.cboFlights.Location = New System.Drawing.Point(173, 23)
        Me.cboFlights.Name = "cboFlights"
        Me.cboFlights.Size = New System.Drawing.Size(132, 21)
        Me.cboFlights.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(21, 143)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(116, 34)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Flight"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'radDesignatedSeat
        '
        Me.radDesignatedSeat.AutoSize = True
        Me.radDesignatedSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.radDesignatedSeat.Location = New System.Drawing.Point(11, 108)
        Me.radDesignatedSeat.Name = "radDesignatedSeat"
        Me.radDesignatedSeat.Size = New System.Drawing.Size(179, 19)
        Me.radDesignatedSeat.TabIndex = 1
        Me.radDesignatedSeat.Text = "Designated Seat at Check In"
        Me.radDesignatedSeat.UseVisualStyleBackColor = True
        Me.radDesignatedSeat.Visible = False
        '
        'radReservedSeat
        '
        Me.radReservedSeat.AutoSize = True
        Me.radReservedSeat.Checked = True
        Me.radReservedSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.radReservedSeat.Location = New System.Drawing.Point(11, 74)
        Me.radReservedSeat.Name = "radReservedSeat"
        Me.radReservedSeat.Size = New System.Drawing.Size(111, 19)
        Me.radReservedSeat.TabIndex = 0
        Me.radReservedSeat.TabStop = True
        Me.radReservedSeat.Text = "Reserved Seats"
        Me.radReservedSeat.UseVisualStyleBackColor = True
        Me.radReservedSeat.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(196, 143)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 7
        '
        'lblReservedSeats
        '
        Me.lblReservedSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReservedSeats.Location = New System.Drawing.Point(196, 68)
        Me.lblReservedSeats.Name = "lblReservedSeats"
        Me.lblReservedSeats.Size = New System.Drawing.Size(109, 23)
        Me.lblReservedSeats.TabIndex = 6
        Me.lblReservedSeats.Visible = False
        '
        'lblDesignatedSeats
        '
        Me.lblDesignatedSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDesignatedSeats.Location = New System.Drawing.Point(196, 105)
        Me.lblDesignatedSeats.Name = "lblDesignatedSeats"
        Me.lblDesignatedSeats.Size = New System.Drawing.Size(109, 23)
        Me.lblDesignatedSeats.TabIndex = 8
        Me.lblDesignatedSeats.Visible = False
        '
        'frmBookFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 201)
        Me.Controls.Add(Me.lblDesignatedSeats)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblReservedSeats)
        Me.Controls.Add(Me.radDesignatedSeat)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.radReservedSeat)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cboFlights)
        Me.Controls.Add(Me.lblFlights)
        Me.Name = "frmBookFlights"
        Me.Text = "Book Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFlights As Label
    Friend WithEvents cboFlights As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents radDesignatedSeat As RadioButton
    Friend WithEvents radReservedSeat As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblReservedSeats As Label
    Friend WithEvents lblDesignatedSeats As Label
End Class
