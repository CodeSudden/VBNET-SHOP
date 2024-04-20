<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Shop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shop))
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox8 = New PictureBox()
        Panel2 = New Panel()
        buyBtn = New Button()
        PictureBox1 = New PictureBox()
        Item7 = New RadioButton()
        Item6 = New RadioButton()
        Item5 = New RadioButton()
        Item4 = New RadioButton()
        Item3 = New RadioButton()
        Item2 = New RadioButton()
        Item1 = New RadioButton()
        Label2 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 68)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(198, 111)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(257, 68)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(198, 111)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(717, 68)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(198, 111)
        PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(130, 279)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(203, 135)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(486, 68)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(198, 111)
        PictureBox6.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(590, 233)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(185, 242)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 7
        PictureBox8.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Yellow
        Panel2.Controls.Add(buyBtn)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Item7)
        Panel2.Controls.Add(Item6)
        Panel2.Controls.Add(Item5)
        Panel2.Controls.Add(Item4)
        Panel2.Controls.Add(Item3)
        Panel2.Controls.Add(Item2)
        Panel2.Controls.Add(Item1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox8)
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Font = New Font("Stencil", 15.75F)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1061, 540)
        Panel2.TabIndex = 16
        ' 
        ' buyBtn
        ' 
        buyBtn.BackColor = Color.SandyBrown
        buyBtn.FlatAppearance.BorderSize = 0
        buyBtn.FlatStyle = FlatStyle.Flat
        buyBtn.Font = New Font("Stencil", 15.75F)
        buyBtn.ForeColor = SystemColors.ControlText
        buyBtn.Location = New Point(746, 20)
        buyBtn.Name = "buyBtn"
        buyBtn.Size = New Size(98, 31)
        buyBtn.TabIndex = 26
        buyBtn.Text = "Buy Item"
        buyBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(366, 233)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 242)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Item7
        ' 
        Item7.AutoSize = True
        Item7.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Item7.Location = New Point(638, 471)
        Item7.Name = "Item7"
        Item7.Size = New Size(83, 42)
        Item7.TabIndex = 24
        Item7.TabStop = True
        Item7.Text = "Phraoh" & vbCrLf & " P3000" & vbCrLf
        Item7.UseVisualStyleBackColor = True
        ' 
        ' Item6
        ' 
        Item6.AutoSize = True
        Item6.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Item6.Location = New Point(398, 469)
        Item6.Name = "Item6"
        Item6.Size = New Size(99, 42)
        Item6.TabIndex = 23
        Item6.TabStop = True
        Item6.Text = "Poseidon" & vbCrLf & "  P5000"
        Item6.UseVisualStyleBackColor = True
        ' 
        ' Item5
        ' 
        Item5.AutoSize = True
        Item5.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Item5.Location = New Point(156, 420)
        Item5.Name = "Item5"
        Item5.Size = New Size(135, 42)
        Item5.TabIndex = 22
        Item5.TabStop = True
        Item5.Text = "Glacier M416" & vbCrLf & "       P800" & vbCrLf
        Item5.UseVisualStyleBackColor = True
        ' 
        ' Item4
        ' 
        Item4.AutoSize = True
        Item4.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Item4.Location = New Point(708, 185)
        Item4.Name = "Item4"
        Item4.Size = New Size(206, 42)
        Item4.TabIndex = 21
        Item4.TabStop = True
        Item4.Text = "Hextech Crystal Scar L" & vbCrLf & "                P2050"
        Item4.UseVisualStyleBackColor = True
        ' 
        ' Item3
        ' 
        Item3.AutoSize = True
        Item3.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Item3.Location = New Point(486, 185)
        Item3.Name = "Item3"
        Item3.Size = New Size(186, 42)
        Item3.TabIndex = 20
        Item3.TabStop = True
        Item3.Text = "Water Blaster Scar L" & vbCrLf & "             P500" & vbCrLf
        Item3.UseVisualStyleBackColor = True
        ' 
        ' Item2
        ' 
        Item2.AutoSize = True
        Item2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Item2.Location = New Point(305, 189)
        Item2.Name = "Item2"
        Item2.Size = New Size(116, 42)
        Item2.TabIndex = 19
        Item2.TabStop = True
        Item2.Text = "Joker M416" & vbCrLf & "    P1500"
        Item2.UseVisualStyleBackColor = True
        ' 
        ' Item1
        ' 
        Item1.AutoSize = True
        Item1.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Item1.Location = New Point(18, 194)
        Item1.Name = "Item1"
        Item1.Size = New Size(193, 42)
        Item1.TabIndex = 18
        Item1.TabStop = True
        Item1.Text = "Cyrofrost shard UMP" & vbCrLf & "             P2000"
        Item1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 42)
        Label2.TabIndex = 17
        Label2.Text = "ITEM SHOP"
        ' 
        ' Shop
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(1061, 540)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Shop"
        Text = "Menu"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Item2 As RadioButton
    Friend WithEvents Item1 As RadioButton
    Friend WithEvents Item3 As RadioButton
    Friend WithEvents Item5 As RadioButton
    Friend WithEvents Item4 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Item7 As RadioButton
    Friend WithEvents Item6 As RadioButton
    Friend WithEvents buyBtn As Button

End Class
