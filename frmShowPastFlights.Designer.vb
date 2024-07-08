<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPastFlights
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
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.lblPastMiles = New System.Windows.Forms.Label()
        Me.lblPastFlights = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(33, 87)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(316, 164)
        Me.lstResults.TabIndex = 0
        '
        'lblPastMiles
        '
        Me.lblPastMiles.AutoSize = True
        Me.lblPastMiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPastMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPastMiles.Location = New System.Drawing.Point(72, 42)
        Me.lblPastMiles.Name = "lblPastMiles"
        Me.lblPastMiles.Size = New System.Drawing.Size(118, 19)
        Me.lblPastMiles.TabIndex = 1
        Me.lblPastMiles.Text = "Total Miles Flown"
        '
        'lblPastFlights
        '
        Me.lblPastFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPastFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPastFlights.Location = New System.Drawing.Point(217, 42)
        Me.lblPastFlights.Name = "lblPastFlights"
        Me.lblPastFlights.Size = New System.Drawing.Size(100, 23)
        Me.lblPastFlights.TabIndex = 2
        '
        'frmShowPastFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 286)
        Me.Controls.Add(Me.lblPastFlights)
        Me.Controls.Add(Me.lblPastMiles)
        Me.Controls.Add(Me.lstResults)
        Me.Name = "frmShowPastFlights"
        Me.Text = "Show Past Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstResults As ListBox
    Friend WithEvents lblPastMiles As Label
    Friend WithEvents lblPastFlights As Label
End Class
