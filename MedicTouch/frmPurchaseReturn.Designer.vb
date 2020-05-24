<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseReturn
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
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvWareHouse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPurchaseEntryClose = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.lblFinalAmount = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.cbxPaymentBy = New System.Windows.Forms.ComboBox()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPurchaseAmount = New System.Windows.Forms.TextBox()
        Me.txtDiscountRate = New System.Windows.Forms.TextBox()
        Me.txtSGSTAmount = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCGSTAmount = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtGSTRate = New System.Windows.Forms.TextBox()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPurchaseReturnId = New System.Windows.Forms.TextBox()
        Me.txtPurchaseReturnDate = New System.Windows.Forms.TextBox()
        Me.txtPurchaseReturnYear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.txtPurchaseSupplierId = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPurchaseDate = New System.Windows.Forms.TextBox()
        Me.txtPurchaseYearCode = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPurchaseReturn = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMRP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPurchaseEntryQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBatchNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvExpDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPurchaseRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtOrderId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxPurchaseId = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewPurchaseReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(253, 28)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(70, 13)
        Me.Label63.TabIndex = 17
        Me.Label63.Text = "Total Amount"
        '
        'Column6
        '
        Me.Column6.HeaderText = "CGST %"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "CGST Rate"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 50
        '
        'dgvWareHouse
        '
        Me.dgvWareHouse.HeaderText = "Warehouse"
        Me.dgvWareHouse.Name = "dgvWareHouse"
        Me.dgvWareHouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWareHouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvWareHouse.Width = 80
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(888, 466)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(136, 37)
        Me.btnReset.TabIndex = 94
        Me.btnReset.Text = "Search"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(888, 418)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(136, 37)
        Me.btnSubmit.TabIndex = 90
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnPurchaseEntryClose
        '
        Me.btnPurchaseEntryClose.Location = New System.Drawing.Point(888, 515)
        Me.btnPurchaseEntryClose.Name = "btnPurchaseEntryClose"
        Me.btnPurchaseEntryClose.Size = New System.Drawing.Size(136, 37)
        Me.btnPurchaseEntryClose.TabIndex = 91
        Me.btnPurchaseEntryClose.Text = "Close"
        Me.btnPurchaseEntryClose.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Lime
        Me.GroupBox11.Controls.Add(Me.lblRefNo)
        Me.GroupBox11.Controls.Add(Me.txtRefNo)
        Me.GroupBox11.Controls.Add(Me.txtRemark)
        Me.GroupBox11.Controls.Add(Me.lblFinalAmount)
        Me.GroupBox11.Controls.Add(Me.Label64)
        Me.GroupBox11.Controls.Add(Me.Label60)
        Me.GroupBox11.Controls.Add(Me.Label65)
        Me.GroupBox11.Controls.Add(Me.cbxPaymentBy)
        Me.GroupBox11.Location = New System.Drawing.Point(507, 418)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(350, 158)
        Me.GroupBox11.TabIndex = 93
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Payment"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Location = New System.Drawing.Point(9, 92)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(74, 13)
        Me.lblRefNo.TabIndex = 24
        Me.lblRefNo.Text = "Reference No"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(101, 86)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(152, 20)
        Me.txtRefNo.TabIndex = 23
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(101, 121)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(243, 31)
        Me.txtRemark.TabIndex = 13
        '
        'lblFinalAmount
        '
        Me.lblFinalAmount.AutoSize = True
        Me.lblFinalAmount.Font = New System.Drawing.Font("digital display tfb", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalAmount.Location = New System.Drawing.Point(170, 17)
        Me.lblFinalAmount.Name = "lblFinalAmount"
        Me.lblFinalAmount.Size = New System.Drawing.Size(24, 29)
        Me.lblFinalAmount.TabIndex = 22
        Me.lblFinalAmount.Text = "0"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(6, 131)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(44, 13)
        Me.Label64.TabIndex = 5
        Me.Label64.Text = "Remark"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(6, 28)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(103, 13)
        Me.Label60.TabIndex = 21
        Me.Label60.Text = "Final Payble Amount"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(6, 67)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(63, 13)
        Me.Label65.TabIndex = 4
        Me.Label65.Text = "Payment By"
        '
        'cbxPaymentBy
        '
        Me.cbxPaymentBy.FormattingEnabled = True
        Me.cbxPaymentBy.Items.AddRange(New Object() {"Cash", "Card", "Paytm", "Net Banking"})
        Me.cbxPaymentBy.Location = New System.Drawing.Point(101, 61)
        Me.cbxPaymentBy.Name = "cbxPaymentBy"
        Me.cbxPaymentBy.Size = New System.Drawing.Size(152, 21)
        Me.cbxPaymentBy.TabIndex = 16
        '
        'Column9
        '
        Me.Column9.HeaderText = "SGST Rate"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPurchaseAmount)
        Me.GroupBox2.Controls.Add(Me.txtDiscountRate)
        Me.GroupBox2.Controls.Add(Me.txtSGSTAmount)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCGSTAmount)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.Label67)
        Me.GroupBox2.Controls.Add(Me.Label63)
        Me.GroupBox2.Controls.Add(Me.txtGSTRate)
        Me.GroupBox2.Location = New System.Drawing.Point(-6, 418)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 158)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "SGST Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Purchase Amount"
        '
        'txtPurchaseAmount
        '
        Me.txtPurchaseAmount.Location = New System.Drawing.Point(384, 63)
        Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
        Me.txtPurchaseAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtPurchaseAmount.TabIndex = 26
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.Location = New System.Drawing.Point(384, 97)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.Size = New System.Drawing.Size(113, 20)
        Me.txtDiscountRate.TabIndex = 25
        '
        'txtSGSTAmount
        '
        Me.txtSGSTAmount.Location = New System.Drawing.Point(118, 57)
        Me.txtSGSTAmount.Name = "txtSGSTAmount"
        Me.txtSGSTAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtSGSTAmount.TabIndex = 30
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(253, 103)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(49, 13)
        Me.Label68.TabIndex = 23
        Me.Label68.Text = "Discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "CGST Amount"
        '
        'txtCGSTAmount
        '
        Me.txtCGSTAmount.Location = New System.Drawing.Point(118, 25)
        Me.txtCGSTAmount.Name = "txtCGSTAmount"
        Me.txtCGSTAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtCGSTAmount.TabIndex = 28
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(384, 25)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtAmount.TabIndex = 18
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(10, 100)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(68, 13)
        Me.Label67.TabIndex = 1
        Me.Label67.Text = "GST Amount"
        '
        'txtGSTRate
        '
        Me.txtGSTRate.Location = New System.Drawing.Point(118, 97)
        Me.txtGSTRate.Name = "txtGSTRate"
        Me.txtGSTRate.Size = New System.Drawing.Size(113, 20)
        Me.txtGSTRate.TabIndex = 8
        '
        'Column3
        '
        Me.Column3.HeaderText = "SGST%"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.SlateGray
        Me.GroupBox4.Controls.Add(Me.txtPurchaseReturnId)
        Me.GroupBox4.Controls.Add(Me.txtPurchaseReturnDate)
        Me.GroupBox4.Controls.Add(Me.txtPurchaseReturnYear)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(-6, -17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1276, 63)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoice Info"
        '
        'txtPurchaseReturnId
        '
        Me.txtPurchaseReturnId.Location = New System.Drawing.Point(151, 25)
        Me.txtPurchaseReturnId.Name = "txtPurchaseReturnId"
        Me.txtPurchaseReturnId.Size = New System.Drawing.Size(100, 22)
        Me.txtPurchaseReturnId.TabIndex = 37
        '
        'txtPurchaseReturnDate
        '
        Me.txtPurchaseReturnDate.Location = New System.Drawing.Point(1155, 28)
        Me.txtPurchaseReturnDate.Name = "txtPurchaseReturnDate"
        Me.txtPurchaseReturnDate.ReadOnly = True
        Me.txtPurchaseReturnDate.Size = New System.Drawing.Size(115, 22)
        Me.txtPurchaseReturnDate.TabIndex = 36
        '
        'txtPurchaseReturnYear
        '
        Me.txtPurchaseReturnYear.Location = New System.Drawing.Point(785, 28)
        Me.txtPurchaseReturnYear.Name = "txtPurchaseReturnYear"
        Me.txtPurchaseReturnYear.ReadOnly = True
        Me.txtPurchaseReturnYear.Size = New System.Drawing.Size(100, 22)
        Me.txtPurchaseReturnYear.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(672, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Year Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(971, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Purchase Return  Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Purchase Return Id"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(372, 27)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceNo.TabIndex = 30
        '
        'txtPurchaseSupplierId
        '
        Me.txtPurchaseSupplierId.Location = New System.Drawing.Point(85, 67)
        Me.txtPurchaseSupplierId.Name = "txtPurchaseSupplierId"
        Me.txtPurchaseSupplierId.ReadOnly = True
        Me.txtPurchaseSupplierId.Size = New System.Drawing.Size(105, 20)
        Me.txtPurchaseSupplierId.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Suppiler Id"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(372, 71)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.ReadOnly = True
        Me.txtSupplierName.Size = New System.Drawing.Size(214, 20)
        Me.txtSupplierName.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(515, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Order Id"
        '
        'txtPurchaseDate
        '
        Me.txtPurchaseDate.Location = New System.Drawing.Point(1149, 27)
        Me.txtPurchaseDate.Name = "txtPurchaseDate"
        Me.txtPurchaseDate.ReadOnly = True
        Me.txtPurchaseDate.Size = New System.Drawing.Size(115, 20)
        Me.txtPurchaseDate.TabIndex = 23
        '
        'txtPurchaseYearCode
        '
        Me.txtPurchaseYearCode.Location = New System.Drawing.Point(887, 33)
        Me.txtPurchaseYearCode.Name = "txtPurchaseYearCode"
        Me.txtPurchaseYearCode.ReadOnly = True
        Me.txtPurchaseYearCode.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchaseYearCode.TabIndex = 19
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(755, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(123, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Purchase Year Code"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(219, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Suppiler Name"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(1005, 33)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Purchase Date"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(219, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 13)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Invoice No"
        '
        'Column8
        '
        Me.Column8.HeaderText = "GST %"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 50
        '
        'DataGridViewPurchaseReturn
        '
        Me.DataGridViewPurchaseReturn.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridViewPurchaseReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewPurchaseReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchaseReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.dgvCompany, Me.Column14, Me.dgvMRP, Me.dgvPurchaseEntryQuantity, Me.Column5, Me.dgvBatchNo, Me.dgvExpDate, Me.Column11, Me.Column12, Me.dgvPurchaseRate, Me.Column8, Me.Column3, Me.Column9, Me.Column6, Me.Column10, Me.dgvWareHouse})
        Me.DataGridViewPurchaseReturn.Location = New System.Drawing.Point(-6, 152)
        Me.DataGridViewPurchaseReturn.Name = "DataGridViewPurchaseReturn"
        Me.DataGridViewPurchaseReturn.RowHeadersVisible = False
        Me.DataGridViewPurchaseReturn.Size = New System.Drawing.Size(1276, 260)
        Me.DataGridViewPurchaseReturn.TabIndex = 89
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Id"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 120
        '
        'dgvCompany
        '
        Me.dgvCompany.HeaderText = "Company"
        Me.dgvCompany.Name = "dgvCompany"
        Me.dgvCompany.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Category"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'dgvMRP
        '
        Me.dgvMRP.HeaderText = "MRP"
        Me.dgvMRP.Name = "dgvMRP"
        Me.dgvMRP.Width = 60
        '
        'dgvPurchaseEntryQuantity
        '
        Me.dgvPurchaseEntryQuantity.HeaderText = "Quantity"
        Me.dgvPurchaseEntryQuantity.Name = "dgvPurchaseEntryQuantity"
        Me.dgvPurchaseEntryQuantity.ReadOnly = True
        Me.dgvPurchaseEntryQuantity.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 75
        '
        'dgvBatchNo
        '
        Me.dgvBatchNo.HeaderText = "Batch No"
        Me.dgvBatchNo.Name = "dgvBatchNo"
        Me.dgvBatchNo.Width = 80
        '
        'dgvExpDate
        '
        Me.dgvExpDate.HeaderText = "ExpDate"
        Me.dgvExpDate.Name = "dgvExpDate"
        Me.dgvExpDate.Width = 60
        '
        'Column11
        '
        Me.Column11.HeaderText = "Discount %"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 50
        '
        'Column12
        '
        Me.Column12.HeaderText = "Discount Rate"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 50
        '
        'dgvPurchaseRate
        '
        Me.dgvPurchaseRate.HeaderText = "Purchase Rate"
        Me.dgvPurchaseRate.Name = "dgvPurchaseRate"
        Me.dgvPurchaseRate.Width = 75
        '
        'txtOrderId
        '
        Me.txtOrderId.Location = New System.Drawing.Point(600, 32)
        Me.txtOrderId.Name = "txtOrderId"
        Me.txtOrderId.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderId.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxPurchaseId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.txtPurchaseSupplierId)
        Me.GroupBox1.Controls.Add(Me.txtOrderId)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtSupplierName)
        Me.GroupBox1.Controls.Add(Me.txtPurchaseYearCode)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtPurchaseDate)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1267, 100)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Entry Details"
        '
        'cbxPurchaseId
        '
        Me.cbxPurchaseId.FormattingEnabled = True
        Me.cbxPurchaseId.Location = New System.Drawing.Point(85, 27)
        Me.cbxPurchaseId.Name = "cbxPurchaseId"
        Me.cbxPurchaseId.Size = New System.Drawing.Size(105, 21)
        Me.cbxPurchaseId.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Purchase Id"
        '
        'frmPurchaseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1280, 598)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnPurchaseEntryClose)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridViewPurchaseReturn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPurchaseReturn"
        Me.Text = "frmPurchaseReturn"
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridViewPurchaseReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label63 As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents dgvWareHouse As DataGridViewTextBoxColumn
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnPurchaseEntryClose As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents lblRefNo As Label
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents lblFinalAmount As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents cbxPaymentBy As ComboBox
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPurchaseAmount As TextBox
    Friend WithEvents txtDiscountRate As TextBox
    Friend WithEvents txtSGSTAmount As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCGSTAmount As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txtGSTRate As TextBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPurchaseSupplierId As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPurchaseDate As TextBox
    Friend WithEvents txtPurchaseYearCode As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPurchaseReturn As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvCompany As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents dgvMRP As DataGridViewTextBoxColumn
    Friend WithEvents dgvPurchaseEntryQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents dgvBatchNo As DataGridViewTextBoxColumn
    Friend WithEvents dgvExpDate As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents dgvPurchaseRate As DataGridViewTextBoxColumn
    Friend WithEvents txtOrderId As TextBox
    Friend WithEvents txtPurchaseReturnId As TextBox
    Friend WithEvents txtPurchaseReturnDate As TextBox
    Friend WithEvents txtPurchaseReturnYear As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxPurchaseId As ComboBox
    Friend WithEvents Label7 As Label
End Class
