<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyOperations
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
        components = New ComponentModel.Container()
        cbPropertyType = New ComboBox()
        btnSearch = New ToolStripMenuItem()
        btnUpdate = New ToolStripMenuItem()
        btnAdd = New ToolStripMenuItem()
        MenuStrip1 = New MenuStrip()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtPropertyID = New TextBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        lblLocation = New Label()
        txtLocation = New TextBox()
        lblPropertyType = New Label()
        lblPropertyID = New Label()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        lblStatus = New Label()
        cbStatus = New ComboBox()
        dtpStartDate = New DateTimePicker()
        lblStartLease = New Label()
        lblEndLease = New Label()
        dtpEndDate = New DateTimePicker()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbPropertyType
        ' 
        cbPropertyType.FormattingEnabled = True
        cbPropertyType.Location = New Point(121, 107)
        cbPropertyType.Name = "cbPropertyType"
        cbPropertyType.Size = New Size(170, 28)
        cbPropertyType.TabIndex = 78
        ' 
        ' btnSearch
        ' 
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(67, 24)
        btnSearch.Text = "Search"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(72, 24)
        btnUpdate.Text = "Update"
        ' 
        ' btnAdd
        ' 
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(51, 24)
        btnAdd.Text = "Add"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnAdd, btnUpdate, btnSearch})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 69
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtPropertyID
        ' 
        txtPropertyID.Location = New Point(121, 59)
        txtPropertyID.Name = "txtPropertyID"
        txtPropertyID.Size = New Size(170, 27)
        txtPropertyID.TabIndex = 62
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Location = New Point(42, 154)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(69, 20)
        lblLocation.TabIndex = 66
        lblLocation.Text = "Location:"
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(121, 151)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(170, 27)
        txtLocation.TabIndex = 65
        ' 
        ' lblPropertyType
        ' 
        lblPropertyType.AutoSize = True
        lblPropertyType.Location = New Point(12, 110)
        lblPropertyType.Name = "lblPropertyType"
        lblPropertyType.Size = New Size(99, 20)
        lblPropertyType.TabIndex = 64
        lblPropertyType.Text = "PropertyType:"
        ' 
        ' lblPropertyID
        ' 
        lblPropertyID.AutoSize = True
        lblPropertyID.Location = New Point(28, 66)
        lblPropertyID.Name = "lblPropertyID"
        lblPropertyID.Size = New Size(83, 20)
        lblPropertyID.TabIndex = 63
        lblPropertyID.Text = "PropertyID:"
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(59, 195)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(52, 20)
        lblStatus.TabIndex = 81
        lblStatus.Text = "Status:"
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Location = New Point(121, 195)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(170, 28)
        cbStatus.TabIndex = 82
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.CustomFormat = "dd/MM/yyyy"
        dtpStartDate.Location = New Point(121, 249)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(250, 27)
        dtpStartDate.TabIndex = 83
        dtpStartDate.Value = New Date(2025, 4, 14, 0, 0, 0, 0)
        ' 
        ' lblStartLease
        ' 
        lblStartLease.AutoSize = True
        lblStartLease.Location = New Point(31, 249)
        lblStartLease.Name = "lblStartLease"
        lblStartLease.Size = New Size(80, 20)
        lblStartLease.TabIndex = 84
        lblStartLease.Text = "StartLease:"
        ' 
        ' lblEndLease
        ' 
        lblEndLease.AutoSize = True
        lblEndLease.Location = New Point(37, 302)
        lblEndLease.Name = "lblEndLease"
        lblEndLease.Size = New Size(74, 20)
        lblEndLease.TabIndex = 86
        lblEndLease.Text = "EndLease:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.CustomFormat = "dd/MM/yyyy"
        dtpEndDate.Location = New Point(121, 302)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(250, 27)
        dtpEndDate.TabIndex = 85
        dtpEndDate.Value = New Date(2025, 4, 14, 0, 0, 0, 0)
        ' 
        ' PropertyOperations
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblEndLease)
        Controls.Add(dtpEndDate)
        Controls.Add(lblStartLease)
        Controls.Add(dtpStartDate)
        Controls.Add(cbStatus)
        Controls.Add(lblStatus)
        Controls.Add(cbPropertyType)
        Controls.Add(MenuStrip1)
        Controls.Add(txtPropertyID)
        Controls.Add(lblLocation)
        Controls.Add(txtLocation)
        Controls.Add(lblPropertyType)
        Controls.Add(lblPropertyID)
        Name = "PropertyOperations"
        Text = "PropertyOperations"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbPropertyType As ComboBox
    Friend WithEvents btnSearch As ToolStripMenuItem
    Friend WithEvents btnUpdate As ToolStripMenuItem
    Friend WithEvents btnAdd As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtPropertyID As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblPropertyType As Label
    Friend WithEvents lblPropertyID As Label
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblStartLease As Label
    Friend WithEvents lblEndLease As Label
    Friend WithEvents dtpEndDate As DateTimePicker
End Class
