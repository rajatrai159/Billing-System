Public Class start_Page

    Private Sub btn_admin_Click(sender As System.Object, e As System.EventArgs) Handles btn_admin.Click
        Form1.Show()
        If Form1.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btn_user_Click(sender As System.Object, e As System.EventArgs) Handles btn_user.Click
        employee.Show()
        If employee.Visible Then
            Me.Hide()
        End If
    End Sub
End Class