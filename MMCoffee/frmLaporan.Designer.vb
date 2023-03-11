<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lv_laporanRobusta = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lv_laporanJahe = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdtProduk = New System.Windows.Forms.Button()
        Me.btnUpdtStok = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jmRobusta = New System.Windows.Forms.TextBox()
        Me.jkRobusta = New System.Windows.Forms.TextBox()
        Me.tsRobusta = New System.Windows.Forms.TextBox()
        Me.tsJahe = New System.Windows.Forms.TextBox()
        Me.jkJahe = New System.Windows.Forms.TextBox()
        Me.jmJahe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlLeftSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lv_laporanRobusta)
        Me.GroupBox1.Location = New System.Drawing.Point(285, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(693, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kopi Robusta"
        '
        'lv_laporanRobusta
        '
        Me.lv_laporanRobusta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader8})
        Me.lv_laporanRobusta.HideSelection = False
        Me.lv_laporanRobusta.Location = New System.Drawing.Point(13, 26)
        Me.lv_laporanRobusta.Margin = New System.Windows.Forms.Padding(2)
        Me.lv_laporanRobusta.Name = "lv_laporanRobusta"
        Me.lv_laporanRobusta.Size = New System.Drawing.Size(673, 133)
        Me.lv_laporanRobusta.TabIndex = 0
        Me.lv_laporanRobusta.UseCompatibleStateImageBehavior = False
        Me.lv_laporanRobusta.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tanggal"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Jumlah Masuk"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah Keluar"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Keterangan"
        Me.ColumnHeader8.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lv_laporanJahe)
        Me.GroupBox2.Location = New System.Drawing.Point(282, 300)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(695, 161)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kopi Jahe"
        '
        'lv_laporanJahe
        '
        Me.lv_laporanJahe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lv_laporanJahe.HideSelection = False
        Me.lv_laporanJahe.Location = New System.Drawing.Point(15, 26)
        Me.lv_laporanJahe.Margin = New System.Windows.Forms.Padding(2)
        Me.lv_laporanJahe.Name = "lv_laporanJahe"
        Me.lv_laporanJahe.Size = New System.Drawing.Size(673, 133)
        Me.lv_laporanJahe.TabIndex = 1
        Me.lv_laporanJahe.UseCompatibleStateImageBehavior = False
        Me.lv_laporanJahe.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No"
        Me.ColumnHeader4.Width = 30
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tanggal"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Jumlah Masuk"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Jumlah Keluar"
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Keterangan"
        Me.ColumnHeader10.Width = 80
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.Controls.Add(Me.btnLogout)
        Me.pnlLeftSide.Controls.Add(Me.btnReport)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtProduk)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtStok)
        Me.pnlLeftSide.Controls.Add(Me.btnBack)
        Me.pnlLeftSide.Location = New System.Drawing.Point(3, 1)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(183, 530)
        Me.pnlLeftSide.TabIndex = 16
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "LAPORAN PENJUALAN MM COFFEE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(790, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Jumlah Masuk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(527, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Jumlah Keluar"
        '
        'jmRobusta
        '
        Me.jmRobusta.Location = New System.Drawing.Point(399, 254)
        Me.jmRobusta.Name = "jmRobusta"
        Me.jmRobusta.ReadOnly = True
        Me.jmRobusta.Size = New System.Drawing.Size(100, 22)
        Me.jmRobusta.TabIndex = 21
        '
        'jkRobusta
        '
        Me.jkRobusta.Location = New System.Drawing.Point(631, 254)
        Me.jkRobusta.Name = "jkRobusta"
        Me.jkRobusta.ReadOnly = True
        Me.jkRobusta.Size = New System.Drawing.Size(100, 22)
        Me.jkRobusta.TabIndex = 22
        '
        'tsRobusta
        '
        Me.tsRobusta.Location = New System.Drawing.Point(868, 254)
        Me.tsRobusta.Name = "tsRobusta"
        Me.tsRobusta.ReadOnly = True
        Me.tsRobusta.Size = New System.Drawing.Size(100, 22)
        Me.tsRobusta.TabIndex = 23
        '
        'tsJahe
        '
        Me.tsJahe.Location = New System.Drawing.Point(868, 477)
        Me.tsJahe.Name = "tsJahe"
        Me.tsJahe.ReadOnly = True
        Me.tsJahe.Size = New System.Drawing.Size(100, 22)
        Me.tsJahe.TabIndex = 29
        '
        'jkJahe
        '
        Me.jkJahe.Location = New System.Drawing.Point(631, 477)
        Me.jkJahe.Name = "jkJahe"
        Me.jkJahe.ReadOnly = True
        Me.jkJahe.Size = New System.Drawing.Size(100, 22)
        Me.jkJahe.TabIndex = 28
        '
        'jmJahe
        '
        Me.jmJahe.Location = New System.Drawing.Point(399, 477)
        Me.jmJahe.Name = "jmJahe"
        Me.jmJahe.ReadOnly = True
        Me.jmJahe.Size = New System.Drawing.Size(100, 22)
        Me.jmJahe.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(527, 480)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Jumlah Keluar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 480)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Jumlah Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(790, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Total Stok"
        '
        'frmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 531)
        Me.Controls.Add(Me.tsJahe)
        Me.Controls.Add(Me.jkJahe)
        Me.Controls.Add(Me.jmJahe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tsRobusta)
        Me.Controls.Add(Me.jkRobusta)
        Me.Controls.Add(Me.jmRobusta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmLaporan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.pnlLeftSide.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lv_laporanRobusta As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lv_laporanJahe As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdtProduk As Button
    Friend WithEvents btnUpdtStok As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents jmRobusta As TextBox
    Friend WithEvents jkRobusta As TextBox
    Friend WithEvents tsRobusta As TextBox
    Friend WithEvents tsJahe As TextBox
    Friend WithEvents jkJahe As TextBox
    Friend WithEvents jmJahe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
