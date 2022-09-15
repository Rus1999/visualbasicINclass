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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.RmBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBoxBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"White", "Blue", "Pink", "Black", "Red", "Crimson"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(112, 144)
        Me.ListBox1.TabIndex = 0
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.AddBtn.Location = New System.Drawing.Point(130, 12)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(94, 29)
        Me.AddBtn.TabIndex = 1
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'RmBtn
        '
        Me.RmBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.RmBtn.Location = New System.Drawing.Point(130, 47)
        Me.RmBtn.Name = "RmBtn"
        Me.RmBtn.Size = New System.Drawing.Size(94, 29)
        Me.RmBtn.TabIndex = 2
        Me.RmBtn.Text = "Remove"
        Me.RmBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.ClearBtn.Location = New System.Drawing.Point(130, 82)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(94, 29)
        Me.ClearBtn.TabIndex = 3
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(230, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(301, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCoral
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(230, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightCoral
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"White", "Blue", "Pink", "Black", "Red", "Crimson"})
        Me.ComboBox1.Location = New System.Drawing.Point(230, 117)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 28)
        Me.ComboBox1.TabIndex = 7
        '
        'ListBoxBtn
        '
        Me.ListBoxBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.ListBoxBtn.Location = New System.Drawing.Point(130, 117)
        Me.ListBoxBtn.Name = "ListBoxBtn"
        Me.ListBoxBtn.Size = New System.Drawing.Size(94, 29)
        Me.ListBoxBtn.TabIndex = 8
        Me.ListBoxBtn.Text = "Show"
        Me.ListBoxBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 163)
        Me.Controls.Add(Me.ListBoxBtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.RmBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "WOWZAA!!!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents RmBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBoxBtn As Button
End Class
