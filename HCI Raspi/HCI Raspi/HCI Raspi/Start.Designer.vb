<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.components = New System.ComponentModel.Container()
        Me.btnManager = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnManager
        '
        Me.btnManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnManager.Location = New System.Drawing.Point(206, 176)
        Me.btnManager.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnManager.Name = "btnManager"
        Me.btnManager.Size = New System.Drawing.Size(205, 46)
        Me.btnManager.TabIndex = 0
        Me.btnManager.Text = "Manager Mode"
        Me.ToolTip1.SetToolTip(Me.btnManager, "Create and track employee profiles")
        Me.btnManager.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCapture.Location = New System.Drawing.Point(206, 257)
        Me.btnCapture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(205, 46)
        Me.btnCapture.TabIndex = 1
        Me.btnCapture.Text = "Capture Mode"
        Me.ToolTip1.SetToolTip(Me.btnCapture, "Security camera mode")
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(190, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Startup Mode"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 423)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnManager)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManager As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
