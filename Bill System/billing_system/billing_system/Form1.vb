Imports System.Data.OleDb
Public Class Form1

    Private Sub btn_login_Click(sender As System.Object, e As System.EventArgs) Handles btn_login.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String = ""
        If TXT_USER.Text = "" Or TXT_PASS.Text = "" Then
            MsgBox("Plz Fill All the info", MsgBoxStyle.OkOnly, "Login failed")
        Else
            uname = TXT_USER.Text
            pword = TXT_PASS.Text
            Dim querry As String = "Select pass From adminLogin where name= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database11.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception

                TXT_USER.Clear()
                TXT_PASS.Clear()
            End Try
            If (pword = pass) Then
                MsgBox("Welcome", MsgBoxStyle.OkOnly, "Login success")
                TXT_USER.Clear()
                TXT_PASS.Clear()
                admin.Show()
                If admin.Visible Then
                    Me.Hide()
                End If
            Else
                MsgBox("Username does not exist", MsgBoxStyle.OkOnly, "Login failed")

                TXT_USER.Clear()
                TXT_PASS.Clear()
            End If
        End If
        


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        TXT_USER.Clear()
        TXT_PASS.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        start_Page.Show()
    End Sub
End Class
