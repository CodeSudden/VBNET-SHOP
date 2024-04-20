Imports System.Data.OleDb
Imports Gunshop.UserLogin
Imports System.Reflection.Metadata


Public Class Shop
    Private _userInfo As UserInfo
    Public Sub New(userInfo As UserInfo)
        InitializeComponent()
        _userInfo = userInfo
    End Sub
    ' Define a class to represent items in the shop
    Public Class ShopItem
        Public Property Name As String
        Public Property Price As Decimal
        ' Add other properties as needed
    End Class

    ' Define a list of shop items
    Private shopItems As New List(Of ShopItem)()

    ' Store the selected item
    Private selectedShopItem As ShopItem = Nothing

    ' Populate the list of shop items (you can do this in the form load event)
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the shopItems list with items available for purchase
        shopItems.Add(New ShopItem() With {.Name = "Cyrofrost Shard UMP", .Price = 2000.0})
        shopItems.Add(New ShopItem() With {.Name = "Joker M416", .Price = 1500})
        shopItems.Add(New ShopItem() With {.Name = "Water Blaster Scar L", .Price = 500})
        shopItems.Add(New ShopItem() With {.Name = "Hextech Crystal Scar L", .Price = 2050})
        shopItems.Add(New ShopItem() With {.Name = "Glacier M416", .Price = 800})
        shopItems.Add(New ShopItem() With {.Name = "Poseidon", .Price = 5000})
        shopItems.Add(New ShopItem() With {.Name = "Pharaoh", .Price = 3000})
    End Sub
    ' Event handler for the Buy button click
    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        ' Check if an item is selected
        If selectedShopItem IsNot Nothing Then
            ' Proceed with the purchase
            ' Example:
            Dim itemName As String = selectedShopItem.Name
            Dim itemPrice As Decimal = selectedShopItem.Price

            ' Get the current user's name from the _userInfo object
            Dim userName As String = _userInfo.AccountName
            Dim status As String = "Paid"

            ' Save payment information to the database
            SavePaymentToDatabase(userName, itemName, itemPrice, status)

            ' Provide feedback to the user
            MessageBox.Show($"Thank you for your purchase of {itemName} for P{itemPrice}.")
        Else
            ' No item selected, display error message
            MessageBox.Show("Please select an item to purchase.")
        End If
    End Sub

    ' Event handler for radio button selection
    Private Sub ItemRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Item1.CheckedChanged
        ' Update the selectedShopItem variable based on the selected radio button
        If Item1.Checked Then
            ' Example: Set selectedShopItem to the corresponding item from the shopItems list
            selectedShopItem = shopItems(0) ' Change the index to match the selected item
        End If
    End Sub
    Private Sub ItemRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Item2.CheckedChanged
        ' Update the selectedShopItem variable based on the selected radio button
        If Item2.Checked Then
            ' Example: Set selectedShopItem to the corresponding item from the shopItems list
            selectedShopItem = shopItems(1) ' Change the index to match the selected item
        End If
    End Sub
    Private Sub ItemRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Item3.CheckedChanged
        ' Update the selectedShopItem variable based on the selected radio button
        If Item3.Checked Then
            ' Example: Set selectedShopItem to the corresponding item from the shopItems list
            selectedShopItem = shopItems(2) ' Change the index to match the selected item
        End If
    End Sub
    Private Sub ItemRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Item4.CheckedChanged
        ' Update the selectedShopItem variable based on the selected radio button
        If Item4.Checked Then
            ' Example: Set selectedShopItem to the corresponding item from the shopItems list
            selectedShopItem = shopItems(3) ' Change the index to match the selected item
        End If
    End Sub
    Private Sub ItemRadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Item5.CheckedChanged
        ' Update the selectedShopItem variable based on the selected radio button
        If Item5.Checked Then
            ' Example: Set selectedShopItem to the corresponding item from the shopItems list
            selectedShopItem = shopItems(4) ' Change the index to match the selected item
        End If
    End Sub
    Private Sub ItemRadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles Item6.CheckedChanged
        ' Update the selectedShopItem variable based on the selected radio button
        If Item6.Checked Then
            ' Example: Set selectedShopItem to the corresponding item from the shopItems list
            selectedShopItem = shopItems(5) ' Change the index to match the selected item
        End If
    End Sub
    Private Sub ItemRadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles Item7.CheckedChanged
        ' Update the selectedShopItem variable based on the selected radio button
        If Item7.Checked Then
            ' Example: Set selectedShopItem to the corresponding item from the shopItems list
            selectedShopItem = shopItems(6) ' Change the index to match the selected item
        End If
    End Sub

    ' Function to save payment information to the database
    Private Sub SavePaymentToDatabase(userName As String, itemName As String, Price As Decimal, Status As String)
        ' Example: Insert a new record into the Payments table with the user's name, item name, and price
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"
        Dim query As String = "INSERT INTO Payments (CustomerName, Product, Price, Status, PurchaseDate) VALUES (@CustomerName, @Product, @price, @status, @PurchaseDate)"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerName", userName)
                command.Parameters.AddWithValue("@Product", itemName)
                command.Parameters.AddWithValue("@TotalValue", Price)
                command.Parameters.AddWithValue("@Status", Status)
                command.Parameters.AddWithValue("@PurchaseDate", DateTime.Now.ToString("d/M/yyyy"))
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
