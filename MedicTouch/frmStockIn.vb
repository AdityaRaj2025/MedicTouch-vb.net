Imports System.Data.SqlClient
Public Class frmStockIn
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    Private Sub frmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        '  Me.MaximumSize = New Size(1110, 585)
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblStockIn"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblStockIn")
        DataGridViewStockIn.DataSource = ds.Tables("tblStockIn")
        sqlCon.Close()
    End Sub
    Private Sub frmStockIn_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub
    Private Sub DataGridViewStockIn_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStockIn.CellDoubleClick
        frmPurchaseEntryEidited.txtInvoiceNo.Text = DataGridViewStockIn.Rows(e.RowIndex).Cells(0).Value
        frmPurchaseEntryEidited.MdiParent = frmMdi
        frmPurchaseEntryEidited.Show()
        frmPurchaseEntryEidited.btnSearch.PerformClick()
    End Sub
End Class