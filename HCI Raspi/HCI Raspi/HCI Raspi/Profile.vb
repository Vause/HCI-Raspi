Imports System.Data.SQLite
Imports System.IO
Public Class Profile
    Dim con As New SQLite.SQLiteConnection
    Dim cmd As New SQLite.SQLiteCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox2.Image.Dispose()
        PictureBox2.Image = Nothing
        Me.Close()
        Search.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.ConnectionString = "Datasource=" & Application.StartupPath & "\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
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
            PictureBox2.Image.Save(Application.StartupPath & "\data\opencv_frame_" & TextBox1.Text.ToLower() & "_" & TextBox2.Text.ToLower() & "_" & ComboBox1.Text & ".png")
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
            PictureBox2.Image = Image.FromFile(Application.StartupPath & "\data\opencv_frame_" & TextBox1.Text.ToLower() & "_" & TextBox2.Text.ToLower() & "_" & ComboBox1.Text & ".png")
        Catch
            MessageBox.Show("Profile Not Found!")
            Me.Close()
            Search.Show()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox2.Image.Dispose()
        PictureBox2.Image = Nothing
        Dim r As New Process
        r.StartInfo.FileName = "pythonw.exe"
        r.StartInfo.WorkingDirectory = Application.StartupPath & "\"
        r.StartInfo.Arguments = "try.py"
        r.StartInfo.RedirectStandardOutput = True
        r.StartInfo.CreateNoWindow = True
        r.StartInfo.UseShellExecute = False
        r.Start()
        r.WaitForExit()
        PictureBox2.Image = Image.FromFile(Application.StartupPath & "\data\opencv_frame_" & TextBox1.Text.ToLower() & "_" & TextBox2.Text.ToLower() & "_" & ComboBox1.Text & ".png")
    End Sub



    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete this profile?", "Delete?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'nothing happens
        ElseIf result = DialogResult.Yes Then
            'code to delete the profile
            PictureBox2.Image.Dispose()
            PictureBox2.Image = Nothing
            Try
                con.ConnectionString = "Datasource=" & Application.StartupPath & "\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0"
                cmd.Connection = con

                cmd.CommandText = "DELETE FROM Employees WHERE ID = @eID"

                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add(New SQLiteParameter("@eID", Label4.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Error while deleting record. " & ex.Message, "Delete Record")
            Finally
            End Try
            Dim datasetDirectory As String = Application.StartupPath & "\dataset\"
            Dim profileDirectory As String = Application.StartupPath & "\data\"
            For Each datasetPhoto In Directory.GetFiles(datasetDirectory, "User" & Label4.Text & "*.jpg", SearchOption.TopDirectoryOnly)
                File.Delete(datasetPhoto)
            Next
            For Each profilePhoto In Directory.GetFiles(profileDirectory, "opencv_frame_" & TextBox1.Text.ToLower() & "_" & TextBox2.Text.ToLower() & "_" & ComboBox1.Text & ".png", SearchOption.TopDirectoryOnly)
                File.Delete(profilePhoto)
            Next
            Me.Close()
            MsgBox("Profile Deleted.", MsgBoxStyle.OkOnly)
            Search.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim Instructions As Integer = MessageBox.Show("Tips: \n Turn your head slowly in each direction while the camera captures your movement \n Keep your head the same distance from the camera \n The camera will capture for about 3 seconds.", "caption", MessageBoxButtons.OKCancel)
        'If Instructions = DialogResult.OK Then
        '    Dim datasetDirectory As String = Application.StartupPath & "\dataset\"
        '    For Each datasetPhoto In Directory.GetFiles(datasetDirectory, "User" & Label4.Text & "*.png", SearchOption.TopDirectoryOnly)
        '        File.Delete(datasetPhoto)
        '    Next
        '    System.Diagnostics.Process.Start(Application.StartupPath & "\facetrainer.py")
        '    System.Threading.Thread.Sleep(10000)
        '    System.Diagnostics.Process.Start(Application.StartupPath & "\trainer.py")
        'Else
        '    'do nothing
        'End If

    End Sub
End Class