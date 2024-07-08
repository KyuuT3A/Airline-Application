<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeletePilots
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPilotDelete = New System.Windows.Forms.Label()
        Me.cboPilot = New System.Windows.Forms.ComboBox()
        Me.btnDeletePilot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 59)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 44)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPilotDelete
        '
        Me.lblPilotDelete.AutoSize = True
        Me.lblPilotDelete.Location = New System.Drawing.Point(19, 26)
        Me.lblPilotDelete.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPilotDelete.Name = "lblPilotDelete"
        Me.lblPilotDelete.Size = New System.Drawing.Size(76, 13)
        Me.lblPilotDelete.TabIndex = 6
        Me.lblPilotDelete.Text = "Pilot to Delete:"
        '
        'cboPilot
        '
        Me.cboPilot.FormattingEnabled = True
        Me.cboPilot.Location = New System.Drawing.Point(139, 26)
        Me.cboPilot.Margin = New System.Windows.Forms.Padding(1)
        Me.cboPilot.Name = "cboPilot"
        Me.cboPilot.Size = New System.Drawing.Size(153, 21)
        Me.cboPilot.TabIndex = 5
        '
        'btnDeletePilot
        '
        Me.btnDeletePilot.Location = New System.Drawing.Point(22, 59)
        Me.btnDeletePilot.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeletePilot.Name = "btnDeletePilot"
        Me.btnDeletePilot.Size = New System.Drawing.Size(119, 44)
        Me.btnDeletePilot.TabIndex = 4
        Me.btnDeletePilot.Text = "Delete Pilot"
        Me.btnDeletePilot.UseVisualStyleBackColor = True
        '
        'frmDeletePilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 133)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPilotDelete)
        Me.Controls.Add(Me.cboPilot)
        Me.Controls.Add(Me.btnDeletePilot)
        Me.Name = "frmDeletePilots"
        Me.Text = "Delete Pilots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblPilotDelete As Label
    Friend WithEvents cboPilot As ComboBox
    Friend WithEvents btnDeletePilot As Button
End Class
