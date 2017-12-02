Public Class Log
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListView1.Items.Add("TestValue")

        ' https://social.msdn.microsoft.com/Forums/en-US/8919e4d7-f814-42e8-83a7-8b830b5a0355/how-to-show-data-from-sql-database-to-listview-vbnet?forum=vbgeneral
    End Sub

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class