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
        Me.ResultText = New System.Windows.Forms.Label()
        Me.BoldChk = New System.Windows.Forms.CheckBox()
        Me.ItalicChk = New System.Windows.Forms.CheckBox()
        Me.UnderlinedChk = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultText
        '
        Me.ResultText.BackColor = System.Drawing.Color.MistyRose
        Me.ResultText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultText.Location = New System.Drawing.Point(12, 9)
        Me.ResultText.Name = "ResultText"
        Me.ResultText.Size = New System.Drawing.Size(237, 25)
        Me.ResultText.TabIndex = 0
        Me.ResultText.Text = "WOWZAA!!!"
        Me.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BoldChk
        '
        Me.BoldChk.AutoSize = True
        Me.BoldChk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BoldChk.Location = New System.Drawing.Point(12, 43)
        Me.BoldChk.Name = "BoldChk"
        Me.BoldChk.Size = New System.Drawing.Size(63, 24)
        Me.BoldChk.TabIndex = 1
        Me.BoldChk.Text = "Bold"
        Me.BoldChk.UseVisualStyleBackColor = True
        '
        'ItalicChk
        '
        Me.ItalicChk.AutoSize = True
        Me.ItalicChk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.ItalicChk.Location = New System.Drawing.Point(80, 43)
        Me.ItalicChk.Name = "ItalicChk"
        Me.ItalicChk.Size = New System.Drawing.Size(63, 24)
        Me.ItalicChk.TabIndex = 2
        Me.ItalicChk.Text = "Italic"
        Me.ItalicChk.UseVisualStyleBackColor = True
        '
        'UnderlinedChk
        '
        Me.UnderlinedChk.AutoSize = True
        Me.UnderlinedChk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.UnderlinedChk.Location = New System.Drawing.Point(149, 43)
        Me.UnderlinedChk.Name = "UnderlinedChk"
        Me.UnderlinedChk.Size = New System.Drawing.Size(104, 24)
        Me.UnderlinedChk.TabIndex = 3
        Me.UnderlinedChk.Text = "Underlined"
        Me.UnderlinedChk.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(261, 73)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UnderlinedChk)
        Me.Controls.Add(Me.ItalicChk)
        Me.Controls.Add(Me.BoldChk)
        Me.Controls.Add(Me.ResultText)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultText As Label
    Friend WithEvents BoldChk As CheckBox
    Friend WithEvents ItalicChk As CheckBox
    Friend WithEvents UnderlinedChk As CheckBox
    Friend WithEvents Button1 As Button
End Class
