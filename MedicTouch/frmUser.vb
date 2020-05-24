Imports System.Data.SqlClient
Public Class frmUser
    Dim flag As Integer = 0
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    '***********************Laod Event Code***************************************************
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(1110, 585)
        Me.MdiParent = frmMdiAdmin
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next

        RichTextBoxMessage.Text = "First Create Supplier and Save Button Click And Search for search button click"
        '---------------------------------------------------------------------------------------------------------------
        FillDataGridUserCreate()
        btnSave.Enabled = False
        txtUserId.Focus()
        txtUserId.ReadOnly = False


        '*************State Code***************************************************
        'sqlCon.Open()
        'sqlCmd.Connection = sqlCon
        'sqlCmd.CommandText = "Select * from tblState"
        'sqlDr = sqlCmd.ExecuteReader()
        'While (sqlDr.Read())
        '    cbxState.Items.Add(sqlDr("StatesName"))
        'End While
        'sqlDr.Close()
        'sqlCon.Close()
    End Sub

    Private Sub frmUser_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 2
    End Sub
    '************Function User Id Genrate*******************************************
    Private Sub GenerateUserId()
        Dim slno As Integer
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select UserId from tblUser"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            txtUserId.Text = sqlDr(0).ToString
        End While
        If (txtUserId.Text = vbNullString) Then
            txtUserId.Text = "U" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtUserId.Text.Substring(1, 5))
            slno = slno + 1
            txtUserId.Text = "U" & slno
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        If flag = 0 Then
            sqlCmd.CommandText = "Select * from tblUser"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblUser")
            DR = DS.Tables("tblUser").NewRow
            DR("UserId") = txtUserId.Text
            DR("UserType") = cbxUserType.Text
            DR("UserName") = txtName.Text
            DR("DOB") = dtbDob.Text
            DR("MobileNo") = txtMobileNo.Text
            DR("Email") = txtEmail.Text
            If rdbMale.Checked = True Then
                DR("Gender") = "m"
            Else
                DR("Gender") = "f"
            End If
            DR("City") = cbxCity.Text
            DR("State") = cbxState.Text
            If ckbUserActive.Checked = True Then
                DR("UserStatus") = "a"
            End If
            DR("Address") = rtxAddress.Text
            DR("Pincode") = txtPincode.Text
            DR("PAN") = txtPAN.Text
            DR("CreatePassword") = txtCreatePassword.Text
            DS.Tables("tblUser").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblUser")
            sqlCon.Close()
            MessageBox.Show("Please Smile User Create done successfully...")
        Else
            sqlCmd.CommandText = "Select * from tblUser where SupplierId = '" & txtUserId.Text & "'"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblUser")
            DR = DS.Tables("tblUser").Rows(0)
            DR("UserId") = txtUserId.Text
            DR("UserName") = txtName.Text
            DR("UserType") = cbxUserType.Text
            DR("Address") = rtxAddress.Text
            If rdbMale.Checked = True Then
                DR("Gender") = "m"
            Else
                DR("Gender") = "f"
            End If
            DR("MobileNo") = txtMobileNo.Text
            DR("DOB") = dtbDob.Text
            DR("State") = cbxState.Text
            DR("City") = cbxCity.Text
            DR("Pincode") = txtPincode.Text
            DR("Email") = txtEmail.Text
            DR("PAN") = txtPAN.Text
            DR("CreatePassword") = txtCreatePassword.Text
            MessageBox.Show("Please Smile User Updated successfully...")
        End If
        txtUserId.ReadOnly = False
        FormReset()
        FillDataGridUserCreate()
    End Sub
    '.................Reset Code.......................................
    Private Sub FormReset()
        txtMobileNo.Clear()
        txtEmail.Clear()
        txtMobileNo.Clear()
        cbxCity.Text = "Select"
        cbxState.Text = "Select"
        txtPincode.Clear()
        rtxAddress.Clear()
        txtName.Clear()
        txtPAN.Clear()
        txtCreatePassword.Clear()
    End Sub
    '**********Button New Code******************************************************
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cbxUserType.Focus()
        txtUserId.ReadOnly = True
        FormReset()
        GenerateUserId()
        FillDataGridUserCreate()
        btnSave.Enabled = True
        flag = 0
    End Sub
    '****************DataGrid View Function************************************
    Private Sub FillDataGridUserCreate()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblUser"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblUser")
        DataGridViewUserCreate.DataSource = ds.Tables("tblUser")
        sqlCon.Close()
    End Sub
    '*************Button User Search*************************************************************************
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblUser where UserId ='" & txtUserId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If sqlDr.Read() Then
            txtUserId.Text = sqlDr("UserId")
            cbxUserType.Text = sqlDr("UserType")
            txtName.Text = sqlDr("UserName")
            If sqlDr("Gender") = "a" Then
                rdbMale.Checked = True
            Else
                rdbFemale.Checked = False
            End If
            dtbDob.Text = sqlDr("DOB")
            txtMobileNo.Text = sqlDr("MobileNo").ToString
            txtEmail.Text = sqlDr("Email").ToString
            cbxState.Text = sqlDr("State").ToString()
            cbxCity.Text = sqlDr("City").ToString()
            txtPincode.Text = sqlDr("Pincode").ToString()
            txtPAN.Text = sqlDr("PAN").ToString()
            rtxAddress.Text = ("Address")
            txtCreatePassword.Text = sqlDr("CreatePassword")
            If sqlDr("UserStatus") = "a" Then
                ckbUserActive.Checked = True
            Else
                ckbUserActive.Checked = False
            End If
        Else
            MessageBox.Show(" Sorry No Record Found")
        End If
        btnSave.Enabled = True
        sqlCon.Close()
        sqlDr.Close()
    End Sub
    '*************Button Reset****************************************************************
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        FormReset()
        txtUserId.Clear()
        txtUserId.ReadOnly = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class