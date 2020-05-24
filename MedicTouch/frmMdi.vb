Public Class frmMdi
    Private Sub frmMdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVoucherName.Text = "Please Select Work"

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
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        FrmCustomer.Show()
        lblVoucherName.Text = "Customer Create"
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        frmPurchaseEntry.Show()
        lblVoucherName.Text = "Purchase Entry"
    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        lblVoucherName.Text = "Sale"
        frmSale.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        frmMdiAdmin.Show()
    End Sub

    Private Sub btnCurrentStock_Click(sender As Object, e As EventArgs) Handles btnCurrentStock.Click
        frmCurrentStock.Show()
        lblVoucherName.Text = "Current Stock"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        frmStockIn.Show()
        lblVoucherName.Text = "Stock In"
    End Sub

    Private Sub btnPurchaseReturn_Click(sender As Object, e As EventArgs) Handles btnPurchaseReturn.Click
        frmPurchaseReturn.Show()
        lblVoucherName.Text = "Purchase Return"
    End Sub

    Private Sub btnSaleReturn_Click(sender As Object, e As EventArgs) Handles btnSaleReturn.Click
        lblVoucherName.Text = "Sales Return"
        frmSaleReturn.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Today.Date.ToString("dd/MM/yyyy")
    End Sub
End Class
