Imports System.Data.OleDb

Public Class Payments
    Private Sub Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"
        Dim query As String = "SELECT * FROM PAYMENTS" ' Replace YourTableNameHere with the actual name of your table

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "Payments")

                ' Bind the DataSet to the DataGridView
                DataGridView1.DataSource = dataSet.Tables("Payments")

            Catch ex As Exception
                MessageBox.Show("Error loading data from database: " & ex.Message)
            End Try
        End Using
    End Sub
End Class