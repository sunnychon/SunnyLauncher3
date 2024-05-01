'  ####    ##      
'###   #   ##      
'##        ##      
'###       ##      
'  ###     ##      
'    ###   ##      
'     ##   ##      
'#   ###   ##     #
' ####     #######  

Imports System.IO
Imports System.Threading
Public Class Form1
    Dim UsrName
    Dim InitMem
    Dim McMem
    Dim JvmPath
    Dim McVer
    Dim Configured_cfg

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Configured_cfg = False
        UpdateCfg()
        File.Delete("latest_news.txt")
        Shell("aria2c https://raw.githubusercontent.com/sunnychon/SunnyLauncherFiles/main/latest_news.txt")
        Thread.Sleep(2000)
        Try
            NewsBox.Text = File.ReadAllText("latest_news.txt")
        Catch
        End Try
        If Not File.Exists("aria2c.exe") Then
            NewsBox.Text = "Failed to get news because Aria2 not installed."
        End If
    End Sub

    Sub UpdateCfg()
        Try
            Me.UsrName = File.ReadAllText("Cfg.UsrName.slcfg")
            Me.InitMem = File.ReadAllText("Cfg.InitMem.slcfg")
            Me.McMem = File.ReadAllText("Cfg.McMem.slcfg")
            Me.JvmPath = File.ReadAllText("Cfg.JvmPath.slcfg")
            Me.McVer = File.ReadAllText("Cfg.McVer.slcfg")
            Thread.Sleep(500)
            If File.Exists("Cfg.UsrName.slcfg") Then
                If File.Exists("Cfg.McVer.slcfg") Then
                    Configured_cfg = True
                    Me.LaunchBtn.Text = "Launch - " & McVer & " - " & UsrName
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub StartSettings_Click(sender As Object, e As EventArgs) Handles StartSettings.Click
        ConfigPage.Show()
    End Sub

    Private Sub LaunchBtn_Click(sender As Object, e As EventArgs) Handles LaunchBtn.Click

        If Configured_cfg = True Then
            If File.Exists(".\Minecraft_Data\" & Me.McVer & "\.minecraft\runmc.bat") Then
                Shell("cmd /c .\Minecraft_Data\" & Me.McVer & "\.minecraft\runmc.bat " & Me.JvmPath & " " & Me.McMem & " " & Me.InitMem & " " & Me.UsrName, AppWinStyle.Hide)
                End
            Else
                LaunchBtn.Text = "runmc.bat Not Found! Make sure you have downloaded the correct version of Minecraft."
            End If
        Else
                ConfigPage.Show()
        End If
    End Sub
End Class
