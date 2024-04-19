Public Class AdminLogin

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim username As String = Me.username.Text
        Dim password As String = Me.password.Text

        ' Check if the username and password are correct
        If username = "admin" AndAlso password = "password" Then
            ' If the credentials are correct, close the login form and open the main form
            Dim Main As New AdminMain()
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub userlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles userlink.LinkClicked
        Dim userlogin As New UserLogin()
        userlogin.Show()
        Me.Hide() ' Hide the MainForm when opening the AdminLoginForm
    End Sub
End Class