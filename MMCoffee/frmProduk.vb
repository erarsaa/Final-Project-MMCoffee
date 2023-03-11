Imports System.Data.OracleClient
'belum update dataset di form stok yang hapusnya
'belum update combobox id di form stok
Public Class frmProduk
    Dim conn As New OracleConnection
    Dim dr As OracleDataReader
    Dim cmd As New OracleCommand
    Dim StokID, JMLKELUAR, JMLMASUK, NO As Integer
    Dim Ket As String

    Sub koneksi()
        conn.Close()
        conn = New OracleConnection("data source= (DESCRIPTION = " &
    "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-1AMLBSHE)(PORT = 1521)) " &
    "(CONNECT_DATA = " &
      "(SERVER = DEDICATED) " &
      "(SERVICE_NAME = XE) " &
    ") " &
  "); user id=hr; password=hr;")
        conn.Open()
    End Sub

    Private Sub btnBrgMasuk_Click(sender As Object, e As EventArgs) Handles btnTbhProduk.Click
        pnlTbhProduk.Visible = True
        pnlHpsProduk.Visible = False
    End Sub

    Private Sub btnHpsProduk_Click(sender As Object, e As EventArgs) Handles btnHpsProduk.Click
        Me.BRGTableAdapter.Fill(Me.DataSet3.BRG)
        pnlHpsProduk.Visible = True
        pnlTbhProduk.Visible = False
        cb_idProduk_hps.ResetText()
    End Sub

    Private Sub btnUpdtStok_Click(sender As Object, e As EventArgs) Handles btnUpdtStok.Click
        frmStok.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdtProduk_Click(sender As Object, e As EventArgs) Handles btnUpdtProduk.Click
        Me.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmAdmin.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

    End Sub

    Private Sub btnLihat_hps_Click(sender As Object, e As EventArgs) Handles btnLihat_hps.Click
        Me.Hide()
        frmLhtProduk.ShowDialog()
    End Sub

    Private Sub btnLihat_tbh_Click(sender As Object, e As EventArgs) Handles btnLihat_tbh.Click
        Me.Hide()
        frmLhtProduk.ShowDialog()
    End Sub

    Private Sub btnBatal_tbh_Click(sender As Object, e As EventArgs) Handles btnBatal_tbh.Click
        Dim batalTambah = MessageBox.Show("Anda yakin ingin membatalkan tambah produk ??", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalTambah = vbYes Then
            tb_idProduk_tbh.Text = ""
            tb_nmProduk_tbh.Text = ""
            tb_harga_tbh.Text = ""
            tb_stok_tbh.Text = ""
            MsgBox("Produk Batal Ditambahkan")
        End If
    End Sub

    Private Sub btnBatal_hps_Click(sender As Object, e As EventArgs) Handles btnBatal_hps.Click
        Dim batalHapus = MessageBox.Show("Anda yakin ingin membatalkan tambah produk ??", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalHapus = vbYes Then
            cb_idProduk_hps.ResetText()
            tb_nmProduk_hps.Text = ""
            tb_harga_hps.Text = ""
            tb_stok_hps.Text = ""
            MsgBox("Produk Batal Dihapus")
        End If
    End Sub

    Private Sub cb_idProduk_hps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_idProduk_hps.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & cb_idProduk_hps.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            tb_nmProduk_hps.Text = dr("NAMAPRODUK")
            tb_harga_hps.Text = dr("HARGA_SATUAN")
            If (dr("ID_PRODUK") = "RBS") Then
                tb_stok_hps.Text = frmLaporan.tsRobusta.Text
            ElseIf (dr("ID_PRODUK") = "JHE") Then
                tb_stok_hps.Text = frmLaporan.tsJahe.Text
            End If
        End If
    End Sub

    Private Sub pnlHpsProduk_Paint(sender As Object, e As PaintEventArgs) Handles pnlHpsProduk.Paint

    End Sub

    Private Sub frmProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.BRG' table. You can move, or remove it, as needed.
        Me.BRGTableAdapter.Fill(Me.DataSet3.BRG)

    End Sub

    Private Sub btnHapus_hps_Click(sender As Object, e As EventArgs) Handles btnHapus_hps.Click
        Dim hapus = MessageBox.Show("Anda yakin ingin menghapus produk ??", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hapus = vbYes Then
            koneksi()
            'Hapus dari database tabel BRG sesuai dengan id_produk
            cmd = New OracleCommand("delete BRG where ID_PRODUK='" & cb_idProduk_hps.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                StokID = dr("ID_STOK") + 1
            End If

            'Tambah ke database tabel STOKBRG (barang keluar/pengurangan semua sisa stok yang ada)
            Ket = "Lainnya"
            JMLMASUK = 0
            NO = 1
            cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_hps.Value.ToShortDateString & "','" & cb_idProduk_hps.Text & "'," &
                                     "'" & tb_nmProduk_hps.Text & "'," & JMLMASUK & "," & CInt(tb_stok_hps.Text) & ",'" & Ket & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil Dihapus")
            cb_idProduk_hps.ResetText()
        End If
        Me.BRGTableAdapter.Fill(Me.DataSet3.BRG)
    End Sub

    Private Sub btnSimpan_tbh_Click(sender As Object, e As EventArgs) Handles btnSimpan_tbh.Click
        koneksi()
        'Tambah ke database tabel BRG
        cmd = New OracleCommand("insert into BRG values ('" & tb_idProduk_tbh.Text & "','" & tb_nmProduk_tbh.Text & "'," & CDbl(tb_harga_tbh.Text) &
                                 "," & CInt(tb_stok_tbh.Text) & ",'" & DateTimePicker_tbhProduk.Value.ToShortDateString & "')", conn)
        cmd.ExecuteNonQuery()

        cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            StokID = dr("ID_STOK") + 1
        End If

        'tambah ke database tabel STOKBRG
        JMLKELUAR = 0
        NO = 1
        Ket = "Suplier"
        cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_tbhProduk.Value.ToShortDateString & "','" & tb_idProduk_tbh.Text & "'," &
                                 "'" & tb_nmProduk_tbh.Text & "'," & CInt(tb_stok_tbh.Text) & "," & JMLKELUAR & ",'" & Ket & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Produk Berhasil Ditambahkan")

        'Bersihkan textbox
        tb_idProduk_tbh.Text = ""
        tb_nmProduk_tbh.Text = ""
        tb_harga_tbh.Text = ""
        tb_stok_tbh.Text = ""

    End Sub
End Class