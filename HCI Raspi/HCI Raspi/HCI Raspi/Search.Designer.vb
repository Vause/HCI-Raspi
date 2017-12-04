<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtSecurity = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFNameError = New System.Windows.Forms.Label()
        Me.lblLNameError = New System.Windows.Forms.Label()
        Me.lblSecurityError = New System.Windows.Forms.Label()
        Me.ProfileTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Last Name"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(333, 102)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 22)
        Me.txtFName.TabIndex = 3
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(333, 182)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 22)
        Me.txtLName.TabIndex = 4
        '
        'txtSecurity
        '
        Me.txtSecurity.Location = New System.Drawing.Point(333, 262)
        Me.txtSecurity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.Size = New System.Drawing.Size(100, 22)
        Me.txtSecurity.TabIndex = 5
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 349)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(149, 50)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(285, 349)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(149, 50)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(27, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Employee Security Level"
        '
        'lblFNameError
        '
        Me.lblFNameError.AutoSize = True
        Me.lblFNameError.ForeColor = System.Drawing.Color.Red
        Me.lblFNameError.Location = New System.Drawing.Point(27, 142)
        Me.lblFNameError.Name = "lblFNameError"
        Me.lblFNameError.Size = New System.Drawing.Size(248, 17)
        Me.lblFNameError.TabIndex = 9
        Me.lblFNameError.Text = "Invalid input. Please enter only letters."
        '
        'lblLNameError
        '
        Me.lblLNameError.AutoSize = True
        Me.lblLNameError.ForeColor = System.Drawing.Color.Red
        Me.lblLNameError.Location = New System.Drawing.Point(27, 222)
        Me.lblLNameError.Name = "lblLNameError"
        Me.lblLNameError.Size = New System.Drawing.Size(248, 17)
        Me.lblLNameError.TabIndex = 10
        Me.lblLNameError.Text = "Invalid input. Please enter only letters."
        '
        'lblSecurityError
        '
        Me.lblSecurityError.AutoSize = True
        Me.lblSecurityError.ForeColor = System.Drawing.Color.Red
        Me.lblSecurityError.Location = New System.Drawing.Point(27, 302)
        Me.lblSecurityError.Name = "lblSecurityError"
        Me.lblSecurityError.Size = New System.Drawing.Size(361, 17)
        Me.lblSecurityError.TabIndex = 11
        Me.lblSecurityError.Text = "Invalid input. Please choose a number between 1 and 3."
        '
        'ProfileTitle
        '
        Me.ProfileTitle.AutoSize = True
        Me.ProfileTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileTitle.Location = New System.Drawing.Point(112, 28)
        Me.ProfileTitle.Name = "ProfileTitle"
        Me.ProfileTitle.Size = New System.Drawing.Size(227, 29)
        Me.ProfileTitle.TabIndex = 23
        Me.ProfileTitle.Text = "Search Employees"
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 430)
        Me.Controls.Add(Me.ProfileTitle)
        Me.Controls.Add(Me.lblSecurityError)
        Me.Controls.Add(Me.lblLNameError)
        Me.Controls.Add(Me.lblFNameError)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtSecurity)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Search"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtSecurity As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFNameError As Label
    Friend WithEvents lblLNameError As Label
    Friend WithEvents lblSecurityError As Label
    Friend WithEvents ProfileTitle As Label
End Class
