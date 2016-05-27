Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Globalization
Module db
    Public conn As MySqlConnection
    Public CMD As MySqlCommand
    Public DS, SDS As New DataSet
    Public DA, SDA As MySqlDataAdapter
    Public RD As MySqlDataReader
    Public dt As DataTable
    Public lokasiData As String
    Private bindingSource1 As New BindingSource()
    Public con_server As String
    Public con_userid As String
    Public con_password As String
    Public con_database As String
    Public con_string As String
    Public Sub koneksi()
        lokasiData = "Server=localhost;user id=root;password=;database=aplprofit;"
        Try
            conn = New MySqlConnection(lokasiData)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Gagal")
        End Try
    End Sub
    Public Sub dataCust()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim cmd As New MySqlCommand("SELECT kode,nama,alamat  From customer", conn)
        Dim myAdapter As New MySqlDataAdapter(cmd)
        dt = New DataTable
        myAdapter.Fill(dt)
        customer.GridControl1.DataSource = Nothing
        customer.GridControl1.DataSource = dt
    End Sub
    Public Sub CabangCombo(ByVal combo As DevExpress.XtraEditors.ComboBoxEdit)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        query = "select kode,nama from cabang ORDER BY kode ASC"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            combo.Properties.Items.Add(RD.Item(0) & " - " & RD.Item(1))
        End While
        conn.Close()
    End Sub
    Public Sub JabatanCombo(ByVal combo As DevExpress.XtraEditors.ComboBoxEdit, ByVal cb As String, ByVal kj As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        Dim codecabang As String
        codecabang = cb.Substring(0, 3)
        query = "select kode,kodejabatan from employee where SUBSTRING(kode,1,3)='" & codecabang & "' and kodejabatan='" & kj & "' ORDER BY kode ASC"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            combo.Properties.Items.Add(RD.Item(0) & " - " & RD.Item(1))
        End While
        conn.Close()
    End Sub
    Public Sub CustCombo(ByVal combo As DevExpress.XtraEditors.ComboBoxEdit, ByVal cb As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim query As String
        'Dim a As Integer
        Dim codecabang As String
        codecabang = cb.Substring(0, 3)
        query = "select kode,nama from customer where SUBSTRING(kode,1,3)='" & codecabang & "' ORDER BY kode ASC"
        CMD = New MySqlCommand(query, conn)
        RD = CMD.ExecuteReader
        While RD.Read
            combo.Properties.Items.Add(RD.Item(0) & " - " & RD.Item(1))
        End While
        conn.Close()
    End Sub
    Public Sub custCode(ByVal cabang As String, ByVal txt As DevExpress.XtraEditors.TextEdit)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim codecabang, codecust, code As String
        codecabang = cabang.Substring(0, 3)

        code = codecabang & "" & codecust
        CMD = New MySqlCommand("SELECT kode FROM customer where SUBSTRING(kode,1,3)='" & codecabang & "' ORDER BY kode DESC LIMIT 1", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim num, ss As String
            num = RD!kode
            ss = Strings.Right(num, 3)
            'MsgBox(Convert.ToDouble(num) + 1)
            Select Case Convert.ToDouble(ss)
                Case Is <= 9
                    codecust = Convert.ToDouble(num) + 1
                Case Is <= 99
                    codecust = Convert.ToDouble(num) + 1
            End Select

        Else
            codecust = codecabang & "200001"
        End If
        txt.Text = codecust
    End Sub
    Public Sub inserttocust(ByVal kode As String, ByVal nama As String, ByVal alamat As String, ByVal notlp As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from customer where kode='" & kode & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim query As String
                query = "insert into customer(kode,nama,alamat,notlp) values ('" & kode & "','" & nama & "','" & alamat & "','" & notlp & "')"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub
    Public Sub transcode(ByVal cust As String, ByVal tgl As String, ByVal txt As DevExpress.XtraEditors.TextEdit)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Dim t, c, code, ct As String
        t = tgl.Replace("/", "")
        c = Strings.Left(cust, 9)
        code = c & "" & t
        CMD = New MySqlCommand("SELECT kodetransaksi FROM traksaksi where SUBSTRING(kodetransaksi,1,17)='" & code & "' ORDER BY kodetransaksi DESC LIMIT 1", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim num, ss As String
            num = RD!kodetransaksi
            ss = Strings.Right(num, 3)
            ' MsgBox(Convert.ToDouble(ss) + 1)
            ''MsgBox(Convert.ToDouble(num) + 1)
            Select Case Convert.ToDouble(ss)
                Case Is <= 9
                    ct = code & "00" & Convert.ToDouble(ss) + 1
                Case Is <= 99
                    ct = code & "0" & Convert.ToDouble(ss) + 1
            End Select
        Else
            ct = code & "001"
        End If
        txt.Text = ct
    End Sub
    Public Sub dgvTermin(ByVal grid As DataGridView)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        DA = New MySqlDataAdapter("select * from detailtransaksi where id is NULL", conn)
        DS.Reset()
        DS.Clear()
        DS.Tables.Clear()
        DA.Fill(DS)
        grid.DataSource = Nothing
        grid.Columns.Clear()
        grid.DataSource = DS.Tables(0)
        Dim calcol As New GridDateControl
        calcol.Name = "calcol"
        calcol.HeaderText = "Tanggal Daftar"
        calcol.DataPropertyName = "TglAktif"
    End Sub
    Public Sub actionSimpan(ByVal kt As String, ByVal jt As String, ByVal th As String, ByVal tgl As Date, ByVal kc As String, ByVal kkb As String, ByVal ks As String, ByVal kme As String, ByVal kp As String, ByVal js As String, ByVal ph As String, ByVal exp As String, ByVal nominal As String, ByVal rbt As String, ByVal retur As String, ByVal hpp As String, ByVal ry As String, ByVal km As String, ByVal op As String, ByVal dt As String, ByVal pjk As String, ByVal dprabat As String, ByVal returh As String, ByVal termin As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from traksaksi where kodetransaksi='" & kt & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim simpan As String = "insert into traksaksi values('" & kt & "','" & jt & "','" & th & "','" & tgl.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) & "','" & kc & "','" & kkb & "','" & ks & "','" & kme & "','" & kp & "'," & js & "," & ph & "," & exp & "," & nominal & "," & rbt & "," & retur & "," & hpp & "," & ry & "," & km & "," & op & "," & dt & "," & pjk & "," & dprabat & "," & returh & "," & termin & ")"

                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("Kode Transaksi Sudah Terdaftar", MsgBoxStyle.Information, "Informasi")
        End If
        conn.Close()
    End Sub
    Public Sub actionSimpanDetail(ByVal kt As String, ByVal termin As String, ByVal tgl As Date, ByVal nominal As String, ByVal tahun As String, ByVal ket As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from detailtransaksi where kodetrans='" & kt & "'", conn)
        RD = CMD.ExecuteReader()
        RD.Read()
        If Not RD.HasRows Then
            conn.Close()
            conn.Open()
            Try
                Dim simpandetail As String = "insert into detailtransaksi(kodeTrans,Termin,Tanggalbayar,bayar,tahun,keterangan) values('" & kt & "','" & termin & "','" & tgl.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) & "'," & nominal & ",'" & tahun & "','" & ket & "')"
                CMD = New MySqlCommand(simpandetail, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End If
        conn.Close()
    End Sub
    Public Sub getData(ByVal pk As String, ByVal txt As DevExpress.XtraEditors.TextEdit)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select nama from customer where kode='" & pk & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txt.Text = RD.Item(0)
        End If
    End Sub
End Module
