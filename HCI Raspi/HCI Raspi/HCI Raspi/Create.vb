Imports System.Data.SQLite
Public Class Create
    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.Hide() 'Only one form is shown at a time
        Me.CenterToScreen()

        'Errors are not visible yet
        lblFNameError.Visible = False
        lblLNameError.Visible = False
        lblSecurityError.Visible = False

        'Next Button is inactive at the start
        btnNext.Enabled = False
        cboSecurity.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Instructions.Show()
        Me.Hide()
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        'If everything is empty, Next button is disabled
        If (txtFName.Text = "" Or txtLName.Text = "" Or cboSecurity.Text = "") Then
            btnNext.Enabled = False
        Else

            'If user enters anything but letters, an error will be thrown
            If Not (System.Text.RegularExpressions.Regex.IsMatch(txtFName.Text, "^[A-Za-z]+$") Or txtFName.Text = "") Then
                lblFNameError.Visible = True
                btnNext.Enabled = False
            Else
                lblFNameError.Visible = False
                btnNext.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        If (txtLName.Text = "" Or txtFName.Text = "" Or cboSecurity.Text = "") Then
            btnNext.Enabled = False
        Else
            'If user enters anything but letters, an error will be thrown
            If Not (System.Text.RegularExpressions.Regex.IsMatch(txtLName.Text, "^[A-Za-z]+$")) Then
                lblLNameError.Visible = True
                btnNext.Enabled = False
            Else
                lblLNameError.Visible = False
                btnNext.Enabled = True
            End If
        End If
    End Sub

    Private Sub cboSecurity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSecurity.SelectedIndexChanged
        If (cboSecurity.Text = "" Or txtFName.Text = "" Or txtLName.Text = "") Then
            btnNext.Enabled = False
        Else
            'If user enters anything but letters, an error will be thrown
            If Not (cboSecurity.Text = "1" Or cboSecurity.Text = "2" Or cboSecurity.Text = "3") Then
                lblSecurityError.Visible = True
                btnNext.Enabled = False
            Else
                lblSecurityError.Visible = False
                btnNext.Enabled = True
            End If
        End If
    End Sub

End Class