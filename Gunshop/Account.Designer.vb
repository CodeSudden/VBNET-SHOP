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
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightYellow
        Label1.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label1.Location = New Point(104, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 34)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightYellow
        Label2.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label2.Location = New Point(104, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 34)
        Label2.TabIndex = 1
        Label2.Text = "Account Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LightYellow
        Label3.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label3.Location = New Point(104, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 34)
        Label3.TabIndex = 2
        Label3.Text = "Contact"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.LightYellow
        Label4.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label4.Location = New Point(104, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 34)
        Label4.TabIndex = 3
        Label4.Text = "Country"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.LightYellow
        Label5.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label5.Location = New Point(316, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 34)
        Label5.TabIndex = 4
        Label5.Text = "Gracy Yadao"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LightYellow
        Label6.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label6.Location = New Point(316, 128)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 34)
        Label6.TabIndex = 5
        Label6.Text = "Gummy"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.LightYellow
        Label7.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label7.Location = New Point(316, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 34)
        Label7.TabIndex = 6
        Label7.Text = "09123456789"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.LightYellow
        Label8.Font = New Font("Tw Cen MT Condensed Extra Bold", 21.75F)
        Label8.Location = New Point(316, 226)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 34)
        Label8.TabIndex = 7
        Label8.Text = "Philippines"
        ' 
        ' Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Account"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
