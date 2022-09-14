Imports System.Data.SqlClient
Public Class frmAllReports
    Public sqlCB As New SqlCommandBuilder()
    Private Sub frmAllReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbMedicTouchDataSet.tblPurchaseOrderList' table. You can move, or remove it, as needed.
        Me.tblPurchaseOrderListTableAdapter.Fill(Me.dbMedicTouchDataSet.tblPurchaseOrderList)
        'TODO: This line of code loads data into the 'dbMedicTouchDataSet.tblProductMaster' table. You can move, or remove it, as needed.
        Me.tblProductMasterTableAdapter.Fill(Me.dbMedicTouchDataSet.tblProductMaster)
        ' Me.MdiParent = frmMdiAdmin
        'For i As Integer = 1 To Application.OpenForms.Count - 2
        '    Application.OpenForms.Item(i).Close()
        'Next
        Me.tblCustomerTableAdapter.Fill(Me.dbMedicTouchDataSet.tblCustomer)
        Me.tblCurrentStockTableAdapter.Fill(Me.dbMedicTouchDataSet.tblCurrentStock)
        Me.tblUserTableAdapter.Fill(Me.dbMedicTouchDataSet.tblUser)
        Me.tblSupplierTableAdapter.Fill(Me.dbMedicTouchDataSet.tblSupplier)
        Me.tblSaleTableAdapter.Fill(Me.dbMedicTouchDataSet.tblSale)
        Me.tblStockInTableAdapter.Fill(Me.dbMedicTouchDataSet.tblStockIn)
        Me.tblStockOutTableAdapter.Fill(Me.dbMedicTouchDataSet.tblStockOut)
        Me.tblPurchaseOrderTableAdapter.Fill(Me.dbMedicTouchDataSet.tblPurchaseOrder)
        Me.tblPurchaseEntryTableAdapter.Fill(Me.dbMedicTouchDataSet.tblPurchaseEntry)
        Me.tblProductMasterTableAdapter.Fill(Me.dbMedicTouchDataSet.tblProductMaster)





        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmAllReports_Move(sender As Object, e As EventArgs) Handles Me.Move
        'Me.Left = 1
        'Me.Top = 40
    End Sub

    Private Sub btnCustomerReport_Click(sender As Object, e As EventArgs) Handles btnCustomerReport.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblCustomerBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportCustomer.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnCurrentStock_Click(sender As Object, e As EventArgs) Handles btnCurrentStock.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblCurrentStockBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportCurrentStock.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblSupplierBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportSupplier.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnUserReport_Click(sender As Object, e As EventArgs) Handles btnUserReport.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblUserBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportUser.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnSaleReport_Click(sender As Object, e As EventArgs) Handles btnSaleReport.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblSaleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportSale.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnStockInReport_Click(sender As Object, e As EventArgs) Handles btnStockInReport.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblStockInBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportStockIn.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblStockOutBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportStockOut.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnreportPurchaseEntry_Click(sender As Object, e As EventArgs) Handles btnreportPurchaseEntry.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblPurchaseEntryBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportPurchaseEntry.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPurchaseOrder_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrder.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblPurchaseOrderBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportPurchaseOrder.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnProductMaster_Click(sender As Object, e As EventArgs) Handles btnProductMaster.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblProductMasterBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportProductMaster.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnPurchaseOrderList_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrderList.Click
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblPurchaseOrderListBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.reportPurchaseOrderList.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class