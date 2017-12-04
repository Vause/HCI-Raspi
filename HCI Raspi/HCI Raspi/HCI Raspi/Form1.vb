Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Create.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Search.Show()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Start.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnLog.Click
        Log.Show()
        Me.Close()
    End Sub
End Class
