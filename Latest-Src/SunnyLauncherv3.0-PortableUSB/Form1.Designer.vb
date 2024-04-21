<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StartSettings = New System.Windows.Forms.Button()
        Me.LaunchBtn = New System.Windows.Forms.Button()
        Me.NewsBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SunnyLauncherv3._0_PortableUSB.My.Resources.Resources.SLPortable
        Me.PictureBox1.Location = New System.Drawing.Point(-34, -25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 236)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StartSettings
        '
        Me.StartSettings.Location = New System.Drawing.Point(543, 12)
        Me.StartSettings.Name = "StartSettings"
        Me.StartSettings.Size = New System.Drawing.Size(75, 23)
        Me.StartSettings.TabIndex = 1
        Me.StartSettings.Text = "Settings"
        Me.StartSettings.UseVisualStyleBackColor = True
        '
        'LaunchBtn
        '
        Me.LaunchBtn.Font = New System.Drawing.Font("新細明體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LaunchBtn.Location = New System.Drawing.Point(12, 217)
        Me.LaunchBtn.Name = "LaunchBtn"
        Me.LaunchBtn.Size = New System.Drawing.Size(606, 86)
        Me.LaunchBtn.TabIndex = 2
        Me.LaunchBtn.Text = "Need to reset settings"
        Me.LaunchBtn.UseVisualStyleBackColor = True
        '
        'NewsBox
        '
        Me.NewsBox.Location = New System.Drawing.Point(204, 34)
        Me.NewsBox.Multiline = True
        Me.NewsBox.Name = "NewsBox"
        Me.NewsBox.Size = New System.Drawing.Size(333, 177)
        Me.NewsBox.TabIndex = 3
        Me.NewsBox.Text = "Failed to get news,please cheak your network connection."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "News"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewsBox)
        Me.Controls.Add(Me.LaunchBtn)
        Me.Controls.Add(Me.StartSettings)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(646, 354)
        Me.MinimumSize = New System.Drawing.Size(646, 354)
        Me.Name = "Form1"
        Me.Text = "SunnyLauncher 3.0 Portable USB"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StartSettings As Button
    Friend WithEvents LaunchBtn As Button
    Friend WithEvents NewsBox As TextBox
    Friend WithEvents Label1 As Label
End Class
