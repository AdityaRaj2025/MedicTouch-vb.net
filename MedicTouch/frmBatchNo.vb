Imports System.Data.SqlClient
Public Class frmBatchNo
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    Dim i As Integer

    Private Sub frmBatchNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi

    End Sub
    Private Sub cbxBatchNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBatchNo.SelectedIndexChanged

        frmSale.DataGridViewSale.Rows(i).Cells(6).Value = cbxBatchNo.Text
        Me.Close()
    End Sub

    Public Sub getRowIndex(index As Integer)
        i = index
    End Sub
    Private Sub frmBatchNo_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 70
        Me.Top = 200
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class