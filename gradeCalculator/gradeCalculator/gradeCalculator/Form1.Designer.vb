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
        Me.LabelInput = New System.Windows.Forms.Label()
        Me.MarkInput = New System.Windows.Forms.TextBox()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.OKbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelInput
        '
        Me.LabelInput.AutoSize = True
        Me.LabelInput.Location = New System.Drawing.Point(25, 23)
        Me.LabelInput.Name = "LabelInput"
        Me.LabelInput.Size = New System.Drawing.Size(113, 20)
        Me.LabelInput.TabIndex = 0
        Me.LabelInput.Text = "Enter your mark"
        '
        'MarkInput
        '
        Me.MarkInput.Location = New System.Drawing.Point(186, 23)
        Me.MarkInput.Name = "MarkInput"
        Me.MarkInput.Size = New System.Drawing.Size(125, 27)
        Me.MarkInput.TabIndex = 1
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(45, 82)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(217, 20)
        Me.LabelDescription.TabIndex = 2
        Me.LabelDescription.Text = "Click OK to find out your grade."
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OKbtn
        '
        Me.OKbtn.Location = New System.Drawing.Point(113, 134)
        Me.OKbtn.Name = "OKbtn"
        Me.OKbtn.Size = New System.Drawing.Size(94, 29)
        Me.OKbtn.TabIndex = 3
        Me.OKbtn.Text = "OK"
        Me.OKbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 230)
        Me.Controls.Add(Me.OKbtn)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.MarkInput)
        Me.Controls.Add(Me.LabelInput)
        Me.Name = "Form1"
        Me.Text = "If...Then...Else"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInput As Label
    Friend WithEvents MarkInput As TextBox
    Friend WithEvents LabelDescription As Label
    Friend WithEvents OKbtn As Button
End Class
