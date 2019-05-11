Public Class admin

    Private Sub BTN_LOGOUT_Click(sender As System.Object, e As System.EventArgs) Handles BTN_LOGOUT.Click
        Form1.Show()
        If Form1.Visible Then
            Me.Hide()
        End If

    End Sub

    Private Sub BTN_ITEMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ITEMS.Click
        Me.Hide()
        Item_Info.Show()
    End Sub

    Private Sub BTN_SALES_Click(sender As System.Object, e As System.EventArgs) Handles BTN_SALES.Click
        Me.Hide()
        sales_info.Show()
    End Sub

    Private Sub BTN_EMPLOYEE_Click(sender As System.Object, e As System.EventArgs) Handles BTN_EMPLOYEE.Click
        Me.Hide()
        Emp_Section.Show()
    End Sub
End Class