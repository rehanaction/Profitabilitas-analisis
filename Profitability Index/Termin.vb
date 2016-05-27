Imports Microsoft.VisualBasic.Financial
Imports Microsoft.Office.Interop
Imports System.Math
Imports System.Drawing
Imports Spire.Xls
Imports Exalt = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Public Class Termin
    Dim dt As New DataTable
    Private Sub Termin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mergerHeader()
        analisis()
        IRRkolom()
        getDataPelanggan(TxtPelanggan.Text)
        getDataCabang(txtCabang.Text)
    End Sub
    Public Sub getDataPelanggan(ByVal pk As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select nama from customer where kode=" & pk & "", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TxtPelanggan.Text = RD.Item(0)
        End If
        conn.Close()
    End Sub
    Public Sub getDataCabang(ByVal pk As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select nama from cabang where kode=" & pk & "", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txtCabang.Text = RD.Item(0)
        End If
        conn.Close()
    End Sub

    Sub analisis()
        Dim taktis As Double = lblTaktis.Text
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(0).Cells(0).Value = "ANALISIS LABA KOMERSIAL:"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(1).Cells(0).Value = "PENJUALAN (J*K*L):"
        DataGridView1.Rows.Item(1).Cells(3).Value = Penjualan()
        DataGridView1.Rows.Item(1).Cells(6).Value = Penjualan()
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(2).Cells(0).Value = "DISKON "
        DataGridView1.Rows.Item(2).Cells(1).Value = lblRabat.Text & "%"
        DataGridView1.Rows.Item(2).Cells(3).Value = DataGridView1.Rows.Item(1).Cells(3).Value * (lblRabat.Text / 100)
        DataGridView1.Rows.Item(2).Cells(6).Value = DataGridView1.Rows.Item(1).Cells(3).Value * (lblRabat.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(3).Cells(0).Value = "  PENJUALAN KOTOR"
        DataGridView1.Rows.Item(3).Cells(3).Value = DataGridView1.Rows.Item(1).Cells(3).Value - DataGridView1.Rows.Item(2).Cells(3).Value
        DataGridView1.Rows.Item(3).Cells(6).Value = DataGridView1.Rows.Item(1).Cells(3).Value - DataGridView1.Rows.Item(2).Cells(3).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(4).Cells(0).Value = "RETUR"
        DataGridView1.Rows.Item(4).Cells(1).Value = lblretur.Text & "%"
        DataGridView1.Rows.Item(4).Cells(3).Value = DataGridView1.Rows.Item(3).Cells(3).Value * (lblretur.Text / 100)
        DataGridView1.Rows.Item(4).Cells(6).Value = DataGridView1.Rows.Item(3).Cells(3).Value * (lblretur.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(5).Cells(0).Value = "  PENJUALAN BERSIH"
        DataGridView1.Rows.Item(5).Cells(4).Value = DataGridView1.Rows.Item(3).Cells(3).Value - DataGridView1.Rows.Item(4).Cells(3).Value
        DataGridView1.Rows.Item(5).Cells(7).Value = DataGridView1.Rows.Item(3).Cells(3).Value - DataGridView1.Rows.Item(4).Cells(3).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(6).Cells(0).Value = "  HPP "
        DataGridView1.Rows.Item(6).Cells(1).Value = lblHpp.Text & "%"
        DataGridView1.Rows.Item(6).Cells(3).Value = DataGridView1.Rows.Item(1).Cells(3).Value * (lblHpp.Text / 100)
        DataGridView1.Rows.Item(6).Cells(6).Value = DataGridView1.Rows.Item(1).Cells(3).Value * (lblHpp.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(7).Cells(0).Value = "ROYALTI"
        DataGridView1.Rows.Item(7).Cells(1).Value = lblRoyalti.Text & "%"
        DataGridView1.Rows.Item(7).Cells(3).Value = DataGridView1.Rows.Item(1).Cells(3).Value * (lblRoyalti.Text / 100)
        DataGridView1.Rows.Item(7).Cells(6).Value = DataGridView1.Rows.Item(1).Cells(3).Value * (lblRoyalti.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(8).Cells(0).Value = "KOMISI PENJUALAN"
        DataGridView1.Rows.Item(8).Cells(1).Value = lblkomisi.Text & "%"
        DataGridView1.Rows.Item(8).Cells(3).Value = DataGridView1.Rows.Item(5).Cells(4).Value * (lblkomisi.Text / 100)
        DataGridView1.Rows.Item(8).Cells(6).Value = DataGridView1.Rows.Item(5).Cells(4).Value * (lblkomisi.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(9).Cells(0).Value = "BEBAN LAIN-LAIN"
        DataGridView1.Rows.Item(9).Cells(4).Value = DataGridView1.Rows.Item(6).Cells(3).Value + DataGridView1.Rows.Item(7).Cells(3).Value + DataGridView1.Rows.Item(8).Cells(3).Value
        DataGridView1.Rows.Item(9).Cells(7).Value = DataGridView1.Rows.Item(6).Cells(3).Value + DataGridView1.Rows.Item(7).Cells(3).Value + DataGridView1.Rows.Item(8).Cells(3).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(10).Cells(0).Value = "LABA KOTOR"
        DataGridView1.Rows.Item(10).Cells(4).Value = DataGridView1.Rows.Item(5).Cells(4).Value - DataGridView1.Rows.Item(9).Cells(4).Value
        DataGridView1.Rows.Item(10).Cells(7).Value = DataGridView1.Rows.Item(5).Cells(4).Value - DataGridView1.Rows.Item(9).Cells(4).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(12).Cells(0).Value = "DANA TAKTIS/MARKETING"
        DataGridView1.Rows.Item(12).Cells(3).Value = taktis
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(13).Cells(0).Value = "BEBAN OPERASIONAL CABANG"
        DataGridView1.Rows.Item(13).Cells(1).Value = lblOperasional.Text & "%"
        DataGridView1.Rows.Item(13).Cells(3).Value = DataGridView1.Rows.Item(5).Cells(4).Value * (lblOperasional.Text / 100)
        DataGridView1.Rows.Item(13).Cells(6).Value = DataGridView1.Rows.Item(5).Cells(4).Value * (lblOperasional.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(14).Cells(0).Value = "TOTAL BIAYA"
        DataGridView1.Rows.Item(14).Cells(4).Value = DataGridView1.Rows.Item(13).Cells(3).Value + DataGridView1.Rows.Item(12).Cells(3).Value
        DataGridView1.Rows.Item(14).Cells(7).Value = DataGridView1.Rows.Item(13).Cells(6).Value + DataGridView1.Rows.Item(12).Cells(6).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(15).Cells(0).Value = "LABA SEBELUM PAJAK"
        DataGridView1.Rows.Item(15).Cells(4).Value = DataGridView1.Rows.Item(10).Cells(4).Value - DataGridView1.Rows.Item(14).Cells(4).Value
        DataGridView1.Rows.Item(15).Cells(7).Value = DataGridView1.Rows.Item(10).Cells(7).Value - DataGridView1.Rows.Item(14).Cells(7).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(16).Cells(0).Value = "PAJAK PENGHASILAN - KOMERSIAL"
        DataGridView1.Rows.Item(16).Cells(1).Value = lblPajak.Text & "%"
        DataGridView1.Rows.Item(16).Cells(4).Value = DataGridView1.Rows.Item(15).Cells(4).Value * (lblPajak.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(17).Cells(0).Value = "KONTRIBUSI TERHADAP BIAYA OPERASIONAL"
        DataGridView1.Rows.Item(17).Cells(4).Value = DataGridView1.Rows.Item(15).Cells(4).Value - DataGridView1.Rows.Item(16).Cells(4).Value
        DataGridView1.Rows.Item(17).Cells(5).Value = FormatNumber((DataGridView1.Rows.Item(17).Cells(4).Value / DataGridView1.Rows.Item(1).Cells(3).Value) * 100, 1) & "%"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(19).Cells(0).Value = "ANALISIS LABA FISKAL:"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(20).Cells(0).Value = "PAJAK PENGHASILAN - FISKAL"
        DataGridView1.Rows.Item(20).Cells(7).Value = DataGridView1.Rows.Item(15).Cells(7).Value * (lblPajak.Text / 100)
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(21).Cells(0).Value = "LABA (RUGI) BERSIH FISKAL SETELAH PAJAK"
        DataGridView1.Rows.Item(21).Cells(7).Value = DataGridView1.Rows.Item(15).Cells(7).Value - DataGridView1.Rows.Item(20).Cells(7).Value
        DataGridView1.Rows.Item(21).Cells(8).Value = FormatNumber((DataGridView1.Rows.Item(21).Cells(7).Value / DataGridView1.Rows.Item(1).Cells(6).Value) * 100, 1) & "%"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(22).Cells(0).Value = "IMPLIKASI PENERAPAN PPH FISKAL TERHADAP LABA KOMERSIAL:"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(23).Cells(0).Value = "LABA SEBELUM PAJAK (KOMERSIAL)"
        DataGridView1.Rows.Item(23).Cells(4).Value = DataGridView1.Rows.Item(15).Cells(4).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(24).Cells(0).Value = "PPH TERUTANG (FISKAL)"
        DataGridView1.Rows.Item(24).Cells(4).Value = DataGridView1.Rows.Item(20).Cells(7).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(25).Cells(0).Value = "LABA (RUGI) BERSIH SETELAH PAJAK"
        DataGridView1.Rows.Item(25).Cells(4).Value = DataGridView1.Rows.Item(23).Cells(4).Value - DataGridView1.Rows.Item(20).Cells(7).Value
        DataGridView1.Rows.Item(25).Cells(5).Value = FormatNumber((DataGridView1.Rows.Item(25).Cells(4).Value / DataGridView1.Rows.Item(1).Cells(6).Value) * 100, 1) & "%"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(28).Cells(0).Value = "Penjualan Netto Minimum"
        DataGridView1.Rows.Item(28).Cells(3).Value = DataGridView1.Rows.Item(3).Cells(3).Value
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(29).Cells(0).Value = "Minimum yang Ditagihkan"
        DataGridView1.Rows.Item(29).Cells(3).Value = DataGridView1.Rows.Item(5).Cells(4).Value + Replace(lblDp.Text, ".", "")
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(30).Cells(0).Value = "NPV"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(31).Cells(0).Value = "Tingkat Pengembalian yang Diharapkan"
        DataGridView1.Rows.Item(31).Cells(3).Value = lblHretur.Text & "%"
        DataGridView1.Rows.Add(New String() {"", ""})
        DataGridView1.Rows.Item(32).Cells(0).Value = "IRR"

    End Sub
    Function hitungpenjualan(ByVal js As DevExpress.XtraEditors.TextEdit)
        Return (js.Text)
    End Function
    Public Sub IRRkolom()
        Dim dp, total As Double
        Dim netval As Decimal
        dp = Replace(lblDp.Text, ".", "")
        total = DataGridView1.Rows.Item(6).Cells(3).Value + DataGridView1.Rows.Item(7).Cells(3).Value + DataGridView1.Rows.Item(8).Cells(3).Value + DataGridView1.Rows.Item(12).Cells(3).Value + DataGridView1.Rows.Item(13).Cells(3).Value + DataGridView1.Rows.Item(20).Cells(7).Value + dp
        dgvIrr.Rows.Item(0).Cells(0).Value = "TOTAL INVESTASI"
        dgvIrr.Rows.Item(0).Cells(1).Value = (-total)
        dgvIrr.Columns(1).DefaultCellStyle.Format = "c"
        dgvIrr.Columns(2).DefaultCellStyle.Format = "c"
        dgvIrr.Columns(3).DefaultCellStyle.Format = "c"
        Dim akhir As Integer = dgvIrr.RowCount - 2
        dgvIrr.Rows.Item(akhir).Cells(0).Value = "Cashflow"
        dgvIrr.Rows(akhir).Cells(1).Value = 0
        dgvIrr.Rows(akhir).Cells(1).Value += dgvIrr.Rows(0).Cells(1).Value
        Dim arr As Integer = dgvIrr.ColumnCount - 1
        Dim values(dgvIrr.ColumnCount - 1) As Double
        For i As Integer = 0 To dgvIrr.ColumnCount - 2
            values(i) = dgvIrr.Rows(akhir).Cells(i + 1).Value
        Next
        Dim MoneyFmt As String = "###,##0.00"
        ' Define percentage format. 
        Dim PercentFmt As String = "#0.00"
        Dim rate As Decimal = Int(lblHretur.Text) / 100
        Dim Guess As Double = 0.1
        ' Calculate internal rate. 
        Dim CalcRetRate As Double = IRR(values, Guess) * 100
        netval = NPV(rate, values)
        DataGridView1.Rows.Item(30).Cells(3).Value = Round(netval)
        DataGridView1.Rows.Item(32).Cells(3).Value = Format(CalcRetRate, PercentFmt) & "%"
        'dgvIrr.Rows(akhir - 1).Cells(1).Value = netval
        'dgvIrr.Rows(akhir - 1).Cells(2).Value = Format(CalcRetRate, PercentFmt)
    End Sub
    Public Sub mergerHeader()
        Me.DataGridView1.Columns.Add("JanWin", "Keterangan")
        Me.DataGridView1.Columns.Add("JanLoss", "%")
        Me.DataGridView1.Columns.Add("JanLoss", "")
        Me.DataGridView1.Columns.Add("FebWin", "")
        Me.DataGridView1.Columns.Add("FebLoss", "")
        Me.DataGridView1.Columns.Add("FebLoss2", "")
        Me.DataGridView1.Columns.Add("MarWin", "")
        Me.DataGridView1.Columns.Add("MarLoss", "")
        Me.DataGridView1.Columns.Add("MarLoss", "")
        For j As Integer = 0 To Me.DataGridView1.ColumnCount - 1
            Me.DataGridView1.Columns(j).Width = 115
            Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "c"
            Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "c"
            Me.DataGridView1.Columns(6).DefaultCellStyle.Format = "c"
            Me.DataGridView1.Columns(7).DefaultCellStyle.Format = "c"
            Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Me.DataGridView1.Columns(8).Width = 30
            Me.DataGridView1.Columns(5).Width = 30
            Me.DataGridView1.Columns(2).Width = 0
        Next
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ColumnHeadersHeight = Me.DataGridView1.ColumnHeadersHeight * 2
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            Dim r2 As Rectangle = e.CellBounds
            r2.Y += e.CellBounds.Height / 2
            r2.Height = e.CellBounds.Height / 2
            e.PaintBackground(r2, True)
            e.PaintContent(r2)
            e.Handled = True
        End If
    End Sub
    Private Sub DataGridView1_Paint(sender As Object, e As PaintEventArgs) Handles DataGridView1.Paint
        Dim monthes As String() = {"Analisis", "Analisis Laba Komersial", "Analisa Laba Fiskal"}
        Dim j As Integer = 0
        While j < 9
            Dim r1 As Rectangle = DataGridView1.GetCellDisplayRectangle(j, -1, True)
            Dim w2 As Integer = DataGridView1.GetCellDisplayRectangle(j + 1, -1, True).Width
            r1.X += 1
            r1.Y += 1
            r1.Width = r1.Width + w2 - 3
            r1.Height = r1.Height / 3 - 3
            e.Graphics.FillRectangle(New SolidBrush(Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1)
            Dim format As New StringFormat()
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(monthes(j \ 3), DataGridView1.ColumnHeadersDefaultCellStyle.Font, New SolidBrush(DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor), r1, format)
            j += 3
        End While
    End Sub
    Private Sub DataGridView1_Scroll(sender As Object, e As ScrollEventArgs) Handles DataGridView1.Scroll
        Dim rtHeader As Rectangle = DataGridView1.DisplayRectangle
        rtHeader.Height = Me.DataGridView1.ColumnHeadersHeight / 2
        Me.DataGridView1.Invalidate(rtHeader)
    End Sub
    Private Sub DataGridView1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnWidthChanged
        Dim rtHeader As Rectangle = DataGridView1.DisplayRectangle
        rtHeader.Height = Me.DataGridView1.ColumnHeadersHeight / 2
        Me.DataGridView1.Invalidate(rtHeader)
    End Sub
    Public Function Penjualan()
        Dim je, re As Double
        Dim hp As Decimal
        je = Replace(lblSiswa.Text, ".", "")
        re = lblRe.Text
        hp = Replace(lblHp.Text, ".", "")
        Return (je * re * hp)
    End Function
    Public Sub getValue(ByVal tahun As String, ByVal termin As String)
        For c As Integer = 2 To DataGridView1.ColumnCount - 1
            MsgBox(DataGridView1.Columns(c).HeaderCell.Value.ToString())
            'For baris As Integer = 0 To DataGridView1.RowCount - 1
            '    kb = DataGridView1.Rows(baris).Cells(0).Value.ToString()
            '    ckb = kb.Replace("-", "")
            '    simpanStockNasional(ckb, DataGridView1.Rows(baris).Cells(c).Value, DataGridView1.Columns(c).HeaderCell.Value.ToString())
            'Next
        Next
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim d As Integer
        Dim n As Integer
        Dim cur_row As Integer
        If ((DataGridView1.ColumnCount = 0) Or (DataGridView1.RowCount = 0)) Then
            Exit Sub
        End If
        Dim dset As New DataSet
        dset.Tables.Add()
        DataGridView1.Columns(3).HeaderText = "ANALISIS LABA KOMERSIAL"
        DataGridView1.Columns(6).HeaderText = "ANALISIS LABA FISKAL"
        For d = 0 To DataGridView1.ColumnCount - 1
            dset.Tables(0).Columns.Add(DataGridView1.Columns(d).HeaderText)
        Next
        Dim dr1 As DataRow
        For d = 0 To DataGridView1.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For n = 0 To DataGridView1.ColumnCount - 1
                dr1(n) = DataGridView1.Rows(d).Cells(n).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next
        Dim excel As New Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        wSheet.Range(wSheet.Cells(5, 1), wSheet.Cells(5, 3)).Merge()
        wSheet.Range(wSheet.Cells(5, 4), wSheet.Cells(5, 6)).Merge()
        wSheet.Range(wSheet.Cells(5, 7), wSheet.Cells(5, 9)).Merge()
        wSheet.Range("A1:I1").MergeCells = True
        wSheet.Range("A1:I1").Interior.ColorIndex = XLColor.Aqua
        excel.Cells(1, 1) = "ANALISIS PROFITABILITAS PENGAJUAN RABAT"
        wSheet.Range("A1:B1").Font.Bold = True
        wSheet.Range("A2:B2").MergeCells = True
        excel.Cells(2, 1) = "CABANG"
        wSheet.Range("A2:B2").Font.Bold = True
        wSheet.Range("C2:D2").MergeCells = True
        excel.Cells(2, 3) = txtCabang.Text
        wSheet.Range("C2:D2").Font.Bold = True
        wSheet.Range("A3:B3").MergeCells = True
        excel.Cells(3, 1) = "NAMA PELANGGAN"
        wSheet.Range("A3:B3").Font.Bold = True
        wSheet.Range("C3:D3").MergeCells = True
        excel.Cells(3, 3) = TxtPelanggan.Text
        wSheet.Range("C3:D3").Font.Bold = True
        wSheet.Range("A4:B4").MergeCells = True
        excel.Cells(4, 1) = "TAHUN TRANSAKSI"
        wSheet.Range("A4:B4").Font.Bold = True
        wSheet.Range("C4:D4").MergeCells = True
        excel.Cells(4, 3) = txtTahun.Text
        wSheet.Range("C4:D4").Font.Bold = True
        wSheet.Range("E2:F2").MergeCells = True
        excel.Cells(2, 5) = "JENIS TRANSAKSI"
        wSheet.Range("E2:F2").Font.Bold = True
        wSheet.Range("G2:H2").MergeCells = True
        excel.Cells(2, 7) = txtjenisTrans.Text
        wSheet.Range("G2:H2").Font.Bold = True
        wSheet.Range("A5:I5").VerticalAlignment = Exalt.Constants.xlCenter
        wSheet.Range("A16:B16").VerticalAlignment = Exalt.Constants.xlCenter
        wSheet.Range("A23:B23").VerticalAlignment = Exalt.Constants.xlCenter
        wSheet.Range("A27:B27").VerticalAlignment = Exalt.Constants.xlCenter
        wSheet.Range("A31:B31").VerticalAlignment = Exalt.Constants.xlCenter
        wSheet.Range("A16:B16").MergeCells = True
        wSheet.Range("A23:B23").MergeCells = True
        wSheet.Range("A27:B27").MergeCells = True
        wSheet.Range("A31:B31").MergeCells = True
        wSheet.Range("A16:B16").Interior.ColorIndex = XLColor.Aqua
        wSheet.Range("A23:B23").Interior.ColorIndex = XLColor.Aqua
        wSheet.Range("A27:B27").Interior.ColorIndex = XLColor.Aqua
        wSheet.Range("A31:B31").Interior.ColorIndex = XLColor.Aqua
        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(5, colIndex) = dc.ColumnName
        Next
        Dim formatRange As Excel.Range = wSheet.UsedRange
        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 5, colIndex) = dr(dc.ColumnName)
                Dim cell As Excel.Range = formatRange.Cells(rowIndex + 5, colIndex)
                Dim border As Excel.Borders = cell.Borders
                border.LineStyle = Exalt.XlLineStyle.xlContinuous
                border.Weight = 2.0
            Next
        Next
        wSheet.Columns.AutoFit()
        wSheet.Range("A5:I5").Interior.ColorIndex = XLColor.Aqua
        wSheet.Range("A5:I5").Font.Bold = True
        wSheet.Range("D6:D" & rowIndex + 2).NumberFormat = "Rp,   ##,##0"
        wSheet.Range("E6:E" & rowIndex + 5).NumberFormat = "Rp,   ##,##0"
        wSheet.Range("G6:G" & rowIndex + 5).NumberFormat = "Rp,   ##,##0"
        wSheet.Range("H6:H" & rowIndex + 2).NumberFormat = "Rp,   ##,##0"
        Dim strFileName As String
        Dim fsave As New SaveFileDialog
        With fsave
            .Filter = "excel files 2007 (*.xlsx)|*.xlsx|all files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Save Data Export "
        End With
        If fsave.ShowDialog() = DialogResult.OK Then
            strFileName = fsave.FileName
        End If
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If
        wBook.SaveAs(strFileName)
        excel.Visible = True
    End Sub
    Public Enum XLColor
        Aqua = 42
        Black = 1
        Blue = 5
        BlueGray = 47
        BrightGreen = 4
        Brown = 53
        Cream = 19
        DarkBlue = 11
        DarkGreen = 51
        DarkPurple = 21
        DarkRed = 9
        DarkTeal = 49
        DarkYellow = 12
        Gold = 44
        Gray25 = 15
        Gray40 = 48
        Gray50 = 16
        Gray80 = 56
        Green = 10
        Indigo = 55
        Lavender = 39
        LightBlue = 41
        LightGreen = 35
        LightLavender = 24
        LightOrange = 45
        LightTurquoise = 20
        LightYellow = 36
        Lime = 43
        NavyBlue = 23
        OliveGreen = 52
        Orange = 46
        PaleBlue = 37
        Pink = 7
        Plum = 18
        PowderBlue = 17
        Red = 3
        Rose = 38
        Salmon = 22
        SeaGreen = 50
        SkyBlue = 33
        Tan = 40
        Teal = 14
        Turquoise = 8
        Violet = 13
        White = 2
        Yellow = 6
    End Enum
End Class