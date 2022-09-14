Imports System.Data.SqlClient
Public Class frmCurrentStock
    Public DS As New DataSet()
    Public DR As DataRow
    Private repo As Repository

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        repo = New Repository()
    End Sub


    Private Sub frmCurrentStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(1280, 598)
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next
        DS.Clear()
        repo.Fill(DS, "tblCurrentStock", "Select * from tblCurrentStock")
        DataGridViewCurrentStock.DataSource = DS.Tables("tblCurrentStock")
        repo.Close()
    End Sub

    Private Sub frmCurrentStock_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub
End Class