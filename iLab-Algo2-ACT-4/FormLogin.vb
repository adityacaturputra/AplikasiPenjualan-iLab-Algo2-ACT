Imports System.Data.Odbc
Public Class FormLogin
    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        Me.Hide()
    End Sub
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode Admin dan Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tabel_admin where kodeadmin='" & TextBox1.Text & "' and passwordadmin='" & TextBox2.Text &
            "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
            Else
                MsgBox("Kode Admin atau Password Salah!")
            End If
        End If
    End Sub
End Class