﻿Imports System.Data.Odbc
Public Class FormDataAdmin
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox2.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox2.Enabled = False
        ComboBox1.Enabled = False
        Button_Input.Enabled = True
        Button_Edit.Enabled = True
        Button_Hapus.Enabled = True
        Button_Input.Text = "Input"
        Button_Edit.Text = "Edit"
        Button_Hapus.Text = "Hapus"
        Button_Tutup.Text = "Tutup"
        Call Koneksi()
        Da = New OdbcDataAdapter("Select kodeadmin, namaadmin, leveladmin From tabel_admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tabel_admin")
        DataGridView1.DataSource = Ds.Tables("tabel_admin")
        DataGridView1.ReadOnly = True
    End Sub

    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox2.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
    End Sub

    Private Sub FormDataAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Btn_Input_Click(sender As Object, e As EventArgs) Handles Button_Input.Click
        If Button_Input.Text = "Input" Then
            Button_Input.Text = "Simpan"
            Button_Edit.Enabled = False
            Button_Hapus.Enabled = False
            Button_Tutup.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field Data Admin!")
            Else
                Call Koneksi()
                Dim InputData As String = "insert into tabel_admin values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If Button_Edit.Text = "Edit" Then
            Button_Edit.Text = "Simpan"
            Button_Input.Enabled = False
            Button_Hapus.Enabled = False
            Button_Tutup.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field Data Admin!")
            Else
                Call Koneksi()
                Dim UpdateData As String = "update tabel_admin set namaadmin='" & TextBox2.Text & "', passwordadmin='" & TextBox3.Text & "',leveladmin='" & ComboBox1.Text & "' where kodeadmin='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tabel_admin where kodeadmin='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Admin Tidak Tersedia")
            Else
                TextBox1.Text = Rd.Item("kodeadmin")
                TextBox2.Text = Rd.Item("namaadmin")
                TextBox3.Text = Rd.Item("passwordadmin")
                ComboBox1.Text = Rd.Item("leveladmin")
            End If
        End If
    End Sub

    Private Sub Button_Tutup_Click(sender As Object, e As EventArgs) Handles Button_Tutup.Click

        If Button_Tutup.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click

        If Button_Hapus.Text = "Hapus" Then
            Button_Hapus.Text = "Delete"
            Button_Input.Enabled = False
            Button_Edit.Enabled = False
            Button_Tutup.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field Data Admin!")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete from tabel_admin where kodeadmin='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub
End Class