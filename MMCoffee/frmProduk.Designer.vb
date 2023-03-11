<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnHpsProduk = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdtProduk = New System.Windows.Forms.Button()
        Me.btnUpdtStok = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlTbhProduk = New System.Windows.Forms.Panel()
        Me.DateTimePicker_tbhProduk = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_harga_tbh = New System.Windows.Forms.TextBox()
        Me.tb_stok_tbh = New System.Windows.Forms.TextBox()
        Me.tb_nmProduk_tbh = New System.Windows.Forms.TextBox()
        Me.tb_idProduk_tbh = New System.Windows.Forms.TextBox()
        Me.btnLihat_tbh = New System.Windows.Forms.Button()
        Me.btnSimpan_tbh = New System.Windows.Forms.Button()
        Me.btnBatal_tbh = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.btnTbhProduk = New System.Windows.Forms.Button()
        Me.pnlHpsProduk = New System.Windows.Forms.Panel()
        Me.cb_idProduk_hps = New System.Windows.Forms.ComboBox()
        Me.BRGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New MMCoffee.DataSet3()
        Me.DateTimePicker_hps = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_harga_hps = New System.Windows.Forms.TextBox()
        Me.tb_stok_hps = New System.Windows.Forms.TextBox()
        Me.tb_nmProduk_hps = New System.Windows.Forms.TextBox()
        Me.btnLihat_hps = New System.Windows.Forms.Button()
        Me.btnHapus_hps = New System.Windows.Forms.Button()
        Me.btnBatal_hps = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BRGTableAdapter = New MMCoffee.DataSet3TableAdapters.BRGTableAdapter()
        Me.pnlLeftSide.SuspendLayout()
        Me.pnlTbhProduk.SuspendLayout()
        Me.pnlTopSide.SuspendLayout()
        Me.pnlHpsProduk.SuspendLayout()
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHpsProduk
        '
        Me.btnHpsProduk.BackColor = System.Drawing.Color.Transparent
        Me.btnHpsProduk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHpsProduk.FlatAppearance.BorderSize = 0
        Me.btnHpsProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHpsProduk.Location = New System.Drawing.Point(189, 3)
        Me.btnHpsProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHpsProduk.Name = "btnHpsProduk"
        Me.btnHpsProduk.Size = New System.Drawing.Size(181, 38)
        Me.btnHpsProduk.TabIndex = 18
        Me.btnHpsProduk.Text = "Hapus Produk"
        Me.btnHpsProduk.UseVisualStyleBackColor = False
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
        'pnlLeftSide
        '
        Me.pnlLeftSide.Controls.Add(Me.btnLogout)
        Me.pnlLeftSide.Controls.Add(Me.btnReport)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtProduk)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtStok)
        Me.pnlLeftSide.Controls.Add(Me.btnBack)
        Me.pnlLeftSide.Location = New System.Drawing.Point(-1, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(183, 530)
        Me.pnlLeftSide.TabIndex = 34
        '
        'pnlTbhProduk
        '
        Me.pnlTbhProduk.Controls.Add(Me.DateTimePicker_tbhProduk)
        Me.pnlTbhProduk.Controls.Add(Me.Label7)
        Me.pnlTbhProduk.Controls.Add(Me.tb_harga_tbh)
        Me.pnlTbhProduk.Controls.Add(Me.tb_stok_tbh)
        Me.pnlTbhProduk.Controls.Add(Me.tb_nmProduk_tbh)
        Me.pnlTbhProduk.Controls.Add(Me.tb_idProduk_tbh)
        Me.pnlTbhProduk.Controls.Add(Me.btnLihat_tbh)
        Me.pnlTbhProduk.Controls.Add(Me.btnSimpan_tbh)
        Me.pnlTbhProduk.Controls.Add(Me.btnBatal_tbh)
        Me.pnlTbhProduk.Controls.Add(Me.Label8)
        Me.pnlTbhProduk.Controls.Add(Me.Label9)
        Me.pnlTbhProduk.Controls.Add(Me.Label10)
        Me.pnlTbhProduk.Controls.Add(Me.Label11)
        Me.pnlTbhProduk.Controls.Add(Me.Label12)
        Me.pnlTbhProduk.Location = New System.Drawing.Point(186, 49)
        Me.pnlTbhProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTbhProduk.Name = "pnlTbhProduk"
        Me.pnlTbhProduk.Size = New System.Drawing.Size(864, 479)
        Me.pnlTbhProduk.TabIndex = 33
        '
        'DateTimePicker_tbhProduk
        '
        Me.DateTimePicker_tbhProduk.Location = New System.Drawing.Point(359, 145)
        Me.DateTimePicker_tbhProduk.Name = "DateTimePicker_tbhProduk"
        Me.DateTimePicker_tbhProduk.Size = New System.Drawing.Size(235, 22)
        Me.DateTimePicker_tbhProduk.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(259, 58)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(251, 31)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "TAMBAH PRODUK"
        '
        'tb_harga_tbh
        '
        Me.tb_harga_tbh.Location = New System.Drawing.Point(359, 342)
        Me.tb_harga_tbh.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_harga_tbh.Name = "tb_harga_tbh"
        Me.tb_harga_tbh.Size = New System.Drawing.Size(235, 22)
        Me.tb_harga_tbh.TabIndex = 26
        '
        'tb_stok_tbh
        '
        Me.tb_stok_tbh.Location = New System.Drawing.Point(359, 295)
        Me.tb_stok_tbh.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_stok_tbh.Name = "tb_stok_tbh"
        Me.tb_stok_tbh.Size = New System.Drawing.Size(235, 22)
        Me.tb_stok_tbh.TabIndex = 25
        '
        'tb_nmProduk_tbh
        '
        Me.tb_nmProduk_tbh.Location = New System.Drawing.Point(359, 245)
        Me.tb_nmProduk_tbh.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nmProduk_tbh.Name = "tb_nmProduk_tbh"
        Me.tb_nmProduk_tbh.Size = New System.Drawing.Size(235, 22)
        Me.tb_nmProduk_tbh.TabIndex = 24
        '
        'tb_idProduk_tbh
        '
        Me.tb_idProduk_tbh.Location = New System.Drawing.Point(359, 195)
        Me.tb_idProduk_tbh.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_idProduk_tbh.Name = "tb_idProduk_tbh"
        Me.tb_idProduk_tbh.Size = New System.Drawing.Size(235, 22)
        Me.tb_idProduk_tbh.TabIndex = 23
        '
        'btnLihat_tbh
        '
        Me.btnLihat_tbh.Location = New System.Drawing.Point(475, 416)
        Me.btnLihat_tbh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLihat_tbh.Name = "btnLihat_tbh"
        Me.btnLihat_tbh.Size = New System.Drawing.Size(83, 26)
        Me.btnLihat_tbh.TabIndex = 21
        Me.btnLihat_tbh.Text = "Lihat"
        Me.btnLihat_tbh.UseVisualStyleBackColor = True
        '
        'btnSimpan_tbh
        '
        Me.btnSimpan_tbh.Location = New System.Drawing.Point(356, 416)
        Me.btnSimpan_tbh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan_tbh.Name = "btnSimpan_tbh"
        Me.btnSimpan_tbh.Size = New System.Drawing.Size(83, 26)
        Me.btnSimpan_tbh.TabIndex = 20
        Me.btnSimpan_tbh.Text = "Simpan"
        Me.btnSimpan_tbh.UseVisualStyleBackColor = True
        '
        'btnBatal_tbh
        '
        Me.btnBatal_tbh.Location = New System.Drawing.Point(237, 416)
        Me.btnBatal_tbh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal_tbh.Name = "btnBatal_tbh"
        Me.btnBatal_tbh.Size = New System.Drawing.Size(83, 26)
        Me.btnBatal_tbh.TabIndex = 19
        Me.btnBatal_tbh.Text = "Batal"
        Me.btnBatal_tbh.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 346)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Harga Satuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 299)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Stok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(202, 249)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Nama Produk"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 198)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "ID Produk"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(202, 149)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Tanggal"
        '
        'pnlTopSide
        '
        Me.pnlTopSide.Controls.Add(Me.btnHpsProduk)
        Me.pnlTopSide.Controls.Add(Me.btnTbhProduk)
        Me.pnlTopSide.Location = New System.Drawing.Point(189, 4)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(861, 42)
        Me.pnlTopSide.TabIndex = 35
        '
        'btnTbhProduk
        '
        Me.btnTbhProduk.BackColor = System.Drawing.Color.Transparent
        Me.btnTbhProduk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTbhProduk.FlatAppearance.BorderSize = 0
        Me.btnTbhProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTbhProduk.Location = New System.Drawing.Point(5, 2)
        Me.btnTbhProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTbhProduk.Name = "btnTbhProduk"
        Me.btnTbhProduk.Size = New System.Drawing.Size(181, 38)
        Me.btnTbhProduk.TabIndex = 17
        Me.btnTbhProduk.Text = "Tambah Produk"
        Me.btnTbhProduk.UseVisualStyleBackColor = False
        '
        'pnlHpsProduk
        '
        Me.pnlHpsProduk.Controls.Add(Me.cb_idProduk_hps)
        Me.pnlHpsProduk.Controls.Add(Me.DateTimePicker_hps)
        Me.pnlHpsProduk.Controls.Add(Me.Label1)
        Me.pnlHpsProduk.Controls.Add(Me.tb_harga_hps)
        Me.pnlHpsProduk.Controls.Add(Me.tb_stok_hps)
        Me.pnlHpsProduk.Controls.Add(Me.tb_nmProduk_hps)
        Me.pnlHpsProduk.Controls.Add(Me.btnLihat_hps)
        Me.pnlHpsProduk.Controls.Add(Me.btnHapus_hps)
        Me.pnlHpsProduk.Controls.Add(Me.btnBatal_hps)
        Me.pnlHpsProduk.Controls.Add(Me.Label2)
        Me.pnlHpsProduk.Controls.Add(Me.Label3)
        Me.pnlHpsProduk.Controls.Add(Me.Label4)
        Me.pnlHpsProduk.Controls.Add(Me.Label5)
        Me.pnlHpsProduk.Controls.Add(Me.Label6)
        Me.pnlHpsProduk.Location = New System.Drawing.Point(186, 49)
        Me.pnlHpsProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHpsProduk.Name = "pnlHpsProduk"
        Me.pnlHpsProduk.Size = New System.Drawing.Size(864, 479)
        Me.pnlHpsProduk.TabIndex = 34
        '
        'cb_idProduk_hps
        '
        Me.cb_idProduk_hps.DataSource = Me.BRGBindingSource
        Me.cb_idProduk_hps.DisplayMember = "ID_PRODUK"
        Me.cb_idProduk_hps.FormattingEnabled = True
        Me.cb_idProduk_hps.Location = New System.Drawing.Point(359, 195)
        Me.cb_idProduk_hps.Name = "cb_idProduk_hps"
        Me.cb_idProduk_hps.Size = New System.Drawing.Size(235, 24)
        Me.cb_idProduk_hps.TabIndex = 29
        '
        'BRGBindingSource
        '
        Me.BRGBindingSource.DataMember = "BRG"
        Me.BRGBindingSource.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker_hps
        '
        Me.DateTimePicker_hps.Location = New System.Drawing.Point(359, 145)
        Me.DateTimePicker_hps.Name = "DateTimePicker_hps"
        Me.DateTimePicker_hps.Size = New System.Drawing.Size(235, 22)
        Me.DateTimePicker_hps.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "HAPUS PRODUK"
        '
        'tb_harga_hps
        '
        Me.tb_harga_hps.Location = New System.Drawing.Point(359, 296)
        Me.tb_harga_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_harga_hps.Name = "tb_harga_hps"
        Me.tb_harga_hps.Size = New System.Drawing.Size(235, 22)
        Me.tb_harga_hps.TabIndex = 26
        '
        'tb_stok_hps
        '
        Me.tb_stok_hps.Location = New System.Drawing.Point(359, 346)
        Me.tb_stok_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_stok_hps.Name = "tb_stok_hps"
        Me.tb_stok_hps.Size = New System.Drawing.Size(235, 22)
        Me.tb_stok_hps.TabIndex = 25
        '
        'tb_nmProduk_hps
        '
        Me.tb_nmProduk_hps.Location = New System.Drawing.Point(359, 245)
        Me.tb_nmProduk_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nmProduk_hps.Name = "tb_nmProduk_hps"
        Me.tb_nmProduk_hps.Size = New System.Drawing.Size(235, 22)
        Me.tb_nmProduk_hps.TabIndex = 24
        '
        'btnLihat_hps
        '
        Me.btnLihat_hps.Location = New System.Drawing.Point(475, 405)
        Me.btnLihat_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLihat_hps.Name = "btnLihat_hps"
        Me.btnLihat_hps.Size = New System.Drawing.Size(83, 26)
        Me.btnLihat_hps.TabIndex = 21
        Me.btnLihat_hps.Text = "Lihat"
        Me.btnLihat_hps.UseVisualStyleBackColor = True
        '
        'btnHapus_hps
        '
        Me.btnHapus_hps.Location = New System.Drawing.Point(356, 405)
        Me.btnHapus_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus_hps.Name = "btnHapus_hps"
        Me.btnHapus_hps.Size = New System.Drawing.Size(83, 26)
        Me.btnHapus_hps.TabIndex = 20
        Me.btnHapus_hps.Text = "Hapus"
        Me.btnHapus_hps.UseVisualStyleBackColor = True
        '
        'btnBatal_hps
        '
        Me.btnBatal_hps.Location = New System.Drawing.Point(237, 405)
        Me.btnBatal_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal_hps.Name = "btnBatal_hps"
        Me.btnBatal_hps.Size = New System.Drawing.Size(83, 26)
        Me.btnBatal_hps.TabIndex = 19
        Me.btnBatal_hps.Text = "Batal"
        Me.btnBatal_hps.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 300)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 350)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 249)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nama Produk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 198)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ID Produk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tanggal"
        '
        'BRGTableAdapter
        '
        Me.BRGTableAdapter.ClearBeforeFill = True
        '
        'frmProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 531)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlHpsProduk)
        Me.Controls.Add(Me.pnlTbhProduk)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmProduk"
        Me.Text = "Form1"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlTbhProduk.ResumeLayout(False)
        Me.pnlTbhProduk.PerformLayout()
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlHpsProduk.ResumeLayout(False)
        Me.pnlHpsProduk.PerformLayout()
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHpsProduk As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdtProduk As Button
    Friend WithEvents btnUpdtStok As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlTbhProduk As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_harga_tbh As TextBox
    Friend WithEvents tb_stok_tbh As TextBox
    Friend WithEvents tb_nmProduk_tbh As TextBox
    Friend WithEvents tb_idProduk_tbh As TextBox
    Friend WithEvents btnLihat_tbh As Button
    Friend WithEvents btnSimpan_tbh As Button
    Friend WithEvents btnBatal_tbh As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnTbhProduk As Button
    Friend WithEvents pnlHpsProduk As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_harga_hps As TextBox
    Friend WithEvents tb_stok_hps As TextBox
    Friend WithEvents tb_nmProduk_hps As TextBox
    Friend WithEvents btnLihat_hps As Button
    Friend WithEvents btnHapus_hps As Button
    Friend WithEvents btnBatal_hps As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker_tbhProduk As DateTimePicker
    Friend WithEvents cb_idProduk_hps As ComboBox
    Friend WithEvents DateTimePicker_hps As DateTimePicker
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents BRGBindingSource As BindingSource
    Friend WithEvents BRGTableAdapter As DataSet3TableAdapters.BRGTableAdapter
End Class
