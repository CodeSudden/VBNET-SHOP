<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        login_btn = New Button()
        userlink = New LinkLabel()
        Button2 = New Button()
        Label1 = New Label()
        username = New TextBox()
        PictureBox3 = New PictureBox()
        password = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(login_btn)
        Panel1.Controls.Add(userlink)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(username)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(password)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 450)
        Panel1.TabIndex = 10
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(38, 151)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' login_btn
        ' 
        login_btn.BackColor = SystemColors.AppWorkspace
        login_btn.FlatAppearance.BorderSize = 0
        login_btn.FlatStyle = FlatStyle.Flat
        login_btn.Location = New Point(107, 295)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(186, 28)
        login_btn.TabIndex = 11
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' userlink
        ' 
        userlink.AutoSize = True
        userlink.Location = New Point(151, 379)
        userlink.Name = "userlink"
        userlink.Size = New Size(82, 15)
        userlink.TabIndex = 18
        userlink.TabStop = True
        userlink.Text = "Login as User?"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(107, 329)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 30)
        Button2.TabIndex = 12
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(19, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 57)
        Label1.TabIndex = 17
        Label1.Text = "ADMIN LOGIN"
        ' 
        ' username
        ' 
        username.Location = New Point(75, 160)
        username.Name = "username"
        username.PlaceholderText = "Username"
        username.Size = New Size(251, 23)
        username.TabIndex = 13
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(38, 195)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 32)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' password
        ' 
        password.Location = New Point(75, 204)
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(251, 23)
        password.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(466, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(281, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "AdminLogin"
        Text = "Admin Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents login_btn As Button
    Friend WithEvents adminlink As LinkLabel
    Friend WithEvents userlink As LinkLabel
End Class
