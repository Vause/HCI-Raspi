<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblSecurity = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.cboSecurity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFNameError = New System.Windows.Forms.Label()
        Me.lblLNameError = New System.Windows.Forms.Label()
        Me.lblSecurityError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(6, 57)
        Me.lblFName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(142, 17)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "Employee First Name"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(6, 114)
        Me.lblLName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(142, 17)
        Me.lblLName.TabIndex = 1
        Me.lblLName.Text = "Employee Last Name"
        '
        'lblSecurity
        '
        Me.lblSecurity.AutoSize = True
        Me.lblSecurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecurity.Location = New System.Drawing.Point(6, 174)
        Me.lblSecurity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecurity.Name = "lblSecurity"
        Me.lblSecurity.Size = New System.Drawing.Size(231, 17)
        Me.lblSecurity.TabIndex = 2
        Me.lblSecurity.Text = "Employee Security Clearance Level"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(9, 225)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 41)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(255, 225)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 41)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(236, 57)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(128, 20)
        Me.txtFName.TabIndex = 5
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(236, 112)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(128, 20)
        Me.txtLName.TabIndex = 6
        '
        'cboSecurity
        '
        Me.cboSecurity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecurity.FormattingEnabled = True
        Me.cboSecurity.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboSecurity.Location = New System.Drawing.Point(236, 171)
        Me.cboSecurity.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSecurity.Name = "cboSecurity"
        Me.cboSecurity.Size = New System.Drawing.Size(128, 21)
        Me.cboSecurity.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Enter Employee Information"
        '
        'lblFNameError
        '
        Me.lblFNameError.AutoSize = True
        Me.lblFNameError.ForeColor = System.Drawing.Color.Red
        Me.lblFNameError.Location = New System.Drawing.Point(16, 81)
        Me.lblFNameError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFNameError.Name = "lblFNameError"
        Me.lblFNameError.Size = New System.Drawing.Size(185, 13)
        Me.lblFNameError.TabIndex = 10
        Me.lblFNameError.Text = "Invalid input. Please enter only letters."
        '
        'lblLNameError
        '
        Me.lblLNameError.AutoSize = True
        Me.lblLNameError.ForeColor = System.Drawing.Color.Red
        Me.lblLNameError.Location = New System.Drawing.Point(16, 141)
        Me.lblLNameError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLNameError.Name = "lblLNameError"
        Me.lblLNameError.Size = New System.Drawing.Size(185, 13)
        Me.lblLNameError.TabIndex = 11
        Me.lblLNameError.Text = "Invalid input. Please enter only letters."
        '
        'lblSecurityError
        '
        Me.lblSecurityError.AutoSize = True
        Me.lblSecurityError.ForeColor = System.Drawing.Color.Red
        Me.lblSecurityError.Location = New System.Drawing.Point(16, 201)
        Me.lblSecurityError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecurityError.Name = "lblSecurityError"
        Me.lblSecurityError.Size = New System.Drawing.Size(273, 13)
        Me.lblSecurityError.TabIndex = 12
        Me.lblSecurityError.Text = "Invalid input. Please choose a number between 1 and 3."
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 275)
        Me.Controls.Add(Me.lblSecurityError)
        Me.Controls.Add(Me.lblLNameError)
        Me.Controls.Add(Me.lblFNameError)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSecurity)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSecurity)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Create"
        Me.Text = "Create"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblSecurity As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents cboSecurity As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFNameError As Label
    Friend WithEvents lblLNameError As Label
    Friend WithEvents lblSecurityError As Label
End Class
