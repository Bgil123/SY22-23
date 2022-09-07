<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nametextbox = New System.Windows.Forms.TextBox()
        Me.CCTextBox = New System.Windows.Forms.TextBox()
        Me.ExpdateTextBox = New System.Windows.Forms.TextBox()
        Me.ziptextbox = New System.Windows.Forms.TextBox()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.Buybutton = New System.Windows.Forms.Button()
        Me.cancelbutton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.feetextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "cc#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exp Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "zip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount"
        '
        'nametextbox
        '
        Me.nametextbox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.nametextbox.Location = New System.Drawing.Point(75, 12)
        Me.nametextbox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.nametextbox.Name = "nametextbox"
        Me.nametextbox.Size = New System.Drawing.Size(66, 30)
        Me.nametextbox.TabIndex = 5
        '
        'CCTextBox
        '
        Me.CCTextBox.Location = New System.Drawing.Point(79, 55)
        Me.CCTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CCTextBox.Name = "CCTextBox"
        Me.CCTextBox.Size = New System.Drawing.Size(66, 30)
        Me.CCTextBox.TabIndex = 6
        '
        'ExpdateTextBox
        '
        Me.ExpdateTextBox.Location = New System.Drawing.Point(102, 92)
        Me.ExpdateTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ExpdateTextBox.Name = "ExpdateTextBox"
        Me.ExpdateTextBox.Size = New System.Drawing.Size(66, 30)
        Me.ExpdateTextBox.TabIndex = 7
        '
        'ziptextbox
        '
        Me.ziptextbox.Location = New System.Drawing.Point(79, 135)
        Me.ziptextbox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ziptextbox.Name = "ziptextbox"
        Me.ziptextbox.Size = New System.Drawing.Size(66, 30)
        Me.ziptextbox.TabIndex = 8
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(92, 175)
        Me.amountTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(66, 30)
        Me.amountTextBox.TabIndex = 9
        '
        'Buybutton
        '
        Me.Buybutton.ForeColor = System.Drawing.Color.DarkGreen
        Me.Buybutton.Location = New System.Drawing.Point(13, 433)
        Me.Buybutton.Name = "Buybutton"
        Me.Buybutton.Size = New System.Drawing.Size(98, 37)
        Me.Buybutton.TabIndex = 10
        Me.Buybutton.Text = "Buy"
        Me.Buybutton.UseVisualStyleBackColor = True
        '
        'cancelbutton
        '
        Me.cancelbutton.ForeColor = System.Drawing.Color.Red
        Me.cancelbutton.Location = New System.Drawing.Point(550, 433)
        Me.cancelbutton.Name = "cancelbutton"
        Me.cancelbutton.Size = New System.Drawing.Size(102, 37)
        Me.cancelbutton.TabIndex = 11
        Me.cancelbutton.Text = "Cancel"
        Me.cancelbutton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fee"
        '
        'feetextbox
        '
        Me.feetextbox.Location = New System.Drawing.Point(79, 220)
        Me.feetextbox.Name = "feetextbox"
        Me.feetextbox.Size = New System.Drawing.Size(100, 30)
        Me.feetextbox.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(709, 482)
        Me.Controls.Add(Me.feetextbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cancelbutton)
        Me.Controls.Add(Me.Buybutton)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.ziptextbox)
        Me.Controls.Add(Me.ExpdateTextBox)
        Me.Controls.Add(Me.CCTextBox)
        Me.Controls.Add(Me.nametextbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "My App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nametextbox As TextBox
    Friend WithEvents CCTextBox As TextBox
    Friend WithEvents ExpdateTextBox As TextBox
    Friend WithEvents ziptextbox As TextBox
    Friend WithEvents amountTextBox As TextBox
    Friend WithEvents Buybutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents feetextbox As TextBox
End Class
