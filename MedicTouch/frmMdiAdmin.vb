Public Class frmMdiAdmin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProductMaster.Click
        frmProductMaster.Show()
    End Sub

    Private Sub btnUserCreate_Click(sender As Object, e As EventArgs) Handles btnUserCreate.Click
        frmUser.Show()
    End Sub

    Private Sub btnSupplierCreate_Click(sender As Object, e As EventArgs) Handles btnSupplierCreate.Click
        frmSupplier.Show()
    End Sub

    Private Sub btnPurchaseOrder_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrder.Click
        frmPurchaseOrder.Show()
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        frmStockOut.Show()
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        frmAllReports.Show()
    End Sub

    Private Sub btnCurrentStock_Click(sender As Object, e As EventArgs) Handles btnCurrentStock.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmCustomerReport.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmMdi.Show()
        Me.Close()
    End Sub

    Private Sub frmMdiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next


        Timer1.Start()
        If (DateTime.Now.Hour < 12) Then
            lblGreeting.Text = "Good Morning"
            lblDate.Text = Convert.ToString(DateTime.Now)
        ElseIf (DateTime.Now.Hour < 17) Then
            lblGreeting.Text = "Good Afternoon"
            lblDate.Text = Convert.ToString(DateTime.Now)
        Else
            lblGreeting.Text = "Good Evening"
            lblDate.Text = Convert.ToString(DateTime.Now)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        frmHelp.Show()
    End Sub
End Class