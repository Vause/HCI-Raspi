Imports System.Data.SQLite
Public Class Profile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox2.Image.Dispose()
        PictureBox2.Image = Nothing
        Me.Close()
        Search.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SQLite.SQLiteConnection
        Dim cmd As New SQLite.SQLiteCommand
        Try
            con.ConnectionString = "Datasource=C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
            cmd.Connection = con

            cmd.CommandText = "UPDATE Employees SET FName = @first, LName = @last, SecurityLevel = @sl WHERE ID = @eID"

            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New SQLiteParameter("@first", TextBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@last", TextBox2.Text))
            cmd.Parameters.Add(New SQLiteParameter("@sl", ComboBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@eID", Label4.Text))
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            PictureBox2.Image.Save("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame_" & TextBox1.Text & "_" & TextBox2.Text & "_" & ComboBox1.Text & ".png")
        Catch ex As Exception
            MessageBox.Show("Error while updating table. " & ex.Message, "Update Records")
        Finally
        End Try

        Me.Close()
        Search.Show()
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()



        TextBox1.Text = Search.First.ToString()
        TextBox2.Text = Search.Last.ToString()
        ComboBox1.Text = Search.SL.ToString()
        Label4.Text = Search.EmpID.ToString()

        Try
            PictureBox2.Image = Image.FromFile("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame_" & TextBox1.Text & "_" & TextBox2.Text & "_" & ComboBox1.Text & ".png")
        Catch
            MessageBox.Show("Profile Not Found!")
            Me.Close()
            Search.Show()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox2.Image.Dispose()
        PictureBox2.Image = Nothing
        System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\try.py")
        Threading.Thread.Sleep(5000)
        PictureBox2.Image = Image.FromFile("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame_" & TextBox1.Text & "_" & TextBox2.Text & "_" & ComboBox1.Text & ".png")
    End Sub



    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete this profile?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'nothing happens
        ElseIf result = DialogResult.Yes Then
            'code to delete the profile
        End If
    End Sub
End Class