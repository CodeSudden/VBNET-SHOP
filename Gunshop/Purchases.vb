Imports System.Data.OleDb
Imports Gunshop.UserLogin

Public Class Purchases
    Private _userInfo As UserInfo
    Public Sub New(userInfo As UserInfo)
        InitializeComponent()
        _userInfo = userInfo
    End Sub
    Private Sub Purchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve purchases for the current user
        Dim userName As String = _userInfo.AccountName ' Assuming _userInfo contains the current user's information
        Dim purchases As DataTable = GetPurchasesForUser(userName)

        ' Display purchases in DataGridView
        DataGridView1.DataSource = purchases
    End Sub
    Private Function GetPurchasesForUser(userName As String) As DataTable
        ' Query the database to retrieve purchases for the specified user
        Dim purchases As New DataTable()

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"
        Dim query As String = "SELECT Product, Price, Status, PurchaseDate FROM Payments WHERE CustomerName = @CustomerName"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerName", userName)
                Using adapter As New OleDbDataAdapter(command)
                    adapter.Fill(purchases)
                End Using
            End Using
        End Using

        Return purchases
    End Function
End Class