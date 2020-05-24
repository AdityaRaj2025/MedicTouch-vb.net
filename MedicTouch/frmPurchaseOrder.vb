Imports System.Data.SqlClient
Public Class frmPurchaseOrder
    Dim flag As Integer = 0
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()

    '*********************************************Load Time Code*************************************************
    Private Sub frmPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlDR As SqlDataReader
        Dim sqlCmd As New SqlCommand()

        Me.MaximumSize = New Size(1110, 585)
        Me.MdiParent = frmMdiAdmin
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next

        txtOrderDate.Text = Today.Date.ToString("dd/MM/yyyy")
        txtYearCode.Text = Today.Year.ToString & "-" & (Today.Year + 1).ToString
        GenerateOrderId()


        '*************************** This code come to supplier name in cbxSupplierName Event ************************************************************************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblSupplier"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxSupplierName.Items.Add(sqlDr("SupplierName"))
        End While
        sqlCon.Close()
        '*********************Datagridview Combobox select code for product name*****************************************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblProductMaster"
        sqlDr = sqlCmd.ExecuteReader()
        While sqlDr.Read()
            dgvCbxProductName.Items.Add(sqlDr("ProductName"))
        End While
        sqlCon.Close()
    End Sub

    Private Sub frmPurchaseOrder_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 2
    End Sub
    '************************************Purchase Order Id Genrate Code************************************************
    Private Sub GenerateOrderId()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim sqlDR As SqlDataReader
        Dim slno As Integer
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select OrderNo from tblPurchaseOrder"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            txtOrderNumber.Text = sqlDr(0).ToString
        End While
        If (txtOrderNumber.Text = vbNullString) Then
            txtOrderNumber.Text = "PO" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtOrderNumber.Text.Substring(2, 5))
            slno = slno + 1
            txtOrderNumber.Text = "PO" & slno
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseOrder"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblPurchaseOrder")
        DR = DS.Tables("tblPurchaseOrder").NewRow
        DR("OrderNo") = txtOrderNumber.Text
        DR("YearCode") = txtYearCode.Text
        DR("SupplierName") = cbxSupplierName.Text
        DR("OrderDate") = txtOrderDate.Text
        DR("ExpectedDate") = dtpExpectedDate.Text
        DR("MobileNo") = txtMobileNo.Text
        DR("SupplierId") = txtSupplierId.Text
        DR("Status") = "open"
        DS.Tables("tblPurchaseOrder").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblPurchaseOrder")
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
        '^^^Second Table^^^^^^^-----------------------------------------------
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseOrderList"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblPurchaseOrderList")

        For i = 0 To DGV1.RowCount - 2
            DR = DS.Tables("tblPurchaseOrderList").NewRow
            DR("ProductId") = DGV1.Rows(i).Cells(1).Value
            DR("ProductName") = DGV1.Rows(i).Cells(0).Value
            DR("Company") = DGV1.Rows(i).Cells(2).Value
            DR("Category") = DGV1.Rows(i).Cells(3).Value
            DR("MRP") = DGV1.Rows(i).Cells(4).Value
            DR("Quantity") = DGV1.Rows(i).Cells(5).Value
            DR("OrderId") = txtOrderNumber.Text
            DS.Tables("tblPurchaseOrderList").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblPurchaseOrderList")
        Next i
        MessageBox.Show("Purchase Order done successfully...")
        sqlCon.Close()
        DGV1.Rows.Clear()
        PurchaseOrderReset()
        GenerateOrderId()
    End Sub
    '********************Reset Function************************************************************************************** 
    Private Sub PurchaseOrderReset()
        txtSupplierId.Clear()
        txtMobileNo.Clear()
        If cbxSupplierName.SelectedIndex = -1 Then cbxSupplierName.Text = ""
    End Sub
    '************Supplier Details Show code************************************************************************************************
    Private Sub cbxSupplierName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplierName.SelectedIndexChanged
        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from  tblSupplier  Where SupplierName ='" & cbxSupplierName.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If (sqlDr.Read()) Then
            txtSupplierId.Text = sqlDr("SupplierId")
            txtMobileNo.Text = sqlDr("MobileNo")
        Else
            MessageBox.Show("Sorry No Supplier Create")
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub
    '***********Datagridview Product Name combobox Code***********************************************
    Private Sub DGV1_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellValidated
        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        If DGV1.Rows.Count > 1 Then
            sqlCmd.Connection = sqlCon
            sqlCmd.CommandText = "Select * from  tblProductMaster where ProductName ='" & DGV1.Rows(e.RowIndex).Cells(0).Value & "'"
            sqlDr = sqlCmd.ExecuteReader()
            If sqlDr.Read Then
                If e.ColumnIndex = 0 Then
                    DGV1.Rows(e.RowIndex).Cells(1).Value = sqlDr("ProductId")
                    DGV1.Rows(e.RowIndex).Cells(2).Value = sqlDr("Company")
                    DGV1.Rows(e.RowIndex).Cells(3).Value = sqlDr("Category")
                    DGV1.Rows(e.RowIndex).Cells(4).Value = sqlDr("MRP")

                End If
            End If
            sqlDr.Close()
        End If
        sqlCon.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqlDR As SqlDataReader
        Dim sqlCmd As New SqlCommand()

        flag = 1
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseOrder  where OrderNo ='" & txtOrderNumber.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If sqlDr.Read() Then
            txtOrderNumber.Text = sqlDr("OrderNo")
            txtYearCode.Text = sqlDr("YearCode")
            txtOrderDate.Text = sqlDr("OrderDate")
            dtpExpectedDate.Text = sqlDr("ExpectedDate")
            cbxSupplierName.SelectedItem = sqlDR("SupplierName")
            txtSupplierId.Text = sqlDr("SupplierId")
            txtMobileNo.Text = sqlDr("MobileNo")
        Else
            MessageBox.Show("Sorry No Record Found")
            sqlDR.Close()
        End If
        sqlCon.Close()

        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseOrderList where orderId = '" & txtOrderNumber.Text & "'"
        sqlDR = sqlCmd.ExecuteReader()
        Dim i As Integer = 0
        While (sqlDR.Read())
            DGV1.Rows.Add()
            DGV1.Rows(i).Cells(0).Value = sqlDR("ProductName")
            DGV1.Rows(i).Cells(1).Value = sqlDR("ProductId")
            DGV1.Rows(i).Cells(2).Value = sqlDR("company")
            DGV1.Rows(i).Cells(3).Value = sqlDR("Category")
            DGV1.Rows(i).Cells(0).Value = sqlDR("MRP")
            DGV1.Rows(i).Cells(0).Value = sqlDR("Quantity")
            i = i + 1
        End While
        sqlDR.Close()
        sqlCon.Close()
        btnAdd.Enabled = True
    End Sub

    Private Sub DGV1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV1.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class