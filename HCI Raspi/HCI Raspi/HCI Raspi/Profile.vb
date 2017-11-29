Public Class Profile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Search.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Search.TextBox1.Text
        TextBox2.Text = Search.TextBox2.Text
        ComboBox1.Text = Search.TextBox3.Text
        Try
            PictureBox2.Image = Image.FromFile("C:\Users\Ruben\Desktop\CSCI 488\HCI-Raspi\HCI-Raspi\HCI Raspi\HCI Raspi\HCI Raspi\bin\Debug\data\opencv_frame_" & TextBox1.Text & "_" & TextBox2.Text & "_" & ComboBox1.Text & ".png")
        Catch
            MessageBox.Show("Profile Not Found!")
            Me.Hide()
            Search.Show()
        End Try
    End Sub
End Class