Imports Microsoft.Data.SqlClient
Public Class StoredProcedureClasses
    Shared connectionString As String = "Server=STEPHEN\SQLEXPRESS; Database=Test; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"
    Public Class Finance
        Public Sub FinanceDetailsInsert(finance As ProjectClass.Finance)
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("FinanceDetailsInsert", connection)
                command.CommandType = CommandType.StoredProcedure

                command.Parameters.AddWithValue("@PropertyID", finance.Propertyid)
                command.Parameters.AddWithValue("@PropertyType", finance.Propertytype)
                command.Parameters.AddWithValue("@Location", finance.Location)
                command.Parameters.AddWithValue("@PropertySize", finance.Propertysize)
                command.Parameters.AddWithValue("@PurchasePrice", finance.Purchaseprice)
                command.Parameters.AddWithValue("@MarketValue", finance.Marketvalue)
                command.Parameters.AddWithValue("@PropertyAge", finance.Propertyage)
                command.Parameters.AddWithValue("@RenovationCost", finance.Renovationcost)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Sub

        Public Sub FinanceDetailsUpdateRecord(finance As ProjectClass.Finance)
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("FinanceDetailsUpdate", connection)
                command.CommandType = CommandType.StoredProcedure

                command.Parameters.AddWithValue("@PropertyID", finance.Propertyid)
                command.Parameters.AddWithValue("@PropertyType", finance.Propertytype)
                command.Parameters.AddWithValue("@Location", finance.Location)
                command.Parameters.AddWithValue("@PropertySize", finance.Propertysize)
                command.Parameters.AddWithValue("@PurchasePrice", finance.Purchaseprice)
                command.Parameters.AddWithValue("@MarketValue", finance.Marketvalue)
                command.Parameters.AddWithValue("@PropertyAge", finance.Propertyage)
                command.Parameters.AddWithValue("@RenovationCost", finance.Renovationcost)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Sub

        Public Function FinanceDetailsGetAllRecord() As DataTable
            Dim dt As New DataTable()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("FinanceDetailsGetAllRecord", connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using

            Return dt
        End Function

        Public Function FinanceDetailsSearch(searchTerm As String) As DataTable
            Dim dt As New DataTable()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("FinanceDetailsSearch", connection)
                command.CommandType = CommandType.StoredProcedure


                command.Parameters.AddWithValue("@searchTerm", searchTerm)


                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using

            Return dt
        End Function

        Public Function FinanceDetailsGetRecordById(id As Integer) As DataTable
            Dim dt As New DataTable()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("FinanceDetailsGetRecordById", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@Id", id)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using

            Return dt
        End Function

    End Class

    Public Class Operations
        Public Sub PropertyOperationsInsert(operations As ProjectClass.Operations)
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("PropertyOperationsInsert", connection)
                command.CommandType = CommandType.StoredProcedure

                command.Parameters.AddWithValue("@PropertyID", operations.Propertyid)
                command.Parameters.AddWithValue("@PropertyType", operations.Propertytype)
                command.Parameters.AddWithValue("@Location", operations.Location)
                command.Parameters.AddWithValue("@Status", operations.Status)
                command.Parameters.AddWithValue("@StartLease", operations.Startlease)
                command.Parameters.AddWithValue("@EndLease", operations.Endlease)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Sub

        Public Sub PropertyOperationsUpdateRecord(operations As ProjectClass.Operations)
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("PropertyOperationsUpdate", connection)
                command.CommandType = CommandType.StoredProcedure

                command.Parameters.AddWithValue("@PropertyID", operations.Propertyid)
                command.Parameters.AddWithValue("@PropertyType", operations.Propertytype)
                command.Parameters.AddWithValue("@Location", operations.Location)
                command.Parameters.AddWithValue("@Status", operations.Status)
                command.Parameters.AddWithValue("@StartLease", operations.Startlease)
                command.Parameters.AddWithValue("@EndLease", operations.Endlease)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Sub

        Public Function PropertyOperationsGetAllRecord() As DataTable
            Dim dt As New DataTable()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("PropertyOperationsSearchGetAllRecord", connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using

            Return dt
        End Function

        Public Function PropertyOperationsSearch(searchTerm As String) As DataTable
            Dim dt As New DataTable()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("PropertyOperationsSearch", connection)
                command.CommandType = CommandType.StoredProcedure


                command.Parameters.AddWithValue("@searchTerm", searchTerm)


                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using

            Return dt
        End Function

        Public Function PropertyOperationsGetRecordById(id As Integer) As DataTable
            Dim dt As New DataTable()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("PropertyOperationsSearchGetRecordById", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@Id", id)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using

            Return dt
        End Function

    End Class
End Class
