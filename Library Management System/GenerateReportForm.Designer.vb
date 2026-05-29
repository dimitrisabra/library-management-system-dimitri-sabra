<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateReportForm))
        dgvReturned = New DataGridView()
        lblTotalProfit = New Label()
        btnExportPDF = New Button()
        GroupBox1 = New GroupBox()
        btnRefresh = New Button()
        Label3 = New Label()
        Label2 = New Label()
        dtpEndDate = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        CType(dgvReturned, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvReturned
        ' 
        dgvReturned.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReturned.Location = New Point(20, 93)
        dgvReturned.Name = "dgvReturned"
        dgvReturned.Size = New Size(1047, 442)
        dgvReturned.TabIndex = 0
        ' 
        ' lblTotalProfit
        ' 
        lblTotalProfit.AutoSize = True
        lblTotalProfit.Location = New Point(846, 555)
        lblTotalProfit.Name = "lblTotalProfit"
        lblTotalProfit.Size = New Size(40, 15)
        lblTotalProfit.TabIndex = 1
        lblTotalProfit.Text = "Label1"
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.Location = New Point(483, 612)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(102, 23)
        btnExportPDF.TabIndex = 2
        btnExportPDF.Text = "Export as PDF"
        btnExportPDF.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblTotalProfit)
        GroupBox1.Controls.Add(btnRefresh)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(dtpEndDate)
        GroupBox1.Controls.Add(dtpStartDate)
        GroupBox1.Controls.Add(dgvReturned)
        GroupBox1.Controls.Add(btnExportPDF)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(65, 51)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1110, 665)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Generate Report"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(917, 36)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(616, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 8
        Label3.Text = "End Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(307, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 7
        Label2.Text = "Start Date"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(686, 36)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(214, 23)
        dtpEndDate.TabIndex = 6
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(373, 36)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(212, 23)
        dtpStartDate.TabIndex = 5
        ' 
        ' GenerateReportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1202, 749)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "GenerateReportForm"
        Text = "Generate Report"
        CType(dgvReturned, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvReturned As DataGridView
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
End Class
