<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stopwatch
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
        Me.components = New System.ComponentModel.Container()
        Me.TimerLbl = New System.Windows.Forms.Label()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TimerLbl
        '
        Me.TimerLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TimerLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TimerLbl.Location = New System.Drawing.Point(12, 9)
        Me.TimerLbl.Name = "TimerLbl"
        Me.TimerLbl.Size = New System.Drawing.Size(112, 84)
        Me.TimerLbl.TabIndex = 0
        Me.TimerLbl.Text = "0"
        Me.TimerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartBtn
        '
        Me.StartBtn.Location = New System.Drawing.Point(130, 9)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartBtn.TabIndex = 1
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'StopBtn
        '
        Me.StopBtn.Location = New System.Drawing.Point(130, 38)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(75, 23)
        Me.StopBtn.TabIndex = 2
        Me.StopBtn.Text = "Stop"
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(130, 70)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(75, 23)
        Me.ResetBtn.TabIndex = 3
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'stopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(212, 101)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.StopBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.TimerLbl)
        Me.Name = "stopwatch"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimerLbl As Label
    Friend WithEvents StartBtn As Button
    Friend WithEvents StopBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Timer1 As Timer
End Class
