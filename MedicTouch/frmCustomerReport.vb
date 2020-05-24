Imports System.Data.SqlClient
Public Class frmCustomerReport
    Private Sub frmCustomerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        Me.MaximumSize = New Size(1110, 585)
        Me.MdiParent = frmMdiAdmin
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        Me.tblCustomerTableAdapter.Fill(Me.dbMedicTouchDataSet.tblCustomer)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmCustomerReport_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 2
    End Sub


End Class