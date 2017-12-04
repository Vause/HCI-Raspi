Public Class Finish
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Close()
        Create.Close()
    End Sub

    Private Sub Finish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class