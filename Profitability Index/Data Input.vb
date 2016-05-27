Imports Profitability_Index.db
Imports MySql.Data.MySqlClient
Public Class Data_Input
    Private Sub Data_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        CabangCombo(CmbCabang)
        cmbJenisTrans.Items.Add("BOS")
        cmbJenisTrans.Items.Add("Siswa")
        cmbJenisTrans.Items.Add("Yayasan")
        Dim calcol As New GridDateControl
        calcol.Name = "Tanggal"
        calcol.HeaderText = "Tanggal"
        calcol.DataPropertyName = "TanggalBayar"

        With dgvTermin
            .Columns.Add("Termin", "Termin")
            .Columns.Add(calcol)
            .Columns.Add("Tahun", "Tahun")
            .Columns.Add("Bayar", "Total Pembayaran")
            .Columns.Add("Keterangan", "Keterangan")
        End With
    End Sub



    Private Sub CmbCabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCabang.SelectedIndexChanged
        If CmbCabang.Text <> "" Then
            JabatanCombo(CmbKacab, CmbCabang.Text, "KC")
            JabatanCombo(CmbSpv, CmbCabang.Text, "SP")
            JabatanCombo(cmbMe, CmbCabang.Text, "ME")
            CustCombo(CmbCust, CmbCabang.Text)
        End If
    End Sub

    Private Sub CmbCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCust.SelectedIndexChanged
        If CmbCust.Text <> "" Then
            transcode(CmbCust.Text, dtpTanggalTrans.Text, txtKodeTrans)
            Dim th As String
            th = dtpTanggalTrans.Text
            txtTahun.Text = Strings.Right(th, 4)
        End If
    End Sub



    Private Sub txtSiswa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSiswa.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back _
            OrElse KeyAscii = Keys.Return _
            OrElse KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub

    Private Sub txtSiswa_TextChanged(sender As Object, e As EventArgs) Handles txtSiswa.TextChanged
        If Microsoft.VisualBasic.Len(txtSiswa.Text) = 0 Then
            Exit Sub
        End If
        txtSiswa.Text = FormatNumber(txtSiswa.Text, 0)
        txtSiswa.SelectionStart = Microsoft.VisualBasic.Len(txtSiswa.Text)
    End Sub



    Private Sub txthargaEks_TextChanged(sender As Object, e As EventArgs) Handles txthargaEks.TextChanged
        If Microsoft.VisualBasic.Len(txthargaEks.Text) = 0 Then
            Exit Sub
        End If
        txthargaEks.Text = FormatNumber(txthargaEks.Text, 0)
        txthargaEks.SelectionStart = Microsoft.VisualBasic.Len(txthargaEks.Text)
    End Sub

    Private Sub txthargaEks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthargaEks.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back _
            OrElse KeyAscii = Keys.Return _
            OrElse KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub
    Private Sub txtRata2exp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRata2exp.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back _
            OrElse KeyAscii = Keys.Return _
            OrElse KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub
    Private Sub txtNominal_TextChanged(sender As Object, e As EventArgs) Handles txtNominal.TextChanged
        If Microsoft.VisualBasic.Len(txtNominal.Text) = 0 Then
            Exit Sub
        End If
        txtNominal.Text = FormatNumber(txtNominal.Text, 0)
        txtNominal.SelectionStart = Microsoft.VisualBasic.Len(txtNominal.Text)
    End Sub

    Private Sub txtNominal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNominal.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back _
            OrElse KeyAscii = Keys.Return _
            OrElse KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub



    Private Sub txtOperasional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOperasional.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
                OrElse keyAscii = Keys.Back _
                OrElse keyAscii = Keys.Return _
                OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub

    Private Sub TxtRabat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRabat.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub TxtRetur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRetur.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub txtHpp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHpp.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub TxtRoyalty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRoyalty.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub txtKomisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKomisi.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub txtDanaTaktis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDanaTaktis.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub txtDanaTaktis_TextChanged(sender As Object, e As EventArgs) Handles txtDanaTaktis.TextChanged
        If Microsoft.VisualBasic.Len(txtDanaTaktis.Text) = 0 Then
            Exit Sub
        End If
        txtDanaTaktis.Text = FormatNumber(txtDanaTaktis.Text, 0)
        txtDanaTaktis.SelectionStart = Microsoft.VisualBasic.Len(txtDanaTaktis.Text)
    End Sub
    Private Sub txtPajak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPajak.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub txtDpRabat_TextChanged(sender As Object, e As EventArgs) Handles txtDpRabat.TextChanged
        If Microsoft.VisualBasic.Len(txtDpRabat.Text) = 0 Then
            Exit Sub
        End If
        txtDpRabat.Text = FormatNumber(txtDpRabat.Text, 0)
        txtDpRabat.SelectionStart = Microsoft.VisualBasic.Len(txtDpRabat.Text)
    End Sub
    Private Sub txtDpRabat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDpRabat.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub txthrpRetur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthrpRetur.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub txtTermin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTermin.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
              OrElse keyAscii = Keys.Back _
              OrElse keyAscii = Keys.Return _
              OrElse keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If (CmbCabang.Text <> "" And CmbKacab.Text <> "" And CmbSpv.Text <> "" And cmbMe.Text <> "" And CmbCust.Text <> "" And dtpTanggalTrans.Text <> "" And txtKodeTrans.Text <> "" And txtTahun.Text <> "" And cmbJenisTrans.Text <> "" And txtSiswa.Text <> "" And txthargaEks.Text <> "" And txtRata2exp.Text <> "" And txtNominal.Text <> "" And TxtRabat.Text <> "" And TxtRetur.Text <> "" And txtHpp.Text <> "" And TxtRoyalty.Text <> "" And txtKomisi.Text <> "" And txtOperasional.Text <> "" And txtDanaTaktis.Text <> "" And txtPajak.Text <> "" And txtDpRabat.Text <> "" And txthrpRetur.Text <> "" And txtTermin.Text <> "") Then
            Dim tahun(dgvTermin.RowCount - 2) As Integer
            If (dgvTermin.RowCount - 1 > txtTermin.Text) Then
                MsgBox("Data Termin Yang anda input melebihi Jumlah Termin")
            ElseIf (dgvTermin.RowCount - 1 = txtTermin.Text) Then
                actionSimpan(txtKodeTrans.Text, cmbJenisTrans.Text, txtTahun.Text, dtpTanggalTrans.Text, CmbCabang.Text.ToString.Substring(0, 3), CmbKacab.Text.ToString.Substring(0, 7), CmbSpv.Text.ToString.Substring(0, 7), cmbMe.Text.ToString.Substring(0, 7), CmbCust.Text.ToString.Substring(0, 9), Replace(txtSiswa.Text, ".", ""), Replace(txthargaEks.Text, ".", ""), txtRata2exp.Text, Replace(txtNominal.Text, ".", ""), TxtRabat.Text, TxtRetur.Text, txtHpp.Text, TxtRoyalty.Text, txtKomisi.Text, txtOperasional.Text, Replace(txtDanaTaktis.Text, ".", ""), txtPajak.Text, Replace(txtDpRabat.Text, ".", ""), txthrpRetur.Text, txtTermin.Text)
                Dim awal As Integer
                Dim akhir As Integer
                awal = dgvTermin.Rows(0).Cells(2).Value
                akhir = dgvTermin.Rows(0).Cells(2).Value
                For baris As Integer = 0 To dgvTermin.RowCount - 2
                    actionSimpanDetail(txtKodeTrans.Text, dgvTermin.Rows(baris).Cells(0).Value, dgvTermin.Rows(baris).Cells(1).Value, dgvTermin.Rows(baris).Cells(3).Value, dgvTermin.Rows(baris).Cells(2).Value, dgvTermin.Rows(baris).Cells(4).Value)
                    tahun(baris) = dgvTermin.Rows(baris).Cells(2).Value
                    If dgvTermin.Rows(baris).Cells(2).Value < awal Then
                        awal = dgvTermin.Rows(baris).Cells(2).Value
                    End If
                    If dgvTermin.Rows(baris).Cells(2).Value > akhir Then
                        akhir = dgvTermin.Rows(baris).Cells(2).Value
                    End If
                Next
                Dim uniqueValues As Integer() = tahun.Distinct().ToArray()

                'Me.Visible = False

                Dim NewMDIChild As New Termin
                NewMDIChild.txtKodeTrans.Text = txtKodeTrans.Text
                NewMDIChild.TxtPelanggan.Text = CmbCust.Text
                NewMDIChild.txtTermin.Text = txtTermin.Text
                NewMDIChild.txtCabang.Text = CmbCabang.Text
                NewMDIChild.txtTahun.Text = txtTahun.Text
                NewMDIChild.txtjenisTrans.Text = cmbJenisTrans.Text
                NewMDIChild.lblSiswa.Text = txtSiswa.Text
                NewMDIChild.lblRe.Text = txtRata2exp.Text
                NewMDIChild.lblHp.Text = txthargaEks.Text
                NewMDIChild.lblRabat.Text = TxtRabat.Text
                NewMDIChild.lblretur.Text = TxtRetur.Text
                NewMDIChild.lblHpp.Text = txtHpp.Text
                NewMDIChild.lblRoyalti.Text = TxtRoyalty.Text
                NewMDIChild.lblkomisi.Text = txtKomisi.Text
                NewMDIChild.lblTaktis.Text = txtDanaTaktis.Text
                NewMDIChild.lblOperasional.Text = txtOperasional.Text
                NewMDIChild.lblPajak.Text = txtPajak.Text
                NewMDIChild.lblAwal.Text = awal
                NewMDIChild.lblakhir.Text = akhir
                NewMDIChild.lblDp.Text = txtDpRabat.Text
                NewMDIChild.lblHretur.Text = txthrpRetur.Text
                NewMDIChild.dgvIrr.Columns.Add("URAIAN", "URAIAN")
                NewMDIChild.dgvIrr.Columns.Add("", "Tahun Ke - 0")
                Dim th As Integer = 0
                For d As Integer = awal To akhir
                    th += 1
                    NewMDIChild.dgvIrr.Columns.Add("Tahun", d)
                Next
                For c As Integer = 2 To NewMDIChild.dgvIrr.ColumnCount - 1
                    For baris As Integer = 0 To dgvTermin.RowCount - 2
                        If NewMDIChild.dgvIrr.Columns(c).HeaderCell.Value.ToString() = dgvTermin.Rows(baris).Cells(2).Value Then
                            NewMDIChild.dgvIrr.Rows.Add(New String() {"", ""})
                            NewMDIChild.dgvIrr.Rows.Add(New String() {"", ""})
                            NewMDIChild.dgvIrr.Rows.Item(baris + 1).Cells(0).Value = "Pembayaran Ke-" & baris + 1
                            NewMDIChild.dgvIrr.Rows.Item(baris + 1).Cells(c).Value = dgvTermin.Rows(baris).Cells(3).Value
                        End If
                    Next
                Next
                Dim akhir2 As Integer = NewMDIChild.dgvIrr.RowCount - 2
                Dim total(akhir2) As Double
                NewMDIChild.dgvIrr.Rows(akhir2).Cells(2).Value = 0
                For a As Integer = 2 To NewMDIChild.dgvIrr.ColumnCount - 1
                    For baris As Integer = 0 To NewMDIChild.dgvIrr.RowCount - 2
                        total(a) += NewMDIChild.dgvIrr.Rows(baris).Cells(a).Value
                    Next
                Next
                For a2 As Integer = 2 To NewMDIChild.dgvIrr.ColumnCount - 1
                    NewMDIChild.dgvIrr.Rows(akhir2).Cells(a2).Value = total(a2)
                Next
                NewMDIChild.MdiParent = MDIParent1
                NewMDIChild.Show()
                Me.Close()
            Else
                MsgBox("Data Termin Yang anda input Kurang Dari Jumlah Termin")
            End If
        Else
            MsgBox("Semua Data Wajib Diisi !!")
        End If
    End Sub

    Private Sub dgvTermin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTermin.CellContentClick

    End Sub

    Private Sub dgvTermin_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTermin.CellEndEdit
        If (e.ColumnIndex = 1) Then
            For baris As Integer = 0 To dgvTermin.RowCount - 2

                dgvTermin.Rows(baris).Cells(2).Value = dgvTermin.Rows(baris).Cells(1).Value.ToString.Substring(6, 4)
            Next
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtFind.Text <> "" Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            CMD = New MySqlCommand("Select * from traksaksi where kodetransaksi='" & txtFind.Text & "' ", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                GroupControl1.Enabled = False
                GroupControl2.Enabled = False
                txtKodeTrans.Text = RD.Item(0)
                cmbJenisTrans.Text = RD.Item(1)
                txtTahun.Text = RD.Item(2)
                dtpTanggalTrans.Text = RD.Item(3)
                CmbCabang.Text = RD.Item(4)
                CmbKacab.Text = RD.Item(5)
                CmbSpv.Text = RD.Item(6)
                cmbMe.Text = RD.Item(7)
                CmbCust.Text = RD.Item(8)
                txtSiswa.Text = RD.Item(9)
                txthargaEks.Text = RD.Item(10)
                txtRata2exp.Text = RD.Item(11)
                txtNominal.Text = RD.Item(12)
                TxtRabat.Text = RD.Item(13)
                TxtRetur.Text = RD.Item(14)
                txtHpp.Text = RD.Item(15)
                TxtRoyalty.Text = RD.Item(16)
                txtKomisi.Text = RD.Item(17)
                txtOperasional.Text = RD.Item(18)
                txtDanaTaktis.Text = RD.Item(19)
                txtPajak.Text = RD.Item(20)
                txtDpRabat.Text = RD.Item(21)
                txthrpRetur.Text = RD.Item(22)
                txtTermin.Text = RD.Item(23)
                RD.Close()
                DA = New MySqlDataAdapter("select Termin,Tanggalbayar,tahun,bayar,keterangan from detailtransaksi where kodeTrans='" & txtFind.Text & "'", conn)
                DS.Reset()
                DS.Clear()
                DS.Tables.Clear()
                DA.Fill(DS)
                dgvTermin.DataSource = Nothing
                dgvTermin.Columns.Clear()
                dgvTermin.DataSource = DS.Tables(0)
            Else
                MsgBox("Data Tidak Ditemukan !!", MsgBoxStyle.Information, "Informasi")
            End If
            conn.Close()
        End If
    End Sub

End Class