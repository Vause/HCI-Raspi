Public Class Home
    'This form directs to the different forms in the application
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Create.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Search.Show()
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Start.Show()
        Me.Close()
    End Sub

    Private Sub btnLog_Click_1(sender As Object, e As EventArgs) Handles btnLog.Click
        Log.Show()
        Me.Close()
    End Sub
End Class
