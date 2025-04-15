Public Class FinanceDetails
    Private financeList As New List(Of ProjectClass.Finance)
    Dim financeSp As New StoredProcedureClasses.Finance()
    Private Sub FinanceDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RefreshGrid()
        With cbPropertyType.Items
            .Add("Apartment")
            .Add("House")
            .Add("Condominium")
            .Add("Townhouse")
            .Add("Villa")
            .Add("Studio")
            .Add("Loft")
            .Add("Office Space")
            .Add("Retail Space")
            .Add("Warehouse")
            .Add("Industrial Property")
            .Add("Land / Plot")
            .Add("Mixed-Use Building")
            .Add("Parking Space")
            .Add("Farm / Agricultural Property")
            .Add("Hotel / Hospitality")
            .Add("Commercial Building")
        End With
        cbPropertyType.SelectedIndex = 0

        AddBtnConfiguration()
    End Sub

    Private Sub AddBtnConfiguration()
        btnAdd.Enabled = True
        btnSearch.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub UpdateBtnConfiguration()
        btnAdd.Enabled = False
        btnSearch.Enabled = True
        btnUpdate.Enabled = True

        txtPropertyID.Enabled = False
    End Sub

    Private Function ValidateFinanceFields() As Boolean
        If String.IsNullOrWhiteSpace(txtPropertyID.Text) Then
            MessageBox.Show("Property ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPropertyID.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbPropertyType.Text) Then
            MessageBox.Show("Property Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbPropertyType.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtLocation.Text) Then
            MessageBox.Show("Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLocation.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPropertySize.Text) Then
            MessageBox.Show("Property Size is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPropertySize.Focus()
            Return False
        End If

        If Not IsNumeric(txtPurchasePrice.Text) Then
            MessageBox.Show("Purchase Price must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPurchasePrice.Focus()
            Return False
        End If

        If Not IsNumeric(txtMarketValue.Text) Then
            MessageBox.Show("Market Value must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMarketValue.Focus()
            Return False
        End If

        If Not IsNumeric(txtPropertyAge.Text) Then
            MessageBox.Show("Property Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPropertyAge.Focus()
            Return False
        End If

        If Not IsNumeric(txtRenovationCost.Text) Then
            MessageBox.Show("Renovation Cost must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRenovationCost.Focus()
            Return False
        End If

        Return True
    End Function

    'Private Sub RefreshGrid()
    '    dgvFinance.DataSource = Nothing
    '    dgvFinance.DataSource = financeList
    'End Sub

    Private Sub ClearFields()
        txtPropertyID.Clear()
        cbPropertyType.ResetText()
        txtLocation.Clear()
        txtPropertySize.Clear()
        txtPurchasePrice.Clear()
        txtMarketValue.Clear()
        txtPropertyAge.Clear()
        txtRenovationCost.Clear()
    End Sub



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateFinanceFields() Then
            Exit Sub
        End If

        Try
            Dim newFinance As New ProjectClass.Finance With {
            .Propertyid = txtPropertyID.Text,
            .Propertytype = cbPropertyType.Text,
            .Location = txtLocation.Text,
            .Propertysize = txtPropertySize.Text,
            .Purchaseprice = Integer.Parse(txtPurchasePrice.Text),
            .Marketvalue = Integer.Parse(txtMarketValue.Text),
            .Propertyage = Integer.Parse(txtPropertyAge.Text),
            .Renovationcost = Integer.Parse(txtRenovationCost.Text)
        }

            financeSp.FinanceDetailsInsert(newFinance)

            MessageBox.Show("Details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'RefreshGrid()

            ClearFields()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidateFinanceFields() Then
            Exit Sub
        End If

        Try
            Dim updatedFinance As New ProjectClass.Finance With {
            .Propertyid = txtPropertyID.Text,
            .Propertytype = cbPropertyType.Text,
            .Location = txtLocation.Text,
            .Propertysize = txtPropertySize.Text,
            .Purchaseprice = Integer.Parse(txtPurchasePrice.Text),
            .Marketvalue = Integer.Parse(txtMarketValue.Text),
            .Propertyage = Integer.Parse(txtPropertyAge.Text),
            .Renovationcost = Integer.Parse(txtRenovationCost.Text)
        }

            financeSp.FinanceDetailsUpdateRecord(updatedFinance)

            MessageBox.Show("Finance record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearFields()
            AddBtnConfiguration()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        For Each f As Form In Application.OpenForms
            If TypeOf f Is SearchTable Then

                f.BringToFront()
                Return
            End If
        Next

        Dim searchForm As New SearchTable()
        searchForm.SearchContext = "Finance"

        If searchForm.ShowDialog() = DialogResult.OK Then
            Dim selectedId As Integer = searchForm.SelectedId

            Dim spFinance As New StoredProcedureClasses.Finance()
            Dim resultTable As DataTable = spFinance.FinanceDetailsGetRecordById(selectedId)

            If resultTable.Rows.Count > 0 Then
                Dim row As DataRow = resultTable.Rows(0)
                txtPropertyID.Text = row("propertyid").ToString()
                cbPropertyType.Text = row("propertytype").ToString()
                txtLocation.Text = row("location").ToString()
                txtPropertySize.Text = row("propertysize").ToString()
                txtPurchasePrice.Text = row("purchaseprice").ToString()
                txtMarketValue.Text = row("marketvalue").ToString()
                txtPropertyAge.Text = row("propertyage").ToString()
                txtRenovationCost.Text = row("renovationcost").ToString()
            End If
            UpdateBtnConfiguration()
            Me.BringToFront()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

End Class