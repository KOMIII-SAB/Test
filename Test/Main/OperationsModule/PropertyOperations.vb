Public Class PropertyOperations
    Private operationslist As New List(Of ProjectClass.Operations)
    Dim operationSP As New StoredProcedureClasses.Operations()
    Private Sub PropertyOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        With cbStatus.Items
            .Add("Available")
            .Add("Rented")
            .Add("Under Construction")
            .Add("Sold")
            .Add("Under Renovation")
            .Add("Leased")
            .Add("Pending")
            .Add("Vacant")
        End With
        cbStatus.SelectedIndex = 0

        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.CustomFormat = "MM/dd/yy"

        dtpEndDate.Format = DateTimePickerFormat.Custom
        dtpEndDate.CustomFormat = "MM/dd/yy"

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

    Private Function ValidateOperationFields() As Boolean
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

        If String.IsNullOrWhiteSpace(cbStatus.Text) Then
            MessageBox.Show("Property Size is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbStatus.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub ClearFields()
        txtPropertyID.Clear()
        cbPropertyType.ResetText()
        txtLocation.Clear()
        cbStatus.ResetText()
        dtpStartDate.ResetText()
        dtpEndDate.ResetText()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateOperationFields() Then
            Exit Sub
        End If

        If dtpStartDate.Value >= dtpEndDate.Value Then
            MessageBox.Show("Start Lease date must be earlier than End Lease date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpStartDate.Focus()
            Return
        End If

        Try
            Dim newOperations As New ProjectClass.Operations With {
            .Propertyid = txtPropertyID.Text,
            .Propertytype = cbPropertyType.Text,
            .Location = txtLocation.Text,
            .Status = cbStatus.Text,
            .Startlease = Date.Parse(dtpStartDate.Value),
            .Endlease = Date.Parse(dtpEndDate.Value)
        }

            operationSP.PropertyOperationsInsert(newOperations)

            MessageBox.Show("Details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'RefreshGrid()

            ClearFields()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidateOperationFields() Then
            Exit Sub
        End If

        Try
            Dim updatedOperation As New ProjectClass.Operations With {
            .Propertyid = txtPropertyID.Text,
            .Propertytype = cbPropertyType.Text,
            .Location = txtLocation.Text,
            .Status = cbStatus.Text,
            .Startlease = Date.Parse(dtpStartDate.Value),
            .Endlease = Date.Parse(dtpEndDate.Value)
        }

            operationSP.PropertyOperationsUpdateRecord(updatedOperation)

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
        searchForm.SearchContext = "Operations"

        If searchForm.ShowDialog() = DialogResult.OK Then
            Dim selectedId As Integer = searchForm.SelectedId

            Dim spOperation As New StoredProcedureClasses.Operations()
            Dim resultTable As DataTable = spOperation.PropertyOperationsGetRecordById(selectedId)

            If resultTable.Rows.Count > 0 Then
                Dim row As DataRow = resultTable.Rows(0)
                txtPropertyID.Text = row("propertyid").ToString()
                cbPropertyType.Text = row("propertytype").ToString()
                txtLocation.Text = row("location").ToString()
                cbStatus.Text = row("status").ToString()
                dtpStartDate.Value = row("startlease").ToString()
                dtpEndDate.Value = row("endlease").ToString()
            End If
            UpdateBtnConfiguration()
            Me.BringToFront()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class