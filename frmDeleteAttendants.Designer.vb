<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteAttendants
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
        Me.lblAttendantDelete = New System.Windows.Forms.Label()
        Me.cboAttendant = New System.Windows.Forms.ComboBox()
        Me.btnDeleteAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(179, 58)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 44)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAttendantDelete
        '
        Me.lblAttendantDelete.AutoSize = True
        Me.lblAttendantDelete.Location = New System.Drawing.Point(25, 25)
        Me.lblAttendantDelete.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAttendantDelete.Name = "lblAttendantDelete"
        Me.lblAttendantDelete.Size = New System.Drawing.Size(102, 13)
        Me.lblAttendantDelete.TabIndex = 10
        Me.lblAttendantDelete.Text = "Attendant to Delete:"
        '
        'cboAttendant
        '
        Me.cboAttendant.FormattingEnabled = True
        Me.cboAttendant.Location = New System.Drawing.Point(145, 25)
        Me.cboAttendant.Margin = New System.Windows.Forms.Padding(1)
        Me.cboAttendant.Name = "cboAttendant"
        Me.cboAttendant.Size = New System.Drawing.Size(153, 21)
        Me.cboAttendant.TabIndex = 9
        '
        'btnDeleteAttendant
        '
        Me.btnDeleteAttendant.Location = New System.Drawing.Point(28, 58)
        Me.btnDeleteAttendant.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteAttendant.Name = "btnDeleteAttendant"
        Me.btnDeleteAttendant.Size = New System.Drawing.Size(119, 44)
        Me.btnDeleteAttendant.TabIndex = 8
        Me.btnDeleteAttendant.Text = "Delete Attendant"
        Me.btnDeleteAttendant.UseVisualStyleBackColor = True
        '
        'frmDeleteAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 134)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAttendantDelete)
        Me.Controls.Add(Me.cboAttendant)
        Me.Controls.Add(Me.btnDeleteAttendant)
        Me.Name = "frmDeleteAttendants"
        Me.Text = "Delete Attendants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblAttendantDelete As Label
    Friend WithEvents cboAttendant As ComboBox
    Friend WithEvents btnDeleteAttendant As Button
End Class
