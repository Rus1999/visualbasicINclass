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
        Me.MarkInput = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.MarkInputBox = New System.Windows.Forms.TextBox()
        Me.GradeResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MarkInput
        '
        Me.MarkInput.AutoSize = True
        Me.MarkInput.Location = New System.Drawing.Point(3, 6)
        Me.MarkInput.Name = "MarkInput"
        Me.MarkInput.Size = New System.Drawing.Size(159, 20)
        Me.MarkInput.TabIndex = 0
        Me.MarkInput.Text = "Please enter your mark"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(103, 33)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(49, 20)
        Me.GradeLabel.TabIndex = 1
        Me.GradeLabel.Text = "Grade"
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(3, 29)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(94, 29)
        Me.CalculateBtn.TabIndex = 2
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'MarkInputBox
        '
        Me.MarkInputBox.Location = New System.Drawing.Point(168, 3)
        Me.MarkInputBox.Name = "MarkInputBox"
        Me.MarkInputBox.Size = New System.Drawing.Size(139, 27)
        Me.MarkInputBox.TabIndex = 3
        '
        'GradeResult
        '
        Me.GradeResult.Location = New System.Drawing.Point(168, 33)
        Me.GradeResult.Name = "GradeResult"
        Me.GradeResult.Size = New System.Drawing.Size(139, 27)
        Me.GradeResult.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 61)
        Me.Controls.Add(Me.GradeResult)
        Me.Controls.Add(Me.MarkInputBox)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.GradeLabel)
        Me.Controls.Add(Me.MarkInput)
        Me.Name = "Form1"
        Me.Text = "WoW Zaa!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarkInput As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents MarkInputBox As TextBox
    Friend WithEvents GradeResult As TextBox
End Class
