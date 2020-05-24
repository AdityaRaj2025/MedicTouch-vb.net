Imports System.Data.SqlClient
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class frmSale
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

    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(1280, 598)
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next

        GenerateSaleId()
        txtSaleDate.Text = Today.Date.ToString("dd/MM/yyyy")
        txtYearCode.Text = Today.Year.ToString & "-" & (Today.Year + 1).ToString
        '*************************Sale DataGridView Product Name comboBox Code*****************************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select ProductName from tblProductMaster"
        sqlDr = sqlCmd.ExecuteReader()
        While sqlDr.Read()
            dgvProductName.Items.Add(sqlDr("ProductName"))
        End While
        sqlCon.Close()
        '*************************Customer Name ComboBox Come*************************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblCustomer"
        sqlDr = sqlCmd.ExecuteReader()
        While sqlDr.Read()
            cbxCustomerName.Items.Add(sqlDr("CustomerName"))
        End While
        sqlCon.Close()
        ''***********Composition add of grid combobox************************
        'sqlCon.Open()
        'sqlCmd.Connection = sqlCon
        'sqlCmd.CommandText = "Select * from tblComposition"
        'sqlDr = sqlCmd.ExecuteReader()
        'While sqlDr.Read()
        '    dgvComposition.Items.Add(sqlDr("Composition"))
        'End While
        'sqlCon.Close()
    End Sub
    Private Sub frmSale_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub
    '------------****************************-ID Generate Function for frmSale----************************************************************
    Private Sub GenerateSaleId()
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        Dim slno As Integer
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select SaleId from tblSale"
        sqlDr = sqlCmd.ExecuteReader()
        While (sqlDr.Read())
            txtSaleId.Text = sqlDr(0).ToString
        End While
        If (txtSaleId.Text = vbNullString) Then
            txtSaleId.Text = "S" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtSaleId.Text.Substring(1, 5))
            slno = slno + 1
            txtSaleId.Text = "S" & slno
        End If
        sqlDr.Close()
        sqlCon.Close()
    End Sub

    '*******Button Subbmit Code*******************************************
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim sqlCmd As New SqlCommand()
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblSale"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblSale")
        DR = DS.Tables("tblSale").NewRow
        DR("SaleId") = txtSaleId.Text
        DR("CustomerName") = cbxCustomerName.Text
        DR("CustomerId") = txtCustomerId.Text
        DR("YearCode") = txtYearCode.Text
        DR("SaleDate") = txtSaleDate.Text
        DR("DiscountAmount") = txtDiscountRate.Text
        DR("GSTAmount") = txtGSTRate.Text
        DR("PaymentBy") = cbxPaymentBy.Text
        DR("TotalAmount") = txtAmount.Text
        DR("FinalGivenAmount") = lblFinalGivenAmount.Text
        DR("SallingAmount") = txtSallingAmount.Text
        DR("SGSTAmount") = txtSGSTAmount.Text
        DR("CGSTAmount") = txtCGSTAmount.Text
        DR("Remark") = txtRemark.Text

        DS.Tables("tblSale").Rows.Add(DR)
        sqlCB.DataAdapter = sqlDA
        sqlDA.Update(DS, "tblSale")
        '------------------------------------ Insert Image -----------------------------
        If Not PrescriptionImage.Image Is Nothing Then
            Dim ms As New MemoryStream
            'PrescriptionImage.Image.Save(ms, PrescriptionImage.Image.RawFormat)
            sqlCmd.Connection = sqlCon
            sqlCmd.CommandText = "Update tblSale set PrescriptionImage = @photo where SaleId=' " & txtSaleId.Text & "'"
            Dim p As New SqlParameter("@photo", SqlDbType.Image)
            p.Value = ms.GetBuffer
            sqlCmd.Parameters.Add(p)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("try")
        End If
        sqlCB.DataAdapter = Nothing
        sqlCon.Close()
        '*********tblStockOut Code for salling time*********************************************
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from tblStockOut"
        sqlDA.SelectCommand = sqlCmd
        sqlDA.Fill(DS, "tblStockOut")
        For i = 0 To DataGridViewSale.RowCount - 2
            DR = DS.Tables("tblStockOut").NewRow
            DR("SaleId") = txtSaleId.Text
            DR("ProductName") = DataGridViewSale.Rows(i).Cells(0).Value
            DR("ProductId") = DataGridViewSale.Rows(i).Cells(1).Value
            DR("Company") = DataGridViewSale.Rows(i).Cells(2).Value
            DR("Category") = DataGridViewSale.Rows(i).Cells(3).Value
            DR("Composition") = DataGridViewSale.Rows(i).Cells(4).Value
            DR("MRP") = DataGridViewSale.Rows(i).Cells(5).Value
            DR("BatchNo") = DataGridViewSale.Rows(i).Cells(6).Value
            DR("ExpDate") = DataGridViewSale.Rows(i).Cells(8).Value
            DR("Quantity") = DataGridViewSale.Rows(i).Cells(9).Value
            DR("Amount") = DataGridViewSale.Rows(i).Cells(10).Value
            DR("GST") = DataGridViewSale.Rows(i).Cells(11).Value
            DR("SGSTRate") = DataGridViewSale.Rows(i).Cells(12).Value
            DR("CGSTRate") = DataGridViewSale.Rows(i).Cells(13).Value
            DR("Discount") = DataGridViewSale.Rows(i).Cells(14).Value
            DR("DiscountRate") = DataGridViewSale.Rows(i).Cells(15).Value
            DR("SallingRate") = DataGridViewSale.Rows(i).Cells(16).Value
            DS.Tables("tblStockOut").Rows.Add(DR)
            sqlCB.DataAdapter = sqlDA
            sqlDA.Update(DS, "tblStockOut")
        Next i
        sqlDr.Close()
        sqlCon.Close()

        '*******************Current Stock Update*************************
        Dim sqlCmd2 As New SqlCommand()
        Dim sqlDA2 As New SqlDataAdapter()
        Dim DS2 As New DataSet()
        'Dim DR2 As New DataRow
        sqlCon.Open()
        sqlCmd2.Connection = sqlCon
        For i = 0 To DataGridViewSale.RowCount - 2
            sqlCmd2.CommandText = "Select * from  tblCurrentStock where BatchNo ='" & DataGridViewSale.Rows(i).Cells(6).Value & "'"
            sqlDA2.SelectCommand = sqlCmd2
            sqlDA2.Fill(DS2, "tblCurrentStock")
            DR = DS2.Tables("tblCurrentStock").Rows(0)
            DR("Quantity") = DataGridViewSale.Rows(i).Cells(7).Value - DataGridViewSale.Rows(i).Cells(9).Value
            sqlCB.DataAdapter = sqlDA2
            sqlDA2.Update(DS2, "tblCurrentStock")
        Next i
        sqlDr.Close()
        sqlCon.Close()
        MessageBox.Show("Sale successfully...")
        GenerateSaleId()
    End Sub

    Private Sub DataGridViewSale_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSale.CellValidated

        '  MessageBox.Show("Try0")

        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()

        '---------------Calculating Discount rate and selling rate -----------------------------------
        If (e.ColumnIndex = 14) Then
            DataGridViewSale.Rows(e.RowIndex).Cells(15).Value = (DataGridViewSale.Rows(e.RowIndex).Cells(10).Value * DataGridViewSale.Rows(e.RowIndex).Cells(14).Value) / 100
            DataGridViewSale.Rows(e.RowIndex).Cells(16).Value = DataGridViewSale.Rows(e.RowIndex).Cells(10).Value - (DataGridViewSale.Rows(e.RowIndex).Cells(10).Value * DataGridViewSale.Rows(e.RowIndex).Cells(14).Value) / 100
        End If


        '----- Fetching product details --------------------

        If DataGridViewSale.Rows.Count > 1 And e.ColumnIndex = 0 Then
            sqlCon.Open()
            sqlCmd.Connection = sqlCon
            sqlCmd.CommandText = "Select * from  tblProductMaster where ProductName ='" & DataGridViewSale.Rows(e.RowIndex).Cells(0).Value & "'"
            sqlDr = sqlCmd.ExecuteReader()

            If sqlDr.Read Then
                DataGridViewSale.Rows(e.RowIndex).Cells(1).Value = sqlDr("ProductId")
                DataGridViewSale.Rows(e.RowIndex).Cells(2).Value = sqlDr("Company")
                DataGridViewSale.Rows(e.RowIndex).Cells(3).Value = sqlDr("Category")
                DataGridViewSale.Rows(e.RowIndex).Cells(4).Value = sqlDr("Composition")
                DataGridViewSale.Rows(e.RowIndex).Cells(5).Value = sqlDr("MRP")
                DataGridViewSale.Rows(e.RowIndex).Cells(11).Value = sqlDr("GST")
            End If
        End If

        If (e.ColumnIndex = 9) Then
            '------------Put Quantity and Show Amount Or Calculate SGST and CGST for Amount------------------------------
            Dim count As Integer = DataGridViewSale.RowCount
            For i = 0 To count - 2
                Dim a As Integer
                a = DataGridViewSale.Rows(i).Cells(11).Value / 2
                DataGridViewSale.Rows(i).Cells(10).Value = DataGridViewSale.Rows(i).Cells(5).Value * DataGridViewSale.Rows(i).Cells(9).Value
                DataGridViewSale.Rows(i).Cells(12).Value = (DataGridViewSale.Rows(i).Cells(10).Value * a) / 100
                DataGridViewSale.Rows(i).Cells(13).Value = (DataGridViewSale.Rows(i).Cells(10).Value * a) / 100
            Next
        End If
        sqlCon.Close()



        '------EVENT IS FIRING TWICE----------
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select BatchNo from  tblCurrentStock where ProductName='" & DataGridViewSale.Rows(e.RowIndex).Cells(0).Value & "'"
        ' MessageBox.Show(sqlCmd.CommandText)
        sqlDr = sqlCmd.ExecuteReader()
        ri = e.RowIndex
        cbxBatchNo.Items.Clear()
        cbxBatchNo.Text = ""

        While sqlDr.Read()
            cbxBatchNo.Items.Add(sqlDr("BatchNo"))
        End While
        sqlDr.Close()
        sqlCon.Close()

        '-----Select BatchNo for tblCurrentStock and Show ExpDate nd AbilableStock------------------------

        If DataGridViewSale.Rows.Count > 1 And e.ColumnIndex = 6 Then
            sqlCon.Open()
            sqlCmd.Connection = sqlCon
            sqlCmd.CommandText = "Select * from  tblCurrentStock where BatchNo ='" & DataGridViewSale.Rows(e.RowIndex).Cells(6).Value & "'"
            sqlDr = sqlCmd.ExecuteReader()
            If sqlDr.Read Then
                DataGridViewSale.Rows(e.RowIndex).Cells(8).Value = sqlDr("ExpDate")
                DataGridViewSale.Rows(e.RowIndex).Cells(7).Value = sqlDr("Quantity")
            End If
            sqlDr.Close()
        End If
        sqlCon.Close()

        '------Calculate ProductPrice SellingPrice and GivenAmount for TextBox Code-------------------------------------------------
        Dim iAmount As Integer
        Dim Sgst As Integer
        Dim Cgst As Integer
        Dim Pr As Integer
        Dim pd As Integer
        Dim payment As Integer
        Dim count1 As Integer = DataGridViewSale.RowCount
        For j = 0 To count1 - 1
            iAmount += Convert.ToInt32(DataGridViewSale.Rows(j).Cells(16).Value)
            txtAmount.Text = iAmount
            Sgst += Convert.ToInt32(DataGridViewSale.Rows(j).Cells(12).Value)
            txtSGSTAmount.Text = Sgst
            Cgst += Convert.ToInt32(DataGridViewSale.Rows(j).Cells(13).Value)
            txtCGSTAmount.Text = Cgst
            Pr += Convert.ToInt32(DataGridViewSale.Rows(j).Cells(16).Value)
            txtSallingAmount.Text = Pr
            pd += Convert.ToInt32(DataGridViewSale.Rows(j).Cells(15).Value)
            txtDiscountRate.Text = pd
            payment += Convert.ToInt32(DataGridViewSale.Rows(j).Cells(16).Value)
            lblFinalGivenAmount.Text = payment
        Next
        txtGSTRate.Text = CInt(txtSGSTAmount.Text) + (txtCGSTAmount.Text)
    End Sub

    '*********************************************cbxCustomer Slect code and dispaly details*******************************************
    Private Sub cbxCustomerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomerName.SelectedIndexChanged
        Dim sqlCmd As New SqlCommand()
        Dim sqlDr As SqlDataReader
        Dim sqlDA As New SqlDataAdapter()
        sqlCon.Open()
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandText = "Select * from  tblCustomer  Where CustomerName ='" & cbxCustomerName.Text & "'"
        sqlDr = sqlCmd.ExecuteReader()
        If (sqlDr.Read()) Then
            txtCustomerId.Text = sqlDr("CustomerId")
            txtMobileNo.Text = sqlDr("MobileNo")
        Else
            MessageBox.Show("Sorry No Customer Avilable...")
            sqlDr.Close()
        End If
        sqlCon.Close()
    End Sub

    '***************Payment Method of cbxPayment*********************************************************
    Private Sub cbxPaymentBy_Validated(sender As Object, e As EventArgs) Handles cbxPaymentBy.Validated
        If cbxPaymentBy.Text = "Card" Then
            txtRefNo.Visible = True
            lblRefNo.Visible = True
        ElseIf cbxPaymentBy.Text = "Cash"
            lblRefNo.Visible = False
            txtRefNo.Visible = False
        End If
    End Sub

    '**********************************Camera code for btnStart******************************************************
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If cameras.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf captured)
            camera.start()
        End If
    End Sub
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        PrescriptionImage.Image = PictureBox1.Image
    End Sub
    Private Sub btnCameraClose_Click(sender As Object, e As EventArgs) Handles btnCameraClose.Click
        camera.Stop()
    End Sub
    Private Sub captured(Sender As Object, eventargs As NewFrameEventArgs)
        bmp = DirectCast(eventargs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub cbxBatchNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBatchNo.SelectedIndexChanged
        DataGridViewSale.Rows(ri).Cells(6).Value = cbxBatchNo.Text
    End Sub

    '******************************************Code for Gridview Combox*************************************************
    Private Sub DataGridViewSale_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridViewSale.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class