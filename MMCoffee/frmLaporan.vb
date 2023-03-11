Imports System.Data.OracleClient

Public Class frmLaporan
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

    Private Sub btnUpdtStok_Click(sender As Object, e As EventArgs) Handles btnUpdtStok.Click
        frmStok.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdtProduk_Click(sender As Object, e As EventArgs) Handles btnUpdtProduk.Click
        frmProduk.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmAdmin.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

    End Sub

    Dim totalMasukRBS, totalKeluarRBS As Integer
    Dim totalMasukJHE, totalKeluarJHE As Integer
    Private Sub frmLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        'tabel kopi robusta
        totalMasukRBS = 0
        totalKeluarRBS = 0
        lv_laporanRobusta.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = 'RBS'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_laporanRobusta.Items.Add(NO)
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(4))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        For i As Integer = 0 To lv_laporanRobusta.Items.Count - 1
            totalMasukRBS = totalMasukRBS + CInt(lv_laporanRobusta.Items(i).SubItems(2).Text)
            totalKeluarRBS = totalKeluarRBS + CInt(lv_laporanRobusta.Items(i).SubItems(3).Text)
        Next
        jmRobusta.Text = totalMasukRBS
        jkRobusta.Text = totalKeluarRBS
        tsRobusta.Text = totalMasukRBS - totalKeluarRBS

        'tabel kopi jahe
        totalMasukJHE = 0
        totalKeluarJHE = 0
        lv_laporanJahe.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = 'JHE'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_laporanJahe.Items.Add(NO)
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(4))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        For i As Integer = 0 To lv_laporanJahe.Items.Count - 1
            totalMasukJHE = totalMasukJHE + CInt(lv_laporanJahe.Items(i).SubItems(2).Text)
            totalKeluarJHE = totalKeluarJHE + CInt(lv_laporanJahe.Items(i).SubItems(3).Text)
        Next
        jmJahe.Text = totalMasukJHE
        jkJahe.Text = totalKeluarJHE
        tsJahe.Text = totalMasukJHE - totalKeluarJHE
    End Sub
End Class