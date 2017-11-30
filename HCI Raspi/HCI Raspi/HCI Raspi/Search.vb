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
            con.ConnectionString = "Datasource=C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
            cmd.Connection = con
            cmd.CommandText = "SELECT ID, FName, LName, SecurityLevel FROM Employees WHERE (FName = @first AND LName = @last AND SecurityLevel = @sl)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New SQLiteParameter("@first", TextBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@last", TextBox2.Text))
            cmd.Parameters.Add(New SQLiteParameter("@sl", TextBox3.Text))
            con.Open()
            Dim r As SQLiteDataReader
            r = cmd.ExecuteReader()
            'Dim r As SQLiteDataReader
            'r = cmd.ExecuteReader()
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
        Form1.Hide()
    End Sub
End Class