Imports System.Data.SQLite
Public Class Log
    Dim conn As SQLiteConnection
    Dim cmd As SQLiteCommand
    Dim da As SQLiteDataAdapter
    Dim ds As DataSet
    Dim itemcoll(100) As String


    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.ListView1.View = View.Details

        'Create DB connection
        'Select information from Logs
        'Show data from Logs table in listview
        conn = New SQLiteConnection("Datasource=" & Application.StartupPath & "\HCIRaspi.db;stepapi=0;syncpragma=NORMAL;notxn=0;timeout=100000;shortnames=0;longnames=0;nocreat=0;nowchar=0;fksupport=0;oemcp=0;bigint=0;jdconv=0")
        Dim strQ As String = String.Empty
        strQ = "SELECT EmployeeID, EmployeeLName, TimeLog, Success FROM Logs"
        cmd = New SQLiteCommand(strQ, conn)
        da = New SQLiteDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Logs")
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.ListView1.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())

        Next
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                Me.ListView1.AutoResizeColumn(j, ColumnHeaderAutoResizeStyle.HeaderSize)
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView1.Items.Add(lvi)
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub
End Class