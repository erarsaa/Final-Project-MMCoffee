Imports System.Data.OracleClient

Public Class frmLhtProduk
    Dim conn As New OracleConnection
    Dim dr As OracleDataReader
    Dim cmd As New OracleCommand
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_lihatProduk.SelectedIndexChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmProduk.ShowDialog()
    End Sub

    Private Sub frmLhtProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        lv_lihatProduk.Items.Clear()
        cmd = New OracleCommand("SELECT * from BRG", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_lihatProduk.Items.Add(dr.Item(0))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(4))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub
End Class