Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"
        Dim queryTotalPrice As String = "SELECT SUM(price) AS TotalPrice FROM PAYMENTS"
        Dim queryTotalCustomers As String = "SELECT COUNT(*) AS CustomerCount FROM CUSTOMER"
        Dim queryTotalProducts As String = "SELECT COUNT(*) AS ProductCount FROM PRODUCTS"

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                ' Retrieve total price
                Dim commandTotalPrice As New OleDbCommand(queryTotalPrice, connection)
                Dim totalPrice As Object = commandTotalPrice.ExecuteScalar()

                If totalPrice IsNot DBNull.Value Then
                    Dim total As Decimal = Convert.ToDecimal(totalPrice)
                    lblEarn.Text = total.ToString("C") ' Display total price formatted as currency
                Else
                    lblEarn.Text = "No payments found." ' If there are no payments in the table
                End If

                ' Retrieve total customer count
                Dim commandTotalCustomers As New OleDbCommand(queryTotalCustomers, connection)
                Dim customerCount As Object = commandTotalCustomers.ExecuteScalar()

                If customerCount IsNot DBNull.Value Then
                    Dim count As Integer = Convert.ToInt32(customerCount)
                    lblCustomer.Text = count.ToString() ' Display customer count
                Else
                    lblCustomer.Text = "No customers found." ' If there are no customers in the table
                End If

                ' Retrieve total Products count
                Dim commandTotalProducts As New OleDbCommand(queryTotalProducts, connection)
                Dim productCount As Object = commandTotalProducts.ExecuteScalar()

                If productCount IsNot DBNull.Value Then
                    Dim count As Integer = Convert.ToInt32(productCount)
                    lblProducts.Text = count.ToString() ' Display customer count
                Else
                    lblProducts.Text = "No customers found." ' If there are no customers in the table
                End If

            Catch ex As Exception
                MessageBox.Show("Error retrieving data from database: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
