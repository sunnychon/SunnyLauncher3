<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigPage
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigPage))
        Me.UsrNameBox = New System.Windows.Forms.TextBox()
        Me.UsrNameLabel = New System.Windows.Forms.Label()
        Me.InitMemLabel = New System.Windows.Forms.Label()
        Me.InitMemBox = New System.Windows.Forms.TextBox()
        Me.McMemBox = New System.Windows.Forms.TextBox()
        Me.JvmPathBox = New System.Windows.Forms.TextBox()
        Me.McVerBox = New System.Windows.Forms.TextBox()
        Me.McMemLabel = New System.Windows.Forms.Label()
        Me.JvmPathLabel = New System.Windows.Forms.Label()
        Me.McVerLabel = New System.Windows.Forms.Label()
        Me.CfgReset = New System.Windows.Forms.Button()
        Me.CfgCancel = New System.Windows.Forms.Button()
        Me.CfgApply = New System.Windows.Forms.Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsrNameBox
        '
        Me.UsrNameBox.Location = New System.Drawing.Point(97, 6)
        Me.UsrNameBox.Name = "UsrNameBox"
        Me.UsrNameBox.Size = New System.Drawing.Size(155, 22)
        Me.UsrNameBox.TabIndex = 0
        '
        'UsrNameLabel
        '
        Me.UsrNameLabel.AutoSize = True
        Me.UsrNameLabel.Location = New System.Drawing.Point(12, 9)
        Me.UsrNameLabel.Name = "UsrNameLabel"
        Me.UsrNameLabel.Size = New System.Drawing.Size(57, 12)
        Me.UsrNameLabel.TabIndex = 1
        Me.UsrNameLabel.Text = "User name:"
        '
        'InitMemLabel
        '
        Me.InitMemLabel.AutoSize = True
        Me.InitMemLabel.Location = New System.Drawing.Point(12, 37)
        Me.InitMemLabel.Name = "InitMemLabel"
        Me.InitMemLabel.Size = New System.Drawing.Size(66, 12)
        Me.InitMemLabel.TabIndex = 2
        Me.InitMemLabel.Text = "Init memory:"
        '
        'InitMemBox
        '
        Me.InitMemBox.Location = New System.Drawing.Point(97, 34)
        Me.InitMemBox.Name = "InitMemBox"
        Me.InitMemBox.Size = New System.Drawing.Size(155, 22)
        Me.InitMemBox.TabIndex = 3
        '
        'McMemBox
        '
        Me.McMemBox.Location = New System.Drawing.Point(97, 62)
        Me.McMemBox.Name = "McMemBox"
        Me.McMemBox.Size = New System.Drawing.Size(155, 22)
        Me.McMemBox.TabIndex = 4
        '
        'JvmPathBox
        '
        Me.JvmPathBox.Location = New System.Drawing.Point(97, 91)
        Me.JvmPathBox.Name = "JvmPathBox"
        Me.JvmPathBox.Size = New System.Drawing.Size(155, 22)
        Me.JvmPathBox.TabIndex = 5
        '
        'McVerBox
        '
        Me.McVerBox.Location = New System.Drawing.Point(97, 120)
        Me.McVerBox.Name = "McVerBox"
        Me.McVerBox.Size = New System.Drawing.Size(155, 22)
        Me.McVerBox.TabIndex = 6
        '
        'McMemLabel
        '
        Me.McMemLabel.AutoSize = True
        Me.McMemLabel.Location = New System.Drawing.Point(12, 65)
        Me.McMemLabel.Name = "McMemLabel"
        Me.McMemLabel.Size = New System.Drawing.Size(77, 12)
        Me.McMemLabel.TabIndex = 7
        Me.McMemLabel.Text = "Game memory:"
        '
        'JvmPathLabel
        '
        Me.JvmPathLabel.AutoSize = True
        Me.JvmPathLabel.Location = New System.Drawing.Point(13, 94)
        Me.JvmPathLabel.Name = "JvmPathLabel"
        Me.JvmPathLabel.Size = New System.Drawing.Size(50, 12)
        Me.JvmPathLabel.TabIndex = 8
        Me.JvmPathLabel.Text = "Jvm Path:"
        '
        'McVerLabel
        '
        Me.McVerLabel.AutoSize = True
        Me.McVerLabel.Location = New System.Drawing.Point(13, 123)
        Me.McVerLabel.Name = "McVerLabel"
        Me.McVerLabel.Size = New System.Drawing.Size(74, 12)
        Me.McVerLabel.TabIndex = 9
        Me.McVerLabel.Text = "Game Version:"
        '
        'CfgReset
        '
        Me.CfgReset.Location = New System.Drawing.Point(15, 160)
        Me.CfgReset.Name = "CfgReset"
        Me.CfgReset.Size = New System.Drawing.Size(75, 23)
        Me.CfgReset.TabIndex = 10
        Me.CfgReset.Text = "Reset"
        Me.CfgReset.UseVisualStyleBackColor = True
        '
        'CfgCancel
        '
        Me.CfgCancel.Location = New System.Drawing.Point(96, 160)
        Me.CfgCancel.Name = "CfgCancel"
        Me.CfgCancel.Size = New System.Drawing.Size(75, 23)
        Me.CfgCancel.TabIndex = 11
        Me.CfgCancel.Text = "Cancel"
        Me.CfgCancel.UseVisualStyleBackColor = True
        '
        'CfgApply
        '
        Me.CfgApply.Location = New System.Drawing.Point(177, 160)
        Me.CfgApply.Name = "CfgApply"
        Me.CfgApply.Size = New System.Drawing.Size(75, 23)
        Me.CfgApply.TabIndex = 12
        Me.CfgApply.Text = "Apply"
        Me.CfgApply.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Enabled = False
        Me.VersionLabel.Location = New System.Drawing.Point(12, 145)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(184, 12)
        Me.VersionLabel.TabIndex = 13
        Me.VersionLabel.Text = "SunnyLauncher Version 3.0Portable-b"
        '
        'ConfigPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 200)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.CfgApply)
        Me.Controls.Add(Me.CfgCancel)
        Me.Controls.Add(Me.CfgReset)
        Me.Controls.Add(Me.McVerLabel)
        Me.Controls.Add(Me.JvmPathLabel)
        Me.Controls.Add(Me.McMemLabel)
        Me.Controls.Add(Me.McVerBox)
        Me.Controls.Add(Me.JvmPathBox)
        Me.Controls.Add(Me.McMemBox)
        Me.Controls.Add(Me.InitMemBox)
        Me.Controls.Add(Me.InitMemLabel)
        Me.Controls.Add(Me.UsrNameLabel)
        Me.Controls.Add(Me.UsrNameBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(283, 239)
        Me.MinimumSize = New System.Drawing.Size(283, 239)
        Me.Name = "ConfigPage"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsrNameBox As TextBox
    Friend WithEvents UsrNameLabel As Label
    Friend WithEvents InitMemLabel As Label
    Friend WithEvents InitMemBox As TextBox
    Friend WithEvents McMemBox As TextBox
    Friend WithEvents JvmPathBox As TextBox
    Friend WithEvents McVerBox As TextBox
    Friend WithEvents McMemLabel As Label
    Friend WithEvents JvmPathLabel As Label
    Friend WithEvents McVerLabel As Label
    Friend WithEvents CfgReset As Button
    Friend WithEvents CfgCancel As Button
    Friend WithEvents CfgApply As Button
    Friend WithEvents VersionLabel As Label
End Class
