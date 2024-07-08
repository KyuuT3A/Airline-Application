<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotsPastFlight
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
        Me.lblPastMiles = New System.Windows.Forms.Label()
        Me.lblPastMiles1 = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblPastMiles
        '
        Me.lblPastMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPastMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPastMiles.Location = New System.Drawing.Point(208, 21)
        Me.lblPastMiles.Name = "lblPastMiles"
        Me.lblPastMiles.Size = New System.Drawing.Size(100, 23)
        Me.lblPastMiles.TabIndex = 5
        '
        'lblPastMiles1
        '
        Me.lblPastMiles1.AutoSize = True
        Me.lblPastMiles1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPastMiles1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPastMiles1.Location = New System.Drawing.Point(63, 21)
        Me.lblPastMiles1.Name = "lblPastMiles1"
        Me.lblPastMiles1.Size = New System.Drawing.Size(114, 19)
        Me.lblPastMiles1.TabIndex = 4
        Me.lblPastMiles1.Text = "Past Miles Flown"
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(24, 66)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(316, 164)
        Me.lstResults.TabIndex = 3
        '
        'frmPilotsPastFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 262)
        Me.Controls.Add(Me.lblPastMiles)
        Me.Controls.Add(Me.lblPastMiles1)
        Me.Controls.Add(Me.lstResults)
        Me.Name = "frmPilotsPastFlight"
        Me.Text = "frmPilotsPastFlight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPastMiles As Label
    Friend WithEvents lblPastMiles1 As Label
    Friend WithEvents lstResults As ListBox
End Class
