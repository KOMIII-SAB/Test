Public Class SearchTable
    Public SearchContext As String
    Private dt As DataTable
    Public SelectedId As Integer
    Private Sub SearchTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim spfinance As New StoredProcedureClasses.Finance()
        Dim spoperation As New StoredProcedureClasses.Operations()
        Dim dt As New DataTable()
        LoadData("")
        If SearchContext = "Finance" Then
            dt = spfinance.FinanceDetailsGetAllRecord()
        ElseIf SearchContext = "Operations" Then
            dt = spoperation.PropertyOperationsGetAllRecord()
        Else
            ' Load default or other data
        End If

        dvgSearchResult.DataSource = dt
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        LoadData(txtSearchBox.Text)
    End Sub

    Private Sub LoadData(searchTerm As String)
        Dim spfinance As New StoredProcedureClasses.Finance()
        Dim spoperation As New StoredProcedureClasses.Operations()
        If SearchContext = "Finance" Then
            dt = spfinance.FinanceDetailsSearch(searchTerm)
        ElseIf SearchContext = "Operations" Then
            dt = spoperation.PropertyOperationsSearch(searchTerm)
        Else
            dt = New DataTable()
        End If
        dvgSearchResult.DataSource = dt
    End Sub

    Private Sub dvgSearchResult_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgSearchResult.CellClick
        If e.RowIndex >= 0 Then
            SelectedId = Convert.ToInt32(dvgSearchResult.Rows(e.RowIndex).Cells("id").Value)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class