<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageAttendants
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
        Me.btnAddAttendantsToFutureFlights = New System.Windows.Forms.Button()
        Me.btnDeleteAttendants = New System.Windows.Forms.Button()
        Me.btnAddAttendants = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddAttendantsToFutureFlights
        '
        Me.btnAddAttendantsToFutureFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddAttendantsToFutureFlights.Location = New System.Drawing.Point(12, 134)
        Me.btnAddAttendantsToFutureFlights.Name = "btnAddAttendantsToFutureFlights"
        Me.btnAddAttendantsToFutureFlights.Size = New System.Drawing.Size(206, 47)
        Me.btnAddAttendantsToFutureFlights.TabIndex = 5
        Me.btnAddAttendantsToFutureFlights.Text = "Add Attendants To Future Flights"
        Me.btnAddAttendantsToFutureFlights.UseVisualStyleBackColor = True
        '
        'btnDeleteAttendants
        '
        Me.btnDeleteAttendants.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDeleteAttendants.Location = New System.Drawing.Point(12, 70)
        Me.btnDeleteAttendants.Name = "btnDeleteAttendants"
        Me.btnDeleteAttendants.Size = New System.Drawing.Size(206, 47)
        Me.btnDeleteAttendants.TabIndex = 4
        Me.btnDeleteAttendants.Text = "Delete Attendants"
        Me.btnDeleteAttendants.UseVisualStyleBackColor = True
        '
        'btnAddAttendants
        '
        Me.btnAddAttendants.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddAttendants.Location = New System.Drawing.Point(12, 12)
        Me.btnAddAttendants.Name = "btnAddAttendants"
        Me.btnAddAttendants.Size = New System.Drawing.Size(206, 47)
        Me.btnAddAttendants.TabIndex = 3
        Me.btnAddAttendants.Text = "Add Attendants"
        Me.btnAddAttendants.UseVisualStyleBackColor = True
        '
        'frmManageAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 195)
        Me.Controls.Add(Me.btnAddAttendantsToFutureFlights)
        Me.Controls.Add(Me.btnDeleteAttendants)
        Me.Controls.Add(Me.btnAddAttendants)
        Me.Name = "frmManageAttendants"
        Me.Text = "Manage Attendants"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddAttendantsToFutureFlights As Button
    Friend WithEvents btnDeleteAttendants As Button
    Friend WithEvents btnAddAttendants As Button
End Class
