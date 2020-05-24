<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllReports
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblPurchaseOrderListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbMedicTouchDataSet = New MedicTouch.dbMedicTouchDataSet()
        Me.tblSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblCurrentStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnCustomerReport = New System.Windows.Forms.Button()
        Me.btnUserReport = New System.Windows.Forms.Button()
        Me.btnSaleReport = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblCustomerTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblCustomerTableAdapter()
        Me.tblUserTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblUserTableAdapter()
        Me.tblCurrentStockTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblCurrentStockTableAdapter()
        Me.btnCurrentStock = New System.Windows.Forms.Button()
        Me.btnStockInReport = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.tblStockOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblStockOutTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblStockOutTableAdapter()
        Me.tblStockInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblStockInTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblStockInTableAdapter()
        Me.tblSaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblSaleTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblSaleTableAdapter()
        Me.tblSupplierTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblSupplierTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPurchaseOrder = New System.Windows.Forms.Button()
        Me.btnreportPurchaseEntry = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnPurchaseOrderList = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.btnProductMaster = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.btnClose2 = New System.Windows.Forms.Button()
        Me.tblPurchaseEntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblPurchaseEntryTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblPurchaseEntryTableAdapter()
        Me.tblPurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblPurchaseOrderTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblPurchaseOrderTableAdapter()
        Me.tblProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblProductMasterTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblProductMasterTableAdapter()
        Me.tblPurchaseOrderListTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblPurchaseOrderListTableAdapter()
        CType(Me.tblPurchaseOrderListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbMedicTouchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblCurrentStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblStockOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblStockInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.tblPurchaseEntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblPurchaseOrderListBindingSource
        '
        Me.tblPurchaseOrderListBindingSource.DataMember = "tblPurchaseOrderList"
        Me.tblPurchaseOrderListBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'dbMedicTouchDataSet
        '
        Me.dbMedicTouchDataSet.DataSetName = "dbMedicTouchDataSet"
        Me.dbMedicTouchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblSupplierBindingSource
        '
        Me.tblSupplierBindingSource.DataMember = "tblSupplier"
        Me.tblSupplierBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblUserBindingSource
        '
        Me.tblUserBindingSource.DataMember = "tblUser"
        Me.tblUserBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblCurrentStockBindingSource
        '
        Me.tblCurrentStockBindingSource.DataMember = "tblCurrentStock"
        Me.tblCurrentStockBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.DarkViolet
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.Color.White
        Me.btnSupplier.Location = New System.Drawing.Point(1, 517)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(140, 43)
        Me.btnSupplier.TabIndex = 90
        Me.btnSupplier.Text = "Supplier Report"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'btnCustomerReport
        '
        Me.btnCustomerReport.BackColor = System.Drawing.Color.DarkViolet
        Me.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerReport.ForeColor = System.Drawing.Color.White
        Me.btnCustomerReport.Location = New System.Drawing.Point(402, 517)
        Me.btnCustomerReport.Name = "btnCustomerReport"
        Me.btnCustomerReport.Size = New System.Drawing.Size(140, 43)
        Me.btnCustomerReport.TabIndex = 91
        Me.btnCustomerReport.Text = "Customer Report"
        Me.btnCustomerReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCustomerReport.UseVisualStyleBackColor = False
        '
        'btnUserReport
        '
        Me.btnUserReport.BackColor = System.Drawing.Color.DarkViolet
        Me.btnUserReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserReport.ForeColor = System.Drawing.Color.White
        Me.btnUserReport.Location = New System.Drawing.Point(269, 517)
        Me.btnUserReport.Name = "btnUserReport"
        Me.btnUserReport.Size = New System.Drawing.Size(140, 43)
        Me.btnUserReport.TabIndex = 92
        Me.btnUserReport.Text = "User Report"
        Me.btnUserReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnUserReport.UseVisualStyleBackColor = False
        '
        'btnSaleReport
        '
        Me.btnSaleReport.BackColor = System.Drawing.Color.DarkViolet
        Me.btnSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaleReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaleReport.ForeColor = System.Drawing.Color.White
        Me.btnSaleReport.Location = New System.Drawing.Point(135, 517)
        Me.btnSaleReport.Name = "btnSaleReport"
        Me.btnSaleReport.Size = New System.Drawing.Size(140, 43)
        Me.btnSaleReport.TabIndex = 93
        Me.btnSaleReport.Text = "Sale Report"
        Me.btnSaleReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSaleReport.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReportViewer1.ForeColor = System.Drawing.Color.Yellow
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblPurchaseOrderListBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportPurchaseOrderList.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1286, 464)
        Me.ReportViewer1.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Reports"
        '
        'tblCustomerBindingSource
        '
        Me.tblCustomerBindingSource.DataMember = "tblCustomer"
        Me.tblCustomerBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblCustomerTableAdapter
        '
        Me.tblCustomerTableAdapter.ClearBeforeFill = True
        '
        'tblUserTableAdapter
        '
        Me.tblUserTableAdapter.ClearBeforeFill = True
        '
        'tblCurrentStockTableAdapter
        '
        Me.tblCurrentStockTableAdapter.ClearBeforeFill = True
        '
        'btnCurrentStock
        '
        Me.btnCurrentStock.BackColor = System.Drawing.Color.DarkViolet
        Me.btnCurrentStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurrentStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentStock.ForeColor = System.Drawing.Color.White
        Me.btnCurrentStock.Location = New System.Drawing.Point(535, 517)
        Me.btnCurrentStock.Name = "btnCurrentStock"
        Me.btnCurrentStock.Size = New System.Drawing.Size(140, 43)
        Me.btnCurrentStock.TabIndex = 96
        Me.btnCurrentStock.Text = "Current Stock"
        Me.btnCurrentStock.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCurrentStock.UseVisualStyleBackColor = False
        '
        'btnStockInReport
        '
        Me.btnStockInReport.BackColor = System.Drawing.Color.DarkViolet
        Me.btnStockInReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockInReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockInReport.ForeColor = System.Drawing.Color.White
        Me.btnStockInReport.Location = New System.Drawing.Point(669, 517)
        Me.btnStockInReport.Name = "btnStockInReport"
        Me.btnStockInReport.Size = New System.Drawing.Size(140, 43)
        Me.btnStockInReport.TabIndex = 97
        Me.btnStockInReport.Text = "StockIn"
        Me.btnStockInReport.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnStockInReport.UseVisualStyleBackColor = False
        '
        'btnStockOut
        '
        Me.btnStockOut.BackColor = System.Drawing.Color.DarkViolet
        Me.btnStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOut.ForeColor = System.Drawing.Color.White
        Me.btnStockOut.Location = New System.Drawing.Point(802, 517)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(140, 43)
        Me.btnStockOut.TabIndex = 98
        Me.btnStockOut.Text = "Stock Out"
        Me.btnStockOut.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnStockOut.UseVisualStyleBackColor = False
        '
        'tblStockOutBindingSource
        '
        Me.tblStockOutBindingSource.DataMember = "tblStockOut"
        Me.tblStockOutBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblStockOutTableAdapter
        '
        Me.tblStockOutTableAdapter.ClearBeforeFill = True
        '
        'tblStockInBindingSource
        '
        Me.tblStockInBindingSource.DataMember = "tblStockIn"
        Me.tblStockInBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblStockInTableAdapter
        '
        Me.tblStockInTableAdapter.ClearBeforeFill = True
        '
        'tblSaleBindingSource
        '
        Me.tblSaleBindingSource.DataMember = "tblSale"
        Me.tblSaleBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblSaleTableAdapter
        '
        Me.tblSaleTableAdapter.ClearBeforeFill = True
        '
        'tblSupplierTableAdapter
        '
        Me.tblSupplierTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1286, 22)
        Me.Panel1.TabIndex = 99
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Location = New System.Drawing.Point(1249, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(37, 23)
        Me.btnClose.TabIndex = 96
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(1, 486)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1286, 25)
        Me.Panel2.TabIndex = 100
        '
        'btnPurchaseOrder
        '
        Me.btnPurchaseOrder.BackColor = System.Drawing.Color.DarkViolet
        Me.btnPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchaseOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseOrder.ForeColor = System.Drawing.Color.White
        Me.btnPurchaseOrder.Location = New System.Drawing.Point(934, 517)
        Me.btnPurchaseOrder.Name = "btnPurchaseOrder"
        Me.btnPurchaseOrder.Size = New System.Drawing.Size(140, 43)
        Me.btnPurchaseOrder.TabIndex = 101
        Me.btnPurchaseOrder.Text = "Purchase Order"
        Me.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnPurchaseOrder.UseVisualStyleBackColor = False
        '
        'btnreportPurchaseEntry
        '
        Me.btnreportPurchaseEntry.BackColor = System.Drawing.Color.DarkViolet
        Me.btnreportPurchaseEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportPurchaseEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportPurchaseEntry.ForeColor = System.Drawing.Color.White
        Me.btnreportPurchaseEntry.Location = New System.Drawing.Point(1068, 517)
        Me.btnreportPurchaseEntry.Name = "btnreportPurchaseEntry"
        Me.btnreportPurchaseEntry.Size = New System.Drawing.Size(137, 43)
        Me.btnreportPurchaseEntry.TabIndex = 102
        Me.btnreportPurchaseEntry.Text = "Purchase Entry"
        Me.btnreportPurchaseEntry.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnreportPurchaseEntry.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkViolet
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1068, 566)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 43)
        Me.Button3.TabIndex = 111
        Me.Button3.Text = "Purchase"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkViolet
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(934, 566)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 43)
        Me.Button4.TabIndex = 110
        Me.Button4.Text = "Purchase Order"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkViolet
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(802, 566)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 43)
        Me.Button5.TabIndex = 109
        Me.Button5.Text = "Stock Out"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkViolet
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(669, 566)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 43)
        Me.Button6.TabIndex = 108
        Me.Button6.Text = "StockIn"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkViolet
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(535, 566)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(140, 43)
        Me.Button7.TabIndex = 107
        Me.Button7.Text = "Current Stock"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnPurchaseOrderList
        '
        Me.btnPurchaseOrderList.BackColor = System.Drawing.Color.DarkViolet
        Me.btnPurchaseOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchaseOrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseOrderList.ForeColor = System.Drawing.Color.White
        Me.btnPurchaseOrderList.Location = New System.Drawing.Point(135, 566)
        Me.btnPurchaseOrderList.Name = "btnPurchaseOrderList"
        Me.btnPurchaseOrderList.Size = New System.Drawing.Size(140, 43)
        Me.btnPurchaseOrderList.TabIndex = 106
        Me.btnPurchaseOrderList.Text = "Purchase Order List"
        Me.btnPurchaseOrderList.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnPurchaseOrderList.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkViolet
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(269, 566)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(140, 43)
        Me.Button9.TabIndex = 105
        Me.Button9.Text = "User Report"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DarkViolet
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(402, 566)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(140, 43)
        Me.Button10.TabIndex = 104
        Me.Button10.Text = "Customer Report"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'btnProductMaster
        '
        Me.btnProductMaster.BackColor = System.Drawing.Color.DarkViolet
        Me.btnProductMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductMaster.ForeColor = System.Drawing.Color.White
        Me.btnProductMaster.Location = New System.Drawing.Point(1, 566)
        Me.btnProductMaster.Name = "btnProductMaster"
        Me.btnProductMaster.Size = New System.Drawing.Size(140, 43)
        Me.btnProductMaster.TabIndex = 103
        Me.btnProductMaster.Text = "Product Master"
        Me.btnProductMaster.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnProductMaster.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.DarkViolet
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(1068, 615)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(137, 43)
        Me.Button12.TabIndex = 120
        Me.Button12.Text = "Purchase"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.DarkViolet
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(934, 615)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(140, 43)
        Me.Button13.TabIndex = 119
        Me.Button13.Text = "Purchase Order"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.DarkViolet
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(802, 615)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(140, 43)
        Me.Button14.TabIndex = 118
        Me.Button14.Text = "Stock Out"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.DarkViolet
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.White
        Me.Button15.Location = New System.Drawing.Point(669, 615)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(140, 43)
        Me.Button15.TabIndex = 117
        Me.Button15.Text = "StockIn"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.DarkViolet
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Location = New System.Drawing.Point(535, 615)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(140, 43)
        Me.Button16.TabIndex = 116
        Me.Button16.Text = "Current Stock"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.DarkViolet
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.White
        Me.Button17.Location = New System.Drawing.Point(135, 615)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(140, 43)
        Me.Button17.TabIndex = 115
        Me.Button17.Text = "Sale Report"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.DarkViolet
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.White
        Me.Button18.Location = New System.Drawing.Point(269, 615)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(140, 43)
        Me.Button18.TabIndex = 114
        Me.Button18.Text = "User Report"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.DarkViolet
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.White
        Me.Button19.Location = New System.Drawing.Point(402, 615)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(140, 43)
        Me.Button19.TabIndex = 113
        Me.Button19.Text = "Customer Report"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.DarkViolet
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.White
        Me.Button20.Location = New System.Drawing.Point(1, 615)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(140, 43)
        Me.Button20.TabIndex = 112
        Me.Button20.Text = "Supplier Report"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button20.UseVisualStyleBackColor = False
        '
        'btnClose2
        '
        Me.btnClose2.BackColor = System.Drawing.Color.Red
        Me.btnClose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose2.Location = New System.Drawing.Point(1212, 517)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(75, 141)
        Me.btnClose2.TabIndex = 121
        Me.btnClose2.Text = "X"
        Me.btnClose2.UseVisualStyleBackColor = False
        '
        'tblPurchaseEntryBindingSource
        '
        Me.tblPurchaseEntryBindingSource.DataMember = "tblPurchaseEntry"
        Me.tblPurchaseEntryBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblPurchaseEntryTableAdapter
        '
        Me.tblPurchaseEntryTableAdapter.ClearBeforeFill = True
        '
        'tblPurchaseOrderBindingSource
        '
        Me.tblPurchaseOrderBindingSource.DataMember = "tblPurchaseOrder"
        Me.tblPurchaseOrderBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblPurchaseOrderTableAdapter
        '
        Me.tblPurchaseOrderTableAdapter.ClearBeforeFill = True
        '
        'tblProductMasterBindingSource
        '
        Me.tblProductMasterBindingSource.DataMember = "tblProductMaster"
        Me.tblProductMasterBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'tblProductMasterTableAdapter
        '
        Me.tblProductMasterTableAdapter.ClearBeforeFill = True
        '
        'tblPurchaseOrderListTableAdapter
        '
        Me.tblPurchaseOrderListTableAdapter.ClearBeforeFill = True
        '
        'frmAllReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1288, 667)
        Me.Controls.Add(Me.btnClose2)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnPurchaseOrderList)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.btnProductMaster)
        Me.Controls.Add(Me.btnreportPurchaseEntry)
        Me.Controls.Add(Me.btnPurchaseOrder)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnStockOut)
        Me.Controls.Add(Me.btnStockInReport)
        Me.Controls.Add(Me.btnCurrentStock)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnSaleReport)
        Me.Controls.Add(Me.btnUserReport)
        Me.Controls.Add(Me.btnCustomerReport)
        Me.Controls.Add(Me.btnSupplier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(40, 40)
        Me.Name = "frmAllReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmAllReports"
        CType(Me.tblPurchaseOrderListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbMedicTouchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblCurrentStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblStockOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblStockInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblPurchaseEntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnCustomerReport As Button
    Friend WithEvents btnUserReport As Button
    Friend WithEvents btnSaleReport As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblCustomerBindingSource As BindingSource
    Friend WithEvents dbMedicTouchDataSet As dbMedicTouchDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents tblCustomerTableAdapter As dbMedicTouchDataSetTableAdapters.tblCustomerTableAdapter
    Friend WithEvents tblUserBindingSource As BindingSource
    Friend WithEvents tblUserTableAdapter As dbMedicTouchDataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents tblCurrentStockBindingSource As BindingSource
    Friend WithEvents tblCurrentStockTableAdapter As dbMedicTouchDataSetTableAdapters.tblCurrentStockTableAdapter
    Friend WithEvents btnCurrentStock As Button
    Friend WithEvents btnStockInReport As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents tblStockOutBindingSource As BindingSource
    Friend WithEvents tblStockOutTableAdapter As dbMedicTouchDataSetTableAdapters.tblStockOutTableAdapter
    Friend WithEvents tblStockInBindingSource As BindingSource
    Friend WithEvents tblStockInTableAdapter As dbMedicTouchDataSetTableAdapters.tblStockInTableAdapter
    Friend WithEvents tblSaleBindingSource As BindingSource
    Friend WithEvents tblSaleTableAdapter As dbMedicTouchDataSetTableAdapters.tblSaleTableAdapter
    Friend WithEvents tblSupplierBindingSource As BindingSource
    Friend WithEvents tblSupplierTableAdapter As dbMedicTouchDataSetTableAdapters.tblSupplierTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPurchaseOrder As Button
    Friend WithEvents btnreportPurchaseEntry As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnPurchaseOrderList As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btnProductMaster As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClose2 As Button
    Friend WithEvents tblPurchaseEntryBindingSource As BindingSource
    Friend WithEvents tblPurchaseEntryTableAdapter As dbMedicTouchDataSetTableAdapters.tblPurchaseEntryTableAdapter
    Friend WithEvents tblPurchaseOrderBindingSource As BindingSource
    Friend WithEvents tblPurchaseOrderTableAdapter As dbMedicTouchDataSetTableAdapters.tblPurchaseOrderTableAdapter
    Friend WithEvents tblProductMasterBindingSource As BindingSource
    Friend WithEvents tblProductMasterTableAdapter As dbMedicTouchDataSetTableAdapters.tblProductMasterTableAdapter
    Friend WithEvents tblPurchaseOrderListBindingSource As BindingSource
    Friend WithEvents tblPurchaseOrderListTableAdapter As dbMedicTouchDataSetTableAdapters.tblPurchaseOrderListTableAdapter
End Class
