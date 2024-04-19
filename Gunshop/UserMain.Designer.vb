<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserMain))
        Panel1 = New Panel()
        Label1 = New Label()
        logout = New Button()
        account = New Button()
        purchases = New Button()
        shop = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(logout)
        Panel1.Controls.Add(account)
        Panel1.Controls.Add(purchases)
        Panel1.Controls.Add(shop)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(135, 540)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 16)
        Label1.TabIndex = 5
        Label1.Text = "Battlegrounds"
        ' 
        ' logout
        ' 
        logout.BackColor = Color.White
        logout.FlatAppearance.BorderSize = 0
        logout.FlatStyle = FlatStyle.Popup
        logout.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logout.Location = New Point(0, 368)
        logout.Name = "logout"
        logout.Size = New Size(135, 27)
        logout.TabIndex = 4
        logout.Text = "Logout"
        logout.UseVisualStyleBackColor = False
        ' 
        ' account
        ' 
        account.BackColor = Color.White
        account.FlatAppearance.BorderSize = 0
        account.FlatStyle = FlatStyle.Popup
        account.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        account.Location = New Point(0, 246)
        account.Name = "account"
        account.Size = New Size(135, 27)
        account.TabIndex = 3
        account.Text = "Account"
        account.UseVisualStyleBackColor = False
        ' 
        ' purchases
        ' 
        purchases.BackColor = Color.White
        purchases.FlatAppearance.BorderSize = 0
        purchases.FlatStyle = FlatStyle.Popup
        purchases.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        purchases.Location = New Point(0, 193)
        purchases.Name = "purchases"
        purchases.Size = New Size(135, 27)
        purchases.TabIndex = 2
        purchases.Text = "Purchases"
        purchases.UseVisualStyleBackColor = False
        ' 
        ' shop
        ' 
        shop.BackColor = Color.White
        shop.FlatAppearance.BorderColor = Color.White
        shop.FlatAppearance.BorderSize = 0
        shop.FlatStyle = FlatStyle.Popup
        shop.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        shop.ForeColor = SystemColors.ControlText
        shop.Location = New Point(0, 143)
        shop.Name = "shop"
        shop.Size = New Size(135, 27)
        shop.TabIndex = 1
        shop.Text = "Shop"
        shop.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(34, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 57)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(135, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(926, 540)
        Panel2.TabIndex = 2
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(1061, 540)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Main"
        Text = "Main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents logout As Button
    Friend WithEvents account As Button
    Friend WithEvents purchases As Button
    Friend WithEvents shop As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
