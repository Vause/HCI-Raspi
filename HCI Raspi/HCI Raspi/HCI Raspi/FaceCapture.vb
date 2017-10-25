Public Class FaceCapture
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Create.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Finish.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = True
    End Sub
End Class