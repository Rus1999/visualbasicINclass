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
        Me.LaserJetX = New System.Windows.Forms.CheckBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BigNotebook = New System.Windows.Forms.CheckBox()
        Me.SmartDesktop = New System.Windows.Forms.CheckBox()
        Me.HDDigicam = New System.Windows.Forms.CheckBox()
        Me.HiTechMP4 = New System.Windows.Forms.CheckBox()
        Me.ADSLModem = New System.Windows.Forms.CheckBox()
        Me.LaserJetX_price = New System.Windows.Forms.Label()
        Me.BigNotebook_price = New System.Windows.Forms.Label()
        Me.SmartDesktop_price = New System.Windows.Forms.Label()
        Me.HDDigicam_price = New System.Windows.Forms.Label()
        Me.HiTechMP4_price = New System.Windows.Forms.Label()
        Me.ADSLModem_price = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LaserJetX
        '
        Me.LaserJetX.AutoSize = True
        Me.LaserJetX.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LaserJetX.Location = New System.Drawing.Point(12, 55)
        Me.LaserJetX.Name = "LaserJetX"
        Me.LaserJetX.Size = New System.Drawing.Size(100, 24)
        Me.LaserJetX.TabIndex = 0
        Me.LaserJetX.Text = "Laser Jet X"
        Me.LaserJetX.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(308, 31)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "WOWZAA!!! Shopping Cart"
        '
        'BigNotebook
        '
        Me.BigNotebook.AutoSize = True
        Me.BigNotebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BigNotebook.Location = New System.Drawing.Point(12, 85)
        Me.BigNotebook.Name = "BigNotebook"
        Me.BigNotebook.Size = New System.Drawing.Size(124, 24)
        Me.BigNotebook.TabIndex = 2
        Me.BigNotebook.Text = "Big Notebook"
        Me.BigNotebook.UseVisualStyleBackColor = True
        '
        'SmartDesktop
        '
        Me.SmartDesktop.AutoSize = True
        Me.SmartDesktop.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SmartDesktop.Location = New System.Drawing.Point(12, 115)
        Me.SmartDesktop.Name = "SmartDesktop"
        Me.SmartDesktop.Size = New System.Drawing.Size(129, 24)
        Me.SmartDesktop.TabIndex = 3
        Me.SmartDesktop.Text = "Smart Desktop"
        Me.SmartDesktop.UseVisualStyleBackColor = True
        '
        'HDDigicam
        '
        Me.HDDigicam.AutoSize = True
        Me.HDDigicam.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HDDigicam.Location = New System.Drawing.Point(12, 145)
        Me.HDDigicam.Name = "HDDigicam"
        Me.HDDigicam.Size = New System.Drawing.Size(113, 24)
        Me.HDDigicam.TabIndex = 4
        Me.HDDigicam.Text = "HD Digicam"
        Me.HDDigicam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HDDigicam.UseVisualStyleBackColor = True
        '
        'HiTechMP4
        '
        Me.HiTechMP4.AutoSize = True
        Me.HiTechMP4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HiTechMP4.Location = New System.Drawing.Point(12, 175)
        Me.HiTechMP4.Name = "HiTechMP4"
        Me.HiTechMP4.Size = New System.Drawing.Size(109, 24)
        Me.HiTechMP4.TabIndex = 5
        Me.HiTechMP4.Text = "HiTech MP4"
        Me.HiTechMP4.UseVisualStyleBackColor = True
        '
        'ADSLModem
        '
        Me.ADSLModem.AutoSize = True
        Me.ADSLModem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ADSLModem.Location = New System.Drawing.Point(12, 205)
        Me.ADSLModem.Name = "ADSLModem"
        Me.ADSLModem.Size = New System.Drawing.Size(123, 24)
        Me.ADSLModem.TabIndex = 6
        Me.ADSLModem.Text = "ADSL Modem"
        Me.ADSLModem.UseVisualStyleBackColor = True
        '
        'LaserJetX_price
        '
        Me.LaserJetX_price.AutoSize = True
        Me.LaserJetX_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LaserJetX_price.Location = New System.Drawing.Point(256, 55)
        Me.LaserJetX_price.Name = "LaserJetX_price"
        Me.LaserJetX_price.Size = New System.Drawing.Size(41, 20)
        Me.LaserJetX_price.TabIndex = 7
        Me.LaserJetX_price.Text = "$100"
        Me.LaserJetX_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BigNotebook_price
        '
        Me.BigNotebook_price.AutoSize = True
        Me.BigNotebook_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BigNotebook_price.Location = New System.Drawing.Point(256, 85)
        Me.BigNotebook_price.Name = "BigNotebook_price"
        Me.BigNotebook_price.Size = New System.Drawing.Size(41, 20)
        Me.BigNotebook_price.TabIndex = 8
        Me.BigNotebook_price.Text = "$500"
        Me.BigNotebook_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SmartDesktop_price
        '
        Me.SmartDesktop_price.AutoSize = True
        Me.SmartDesktop_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SmartDesktop_price.Location = New System.Drawing.Point(256, 115)
        Me.SmartDesktop_price.Name = "SmartDesktop_price"
        Me.SmartDesktop_price.Size = New System.Drawing.Size(41, 20)
        Me.SmartDesktop_price.TabIndex = 9
        Me.SmartDesktop_price.Text = "$200"
        Me.SmartDesktop_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HDDigicam_price
        '
        Me.HDDigicam_price.AutoSize = True
        Me.HDDigicam_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HDDigicam_price.Location = New System.Drawing.Point(264, 145)
        Me.HDDigicam_price.Name = "HDDigicam_price"
        Me.HDDigicam_price.Size = New System.Drawing.Size(33, 20)
        Me.HDDigicam_price.TabIndex = 10
        Me.HDDigicam_price.Text = "$80"
        Me.HDDigicam_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HiTechMP4_price
        '
        Me.HiTechMP4_price.AutoSize = True
        Me.HiTechMP4_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HiTechMP4_price.Location = New System.Drawing.Point(256, 175)
        Me.HiTechMP4_price.Name = "HiTechMP4_price"
        Me.HiTechMP4_price.Size = New System.Drawing.Size(41, 20)
        Me.HiTechMP4_price.TabIndex = 11
        Me.HiTechMP4_price.Text = "$300"
        Me.HiTechMP4_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ADSLModem_price
        '
        Me.ADSLModem_price.AutoSize = True
        Me.ADSLModem_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ADSLModem_price.Location = New System.Drawing.Point(256, 205)
        Me.ADSLModem_price.Name = "ADSLModem_price"
        Me.ADSLModem_price.Size = New System.Drawing.Size(41, 20)
        Me.ADSLModem_price.TabIndex = 12
        Me.ADSLModem_price.Text = "$150"
        Me.ADSLModem_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Total.Location = New System.Drawing.Point(12, 247)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(49, 25)
        Me.Total.TabIndex = 13
        Me.Total.Text = "Total"
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Result
        '
        Me.Result.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Result.Location = New System.Drawing.Point(210, 251)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(87, 20)
        Me.Result.TabIndex = 14
        Me.Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Calculate
        '
        Me.Calculate.BackColor = System.Drawing.Color.Turquoise
        Me.Calculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calculate.Location = New System.Drawing.Point(61, 284)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(94, 29)
        Me.Calculate.TabIndex = 15
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.Crimson
        Me.Reset.Location = New System.Drawing.Point(161, 284)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(94, 29)
        Me.Reset.TabIndex = 16
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(323, 321)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.ADSLModem_price)
        Me.Controls.Add(Me.HiTechMP4_price)
        Me.Controls.Add(Me.HDDigicam_price)
        Me.Controls.Add(Me.SmartDesktop_price)
        Me.Controls.Add(Me.BigNotebook_price)
        Me.Controls.Add(Me.LaserJetX_price)
        Me.Controls.Add(Me.ADSLModem)
        Me.Controls.Add(Me.HiTechMP4)
        Me.Controls.Add(Me.HDDigicam)
        Me.Controls.Add(Me.SmartDesktop)
        Me.Controls.Add(Me.BigNotebook)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.LaserJetX)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "Form1"
        Me.Text = "WOWZAA!!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LaserJetX As Windows.Forms.CheckBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BigNotebook As Windows.Forms.CheckBox
    Friend WithEvents SmartDesktop As Windows.Forms.CheckBox
    Friend WithEvents HDDigicam As Windows.Forms.CheckBox
    Friend WithEvents HiTechMP4 As Windows.Forms.CheckBox
    Friend WithEvents ADSLModem As Windows.Forms.CheckBox
    Friend WithEvents LaserJetX_price As Label
    Friend WithEvents BigNotebook_price As Label
    Friend WithEvents SmartDesktop_price As Label
    Friend WithEvents HDDigicam_price As Label
    Friend WithEvents HiTechMP4_price As Label
    Friend WithEvents ADSLModem_price As Label
    Friend WithEvents Total As Label
    Friend WithEvents Result As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents Reset As Button
End Class
