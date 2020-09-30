<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MEDDATADataSet = New MEDICAL.MEDDATADataSet()
        Me.tbl_orderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_orderTableAdapter = New MEDICAL.MEDDATADataSetTableAdapters.tbl_orderTableAdapter()
        CType(Me.MEDDATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_orderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetorder"
        ReportDataSource1.Value = Me.tbl_orderBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MEDICAL.orderreport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(714, 434)
        Me.ReportViewer1.TabIndex = 0
        '
        'MEDDATADataSet
        '
        Me.MEDDATADataSet.DataSetName = "MEDDATADataSet"
        Me.MEDDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_orderBindingSource
        '
        Me.tbl_orderBindingSource.DataMember = "tbl_order"
        Me.tbl_orderBindingSource.DataSource = Me.MEDDATADataSet
        '
        'tbl_orderTableAdapter
        '
        Me.tbl_orderTableAdapter.ClearBeforeFill = True
        '
        'orderReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 434)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "orderReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Report"
        CType(Me.MEDDATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_orderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_orderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDDATADataSet As MEDICAL.MEDDATADataSet
    Friend WithEvents tbl_orderTableAdapter As MEDICAL.MEDDATADataSetTableAdapters.tbl_orderTableAdapter
End Class
