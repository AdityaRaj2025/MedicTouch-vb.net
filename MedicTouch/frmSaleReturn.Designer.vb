<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleReturn
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSallingRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaleDate = New System.Windows.Forms.TextBox()
        Me.cbxCustomerName = New System.Windows.Forms.ComboBox()
        Me.txtSaleId = New System.Windows.Forms.TextBox()
        Me.txtYearCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridViewSale = New System.Windows.Forms.DataGridView()
        Me.dgvProductName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvComposition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBatchNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvExpDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPurchaseEntryQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxBatchNo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtSallingAmount = New System.Windows.Forms.TextBox()
        Me.txtDiscountRate = New System.Windows.Forms.TextBox()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtSGSTAmount = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtGSTRate = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCGSTAmount = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.lblFinalGivenAmount = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.cbxPaymentBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnCameraClose = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSallingRate
        '
        Me.dgvSallingRate.HeaderText = "Salling Rate"
        Me.dgvSallingRate.Name = "dgvSallingRate"
        Me.dgvSallingRate.Width = 95
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(695, 15)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.ReadOnly = True
        Me.txtMobileNo.Size = New System.Drawing.Size(115, 22)
        Me.txtMobileNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(575, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Mobile No"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(695, 46)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.ReadOnly = True
        Me.txtCustomerId.Size = New System.Drawing.Size(115, 22)
        Me.txtCustomerId.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(575, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Customer Id"
        '
        'txtSaleDate
        '
        Me.txtSaleDate.Location = New System.Drawing.Point(1156, 31)
        Me.txtSaleDate.Name = "txtSaleDate"
        Me.txtSaleDate.ReadOnly = True
        Me.txtSaleDate.Size = New System.Drawing.Size(115, 22)
        Me.txtSaleDate.TabIndex = 23
        '
        'cbxCustomerName
        '
        Me.cbxCustomerName.FormattingEnabled = True
        Me.cbxCustomerName.Location = New System.Drawing.Point(350, 31)
        Me.cbxCustomerName.Name = "cbxCustomerName"
        Me.cbxCustomerName.Size = New System.Drawing.Size(191, 24)
        Me.cbxCustomerName.TabIndex = 1
        '
        'txtSaleId
        '
        Me.txtSaleId.Location = New System.Drawing.Point(84, 31)
        Me.txtSaleId.Name = "txtSaleId"
        Me.txtSaleId.Size = New System.Drawing.Size(100, 22)
        Me.txtSaleId.TabIndex = 0
        '
        'txtYearCode
        '
        Me.txtYearCode.Location = New System.Drawing.Point(947, 31)
        Me.txtYearCode.Name = "txtYearCode"
        Me.txtYearCode.ReadOnly = True
        Me.txtYearCode.Size = New System.Drawing.Size(100, 22)
        Me.txtYearCode.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(209, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(846, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Year Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1063, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sale Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sale Id"
        '
        'DataGridViewSale
        '
        Me.DataGridViewSale.BackgroundColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewSale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvProductName, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.Column14, Me.dgvComposition, Me.DataGridViewTextBoxColumn4, Me.dgvBatchNo, Me.Column3, Me.dgvExpDate, Me.dgvPurchaseEntryQuantity, Me.Column5, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.dgvSallingRate})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewSale.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewSale.Location = New System.Drawing.Point(2, 103)
        Me.DataGridViewSale.Name = "DataGridViewSale"
        Me.DataGridViewSale.RowHeadersVisible = False
        Me.DataGridViewSale.Size = New System.Drawing.Size(1276, 291)
        Me.DataGridViewSale.TabIndex = 84
        '
        'dgvProductName
        '
        Me.dgvProductName.HeaderText = "Product Name"
        Me.dgvProductName.Name = "dgvProductName"
        Me.dgvProductName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvProductName.Width = 110
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 85
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Category"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 80
        '
        'dgvComposition
        '
        Me.dgvComposition.HeaderText = "Composition"
        Me.dgvComposition.Name = "dgvComposition"
        Me.dgvComposition.ReadOnly = True
        Me.dgvComposition.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComposition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "MRP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'dgvBatchNo
        '
        Me.dgvBatchNo.HeaderText = "Batch No"
        Me.dgvBatchNo.Name = "dgvBatchNo"
        Me.dgvBatchNo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column3
        '
        Me.Column3.HeaderText = "Avilable Stock"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'dgvExpDate
        '
        Me.dgvExpDate.HeaderText = "ExpDate"
        Me.dgvExpDate.Name = "dgvExpDate"
        Me.dgvExpDate.ReadOnly = True
        Me.dgvExpDate.Width = 80
        '
        'dgvPurchaseEntryQuantity
        '
        Me.dgvPurchaseEntryQuantity.HeaderText = "Quantity"
        Me.dgvPurchaseEntryQuantity.Name = "dgvPurchaseEntryQuantity"
        Me.dgvPurchaseEntryQuantity.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 60
        '
        'Column8
        '
        Me.Column8.HeaderText = "GST %"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "SGST Rate"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 60
        '
        'Column10
        '
        Me.Column10.HeaderText = "CGST Rate"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 60
        '
        'Column11
        '
        Me.Column11.HeaderText = "Discount %"
        Me.Column11.Name = "Column11"
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.Width = 70
        '
        'Column12
        '
        Me.Column12.HeaderText = "Discount Rate"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 60
        '
        'cbxBatchNo
        '
        Me.cbxBatchNo.FormattingEnabled = True
        Me.cbxBatchNo.Location = New System.Drawing.Point(540, 82)
        Me.cbxBatchNo.Name = "cbxBatchNo"
        Me.cbxBatchNo.Size = New System.Drawing.Size(99, 21)
        Me.cbxBatchNo.TabIndex = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.txtMobileNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCustomerId)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSaleDate)
        Me.GroupBox1.Controls.Add(Me.cbxCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtSaleId)
        Me.GroupBox1.Controls.Add(Me.txtYearCode)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1276, 74)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Info"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 138)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.btnCancle)
        Me.Panel3.Controls.Add(Me.btnSubmit)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.GroupBox11)
        Me.Panel3.Controls.Add(Me.GroupBox10)
        Me.Panel3.Location = New System.Drawing.Point(2, 391)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1276, 206)
        Me.Panel3.TabIndex = 87
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Teal
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.txtSallingAmount)
        Me.GroupBox2.Controls.Add(Me.txtDiscountRate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(514, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 196)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selling Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Salling Amount"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(6, 66)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(57, 13)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Discount"
        '
        'txtSallingAmount
        '
        Me.txtSallingAmount.Location = New System.Drawing.Point(129, 27)
        Me.txtSallingAmount.Name = "txtSallingAmount"
        Me.txtSallingAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtSallingAmount.TabIndex = 8
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.Location = New System.Drawing.Point(129, 63)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.Size = New System.Drawing.Size(113, 20)
        Me.txtDiscountRate.TabIndex = 7
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(1131, 99)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(136, 37)
        Me.btnCancle.TabIndex = 29
        Me.btnCancle.Text = "Cancle"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(1131, 56)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(136, 37)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Teal
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtAmount)
        Me.GroupBox4.Controls.Add(Me.Label67)
        Me.GroupBox4.Controls.Add(Me.txtSGSTAmount)
        Me.GroupBox4.Controls.Add(Me.Label63)
        Me.GroupBox4.Controls.Add(Me.txtGSTRate)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtCGSTAmount)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(263, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 196)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "SGST Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(118, 133)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtAmount.TabIndex = 18
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(10, 100)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(78, 13)
        Me.Label67.TabIndex = 1
        Me.Label67.Text = "GST Amount"
        '
        'txtSGSTAmount
        '
        Me.txtSGSTAmount.Location = New System.Drawing.Point(118, 57)
        Me.txtSGSTAmount.Name = "txtSGSTAmount"
        Me.txtSGSTAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtSGSTAmount.TabIndex = 22
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(10, 136)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(82, 13)
        Me.Label63.TabIndex = 17
        Me.Label63.Text = "Total Amount"
        '
        'txtGSTRate
        '
        Me.txtGSTRate.Location = New System.Drawing.Point(118, 97)
        Me.txtGSTRate.Name = "txtGSTRate"
        Me.txtGSTRate.Size = New System.Drawing.Size(113, 20)
        Me.txtGSTRate.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "CGST Amount"
        '
        'txtCGSTAmount
        '
        Me.txtCGSTAmount.Location = New System.Drawing.Point(118, 25)
        Me.txtCGSTAmount.Name = "txtCGSTAmount"
        Me.txtCGSTAmount.Size = New System.Drawing.Size(113, 20)
        Me.txtCGSTAmount.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1131, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 37)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox11.Controls.Add(Me.txtRefNo)
        Me.GroupBox11.Controls.Add(Me.lblRefNo)
        Me.GroupBox11.Controls.Add(Me.txtRemark)
        Me.GroupBox11.Controls.Add(Me.lblFinalGivenAmount)
        Me.GroupBox11.Controls.Add(Me.Label64)
        Me.GroupBox11.Controls.Add(Me.Label60)
        Me.GroupBox11.Controls.Add(Me.Label65)
        Me.GroupBox11.Controls.Add(Me.cbxPaymentBy)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(773, 7)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(350, 192)
        Me.GroupBox11.TabIndex = 28
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Given Amount"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(101, 85)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(152, 20)
        Me.txtRefNo.TabIndex = 24
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Location = New System.Drawing.Point(6, 92)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(79, 13)
        Me.lblRefNo.TabIndex = 23
        Me.lblRefNo.Text = "Refernce No"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(101, 121)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(243, 31)
        Me.txtRemark.TabIndex = 13
        '
        'lblFinalGivenAmount
        '
        Me.lblFinalGivenAmount.AutoSize = True
        Me.lblFinalGivenAmount.Font = New System.Drawing.Font("digital display tfb", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalGivenAmount.Location = New System.Drawing.Point(170, 17)
        Me.lblFinalGivenAmount.Name = "lblFinalGivenAmount"
        Me.lblFinalGivenAmount.Size = New System.Drawing.Size(24, 29)
        Me.lblFinalGivenAmount.TabIndex = 22
        Me.lblFinalGivenAmount.Text = "0"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(6, 131)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(50, 13)
        Me.Label64.TabIndex = 5
        Me.Label64.Text = "Remark"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(6, 28)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(117, 13)
        Me.Label60.TabIndex = 21
        Me.Label60.Text = "Final Given Amount"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(6, 60)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(73, 13)
        Me.Label65.TabIndex = 4
        Me.Label65.Text = "Payment By"
        '
        'cbxPaymentBy
        '
        Me.cbxPaymentBy.FormattingEnabled = True
        Me.cbxPaymentBy.Items.AddRange(New Object() {"Cash", "Card", "Paytm", "Net Banking"})
        Me.cbxPaymentBy.Location = New System.Drawing.Point(101, 54)
        Me.cbxPaymentBy.Name = "cbxPaymentBy"
        Me.cbxPaymentBy.Size = New System.Drawing.Size(152, 21)
        Me.cbxPaymentBy.TabIndex = 16
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Teal
        Me.GroupBox10.Controls.Add(Me.btnCameraClose)
        Me.GroupBox10.Controls.Add(Me.btnStart)
        Me.GroupBox10.Controls.Add(Me.btnCapture)
        Me.GroupBox10.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(254, 197)
        Me.GroupBox10.TabIndex = 27
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Prescription Camera "
        '
        'btnCameraClose
        '
        Me.btnCameraClose.Location = New System.Drawing.Point(90, 166)
        Me.btnCameraClose.Name = "btnCameraClose"
        Me.btnCameraClose.Size = New System.Drawing.Size(73, 23)
        Me.btnCameraClose.TabIndex = 107
        Me.btnCameraClose.Text = "Stop"
        Me.btnCameraClose.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(9, 166)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 21)
        Me.btnStart.TabIndex = 106
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(169, 166)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(75, 21)
        Me.btnCapture.TabIndex = 105
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.SlateGray
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(241, 144)
        Me.TableLayoutPanel2.TabIndex = 104
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(122, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 138)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'frmSaleReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1280, 598)
        Me.Controls.Add(Me.DataGridViewSale)
        Me.Controls.Add(Me.cbxBatchNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSaleReturn"
        Me.Text = "frmSaleReturn"
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSallingRate As DataGridViewTextBoxColumn
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaleDate As TextBox
    Friend WithEvents cbxCustomerName As ComboBox
    Friend WithEvents txtSaleId As TextBox
    Friend WithEvents txtYearCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridViewSale As DataGridView
    Friend WithEvents dgvProductName As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents dgvComposition As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents dgvBatchNo As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents dgvExpDate As DataGridViewTextBoxColumn
    Friend WithEvents dgvPurchaseEntryQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents cbxBatchNo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents txtSallingAmount As TextBox
    Friend WithEvents txtDiscountRate As TextBox
    Friend WithEvents btnCancle As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txtSGSTAmount As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents txtGSTRate As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCGSTAmount As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents lblRefNo As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents lblFinalGivenAmount As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents cbxPaymentBy As ComboBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents btnCameraClose As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
End Class
