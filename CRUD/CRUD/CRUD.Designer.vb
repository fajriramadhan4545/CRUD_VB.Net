<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtJeniskelamin = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._81
        Me.GroupBox1.Controls.Add(Me.DataGridView)
        Me.GroupBox1.Controls.Add(Me.btnKeluar)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelp)
        Me.GroupBox1.Controls.Add(Me.txtJeniskelamin)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtKode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ";"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(20, 197)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.Size = New System.Drawing.Size(606, 168)
        Me.DataGridView.TabIndex = 18
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(431, 167)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(57, 23)
        Me.btnKeluar.TabIndex = 17
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(375, 167)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(49, 23)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(323, 168)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(45, 23)
        Me.btnBatal.TabIndex = 15
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(273, 168)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(44, 23)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(215, 168)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(52, 23)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan "
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(152, 168)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(57, 23)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(392, 99)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(191, 41)
        Me.txtAlamat.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(392, 64)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(191, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(392, 35)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(121, 20)
        Me.txtTelp.TabIndex = 9
        '
        'txtJeniskelamin
        '
        Me.txtJeniskelamin.FormattingEnabled = True
        Me.txtJeniskelamin.Items.AddRange(New Object() {"L", "P"})
        Me.txtJeniskelamin.Location = New System.Drawing.Point(103, 99)
        Me.txtJeniskelamin.Name = "txtJeniskelamin"
        Me.txtJeniskelamin.Size = New System.Drawing.Size(46, 21)
        Me.txtJeniskelamin.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(103, 67)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(191, 20)
        Me.txtNama.TabIndex = 7
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(103, 35)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(100, 20)
        Me.txtKode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Teman"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 389)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CRUD"
        Me.Text = "\"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtJeniskelamin As System.Windows.Forms.ComboBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView

End Class
