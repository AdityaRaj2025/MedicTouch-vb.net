Imports System.Data.SqlClient
Public Class FrmCustomer
    Dim flag As Integer = 0
    Public sqlDr As SqlDataReader
    Public DS As New DataSet()
    Public DR As DataRow

    Private repo As Repository

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        repo = New Repository()
    End Sub

    '***********Load Event Code********************************************************
    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(1280, 598)
        Me.MdiParent = frmMdi
        For i As Integer = 1 To Application.OpenForms.Count - 2
            Application.OpenForms.Item(i).Close()
        Next

        txtCustomerId.Focus()
        FillDataGridCustomer()
        btnSave.Enabled = False
        txtCustomerId.ReadOnly = False
        '*********State Code****************************
        'sqlCon.Open()
        'sqlCmd.Connection = sqlCon
        'sqlCmd.CommandText = "Select * from tblState"
        'sqlDr = sqlCmd.ExecuteReader()
        'While (sqlDr.Read())
        '    cbxState.Items.Add(sqlDr("StatesName"))
        'End While
        'sqlDr.Close()
        'sqlCon.Close()
    End Sub
    Private Sub FrmCustomer_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Left = 2
        Me.Top = 65
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtCustomerId.ReadOnly = True
        btnSave.Enabled = True
        GenerateCustomerId()
        FillDataGridCustomer()
        CustomerFormReset()
        flag = 0
    End Sub
    '**************Function Customer Id**************************************************
    Private Sub GenerateCustomerId()
        Dim slno As Integer
        sqlDr = repo.Query("Select CustomerId from tblCustomer")
        While (sqlDr.Read())
            txtCustomerId.Text = sqlDr(0).ToString
        End While
        If (txtCustomerId.Text = vbNullString) Then
            txtCustomerId.Text = "C" & Today.Year.ToString().Substring(2, 2) & "001"
        Else
            slno = Convert.ToInt16(txtCustomerId.Text.Substring(1, 5))
            slno = slno + 1
            txtCustomerId.Text = "C" & slno
        End If
        sqlDr.Close()
        repo.Close()
    End Sub
    '********************************************************Custmer MemberShip******************************************************************
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If flag = 0 Then
            MessageBox.Show(flag)
            repo.Fill(DS, "tblCustomer", "Select * from tblCustomer")
            DR = DS.Tables("tblCustomer").NewRow
            DR("CustomerId") = txtCustomerId.Text
            DR("CustomerName") = txtCustomerName.Text
            DR("Address") = rtxAddress.Text
            DR("Gender") = cbxGender.Text
            DR("MobileNo") = txtMobileNumber.Text
            DR("DOB") = dtpDOB.Text
            If cbxState.Text = "Select" Then
                MessageBox.Show("Please Select State")
            Else
                DR("State") = cbxState.Text
            End If
            DR("City") = cbxCity.Text
            DR("Pincode") = txtPinCode.Text
            DR("Email") = txtEmailId.Text
            If robActivate.Checked = True Then
                DR("CustomerStatus") = "a"
            Else
                DR("CustomerStatus") = "d"
            End If
            DR("Date") = Today.Date()
            DR("Time") = Now.TimeOfDay()
            DS.Tables("tblCustomer").Rows.Add(DR)
            repo.Update(DS, "tblCustomer")
            MessageBox.Show("Please Smile Customer Create done successfully...")
        Else
            MessageBox.Show(flag)
            repo.Fill(DS, "tblCustomer", "Select * from tblCustomer where CustomerId = '" & txtCustomerId.Text & "'")
            DR = DS.Tables("tblCustomer").Rows(0)
            DR("CustomerId") = txtCustomerId.Text
            DR("CustomerName") = txtCustomerName.Text
            DR("Address") = rtxAddress.Text
            DR("Gender") = cbxGender.Text
            DR("MobileNo") = txtMobileNumber.Text
            DR("DOB") = dtpDOB.Text
            DR("State") = cbxState.Text
            DR("City") = cbxCity.Text
            DR("Pincode") = txtPinCode.Text
            DR("Email") = txtEmailId.Text
            If robActivate.Checked = True Then
                DR("CustomerStatus") = "a"
            Else
                DR("CustomerStatus") = "d"
            End If
            DR("Date") = Today.Date()
            DR("Time") = Now.TimeOfDay()
            repo.Update(DS, "tblCustomer")
            MessageBox.Show("Please Smile Customer Updated successfully...")
        End If
        repo.Close()
        GenerateCustomerId()
        CustomerFormReset()
        btnSave.Enabled = False
        FillDataGridCustomer()
    End Sub
    '********************Reset Function************************************************************************************** 
    Private Sub CustomerFormReset()
        txtCustomerName.Clear()
        txtEmailId.Clear()
        txtMobileNumber.Clear()
        txtPinCode.Clear()
        rtxAddress.Clear()
        If cbxCity.SelectedIndex = -1 Then cbxCity.Text = "Select"
        If cbxState.SelectedIndex = -1 Then cbxCity.Text = "Select"
        If cbxGender.SelectedIndex = -1 Then cbxGender.Text = "Select"
        FillDataGridCustomer()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CustomerFormReset()
        txtCustomerId.Clear()
        If cbxCity.SelectedIndex = -1 Then cbxCity.Text = "Select"
        If cbxState.SelectedIndex = -1 Then cbxCity.Text = "Select"
        txtCustomerId.ReadOnly = False
        txtCustomerId.Focus()
    End Sub

    '*******************************************DataGrid View Function*********************************************************************
    Private Sub FillDataGridCustomer()
        DS.Clear()
        repo.Fill(DS, "tblCustomer", "Select * from tblCustomer")
        DataGridViewCustomer.DataSource = DS.Tables("tblCustomer")
        repo.Close()
    End Sub
    '***************Search Code************************************************************************************
    Private Sub btnCustomerIdSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerIdSearch.Click
        flag = 1
        sqlDr = repo.Query("Select * from tblCustomer  where CustomerId ='" & txtCustomerId.Text & "'")
        If sqlDr.Read() Then
            txtCustomerId.Text = sqlDr("CustomerId")
            txtCustomerName.Text = sqlDr("CustomerName")
            rtxAddress.Text = sqlDr("Address")
            If IsDBNull(sqlDr("Gender")) Or sqlDr("Gender") = "" Then
                cbxGender.SelectedIndex = -1
            Else
                cbxGender.SelectedItem = sqlDr("Gender")
            End If
            cbxGender.Text = sqlDr("Gender")
            txtMobileNumber.Text = sqlDr("MobileNo")
            dtpDOB.Text = sqlDr("DOB")
            'If IsDBNull(sqlDr("State")) Or sqlDr("State") = "" Then
            '    cbxState.SelectedIndex = -1
            'Else
            '    cbxState.SelectedItem = sqlDr("State")
            'End If
            'If IsDBNull(sqlDr("City")) Or sqlDr("City") = "" Then
            '    cbxCity.SelectedIndex = -1
            'Else
            '    cbxCity.SelectedItem = sqlDr("City")
            'End If
            txtPinCode.Text = sqlDr("Pincode")
            txtEmailId.Text = sqlDr("Email")
            If sqlDr("CustomerStatus") = "a" Then
                robActivate.Checked = True
            Else
                robDeactivate.Checked = True
            End If
        Else
            MessageBox.Show("Sorry No Record Found")
        End If
        btnSave.Enabled = True
        repo.Close()
        sqlDr.Close()
    End Sub
End Class