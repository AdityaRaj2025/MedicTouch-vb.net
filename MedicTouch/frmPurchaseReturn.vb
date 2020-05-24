Imports System.Data.SqlClient
Public Class frmPurchaseReturn
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    Private Sub frmPurchaseReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        txtPurchaseReturnDate.Text = Today.Date.ToString("dd/MM/yyyy")
        txtPurchaseReturnYear.Text = Today.Year.ToString & "-" & (Today.Year + 1).ToString

        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseEntry"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxPurchaseId.Items.Add(sqlDr("PurchaseId"))
        End While
        sqlCon.Close()
        GeneratePurchaseReturnId()
    End Sub

    Private Sub frmPurchaseReturn_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub

    '--------------------ID Generate Purchase product function-------------------------------------------
    Private Sub GeneratePurchaseReturnId()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim slno As Integer
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select PurchaseReturnId from tblPurchaseReturn"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            txtPurchaseReturnId.Text = sqlDr(0).ToString
        End While
        If (txtPurchaseReturnId.Text = vbNullString) Then
            txtPurchaseReturnId.Text = "PR" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtPurchaseReturnId.Text.Substring(2, 5))
            slno = slno + 1
            txtPurchaseReturnId.Text = "PR" & slno
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub

    Private Sub cbxPurchaseReturnId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPurchaseId.SelectedIndexChanged
        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()
        While DataGridViewPurchaseReturn.Rows.Count > 1
            DataGridViewPurchaseReturn.Rows.RemoveAt(0)
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
            DataGridViewPurchaseReturn.Rows.Add()
            DataGridViewPurchaseReturn.Rows(i).Cells(0).Value = sqlDr("ProductId")
            DataGridViewPurchaseReturn.Rows(i).Cells(1).Value = sqlDr("ProductName")
            DataGridViewPurchaseReturn.Rows(i).Cells(2).Value = sqlDr("Company")
            DataGridViewPurchaseReturn.Rows(i).Cells(3).Value = sqlDr("Category")
            DataGridViewPurchaseReturn.Rows(i).Cells(5).Value = sqlDr("Quantity")
            DataGridViewPurchaseReturn.Rows(i).Cells(4).Value = sqlDr("MRP")
            DataGridViewPurchaseReturn.Rows(i).Cells(6).Value = sqlDr("Amount")
            DataGridViewPurchaseReturn.Rows(i).Cells(7).Value = sqlDr("BatchNo")
            DataGridViewPurchaseReturn.Rows(i).Cells(8).Value = sqlDr("ExpDate")
            DataGridViewPurchaseReturn.Rows(i).Cells(9).Value = sqlDr("Discount")
            DataGridViewPurchaseReturn.Rows(i).Cells(10).Value = sqlDr("DiscountRate")
            DataGridViewPurchaseReturn.Rows(i).Cells(11).Value = sqlDr("PurchaseRate")
            DataGridViewPurchaseReturn.Rows(i).Cells(12).Value = sqlDr("GST")
            DataGridViewPurchaseReturn.Rows(i).Cells(13).Value = sqlDr("SGST%")
            DataGridViewPurchaseReturn.Rows(i).Cells(14).Value = sqlDr("SGSTRate")
            DataGridViewPurchaseReturn.Rows(i).Cells(15).Value = sqlDr("CGST%")
            DataGridViewPurchaseReturn.Rows(i).Cells(16).Value = sqlDr("CGSTRate")
            ' DataGridViewPurchaseReturn.Rows(i).Cells(17).Value = sqlDr("Warehouse")
            i = i + 1
        End While
        sqlDr.Close()
        sqlCon.Close()
    End Sub
End Class