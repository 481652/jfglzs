Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32
Imports [set].Internal

Namespace WindowsApplication1

	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.OrderContext
			AddHandler MyBase.FormClosing, AddressOf Me.InsertContext
			Me.m_PropertyCollection = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts"
			Me.m_QueueCollection = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts-bak"
			Me.importerCollection = "c:\windows\jf"
			Me.m_CustomerCollection = "www.zmyxl2008.com"
			Me._ValueCollection = "C:\Windows\System32\drivers\etc\hosts"
			Me.orderCollection = False
			Me.m_AdapterCollection = ""
			Me.SearchContext()
		End Sub

	
		Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (int_0 As Integer, int_1 As Integer, string_0 As String, int_2 As Integer) As Boolean

	
		Private Declare Ansi Function BlockInput Lib "user32" (long_0 As Long) As Object

	
		Private Declare Ansi Sub Sleep Lib "kernel32" (long_0 As Long)

	
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form1.RECT) As Integer

	
		Private Sub OrderContext(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim left As String = ""
				Me.m_AdapterCollection = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "dzjs", ""))
				If Operators.CompareString(Me.m_AdapterCollection, "", False) = 0 Then
				End If
				Me.TextBox1.Text = Me.m_AdapterCollection
				Me.m_AdapterCollection = Me.GetProcessPathsByName("studentMain")
				If Operators.CompareString(Me.m_AdapterCollection, "", False) <> 0 Then
				End If
				Me.m_AdapterCollection = Me.GetProcessPathsByName("ClassMangerApp")
				If Operators.CompareString(Me.m_AdapterCollection, "", False) <> 0 Then
				End If
				Me.m_AdapterCollection = Me.GetProcessPathsByName("REDAgent")
				If Operators.CompareString(Me.m_AdapterCollection, "", False) = 0 Then
				End If
				Me.TextBox1.Text = "自动获得文件路径是：" + Me.m_AdapterCollection
				Me.m_RefCollection = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
				If Operators.CompareString(Me.m_RefCollection, "off", False) <> 0 Then
				End If
				Me.RadioButton1.Checked = True
				Me.RadioButton2.Checked = True
				Dim left2 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", ""))
				If Operators.CompareString(left2, "off", False) <> 0 Then
				End If
				Me.RadioButton3.Checked = True
				Me.RadioButton4.Checked = True
				Dim left3 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", ""))
				If Operators.CompareString(left3, "off", False) <> 0 Then
				End If
				Me.RadioButton5.Checked = True
				Me.RadioButton6.Checked = True
				Dim left4 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "win_jian", ""))
				If Operators.CompareString(left4, "on", False) <> 0 Then
				End If
				Me.RadioButton11.Checked = True
				Me.RadioButton12.Checked = True
				left = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "games_jianche", ""))
				If Operators.CompareString(left, "off", False) <> 0 Then
				End If
				Me.RadioButton14.Checked = True
				Me.RadioButton13.Checked = True
				Dim left5 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "bianhao", ""))
				If Operators.CompareString(left5, "off", False) <> 0 Then
				End If
				Me.RadioButton10.Checked = True
				Me.RadioButton9.Checked = True
				Dim left6 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "xiazai", ""))
				If Operators.CompareString(left6, "on", False) <> 0 Then
				End If
				Me.RadioButton7.Checked = True
				Me.RadioButton8.Checked = True
				Dim num3 As Integer = Conversions.ToInteger(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 2))
				If num3 <> 1 Then
				End If
				Me.RadioButton15.Checked = True
				If num3 <> 2 Then
				End If
				Me.RadioButton16.Checked = True
				If num3 <> 0 Then
				End If
				Me.RadioButton17.Checked = True
				Dim num4 As Integer = Conversions.ToInteger(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "zcb", 2))
				If num4 <> 2 Then
				End If
				Me.RadioButton19.Checked = True
				If num4 <> 0 Then
				End If
				Me.RadioButton20.Checked = True
				Dim num5 As Integer = num6 + 1
				num6 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub InsertContext(sender As Object, e As FormClosingEventArgs)
			ProjectData.EndApp()
		End Sub

	
		Private Sub ChangeContext(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Me.OpenFileDialog1.ShowDialog()
				Dim fileName As String = Me.OpenFileDialog1.FileName
				Dim fileName2 As String = Path.GetFileName(fileName)
				Path.GetDirectoryName(fileName)
				Path.GetExtension(fileName)
				If Not Me.FlushContext(Strings.Replace(fileName2, ".exe", "", 1, -1, CompareMethod.Binary)) Then
				End If
				Me.TextBox1.Text = Me.OpenFileDialog1.FileName
				Me.m_AdapterCollection = Me.OpenFileDialog1.FileName
				Interaction.MsgBox("你所选的文件并没有运行，请重新选择或先运行电子教室！", MsgBoxStyle.OkOnly, Nothing)
				Dim num3 As Integer = num4 + 1
				num4 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Private Sub ComputeContext(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				If Operators.CompareString(Me.m_AdapterCollection, "", False) <> 0 Then
				End If
				Me.Label2.Text = "选择学生端程序文件!"
				If Strings.Len(Me.pd_new.Text) >= 6 Then
				End If
				Me.Label2.Text = "密码应该是6位或以上的字母或数字，请重新输入！"
				If Operators.CompareString(Me.pd_new.Text, "123456", False) <> 0 Then
				End If
				Me.Label2.Text = "密码太简单，请重新输入！"
				Me.Label2.Text = ""
				Me.Button1.Enabled = False
				If File.Exists(Me.m_PropertyCollection) Then
				End If
				File.Copy("hosts", Me.m_PropertyCollection, True)
				If File.Exists(Me.m_QueueCollection) Then
				End If
				File.Copy(Me.m_PropertyCollection, Me.m_QueueCollection, True)
				Me.PublishContext(Application.StartupPath + "/hmd_local.txt", "on")
				Me.PublishContext("http://" + Me.m_CustomerCollection + "/hmd_net.txt", "on")
				Me.ResolveContext()
				Me.DefineContext()
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub DefineContext()
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim num3 As Integer = Marshal.SizeOf(IntPtr.Zero) * 8
				Me.Cursor = Cursors.WaitCursor
				Dim registryKey As RegistryKey = CandidateCollection.PrintContext.Registry.CurrentUser
				Dim registryKey2 As RegistryKey = registryKey.OpenSubKey("Software\jfglzs")
				If registryKey2 IsNot Nothing Then
				End If
				registryKey2 = registryKey.CreateSubKey("Software\jfglzs")
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "dzjs", Me.m_AdapterCollection, 1)
				If Not Me.RadioButton1.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", "off", 1)
				If Not Me.RadioButton2.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", "on", 1)
				If Not Me.RadioButton3.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", "off", 1)
				If Not Me.RadioButton4.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", "on", 1)
				If Not Me.RadioButton5.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", "off", 1)
				If Not Me.RadioButton6.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", "on", 1)
				If Not Me.RadioButton11.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "win_jian", "on", 1)
				If Not Me.RadioButton12.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "win_jian", "off", 1)
				If Not Me.RadioButton9.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "bianhao", "on", 1)
				If Not Me.RadioButton10.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "bianhao", "off", 1)
				If Not Me.RadioButton13.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "games_jianche", "on", 1)
				If Not Me.RadioButton14.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "games_jianche", "off", 1)
				If Not Me.RadioButton7.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "xiazai", "on", 1)
				If Not Me.RadioButton8.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "xiazai", "off", 1)
				If Not Me.RadioButton15.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 1, 4)
				If Not Me.RadioButton16.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 2, 4)
				If Not Me.RadioButton17.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 0, 4)
				If Not Me.RadioButton19.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "zcb", 2, 4)
				If Not Me.RadioButton20.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "zcb", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "zhuye", Me.m_CustomerCollection, 1)
				Dim text As String = Me.m_AdapterCollection + "2"
				File.Copy(Me.m_AdapterCollection, text, True)
				Dim adapterCollection As String = Me.m_AdapterCollection
				Dim str As String = Strings.Mid(adapterCollection, 1, Strings.Len(adapterCollection) - 16)
				File.SetAttributes(str + "\SpecialSet.exe", File.GetAttributes(str + "\SpecialSet.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 0, 4)
				Interaction.Shell("sc delete zmserv", AppWinStyle.Hide, True, -1)
				Dim object_ As String = MessageCollection.TestContext(Strings.Trim(Me.pd_new.Text))
				Interaction.Shell(Application.StartupPath + "\regini.exe " + Application.StartupPath + "\regqx.ini", AppWinStyle.Hide, True, -1)
				Thread.Sleep(1000)
				File.Copy(Application.StartupPath + "\yl.wav", Application.StartupPath + "\yl.reg", True)
				Interaction.Shell("regedit.exe /s " + Application.StartupPath + "\yl.reg", AppWinStyle.Hide, True, -1)
				Thread.Sleep(1000)
				If Not Me.RadioButton1.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 3, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 3, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 3, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 3, 4)
				If Not Me.RadioButton2.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 4, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 4, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 4, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 4, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", Application.StartupPath + "\przs.exe", 1)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", Application.StartupPath + "\jfglzsn.exe", 1)
				Thread.Sleep(1000)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", Application.StartupPath + "\przs.exe", 1)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", Application.StartupPath + "\jfglzsn.exe", 1)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\PublicProfile", "EnableFirewall", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\DomainProfile\PublicProfile", "EnableFirewall", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableLockWorkstation", 1, 4)
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				registryKey.DeleteSubKeyTree("SYSTEM\CurrentControlSet\Control\SafeBoot\Network")
				Interaction.Shell("cmd /c bcdedit /set {bootmgr} displaybootmenu no", AppWinStyle.MinimizedFocus, False, -1)
				Interaction.Shell("cmd /c bcdedit /delete {ee888888-8888-8888-8888-8888888888ee}", AppWinStyle.MinimizedFocus, False, -1)
				Me.PushContext()
				If Not Me.FillContext(Me.m_CustomerCollection, 5000) Then
				End If
				Me.CreateContext()
				Interaction.Shell(Application.StartupPath + "\regini.exe " + Application.StartupPath + "\regqxoff.ini", AppWinStyle.Hide, True, -1)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "n", object_, 1)
				Dim str2 As String = Application.StartupPath + "\zmserv.exe"
				Interaction.Shell("sc create zmserv binPath= " + str2 + " start= auto", AppWinStyle.Hide, True, -1)
				Interaction.Shell("sc failure zmserv actions= ""reboot/60000/reboot/60000/reboot/60000"" reset= 300 ", AppWinStyle.Hide, True, -1)
				Thread.Sleep(1000)
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Google")
				If registryKey2 IsNot Nothing Then
				End If
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Google")
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Google\Chrome")
				If registryKey2 IsNot Nothing Then
				End If
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Google\Chrome")
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Microsoft")
				If registryKey2 IsNot Nothing Then
				End If
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Microsoft")
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Microsoft\Edge")
				If registryKey2 IsNot Nothing Then
				End If
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Microsoft\Edge")
				If Not Me.RadioButton13.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", 0, 4)
				If Not Me.RadioButton14.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", 1, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", 1, 4)
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\sidebar.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Chess.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\FreeCell.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Hearts.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Minesweeper.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Mahjong.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\SpiderSolitaire.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\bckgzm.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\chkrzm.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\shvlzm.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Solitaire.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winmine")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "WebWidgetAllowed", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\WindowsStore", "RemoveWindowsStore", 1, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton", 0, 4)
				MessageCollection.ListContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer", "DesktopProcess")
				MessageCollection.RemoveContext(Registry.CurrentUser, "Control Panel\Desktop", "AutoEndTasks", 1, 4)
				If Not Me.RadioButton11.Checked Then
				End If
				File.Copy(Application.StartupPath + "\huifu.wav", Application.StartupPath + "\huifu.reg", True)
				Interaction.Shell("regedit.exe /s " + Application.StartupPath + "\huifu.reg", AppWinStyle.Hide, True, -1)
				Thread.Sleep(1000)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayContextMenu", 0, 4)
				If Not Me.RadioButton8.Checked Then
				End If
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 3, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 1, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 1, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 3, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 2, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 3, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 2, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 1, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 1, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 2, 4)
				If Not Me.RadioButton7.Checked Then
				End If
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 1, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 1, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 0, 4)
				Thread.Sleep(1000)
				File.SetAttributes(Me.m_PropertyCollection, File.GetAttributes(Me.m_PropertyCollection) Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes("C:\Windows\System32\drivers\etc", File.GetAttributes("C:\Windows\System32\drivers\etc") Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", 0, 4)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\Hidden\SHOWALL", "CheckedValue", 0, 4)
				If Not Me.RadioButton8.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFolderOptions", 1, 4)
				If Not Me.RadioButton7.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFolderOptions", 0, 4)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", 1, 4)
				If Not Me.RadioButton20.Checked Then
				End If
				registryKey = CandidateCollection.PrintContext.Registry.CurrentUser
				registryKey2 = registryKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
				If registryKey2 IsNot Nothing Then
				End If
				registryKey2 = registryKey.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, 4)
				If Not Me.RadioButton19.Checked Then
				End If
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, 4)
				File.SetAttributes("C:\Program Files\Microsoft Games", File.GetAttributes("C:\Program Files\Microsoft Games") Or FileAttributes.Hidden Or FileAttributes.System)
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters", "DisabledComponents", 255, 4)
				Directory.CreateDirectory(Me.importerCollection)
				File.Copy(Application.StartupPath + "\jfglzsn.exe", Me.importerCollection + "\jfglzsn.dat", True)
				File.Copy(Application.StartupPath + "\przs.exe", Me.importerCollection + "\przs.dat", True)
				File.Copy(Application.StartupPath + "\zmserv.exe", Me.importerCollection + "\zmserv.dat", True)
				File.SetAttributes(Me.importerCollection, File.GetAttributes(Me.importerCollection) Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Me.importerCollection + "\jfglzsn.dat", File.GetAttributes(Me.importerCollection + "\jfglzsn.dat") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Me.importerCollection + "\przs.dat", File.GetAttributes(Me.importerCollection + "\przs.dat") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Me.importerCollection + "\zmserv.dat", File.GetAttributes(Me.importerCollection + "\zmserv.dat") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\jfglzsn.exe", File.GetAttributes(Application.StartupPath + "\jfglzsn.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\zmserv.exe", File.GetAttributes(Application.StartupPath + "\zmserv.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\przs.exe", File.GetAttributes(Application.StartupPath + "\przs.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\set.exe", File.GetAttributes(Application.StartupPath + "\set.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\uninstall.exe", File.GetAttributes(Application.StartupPath + "\uninstall.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\about.exe", File.GetAttributes(Application.StartupPath + "\about.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\yl.wav", File.GetAttributes(Application.StartupPath + "\yl.wav") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\huifu.wav", File.GetAttributes(Application.StartupPath + "\huifu.wav") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\hmd_local.txt", File.GetAttributes(Application.StartupPath + "\hmd_local.txt") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath + "\regini.exe", File.GetAttributes(Application.StartupPath + "\regini.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes(Application.StartupPath, File.GetAttributes(Application.StartupPath) Or FileAttributes.Hidden Or FileAttributes.System)
				File.SetAttributes("C:\Windows\Microsoft.NET", File.GetAttributes("C:\Windows\Microsoft.NET") Or FileAttributes.Hidden Or FileAttributes.System)
				File.Delete(Application.StartupPath + "\yl.reg")
				File.Delete(Application.StartupPath + "\huifu.reg")
				Thread.Sleep(2000)
				Me.Cursor = Cursors.[Default]
				For Each process As Process In Process.GetProcessesByName("explorer")
					process.Kill()
				Next
				Process.Start("explorer.exe")
				CandidateCollection.PrepareContext.Form3.Show()
				Dim num4 As Integer = num5 + 1
				num5 = num2

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub PushContext()
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim str As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\Internet Explorer\Quick Launch"
				Microsoft.VisualBasic.FileSystem.Kill(str + "\*.*")
				File.Copy(Application.StartupPath + "\zy\Internet   Explore.lnk", str + "\Internet   Explore.lnk", True)
				Dim str2 As String = str + "\User Pinned\TaskBar"
				Microsoft.VisualBasic.FileSystem.Kill(str2 + "\*.*")
				File.Copy(Application.StartupPath + "\zy\Internet   Explore.lnk", str2 + "\Internet   Explore.lnk", True)
				Dim str3 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Favorites", ""))
				Dim str4 As String = str3 + "\links"
				Dim str5 As String = str3 + "\links"
				Microsoft.VisualBasic.FileSystem.Kill(str4 + "\*.*")
				Microsoft.VisualBasic.FileSystem.Kill(str5 + "\*.*")
				File.Copy(Application.StartupPath + "\zy\百度搜索&网址导航.url", str4 + "\百度搜索&网址导航.url", True)
				File.Copy(Application.StartupPath + "\zy\百度搜索&网址导航.url", str4 + "\百度搜索&网址导航.url", True)
				Dim currentUser As RegistryKey = CandidateCollection.PrintContext.Registry.CurrentUser
				Dim registryKey As RegistryKey = currentUser.OpenSubKey("Software\Microsoft\Internet Explorer\LinksBar", True)
				If registryKey IsNot Nothing Then
				End If
				registryKey = currentUser.CreateSubKey("Software\Microsoft\Internet Explorer\LinksBar")
				registryKey.SetValue("Enabled", 1)
				Dim num3 As Integer = num4 + 1
				num4 = num2

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub CreateContext()
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
				Dim enumerator As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(folderPath, SearchOption.SearchTopLevelOnly, New String() { "*.exe" }).GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					If Strings.InStr(text, "360安全浏览器", CompareMethod.Binary) > 0 Then
						num3 += 1
						File.SetAttributes(text, FileAttributes.Normal)
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", folderPath + "\360安全浏览器.exe", True)
					Else
						If Strings.InStr(text, "Google Chrome", CompareMethod.Binary) > 0 Then
							num3 += 1
							File.SetAttributes(text, FileAttributes.Normal)
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", folderPath + "\Google Chrome.exe", True)
						Else
							If Strings.InStr(text, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								num3 += 1
								File.SetAttributes(text, FileAttributes.Normal)
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", folderPath + "\2345加速浏览器.exe", True)
							Else
								If Strings.InStr(text, "360极速浏览器", CompareMethod.Binary) > 0 Then
									num3 += 1
									File.SetAttributes(text, FileAttributes.Normal)
									File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", folderPath + "\360极速浏览器.exe", True)
								Else
									If Strings.InStr(text, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
										num3 += 1
										File.SetAttributes(text, FileAttributes.Normal)
										File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", folderPath + "\360 极速浏览器X.exe", True)
									Else
										If Strings.InStr(text, "QQ浏览器", CompareMethod.Binary) > 0 Then
											num3 += 1
											File.SetAttributes(text, FileAttributes.Normal)
											File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", folderPath + "\QQ浏览器.exe", True)
										Else
											If Strings.InStr(text, "极速浏览器", CompareMethod.Binary) > 0 Then
												num3 += 1
												File.SetAttributes(text, FileAttributes.Normal)
												File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", folderPath + "\极速浏览器.exe", True)
											Else
												If Strings.InStr(text, "双核浏览器", CompareMethod.Binary) > 0 Then
													num3 += 1
													File.SetAttributes(text, FileAttributes.Normal)
													File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", folderPath + "\双核浏览器.exe", True)
												Else
													If Strings.InStr(text, "Firefox", CompareMethod.Binary) > 0 Then
														num3 += 1
														File.SetAttributes(text, FileAttributes.Normal)
														File.Copy(Application.StartupPath + "\zy\Firefox.exe", folderPath + "\Firefox.exe", True)
													Else
														If Strings.InStr(text, "谷歌浏览器", CompareMethod.Binary) > 0 Then
															Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
															File.SetAttributes(text, FileAttributes.Normal)
															Microsoft.VisualBasic.FileSystem.Kill(text)
														Else
															If Strings.InStr(text, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																num3 += 1
																File.SetAttributes(text, FileAttributes.Normal)
																File.Copy(Application.StartupPath + "\zy\Microsoft Edge.exe", folderPath + "\Microsoft Edge.exe", True)
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End While
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				Dim text2 As String = "C:\Users\Public\Desktop"
				Dim enumerator2 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(text2, SearchOption.SearchTopLevelOnly, New String() { "*.exe" }).GetEnumerator()
				While enumerator2.MoveNext()
					Dim text3 As String = enumerator2.Current
					If Strings.InStr(text3, "360安全浏览器", CompareMethod.Binary) > 0 Then
						num3 += 1
						File.SetAttributes(text3, FileAttributes.Normal)
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", text2 + "\360安全浏览器.exe", True)
					Else
						If Strings.InStr(text3, "Google Chrome", CompareMethod.Binary) > 0 Then
							num3 += 1
							File.SetAttributes(text3, FileAttributes.Normal)
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", text2 + "\Google Chrome.exe", True)
						Else
							If Strings.InStr(text3, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								num3 += 1
								File.SetAttributes(text3, FileAttributes.Normal)
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", text2 + "\2345加速浏览器.exe", True)
							Else
								If Strings.InStr(text3, "360极速浏览器", CompareMethod.Binary) > 0 Then
									num3 += 1
									File.SetAttributes(text3, FileAttributes.Normal)
									File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", text2 + "\360极速浏览器.exe", True)
								Else
									If Strings.InStr(text3, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
										num3 += 1
										File.SetAttributes(text3, FileAttributes.Normal)
										File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", text2 + "\360 极速浏览器X.exe", True)
									Else
										If Strings.InStr(text3, "QQ浏览器", CompareMethod.Binary) > 0 Then
											num3 += 1
											File.SetAttributes(text3, FileAttributes.Normal)
											File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", text2 + "\QQ浏览器.exe", True)
										Else
											If Strings.InStr(text3, "极速浏览器", CompareMethod.Binary) > 0 Then
												num3 += 1
												File.SetAttributes(text3, FileAttributes.Normal)
												File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", text2 + "\极速浏览器.exe", True)
											Else
												If Strings.InStr(text3, "双核浏览器", CompareMethod.Binary) > 0 Then
													num3 += 1
													File.SetAttributes(text3, FileAttributes.Normal)
													File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", text2 + "\双核浏览器.exe", True)
												Else
													If Strings.InStr(text3, "Firefox", CompareMethod.Binary) > 0 Then
														num3 += 1
														File.SetAttributes(text3, FileAttributes.Normal)
														File.Copy(Application.StartupPath + "\zy\Firefox.exe", text2 + "\Firefox.exe", True)
													Else
														If Strings.InStr(text3, "谷歌浏览器", CompareMethod.Binary) > 0 Then
															Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
															File.SetAttributes(text3, FileAttributes.Normal)
															Microsoft.VisualBasic.FileSystem.Kill(text3)
														Else
															If Strings.InStr(text3, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																num3 += 1
																File.SetAttributes(text3, FileAttributes.Normal)
																File.Copy(Application.StartupPath + "\zy\Microsoft Edge.exe", text2 + "\Microsoft Edge.exe", True)
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End While
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				Dim enumerator3 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(folderPath, SearchOption.SearchTopLevelOnly, New String() { "*.lnk" }).GetEnumerator()
				While enumerator3.MoveNext()
					Dim text4 As String = enumerator3.Current
					If Strings.InStr(text4, "360安全浏览器", CompareMethod.Binary) > 0 Then
						Dim text5 As String = Me.ReadShortCut(text4)
						MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360", text5, 1)
						File.SetAttributes(text4, FileAttributes.Normal)
						Microsoft.VisualBasic.FileSystem.Kill(text4)
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", folderPath + "\360安全浏览器.exe", True)
						num3 += 1
					Else
						If Strings.InStr(text4, "Google Chrome", CompareMethod.Binary) > 0 Then
							Dim text5 As String = Me.ReadShortCut(text4)
							MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "chrome", text5, 1)
							File.SetAttributes(text4, FileAttributes.Normal)
							Microsoft.VisualBasic.FileSystem.Kill(text4)
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", folderPath + "\Google Chrome.exe", True)
							num3 += 1
						Else
							If Strings.InStr(text4, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								Dim text5 As String = Me.ReadShortCut(text4)
								MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "2345", text5, 1)
								File.SetAttributes(text4, FileAttributes.Normal)
								Microsoft.VisualBasic.FileSystem.Kill(text4)
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", folderPath + "\2345加速浏览器.exe", True)
								num3 += 1
							Else
								If Strings.InStr(text4, "Firefox", CompareMethod.Binary) > 0 Or Strings.InStr(text4, "firefox", CompareMethod.Binary) > 0 Then
									Dim text5 As String = Me.ReadShortCut(text4)
									MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "firefox", text5, 1)
									File.SetAttributes(text4, FileAttributes.Normal)
									Microsoft.VisualBasic.FileSystem.Kill(text4)
									File.Copy(Application.StartupPath + "\zy\Firefox.exe", folderPath + "\Firefox.exe", True)
									num3 += 1
								Else
									If Strings.InStr(text4, "360极速浏览器", CompareMethod.Binary) > 0 Then
										Dim text5 As String = Me.ReadShortCut(text4)
										MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360js", text5, 1)
										File.SetAttributes(text4, FileAttributes.Normal)
										Microsoft.VisualBasic.FileSystem.Kill(text4)
										File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", folderPath + "\360极速浏览器.exe", True)
										num3 += 1
									Else
										If Strings.InStr(text4, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
											Dim text5 As String = Me.ReadShortCut(text4)
											MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360jsx", text5, 1)
											File.SetAttributes(text4, FileAttributes.Normal)
											Microsoft.VisualBasic.FileSystem.Kill(text4)
											File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", folderPath + "\360 极速浏览器X.exe", True)
											num3 += 1
										Else
											If Strings.InStr(text4, "QQ浏览器", CompareMethod.Binary) > 0 Then
												Dim text5 As String = Me.ReadShortCut(text4)
												MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "qq", text5, 1)
												File.SetAttributes(text4, FileAttributes.Normal)
												Microsoft.VisualBasic.FileSystem.Kill(text4)
												File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", folderPath + "\QQ浏览器.exe", True)
												num3 += 1
											Else
												If Strings.InStr(text4, "极速浏览器", CompareMethod.Binary) > 0 Then
													Dim text5 As String = Me.ReadShortCut(text4)
													MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "jisu", text5, 1)
													File.SetAttributes(text4, FileAttributes.Normal)
													Microsoft.VisualBasic.FileSystem.Kill(text4)
													File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", folderPath + "\极速浏览器.exe", True)
													num3 += 1
												Else
													If Strings.InStr(text4, "双核浏览器", CompareMethod.Binary) > 0 Then
														Dim text5 As String = Me.ReadShortCut(text4)
														MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "shuanghe", text5, 1)
														File.SetAttributes(text4, FileAttributes.Normal)
														Microsoft.VisualBasic.FileSystem.Kill(text4)
														File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", folderPath + "\双核浏览器.exe", True)
														num3 += 1
													Else
														If Strings.InStr(text4, "谷歌浏览器", CompareMethod.Binary) > 0 Then
															Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
															Microsoft.VisualBasic.FileSystem.Kill(text4)
														Else
															If Strings.InStr(text4, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																Dim text5 As String = Me.ReadShortCut(text4)
																File.SetAttributes(text4, FileAttributes.Normal)
																Microsoft.VisualBasic.FileSystem.Kill(text4)
																If Strings.InStr(text5, ".exe", CompareMethod.Binary) > 0 Then
																	MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "edge", text5, 1)
																	File.Copy(Application.StartupPath + "\zy\Microsoft Edge.exe", folderPath + "\Microsoft Edge.exe", True)
																	num3 += 1
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End While
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				Dim enumerator4 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(text2, SearchOption.SearchTopLevelOnly, New String() { "*.lnk" }).GetEnumerator()
				While enumerator4.MoveNext()
					Dim text6 As String = enumerator4.Current
					If Strings.InStr(text6, "360安全浏览器", CompareMethod.Binary) > 0 Then
						Dim text5 As String = Me.ReadShortCut(text6)
						MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360", text5, 1)
						File.SetAttributes(text6, FileAttributes.Normal)
						Microsoft.VisualBasic.FileSystem.Kill(text6)
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", text2 + "\360安全浏览器.exe", True)
						num3 += 1
					Else
						If Strings.InStr(text6, "Google Chrome", CompareMethod.Binary) > 0 Then
							Dim text5 As String = Me.ReadShortCut(text6)
							MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "chrome", text5, 1)
							File.SetAttributes(text6, FileAttributes.Normal)
							Microsoft.VisualBasic.FileSystem.Kill(text6)
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", text2 + "\Google Chrome.exe", True)
							num3 += 1
						Else
							If Strings.InStr(text6, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								Dim text5 As String = Me.ReadShortCut(text6)
								MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "2345", text5, 1)
								File.SetAttributes(text6, FileAttributes.Normal)
								Microsoft.VisualBasic.FileSystem.Kill(text6)
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", text2 + "\2345加速浏览器.exe", True)
								num3 += 1
							Else
								If Strings.InStr(text6, "Firefox", CompareMethod.Binary) > 0 Or Strings.InStr(text6, "firefox", CompareMethod.Binary) > 0 Then
									Dim text5 As String = Me.ReadShortCut(text6)
									MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "firefox", text5, 1)
									File.SetAttributes(text6, FileAttributes.Normal)
									Microsoft.VisualBasic.FileSystem.Kill(text6)
									File.Copy(Application.StartupPath + "\zy\Firefox.exe", text2 + "\Firefox.exe", True)
									num3 += 1
								Else
									If Strings.InStr(text6, "360极速浏览器", CompareMethod.Binary) > 0 Then
										Dim text5 As String = Me.ReadShortCut(text6)
										MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360js", text5, 1)
										File.SetAttributes(text6, FileAttributes.Normal)
										Microsoft.VisualBasic.FileSystem.Kill(text6)
										File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", text2 + "\360极速浏览器.exe", True)
										num3 += 1
									Else
										If Strings.InStr(text6, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
											Dim text5 As String = Me.ReadShortCut(text6)
											MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360jsx", text5, 1)
											File.SetAttributes(text6, FileAttributes.Normal)
											Microsoft.VisualBasic.FileSystem.Kill(text6)
											File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", text2 + "\360 极速浏览器X.exe", True)
											num3 += 1
										Else
											If Strings.InStr(text6, "QQ浏览器", CompareMethod.Binary) > 0 Then
												Dim text5 As String = Me.ReadShortCut(text6)
												MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "qq", text5, 1)
												File.SetAttributes(text6, FileAttributes.Normal)
												Microsoft.VisualBasic.FileSystem.Kill(text6)
												File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", text2 + "\QQ浏览器.exe", True)
												num3 += 1
											Else
												If Strings.InStr(text6, "谷歌浏览器", CompareMethod.Binary) > 0 Then
													Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
													Microsoft.VisualBasic.FileSystem.Kill(text6)
												Else
													If Strings.InStr(text6, "极速浏览器", CompareMethod.Binary) > 0 Then
														Dim text5 As String = Me.ReadShortCut(text6)
														MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "jisu", text5, 1)
														File.SetAttributes(text6, FileAttributes.Normal)
														Microsoft.VisualBasic.FileSystem.Kill(text6)
														File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", text2 + "\极速浏览器.exe", True)
														num3 += 1
													Else
														If Strings.InStr(text6, "双核浏览器", CompareMethod.Binary) > 0 Then
															Dim text5 As String = Me.ReadShortCut(text6)
															MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "shuanghe", text5, 1)
															File.SetAttributes(text6, FileAttributes.Normal)
															Microsoft.VisualBasic.FileSystem.Kill(text6)
															File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", text2 + "\双核浏览器.exe", True)
															num3 += 1
														Else
															If Strings.InStr(text6, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																Dim text5 As String = Me.ReadShortCut(text6)
																File.SetAttributes(text6, FileAttributes.Normal)
																Microsoft.VisualBasic.FileSystem.Kill(text6)
																If Strings.InStr(text5, ".exe", CompareMethod.Binary) > 0 Then
																	MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "edge", text5, 1)
																	File.Copy(Application.StartupPath + "\zy\Microsoft Edge.exe", text2 + "\Microsoft Edge.exe", True)
																	num3 += 1
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End While
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
				If num3 <> 0 Then
				End If
				File.Copy(Application.StartupPath + "\zy\百度搜索&网址导航.url", folderPath + "\百度搜索&网址导航.url", True)
				Dim enumerator5 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(folderPath, SearchOption.SearchTopLevelOnly, New String() { "*.lnk" }).GetEnumerator()
				While enumerator5.MoveNext()
					Dim text7 As String = enumerator5.Current
					If Strings.InStr(text7, "网址导航", CompareMethod.Binary) > 0 Or Strings.InStr(text7, "上网导航", CompareMethod.Binary) > 0 Or Strings.InStr(text7, "百度一下", CompareMethod.Binary) > 0 Then
						Microsoft.VisualBasic.FileSystem.Kill(text7)
					End If
				End While
				If enumerator5 IsNot Nothing Then
					enumerator5.Dispose()
				End If
				Dim enumerator6 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(Application.StartupPath + "\zy\", SearchOption.SearchAllSubDirectories, New String() { "*.*" }).GetEnumerator()
				While enumerator6.MoveNext()
					Dim file As String = enumerator6.Current
					CandidateCollection.PrintContext.FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing)
				End While
				If enumerator6 IsNot Nothing Then
					enumerator6.Dispose()
				End If
				Dim num4 As Integer = num5 + 1
				num5 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Public Function ReadShortCut(strFile As String) As String
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID("WScript.Shell")))
			Dim instance As Object = objectValue
			Dim type As Type = Nothing
			Dim memberName As String = "CreateShortcut"
			Dim array As Object() = New Object() { strFile }
			Dim array2 As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array3 As Boolean() = New Boolean() { True }
			Dim array4 As Boolean() = array3
			Dim obj As Object = NewLateBinding.LateGet(instance, type, memberName, array, argumentNames, typeArguments, array3)
			If array4(0) Then
				strFile = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj)
			Dim result As String = Conversions.ToString(NewLateBinding.LateGet(objectValue2, Nothing, "TargetPath", New Object(-1) {}, Nothing, Nothing, Nothing))
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue2))
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue))
			Return result
		End Function

	
		Private Sub WriteContext(sender As Object, e As EventArgs)
			Process.Start("http://www.jfglzs.com/software/bangzhu.htm")
		End Sub

	
		Private Sub ResolveContext()
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim text As String = "zmserv"
				Dim text2 As String = Conversions.ToString(MessageCollection.m_InfoCollection)
				Dim text3 As String = "jfglzsn"
				Dim processesByName As Process()
				Dim processesByName2 As Process()
				Do
					processesByName = Process.GetProcessesByName(text2)
					processesByName(0).Kill()
					processesByName2 = Process.GetProcessesByName(text3)
					processesByName2(0).Kill()
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				Dim num3 As Integer = 10
				num3 = num3 * 10 + 2
				For Each process As Process In Process.GetProcesses()
					Dim num4 As Integer = Strings.Len(process.ProcessName)
					If num4 >= 4 Then
						Dim num5 As Integer = num4
						Dim j As Integer = 1
						While j <= num5
							Dim num6 As Integer = Strings.Asc(Strings.Mid(process.ProcessName, j, 1))
							If num6 >= num3 Then
								If num6 <= num3 + 9 Then
									j += 1
									Continue While
								End If
							End If
							If j = num4 + 1 Then
								process.Kill()
							End If
						End While
					End If
				Next
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				Thread.Sleep(1000)
				Dim processesByName3 As Process() = Process.GetProcessesByName(text)
				processesByName3(0).Kill()
				Dim lpRect As Form1.RECT
				lpRect.Left = 0
				lpRect.Top = 0
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				Form1.ClipCursor(lpRect)
				Dim num7 As Integer = num8 + 1
				num8 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Private Sub StartContext(sender As Object, e As EventArgs)
			Dim text As String = ""
			Using openFileDialog As OpenFileDialog = New OpenFileDialog()
				openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png"
				openFileDialog.InitialDirectory = Application.StartupPath + "\wallpaper"
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					text = openFileDialog.FileName
				End If
			End Using
			If String.IsNullOrEmpty(text) Then
				MessageBox.Show("请先选择图片文件")
				Return
			End If
			Try
				Me.LogoutContext(text, Form1.WallpaperStyle.Stretched)
			Catch ex As Exception
				MessageBox.Show("设置失败: {ex.Message}")
			End Try
		End Sub

	
		Private Sub GetContext(sender As Object, e As EventArgs)
			Dim string_ As String = "C:\Windows\Web\Wallpaper\Windows\img0.jpg"
			Try
				Me.LogoutContext(string_, Form1.WallpaperStyle.Stretched)
			Catch ex As Exception
				MessageBox.Show("设置失败: {ex.Message}")
			End Try
		End Sub

	
		Private Sub LogoutContext(string_0 As String, wallpaperStyle_0 As Form1.WallpaperStyle)
			If Not File.Exists(string_0) Then
				Throw New ArgumentException("指定的图片文件不存在")
			End If
			Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
				registryKey.SetValue("Wallpaper", string_0)
				registryKey.SetValue("WallpaperStyle", "2")
			End Using
			If Not Form1.SystemParametersInfo(20, 0, string_0, 3) Then
				Throw New Win32Exception()
			End If
		End Sub

	
		Private Sub CustomizeContext(string_0 As String)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim text As String = "127.0.0.1"
				Dim text2 As String = File.ReadAllText(Me.m_PropertyCollection)
				If text2.Contains(text + " " + string_0) Then
				End If
				text2 = String.Concat(New String() { text2, Environment.NewLine, text, " ", string_0 })
				File.WriteAllText(Me.m_PropertyCollection, text2)
				Dim num3 As Integer = num4 + 1
				num4 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Public Function GetProcessPathsByName(processName As String) As String
			Dim result As String
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim text As String = ""
				Dim processesByName As Process() = Process.GetProcessesByName(processName)
				For Each process As Process In processesByName
					text = process.MainModule.FileName
				Next
				result = text
				Dim num3 As Integer = num4 + 1
				num4 = num2

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			Return result
		End Function

	
		Private Sub RestartContext(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("https://www.jfglzs.com/c16.html")
		End Sub

	
		Private Sub PublishContext(string_0 As String, string_1 As String)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				If Me.FillContext("223.5.5.5", 1500) Then
				End If
				Me.orderCollection = False
				Dim tempFileName As String = Path.GetTempFileName()
				Using webClient As WebClient = New WebClient()
					webClient.DownloadFile(string_0, tempFileName)
				End Using
				Dim array As String() = File.ReadAllLines(tempFileName)
				If Strings.InStr(array(0), "www.", CompareMethod.Binary) <> 0 Then
				End If
				Me.orderCollection = False
							For Each left As String In array
					If Operators.CompareString(left, "视频网站：", False) = 0 Then
						num4 = num3 - 1
						num5 = num3 + 1
					End If
					If Operators.CompareString(left, "产品名：", False) = 0 Then
						num6 = num3 - 1
					End If
					num3 += 1
				Next
				File.SetAttributes(Me._ValueCollection, FileAttributes.Normal)
				File.SetAttributes(Me._ValueCollection, FileAttributes.Normal)
				Dim text As String = File.ReadAllText(Me._ValueCollection)
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				Dim array3 As String() = text.Split(New String() { Environment.NewLine }, StringSplitOptions.None)
				For Each text2 As String In array3
					If text2.Trim().StartsWith("127.0.0.1") Then
						Dim array5 As String() = text2.Trim().Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
						If array5.Length > 1 Then
							hashSet.Add(array5(1).ToLower())
						End If
					End If
				Next
				Dim stringBuilder As StringBuilder = New StringBuilder(text)
				stringBuilder.AppendLine()
				Dim num7 As Integer = num4
				For k As Integer = 0 To num7
					If Not String.IsNullOrEmpty(array(k).Trim()) Then
						Dim text3 As String = array(k).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						If Not hashSet.Contains(text3) Then
							stringBuilder.AppendLine("127.0.0.1 " + text3)
						End If
					End If
				Next
				If Operators.CompareString(string_1, "off", False) <> 0 Then
				End If
				Dim num8 As Integer = num5
				Dim num9 As Integer = num6
				For l As Integer = num8 To num9
					If Not String.IsNullOrEmpty(array(l).Trim()) Then
						Dim text4 As String = array(l).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						If Not hashSet.Contains(text4) Then
							stringBuilder.AppendLine("127.0.0.1 " + text4)
						End If
					End If
				Next
				File.WriteAllText(Me._ValueCollection, stringBuilder.ToString())
				Me.orderCollection = True
				File.SetAttributes(Me._ValueCollection, File.GetAttributes(Me._ValueCollection) Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				Interaction.Shell("ipconfig /flushdns", AppWinStyle.Hide, True, -1)
				Dim num10 As Integer = num11 + 1
				num11 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num11 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Private Function FillContext(string_0 As String, int_0 As Integer) As Boolean
			Dim result As Boolean
			If Not NetworkInterface.GetIsNetworkAvailable() Then
				result = False
			Else
				Try
					If New Ping().Send(string_0, int_0).Status Is Nothing Then
						result = True
					Else
						result = False
					End If
				Catch ex As Exception
					result = False
				End Try
			End If
			Return result
		End Function

	
		Private Function FlushContext(string_0 As String) As Boolean
			Return Process.GetProcessesByName(string_0).Length > 0
		End Function

	
		<DebuggerStepThrough()>
		Private Sub SearchContext()
			Me.Button1 = New Button()
			Me.RadioButton1 = New RadioButton()
			Me.RadioButton2 = New RadioButton()
			Me.RadioButton4 = New RadioButton()
			Me.RadioButton3 = New RadioButton()
			Me.RadioButton6 = New RadioButton()
			Me.RadioButton5 = New RadioButton()
			Me.OpenFileDialog1 = New OpenFileDialog()
			Me.Button2 = New Button()
			Me.GroupBox4 = New GroupBox()
			Me.Label4 = New Label()
			Me.Button3 = New Button()
			Me.TextBox1 = New TextBox()
			Me.Label1 = New Label()
			Me.GroupBox5 = New GroupBox()
			Me.Label8 = New Label()
			Me.pd_new = New TextBox()
			Me.Label2 = New Label()
			Me.RadioButton10 = New RadioButton()
			Me.RadioButton9 = New RadioButton()
			Me.Label10 = New Label()
			Me.RadioButton12 = New RadioButton()
			Me.RadioButton11 = New RadioButton()
			Me.GroupBox_0 = New GroupBox()
			Me.Button_restorepic = New Button()
			Me.Button_selectpic = New Button()
			Me.GroupBox9 = New GroupBox()
			Me.RadioButton13 = New RadioButton()
			Me.RadioButton14 = New RadioButton()
			Me.Label11 = New Label()
			Me.Label12 = New Label()
			Me.Label13 = New Label()
			Me.Label15 = New Label()
			Me.Label16 = New Label()
			Me.GroupBox1 = New GroupBox()
			Me.GroupBox2 = New GroupBox()
			Me.GroupBox3 = New GroupBox()
			Me.GroupBox7 = New GroupBox()
			Me.GroupBox_1 = New GroupBox()
			Me.Label7 = New Label()
			Me.Label5 = New Label()
			Me.Label9 = New Label()
			Me.LinkLabel2 = New LinkLabel()
			Me.Label14 = New Label()
			Me.Label3 = New Label()
			Me.Label6 = New Label()
			Me.Label17 = New Label()
			Me.GroupBox6 = New GroupBox()
			Me.RadioButton8 = New RadioButton()
			Me.RadioButton7 = New RadioButton()
			Me.Label18 = New Label()
			Me.GroupBox8 = New GroupBox()
			Me.RadioButton16 = New RadioButton()
			Me.RadioButton15 = New RadioButton()
			Me.RadioButton17 = New RadioButton()
			Me.Label19 = New Label()
			Me.Label20 = New Label()
			Me.Label21 = New Label()
			Me.GroupBox_2 = New GroupBox()
			Me.RadioButton19 = New RadioButton()
			Me.RadioButton20 = New RadioButton()
			Me.Label22 = New Label()
			Me.Label23 = New Label()
			Me.GroupBox4.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.GroupBox_0.SuspendLayout()
			Me.GroupBox9.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox7.SuspendLayout()
			Me.GroupBox_1.SuspendLayout()
			Me.GroupBox6.SuspendLayout()
			Me.GroupBox8.SuspendLayout()
			Me.GroupBox_2.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Button1.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Button1.Location = New Point(728, 638)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Size(118, 33)
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "保存设置(需10秒)"
			Me.Button1.UseVisualStyleBackColor = True
			Me.RadioButton1.AutoSize = True
			Me.RadioButton1.Location = New Point(6, 11)
			Me.RadioButton1.Name = "RadioButton1"
			Me.RadioButton1.Size = New Size(53, 16)
			Me.RadioButton1.TabIndex = 11
			Me.RadioButton1.Text = "允 许"
			Me.RadioButton1.UseVisualStyleBackColor = True
			Me.RadioButton2.AutoSize = True
			Me.RadioButton2.Checked = True
			Me.RadioButton2.Location = New Point(81, 11)
			Me.RadioButton2.Name = "RadioButton2"
			Me.RadioButton2.Size = New Size(53, 16)
			Me.RadioButton2.TabIndex = 12
			Me.RadioButton2.TabStop = True
			Me.RadioButton2.Text = "禁 止"
			Me.RadioButton2.UseVisualStyleBackColor = True
			Me.RadioButton4.AutoSize = True
			Me.RadioButton4.Checked = True
			Me.RadioButton4.Location = New Point(82, 11)
			Me.RadioButton4.Name = "RadioButton4"
			Me.RadioButton4.Size = New Size(53, 16)
			Me.RadioButton4.TabIndex = 1
			Me.RadioButton4.TabStop = True
			Me.RadioButton4.Text = "禁 止"
			Me.RadioButton4.UseVisualStyleBackColor = True
			Me.RadioButton3.AutoSize = True
			Me.RadioButton3.Location = New Point(7, 11)
			Me.RadioButton3.Name = "RadioButton3"
			Me.RadioButton3.Size = New Size(47, 16)
			Me.RadioButton3.TabIndex = 0
			Me.RadioButton3.Text = "允许"
			Me.RadioButton3.UseVisualStyleBackColor = True
			Me.RadioButton6.AutoSize = True
			Me.RadioButton6.Checked = True
			Me.RadioButton6.Location = New Point(81, 11)
			Me.RadioButton6.Name = "RadioButton6"
			Me.RadioButton6.Size = New Size(53, 16)
			Me.RadioButton6.TabIndex = 1
			Me.RadioButton6.TabStop = True
			Me.RadioButton6.Text = "禁 止"
			Me.RadioButton6.UseVisualStyleBackColor = True
			Me.RadioButton5.AutoSize = True
			Me.RadioButton5.Location = New Point(6, 11)
			Me.RadioButton5.Name = "RadioButton5"
			Me.RadioButton5.Size = New Size(47, 16)
			Me.RadioButton5.TabIndex = 0
			Me.RadioButton5.Text = "允许"
			Me.RadioButton5.UseVisualStyleBackColor = True
			Me.OpenFileDialog1.FileName = "OpenFileDialog1"
			Me.OpenFileDialog1.Filter = "exe文件 |*.exe"
			Me.OpenFileDialog1.InitialDirectory = "C:\Program Files (x86)"
			Me.Button2.Location = New Point(25, 50)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Size(123, 27)
			Me.Button2.TabIndex = 16
			Me.Button2.Text = "手动选择学生端文件"
			Me.Button2.UseVisualStyleBackColor = True
			Me.GroupBox4.Controls.Add(Me.Label4)
			Me.GroupBox4.Controls.Add(Me.Button3)
			Me.GroupBox4.Controls.Add(Me.TextBox1)
			Me.GroupBox4.Controls.Add(Me.Button2)
			Me.GroupBox4.Controls.Add(Me.Label1)
			Me.GroupBox4.Location = New Point(56, 12)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.Size = New Size(738, 85)
			Me.GroupBox4.TabIndex = 17
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "1、电子教室学生端的文件名和路径"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label4.Location = New Point(184, 67)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Size(401, 12)
			Me.Label4.TabIndex = 21
			Me.Label4.Text = "（红蜘蛛:C:\Program Files (x86)\3000soft\Red Spider\REDAgent.exe）"
			Me.Button3.Font = New Font("宋体", 9F)
			Me.Button3.Location = New Point(633, 47)
			Me.Button3.Name = "Button3"
			Me.Button3.Size = New Size(81, 27)
			Me.Button3.TabIndex = 20
			Me.Button3.Text = "设置方法"
			Me.Button3.UseVisualStyleBackColor = True
			Me.TextBox1.Font = New Font("宋体", 9F)
			Me.TextBox1.Location = New Point(25, 20)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Size = New Size(689, 21)
			Me.TextBox1.TabIndex = 19
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label1.Location = New Point(184, 48)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(401, 12)
			Me.Label1.TabIndex = 17
			Me.Label1.Text = "（极域:c:\.\StudentMain.exe，锐捷云课堂:E:\..\ClassMangerApp.exe）"
			Me.GroupBox5.Controls.Add(Me.Label8)
			Me.GroupBox5.Controls.Add(Me.pd_new)
			Me.GroupBox5.Location = New Point(56, 491)
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.Size = New Size(520, 57)
			Me.GroupBox5.TabIndex = 19
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "10、设置密码（因极域密码容易查看到，所以本密码不要与极域密码相同）"
			Me.Label8.AutoSize = True
			Me.Label8.Location = New Point(347, 28)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Size(155, 12)
			Me.Label8.TabIndex = 3
			Me.Label8.Text = "（6位及以上的字母或数字）"
			Me.pd_new.Location = New Point(154, 25)
			Me.pd_new.Name = "pd_new"
			Me.pd_new.PasswordChar = "*"c
			Me.pd_new.Size = New Size(192, 21)
			Me.pd_new.TabIndex = 1
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = Color.Red
			Me.Label2.Location = New Point(73, 545)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Size(0, 12)
			Me.Label2.TabIndex = 4
			Me.RadioButton10.AutoSize = True
			Me.RadioButton10.Location = New Point(8, 12)
			Me.RadioButton10.Name = "RadioButton10"
			Me.RadioButton10.Size = New Size(59, 16)
			Me.RadioButton10.TabIndex = 1
			Me.RadioButton10.Text = "不显示"
			Me.RadioButton10.UseVisualStyleBackColor = True
			Me.RadioButton9.AutoSize = True
			Me.RadioButton9.Checked = True
			Me.RadioButton9.Location = New Point(82, 11)
			Me.RadioButton9.Name = "RadioButton9"
			Me.RadioButton9.Size = New Size(53, 16)
			Me.RadioButton9.TabIndex = 0
			Me.RadioButton9.TabStop = True
			Me.RadioButton9.Text = "显 示"
			Me.RadioButton9.UseVisualStyleBackColor = True
			Me.Label10.AutoSize = True
			Me.Label10.ForeColor = Color.DarkRed
			Me.Label10.Location = New Point(403, 244)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Size(443, 12)
			Me.Label10.TabIndex = 2
			Me.Label10.Text = "（强烈建议禁止，学生按win+Tab或在任务栏上点右键，可用虚拟桌面来脱离控制）"
			Me.RadioButton12.AutoSize = True
			Me.RadioButton12.Checked = True
			Me.RadioButton12.Location = New Point(81, 11)
			Me.RadioButton12.Name = "RadioButton12"
			Me.RadioButton12.Size = New Size(59, 16)
			Me.RadioButton12.TabIndex = 1
			Me.RadioButton12.TabStop = True
			Me.RadioButton12.Text = "禁 止 "
			Me.RadioButton12.UseVisualStyleBackColor = True
			Me.RadioButton11.AutoSize = True
			Me.RadioButton11.Location = New Point(7, 11)
			Me.RadioButton11.Name = "RadioButton11"
			Me.RadioButton11.Size = New Size(53, 16)
			Me.RadioButton11.TabIndex = 0
			Me.RadioButton11.Text = "允 许"
			Me.RadioButton11.UseVisualStyleBackColor = True
			Me.GroupBox_0.Controls.Add(Me.Button_restorepic)
			Me.GroupBox_0.Controls.Add(Me.Button_selectpic)
			Me.GroupBox_0.Location = New Point(56, 563)
			Me.GroupBox_0.Name = "GroupBox10"
			Me.GroupBox_0.Size = New Size(520, 62)
			Me.GroupBox_0.TabIndex = 23
			Me.GroupBox_0.TabStop = False
			Me.GroupBox_0.Text = "11、可选：设置学生电脑桌面"
			Me.Button_restorepic.Location = New Point(371, 20)
			Me.Button_restorepic.Name = "Button_restorepic"
			Me.Button_restorepic.Size = New Size(131, 29)
			Me.Button_restorepic.TabIndex = 1
			Me.Button_restorepic.Text = "恢复windows默认桌面"
			Me.Button_restorepic.UseVisualStyleBackColor = True
			Me.Button_selectpic.Location = New Point(200, 20)
			Me.Button_selectpic.Name = "Button_selectpic"
			Me.Button_selectpic.Size = New Size(127, 29)
			Me.Button_selectpic.TabIndex = 0
			Me.Button_selectpic.Text = "选择背景图(内含6张)"
			Me.Button_selectpic.UseVisualStyleBackColor = True
			Me.GroupBox9.Controls.Add(Me.RadioButton13)
			Me.GroupBox9.Controls.Add(Me.RadioButton14)
			Me.GroupBox9.Location = New Point(56, 424)
			Me.GroupBox9.Name = "GroupBox9"
			Me.GroupBox9.Size = New Size(520, 53)
			Me.GroupBox9.TabIndex = 15
			Me.GroupBox9.TabStop = False
			Me.GroupBox9.Text = "9、扫雷、纸牌、拼图板、谷歌浏览器的小恐龙、Edge浏览器的冲浪等小游戏"
			Me.RadioButton13.AutoSize = True
			Me.RadioButton13.Checked = True
			Me.RadioButton13.Location = New Point(277, 28)
			Me.RadioButton13.Name = "RadioButton13"
			Me.RadioButton13.Size = New Size(53, 16)
			Me.RadioButton13.TabIndex = 1
			Me.RadioButton13.TabStop = True
			Me.RadioButton13.Text = "禁 止"
			Me.RadioButton13.UseVisualStyleBackColor = True
			Me.RadioButton14.AutoSize = True
			Me.RadioButton14.Location = New Point(202, 28)
			Me.RadioButton14.Name = "RadioButton14"
			Me.RadioButton14.Size = New Size(53, 16)
			Me.RadioButton14.TabIndex = 0
			Me.RadioButton14.Text = "允 许"
			Me.RadioButton14.UseVisualStyleBackColor = True
			Me.Label11.AutoSize = True
			Me.Label11.Location = New Point(65, 120)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Size(101, 12)
			Me.Label11.TabIndex = 24
			Me.Label11.Text = "2、USB存储设备："
			Me.Label12.AutoSize = True
			Me.Label12.Location = New Point(64, 158)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Size(83, 12)
			Me.Label12.TabIndex = 25
			Me.Label12.Text = "3、杀毒软件："
			Me.Label13.AutoSize = True
			Me.Label13.Location = New Point(64, 200)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Size(95, 12)
			Me.Label13.TabIndex = 26
			Me.Label13.Text = "4、命令提示符："
			Me.Label15.AutoSize = True
			Me.Label15.Location = New Point(65, 240)
			Me.Label15.Name = "Label15"
			Me.Label15.Size = New Size(173, 12)
			Me.Label15.TabIndex = 28
			Me.Label15.Text = "5、windows键和任务栏的右键："
			Me.Label16.AutoSize = True
			Me.Label16.Location = New Point(64, 283)
			Me.Label16.Name = "Label16"
			Me.Label16.Size = New Size(197, 12)
			Me.Label16.TabIndex = 29
			Me.Label16.Text = "6、机器编号（取计算机名的后6位）"
			Me.GroupBox1.Controls.Add(Me.RadioButton1)
			Me.GroupBox1.Controls.Add(Me.RadioButton2)
			Me.GroupBox1.Location = New Point(252, 105)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Size(149, 33)
			Me.GroupBox1.TabIndex = 30
			Me.GroupBox1.TabStop = False
			Me.GroupBox2.Controls.Add(Me.RadioButton4)
			Me.GroupBox2.Controls.Add(Me.RadioButton3)
			Me.GroupBox2.Location = New Point(252, 146)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Size(150, 33)
			Me.GroupBox2.TabIndex = 31
			Me.GroupBox2.TabStop = False
			Me.GroupBox3.Controls.Add(Me.RadioButton6)
			Me.GroupBox3.Controls.Add(Me.RadioButton5)
			Me.GroupBox3.Location = New Point(252, 190)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.Size = New Size(149, 33)
			Me.GroupBox3.TabIndex = 32
			Me.GroupBox3.TabStop = False
			Me.GroupBox7.Controls.Add(Me.RadioButton12)
			Me.GroupBox7.Controls.Add(Me.RadioButton11)
			Me.GroupBox7.Location = New Point(252, 229)
			Me.GroupBox7.Name = "GroupBox7"
			Me.GroupBox7.Size = New Size(150, 33)
			Me.GroupBox7.TabIndex = 32
			Me.GroupBox7.TabStop = False
			Me.GroupBox_1.Controls.Add(Me.RadioButton10)
			Me.GroupBox_1.Controls.Add(Me.RadioButton9)
			Me.GroupBox_1.Location = New Point(252, 269)
			Me.GroupBox_1.Name = "GroupBox12"
			Me.GroupBox_1.Size = New Size(149, 33)
			Me.GroupBox_1.TabIndex = 32
			Me.GroupBox_1.TabStop = False
			Me.Label7.AutoSize = True
			Me.Label7.ForeColor = Color.Black
			Me.Label7.Location = New Point(402, 203)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Size(503, 12)
			Me.Label7.TabIndex = 35
			Me.Label7.Text = "（建议禁止，禁止后，在DEV C++运行程序时，win7只显示结果2秒，win10上可长久显示结果）"
			Me.Label5.AutoSize = True
			Me.Label5.ForeColor = Color.Black
			Me.Label5.Location = New Point(31, 721)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Size(239, 12)
			Me.Label5.TabIndex = 36
			Me.Label5.Text = "但不能禁止360等其它浏览器下载，不能禁止"
			Me.Label9.AutoSize = True
			Me.Label9.ForeColor = Color.Black
			Me.Label9.Location = New Point(34, 747)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Size(341, 12)
			Me.Label9.TabIndex = 37
			Me.Label9.Text = "浏览器，win10和win11只保留edge浏览器，最后再在这里设置。"
			Me.LinkLabel2.AutoSize = True
			Me.LinkLabel2.BackColor = Color.Transparent
			Me.LinkLabel2.LinkColor = Color.FromArgb(0, 0, 192)
			Me.LinkLabel2.Location = New Point(389, 747)
			Me.LinkLabel2.Name = "LinkLabel2"
			Me.LinkLabel2.Size = New Size(143, 12)
			Me.LinkLabel2.TabIndex = 39
			Me.LinkLabel2.TabStop = True
			Me.LinkLabel2.Text = "chrome浏览器下载地址>>>"
			Me.Label14.AutoSize = True
			Me.Label14.ForeColor = Color.Black
			Me.Label14.Location = New Point(400, 160)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Size(293, 12)
			Me.Label14.TabIndex = 40
			Me.Label14.Text = "（建议禁止，学生可用杀毒软件的""粉碎文件""等功能）"
			Me.Label3.AutoSize = True
			Me.Label3.Location = New Point(30, 696)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Size(905, 12)
			Me.Label3.TabIndex = 41
			Me.Label3.Text = "注：网上有专门软件来破解小助手，强烈建议禁止浏览器下载文件。禁止后，学生可以在浏览器中复制图片，然后粘贴。本软件可禁止chrome、edge、firfox、IE的下载，"
			Me.Label6.AutoSize = True
			Me.Label6.Location = New Point(273, 721)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Size(521, 12)
			Me.Label6.TabIndex = 42
			Me.Label6.Text = "假chrome(显示:谷歌浏览器)的小恐龙游戏，所以要先卸载一些浏览器，win7只保留google chrome"
			Me.Label17.AutoSize = True
			Me.Label17.Location = New Point(62, 653)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Size(221, 12)
			Me.Label17.TabIndex = 33
			Me.Label17.Text = "12、浏览器下载软件和设置文件夹选项："
			Me.GroupBox6.Controls.Add(Me.RadioButton8)
			Me.GroupBox6.Controls.Add(Me.RadioButton7)
			Me.GroupBox6.Location = New Point(285, 640)
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.Size = New Size(165, 33)
			Me.GroupBox6.TabIndex = 33
			Me.GroupBox6.TabStop = False
			Me.RadioButton8.AutoSize = True
			Me.RadioButton8.Checked = True
			Me.RadioButton8.Location = New Point(94, 11)
			Me.RadioButton8.Name = "RadioButton8"
			Me.RadioButton8.Size = New Size(59, 16)
			Me.RadioButton8.TabIndex = 1
			Me.RadioButton8.TabStop = True
			Me.RadioButton8.Text = "禁 止 "
			Me.RadioButton8.UseVisualStyleBackColor = True
			Me.RadioButton7.AutoSize = True
			Me.RadioButton7.Location = New Point(16, 11)
			Me.RadioButton7.Name = "RadioButton7"
			Me.RadioButton7.Size = New Size(53, 16)
			Me.RadioButton7.TabIndex = 0
			Me.RadioButton7.Text = "允 许"
			Me.RadioButton7.UseVisualStyleBackColor = True
			Me.Label18.AutoSize = True
			Me.Label18.ForeColor = Color.DarkRed
			Me.Label18.Location = New Point(453, 653)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Size(137, 12)
			Me.Label18.TabIndex = 43
			Me.Label18.Text = "（强烈建议禁止！！！）"
			Me.GroupBox8.Controls.Add(Me.RadioButton16)
			Me.GroupBox8.Controls.Add(Me.RadioButton15)
			Me.GroupBox8.Controls.Add(Me.RadioButton17)
			Me.GroupBox8.Location = New Point(255, 311)
			Me.GroupBox8.Name = "GroupBox8"
			Me.GroupBox8.Size = New Size(303, 33)
			Me.GroupBox8.TabIndex = 45
			Me.GroupBox8.TabStop = False
			Me.RadioButton16.AutoSize = True
			Me.RadioButton16.Checked = True
			Me.RadioButton16.Location = New Point(79, 13)
			Me.RadioButton16.Name = "RadioButton16"
			Me.RadioButton16.Size = New Size(143, 16)
			Me.RadioButton16.TabIndex = 53
			Me.RadioButton16.TabStop = True
			Me.RadioButton16.Text = "仅C++可生成新exe文件"
			Me.RadioButton16.UseVisualStyleBackColor = True
			Me.RadioButton15.AutoSize = True
			Me.RadioButton15.Location = New Point(5, 13)
			Me.RadioButton15.Name = "RadioButton15"
			Me.RadioButton15.Size = New Size(71, 16)
			Me.RadioButton15.TabIndex = 1
			Me.RadioButton15.Text = "全部允许"
			Me.RadioButton15.UseVisualStyleBackColor = True
			Me.RadioButton17.AutoSize = True
			Me.RadioButton17.Location = New Point(227, 13)
			Me.RadioButton17.Name = "RadioButton17"
			Me.RadioButton17.Size = New Size(71, 16)
			Me.RadioButton17.TabIndex = 0
			Me.RadioButton17.Text = "全部禁止"
			Me.RadioButton17.UseVisualStyleBackColor = True
			Me.Label19.AutoSize = True
			Me.Label19.Location = New Point(64, 326)
			Me.Label19.Name = "Label19"
			Me.Label19.Size = New Size(197, 12)
			Me.Label19.TabIndex = 44
			Me.Label19.Text = "7、新的exe、reg、bat等高危文件："
			Me.Label20.AutoSize = True
			Me.Label20.ForeColor = Color.Black
			Me.Label20.Location = New Point(559, 326)
			Me.Label20.Name = "Label20"
			Me.Label20.Size = New Size(275, 12)
			Me.Label20.TabIndex = 51
			Me.Label20.Text = "（安装软件或复制exe文件到硬盘要先退出小助手）"
			Me.Label21.AutoSize = True
			Me.Label21.ForeColor = Color.Black
			Me.Label21.Location = New Point(564, 375)
			Me.Label21.Name = "Label21"
			Me.Label21.Size = New Size(275, 12)
			Me.Label21.TabIndex = 54
			Me.Label21.Text = "（mpython、考试软件、3d one不能设为完全禁止）"
			Me.GroupBox_2.Controls.Add(Me.RadioButton19)
			Me.GroupBox_2.Controls.Add(Me.RadioButton20)
			Me.GroupBox_2.Location = New Point(255, 362)
			Me.GroupBox_2.Name = "GroupBox11"
			Me.GroupBox_2.Size = New Size(303, 33)
			Me.GroupBox_2.TabIndex = 53
			Me.GroupBox_2.TabStop = False
			Me.RadioButton19.AutoSize = True
			Me.RadioButton19.Checked = True
			Me.RadioButton19.Location = New Point(79, 13)
			Me.RadioButton19.Name = "RadioButton19"
			Me.RadioButton19.Size = New Size(125, 16)
			Me.RadioButton19.TabIndex = 53
			Me.RadioButton19.TabStop = True
			Me.RadioButton19.Text = "只监控打开regedit"
			Me.RadioButton19.UseVisualStyleBackColor = True
			Me.RadioButton20.AutoSize = True
			Me.RadioButton20.Location = New Point(227, 13)
			Me.RadioButton20.Name = "RadioButton20"
			Me.RadioButton20.Size = New Size(71, 16)
			Me.RadioButton20.TabIndex = 0
			Me.RadioButton20.Text = "完全禁止"
			Me.RadioButton20.UseVisualStyleBackColor = True
			Me.Label22.AutoSize = True
			Me.Label22.Location = New Point(62, 377)
			Me.Label22.Name = "Label22"
			Me.Label22.Size = New Size(95, 12)
			Me.Label22.TabIndex = 52
			Me.Label22.Text = "8、注册表编辑："
			Me.Label23.AutoSize = True
			Me.Label23.ForeColor = Color.Black
			Me.Label23.Location = New Point(402, 118)
			Me.Label23.Name = "Label23"
			Me.Label23.Size = New Size(503, 12)
			Me.Label23.TabIndex = 40
			Me.Label23.Text = "（如果要使用机器人等外部设备，要设为允许，你可使用电子教室控制USB存储的开放和禁止）"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(958, 787)
			MyBase.Controls.Add(Me.Label21)
			MyBase.Controls.Add(Me.GroupBox_2)
			MyBase.Controls.Add(Me.Label22)
			MyBase.Controls.Add(Me.Label20)
			MyBase.Controls.Add(Me.GroupBox8)
			MyBase.Controls.Add(Me.Label19)
			MyBase.Controls.Add(Me.Label18)
			MyBase.Controls.Add(Me.GroupBox6)
			MyBase.Controls.Add(Me.Label17)
			MyBase.Controls.Add(Me.Label6)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label23)
			MyBase.Controls.Add(Me.Label14)
			MyBase.Controls.Add(Me.LinkLabel2)
			MyBase.Controls.Add(Me.Label9)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.Label7)
			MyBase.Controls.Add(Me.Label10)
			MyBase.Controls.Add(Me.GroupBox3)
			MyBase.Controls.Add(Me.GroupBox7)
			MyBase.Controls.Add(Me.GroupBox_1)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.GroupBox1)
			MyBase.Controls.Add(Me.Label16)
			MyBase.Controls.Add(Me.Label15)
			MyBase.Controls.Add(Me.Label13)
			MyBase.Controls.Add(Me.Label12)
			MyBase.Controls.Add(Me.Label11)
			MyBase.Controls.Add(Me.GroupBox9)
			MyBase.Controls.Add(Me.GroupBox_0)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.GroupBox5)
			MyBase.Controls.Add(Me.GroupBox4)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Name = "Form1"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设 置"
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.GroupBox_0.ResumeLayout(False)
			Me.GroupBox9.ResumeLayout(False)
			Me.GroupBox9.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox7.ResumeLayout(False)
			Me.GroupBox7.PerformLayout()
			Me.GroupBox_1.ResumeLayout(False)
			Me.GroupBox_1.PerformLayout()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.GroupBox8.ResumeLayout(False)
			Me.GroupBox8.PerformLayout()
			Me.GroupBox_2.ResumeLayout(False)
			Me.GroupBox_2.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

	
		' (get) Token: 0x06000042 RID: 66 RVA: 0x00002457 File Offset: 0x00000657
		' (set) Token: 0x06000043 RID: 67 RVA: 0x00009F64 File Offset: 0x00008164
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me.m_StatusCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.ComputeContext
				Dim statusCollection As Button = Me.m_StatusCollection
				If statusCollection IsNot Nothing Then
					RemoveHandler statusCollection.Click, value2
				End If
				Me.m_StatusCollection = value
				statusCollection = Me.m_StatusCollection
				If statusCollection IsNot Nothing Then
					AddHandler statusCollection.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000044 RID: 68 RVA: 0x0000245F File Offset: 0x0000065F
		' (set) Token: 0x06000045 RID: 69 RVA: 0x00002467 File Offset: 0x00000667
		Friend Overridable Property RadioButton1 As RadioButton

	
		' (get) Token: 0x06000046 RID: 70 RVA: 0x00002470 File Offset: 0x00000670
		' (set) Token: 0x06000047 RID: 71 RVA: 0x00002478 File Offset: 0x00000678
		Friend Overridable Property RadioButton2 As RadioButton

	
		' (get) Token: 0x06000048 RID: 72 RVA: 0x00002481 File Offset: 0x00000681
		' (set) Token: 0x06000049 RID: 73 RVA: 0x00002489 File Offset: 0x00000689
		Friend Overridable Property RadioButton4 As RadioButton

	
		' (get) Token: 0x0600004A RID: 74 RVA: 0x00002492 File Offset: 0x00000692
		' (set) Token: 0x0600004B RID: 75 RVA: 0x0000249A File Offset: 0x0000069A
		Friend Overridable Property RadioButton3 As RadioButton

	
		' (get) Token: 0x0600004C RID: 76 RVA: 0x000024A3 File Offset: 0x000006A3
		' (set) Token: 0x0600004D RID: 77 RVA: 0x000024AB File Offset: 0x000006AB
		Friend Overridable Property RadioButton6 As RadioButton

	
		' (get) Token: 0x0600004E RID: 78 RVA: 0x000024B4 File Offset: 0x000006B4
		' (set) Token: 0x0600004F RID: 79 RVA: 0x000024BC File Offset: 0x000006BC
		Friend Overridable Property RadioButton5 As RadioButton

	
		' (get) Token: 0x06000050 RID: 80 RVA: 0x000024C5 File Offset: 0x000006C5
		' (set) Token: 0x06000051 RID: 81 RVA: 0x000024CD File Offset: 0x000006CD
		Friend Overridable Property OpenFileDialog1 As OpenFileDialog

	
		' (get) Token: 0x06000052 RID: 82 RVA: 0x000024D6 File Offset: 0x000006D6
		' (set) Token: 0x06000053 RID: 83 RVA: 0x00009FA8 File Offset: 0x000081A8
		Friend Overridable Property Button2 As Button
			<CompilerGenerated()>
			Get
				Return Me.attrCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.ChangeContext
				Dim button As Button = Me.attrCollection
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me.attrCollection = value
				button = Me.attrCollection
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000054 RID: 84 RVA: 0x000024DE File Offset: 0x000006DE
		' (set) Token: 0x06000055 RID: 85 RVA: 0x000024E6 File Offset: 0x000006E6
		Friend Overridable Property GroupBox4 As GroupBox

	
		' (get) Token: 0x06000056 RID: 86 RVA: 0x000024EF File Offset: 0x000006EF
		' (set) Token: 0x06000057 RID: 87 RVA: 0x000024F7 File Offset: 0x000006F7
		Friend Overridable Property Label1 As Label

	
		' (get) Token: 0x06000058 RID: 88 RVA: 0x00002500 File Offset: 0x00000700
		' (set) Token: 0x06000059 RID: 89 RVA: 0x00002508 File Offset: 0x00000708
		Friend Overridable Property TextBox1 As TextBox

	
		' (get) Token: 0x0600005A RID: 90 RVA: 0x00002511 File Offset: 0x00000711
		' (set) Token: 0x0600005B RID: 91 RVA: 0x00009FEC File Offset: 0x000081EC
		Friend Overridable Property Button3 As Button
			<CompilerGenerated()>
			Get
				Return Me.specificationCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.WriteContext
				Dim button As Button = Me.specificationCollection
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me.specificationCollection = value
				button = Me.specificationCollection
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x0600005C RID: 92 RVA: 0x00002519 File Offset: 0x00000719
		' (set) Token: 0x0600005D RID: 93 RVA: 0x00002521 File Offset: 0x00000721
		Friend Overridable Property GroupBox5 As GroupBox

	
		' (get) Token: 0x0600005E RID: 94 RVA: 0x0000252A File Offset: 0x0000072A
		' (set) Token: 0x0600005F RID: 95 RVA: 0x00002532 File Offset: 0x00000732
		Friend Overridable Property pd_new As TextBox

	
		' (get) Token: 0x06000060 RID: 96 RVA: 0x0000253B File Offset: 0x0000073B
		' (set) Token: 0x06000061 RID: 97 RVA: 0x00002543 File Offset: 0x00000743
		Friend Overridable Property Label8 As Label

	
		' (get) Token: 0x06000062 RID: 98 RVA: 0x0000254C File Offset: 0x0000074C
		' (set) Token: 0x06000063 RID: 99 RVA: 0x00002554 File Offset: 0x00000754
		Friend Overridable Property Label2 As Label

	
		' (get) Token: 0x06000064 RID: 100 RVA: 0x0000255D File Offset: 0x0000075D
		' (set) Token: 0x06000065 RID: 101 RVA: 0x00002565 File Offset: 0x00000765
		Friend Overridable Property RadioButton10 As RadioButton

	
		' (get) Token: 0x06000066 RID: 102 RVA: 0x0000256E File Offset: 0x0000076E
		' (set) Token: 0x06000067 RID: 103 RVA: 0x00002576 File Offset: 0x00000776
		Friend Overridable Property RadioButton9 As RadioButton

	
		' (get) Token: 0x06000068 RID: 104 RVA: 0x0000257F File Offset: 0x0000077F
		' (set) Token: 0x06000069 RID: 105 RVA: 0x00002587 File Offset: 0x00000787
		Friend Overridable Property Label4 As Label

	
		' (get) Token: 0x0600006A RID: 106 RVA: 0x00002590 File Offset: 0x00000790
		' (set) Token: 0x0600006B RID: 107 RVA: 0x00002598 File Offset: 0x00000798
		Friend Overridable Property Label10 As Label

	
		' (get) Token: 0x0600006C RID: 108 RVA: 0x000025A1 File Offset: 0x000007A1
		' (set) Token: 0x0600006D RID: 109 RVA: 0x000025A9 File Offset: 0x000007A9
		Friend Overridable Property RadioButton12 As RadioButton

	
		' (get) Token: 0x0600006E RID: 110 RVA: 0x000025B2 File Offset: 0x000007B2
		' (set) Token: 0x0600006F RID: 111 RVA: 0x000025BA File Offset: 0x000007BA
		Friend Overridable Property RadioButton11 As RadioButton

	
		' (get) Token: 0x06000070 RID: 112 RVA: 0x000025C3 File Offset: 0x000007C3
		' (set) Token: 0x06000071 RID: 113 RVA: 0x000025CB File Offset: 0x000007CB
		Friend Overridable Property GroupBox_0 As GroupBox

	
		' (get) Token: 0x06000072 RID: 114 RVA: 0x000025D4 File Offset: 0x000007D4
		' (set) Token: 0x06000073 RID: 115 RVA: 0x0000A030 File Offset: 0x00008230
		Friend Overridable Property Button_restorepic As Button
			<CompilerGenerated()>
			Get
				Return Me.managerCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.GetContext
				Dim button As Button = Me.managerCollection
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me.managerCollection = value
				button = Me.managerCollection
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000074 RID: 116 RVA: 0x000025DC File Offset: 0x000007DC
		' (set) Token: 0x06000075 RID: 117 RVA: 0x0000A074 File Offset: 0x00008274
		Friend Overridable Property Button_selectpic As Button
			<CompilerGenerated()>
			Get
				Return Me.m_CallbackCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.StartContext
				Dim callbackCollection As Button = Me.m_CallbackCollection
				If callbackCollection IsNot Nothing Then
					RemoveHandler callbackCollection.Click, value2
				End If
				Me.m_CallbackCollection = value
				callbackCollection = Me.m_CallbackCollection
				If callbackCollection IsNot Nothing Then
					AddHandler callbackCollection.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000076 RID: 118 RVA: 0x000025E4 File Offset: 0x000007E4
		' (set) Token: 0x06000077 RID: 119 RVA: 0x000025EC File Offset: 0x000007EC
		Friend Overridable Property GroupBox9 As GroupBox

	
		' (get) Token: 0x06000078 RID: 120 RVA: 0x000025F5 File Offset: 0x000007F5
		' (set) Token: 0x06000079 RID: 121 RVA: 0x000025FD File Offset: 0x000007FD
		Friend Overridable Property RadioButton13 As RadioButton

	
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00002606 File Offset: 0x00000806
		' (set) Token: 0x0600007B RID: 123 RVA: 0x0000260E File Offset: 0x0000080E
		Friend Overridable Property RadioButton14 As RadioButton

	
		' (get) Token: 0x0600007C RID: 124 RVA: 0x00002617 File Offset: 0x00000817
		' (set) Token: 0x0600007D RID: 125 RVA: 0x0000261F File Offset: 0x0000081F
		Friend Overridable Property Label11 As Label

	
		' (get) Token: 0x0600007E RID: 126 RVA: 0x00002628 File Offset: 0x00000828
		' (set) Token: 0x0600007F RID: 127 RVA: 0x00002630 File Offset: 0x00000830
		Friend Overridable Property Label12 As Label

	
		' (get) Token: 0x06000080 RID: 128 RVA: 0x00002639 File Offset: 0x00000839
		' (set) Token: 0x06000081 RID: 129 RVA: 0x00002641 File Offset: 0x00000841
		Friend Overridable Property Label13 As Label

	
		' (get) Token: 0x06000082 RID: 130 RVA: 0x0000264A File Offset: 0x0000084A
		' (set) Token: 0x06000083 RID: 131 RVA: 0x00002652 File Offset: 0x00000852
		Friend Overridable Property Label15 As Label

	
		' (get) Token: 0x06000084 RID: 132 RVA: 0x0000265B File Offset: 0x0000085B
		' (set) Token: 0x06000085 RID: 133 RVA: 0x00002663 File Offset: 0x00000863
		Friend Overridable Property Label16 As Label

	
		' (get) Token: 0x06000086 RID: 134 RVA: 0x0000266C File Offset: 0x0000086C
		' (set) Token: 0x06000087 RID: 135 RVA: 0x00002674 File Offset: 0x00000874
		Friend Overridable Property GroupBox1 As GroupBox

	
		' (get) Token: 0x06000088 RID: 136 RVA: 0x0000267D File Offset: 0x0000087D
		' (set) Token: 0x06000089 RID: 137 RVA: 0x00002685 File Offset: 0x00000885
		Friend Overridable Property GroupBox2 As GroupBox

	
		' (get) Token: 0x0600008A RID: 138 RVA: 0x0000268E File Offset: 0x0000088E
		' (set) Token: 0x0600008B RID: 139 RVA: 0x00002696 File Offset: 0x00000896
		Friend Overridable Property GroupBox3 As GroupBox

	
		' (get) Token: 0x0600008C RID: 140 RVA: 0x0000269F File Offset: 0x0000089F
		' (set) Token: 0x0600008D RID: 141 RVA: 0x000026A7 File Offset: 0x000008A7
		Friend Overridable Property GroupBox7 As GroupBox

	
		' (get) Token: 0x0600008E RID: 142 RVA: 0x000026B0 File Offset: 0x000008B0
		' (set) Token: 0x0600008F RID: 143 RVA: 0x000026B8 File Offset: 0x000008B8
		Friend Overridable Property GroupBox_1 As GroupBox

	
		' (get) Token: 0x06000090 RID: 144 RVA: 0x000026C1 File Offset: 0x000008C1
		' (set) Token: 0x06000091 RID: 145 RVA: 0x000026C9 File Offset: 0x000008C9
		Friend Overridable Property Label7 As Label

	
		' (get) Token: 0x06000092 RID: 146 RVA: 0x000026D2 File Offset: 0x000008D2
		' (set) Token: 0x06000093 RID: 147 RVA: 0x000026DA File Offset: 0x000008DA
		Friend Overridable Property Label5 As Label

	
		' (get) Token: 0x06000094 RID: 148 RVA: 0x000026E3 File Offset: 0x000008E3
		' (set) Token: 0x06000095 RID: 149 RVA: 0x000026EB File Offset: 0x000008EB
		Friend Overridable Property Label9 As Label

	
		' (get) Token: 0x06000096 RID: 150 RVA: 0x000026F4 File Offset: 0x000008F4
		' (set) Token: 0x06000097 RID: 151 RVA: 0x0000A0B8 File Offset: 0x000082B8
		Friend Overridable Property LinkLabel2 As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me.regCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.RestartContext
				Dim linkLabel As LinkLabel = Me.regCollection
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, value2
				End If
				Me.regCollection = value
				linkLabel = Me.regCollection
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000098 RID: 152 RVA: 0x000026FC File Offset: 0x000008FC
		' (set) Token: 0x06000099 RID: 153 RVA: 0x00002704 File Offset: 0x00000904
		Friend Overridable Property Label14 As Label

	
		' (get) Token: 0x0600009A RID: 154 RVA: 0x0000270D File Offset: 0x0000090D
		' (set) Token: 0x0600009B RID: 155 RVA: 0x00002715 File Offset: 0x00000915
		Friend Overridable Property Label3 As Label

	
		' (get) Token: 0x0600009C RID: 156 RVA: 0x0000271E File Offset: 0x0000091E
		' (set) Token: 0x0600009D RID: 157 RVA: 0x00002726 File Offset: 0x00000926
		Friend Overridable Property Label6 As Label

	
		' (get) Token: 0x0600009E RID: 158 RVA: 0x0000272F File Offset: 0x0000092F
		' (set) Token: 0x0600009F RID: 159 RVA: 0x00002737 File Offset: 0x00000937
		Friend Overridable Property Label17 As Label

	
		' (get) Token: 0x060000A0 RID: 160 RVA: 0x00002740 File Offset: 0x00000940
		' (set) Token: 0x060000A1 RID: 161 RVA: 0x00002748 File Offset: 0x00000948
		Friend Overridable Property GroupBox6 As GroupBox

	
		' (get) Token: 0x060000A2 RID: 162 RVA: 0x00002751 File Offset: 0x00000951
		' (set) Token: 0x060000A3 RID: 163 RVA: 0x00002759 File Offset: 0x00000959
		Friend Overridable Property RadioButton8 As RadioButton

	
		' (get) Token: 0x060000A4 RID: 164 RVA: 0x00002762 File Offset: 0x00000962
		' (set) Token: 0x060000A5 RID: 165 RVA: 0x0000276A File Offset: 0x0000096A
		Friend Overridable Property RadioButton7 As RadioButton

	
		' (get) Token: 0x060000A6 RID: 166 RVA: 0x00002773 File Offset: 0x00000973
		' (set) Token: 0x060000A7 RID: 167 RVA: 0x0000277B File Offset: 0x0000097B
		Friend Overridable Property Label18 As Label

	
		' (get) Token: 0x060000A8 RID: 168 RVA: 0x00002784 File Offset: 0x00000984
		' (set) Token: 0x060000A9 RID: 169 RVA: 0x0000278C File Offset: 0x0000098C
		Friend Overridable Property GroupBox8 As GroupBox

	
		' (get) Token: 0x060000AA RID: 170 RVA: 0x00002795 File Offset: 0x00000995
		' (set) Token: 0x060000AB RID: 171 RVA: 0x0000279D File Offset: 0x0000099D
		Friend Overridable Property RadioButton15 As RadioButton

	
		' (get) Token: 0x060000AC RID: 172 RVA: 0x000027A6 File Offset: 0x000009A6
		' (set) Token: 0x060000AD RID: 173 RVA: 0x000027AE File Offset: 0x000009AE
		Friend Overridable Property RadioButton17 As RadioButton

	
		' (get) Token: 0x060000AE RID: 174 RVA: 0x000027B7 File Offset: 0x000009B7
		' (set) Token: 0x060000AF RID: 175 RVA: 0x000027BF File Offset: 0x000009BF
		Friend Overridable Property Label19 As Label

	
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x000027C8 File Offset: 0x000009C8
		' (set) Token: 0x060000B1 RID: 177 RVA: 0x000027D0 File Offset: 0x000009D0
		Friend Overridable Property Label20 As Label

	
		' (get) Token: 0x060000B2 RID: 178 RVA: 0x000027D9 File Offset: 0x000009D9
		' (set) Token: 0x060000B3 RID: 179 RVA: 0x000027E1 File Offset: 0x000009E1
		Friend Overridable Property RadioButton16 As RadioButton

	
		' (get) Token: 0x060000B4 RID: 180 RVA: 0x000027EA File Offset: 0x000009EA
		' (set) Token: 0x060000B5 RID: 181 RVA: 0x000027F2 File Offset: 0x000009F2
		Friend Overridable Property Label21 As Label

	
		' (get) Token: 0x060000B6 RID: 182 RVA: 0x000027FB File Offset: 0x000009FB
		' (set) Token: 0x060000B7 RID: 183 RVA: 0x00002803 File Offset: 0x00000A03
		Friend Overridable Property GroupBox_2 As GroupBox

	
		' (get) Token: 0x060000B8 RID: 184 RVA: 0x0000280C File Offset: 0x00000A0C
		' (set) Token: 0x060000B9 RID: 185 RVA: 0x00002814 File Offset: 0x00000A14
		Friend Overridable Property RadioButton19 As RadioButton

	
		' (get) Token: 0x060000BA RID: 186 RVA: 0x0000281D File Offset: 0x00000A1D
		' (set) Token: 0x060000BB RID: 187 RVA: 0x00002825 File Offset: 0x00000A25
		Friend Overridable Property RadioButton20 As RadioButton

	
		' (get) Token: 0x060000BC RID: 188 RVA: 0x0000282E File Offset: 0x00000A2E
		' (set) Token: 0x060000BD RID: 189 RVA: 0x00002836 File Offset: 0x00000A36
		Friend Overridable Property Label22 As Label

	
		' (get) Token: 0x060000BE RID: 190 RVA: 0x0000283F File Offset: 0x00000A3F
		' (set) Token: 0x060000BF RID: 191 RVA: 0x00002847 File Offset: 0x00000A47
		Friend Overridable Property Label23 As Label

	
		Private m_PropertyCollection As String

	
		Private m_QueueCollection As String

	
		Private importerCollection As String

	
		Private m_CustomerCollection As String

	
		Private m_AuthenticationCollection As String

	
		Private templateCollection As String

	
		Private _ValueCollection As String

	
		Private orderCollection As Boolean

	
		Private Const iteratorCollection As Integer = 20

	
		Private Const configurationCollection As Integer = 1

	
		Private Const _ComparatorCollection As Integer = 2

	
		Private m_AdapterCollection As String

	
		Private m_RefCollection As String

	
		<AccessedThroughProperty("Button1")>
		<CompilerGenerated()>
		Private m_StatusCollection As Button

	
		<AccessedThroughProperty("RadioButton1")>
		<CompilerGenerated()>
		Private m_ConfigCollection As RadioButton

	
		<AccessedThroughProperty("RadioButton2")>
		<CompilerGenerated()>
		Private _InvocationCollection As RadioButton

	
		<AccessedThroughProperty("RadioButton4")>
		<CompilerGenerated()>
		Private stubCollection As RadioButton

	
		<AccessedThroughProperty("RadioButton3")>
		<CompilerGenerated()>
		Private _MapCollection As RadioButton

	
		<AccessedThroughProperty("RadioButton6")>
		<CompilerGenerated()>
		Private _MapperCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton5")>
		Private m_InterpreterCollection As RadioButton

	
		<AccessedThroughProperty("OpenFileDialog1")>
		<CompilerGenerated()>
		Private _FilterCollection As OpenFileDialog

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button2")>
		Private attrCollection As Button

	
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox4")>
		Private systemCollection As GroupBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label1")>
		Private m_RegistryCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("TextBox1")>
		Private m_RulesCollection As TextBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button3")>
		Private specificationCollection As Button

	
		<AccessedThroughProperty("GroupBox5")>
		<CompilerGenerated()>
		Private poolCollection As GroupBox

	
		<AccessedThroughProperty("pd_new")>
		<CompilerGenerated()>
		Private m_InstanceCollection As TextBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label8")>
		Private composerCollection As Label

	
		<AccessedThroughProperty("Label2")>
		<CompilerGenerated()>
		Private _IndexerCollection As Label

	
		<AccessedThroughProperty("RadioButton10")>
		<CompilerGenerated()>
		Private strategyCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton9")>
		Private _ParserCollection As RadioButton

	
		<AccessedThroughProperty("Label4")>
		<CompilerGenerated()>
		Private m_ClientCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label10")>
		Private errorCollection As Label

	
		<AccessedThroughProperty("RadioButton12")>
		<CompilerGenerated()>
		Private resolverCollection As RadioButton

	
		<AccessedThroughProperty("RadioButton11")>
		<CompilerGenerated()>
		Private _AttributeCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox10")>
		Private _DefinitionCollection As GroupBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button_restorepic")>
		Private managerCollection As Button

	
		<AccessedThroughProperty("Button_selectpic")>
		<CompilerGenerated()>
		Private m_CallbackCollection As Button

	
		<AccessedThroughProperty("GroupBox9")>
		<CompilerGenerated()>
		Private _MockCollection As GroupBox

	
		<AccessedThroughProperty("RadioButton13")>
		<CompilerGenerated()>
		Private m_TaskCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton14")>
		Private m_ContainerCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label11")>
		Private _ObserverCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label12")>
		Private _FacadeCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label13")>
		Private m_RecordCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label15")>
		Private _PrototypeCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label16")>
		Private m_WorkerCollection As Label

	
		<AccessedThroughProperty("GroupBox1")>
		<CompilerGenerated()>
		Private proccesorCollection As GroupBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox2")>
		Private m_SerializerCollection As GroupBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox3")>
		Private decoratorCollection As GroupBox

	
		<AccessedThroughProperty("GroupBox7")>
		<CompilerGenerated()>
		Private listenerCollection As GroupBox

	
		<AccessedThroughProperty("GroupBox12")>
		<CompilerGenerated()>
		Private annotationCollection As GroupBox

	
		<AccessedThroughProperty("Label7")>
		<CompilerGenerated()>
		Private m_TagCollection As Label

	
		<AccessedThroughProperty("Label5")>
		<CompilerGenerated()>
		Private m_ExporterCollection As Label

	
		<AccessedThroughProperty("Label9")>
		<CompilerGenerated()>
		Private merchantCollection As Label

	
		<AccessedThroughProperty("LinkLabel2")>
		<CompilerGenerated()>
		Private regCollection As LinkLabel

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label14")>
		Private _StateCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label3")>
		Private itemCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label6")>
		Private m_FieldCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label17")>
		Private m_TestsCollection As Label

	
		<AccessedThroughProperty("GroupBox6")>
		<CompilerGenerated()>
		Private _WatcherCollection As GroupBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton8")>
		Private m_ModelCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton7")>
		Private _UtilsCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label18")>
		Private valCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox8")>
		Private m_BaseCollection As GroupBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton15")>
		Private m_CodeCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton17")>
		Private m_AdvisorCollection As RadioButton

	
		<AccessedThroughProperty("Label19")>
		<CompilerGenerated()>
		Private m_ProxyCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label20")>
		Private m_VisitorCollection As Label

	
		<AccessedThroughProperty("RadioButton16")>
		<CompilerGenerated()>
		Private _PrinterCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label21")>
		Private _TokenizerCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox11")>
		Private _GetterCollection As GroupBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton19")>
		Private tokenCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton20")>
		Private producerCollection As RadioButton

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label22")>
		Private _BridgeCollection As Label

	
		<AccessedThroughProperty("Label23")>
		<CompilerGenerated()>
		Private _DatabaseCollection As Label

	
		Public Enum WallpaperStyle
		
			Tiled = 1
		
			Centered
		
			Stretched = 6
		End Enum

	
		Public Structure RECT
		
			Public Left As Integer

		
			Public Top As Integer

		
			Public Right As Integer

		
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
