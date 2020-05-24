Imports System.Data.SqlClient
Public Class frmLogin
    Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public DR As DataRow
    Public sqlCB As New SqlCommandBuilder()
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select UserId from  tblLogin where UserId ='" & txtUserName.Text & "'and Password='" & txtPassword.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If (sqlDr.Read()) Then
            sqlCon.Close()
            frmMdiAdmin.Show()
            Me.Close()
        Else
            sqlDr.Close()
            sqlCmd.Connection = sqlCon
            sqlCmd.CommandText = "Select UserName from tblUser where UserName ='" & txtUserName.Text & "'and CreatePassword='" & txtPassword.Text & "'"
            sqlDr = sqlCmd.ExecuteReader()
            If sqlDr.Read() Then
                sqlCon.Close()
                frmMdi.Show()
            Else
                MessageBox.Show("Invalid Username/Password...Please Try Again")
            End If
        End If
        sqlCon.Close()
    End Sub

    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub
End Class