Imports System.Data.SqlClient
Public Class frmSupplier
    Dim flag As Integer = 0
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    '****************Load Event Code*************************************************************
    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(1110, 585)
        Me.MdiParent = frmMdiAdmin
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        '-----------------------------------------------------------------------------------------------------------

        txtSupplierId.Focus()
        FillDataGridSupplier()
        btnSave.Enabled = False
        txtSupplierId.ReadOnly = False
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
    '*******************Load Event Code End*****************************************************************
    Private Sub frmSupplier_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 2
    End Sub
    '*****************Function Generate Suppiler Id***********************************************************
    Private Sub GenerateSupplierId()
        Dim slno As Integer
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select SupplierId from tblSupplier where year(Date)=" & Today.Year
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            txtSupplierId.Text = sqlDr(0).ToString
        End While
        If (txtSupplierId.Text = vbNullString) Then
            txtSupplierId.Text = "S" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtSupplierId.Text.Substring(1, 5))
            slno = slno + 1
            txtSupplierId.Text = "S" & slno
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub
    '*******************************************DataGrid View Function*********************************************************************
    Private Sub FillDataGridSupplier()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblSupplier"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblSupplier")
        DataGridViewSupplier.DataSource = ds.Tables("tblSupplier")
        sqlCon.Close()
    End Sub
    '*******************ButtonNew Code*************************************************************** 
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtSupplierId.ReadOnly = True
        btnSave.Enabled = True
        GenerateSupplierId()
        FillDataGridSupplier()
        SupplierFormReset()
        flag = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        If flag = 0 Then
            sqlCmd.CommandText = "Select * from tblSupplier"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblSupplier")
            DR = DS.Tables("tblSupplier").NewRow
            DR("SupplierId") = txtSupplierId.Text
            DR("SupplierName") = txtSupplierName.Text
            DR("Address") = txtAddress.Text
            If rdbMale.Checked = True Then
                DR("Gender") = "m"
            Else
                DR("Gender") = "f"
            End If
            DR("MobileNo") = txtContactNo.Text
            DR("DOB") = dtpDOB.Text
            DR("State") = cbxState.Text
            DR("City") = cbxCity.Text
            DR("Pincode") = txtPincode.Text
            DR("Email") = txtEmailId.Text
            DR("PAN") = txtPAN.Text
            DR("GSTIN") = txtGSTIN.Text
            DS.Tables("tblSupplier").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblSupplier")
            MessageBox.Show("Please Smile Supplier Create done successfully...")
        Else
            sqlCmd.CommandText = "Select * from tblSupplier where SupplierId = '" & txtSupplierId.Text & "'"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblSupplier")
            DR = DS.Tables("tblSupplier").Rows(0)
            DR("SupplierId") = txtSupplierId.Text
            DR("SupplierName") = txtSupplierName.Text
            DR("Address") = txtAddress.Text
            If rdbMale.Checked = True Then
                DR("Gender") = "m"
            Else
                DR("Gender") = "f"
            End If
            DR("MobileNo") = txtContactNo.Text
            DR("DOB") = dtpDOB.Text
            DR("State") = cbxState.Text
            DR("City") = cbxCity.Text
            DR("Pincode") = txtPincode.Text
            DR("Email") = txtEmailId.Text
            DR("PAN") = txtGSTIN.Text
            DR("GSTIN") = txtPAN.Text
            MessageBox.Show("Supplier updated successfully...")
        End If
        DR("Date") = Today.Date()
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblSupplier")
        sqlCon.Close()
        GenerateSupplierId()
        btnSave.Enabled = False
        SupplierFormReset()
        FillDataGridSupplier()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSupplierId.Clear()
        txtSupplierId.ReadOnly = False
        txtSupplierId.Focus()
        SupplierFormReset()
    End Sub
    '********************Reset Function************************************************************************************** 
    Private Sub SupplierFormReset()
        txtSupplierName.Clear()
        txtEmailId.Clear()
        txtContactNo.Clear()
        txtPincode.Clear()
        txtAddress.Clear()
        txtGSTIN.Clear()
        txtPAN.Clear()
        If cbxCity.SelectedIndex = -1 Then cbxCity.Text = "Select"
        If cbxState.SelectedIndex = -1 Then cbxCity.Text = "Select"
    End Sub
    '**************btnSearch**************************************************************************
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        flag = 1
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblSupplier  where SupplierId ='" & txtSupplierId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If sqlDr.Read() Then
            txtSupplierId.Text = sqlDr("SupplierId")
            txtSupplierName.Text = sqlDr("SupplierName")
            txtAddress.Text = sqlDr("Address")
            rdbGender.Text = sqlDr("Gender")
            txtContactNo.Text = sqlDr("MobileNo")
            dtpDOB.Text = sqlDr("DOB")
            If IsDBNull(sqlDr("State")) Or sqlDr("State") = "" Then
                cbxState.SelectedIndex = -1
            Else
                cbxState.SelectedItem = sqlDr("State")
            End If
            If IsDBNull(sqlDr("City")) Or sqlDr("City") = "" Then
                cbxCity.SelectedIndex = -1
            Else
                cbxCity.SelectedItem = sqlDr("City")
            End If
            txtPincode.Text = sqlDr("Pincode")
            txtEmailId.Text = sqlDr("Email")
            txtGSTIN.Text = sqlDr("PAN")
            txtPAN.Text = sqlDr("GSTIN")
        Else
            MessageBox.Show(" Sorry No Record Found")
        End If
        btnSave.Enabled = True
        sqlCon.Close()
        sqlDr.Close()
    End Sub
End Class