Public Class Finish
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       Form1.Show()
        Me.Close()
        Create.Close()
    End Sub

    Private Sub Finish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class