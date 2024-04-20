Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class UserLogin

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password.UseSystemPasswordChar = True
    End Sub
    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        ' Toggle between showing and hiding the password
        password.UseSystemPasswordChar = Not showPass.Checked
    End Sub
    Public Class UserInfo
        Public Property FirstName As String
        Public Property LastName As String
        Public Property AccountName As String
        Public Property Contact As String
        Public Property Country As String
        Public Property DateOfBirth As Date
        Public Property Password As String
        Public Property RegistrationDate As Date
        ' Add other properties as needed
    End Class

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"

        ' Get the account name and password entered by the user
        Dim uname As String = username.Text
        Dim passwrd As String = password.Text

        ' SQL SELECT statement to retrieve user information
        Dim query As String = "SELECT Fname, Lname, AccName, Contact, Country, DOB, Password, RegDate FROM CUSTOMER WHERE AccName = @AccountName AND Password = @Password"

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    ' Add parameters to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@AccountName", uname)
                    command.Parameters.AddWithValue("@Password", passwrd)

                    ' Execute the SELECT statement
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' User exists, retrieve user information
                            Dim userInfo As New UserInfo()
                            userInfo.FirstName = reader("Fname").ToString()
                            userInfo.LastName = reader("Lname").ToString()
                            userInfo.AccountName = reader("AccName").ToString()
                            userInfo.Contact = reader("Contact").ToString()
                            userInfo.Country = reader("Country").ToString()
                            userInfo.DateOfBirth = Date.Parse(reader("DOB").ToString()) ' Assuming DOB is stored as a date
                            userInfo.Password = reader("Password").ToString()
                            userInfo.RegistrationDate = Date.Parse(reader("RegDate").ToString()) ' Assuming RegDate is stored as a date

                            ' Close the login form
                            Me.Hide()

                            ' Pass userInfo object to UserMain form
                            Dim mainForm As New UserMain(userInfo)
                            mainForm.Show()
                        Else
                            ' User does not exist or invalid credentials
                            MessageBox.Show("Invalid account name or password. Please try again.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error logging in: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Adminlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles adminlink.LinkClicked
        Dim adminlogin As New AdminLogin()
        adminlogin.Show()
        Me.Hide() ' Hide the MainForm when opening the AdminLoginForm
    End Sub

    Private Sub Signuplink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signuplink.LinkClicked
        Dim signup As New UserRegister()
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class