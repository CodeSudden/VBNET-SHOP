<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label7 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.7142868F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 59.2857132F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 146F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 84F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 102F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 99F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 141F))
        TableLayoutPanel1.Controls.Add(Label7, 6, 0)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label6, 5, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label5, 4, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label4, 3, 0)
        TableLayoutPanel1.Font = New Font("Segoe UI", 12F)
        TableLayoutPanel1.Location = New Point(35, 43)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 36F))
        TableLayoutPanel1.Size = New Size(870, 100)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Label7.Location = New Point(730, 1)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 19)
        Label7.TabIndex = 7
        Label7.Text = "Date Registered"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Label3.Location = New Point(295, 1)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 19)
        Label3.TabIndex = 3
        Label3.Text = "Account Name"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Label6.Location = New Point(630, 1)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 19)
        Label6.TabIndex = 6
        Label6.Text = "Contact"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Label1.Location = New Point(4, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 19)
        Label1.TabIndex = 1
        Label1.Text = "CustomerID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Label5.Location = New Point(527, 1)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 19)
        Label5.TabIndex = 5
        Label5.Text = "Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Label2.Location = New Point(123, 1)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 19)
        Label2.TabIndex = 2
        Label2.Text = "Customer Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        Label4.Location = New Point(442, 1)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 19)
        Label4.TabIndex = 4
        Label4.Text = "Item"
        ' 
        ' Customers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1061, 540)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Customers"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
