Public Class Instructions
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Close()
        FaceCapture.Show()
    End Sub

    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class