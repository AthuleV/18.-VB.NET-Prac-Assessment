<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        Button2 = New Button()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(73, 54)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(159, 229)
        ListBox1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(309, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(309, 97)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(309, 139)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(141, 100)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Case"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(10, 65)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(72, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "To Lower"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(9, 30)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(72, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "To Upper"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Location = New Point(479, 139)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(133, 100)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Color"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(8, 66)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(48, 19)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Blue"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(7, 34)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(45, 19)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Red"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(661, 318)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(309, 276)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 27)
        Label1.TabIndex = 6
        Label1.Text = "                                                  "
        Label1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label

End Class
