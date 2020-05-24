<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.DataGridViewUserCreate = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPAN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxCity = New System.Windows.Forms.ComboBox()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCreatePassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblUserStatus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.cbxUserType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckbUserActive = New System.Windows.Forms.CheckBox()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.rdbGender = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.dtbDob = New System.Windows.Forms.DateTimePicker()
        Me.rtxAddress = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMessage = New System.Windows.Forms.Panel()
        Me.RichTextBoxMessage = New System.Windows.Forms.RichTextBox()
        CType(Me.DataGridViewUserCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewUserCreate
        '
        Me.DataGridViewUserCreate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewUserCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUserCreate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewUserCreate.Location = New System.Drawing.Point(0, 431)
        Me.DataGridViewUserCreate.Name = "DataGridViewUserCreate"
        Me.DataGridViewUserCreate.Size = New System.Drawing.Size(1110, 154)
        Me.DataGridViewUserCreate.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(474, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "User Create"
        '
        'txtPAN
        '
        Me.txtPAN.Location = New System.Drawing.Point(544, 135)
        Me.txtPAN.Name = "txtPAN"
        Me.txtPAN.Size = New System.Drawing.Size(270, 20)
        Me.txtPAN.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "PAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(445, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Address"
        '
        'txtPincode
        '
        Me.txtPincode.Location = New System.Drawing.Point(111, 347)
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(171, 20)
        Me.txtPincode.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Pincode"
        '
        'cbxCity
        '
        Me.cbxCity.FormattingEnabled = True
        Me.cbxCity.Location = New System.Drawing.Point(110, 300)
        Me.cbxCity.Name = "cbxCity"
        Me.cbxCity.Size = New System.Drawing.Size(172, 21)
        Me.cbxCity.TabIndex = 31
        '
        'cbxState
        '
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(110, 241)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(172, 21)
        Me.cbxState.TabIndex = 30
        Me.cbxState.Text = "Select"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "State"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtCreatePassword)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(448, 303)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 58)
        Me.Panel4.TabIndex = 71
        '
        'txtCreatePassword
        '
        Me.txtCreatePassword.Location = New System.Drawing.Point(167, 12)
        Me.txtCreatePassword.Name = "txtCreatePassword"
        Me.txtCreatePassword.Size = New System.Drawing.Size(164, 20)
        Me.txtCreatePassword.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Create Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(826, 361)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 64)
        Me.Panel1.TabIndex = 72
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(86, 16)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 35)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(7, 17)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 32)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1073, -3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 23)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(289, 24)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(73, 32)
        Me.btnNew.TabIndex = 53
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(366, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(73, 32)
        Me.btnSearch.TabIndex = 52
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblUserStatus
        '
        Me.lblUserStatus.AutoSize = True
        Me.lblUserStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserStatus.Location = New System.Drawing.Point(445, 401)
        Me.lblUserStatus.Name = "lblUserStatus"
        Me.lblUserStatus.Size = New System.Drawing.Size(88, 16)
        Me.lblUserStatus.TabIndex = 89
        Me.lblUserStatus.Text = "User Status"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 87
        Me.Label17.Text = "User Id"
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(111, 29)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.ReadOnly = True
        Me.txtUserId.Size = New System.Drawing.Size(172, 20)
        Me.txtUserId.TabIndex = 88
        '
        'cbxUserType
        '
        Me.cbxUserType.FormattingEnabled = True
        Me.cbxUserType.Items.AddRange(New Object() {"Fornt User", "Back User"})
        Me.cbxUserType.Location = New System.Drawing.Point(111, 76)
        Me.cbxUserType.Name = "cbxUserType"
        Me.cbxUserType.Size = New System.Drawing.Size(172, 21)
        Me.cbxUserType.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "User Type"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(544, 84)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 20)
        Me.txtEmail.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(445, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(544, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(270, 20)
        Me.txtName.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Mobile No"
        '
        'ckbUserActive
        '
        Me.ckbUserActive.AutoSize = True
        Me.ckbUserActive.Checked = True
        Me.ckbUserActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbUserActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbUserActive.Location = New System.Drawing.Point(544, 401)
        Me.ckbUserActive.Name = "ckbUserActive"
        Me.ckbUserActive.Size = New System.Drawing.Size(107, 20)
        Me.ckbUserActive.TabIndex = 80
        Me.ckbUserActive.Text = "User Active"
        Me.ckbUserActive.UseVisualStyleBackColor = True
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(110, 182)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(173, 20)
        Me.txtMobileNo.TabIndex = 82
        '
        'rdbGender
        '
        Me.rdbGender.AutoSize = True
        Me.rdbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbGender.Location = New System.Drawing.Point(11, 400)
        Me.rdbGender.Name = "rdbGender"
        Me.rdbGender.Size = New System.Drawing.Size(59, 16)
        Me.rdbGender.TabIndex = 74
        Me.rdbGender.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Date of Birth"
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(111, 398)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(57, 19)
        Me.rdbMale.TabIndex = 77
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(209, 398)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(73, 19)
        Me.rdbFemale.TabIndex = 78
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'dtbDob
        '
        Me.dtbDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbDob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbDob.Location = New System.Drawing.Point(111, 128)
        Me.dtbDob.Name = "dtbDob"
        Me.dtbDob.Size = New System.Drawing.Size(172, 22)
        Me.dtbDob.TabIndex = 79
        '
        'rtxAddress
        '
        Me.rtxAddress.Location = New System.Drawing.Point(544, 191)
        Me.rtxAddress.Name = "rtxAddress"
        Me.rtxAddress.Size = New System.Drawing.Size(270, 96)
        Me.rtxAddress.TabIndex = 90
        Me.rtxAddress.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1110, 23)
        Me.Panel2.TabIndex = 91
        '
        'PanelMessage
        '
        Me.PanelMessage.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelMessage.Controls.Add(Me.RichTextBoxMessage)
        Me.PanelMessage.Location = New System.Drawing.Point(880, 28)
        Me.PanelMessage.Name = "PanelMessage"
        Me.PanelMessage.Size = New System.Drawing.Size(218, 259)
        Me.PanelMessage.TabIndex = 92
        '
        'RichTextBoxMessage
        '
        Me.RichTextBoxMessage.BackColor = System.Drawing.SystemColors.MenuText
        Me.RichTextBoxMessage.ForeColor = System.Drawing.SystemColors.Info
        Me.RichTextBoxMessage.Location = New System.Drawing.Point(3, 4)
        Me.RichTextBoxMessage.Name = "RichTextBoxMessage"
        Me.RichTextBoxMessage.Size = New System.Drawing.Size(212, 252)
        Me.RichTextBoxMessage.TabIndex = 0
        Me.RichTextBoxMessage.Text = ""
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1110, 585)
        Me.Controls.Add(Me.PanelMessage)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtPAN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.rtxAddress)
        Me.Controls.Add(Me.txtPincode)
        Me.Controls.Add(Me.lblUserStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.cbxUserType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cbxCity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxState)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckbUserActive)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.rdbGender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rdbMale)
        Me.Controls.Add(Me.rdbFemale)
        Me.Controls.Add(Me.dtbDob)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewUserCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUser"
        Me.Text = "frmUser"
        CType(Me.DataGridViewUserCreate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelMessage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewUserCreate As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPAN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxCity As ComboBox
    Friend WithEvents cbxState As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblUserStatus As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents cbxUserType As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ckbUserActive As CheckBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents rdbGender As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents dtbDob As DateTimePicker
    Friend WithEvents rtxAddress As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelMessage As Panel
    Friend WithEvents RichTextBoxMessage As RichTextBox
End Class
