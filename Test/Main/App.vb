Public Class App

    Private AppContainer As New Panel
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppContainer.Dock = DockStyle.Fill
        Me.Controls.Add(AppContainer)

        Dim args As String() = Environment.GetCommandLineArgs()

        If args.Length > 1 Then
            Dim ModuleName As String = args(1).ToLower()

            Select Case ModuleName
                Case "finance"
                    AppContainer.Controls.Clear()
                    Dim Financeform As New FinanceDetails()
                    Financeform.TopLevel = False
                    Financeform.FormBorderStyle = FormBorderStyle.None
                    Financeform.Dock = DockStyle.Fill
                    AppContainer.Controls.Add(Financeform)
                    Financeform.Show()
                Case "operations"
                    AppContainer.Controls.Clear()
                    Dim Operationsform As New PropertyOperations()
                    Operationsform.TopLevel = False
                    Operationsform.FormBorderStyle = FormBorderStyle.None
                    Operationsform.Dock = DockStyle.Fill
                    AppContainer.Controls.Add(Operationsform)
                    Operationsform.Show()
                Case Else
                    MessageBox.Show("Unknown module: " & ModuleName)
            End Select
        End If
    End Sub
End Class
