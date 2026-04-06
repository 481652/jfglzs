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
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class Form3
		Inherits Form

		' Token: 0x0600004A RID: 74 RVA: 0x00002518 File Offset: 0x00000718
		Public Sub New()
			Me.InstantiatePolicy()
		End Sub

		' Token: 0x0600004C RID: 76 RVA: 0x00003360 File Offset: 0x00001560
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

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x0600004D RID: 77 RVA: 0x00002526 File Offset: 0x00000726
		' (set) Token: 0x0600004E RID: 78 RVA: 0x0000252E File Offset: 0x0000072E
		Friend Overridable Property Label1 As Label

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00002537 File Offset: 0x00000737
		' (set) Token: 0x06000050 RID: 80 RVA: 0x0000253F File Offset: 0x0000073F
		Friend Overridable Property Label3 As Label

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000051 RID: 81 RVA: 0x00002548 File Offset: 0x00000748
		' (set) Token: 0x06000052 RID: 82 RVA: 0x00002550 File Offset: 0x00000750
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x1700001A RID: 26
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

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000055 RID: 85 RVA: 0x00002561 File Offset: 0x00000761
		' (set) Token: 0x06000056 RID: 86 RVA: 0x00002569 File Offset: 0x00000769
		Friend Overridable Property Label2 As Label

		' Token: 0x06000057 RID: 87 RVA: 0x000036A8 File Offset: 0x000018A8
		Private Sub MovePolicy(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				If Strings.Len(Me.TextBox1.Text) >= 6 Then
					GoTo IL_46
				End If
				IL_1D:
				num2 = 3
				Me.Label1.Text = "密码应该是6位以上的字母或数字，请重新输入！"
				IL_2F:
				num2 = 4
				Me.TextBox1.Text = ""
				GoTo IL_1A2
				IL_46:
				num2 = 6
				Dim left As String = IteratorWrapper.ResetPolicy(Strings.Trim(Me.TextBox1.Text))
				IL_5F:
				num2 = 7
				Dim right As String = Conversions.ToString(IteratorWrapper.DisablePolicy(Registry.CurrentUser, "Software", "n", ""))
				IL_81:
				num2 = 8
				If Operators.CompareString(left, right, False) <> 0 Then
					GoTo IL_17C
				End If
				IL_92:
				num2 = 9
				Me.Button1.Enabled = False
				IL_A1:
				num2 = 10
				Me.Label1.Text = ""
				IL_B4:
				num2 = 11
				Me.ReflectPolicy()
				IL_BD:
				num2 = 12
				Me.ChangePolicy()
				IL_C6:
				num2 = 13
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 3, 4)
				IL_E4:
				num2 = 14
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 3, 4)
				IL_102:
				num2 = 15
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 3, 4)
				IL_120:
				num2 = 16
				IteratorWrapper.InterruptPolicy(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 3, 4)
				IL_13E:
				num2 = 17
				For Each process As Process In Process.GetProcessesByName("explorer")
					IL_155:
					num2 = 18
					process.Kill()
					IL_15F:
					num2 = 19
				Next
				IL_16C:
				num2 = 20
				Process.Start("explorer.exe")
				GoTo IL_1A2
				IL_17C:
				num2 = 22
				Me.Label1.Text = "密码不正确，请重新输入！"
				IL_18F:
				num2 = 23
				Me.TextBox1.Text = ""
				IL_1A2:
				GoTo IL_25A
				IL_1A7:
				GoTo IL_265
				IL_1AC:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_234
				IL_1BF:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_234:
				GoTo IL_265
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1AC
			End Try
			IL_25A:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_265:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x06000058 RID: 88 RVA: 0x000028DC File Offset: 0x00000ADC
		Private Function WritePolicy(string_0 As String) As Boolean
			Return Process.GetProcessesByName(string_0).Length > 0
		End Function

		' Token: 0x06000059 RID: 89 RVA: 0x00003944 File Offset: 0x00001B44
		Private Sub ReflectPolicy()
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Me.Button1.Enabled = False
				IL_16:
				num2 = 3
				Dim text As String = "zmserv"
				IL_1F:
				num2 = 4
				IL_21:
				num2 = 5
				Dim text2 As String = Conversions.ToString(IteratorWrapper.eventWrapper)
				IL_2E:
				num2 = 6
				Dim text3 As String = "jfglzsn"
				Dim processesByName As Process()
				Dim processesByName2 As Process()
				Do
					IL_79:
					num2 = 8
					IL_39:
					num2 = 9
					processesByName = Process.GetProcessesByName(text2)
					IL_43:
					num2 = 10
					processesByName(0).Kill()
					IL_4E:
					num2 = 11
					processesByName2 = Process.GetProcessesByName(text3)
					IL_5A:
					num2 = 12
					processesByName2(0).Kill()
					IL_66:
					num2 = 13
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				IL_7D:
				num2 = 16
				Dim num3 As Integer = 10
				IL_84:
				num2 = 17
				num3 = num3 * 10 + 2
				IL_90:
				num2 = 18
				For Each process As Process In Process.GetProcesses()
					IL_AF:
					num2 = 19
					Dim num4 As Integer = Strings.Len(process.ProcessName)
					IL_C0:
					num2 = 20
					If num4 >= 4 Then
						IL_C8:
						num2 = 22
						Dim num5 As Integer = num4
						Dim j As Integer = 1
						While j <= num5
							IL_D4:
							num2 = 23
							Dim num6 As Integer = Strings.Asc(Strings.Mid(process.ProcessName, j, 1))
							IL_ED:
							num2 = 24
							If num6 >= num3 Then
								IL_F6:
								num2 = 26
								If num6 <= num3 + 9 Then
									IL_102:
									num2 = 28
									j += 1
									Continue While
								End If
							End If
							IL_12B:
							num2 = 29
							If j = num4 + 1 Then
								IL_113:
								num2 = 30
								process.Kill()
								GoTo IL_11D
							End If
							GoTo IL_11D
						End While
						GoTo IL_12B
					End If
					IL_11D:
					num2 = 31
				Next
				IL_138:
				num2 = 32
				IteratorWrapper.InterruptPolicy(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_156:
				num2 = 33
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_167:
				num2 = 34
				Thread.Sleep(3000)
				IL_174:
				num2 = 35
				Dim processesByName3 As Process() = Process.GetProcessesByName(text)
				IL_180:
				num2 = 36
				processesByName3(0).Kill()
				Do
					IL_1CE:
					num2 = 38
					IL_18E:
					num2 = 39
					processesByName = Process.GetProcessesByName(text2)
					IL_198:
					num2 = 40
					processesByName(0).Kill()
					IL_1A3:
					num2 = 41
					processesByName2 = Process.GetProcessesByName(text3)
					IL_1AF:
					num2 = 42
					processesByName2(0).Kill()
					IL_1BB:
					num2 = 43
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				IL_1D3:
				num2 = 46
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_1E4:
				num2 = 47
				Thread.Sleep(2000)
				IL_1F1:
				num2 = 48
				If Not(Not Me.WritePolicy("jfglzsn") And Not Me.WritePolicy(Conversions.ToString(IteratorWrapper.eventWrapper))) Then
					GoTo IL_233
				End If
				IL_218:
				num2 = 49
				Interaction.MsgBox("退出程序成功！", MsgBoxStyle.OkOnly, Nothing)
				IL_228:
				num2 = 50
				MyBase.Close()
				GoTo IL_252
				IL_233:
				num2 = 52
				Interaction.MsgBox("退出程序不成功！请重新执行退出程序命令或重启电脑", MsgBoxStyle.OkOnly, Nothing)
				IL_243:
				num2 = 53
				Me.Button1.Enabled = True
				IL_252:
				GoTo IL_385
				IL_257:
				GoTo IL_390
				IL_25C:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_35F
				IL_272:
				Dim num8 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_35F:
				GoTo IL_390
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_25C
			End Try
			IL_385:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_390:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x00003D08 File Offset: 0x00001F08
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

		' Token: 0x0600005B RID: 91 RVA: 0x00003EF0 File Offset: 0x000020F0
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

		' Token: 0x0400001D RID: 29
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private _ParamsWrapper As Label

		' Token: 0x0400001E RID: 30
		<CompilerGenerated()>
		<AccessedThroughProperty("Label3")>
		Private _TagWrapper As Label

		' Token: 0x0400001F RID: 31
		<CompilerGenerated()>
		<AccessedThroughProperty("TextBox1")>
		Private poolWrapper As TextBox

		' Token: 0x04000020 RID: 32
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private serverWrapper As Button

		' Token: 0x04000021 RID: 33
		<CompilerGenerated()>
		<AccessedThroughProperty("Label2")>
		Private printerWrapper As Label
	End Class
End Namespace
