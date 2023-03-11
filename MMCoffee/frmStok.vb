Imports System.Data.OracleClient
'benerin dibagian combobox pas dari admin klik update
'dibagian tambah stok cb nya udah clear tapi nama produknya belum

Public Class frmStok
    Dim conn As New OracleConnection
    Dim dr As OracleDataReader
    Dim cmd As New OracleCommand
    Dim StokID, JMLKELUAR, JMLMASUK, NO As Integer
    Dim str, Ket As String

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

    Private Sub btnBrgMasuk_Click(sender As Object, e As EventArgs) Handles btnBrgMasuk.Click
        pnlBrgMasuk.Visible = True
        pnlBrgKeluar.Visible = False
        idProduk.ResetText()
        nmProduk.Text = ""
    End Sub

    Private Sub btnBrgKeluar_Click(sender As Object, e As EventArgs) Handles btnBrgKeluar.Click
        pnlBrgKeluar.Visible = True
        pnlBrgMasuk.Visible = False
        cb_idProduk.ResetText()
        tb_nmProduk.Text = ""
    End Sub

    Private Sub btnUpdtStok_Click(sender As Object, e As EventArgs) Handles btnUpdtStok.Click
        Me.Show()
    End Sub

    Private Sub btnUpdtProduk_Click(sender As Object, e As EventArgs) Handles btnUpdtProduk.Click
        frmProduk.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmAdmin.ShowDialog()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            StokID = dr("ID_STOK") + 1
        End If
        JMLKELUAR = 0
        NO = 1
        Ket = "Suplier"
        cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_tambah_stok.Value.ToShortDateString & "','" & idProduk.Text & "'," &
                                 "'" & nmProduk.Text & "'," & jmlBrgMasuk.Value & "," & JMLKELUAR & ",'" & Ket & "')", conn)
        cmd.ExecuteNonQuery()

        lvBarangMasuk.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, ID_PRODUK, NAMAPRODUK, JUMLAH_PEMASUKAN, KETERANGAN from STOKBRG WHERE KETERANGAN = 'Suplier'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lvBarangMasuk.Items.Add(NO)
                lvBarangMasuk.Items(lvBarangMasuk.Items.Count - 1).SubItems.Add(dr.Item(1))
                lvBarangMasuk.Items(lvBarangMasuk.Items.Count - 1).SubItems.Add(dr.Item(2))
                lvBarangMasuk.Items(lvBarangMasuk.Items.Count - 1).SubItems.Add(dr.Item(3))
                lvBarangMasuk.Items(lvBarangMasuk.Items.Count - 1).SubItems.Add(dr.Item(4))
                lvBarangMasuk.Items(lvBarangMasuk.Items.Count - 1).SubItems.Add(dr.Item(5))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
        jmlBrgMasuk.Value = 0
        idProduk.ResetText()
        nmProduk.Text = ""
        idProduk.ResetText()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim batalTambah = MessageBox.Show("Anda yakin ingin membatalkan tambah stok ??", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalTambah = vbYes Then
            jmlBrgMasuk.Value = 0
            idProduk.ResetText()
            nmProduk.Text = ""
            MsgBox("Stok Batal Dihapus")
        End If
    End Sub

    Private Sub idProduk_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles idProduk.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & idProduk.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            nmProduk.Text = dr("NAMAPRODUK")
        End If
    End Sub

    Private Sub pnlBrgMasuk_Paint(sender As Object, e As PaintEventArgs) Handles pnlBrgMasuk.Paint

    End Sub

    Private Sub btn_batal_hps_Click(sender As Object, e As EventArgs) Handles btn_batal_hps.Click
        Dim batalHapus = MessageBox.Show("Anda yakin ingin membatalkan menghapus stok ??", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalHapus = vbYes Then
            jmlBrgKeluar.Value = 0
            idProduk.ResetText()
            nmProduk.Text = ""
            MsgBox("Stok Batal Dihapus")
        End If
    End Sub

    Private Sub cb_idProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_idProduk.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & cb_idProduk.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            tb_nmProduk.Text = dr("NAMAPRODUK")
        End If
    End Sub

    Private Sub btnSimpan_hps_Click(sender As Object, e As EventArgs) Handles btnSimpan_hps.Click
        koneksi()
        cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            StokID = dr("ID_STOK") + 1
        End If
        Ket = "Suplier"
        JMLMASUK = 0
        NO = 1
        cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_tambah_stok.Value.ToShortDateString & "','" & idProduk.Text & "'," &
                                 "'" & nmProduk.Text & "'," & JMLMASUK & "," & jmlBrgKeluar.Value & ",'" & cb_Ket.Text & "')", conn)
        cmd.ExecuteNonQuery()

        lvBarangKeluar.Items.Clear()
        cmd = New OracleCommand("SELECT  ID_STOK, TANGGAL, ID_PRODUK, NAMAPRODUK, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE KETERANGAN NOT IN '" & Ket & "'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lvBarangKeluar.Items.Add(NO)
                lvBarangKeluar.Items(lvBarangKeluar.Items.Count - 1).SubItems.Add(dr.Item(1))
                lvBarangKeluar.Items(lvBarangKeluar.Items.Count - 1).SubItems.Add(dr.Item(2))
                lvBarangKeluar.Items(lvBarangKeluar.Items.Count - 1).SubItems.Add(dr.Item(3))
                lvBarangKeluar.Items(lvBarangKeluar.Items.Count - 1).SubItems.Add(dr.Item(4))
                lvBarangKeluar.Items(lvBarangKeluar.Items.Count - 1).SubItems.Add(dr.Item(5))
                NO = NO + 1
            End While
            dr.Close()
        End If
        jmlBrgKeluar.Value = 0
        cb_idProduk.ResetText()
        tb_nmProduk.Text = ""
        dr.Close()
        cmd.Dispose()
        cb_idProduk.ResetText()
    End Sub

    Private Sub frmStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.BRG' table. You can move, or remove it, as needed.
        Me.BRGTableAdapter.Fill(Me.DataSet1.BRG)
    End Sub

End Class