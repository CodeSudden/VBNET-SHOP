Public Class UserMain
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
        ' Show the purchases section content
        ' Example:
        Dim Shop As New Shop()
        ShowContentForm(Shop)
    End Sub
    Private Sub ShowPurchasesSection()
        ' Show the purchases section content
        ' Example:
        Dim Purchases As New Purchases()
        ShowContentForm(purchases)
    End Sub
    Private Sub ShowAccountSection()
        ' Show the account section content
        ' Example:
        Dim Account As New Account()
        ShowContentForm(Account)
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