<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceDetails
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
        Label1 = New Label()
        txtPropertySize = New TextBox()
        lblLocation = New Label()
        txtLocation = New TextBox()
        lblPropertyType = New Label()
        lblPropertyID = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        txtPropertyID = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuStrip1 = New MenuStrip()
        btnAdd = New ToolStripMenuItem()
        btnUpdate = New ToolStripMenuItem()
        btnSearch = New ToolStripMenuItem()
        lblPurchasePrice = New Label()
        txtPurchasePrice = New TextBox()
        lblMarketValue = New Label()
        txtMarketValue = New TextBox()
        lblPropertyAge = New Label()
        txtPropertyAge = New TextBox()
        lblRenovationCost = New Label()
        txtRenovationCost = New TextBox()
        cbPropertyType = New ComboBox()
        lblPropertySize = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 225)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 42
        Label1.Text = "*sq ft or sq m"
        ' 
        ' txtPropertySize
        ' 
        txtPropertySize.Location = New Point(121, 195)
        txtPropertySize.Name = "txtPropertySize"
        txtPropertySize.Size = New Size(200, 27)
        txtPropertySize.TabIndex = 40
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Location = New Point(42, 154)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(69, 20)
        lblLocation.TabIndex = 39
        lblLocation.Text = "Location:"
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(121, 151)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(170, 27)
        txtLocation.TabIndex = 38
        ' 
        ' lblPropertyType
        ' 
        lblPropertyType.AutoSize = True
        lblPropertyType.Location = New Point(12, 110)
        lblPropertyType.Name = "lblPropertyType"
        lblPropertyType.Size = New Size(99, 20)
        lblPropertyType.TabIndex = 37
        lblPropertyType.Text = "PropertyType:"
        ' 
        ' lblPropertyID
        ' 
        lblPropertyID.AutoSize = True
        lblPropertyID.Location = New Point(28, 66)
        lblPropertyID.Name = "lblPropertyID"
        lblPropertyID.Size = New Size(83, 20)
        lblPropertyID.TabIndex = 35
        lblPropertyID.Text = "PropertyID:"
        ' 
        ' txtPropertyID
        ' 
        txtPropertyID.Location = New Point(121, 59)
        txtPropertyID.Name = "txtPropertyID"
        txtPropertyID.Size = New Size(170, 27)
        txtPropertyID.TabIndex = 34
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnAdd, btnUpdate, btnSearch})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 52
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnAdd
        ' 
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(51, 24)
        btnAdd.Text = "Add"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(72, 24)
        btnUpdate.Text = "Update"
        ' 
        ' btnSearch
        ' 
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(67, 24)
        btnSearch.Text = "Search"
        ' 
        ' lblPurchasePrice
        ' 
        lblPurchasePrice.AutoSize = True
        lblPurchasePrice.Location = New Point(5, 284)
        lblPurchasePrice.Name = "lblPurchasePrice"
        lblPurchasePrice.Size = New Size(106, 20)
        lblPurchasePrice.TabIndex = 54
        lblPurchasePrice.Text = "Purchase Price:"
        ' 
        ' txtPurchasePrice
        ' 
        txtPurchasePrice.Location = New Point(121, 284)
        txtPurchasePrice.Name = "txtPurchasePrice"
        txtPurchasePrice.Size = New Size(170, 27)
        txtPurchasePrice.TabIndex = 53
        ' 
        ' lblMarketValue
        ' 
        lblMarketValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblMarketValue.AutoSize = True
        lblMarketValue.Location = New Point(487, 59)
        lblMarketValue.Name = "lblMarketValue"
        lblMarketValue.Size = New Size(98, 20)
        lblMarketValue.TabIndex = 56
        lblMarketValue.Text = "Market Value:"
        ' 
        ' txtMarketValue
        ' 
        txtMarketValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMarketValue.Location = New Point(591, 59)
        txtMarketValue.Name = "txtMarketValue"
        txtMarketValue.Size = New Size(170, 27)
        txtMarketValue.TabIndex = 55
        ' 
        ' lblPropertyAge
        ' 
        lblPropertyAge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPropertyAge.AutoSize = True
        lblPropertyAge.Location = New Point(486, 110)
        lblPropertyAge.Name = "lblPropertyAge"
        lblPropertyAge.Size = New Size(99, 20)
        lblPropertyAge.TabIndex = 58
        lblPropertyAge.Text = "Property Age:"
        ' 
        ' txtPropertyAge
        ' 
        txtPropertyAge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPropertyAge.Location = New Point(591, 110)
        txtPropertyAge.Name = "txtPropertyAge"
        txtPropertyAge.Size = New Size(170, 27)
        txtPropertyAge.TabIndex = 57
        ' 
        ' lblRenovationCost
        ' 
        lblRenovationCost.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRenovationCost.AutoSize = True
        lblRenovationCost.Location = New Point(465, 154)
        lblRenovationCost.Name = "lblRenovationCost"
        lblRenovationCost.Size = New Size(120, 20)
        lblRenovationCost.TabIndex = 60
        lblRenovationCost.Text = "Renovation Cost:"
        ' 
        ' txtRenovationCost
        ' 
        txtRenovationCost.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtRenovationCost.Location = New Point(591, 154)
        txtRenovationCost.Name = "txtRenovationCost"
        txtRenovationCost.Size = New Size(170, 27)
        txtRenovationCost.TabIndex = 59
        ' 
        ' cbPropertyType
        ' 
        cbPropertyType.FormattingEnabled = True
        cbPropertyType.Location = New Point(122, 110)
        cbPropertyType.Name = "cbPropertyType"
        cbPropertyType.Size = New Size(170, 28)
        cbPropertyType.TabIndex = 61
        ' 
        ' lblPropertySize
        ' 
        lblPropertySize.AutoSize = True
        lblPropertySize.Location = New Point(12, 195)
        lblPropertySize.Name = "lblPropertySize"
        lblPropertySize.Size = New Size(99, 20)
        lblPropertySize.TabIndex = 62
        lblPropertySize.Text = "Property Size:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(293, 287)
        Label2.Name = "Label2"
        Label2.Size = New Size(17, 20)
        Label2.TabIndex = 63
        Label2.Text = "$"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(763, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(17, 20)
        Label5.TabIndex = 66
        Label5.Text = "$"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(763, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 20)
        Label4.TabIndex = 65
        Label4.Text = "$"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(763, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 20)
        Label3.TabIndex = 64
        Label3.Text = "$"
        ' 
        ' FinanceDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblPropertySize)
        Controls.Add(cbPropertyType)
        Controls.Add(lblRenovationCost)
        Controls.Add(txtRenovationCost)
        Controls.Add(lblPropertyAge)
        Controls.Add(txtPropertyAge)
        Controls.Add(lblMarketValue)
        Controls.Add(txtMarketValue)
        Controls.Add(lblPurchasePrice)
        Controls.Add(txtPurchasePrice)
        Controls.Add(Label1)
        Controls.Add(txtPropertySize)
        Controls.Add(lblLocation)
        Controls.Add(txtLocation)
        Controls.Add(lblPropertyType)
        Controls.Add(lblPropertyID)
        Controls.Add(txtPropertyID)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FinanceDetails"
        Text = "FinanceDetails"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCondition As Label
    Friend WithEvents cbCondition As ComboBox
    Friend WithEvents lblBathrooms As Label
    Friend WithEvents txtBathrooms As TextBox
    Friend WithEvents lblBedrooms As Label
    Friend WithEvents txtBedrooms As TextBox
    Friend WithEvents lblYearBuild As Label
    Friend WithEvents txtYearBuild As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents txtPropertySize As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblPropertyType As Label
    Friend WithEvents lblPropertyID As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtPropertyID As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnAdd As ToolStripMenuItem
    Friend WithEvents btnUpdate As ToolStripMenuItem
    Friend WithEvents btnSearch As ToolStripMenuItem
    Friend WithEvents lblPurchasePrice As Label
    Friend WithEvents txtPurchasePrice As TextBox
    Friend WithEvents lblMarketValue As Label
    Friend WithEvents txtMarketValue As TextBox
    Friend WithEvents lblPropertyAge As Label
    Friend WithEvents txtPropertyAge As TextBox
    Friend WithEvents lblRenovationCost As Label
    Friend WithEvents txtRenovationCost As TextBox
    Friend WithEvents cbPropertyType As ComboBox
    Friend WithEvents lblPropertySize As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
