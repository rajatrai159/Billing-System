Imports System.Data.OleDb
Public Class sales_info
    Dim provider As String

    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim command As New OleDbDataAdapter
    Dim dt As New DataTable

    Public Sub lode_data()
        Try
            connString = "SELECT * FROM sales"
            myConnection.Open()
            Dim search As New OleDbDataAdapter(connString, myConnection)
            Dim ds As DataSet = New DataSet
            search.Fill(ds, "sales")
            DataGridView1.DataSource = ds.Tables("sales")
            myConnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try

    End Sub

    Private Sub FontSizeChamge()
        Dim stric_style As New DataGridViewCellStyle
        stric_style.Font = New Font("Times New Roman", 14, FontStyle.Regular)
        For Each row As DataGridViewRow In DataGridView1.Rows
            For i = 0 To DataGridView1.Columns.Count - 1
                row.Cells(i).Style = stric_style

            Next

        Next
    End Sub
    Private Sub sales_info_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Visible = True
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bill System\DB\AllDatabase.accdb"
        myConnection.Open()
        command = New OleDbDataAdapter("Select * From sales", myConnection)
        command.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        myConnection.Close()
        FontSizeChamge()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class