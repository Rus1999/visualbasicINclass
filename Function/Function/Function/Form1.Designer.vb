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
        Me.CalBtn = New System.Windows.Forms.Button()
        Me.HeightLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeightTxtBox = New System.Windows.Forms.TextBox()
        Me.WeightTxtBox = New System.Windows.Forms.TextBox()
        Me.BMILbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalBtn
        '
        Me.CalBtn.Location = New System.Drawing.Point(54, 101)
        Me.CalBtn.Name = "CalBtn"
        Me.CalBtn.Size = New System.Drawing.Size(94, 29)
        Me.CalBtn.TabIndex = 0
        Me.CalBtn.Text = "Calculate"
        Me.CalBtn.UseVisualStyleBackColor = True
        '
        'HeightLbl
        '
        Me.HeightLbl.AutoSize = True
        Me.HeightLbl.Location = New System.Drawing.Point(12, 9)
        Me.HeightLbl.Name = "HeightLbl"
        Me.HeightLbl.Size = New System.Drawing.Size(81, 20)
        Me.HeightLbl.TabIndex = 1
        Me.HeightLbl.Text = "Height (m)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Weight (kg)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BMI"
        '
        'HeightTxtBox
        '
        Me.HeightTxtBox.Location = New System.Drawing.Point(99, 6)
        Me.HeightTxtBox.Name = "HeightTxtBox"
        Me.HeightTxtBox.Size = New System.Drawing.Size(97, 27)
        Me.HeightTxtBox.TabIndex = 4
        '
        'WeightTxtBox
        '
        Me.WeightTxtBox.Location = New System.Drawing.Point(99, 37)
        Me.WeightTxtBox.Name = "WeightTxtBox"
        Me.WeightTxtBox.Size = New System.Drawing.Size(97, 27)
        Me.WeightTxtBox.TabIndex = 5
        '
        'BMILbl
        '
        Me.BMILbl.BackColor = System.Drawing.Color.IndianRed
        Me.BMILbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BMILbl.Location = New System.Drawing.Point(99, 71)
        Me.BMILbl.Name = "BMILbl"
        Me.BMILbl.Size = New System.Drawing.Size(97, 27)
        Me.BMILbl.TabIndex = 6
        Me.BMILbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 136)
        Me.Controls.Add(Me.BMILbl)
        Me.Controls.Add(Me.WeightTxtBox)
        Me.Controls.Add(Me.HeightTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HeightLbl)
        Me.Controls.Add(Me.CalBtn)
        Me.Name = "Form1"
        Me.Text = "BMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalBtn As Button
    Friend WithEvents HeightLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HeightTxtBox As TextBox
    Friend WithEvents WeightTxtBox As TextBox
    Friend WithEvents BMILbl As Label
End Class
