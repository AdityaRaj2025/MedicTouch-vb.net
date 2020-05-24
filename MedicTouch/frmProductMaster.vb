Imports System.Data.SqlClient
Public Class frmProductMaster
    Dim flag As Integer = 0
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    '**************************************Load Event Code**********************************************************************
    Private Sub frmProductMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdiAdmin
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        '*---------------------*-------------------*-------------------*-------------------*------------------*
        txtProductId.Focus()
        btnSave.Enabled = False
        '  txtProductId.ReadOnly = False
        ProductCreateFormReset()
        '------------------ Function Call ---------------------------------------------'
        FillDataGrid()
        FillDataGridCategory()
        FillDataGridCompany()
        FillDataGridProductMaster()
        FillDataGridRack()
        ProductMasterCombox()
        FillDataGridGST()
        FillDataGridComposition()
        Warehouse()
    End Sub
    Private Sub frmProductMaster_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 2
    End Sub
    '****************Function GST Create*******************************************************************
    Private Sub FillDataGridGST()
        Dim sqlcmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlcmd.Connection = sqlCon
        sqlcmd.CommandText = "Select * from tblGST"
        sqlDA.SelectCommand = sqlcmd
        ds.Clear()
        sqlDA.Fill(ds, "tblGST")
        DataGridViewGSTCreate.DataSource = ds.Tables("tblGST")
        sqlCon.Close()
    End Sub
    '****************Function Warehouse Create*******************************************************************
    Private Sub Warehouse()
        Dim sqlcmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlcmd.Connection = sqlCon
        sqlcmd.CommandText = "Select * from tblWarehouse"
        sqlDr = sqlcmd.ExecuteReader()
        While (sqlDr.Read())
            cbxWarehouse.Items.Add(sqlDr("Warehouse"))
        End While
        sqlCon.Close()
    End Sub
    '*************************Function Category Create*******************************************************************
    Private Sub FillDataGridCategory()

        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblCategory"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblCategory")
        DataGridViewCategory.DataSource = ds.Tables("tblCategory")
        sqlCon.Close()
    End Sub
    '------------------------------Medicine Create Rack  function--------------------------------------------
    Private Sub FillDataGridRack()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblRackNo"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblRackNo")
        DataGridViewRackNumber.DataSource = ds.Tables("tblRackNo")
        sqlCon.Close()
    End Sub
    '-------------------- Product Master Function code-------------------------------------------
    Private Sub FillDataGridProductMaster()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblProductMaster"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblProductMaster")
        DataGridView1.DataSource = ds.Tables("tblProductMaster")
        sqlCon.Close()
    End Sub
    '------------------------------------ID Generate Product Id Function for Tab Product Master-------------------------------------------
    Private Sub GenerateProductId()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim slno As Integer
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select ProductId from tblProductMaster"
        'sqlDA.SelectCommand = sqlCmd
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            txtProductId.Text = sqlDr(0).ToString
        End While
        If (txtProductId.Text = vbNullString) Then
            txtProductId.Text = "P" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtProductId.Text.Substring(1, 5))
            slno = slno + 1
            txtProductId.Text = "P" & slno
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub
    '********************Reset Function For Tab Product Master************************************************************************************** 
    Private Sub ProductCreateFormReset()
        cbxProductCompanyName.Text = "Select"
        cbxProductGST.Text = "0"
        cbxRackNo.Text = "Select"
        txtQuntity.Clear()
        FillDataGridProductMaster()
        txtProductMRP.Text = "0"
        txtReOrderPoint.Text = "0"
        txtProductMRP.Text = "0"
    End Sub
    '*******************Tab GST Code**************************************************************
    Private Sub btnGSTAdd_Click(sender As Object, e As EventArgs) Handles btnGSTAdd.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblGST"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblGST")
        DR = DS.Tables("tblGST").NewRow
        DR("GST") = txtGSTRate.Text
        DS.Tables("tblGST").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblGST")
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
        MessageBox.Show("GST RATE Create done successfully...")
        FillDataGridGST()
        cbxProductGST.Items.Add(txtGSTRate.Text)
    End Sub
    '------------------------------Medicine Create Company function--------------------------------------------
    Private Sub FillDataGridCompany()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblCompany"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblCompany")
        DataGridViewCompanyName.DataSource = ds.Tables("tblCompany")
        sqlCon.Close()
    End Sub
    '*******************Function Composition Code********************************************** 
    Private Sub FillDataGridComposition()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblComposition"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblComposition")
        DataGridViewComposition.DataSource = ds.Tables("tblComposition")
        sqlCon.Close()
    End Sub
    '*************Tab Warehouse Code*********************************
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Try
            sqlCon.Open()
            sqlCmd.Connection = sqlCon
            sqlCmd.CommandText = "Select * from tblWarehouse"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblWarehouse")
            DR = DS.Tables("tblWarehouse").NewRow
            DR("Warehouse") = txtWareHouseType.Text
            DR("Place") = txtLocation.Text
            DS.Tables("tblWarehouse").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblWarehouse")
            sqlCB.DataAdapter = Nothing
            MessageBox.Show("Warehouse Create done successfully...")
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Duplicate Entry")
        Finally
            sqlCon.Close()
        End Try
        FillDataGrid()
    End Sub
    '------------------------------Warehouse function--------------------------------------------
    Private Sub FillDataGrid()

        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblWarehouse"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblWarehouses")      'Remember this code event and Carefull
        DataGridViewWarehouse.DataSource = ds.Tables("tblWarehouses")      'Remember this code event and Carefull
        sqlCon.Close()
    End Sub
    '***********************Tab Company Name Code**************************************************
    Private Sub btnCompanyAdd_Click(sender As Object, e As EventArgs) Handles btnCompanyAdd.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblCompany"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblCompany")
        DR = DS.Tables("tblCompany").NewRow
        DR("Company") = txtCompanyName.Text
        DS.Tables("tblCompany").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblCompany")
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
        MessageBox.Show("Company Create done successfully...")
        FillDataGridCompany()
        cbxProductCompanyName.Items.Add(txtCompanyName.Text)
    End Sub
    '****************Tab Category Code*********************************************************************************
    Private Sub btnCategoryAdd_Click(sender As Object, e As EventArgs) Handles btnCategoryAdd.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblCategory"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblCategory")
        DR = DS.Tables("tblCategory").NewRow
        DR("Category") = txtCategory.Text
        DS.Tables("tblCategory").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblCategory")
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
        MessageBox.Show("Product Category Create done successfully...")
        FillDataGridCategory()
        cbxProductCategory.Items.Add(txtCategory.Text)
    End Sub
    '****************************Tab Composition***********************************************************
    Private Sub btnCompositionAdd_Click(sender As Object, e As EventArgs) Handles btnCompositionAdd.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblComposition"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblComposition")
        DR = DS.Tables("tblComposition").NewRow
        DR("Composition") = txtComposition.Text
        DS.Tables("tblComposition").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblComposition")
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
        MessageBox.Show("Product Composition Create done successfully...")
        FillDataGridComposition()
        cbxComposition.Items.Add(txtComposition.Text)
    End Sub
    '***********************************Tab Rack Code********************************************
    Private Sub btnRackNumberAdd_Click(sender As Object, e As EventArgs) Handles btnRackNumberAdd.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblRackNo"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblRackNo")
        DR = DS.Tables("tblRackNo").NewRow
        DR("RackNo") = txtRackNumber.Text
        DS.Tables("tblRackNo").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblRackNo")
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
        MessageBox.Show("Rack Create done successfully...")
        FillDataGridRack()
        cbxRackNo.Items.Add(txtRackNumber.Text)
    End Sub
    '********************************ProductMaster ComboBox Functions******************************************************
    Private Sub ProductMasterCombox()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select Category from tblCategory"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxProductCategory.Items.Add(sqlDr(0).ToString)
        End While
        sqlDr.Close()
        '------------------Next Company ComboBox  -------------------------------------------------------------
        sqlCmd.CommandText = "Select Company from tblCompany"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxProductCompanyName.Items.Add(sqlDr(0).ToString)
        End While
        sqlDr.Close()
        '**************************Next Rack Combobox *************************
        sqlCmd.CommandText = "Select RackNo from tblRackNo"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxRackNo.Items.Add(sqlDr(0).ToString)
        End While
        sqlDr.Close()
        '***********************************Next GST Rate Combox********************************
        sqlCmd.CommandText = "Select GST from tblGST"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxProductGST.Items.Add(sqlDr(0).ToString)
        End While
        sqlDr.Close()
        '***********************************Next Compositation Combobox ********************************
        sqlCmd.CommandText = "Select Composition from tblComposition"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxComposition.Items.Add(sqlDr(0).ToString)
        End While
        sqlDr.Close()
        sqlCon.Close()
    End Sub
    '******************Tab Product Master Code**********************************************************
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        'If txtProductName.Text = String.Empty Then
        '    MessageBox.Show("Please Fill Product Name")
        'Else

        'End If
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        If flag = 0 Then
            sqlCmd.CommandText = "Select * from tblProductMaster"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblProductMaster")
            DR = DS.Tables("tblProductMaster").NewRow
            DR("ProductId") = txtProductId.Text
            DR("ProductName") = txtProductName.Text
            DR("Category") = cbxProductCategory.Text
            DR("Company") = cbxProductCompanyName.Text
            DR("Composition") = cbxComposition.Text
            DR("MRP") = txtProductMRP.Text
            DR("GST") = cbxProductGST.Text
            DR("Warehouse") = cbxWarehouse.Text
            DR("RackNo") = cbxRackNo.Text
            DR("ReOrderPoint") = txtReOrderPoint.Text
            DS.Tables("tblProductMaster").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblProductMaster")
            sqlCB.DataAdapter = Nothing
            MessageBox.Show(" Please Smile Product Create done successfully...")
        Else
            sqlCmd.CommandText = "Select * from tblProductMaster where ProductId = '" & txtProductId.Text & "'"
            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(DS, "tblProductMaster")
            DR = DS.Tables("tblProductMaster").Rows(0)
            'DR("ProductId") = txtProductId.Text
            DR("ProductName") = txtProductName.Text
            DR("Category") = cbxProductCategory.Text
            DR("Company") = cbxProductCompanyName.Text
            DR("Composition") = cbxComposition.Text
            DR("MRP") = txtProductMRP.Text
            If cbxProductGST.Text = "" Then
                DR("GST") = 0
            Else
                DR("GST") = cbxProductGST.Text
            End If
            DR("Warehouse") = cbxWarehouse.Text
            DR("RackNo") = cbxRackNo.Text
            DR("ReOrderPoint") = txtReOrderPoint.Text
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblProductMaster")
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblProductMaster")
            MessageBox.Show("Product updated successfully...")
        End If
        sqlCon.Close()
        ProductCreateFormReset()
        FillDataGridProductMaster()
        GenerateProductId()
    End Sub
    '***************Product Master For Button New Code*****************************
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtProductId.ReadOnly = True
        btnSave.Enabled = True
        GenerateProductId()
        FillDataGridProductMaster()
        ProductCreateFormReset()
        flag = 0
    End Sub
    '**********Product Master For Button Reset Code************************************
    Private Sub btnProductReset_Click(sender As Object, e As EventArgs) Handles btnProductReset.Click
        ProductCreateFormReset()
        txtProductId.Clear()
        txtProductId.ReadOnly = False
        txtProductId.Focus()
    End Sub
    '**********Product Master For Button Search Code************************************
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        flag = 1
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblProductMaster  where ProductId ='" & txtProductId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If sqlDr.Read() Then
            txtProductId.Text = sqlDr("ProductId")
            txtProductName.Text = sqlDr("ProductName")
            cbxProductCompanyName.Text = sqlDr("Company")
            cbxProductCategory.Text = sqlDr("Category")
            cbxComposition.Text = sqlDr("Composition")
            cbxWarehouse.Text = sqlDr("Warehouse")
            txtProductMRP.Text = sqlDr("MRP")
            cbxRackNo.Text = sqlDr("RackNo")
            txtReOrderPoint.Text = sqlDr("ReOrderPoint")
            cbxProductGST.Text = sqlDr("GST")
        Else
            MessageBox.Show(" Sorry No Record Found")
        End If
        btnSave.Enabled = True
        sqlCon.Close()
        sqlDr.Close()
    End Sub
    '***************Product Master Form All Tab Close Button Code********************************************
    Private Sub btnGSTClose_Click(sender As Object, e As EventArgs) Handles btnGSTClose.Click
        Me.Close()
    End Sub
    Private Sub btnProductMasterClose_Click(sender As Object, e As EventArgs) Handles btnProductMasterClose.Click
        Me.Close()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnCompanyClose_Click(sender As Object, e As EventArgs) Handles btnCompanyClose.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub btnCompositionClose_Click(sender As Object, e As EventArgs) Handles btnCompositionClose.Click
        Me.Close()
    End Sub
    Private Sub btnRackNumberClose_Click(sender As Object, e As EventArgs) Handles btnRackNumberClose.Click
        Me.Close()
    End Sub
End Class