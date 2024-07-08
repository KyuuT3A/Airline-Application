<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowFutureFlights
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
        Me.lblFutureFlights = New System.Windows.Forms.Label()
        Me.lblFuture = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblFutureFlights
        '
        Me.lblFutureFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFutureFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFutureFlights.Location = New System.Drawing.Point(207, 28)
        Me.lblFutureFlights.Name = "lblFutureFlights"
        Me.lblFutureFlights.Size = New System.Drawing.Size(100, 23)
        Me.lblFutureFlights.TabIndex = 5
        '
        'lblFuture
        '
        Me.lblFuture.AutoSize = True
        Me.lblFuture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFuture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFuture.Location = New System.Drawing.Point(62, 28)
        Me.lblFuture.Name = "lblFuture"
        Me.lblFuture.Size = New System.Drawing.Size(118, 19)
        Me.lblFuture.TabIndex = 4
        Me.lblFuture.Text = "Total Miles Flown"
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(23, 73)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(316, 164)
        Me.lstResults.TabIndex = 3
        '
        'frmShowFutureFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 283)
        Me.Controls.Add(Me.lblFutureFlights)
        Me.Controls.Add(Me.lblFuture)
        Me.Controls.Add(Me.lstResults)
        Me.Name = "frmShowFutureFlights"
        Me.Text = "Show Future Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFutureFlights As Label
    Friend WithEvents lblFuture As Label
    Friend WithEvents lstResults As ListBox
End Class
