<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLogin))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        login_btn = New Button()
        Button2 = New Button()
        username = New TextBox()
        password = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        adminlink = New LinkLabel()
        signuplink = New LinkLabel()
        showPass = New CheckBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 450)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(60, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(281, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' login_btn
        ' 
        login_btn.BackColor = SystemColors.AppWorkspace
        login_btn.FlatAppearance.BorderSize = 0
        login_btn.FlatStyle = FlatStyle.Flat
        login_btn.Location = New Point(505, 276)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(186, 28)
        login_btn.TabIndex = 2
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(505, 310)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 30)
        Button2.TabIndex = 3
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' username
        ' 
        username.Location = New Point(481, 166)
        username.Name = "username"
        username.PlaceholderText = "Username"
        username.Size = New Size(251, 23)
        username.TabIndex = 4
        ' 
        ' password
        ' 
        password.Location = New Point(481, 210)
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(251, 23)
        password.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(444, 157)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(444, 201)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 32)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(395, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 76)
        Label1.TabIndex = 8
        Label1.Text = "USER LOGIN"
        ' 
        ' adminlink
        ' 
        adminlink.AutoSize = True
        adminlink.Location = New Point(555, 388)
        adminlink.Name = "adminlink"
        adminlink.Size = New Size(95, 15)
        adminlink.TabIndex = 9
        adminlink.TabStop = True
        adminlink.Text = "Login as Admin?"
        ' 
        ' signuplink
        ' 
        signuplink.AutoSize = True
        signuplink.Location = New Point(491, 357)
        signuplink.Name = "signuplink"
        signuplink.Size = New Size(200, 15)
        signuplink.TabIndex = 10
        signuplink.TabStop = True
        signuplink.Text = "Dont have an Account? Sign Up here"
        ' 
        ' showPass
        ' 
        showPass.AutoSize = True
        showPass.Location = New Point(481, 239)
        showPass.Name = "showPass"
        showPass.Size = New Size(108, 19)
        showPass.TabIndex = 11
        showPass.Text = "Show password"
        showPass.UseVisualStyleBackColor = True
        ' 
        ' UserLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(800, 450)
        Controls.Add(showPass)
        Controls.Add(signuplink)
        Controls.Add(adminlink)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Button2)
        Controls.Add(login_btn)
        Controls.Add(Panel1)
        Name = "UserLogin"
        Text = "Login"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents login_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents adminlink As LinkLabel
    Friend WithEvents signuplink As LinkLabel
    Friend WithEvents showPass As CheckBox
End Class
