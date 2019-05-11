<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_SALES = New System.Windows.Forms.Button()
        Me.BTN_ITEMS = New System.Windows.Forms.Button()
        Me.BTN_EMPLOYEE = New System.Windows.Forms.Button()
        Me.BTN_LOGOUT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_SALES
        '
        Me.BTN_SALES.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SALES.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_SALES.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SALES.ForeColor = System.Drawing.Color.Blue
        Me.BTN_SALES.Location = New System.Drawing.Point(57, 142)
        Me.BTN_SALES.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_SALES.Name = "BTN_SALES"
        Me.BTN_SALES.Size = New System.Drawing.Size(253, 111)
        Me.BTN_SALES.TabIndex = 0
        Me.BTN_SALES.Text = "SALES"
        Me.BTN_SALES.UseVisualStyleBackColor = False
        '
        'BTN_ITEMS
        '
        Me.BTN_ITEMS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ITEMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_ITEMS.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ITEMS.ForeColor = System.Drawing.Color.Blue
        Me.BTN_ITEMS.Location = New System.Drawing.Point(336, 142)
        Me.BTN_ITEMS.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_ITEMS.Name = "BTN_ITEMS"
        Me.BTN_ITEMS.Size = New System.Drawing.Size(253, 111)
        Me.BTN_ITEMS.TabIndex = 1
        Me.BTN_ITEMS.Text = "ITEMS"
        Me.BTN_ITEMS.UseVisualStyleBackColor = False
        '
        'BTN_EMPLOYEE
        '
        Me.BTN_EMPLOYEE.BackColor = System.Drawing.Color.Transparent
        Me.BTN_EMPLOYEE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_EMPLOYEE.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EMPLOYEE.ForeColor = System.Drawing.Color.Blue
        Me.BTN_EMPLOYEE.Location = New System.Drawing.Point(57, 299)
        Me.BTN_EMPLOYEE.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_EMPLOYEE.Name = "BTN_EMPLOYEE"
        Me.BTN_EMPLOYEE.Size = New System.Drawing.Size(253, 111)
        Me.BTN_EMPLOYEE.TabIndex = 2
        Me.BTN_EMPLOYEE.Text = "EMPLOYEE"
        Me.BTN_EMPLOYEE.UseVisualStyleBackColor = False
        '
        'BTN_LOGOUT
        '
        Me.BTN_LOGOUT.BackColor = System.Drawing.Color.Transparent
        Me.BTN_LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_LOGOUT.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LOGOUT.ForeColor = System.Drawing.Color.Blue
        Me.BTN_LOGOUT.Location = New System.Drawing.Point(336, 299)
        Me.BTN_LOGOUT.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_LOGOUT.Name = "BTN_LOGOUT"
        Me.BTN_LOGOUT.Size = New System.Drawing.Size(253, 111)
        Me.BTN_LOGOUT.TabIndex = 3
        Me.BTN_LOGOUT.Text = "LOGOUT"
        Me.BTN_LOGOUT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 92)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Admin Section"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.billing_system.My.Resources.Resources.Restarunthomej
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(648, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_LOGOUT)
        Me.Controls.Add(Me.BTN_EMPLOYEE)
        Me.Controls.Add(Me.BTN_ITEMS)
        Me.Controls.Add(Me.BTN_SALES)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_SALES As System.Windows.Forms.Button
    Friend WithEvents BTN_ITEMS As System.Windows.Forms.Button
    Friend WithEvents BTN_EMPLOYEE As System.Windows.Forms.Button
    Friend WithEvents BTN_LOGOUT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
