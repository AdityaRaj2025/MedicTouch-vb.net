<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.txtSupplierId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtYearCode = New System.Windows.Forms.TextBox()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpExpectedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxSupplierName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.dgvCbxProductName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgvProductId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCustomerIdSearch = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtOrderDate)
        Me.GroupBox3.Controls.Add(Me.txtSupplierId)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtYearCode)
        Me.GroupBox3.Controls.Add(Me.txtMobileNo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dtpExpectedDate)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cbxSupplierName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtOrderNumber)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(0, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1107, 134)
        Me.GroupBox3.TabIndex = 92
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Order Invoice"
        '
        'txtOrderDate
        '
        Me.txtOrderDate.Location = New System.Drawing.Point(636, 27)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.ReadOnly = True
        Me.txtOrderDate.Size = New System.Drawing.Size(115, 22)
        Me.txtOrderDate.TabIndex = 22
        '
        'txtSupplierId
        '
        Me.txtSupplierId.Location = New System.Drawing.Point(897, 88)
        Me.txtSupplierId.Name = "txtSupplierId"
        Me.txtSupplierId.ReadOnly = True
        Me.txtSupplierId.Size = New System.Drawing.Size(100, 22)
        Me.txtSupplierId.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(773, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Suppiler Id"
        '
        'txtYearCode
        '
        Me.txtYearCode.Location = New System.Drawing.Point(399, 27)
        Me.txtYearCode.Name = "txtYearCode"
        Me.txtYearCode.Size = New System.Drawing.Size(100, 22)
        Me.txtYearCode.TabIndex = 18
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(539, 88)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.ReadOnly = True
        Me.txtMobileNo.Size = New System.Drawing.Size(182, 22)
        Me.txtMobileNo.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(406, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Mobile No"
        '
        'dtpExpectedDate
        '
        Me.dtpExpectedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpectedDate.Location = New System.Drawing.Point(897, 28)
        Me.dtpExpectedDate.Name = "dtpExpectedDate"
        Me.dtpExpectedDate.Size = New System.Drawing.Size(113, 22)
        Me.dtpExpectedDate.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(773, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Expected Date"
        '
        'cbxSupplierName
        '
        Me.cbxSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSupplierName.FormattingEnabled = True
        Me.cbxSupplierName.Location = New System.Drawing.Point(153, 86)
        Me.cbxSupplierName.Name = "cbxSupplierName"
        Me.cbxSupplierName.Size = New System.Drawing.Size(212, 24)
        Me.cbxSupplierName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(276, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Suppiler Name"
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.Location = New System.Drawing.Point(137, 30)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtOrderNumber.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(546, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(84, 16)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Order Date"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(30, 31)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 16)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Order No"
        '
        'btnMail
        '
        Me.btnMail.Location = New System.Drawing.Point(648, 4)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(75, 32)
        Me.btnMail.TabIndex = 96
        Me.btnMail.Text = "Mail"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(891, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 95
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(810, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 32)
        Me.btnSearch.TabIndex = 94
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(729, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 91
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(448, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Purchase Order"
        '
        'DGV1
        '
        Me.DGV1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCbxProductName, Me.dgvProductId, Me.dgvCompanyName, Me.Column13, Me.Column1, Me.dgvtxtQuantity})
        Me.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGV1.Location = New System.Drawing.Point(0, 174)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(1109, 372)
        Me.DGV1.TabIndex = 86
        '
        'dgvCbxProductName
        '
        Me.dgvCbxProductName.HeaderText = "Product Name"
        Me.dgvCbxProductName.Name = "dgvCbxProductName"
        Me.dgvCbxProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvCbxProductName.Width = 200
        '
        'dgvProductId
        '
        Me.dgvProductId.FillWeight = 150.0!
        Me.dgvProductId.HeaderText = "Product Id"
        Me.dgvProductId.Name = "dgvProductId"
        Me.dgvProductId.ReadOnly = True
        Me.dgvProductId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvProductId.Width = 150
        '
        'dgvCompanyName
        '
        Me.dgvCompanyName.HeaderText = "Company"
        Me.dgvCompanyName.Name = "dgvCompanyName"
        Me.dgvCompanyName.ReadOnly = True
        Me.dgvCompanyName.Width = 200
        '
        'Column13
        '
        Me.Column13.HeaderText = "Category"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 200
        '
        'Column1
        '
        Me.Column1.HeaderText = "MRP"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 135
        '
        'dgvtxtQuantity
        '
        Me.dgvtxtQuantity.HeaderText = "Quantity"
        Me.dgvtxtQuantity.Name = "dgvtxtQuantity"
        Me.dgvtxtQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtxtQuantity.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 178)
        Me.Panel1.TabIndex = 97
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnMail)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 504)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1110, 81)
        Me.Panel2.TabIndex = 98
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnCustomerIdSearch)
        Me.Panel3.Location = New System.Drawing.Point(209, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(433, 73)
        Me.Panel3.TabIndex = 97
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(18, 16)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 44)
        Me.btnNew.TabIndex = 53
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(342, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(261, 16)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 44)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(99, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 44)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCustomerIdSearch
        '
        Me.btnCustomerIdSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCustomerIdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerIdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerIdSearch.Location = New System.Drawing.Point(180, 16)
        Me.btnCustomerIdSearch.Name = "btnCustomerIdSearch"
        Me.btnCustomerIdSearch.Size = New System.Drawing.Size(75, 44)
        Me.btnCustomerIdSearch.TabIndex = 52
        Me.btnCustomerIdSearch.Text = "Search"
        Me.btnCustomerIdSearch.UseVisualStyleBackColor = False
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1110, 585)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPurchaseOrder"
        Me.Text = "frmPurchaseOrder"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtOrderDate As TextBox
    Friend WithEvents txtSupplierId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtYearCode As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpExpectedDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxSupplierName As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOrderNumber As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents btnMail As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents dgvCbxProductName As DataGridViewComboBoxColumn
    Friend WithEvents dgvProductId As DataGridViewTextBoxColumn
    Friend WithEvents dgvCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCustomerIdSearch As Button
End Class
