Imports System.Data.SQLite
Public Class Search
    Public EmpID As Integer
    Public First As String
    Public Last As String
    Public SL As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SQLite.SQLiteConnection
        Dim cmd As New SQLite.SQLiteCommand
        Try
            con.ConnectionString = "Datasource=" & Application.StartupPath & "\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
            cmd.Connection = con
            cmd.CommandText = "SELECT ID, FName, LName, SecurityLevel FROM Employees WHERE (FName = @first AND LName = @last AND SecurityLevel = @sl)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New SQLiteParameter("@first", TextBox1.Text.ToLower()))
            cmd.Parameters.Add(New SQLiteParameter("@last", TextBox2.Text.ToLower()))
            cmd.Parameters.Add(New SQLiteParameter("@sl", TextBox3.Text))
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        MessageBox.Show(Application.StartupPath & "\data\")
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button2.Enabled = False
        Form1.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "") Then
            Button2.Enabled = False
        Else

            If Not (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text, "^[A-Za-z]+$") Or TextBox1.Text = "") Then
                Label3.Visible = True
                Button2.Enabled = False
            Else
                Label3.Visible = False
                Button2.Enabled = True

            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If (TextBox2.Text = "" Or TextBox1.Text = "" Or TextBox3.Text = "") Then
            Button2.Enabled = False
        Else
            If Not (System.Text.RegularExpressions.Regex.IsMatch(TextBox2.Text, "^[A-Za-z]+$")) Then
                Label5.Visible = True
                Button2.Enabled = False
            Else
                Label5.Visible = False
                Button2.Enabled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If (TextBox3.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "") Then
            Button2.Enabled = False
        Else

            If Not (TextBox3.Text = "1" Or TextBox3.Text = "2" Or TextBox3.Text = "3") Then
                Label6.Visible = True
                Button2.Enabled = False
            Else
                Label6.Visible = False
                Button2.Enabled = True
            End If
        End If
    End Sub
End Class