Public Class Login


    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then txtpassword.Focus()
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then btnlogin.Focus()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksiDB()
        txtusername.Focus()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        End
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("select * from LOGIN where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()

            If Not DR.HasRows Then
                MsgBox("Anda gagal login!!")
                txtusername.Clear()
                txtpassword.Clear()
                txtusername.Focus()
            Else
                Me.Visible = False
                Formutama.Show()
            End If
        End If
    End Sub
End Class

