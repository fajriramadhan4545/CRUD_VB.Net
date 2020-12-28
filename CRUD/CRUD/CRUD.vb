Public Class CRUD
    Sub kosongkan()
        txtKode.Text = ""
        txtNama.text = ""
        txtJeniskelamin.Text = ""
        txtTelp.Text = ""
        txtEmail.Text = ""
        txtAlamat.Text = ""
        txtKode.Focus()
    End Sub

    Sub Matikanform()
        txtKode.Enabled = False
        txtNama.Enabled = False
        txtJeniskelamin.Enabled = False
        txtTelp.Enabled = False
        txtEmail.Enabled = False
        txtAlamat.Enabled = False
    End Sub

    Sub Hidupkanform()
        txtKode.Enabled = True
        txtNama.Enabled = True
        txtJeniskelamin.Enabled = True
        txtTelp.Enabled = True
        txtEmail.Enabled = True
        txtAlamat.Enabled = True
    End Sub

    Sub Tampilkandata()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from CRUD", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView.DataSource = DS.Tables(0)
        DataGridView.ReadOnly = True
    End Sub

    Private Sub CRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Matikanform()
        Call Tampilkandata()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Call Hidupkanform()
        Call kosongkan()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call Matikanform()
        Call kosongkan()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtKode.Text = "" Or txtNama.Text = "" Or txtJeniskelamin.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("select * from CRUD where kode='" & txtKode.Text & "' ", CONN)
            DR = CMD.ExecuteReader()
            DR.Read()
            If Not DR.HasRows Then
                Call koneksiDB()
                Dim Simpan As String
                Simpan = "insert into CRUD values('" & txtKode.Text & "','" & txtNama.Text & "','" & txtJeniskelamin.Text & "','" & txtTelp.Text & "','" & txtEmail.Text & "', '" & txtAlamat.Text & "')"
                CMD = New OleDb.OleDbCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Berhasil!")
            Else
                MsgBox("Kode Teman Sudah Ada")
            End If
            Call Matikanform()
            Call kosongkan()
            Call Tampilkandata()
        End If
    End Sub

    Private Sub DataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseClick
        On Error Resume Next
        txtKode.Text = DataGridView.Rows(e.RowIndex).Cells(0).Value
        txtNama.Text = DataGridView.Rows(e.RowIndex).Cells(1).Value
        txtJeniskelamin.Text = DataGridView.Rows(e.RowIndex).Cells(2).Value
        txtTelp.Text = DataGridView.Rows(e.RowIndex).Cells(3).Value
        txtEmail.Text = DataGridView.Rows(e.RowIndex).Cells(4).Value
        txtAlamat.Text = DataGridView.Rows(e.RowIndex).Cells(5).Value

        Call Hidupkanform()
        txtKode.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtKode.Text = "" Or txtNama.Text = "" Or txtJeniskelamin.Text = "" Then
            MsgBox("Tidak Boleh Kosong")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update CRUD set nama_teman='" & txtNama.Text & "',jenis_kelamin='" & txtJeniskelamin.Text & "',nomor_tlp='" & txtTelp.Text & "',email='" & txtEmail.Text & "',alamat_rumah='" & txtAlamat.Text & "' where kode='" & txtKode.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Update Data Berhasil!")
        End If

        Call Matikanform()
        Call kosongkan()
        Call Tampilkandata()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Then
            MsgBox("Tidak Ada Data")
            Exit Sub
        Else
            If MessageBox.Show("Yakin datanya mau dihapus?", "konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand("delete from CRUD where kode='" & txtKode.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus")
            Else
                Call Matikanform()
                Call kosongkan()
            End If
        End If

        Call Matikanform()
        Call kosongkan()
        Call Tampilkandata()
    End Sub

    
   
End Class
