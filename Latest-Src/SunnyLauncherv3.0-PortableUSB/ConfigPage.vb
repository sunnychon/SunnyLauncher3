Imports System.IO
Imports System.Threading
Public Class ConfigPage
    Dim UsrName
    Dim InitMem
    Dim McMem
    Dim JvmPath
    Dim McVer
    Private Sub ConfigPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UsrName = File.ReadAllText("Cfg.UsrName.slcfg")
            InitMem = File.ReadAllText("Cfg.InitMem.slcfg")
            McMem = File.ReadAllText("Cfg.McMem.slcfg")
            JvmPath = File.ReadAllText("Cfg.JvmPath.slcfg")
            McVer = File.ReadAllText("Cfg.McVer.slcfg")
            UsrNameBox.Text = UsrName
            InitMemBox.Text = InitMem
            McMemBox.Text = McMem
            JvmPathBox.Text = JvmPath
            McVerBox.Text = McVer
        Catch
        End Try
    End Sub

    Private Sub CfgReset_Click(sender As Object, e As EventArgs) Handles CfgReset.Click
        UsrNameBox.Text = "SunnyLauncherUser"
        InitMemBox.Text = 1024
        McMemBox.Text = 2048
        JvmPathBox.Text = "..\..\..\Java_Runtime\jdk-18.0.2.1\bin\javaw.exe"
        McVerBox.Text = "f1.20.1"
        ApplyChanges()
    End Sub

    Sub ApplyChanges()
        UsrName = UsrNameBox.Text
        InitMem = InitMemBox.Text
        McMem = McMemBox.Text
        JvmPath = JvmPathBox.Text
        McVer = McVerBox.Text
        WriteCfg(UsrName, "UsrName")
        WriteCfg(InitMem, "InitMem")
        WriteCfg(McMem, "McMem")
        WriteCfg(JvmPath, "JvmPath")
        WriteCfg(McVer, "McVer")
        Thread.Sleep(500)
        Form1.UpdateCfg()
    End Sub

    Sub WriteCfg(ByVal Data, File)
        System.IO.File.WriteAllText("Cfg." & File & ".slcfg", Data)
    End Sub

    Private Sub CfgApply_Click(sender As Object, e As EventArgs) Handles CfgApply.Click
        ApplyChanges()
    End Sub

    Private Sub CfgCancel_Click(sender As Object, e As EventArgs) Handles CfgCancel.Click
        Me.Close()
    End Sub
End Class