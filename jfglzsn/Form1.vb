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
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x0600002A RID: 42 RVA: 0x00002A3C File Offset: 0x00000C3C
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

		' Token: 0x0600002B RID: 43
		Private Declare Ansi Function GetDriveTypeA Lib "kernel32" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef string_0 As String) As Long

		' Token: 0x0600002C RID: 44
		Private Declare Ansi Function NtSuspendProcess Lib "ntdll.dll" (intptr_0 As IntPtr) As Integer

		' Token: 0x0600002D RID: 45
		Private Declare Ansi Function NtResumeProcess Lib "ntdll.dll" (intptr_0 As IntPtr) As Integer

		' Token: 0x0600002E RID: 46
		Private Declare Function RtlAdjustPrivilege Lib "ntdll.dll" (int_0 As Integer, int_1 As Integer, int_2 As Integer, ByRef int_3 As Integer) As Integer

		' Token: 0x0600002F RID: 47
		Private Declare Function NtShutdownSystem Lib "ntdll.dll" (int_0 As Integer) As Integer

		' Token: 0x06000030 RID: 48
		Private Declare Ansi Function SetForegroundWindow Lib "user32" (intptr_0 As IntPtr) As Boolean

		' Token: 0x06000031 RID: 49
		Private Declare Ansi Function GetForegroundWindow Lib "user32" () As IntPtr

		' Token: 0x06000032 RID: 50
		Private Declare Ansi Function GetWindowTextA Lib "user32" (intptr_0 As IntPtr, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef string_0 As String, int_0 As Integer) As Integer

		' Token: 0x06000033 RID: 51
		Private Declare Ansi Function GetWindowThreadProcessId Lib "user32" (intptr_0 As IntPtr, ByRef int_0 As Integer) As Integer

		' Token: 0x06000034 RID: 52
		Private Declare Ansi Sub keybd_event Lib "user32" (byte_0 As Byte, byte_1 As Byte, int_0 As Integer, int_1 As Integer)

		' Token: 0x06000035 RID: 53
		Private Declare Function BlockInput Lib "user32.dll" (bool_0 As Boolean) As Boolean

		' Token: 0x06000036 RID: 54 RVA: 0x00002BA0 File Offset: 0x00000DA0
		Private Sub CompareState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Me._CustomerStatus += 1L
				IL_20:
				num2 = 3
				Me.attrStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "zhuye", ""))
				IL_46:
				num2 = 4
				Me.FindState("http://" + Me.attrStatus + "/hmd_net.txt", "on")
				IL_68:
				num2 = 5
				File.SetAttributes(Me._ContainerStatus + "2", FileAttributes.Normal)
				IL_84:
				num2 = 6
				File.Copy(Me._ContainerStatus, Me._ContainerStatus + "2", True)
				IL_A2:
				num2 = 7
				If Me.m_ParserStatus Then
					GoTo IL_BC
				End If
				IL_AC:
				num2 = 8
				Me.Timer_updatehosts.Enabled = True
				GoTo IL_CB
				IL_BC:
				num2 = 10
				Me.Timer_route.Enabled = True
				IL_CB:
				num2 = 11
				If Me._CustomerStatus <> 2L Then
					GoTo IL_17E
				End If
				IL_E2:
				num2 = 12
				If Not(Operators.CompareString(Me._MockStatus, "", False) <> 0 And Operators.CompareString(Me.fieldStatus, "", False) <> 0 And Operators.CompareString(Me.m_ConnectionStatus, "", False) <> 0) Then
					GoTo IL_134
				End If
				IL_125:
				num2 = 13
				Me.Timer_qdx.Enabled = True
				IL_134:
				num2 = 14
				Dim left As String = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
				IL_156:
				num2 = 15
				If Operators.CompareString(left, "on", False) <> 0 Then
					GoTo IL_2AC
				End If
				IL_16A:
				num2 = 16
				Me.Timer_usb.Enabled = True
				GoTo IL_2AC
				IL_17E:
				num2 = 18
				If Me._CustomerStatus <> 7L Then
					GoTo IL_1B5
				End If
				IL_192:
				num2 = 19
				Me.Timer_fhq.Enabled = True
				IL_1A1:
				num2 = 20
				Me.Timer1.Enabled = True
				GoTo IL_2AC
				IL_1B5:
				num2 = 22
				If Me._CustomerStatus <> 10L Then
					GoTo IL_253
				End If
				IL_1CC:
				num2 = 23
				Me.Timer_wangluo.Enabled = True
				IL_1DB:
				num2 = 24
				Dim left2 As Object = Me.CheckProcessStatus(Me.m_ResolverStatus)
				IL_1F0:
				num2 = 25
				If Not Operators.ConditionalCompareObjectEqual(left2, Form1.ProcessStatus.NotFound, False) Then
					GoTo IL_2AC
				End If
				IL_205:
				num2 = 26
				If File.Exists(Me.m_ImporterStatus) Then
					GoTo IL_242
				End If
				IL_215:
				num2 = 27
				Me.m_PredicateStatus = Me.m_ImporterStatus + "2"
				IL_22E:
				num2 = 28
				File.Copy(Me.m_PredicateStatus, Me.m_ImporterStatus)
				IL_242:
				num2 = 29
				Process.Start(Me.m_ImporterStatus)
				GoTo IL_2AC
				IL_253:
				num2 = 31
				If Me._CustomerStatus <> 12L Then
					GoTo IL_2AC
				End If
				IL_267:
				num2 = 32
				left2 = Me.CheckProcessStatus(Me.m_ResolverStatus)
				IL_27C:
				num2 = 33
				If Not Operators.ConditionalCompareObjectNotEqual(left2, Form1.ProcessStatus.NotFound, False) Then
					GoTo IL_29D
				End If
				IL_28E:
				num2 = 34
				Me.Timer_dzjs.Enabled = True
				IL_29D:
				num2 = 35
				Me.Timer_main.Enabled = False
				IL_2AC:
				GoTo IL_392
				IL_2B1:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_351:
				GoTo IL_387
				IL_353:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_364:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_353
			End Try
			IL_387:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_392:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x00002474 File Offset: 0x00000674
		Private Sub ValidateState(sender As Object, e As EventArgs)
			If Not TokenStatus.DisableState.Form2.Visible Then
				TokenStatus.DisableState.Form2.Show()
			End If
		End Sub

		' Token: 0x06000038 RID: 56 RVA: 0x00002F64 File Offset: 0x00001164
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub MapState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				If Me.InterruptState("zmserv") Then
					GoTo IL_CD
				End If
				IL_1A:
				num2 = 3
				If File.Exists(Application.StartupPath + "\zmserv.exe") Then
					GoTo IL_71
				End If
				IL_32:
				num2 = 4
				If Not File.Exists(Me.helperStatus + "\zmserv.dat") Then
					GoTo IL_71
				End If
				IL_4B:
				num2 = 6
				File.Copy(Me.helperStatus + "\zmserv.dat", Application.StartupPath + "\zmserv.exe")
				IL_71:
				num2 = 7
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_8E:
				num2 = 8
				Dim str As String = Application.StartupPath + "\zmserv.exe"
				IL_A0:
				num2 = 9
				Interaction.Shell("sc create zmserv binPath= " + str + " start= auto", AppWinStyle.Hide, True, -1)
				IL_BC:
				num2 = 10
				Interaction.Shell("net start zmserv", AppWinStyle.Hide, True, -1)
				IL_CD:
				num2 = 11
				If Me.InterruptState(Conversions.ToString(FilterStatus.serializerStatus)) Then
					GoTo IL_221
				End If
				IL_E5:
				num2 = 12
				Dim ptr As Long = Me._AdvisorStatus
				Me._AdvisorStatus = ptr + 1L
				IL_FF:
				num2 = 13
				If File.Exists(Application.StartupPath + "\przs.exe") Then
					GoTo IL_159
				End If
				IL_118:
				num2 = 14
				If Not File.Exists(Me.helperStatus + "\przs.dat") Then
					GoTo IL_159
				End If
				IL_132:
				num2 = 16
				File.Copy(Me.helperStatus + "\przs.dat", Application.StartupPath + "\przs.exe")
				IL_159:
				num2 = 17
				Process.Start(Application.StartupPath + "\przs.exe")
				IL_171:
				num2 = 18
				If Me._AdvisorStatus < 5L Then
					GoTo IL_221
				End If
				IL_188:
				num2 = 19
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_1A6:
				num2 = 20
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_1B7:
				num2 = 21
				Thread.Sleep(3000)
				IL_1C4:
				num2 = 22
				Dim str2 As String = Application.StartupPath + "\zmserv.exe"
				IL_1D7:
				num2 = 23
				Interaction.Shell("sc create zmserv binPath= " + str2 + " start= auto", AppWinStyle.Hide, True, -1)
				IL_1F3:
				num2 = 24
				Interaction.Shell("net start zmserv", AppWinStyle.Hide, True, -1)
				IL_204:
				num2 = 25
				Process.Start(Application.StartupPath + "\jfglzsn.exe")
				ProjectData.EndApp()
				IL_221:
				GoTo IL_2E1
				IL_226:
				GoTo IL_2EC
				IL_22B:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_2BB
				IL_23E:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_2BB:
				GoTo IL_2EC
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_22B
			End Try
			IL_2E1:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_2EC:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x06000039 RID: 57 RVA: 0x00003284 File Offset: 0x00001484
		Private Sub SortState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim num3 As Integer = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", ""))
				IL_29:
				num2 = 3
				If num3 <> 3 Then
					GoTo IL_E2
				End If
				IL_32:
				num2 = 4
				FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 4, 4)
				IL_4F:
				num2 = 5
				FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 4, 4)
				IL_6C:
				num2 = 6
				FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 4, 4)
				IL_89:
				num2 = 7
				FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 4, 4)
				IL_A6:
				num2 = 8
				TokenStatus.DisableState.Form2.shuoming.Text = "你修改注册表企图使用U盘！请重新启动电脑。"
				IL_C1:
				num2 = 9
				TokenStatus.DisableState.Form2.Show()
				IL_D3:
				num2 = 10
				Me.Timer2.Enabled = True
				IL_E2:
				GoTo IL_15D
				IL_E4:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_11E:
				GoTo IL_152
				IL_120:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_130:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_120
			End Try
			IL_152:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_15D:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600003A RID: 58 RVA: 0x00003414 File Offset: 0x00001614
		Private Sub ResolveState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				If Me.m_OrderStatus <> 0 Then
					GoTo IL_25
				End If
				IL_12:
				num2 = 3
				Me.Timer_dzjs.Enabled = False
				GoTo IL_276
				IL_25:
				num2 = 5
				If Me.m_OrderStatus <> 1 Then
					GoTo IL_BD
				End If
				IL_33:
				num2 = 6
				Dim num3 As Integer = Information.UBound(Me._AccountStatus, 1)
				For i As Integer = 0 To num3
					IL_46:
					num2 = 7
					Dim string_ As String = Strings.Replace(Me._AccountStatus(i), ".exe", "", 1, -1, CompareMethod.Binary)
					IL_64:
					num2 = 8
					If Not Me.InterruptState(string_) Then
						IL_70:
						num2 = 9
						TokenStatus.DisableState.Form2.shuoming.Text = "电子教室进程未找到或本地连接IP地址错误！请重新启动电脑。"
						IL_8C:
						num2 = 10
						TokenStatus.DisableState.Form2.Show()
						IL_9E:
						num2 = 11
						Me.Timer2.Enabled = True
					End If
					IL_AD:
					num2 = 12
				Next
				GoTo IL_276
				IL_BD:
				num2 = 14
				If Me.m_OrderStatus <> 2 Then
					GoTo IL_276
				End If
				IL_CC:
				num2 = 15
				Dim processStatus As Form1.ProcessStatus = Me.CheckProcessStatus(Me.m_ResolverStatus)
				IL_DD:
				num2 = 16
				Select Case processStatus
					Case Form1.ProcessStatus.Running
						IL_FC:
						num2 = 18
						Me.m_ValueStatus = 0
						IL_106:
						num2 = 19
						If Not Me._PolicyStatus Then
							GoTo IL_123
						End If
						IL_111:
						num2 = 20
						TokenStatus.DisableState.Form3.Close()
						IL_123:
						num2 = 21
						Me._PolicyStatus = False
					Case Form1.ProcessStatus.Suspended
						IL_132:
						num2 = 23
						Me.m_ValueStatus += 1
					Case Form1.ProcessStatus.NotResponding
						IL_145:
						num2 = 25
						Me.m_ValueStatus += 1
					Case Form1.ProcessStatus.NotFound
						IL_158:
						num2 = 27
						Me._PolicyStatus = True
						IL_162:
						num2 = 28
						Me.bridgeStatus += 1
						IL_173:
						num2 = 29
						If File.Exists(Me.m_ImporterStatus) Then
							GoTo IL_1B0
						End If
						IL_183:
						num2 = 30
						Me.m_PredicateStatus = Me.m_ImporterStatus + "2"
						IL_19C:
						num2 = 31
						File.Copy(Me.m_PredicateStatus, Me.m_ImporterStatus)
						IL_1B0:
						num2 = 32
						Process.Start(Me.m_ImporterStatus)
				End Select
				IL_1BF:
				num2 = 35
				If Me.bridgeStatus < 5 Then
					GoTo IL_1E6
				End If
				IL_1CB:
				num2 = 36
				Form1.ForceShutdown()
				IL_1D3:
				num2 = 37
				Process.Start("shutdown", "/s /f /t 0")
				IL_1E6:
				num2 = 38
				If Me.m_ValueStatus <= 10 Then
					GoTo IL_232
				End If
				IL_1F3:
				num2 = 39
				TokenStatus.DisableState.Form2.shuoming.Text = "电子教室程序被暂停！"
				IL_20F:
				num2 = 40
				TokenStatus.DisableState.Form2.Show()
				IL_221:
				num2 = 41
				Me.Timer2.Enabled = True
				GoTo IL_276
				IL_232:
				num2 = 43
				If Me.m_ValueStatus <= 8 Then
					GoTo IL_276
				End If
				IL_23E:
				num2 = 44
				Me._PolicyStatus = True
				IL_248:
				num2 = 45
				TokenStatus.DisableState.Form3.shuoming.Text = "电子教室程序被暂停！"
				IL_264:
				num2 = 46
				TokenStatus.DisableState.Form3.Show()
				IL_276:
				GoTo IL_38D
				IL_27B:
				GoTo IL_398
				IL_280:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_367
				IL_296:
				Dim num5 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_367:
				GoTo IL_398
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_280
			End Try
			IL_38D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_398:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x000037E0 File Offset: 0x000019E0
		Private Sub ExcludeState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim wiredNetworkIP As String = Me.GetWiredNetworkIP()
				IL_11:
				num2 = 3
				If Not String.IsNullOrEmpty(Me._InstanceStatus) Then
					GoTo IL_40
				End If
				IL_20:
				num2 = 4
				If String.IsNullOrEmpty(wiredNetworkIP) OrElse wiredNetworkIP.StartsWith("169.254.") Then
					GoTo IL_40
				End If
				IL_37:
				num2 = 5
				Me._InstanceStatus = wiredNetworkIP
				IL_40:
				num2 = 6
				If Not String.IsNullOrEmpty(wiredNetworkIP) Then
					GoTo IL_131
				End If
				IL_4D:
				num2 = 7
				Me.m_IndexerStatus += 1
				IL_5D:
				num2 = 8
				If Me.m_IndexerStatus > 5 Then
					GoTo IL_C1
				End If
				IL_68:
				num2 = 9
				Me._AttributeStatus = True
				IL_72:
				num2 = 10
				TokenStatus.DisableState.Form3.shuoming.Text = "你拔了网线或禁用了网络连接！"
				IL_8E:
				num2 = 11
				TokenStatus.DisableState.Form3.shuoming2.Text = "请马上恢复网络，否则会全屏锁定！"
				IL_AA:
				num2 = 12
				TokenStatus.DisableState.Form3.Show()
				GoTo IL_28F
				IL_C1:
				num2 = 14
				TokenStatus.DisableState.Form3.Close()
				IL_D3:
				num2 = 15
				TokenStatus.DisableState.Form2.shuoming.Text = "你拔了网线或禁用了网络连接！"
				IL_EF:
				num2 = 16
				TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
				IL_10B:
				num2 = 17
				TokenStatus.DisableState.Form2.Show()
				IL_11D:
				num2 = 18
				Me.Timer2.Enabled = True
				GoTo IL_28F
				IL_131:
				num2 = 20
				If Not(Operators.CompareString(wiredNetworkIP, Me._InstanceStatus, False) <> 0 And Operators.CompareString(Me._InstanceStatus, "", False) <> 0) Then
					GoTo IL_257
				End If
				IL_15E:
				num2 = 21
				Me.m_IndexerStatus += 1
				IL_16F:
				num2 = 22
				If Me.m_IndexerStatus > 5 Then
					GoTo IL_1DF
				End If
				IL_17B:
				num2 = 23
				Me._RequestStatus = True
				IL_185:
				num2 = 24
				TokenStatus.DisableState.Form3.shuoming.Text = "你修改了IP地址！原地址为:" + Me._InstanceStatus
				IL_1AC:
				num2 = 25
				TokenStatus.DisableState.Form3.shuoming2.Text = "请马上恢复网络，否则会全屏锁定！"
				IL_1C8:
				num2 = 26
				TokenStatus.DisableState.Form3.Show()
				GoTo IL_28F
				IL_1DF:
				num2 = 28
				TokenStatus.DisableState.Form3.Close()
				IL_1F1:
				num2 = 29
				TokenStatus.DisableState.Form2.shuoming.Text = "你修改了IP地址！原地址为:" + Me._InstanceStatus
				IL_218:
				num2 = 30
				TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
				IL_234:
				num2 = 31
				TokenStatus.DisableState.Form2.Show()
				IL_246:
				num2 = 32
				Me.Timer2.Enabled = True
				GoTo IL_28F
				IL_257:
				num2 = 34
				If Not(Me._RequestStatus Or Me._AttributeStatus) Then
					GoTo IL_27B
				End If
				IL_269:
				num2 = 35
				TokenStatus.DisableState.Form3.Close()
				IL_27B:
				num2 = 36
				Me._RequestStatus = False
				IL_285:
				num2 = 37
				Me._AttributeStatus = False
				IL_28F:
				GoTo IL_37E
				IL_294:
				GoTo IL_388
				IL_299:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_359
				IL_2AE:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_359:
				GoTo IL_388
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_299
			End Try
			IL_37E:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_388:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x0600003C RID: 60 RVA: 0x00003B9C File Offset: 0x00001D9C
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub CheckState(sender As Object, e As EventArrivedEventArgs)
			Dim managementBaseObject As ManagementBaseObject = CType(e.NewEvent("TargetInstance"), ManagementBaseObject)
			Dim num As Integer = Conversions.ToInteger(managementBaseObject("ProcessId"))
			Me.m_TokenizerStatus = managementBaseObject("Name").ToString()
			Dim processById As Process = Process.GetProcessById(num)
			Dim fileName As String = processById.MainModule.FileName
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			If Not String.IsNullOrEmpty(fileName) Then
				Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(fileName)
				Dim productName As String = versionInfo.ProductName
				Dim fileDescription As String = versionInfo.FileDescription
				Dim [string] As String = productName + fileDescription
				If Operators.CompareString(Me._GetterStatus, "off", False) = 0 Then
					Me._QueueStatus = 11
				Else
					Me._QueueStatus = 1
				End If
				While Operators.CompareString(Me.classStatus(Me._QueueStatus), "", False) <> 0
					Dim value As String = Me.classStatus(Me._QueueStatus)
					If Strings.InStr("|" + Strings.UCase(Me.m_TokenizerStatus), Strings.UCase(value), CompareMethod.Binary) <> 0 Then
						flag = True
						IL_10A:
						If Operators.CompareString(Me.m_MapStatus, "off", False) = 0 Then
							Me._ListenerStatus = 3
						Else
							Me._ListenerStatus = 1
						End If
						While Operators.CompareString(Me.productStatus(Me._ListenerStatus), "", False) <> 0
							Dim string2 As String = Me.productStatus(Me._ListenerStatus)
							If Strings.InStr([string], string2, CompareMethod.Binary) = 0 Then
								Me._ListenerStatus += 1
							Else
								flag2 = True
								IL_176:
								If flag Then
									If Me._QueueStatus <= 10 Then
										MyBase.BeginInvoke(AddressOf Me.ConcatState)
									ElseIf Me._QueueStatus <= 16 Then
										processById.Kill()
										MyBase.BeginInvoke(AddressOf Me.VerifyState)
									ElseIf Me._QueueStatus <= 21 Then
										If Me.messageStatus <> 1 Then
											processById.Kill()
											MyBase.BeginInvoke(AddressOf Me.VerifyState)
										End If
									Else
										processById.Kill()
										MyBase.BeginInvoke(AddressOf Me.VerifyState)
										processById.WaitForExit(1000)
										FileSystem.Kill(fileName)
									End If
								End If
								If Not flag2 Then
									Return
								End If
								If Me._ListenerStatus <= 3 Then
									Thread.Sleep(2000)
									processById.Kill()
									Return
								End If
								If Me._ListenerStatus = 4 Then
									Thread.Sleep(2000)
									processById.Kill()
									Return
								End If
								If Me._ListenerStatus = 5 Then
									MyBase.BeginInvoke(AddressOf Me.VerifyState)
									Thread.Sleep(2000)
									processById.Kill()
									Return
								End If
								If Me._ListenerStatus = 6 Then
									MyBase.BeginInvoke(AddressOf Me.VerifyState)
									Thread.Sleep(500)
									processById.Kill()
									Return
								End If
								If Me._ListenerStatus > 50 Then
									processById.Kill()
									MyBase.BeginInvoke(AddressOf Me.VerifyState)
									processById.WaitForExit(1000)
									FileSystem.Kill(fileName)
									Return
								End If
								processById.Kill()
								If Me._ListenerStatus <> 43 Then
									MyBase.BeginInvoke(AddressOf Me.VerifyState)
									Return
								End If
								Return
							End If
						End While
						GoTo IL_176
					End If
					Me._QueueStatus += 1
				End While
				GoTo IL_10A
			End If
		End Sub

		' Token: 0x0600003D RID: 61 RVA: 0x00003EB4 File Offset: 0x000020B4
		Private Sub InstantiateState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", ""))
				IL_29:
				num2 = 3
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\PublicProfile", "EnableFirewall", ""))
				IL_4B:
				num2 = 4
				If Not Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(objectValue, "1", False), Operators.CompareObjectEqual(objectValue2, "1", False))) Then
					GoTo IL_1C2
				End If
				IL_75:
				num2 = 5
				Me._PoolStatus += 1
				IL_85:
				num2 = 6
				If Me._PoolStatus > 5 Then
					GoTo IL_155
				End If
				IL_93:
				num2 = 7
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_B0:
				num2 = 8
				Interaction.Shell("netsh advfirewall set allprofiles state off", AppWinStyle.Hide, True, -1)
				IL_C0:
				num2 = 9
				FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", 0, 4)
				IL_DE:
				num2 = 10
				FilterStatus.ReadState(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\PublicProfile", "EnableFirewall", 0, 4)
				IL_FC:
				num2 = 11
				Me.m_AuthenticationStatus = True
				IL_106:
				num2 = 12
				TokenStatus.DisableState.Form3.shuoming.Text = "你启用了防火墙，危害电子教室的运行！"
				IL_122:
				num2 = 13
				TokenStatus.DisableState.Form3.shuoming2.Text = "现在助手强制关闭防火墙！"
				IL_13E:
				num2 = 14
				TokenStatus.DisableState.Form3.Show()
				GoTo IL_1E9
				IL_155:
				num2 = 16
				TokenStatus.DisableState.Form3.Close()
				IL_167:
				num2 = 17
				TokenStatus.DisableState.Form2.shuoming.Text = "你启用了防火墙，危害电子教室的运行！"
				IL_183:
				num2 = 18
				TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
				IL_19F:
				num2 = 19
				TokenStatus.DisableState.Form2.Show()
				IL_1B1:
				num2 = 20
				Me.Timer2.Enabled = True
				GoTo IL_1E9
				IL_1C2:
				num2 = 22
				If Not Me.m_AuthenticationStatus Then
					GoTo IL_1DF
				End If
				IL_1CD:
				num2 = 23
				TokenStatus.DisableState.Form3.Close()
				IL_1DF:
				num2 = 24
				Me.m_AuthenticationStatus = False
				IL_1E9:
				GoTo IL_2A1
				IL_1EE:
				GoTo IL_2AB
				IL_1F3:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_27C
				IL_205:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_27C:
				GoTo IL_2AB
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1F3
			End Try
			IL_2A1:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_2AB:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x0600003E RID: 62 RVA: 0x00004194 File Offset: 0x00002394
		Private Sub DestroyState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
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
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.CurrentUser, "Software", "n", ""))
				IL_3D:
				num2 = 4
				If Not Operators.ConditionalCompareObjectNotEqual(objectValue, Me._MockStatus, False) Then
					GoTo IL_14D
				End If
				IL_51:
				num2 = 5
				Me._ProcessStatus += 1
				IL_61:
				num2 = 6
				FilterStatus.ReadState(Registry.CurrentUser, "Software", "n", Me._MockStatus, 1)
				IL_7E:
				num2 = 7
				TokenStatus.DisableState.Form3.shuoming.Text = "你修改了助手的密码！"
				IL_99:
				num2 = 8
				TokenStatus.DisableState.Form3.shuoming2.Text = "现在强制恢复密码！"
				IL_B4:
				num2 = 9
				TokenStatus.DisableState.Form3.Show()
				IL_C6:
				num2 = 10
				Me._ListStatus = True
				IL_D0:
				num2 = 11
				If Me._ProcessStatus <= 25 Then
					GoTo IL_174
				End If
				IL_E0:
				num2 = 12
				TokenStatus.DisableState.Form3.Close()
				IL_F2:
				num2 = 13
				TokenStatus.DisableState.Form2.shuoming.Text = "你修改了助手的密码！"
				IL_10E:
				num2 = 14
				TokenStatus.DisableState.Form2.shuoming2.Text = "请重新启动电脑！"
				IL_12A:
				num2 = 15
				TokenStatus.DisableState.Form2.Show()
				IL_13C:
				num2 = 16
				Me.Timer2.Enabled = True
				GoTo IL_174
				IL_14D:
				num2 = 18
				If Not Me._ListStatus Then
					GoTo IL_16A
				End If
				IL_158:
				num2 = 19
				TokenStatus.DisableState.Form3.Close()
				IL_16A:
				num2 = 20
				Me._ListStatus = False
				IL_174:
				num2 = 21
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_196:
				num2 = 22
				If Not Operators.ConditionalCompareObjectEqual(objectValue2, "", False) Then
					GoTo IL_1C9
				End If
				IL_1A7:
				num2 = 23
				objectValue2 = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_1C9:
				num2 = 24
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				IL_1EC:
				num2 = 25
				If Not Operators.ConditionalCompareObjectEqual(objectValue3, "", False) Then
					GoTo IL_221
				End If
				IL_1FE:
				num2 = 26
				objectValue3 = RuntimeHelpers.GetObjectValue(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				IL_221:
				num2 = 27
				If Not Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(objectValue2, Me.fieldStatus, False), Operators.CompareObjectNotEqual(objectValue3, Me.m_ConnectionStatus, False))) Then
					GoTo IL_299
				End If
				IL_24B:
				num2 = 28
				FilterStatus.ReadState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", Application.StartupPath + "\przs.exe", 1)
				IL_272:
				num2 = 29
				FilterStatus.ReadState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", Application.StartupPath + "\jfglzsn.exe", 1)
				IL_299:
				GoTo IL_36C
				IL_29E:
				GoTo IL_377
				IL_2A3:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_346
				IL_2B9:
				Dim num5 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_346:
				GoTo IL_377
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2A3
			End Try
			IL_36C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_377:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x0600003F RID: 63 RVA: 0x00004540 File Offset: 0x00002740
		Private Sub InsertState(sender As Object, e As EventArgs)
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
				IL_0C:
				num2 = 3
				Dim num4 As Integer = 0
				IL_10:
				num2 = 4
				If Me._RuleStatus <> 1 Then
					GoTo IL_5F
				End If
				IL_1B:
				num2 = 5
				num3 = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "ChannelId", ""))
				IL_3C:
				num2 = 6
				num4 = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
				GoTo IL_AE
				IL_5F:
				num2 = 8
				If Me._RuleStatus <> 2 Then
					GoTo IL_AE
				End If
				IL_6A:
				num2 = 9
				num3 = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "ChannelId", ""))
				IL_8C:
				num2 = 10
				num4 = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
				IL_AE:
				num2 = 11
				If Not(num3 <> Me.m_InfoStatus Or num4 <> Me._InvocationStatus) Then
					GoTo IL_133
				End If
				IL_CC:
				num2 = 12
				Me.m_TaskStatus += 1
				IL_DD:
				num2 = 13
				TokenStatus.DisableState.Form3.shuoming.Text = "你修改了极域电子教室的参数！"
				IL_F9:
				num2 = 14
				TokenStatus.DisableState.Form3.shuoming2.Text = "请马上恢复，否则会锁屏！"
				IL_115:
				num2 = 15
				TokenStatus.DisableState.Form3.Show()
				IL_127:
				num2 = 16
				Me.m_SingletonStatus = True
				GoTo IL_15A
				IL_133:
				num2 = 18
				If Not Me.m_SingletonStatus Then
					GoTo IL_150
				End If
				IL_13E:
				num2 = 19
				TokenStatus.DisableState.Form3.Close()
				IL_150:
				num2 = 20
				Me.m_SingletonStatus = False
				IL_15A:
				num2 = 21
				If Me.m_TaskStatus <= 5 Then
					GoTo IL_1B5
				End If
				IL_166:
				num2 = 22
				TokenStatus.DisableState.Form3.Close()
				IL_178:
				num2 = 23
				TokenStatus.DisableState.Form2.shuoming.Text = "你修改了极域电子教室的参数！"
				IL_194:
				num2 = 24
				TokenStatus.DisableState.Form2.Show()
				IL_1A6:
				num2 = 25
				Me.Timer2.Enabled = True
				IL_1B5:
				num2 = 26
				If Not Me.m_RoleStatus Then
					GoTo IL_2FF
				End If
				IL_1C3:
				num2 = 27
				Me.m_ComposerStatus.Refresh()
				IL_1D1:
				num2 = 28
				Me.m_ReponseStatus.Refresh()
				IL_1DF:
				num2 = 29
				If Not(Me.m_ComposerStatus.Status = CType(0, ServiceControllerStatus) Or Me.m_ReponseStatus.Status = CType(0, ServiceControllerStatus)) Then
					GoTo IL_24F
				End If
				IL_201:
				num2 = 30
				Me._ExceptionStatus += 1
				IL_212:
				num2 = 31
				TokenStatus.DisableState.Form3.shuoming.Text = "极域电子教室的2个重要服务不存在！"
				IL_22E:
				num2 = 32
				TokenStatus.DisableState.Form3.Show()
				IL_240:
				num2 = 33
				Me.m_ComparatorStatus = True
				GoTo IL_2FF
				IL_24F:
				num2 = 35
				If Not(Me.m_ComposerStatus.Status = ServiceControllerStatus.Running And Me.m_ReponseStatus.Status = ServiceControllerStatus.Running) Then
					GoTo IL_29A
				End If
				IL_271:
				num2 = 36
				If Not Me.m_ComparatorStatus Then
					GoTo IL_28E
				End If
				IL_27C:
				num2 = 37
				TokenStatus.DisableState.Form3.Close()
				IL_28E:
				num2 = 38
				Me.m_ComparatorStatus = False
				GoTo IL_2FF
				IL_29A:
				num2 = 40
				Me.m_ComposerStatus.Start()
				IL_2A8:
				num2 = 41
				Me.m_ReponseStatus.Start()
				IL_2B6:
				num2 = 42
				Me._ExceptionStatus += 1
				IL_2C7:
				num2 = 43
				TokenStatus.DisableState.Form3.shuoming.Text = "极域电子教室的2个重要服务停止！"
				IL_2E3:
				num2 = 44
				TokenStatus.DisableState.Form3.Show()
				IL_2F5:
				num2 = 45
				Me.m_ComparatorStatus = True
				IL_2FF:
				num2 = 46
				If Me._ExceptionStatus <= 5 Then
					GoTo IL_35A
				End If
				IL_30B:
				num2 = 47
				TokenStatus.DisableState.Form3.Close()
				IL_31D:
				num2 = 48
				TokenStatus.DisableState.Form2.shuoming.Text = "极域电子教室的2个重要服务停止！"
				IL_339:
				num2 = 49
				TokenStatus.DisableState.Form2.Show()
				IL_34B:
				num2 = 50
				Me.Timer2.Enabled = True
				IL_35A:
				GoTo IL_481
				IL_35F:
				GoTo IL_48C
				IL_364:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_45B
				IL_37A:
				Dim num6 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_45B:
				GoTo IL_48C
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_364
			End Try
			IL_481:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_48C:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x06000040 RID: 64 RVA: 0x00004A00 File Offset: 0x00002C00
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

		' Token: 0x06000041 RID: 65 RVA: 0x00004ABC File Offset: 0x00002CBC
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

		' Token: 0x06000042 RID: 66 RVA: 0x00004BF4 File Offset: 0x00002DF4
		Private Sub NewState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num12 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				MyBase.Hide()
				IL_10:
				num2 = 3
				Dim num3 As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
				IL_28:
				num2 = 4
				Dim num4 As Integer = num3 Mod 7
				IL_2F:
				num2 = 5
				Dim num5 As Integer = num3 Mod 9
				IL_37:
				num2 = 6
				Dim num6 As Integer = num3 Mod 5
				IL_3D:
				num2 = 7
				Dim num7 As Integer = num3 Mod 3
				IL_44:
				num2 = 8
				If num3 Mod 2 <> 0 Then
					GoTo IL_92
				End If
				IL_4B:
				num2 = 9
				Dim text As String = Conversions.ToString(Strings.Chr(97 + num4)) + Conversions.ToString(Strings.Chr(98 + num5)) + Conversions.ToString(Strings.Chr(101 + num6)) + Conversions.ToString(Strings.Chr(99 + num7))
				GoTo IL_D7
				IL_92:
				num2 = 11
				text = Conversions.ToString(Strings.Chr(97 + num5)) + Conversions.ToString(Strings.Chr(98 + num4)) + Conversions.ToString(Strings.Chr(101 + num7)) + Conversions.ToString(Strings.Chr(99 + num6))
				IL_D7:
				num2 = 12
				FilterStatus.serializerStatus = text
				IL_E1:
				num2 = 13
				FilterStatus._SetterStatus = text + ".exe"
				IL_F5:
				num2 = 14
				VBMath.Randomize(CDbl(num3))
				IL_FF:
				num2 = 15
				Dim num8 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
				IL_12E:
				num2 = 16
				Dim text2 As String = ""
				IL_138:
				num2 = 17
				Dim num9 As Integer = 1
				Do
					IL_178:
					num2 = 18
					Dim num10 As Long = num8 Mod 10L + 105L
					IL_140:
					num2 = 19
					text2 = Conversions.ToString(Strings.Chr(CInt(num10))) + text2
					IL_159:
					num2 = 20
					num8 /= 10L
					IL_16A:
					num2 = 21
					num9 += 1
				Loop While num9 <= 5
				IL_195:
				num2 = 22
				FilterStatus.serializerStatus = text2
				IL_19F:
				num2 = 23
				FilterStatus._SetterStatus = text2 + ".exe"
				IL_1B3:
				num2 = 24
				Me.m_MapperStatus = "C:\Program Files (x86)\" + Strings.Mid(text2, 2, 4)
				IL_1CF:
				num2 = 25
				Me._RepositoryStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "dzjs", ""))
				IL_1F6:
				num2 = 26
				Me._PropertyStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "usb_jianche", ""))
				IL_21D:
				num2 = 27
				Me._GetterStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "shadu_jianche", ""))
				IL_244:
				num2 = 28
				Me.m_MapStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "cmd_jianche", ""))
				IL_26B:
				num2 = 29
				Me._AccountStatus = Strings.Split(Me._RepositoryStatus, ",", -1, CompareMethod.Binary)
				IL_286:
				num2 = 30
				If Not(Operators.CompareString(Me._AccountStatus(0), "other", False) = 0 Or Operators.CompareString(Me._AccountStatus(0), "", False) = 0) Then
					GoTo IL_2C4
				End If
				IL_2B8:
				num2 = 31
				Me.m_OrderStatus = 0
				GoTo IL_2F2
				IL_2C4:
				num2 = 33
				If Strings.InStr(Me._AccountStatus(0), "\", CompareMethod.Binary) = 0 Then
					GoTo IL_2E8
				End If
				IL_2DC:
				num2 = 34
				Me.m_OrderStatus = 2
				GoTo IL_2F2
				IL_2E8:
				num2 = 36
				Me.m_OrderStatus = 1
				IL_2F2:
				num2 = 37
				Me.m_ImporterStatus = Me._AccountStatus(0)
				IL_303:
				num2 = 38
				Me.m_ResolverStatus = Strings.Replace(Path.GetFileName(Me.m_ImporterStatus), ".exe", "", 1, -1, CompareMethod.Binary)
				IL_329:
				num2 = 39
				Me.classStatus(1) = "|备用"
				IL_339:
				num2 = 40
				Me.classStatus(2) = "|备用"
				IL_349:
				num2 = 41
				Me.classStatus(3) = "|备用"
				IL_359:
				num2 = 42
				Me.classStatus(4) = "|360safe.exe"
				IL_369:
				num2 = 43
				Me.classStatus(5) = "|HipsTray.exe"
				IL_379:
				num2 = 44
				Me.classStatus(6) = "|QQPCTray.exe"
				IL_389:
				num2 = 45
				Me.classStatus(7) = "|360taskmgr"
				IL_399:
				num2 = 46
				Me.classStatus(8) = "|QQPCNetFlow.exe"
				IL_3A9:
				num2 = 47
				Me.classStatus(9) = "|360netman.exe"
				IL_3BA:
				num2 = 48
				Me.classStatus(10) = "|iu杀毒"
				IL_3CB:
				num2 = 49
				Me.classStatus(11) = "进程"
				IL_3DC:
				num2 = 50
				Me.classStatus(12) = "任务管理"
				IL_3ED:
				num2 = 51
				Me.classStatus(13) = "虚拟桌面"
				IL_3FE:
				num2 = 52
				Me.classStatus(14) = "|Minesweeper"
				IL_40F:
				num2 = 53
				Me.classStatus(15) = "|winmine.exe"
				IL_420:
				num2 = 54
				Me.classStatus(16) = "|solitaire.exe"
				IL_431:
				num2 = 55
				Me.classStatus(17) = "|winrarrr.exe"
				IL_442:
				num2 = 56
				Me.classStatus(18) = "|wzmainnn.exe"
				IL_453:
				num2 = 57
				Me.classStatus(19) = "|bandizippp.exe"
				IL_464:
				num2 = 58
				Me.classStatus(20) = "|7zFMMM.exe"
				IL_475:
				num2 = 59
				Me.classStatus(21) = "|360zippp.exe"
				IL_486:
				num2 = 60
				Me.classStatus(22) = "掌控课堂"
				IL_497:
				num2 = 61
				Me.classStatus(23) = "夕颜若雪工具箱"
				IL_4A8:
				num2 = 62
				Me.classStatus(24) = "极域"
				IL_4B9:
				num2 = 63
				Me.classStatus(25) = "课堂狂欢器"
				IL_4CA:
				num2 = 64
				Me.classStatus(26) = "电子教室"
				IL_4DB:
				num2 = 65
				Me.classStatus(27) = "吾爱破解"
				IL_4EC:
				num2 = 66
				Me.classStatus(28) = "|NoTopDomain"
				IL_4FD:
				num2 = 67
				Me.productStatus(1) = "Windows 命令处理程序"
				IL_50D:
				num2 = 68
				Me.productStatus(2) = "Windows Command Processor"
				IL_51D:
				num2 = 69
				Me.productStatus(3) = "Windows PowerShell"
				IL_52D:
				num2 = 70
				Me.productStatus(4) = "注册表编辑器"
				IL_53D:
				num2 = 71
				Me.productStatus(5) = "Microsoft 管理控制台"
				IL_54D:
				num2 = 72
				Me.productStatus(6) = "任务管理器"
				IL_55D:
				num2 = 73
				Me.productStatus(7) = "PC Hunter"
				IL_56D:
				num2 = 74
				Me.productStatus(8) = "IceSword"
				IL_57D:
				num2 = 75
				Me.productStatus(9) = "Wsyscheck"
				IL_58E:
				num2 = 76
				Me.productStatus(10) = "SnipeSword"
				IL_59F:
				num2 = 77
				Me.productStatus(11) = "Process Explorer"
				IL_5B0:
				num2 = 78
				Me.productStatus(12) = "狡兔二窟"
				IL_5C1:
				num2 = 79
				Me.productStatus(13) = "Process-X"
				IL_5D2:
				num2 = 80
				Me.productStatus(14) = "Process Master"
				IL_5E3:
				num2 = 81
				Me.productStatus(15) = "PrcView"
				IL_5F4:
				num2 = 82
				Me.productStatus(16) = "Process Viewer"
				IL_605:
				num2 = 83
				Me.productStatus(17) = "PowerTool"
				IL_616:
				num2 = 84
				Me.productStatus(18) = "Windows Kernel Explorer"
				IL_627:
				num2 = 85
				Me.productStatus(19) = "FTCleaner"
				IL_638:
				num2 = 86
				Me.productStatus(20) = "Process Lasso"
				IL_649:
				num2 = 87
				Me.productStatus(21) = "process manager"
				IL_65A:
				num2 = 88
				Me.productStatus(22) = "Process Hacker"
				IL_66B:
				num2 = 89
				Me.productStatus(23) = "ProcessOVER"
				IL_67C:
				num2 = 90
				Me.productStatus(24) = "Dexpot"
				IL_68D:
				num2 = 91
				Me.productStatus(25) = "Deskman"
				IL_69E:
				num2 = 92
				Me.productStatus(26) = "iDesktop"
				IL_6AF:
				num2 = 93
				Me.productStatus(27) = "YtMDesk"
				IL_6C0:
				num2 = 94
				Me.productStatus(28) = "DexpotProPortable"
				IL_6D1:
				num2 = 95
				Me.productStatus(29) = "Desktops"
				IL_6E2:
				num2 = 96
				Me.productStatus(30) = "Wise Desktop"
				IL_6F3:
				num2 = 97
				Me.productStatus(31) = "VDesktop"
				IL_704:
				num2 = 98
				Me.productStatus(32) = "MagicDesktop"
				IL_715:
				num2 = 99
				Me.productStatus(33) = "MultiDesk"
				IL_726:
				num2 = 100
				Me.productStatus(34) = "小宝虚拟桌面"
				IL_737:
				num2 = 101
				Me.productStatus(35) = "系统配置实用程序"
				IL_748:
				num2 = 102
				Me.productStatus(36) = "资源和性能监视器"
				IL_759:
				num2 = 103
				Me.productStatus(37) = "Special Setting Program"
				IL_76A:
				num2 = 104
				Me.productStatus(38) = "瑞星防火墙"
				IL_77B:
				num2 = 105
				Me.productStatus(39) = "火绒剑"
				IL_78C:
				num2 = 106
				Me.productStatus(40) = "超级进程王"
				IL_79D:
				num2 = 107
				Me.productStatus(41) = "OpenArk"
				IL_7AE:
				num2 = 108
				Me.productStatus(42) = "Procmon"
				IL_7BF:
				num2 = 109
				Me.productStatus(43) = "GameBar"
				IL_7D0:
				num2 = 110
				Me.productStatus(44) = "Registry Workshop"
				IL_7E1:
				num2 = 111
				Me.productStatus(45) = "暂 时 备 用"
				IL_7F2:
				num2 = 112
				Me.productStatus(46) = "暂 时 备 用"
				IL_803:
				num2 = 113
				Me.productStatus(47) = "暂 时 备 用"
				IL_814:
				num2 = 114
				Me.productStatus(48) = "暂 时 备 用"
				IL_825:
				num2 = 115
				Me.productStatus(49) = "暂 时 备 用"
				IL_836:
				num2 = 116
				Me.productStatus(50) = "暂 时 备 用"
				IL_847:
				num2 = 117
				Me.productStatus(51) = "极域杀手"
				IL_858:
				num2 = 118
				Me.productStatus(52) = "极域墓地制造器"
				IL_869:
				num2 = 119
				Me.productStatus(53) = "极域杀死"
				IL_87A:
				num2 = 120
				Me.productStatus(54) = "翘课"
				IL_88B:
				num2 = 121
				Me.productStatus(55) = "夕颜若雪工具箱"
				IL_89C:
				num2 = 122
				Me.productStatus(56) = "学生机房Hack助手"
				IL_8AD:
				num2 = 123
				Me.productStatus(57) = "再见极域"
				IL_8BE:
				num2 = 124
				Me.productStatus(58) = "KillControl"
				IL_8CF:
				num2 = 125
				Me.productStatus(59) = "去除控制"
				IL_8E0:
				num2 = 126
				Me.productStatus(60) = "MsgFlood"
				IL_8F1:
				num2 = 127
				Me.productStatus(61) = "极域工具包"
				IL_902:
				num2 = 128
				Me.productStatus(62) = "Astrum For Online Classroom"
				IL_916:
				num2 = 129
				Me.productStatus(63) = "JiYu Trainer"
				IL_92A:
				num2 = 130
				Me.productStatus(64) = "掌控课堂"
				IL_93E:
				num2 = 131
				Me.productStatus(65) = "FuckMythware"
				IL_952:
				num2 = 132
				Me.productStatus(66) = "Hello Teacher"
				IL_966:
				num2 = 133
				Me.productStatus(67) = "JIYUPLUS"
				IL_97A:
				num2 = 134
				Me.productStatus(68) = "极域Tool"
				IL_98E:
				num2 = 135
				Me.productStatus(69) = "微机课救星"
				IL_9A2:
				num2 = 136
				Me.productStatus(70) = "极域X"
				IL_9B6:
				num2 = 137
				Me.productStatus(71) = "UnMythware"
				IL_9CA:
				num2 = 138
				Me.productStatus(72) = FilterStatus._ProcStatus
				IL_9DE:
				num2 = 139
				Me.productStatus(73) = "BITS管理实用程序"
				IL_9F2:
				num2 = 140
				Me.productStatus(74) = "DzjsTools"
				IL_A06:
				num2 = 141
				Me.productStatus(75) = "SkiesKiller"
				IL_A1A:
				num2 = 142
				Me.productStatus(76) = FilterStatus.m_ConsumerStatus
				IL_A2E:
				num2 = 143
				Me.productStatus(77) = "MultiDeskTop应用程序"
				IL_A42:
				num2 = 144
				Me.productStatus(78) = "极域电子教室克星"
				IL_A56:
				num2 = 145
				Me._DicStatus = 78
				IL_A64:
				num2 = 146
				Dim processesByName As Process() = Process.GetProcessesByName("taskmgr")
				IL_A76:
				num2 = 147
				processesByName(0).Kill()
				IL_A85:
				num2 = 148
				Dim query As WqlEventQuery = New WqlEventQuery("__InstanceCreationEvent", New TimeSpan(0, 0, 1), "TargetInstance ISA 'Win32_Process'")
				IL_AA4:
				num2 = 149
				Me._RegStatus = New ManagementEventWatcher(query)
				IL_AB7:
				num2 = 150
				AddHandler Me._RegStatus.EventArrived, AddressOf Me.CheckState
				IL_AD4:
				num2 = 151
				Me._RegStatus.Start()
				IL_AE5:
				num2 = 152
				Me.m_InfoStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "ChannelId", ""))
				IL_B0F:
				num2 = 153
				Me._InvocationStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\Wow6432Node\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
				IL_B39:
				num2 = 154
				If Me.m_InfoStatus = 0 Then
					GoTo IL_B6B
				End If
				IL_B47:
				num2 = 155
				Me._RuleStatus = 1
				IL_B54:
				num2 = 156
				Me.Timer_jiyu.Enabled = True
				GoTo IL_BEC
				IL_B6B:
				num2 = 158
				Me.m_InfoStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "ChannelId", ""))
				IL_B95:
				num2 = 159
				Me._InvocationStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\TopDomain\e-Learning Class\Student", "AutoLogin", ""))
				IL_BBF:
				num2 = 160
				If Me.m_InfoStatus = 0 Then
					GoTo IL_BEC
				End If
				IL_BCD:
				num2 = 161
				Me._RuleStatus = 2
				IL_BDA:
				num2 = 162
				Me.Timer_jiyu.Enabled = True
				IL_BEC:
				num2 = 163
				If Not(Me.m_ComposerStatus.Status = CType(0, ServiceControllerStatus) Or Me.m_ReponseStatus.Status = CType(0, ServiceControllerStatus)) Then
					GoTo IL_C23
				End If
				IL_C11:
				num2 = 164
				Me.m_RoleStatus = False
				GoTo IL_CAC
				IL_C23:
				num2 = 166
				If Not(Me.m_ComposerStatus.Status = ServiceControllerStatus.Stopped Or Me.m_ReponseStatus.Status = ServiceControllerStatus.Stopped) Then
					GoTo IL_C6A
				End If
				IL_C48:
				num2 = 167
				Me.m_ComposerStatus.Start()
				IL_C59:
				num2 = 168
				Me.m_ReponseStatus.Start()
				IL_C6A:
				num2 = 169
				Thread.Sleep(1000)
				IL_C7A:
				num2 = 170
				If Not(Me.m_ComposerStatus.Status = ServiceControllerStatus.Running And Me.m_ReponseStatus.Status = ServiceControllerStatus.Running) Then
					GoTo IL_CAC
				End If
				IL_C9F:
				num2 = 171
				Me.m_RoleStatus = True
				IL_CAC:
				num2 = 172
				Me._MockStatus = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software", "n", ""))
				IL_CD6:
				num2 = 173
				Me.fieldStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_D00:
				num2 = 174
				If Operators.CompareString(Me.fieldStatus, "", False) <> 0 Then
					GoTo IL_D43
				End If
				IL_D19:
				num2 = 175
				Me.fieldStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_D43:
				num2 = 176
				Me.m_ConnectionStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				IL_D6D:
				num2 = 177
				If Operators.CompareString(Me.m_ConnectionStatus, "", False) <> 0 Then
					GoTo IL_DB0
				End If
				IL_D86:
				num2 = 178
				Me.m_ConnectionStatus = Conversions.ToString(FilterStatus.SearchState(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn", ""))
				IL_DB0:
				num2 = 179
				Me.messageStatus = Conversions.ToInteger(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "gaowei", 2))
				IL_DDB:
				GoTo IL_1101
				IL_DE0:
				Dim num11 As Integer = num12 + 1
				num12 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num11)
				IL_10C0:
				GoTo IL_10F6
				IL_10C2:
				num12 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_10D3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_10C2
			End Try
			IL_10F6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1101:
			If num12 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000043 RID: 67 RVA: 0x00005D28 File Offset: 0x00003F28
		Private Function InterruptState(string_0 As String) As Boolean
			Return Process.GetProcessesByName(string_0).Length > 0
		End Function

		' Token: 0x06000044 RID: 68 RVA: 0x00005D48 File Offset: 0x00003F48
		Public Function GetWiredNetworkIP() As String
			Dim num As Integer
			Dim result As String
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				For Each networkInterface As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
					IL_20:
					num2 = 3
					If Not networkInterface.Description.ToLower().Contains("virtual") AndAlso networkInterface.OperationalStatus = 1 Then
						IL_44:
						num2 = 4
						Dim enumerator As IEnumerator(Of UnicastIPAddressInformation) = networkInterface.GetIPProperties().UnicastAddresses.GetEnumerator()
						While enumerator.MoveNext()
							Dim unicastIPAddressInformation As UnicastIPAddressInformation = enumerator.Current
							IL_62:
							num2 = 5
							If unicastIPAddressInformation.Address.AddressFamily = 2 AndAlso Not IPAddress.IsLoopback(unicastIPAddressInformation.Address) Then
								IL_B6:
								num2 = 6
								result = unicastIPAddressInformation.Address.ToString()
								GoTo IL_C6
							End If
							IL_81:
							num2 = 7
						End While
						IL_8B:
						num2 = 8
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
							GoTo IL_96
						End If
						GoTo IL_96
						IL_C6:
						GoTo IL_13A
					End If
					IL_96:
					num2 = 9
				Next
				IL_AA:
				num2 = 10
				result = String.Empty
				GoTo IL_C6
				IL_C8:
				GoTo IL_144
				IL_CA:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_118
				IL_DC:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_118:
				GoTo IL_144
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_CA
			End Try
			IL_13A:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
			IL_144:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Function

		' Token: 0x06000045 RID: 69 RVA: 0x00005EC4 File Offset: 0x000040C4
		Private Function CountState(string_0 As String, string_1 As String) As Integer
			Dim num As Integer = 1
			Dim num2 As Integer
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

		' Token: 0x06000046 RID: 70 RVA: 0x00005EF0 File Offset: 0x000040F0
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

		' Token: 0x06000047 RID: 71 RVA: 0x00005F98 File Offset: 0x00004198
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

		' Token: 0x06000048 RID: 72 RVA: 0x00002496 File Offset: 0x00000696
		Private Sub CreateState(sender As Object, e As EventArgs)
			If Not TokenStatus.DisableState.Form4.Visible Then
				TokenStatus.DisableState.Form4.Show()
			End If
		End Sub

		' Token: 0x06000049 RID: 73 RVA: 0x000024B8 File Offset: 0x000006B8
		Private Sub AssetState(sender As Object, e As FormClosingEventArgs)
			If Me._RegStatus IsNot Nothing Then
				Me._RegStatus.[Stop]()
				Me._RegStatus.Dispose()
			End If
		End Sub

		' Token: 0x0600004A RID: 74 RVA: 0x0000600C File Offset: 0x0000420C
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

		' Token: 0x0600004B RID: 75 RVA: 0x000060D4 File Offset: 0x000042D4
		Private Sub ConcatState()
			TokenStatus.DisableState.Form2.shuoming.Text = "你运行了杀毒类、虚拟机类的软件！危害电子教室运行，如有误判，请老师拍照与作者QQ联系。"
			TokenStatus.DisableState.Form2.shuoming3.Text = "gyhrw4yw4y3tq3yszz" + Strings.Replace(Me.m_TokenizerStatus, ".exe", "", 1, -1, CompareMethod.Binary) + "mmfnfxhghrts"
			TokenStatus.DisableState.Form2.Show()
			Me.Timer2.Enabled = True
		End Sub

		' Token: 0x0600004C RID: 76 RVA: 0x00006150 File Offset: 0x00004350
		Private Sub FindState(string_0 As String, string_1 As String)
			Dim num As Integer
			Dim num20 As Integer
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
				If Me.SelectState("223.5.5.5", 1500) Then
					GoTo IL_2E
				End If
				IL_20:
				num2 = 4
				Me.m_ParserStatus = False
				GoTo IL_47E
				IL_2E:
				num2 = 6
				Dim text As String = "c:\1.txt"
				IL_36:
				num2 = 7
				Using webClient As WebClient = New WebClient()
					webClient.DownloadFile(string_0, text)
				End Using
				IL_56:
				num2 = 8
				Dim array As String() = File.ReadAllLines(text)
				IL_60:
				num2 = 9
				If Strings.InStr(array(0), "www.", CompareMethod.Binary) <> 0 Then
					GoTo IL_83
				End If
				IL_74:
				num2 = 10
				Me.m_ParserStatus = False
				GoTo IL_47E
				IL_83:
				num2 = 12
				num3 = 0
				IL_88:
				num2 = 13
				Dim num4 As Integer
				Dim num5 As Integer
				Dim num6 As Integer
				Dim num7 As Integer
				Dim num8 As Integer
				Dim num9 As Integer
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
						num7 = num3 + 1
					End If
					IL_DF:
					num2 = 20
					If Operators.CompareString(left, "IP地址：", False) = 0 Then
						IL_F1:
						num2 = 21
						num8 = num3 - 1
						IL_F9:
						num2 = 22
						num9 = num3 + 1
					End If
					IL_101:
					num2 = 23
					num3 += 1
					IL_108:
					num2 = 24
				Next
				IL_11C:
				num2 = 25
				Dim num10 As Integer = num3 - 1
				IL_124:
				num2 = 26
				File.SetAttributes(Me._ContainerStatus, FileAttributes.Normal)
				IL_137:
				num2 = 27
				File.SetAttributes(Me._ContainerStatus, FileAttributes.Normal)
				IL_14A:
				num2 = 28
				Dim text2 As String = File.ReadAllText(Me._ContainerStatus)
				IL_15A:
				num2 = 29
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				IL_164:
				num2 = 30
				Dim array3 As String() = text2.Split(New String() { Environment.NewLine }, StringSplitOptions.None)
				IL_17F:
				num2 = 31
				For Each text3 As String In array3
					IL_192:
					num2 = 32
					If text3.Trim().StartsWith("127.0.0.1") Then
						IL_1A8:
						num2 = 33
						Dim array5 As String() = text3.Trim().Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
						IL_1C5:
						num2 = 34
						If array5.Length > 1 Then
							IL_1CF:
							num2 = 35
							hashSet.Add(array5(1).ToLower())
						End If
					End If
					IL_1E3:
					num2 = 36
				Next
				IL_1F4:
				num2 = 37
				Dim stringBuilder As StringBuilder = New StringBuilder(text2)
				IL_200:
				num2 = 38
				stringBuilder.AppendLine()
				IL_20B:
				num2 = 39
				Dim num11 As Integer = num4
				For k As Integer = 0 To num11
					IL_21A:
					num2 = 40
					If Not String.IsNullOrEmpty(array(k).Trim()) Then
						IL_22E:
						num2 = 41
						Dim text4 As String = array(k).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						IL_272:
						num2 = 42
						If Not hashSet.Contains(text4) Then
							IL_280:
							num2 = 43
							stringBuilder.AppendLine("127.0.0.1 " + text4)
						End If
					End If
					IL_297:
					num2 = 44
				Next
				IL_2A9:
				num2 = 45
				If Operators.CompareString(string_1, "off", False) <> 0 Then
					GoTo IL_35C
				End If
				IL_2BD:
				num2 = 46
				Dim num12 As Integer = num5
				Dim num13 As Integer = num6
				For l As Integer = num12 To num13
					IL_2CD:
					num2 = 47
					If Not String.IsNullOrEmpty(array(l).Trim()) Then
						IL_2E1:
						num2 = 48
						Dim text5 As String = array(l).Trim().Split(New Char() { "/"c })(0).Replace("http://", "").Replace("https://", "").ToLower()
						IL_325:
						num2 = 49
						If Not hashSet.Contains(text5) Then
							IL_333:
							num2 = 50
							stringBuilder.AppendLine("127.0.0.1 " + text5)
						End If
					End If
					IL_34A:
					num2 = 51
				Next
				IL_35C:
				num2 = 52
				Dim num14 As Integer = Me._DicStatus + 1
				IL_369:
				num2 = 53
				Dim num15 As Integer = num7
				Dim num16 As Integer = num8
				For m As Integer = num15 To num16
					IL_376:
					num2 = 54
					Me.productStatus(num14) = array(m)
					IL_387:
					num2 = 55
					num14 += 1
					IL_390:
					num2 = 56
				Next
				IL_39F:
				num2 = 57
				FilterStatus.ComputeState(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\route.exe")
				IL_3B1:
				num2 = 58
				Dim num17 As Integer = num9
				Dim num18 As Integer = num10
				For n As Integer = num17 To num18
					IL_3BE:
					num2 = 59
					Dim str As String = array(n)
					IL_3C8:
					num2 = 60
					Interaction.Shell("route add  " + str + " mask 255.255.255.255 0.0.0.0 metric 1", AppWinStyle.Hide, True, -1)
					IL_3E5:
					num2 = 61
				Next
				IL_3F4:
				num2 = 62
				FilterStatus.ReadState(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\route.exe", "Debugger", "null", 1)
				IL_411:
				num2 = 63
				File.WriteAllText(Me._ContainerStatus, stringBuilder.ToString())
				IL_426:
				num2 = 64
				Me.m_ParserStatus = True
				IL_430:
				num2 = 65
				File.SetAttributes(Me._ContainerStatus, File.GetAttributes(Me._ContainerStatus) Or FileAttributes.[ReadOnly] Or FileAttributes.Hidden Or FileAttributes.System)
				IL_44F:
				num2 = 66
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_46D:
				num2 = 67
				Interaction.Shell("ipconfig /flushdns", AppWinStyle.Hide, True, -1)
				IL_47E:
				GoTo IL_5E4
				IL_483:
				Dim num19 As Integer = num20 + 1
				num20 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num19)
				IL_5A3:
				GoTo IL_5D9
				IL_5A5:
				num20 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5B6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num20 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5A5
			End Try
			IL_5D9:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5E4:
			If num20 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600004D RID: 77 RVA: 0x00006780 File Offset: 0x00004980
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

		' Token: 0x0600004E RID: 78 RVA: 0x000067D8 File Offset: 0x000049D8
		Public Shared Sub ForceShutdown()
			Dim num As Integer = 0
			Form1.RtlAdjustPrivilege(19, 1, 0, num)
			Form1.NtShutdownSystem(2)
		End Sub

		' Token: 0x06000050 RID: 80 RVA: 0x0000683C File Offset: 0x00004A3C
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

		' Token: 0x1700000E RID: 14
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

		' Token: 0x1700000F RID: 15
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

		' Token: 0x17000010 RID: 16
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

		' Token: 0x17000011 RID: 17
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

		' Token: 0x17000012 RID: 18
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

		' Token: 0x17000013 RID: 19
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

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600005D RID: 93 RVA: 0x00002508 File Offset: 0x00000708
		' (set) Token: 0x0600005E RID: 94 RVA: 0x00002510 File Offset: 0x00000710
		Friend Overridable Property Timer_jcm As Timer

		' Token: 0x17000015 RID: 21
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

		' Token: 0x17000016 RID: 22
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

		' Token: 0x17000017 RID: 23
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

		' Token: 0x17000018 RID: 24
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

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000067 RID: 103 RVA: 0x00002539 File Offset: 0x00000739
		' (set) Token: 0x06000068 RID: 104 RVA: 0x00002541 File Offset: 0x00000741
		Friend Overridable Property Timer3 As Timer

		' Token: 0x1700001A RID: 26
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

		' Token: 0x1700001B RID: 27
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

		' Token: 0x04000011 RID: 17
		Private _CustomerStatus As Long

		' Token: 0x04000012 RID: 18
		Private _ExpressionStatus As Long

		' Token: 0x04000013 RID: 19
		Private _RecordStatus As Boolean

		' Token: 0x04000014 RID: 20
		Private _AttributeStatus As Boolean

		' Token: 0x04000015 RID: 21
		Private stubStatus As Boolean

		' Token: 0x04000016 RID: 22
		Private _PolicyStatus As Boolean

		' Token: 0x04000017 RID: 23
		Private m_AuthenticationStatus As Boolean

		' Token: 0x04000018 RID: 24
		Private m_SingletonStatus As Boolean

		' Token: 0x04000019 RID: 25
		Private m_ComparatorStatus As Boolean

		' Token: 0x0400001A RID: 26
		Private _ListStatus As Boolean

		' Token: 0x0400001B RID: 27
		Private _RequestStatus As Boolean

		' Token: 0x0400001C RID: 28
		Private m_ObjectStatus As Boolean

		' Token: 0x0400001D RID: 29
		Private _ServerStatus As Boolean

		' Token: 0x0400001E RID: 30
		Private _GetterStatus As String

		' Token: 0x0400001F RID: 31
		Private _PropertyStatus As String

		' Token: 0x04000020 RID: 32
		Private m_MapStatus As String

		' Token: 0x04000021 RID: 33
		Private _RepositoryStatus As String

		' Token: 0x04000022 RID: 34
		Private _AccountStatus As String()

		' Token: 0x04000023 RID: 35
		Private classStatus As String()

		' Token: 0x04000024 RID: 36
		Private productStatus As String()

		' Token: 0x04000025 RID: 37
		Private _DicStatus As Integer

		' Token: 0x04000026 RID: 38
		Private _RegistryStatus As String

		' Token: 0x04000027 RID: 39
		Private m_PredicateStatus As String

		' Token: 0x04000028 RID: 40
		Private annotationStatus As Integer

		' Token: 0x04000029 RID: 41
		Private m_OrderStatus As Integer

		' Token: 0x0400002A RID: 42
		Private refStatus As String

		' Token: 0x0400002B RID: 43
		Private _PoolStatus As Integer

		' Token: 0x0400002C RID: 44
		Private m_IndexerStatus As Integer

		' Token: 0x0400002D RID: 45
		Private collectionStatus As Integer

		' Token: 0x0400002E RID: 46
		Private bridgeStatus As Integer

		' Token: 0x0400002F RID: 47
		Private m_ValueStatus As Integer

		' Token: 0x04000030 RID: 48
		Private _ProcessStatus As Integer

		' Token: 0x04000031 RID: 49
		Private m_TaskStatus As Integer

		' Token: 0x04000032 RID: 50
		Private _ExceptionStatus As Integer

		' Token: 0x04000033 RID: 51
		Private systemStatus As Integer

		' Token: 0x04000034 RID: 52
		Private m_ValStatus As Integer

		' Token: 0x04000035 RID: 53
		Private m_CandidateStatus As Integer

		' Token: 0x04000036 RID: 54
		Private methodStatus As Long

		' Token: 0x04000037 RID: 55
		Private m_InfoStatus As Integer

		' Token: 0x04000038 RID: 56
		Private _InvocationStatus As Integer

		' Token: 0x04000039 RID: 57
		Private _RuleStatus As Integer

		' Token: 0x0400003A RID: 58
		Private m_RoleStatus As Boolean

		' Token: 0x0400003B RID: 59
		Private _MockStatus As String

		' Token: 0x0400003C RID: 60
		Private fieldStatus As String

		' Token: 0x0400003D RID: 61
		Private m_ConnectionStatus As String

		' Token: 0x0400003E RID: 62
		Private m_MapperStatus As String

		' Token: 0x0400003F RID: 63
		Private m_ComposerStatus As ServiceController

		' Token: 0x04000040 RID: 64
		Private m_ReponseStatus As ServiceController

		' Token: 0x04000041 RID: 65
		Private _InstanceStatus As String

		' Token: 0x04000042 RID: 66
		Private _ListenerStatus As Integer

		' Token: 0x04000043 RID: 67
		Private messageStatus As Integer

		' Token: 0x04000044 RID: 68
		Private helperStatus As String

		' Token: 0x04000045 RID: 69
		Private m_ParserStatus As Boolean

		' Token: 0x04000046 RID: 70
		Private printerStatus As String

		' Token: 0x04000047 RID: 71
		Private _FactoryStatus As String

		' Token: 0x04000048 RID: 72
		Private _ContainerStatus As String

		' Token: 0x04000049 RID: 73
		Private _QueueStatus As Integer

		' Token: 0x0400004A RID: 74
		Public Const WM_DEVICECHANGE As Integer = 537

		' Token: 0x0400004B RID: 75
		Public Const DBT_DEVICEARRIVAL As Integer = 32768

		' Token: 0x0400004C RID: 76
		Public Const DBT_CONFIGCHANGECANCELED As Integer = 25

		' Token: 0x0400004D RID: 77
		Public Const DBT_CONFIGCHANGED As Integer = 24

		' Token: 0x0400004E RID: 78
		Public Const DBT_CUSTOMEVENT As Integer = 32774

		' Token: 0x0400004F RID: 79
		Public Const DBT_DEVICEQUERYREMOVE As Integer = 32769

		' Token: 0x04000050 RID: 80
		Public Const DBT_DEVICEQUERYREMOVEFAILED As Integer = 32770

		' Token: 0x04000051 RID: 81
		Public Const DBT_DEVICEREMOVECOMPLETE As Integer = 32772

		' Token: 0x04000052 RID: 82
		Public Const DBT_DEVICEREMOVEPENDING As Integer = 32771

		' Token: 0x04000053 RID: 83
		Public Const DBT_DEVICETYPESPECIFIC As Integer = 32773

		' Token: 0x04000054 RID: 84
		Public Const DBT_DEVNODES_CHANGED As Integer = 7

		' Token: 0x04000055 RID: 85
		Public Const DBT_QUERYCHANGECONFIG As Integer = 23

		' Token: 0x04000056 RID: 86
		Public Const DBT_USERDEFINED As Integer = 65535

		' Token: 0x04000057 RID: 87
		Private _RegStatus As ManagementEventWatcher

		' Token: 0x04000058 RID: 88
		Private m_TokenizerStatus As String

		' Token: 0x04000059 RID: 89
		Private m_ResolverStatus As String

		' Token: 0x0400005A RID: 90
		Private m_ImporterStatus As String

		' Token: 0x0400005B RID: 91
		Private attrStatus As String

		' Token: 0x0400005C RID: 92
		Private Const m_ParamStatus As Integer = 19

		' Token: 0x0400005D RID: 93
		Private Const tagStatus As Integer = 0

		' Token: 0x0400005E RID: 94
		Private Const _AdapterStatus As Integer = 1

		' Token: 0x0400005F RID: 95
		Private Const m_PrototypeStatus As Integer = 2

		' Token: 0x04000060 RID: 96
		Private Const descriptorStatus As Integer = 2

		' Token: 0x04000061 RID: 97
		Private Const _PageStatus As Byte = 17

		' Token: 0x04000062 RID: 98
		Private Const m_IdentifierStatus As Byte = 76

		' Token: 0x04000063 RID: 99
		Private Const exporterStatus As Byte = 67

		' Token: 0x04000064 RID: 100
		Private Const m_WrapperStatus As Byte = 87

		' Token: 0x04000065 RID: 101
		Private Const _IteratorStatus As Byte = 18

		' Token: 0x04000066 RID: 102
		Private Const m_VisitorStatus As Byte = 115

		' Token: 0x04000067 RID: 103
		Private Const publisherStatus As Byte = 27

		' Token: 0x04000068 RID: 104
		Private m_ObserverStatus As List(Of String)

		' Token: 0x04000069 RID: 105
		Private _UtilsStatus As List(Of String)

		' Token: 0x0400006A RID: 106
		Private m_WorkerStatus As String

		' Token: 0x0400006B RID: 107
		Private m_MappingStatus As Long

		' Token: 0x0400006C RID: 108
		Private _AdvisorStatus As Long

		' Token: 0x0400006D RID: 109
		Private _ErrorStatus As String

		' Token: 0x0400006E RID: 110
		Private contextStatus As Boolean

		' Token: 0x04000070 RID: 112
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer1")>
		Private configStatus As Timer

		' Token: 0x04000071 RID: 113
		<AccessedThroughProperty("Timer2")>
		<CompilerGenerated()>
		Private creatorStatus As Timer

		' Token: 0x04000072 RID: 114
		<AccessedThroughProperty("Timer_main")>
		<CompilerGenerated()>
		Private _TestsStatus As Timer

		' Token: 0x04000073 RID: 115
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_usb")>
		Private _ParamsStatus As Timer

		' Token: 0x04000074 RID: 116
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_dzjs")>
		Private m_ProducerStatus As Timer

		' Token: 0x04000075 RID: 117
		<AccessedThroughProperty("Timer_wangluo")>
		<CompilerGenerated()>
		Private m_BroadcasterStatus As Timer

		' Token: 0x04000076 RID: 118
		<AccessedThroughProperty("Timer_jcm")>
		<CompilerGenerated()>
		Private m_ParameterStatus As Timer

		' Token: 0x04000077 RID: 119
		<AccessedThroughProperty("Timer_fhq")>
		<CompilerGenerated()>
		Private _ProxyStatus As Timer

		' Token: 0x04000078 RID: 120
		<AccessedThroughProperty("Timer_qdx")>
		<CompilerGenerated()>
		Private _MerchantStatus As Timer

		' Token: 0x04000079 RID: 121
		<AccessedThroughProperty("Timer4")>
		<CompilerGenerated()>
		Private _TestStatus As Timer

		' Token: 0x0400007A RID: 122
		<AccessedThroughProperty("Timer_jiyu")>
		<CompilerGenerated()>
		Private callbackStatus As Timer

		' Token: 0x0400007B RID: 123
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer3")>
		Private _ConfigurationStatus As Timer

		' Token: 0x0400007C RID: 124
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_updatehosts")>
		Private _ItemStatus As Timer

		' Token: 0x0400007D RID: 125
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_route")>
		Private facadeStatus As Timer

		' Token: 0x0200000C RID: 12
		Public Enum ProcessStatus
			' Token: 0x0400007F RID: 127
			Running
			' Token: 0x04000080 RID: 128
			Suspended
			' Token: 0x04000081 RID: 129
			NotResponding
			' Token: 0x04000082 RID: 130
			NotFound
		End Enum
	End Class
End Namespace
