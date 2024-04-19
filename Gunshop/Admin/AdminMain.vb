Public Class AdminMain
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show the default panel (ShopForm) when the MainForm is loaded
        ShowCustomerSection()
    End Sub
    Private Sub CustomersBtn_Click(sender As Object, e As EventArgs) Handles customersbtn.Click
        ShowCustomerSection()
    End Sub
    Private Sub ProductsBtn_Click(sender As Object, e As EventArgs) Handles productsbtn.Click
        ShowProductSection()
    End Sub
    Private Sub PaymentsBtn_Click(sender As Object, e As EventArgs) Handles paymentsbtn.Click
        ShowPaymentsSection()
    End Sub
    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles reportsbtn.Click
        ShowReportSection()
    End Sub
    Private Sub ShowCustomerSection()
        Dim Customers As New Customers()
        ShowContentForm(Customers)
    End Sub
    Private Sub ShowProductSection()
        Dim Products As New Products()
        ShowContentForm(Products)
    End Sub
    Private Sub ShowPaymentsSection()
        Dim Payments As New Payments()
        ShowContentForm(Payments)
    End Sub
    Private Sub ShowReportSection()
        Dim Reports As New Reports()
        ShowContentForm(Reports)
    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' Close the main form and show the login form again
        Dim login As New AdminLogin()
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