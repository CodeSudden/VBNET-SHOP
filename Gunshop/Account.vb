Imports Gunshop.UserLogin
Imports System.Data.OleDb
Imports System.Reflection.Metadata

Public Class Account
    Private _userInfo As UserInfo
    Private _isEditMode As Boolean ' Flag to track edit mode

    Public Sub New(userInfo As UserInfo)
        InitializeComponent()
        _userInfo = userInfo
        _isEditMode = True ' Initially, set to view mode
        ToggleEditMode() ' Call to set initial state of controls
    End Sub

    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUserInfo()
    End Sub

    Private Sub DisplayUserInfo()
        txtFirstName.Text = _userInfo.FirstName
        txtLastName.Text = _userInfo.LastName
        txtAccountName.Text = _userInfo.AccountName
        txtContact.Text = _userInfo.Contact
        txtCountry.Text = _userInfo.Country
        dateDOB.Value = _userInfo.DateOfBirth ' Set the value of the DateTimePicker
        txtPassword.Text = _userInfo.Password
        lblRegDate.Text = _userInfo.RegistrationDate.ToString("yyyy-MM-dd")
    End Sub

    Private Sub ToggleEditMode()
        ' Toggle edit mode flag
        _isEditMode = Not _isEditMode

        ' Enable/disable controls based on edit mode
        txtFirstName.Enabled = _isEditMode
        txtLastName.Enabled = _isEditMode
        txtAccountName.Enabled = _isEditMode
        txtContact.Enabled = _isEditMode
        txtCountry.Enabled = _isEditMode
        dateDOB.Enabled = _isEditMode
        txtPassword.Enabled = _isEditMode

        ' Update button text based on edit mode
        If _isEditMode Then
            btnEdit.Text = "Save"
        Else
            btnEdit.Text = "Edit"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If _isEditMode Then
            ' Save changes to the database
            Try
                ' Open connection to the database
                Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\users\RGBTQ\documents\GunShop.accdb;"
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()

                    ' Construct SQL command to update user information
                    Dim query As String = "UPDATE CUSTOMER SET Fname = @FirstName, Lname = @LastName, AccName = @AccountName, Contact = @Contact, Country = @Country WHERE AccName = @OriginalAccountName"

                    ' Create and execute the command
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text)
                        command.Parameters.AddWithValue("@AccountName", txtAccountName.Text)
                        command.Parameters.AddWithValue("@Contact", txtContact.Text)
                        command.Parameters.AddWithValue("@Country", txtCountry.Text)
                        ' Add other parameters as needed
                        command.Parameters.AddWithValue("@OriginalAccountName", _userInfo.AccountName)

                        ' Execute the command
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if the update was successful
                        If rowsAffected > 0 Then
                            ' Update UserInfo object with new data
                            _userInfo.FirstName = txtFirstName.Text
                            _userInfo.LastName = txtLastName.Text
                            _userInfo.AccountName = txtAccountName.Text
                            _userInfo.Contact = txtContact.Text
                            _userInfo.Country = txtCountry.Text
                            ' Update other user info properties as needed

                            ' Update display
                            DisplayUserInfo()

                            ' Toggle back to view mode
                            ToggleEditMode()

                            MessageBox.Show("User information updated successfully.")
                        Else
                            MessageBox.Show("No rows were updated. Please try again.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating user information: " & ex.Message)
            End Try
        Else
            ' Toggle to edit mode
            ToggleEditMode()
        End If
    End Sub
End Class