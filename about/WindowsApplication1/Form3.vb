Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports about.Internal
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace WindowsApplication1

	<DesignerGenerated()>
	Public Partial Class Form3
		Inherits Form

	
		Public Sub New()
			Me.InstantiatePolicy()
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub InstantiatePolicy()
			Me.Label1 = New Label()
			Me.Label3 = New Label()
			Me.TextBox1 = New TextBox()
			Me.Button1 = New Button()
			Me.Label2 = New Label()
			MyBase.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Color.Red
			Me.Label1.Location = New Point(56, 112)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(0, 12)
			Me.Label1.TabIndex = 19
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label3.ForeColor = Color.DarkRed
			Me.Label3.Location = New Point(37, 46)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Size(119, 14)
			Me.Label3.TabIndex = 18
			Me.Label3.Text = "输入小助手密码："
			Me.TextBox1.Location = New Point(172, 42)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = "*"c
			Me.TextBox1.Size = New Size(104, 21)
			Me.TextBox1.TabIndex = 17
			Me.Button1.Location = New Point(294, 39)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Size(96, 27)
			Me.Button1.TabIndex = 16
			Me.Button1.Text = "退出(需10秒)"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label2.AutoSize = True
			Me.Label2.Location = New Point(38, 87)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Size(287, 12)
			Me.Label2.TabIndex = 21
			Me.Label2.Text = "注：用密码退出后可使用U盘、下载文件，停止监控。"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(417, 181)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Name = "Form3"
			Me.Text = "退出程序"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

	
		' (get) Token: 0x0600004D RID: 77 RVA: 0x00002526 File Offset: 0x00000726
		' (set) Token: 0x0600004E RID: 78 RVA: 0x0000252E File Offset: 0x0000072E
		Friend Overridable Property Label1 As Label

	
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00002537 File Offset: 0x00000737
		' (set) Token: 0x06000050 RID: 80 RVA: 0x0000253F File Offset: 0x0000073F
		Friend Overridable Property Label3 As Label

	
		' (get) Token: 0x06000051 RID: 81 RVA: 0x00002548 File Offset: 0x00000748
		' (set) Token: 0x06000052 RID: 82 RVA: 0x00002550 File Offset: 0x00000750
		Friend Overridable Property TextBox1 As TextBox

	
		' (get) Token: 0x06000053 RID: 83 RVA: 0x00002559 File Offset: 0x00000759
		' (set) Token: 0x06000054 RID: 84 RVA: 0x00003664 File Offset: 0x00001864
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me.serverWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.MovePolicy
				Dim button As Button = Me.serverWrapper
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me.serverWrapper = value
				button = Me.serverWrapper
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000055 RID: 85 RVA: 0x00002561 File Offset: 0x00000761
		' (set) Token: 0x06000056 RID: 86 RVA: 0x00002569 File Offset: 0x00000769
		Friend Overridable Property Label2 As Label

	
		Private Sub MovePolicy(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				If Strings.Len(Me.TextBox1.Text) >= 6 Then
				End If
				Me.Label1.Text = "密码应该是6位以上的字母或数字，请重新输入！"
				Me.TextBox1.Text = ""
				Dim left As String = IteratorWrapper.ResetPolicy(Strings.Trim(Me.TextBox1.Text))
				Dim right As String = Conversions.ToString(IteratorWrapper.DisablePolicy(Registry.CurrentUser, "Software", "n", ""))
				If Operators.CompareString(left, right, False) <> 0 Then
				End If
				Me.Button1.Enabled = False
				Me.Label1.Text = ""
				Me.ReflectPolicy()
				Me.ChangePolicy()
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 3, 4)
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 3, 4)
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 3, 4)
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 3, 4)
				For Each process As Process In Process.GetProcessesByName("explorer")
					process.Kill()
				Next
				Process.Start("explorer.exe")
				Me.Label1.Text = "密码不正确，请重新输入！"
				Me.TextBox1.Text = ""
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return

			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Function WritePolicy(string_0 As String) As Boolean
			Return Process.GetProcessesByName(string_0).Length > 0
		End Function

	
		Private Sub ReflectPolicy()
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Me.Button1.Enabled = False
				Dim text As String = "zmserv"
				Dim text2 As String = Conversions.ToString(IteratorWrapper.eventWrapper)
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
				IteratorWrapper.InterruptPolicy(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				Thread.Sleep(3000)
				Dim processesByName3 As Process() = Process.GetProcessesByName(text)
				processesByName3(0).Kill()
				Do
					processesByName = Process.GetProcessesByName(text2)
					processesByName(0).Kill()
					processesByName2 = Process.GetProcessesByName(text3)
					processesByName2(0).Kill()
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				Thread.Sleep(2000)
				If Not(Not Me.WritePolicy("jfglzsn") And Not Me.WritePolicy(Conversions.ToString(IteratorWrapper.eventWrapper))) Then
				End If
				Interaction.MsgBox("退出程序成功！", MsgBoxStyle.OkOnly, Nothing)
				MyBase.Close()
				Interaction.MsgBox("退出程序不成功！请重新执行退出程序命令或重启电脑", MsgBoxStyle.OkOnly, Nothing)
				Me.Button1.Enabled = True
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try

			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return

			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub ChangePolicy()
			IteratorWrapper.InterruptPolicy(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 1, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 1, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 0, 4)
			IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 0, 4)
			Dim processesByName As Process() = Process.GetProcessesByName("chrome")
			For i As Integer = 0 To processesByName.Length - 1
				processesByName(i).Kill()
			Next
			Dim processesByName2 As Process() = Process.GetProcessesByName("msedge")
			For j As Integer = 0 To processesByName2.Length - 1
				processesByName2(j).Kill()
			Next
			Dim processesByName3 As Process() = Process.GetProcessesByName("firefox")
			For k As Integer = 0 To processesByName3.Length - 1
				processesByName3(k).Kill()
			Next
			Dim processesByName4 As Process() = Process.GetProcessesByName("iexplorer")
			For l As Integer = 0 To processesByName4.Length - 1
				processesByName4(l).Kill()
			Next
		End Sub

	
		Public Function pc_num() As Integer
			Dim environmentVariable As String = Environment.GetEnvironmentVariable("COMPUTERNAME")
			Dim result As Integer
			If environmentVariable.Length > 0 Then
				' The following expression was wrapped in a checked-expression
				result = Strings.Asc(environmentVariable(environmentVariable.Length - 1))
			Else
				result = 88
			End If
			Return result
		End Function

	
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private _ParamsWrapper As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label3")>
		Private _TagWrapper As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("TextBox1")>
		Private poolWrapper As TextBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private serverWrapper As Button

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label2")>
		Private printerWrapper As Label
	End Class
End Namespace
