Imports System.Data.SqlClient

Public Class Repository
    Public sqlCon As New SqlConnection("Data Source=LAPTOP-C8JTQ6V8\SERVIDORBANCO;Initial Catalog=MedicTouch;Integrated Security=True;User Id=sa;Password=lucas")
    'Public sqlCon As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=dbMedicTouch;Integrated Security=True")
    Public sqlCmd As New SqlCommand()
    Public sqlDr As SqlDataReader
    Public sqlDA As New SqlDataAdapter()
    Public DS As New DataSet()
    Public sqlCB As New SqlCommandBuilder()

    Public Sub New()
        sqlCmd.Connection = sqlCon
    End Sub


    Private Sub Open()
        If sqlCon.State <> ConnectionState.Open Then
            sqlCon.Open()
        End If
    End Sub

    Public Function Query(CommandText As String) As SqlDataReader

        Open()

        sqlCmd.CommandText = CommandText
        Return sqlCmd.ExecuteReader()

    End Function

    Public Sub Fill(DS As DataSet, TableName As String, CommandText As String)

        Open()

        sqlCmd.CommandText = CommandText
        sqlDA.SelectCommand = sqlCmd

        sqlDA.Fill(DS, TableName)

    End Sub

    Public Sub Update(DS As DataSet, TableName As String)
        Open()
        sqlDA.Update(DS, TableName)
    End Sub

    Public Sub Close()
        sqlCon.Close()
    End Sub

End Class
