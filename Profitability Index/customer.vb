Public Class customer
    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AplprofitDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.AplprofitDataSet.customer)
        koneksi()
        CabangCombo(cmbBranch)

    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged
        If cmbBranch.Text <> "" Then
            custCode(cmbBranch.Text, txtCustCode)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtCustCode.Text <> "" And txtCustName.Text <> "" And txtCustAddres.Text <> "" And txtCustTlp.Text <> "" Then
            inserttocust(txtCustCode.Text, txtCustName.Text, txtCustAddres.Text, txtCustTlp.Text)
            Me.CustomerTableAdapter.Fill(Me.AplprofitDataSet.customer)
            def()
            MsgBox("Data berhasil Tersimpan", MsgBoxStyle.Information, "Informasi")
        Else
            MsgBox("semua data wajib diisi", MsgBoxStyle.Exclamation, "Information")
        End If
    End Sub
    Sub def()
        cmbBranch.Text = ""
        txtCustCode.Text = ""
        txtCustName.Text = ""
        txtCustAddres.Text = ""
        txtCustTlp.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class