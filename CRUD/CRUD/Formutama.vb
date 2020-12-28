Public Class Formutama
    Sub terkunci()
        LogoutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub DataTemanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataTemanToolStripMenuItem.Click
        CRUD.Show()
    End Sub

    Private Sub TemanDekatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemanDekatToolStripMenuItem.Click
        Temandekat.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Call terkunci()
    End Sub
End Class

