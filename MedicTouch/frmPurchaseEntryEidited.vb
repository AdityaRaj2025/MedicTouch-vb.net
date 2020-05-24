Imports System.Data.SqlClient
Public Class frmPurchaseEntryEidited
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()

    Private Sub frmPurchaseEntryEidited_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next

        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseEntry "
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxPurchaseId.Items.Add(sqlDr("PurchaseId"))
        End While
        sqlCon.Close()
    End Sub

    Private Sub frmPurchaseEntryEidited_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseEntry  where PurchaseId ='" & cbxPurchaseId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        While sqlDr.Read()
            txtAmount.Text = sqlDr("TotalAmount")
            txtCGSTAmount.Text = sqlDr("CGSTAmount")
            txtDiscountRate.Text = sqlDr("DiscountAmount")
            txtGSTRate.Text = sqlDr("GSTRate")
            txtInvoiceNo.Text = sqlDr("InvoiceNo")
            txtPurchaseAmount.Text = sqlDr("PurchaseAmount")
            txtPurchaseDate.Text = sqlDr("PurchaseRate")
            txtPurchaseSupplierId.Text = sqlDr("SupplierId")
            txtPurchaseYearCode.Text = sqlDr("YearCode")
            txtRefNo.Text = sqlDr("RefNo")
            txtRemark.Text = sqlDr("Remark")
            txtSGSTAmount.Text = sqlDr("SGSTAmount")
            txtSupplierName.Text = sqlDr("SupplierName")
            txtOrderId.Text = sqlDr("OrderId")
            cbxPaymentBy.Text = sqlDr("PaymentBy")
            cbxPurchaseId.Text = sqlDr("PurchaseId")
            txtPurchaseDate.Text = sqlDr("PurchaseDate")
        End While
        sqlCon.Close()

    End Sub

    Private Sub cbxPurchaseId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPurchaseId.SelectedIndexChanged
        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()
        While DataGridViewPurchaseEntryEidited.Rows.Count > 1
            DataGridViewPurchaseEntryEidited.Rows.RemoveAt(0)
        End While
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from  tblPurchaseEntry  Where PurchaseId ='" & cbxPurchaseId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()

        If (sqlDr.Read()) Then
            txtSupplierName.Text = sqlDr("SupplierName")
            txtPurchaseSupplierId.Text = sqlDr("SupplierId")
            txtOrderId.Text = sqlDr("OrderId")
            txtInvoiceNo.Text = sqlDr("InvoiceNo")
            txtPurchaseYearCode.Text = sqlDr("YearCode")
            txtPurchaseDate.Text = sqlDr("PurchaseDate")
            txtDiscountRate.Text = sqlDr("DiscountAmount")
            txtGSTRate.Text = sqlDr("GSTAmount")
            txtPurchaseDate.Text = sqlDr("PurchaseDate")
            cbxPaymentBy.Text = sqlDr("PaymentBy")
            txtAmount.Text = sqlDr("TotalAmount")
            lblFinalAmount.Text = sqlDr("FinalAmount")
            txtPurchaseAmount.Text = sqlDr("PurchaseAmount")
            txtSGSTAmount.Text = sqlDr("SGSTAmount")
            txtCGSTAmount.Text = sqlDr("CGSTAmount")
        Else
            MessageBox.Show(" Sorry No Record.......")
        End If
        sqlDr.Close()
        sqlCon.Close()

        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from  tblStockIn  Where PurchaseId ='" & cbxPurchaseId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        Dim i As Integer = 0
        While sqlDr.Read()
            DataGridViewPurchaseEntryEidited.Rows.Add()
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(0).Value = sqlDr("ProductId")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(1).Value = sqlDr("ProductName")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(2).Value = sqlDr("Company")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(3).Value = sqlDr("Category")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(5).Value = sqlDr("Quantity")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(4).Value = sqlDr("MRP")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(6).Value = sqlDr("Amount")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(7).Value = sqlDr("BatchNo")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(8).Value = sqlDr("ExpDate")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(9).Value = sqlDr("Discount")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(10).Value = sqlDr("DiscountRate")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(11).Value = sqlDr("PurchaseRate")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(12).Value = sqlDr("GST")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(13).Value = sqlDr("SGST%")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(14).Value = sqlDr("SGSTRate")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(15).Value = sqlDr("CGST%")
            DataGridViewPurchaseEntryEidited.Rows(i).Cells(16).Value = sqlDr("CGSTRate")
            ' DataGridViewPurchaseEntryEidited.Rows(i).Cells(17).Value = sqlDr("Warehouse")
            i = i + 1
        End While
        sqlDr.Close()
        sqlCon.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseEntry"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblPurchaseEntry")
        DR = DS.Tables("tblPurchaseEntry").NewRow
        ' DR("PurchaseId") = cbxPurchaseId.Text
        DR("InvoiceNo") = txtInvoiceNo.Text
        DR("OrderId") = txtOrderId.Text
        DR("YearCode") = txtPurchaseYearCode.Text
        DR("DiscountAmount") = txtDiscountRate.Text
        DR("GSTAmount") = txtGSTRate.Text
        DR("PurchaseDate") = txtPurchaseDate.Text
        DR("PaymentBy") = cbxPaymentBy.Text
        DR("TotalAmount") = txtAmount.Text
        DR("FinalAmount") = lblFinalAmount.Text
        DR("PurchaseAmount") = txtPurchaseAmount.Text
        DR("SGSTAmount") = txtSGSTAmount.Text
        DR("CGSTAmount") = txtCGSTAmount.Text
        DR("SupplierName") = txtSupplierName.Text
        DR("SupplierId") = txtPurchaseSupplierId.Text
        DR("Remark") = txtRemark.Text
        DS.Tables("tblPurchaseEntry").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblPurchaseEntry")
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
    End Sub
End Class