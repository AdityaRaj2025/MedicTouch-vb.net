<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbMedicTouchDataSet = New MedicTouch.dbMedicTouchDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblCustomerTableAdapter = New MedicTouch.dbMedicTouchDataSetTableAdapters.tblCustomerTableAdapter()
        CType(Me.tblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbMedicTouchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblCustomerBindingSource
        '
        Me.tblCustomerBindingSource.DataMember = "tblCustomer"
        Me.tblCustomerBindingSource.DataSource = Me.dbMedicTouchDataSet
        '
        'dbMedicTouchDataSet
        '
        Me.dbMedicTouchDataSet.DataSetName = "dbMedicTouchDataSet"
        Me.dbMedicTouchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblCustomerBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicTouch.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1110, 452)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblCustomerTableAdapter
        '
        Me.tblCustomerTableAdapter.ClearBeforeFill = True
        '
        'frmCustomerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1110, 585)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerReport"
        Me.Text = "frmCustomerReport"
        CType(Me.tblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbMedicTouchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblCustomerBindingSource As BindingSource
    Friend WithEvents dbMedicTouchDataSet As dbMedicTouchDataSet
    Friend WithEvents tblCustomerTableAdapter As dbMedicTouchDataSetTableAdapters.tblCustomerTableAdapter
End Class
