Public Class FaceCapture
    Private WithEvents p As New Process
    Private num = 0
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
        System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\try.py")
        System.Threading.Thread.Sleep(4000)
        PictureBox1.Image = Image.FromFile("C:\Users\Ruben\Desktop\HCI-master\HCI-Raspi-master\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame.png")

    End Sub
End Class