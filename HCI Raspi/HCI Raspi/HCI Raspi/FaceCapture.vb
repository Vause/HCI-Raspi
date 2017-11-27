Imports System.Data.SQLite
Public Class FaceCapture
    Private WithEvents p As New Process
    Public strFirst As String
    Public strLast As String
    Public strSL As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Create.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Finish.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        System.IO.File.Delete("C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame.png")
        FaceCapture_Load(sender, e)
        'System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\try.py")
        'Threading.Thread.Sleep(3000)
        'PictureBox1.Image = Image.FromFile("C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\opencv_frame.png")
    End Sub

    Private Sub FaceCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SQLite.SQLiteConnection
        Dim cmd As New SQLite.SQLiteCommand
        Try
            con.ConnectionString = "Datasource=C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Employees(FName, LName, SecurityLevel, Picture) VALUES (@firstName, @lastName, @SL, @pic)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New SQLiteParameter("@firstName", Create.TextBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@lastName", Create.TextBox2.Text))
            cmd.Parameters.Add(New SQLiteParameter("@SL", Create.ComboBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@pic", DBNull.Value))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting in table. " & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try
        System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\try.py")
        System.Threading.Thread.Sleep(4000)
        PictureBox1.Image = Image.FromFile("C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame_" & Create.TextBox1.Text & "_" & Create.TextBox2.Text & "_" & Create.ComboBox1.Text & ".png")
    End Sub
End Class