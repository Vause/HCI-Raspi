Imports System.Data.SQLite
Public Class Create
    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.Hide()
        Me.CenterToScreen()
        lblFNameError.Visible = False
        lblLNameError.Visible = False
        lblSecurityError.Visible = False
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
        If (txtFName.Text = "" Or txtLName.Text = "" Or cboSecurity.Text = "") Then
            btnNext.Enabled = False
        Else

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