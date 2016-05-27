<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Termin
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvIrr = New System.Windows.Forms.DataGridView()
        Me.txtCabang = New DevExpress.XtraEditors.TextEdit()
        Me.txtTahun = New DevExpress.XtraEditors.TextEdit()
        Me.txtjenisTrans = New DevExpress.XtraEditors.TextEdit()
        Me.txtTermin = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPelanggan = New DevExpress.XtraEditors.TextEdit()
        Me.txtKodeTrans = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblSiswa = New System.Windows.Forms.Label()
        Me.lblRe = New System.Windows.Forms.Label()
        Me.lblHp = New System.Windows.Forms.Label()
        Me.lblRabat = New System.Windows.Forms.Label()
        Me.lblretur = New System.Windows.Forms.Label()
        Me.lblHpp = New System.Windows.Forms.Label()
        Me.lblRoyalti = New System.Windows.Forms.Label()
        Me.lblkomisi = New System.Windows.Forms.Label()
        Me.lblTaktis = New System.Windows.Forms.Label()
        Me.lblOperasional = New System.Windows.Forms.Label()
        Me.lblPajak = New System.Windows.Forms.Label()
        Me.lblAwal = New System.Windows.Forms.Label()
        Me.lblakhir = New System.Windows.Forms.Label()
        Me.lblDp = New System.Windows.Forms.Label()
        Me.lblHretur = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvIrr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCabang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtjenisTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPelanggan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TabControl1)
        Me.GroupControl1.Controls.Add(Me.txtCabang)
        Me.GroupControl1.Controls.Add(Me.txtTahun)
        Me.GroupControl1.Controls.Add(Me.txtjenisTrans)
        Me.GroupControl1.Controls.Add(Me.txtTermin)
        Me.GroupControl1.Controls.Add(Me.TxtPelanggan)
        Me.GroupControl1.Controls.Add(Me.txtKodeTrans)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(850, 489)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Detail Pembayaran Termin"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(837, 404)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(829, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Analisis Data "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(820, 369)
        Me.DataGridView1.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvIrr)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(829, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "NPV & IRR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvIrr
        '
        Me.dgvIrr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIrr.Location = New System.Drawing.Point(3, 6)
        Me.dgvIrr.Name = "dgvIrr"
        Me.dgvIrr.Size = New System.Drawing.Size(820, 366)
        Me.dgvIrr.TabIndex = 0
        '
        'txtCabang
        '
        Me.txtCabang.Enabled = False
        Me.txtCabang.Location = New System.Drawing.Point(90, 61)
        Me.txtCabang.Name = "txtCabang"
        Me.txtCabang.Size = New System.Drawing.Size(141, 20)
        Me.txtCabang.TabIndex = 11
        '
        'txtTahun
        '
        Me.txtTahun.Enabled = False
        Me.txtTahun.Location = New System.Drawing.Point(341, 61)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(76, 20)
        Me.txtTahun.TabIndex = 10
        '
        'txtjenisTrans
        '
        Me.txtjenisTrans.Enabled = False
        Me.txtjenisTrans.Location = New System.Drawing.Point(584, 61)
        Me.txtjenisTrans.Name = "txtjenisTrans"
        Me.txtjenisTrans.Size = New System.Drawing.Size(88, 20)
        Me.txtjenisTrans.TabIndex = 9
        '
        'txtTermin
        '
        Me.txtTermin.Enabled = False
        Me.txtTermin.Location = New System.Drawing.Point(584, 30)
        Me.txtTermin.Name = "txtTermin"
        Me.txtTermin.Size = New System.Drawing.Size(88, 20)
        Me.txtTermin.TabIndex = 8
        '
        'TxtPelanggan
        '
        Me.TxtPelanggan.Enabled = False
        Me.TxtPelanggan.Location = New System.Drawing.Point(341, 30)
        Me.TxtPelanggan.Name = "TxtPelanggan"
        Me.TxtPelanggan.Size = New System.Drawing.Size(141, 20)
        Me.TxtPelanggan.TabIndex = 7
        '
        'txtKodeTrans
        '
        Me.txtKodeTrans.Enabled = False
        Me.txtKodeTrans.Location = New System.Drawing.Point(90, 30)
        Me.txtKodeTrans.Name = "txtKodeTrans"
        Me.txtKodeTrans.Size = New System.Drawing.Size(141, 20)
        Me.txtKodeTrans.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(503, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "&Jenis Transaksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Tahun Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Cabang "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Jumlah Termin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Kode Transaksi"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(722, 494)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(128, 23)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "&Export To Excel"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(643, 495)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&<< Back"
        Me.SimpleButton1.Visible = False
        '
        'lblSiswa
        '
        Me.lblSiswa.AutoSize = True
        Me.lblSiswa.Location = New System.Drawing.Point(23, 500)
        Me.lblSiswa.Name = "lblSiswa"
        Me.lblSiswa.Size = New System.Drawing.Size(33, 13)
        Me.lblSiswa.TabIndex = 3
        Me.lblSiswa.Text = "siswa"
        Me.lblSiswa.Visible = False
        '
        'lblRe
        '
        Me.lblRe.AutoSize = True
        Me.lblRe.Location = New System.Drawing.Point(58, 500)
        Me.lblRe.Name = "lblRe"
        Me.lblRe.Size = New System.Drawing.Size(36, 13)
        Me.lblRe.TabIndex = 4
        Me.lblRe.Text = "Rata2"
        Me.lblRe.Visible = False
        '
        'lblHp
        '
        Me.lblHp.AutoSize = True
        Me.lblHp.Location = New System.Drawing.Point(100, 500)
        Me.lblHp.Name = "lblHp"
        Me.lblHp.Size = New System.Drawing.Size(22, 13)
        Me.lblHp.TabIndex = 5
        Me.lblHp.Text = "HP"
        Me.lblHp.Visible = False
        '
        'lblRabat
        '
        Me.lblRabat.AutoSize = True
        Me.lblRabat.Location = New System.Drawing.Point(128, 500)
        Me.lblRabat.Name = "lblRabat"
        Me.lblRabat.Size = New System.Drawing.Size(31, 13)
        Me.lblRabat.TabIndex = 6
        Me.lblRabat.Text = "rabat"
        Me.lblRabat.Visible = False
        '
        'lblretur
        '
        Me.lblretur.AutoSize = True
        Me.lblretur.Location = New System.Drawing.Point(165, 500)
        Me.lblretur.Name = "lblretur"
        Me.lblretur.Size = New System.Drawing.Size(28, 13)
        Me.lblretur.TabIndex = 7
        Me.lblretur.Text = "retur"
        Me.lblretur.Visible = False
        '
        'lblHpp
        '
        Me.lblHpp.AutoSize = True
        Me.lblHpp.Location = New System.Drawing.Point(199, 500)
        Me.lblHpp.Name = "lblHpp"
        Me.lblHpp.Size = New System.Drawing.Size(27, 13)
        Me.lblHpp.TabIndex = 8
        Me.lblHpp.Text = "Hpp"
        Me.lblHpp.Visible = False
        '
        'lblRoyalti
        '
        Me.lblRoyalti.AutoSize = True
        Me.lblRoyalti.Location = New System.Drawing.Point(232, 500)
        Me.lblRoyalti.Name = "lblRoyalti"
        Me.lblRoyalti.Size = New System.Drawing.Size(39, 13)
        Me.lblRoyalti.TabIndex = 9
        Me.lblRoyalti.Text = "Royalti"
        Me.lblRoyalti.Visible = False
        '
        'lblkomisi
        '
        Me.lblkomisi.AutoSize = True
        Me.lblkomisi.Location = New System.Drawing.Point(277, 500)
        Me.lblkomisi.Name = "lblkomisi"
        Me.lblkomisi.Size = New System.Drawing.Size(36, 13)
        Me.lblkomisi.TabIndex = 10
        Me.lblkomisi.Text = "komisi"
        Me.lblkomisi.Visible = False
        '
        'lblTaktis
        '
        Me.lblTaktis.AutoSize = True
        Me.lblTaktis.Location = New System.Drawing.Point(319, 500)
        Me.lblTaktis.Name = "lblTaktis"
        Me.lblTaktis.Size = New System.Drawing.Size(36, 13)
        Me.lblTaktis.TabIndex = 11
        Me.lblTaktis.Text = "Taktis"
        Me.lblTaktis.Visible = False
        '
        'lblOperasional
        '
        Me.lblOperasional.AutoSize = True
        Me.lblOperasional.Location = New System.Drawing.Point(361, 500)
        Me.lblOperasional.Name = "lblOperasional"
        Me.lblOperasional.Size = New System.Drawing.Size(63, 13)
        Me.lblOperasional.TabIndex = 12
        Me.lblOperasional.Text = "Operasional"
        Me.lblOperasional.Visible = False
        '
        'lblPajak
        '
        Me.lblPajak.AutoSize = True
        Me.lblPajak.Location = New System.Drawing.Point(430, 500)
        Me.lblPajak.Name = "lblPajak"
        Me.lblPajak.Size = New System.Drawing.Size(34, 13)
        Me.lblPajak.TabIndex = 13
        Me.lblPajak.Text = "Pajak"
        Me.lblPajak.Visible = False
        '
        'lblAwal
        '
        Me.lblAwal.AutoSize = True
        Me.lblAwal.Location = New System.Drawing.Point(470, 500)
        Me.lblAwal.Name = "lblAwal"
        Me.lblAwal.Size = New System.Drawing.Size(32, 13)
        Me.lblAwal.TabIndex = 14
        Me.lblAwal.Text = "tawal"
        Me.lblAwal.Visible = False
        '
        'lblakhir
        '
        Me.lblakhir.AutoSize = True
        Me.lblakhir.Location = New System.Drawing.Point(503, 500)
        Me.lblakhir.Name = "lblakhir"
        Me.lblakhir.Size = New System.Drawing.Size(33, 13)
        Me.lblakhir.TabIndex = 15
        Me.lblakhir.Text = "takhir"
        Me.lblakhir.Visible = False
        '
        'lblDp
        '
        Me.lblDp.AutoSize = True
        Me.lblDp.Location = New System.Drawing.Point(595, 499)
        Me.lblDp.Name = "lblDp"
        Me.lblDp.Size = New System.Drawing.Size(21, 13)
        Me.lblDp.TabIndex = 16
        Me.lblDp.Text = "Dp"
        Me.lblDp.Visible = False
        '
        'lblHretur
        '
        Me.lblHretur.AutoSize = True
        Me.lblHretur.Location = New System.Drawing.Point(557, 499)
        Me.lblHretur.Name = "lblHretur"
        Me.lblHretur.Size = New System.Drawing.Size(54, 13)
        Me.lblHretur.TabIndex = 17
        Me.lblHretur.Text = "returHope"
        Me.lblHretur.Visible = False
        '
        'Termin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 530)
        Me.Controls.Add(Me.lblHretur)
        Me.Controls.Add(Me.lblDp)
        Me.Controls.Add(Me.lblakhir)
        Me.Controls.Add(Me.lblAwal)
        Me.Controls.Add(Me.lblPajak)
        Me.Controls.Add(Me.lblOperasional)
        Me.Controls.Add(Me.lblTaktis)
        Me.Controls.Add(Me.lblkomisi)
        Me.Controls.Add(Me.lblRoyalti)
        Me.Controls.Add(Me.lblHpp)
        Me.Controls.Add(Me.lblretur)
        Me.Controls.Add(Me.lblRabat)
        Me.Controls.Add(Me.lblHp)
        Me.Controls.Add(Me.lblRe)
        Me.Controls.Add(Me.lblSiswa)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "Termin"
        Me.Text = "Termin"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvIrr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCabang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtjenisTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTermin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPelanggan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCabang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTahun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtjenisTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTermin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPelanggan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKodeTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSiswa As Label
    Friend WithEvents lblRe As Label
    Friend WithEvents lblHp As Label
    Friend WithEvents lblRabat As Label
    Friend WithEvents lblretur As Label
    Friend WithEvents lblHpp As Label
    Friend WithEvents lblRoyalti As Label
    Friend WithEvents lblkomisi As Label
    Friend WithEvents lblTaktis As Label
    Friend WithEvents lblOperasional As Label
    Friend WithEvents lblPajak As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvIrr As DataGridView
    Friend WithEvents lblAwal As Label
    Friend WithEvents lblakhir As Label
    Friend WithEvents lblDp As Label
    Friend WithEvents lblHretur As Label
End Class
