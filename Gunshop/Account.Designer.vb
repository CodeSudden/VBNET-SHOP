<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblRegDate = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtAccountName = New TextBox()
        btnEdit = New Button()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        Label9 = New Label()
        txtContact = New TextBox()
        txtCountry = New TextBox()
        dateDOB = New DateTimePicker()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 12.0F, FontStyle.Bold)
        Label1.Location = New Point(193, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 19)
        Label1.TabIndex = 0
        Label1.Text = "First name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(193, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 19)
        Label2.TabIndex = 1
        Label2.Text = "Account Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(193, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 19)
        Label3.TabIndex = 2
        Label3.Text = "Contact:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Rockwell", 12.0F, FontStyle.Bold)
        Label4.Location = New Point(193, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 19)
        Label4.TabIndex = 3
        Label4.Text = "Country:"
        ' 
        ' lblRegDate
        ' 
        lblRegDate.AutoSize = True
        lblRegDate.BackColor = Color.Transparent
        lblRegDate.Font = New Font("Rockwell", 12.0F, FontStyle.Bold)
        lblRegDate.Location = New Point(509, 338)
        lblRegDate.Name = "lblRegDate"
        lblRegDate.Size = New Size(74, 19)
        lblRegDate.TabIndex = 11
        lblRegDate.Text = "Regdate"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Rockwell", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(193, 268)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 19)
        Label5.TabIndex = 12
        Label5.Text = "Date Of Birth:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(193, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 19)
        Label6.TabIndex = 13
        Label6.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(193, 338)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 19)
        Label7.TabIndex = 14
        Label7.Text = "Registration Date"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(46, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(254, 40)
        Label8.TabIndex = 15
        Label8.Text = "Account Details"
        ' 
        ' txtAccountName
        ' 
        txtAccountName.Location = New Point(509, 160)
        txtAccountName.Name = "txtAccountName"
        txtAccountName.Size = New Size(100, 23)
        txtAccountName.TabIndex = 16
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(534, 50)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 17
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(509, 96)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(100, 23)
        txtFirstName.TabIndex = 18
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(509, 131)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(100, 23)
        txtLastName.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Rockwell", 12.0F, FontStyle.Bold)
        Label9.Location = New Point(193, 135)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 19)
        Label9.TabIndex = 20
        Label9.Text = "Last name:"
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(509, 199)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(100, 23)
        txtContact.TabIndex = 22
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(509, 233)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(100, 23)
        txtCountry.TabIndex = 23
        ' 
        ' dateDOB
        ' 
        dateDOB.Location = New Point(509, 264)
        dateDOB.Name = "dateDOB"
        dateDOB.Size = New Size(200, 23)
        dateDOB.TabIndex = 24
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(509, 299)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 25
        ' 
        ' Account
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(800, 450)
        Controls.Add(txtPassword)
        Controls.Add(dateDOB)
        Controls.Add(txtCountry)
        Controls.Add(txtContact)
        Controls.Add(Label9)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(btnEdit)
        Controls.Add(txtAccountName)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblRegDate)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRegDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents dateDOB As DateTimePicker
    Friend WithEvents txtPassword As TextBox
End Class
