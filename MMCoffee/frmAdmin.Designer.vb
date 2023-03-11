<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_tanggal = New System.Windows.Forms.Label()
        Me.Label_waktu = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.Transparent
        Me.pnlAdmin.Controls.Add(Me.Label_waktu)
        Me.pnlAdmin.Controls.Add(Me.Label_tanggal)
        Me.pnlAdmin.Controls.Add(Me.Label5)
        Me.pnlAdmin.Controls.Add(Me.btnBack)
        Me.pnlAdmin.Controls.Add(Me.Label4)
        Me.pnlAdmin.Controls.Add(Me.Label1)
        Me.pnlAdmin.Controls.Add(Me.btnLogout)
        Me.pnlAdmin.Controls.Add(Me.Label3)
        Me.pnlAdmin.Controls.Add(Me.btnStock)
        Me.pnlAdmin.Controls.Add(Me.btnProduct)
        Me.pnlAdmin.Controls.Add(Me.btnReport)
        Me.pnlAdmin.Controls.Add(Me.Label2)
        Me.pnlAdmin.Location = New System.Drawing.Point(1, 0)
        Me.pnlAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(1049, 530)
        Me.pnlAdmin.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ADMIN"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.MMCoffee.My.Resources.Resources.previous
        Me.btnBack.Location = New System.Drawing.Point(7, 7)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 47)
        Me.btnBack.TabIndex = 2
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(757, 340)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 340)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Update Stock"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = Global.MMCoffee.My.Resources.Resources.logout1
        Me.btnLogout.Location = New System.Drawing.Point(706, 212)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(151, 112)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(591, 340)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Report"
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Image = Global.MMCoffee.My.Resources.Resources.inventory1
        Me.btnStock.Location = New System.Drawing.Point(192, 212)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(151, 112)
        Me.btnStock.TabIndex = 0
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Image = Global.MMCoffee.My.Resources.Resources.coffee_bean1
        Me.btnProduct.Location = New System.Drawing.Point(365, 212)
        Me.btnProduct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(151, 112)
        Me.btnProduct.TabIndex = 0
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Image = Global.MMCoffee.My.Resources.Resources.business_report1
        Me.btnReport.Location = New System.Drawing.Point(537, 212)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(151, 112)
        Me.btnReport.TabIndex = 0
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 340)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Update Product"
        '
        'Label_tanggal
        '
        Me.Label_tanggal.AutoSize = True
        Me.Label_tanggal.Location = New System.Drawing.Point(449, 155)
        Me.Label_tanggal.Name = "Label_tanggal"
        Me.Label_tanggal.Size = New System.Drawing.Size(165, 17)
        Me.Label_tanggal.TabIndex = 9
        Me.Label_tanggal.Text = "1 May 2019, Wednesday"
        '
        'Label_waktu
        '
        Me.Label_waktu.AutoSize = True
        Me.Label_waktu.Location = New System.Drawing.Point(484, 181)
        Me.Label_waktu.Name = "Label_waktu"
        Me.Label_waktu.Size = New System.Drawing.Size(88, 17)
        Me.Label_waktu.TabIndex = 10
        Me.Label_waktu.Text = "12:00:00 AM"
        '
        'Timer1
        '
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(1049, 531)
        Me.Controls.Add(Me.pnlAdmin)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAdmin"
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStock As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProduct As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_waktu As Label
    Friend WithEvents Label_tanggal As Label
    Friend WithEvents Timer1 As Timer
End Class
