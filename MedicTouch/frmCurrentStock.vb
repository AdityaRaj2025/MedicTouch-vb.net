Imports System.Data.SqlClient
Public Class frmCurrentStock
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    Private Sub frmCurrentStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(1280, 598)
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblCurrentStock"
        sqlDA.SelectCommand = sqlCmd
        DS.Clear()
        sqlDA.Fill(DS, "tblCurrentStock")
        DataGridViewCurrentStock.DataSource = DS.Tables("tblCurrentStock")
        sqlCon.Close()
    End Sub

    Private Sub frmCurrentStock_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub
End Class