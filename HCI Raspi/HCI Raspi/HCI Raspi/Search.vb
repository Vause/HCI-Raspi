Imports System.Data.SQLite
Public Class Search
    Public EmpID As Integer
    Public First As String
    Public Last As String
    Public SL As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim con As New SQLite.SQLiteConnection
        Dim cmd As New SQLite.SQLiteCommand
        Try
            con.ConnectionString = "Datasource=" & Application.StartupPath & "\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
            cmd.Connection = con
            cmd.CommandText = "SELECT ID, FName, LName, SecurityLevel FROM Employees WHERE (FName = @first AND LName = @last AND SecurityLevel = @sl)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New SQLiteParameter("@first", txtFName.Text.ToLower()))
            cmd.Parameters.Add(New SQLiteParameter("@last", txtLName.Text.ToLower()))
            cmd.Parameters.Add(New SQLiteParameter("@sl", txtSecurity.Text))
            con.Open()
            Dim r As SQLiteDataReader
            r = cmd.ExecuteReader()
            If r.Read() Then
                EmpID = r.GetValue(0)
                First = r.GetValue(1)
                Last = r.GetValue(2)
                SL = r.GetValue(3)
                r.Close()
                con.Close()
                Profile.Show()
                Me.Hide()
            Else
                MessageBox.Show("Record Not Found! Please Try Again.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblFNameError.Visible = False
        lblLNameError.Visible = False
        lblSecurityError.Visible = False
        btnSearch.Enabled = False
        Home.Hide()
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        If (txtFName.Text = "" Or txtLName.Text = "" Or txtSecurity.Text = "") Then
            btnSearch.Enabled = False
        Else

            If Not (System.Text.RegularExpressions.Regex.IsMatch(txtFName.Text, "^[A-Za-z]+$") Or txtFName.Text = "") Then
                lblFNameError.Visible = True
                btnSearch.Enabled = False
            Else
                lblFNameError.Visible = False
                btnSearch.Enabled = True

            End If
        End If
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        If (txtLName.Text = "" Or txtFName.Text = "" Or txtSecurity.Text = "") Then
            btnSearch.Enabled = False
        Else
            If Not (System.Text.RegularExpressions.Regex.IsMatch(txtLName.Text, "^[A-Za-z]+$")) Then
                lblLNameError.Visible = True
                btnSearch.Enabled = False
            Else
                lblLNameError.Visible = False
                btnSearch.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtSecurity_TextChanged(sender As Object, e As EventArgs) Handles txtSecurity.TextChanged
        If (txtSecurity.Text = "" Or txtFName.Text = "" Or txtLName.Text = "") Then
            btnSearch.Enabled = False
        Else

            If Not (txtSecurity.Text = "1" Or txtSecurity.Text = "2" Or txtSecurity.Text = "3") Then
                lblSecurityError.Visible = True
                btnSearch.Enabled = False
            Else
                lblSecurityError.Visible = False
                btnSearch.Enabled = True
            End If
        End If
    End Sub
End Class