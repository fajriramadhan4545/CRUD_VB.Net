<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temandekat
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeDekat = New System.Windows.Forms.TextBox()
        Me.txtTeman = New System.Windows.Forms.TextBox()
        Me.txtAlamatTeman = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHobiTeman = New System.Windows.Forms.TextBox()
        Me.btnTambahTeman = New System.Windows.Forms.Button()
        Me.btnSimpanTeman = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnKeluarTeman = New System.Windows.Forms.Button()
        Me.btnBatalTeman = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TEMAN DEKAT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'txtKodeDekat
        '
        Me.txtKodeDekat.Location = New System.Drawing.Point(85, 83)
        Me.txtKodeDekat.Name = "txtKodeDekat"
        Me.txtKodeDekat.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeDekat.TabIndex = 4
        '
        'txtTeman
        '
        Me.txtTeman.Location = New System.Drawing.Point(85, 122)
        Me.txtTeman.Name = "txtTeman"
        Me.txtTeman.Size = New System.Drawing.Size(100, 20)
        Me.txtTeman.TabIndex = 5
        '
        'txtAlamatTeman
        '
        Me.txtAlamatTeman.Location = New System.Drawing.Point(85, 159)
        Me.txtAlamatTeman.Name = "txtAlamatTeman"
        Me.txtAlamatTeman.Size = New System.Drawing.Size(100, 20)
        Me.txtAlamatTeman.TabIndex = 6
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 240)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(474, 110)
        Me.DGV.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hobi"
        '
        'txtHobiTeman
        '
        Me.txtHobiTeman.Location = New System.Drawing.Point(85, 191)
        Me.txtHobiTeman.Name = "txtHobiTeman"
        Me.txtHobiTeman.Size = New System.Drawing.Size(100, 20)
        Me.txtHobiTeman.TabIndex = 9
        '
        'btnTambahTeman
        '
        Me.btnTambahTeman.Location = New System.Drawing.Point(271, 78)
        Me.btnTambahTeman.Name = "btnTambahTeman"
        Me.btnTambahTeman.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahTeman.TabIndex = 10
        Me.btnTambahTeman.Text = "Tambah"
        Me.btnTambahTeman.UseVisualStyleBackColor = True
        '
        'btnSimpanTeman
        '
        Me.btnSimpanTeman.Location = New System.Drawing.Point(271, 117)
        Me.btnSimpanTeman.Name = "btnSimpanTeman"
        Me.btnSimpanTeman.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpanTeman.TabIndex = 11
        Me.btnSimpanTeman.Text = "Simpan"
        Me.btnSimpanTeman.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(271, 159)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnKeluarTeman
        '
        Me.btnKeluarTeman.Location = New System.Drawing.Point(271, 191)
        Me.btnKeluarTeman.Name = "btnKeluarTeman"
        Me.btnKeluarTeman.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluarTeman.TabIndex = 13
        Me.btnKeluarTeman.Text = "Keluar"
        Me.btnKeluarTeman.UseVisualStyleBackColor = True
        '
        'btnBatalTeman
        '
        Me.btnBatalTeman.Location = New System.Drawing.Point(367, 191)
        Me.btnBatalTeman.Name = "btnBatalTeman"
        Me.btnBatalTeman.Size = New System.Drawing.Size(75, 23)
        Me.btnBatalTeman.TabIndex = 14
        Me.btnBatalTeman.Text = "Batal"
        Me.btnBatalTeman.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(367, 159)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Temandekat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 362)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatalTeman)
        Me.Controls.Add(Me.btnKeluarTeman)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSimpanTeman)
        Me.Controls.Add(Me.btnTambahTeman)
        Me.Controls.Add(Me.txtHobiTeman)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtAlamatTeman)
        Me.Controls.Add(Me.txtTeman)
        Me.Controls.Add(Me.txtKodeDekat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Temandekat"
        Me.Text = "Hobi"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKodeDekat As System.Windows.Forms.TextBox
    Friend WithEvents txtTeman As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamatTeman As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHobiTeman As System.Windows.Forms.TextBox
    Friend WithEvents btnTambahTeman As System.Windows.Forms.Button
    Friend WithEvents btnSimpanTeman As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnKeluarTeman As System.Windows.Forms.Button
    Friend WithEvents btnBatalTeman As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
End Class
