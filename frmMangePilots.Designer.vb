<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagePilots
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
        Me.btnAddPilots = New System.Windows.Forms.Button()
        Me.btnDeletePilots = New System.Windows.Forms.Button()
        Me.btnAddPilotToFutureFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPilots
        '
        Me.btnAddPilots.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddPilots.Location = New System.Drawing.Point(12, 25)
        Me.btnAddPilots.Name = "btnAddPilots"
        Me.btnAddPilots.Size = New System.Drawing.Size(206, 47)
        Me.btnAddPilots.TabIndex = 0
        Me.btnAddPilots.Text = "Add Pilots"
        Me.btnAddPilots.UseVisualStyleBackColor = True
        '
        'btnDeletePilots
        '
        Me.btnDeletePilots.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDeletePilots.Location = New System.Drawing.Point(12, 83)
        Me.btnDeletePilots.Name = "btnDeletePilots"
        Me.btnDeletePilots.Size = New System.Drawing.Size(206, 47)
        Me.btnDeletePilots.TabIndex = 1
        Me.btnDeletePilots.Text = "Delete Pilots"
        Me.btnDeletePilots.UseVisualStyleBackColor = True
        '
        'btnAddPilotToFutureFlights
        '
        Me.btnAddPilotToFutureFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddPilotToFutureFlights.Location = New System.Drawing.Point(12, 147)
        Me.btnAddPilotToFutureFlights.Name = "btnAddPilotToFutureFlights"
        Me.btnAddPilotToFutureFlights.Size = New System.Drawing.Size(206, 47)
        Me.btnAddPilotToFutureFlights.TabIndex = 2
        Me.btnAddPilotToFutureFlights.Text = "Add Pilot To Future Flights"
        Me.btnAddPilotToFutureFlights.UseVisualStyleBackColor = True
        '
        'frmManagePilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 218)
        Me.Controls.Add(Me.btnAddPilotToFutureFlights)
        Me.Controls.Add(Me.btnDeletePilots)
        Me.Controls.Add(Me.btnAddPilots)
        Me.Name = "frmManagePilots"
        Me.Text = "Manage Pilots"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPilots As Button
    Friend WithEvents btnDeletePilots As Button
    Friend WithEvents btnAddPilotToFutureFlights As Button
End Class
