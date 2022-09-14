Imports System.Data.SqlClient
Public Class frmLogin
    Public sqlDr As SqlDataReader

    Private repo As Repository
    Public sqlCB As New SqlCommandBuilder()

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        repo = New Repository()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sqlCmd As New SqlCommand()
        sqlDr = repo.Query("Select UserId from  tblLogin where UserId ='" & txtUserName.Text & "'and Password='" & txtPassword.Text & "'")
        If (sqlDr.Read()) Then
            repo.Close()
            frmMdiAdmin.Show()
            Me.Close()
        Else
            sqlDr.Close()
            sqlDr = repo.Query("Select UserName from tblUser where UserName ='" & txtUserName.Text & "'and CreatePassword='" & txtPassword.Text & "'")
            If sqlDr.Read() Then
                repo.Close()
                frmMdi.Show()
            Else
                MessageBox.Show("Invalid Username/Password...Please Try Again")
            End If
        End If
        repo.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class