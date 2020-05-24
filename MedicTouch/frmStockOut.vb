Imports System.Data.SqlClient
Public Class frmStockOut
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()

    Private Sub frmStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim ds As New DataSet()
        Me.MaximumSize = New Size(1110, 585)
        Me.MdiParent = frmMdiAdmin
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblStockOut"
        sqlDA.SelectCommand = sqlCmd
        ds.Clear()
        sqlDA.Fill(ds, "tblStockOut")
        DataGridViewStockOut.DataSource = ds.Tables("tblStockOut")
        sqlCon.Close()
    End Sub

    Private Sub frmStockOut_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 2
    End Sub
End Class