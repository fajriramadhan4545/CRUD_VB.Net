<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnlogin)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Login"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(148, 90)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(92, 90)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(50, 23)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(92, 64)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(131, 20)
        Me.txtpassword.TabIndex = 3
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(92, 31)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(131, 20)
        Me.txtusername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN APLIKASI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
