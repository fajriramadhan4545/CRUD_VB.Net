Public Class Temandekat

    Sub kosongakanteman()
        txtKodeDekat.Text = ""
        txtTeman.Text = ""
        txtAlamatTeman.Text = ""
        txtHobiTeman.Text = ""
        txtKodeDekat.Focus()
    End Sub

    Sub matikanteman()
        txtKodeDekat.Enabled = False
        txtTeman.Enabled = False
        txtAlamatTeman.Enabled = False
        txtHobiTeman.Enabled = False
    End Sub

    Sub hidupkanteman()
        txtKodeDekat.Enabled = True
        txtTeman.Enabled = True
        txtAlamatTeman.Enabled = True
        txtHobiTeman.Enabled = True
    End Sub

    Sub tampilkanteman()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from DEKAT", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub btnKeluarTeman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluarTeman.Click
        Me.Close()
    End Sub

   
    Private Sub Temandekat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosongakanteman()
        Call matikanteman()
        Call tampilkanteman()
    End Sub

    Private Sub btnTambahTeman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahTeman.Click
        Call kosongakanteman()
        Call hidupkanteman()
    End Sub

    Private Sub btnBatalTeman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalTeman.Click
        Call matikanteman()
        Call kosongakanteman()
    End Sub

    Private Sub btnSimpanTeman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpanTeman.Click
        If txtKodeDekat.Text = "" Or txtTeman.Text = "" Or txtAlamatTeman.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("select * from DEKAT where k_teman='" & txtKodeDekat.Text & "' ", CONN)
            DR = CMD.ExecuteReader()
            DR.Read()
            If Not DR.HasRows Then
                Call koneksiDB()
                Dim Simpan As String
                Simpan = "insert into DEKAT values('" & txtKodeDekat.Text & "','" & txtTeman.Text & "','" & txtAlamatTeman.Text & "','" & txtHobiTeman.Text & "')"
                CMD = New OleDb.OleDbCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Berhasil!")
            Else
                MsgBox("Kode Teman Sudah Ada")
            End If
            Call matikanteman()
            Call kosongakanteman()
            Call tampilkanteman()
        End If
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        txtKodeDekat.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtTeman.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txtAlamatTeman.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtHobiTeman.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        Call hidupkanteman()
        txtKodeDekat.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtKodeDekat.Text = "" Or txtTeman.Text = "" Or txtAlamatTeman.Text = "" Or txtHobiTeman.Text = "" Then
            MsgBox("Tidak Boleh Kosong")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update DEKAT set nama='" & txtTeman.Text & "',alamat='" & txtAlamatTeman.Text & "',hobi='" & txtHobiTeman.Text & "' where k_teman='" & txtKodeDekat.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Update Data Berhasil")
        End If

        Call matikanteman()
        Call kosongakanteman()
        Call tampilkanteman()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If txtKodeDekat.Text = "" Then
            MsgBox("Tidak Ada Data Yang Dihapus")
            Exit Sub
        Else
            If MessageBox.Show("Yakin datanya mau dihapus?", "konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand("delete from DEKAT where k_teman='" & txtKodeDekat.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus")

            Else
                Call matikanteman()
                Call kosongakanteman()
            End If
        End If
        Call kosongakanteman()
        Call matikanteman()
        Call tampilkanteman()
    End Sub
End Class