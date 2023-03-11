<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.idProduk = New System.Windows.Forms.ComboBox()
        Me.BRGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MMCoffee.DataSet1()
        Me.btnBrgKeluar = New System.Windows.Forms.Button()
        Me.pnlBrgMasuk = New System.Windows.Forms.Panel()
        Me.lvBarangMasuk = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimePicker_tambah_stok = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.jmlBrgMasuk = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nmProduk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.btnBrgMasuk = New System.Windows.Forms.Button()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdtProduk = New System.Windows.Forms.Button()
        Me.btnUpdtStok = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlBrgKeluar = New System.Windows.Forms.Panel()
        Me.DateTimePicker_hps = New System.Windows.Forms.DateTimePicker()
        Me.cb_Ket = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_nmProduk = New System.Windows.Forms.TextBox()
        Me.btnSimpan_hps = New System.Windows.Forms.Button()
        Me.btn_batal_hps = New System.Windows.Forms.Button()
        Me.cb_idProduk = New System.Windows.Forms.ComboBox()
        Me.jmlBrgKeluar = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvBarangKeluar = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BRGTableAdapter = New MMCoffee.DataSet1TableAdapters.BRGTableAdapter()
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBrgMasuk.SuspendLayout()
        CType(Me.jmlBrgMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        Me.pnlLeftSide.SuspendLayout()
        Me.pnlBrgKeluar.SuspendLayout()
        CType(Me.jmlBrgKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idProduk
        '
        Me.idProduk.DataSource = Me.BRGBindingSource
        Me.idProduk.DisplayMember = "ID_PRODUK"
        Me.idProduk.FormattingEnabled = True
        Me.idProduk.Location = New System.Drawing.Point(155, 79)
        Me.idProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.idProduk.Name = "idProduk"
        Me.idProduk.Size = New System.Drawing.Size(234, 24)
        Me.idProduk.TabIndex = 7
        '
        'BRGBindingSource
        '
        Me.BRGBindingSource.DataMember = "BRG"
        Me.BRGBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBrgKeluar
        '
        Me.btnBrgKeluar.BackColor = System.Drawing.Color.Transparent
        Me.btnBrgKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrgKeluar.FlatAppearance.BorderSize = 0
        Me.btnBrgKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrgKeluar.Location = New System.Drawing.Point(189, 3)
        Me.btnBrgKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrgKeluar.Name = "btnBrgKeluar"
        Me.btnBrgKeluar.Size = New System.Drawing.Size(181, 38)
        Me.btnBrgKeluar.TabIndex = 18
        Me.btnBrgKeluar.Text = "Barang Keluar"
        Me.btnBrgKeluar.UseVisualStyleBackColor = False
        '
        'pnlBrgMasuk
        '
        Me.pnlBrgMasuk.Controls.Add(Me.lvBarangMasuk)
        Me.pnlBrgMasuk.Controls.Add(Me.DateTimePicker_tambah_stok)
        Me.pnlBrgMasuk.Controls.Add(Me.btnSimpan)
        Me.pnlBrgMasuk.Controls.Add(Me.btnBatal)
        Me.pnlBrgMasuk.Controls.Add(Me.jmlBrgMasuk)
        Me.pnlBrgMasuk.Controls.Add(Me.Label10)
        Me.pnlBrgMasuk.Controls.Add(Me.Label1)
        Me.pnlBrgMasuk.Controls.Add(Me.nmProduk)
        Me.pnlBrgMasuk.Controls.Add(Me.idProduk)
        Me.pnlBrgMasuk.Controls.Add(Me.Label3)
        Me.pnlBrgMasuk.Controls.Add(Me.Label2)
        Me.pnlBrgMasuk.Location = New System.Drawing.Point(2, 2)
        Me.pnlBrgMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBrgMasuk.Name = "pnlBrgMasuk"
        Me.pnlBrgMasuk.Size = New System.Drawing.Size(850, 478)
        Me.pnlBrgMasuk.TabIndex = 17
        '
        'lvBarangMasuk
        '
        Me.lvBarangMasuk.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvBarangMasuk.FullRowSelect = True
        Me.lvBarangMasuk.GridLines = True
        Me.lvBarangMasuk.HideSelection = False
        Me.lvBarangMasuk.Location = New System.Drawing.Point(35, 172)
        Me.lvBarangMasuk.Name = "lvBarangMasuk"
        Me.lvBarangMasuk.Size = New System.Drawing.Size(791, 290)
        Me.lvBarangMasuk.TabIndex = 19
        Me.lvBarangMasuk.UseCompatibleStateImageBehavior = False
        Me.lvBarangMasuk.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "NO"
        Me.ColumnHeader0.Width = 30
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tanggal"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID Produk"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Produk"
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jumlah Barang Masuk"
        Me.ColumnHeader4.Width = 140
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Keterangan"
        Me.ColumnHeader5.Width = 80
        '
        'DateTimePicker_tambah_stok
        '
        Me.DateTimePicker_tambah_stok.Location = New System.Drawing.Point(155, 37)
        Me.DateTimePicker_tambah_stok.Name = "DateTimePicker_tambah_stok"
        Me.DateTimePicker_tambah_stok.Size = New System.Drawing.Size(234, 22)
        Me.DateTimePicker_tambah_stok.TabIndex = 18
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(635, 127)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 26)
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(511, 127)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 26)
        Me.btnBatal.TabIndex = 16
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'jmlBrgMasuk
        '
        Me.jmlBrgMasuk.Location = New System.Drawing.Point(621, 37)
        Me.jmlBrgMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.jmlBrgMasuk.Name = "jmlBrgMasuk"
        Me.jmlBrgMasuk.Size = New System.Drawing.Size(163, 22)
        Me.jmlBrgMasuk.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(427, 41)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Jumlah Barang Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal"
        '
        'nmProduk
        '
        Me.nmProduk.Location = New System.Drawing.Point(155, 124)
        Me.nmProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.nmProduk.Name = "nmProduk"
        Me.nmProduk.Size = New System.Drawing.Size(234, 22)
        Me.nmProduk.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Produk"
        '
        'pnlTopSide
        '
        Me.pnlTopSide.Controls.Add(Me.btnBrgKeluar)
        Me.pnlTopSide.Controls.Add(Me.btnBrgMasuk)
        Me.pnlTopSide.Location = New System.Drawing.Point(188, 0)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(861, 42)
        Me.pnlTopSide.TabIndex = 16
        '
        'btnBrgMasuk
        '
        Me.btnBrgMasuk.BackColor = System.Drawing.Color.Transparent
        Me.btnBrgMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrgMasuk.FlatAppearance.BorderSize = 0
        Me.btnBrgMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrgMasuk.Location = New System.Drawing.Point(5, 2)
        Me.btnBrgMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrgMasuk.Name = "btnBrgMasuk"
        Me.btnBrgMasuk.Size = New System.Drawing.Size(181, 38)
        Me.btnBrgMasuk.TabIndex = 17
        Me.btnBrgMasuk.Text = "Barang Masuk"
        Me.btnBrgMasuk.UseVisualStyleBackColor = False
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.Controls.Add(Me.btnLogout)
        Me.pnlLeftSide.Controls.Add(Me.btnReport)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtProduk)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtStok)
        Me.pnlLeftSide.Controls.Add(Me.btnBack)
        Me.pnlLeftSide.Location = New System.Drawing.Point(1, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(183, 530)
        Me.pnlLeftSide.TabIndex = 15
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = Global.MMCoffee.My.Resources.Resources.logout2
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(59, 476)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 47)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Image = Global.MMCoffee.My.Resources.Resources.business_report2
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(2, 180)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(181, 47)
        Me.btnReport.TabIndex = 15
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnUpdtProduk
        '
        Me.btnUpdtProduk.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdtProduk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdtProduk.FlatAppearance.BorderSize = 0
        Me.btnUpdtProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdtProduk.Image = Global.MMCoffee.My.Resources.Resources.coffee_bean2
        Me.btnUpdtProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdtProduk.Location = New System.Drawing.Point(2, 129)
        Me.btnUpdtProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdtProduk.Name = "btnUpdtProduk"
        Me.btnUpdtProduk.Size = New System.Drawing.Size(181, 47)
        Me.btnUpdtProduk.TabIndex = 14
        Me.btnUpdtProduk.Text = "Update Product"
        Me.btnUpdtProduk.UseVisualStyleBackColor = False
        '
        'btnUpdtStok
        '
        Me.btnUpdtStok.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdtStok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdtStok.FlatAppearance.BorderSize = 0
        Me.btnUpdtStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdtStok.Image = Global.MMCoffee.My.Resources.Resources.inventory2
        Me.btnUpdtStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdtStok.Location = New System.Drawing.Point(2, 77)
        Me.btnUpdtStok.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdtStok.Name = "btnUpdtStok"
        Me.btnUpdtStok.Size = New System.Drawing.Size(181, 47)
        Me.btnUpdtStok.TabIndex = 13
        Me.btnUpdtStok.Text = "Update Stock"
        Me.btnUpdtStok.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.MMCoffee.My.Resources.Resources.previous
        Me.btnBack.Location = New System.Drawing.Point(7, 8)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 47)
        Me.btnBack.TabIndex = 12
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlBrgKeluar
        '
        Me.pnlBrgKeluar.Controls.Add(Me.pnlBrgMasuk)
        Me.pnlBrgKeluar.Controls.Add(Me.DateTimePicker_hps)
        Me.pnlBrgKeluar.Controls.Add(Me.cb_Ket)
        Me.pnlBrgKeluar.Controls.Add(Me.Label9)
        Me.pnlBrgKeluar.Controls.Add(Me.Label5)
        Me.pnlBrgKeluar.Controls.Add(Me.tb_nmProduk)
        Me.pnlBrgKeluar.Controls.Add(Me.btnSimpan_hps)
        Me.pnlBrgKeluar.Controls.Add(Me.btn_batal_hps)
        Me.pnlBrgKeluar.Controls.Add(Me.cb_idProduk)
        Me.pnlBrgKeluar.Controls.Add(Me.jmlBrgKeluar)
        Me.pnlBrgKeluar.Controls.Add(Me.Label6)
        Me.pnlBrgKeluar.Controls.Add(Me.Label7)
        Me.pnlBrgKeluar.Controls.Add(Me.Label8)
        Me.pnlBrgKeluar.Controls.Add(Me.lvBarangKeluar)
        Me.pnlBrgKeluar.Location = New System.Drawing.Point(188, 44)
        Me.pnlBrgKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBrgKeluar.Name = "pnlBrgKeluar"
        Me.pnlBrgKeluar.Size = New System.Drawing.Size(852, 478)
        Me.pnlBrgKeluar.TabIndex = 18
        '
        'DateTimePicker_hps
        '
        Me.DateTimePicker_hps.Location = New System.Drawing.Point(147, 43)
        Me.DateTimePicker_hps.Name = "DateTimePicker_hps"
        Me.DateTimePicker_hps.Size = New System.Drawing.Size(229, 22)
        Me.DateTimePicker_hps.TabIndex = 19
        '
        'cb_Ket
        '
        Me.cb_Ket.FormattingEnabled = True
        Me.cb_Ket.Items.AddRange(New Object() {"Kadaluwarsa", "Return", "Lainnya"})
        Me.cb_Ket.Location = New System.Drawing.Point(603, 81)
        Me.cb_Ket.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Ket.Name = "cb_Ket"
        Me.cb_Ket.Size = New System.Drawing.Size(167, 24)
        Me.cb_Ket.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(409, 84)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Alasan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tanggal"
        '
        'tb_nmProduk
        '
        Me.tb_nmProduk.Location = New System.Drawing.Point(147, 126)
        Me.tb_nmProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nmProduk.Name = "tb_nmProduk"
        Me.tb_nmProduk.Size = New System.Drawing.Size(229, 22)
        Me.tb_nmProduk.TabIndex = 9
        '
        'btnSimpan_hps
        '
        Me.btnSimpan_hps.Location = New System.Drawing.Point(617, 124)
        Me.btnSimpan_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan_hps.Name = "btnSimpan_hps"
        Me.btnSimpan_hps.Size = New System.Drawing.Size(100, 26)
        Me.btnSimpan_hps.TabIndex = 11
        Me.btnSimpan_hps.Text = "Simpan"
        Me.btnSimpan_hps.UseVisualStyleBackColor = True
        '
        'btn_batal_hps
        '
        Me.btn_batal_hps.Location = New System.Drawing.Point(493, 124)
        Me.btn_batal_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_batal_hps.Name = "btn_batal_hps"
        Me.btn_batal_hps.Size = New System.Drawing.Size(100, 26)
        Me.btn_batal_hps.TabIndex = 10
        Me.btn_batal_hps.Text = "Batal"
        Me.btn_batal_hps.UseVisualStyleBackColor = True
        '
        'cb_idProduk
        '
        Me.cb_idProduk.DataSource = Me.BRGBindingSource
        Me.cb_idProduk.DisplayMember = "ID_PRODUK"
        Me.cb_idProduk.FormattingEnabled = True
        Me.cb_idProduk.Location = New System.Drawing.Point(147, 81)
        Me.cb_idProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_idProduk.Name = "cb_idProduk"
        Me.cb_idProduk.Size = New System.Drawing.Size(229, 24)
        Me.cb_idProduk.TabIndex = 7
        '
        'jmlBrgKeluar
        '
        Me.jmlBrgKeluar.Location = New System.Drawing.Point(603, 35)
        Me.jmlBrgKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.jmlBrgKeluar.Name = "jmlBrgKeluar"
        Me.jmlBrgKeluar.Size = New System.Drawing.Size(163, 22)
        Me.jmlBrgKeluar.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(409, 38)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Barang Keluar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 128)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nama Produk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 84)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ID Produk"
        '
        'lvBarangKeluar
        '
        Me.lvBarangKeluar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader12})
        Me.lvBarangKeluar.FullRowSelect = True
        Me.lvBarangKeluar.GridLines = True
        Me.lvBarangKeluar.HideSelection = False
        Me.lvBarangKeluar.Location = New System.Drawing.Point(33, 162)
        Me.lvBarangKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.lvBarangKeluar.Name = "lvBarangKeluar"
        Me.lvBarangKeluar.Size = New System.Drawing.Size(791, 290)
        Me.lvBarangKeluar.TabIndex = 1
        Me.lvBarangKeluar.UseCompatibleStateImageBehavior = False
        Me.lvBarangKeluar.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "NO"
        Me.ColumnHeader6.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tanggal"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID Produk"
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nama Produk"
        Me.ColumnHeader9.Width = 130
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Jumlah Barang Keluar"
        Me.ColumnHeader10.Width = 140
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Keterangan"
        Me.ColumnHeader12.Width = 80
        '
        'BRGTableAdapter
        '
        Me.BRGTableAdapter.ClearBeforeFill = True
        '
        'frmStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 531)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.pnlBrgKeluar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmStok"
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBrgMasuk.ResumeLayout(False)
        Me.pnlBrgMasuk.PerformLayout()
        CType(Me.jmlBrgMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlBrgKeluar.ResumeLayout(False)
        Me.pnlBrgKeluar.PerformLayout()
        CType(Me.jmlBrgKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBrgKeluar As Button
    Friend WithEvents pnlBrgMasuk As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents nmProduk As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnBrgMasuk As Button
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdtProduk As Button
    Friend WithEvents btnUpdtStok As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlBrgKeluar As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSimpan_hps As Button
    Friend WithEvents btn_batal_hps As Button
    Friend WithEvents tb_nmProduk As TextBox
    Friend WithEvents cb_idProduk As ComboBox
    Friend WithEvents jmlBrgKeluar As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lvBarangKeluar As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents jmlBrgMasuk As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_Ket As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker_tambah_stok As DateTimePicker
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BRGBindingSource As BindingSource
    Friend WithEvents BRGTableAdapter As DataSet1TableAdapters.BRGTableAdapter
    Friend WithEvents idProduk As ComboBox
    Friend WithEvents DateTimePicker_hps As DateTimePicker
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents lvBarangMasuk As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader0 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
