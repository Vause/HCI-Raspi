Imports System.Data.SQLite
Public Class FaceCapture
    Dim con As New SQLite.SQLiteConnection
    Dim cmd As New SQLite.SQLiteCommand
    Dim p As New Process
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Create.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        Finish.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRetake.Click
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        'System.Diagnostics.Process.Start(Application.StartupPath & "\try.py").WaitForExit()
        Dim r As New Process
        r.StartInfo.FileName = "pythonw.exe"
        r.StartInfo.WorkingDirectory = Application.StartupPath & "\"
        r.StartInfo.Arguments = "try.py"
        r.StartInfo.RedirectStandardOutput = True
        r.StartInfo.CreateNoWindow = True
        r.StartInfo.UseShellExecute = False
        r.Start()
        r.WaitForExit()
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\data\opencv_frame_" & Create.TextBox1.Text.ToLower() & "_" & Create.TextBox2.Text.ToLower() & "_" & Create.ComboBox1.Text & ".png")
    End Sub

    Private Sub FaceCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            con.ConnectionString = "Datasource=" & Application.StartupPath & "\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO Employees(FName, LName, SecurityLevel, ImagePath) VALUES (@firstName, @lastName, @SL, @pic)"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New SQLiteParameter("@firstName", Create.TextBox1.Text.ToLower()))
            cmd.Parameters.Add(New SQLiteParameter("@lastName", Create.TextBox2.Text.ToLower()))
            cmd.Parameters.Add(New SQLiteParameter("@SL", Create.ComboBox1.Text))
            cmd.Parameters.Add(New SQLiteParameter("@pic", "opencv_frame_" & Create.TextBox1.Text.ToLower() & "_" & Create.TextBox2.Text.ToLower() & "_" & Create.ComboBox1.Text & ".png"))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting in table. " & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try
        Dim p As New Process
        p.StartInfo.FileName = "pythonw.exe"
        p.StartInfo.WorkingDirectory = Application.StartupPath & "\"
        p.StartInfo.Arguments = "facetrainer.py"
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
        p.WaitForExit()

        'System.Diagnostics.Process.Start(Application.StartupPath & "\facetrainer.py").WaitForExit()
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\data\opencv_frame_" & Create.TextBox1.Text.ToLower() & "_" & Create.TextBox2.Text.ToLower() & "_" & Create.ComboBox1.Text & ".png")
        'System.Diagnostics.Process.Start(Application.StartupPath & "\trainer.py").WaitForExit()
        con.ConnectionString = "Datasource=" & Application.StartupPath & "\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
        cmd.Connection = con
        cmd.CommandText = "SELECT ID, FName, LName, SecurityLevel FROM Employees ORDER BY ID DESC"
        cmd.CommandType = CommandType.Text
        con.Open()
        Dim r As SQLiteDataReader
        r = cmd.ExecuteReader()
        If r.Read() Then
            Label5.Text = r.GetValue(0)
            Label6.Text = r.GetValue(1)
            Label7.Text = r.GetValue(2)
            Label8.Text = r.GetValue(3)
            r.Close()
            con.Close()
            Me.Hide()
            Dim t As New Process
            t.StartInfo.FileName = "pythonw.exe"
            t.StartInfo.WorkingDirectory = Application.StartupPath & "\"
            t.StartInfo.Arguments = "trainer.py"
            t.StartInfo.RedirectStandardOutput = True
            t.StartInfo.UseShellExecute = False
            t.StartInfo.CreateNoWindow = True
            t.Start()
        End If
    End Sub
End Class