<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblSecurity = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtSecurity = New System.Windows.Forms.ComboBox()
        Me.btnRetake = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFNameError = New System.Windows.Forms.Label()
        Me.lblLNameError = New System.Windows.Forms.Label()
        Me.lblSecurityError = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HCI_Raspi.My.Resources.Resources.diemster
        Me.PictureBox2.Location = New System.Drawing.Point(20, 28)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 137)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(9, 302)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 41)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(393, 302)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 41)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(358, 67)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(128, 20)
        Me.txtFName.TabIndex = 7
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(358, 122)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(128, 20)
        Me.txtLName.TabIndex = 8
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFName.Location = New System.Drawing.Point(176, 69)
        Me.lblFName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(142, 17)
        Me.lblFName.TabIndex = 10
        Me.lblFName.Text = "Employee First Name"
        '
        'lblSecurity
        '
        Me.lblSecurity.AutoSize = True
        Me.lblSecurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSecurity.Location = New System.Drawing.Point(176, 175)
        Me.lblSecurity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecurity.Name = "lblSecurity"
        Me.lblSecurity.Size = New System.Drawing.Size(163, 17)
        Me.lblSecurity.TabIndex = 11
        Me.lblSecurity.Text = "Employee Security Level"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLName.Location = New System.Drawing.Point(176, 122)
        Me.lblLName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(142, 17)
        Me.lblLName.TabIndex = 12
        Me.lblLName.Text = "Employee Last Name"
        '
        'txtSecurity
        '
        Me.txtSecurity.FormattingEnabled = True
        Me.txtSecurity.Items.AddRange(New Object() {"1", "2", "3"})
        Me.txtSecurity.Location = New System.Drawing.Point(358, 171)
        Me.txtSecurity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.Size = New System.Drawing.Size(128, 21)
        Me.txtSecurity.TabIndex = 13
        '
        'btnRetake
        '
        Me.btnRetake.Location = New System.Drawing.Point(20, 193)
        Me.btnRetake.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetake.Name = "btnRetake"
        Me.btnRetake.Size = New System.Drawing.Size(150, 41)
        Me.btnRetake.TabIndex = 14
        Me.btnRetake.Text = "&Retake Profile Picture"
        Me.btnRetake.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(356, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Label4"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(206, 301)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 41)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "&Delete Profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ID"
        '
        'lblFNameError
        '
        Me.lblFNameError.AutoSize = True
        Me.lblFNameError.ForeColor = System.Drawing.Color.Red
        Me.lblFNameError.Location = New System.Drawing.Point(179, 90)
        Me.lblFNameError.Name = "lblFNameError"
        Me.lblFNameError.Size = New System.Drawing.Size(185, 13)
        Me.lblFNameError.TabIndex = 19
        Me.lblFNameError.Text = "Invalid input. Please enter only letters."
        Me.lblFNameError.Visible = False
        '
        'lblLNameError
        '
        Me.lblLNameError.AutoSize = True
        Me.lblLNameError.ForeColor = System.Drawing.Color.Red
        Me.lblLNameError.Location = New System.Drawing.Point(179, 144)
        Me.lblLNameError.Name = "lblLNameError"
        Me.lblLNameError.Size = New System.Drawing.Size(185, 13)
        Me.lblLNameError.TabIndex = 20
        Me.lblLNameError.Text = "Invalid input. Please enter only letters."
        Me.lblLNameError.Visible = False
        '
        'lblSecurityError
        '
        Me.lblSecurityError.AutoSize = True
        Me.lblSecurityError.ForeColor = System.Drawing.Color.Red
        Me.lblSecurityError.Location = New System.Drawing.Point(175, 194)
        Me.lblSecurityError.Name = "lblSecurityError"
        Me.lblSecurityError.Size = New System.Drawing.Size(273, 13)
        Me.lblSecurityError.TabIndex = 21
        Me.lblSecurityError.Text = "Invalid input. Please choose a number between 1 and 3."
        Me.lblSecurityError.Visible = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 353)
        Me.Controls.Add(Me.lblSecurityError)
        Me.Controls.Add(Me.lblLNameError)
        Me.Controls.Add(Me.lblFNameError)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRetake)
        Me.Controls.Add(Me.txtSecurity)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblSecurity)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Profile"
        Me.Text = "Profile"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents lblSecurity As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents txtSecurity As ComboBox
    Friend WithEvents btnRetake As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFNameError As Label
    Friend WithEvents lblLNameError As Label
    Friend WithEvents lblSecurityError As Label
End Class
