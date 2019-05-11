<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start_Page
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
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_admin
        '
        Me.btn_admin.BackColor = System.Drawing.Color.Transparent
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_admin.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admin.ForeColor = System.Drawing.Color.Navy
        Me.btn_admin.Location = New System.Drawing.Point(67, 15)
        Me.btn_admin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(215, 112)
        Me.btn_admin.TabIndex = 0
        Me.btn_admin.Text = "ADMIN"
        Me.btn_admin.UseVisualStyleBackColor = False
        '
        'btn_user
        '
        Me.btn_user.BackColor = System.Drawing.Color.Transparent
        Me.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_user.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_user.ForeColor = System.Drawing.Color.Navy
        Me.btn_user.Location = New System.Drawing.Point(67, 167)
        Me.btn_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(215, 112)
        Me.btn_user.TabIndex = 1
        Me.btn_user.Text = "USER"
        Me.btn_user.UseVisualStyleBackColor = False
        '
        'start_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.billing_system.My.Resources.Resources.madelon_1044192_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_admin)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "start_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "start_Page"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_admin As System.Windows.Forms.Button
    Friend WithEvents btn_user As System.Windows.Forms.Button
End Class
