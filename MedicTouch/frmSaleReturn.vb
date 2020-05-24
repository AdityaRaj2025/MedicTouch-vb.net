Imports System.Data.SqlClient
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class frmSaleReturn
    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap

    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    Dim ri As Integer
    Private Sub frmSaleReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
    End Sub

    Private Sub frmSaleReturn_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub
End Class