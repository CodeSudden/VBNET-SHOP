Imports System.Data.OleDb

Public Class Customers
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"
        Dim query As String = "SELECT * FROM CUSTOMER" ' Replace YourTableNameHere with the actual name of your table

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "Customers")

                ' Bind the DataSet to the DataGridView
                DataGridView1.DataSource = dataSet.Tables("Customers")

            Catch ex As Exception
                MessageBox.Show("Error loading data from database: " & ex.Message)
            End Try
        End Using
    End Sub
End Class