<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        lblEarn = New Label()
        lblCustomer = New Label()
        lblProducts = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(207, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 40)
        Label1.TabIndex = 0
        Label1.Text = "Total Earnings:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(207, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 40)
        Label2.TabIndex = 1
        Label2.Text = "Total Customers:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(207, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(250, 40)
        Label3.TabIndex = 2
        Label3.Text = "Total Products:"
        ' 
        ' lblEarn
        ' 
        lblEarn.AutoSize = True
        lblEarn.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEarn.Location = New Point(530, 160)
        lblEarn.Name = "lblEarn"
        lblEarn.Size = New Size(251, 40)
        lblEarn.TabIndex = 3
        lblEarn.Text = "Total Earnings:"
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomer.Location = New Point(530, 226)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(276, 40)
        lblCustomer.TabIndex = 4
        lblCustomer.Text = "Total Customers:"
        ' 
        ' lblProducts
        ' 
        lblProducts.AutoSize = True
        lblProducts.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProducts.Location = New Point(531, 299)
        lblProducts.Name = "lblProducts"
        lblProducts.Size = New Size(250, 40)
        lblProducts.TabIndex = 5
        lblProducts.Text = "Total Products:"
        ' 
        ' Reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1061, 540)
        Controls.Add(lblProducts)
        Controls.Add(lblCustomer)
        Controls.Add(lblEarn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Reports"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEarn As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblProducts As Label
End Class
