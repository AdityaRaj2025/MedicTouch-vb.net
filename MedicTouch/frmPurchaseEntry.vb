Imports System.Data.SqlClient
Public Class frmPurchaseEntry
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    Private Sub frmPurchaseEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(1280, 598)
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        txtInvoiceNo.Focus()
        txtPurchaseDate.Text = Today.Date.ToString("dd/MM/yyyy")
        txtPurchaseYearCode.Text = Today.Year.ToString & "-" & (Today.Year + 1).ToString
        GeneratePurchaseId()
        '***************************************Purchase Order ID CBXfield code*******************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseOrder where status='Open'"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            cbxOrderId.Items.Add(sqlDr("OrderNo"))
        End While
        sqlCon.Close()

    End Sub
    Private Sub frmPurchaseEntry_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub
    '--------------------ID Generate Purchase product function-------------------------------------------
    Private Sub GeneratePurchaseId()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim slno As Integer
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select PurchaseId from tblPurchaseEntry"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            txtPurchaseId.Text = sqlDr(0).ToString
        End While
        If (txtPurchaseId.Text = vbNullString) Then
            txtPurchaseId.Text = "PP" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtPurchaseId.Text.Substring(2, 5))
            slno = slno + 1
            txtPurchaseId.Text = "PP" & slno
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub
    '************Order Number Select Code****************************************
    Private Sub cbxOrderId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrderId.SelectedIndexChanged
        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()
        While DataGridViewPurchaseEntry.Rows.Count > 1
            DataGridViewPurchaseEntry.Rows.RemoveAt(0)
        End While
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from  tblPurchaseOrder  Where OrderNo ='" & cbxOrderId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If (sqlDr.Read()) Then
            txtSupplierName.Text = sqlDr("SupplierName")
            txtPurchaseSupplierId.Text = sqlDr("SupplierId")
        Else
            MessageBox.Show(" Sorry No Order Create")
        End If
        sqlDr.Close()
        sqlCon.Close()

        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from  tblPurchaseOrderList  Where OrderId ='" & cbxOrderId.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        While sqlDr.Read()
            Dim iAmount As Integer = 0
            Dim count As Integer = DataGridViewPurchaseEntry.RowCount
            DataGridViewPurchaseEntry.Rows.Add()
            DataGridViewPurchaseEntry.Rows(count - 1).Cells(0).Value = sqlDr("ProductId")
            DataGridViewPurchaseEntry.Rows(count - 1).Cells(1).Value = sqlDr("ProductName")
            DataGridViewPurchaseEntry.Rows(count - 1).Cells(2).Value = sqlDr("Company")
            DataGridViewPurchaseEntry.Rows(count - 1).Cells(3).Value = sqlDr("Category")
            DataGridViewPurchaseEntry.Rows(count - 1).Cells(5).Value = sqlDr("Quantity")
            DataGridViewPurchaseEntry.Rows(count - 1).Cells(4).Value = sqlDr("MRP")
            DataGridViewPurchaseEntry.Rows(count - 1).Cells(6).Value = DataGridViewPurchaseEntry.Rows(count - 1).Cells(4).Value * DataGridViewPurchaseEntry.Rows(count - 1).Cells(5).Value
        End While
        sqlDr.Close()
        sqlCon.Close()
        '**************Product master for gst k liye********************************************************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        Dim c As Integer = DataGridViewPurchaseEntry.Rows.Count
        Dim i As Integer = 0
        While i <= c - 2
            sqlCmd.CommandText = "Select GST from  tblProductMaster Where ProductId ='" & DataGridViewPurchaseEntry.Rows(i).Cells(0).Value & "'"
            sqlDr = sqlCmd.ExecuteReader()
            If sqlDr.Read() Then
                DataGridViewPurchaseEntry.Rows(i).Cells(12).Value = sqlDr("GST")
                DataGridViewPurchaseEntry.Rows(i).Cells(13).Value = (DataGridViewPurchaseEntry.Rows(i).Cells(12).Value) / 2
                DataGridViewPurchaseEntry.Rows(i).Cells(15).Value = (DataGridViewPurchaseEntry.Rows(i).Cells(12).Value) / 2
            End If
            i += 1
            sqlDr.Close()
        End While
        sqlCon.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblPurchaseEntry"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblPurchaseEntry")
        DR = DS.Tables("tblPurchaseEntry").NewRow
        DR("PurchaseId") = txtPurchaseId.Text
        DR("InvoiceNo") = txtInvoiceNo.Text
        DR("OrderId") = cbxOrderId.Text
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
        '*********Coneection open for StockIn*************************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        Dim sqlDA2 As New SqlDataAdapter()
        sqlCmd.CommandText = "Select * from tblStockIn"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblStockIn")
        For i = 0 To DataGridViewPurchaseEntry.RowCount - 2
            ' MessageBox.Show("Test" & i)
            DR = DS.Tables("tblStockIn").NewRow
            DR("ProductId") = DataGridViewPurchaseEntry.Rows(i).Cells(0).Value
            DR("ProductName") = DataGridViewPurchaseEntry.Rows(i).Cells(1).Value
            DR("Company") = DataGridViewPurchaseEntry.Rows(i).Cells(2).Value
            DR("Category") = DataGridViewPurchaseEntry.Rows(i).Cells(3).Value
            DR("MRP") = DataGridViewPurchaseEntry.Rows(i).Cells(4).Value
            DR("Quantity") = DataGridViewPurchaseEntry.Rows(i).Cells(5).Value
            DR("Amount") = DataGridViewPurchaseEntry.Rows(i).Cells(6).Value
            DR("BatchNo") = DataGridViewPurchaseEntry.Rows(i).Cells(7).Value
            DR("ExpDate") = DataGridViewPurchaseEntry.Rows(i).Cells(8).Value
            DR("Discount") = DataGridViewPurchaseEntry.Rows(i).Cells(9).Value
            DR("DiscountRate") = DataGridViewPurchaseEntry.Rows(i).Cells(10).Value
            DR("PurchaseRate") = DataGridViewPurchaseEntry.Rows(i).Cells(11).Value
            DR("GST") = DataGridViewPurchaseEntry.Rows(i).Cells(12).Value
            DR("SGST%") = DataGridViewPurchaseEntry.Rows(i).Cells(13).Value
            DR("SGSTRate") = DataGridViewPurchaseEntry.Rows(i).Cells(14).Value
            DR("CGST%") = DataGridViewPurchaseEntry.Rows(i).Cells(15).Value
            DR("CGSTRate") = DataGridViewPurchaseEntry.Rows(i).Cells(16).Value
            'DR("Warehouse") = DataGridViewPurchaseEntry.Rows(i).Cells(17).Value
            DR("PurchaseId") = txtPurchaseId.Text
            DS.Tables("tblStockIn").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblStockIn")
        Next i
        sqlCon.Close()
        '***********************************Current Stock********************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblCurrentStock  "
        sqlDA2.SelectCommand = sqlCmd
        sqlDA2.Fill(DS, "tblCurrentStock")

        For i = 0 To DataGridViewPurchaseEntry.RowCount - 2
            DR = DS.Tables("tblCurrentStock").NewRow
            DR("ProductId") = DataGridViewPurchaseEntry.Rows(i).Cells(0).Value
            DR("ProductName") = DataGridViewPurchaseEntry.Rows(i).Cells(1).Value
            DR("BatchNo") = DataGridViewPurchaseEntry.Rows(i).Cells(7).Value
            DR("Quantity") = DataGridViewPurchaseEntry.Rows(i).Cells(5).Value
            DR("ExpDate") = DataGridViewPurchaseEntry.Rows(i).Cells(8).Value
            DR("Company") = DataGridViewPurchaseEntry.Rows(i).Cells(2).Value
            DR("Category") = DataGridViewPurchaseEntry.Rows(i).Cells(3).Value
            DS.Tables("tblCurrentStock").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA2
            sqlDA2.Update(DS, "tblCurrentStock")
        Next i
        sqlCon.Close()
        MessageBox.Show("Purchase Entry done successfully...")
        '-----------------------purchase order staus close --------------------------
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Update tblPurchaseOrder set status='Close' where OrderNo='" & cbxOrderId.Text & "'"
        sqlCmd.ExecuteNonQuery()
        sqlCon.Close()
        GeneratePurchaseId()
        PurchaseProductReset()
        DataGridViewPurchaseEntry.Rows.Clear()
    End Sub
    Private Sub DataGridViewPurchaseEntry_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPurchaseEntry.CellValidated
        If (e.ColumnIndex) Then
            DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(10).Value = (DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(6).Value * DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(9).Value) / 100
            DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(11).Value = DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(6).Value - (DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(6).Value * DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(9).Value) / 100

            DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(14).Value = ((DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(11).Value) * DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(13).Value) / 100
            DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(16).Value = ((DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(11).Value) * DataGridViewPurchaseEntry.Rows(e.RowIndex).Cells(15).Value) / 100
        End If

        Dim iAmount As Integer
        Dim Sgst As Integer
        Dim Cgst As Integer
        Dim Pr As Integer
        Dim pd As Integer
        Dim payment As Integer
        Dim count1 As Integer = DataGridViewPurchaseEntry.RowCount
        For j = 0 To count1 - 1
            iAmount += Convert.ToInt32(DataGridViewPurchaseEntry.Rows(j).Cells(6).Value)
            txtAmount.Text = iAmount
            Sgst += Convert.ToInt32(DataGridViewPurchaseEntry.Rows(j).Cells(14).Value)
            txtSGSTAmount.Text = Sgst
            Cgst += Convert.ToInt32(DataGridViewPurchaseEntry.Rows(j).Cells(16).Value)
            txtCGSTAmount.Text = Cgst
            Pr += Convert.ToInt32(DataGridViewPurchaseEntry.Rows(j).Cells(11).Value)
            txtPurchaseAmount.Text = Pr
            pd += Convert.ToInt32(DataGridViewPurchaseEntry.Rows(j).Cells(10).Value)
            txtDiscountRate.Text = pd
            payment += Convert.ToInt32(DataGridViewPurchaseEntry.Rows(j).Cells(11).Value)
            lblFinalAmount.Text = payment
        Next
        txtGSTRate.Text = CInt(txtSGSTAmount.Text) + (txtCGSTAmount.Text)
    End Sub
    '********************Reset Function in Purchase Product************************************************************************************** 
    Private Sub PurchaseProductReset()
        txtSupplierName.Clear()
        txtDiscountRate.Clear()
        txtGSTRate.Clear()
        cbxPaymentBy.Text = ""
        If cbxOrderId.SelectedIndex = -1 Then cbxOrderId.Text = ""
    End Sub
    '**************************************************Payment Method for cbxPayment*******************************************
    Private Sub cbxPaymentBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPaymentBy.SelectedIndexChanged
        If cbxPaymentBy.Text = "Card" Then
            txtRefNo.Visible = True
            lblRefNo.Visible = True
        ElseIf cbxPaymentBy.Text = "Cash"
            lblRefNo.Visible = False
            txtRefNo.Visible = False
        End If
    End Sub

    Private Sub btnPurchaseEntryClose_Click(sender As Object, e As EventArgs) Handles btnPurchaseEntryClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmPurchaseEntryEidited.Show()
    End Sub
End Class