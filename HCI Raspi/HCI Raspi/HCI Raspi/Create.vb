Imports System.Data.SQLite
Public Class Create
    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        Me.CenterToScreen()
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        btnNext.Enabled = False
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Instructions.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "") Then
            btnNext.Enabled = False
        Else

            If Not (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text, "^[A-Za-z]+$") Or TextBox1.Text = "") Then
                Label5.Visible = True
                btnNext.Enabled = False
            Else
                Label5.Visible = False
                btnNext.Enabled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If (TextBox2.Text = "" Or TextBox1.Text = "" Or ComboBox1.Text = "") Then
            btnNext.Enabled = False
        Else
            If Not (System.Text.RegularExpressions.Regex.IsMatch(TextBox2.Text, "^[A-Za-z]+$")) Then
                Label6.Visible = True
                btnNext.Enabled = False
            Else
                Label6.Visible = False
                btnNext.Enabled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "") Then
            btnNext.Enabled = False
        Else
            If Not (ComboBox1.Text = "1" Or ComboBox1.Text = "2" Or ComboBox1.Text = "3") Then
                Label7.Visible = True
                btnNext.Enabled = False
            Else
                Label7.Visible = False
                btnNext.Enabled = True
            End If
        End If
    End Sub
End Class