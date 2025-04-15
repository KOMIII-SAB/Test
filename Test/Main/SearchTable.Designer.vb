<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchTable
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
        dvgSearchResult = New DataGridView()
        txtSearchBox = New TextBox()
        lblSearchBox = New Label()
        CType(dvgSearchResult, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dvgSearchResult
        ' 
        dvgSearchResult.BackgroundColor = SystemColors.ButtonHighlight
        dvgSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgSearchResult.Location = New Point(12, 39)
        dvgSearchResult.Name = "dvgSearchResult"
        dvgSearchResult.RowHeadersWidth = 51
        dvgSearchResult.Size = New Size(776, 399)
        dvgSearchResult.TabIndex = 0
        ' 
        ' txtSearchBox
        ' 
        txtSearchBox.Location = New Point(108, 8)
        txtSearchBox.Name = "txtSearchBox"
        txtSearchBox.Size = New Size(170, 27)
        txtSearchBox.TabIndex = 1
        ' 
        ' lblSearchBox
        ' 
        lblSearchBox.AutoSize = True
        lblSearchBox.Location = New Point(20, 11)
        lblSearchBox.Name = "lblSearchBox"
        lblSearchBox.Size = New Size(82, 20)
        lblSearchBox.TabIndex = 2
        lblSearchBox.Text = "Search Box"
        ' 
        ' SearchTable
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblSearchBox)
        Controls.Add(txtSearchBox)
        Controls.Add(dvgSearchResult)
        Name = "SearchTable"
        Text = "SearchTable"
        CType(dvgSearchResult, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dvgSearchResult As DataGridView
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents lblSearchBox As Label
End Class
