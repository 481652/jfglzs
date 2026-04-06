Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports przs.Internal

' Token: 0x0200000C RID: 12
<DesignerGenerated()>
Public Partial Class Form1
	Inherits Form

	' Token: 0x06000036 RID: 54 RVA: 0x00002BFC File Offset: 0x00000DFC
	Public Sub New()
		AddHandler MyBase.Load, AddressOf Me.CountAttribute
		Me.m_Visitor = 0L
		Me.m_Printer = 0
		Me._Publisher = 0
		Me._Importer = "C:\windows\jf"
		Me.m_Resolver = "C:\Windows\System32\drivers\etc\hosts"
		Me.test = 4194304L
		Me.SelectAttribute()
	End Sub

	' Token: 0x06000037 RID: 55 RVA: 0x00002C6C File Offset: 0x00000E6C
	Private Sub QueryAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			Me.Timer1.Enabled = True
			IL_16:
			num2 = 3
			Dim left As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "games_jianche", ""))
			IL_38:
			num2 = 4
			If Operators.CompareString(left, "on", False) <> 0 Then
				GoTo IL_57
			End If
			IL_49:
			num2 = 5
			Me.Timer_youxi.Enabled = True
			IL_57:
			num2 = 6
			Dim left2 As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "bianhao", ""))
			IL_78:
			num2 = 7
			If Operators.CompareString(left2, "on", False) <> 0 Then
				GoTo IL_99
			End If
			IL_88:
			num2 = 8
			Value.SetupAttribute.bianhao.Show()
			IL_99:
			num2 = 9
			Me.Timer_main.Enabled = False
			IL_A8:
			GoTo IL_118
			IL_AA:
			GoTo IL_122
			IL_AC:
			num3 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_F6
			IL_BE:
			Dim num4 As Integer = num3 + 1
			num3 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
			IL_F6:
			GoTo IL_122
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_AC
		End Try
		IL_118:
		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_122:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x06000038 RID: 56 RVA: 0x0000250F File Offset: 0x0000070F
	Private Sub CalculateAttribute(sender As Object, e As EventArgs)
		If Not Value.SetupAttribute.Form2.Visible Then
			Value.SetupAttribute.Form2.Show()
		End If
	End Sub

	' Token: 0x06000039 RID: 57 RVA: 0x00002DB8 File Offset: 0x00000FB8
	Private Sub MoveAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			If Me.SortAttribute("jfglzsn") Then
				GoTo IL_11A
			End If
			IL_1A:
			num2 = 3
			Me.m_Database += 1L
			IL_32:
			num2 = 4
			If File.Exists(Conversions.ToString(Operators.ConcatenateObject(przs.Internal.Message._Role, "\jfglzsn.exe"))) Then
				GoTo IL_94
			End If
			IL_4F:
			num2 = 5
			If Not File.Exists(Me._Importer + "\jfglzsn.dat") Then
				GoTo IL_94
			End If
			IL_68:
			num2 = 7
			File.Copy(Me._Importer + "\jfglzsn.dat", Conversions.ToString(Operators.ConcatenateObject(przs.Internal.Message._Role, "\jfglzsn.exe")), True)
			IL_94:
			num2 = 8
			NewLateBinding.LateCall(Nothing, GetType(Process), "Start", New Object() { Operators.ConcatenateObject(przs.Internal.Message._Role, "\jfglzsn.exe") }, Nothing, Nothing, Nothing, True)
			IL_C9:
			num2 = 9
			If Me.m_Database < 40L Then
				GoTo IL_11A
			End If
			IL_DD:
			num2 = 10
			Value.SetupAttribute.Form2.shuoming.Text = "进程j被多次终止或文件会被杀毒软件（如win10自带的defender）清除！"
			IL_F9:
			num2 = 11
			Value.SetupAttribute.Form2.Show()
			IL_10B:
			num2 = 12
			Me.Timer2.Enabled = True
			IL_11A:
			GoTo IL_199
			IL_11C:
			GoTo IL_1A3
			IL_121:
			num3 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_177
			IL_133:
			Dim num4 As Integer = num3 + 1
			num3 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
			IL_177:
			GoTo IL_1A3
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_121
		End Try
		IL_199:
		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_1A3:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x0600003A RID: 58 RVA: 0x00002F90 File Offset: 0x00001190
	Private Sub CallAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			If File.Exists(Me.m_Resolver) Then
				GoTo IL_103
			End If
			IL_1A:
			num2 = 3
			Me.m_Order += 1L
			IL_32:
			num2 = 4
			Me.m_Base = True
			IL_3B:
			num2 = 5
			If Not File.Exists(Me.m_Resolver + "2") Then
				GoTo IL_9E
			End If
			IL_54:
			num2 = 6
			File.Copy(Me.m_Resolver + "2", Me.m_Resolver, True)
			IL_72:
			num2 = 7
			Value.SetupAttribute.Form3.shuoming.Text = "hosts文件被删除！现在恢复。"
			IL_8D:
			num2 = 8
			Value.SetupAttribute.Form3.Show()
			IL_9E:
			num2 = 9
			If Me.m_Order <= 5L Then
				GoTo IL_12A
			End If
			IL_B2:
			num2 = 10
			Value.SetupAttribute.Form3.Close()
			IL_C4:
			num2 = 11
			Value.SetupAttribute.Form2.shuoming.Text = "hosts文件多次被删除或备份文件不存在！"
			IL_E0:
			num2 = 12
			Value.SetupAttribute.Form2.Show()
			IL_F2:
			num2 = 13
			Me.Timer2.Enabled = True
			GoTo IL_12A
			IL_103:
			num2 = 15
			If Not Me.m_Base Then
				GoTo IL_120
			End If
			IL_10E:
			num2 = 16
			Value.SetupAttribute.Form3.Close()
			IL_120:
			num2 = 17
			Me.m_Base = False
			IL_12A:
			GoTo IL_1C3
			IL_12F:
			GoTo IL_1CD
			IL_134:
			num3 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_19E
			IL_146:
			Dim num4 As Integer = num3 + 1
			num3 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
			IL_19E:
			GoTo IL_1CD
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_134
		End Try
		IL_1C3:
		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_1CD:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x0600003B RID: 59 RVA: 0x00003194 File Offset: 0x00001394
	Private Sub PushAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", ""))
			IL_2A:
			num2 = 3
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", ""))
			IL_4C:
			num2 = 4
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", ""))
			IL_6E:
			num2 = 5
			If Not Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectNotEqual(objectValue, "3", False), Operators.CompareObjectNotEqual(objectValue2, "3", False)), Operators.CompareObjectNotEqual(objectValue3, "3", False))) Then
				GoTo IL_440
			End If
			IL_AB:
			num2 = 6
			Me.m_Object += 1L
			IL_C3:
			num2 = 7
			If Me.m_Object > 15L Then
				GoTo IL_3D3
			End If
			IL_D9:
			num2 = 8
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 3, 4)
			IL_F6:
			num2 = 9
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 1, 4)
			IL_114:
			num2 = 10
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 1, 4)
			IL_132:
			num2 = 11
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 3, 4)
			IL_150:
			num2 = 12
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 0, 4)
			IL_16E:
			num2 = 13
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 2, 4)
			IL_18C:
			num2 = 14
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 3, 4)
			IL_1AA:
			num2 = 15
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 0, 4)
			IL_1C8:
			num2 = 16
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 2, 4)
			IL_1E6:
			num2 = 17
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 1, 4)
			IL_204:
			num2 = 18
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 1, 4)
			IL_222:
			num2 = 19
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 2, 4)
			IL_240:
			num2 = 20
			Dim processesByName As Process() = Process.GetProcessesByName("chrome")
			IL_24F:
			num2 = 21
			For Each process As Process In processesByName
				IL_262:
				num2 = 22
				process.Kill()
				IL_26C:
				num2 = 23
			Next
			IL_27D:
			num2 = 24
			Dim processesByName2 As Process() = Process.GetProcessesByName("msedge")
			IL_28B:
			num2 = 25
			For Each process2 As Process In processesByName2
				IL_29B:
				num2 = 26
				process2.Kill()
				IL_2A5:
				num2 = 27
			Next
			IL_2B5:
			num2 = 28
			Dim processesByName3 As Process() = Process.GetProcessesByName("firefox")
			IL_2C4:
			num2 = 29
			For Each process3 As Process In processesByName3
				IL_2D7:
				num2 = 30
				process3.Kill()
				IL_2E1:
				num2 = 31
			Next
			IL_2F2:
			num2 = 32
			Dim processesByName4 As Process() = Process.GetProcessesByName("iexplorer")
			IL_301:
			num2 = 33
			For Each process4 As Process In processesByName4
				IL_314:
				num2 = 34
				process4.Kill()
				IL_31E:
				num2 = 35
			Next
			IL_32F:
			num2 = 36
			Dim processesByName5 As Process() = Process.GetProcessesByName("explorer")
			IL_33E:
			num2 = 37
			For Each process5 As Process In processesByName5
				IL_351:
				num2 = 38
				process5.Kill()
				IL_35B:
				num2 = 39
			Next
			IL_36C:
			num2 = 40
			Process.Start("explorer")
			IL_37A:
			num2 = 41
			Me._Callback = True
			IL_384:
			num2 = 42
			Value.SetupAttribute.Form3.shuoming.Text = "你违规修改了注册表的禁止下载项！"
			IL_3A0:
			num2 = 43
			Value.SetupAttribute.Form3.shuoming2.Text = "现在助手强制恢复！"
			IL_3BC:
			num2 = 44
			Value.SetupAttribute.Form3.Show()
			GoTo IL_467
			IL_3D3:
			num2 = 46
			Value.SetupAttribute.Form3.Close()
			IL_3E5:
			num2 = 47
			Value.SetupAttribute.Form2.shuoming.Text = "你多次修改了注册表的禁止下载项！"
			IL_401:
			num2 = 48
			Value.SetupAttribute.Form2.shuoming2.Text = "请重新启动电脑！"
			IL_41D:
			num2 = 49
			Value.SetupAttribute.Form2.Show()
			IL_42F:
			num2 = 50
			Me.Timer2.Enabled = True
			GoTo IL_467
			IL_440:
			num2 = 52
			If Not Me._Callback Then
				GoTo IL_45D
			End If
			IL_44B:
			num2 = 53
			Value.SetupAttribute.Form3.Close()
			IL_45D:
			num2 = 54
			Me._Callback = False
			IL_467:
			GoTo IL_599
			IL_46C:
			Dim num3 As Integer = num4 + 1
			num4 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
			IL_558:
			GoTo IL_58E
			IL_55A:
			num4 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			IL_56B:
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_55A
		End Try
		IL_58E:
		Throw ProjectData.CreateProjectError(-2146828237)
		IL_599:
		If num4 <> 0 Then
			ProjectData.ClearProjectError()
		End If
	End Sub

	' Token: 0x0600003C RID: 60 RVA: 0x00003760 File Offset: 0x00001960
	Private Sub GetAttribute(string_0 As String)
		If Directory.Exists(string_0) Then
			Dim fileSystemWatcher As FileSystemWatcher = New FileSystemWatcher()
			fileSystemWatcher.Path = string_0
			fileSystemWatcher.Filter = "*.*"
			If Operators.CompareString(string_0, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), False) = 0 Then
				fileSystemWatcher.IncludeSubdirectories = True
			Else
				fileSystemWatcher.IncludeSubdirectories = False
			End If
			fileSystemWatcher.NotifyFilter = 17
			Me.mapping = Conversions.ToInteger(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "gaowei", 2))
			Me._Error = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "xiazai", "off"))
			If Operators.CompareString(Me._Error, "off", False) = 0 Then
				fileSystemWatcher.Renamed += AddressOf Me.ViewAttribute
			End If
			If Me.mapping <> 1 Then
				fileSystemWatcher.Created += AddressOf Me.IncludeAttribute
				fileSystemWatcher.Changed += AddressOf Me.IncludeAttribute
			End If
			fileSystemWatcher.EnableRaisingEvents = True
		End If
	End Sub

	' Token: 0x0600003D RID: 61 RVA: 0x0000385C File Offset: 0x00001A5C
	Private Sub DestroyAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num5 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			Dim num3 As Integer = Conversions.ToInteger(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", ""))
			IL_29:
			num2 = 3
			Dim num4 As Integer = Conversions.ToInteger(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", ""))
			IL_4A:
			num2 = 4
			If Not(num3 <> 0 Or num4 <> 0) Then
				GoTo IL_162
			End If
			IL_5A:
			num2 = 5
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", 0, 4)
			IL_77:
			num2 = 6
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", 0, 4)
			IL_94:
			num2 = 7
			Dim processesByName As Process() = Process.GetProcessesByName("chrome")
			IL_A2:
			num2 = 8
			For Each process As Process In processesByName
				IL_B4:
				num2 = 9
				process.Kill()
				IL_BE:
				num2 = 10
			Next
			IL_CF:
			num2 = 11
			Dim processesByName2 As Process() = Process.GetProcessesByName("msedge")
			IL_DE:
			num2 = 12
			For Each process2 As Process In processesByName2
				IL_F1:
				num2 = 13
				process2.Kill()
				IL_FB:
				num2 = 14
			Next
			IL_10C:
			num2 = 15
			Me.m_Task = True
			IL_116:
			num2 = 16
			Value.SetupAttribute.Form3.shuoming.Text = "你违规修改了注册表的禁止游戏项！"
			IL_132:
			num2 = 17
			Value.SetupAttribute.Form3.shuoming2.Text = "现在助手强制恢复！"
			IL_14E:
			num2 = 18
			Value.SetupAttribute.Form3.Show()
			GoTo IL_189
			IL_162:
			num2 = 20
			If Not Me.m_Task Then
				GoTo IL_17F
			End If
			IL_16D:
			num2 = 21
			Value.SetupAttribute.Form3.Close()
			IL_17F:
			num2 = 22
			Me.m_Task = False
			IL_189:
			GoTo IL_23D
			IL_18E:
			GoTo IL_248
			IL_193:
			num5 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_217
			IL_1A6:
			Dim num6 As Integer = num5 + 1
			num5 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
			IL_217:
			GoTo IL_248
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_193
		End Try
		IL_23D:
		If num5 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_248:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x0600003E RID: 62 RVA: 0x00003AD8 File Offset: 0x00001CD8
	Private Sub ViewAttribute(sender As Object, e As RenamedEventArgs)
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			If Not MyBase.InvokeRequired Then
				GoTo IL_40
			End If
			IL_12:
			num2 = 3
			Dim method As Action(Of Object, RenamedEventArgs) = AddressOf Me.ViewAttribute
			IL_22:
			num2 = 4
			MyBase.BeginInvoke(method, New Object() { sender, e })
			GoTo IL_1F8
			IL_40:
			num2 = 6
			Dim left As String = Path.GetExtension(e.Name).ToLower()
			IL_53:
			num2 = 7
			If Not(Operators.CompareString(left, ".zip", False) = 0 Or Operators.CompareString(left, ".rar", False) = 0 Or Operators.CompareString(left, ".7z", False) = 0 Or Operators.CompareString(left, ".arj", False) = 0 Or Operators.CompareString(left, ".exe", False) = 0 Or Operators.CompareString(left, ".com", False) = 0 Or Operators.CompareString(left, ".msi", False) = 0 Or Operators.CompareString(left, ".reg", False) = 0 Or Operators.CompareString(left, ".bat", False) = 0 Or Operators.CompareString(left, ".cmd", False) = 0 Or Operators.CompareString(left, ".vbs", False) = 0 Or Operators.CompareString(left, ".vbe", False) = 0 Or Operators.CompareString(left, ".scr", False) = 0 Or Operators.CompareString(left, ".dll", False) = 0 Or Operators.CompareString(left, ".ps1", False) = 0 Or Operators.CompareString(left, ".pif", False) = 0) Then
				GoTo IL_1F8
			End If
			IL_159:
			num2 = 8
			Dim num3 As Integer = 1
			Do
				IL_177:
				num2 = 9
				File.Delete(e.FullPath)
				IL_15F:
				num2 = 10
				Thread.Sleep(200)
				IL_16C:
				num2 = 11
				num3 += 1
			Loop While num3 <= 3
			IL_187:
			num2 = 12
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止下载安装软件，再次操作会锁屏！"
			IL_1A3:
			num2 = 13
			Value.SetupAttribute.Form3.shuoming2.Text = "如果确有需要，请老师来退出小助手。"
			IL_1BF:
			num2 = 14
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			IL_1E6:
			num2 = 15
			Value.SetupAttribute.Form3.Show()
			IL_1F8:
			GoTo IL_28D
			IL_1FD:
			GoTo IL_298
			IL_202:
			num4 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_267
			IL_215:
			Dim num5 As Integer = num4 + 1
			num4 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
			IL_267:
			GoTo IL_298
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_202
		End Try
		IL_28D:
		If num4 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_298:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x0600003F RID: 63 RVA: 0x00003DA4 File Offset: 0x00001FA4
	Private Sub IncludeAttribute(sender As Object, e As FileSystemEventArgs)
		Dim num As Integer
		Dim num8 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			New FileInfo(e.FullPath)
			IL_16:
			num2 = 3
			If Not MyBase.InvokeRequired Then
				GoTo IL_4C
			End If
			IL_20:
			num2 = 4
			Dim method As Action(Of Object, FileSystemEventArgs) = AddressOf Me.IncludeAttribute
			IL_2F:
			num2 = 5
			MyBase.BeginInvoke(method, New Object() { sender, e })
			GoTo IL_613
			IL_4C:
			num2 = 7
			Dim left As String = Path.GetExtension(e.Name).ToLower()
			IL_5F:
			num2 = 8
			If Not(Operators.CompareString(left, ".exe", False) = 0 Or Operators.CompareString(left, ".com", False) = 0) Then
				GoTo IL_22F
			End If
			IL_85:
			num2 = 9
			If Operators.CompareString(left, ".exe", False) <> 0 Then
				GoTo IL_B5
			End If
			IL_96:
			num2 = 10
			Dim value As Object = Strings.Replace(e.FullPath, ".exe", ".cpp", 1, -1, CompareMethod.Binary)
			GoTo IL_D2
			IL_B5:
			num2 = 12
			value = Strings.Replace(e.FullPath, ".com", ".cp", 1, -1, CompareMethod.Binary)
			IL_D2:
			num2 = 13
			Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(e.FullPath)
			IL_E2:
			num2 = 14
			If(Not File.Exists(Conversions.ToString(value)) And Me.mapping = 2) Or Me.mapping = 0 Then
				While True
					IL_1A8:
					num2 = 16
					Dim processesByName As Process() = Process.GetProcessesByName(fileNameWithoutExtension)
					IL_112:
					num2 = 17
					Dim num3 As Integer = processesByName.Length - 1
					Dim i As Integer = 0
					While i <= num3
						IL_122:
						num2 = 18
						If Operators.CompareString(processesByName(i).MainModule.FileName.ToLower(), e.FullPath.ToLower(), False) <> 0 Then
							IL_14C:
							num2 = 21
							i += 1
						Else
							IL_15D:
							num2 = 19
							processesByName(i).Kill()
							IL_16A:
							num2 = 22
							Thread.Sleep(500)
							IL_177:
							num2 = 23
							File.SetAttributes(e.FullPath, FileAttributes.Normal)
							IL_18A:
							num2 = 24
							File.Delete(e.FullPath)
							IL_198:
							num2 = 25
							If File.Exists(e.FullPath) Then
								GoTo IL_1A8
							End If
							GoTo IL_1B9
						End If
					End While
					GoTo IL_16A
				End While
				IL_1B9:
				num2 = 26
				Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的exe文件，再次操作会锁屏！"
				IL_1D5:
				num2 = 27
				Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
				IL_1F1:
				num2 = 28
				Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
				IL_218:
				num2 = 29
				Value.SetupAttribute.Form3.Show()
				GoTo IL_613
			End If
			GoTo IL_613
			IL_22F:
			num2 = 31
			If Not(Operators.CompareString(left, ".reg", False) = 0 Or Operators.CompareString(left, ".bat", False) = 0 Or Operators.CompareString(left, ".cmd", False) = 0 Or Operators.CompareString(left, ".vbs", False) = 0 Or Operators.CompareString(left, ".vbe", False) = 0 Or Operators.CompareString(left, ".scr", False) = 0 Or Operators.CompareString(left, ".dll", False) = 0 Or Operators.CompareString(left, ".ps1", False) = 0 Or Operators.CompareString(left, ".pif", False) = 0) Then
				GoTo IL_393
			End If
			IL_2C6:
			num2 = 32
			Dim num4 As Integer = 1
			Do
				IL_2F7:
				num2 = 33
				File.SetAttributes(e.FullPath, FileAttributes.Normal)
				IL_2CE:
				num2 = 34
				File.Delete(e.FullPath)
				IL_2DC:
				num2 = 35
				Thread.Sleep(200)
				IL_2E9:
				num2 = 36
				num4 += 1
			Loop While num4 <= 3
			IL_30C:
			num2 = 37
			Me._Publisher += 1
			IL_31D:
			num2 = 38
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的reg、bat等高危文件，再次操作会锁屏！"
			IL_339:
			num2 = 39
			Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
			IL_355:
			num2 = 40
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			IL_37C:
			num2 = 41
			Value.SetupAttribute.Form3.Show()
			GoTo IL_613
			IL_393:
			num2 = 43
			If Operators.CompareString(left, ".msi", False) <> 0 Then
				GoTo IL_481
			End If
			IL_3A7:
			num2 = 44
			If Strings.InStr(Strings.LCase(e.FullPath), "config.msi", CompareMethod.Binary) <> 0 Then
				GoTo IL_613
			End If
			IL_3C5:
			num2 = 45
			Dim num5 As Integer = 1
			Do
				IL_3F6:
				num2 = 46
				File.SetAttributes(e.FullPath, FileAttributes.Normal)
				IL_3CD:
				num2 = 47
				File.Delete(e.FullPath)
				IL_3DB:
				num2 = 48
				Thread.Sleep(200)
				IL_3E8:
				num2 = 49
				num5 += 1
			Loop While num5 <= 3
			IL_40B:
			num2 = 50
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的msi等高危文件！"
			IL_427:
			num2 = 51
			Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
			IL_443:
			num2 = 52
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			IL_46A:
			num2 = 53
			Value.SetupAttribute.Form3.Show()
			GoTo IL_613
			IL_481:
			num2 = 55
			Thread.Sleep(500)
			IL_48E:
			num2 = 56
			Dim flag As Boolean = False
			IL_494:
			num2 = 57
			Using fileStream As FileStream = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read)
				Dim array As Byte() = New Byte(1) {}
				fileStream.Read(array, 0, 2)
				flag = (array(0) = 77 And array(1) = 90)
			End Using
			IL_4DC:
			num2 = 58
			If Not flag Then
				GoTo IL_613
			End If
			IL_4E6:
			num2 = 59
			Dim fileName As String = Path.GetFileName(e.FullPath)
			While True
				IL_591:
				num2 = 61
				Dim processesByName As Process() = Process.GetProcessesByName(fileName)
				IL_4FB:
				num2 = 62
				Dim num6 As Integer = processesByName.Length - 1
				Dim j As Integer = 0
				While j <= num6
					IL_50B:
					num2 = 63
					If Operators.CompareString(processesByName(j).MainModule.FileName.ToLower(), e.FullPath.ToLower(), False) <> 0 Then
						IL_535:
						num2 = 66
						j += 1
					Else
						IL_546:
						num2 = 64
						processesByName(j).Kill()
						IL_553:
						num2 = 67
						File.SetAttributes(e.FullPath, FileAttributes.Normal)
						IL_566:
						num2 = 68
						File.Delete(e.FullPath)
						IL_574:
						num2 = 69
						Thread.Sleep(200)
						IL_581:
						num2 = 70
						If File.Exists(e.FullPath) Then
							GoTo IL_591
						End If
						GoTo IL_5A2
					End If
				End While
				GoTo IL_553
			End While
			IL_5A2:
			num2 = 71
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的exe、dll变相文件，再次操作会锁屏！"
			IL_5BE:
			num2 = 72
			Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
			IL_5DA:
			num2 = 73
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			IL_601:
			num2 = 74
			Value.SetupAttribute.Form3.Show()
			IL_613:
			GoTo IL_795
			IL_618:
			Dim num7 As Integer = num8 + 1
			num8 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
			IL_754:
			GoTo IL_78A
			IL_756:
			num8 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			IL_767:
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_756
		End Try
		IL_78A:
		Throw ProjectData.CreateProjectError(-2146828237)
		IL_795:
		If num8 <> 0 Then
			ProjectData.ClearProjectError()
		End If
	End Sub

	' Token: 0x06000040 RID: 64 RVA: 0x00004584 File Offset: 0x00002784
	<MethodImpl(MethodImplOptions.NoOptimization)>
	Private Sub CountAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num11 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			MyBase.Hide()
			IL_10:
			ProjectData.ClearProjectError()
			num = 1
			IL_17:
			num2 = 4
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
			IL_39:
			num2 = 5
			If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
				GoTo IL_6C
			End If
			IL_4A:
			num2 = 6
			objectValue = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
			IL_6C:
			num2 = 7
			przs.Internal.Message._Role = Strings.Mid(Conversions.ToString(objectValue), 1, Strings.Len(RuntimeHelpers.GetObjectValue(objectValue)) - 9)
			IL_8F:
			num2 = 8
			Dim num3 As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
			IL_A8:
			num2 = 9
			Dim num4 As Integer = num3 Mod 7
			IL_B1:
			num2 = 10
			Dim num5 As Integer = num3 Mod 9
			IL_BB:
			num2 = 11
			Dim num6 As Integer = num3 Mod 5
			IL_C4:
			num2 = 12
			Dim num7 As Integer = num3 Mod 3
			IL_CD:
			num2 = 13
			If num3 Mod 2 <> 0 Then
				GoTo IL_11E
			End If
			IL_D6:
			num2 = 14
			Dim str As String = Conversions.ToString(Strings.Chr(97 + num4)) + Conversions.ToString(Strings.Chr(98 + num5)) + Conversions.ToString(Strings.Chr(101 + num6)) + Conversions.ToString(Strings.Chr(99 + num7))
			GoTo IL_164
			IL_11E:
			num2 = 16
			str = Conversions.ToString(Strings.Chr(97 + num5)) + Conversions.ToString(Strings.Chr(98 + num4)) + Conversions.ToString(Strings.Chr(101 + num7)) + Conversions.ToString(Strings.Chr(99 + num6))
			IL_164:
			num2 = 17
			Me.wrapper = str
			IL_16F:
			num2 = 18
			Me._Map = str + ".exe"
			IL_184:
			num2 = 19
			VBMath.Randomize(CDbl(num3))
			IL_18F:
			num2 = 20
			Dim num8 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
			IL_1BE:
			num2 = 21
			Dim text As String = ""
			IL_1C7:
			num2 = 22
			Dim num9 As Integer = 1
			Do
				IL_205:
				num2 = 23
				Dim num10 As Long = num8 Mod 10L + 105L
				IL_1CF:
				num2 = 24
				text = Conversions.ToString(Strings.Chr(CInt(num10))) + text
				IL_1E6:
				num2 = 25
				num8 /= 10L
				IL_1F7:
				num2 = 26
				num9 += 1
			Loop While num9 <= 5
			IL_222:
			num2 = 27
			Me.wrapper = text
			IL_22C:
			num2 = 28
			Me._Map = text + ".exe"
			IL_240:
			num2 = 29
			Dim text2 As String = "C:\Program Files (x86)\" + Strings.Mid(text, 2, 4)
			IL_257:
			num2 = 30
			Me.Text = Strings.Mid(text, 1, 3)
			IL_268:
			num2 = 31
			If Strings.InStr(Application.StartupPath, "C:\Program Files (x86)", CompareMethod.Binary) <> 0 Then
				GoTo IL_389
			End If
			IL_280:
			num2 = 32
			Me.NotifyIcon1.Visible = False
			IL_28F:
			num2 = 33
			If Directory.Exists(text2) Then
				GoTo IL_2A6
			End If
			IL_29B:
			num2 = 34
			Directory.CreateDirectory(text2)
			IL_2A6:
			num2 = 35
			File.SetAttributes(text2 + "\" + Me._Map, FileAttributes.Normal)
			IL_2C5:
			num2 = 36
			File.Delete(text2 + "\" + Me._Map)
			IL_2DF:
			num2 = 37
			File.Copy(Application.StartupPath + "\przs.exe", text2 + "\" + Me._Map, True)
			IL_309:
			num2 = 38
			File.SetAttributes(text2, File.GetAttributes(text2) Or FileAttributes.Hidden Or FileAttributes.System)
			IL_31E:
			num2 = 39
			File.SetAttributes(text2 + "\" + Me._Map, File.GetAttributes(text2 + "\" + Me._Map) Or FileAttributes.Hidden Or FileAttributes.System)
			IL_353:
			num2 = 40
			If Me.SortAttribute(Me.wrapper) Then
				GoTo IL_37F
			End If
			IL_364:
			num2 = 41
			Process.Start(text2 + "\" + Me._Map)
			IL_37F:
			ProjectData.EndApp()
			GoTo IL_8CE
			IL_389:
			num2 = 43
			Dim left As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
			IL_3AC:
			num2 = 44
			If Operators.CompareString(left, "on", False) <> 0 Then
				GoTo IL_46F
			End If
			IL_3C1:
			num2 = 45
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", ""))
			IL_3E4:
			num2 = 46
			If Not Operators.ConditionalCompareObjectNotEqual(objectValue2, 4, False) Then
				GoTo IL_46F
			End If
			IL_3F7:
			num2 = 47
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 4, 4)
			IL_415:
			num2 = 48
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 4, 4)
			IL_433:
			num2 = 49
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 4, 4)
			IL_451:
			num2 = 50
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 4, 4)
			IL_46F:
			num2 = 51
			Me._Error = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "xiazai", "off"))
			IL_496:
			num2 = 52
			If Operators.CompareString(Me._Error, "off", False) <> 0 Then
				GoTo IL_65F
			End If
			IL_4AF:
			num2 = 53
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", ""))
			IL_4D2:
			num2 = 54
			If Not Operators.ConditionalCompareObjectNotEqual(objectValue3, 3, False) Then
				GoTo IL_650
			End If
			IL_4E8:
			num2 = 55
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 3, 4)
			IL_506:
			num2 = 56
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 1, 4)
			IL_524:
			num2 = 57
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 1, 4)
			IL_542:
			num2 = 58
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 3, 4)
			IL_560:
			num2 = 59
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 0, 4)
			IL_57E:
			num2 = 60
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 2, 4)
			IL_59C:
			num2 = 61
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 3, 4)
			IL_5BA:
			num2 = 62
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 0, 4)
			IL_5D8:
			num2 = 63
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 2, 4)
			IL_5F6:
			num2 = 64
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 1, 4)
			IL_614:
			num2 = 65
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 1, 4)
			IL_632:
			num2 = 66
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 2, 4)
			IL_650:
			num2 = 67
			Me.Timer_jzxz.Enabled = True
			IL_65F:
			num2 = 68
			Dim text3 As String = ""
			IL_668:
			num2 = 69
			Dim text4 As String = ""
			IL_672:
			num2 = 70
			Me.GetAttribute("C:\Users\" + Environment.UserName + "\Downloads")
			IL_68F:
			num2 = 71
			Me.GetAttribute(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
			IL_69E:
			num2 = 72
			Me.GetAttribute(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
			IL_6AD:
			num2 = 73
			Dim logicalDrives As String() = Environment.GetLogicalDrives()
			IL_6B7:
			num2 = 74
			For Each string_ As String In logicalDrives
				IL_6CA:
				num2 = 75
				Me.GetAttribute(string_)
				IL_6D5:
				num2 = 76
			Next
			IL_6E6:
			num2 = 77
			If Not Directory.Exists("d:\" + przs.Internal.Message._Queue) Then
				GoTo IL_717
			End If
			IL_6FF:
			num2 = 78
			text3 = "d:\" + przs.Internal.Message._Queue
			GoTo IL_79F
			IL_717:
			num2 = 80
			If Not Directory.Exists("e:\" + przs.Internal.Message._Queue) Then
				GoTo IL_745
			End If
			IL_730:
			num2 = 81
			text3 = "e:\" + przs.Internal.Message._Queue
			GoTo IL_79F
			IL_745:
			num2 = 83
			If Not Directory.Exists("f:\" + przs.Internal.Message._Queue) Then
				GoTo IL_773
			End If
			IL_75E:
			num2 = 84
			text3 = "f:\" + przs.Internal.Message._Queue
			GoTo IL_79F
			IL_773:
			num2 = 86
			If Not Directory.Exists("c:\" + przs.Internal.Message._Queue) Then
				GoTo IL_79F
			End If
			IL_78C:
			num2 = 87
			text3 = "c:\" + przs.Internal.Message._Queue
			IL_79F:
			num2 = 88
			If Operators.CompareString(text3, "", False) = 0 Then
				GoTo IL_7BA
			End If
			IL_7B0:
			num2 = 89
			Me.GetAttribute(text3)
			IL_7BA:
			num2 = 90
			If Not Directory.Exists("d:\" + przs.Internal.Message.m_Page) Then
				GoTo IL_7EC
			End If
			IL_7D3:
			num2 = 91
			text4 = "d:\" + przs.Internal.Message.m_Page
			GoTo IL_877
			IL_7EC:
			num2 = 93
			If Not Directory.Exists("e:\" + przs.Internal.Message.m_Page) Then
				GoTo IL_81B
			End If
			IL_805:
			num2 = 94
			text4 = "e:\" + przs.Internal.Message.m_Page
			GoTo IL_877
			IL_81B:
			num2 = 96
			If Not Directory.Exists("f:\" + przs.Internal.Message.m_Page) Then
				GoTo IL_84A
			End If
			IL_834:
			num2 = 97
			text4 = "f:\" + przs.Internal.Message.m_Page
			GoTo IL_877
			IL_84A:
			num2 = 99
			If Not Directory.Exists("c:\" + przs.Internal.Message.m_Page) Then
				GoTo IL_877
			End If
			IL_863:
			num2 = 100
			text4 = "c:\" + przs.Internal.Message.m_Page
			IL_877:
			num2 = 101
			If Operators.CompareString(text4, "", False) = 0 Then
				GoTo IL_894
			End If
			IL_889:
			num2 = 102
			Me.GetAttribute(text4)
			IL_894:
			num2 = 103
			If Not Directory.Exists("D:\ChromeCoreDownloads") Then
				GoTo IL_8B1
			End If
			IL_8A3:
			num2 = 104
			Me.GetAttribute("D:\ChromeCoreDownloads")
			IL_8B1:
			num2 = 105
			If Not Directory.Exists("C:\Windows\Microsoft.NET\Framework\v4.0.30319") Then
				GoTo IL_8CE
			End If
			IL_8C0:
			num2 = 106
			Me.GetAttribute("C:\Windows\Microsoft.NET\Framework\v4.0.30319")
			IL_8CE:
			GoTo IL_AD5
			IL_8D3:
			GoTo IL_AE0
			IL_8D8:
			num11 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_AAF
			IL_8EE:
			Dim num12 As Integer = num11 + 1
			num11 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num12)
			IL_AAF:
			GoTo IL_AE0
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num11 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_8D8
		End Try
		IL_AD5:
		If num11 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_AE0:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x06000041 RID: 65 RVA: 0x00005098 File Offset: 0x00003298
	Private Sub CalcAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			NewLateBinding.LateCall(Nothing, GetType(Process), "Start", New Object() { Operators.ConcatenateObject(przs.Internal.Message._Role, "\about.exe") }, Nothing, Nothing, Nothing, True)
			IL_3D:
			GoTo IL_98
			IL_3F:
			Dim num3 As Integer = num4 + 1
			num4 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
			IL_59:
			GoTo IL_8D
			IL_5B:
			num4 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			IL_6B:
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_5B
		End Try
		IL_8D:
		Throw ProjectData.CreateProjectError(-2146828237)
		IL_98:
		If num4 <> 0 Then
			ProjectData.ClearProjectError()
		End If
	End Sub

	' Token: 0x06000042 RID: 66 RVA: 0x00005158 File Offset: 0x00003358
	Private Function SortAttribute(string_0 As String) As Boolean
		Return Process.GetProcessesByName(string_0).Length > 0
	End Function

	' Token: 0x06000044 RID: 68 RVA: 0x000051B8 File Offset: 0x000033B8
	<DebuggerStepThrough()>
	Private Sub SelectAttribute()
		Me.initializer = New Container()
		Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
		Me.NotifyIcon1 = New NotifyIcon(Me.initializer)
		Me.Splitter1 = New Splitter()
		Me.Timer_main = New Timer(Me.initializer)
		Me.Timer2 = New Timer(Me.initializer)
		Me.Timer1 = New Timer(Me.initializer)
		Me.Timer4 = New Timer(Me.initializer)
		Me.Timer_jianchahosts = New Timer(Me.initializer)
		Me.Timer_jzxz = New Timer(Me.initializer)
		Me.Timer_youxi = New Timer(Me.initializer)
		MyBase.SuspendLayout()
		Me.NotifyIcon1.Icon = CType(componentResourceManager.GetObject("NotifyIcon1.Icon"), Icon)
		Me.NotifyIcon1.Text = "学生机房管理助手"
		Me.NotifyIcon1.Visible = True
		Me.Splitter1.Location = New Point(0, 0)
		Me.Splitter1.Name = "Splitter1"
		Me.Splitter1.Size = New Size(3, 471)
		Me.Splitter1.TabIndex = 7
		Me.Splitter1.TabStop = False
		Me.Timer_main.Enabled = True
		Me.Timer_main.Interval = 10000
		Me.Timer2.Interval = 1000
		Me.Timer1.Interval = 3000
		Me.Timer4.Interval = 1000
		Me.Timer_jianchahosts.Enabled = True
		Me.Timer_jianchahosts.Interval = 15000
		Me.Timer_jzxz.Interval = 5000
		Me.Timer_youxi.Interval = 30000
		MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
		MyBase.AutoScaleMode = AutoScaleMode.Font
		Me.BackColor = SystemColors.ButtonHighlight
		MyBase.ClientSize = New Size(676, 471)
		MyBase.Controls.Add(Me.Splitter1)
		MyBase.FormBorderStyle = FormBorderStyle.None
		MyBase.HelpButton = True
		MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Icon)
		MyBase.Name = "Form1"
		MyBase.ShowInTaskbar = False
		MyBase.StartPosition = FormStartPosition.CenterScreen
		Me.Text = "word"
		MyBase.WindowState = FormWindowState.Minimized
		MyBase.ResumeLayout(False)
	End Sub

	' Token: 0x17000011 RID: 17
	' (get) Token: 0x06000045 RID: 69 RVA: 0x00002531 File Offset: 0x00000731
	' (set) Token: 0x06000046 RID: 70 RVA: 0x0000542C File Offset: 0x0000362C
	Friend Overridable Property NotifyIcon1 As NotifyIcon
		<CompilerGenerated()>
		Get
			Return Me.m_Indexer
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As NotifyIcon)
			Dim value2 As EventHandler = AddressOf Me.CalcAttribute
			Dim indexer As NotifyIcon = Me.m_Indexer
			If indexer IsNot Nothing Then
				RemoveHandler indexer.Click, value2
			End If
			Me.m_Indexer = value
			indexer = Me.m_Indexer
			If indexer IsNot Nothing Then
				AddHandler indexer.Click, value2
			End If
		End Set
	End Property

	' Token: 0x17000012 RID: 18
	' (get) Token: 0x06000047 RID: 71 RVA: 0x00002539 File Offset: 0x00000739
	' (set) Token: 0x06000048 RID: 72 RVA: 0x00002541 File Offset: 0x00000741
	Friend Overridable Property Splitter1 As Splitter

	' Token: 0x17000013 RID: 19
	' (get) Token: 0x06000049 RID: 73 RVA: 0x0000254A File Offset: 0x0000074A
	' (set) Token: 0x0600004A RID: 74 RVA: 0x00005470 File Offset: 0x00003670
	Friend Overridable Property Timer_main As Timer
		<CompilerGenerated()>
		Get
			Return Me.utils
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.QueryAttribute
			Dim timer As Timer = Me.utils
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value2
			End If
			Me.utils = value
			timer = Me.utils
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x17000014 RID: 20
	' (get) Token: 0x0600004B RID: 75 RVA: 0x00002552 File Offset: 0x00000752
	' (set) Token: 0x0600004C RID: 76 RVA: 0x000054B4 File Offset: 0x000036B4
	Friend Overridable Property Timer2 As Timer
		<CompilerGenerated()>
		Get
			Return Me.m_Ref
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.CalculateAttribute
			Dim ref As Timer = Me.m_Ref
			If ref IsNot Nothing Then
				RemoveHandler ref.Tick, value2
			End If
			Me.m_Ref = value
			ref = Me.m_Ref
			If ref IsNot Nothing Then
				AddHandler ref.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x17000015 RID: 21
	' (get) Token: 0x0600004D RID: 77 RVA: 0x0000255A File Offset: 0x0000075A
	' (set) Token: 0x0600004E RID: 78 RVA: 0x000054F8 File Offset: 0x000036F8
	Friend Overridable Property Timer1 As Timer
		<CompilerGenerated()>
		Get
			Return Me._Pool
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.MoveAttribute
			Dim pool As Timer = Me._Pool
			If pool IsNot Nothing Then
				RemoveHandler pool.Tick, value2
			End If
			Me._Pool = value
			pool = Me._Pool
			If pool IsNot Nothing Then
				AddHandler pool.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x17000016 RID: 22
	' (get) Token: 0x0600004F RID: 79 RVA: 0x00002562 File Offset: 0x00000762
	' (set) Token: 0x06000050 RID: 80 RVA: 0x0000256A File Offset: 0x0000076A
	Friend Overridable Property Timer4 As Timer

	' Token: 0x17000017 RID: 23
	' (get) Token: 0x06000051 RID: 81 RVA: 0x00002573 File Offset: 0x00000773
	' (set) Token: 0x06000052 RID: 82 RVA: 0x0000553C File Offset: 0x0000373C
	Friend Overridable Property Timer_jianchahosts As Timer
		<CompilerGenerated()>
		Get
			Return Me._Merchant
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.CallAttribute
			Dim merchant As Timer = Me._Merchant
			If merchant IsNot Nothing Then
				RemoveHandler merchant.Tick, value2
			End If
			Me._Merchant = value
			merchant = Me._Merchant
			If merchant IsNot Nothing Then
				AddHandler merchant.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x17000018 RID: 24
	' (get) Token: 0x06000053 RID: 83 RVA: 0x0000257B File Offset: 0x0000077B
	' (set) Token: 0x06000054 RID: 84 RVA: 0x00005580 File Offset: 0x00003780
	Friend Overridable Property Timer_jzxz As Timer
		<CompilerGenerated()>
		Get
			Return Me._Strategy
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.PushAttribute
			Dim strategy As Timer = Me._Strategy
			If strategy IsNot Nothing Then
				RemoveHandler strategy.Tick, value2
			End If
			Me._Strategy = value
			strategy = Me._Strategy
			If strategy IsNot Nothing Then
				AddHandler strategy.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x17000019 RID: 25
	' (get) Token: 0x06000055 RID: 85 RVA: 0x00002583 File Offset: 0x00000783
	' (set) Token: 0x06000056 RID: 86 RVA: 0x000055C4 File Offset: 0x000037C4
	Friend Overridable Property Timer_youxi As Timer
		<CompilerGenerated()>
		Get
			Return Me.container
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.DestroyAttribute
			Dim timer As Timer = Me.container
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value2
			End If
			Me.container = value
			timer = Me.container
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x04000015 RID: 21
	Private m_Visitor As Long

	' Token: 0x04000016 RID: 22
	Private wrapper As String

	' Token: 0x04000017 RID: 23
	Private _Map As String

	' Token: 0x04000018 RID: 24
	Private m_Interpreter As String

	' Token: 0x04000019 RID: 25
	Private _Error As String

	' Token: 0x0400001A RID: 26
	Private mapping As Integer

	' Token: 0x0400001B RID: 27
	Private m_Printer As Integer

	' Token: 0x0400001C RID: 28
	Private _Publisher As Integer

	' Token: 0x0400001D RID: 29
	Private m_Database As Long

	' Token: 0x0400001E RID: 30
	Private m_Object As Long

	' Token: 0x0400001F RID: 31
	Private _Callback As Boolean

	' Token: 0x04000020 RID: 32
	Private m_Base As Boolean

	' Token: 0x04000021 RID: 33
	Private m_Task As Boolean

	' Token: 0x04000022 RID: 34
	Private m_Order As Long

	' Token: 0x04000023 RID: 35
	Private _Importer As String

	' Token: 0x04000024 RID: 36
	Private m_Resolver As String

	' Token: 0x04000025 RID: 37
	Private _System As String

	' Token: 0x04000026 RID: 38
	Private test As Long

	' Token: 0x04000028 RID: 40
	<AccessedThroughProperty("NotifyIcon1")>
	<CompilerGenerated()>
	Private m_Indexer As NotifyIcon

	' Token: 0x04000029 RID: 41
	<AccessedThroughProperty("Splitter1")>
	<CompilerGenerated()>
	Private advisor As Splitter

	' Token: 0x0400002A RID: 42
	<AccessedThroughProperty("Timer_main")>
	<CompilerGenerated()>
	Private utils As Timer

	' Token: 0x0400002B RID: 43
	<AccessedThroughProperty("Timer2")>
	<CompilerGenerated()>
	Private m_Ref As Timer

	' Token: 0x0400002C RID: 44
	<AccessedThroughProperty("Timer1")>
	<CompilerGenerated()>
	Private _Pool As Timer

	' Token: 0x0400002D RID: 45
	<AccessedThroughProperty("Timer4")>
	<CompilerGenerated()>
	Private _Mapper As Timer

	' Token: 0x0400002E RID: 46
	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_jianchahosts")>
	Private _Merchant As Timer

	' Token: 0x0400002F RID: 47
	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_jzxz")>
	Private _Strategy As Timer

	' Token: 0x04000030 RID: 48
	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_youxi")>
	Private container As Timer
End Class
