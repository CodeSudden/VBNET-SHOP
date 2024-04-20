Imports System.Data.OleDb

Public Class Products
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"
    Private query As String = "SELECT * FROM PRODUCTS"

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "Products")

                ' Bind the DataSet to the DataGridView
                DataGridView1.DataSource = dataSet.Tables("Products")

            Catch ex As Exception
                MessageBox.Show("Error loading data from database: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Save changes back to the database
    Private Sub BtnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Get the DataTable from the DataGridView's DataSource
            Dim dataTable As DataTable = DirectCast(DataGridView1.DataSource, DataTable)

            ' Create a DataAdapter to update changes back to the database
            Dim adapter As New OleDbDataAdapter(query, connectionString)
            Dim commandBuilder As New OleDbCommandBuilder(adapter)

            ' Update the database with changes from the DataTable
            adapter.Update(dataTable)

            ' Inform the user that changes have been saved
            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving changes to the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
