Imports System.Data.OleDb
Public Class Bill
    Dim conn As OleDbConnection = New OleDbConnection
    Dim comm As New OleDbCommand
    Dim command As OleDbDataAdapter
    Dim dt As New DataTable
    Dim provider As String
    Dim dataFill As String
    Dim connstring As String
    Public Property cost As String

  
    Public Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer
        DataGridView1.Visible = True
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFill = "C:\Bill System\DB\AllDatabase.accdb"
        connstring = provider & dataFill
        conn.ConnectionString = connstring
        conn.Open()
        command = New OleDbDataAdapter("Select * From bill", conn)
        command.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
        command = New OleDbDataAdapter("Select price From bill", conn)
        For i = 0 To DataGridView1.RowCount
            If DataGridView1.Rows.Count = 0 Then
            ElseIf DataGridView1.CurrentRow.Index = DataGridView1.Rows.Count - 1 Then
                DataGridView1.Rows(0).Selected = True
            Else
                lblcost.Text = Val(lblcost.Text) + Val(DataGridView1.CurrentRow.Cells(3).Value.ToString)

                Dim nextrow As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index + 1)
                DataGridView1.CurrentCell = nextrow.Cells(3)
            End If
        Next
        lblgst.Text = Val(lblcost.Text) * 0.28
        lbltotal.Text = Val(lblcost.Text) + Val(lblgst.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        billing.Show()
    End Sub


    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
End Class