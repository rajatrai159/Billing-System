Imports System.Data.OleDb
Public Class Item_Info
    Dim provider As String

    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim command As New OleDbDataAdapter
    Dim dt As New DataTable

    Public Sub lode_data()
        Try
            connString = "SELECT * FROM items"
            myConnection.Open()
            Dim search As New OleDbDataAdapter(connString, myConnection)
            Dim ds As DataSet = New DataSet
            search.Fill(ds, "items")
            DataGridView1.DataSource = ds.Tables("items")
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
    Private Sub Item_Info_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Visible = True
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bill System\DB\AllDatabase.accdb"
        myConnection.Open()
        command = New OleDbDataAdapter("Select * From items", myConnection)
        command.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        myConnection.Close()
        FontSizeChamge()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Bill System\DB\AllDatabase.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into items([item_name],[price],[V\N]) Values (?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("item_name", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("price", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("V\N", CType(TextBox3.Text, String)))
        

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
          

            MsgBox("Save")
            lode_data()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Bill System\DB\AllDatabase.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Update [items] set [price]= '" & TextBox2.Text & "',[V\N]= '" & TextBox3.Text & "' Where [item_name]='" & TextBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
           
            MsgBox("Update")
            lode_data()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Bill System\DB\AllDatabase.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "DELETE FROM [items] WHERE [item_name] =  '" & TextBox1.Text & "'"
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