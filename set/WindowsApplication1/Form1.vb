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
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000028 RID: 40 RVA: 0x00002C3C File Offset: 0x00000E3C
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

		' Token: 0x06000029 RID: 41
		Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (int_0 As Integer, int_1 As Integer, string_0 As String, int_2 As Integer) As Boolean

		' Token: 0x0600002A RID: 42
		Private Declare Ansi Function BlockInput Lib "user32" (long_0 As Long) As Object

		' Token: 0x0600002B RID: 43
		Private Declare Ansi Sub Sleep Lib "kernel32" (long_0 As Long)

		' Token: 0x0600002C RID: 44
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form1.RECT) As Integer

		' Token: 0x0600002D RID: 45 RVA: 0x00002CDC File Offset: 0x00000EDC
		Private Sub OrderContext(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim left As String = ""
				IL_11:
				num2 = 3
				Me.m_AdapterCollection = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "dzjs", ""))
				IL_37:
				num2 = 4
				If Operators.CompareString(Me.m_AdapterCollection, "", False) = 0 Then
					GoTo IL_64
				End If
				IL_4C:
				num2 = 5
				Me.TextBox1.Text = Me.m_AdapterCollection
				GoTo IL_FE
				IL_64:
				num2 = 7
				Me.m_AdapterCollection = Me.GetProcessPathsByName("studentMain")
				IL_77:
				num2 = 8
				If Operators.CompareString(Me.m_AdapterCollection, "", False) <> 0 Then
					GoTo IL_A0
				End If
				IL_8C:
				num2 = 9
				Me.m_AdapterCollection = Me.GetProcessPathsByName("ClassMangerApp")
				IL_A0:
				num2 = 10
				If Operators.CompareString(Me.m_AdapterCollection, "", False) <> 0 Then
					GoTo IL_CA
				End If
				IL_B6:
				num2 = 11
				Me.m_AdapterCollection = Me.GetProcessPathsByName("REDAgent")
				IL_CA:
				num2 = 12
				If Operators.CompareString(Me.m_AdapterCollection, "", False) = 0 Then
					GoTo IL_FE
				End If
				IL_E0:
				num2 = 13
				Me.TextBox1.Text = "自动获得文件路径是：" + Me.m_AdapterCollection
				IL_FE:
				num2 = 14
				Me.m_RefCollection = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
				IL_125:
				num2 = 15
				If Operators.CompareString(Me.m_RefCollection, "off", False) <> 0 Then
					GoTo IL_14C
				End If
				IL_13B:
				num2 = 16
				Me.RadioButton1.Checked = True
				GoTo IL_15B
				IL_14C:
				num2 = 18
				Me.RadioButton2.Checked = True
				IL_15B:
				num2 = 19
				Dim left2 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", ""))
				IL_17E:
				num2 = 20
				If Operators.CompareString(left2, "off", False) <> 0 Then
					GoTo IL_1A1
				End If
				IL_190:
				num2 = 21
				Me.RadioButton3.Checked = True
				GoTo IL_1B0
				IL_1A1:
				num2 = 23
				Me.RadioButton4.Checked = True
				IL_1B0:
				num2 = 24
				Dim left3 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", ""))
				IL_1D3:
				num2 = 25
				If Operators.CompareString(left3, "off", False) <> 0 Then
					GoTo IL_1F6
				End If
				IL_1E5:
				num2 = 26
				Me.RadioButton5.Checked = True
				GoTo IL_205
				IL_1F6:
				num2 = 28
				Me.RadioButton6.Checked = True
				IL_205:
				num2 = 29
				Dim left4 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "win_jian", ""))
				IL_228:
				num2 = 30
				If Operators.CompareString(left4, "on", False) <> 0 Then
					GoTo IL_24B
				End If
				IL_23A:
				num2 = 31
				Me.RadioButton11.Checked = True
				GoTo IL_25A
				IL_24B:
				num2 = 33
				Me.RadioButton12.Checked = True
				IL_25A:
				num2 = 34
				left = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "games_jianche", ""))
				IL_27D:
				num2 = 35
				If Operators.CompareString(left, "off", False) <> 0 Then
					GoTo IL_2A0
				End If
				IL_28F:
				num2 = 36
				Me.RadioButton14.Checked = True
				GoTo IL_2AF
				IL_2A0:
				num2 = 38
				Me.RadioButton13.Checked = True
				IL_2AF:
				num2 = 39
				Dim left5 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "bianhao", ""))
				IL_2D1:
				num2 = 40
				If Operators.CompareString(left5, "off", False) <> 0 Then
					GoTo IL_2F3
				End If
				IL_2E2:
				num2 = 41
				Me.RadioButton10.Checked = True
				GoTo IL_302
				IL_2F3:
				num2 = 43
				Me.RadioButton9.Checked = True
				IL_302:
				num2 = 44
				Dim left6 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "xiazai", ""))
				IL_325:
				num2 = 45
				If Operators.CompareString(left6, "on", False) <> 0 Then
					GoTo IL_348
				End If
				IL_337:
				num2 = 46
				Me.RadioButton7.Checked = True
				GoTo IL_357
				IL_348:
				num2 = 48
				Me.RadioButton8.Checked = True
				IL_357:
				num2 = 49
				Dim num3 As Integer = Conversions.ToInteger(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 2))
				IL_37B:
				num2 = 50
				If num3 <> 1 Then
					GoTo IL_394
				End If
				IL_383:
				num2 = 51
				Me.RadioButton15.Checked = True
				GoTo IL_3C3
				IL_394:
				num2 = 53
				If num3 <> 2 Then
					GoTo IL_3AD
				End If
				IL_39C:
				num2 = 54
				Me.RadioButton16.Checked = True
				GoTo IL_3C3
				IL_3AD:
				num2 = 56
				If num3 <> 0 Then
					GoTo IL_3C3
				End If
				IL_3B4:
				num2 = 57
				Me.RadioButton17.Checked = True
				IL_3C3:
				num2 = 58
				Dim num4 As Integer = Conversions.ToInteger(MessageCollection.VisitContext(Registry.CurrentUser, "Software\jfglzs", "zcb", 2))
				IL_3E6:
				num2 = 59
				If num4 <> 2 Then
					GoTo IL_3FE
				End If
				IL_3ED:
				num2 = 60
				Me.RadioButton19.Checked = True
				GoTo IL_413
				IL_3FE:
				num2 = 62
				If num4 <> 0 Then
					GoTo IL_413
				End If
				IL_404:
				num2 = 63
				Me.RadioButton20.Checked = True
				IL_413:
				GoTo IL_569
				IL_418:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_528:
				GoTo IL_55E
				IL_52A:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_53B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_52A
			End Try
			IL_55E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_569:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600002E RID: 46 RVA: 0x00002436 File Offset: 0x00000636
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub InsertContext(sender As Object, e As FormClosingEventArgs)
			ProjectData.EndApp()
		End Sub

		' Token: 0x0600002F RID: 47 RVA: 0x00003278 File Offset: 0x00001478
		Private Sub ChangeContext(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Me.OpenFileDialog1.ShowDialog()
				IL_16:
				num2 = 3
				Dim fileName As String = Me.OpenFileDialog1.FileName
				IL_24:
				num2 = 4
				Dim fileName2 As String = Path.GetFileName(fileName)
				IL_2D:
				num2 = 5
				Path.GetDirectoryName(fileName)
				IL_36:
				num2 = 6
				Path.GetExtension(fileName)
				IL_3F:
				num2 = 7
				If Not Me.FlushContext(Strings.Replace(fileName2, ".exe", "", 1, -1, CompareMethod.Binary)) Then
					GoTo IL_8A
				End If
				IL_5C:
				num2 = 8
				Me.TextBox1.Text = Me.OpenFileDialog1.FileName
				IL_74:
				num2 = 9
				Me.m_AdapterCollection = Me.OpenFileDialog1.FileName
				GoTo IL_9A
				IL_8A:
				num2 = 11
				Interaction.MsgBox("你所选的文件并没有运行，请重新选择或先运行电子教室！", MsgBoxStyle.OkOnly, Nothing)
				IL_9A:
				GoTo IL_120
				IL_9F:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_DF:
				GoTo IL_115
				IL_E1:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E1
			End Try
			IL_115:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_120:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x000033C0 File Offset: 0x000015C0
		Private Sub ComputeContext(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.m_AdapterCollection, "", False) <> 0 Then
					GoTo IL_34
				End If
				IL_1D:
				num2 = 3
				Me.Label2.Text = "选择学生端程序文件!"
				GoTo IL_14F
				IL_34:
				num2 = 5
				If Strings.Len(Me.pd_new.Text) >= 6 Then
					GoTo IL_60
				End If
				IL_49:
				num2 = 6
				Me.Label2.Text = "密码应该是6位或以上的字母或数字，请重新输入！"
				GoTo IL_14F
				IL_60:
				num2 = 8
				If Operators.CompareString(Me.pd_new.Text, "123456", False) <> 0 Then
					GoTo IL_92
				End If
				IL_7A:
				num2 = 9
				Me.Label2.Text = "密码太简单，请重新输入！"
				GoTo IL_14F
				IL_92:
				num2 = 11
				Me.Label2.Text = ""
				IL_A5:
				num2 = 12
				Me.Button1.Enabled = False
				IL_B4:
				num2 = 13
				If File.Exists(Me.m_PropertyCollection) Then
					GoTo IL_D8
				End If
				IL_C4:
				num2 = 14
				File.Copy("hosts", Me.m_PropertyCollection, True)
				IL_D8:
				num2 = 15
				If File.Exists(Me.m_QueueCollection) Then
					GoTo IL_FD
				End If
				IL_E8:
				num2 = 16
				File.Copy(Me.m_PropertyCollection, Me.m_QueueCollection, True)
				IL_FD:
				num2 = 17
				Me.PublishContext(Application.StartupPath + "/hmd_local.txt", "on")
				IL_11A:
				num2 = 18
				Me.PublishContext("http://" + Me.m_CustomerCollection + "/hmd_net.txt", "on")
				IL_13D:
				num2 = 19
				Me.ResolveContext()
				IL_146:
				num2 = 20
				Me.DefineContext()
				IL_14F:
				GoTo IL_1F4
				IL_154:
				GoTo IL_1FE
				IL_159:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_1CF
				IL_16B:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_1CF:
				GoTo IL_1FE
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_159
			End Try
			IL_1F4:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_1FE:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x06000031 RID: 49 RVA: 0x000035F4 File Offset: 0x000017F4
		Private Sub DefineContext()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim num3 As Integer = Marshal.SizeOf(IntPtr.Zero) * 8
				IL_1C:
				num2 = 3
				Me.Cursor = Cursors.WaitCursor
				IL_29:
				num2 = 4
				Dim registryKey As RegistryKey = CandidateCollection.PrintContext.Registry.CurrentUser
				IL_3B:
				num2 = 5
				Dim registryKey2 As RegistryKey = registryKey.OpenSubKey("Software\jfglzs")
				IL_49:
				num2 = 6
				If registryKey2 IsNot Nothing Then
					GoTo IL_5C
				End If
				IL_4E:
				num2 = 7
				registryKey2 = registryKey.CreateSubKey("Software\jfglzs")
				IL_5C:
				num2 = 8
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "dzjs", Me.m_AdapterCollection, 1)
				IL_79:
				num2 = 9
				If Not Me.RadioButton1.Checked Then
					GoTo IL_A6
				End If
				IL_89:
				num2 = 10
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", "off", 1)
				IL_A6:
				num2 = 11
				If Not Me.RadioButton2.Checked Then
					GoTo IL_D3
				End If
				IL_B6:
				num2 = 12
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", "on", 1)
				IL_D3:
				num2 = 13
				If Not Me.RadioButton3.Checked Then
					GoTo IL_100
				End If
				IL_E3:
				num2 = 14
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", "off", 1)
				IL_100:
				num2 = 15
				If Not Me.RadioButton4.Checked Then
					GoTo IL_12D
				End If
				IL_110:
				num2 = 16
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", "on", 1)
				IL_12D:
				num2 = 17
				If Not Me.RadioButton5.Checked Then
					GoTo IL_15A
				End If
				IL_13D:
				num2 = 18
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", "off", 1)
				IL_15A:
				num2 = 19
				If Not Me.RadioButton6.Checked Then
					GoTo IL_187
				End If
				IL_16A:
				num2 = 20
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", "on", 1)
				IL_187:
				num2 = 21
				If Not Me.RadioButton11.Checked Then
					GoTo IL_1B4
				End If
				IL_197:
				num2 = 22
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "win_jian", "on", 1)
				IL_1B4:
				num2 = 23
				If Not Me.RadioButton12.Checked Then
					GoTo IL_1E1
				End If
				IL_1C4:
				num2 = 24
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "win_jian", "off", 1)
				IL_1E1:
				num2 = 25
				If Not Me.RadioButton9.Checked Then
					GoTo IL_20E
				End If
				IL_1F1:
				num2 = 26
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "bianhao", "on", 1)
				IL_20E:
				num2 = 27
				If Not Me.RadioButton10.Checked Then
					GoTo IL_23B
				End If
				IL_21E:
				num2 = 28
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "bianhao", "off", 1)
				IL_23B:
				num2 = 29
				If Not Me.RadioButton13.Checked Then
					GoTo IL_268
				End If
				IL_24B:
				num2 = 30
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "games_jianche", "on", 1)
				IL_268:
				num2 = 31
				If Not Me.RadioButton14.Checked Then
					GoTo IL_295
				End If
				IL_278:
				num2 = 32
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "games_jianche", "off", 1)
				IL_295:
				num2 = 33
				If Not Me.RadioButton7.Checked Then
					GoTo IL_2C2
				End If
				IL_2A5:
				num2 = 34
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "xiazai", "on", 1)
				IL_2C2:
				num2 = 35
				If Not Me.RadioButton8.Checked Then
					GoTo IL_2EF
				End If
				IL_2D2:
				num2 = 36
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "xiazai", "off", 1)
				IL_2EF:
				num2 = 37
				If Not Me.RadioButton15.Checked Then
					GoTo IL_31D
				End If
				IL_2FF:
				num2 = 38
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 1, 4)
				IL_31D:
				num2 = 39
				If Not Me.RadioButton16.Checked Then
					GoTo IL_34B
				End If
				IL_32D:
				num2 = 40
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 2, 4)
				IL_34B:
				num2 = 41
				If Not Me.RadioButton17.Checked Then
					GoTo IL_379
				End If
				IL_35B:
				num2 = 42
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "gaowei", 0, 4)
				IL_379:
				num2 = 43
				If Not Me.RadioButton19.Checked Then
					GoTo IL_3A7
				End If
				IL_389:
				num2 = 44
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "zcb", 2, 4)
				IL_3A7:
				num2 = 45
				If Not Me.RadioButton20.Checked Then
					GoTo IL_3D5
				End If
				IL_3B7:
				num2 = 46
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "zcb", 0, 4)
				IL_3D5:
				num2 = 47
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\jfglzs", "zhuye", Me.m_CustomerCollection, 1)
				IL_3F3:
				num2 = 48
				Dim text As String = Me.m_AdapterCollection + "2"
				IL_408:
				num2 = 49
				File.Copy(Me.m_AdapterCollection, text, True)
				IL_419:
				num2 = 50
				Dim adapterCollection As String = Me.m_AdapterCollection
				IL_424:
				num2 = 51
				Dim str As String = Strings.Mid(adapterCollection, 1, Strings.Len(adapterCollection) - 16)
				IL_43B:
				num2 = 52
				File.SetAttributes(str + "\SpecialSet.exe", File.GetAttributes(str + "\SpecialSet.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_464:
				num2 = 53
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_482:
				num2 = 54
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, 4)
				IL_4A0:
				num2 = 55
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 0, 4)
				IL_4BE:
				num2 = 56
				Interaction.Shell("sc delete zmserv", AppWinStyle.Hide, True, -1)
				IL_4CF:
				num2 = 57
				Dim object_ As String = MessageCollection.TestContext(Strings.Trim(Me.pd_new.Text))
				IL_4E9:
				num2 = 58
				Interaction.Shell(Application.StartupPath + "\regini.exe " + Application.StartupPath + "\regqx.ini", AppWinStyle.Hide, True, -1)
				IL_50E:
				num2 = 59
				Thread.Sleep(1000)
				IL_51B:
				num2 = 60
				File.Copy(Application.StartupPath + "\yl.wav", Application.StartupPath + "\yl.reg", True)
				IL_542:
				num2 = 61
				Interaction.Shell("regedit.exe /s " + Application.StartupPath + "\yl.reg", AppWinStyle.Hide, True, -1)
				IL_562:
				num2 = 62
				Thread.Sleep(1000)
				IL_56F:
				num2 = 63
				If Not Me.RadioButton1.Checked Then
					GoTo IL_5F7
				End If
				IL_57F:
				num2 = 64
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 3, 4)
				IL_59D:
				num2 = 65
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 3, 4)
				IL_5BB:
				num2 = 66
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 3, 4)
				IL_5D9:
				num2 = 67
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 3, 4)
				IL_5F7:
				num2 = 68
				If Not Me.RadioButton2.Checked Then
					GoTo IL_67F
				End If
				IL_607:
				num2 = 69
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 4, 4)
				IL_625:
				num2 = 70
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 4, 4)
				IL_643:
				num2 = 71
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 4, 4)
				IL_661:
				num2 = 72
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 4, 4)
				IL_67F:
				num2 = 73
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", Application.StartupPath + "\przs.exe", 1)
				IL_6A6:
				num2 = 74
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", Application.StartupPath + "\jfglzsn.exe", 1)
				IL_6CD:
				num2 = 75
				Thread.Sleep(1000)
				IL_6DA:
				num2 = 76
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", Application.StartupPath + "\przs.exe", 1)
				IL_701:
				num2 = 77
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", Application.StartupPath + "\jfglzsn.exe", 1)
				IL_728:
				num2 = 78
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", 0, 4)
				IL_746:
				num2 = 79
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\PublicProfile", "EnableFirewall", 0, 4)
				IL_764:
				num2 = 80
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\DomainProfile\PublicProfile", "EnableFirewall", 0, 4)
				IL_782:
				num2 = 81
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableLockWorkstation", 1, 4)
				IL_7A0:
				num2 = 82
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				IL_7B3:
				num2 = 83
				registryKey.DeleteSubKeyTree("SYSTEM\CurrentControlSet\Control\SafeBoot\Network")
				IL_7C1:
				num2 = 84
				Interaction.Shell("cmd /c bcdedit /set {bootmgr} displaybootmenu no", AppWinStyle.MinimizedFocus, False, -1)
				IL_7D2:
				num2 = 85
				Interaction.Shell("cmd /c bcdedit /delete {ee888888-8888-8888-8888-8888888888ee}", AppWinStyle.MinimizedFocus, False, -1)
				IL_7E3:
				num2 = 86
				Me.PushContext()
				IL_7EC:
				num2 = 87
				If Not Me.FillContext(Me.m_CustomerCollection, 5000) Then
					GoTo IL_80B
				End If
				IL_802:
				num2 = 88
				Me.CreateContext()
				IL_80B:
				num2 = 89
				Interaction.Shell(Application.StartupPath + "\regini.exe " + Application.StartupPath + "\regqxoff.ini", AppWinStyle.Hide, True, -1)
				IL_830:
				num2 = 90
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "n", object_, 1)
				IL_84A:
				num2 = 91
				Dim str2 As String = Application.StartupPath + "\zmserv.exe"
				IL_85E:
				num2 = 92
				Interaction.Shell("sc create zmserv binPath= " + str2 + " start= auto", AppWinStyle.Hide, True, -1)
				IL_87B:
				num2 = 93
				Interaction.Shell("sc failure zmserv actions= ""reboot/60000/reboot/60000/reboot/60000"" reset= 300 ", AppWinStyle.Hide, True, -1)
				IL_88C:
				num2 = 94
				Thread.Sleep(1000)
				IL_899:
				num2 = 95
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				IL_8AC:
				num2 = 96
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Google")
				IL_8BB:
				num2 = 97
				If registryKey2 IsNot Nothing Then
					GoTo IL_8D0
				End If
				IL_8C1:
				num2 = 98
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Google")
				IL_8D0:
				num2 = 99
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Google\Chrome")
				IL_8DF:
				num2 = 100
				If registryKey2 IsNot Nothing Then
					GoTo IL_8F4
				End If
				IL_8E5:
				num2 = 101
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Google\Chrome")
				IL_8F4:
				num2 = 102
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				IL_907:
				num2 = 103
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Microsoft")
				IL_916:
				num2 = 104
				If registryKey2 IsNot Nothing Then
					GoTo IL_92B
				End If
				IL_91C:
				num2 = 105
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Microsoft")
				IL_92B:
				num2 = 106
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Microsoft\Edge")
				IL_93A:
				num2 = 107
				If registryKey2 IsNot Nothing Then
					GoTo IL_94F
				End If
				IL_940:
				num2 = 108
				registryKey2 = registryKey.CreateSubKey("Software\Policies\Microsoft\Edge")
				IL_94F:
				num2 = 109
				If Not Me.RadioButton13.Checked Then
					GoTo IL_99B
				End If
				IL_95F:
				num2 = 110
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", 0, 4)
				IL_97D:
				num2 = 111
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", 0, 4)
				IL_99B:
				num2 = 112
				If Not Me.RadioButton14.Checked Then
					GoTo IL_AC7
				End If
				IL_9AE:
				num2 = 113
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "AllowDinosaurEasterEgg", 1, 4)
				IL_9CC:
				num2 = 114
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "AllowSurfGame", 1, 4)
				IL_9EA:
				num2 = 115
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				IL_9FD:
				num2 = 116
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\sidebar.exe")
				IL_A0B:
				num2 = 117
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Chess.exe")
				IL_A19:
				num2 = 118
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\FreeCell.exe")
				IL_A27:
				num2 = 119
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Hearts.exe")
				IL_A35:
				num2 = 120
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Minesweeper.exe")
				IL_A43:
				num2 = 121
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				IL_A51:
				num2 = 122
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Mahjong.exe")
				IL_A5F:
				num2 = 123
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\SpiderSolitaire.exe")
				IL_A6D:
				num2 = 124
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\bckgzm.exe")
				IL_A7B:
				num2 = 125
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\chkrzm.exe")
				IL_A89:
				num2 = 126
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\shvlzm.exe")
				IL_A97:
				num2 = 127
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Solitaire.exe")
				IL_AA5:
				num2 = 128
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winmine")
				IL_AB6:
				num2 = 129
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				IL_AC7:
				num2 = 130
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "WebWidgetAllowed", 0, 4)
				IL_AE8:
				num2 = 131
				MessageCollection.RemoveContext(Registry.CurrentUser, "Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", 0, 4)
				IL_B09:
				num2 = 132
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\WindowsStore", "RemoveWindowsStore", 1, 4)
				IL_B2A:
				num2 = 133
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton", 0, 4)
				IL_B4B:
				num2 = 134
				MessageCollection.ListContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer", "DesktopProcess")
				IL_B65:
				num2 = 135
				MessageCollection.RemoveContext(Registry.CurrentUser, "Control Panel\Desktop", "AutoEndTasks", 1, 4)
				IL_B86:
				num2 = 136
				If Not Me.RadioButton11.Checked Then
					GoTo IL_C17
				End If
				IL_B99:
				num2 = 137
				File.Copy(Application.StartupPath + "\huifu.wav", Application.StartupPath + "\huifu.reg", True)
				IL_BC3:
				num2 = 138
				Interaction.Shell("regedit.exe /s " + Application.StartupPath + "\huifu.reg", AppWinStyle.Hide, True, -1)
				IL_BE6:
				num2 = 139
				Thread.Sleep(1000)
				IL_BF6:
				num2 = 140
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayContextMenu", 0, 4)
				IL_C17:
				num2 = 141
				If Not Me.RadioButton8.Checked Then
					GoTo IL_DCF
				End If
				IL_C2D:
				num2 = 142
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				IL_C43:
				num2 = 143
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 3, 4)
				IL_C64:
				num2 = 144
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 1, 4)
				IL_C85:
				num2 = 145
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 1, 4)
				IL_CA6:
				num2 = 146
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 3, 4)
				IL_CC7:
				num2 = 147
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 0, 4)
				IL_CE8:
				num2 = 148
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 2, 4)
				IL_D09:
				num2 = 149
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 3, 4)
				IL_D2A:
				num2 = 150
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 0, 4)
				IL_D4B:
				num2 = 151
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 2, 4)
				IL_D6C:
				num2 = 152
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 1, 4)
				IL_D8D:
				num2 = 153
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 1, 4)
				IL_DAE:
				num2 = 154
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 2, 4)
				IL_DCF:
				num2 = 155
				If Not Me.RadioButton7.Checked Then
					GoTo IL_F87
				End If
				IL_DE5:
				num2 = 156
				registryKey = CandidateCollection.PrintContext.Registry.LocalMachine
				IL_DFB:
				num2 = 157
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 0, 4)
				IL_E1C:
				num2 = 158
				MessageCollection.RemoveContext(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 0, 4)
				IL_E3D:
				num2 = 159
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 0, 4)
				IL_E5E:
				num2 = 160
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 0, 4)
				IL_E7F:
				num2 = 161
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 1, 4)
				IL_EA0:
				num2 = 162
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 0, 4)
				IL_EC1:
				num2 = 163
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 0, 4)
				IL_EE2:
				num2 = 164
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 1, 4)
				IL_F03:
				num2 = 165
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 0, 4)
				IL_F24:
				num2 = 166
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 0, 4)
				IL_F45:
				num2 = 167
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 0, 4)
				IL_F66:
				num2 = 168
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 0, 4)
				IL_F87:
				num2 = 169
				Thread.Sleep(1000)
				IL_F97:
				num2 = 170
				File.SetAttributes(Me.m_PropertyCollection, File.GetAttributes(Me.m_PropertyCollection) Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				IL_FB9:
				num2 = 171
				File.SetAttributes("C:\Windows\System32\drivers\etc", File.GetAttributes("C:\Windows\System32\drivers\etc") Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				IL_FD9:
				num2 = 172
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 0, 4)
				IL_FFA:
				num2 = 173
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", 0, 4)
				IL_101B:
				num2 = 174
				MessageCollection.RemoveContext(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\Hidden\SHOWALL", "CheckedValue", 0, 4)
				IL_103C:
				num2 = 175
				If Not Me.RadioButton8.Checked Then
					GoTo IL_1070
				End If
				IL_104F:
				num2 = 176
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFolderOptions", 1, 4)
				IL_1070:
				num2 = 177
				If Not Me.RadioButton7.Checked Then
					GoTo IL_10A4
				End If
				IL_1083:
				num2 = 178
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFolderOptions", 0, 4)
				IL_10A4:
				num2 = 179
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", 1, 4)
				IL_10C5:
				num2 = 180
				If Not Me.RadioButton20.Checked Then
					GoTo IL_113C
				End If
				IL_10D8:
				num2 = 181
				registryKey = CandidateCollection.PrintContext.Registry.CurrentUser
				IL_10EE:
				num2 = 182
				registryKey2 = registryKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
				IL_1100:
				num2 = 183
				If registryKey2 IsNot Nothing Then
					GoTo IL_111B
				End If
				IL_1109:
				num2 = 184
				registryKey2 = registryKey.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
				IL_111B:
				num2 = 185
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, 4)
				IL_113C:
				num2 = 186
				If Not Me.RadioButton19.Checked Then
					GoTo IL_1170
				End If
				IL_114F:
				num2 = 187
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, 4)
				IL_1170:
				num2 = 188
				File.SetAttributes("C:\Program Files\Microsoft Games", File.GetAttributes("C:\Program Files\Microsoft Games") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_118E:
				num2 = 189
				MessageCollection.RemoveContext(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters", "DisabledComponents", 255, 4)
				IL_11B3:
				num2 = 190
				Directory.CreateDirectory(Me.importerCollection)
				IL_11C5:
				num2 = 191
				File.Copy(Application.StartupPath + "\jfglzsn.exe", Me.importerCollection + "\jfglzsn.dat", True)
				IL_11F0:
				num2 = 192
				File.Copy(Application.StartupPath + "\przs.exe", Me.importerCollection + "\przs.dat", True)
				IL_121B:
				num2 = 193
				File.Copy(Application.StartupPath + "\zmserv.exe", Me.importerCollection + "\zmserv.dat", True)
				IL_1246:
				num2 = 194
				File.SetAttributes(Me.importerCollection, File.GetAttributes(Me.importerCollection) Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1266:
				num2 = 195
				File.SetAttributes(Me.importerCollection + "\jfglzsn.dat", File.GetAttributes(Me.importerCollection + "\jfglzsn.dat") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_129A:
				num2 = 196
				File.SetAttributes(Me.importerCollection + "\przs.dat", File.GetAttributes(Me.importerCollection + "\przs.dat") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_12CE:
				num2 = 197
				File.SetAttributes(Me.importerCollection + "\zmserv.dat", File.GetAttributes(Me.importerCollection + "\zmserv.dat") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1302:
				num2 = 198
				File.SetAttributes(Application.StartupPath + "\jfglzsn.exe", File.GetAttributes(Application.StartupPath + "\jfglzsn.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1334:
				num2 = 199
				File.SetAttributes(Application.StartupPath + "\zmserv.exe", File.GetAttributes(Application.StartupPath + "\zmserv.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1366:
				num2 = 200
				File.SetAttributes(Application.StartupPath + "\przs.exe", File.GetAttributes(Application.StartupPath + "\przs.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1398:
				num2 = 201
				File.SetAttributes(Application.StartupPath + "\set.exe", File.GetAttributes(Application.StartupPath + "\set.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_13CA:
				num2 = 202
				File.SetAttributes(Application.StartupPath + "\uninstall.exe", File.GetAttributes(Application.StartupPath + "\uninstall.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_13FC:
				num2 = 203
				File.SetAttributes(Application.StartupPath + "\about.exe", File.GetAttributes(Application.StartupPath + "\about.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_142E:
				num2 = 204
				File.SetAttributes(Application.StartupPath + "\yl.wav", File.GetAttributes(Application.StartupPath + "\yl.wav") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1460:
				num2 = 205
				File.SetAttributes(Application.StartupPath + "\huifu.wav", File.GetAttributes(Application.StartupPath + "\huifu.wav") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1492:
				num2 = 206
				File.SetAttributes(Application.StartupPath + "\hmd_local.txt", File.GetAttributes(Application.StartupPath + "\hmd_local.txt") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_14C4:
				num2 = 207
				File.SetAttributes(Application.StartupPath + "\regini.exe", File.GetAttributes(Application.StartupPath + "\regini.exe") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_14F6:
				num2 = 208
				File.SetAttributes(Application.StartupPath, File.GetAttributes(Application.StartupPath) Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1514:
				num2 = 209
				File.SetAttributes("C:\Windows\Microsoft.NET", File.GetAttributes("C:\Windows\Microsoft.NET") Or FileAttributes.Hidden Or FileAttributes.System)
				IL_1532:
				num2 = 210
				File.Delete(Application.StartupPath + "\yl.reg")
				IL_154C:
				num2 = 211
				File.Delete(Application.StartupPath + "\huifu.reg")
				IL_1566:
				num2 = 212
				Thread.Sleep(2000)
				IL_1576:
				num2 = 213
				Me.Cursor = Cursors.[Default]
				IL_1587:
				num2 = 214
				For Each process As Process In Process.GetProcessesByName("explorer")
					IL_15A5:
					num2 = 215
					process.Kill()
					IL_15B2:
					num2 = 216
				Next
				IL_15C6:
				num2 = 217
				Process.Start("explorer.exe")
				IL_15D7:
				num2 = 218
				CandidateCollection.PrepareContext.Form3.Show()
				IL_15EC:
				GoTo IL_19AE
				IL_15F1:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_196D:
				GoTo IL_19A3
				IL_196F:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1980:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_196F
			End Try
			IL_19A3:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_19AE:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x00004FD4 File Offset: 0x000031D4
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub PushContext()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim str As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\Internet Explorer\Quick Launch"
				IL_1D:
				num2 = 3
				Microsoft.VisualBasic.FileSystem.Kill(str + "\*.*")
				IL_30:
				num2 = 4
				File.Copy(Application.StartupPath + "\zy\Internet   Explore.lnk", str + "\Internet   Explore.lnk", True)
				IL_53:
				num2 = 5
				Dim str2 As String = str + "\User Pinned\TaskBar"
				IL_63:
				num2 = 6
				Microsoft.VisualBasic.FileSystem.Kill(str2 + "\*.*")
				IL_76:
				num2 = 7
				File.Copy(Application.StartupPath + "\zy\Internet   Explore.lnk", str2 + "\Internet   Explore.lnk", True)
				IL_99:
				num2 = 8
				Dim str3 As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Favorites", ""))
				IL_BA:
				num2 = 9
				Dim str4 As String = str3 + "\links"
				IL_C9:
				num2 = 10
				Dim str5 As String = str3 + "\links"
				IL_D9:
				num2 = 11
				Microsoft.VisualBasic.FileSystem.Kill(str4 + "\*.*")
				IL_EC:
				num2 = 12
				Microsoft.VisualBasic.FileSystem.Kill(str5 + "\*.*")
				IL_100:
				num2 = 13
				File.Copy(Application.StartupPath + "\zy\百度搜索&网址导航.url", str4 + "\百度搜索&网址导航.url", True)
				IL_123:
				num2 = 14
				File.Copy(Application.StartupPath + "\zy\百度搜索&网址导航.url", str4 + "\百度搜索&网址导航.url", True)
				IL_146:
				num2 = 15
				Dim currentUser As RegistryKey = CandidateCollection.PrintContext.Registry.CurrentUser
				IL_15A:
				num2 = 16
				Dim registryKey As RegistryKey = currentUser.OpenSubKey("Software\Microsoft\Internet Explorer\LinksBar", True)
				IL_16C:
				num2 = 17
				If registryKey IsNot Nothing Then
					GoTo IL_184
				End If
				IL_173:
				num2 = 18
				registryKey = currentUser.CreateSubKey("Software\Microsoft\Internet Explorer\LinksBar")
				IL_184:
				num2 = 19
				registryKey.SetValue("Enabled", 1)
				IL_199:
				GoTo IL_23F
				IL_19E:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1FE:
				GoTo IL_234
				IL_200:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_211:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_200
			End Try
			IL_234:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_23F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000033 RID: 51 RVA: 0x00005248 File Offset: 0x00003448
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub CreateContext()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				IL_0D:
				num2 = 3
				Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
				IL_18:
				num2 = 4
				Dim enumerator As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(folderPath, SearchOption.SearchTopLevelOnly, New String() { "*.exe" }).GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_55:
					num2 = 5
					If Strings.InStr(text, "360安全浏览器", CompareMethod.Binary) > 0 Then
						IL_66:
						num2 = 6
						num3 += 1
						IL_6E:
						num2 = 7
						File.SetAttributes(text, FileAttributes.Normal)
						IL_7B:
						num2 = 8
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", folderPath + "\360安全浏览器.exe", True)
					Else
						IL_A3:
						num2 = 10
						If Strings.InStr(text, "Google Chrome", CompareMethod.Binary) > 0 Then
							IL_B5:
							num2 = 11
							num3 += 1
							IL_BE:
							num2 = 12
							File.SetAttributes(text, FileAttributes.Normal)
							IL_CC:
							num2 = 13
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", folderPath + "\Google Chrome.exe", True)
						Else
							IL_F5:
							num2 = 15
							If Strings.InStr(text, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								IL_107:
								num2 = 16
								num3 += 1
								IL_110:
								num2 = 17
								File.SetAttributes(text, FileAttributes.Normal)
								IL_11E:
								num2 = 18
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", folderPath + "\2345加速浏览器.exe", True)
							Else
								IL_147:
								num2 = 20
								If Strings.InStr(text, "360极速浏览器", CompareMethod.Binary) > 0 Then
									IL_159:
									num2 = 21
									num3 += 1
									IL_162:
									num2 = 22
									File.SetAttributes(text, FileAttributes.Normal)
									IL_170:
									num2 = 23
									File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", folderPath + "\360极速浏览器.exe", True)
								Else
									IL_199:
									num2 = 25
									If Strings.InStr(text, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
										IL_1AB:
										num2 = 26
										num3 += 1
										IL_1B4:
										num2 = 27
										File.SetAttributes(text, FileAttributes.Normal)
										IL_1C2:
										num2 = 28
										File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", folderPath + "\360 极速浏览器X.exe", True)
									Else
										IL_1EB:
										num2 = 30
										If Strings.InStr(text, "QQ浏览器", CompareMethod.Binary) > 0 Then
											IL_1FD:
											num2 = 31
											num3 += 1
											IL_206:
											num2 = 32
											File.SetAttributes(text, FileAttributes.Normal)
											IL_214:
											num2 = 33
											File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", folderPath + "\QQ浏览器.exe", True)
										Else
											IL_23D:
											num2 = 35
											If Strings.InStr(text, "极速浏览器", CompareMethod.Binary) > 0 Then
												IL_24F:
												num2 = 36
												num3 += 1
												IL_258:
												num2 = 37
												File.SetAttributes(text, FileAttributes.Normal)
												IL_266:
												num2 = 38
												File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", folderPath + "\极速浏览器.exe", True)
											Else
												IL_28F:
												num2 = 40
												If Strings.InStr(text, "双核浏览器", CompareMethod.Binary) > 0 Then
													IL_2A1:
													num2 = 41
													num3 += 1
													IL_2AA:
													num2 = 42
													File.SetAttributes(text, FileAttributes.Normal)
													IL_2B8:
													num2 = 43
													File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", folderPath + "\双核浏览器.exe", True)
												Else
													IL_2E1:
													num2 = 45
													If Strings.InStr(text, "Firefox", CompareMethod.Binary) > 0 Then
														IL_2F3:
														num2 = 46
														num3 += 1
														IL_2FC:
														num2 = 47
														File.SetAttributes(text, FileAttributes.Normal)
														IL_30A:
														num2 = 48
														File.Copy(Application.StartupPath + "\zy\Firefox.exe", folderPath + "\Firefox.exe", True)
													Else
														IL_333:
														num2 = 50
														If Strings.InStr(text, "谷歌浏览器", CompareMethod.Binary) > 0 Then
															IL_345:
															num2 = 51
															Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
															IL_355:
															num2 = 52
															File.SetAttributes(text, FileAttributes.Normal)
															IL_363:
															num2 = 53
															Microsoft.VisualBasic.FileSystem.Kill(text)
														Else
															IL_36E:
															num2 = 55
															If Strings.InStr(text, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																IL_380:
																num2 = 56
																num3 += 1
																IL_389:
																num2 = 57
																File.SetAttributes(text, FileAttributes.Normal)
																IL_397:
																num2 = 58
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
					IL_3BB:
					num2 = 59
				End While
				IL_3C3:
				num2 = 60
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_3D1:
				num2 = 61
				Dim text2 As String = "C:\Users\Public\Desktop"
				IL_3DB:
				num2 = 62
				Dim enumerator2 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(text2, SearchOption.SearchTopLevelOnly, New String() { "*.exe" }).GetEnumerator()
				While enumerator2.MoveNext()
					Dim text3 As String = enumerator2.Current
					IL_41A:
					num2 = 63
					If Strings.InStr(text3, "360安全浏览器", CompareMethod.Binary) > 0 Then
						IL_42D:
						num2 = 64
						num3 += 1
						IL_436:
						num2 = 65
						File.SetAttributes(text3, FileAttributes.Normal)
						IL_445:
						num2 = 66
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", text2 + "\360安全浏览器.exe", True)
					Else
						IL_46E:
						num2 = 68
						If Strings.InStr(text3, "Google Chrome", CompareMethod.Binary) > 0 Then
							IL_481:
							num2 = 69
							num3 += 1
							IL_48A:
							num2 = 70
							File.SetAttributes(text3, FileAttributes.Normal)
							IL_499:
							num2 = 71
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", text2 + "\Google Chrome.exe", True)
						Else
							IL_4C2:
							num2 = 73
							If Strings.InStr(text3, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								IL_4D5:
								num2 = 74
								num3 += 1
								IL_4DE:
								num2 = 75
								File.SetAttributes(text3, FileAttributes.Normal)
								IL_4ED:
								num2 = 76
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", text2 + "\2345加速浏览器.exe", True)
							Else
								IL_516:
								num2 = 78
								If Strings.InStr(text3, "360极速浏览器", CompareMethod.Binary) > 0 Then
									IL_529:
									num2 = 79
									num3 += 1
									IL_532:
									num2 = 80
									File.SetAttributes(text3, FileAttributes.Normal)
									IL_541:
									num2 = 81
									File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", text2 + "\360极速浏览器.exe", True)
								Else
									IL_56A:
									num2 = 83
									If Strings.InStr(text3, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
										IL_57D:
										num2 = 84
										num3 += 1
										IL_586:
										num2 = 85
										File.SetAttributes(text3, FileAttributes.Normal)
										IL_595:
										num2 = 86
										File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", text2 + "\360 极速浏览器X.exe", True)
									Else
										IL_5BE:
										num2 = 88
										If Strings.InStr(text3, "QQ浏览器", CompareMethod.Binary) > 0 Then
											IL_5D1:
											num2 = 89
											num3 += 1
											IL_5DA:
											num2 = 90
											File.SetAttributes(text3, FileAttributes.Normal)
											IL_5E9:
											num2 = 91
											File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", text2 + "\QQ浏览器.exe", True)
										Else
											IL_612:
											num2 = 93
											If Strings.InStr(text3, "极速浏览器", CompareMethod.Binary) > 0 Then
												IL_625:
												num2 = 94
												num3 += 1
												IL_62E:
												num2 = 95
												File.SetAttributes(text3, FileAttributes.Normal)
												IL_63D:
												num2 = 96
												File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", text2 + "\极速浏览器.exe", True)
											Else
												IL_666:
												num2 = 98
												If Strings.InStr(text3, "双核浏览器", CompareMethod.Binary) > 0 Then
													IL_679:
													num2 = 99
													num3 += 1
													IL_682:
													num2 = 100
													File.SetAttributes(text3, FileAttributes.Normal)
													IL_691:
													num2 = 101
													File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", text2 + "\双核浏览器.exe", True)
												Else
													IL_6BA:
													num2 = 103
													If Strings.InStr(text3, "Firefox", CompareMethod.Binary) > 0 Then
														IL_6CD:
														num2 = 104
														num3 += 1
														IL_6D6:
														num2 = 105
														File.SetAttributes(text3, FileAttributes.Normal)
														IL_6E5:
														num2 = 106
														File.Copy(Application.StartupPath + "\zy\Firefox.exe", text2 + "\Firefox.exe", True)
													Else
														IL_70E:
														num2 = 108
														If Strings.InStr(text3, "谷歌浏览器", CompareMethod.Binary) > 0 Then
															IL_721:
															num2 = 109
															Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
															IL_731:
															num2 = 110
															File.SetAttributes(text3, FileAttributes.Normal)
															IL_740:
															num2 = 111
															Microsoft.VisualBasic.FileSystem.Kill(text3)
														Else
															IL_74C:
															num2 = 113
															If Strings.InStr(text3, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																IL_75F:
																num2 = 114
																num3 += 1
																IL_768:
																num2 = 115
																File.SetAttributes(text3, FileAttributes.Normal)
																IL_777:
																num2 = 116
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
					IL_79B:
					num2 = 117
				End While
				IL_7A3:
				num2 = 118
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_7B1:
				num2 = 119
				Dim enumerator3 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(folderPath, SearchOption.SearchTopLevelOnly, New String() { "*.lnk" }).GetEnumerator()
				While enumerator3.MoveNext()
					Dim text4 As String = enumerator3.Current
					IL_7EF:
					num2 = 120
					If Strings.InStr(text4, "360安全浏览器", CompareMethod.Binary) > 0 Then
						IL_801:
						num2 = 121
						Dim text5 As String = Me.ReadShortCut(text4)
						IL_80D:
						num2 = 122
						MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360", text5, 1)
						IL_827:
						num2 = 123
						File.SetAttributes(text4, FileAttributes.Normal)
						IL_835:
						num2 = 124
						Microsoft.VisualBasic.FileSystem.Kill(text4)
						IL_83E:
						num2 = 125
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", folderPath + "\360安全浏览器.exe", True)
						IL_862:
						num2 = 126
						num3 += 1
					Else
						IL_870:
						num2 = 128
						If Strings.InStr(text4, "Google Chrome", CompareMethod.Binary) > 0 Then
							IL_888:
							num2 = 129
							Dim text5 As String = Me.ReadShortCut(text4)
							IL_897:
							num2 = 130
							MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "chrome", text5, 1)
							IL_8B4:
							num2 = 131
							File.SetAttributes(text4, FileAttributes.Normal)
							IL_8C5:
							num2 = 132
							Microsoft.VisualBasic.FileSystem.Kill(text4)
							IL_8D1:
							num2 = 133
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", folderPath + "\Google Chrome.exe", True)
							IL_8F8:
							num2 = 134
							num3 += 1
						Else
							IL_909:
							num2 = 136
							If Strings.InStr(text4, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								IL_921:
								num2 = 137
								Dim text5 As String = Me.ReadShortCut(text4)
								IL_930:
								num2 = 138
								MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "2345", text5, 1)
								IL_94D:
								num2 = 139
								File.SetAttributes(text4, FileAttributes.Normal)
								IL_95E:
								num2 = 140
								Microsoft.VisualBasic.FileSystem.Kill(text4)
								IL_96A:
								num2 = 141
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", folderPath + "\2345加速浏览器.exe", True)
								IL_991:
								num2 = 142
								num3 += 1
							Else
								IL_9A2:
								num2 = 144
								If Strings.InStr(text4, "Firefox", CompareMethod.Binary) > 0 Or Strings.InStr(text4, "firefox", CompareMethod.Binary) > 0 Then
									IL_9CC:
									num2 = 145
									Dim text5 As String = Me.ReadShortCut(text4)
									IL_9DB:
									num2 = 146
									MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "firefox", text5, 1)
									IL_9F8:
									num2 = 147
									File.SetAttributes(text4, FileAttributes.Normal)
									IL_A09:
									num2 = 148
									Microsoft.VisualBasic.FileSystem.Kill(text4)
									IL_A15:
									num2 = 149
									File.Copy(Application.StartupPath + "\zy\Firefox.exe", folderPath + "\Firefox.exe", True)
									IL_A3C:
									num2 = 150
									num3 += 1
								Else
									IL_A4D:
									num2 = 152
									If Strings.InStr(text4, "360极速浏览器", CompareMethod.Binary) > 0 Then
										IL_A65:
										num2 = 153
										Dim text5 As String = Me.ReadShortCut(text4)
										IL_A74:
										num2 = 154
										MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360js", text5, 1)
										IL_A91:
										num2 = 155
										File.SetAttributes(text4, FileAttributes.Normal)
										IL_AA2:
										num2 = 156
										Microsoft.VisualBasic.FileSystem.Kill(text4)
										IL_AAE:
										num2 = 157
										File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", folderPath + "\360极速浏览器.exe", True)
										IL_AD5:
										num2 = 158
										num3 += 1
									Else
										IL_AE6:
										num2 = 160
										If Strings.InStr(text4, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
											IL_AFE:
											num2 = 161
											Dim text5 As String = Me.ReadShortCut(text4)
											IL_B0D:
											num2 = 162
											MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360jsx", text5, 1)
											IL_B2A:
											num2 = 163
											File.SetAttributes(text4, FileAttributes.Normal)
											IL_B3B:
											num2 = 164
											Microsoft.VisualBasic.FileSystem.Kill(text4)
											IL_B47:
											num2 = 165
											File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", folderPath + "\360 极速浏览器X.exe", True)
											IL_B6E:
											num2 = 166
											num3 += 1
										Else
											IL_B7F:
											num2 = 168
											If Strings.InStr(text4, "QQ浏览器", CompareMethod.Binary) > 0 Then
												IL_B97:
												num2 = 169
												Dim text5 As String = Me.ReadShortCut(text4)
												IL_BA6:
												num2 = 170
												MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "qq", text5, 1)
												IL_BC3:
												num2 = 171
												File.SetAttributes(text4, FileAttributes.Normal)
												IL_BD4:
												num2 = 172
												Microsoft.VisualBasic.FileSystem.Kill(text4)
												IL_BE0:
												num2 = 173
												File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", folderPath + "\QQ浏览器.exe", True)
												IL_C07:
												num2 = 174
												num3 += 1
											Else
												IL_C18:
												num2 = 176
												If Strings.InStr(text4, "极速浏览器", CompareMethod.Binary) > 0 Then
													IL_C30:
													num2 = 177
													Dim text5 As String = Me.ReadShortCut(text4)
													IL_C3F:
													num2 = 178
													MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "jisu", text5, 1)
													IL_C5C:
													num2 = 179
													File.SetAttributes(text4, FileAttributes.Normal)
													IL_C6D:
													num2 = 180
													Microsoft.VisualBasic.FileSystem.Kill(text4)
													IL_C79:
													num2 = 181
													File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", folderPath + "\极速浏览器.exe", True)
													IL_CA0:
													num2 = 182
													num3 += 1
												Else
													IL_CB1:
													num2 = 184
													If Strings.InStr(text4, "双核浏览器", CompareMethod.Binary) > 0 Then
														IL_CC9:
														num2 = 185
														Dim text5 As String = Me.ReadShortCut(text4)
														IL_CD8:
														num2 = 186
														MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "shuanghe", text5, 1)
														IL_CF5:
														num2 = 187
														File.SetAttributes(text4, FileAttributes.Normal)
														IL_D06:
														num2 = 188
														Microsoft.VisualBasic.FileSystem.Kill(text4)
														IL_D12:
														num2 = 189
														File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", folderPath + "\双核浏览器.exe", True)
														IL_D39:
														num2 = 190
														num3 += 1
													Else
														IL_D4A:
														num2 = 192
														If Strings.InStr(text4, "谷歌浏览器", CompareMethod.Binary) > 0 Then
															IL_D5F:
															num2 = 193
															Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
															IL_D72:
															num2 = 194
															Microsoft.VisualBasic.FileSystem.Kill(text4)
														Else
															IL_D83:
															num2 = 196
															If Strings.InStr(text4, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																IL_D9B:
																num2 = 197
																Dim text5 As String = Me.ReadShortCut(text4)
																IL_DAA:
																num2 = 198
																File.SetAttributes(text4, FileAttributes.Normal)
																IL_DBB:
																num2 = 199
																Microsoft.VisualBasic.FileSystem.Kill(text4)
																IL_DC7:
																num2 = 200
																If Strings.InStr(text5, ".exe", CompareMethod.Binary) > 0 Then
																	IL_DDD:
																	num2 = 201
																	MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "edge", text5, 1)
																	IL_DFA:
																	num2 = 202
																	File.Copy(Application.StartupPath + "\zy\Microsoft Edge.exe", folderPath + "\Microsoft Edge.exe", True)
																	IL_E21:
																	num2 = 203
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
					IL_E2D:
					num2 = 204
				End While
				IL_E38:
				num2 = 205
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_E49:
				num2 = 206
				Dim enumerator4 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(text2, SearchOption.SearchTopLevelOnly, New String() { "*.lnk" }).GetEnumerator()
				While enumerator4.MoveNext()
					Dim text6 As String = enumerator4.Current
					IL_E8B:
					num2 = 207
					If Strings.InStr(text6, "360安全浏览器", CompareMethod.Binary) > 0 Then
						IL_EA4:
						num2 = 208
						Dim text5 As String = Me.ReadShortCut(text6)
						IL_EB4:
						num2 = 209
						MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360", text5, 1)
						IL_ED1:
						num2 = 210
						File.SetAttributes(text6, FileAttributes.Normal)
						IL_EE3:
						num2 = 211
						Microsoft.VisualBasic.FileSystem.Kill(text6)
						IL_EF0:
						num2 = 212
						File.Copy(Application.StartupPath + "\zy\360安全浏览器.exe", text2 + "\360安全浏览器.exe", True)
						IL_F17:
						num2 = 213
						num3 += 1
					Else
						IL_F28:
						num2 = 215
						If Strings.InStr(text6, "Google Chrome", CompareMethod.Binary) > 0 Then
							IL_F41:
							num2 = 216
							Dim text5 As String = Me.ReadShortCut(text6)
							IL_F51:
							num2 = 217
							MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "chrome", text5, 1)
							IL_F6E:
							num2 = 218
							File.SetAttributes(text6, FileAttributes.Normal)
							IL_F80:
							num2 = 219
							Microsoft.VisualBasic.FileSystem.Kill(text6)
							IL_F8D:
							num2 = 220
							File.Copy(Application.StartupPath + "\zy\Google Chrome.exe", text2 + "\Google Chrome.exe", True)
							IL_FB4:
							num2 = 221
							num3 += 1
						Else
							IL_FC5:
							num2 = 223
							If Strings.InStr(text6, "2345加速浏览器", CompareMethod.Binary) > 0 Then
								IL_FDE:
								num2 = 224
								Dim text5 As String = Me.ReadShortCut(text6)
								IL_FEE:
								num2 = 225
								MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "2345", text5, 1)
								IL_100B:
								num2 = 226
								File.SetAttributes(text6, FileAttributes.Normal)
								IL_101D:
								num2 = 227
								Microsoft.VisualBasic.FileSystem.Kill(text6)
								IL_102A:
								num2 = 228
								File.Copy(Application.StartupPath + "\zy\2345加速浏览器.exe", text2 + "\2345加速浏览器.exe", True)
								IL_1051:
								num2 = 229
								num3 += 1
							Else
								IL_1062:
								num2 = 231
								If Strings.InStr(text6, "Firefox", CompareMethod.Binary) > 0 Or Strings.InStr(text6, "firefox", CompareMethod.Binary) > 0 Then
									IL_108E:
									num2 = 232
									Dim text5 As String = Me.ReadShortCut(text6)
									IL_109E:
									num2 = 233
									MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "firefox", text5, 1)
									IL_10BB:
									num2 = 234
									File.SetAttributes(text6, FileAttributes.Normal)
									IL_10CD:
									num2 = 235
									Microsoft.VisualBasic.FileSystem.Kill(text6)
									IL_10DA:
									num2 = 236
									File.Copy(Application.StartupPath + "\zy\Firefox.exe", text2 + "\Firefox.exe", True)
									IL_1101:
									num2 = 237
									num3 += 1
								Else
									IL_1112:
									num2 = 239
									If Strings.InStr(text6, "360极速浏览器", CompareMethod.Binary) > 0 Then
										IL_112B:
										num2 = 240
										Dim text5 As String = Me.ReadShortCut(text6)
										IL_113B:
										num2 = 241
										MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360js", text5, 1)
										IL_1158:
										num2 = 242
										File.SetAttributes(text6, FileAttributes.Normal)
										IL_116A:
										num2 = 243
										Microsoft.VisualBasic.FileSystem.Kill(text6)
										IL_1177:
										num2 = 244
										File.Copy(Application.StartupPath + "\zy\360极速浏览器.exe", text2 + "\360极速浏览器.exe", True)
										IL_119E:
										num2 = 245
										num3 += 1
									Else
										IL_11AF:
										num2 = 247
										If Strings.InStr(text6, "360 极速浏览器X", CompareMethod.Binary) > 0 Then
											IL_11C8:
											num2 = 248
											Dim text5 As String = Me.ReadShortCut(text6)
											IL_11D8:
											num2 = 249
											MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "360jsx", text5, 1)
											IL_11F5:
											num2 = 250
											File.SetAttributes(text6, FileAttributes.Normal)
											IL_1207:
											num2 = 251
											Microsoft.VisualBasic.FileSystem.Kill(text6)
											IL_1214:
											num2 = 252
											File.Copy(Application.StartupPath + "\zy\360 极速浏览器X.exe", text2 + "\360 极速浏览器X.exe", True)
											IL_123B:
											num2 = 253
											num3 += 1
										Else
											IL_124C:
											num2 = 255
											If Strings.InStr(text6, "QQ浏览器", CompareMethod.Binary) > 0 Then
												IL_1265:
												num2 = 256
												Dim text5 As String = Me.ReadShortCut(text6)
												IL_1275:
												num2 = 257
												MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "qq", text5, 1)
												IL_1292:
												num2 = 258
												File.SetAttributes(text6, FileAttributes.Normal)
												IL_12A4:
												num2 = 259
												Microsoft.VisualBasic.FileSystem.Kill(text6)
												IL_12B1:
												num2 = 260
												File.Copy(Application.StartupPath + "\zy\QQ浏览器.exe", text2 + "\QQ浏览器.exe", True)
												IL_12D8:
												num2 = 261
												num3 += 1
											Else
												IL_12E9:
												num2 = 263
												If Strings.InStr(text6, "谷歌浏览器", CompareMethod.Binary) > 0 Then
													IL_12FF:
													num2 = 264
													Interaction.MsgBox("删除桌面上假google chrome的快捷方式，win7先下载安装正版google chrome再重新设置。", MsgBoxStyle.OkOnly, Nothing)
													IL_1312:
													num2 = 265
													Microsoft.VisualBasic.FileSystem.Kill(text6)
												Else
													IL_1324:
													num2 = 267
													If Strings.InStr(text6, "极速浏览器", CompareMethod.Binary) > 0 Then
														IL_133D:
														num2 = 268
														Dim text5 As String = Me.ReadShortCut(text6)
														IL_134D:
														num2 = 269
														MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "jisu", text5, 1)
														IL_136A:
														num2 = 270
														File.SetAttributes(text6, FileAttributes.Normal)
														IL_137C:
														num2 = 271
														Microsoft.VisualBasic.FileSystem.Kill(text6)
														IL_1389:
														num2 = 272
														File.Copy(Application.StartupPath + "\zy\极速浏览器.exe", text2 + "\极速浏览器.exe", True)
														IL_13B0:
														num2 = 273
														num3 += 1
													Else
														IL_13C1:
														num2 = 275
														If Strings.InStr(text6, "双核浏览器", CompareMethod.Binary) > 0 Then
															IL_13DA:
															num2 = 276
															Dim text5 As String = Me.ReadShortCut(text6)
															IL_13EA:
															num2 = 277
															MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "shuanghe", text5, 1)
															IL_1407:
															num2 = 278
															File.SetAttributes(text6, FileAttributes.Normal)
															IL_1419:
															num2 = 279
															Microsoft.VisualBasic.FileSystem.Kill(text6)
															IL_1426:
															num2 = 280
															File.Copy(Application.StartupPath + "\zy\双核浏览器.exe", text2 + "\双核浏览器.exe", True)
															IL_144D:
															num2 = 281
															num3 += 1
														Else
															IL_145E:
															num2 = 283
															If Strings.InStr(text6, "Microsoft Edge", CompareMethod.Binary) > 0 Then
																IL_1477:
																num2 = 284
																Dim text5 As String = Me.ReadShortCut(text6)
																IL_1487:
																num2 = 285
																File.SetAttributes(text6, FileAttributes.Normal)
																IL_1499:
																num2 = 286
																Microsoft.VisualBasic.FileSystem.Kill(text6)
																IL_14A6:
																num2 = 287
																If Strings.InStr(text5, ".exe", CompareMethod.Binary) > 0 Then
																	IL_14BC:
																	num2 = 288
																	MessageCollection.RemoveContext(Registry.CurrentUser, "Software", "edge", text5, 1)
																	IL_14D9:
																	num2 = 289
																	File.Copy(Application.StartupPath + "\zy\Microsoft Edge.exe", text2 + "\Microsoft Edge.exe", True)
																	IL_1500:
																	num2 = 290
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
					IL_150C:
					num2 = 291
				End While
				IL_1517:
				num2 = 292
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
				IL_1528:
				num2 = 293
				If num3 <> 0 Then
					GoTo IL_1559
				End If
				IL_1532:
				num2 = 294
				File.Copy(Application.StartupPath + "\zy\百度搜索&网址导航.url", folderPath + "\百度搜索&网址导航.url", True)
				IL_1559:
				num2 = 295
				Dim enumerator5 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(folderPath, SearchOption.SearchTopLevelOnly, New String() { "*.lnk" }).GetEnumerator()
				While enumerator5.MoveNext()
					Dim text7 As String = enumerator5.Current
					IL_1591:
					num2 = 296
					If Strings.InStr(text7, "网址导航", CompareMethod.Binary) > 0 Or Strings.InStr(text7, "上网导航", CompareMethod.Binary) > 0 Or Strings.InStr(text7, "百度一下", CompareMethod.Binary) > 0 Then
						IL_15CB:
						num2 = 297
						Microsoft.VisualBasic.FileSystem.Kill(text7)
					End If
					IL_15D8:
					num2 = 298
				End While
				IL_15E7:
				num2 = 299
				If enumerator5 IsNot Nothing Then
					enumerator5.Dispose()
				End If
				IL_15F8:
				num2 = 300
				Dim enumerator6 As IEnumerator(Of String) = CandidateCollection.PrintContext.FileSystem.GetFiles(Application.StartupPath + "\zy\", SearchOption.SearchAllSubDirectories, New String() { "*.*" }).GetEnumerator()
				While enumerator6.MoveNext()
					Dim file As String = enumerator6.Current
					IL_163D:
					num2 = 301
					CandidateCollection.PrintContext.FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing)
					IL_1657:
					num2 = 302
				End While
				IL_1666:
				num2 = 303
				If enumerator6 IsNot Nothing Then
					enumerator6.Dispose()
				End If
				IL_1677:
				GoTo IL_1B8D
				IL_167C:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_1B4C:
				GoTo IL_1B82
				IL_1B4E:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1B5F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1B4E
			End Try
			IL_1B82:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1B8D:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000034 RID: 52 RVA: 0x00006E08 File Offset: 0x00005008
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

		' Token: 0x06000035 RID: 53 RVA: 0x0000243D File Offset: 0x0000063D
		Private Sub WriteContext(sender As Object, e As EventArgs)
			Process.Start("http://www.jfglzs.com/software/bangzhu.htm")
		End Sub

		' Token: 0x06000036 RID: 54 RVA: 0x00006EAC File Offset: 0x000050AC
		Private Sub ResolveContext()
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim text As String = "zmserv"
				IL_12:
				num2 = 3
				IL_15:
				num2 = 4
				Dim text2 As String = Conversions.ToString(MessageCollection.m_InfoCollection)
				IL_24:
				num2 = 5
				Dim text3 As String = "jfglzsn"
				Dim processesByName As Process()
				Dim processesByName2 As Process()
				Do
					IL_78:
					num2 = 7
					IL_30:
					num2 = 8
					processesByName = Process.GetProcessesByName(text2)
					IL_3C:
					num2 = 9
					processesByName(0).Kill()
					IL_49:
					num2 = 10
					processesByName2 = Process.GetProcessesByName(text3)
					IL_56:
					num2 = 11
					processesByName2(0).Kill()
					IL_63:
					num2 = 12
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				IL_7D:
				num2 = 15
				Dim num3 As Integer = 10
				IL_85:
				num2 = 16
				num3 = num3 * 10 + 2
				IL_92:
				num2 = 17
				For Each process As Process In Process.GetProcesses()
					IL_AC:
					num2 = 18
					Dim num4 As Integer = Strings.Len(process.ProcessName)
					IL_BE:
					num2 = 19
					If num4 >= 4 Then
						IL_C7:
						num2 = 21
						Dim num5 As Integer = num4
						Dim j As Integer = 1
						While j <= num5
							IL_D4:
							num2 = 22
							Dim num6 As Integer = Strings.Asc(Strings.Mid(process.ProcessName, j, 1))
							IL_EE:
							num2 = 23
							If num6 >= num3 Then
								IL_F8:
								num2 = 25
								If num6 <= num3 + 9 Then
									IL_105:
									num2 = 27
									j += 1
									Continue While
								End If
							End If
							IL_12F:
							num2 = 28
							If j = num4 + 1 Then
								IL_117:
								num2 = 29
								process.Kill()
								GoTo IL_122
							End If
							GoTo IL_122
						End While
						GoTo IL_12F
					End If
					IL_122:
					num2 = 30
				Next
				IL_13D:
				num2 = 31
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_15C:
				num2 = 32
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_16E:
				num2 = 33
				Thread.Sleep(1000)
				IL_17C:
				num2 = 34
				Dim processesByName3 As Process() = Process.GetProcessesByName(text)
				IL_189:
				num2 = 35
				processesByName3(0).Kill()
				IL_196:
				num2 = 36
				Dim lpRect As Form1.RECT
				lpRect.Left = 0
				IL_1A2:
				num2 = 37
				lpRect.Top = 0
				IL_1AE:
				num2 = 38
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				IL_1CC:
				num2 = 39
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				IL_1EA:
				num2 = 40
				Form1.ClipCursor(lpRect)
				IL_1F6:
				GoTo IL_2ED
				IL_1FB:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_2AD:
				GoTo IL_2E2
				IL_2AF:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2C0:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2AF
			End Try
			IL_2E2:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2ED:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x000071CC File Offset: 0x000053CC
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

		' Token: 0x06000038 RID: 56 RVA: 0x00007278 File Offset: 0x00005478
		Private Sub GetContext(sender As Object, e As EventArgs)
			Dim string_ As String = "C:\Windows\Web\Wallpaper\Windows\img0.jpg"
			Try
				Me.LogoutContext(string_, Form1.WallpaperStyle.Stretched)
			Catch ex As Exception
				MessageBox.Show("设置失败: {ex.Message}")
			End Try
		End Sub

		' Token: 0x06000039 RID: 57 RVA: 0x000072C0 File Offset: 0x000054C0
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

		' Token: 0x0600003A RID: 58 RVA: 0x0000733C File Offset: 0x0000553C
		Private Sub CustomizeContext(string_0 As String)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim text As String = "127.0.0.1"
				IL_10:
				num2 = 3
				Dim text2 As String = File.ReadAllText(Me.m_PropertyCollection)
				IL_1E:
				num2 = 4
				If text2.Contains(text + " " + string_0) Then
					GoTo IL_6C
				End If
				IL_34:
				num2 = 5
				text2 = String.Concat(New String() { text2, Environment.NewLine, text, " ", string_0 })
				IL_5E:
				num2 = 6
				File.WriteAllText(Me.m_PropertyCollection, text2)
				IL_6C:
				GoTo IL_DB
				IL_6E:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_9A:
				GoTo IL_D0
				IL_9C:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_AD:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_9C
			End Try
			IL_D0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_DB:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x00007440 File Offset: 0x00005640
		Public Function GetProcessPathsByName(processName As String) As String
			Dim num As Integer
			Dim result As String
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim text As String = ""
				IL_10:
				num2 = 3
				Dim processesByName As Process() = Process.GetProcessesByName(processName)
				IL_1A:
				num2 = 4
				For Each process As Process In processesByName
					IL_2A:
					num2 = 5
					text = process.MainModule.FileName
					IL_39:
					num2 = 6
				Next
				IL_48:
				num2 = 7
				result = text
				IL_4D:
				GoTo IL_C0
				IL_4F:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_7F:
				GoTo IL_B5
				IL_81:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_92:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_81
			End Try
			IL_B5:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_C0:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0600003C RID: 60 RVA: 0x0000244A File Offset: 0x0000064A
		Private Sub RestartContext(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("https://www.jfglzs.com/c16.html")
		End Sub

		' Token: 0x0600003D RID: 61 RVA: 0x00007528 File Offset: 0x00005728
		Private Sub PublishContext(string_0 As String, string_1 As String)
			Dim num As Integer
			Dim num11 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				IL_0C:
				num2 = 3
				If Me.FillContext("223.5.5.5", 1500) Then
					GoTo IL_2E
				End If
				IL_20:
				num2 = 4
				Me.orderCollection = False
				GoTo IL_39A
				IL_2E:
				num2 = 6
				Dim tempFileName As String = Path.GetTempFileName()
				IL_36:
				num2 = 7
				Using webClient As WebClient = New WebClient()
					webClient.DownloadFile(string_0, tempFileName)
				End Using
				IL_56:
				num2 = 8
				Dim array As String() = File.ReadAllLines(tempFileName)
				IL_60:
				num2 = 9
				If Strings.InStr(array(0), "www.", CompareMethod.Binary) <> 0 Then
					GoTo IL_83
				End If
				IL_74:
				num2 = 10
				Me.orderCollection = False
				GoTo IL_39A
				IL_83:
				num2 = 12
				num3 = 0
				IL_88:
				num2 = 13
				Dim num4 As Integer
				Dim num5 As Integer
				Dim num6 As Integer
				For Each left As String In array
					IL_9B:
					num2 = 14
					If Operators.CompareString(left, "视频网站：", False) = 0 Then
						IL_AD:
						num2 = 15
						num4 = num3 - 1
						IL_B5:
						num2 = 16
						num5 = num3 + 1
					End If
					IL_BD:
					num2 = 17
					If Operators.CompareString(left, "产品名：", False) = 0 Then
						IL_CF:
						num2 = 18
						num6 = num3 - 1
						IL_D7:
						num2 = 19
					End If
					IL_DA:
					num2 = 20
					num3 += 1
					IL_E1:
					num2 = 21
				Next
				IL_F2:
				num2 = 22
				IL_F5:
				num2 = 23
				File.SetAttributes(Me._ValueCollection, FileAttributes.Normal)
				IL_108:
				num2 = 24
				File.SetAttributes(Me._ValueCollection, FileAttributes.Normal)
				IL_11B:
				num2 = 25
				Dim text As String = File.ReadAllText(Me._ValueCollection)
				IL_12B:
				num2 = 26
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				IL_135:
				num2 = 27
				Dim array3 As String() = text.Split(New String() { Environment.NewLine }, StringSplitOptions.None)
				IL_150:
				num2 = 28
				For Each text2 As String In array3
					IL_163:
					num2 = 29
					If text2.Trim().StartsWith("127.0.0.1") Then
						IL_179:
						num2 = 30
						Dim array5 As String() = text2.Trim().Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
						IL_196:
						num2 = 31
						If array5.Length > 1 Then
							IL_1A0:
							num2 = 32
							hashSet.Add(array5(1).ToLower())
						End If
					End If
					IL_1B4:
					num2 = 33
				Next
				IL_1C5:
				num2 = 34
				Dim stringBuilder As StringBuilder = New StringBuilder(text)
				IL_1D1:
				num2 = 35
				stringBuilder.AppendLine()
				IL_1DC:
				num2 = 36
				Dim num7 As Integer = num4
				For k As Integer = 0 To num7
					IL_1EB:
					num2 = 37
					If Not String.IsNullOrEmpty(array(k).Trim()) Then
						IL_1FF:
						num2 = 38
						Dim text3 As String = array(k).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						IL_243:
						num2 = 39
						If Not hashSet.Contains(text3) Then
							IL_251:
							num2 = 40
							stringBuilder.AppendLine("127.0.0.1 " + text3)
						End If
					End If
					IL_268:
					num2 = 41
				Next
				IL_27A:
				num2 = 42
				If Operators.CompareString(string_1, "off", False) <> 0 Then
					GoTo IL_32D
				End If
				IL_28E:
				num2 = 43
				Dim num8 As Integer = num5
				Dim num9 As Integer = num6
				For l As Integer = num8 To num9
					IL_29E:
					num2 = 44
					If Not String.IsNullOrEmpty(array(l).Trim()) Then
						IL_2B2:
						num2 = 45
						Dim text4 As String = array(l).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						IL_2F6:
						num2 = 46
						If Not hashSet.Contains(text4) Then
							IL_304:
							num2 = 47
							stringBuilder.AppendLine("127.0.0.1 " + text4)
						End If
					End If
					IL_31B:
					num2 = 48
				Next
				IL_32D:
				num2 = 49
				File.WriteAllText(Me._ValueCollection, stringBuilder.ToString())
				IL_342:
				num2 = 50
				Me.orderCollection = True
				IL_34C:
				num2 = 51
				File.SetAttributes(Me._ValueCollection, File.GetAttributes(Me._ValueCollection) Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				IL_36B:
				num2 = 52
				MessageCollection.RemoveContext(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_389:
				num2 = 53
				Interaction.Shell("ipconfig /flushdns", AppWinStyle.Hide, True, -1)
				IL_39A:
				GoTo IL_4C8
				IL_39F:
				Dim num10 As Integer = num11 + 1
				num11 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num10)
				IL_487:
				GoTo IL_4BD
				IL_489:
				num11 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_49A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num11 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_489
			End Try
			IL_4BD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4C8:
			If num11 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600003E RID: 62 RVA: 0x00007A3C File Offset: 0x00005C3C
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

		' Token: 0x0600003F RID: 63 RVA: 0x00007A94 File Offset: 0x00005C94
		Private Function FlushContext(string_0 As String) As Boolean
			Return Process.GetProcessesByName(string_0).Length > 0
		End Function

		' Token: 0x06000041 RID: 65 RVA: 0x00007AF4 File Offset: 0x00005CF4
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

		' Token: 0x1700000D RID: 13
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

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000044 RID: 68 RVA: 0x0000245F File Offset: 0x0000065F
		' (set) Token: 0x06000045 RID: 69 RVA: 0x00002467 File Offset: 0x00000667
		Friend Overridable Property RadioButton1 As RadioButton

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000046 RID: 70 RVA: 0x00002470 File Offset: 0x00000670
		' (set) Token: 0x06000047 RID: 71 RVA: 0x00002478 File Offset: 0x00000678
		Friend Overridable Property RadioButton2 As RadioButton

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000048 RID: 72 RVA: 0x00002481 File Offset: 0x00000681
		' (set) Token: 0x06000049 RID: 73 RVA: 0x00002489 File Offset: 0x00000689
		Friend Overridable Property RadioButton4 As RadioButton

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x0600004A RID: 74 RVA: 0x00002492 File Offset: 0x00000692
		' (set) Token: 0x0600004B RID: 75 RVA: 0x0000249A File Offset: 0x0000069A
		Friend Overridable Property RadioButton3 As RadioButton

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x0600004C RID: 76 RVA: 0x000024A3 File Offset: 0x000006A3
		' (set) Token: 0x0600004D RID: 77 RVA: 0x000024AB File Offset: 0x000006AB
		Friend Overridable Property RadioButton6 As RadioButton

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x0600004E RID: 78 RVA: 0x000024B4 File Offset: 0x000006B4
		' (set) Token: 0x0600004F RID: 79 RVA: 0x000024BC File Offset: 0x000006BC
		Friend Overridable Property RadioButton5 As RadioButton

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000050 RID: 80 RVA: 0x000024C5 File Offset: 0x000006C5
		' (set) Token: 0x06000051 RID: 81 RVA: 0x000024CD File Offset: 0x000006CD
		Friend Overridable Property OpenFileDialog1 As OpenFileDialog

		' Token: 0x17000015 RID: 21
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

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x06000054 RID: 84 RVA: 0x000024DE File Offset: 0x000006DE
		' (set) Token: 0x06000055 RID: 85 RVA: 0x000024E6 File Offset: 0x000006E6
		Friend Overridable Property GroupBox4 As GroupBox

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x06000056 RID: 86 RVA: 0x000024EF File Offset: 0x000006EF
		' (set) Token: 0x06000057 RID: 87 RVA: 0x000024F7 File Offset: 0x000006F7
		Friend Overridable Property Label1 As Label

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x06000058 RID: 88 RVA: 0x00002500 File Offset: 0x00000700
		' (set) Token: 0x06000059 RID: 89 RVA: 0x00002508 File Offset: 0x00000708
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000019 RID: 25
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

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x0600005C RID: 92 RVA: 0x00002519 File Offset: 0x00000719
		' (set) Token: 0x0600005D RID: 93 RVA: 0x00002521 File Offset: 0x00000721
		Friend Overridable Property GroupBox5 As GroupBox

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x0600005E RID: 94 RVA: 0x0000252A File Offset: 0x0000072A
		' (set) Token: 0x0600005F RID: 95 RVA: 0x00002532 File Offset: 0x00000732
		Friend Overridable Property pd_new As TextBox

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000060 RID: 96 RVA: 0x0000253B File Offset: 0x0000073B
		' (set) Token: 0x06000061 RID: 97 RVA: 0x00002543 File Offset: 0x00000743
		Friend Overridable Property Label8 As Label

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000062 RID: 98 RVA: 0x0000254C File Offset: 0x0000074C
		' (set) Token: 0x06000063 RID: 99 RVA: 0x00002554 File Offset: 0x00000754
		Friend Overridable Property Label2 As Label

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000064 RID: 100 RVA: 0x0000255D File Offset: 0x0000075D
		' (set) Token: 0x06000065 RID: 101 RVA: 0x00002565 File Offset: 0x00000765
		Friend Overridable Property RadioButton10 As RadioButton

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000066 RID: 102 RVA: 0x0000256E File Offset: 0x0000076E
		' (set) Token: 0x06000067 RID: 103 RVA: 0x00002576 File Offset: 0x00000776
		Friend Overridable Property RadioButton9 As RadioButton

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000068 RID: 104 RVA: 0x0000257F File Offset: 0x0000077F
		' (set) Token: 0x06000069 RID: 105 RVA: 0x00002587 File Offset: 0x00000787
		Friend Overridable Property Label4 As Label

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600006A RID: 106 RVA: 0x00002590 File Offset: 0x00000790
		' (set) Token: 0x0600006B RID: 107 RVA: 0x00002598 File Offset: 0x00000798
		Friend Overridable Property Label10 As Label

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x0600006C RID: 108 RVA: 0x000025A1 File Offset: 0x000007A1
		' (set) Token: 0x0600006D RID: 109 RVA: 0x000025A9 File Offset: 0x000007A9
		Friend Overridable Property RadioButton12 As RadioButton

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600006E RID: 110 RVA: 0x000025B2 File Offset: 0x000007B2
		' (set) Token: 0x0600006F RID: 111 RVA: 0x000025BA File Offset: 0x000007BA
		Friend Overridable Property RadioButton11 As RadioButton

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000070 RID: 112 RVA: 0x000025C3 File Offset: 0x000007C3
		' (set) Token: 0x06000071 RID: 113 RVA: 0x000025CB File Offset: 0x000007CB
		Friend Overridable Property GroupBox_0 As GroupBox

		' Token: 0x17000025 RID: 37
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

		' Token: 0x17000026 RID: 38
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

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000076 RID: 118 RVA: 0x000025E4 File Offset: 0x000007E4
		' (set) Token: 0x06000077 RID: 119 RVA: 0x000025EC File Offset: 0x000007EC
		Friend Overridable Property GroupBox9 As GroupBox

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000078 RID: 120 RVA: 0x000025F5 File Offset: 0x000007F5
		' (set) Token: 0x06000079 RID: 121 RVA: 0x000025FD File Offset: 0x000007FD
		Friend Overridable Property RadioButton13 As RadioButton

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00002606 File Offset: 0x00000806
		' (set) Token: 0x0600007B RID: 123 RVA: 0x0000260E File Offset: 0x0000080E
		Friend Overridable Property RadioButton14 As RadioButton

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x0600007C RID: 124 RVA: 0x00002617 File Offset: 0x00000817
		' (set) Token: 0x0600007D RID: 125 RVA: 0x0000261F File Offset: 0x0000081F
		Friend Overridable Property Label11 As Label

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x0600007E RID: 126 RVA: 0x00002628 File Offset: 0x00000828
		' (set) Token: 0x0600007F RID: 127 RVA: 0x00002630 File Offset: 0x00000830
		Friend Overridable Property Label12 As Label

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000080 RID: 128 RVA: 0x00002639 File Offset: 0x00000839
		' (set) Token: 0x06000081 RID: 129 RVA: 0x00002641 File Offset: 0x00000841
		Friend Overridable Property Label13 As Label

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000082 RID: 130 RVA: 0x0000264A File Offset: 0x0000084A
		' (set) Token: 0x06000083 RID: 131 RVA: 0x00002652 File Offset: 0x00000852
		Friend Overridable Property Label15 As Label

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000084 RID: 132 RVA: 0x0000265B File Offset: 0x0000085B
		' (set) Token: 0x06000085 RID: 133 RVA: 0x00002663 File Offset: 0x00000863
		Friend Overridable Property Label16 As Label

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000086 RID: 134 RVA: 0x0000266C File Offset: 0x0000086C
		' (set) Token: 0x06000087 RID: 135 RVA: 0x00002674 File Offset: 0x00000874
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x06000088 RID: 136 RVA: 0x0000267D File Offset: 0x0000087D
		' (set) Token: 0x06000089 RID: 137 RVA: 0x00002685 File Offset: 0x00000885
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600008A RID: 138 RVA: 0x0000268E File Offset: 0x0000088E
		' (set) Token: 0x0600008B RID: 139 RVA: 0x00002696 File Offset: 0x00000896
		Friend Overridable Property GroupBox3 As GroupBox

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x0600008C RID: 140 RVA: 0x0000269F File Offset: 0x0000089F
		' (set) Token: 0x0600008D RID: 141 RVA: 0x000026A7 File Offset: 0x000008A7
		Friend Overridable Property GroupBox7 As GroupBox

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x0600008E RID: 142 RVA: 0x000026B0 File Offset: 0x000008B0
		' (set) Token: 0x0600008F RID: 143 RVA: 0x000026B8 File Offset: 0x000008B8
		Friend Overridable Property GroupBox_1 As GroupBox

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000090 RID: 144 RVA: 0x000026C1 File Offset: 0x000008C1
		' (set) Token: 0x06000091 RID: 145 RVA: 0x000026C9 File Offset: 0x000008C9
		Friend Overridable Property Label7 As Label

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x06000092 RID: 146 RVA: 0x000026D2 File Offset: 0x000008D2
		' (set) Token: 0x06000093 RID: 147 RVA: 0x000026DA File Offset: 0x000008DA
		Friend Overridable Property Label5 As Label

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000094 RID: 148 RVA: 0x000026E3 File Offset: 0x000008E3
		' (set) Token: 0x06000095 RID: 149 RVA: 0x000026EB File Offset: 0x000008EB
		Friend Overridable Property Label9 As Label

		' Token: 0x17000037 RID: 55
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

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x06000098 RID: 152 RVA: 0x000026FC File Offset: 0x000008FC
		' (set) Token: 0x06000099 RID: 153 RVA: 0x00002704 File Offset: 0x00000904
		Friend Overridable Property Label14 As Label

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x0600009A RID: 154 RVA: 0x0000270D File Offset: 0x0000090D
		' (set) Token: 0x0600009B RID: 155 RVA: 0x00002715 File Offset: 0x00000915
		Friend Overridable Property Label3 As Label

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x0600009C RID: 156 RVA: 0x0000271E File Offset: 0x0000091E
		' (set) Token: 0x0600009D RID: 157 RVA: 0x00002726 File Offset: 0x00000926
		Friend Overridable Property Label6 As Label

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x0600009E RID: 158 RVA: 0x0000272F File Offset: 0x0000092F
		' (set) Token: 0x0600009F RID: 159 RVA: 0x00002737 File Offset: 0x00000937
		Friend Overridable Property Label17 As Label

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x060000A0 RID: 160 RVA: 0x00002740 File Offset: 0x00000940
		' (set) Token: 0x060000A1 RID: 161 RVA: 0x00002748 File Offset: 0x00000948
		Friend Overridable Property GroupBox6 As GroupBox

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x060000A2 RID: 162 RVA: 0x00002751 File Offset: 0x00000951
		' (set) Token: 0x060000A3 RID: 163 RVA: 0x00002759 File Offset: 0x00000959
		Friend Overridable Property RadioButton8 As RadioButton

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x060000A4 RID: 164 RVA: 0x00002762 File Offset: 0x00000962
		' (set) Token: 0x060000A5 RID: 165 RVA: 0x0000276A File Offset: 0x0000096A
		Friend Overridable Property RadioButton7 As RadioButton

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x060000A6 RID: 166 RVA: 0x00002773 File Offset: 0x00000973
		' (set) Token: 0x060000A7 RID: 167 RVA: 0x0000277B File Offset: 0x0000097B
		Friend Overridable Property Label18 As Label

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x060000A8 RID: 168 RVA: 0x00002784 File Offset: 0x00000984
		' (set) Token: 0x060000A9 RID: 169 RVA: 0x0000278C File Offset: 0x0000098C
		Friend Overridable Property GroupBox8 As GroupBox

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x060000AA RID: 170 RVA: 0x00002795 File Offset: 0x00000995
		' (set) Token: 0x060000AB RID: 171 RVA: 0x0000279D File Offset: 0x0000099D
		Friend Overridable Property RadioButton15 As RadioButton

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x060000AC RID: 172 RVA: 0x000027A6 File Offset: 0x000009A6
		' (set) Token: 0x060000AD RID: 173 RVA: 0x000027AE File Offset: 0x000009AE
		Friend Overridable Property RadioButton17 As RadioButton

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000AE RID: 174 RVA: 0x000027B7 File Offset: 0x000009B7
		' (set) Token: 0x060000AF RID: 175 RVA: 0x000027BF File Offset: 0x000009BF
		Friend Overridable Property Label19 As Label

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x000027C8 File Offset: 0x000009C8
		' (set) Token: 0x060000B1 RID: 177 RVA: 0x000027D0 File Offset: 0x000009D0
		Friend Overridable Property Label20 As Label

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000B2 RID: 178 RVA: 0x000027D9 File Offset: 0x000009D9
		' (set) Token: 0x060000B3 RID: 179 RVA: 0x000027E1 File Offset: 0x000009E1
		Friend Overridable Property RadioButton16 As RadioButton

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000B4 RID: 180 RVA: 0x000027EA File Offset: 0x000009EA
		' (set) Token: 0x060000B5 RID: 181 RVA: 0x000027F2 File Offset: 0x000009F2
		Friend Overridable Property Label21 As Label

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000B6 RID: 182 RVA: 0x000027FB File Offset: 0x000009FB
		' (set) Token: 0x060000B7 RID: 183 RVA: 0x00002803 File Offset: 0x00000A03
		Friend Overridable Property GroupBox_2 As GroupBox

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000B8 RID: 184 RVA: 0x0000280C File Offset: 0x00000A0C
		' (set) Token: 0x060000B9 RID: 185 RVA: 0x00002814 File Offset: 0x00000A14
		Friend Overridable Property RadioButton19 As RadioButton

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000BA RID: 186 RVA: 0x0000281D File Offset: 0x00000A1D
		' (set) Token: 0x060000BB RID: 187 RVA: 0x00002825 File Offset: 0x00000A25
		Friend Overridable Property RadioButton20 As RadioButton

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000BC RID: 188 RVA: 0x0000282E File Offset: 0x00000A2E
		' (set) Token: 0x060000BD RID: 189 RVA: 0x00002836 File Offset: 0x00000A36
		Friend Overridable Property Label22 As Label

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000BE RID: 190 RVA: 0x0000283F File Offset: 0x00000A3F
		' (set) Token: 0x060000BF RID: 191 RVA: 0x00002847 File Offset: 0x00000A47
		Friend Overridable Property Label23 As Label

		' Token: 0x04000010 RID: 16
		Private m_PropertyCollection As String

		' Token: 0x04000011 RID: 17
		Private m_QueueCollection As String

		' Token: 0x04000012 RID: 18
		Private importerCollection As String

		' Token: 0x04000013 RID: 19
		Private m_CustomerCollection As String

		' Token: 0x04000014 RID: 20
		Private m_AuthenticationCollection As String

		' Token: 0x04000015 RID: 21
		Private templateCollection As String

		' Token: 0x04000016 RID: 22
		Private _ValueCollection As String

		' Token: 0x04000017 RID: 23
		Private orderCollection As Boolean

		' Token: 0x04000018 RID: 24
		Private Const iteratorCollection As Integer = 20

		' Token: 0x04000019 RID: 25
		Private Const configurationCollection As Integer = 1

		' Token: 0x0400001A RID: 26
		Private Const _ComparatorCollection As Integer = 2

		' Token: 0x0400001B RID: 27
		Private m_AdapterCollection As String

		' Token: 0x0400001C RID: 28
		Private m_RefCollection As String

		' Token: 0x0400001E RID: 30
		<AccessedThroughProperty("Button1")>
		<CompilerGenerated()>
		Private m_StatusCollection As Button

		' Token: 0x0400001F RID: 31
		<AccessedThroughProperty("RadioButton1")>
		<CompilerGenerated()>
		Private m_ConfigCollection As RadioButton

		' Token: 0x04000020 RID: 32
		<AccessedThroughProperty("RadioButton2")>
		<CompilerGenerated()>
		Private _InvocationCollection As RadioButton

		' Token: 0x04000021 RID: 33
		<AccessedThroughProperty("RadioButton4")>
		<CompilerGenerated()>
		Private stubCollection As RadioButton

		' Token: 0x04000022 RID: 34
		<AccessedThroughProperty("RadioButton3")>
		<CompilerGenerated()>
		Private _MapCollection As RadioButton

		' Token: 0x04000023 RID: 35
		<AccessedThroughProperty("RadioButton6")>
		<CompilerGenerated()>
		Private _MapperCollection As RadioButton

		' Token: 0x04000024 RID: 36
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton5")>
		Private m_InterpreterCollection As RadioButton

		' Token: 0x04000025 RID: 37
		<AccessedThroughProperty("OpenFileDialog1")>
		<CompilerGenerated()>
		Private _FilterCollection As OpenFileDialog

		' Token: 0x04000026 RID: 38
		<CompilerGenerated()>
		<AccessedThroughProperty("Button2")>
		Private attrCollection As Button

		' Token: 0x04000027 RID: 39
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox4")>
		Private systemCollection As GroupBox

		' Token: 0x04000028 RID: 40
		<CompilerGenerated()>
		<AccessedThroughProperty("Label1")>
		Private m_RegistryCollection As Label

		' Token: 0x04000029 RID: 41
		<CompilerGenerated()>
		<AccessedThroughProperty("TextBox1")>
		Private m_RulesCollection As TextBox

		' Token: 0x0400002A RID: 42
		<CompilerGenerated()>
		<AccessedThroughProperty("Button3")>
		Private specificationCollection As Button

		' Token: 0x0400002B RID: 43
		<AccessedThroughProperty("GroupBox5")>
		<CompilerGenerated()>
		Private poolCollection As GroupBox

		' Token: 0x0400002C RID: 44
		<AccessedThroughProperty("pd_new")>
		<CompilerGenerated()>
		Private m_InstanceCollection As TextBox

		' Token: 0x0400002D RID: 45
		<CompilerGenerated()>
		<AccessedThroughProperty("Label8")>
		Private composerCollection As Label

		' Token: 0x0400002E RID: 46
		<AccessedThroughProperty("Label2")>
		<CompilerGenerated()>
		Private _IndexerCollection As Label

		' Token: 0x0400002F RID: 47
		<AccessedThroughProperty("RadioButton10")>
		<CompilerGenerated()>
		Private strategyCollection As RadioButton

		' Token: 0x04000030 RID: 48
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton9")>
		Private _ParserCollection As RadioButton

		' Token: 0x04000031 RID: 49
		<AccessedThroughProperty("Label4")>
		<CompilerGenerated()>
		Private m_ClientCollection As Label

		' Token: 0x04000032 RID: 50
		<CompilerGenerated()>
		<AccessedThroughProperty("Label10")>
		Private errorCollection As Label

		' Token: 0x04000033 RID: 51
		<AccessedThroughProperty("RadioButton12")>
		<CompilerGenerated()>
		Private resolverCollection As RadioButton

		' Token: 0x04000034 RID: 52
		<AccessedThroughProperty("RadioButton11")>
		<CompilerGenerated()>
		Private _AttributeCollection As RadioButton

		' Token: 0x04000035 RID: 53
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox10")>
		Private _DefinitionCollection As GroupBox

		' Token: 0x04000036 RID: 54
		<CompilerGenerated()>
		<AccessedThroughProperty("Button_restorepic")>
		Private managerCollection As Button

		' Token: 0x04000037 RID: 55
		<AccessedThroughProperty("Button_selectpic")>
		<CompilerGenerated()>
		Private m_CallbackCollection As Button

		' Token: 0x04000038 RID: 56
		<AccessedThroughProperty("GroupBox9")>
		<CompilerGenerated()>
		Private _MockCollection As GroupBox

		' Token: 0x04000039 RID: 57
		<AccessedThroughProperty("RadioButton13")>
		<CompilerGenerated()>
		Private m_TaskCollection As RadioButton

		' Token: 0x0400003A RID: 58
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton14")>
		Private m_ContainerCollection As RadioButton

		' Token: 0x0400003B RID: 59
		<CompilerGenerated()>
		<AccessedThroughProperty("Label11")>
		Private _ObserverCollection As Label

		' Token: 0x0400003C RID: 60
		<CompilerGenerated()>
		<AccessedThroughProperty("Label12")>
		Private _FacadeCollection As Label

		' Token: 0x0400003D RID: 61
		<CompilerGenerated()>
		<AccessedThroughProperty("Label13")>
		Private m_RecordCollection As Label

		' Token: 0x0400003E RID: 62
		<CompilerGenerated()>
		<AccessedThroughProperty("Label15")>
		Private _PrototypeCollection As Label

		' Token: 0x0400003F RID: 63
		<CompilerGenerated()>
		<AccessedThroughProperty("Label16")>
		Private m_WorkerCollection As Label

		' Token: 0x04000040 RID: 64
		<AccessedThroughProperty("GroupBox1")>
		<CompilerGenerated()>
		Private proccesorCollection As GroupBox

		' Token: 0x04000041 RID: 65
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox2")>
		Private m_SerializerCollection As GroupBox

		' Token: 0x04000042 RID: 66
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox3")>
		Private decoratorCollection As GroupBox

		' Token: 0x04000043 RID: 67
		<AccessedThroughProperty("GroupBox7")>
		<CompilerGenerated()>
		Private listenerCollection As GroupBox

		' Token: 0x04000044 RID: 68
		<AccessedThroughProperty("GroupBox12")>
		<CompilerGenerated()>
		Private annotationCollection As GroupBox

		' Token: 0x04000045 RID: 69
		<AccessedThroughProperty("Label7")>
		<CompilerGenerated()>
		Private m_TagCollection As Label

		' Token: 0x04000046 RID: 70
		<AccessedThroughProperty("Label5")>
		<CompilerGenerated()>
		Private m_ExporterCollection As Label

		' Token: 0x04000047 RID: 71
		<AccessedThroughProperty("Label9")>
		<CompilerGenerated()>
		Private merchantCollection As Label

		' Token: 0x04000048 RID: 72
		<AccessedThroughProperty("LinkLabel2")>
		<CompilerGenerated()>
		Private regCollection As LinkLabel

		' Token: 0x04000049 RID: 73
		<CompilerGenerated()>
		<AccessedThroughProperty("Label14")>
		Private _StateCollection As Label

		' Token: 0x0400004A RID: 74
		<CompilerGenerated()>
		<AccessedThroughProperty("Label3")>
		Private itemCollection As Label

		' Token: 0x0400004B RID: 75
		<CompilerGenerated()>
		<AccessedThroughProperty("Label6")>
		Private m_FieldCollection As Label

		' Token: 0x0400004C RID: 76
		<CompilerGenerated()>
		<AccessedThroughProperty("Label17")>
		Private m_TestsCollection As Label

		' Token: 0x0400004D RID: 77
		<AccessedThroughProperty("GroupBox6")>
		<CompilerGenerated()>
		Private _WatcherCollection As GroupBox

		' Token: 0x0400004E RID: 78
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton8")>
		Private m_ModelCollection As RadioButton

		' Token: 0x0400004F RID: 79
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton7")>
		Private _UtilsCollection As RadioButton

		' Token: 0x04000050 RID: 80
		<CompilerGenerated()>
		<AccessedThroughProperty("Label18")>
		Private valCollection As Label

		' Token: 0x04000051 RID: 81
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox8")>
		Private m_BaseCollection As GroupBox

		' Token: 0x04000052 RID: 82
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton15")>
		Private m_CodeCollection As RadioButton

		' Token: 0x04000053 RID: 83
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton17")>
		Private m_AdvisorCollection As RadioButton

		' Token: 0x04000054 RID: 84
		<AccessedThroughProperty("Label19")>
		<CompilerGenerated()>
		Private m_ProxyCollection As Label

		' Token: 0x04000055 RID: 85
		<CompilerGenerated()>
		<AccessedThroughProperty("Label20")>
		Private m_VisitorCollection As Label

		' Token: 0x04000056 RID: 86
		<AccessedThroughProperty("RadioButton16")>
		<CompilerGenerated()>
		Private _PrinterCollection As RadioButton

		' Token: 0x04000057 RID: 87
		<CompilerGenerated()>
		<AccessedThroughProperty("Label21")>
		Private _TokenizerCollection As Label

		' Token: 0x04000058 RID: 88
		<CompilerGenerated()>
		<AccessedThroughProperty("GroupBox11")>
		Private _GetterCollection As GroupBox

		' Token: 0x04000059 RID: 89
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton19")>
		Private tokenCollection As RadioButton

		' Token: 0x0400005A RID: 90
		<CompilerGenerated()>
		<AccessedThroughProperty("RadioButton20")>
		Private producerCollection As RadioButton

		' Token: 0x0400005B RID: 91
		<CompilerGenerated()>
		<AccessedThroughProperty("Label22")>
		Private _BridgeCollection As Label

		' Token: 0x0400005C RID: 92
		<AccessedThroughProperty("Label23")>
		<CompilerGenerated()>
		Private _DatabaseCollection As Label

		' Token: 0x0200000C RID: 12
		Public Enum WallpaperStyle
			' Token: 0x0400005E RID: 94
			Tiled = 1
			' Token: 0x0400005F RID: 95
			Centered
			' Token: 0x04000060 RID: 96
			Stretched = 6
		End Enum

		' Token: 0x0200000D RID: 13
		Public Structure RECT
			' Token: 0x04000061 RID: 97
			Public Left As Integer

			' Token: 0x04000062 RID: 98
			Public Top As Integer

			' Token: 0x04000063 RID: 99
			Public Right As Integer

			' Token: 0x04000064 RID: 100
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
