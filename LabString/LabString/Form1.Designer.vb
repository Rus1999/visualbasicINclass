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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.UniversityLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UniversityTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CheckDataBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(3, 6)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(49, 20)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'UniversityLabel
        '
        Me.UniversityLabel.AutoSize = True
        Me.UniversityLabel.Location = New System.Drawing.Point(3, 42)
        Me.UniversityLabel.Name = "UniversityLabel"
        Me.UniversityLabel.Size = New System.Drawing.Size(73, 20)
        Me.UniversityLabel.TabIndex = 1
        Me.UniversityLabel.Text = "University"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(3, 78)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(50, 20)
        Me.PhoneLabel.TabIndex = 2
        Me.PhoneLabel.Text = "Phone"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(83, 6)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(228, 27)
        Me.NameTextBox.TabIndex = 3
        '
        'UniversityTextBox
        '
        Me.UniversityTextBox.Location = New System.Drawing.Point(83, 42)
        Me.UniversityTextBox.Name = "UniversityTextBox"
        Me.UniversityTextBox.Size = New System.Drawing.Size(228, 27)
        Me.UniversityTextBox.TabIndex = 4
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(83, 78)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(228, 27)
        Me.PhoneTextBox.TabIndex = 5
        '
        'CheckDataBtn
        '
        Me.CheckDataBtn.Location = New System.Drawing.Point(12, 118)
        Me.CheckDataBtn.Name = "CheckDataBtn"
        Me.CheckDataBtn.Size = New System.Drawing.Size(299, 29)
        Me.CheckDataBtn.TabIndex = 6
        Me.CheckDataBtn.Text = "Check Data"
        Me.CheckDataBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 159)
        Me.Controls.Add(Me.CheckDataBtn)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.UniversityTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.UniversityLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "Form1"
        Me.Text = "Input Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents UniversityLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents UniversityTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents CheckDataBtn As Button
End Class
