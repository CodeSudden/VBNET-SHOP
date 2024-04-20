Imports Gunshop.UserLogin

Public Class UserMain
    Private _userInfo As UserInfo

    Public Sub New(userInfo As UserInfo)
        InitializeComponent()
        _userInfo = userInfo
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show the default panel (ShopForm) when the MainForm is loaded
        ShowShopSection()
    End Sub
    Private Sub Shop_Click(sender As Object, e As EventArgs) Handles shop.Click
        ShowShopSection()
    End Sub
    Private Sub Purchase_Click(sender As Object, e As EventArgs) Handles purchases.Click
        ShowPurchasesSection()
    End Sub

    Private Sub Account_Click(sender As Object, e As EventArgs) Handles account.Click
        ShowAccountSection()
    End Sub

    Private Sub ShowShopSection()
        ' Check if user information is available in UserMain form
        If _userInfo IsNot Nothing Then
            ' Pass the user information to the Account form constructor
            Dim Shop As New Shop(_userInfo)
            ' Show the Account form
            ShowContentForm(Shop)
        Else
            ' Handle case where user information is not available
            MessageBox.Show("User information not available. Please log in.")
        End If
    End Sub
    Private Sub ShowPurchasesSection()
        ' Check if user information is available in UserMain form
        If _userInfo IsNot Nothing Then
            ' Pass the user information to the Account form constructor
            Dim Shop As New Purchases(_userInfo)
            ' Show the Account form
            ShowContentForm(Shop)
        Else
            ' Handle case where user information is not available
            MessageBox.Show("User information not available. Please log in.")
        End If
    End Sub
    Private Sub ShowAccountSection()
        ' Check if user information is available in UserMain form
        If _userInfo IsNot Nothing Then
            ' Pass the user information to the Account form constructor
            Dim accountForm As New Account(_userInfo)
            ' Show the Account form
            ShowContentForm(accountForm)
        Else
            ' Handle case where user information is not available
            MessageBox.Show("User information not available. Please log in.")
        End If
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Close the main form and show the login form again
        Dim login As New UserLogin()
        login.Show()
        Me.Close()
    End Sub

    Private Sub ShowContentForm(ByVal formToShow As Form)
        ' Clear existing content and show the specified form
        Panel2.Controls.Clear()
        formToShow.TopLevel = False
        Panel2.Controls.Add(formToShow)
        formToShow.Dock = DockStyle.Fill
        formToShow.Show()
    End Sub

End Class