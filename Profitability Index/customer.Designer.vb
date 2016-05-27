<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbBranch = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCustTlp = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustAddres = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustName = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AplprofitDataSet = New Profitability_Index.aplprofitDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colkode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnotlp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CustomerTableAdapter = New Profitability_Index.aplprofitDataSetTableAdapters.customerTableAdapter()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustTlp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustAddres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AplprofitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnCancel)
        Me.GroupControl1.Controls.Add(Me.btnSimpan)
        Me.GroupControl1.Controls.Add(Me.cmbBranch)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtCustTlp)
        Me.GroupControl1.Controls.Add(Me.txtCustAddres)
        Me.GroupControl1.Controls.Add(Me.txtCustName)
        Me.GroupControl1.Controls.Add(Me.txtCustCode)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(711, 197)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Header Customer"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(219, 167)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(140, 167)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "Save"
        '
        'cmbBranch
        '
        Me.cmbBranch.Location = New System.Drawing.Point(139, 34)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBranch.Size = New System.Drawing.Size(221, 20)
        Me.cmbBranch.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Branch"
        '
        'txtCustTlp
        '
        Me.txtCustTlp.Location = New System.Drawing.Point(139, 142)
        Me.txtCustTlp.Name = "txtCustTlp"
        Me.txtCustTlp.Size = New System.Drawing.Size(221, 20)
        Me.txtCustTlp.TabIndex = 3
        '
        'txtCustAddres
        '
        Me.txtCustAddres.Location = New System.Drawing.Point(139, 116)
        Me.txtCustAddres.Name = "txtCustAddres"
        Me.txtCustAddres.Size = New System.Drawing.Size(221, 20)
        Me.txtCustAddres.TabIndex = 4
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(139, 88)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(221, 20)
        Me.txtCustName.TabIndex = 3
        '
        'txtCustCode
        '
        Me.txtCustCode.Enabled = False
        Me.txtCustCode.Location = New System.Drawing.Point(139, 60)
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(221, 20)
        Me.txtCustCode.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 149)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Telephone"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 119)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Customer Address"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 91)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Customer Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Customer Number"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CustomerBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 203)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(711, 298)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.AplprofitDataSet
        '
        'AplprofitDataSet
        '
        Me.AplprofitDataSet.DataSetName = "aplprofitDataSet"
        Me.AplprofitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colkode, Me.colnama, Me.colalamat, Me.colnotlp})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colkode
        '
        Me.colkode.FieldName = "kode"
        Me.colkode.Name = "colkode"
        Me.colkode.Visible = True
        Me.colkode.VisibleIndex = 0
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 1
        '
        'colalamat
        '
        Me.colalamat.FieldName = "alamat"
        Me.colalamat.Name = "colalamat"
        Me.colalamat.Visible = True
        Me.colalamat.VisibleIndex = 2
        '
        'colnotlp
        '
        Me.colnotlp.FieldName = "notlp"
        Me.colnotlp.Name = "colnotlp"
        Me.colnotlp.Visible = True
        Me.colnotlp.VisibleIndex = 3
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 505)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "customer"
        Me.Text = "customer"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustTlp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustAddres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AplprofitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbBranch As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustTlp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustAddres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AplprofitDataSet As aplprofitDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As aplprofitDataSetTableAdapters.customerTableAdapter
    Friend WithEvents colkode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colalamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnotlp As DevExpress.XtraGrid.Columns.GridColumn
End Class
