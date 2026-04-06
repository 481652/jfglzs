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

	Private Sub QueryAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			Me.Timer1.Enabled = True
			Dim left As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "games_jianche", ""))
			If Operators.CompareString(left, "on", False) <> 0 Then
			End If
			Me.Timer_youxi.Enabled = True
			Dim left2 As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "bianhao", ""))
			If Operators.CompareString(left2, "on", False) <> 0 Then
			End If
			Value.SetupAttribute.bianhao.Show()
			Me.Timer_main.Enabled = False
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try

		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return

		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	Private Sub CalculateAttribute(sender As Object, e As EventArgs)
		If Not Value.SetupAttribute.Form2.Visible Then
			Value.SetupAttribute.Form2.Show()
		End If
	End Sub

	Private Sub MoveAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			If Me.SortAttribute("jfglzsn") Then
			End If
			Me.m_Database += 1L
			If File.Exists(Conversions.ToString(Operators.ConcatenateObject(przs.Internal.Message._Role, "\jfglzsn.exe"))) Then
			End If
			If Not File.Exists(Me._Importer + "\jfglzsn.dat") Then
			End If
			File.Copy(Me._Importer + "\jfglzsn.dat", Conversions.ToString(Operators.ConcatenateObject(przs.Internal.Message._Role, "\jfglzsn.exe")), True)
			NewLateBinding.LateCall(Nothing, GetType(Process), "Start", New Object() { Operators.ConcatenateObject(przs.Internal.Message._Role, "\jfglzsn.exe") }, Nothing, Nothing, Nothing, True)
			If Me.m_Database < 40L Then
			End If
			Value.SetupAttribute.Form2.shuoming.Text = "进程j被多次终止或文件会被杀毒软件（如win10自带的defender）清除！"
			Value.SetupAttribute.Form2.Show()
			Me.Timer2.Enabled = True
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try

		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	Private Sub CallAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			If File.Exists(Me.m_Resolver) Then
			End If
			Me.m_Order += 1L
			Me.m_Base = True
			If Not File.Exists(Me.m_Resolver + "2") Then
			End If
			File.Copy(Me.m_Resolver + "2", Me.m_Resolver, True)
			Value.SetupAttribute.Form3.shuoming.Text = "hosts文件被删除！现在恢复。"
			Value.SetupAttribute.Form3.Show()
			If Me.m_Order <= 5L Then
			End If
			Value.SetupAttribute.Form3.Close()
			Value.SetupAttribute.Form2.shuoming.Text = "hosts文件多次被删除或备份文件不存在！"
			Value.SetupAttribute.Form2.Show()
			Me.Timer2.Enabled = True
			If Not Me.m_Base Then
			End If
			Value.SetupAttribute.Form3.Close()
			Me.m_Base = False
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	Private Sub PushAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", ""))
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", ""))
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", ""))
			If Not Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectNotEqual(objectValue, "3", False), Operators.CompareObjectNotEqual(objectValue2, "3", False)), Operators.CompareObjectNotEqual(objectValue3, "3", False))) Then
			End If
			Me.m_Object += 1L
			If Me.m_Object > 15L Then
			End If
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 3, 4)
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 3, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 0, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 2, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 3, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 0, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 2, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 2, 4)
			Dim processesByName As Process() = Process.GetProcessesByName("chrome")
			For Each process As Process In processesByName
				process.Kill()
			Next
			Dim processesByName2 As Process() = Process.GetProcessesByName("msedge")
			For Each process2 As Process In processesByName2
				process2.Kill()
			Next
			Dim processesByName3 As Process() = Process.GetProcessesByName("firefox")
			For Each process3 As Process In processesByName3
				process3.Kill()
			Next
			Dim processesByName4 As Process() = Process.GetProcessesByName("iexplorer")
			For Each process4 As Process In processesByName4
				process4.Kill()
			Next
			Dim processesByName5 As Process() = Process.GetProcessesByName("explorer")
			For Each process5 As Process In processesByName5
				process5.Kill()
			Next
			Process.Start("explorer")
			Me._Callback = True
			Value.SetupAttribute.Form3.shuoming.Text = "你违规修改了注册表的禁止下载项！"
			Value.SetupAttribute.Form3.shuoming2.Text = "现在助手强制恢复！"
			Value.SetupAttribute.Form3.Show()
			Value.SetupAttribute.Form3.Close()
			Value.SetupAttribute.Form2.shuoming.Text = "你多次修改了注册表的禁止下载项！"
			Value.SetupAttribute.Form2.shuoming2.Text = "请重新启动电脑！"
			Value.SetupAttribute.Form2.Show()
			Me.Timer2.Enabled = True
			If Not Me._Callback Then
			End If
			Value.SetupAttribute.Form3.Close()
			Me._Callback = False
			Dim num3 As Integer = num4 + 1
			num4 = num2
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
	End Sub

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

	Private Sub DestroyAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num5 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			Dim num3 As Integer = Conversions.ToInteger(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", ""))
			Dim num4 As Integer = Conversions.ToInteger(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", ""))
			If Not(num3 <> 0 Or num4 <> 0) Then
			End If
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", 0, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", 0, 4)
			Dim processesByName As Process() = Process.GetProcessesByName("chrome")
			For Each process As Process In processesByName
				process.Kill()
			Next
			Dim processesByName2 As Process() = Process.GetProcessesByName("msedge")
			For Each process2 As Process In processesByName2
				process2.Kill()
			Next
			Me.m_Task = True
			Value.SetupAttribute.Form3.shuoming.Text = "你违规修改了注册表的禁止游戏项！"
			Value.SetupAttribute.Form3.shuoming2.Text = "现在助手强制恢复！"
			Value.SetupAttribute.Form3.Show()
			If Not Me.m_Task Then
			End If
			Value.SetupAttribute.Form3.Close()
			Me.m_Task = False
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
		If num5 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return

		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	Private Sub ViewAttribute(sender As Object, e As RenamedEventArgs)
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			If Not MyBase.InvokeRequired Then
			End If
			Dim method As Action(Of Object, RenamedEventArgs) = AddressOf Me.ViewAttribute
			MyBase.BeginInvoke(method, New Object() { sender, e })
			Dim left As String = Path.GetExtension(e.Name).ToLower()
			If Not(Operators.CompareString(left, ".zip", False) = 0 Or Operators.CompareString(left, ".rar", False) = 0 Or Operators.CompareString(left, ".7z", False) = 0 Or Operators.CompareString(left, ".arj", False) = 0 Or Operators.CompareString(left, ".exe", False) = 0 Or Operators.CompareString(left, ".com", False) = 0 Or Operators.CompareString(left, ".msi", False) = 0 Or Operators.CompareString(left, ".reg", False) = 0 Or Operators.CompareString(left, ".bat", False) = 0 Or Operators.CompareString(left, ".cmd", False) = 0 Or Operators.CompareString(left, ".vbs", False) = 0 Or Operators.CompareString(left, ".vbe", False) = 0 Or Operators.CompareString(left, ".scr", False) = 0 Or Operators.CompareString(left, ".dll", False) = 0 Or Operators.CompareString(left, ".ps1", False) = 0 Or Operators.CompareString(left, ".pif", False) = 0) Then
			End If
			Dim num3 As Integer = 1
			Do
				File.Delete(e.FullPath)
				Thread.Sleep(200)
				num3 += 1
			Loop While num3 <= 3
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止下载安装软件，再次操作会锁屏！"
			Value.SetupAttribute.Form3.shuoming2.Text = "如果确有需要，请老师来退出小助手。"
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			Value.SetupAttribute.Form3.Show()
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
		If num4 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return

		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	Private Sub IncludeAttribute(sender As Object, e As FileSystemEventArgs)
		Dim num As Integer
		Dim num8 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			New FileInfo(e.FullPath)
			If Not MyBase.InvokeRequired Then
			End If
			Dim method As Action(Of Object, FileSystemEventArgs) = AddressOf Me.IncludeAttribute
			MyBase.BeginInvoke(method, New Object() { sender, e })
			Dim left As String = Path.GetExtension(e.Name).ToLower()
			If Not(Operators.CompareString(left, ".exe", False) = 0 Or Operators.CompareString(left, ".com", False) = 0) Then
			End If
			If Operators.CompareString(left, ".exe", False) <> 0 Then
			End If
			Dim value As Object = Strings.Replace(e.FullPath, ".exe", ".cpp", 1, -1, CompareMethod.Binary)
			value = Strings.Replace(e.FullPath, ".com", ".cp", 1, -1, CompareMethod.Binary)
			Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(e.FullPath)
			If(Not File.Exists(Conversions.ToString(value)) And Me.mapping = 2) Or Me.mapping = 0 Then
				While True
					Dim processesByName As Process() = Process.GetProcessesByName(fileNameWithoutExtension)
					Dim num3 As Integer = processesByName.Length - 1
					Dim i As Integer = 0
					While i <= num3
						If Operators.CompareString(processesByName(i).MainModule.FileName.ToLower(), e.FullPath.ToLower(), False) <> 0 Then
							i += 1
						Else
							processesByName(i).Kill()
							Thread.Sleep(500)
							File.SetAttributes(e.FullPath, FileAttributes.Normal)
							File.Delete(e.FullPath)
							If File.Exists(e.FullPath) Then
							End If
						End If
					End While
				End While
				Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的exe文件，再次操作会锁屏！"
				Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
				Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
				Value.SetupAttribute.Form3.Show()
			End If
			If Not(Operators.CompareString(left, ".reg", False) = 0 Or Operators.CompareString(left, ".bat", False) = 0 Or Operators.CompareString(left, ".cmd", False) = 0 Or Operators.CompareString(left, ".vbs", False) = 0 Or Operators.CompareString(left, ".vbe", False) = 0 Or Operators.CompareString(left, ".scr", False) = 0 Or Operators.CompareString(left, ".dll", False) = 0 Or Operators.CompareString(left, ".ps1", False) = 0 Or Operators.CompareString(left, ".pif", False) = 0) Then
			End If
			Dim num4 As Integer = 1
			Do
				File.SetAttributes(e.FullPath, FileAttributes.Normal)
				File.Delete(e.FullPath)
				Thread.Sleep(200)
				num4 += 1
			Loop While num4 <= 3
			Me._Publisher += 1
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的reg、bat等高危文件，再次操作会锁屏！"
			Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			Value.SetupAttribute.Form3.Show()
			If Operators.CompareString(left, ".msi", False) <> 0 Then
			End If
			If Strings.InStr(Strings.LCase(e.FullPath), "config.msi", CompareMethod.Binary) <> 0 Then
			End If
			Dim num5 As Integer = 1
			Do
				File.SetAttributes(e.FullPath, FileAttributes.Normal)
				File.Delete(e.FullPath)
				Thread.Sleep(200)
				num5 += 1
			Loop While num5 <= 3
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的msi等高危文件！"
			Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			Value.SetupAttribute.Form3.Show()
			Thread.Sleep(500)
			Dim flag As Boolean = False
			Using fileStream As FileStream = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read)
				Dim array As Byte() = New Byte(1) {}
				fileStream.Read(array, 0, 2)
				flag = (array(0) = 77 And array(1) = 90)
			End Using
			If Not flag Then
			End If
			Dim fileName As String = Path.GetFileName(e.FullPath)
			While True
				Dim processesByName As Process() = Process.GetProcessesByName(fileName)
				Dim num6 As Integer = processesByName.Length - 1
				Dim j As Integer = 0
				While j <= num6
					If Operators.CompareString(processesByName(j).MainModule.FileName.ToLower(), e.FullPath.ToLower(), False) <> 0 Then
						j += 1
					Else
						processesByName(j).Kill()
						File.SetAttributes(e.FullPath, FileAttributes.Normal)
						File.Delete(e.FullPath)
						Thread.Sleep(200)
						If File.Exists(e.FullPath) Then
						End If
					End If
				End While
			End While
			Value.SetupAttribute.Form3.shuoming.Text = "本电脑禁止创建新的exe、dll变相文件，再次操作会锁屏！"
			Value.SetupAttribute.Form3.shuoming2.Text = "老师请先退出小助手，重新安装软件。你也可重新设置：允许（不建议）"
			Value.SetupAttribute.Form3.shuoming3.Text = "刚刚删除文件：" + e.FullPath
			Value.SetupAttribute.Form3.Show()
			Dim num7 As Integer = num8 + 1
			num8 = num2

		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
	End Sub

	<MethodImpl(MethodImplOptions.NoOptimization)>
	Private Sub CountAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num11 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			MyBase.Hide()

			ProjectData.ClearProjectError()
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
			If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
			End If
			objectValue = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
			przs.Internal.Message._Role = Strings.Mid(Conversions.ToString(objectValue), 1, Strings.Len(RuntimeHelpers.GetObjectValue(objectValue)) - 9)
			Dim num3 As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
			Dim num4 As Integer = num3 Mod 7
			Dim num5 As Integer = num3 Mod 9
			Dim num6 As Integer = num3 Mod 5
			Dim num7 As Integer = num3 Mod 3
			If num3 Mod 2 <> 0 Then
			End If
			Dim str As String = Conversions.ToString(Strings.Chr(97 + num4)) + Conversions.ToString(Strings.Chr(98 + num5)) + Conversions.ToString(Strings.Chr(101 + num6)) + Conversions.ToString(Strings.Chr(99 + num7))
			str = Conversions.ToString(Strings.Chr(97 + num5)) + Conversions.ToString(Strings.Chr(98 + num4)) + Conversions.ToString(Strings.Chr(101 + num7)) + Conversions.ToString(Strings.Chr(99 + num6))
			Me.wrapper = str
			Me._Map = str + ".exe"
			VBMath.Randomize(CDbl(num3))
			Dim num8 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
			Dim text As String = ""
			Dim num9 As Integer = 1
			Do
				Dim num10 As Long = num8 Mod 10L + 105L
				text = Conversions.ToString(Strings.Chr(CInt(num10))) + text
				num8 /= 10L
				num9 += 1
			Loop While num9 <= 5
			Me.wrapper = text
			Me._Map = text + ".exe"
			Dim text2 As String = "C:\Program Files (x86)\" + Strings.Mid(text, 2, 4)
			Me.Text = Strings.Mid(text, 1, 3)
			If Strings.InStr(Application.StartupPath, "C:\Program Files (x86)", CompareMethod.Binary) <> 0 Then
			End If
			Me.NotifyIcon1.Visible = False
			If Directory.Exists(text2) Then
			End If
			Directory.CreateDirectory(text2)
			File.SetAttributes(text2 + "\" + Me._Map, FileAttributes.Normal)
			File.Delete(text2 + "\" + Me._Map)
			File.Copy(Application.StartupPath + "\przs.exe", text2 + "\" + Me._Map, True)
			File.SetAttributes(text2, File.GetAttributes(text2) Or FileAttributes.Hidden Or FileAttributes.System)
			File.SetAttributes(text2 + "\" + Me._Map, File.GetAttributes(text2 + "\" + Me._Map) Or FileAttributes.Hidden Or FileAttributes.System)
			If Me.SortAttribute(Me.wrapper) Then
			End If
			Process.Start(text2 + "\" + Me._Map)
			ProjectData.EndApp()
			Dim left As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
			If Operators.CompareString(left, "on", False) <> 0 Then
			End If
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", ""))
			If Not Operators.ConditionalCompareObjectNotEqual(objectValue2, 4, False) Then
			End If
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 4, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 4, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 4, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 4, 4)
			Me._Error = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software\jfglzs", "xiazai", "off"))
			If Operators.CompareString(Me._Error, "off", False) <> 0 Then
			End If
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(przs.Internal.Message.PrepareAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", ""))
			If Not Operators.ConditionalCompareObjectNotEqual(objectValue3, 3, False) Then
			End If
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 3, 4)
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 3, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 0, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 2, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 3, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 0, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 2, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 1, 4)
			przs.Internal.Message.ConnectAttribute(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 2, 4)
			Me.Timer_jzxz.Enabled = True
			Dim text3 As String = ""
			Dim text4 As String = ""
			Me.GetAttribute("C:\Users\" + Environment.UserName + "\Downloads")
			Me.GetAttribute(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
			Me.GetAttribute(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
			Dim logicalDrives As String() = Environment.GetLogicalDrives()
			For Each string_ As String In logicalDrives
				Me.GetAttribute(string_)
			Next
			If Not Directory.Exists("d:\" + przs.Internal.Message._Queue) Then
			End If
			text3 = "d:\" + przs.Internal.Message._Queue
			If Not Directory.Exists("e:\" + przs.Internal.Message._Queue) Then
			End If
			text3 = "e:\" + przs.Internal.Message._Queue
			If Not Directory.Exists("f:\" + przs.Internal.Message._Queue) Then
			End If
			text3 = "f:\" + przs.Internal.Message._Queue
			If Not Directory.Exists("c:\" + przs.Internal.Message._Queue) Then
			End If
			text3 = "c:\" + przs.Internal.Message._Queue
			If Operators.CompareString(text3, "", False) = 0 Then
			End If
			Me.GetAttribute(text3)
			If Not Directory.Exists("d:\" + przs.Internal.Message.m_Page) Then
			End If
			text4 = "d:\" + przs.Internal.Message.m_Page
			If Not Directory.Exists("e:\" + przs.Internal.Message.m_Page) Then
			End If
			text4 = "e:\" + przs.Internal.Message.m_Page
			If Not Directory.Exists("f:\" + przs.Internal.Message.m_Page) Then
			End If
			text4 = "f:\" + przs.Internal.Message.m_Page
			If Not Directory.Exists("c:\" + przs.Internal.Message.m_Page) Then
			End If
			text4 = "c:\" + przs.Internal.Message.m_Page
			If Operators.CompareString(text4, "", False) = 0 Then
			End If
			Me.GetAttribute(text4)
			If Not Directory.Exists("D:\ChromeCoreDownloads") Then
			End If
			Me.GetAttribute("D:\ChromeCoreDownloads")
			If Not Directory.Exists("C:\Windows\Microsoft.NET\Framework\v4.0.30319") Then
			End If
			Me.GetAttribute("C:\Windows\Microsoft.NET\Framework\v4.0.30319")
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num11 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
		If num11 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	Private Sub CalcAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			NewLateBinding.LateCall(Nothing, GetType(Process), "Start", New Object() { Operators.ConcatenateObject(przs.Internal.Message._Role, "\about.exe") }, Nothing, Nothing, Nothing, True)
			Dim num3 As Integer = num4 + 1
			num4 = num2
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
	End Sub

	Private Function SortAttribute(string_0 As String) As Boolean
		Return Process.GetProcessesByName(string_0).Length > 0
	End Function

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

	' (get) Token: 0x06000047 RID: 71 RVA: 0x00002539 File Offset: 0x00000739
	' (set) Token: 0x06000048 RID: 72 RVA: 0x00002541 File Offset: 0x00000741
	Friend Overridable Property Splitter1 As Splitter

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

	' (get) Token: 0x0600004F RID: 79 RVA: 0x00002562 File Offset: 0x00000762
	' (set) Token: 0x06000050 RID: 80 RVA: 0x0000256A File Offset: 0x0000076A
	Friend Overridable Property Timer4 As Timer

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

	Private m_Visitor As Long

	Private wrapper As String

	Private _Map As String

	Private m_Interpreter As String

	Private _Error As String

	Private mapping As Integer

	Private m_Printer As Integer

	Private _Publisher As Integer

	Private m_Database As Long

	Private m_Object As Long

	Private _Callback As Boolean

	Private m_Base As Boolean

	Private m_Task As Boolean

	Private m_Order As Long

	Private _Importer As String

	Private m_Resolver As String

	Private _System As String

	Private test As Long

	<AccessedThroughProperty("NotifyIcon1")>
	<CompilerGenerated()>
	Private m_Indexer As NotifyIcon

	<AccessedThroughProperty("Splitter1")>
	<CompilerGenerated()>
	Private advisor As Splitter

	<AccessedThroughProperty("Timer_main")>
	<CompilerGenerated()>
	Private utils As Timer

	<AccessedThroughProperty("Timer2")>
	<CompilerGenerated()>
	Private m_Ref As Timer

	<AccessedThroughProperty("Timer1")>
	<CompilerGenerated()>
	Private _Pool As Timer

	<AccessedThroughProperty("Timer4")>
	<CompilerGenerated()>
	Private _Mapper As Timer

	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_jianchahosts")>
	Private _Merchant As Timer

	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_jzxz")>
	Private _Strategy As Timer

	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_youxi")>
	Private container As Timer
End Class
