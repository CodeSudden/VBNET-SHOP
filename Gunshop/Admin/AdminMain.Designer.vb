<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMain))
        Panel1 = New Panel()
        ADMINISTRATOR = New Label()
        PictureBox1 = New PictureBox()
        logout = New Button()
        reportsbtn = New Button()
        paymentsbtn = New Button()
        productsbtn = New Button()
        customersbtn = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Yellow
        Panel1.Controls.Add(ADMINISTRATOR)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(logout)
        Panel1.Controls.Add(reportsbtn)
        Panel1.Controls.Add(paymentsbtn)
        Panel1.Controls.Add(productsbtn)
        Panel1.Controls.Add(customersbtn)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(135, 540)
        Panel1.TabIndex = 0
        ' 
        ' ADMINISTRATOR
        ' 
        ADMINISTRATOR.AutoSize = True
        ADMINISTRATOR.Location = New Point(22, 96)
        ADMINISTRATOR.Name = "ADMINISTRATOR"
        ADMINISTRATOR.Size = New Size(96, 15)
        ADMINISTRATOR.TabIndex = 1
        ADMINISTRATOR.Text = "ADMINISTRATOR"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 81)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' logout
        ' 
        logout.Location = New Point(0, 418)
        logout.Name = "logout"
        logout.Size = New Size(135, 28)
        logout.TabIndex = 5
        logout.Text = "Logout"
        logout.UseVisualStyleBackColor = True
        ' 
        ' reportsbtn
        ' 
        reportsbtn.Location = New Point(0, 294)
        reportsbtn.Name = "reportsbtn"
        reportsbtn.Size = New Size(135, 28)
        reportsbtn.TabIndex = 4
        reportsbtn.Text = "Reports"
        reportsbtn.UseVisualStyleBackColor = True
        ' 
        ' paymentsbtn
        ' 
        paymentsbtn.Location = New Point(0, 248)
        paymentsbtn.Name = "paymentsbtn"
        paymentsbtn.Size = New Size(135, 28)
        paymentsbtn.TabIndex = 3
        paymentsbtn.Text = "Payments"
        paymentsbtn.UseVisualStyleBackColor = True
        ' 
        ' productsbtn
        ' 
        productsbtn.Location = New Point(0, 204)
        productsbtn.Name = "productsbtn"
        productsbtn.Size = New Size(135, 28)
        productsbtn.TabIndex = 2
        productsbtn.Text = "Products"
        productsbtn.UseVisualStyleBackColor = True
        ' 
        ' customersbtn
        ' 
        customersbtn.Location = New Point(0, 160)
        customersbtn.Name = "customersbtn"
        customersbtn.Size = New Size(135, 28)
        customersbtn.TabIndex = 1
        customersbtn.Text = "Customers"
        customersbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(135, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(926, 540)
        Panel2.TabIndex = 1
        ' 
        ' AdminMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1061, 540)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AdminMain"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents reportsbtn As Button
    Friend WithEvents paymentsbtn As Button
    Friend WithEvents productsbtn As Button
    Friend WithEvents customersbtn As Button
    Friend WithEvents ADMINISTRATOR As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logout As Button
    Friend WithEvents Panel2 As Panel
End Class
