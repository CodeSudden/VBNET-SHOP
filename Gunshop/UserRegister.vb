Imports System.Data.OleDb

Public Class UserRegister
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"

        ' Collect user input from the form
        Dim firstName As String = txtFname.Text
        Dim lastName As String = txtLname.Text
        Dim accountName As String = txtAccname.Text
        Dim contact As Integer
        If Integer.TryParse(txtContact.Text, contact) = False Then
            MessageBox.Show("Please enter a valid integer for the contact field.")
            Return
        End If
        Dim country As String = txtCountry.Text
        Dim dob As String = txtDob.Value.Date
        Dim password As String = txtPassword.Text
        Dim currentDate As Date = Date.Today

        ' SQL INSERT statement
        Dim query As String = "INSERT INTO CUSTOMER (`Fname`, `Lname`, `AccName`, `Contact`, `Country`, `DOB`, `Password`, `RegDate`)
                                VALUES (@FirstName, @LastName, @AccountName, @Contact, @Country, @DOB, @Password, @RegistrationDate)"

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    ' Add parameters to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@AccountName", accountName)
                    command.Parameters.AddWithValue("@Contact", contact)
                    command.Parameters.AddWithValue("@Country", country)
                    command.Parameters.AddWithValue("@DOB", dob)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@RegistrationDate", currentDate)

                    ' Execute the INSERT statement
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration successful!")
                ' Redirect to the login page (close current form and open login form)
                Me.Close() ' Close the registration form
                Dim loginForm As New UserLogin()
                loginForm.Show() ' Show the login form

            Catch ex As Exception
                MessageBox.Show("Error registering user: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close() ' Close the registration form
        Dim loginForm As New UserLogin()
        loginForm.Show() ' Show the login form
    End Sub
End Class