Public Class Start
    Private Sub btnManager_Click(sender As Object, e As EventArgs) Handles btnManager.Click
        Home.Show()
        Me.Hide()
    End Sub

    'Run Face-Recognition python file. Check python files for more detail
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Dim FR As New Process
        FR.StartInfo.FileName = "pythonw.exe"
        FR.StartInfo.WorkingDirectory = Application.StartupPath & "\"
        FR.StartInfo.Arguments = "Face-Recognition.py"
        FR.StartInfo.RedirectStandardOutput = True
        FR.StartInfo.CreateNoWindow = True
        FR.StartInfo.UseShellExecute = False
        FR.Start()
        FR.WaitForExit()
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class