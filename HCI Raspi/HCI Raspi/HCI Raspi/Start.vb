Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\Face-Recognition.py")
    End Sub
End Class