<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRegister
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
        Label5 = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        txtFname = New TextBox()
        txtAccname = New TextBox()
        txtContact = New TextBox()
        txtCountry = New TextBox()
        RegisterBtn = New Button()
        cancelBtn = New Button()
        Label6 = New Label()
        txtLname = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtPassword = New TextBox()
        txtDob = New DateTimePicker()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(256, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(318, 40)
        Label1.TabIndex = 0
        Label1.Text = "Account Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(199, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 19)
        Label2.TabIndex = 1
        Label2.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(163, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 19)
        Label3.TabIndex = 2
        Label3.Text = "Account Name: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(415, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 19)
        Label4.TabIndex = 3
        Label4.Text = "Contact:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label5.Location = New Point(211, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 19)
        Label5.TabIndex = 4
        Label5.Text = "Country:"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(294, 116)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(100, 23)
        txtFname.TabIndex = 1
        ' 
        ' txtAccname
        ' 
        txtAccname.Location = New Point(294, 170)
        txtAccname.Name = "txtAccname"
        txtAccname.Size = New Size(100, 23)
        txtAccname.TabIndex = 3
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(509, 170)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(100, 23)
        txtContact.TabIndex = 4
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(294, 219)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(100, 23)
        txtCountry.TabIndex = 5
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.BackColor = Color.DeepSkyBlue
        RegisterBtn.FlatAppearance.BorderSize = 0
        RegisterBtn.FlatStyle = FlatStyle.Flat
        RegisterBtn.Font = New Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegisterBtn.Location = New Point(409, 363)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(100, 37)
        RegisterBtn.TabIndex = 8
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = False
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BackColor = Color.Red
        cancelBtn.FlatAppearance.BorderSize = 0
        cancelBtn.FlatStyle = FlatStyle.Flat
        cancelBtn.Font = New Font("Century", 9.75F, FontStyle.Bold)
        cancelBtn.Location = New Point(294, 363)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(100, 38)
        cancelBtn.TabIndex = 9
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label6.Location = New Point(415, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 19)
        Label6.TabIndex = 11
        Label6.Text = "Last Name:"
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(509, 116)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(100, 23)
        txtLname.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label7.Location = New Point(258, 277)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 19)
        Label7.TabIndex = 13
        Label7.Text = "Date Of Birth:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label8.Location = New Point(415, 223)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 19)
        Label8.TabIndex = 16
        Label8.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(509, 223)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 6
        ' 
        ' txtDob
        ' 
        txtDob.Location = New Point(389, 273)
        txtDob.Name = "txtDob"
        txtDob.Size = New Size(200, 23)
        txtDob.TabIndex = 7
        ' 
        ' UserRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(800, 450)
        Controls.Add(txtPassword)
        Controls.Add(Label8)
        Controls.Add(txtDob)
        Controls.Add(Label7)
        Controls.Add(txtLname)
        Controls.Add(Label6)
        Controls.Add(cancelBtn)
        Controls.Add(RegisterBtn)
        Controls.Add(txtCountry)
        Controls.Add(txtContact)
        Controls.Add(txtAccname)
        Controls.Add(txtFname)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "UserRegister"
        Text = "Form1"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAccname As TextBox
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDob As DateTimePicker
End Class
