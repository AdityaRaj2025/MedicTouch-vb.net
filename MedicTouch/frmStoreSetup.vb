Imports System.Data.SqlClient
Public Class frmStoreSetup
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder(sqlDA)
    Private Sub frmStoreSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblToday.Text = Today.Date.ToString
        lblTimeOfDay.Text = TimeOfDay.TimeOfDay.ToString

        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblStoreSetup"
        sqlDr = sqlCmd.ExecuteReader()
        If sqlDr.Read() Then
            txtMedicalStoreName.Text = sqlDr(0)
            txtMallingName.Text = sqlDr(1)
            txtEmail.Text = sqlDr("Email")
            rtbAddress.Text = sqlDr("Address")
            txtContactNo.Text = sqlDr("ContactNo")
            cmbState.Text = sqlDr("State")
            cbxCity.Text = sqlDr("City")
            txtPinCode.Text = sqlDr("Pincode")
            txtLicenseNo.Text = sqlDr("LicenseNo")
            txtPanNo.Text = sqlDr("PAN")
            txtGSTIN.Text = sqlDr("GSTIN")
            cbxCountry.Text = sqlDr("Country")
            txtCreatePassword.Text = sqlDr("CreatePassword")
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCreatePassword.Text = txtConformPassword.Text Then
            sqlCon.Open()
            sqlCmd.Connection = sqlCon
            sqlCmd.CommandText = "Select * from tblStoreSetup"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblStoreSetup")
            DR = DS.Tables("tblStoreSetup").NewRow
            DR("MedicalStoreName") = txtMedicalStoreName.Text
            DR("MallingName") = txtMallingName.Text
            DR("Email") = txtEmail.Text
            DR("ContactNo") = txtContactNo.Text
            DR("State") = cmbState.Text
            DR("City") = cbxCity.Text
            DR("Pincode") = txtPinCode.Text
            DR("Address") = rtbAddress.Text
            DR("LicenseNo") = txtLicenseNo.Text
            DR("PAN") = txtPanNo.Text
            DR("GSTIN") = txtGSTIN.Text
            DR("Country") = cbxCountry.Text
            DR("UserName") = txtUserName.Text
            DR("CreatePassword") = txtCreatePassword.Text
            DR("Date") = lblToday.Text
            DR("Time") = lblTimeOfDay.Text
            DS.Tables("tblStoreSetup").Rows.Add(DR)
            sqlDA.Update(DS, "tblStoreSetup")
            MessageBox.Show("Store Setup Create done successfully...")
            FormReset()
            frmLogin.Show()
            sqlDr.Close()
            Me.Close()
            sqlDr.Close()
            sqlCon.Close()
        Else
            MessageBox.Show("Passwords doesnot match...")
        End If
    End Sub
    Private Sub FormReset()
        txtMedicalStoreName.Clear()
        txtMallingName.Clear()
        txtEmail.Clear()
        txtContactNo.Clear()
        cbxCountry.Text = "Select"
        cmbState.Text = "Select"
        cbxCity.Text = "Select"
        txtPinCode.Clear()
        rtbAddress.Clear()
        txtLicenseNo.Clear()
        txtPanNo.Clear()
        txtUserName.Clear()
        txtCreatePassword.Clear()
        txtConformPassword.Clear()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtMedicalStoreName.Enabled = True
        txtMallingName.Enabled = True
        txtEmail.Enabled = True
        txtContactNo.Enabled = True
    End Sub
End Class