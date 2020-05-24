<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMaster
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnProductMasterClose = New System.Windows.Forms.Button()
        Me.btnProductReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtBatchNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuntity = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpMFGDate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpEXPDate = New System.Windows.Forms.DateTimePicker()
        Me.txtReOrderPoint = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxRackNo = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxWarehouse = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxComposition = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cbxProductCategory = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.cbxProductCompanyName = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cbxProductGST = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtProductMRP = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbxWareHouseCreate = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DataGridViewWarehouse = New System.Windows.Forms.DataGridView()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWareHouseType = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCompanyClose = New System.Windows.Forms.Button()
        Me.btnCompanyEdit = New System.Windows.Forms.Button()
        Me.btnCompanyReset = New System.Windows.Forms.Button()
        Me.DataGridViewCompanyName = New System.Windows.Forms.DataGridView()
        Me.btnCompanyAdd = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCategoryReset = New System.Windows.Forms.Button()
        Me.DataGridViewCategory = New System.Windows.Forms.DataGridView()
        Me.btnCategoryAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnCompositionClose = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridViewComposition = New System.Windows.Forms.DataGridView()
        Me.btnCompositionAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComposition = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRackNumberClose = New System.Windows.Forms.Button()
        Me.btnRackNumberEdit = New System.Windows.Forms.Button()
        Me.btnRackNumberReset = New System.Windows.Forms.Button()
        Me.DataGridViewRackNumber = New System.Windows.Forms.DataGridView()
        Me.btnRackNumberAdd = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtRackNumber = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnGSTClose = New System.Windows.Forms.Button()
        Me.btnGSTEdit = New System.Windows.Forms.Button()
        Me.btnGSTReset = New System.Windows.Forms.Button()
        Me.DataGridViewGSTCreate = New System.Windows.Forms.DataGridView()
        Me.btnGSTAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGSTRate = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbxWareHouseCreate.SuspendLayout()
        CType(Me.DataGridViewWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridViewComposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewRackNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridViewGSTCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1111, 585)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1103, 556)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Product Master"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1097, 288)
        Me.DataGridView1.TabIndex = 39
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Controls.Add(Me.txtReOrderPoint)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Location = New System.Drawing.Point(3, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1096, 133)
        Me.Panel4.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnProductMasterClose)
        Me.Panel5.Controls.Add(Me.btnProductReset)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Location = New System.Drawing.Point(474, 78)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(263, 36)
        Me.Panel5.TabIndex = 40
        '
        'btnProductMasterClose
        '
        Me.btnProductMasterClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProductMasterClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductMasterClose.Location = New System.Drawing.Point(183, 3)
        Me.btnProductMasterClose.Name = "btnProductMasterClose"
        Me.btnProductMasterClose.Size = New System.Drawing.Size(75, 27)
        Me.btnProductMasterClose.TabIndex = 18
        Me.btnProductMasterClose.Text = "Close"
        Me.btnProductMasterClose.UseVisualStyleBackColor = False
        '
        'btnProductReset
        '
        Me.btnProductReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProductReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductReset.Location = New System.Drawing.Point(98, 3)
        Me.btnProductReset.Name = "btnProductReset"
        Me.btnProductReset.Size = New System.Drawing.Size(75, 27)
        Me.btnProductReset.TabIndex = 17
        Me.btnProductReset.Text = "Reset"
        Me.btnProductReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 27)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtBatchNo)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtQuntity)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.dtpMFGDate)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.dtpEXPDate)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(20, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(414, 100)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Product Opening Stock"
        '
        'txtBatchNo
        '
        Me.txtBatchNo.Location = New System.Drawing.Point(291, 28)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Size = New System.Drawing.Size(100, 20)
        Me.txtBatchNo.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(204, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Batch No"
        '
        'txtQuntity
        '
        Me.txtQuntity.Location = New System.Drawing.Point(71, 28)
        Me.txtQuntity.Name = "txtQuntity"
        Me.txtQuntity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuntity.TabIndex = 38
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(6, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 13)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Quntity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(6, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "MFG"
        '
        'dtpMFGDate
        '
        Me.dtpMFGDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMFGDate.Location = New System.Drawing.Point(80, 69)
        Me.dtpMFGDate.Name = "dtpMFGDate"
        Me.dtpMFGDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpMFGDate.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(204, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "EXP.Date"
        '
        'dtpEXPDate
        '
        Me.dtpEXPDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEXPDate.Location = New System.Drawing.Point(291, 69)
        Me.dtpEXPDate.Name = "dtpEXPDate"
        Me.dtpEXPDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpEXPDate.TabIndex = 19
        '
        'txtReOrderPoint
        '
        Me.txtReOrderPoint.Location = New System.Drawing.Point(862, 18)
        Me.txtReOrderPoint.Name = "txtReOrderPoint"
        Me.txtReOrderPoint.Size = New System.Drawing.Size(75, 20)
        Me.txtReOrderPoint.TabIndex = 17
        Me.txtReOrderPoint.Text = "10"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(771, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "ReOrder "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxRackNo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(474, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 56)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rack Entry"
        '
        'cbxRackNo
        '
        Me.cbxRackNo.FormattingEnabled = True
        Me.cbxRackNo.Location = New System.Drawing.Point(103, 24)
        Me.cbxRackNo.Name = "cbxRackNo"
        Me.cbxRackNo.Size = New System.Drawing.Size(88, 24)
        Me.cbxRackNo.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(6, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Rack No"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.btnSearch)
        Me.Panel13.Controls.Add(Me.cbxWarehouse)
        Me.Panel13.Controls.Add(Me.btnNew)
        Me.Panel13.Controls.Add(Me.Label10)
        Me.Panel13.Controls.Add(Me.cbxComposition)
        Me.Panel13.Controls.Add(Me.Label3)
        Me.Panel13.Controls.Add(Me.Label38)
        Me.Panel13.Controls.Add(Me.cbxProductCategory)
        Me.Panel13.Controls.Add(Me.Label31)
        Me.Panel13.Controls.Add(Me.Label32)
        Me.Panel13.Controls.Add(Me.Label33)
        Me.Panel13.Controls.Add(Me.txtProductId)
        Me.Panel13.Controls.Add(Me.txtProductName)
        Me.Panel13.Controls.Add(Me.cbxProductCompanyName)
        Me.Panel13.Controls.Add(Me.Label35)
        Me.Panel13.Controls.Add(Me.cbxProductGST)
        Me.Panel13.Controls.Add(Me.Label37)
        Me.Panel13.Controls.Add(Me.txtProductMRP)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1097, 117)
        Me.Panel13.TabIndex = 36
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(227, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(59, 27)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cbxWarehouse
        '
        Me.cbxWarehouse.FormattingEnabled = True
        Me.cbxWarehouse.Location = New System.Drawing.Point(943, 55)
        Me.cbxWarehouse.Name = "cbxWarehouse"
        Me.cbxWarehouse.Size = New System.Drawing.Size(149, 21)
        Me.cbxWarehouse.TabIndex = 23
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(174, 10)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(52, 27)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(843, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Warehouse"
        '
        'cbxComposition
        '
        Me.cbxComposition.FormattingEnabled = True
        Me.cbxComposition.Location = New System.Drawing.Point(95, 64)
        Me.cbxComposition.Name = "cbxComposition"
        Me.cbxComposition.Size = New System.Drawing.Size(189, 21)
        Me.cbxComposition.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Composition"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(574, 20)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(57, 13)
        Me.Label38.TabIndex = 19
        Me.Label38.Text = "Category"
        '
        'cbxProductCategory
        '
        Me.cbxProductCategory.FormattingEnabled = True
        Me.cbxProductCategory.Location = New System.Drawing.Point(637, 14)
        Me.cbxProductCategory.Name = "cbxProductCategory"
        Me.cbxProductCategory.Size = New System.Drawing.Size(163, 21)
        Me.cbxProductCategory.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(4, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(66, 13)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Product Id"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(290, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 13)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Product Name"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(843, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Company Name"
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(91, 13)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.ReadOnly = True
        Me.txtProductId.Size = New System.Drawing.Size(77, 20)
        Me.txtProductId.TabIndex = 1
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(383, 15)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(171, 20)
        Me.txtProductName.TabIndex = 2
        Me.txtProductName.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbxProductCompanyName
        '
        Me.cbxProductCompanyName.FormattingEnabled = True
        Me.cbxProductCompanyName.Location = New System.Drawing.Point(943, 12)
        Me.cbxProductCompanyName.Name = "cbxProductCompanyName"
        Me.cbxProductCompanyName.Size = New System.Drawing.Size(149, 21)
        Me.cbxProductCompanyName.TabIndex = 5
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(290, 68)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 13)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "MRP Rate"
        '
        'cbxProductGST
        '
        Me.cbxProductGST.FormattingEnabled = True
        Me.cbxProductGST.Location = New System.Drawing.Point(637, 60)
        Me.cbxProductGST.Name = "cbxProductGST"
        Me.cbxProductGST.Size = New System.Drawing.Size(163, 21)
        Me.cbxProductGST.TabIndex = 10
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(574, 64)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(32, 13)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "GST"
        '
        'txtProductMRP
        '
        Me.txtProductMRP.Location = New System.Drawing.Point(383, 68)
        Me.txtProductMRP.Name = "txtProductMRP"
        Me.txtProductMRP.Size = New System.Drawing.Size(171, 20)
        Me.txtProductMRP.TabIndex = 8
        Me.txtProductMRP.Text = "455"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1103, 556)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Warehouse"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.gbxWareHouseCreate)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1086, 216)
        Me.Panel1.TabIndex = 2
        '
        'gbxWareHouseCreate
        '
        Me.gbxWareHouseCreate.Controls.Add(Me.Label25)
        Me.gbxWareHouseCreate.Controls.Add(Me.txtLocation)
        Me.gbxWareHouseCreate.Controls.Add(Me.btnEdit)
        Me.gbxWareHouseCreate.Controls.Add(Me.DataGridViewWarehouse)
        Me.gbxWareHouseCreate.Controls.Add(Me.btnReset)
        Me.gbxWareHouseCreate.Controls.Add(Me.btnClose)
        Me.gbxWareHouseCreate.Controls.Add(Me.btnAdd)
        Me.gbxWareHouseCreate.Controls.Add(Me.Label8)
        Me.gbxWareHouseCreate.Controls.Add(Me.txtWareHouseType)
        Me.gbxWareHouseCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxWareHouseCreate.Location = New System.Drawing.Point(5, 12)
        Me.gbxWareHouseCreate.Name = "gbxWareHouseCreate"
        Me.gbxWareHouseCreate.Size = New System.Drawing.Size(1093, 140)
        Me.gbxWareHouseCreate.TabIndex = 1
        Me.gbxWareHouseCreate.TabStop = False
        Me.gbxWareHouseCreate.Text = "Warehouse Create"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(378, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 16)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocation.Location = New System.Drawing.Point(325, 63)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(198, 22)
        Me.txtLocation.TabIndex = 37
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(99, 100)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'DataGridViewWarehouse
        '
        Me.DataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewWarehouse.Location = New System.Drawing.Point(566, 30)
        Me.DataGridViewWarehouse.Name = "DataGridViewWarehouse"
        Me.DataGridViewWarehouse.Size = New System.Drawing.Size(294, 93)
        Me.DataGridViewWarehouse.TabIndex = 31
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(192, 100)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 33
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(284, 100)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 100)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Please Enter Warehouse Type"
        '
        'txtWareHouseType
        '
        Me.txtWareHouseType.AutoCompleteCustomSource.AddRange(New String() {"Crocin", "Combiflam"})
        Me.txtWareHouseType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtWareHouseType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtWareHouseType.Location = New System.Drawing.Point(15, 63)
        Me.txtWareHouseType.Name = "txtWareHouseType"
        Me.txtWareHouseType.Size = New System.Drawing.Size(198, 22)
        Me.txtWareHouseType.TabIndex = 30
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Panel11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1103, 556)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Company"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.GroupBox4)
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1091, 163)
        Me.Panel11.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCompanyClose)
        Me.GroupBox4.Controls.Add(Me.btnCompanyEdit)
        Me.GroupBox4.Controls.Add(Me.btnCompanyReset)
        Me.GroupBox4.Controls.Add(Me.DataGridViewCompanyName)
        Me.GroupBox4.Controls.Add(Me.btnCompanyAdd)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtCompanyName)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(745, 140)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Company Create"
        '
        'btnCompanyClose
        '
        Me.btnCompanyClose.Location = New System.Drawing.Point(395, 100)
        Me.btnCompanyClose.Name = "btnCompanyClose"
        Me.btnCompanyClose.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyClose.TabIndex = 6
        Me.btnCompanyClose.Text = "Close"
        Me.btnCompanyClose.UseVisualStyleBackColor = True
        '
        'btnCompanyEdit
        '
        Me.btnCompanyEdit.Location = New System.Drawing.Point(233, 100)
        Me.btnCompanyEdit.Name = "btnCompanyEdit"
        Me.btnCompanyEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyEdit.TabIndex = 5
        Me.btnCompanyEdit.Text = "Edit"
        Me.btnCompanyEdit.UseVisualStyleBackColor = True
        '
        'btnCompanyReset
        '
        Me.btnCompanyReset.Location = New System.Drawing.Point(314, 100)
        Me.btnCompanyReset.Name = "btnCompanyReset"
        Me.btnCompanyReset.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyReset.TabIndex = 4
        Me.btnCompanyReset.Text = "Reset"
        Me.btnCompanyReset.UseVisualStyleBackColor = True
        '
        'DataGridViewCompanyName
        '
        Me.DataGridViewCompanyName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompanyName.Location = New System.Drawing.Point(502, 19)
        Me.DataGridViewCompanyName.Name = "DataGridViewCompanyName"
        Me.DataGridViewCompanyName.Size = New System.Drawing.Size(237, 104)
        Me.DataGridViewCompanyName.TabIndex = 3
        '
        'btnCompanyAdd
        '
        Me.btnCompanyAdd.Location = New System.Drawing.Point(152, 100)
        Me.btnCompanyAdd.Name = "btnCompanyAdd"
        Me.btnCompanyAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyAdd.TabIndex = 2
        Me.btnCompanyAdd.Text = "ADD"
        Me.btnCompanyAdd.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 46)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(211, 16)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Please Enter Company Name"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(258, 45)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(218, 20)
        Me.txtCompanyName.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.Panel2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1103, 556)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Category"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1096, 163)
        Me.Panel2.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnCategoryReset)
        Me.GroupBox2.Controls.Add(Me.DataGridViewCategory)
        Me.GroupBox2.Controls.Add(Me.btnCategoryAdd)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCategory)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(745, 140)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create Product Category"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(233, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCategoryReset
        '
        Me.btnCategoryReset.Location = New System.Drawing.Point(314, 100)
        Me.btnCategoryReset.Name = "btnCategoryReset"
        Me.btnCategoryReset.Size = New System.Drawing.Size(75, 23)
        Me.btnCategoryReset.TabIndex = 4
        Me.btnCategoryReset.Text = "Reset"
        Me.btnCategoryReset.UseVisualStyleBackColor = True
        '
        'DataGridViewCategory
        '
        Me.DataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCategory.Location = New System.Drawing.Point(502, 19)
        Me.DataGridViewCategory.Name = "DataGridViewCategory"
        Me.DataGridViewCategory.Size = New System.Drawing.Size(237, 104)
        Me.DataGridViewCategory.TabIndex = 3
        '
        'btnCategoryAdd
        '
        Me.btnCategoryAdd.Location = New System.Drawing.Point(152, 100)
        Me.btnCategoryAdd.Name = "btnCategoryAdd"
        Me.btnCategoryAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCategoryAdd.TabIndex = 2
        Me.btnCategoryAdd.Text = "ADD"
        Me.btnCategoryAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Please Enter Product Category"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(258, 45)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(218, 20)
        Me.txtCategory.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.Panel16)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1103, 556)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Composition"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel16.Controls.Add(Me.GroupBox7)
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1091, 163)
        Me.Panel16.TabIndex = 9
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnCompositionClose)
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.Button5)
        Me.GroupBox7.Controls.Add(Me.DataGridViewComposition)
        Me.GroupBox7.Controls.Add(Me.btnCompositionAdd)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.txtComposition)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(745, 140)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Composition Create"
        '
        'btnCompositionClose
        '
        Me.btnCompositionClose.Location = New System.Drawing.Point(395, 100)
        Me.btnCompositionClose.Name = "btnCompositionClose"
        Me.btnCompositionClose.Size = New System.Drawing.Size(75, 23)
        Me.btnCompositionClose.TabIndex = 6
        Me.btnCompositionClose.Text = "Close"
        Me.btnCompositionClose.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(233, 100)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(314, 100)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Reset"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridViewComposition
        '
        Me.DataGridViewComposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewComposition.Location = New System.Drawing.Point(502, 19)
        Me.DataGridViewComposition.Name = "DataGridViewComposition"
        Me.DataGridViewComposition.Size = New System.Drawing.Size(237, 104)
        Me.DataGridViewComposition.TabIndex = 3
        '
        'btnCompositionAdd
        '
        Me.btnCompositionAdd.Location = New System.Drawing.Point(152, 100)
        Me.btnCompositionAdd.Name = "btnCompositionAdd"
        Me.btnCompositionAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnCompositionAdd.TabIndex = 2
        Me.btnCompositionAdd.Text = "ADD"
        Me.btnCompositionAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Please Enter Composition"
        '
        'txtComposition
        '
        Me.txtComposition.Location = New System.Drawing.Point(209, 44)
        Me.txtComposition.Name = "txtComposition"
        Me.txtComposition.Size = New System.Drawing.Size(218, 20)
        Me.txtComposition.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.Panel10)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1103, 556)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Rack"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.GroupBox3)
        Me.Panel10.Location = New System.Drawing.Point(3, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1091, 163)
        Me.Panel10.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRackNumberClose)
        Me.GroupBox3.Controls.Add(Me.btnRackNumberEdit)
        Me.GroupBox3.Controls.Add(Me.btnRackNumberReset)
        Me.GroupBox3.Controls.Add(Me.DataGridViewRackNumber)
        Me.GroupBox3.Controls.Add(Me.btnRackNumberAdd)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.txtRackNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(745, 140)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rack Setting"
        '
        'btnRackNumberClose
        '
        Me.btnRackNumberClose.Location = New System.Drawing.Point(395, 100)
        Me.btnRackNumberClose.Name = "btnRackNumberClose"
        Me.btnRackNumberClose.Size = New System.Drawing.Size(75, 23)
        Me.btnRackNumberClose.TabIndex = 6
        Me.btnRackNumberClose.Text = "Close"
        Me.btnRackNumberClose.UseVisualStyleBackColor = True
        '
        'btnRackNumberEdit
        '
        Me.btnRackNumberEdit.Location = New System.Drawing.Point(233, 100)
        Me.btnRackNumberEdit.Name = "btnRackNumberEdit"
        Me.btnRackNumberEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnRackNumberEdit.TabIndex = 5
        Me.btnRackNumberEdit.Text = "Edit"
        Me.btnRackNumberEdit.UseVisualStyleBackColor = True
        '
        'btnRackNumberReset
        '
        Me.btnRackNumberReset.Location = New System.Drawing.Point(314, 100)
        Me.btnRackNumberReset.Name = "btnRackNumberReset"
        Me.btnRackNumberReset.Size = New System.Drawing.Size(75, 23)
        Me.btnRackNumberReset.TabIndex = 4
        Me.btnRackNumberReset.Text = "Reset"
        Me.btnRackNumberReset.UseVisualStyleBackColor = True
        '
        'DataGridViewRackNumber
        '
        Me.DataGridViewRackNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRackNumber.Location = New System.Drawing.Point(502, 19)
        Me.DataGridViewRackNumber.Name = "DataGridViewRackNumber"
        Me.DataGridViewRackNumber.Size = New System.Drawing.Size(237, 104)
        Me.DataGridViewRackNumber.TabIndex = 3
        '
        'btnRackNumberAdd
        '
        Me.btnRackNumberAdd.Location = New System.Drawing.Point(152, 100)
        Me.btnRackNumberAdd.Name = "btnRackNumberAdd"
        Me.btnRackNumberAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnRackNumberAdd.TabIndex = 2
        Me.btnRackNumberAdd.Text = "ADD"
        Me.btnRackNumberAdd.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 46)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(195, 16)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Please Enter Rack Number"
        '
        'txtRackNumber
        '
        Me.txtRackNumber.Location = New System.Drawing.Point(258, 45)
        Me.txtRackNumber.Name = "txtRackNumber"
        Me.txtRackNumber.Size = New System.Drawing.Size(218, 20)
        Me.txtRackNumber.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage7.Controls.Add(Me.Panel15)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1103, 556)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "GST"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel15.Controls.Add(Me.GroupBox6)
        Me.Panel15.Location = New System.Drawing.Point(3, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1096, 163)
        Me.Panel15.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnGSTClose)
        Me.GroupBox6.Controls.Add(Me.btnGSTEdit)
        Me.GroupBox6.Controls.Add(Me.btnGSTReset)
        Me.GroupBox6.Controls.Add(Me.DataGridViewGSTCreate)
        Me.GroupBox6.Controls.Add(Me.btnGSTAdd)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txtGSTRate)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(745, 140)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GST RATE Create"
        '
        'btnGSTClose
        '
        Me.btnGSTClose.Location = New System.Drawing.Point(395, 100)
        Me.btnGSTClose.Name = "btnGSTClose"
        Me.btnGSTClose.Size = New System.Drawing.Size(75, 23)
        Me.btnGSTClose.TabIndex = 6
        Me.btnGSTClose.Text = "Close"
        Me.btnGSTClose.UseVisualStyleBackColor = True
        '
        'btnGSTEdit
        '
        Me.btnGSTEdit.Location = New System.Drawing.Point(233, 100)
        Me.btnGSTEdit.Name = "btnGSTEdit"
        Me.btnGSTEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnGSTEdit.TabIndex = 5
        Me.btnGSTEdit.Text = "Edit"
        Me.btnGSTEdit.UseVisualStyleBackColor = True
        '
        'btnGSTReset
        '
        Me.btnGSTReset.Location = New System.Drawing.Point(314, 100)
        Me.btnGSTReset.Name = "btnGSTReset"
        Me.btnGSTReset.Size = New System.Drawing.Size(75, 23)
        Me.btnGSTReset.TabIndex = 4
        Me.btnGSTReset.Text = "Reset"
        Me.btnGSTReset.UseVisualStyleBackColor = True
        '
        'DataGridViewGSTCreate
        '
        Me.DataGridViewGSTCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGSTCreate.Location = New System.Drawing.Point(502, 19)
        Me.DataGridViewGSTCreate.Name = "DataGridViewGSTCreate"
        Me.DataGridViewGSTCreate.Size = New System.Drawing.Size(237, 104)
        Me.DataGridViewGSTCreate.TabIndex = 3
        '
        'btnGSTAdd
        '
        Me.btnGSTAdd.Location = New System.Drawing.Point(152, 100)
        Me.btnGSTAdd.Name = "btnGSTAdd"
        Me.btnGSTAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnGSTAdd.TabIndex = 2
        Me.btnGSTAdd.Text = "ADD"
        Me.btnGSTAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Please Enter GST"
        '
        'txtGSTRate
        '
        Me.txtGSTRate.Location = New System.Drawing.Point(171, 44)
        Me.txtGSTRate.Name = "txtGSTRate"
        Me.txtGSTRate.Size = New System.Drawing.Size(218, 20)
        Me.txtGSTRate.TabIndex = 0
        '
        'frmProductMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1110, 585)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductMaster"
        Me.Text = "Product Master"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.gbxWareHouseCreate.ResumeLayout(False)
        Me.gbxWareHouseCreate.PerformLayout()
        CType(Me.DataGridViewWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridViewCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataGridViewComposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridViewRackNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridViewGSTCreate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnProductMasterClose As Button
    Friend WithEvents btnProductReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtBatchNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuntity As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpMFGDate As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpEXPDate As DateTimePicker
    Friend WithEvents txtReOrderPoint As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxRackNo As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents cbxWarehouse As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxComposition As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents cbxProductCategory As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents cbxProductCompanyName As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents cbxProductGST As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtProductMRP As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbxWareHouseCreate As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents DataGridViewWarehouse As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtWareHouseType As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCompanyClose As Button
    Friend WithEvents btnCompanyEdit As Button
    Friend WithEvents btnCompanyReset As Button
    Friend WithEvents DataGridViewCompanyName As DataGridView
    Friend WithEvents btnCompanyAdd As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCategoryReset As Button
    Friend WithEvents DataGridViewCategory As DataGridView
    Friend WithEvents btnCategoryAdd As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnCompositionClose As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridViewComposition As DataGridView
    Friend WithEvents btnCompositionAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtComposition As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRackNumberClose As Button
    Friend WithEvents btnRackNumberEdit As Button
    Friend WithEvents btnRackNumberReset As Button
    Friend WithEvents DataGridViewRackNumber As DataGridView
    Friend WithEvents btnRackNumberAdd As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txtRackNumber As TextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnGSTClose As Button
    Friend WithEvents btnGSTEdit As Button
    Friend WithEvents btnGSTReset As Button
    Friend WithEvents DataGridViewGSTCreate As DataGridView
    Friend WithEvents btnGSTAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGSTRate As TextBox
End Class
