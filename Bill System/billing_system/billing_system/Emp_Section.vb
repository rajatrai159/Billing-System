Imports System.Data.OleDb
Public Class Emp_Section
    Dim provider As String

    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim command As New OleDbDataAdapter
    Dim dt As New DataTable

    Public Sub lode_data()
        Try
            connString = "SELECT * FROM empDetail"
            myConnection.Open()
            Dim search As New OleDbDataAdapter(connString, myConnection)
            Dim ds As DataSet = New DataSet
            search.Fill(ds, "empDetail")
            DataGridView1.DataSource = ds.Tables("empDetail")
            myConnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try

    End Sub

    Private Sub FontSizeChamge()
        Dim stric_style As New DataGridViewCellStyle
        stric_style.Font = New Font("Times New Roman", 12, FontStyle.Regular)
        For Each row As DataGridViewRow In DataGridView1.Rows
            For i = 0 To DataGridView1.Columns.Count - 1
                row.Cells(i).Style = stric_style

            Next

        Next
    End Sub
    Private Sub Emp_Section_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Visible = True
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bill System\DB\AllDatabase.accdb"
        myConnection.Open()
        command = New OleDbDataAdapter("Select * From empDetail", myConnection)
        command.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        myConnection.Close()
        FontSizeChamge()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Bill System\DB\AllDatabase.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into empDetail([Name],[Email_ID],[Number],[Address]) Values (?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Name", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Email_ID", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Number", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(TextBox4.Text, String)))


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

            MsgBox("Save")
            lode_data()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Bill System\DB\AllDatabase.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Update [empDetail] set [Email_ID]= '" & TextBox2.Text & "',[Number]= '" & TextBox3.Text & "',[Address]='" & TextBox4.Text & "' Where [Name]='" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            MsgBox("Update")
            lode_data()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Bill System\DB\AllDatabase.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "DELETE FROM [empDetail] WHERE [Name] =  '" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()

            MsgBox("Delete")
            lode_data()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try
    End Sub
End Class