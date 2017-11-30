Imports System.Data.SQLite
Public Class FaceCapture
    Private WithEvents p As New Process
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Create.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        Finish.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\try.py")
        Threading.Thread.Sleep(5000)
        PictureBox1.Image = Image.FromFile("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame_" & Create.TextBox1.Text & "_" & Create.TextBox2.Text & "_" & Create.ComboBox1.Text & ".png")
    End Sub

    Private Sub FaceCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SQLite.SQLiteConnection
        Dim cmd As New SQLite.SQLiteCommand
        Try
            con.ConnectionString = "Datasource=C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Employees(FName, LName, SecurityLevel, ImagePath) VALUES (@firstName, @lastName, @SL, @pic)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New SQLiteParameter("@firstName", Create.TextBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@lastName", Create.TextBox2.Text))
            cmd.Parameters.Add(New SQLiteParameter("@SL", Create.ComboBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@pic", "opencv_frame_" & Create.TextBox1.Text & "_" & Create.TextBox2.Text & "_" & Create.ComboBox1.Text & ".png"))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting in table. " & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try
        System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\facetrainer.py")
        System.Threading.Thread.Sleep(10000)
        PictureBox1.Image = Image.FromFile("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame_" & Create.TextBox1.Text & "_" & Create.TextBox2.Text & "_" & Create.ComboBox1.Text & ".png")
        System.Threading.Thread.Sleep(1000)
        System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\trainer.py")
    End Sub
End Class