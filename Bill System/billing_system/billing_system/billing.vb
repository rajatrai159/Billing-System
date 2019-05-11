Imports System.Data.OleDb
Public Class billing
    Dim conn As OleDbConnection = New OleDbConnection
    Dim comm As New OleDbCommand
    Dim command As OleDbDataAdapter
    Dim dt As New DataTable
    Dim provider As String
    Dim dataFill As String
    Dim connstring As String

    
   

    Private Sub billing_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DataGridView1.Visible = True
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bill System\DB\AllDatabase.accdb"
        conn.Open()
        command = New OleDbDataAdapter("Select * From Items", conn)
        command.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        Dim str As String
        str = "delete from bill"
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Dim i As Integer = 1
    Dim food(50) As String
    Dim price(10) As Integer
    Dim quantity(10) As Integer
    Public total As Integer = 0

    Private Sub addbill()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFill = "C:\Bill System\DB\AllDatabase.accdb"
        connstring = provider & dataFill
        conn.ConnectionString = connstring
        conn.Open()
        Dim str As String
        str = "Insert into bill([item_name], [quantity], [price] ) Values(?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)

        cmd.Parameters.Add(New OleDbParameter("@item_name", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@quantity", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@price", CType(TextBox6.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()


            
        Catch ex As Exception
            MsgBox(ex.InnerException)
            conn.Close()
        End Try


    End Sub
    Private Sub addsales()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFill = "C:\Bill System\DB\AllDatabase.accdb"
        connstring = provider & dataFill
        conn.ConnectionString = connstring
        conn.Open()
        Dim str As String
        str = "Insert into sales([item_name], [quantity], [price] ) Values(?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)

        cmd.Parameters.Add(New OleDbParameter("@item_name", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@quantity", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("@price", CType(TextBox6.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()

            MsgBox("Successfully Inserted")
            TextBox5.Clear()
            TextBox6.Clear()

        Catch ex As Exception
            MsgBox(ex.InnerException)
            conn.Close()
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox6.Text = ""
        TextBox6.Text = TextBox5.Text * TextBox3.Text
        total = total + TextBox6.Text
        TextBox7.Text = total
        addbill()
        addsales()



    End Sub

   
    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim obj As New Bill
        obj.cost = TextBox7.Text
        obj.Show()
        ' Me.Hide()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        employee.Show()
    End Sub

    Function fun() As Integer
        Return TextBox7.Text
    End Function

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class