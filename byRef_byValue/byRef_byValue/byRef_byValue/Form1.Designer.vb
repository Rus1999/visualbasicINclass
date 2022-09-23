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
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.ValueLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShowBtn
        '
        Me.ShowBtn.Location = New System.Drawing.Point(12, 9)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(198, 29)
        Me.ShowBtn.TabIndex = 0
        Me.ShowBtn.Text = "ShowBtn"
        Me.ShowBtn.UseVisualStyleBackColor = True
        '
        'ValueLbl
        '
        Me.ValueLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ValueLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ValueLbl.Location = New System.Drawing.Point(12, 41)
        Me.ValueLbl.Name = "ValueLbl"
        Me.ValueLbl.Size = New System.Drawing.Size(198, 225)
        Me.ValueLbl.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 275)
        Me.Controls.Add(Me.ValueLbl)
        Me.Controls.Add(Me.ShowBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShowBtn As Button
    Friend WithEvents ValueLbl As Label
End Class
