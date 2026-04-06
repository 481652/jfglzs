Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports WindowsApplication1.Internal

Namespace WindowsApplication1
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class Form2
		Inherits Form

		' Token: 0x0600006D RID: 109 RVA: 0x0000255A File Offset: 0x0000075A
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.IncludeState
			AddHandler MyBase.Load, AddressOf Me.CallState
			Me.QueryState()
		End Sub

		' Token: 0x0600006F RID: 111 RVA: 0x00006DFC File Offset: 0x00004FFC
		<DebuggerStepThrough()>
		Private Sub QueryState()
			Me.m_ClientStatus = New Container()
			Me.Button2 = New Button()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.TextBox1 = New TextBox()
			Me.Button1 = New Button()
			Me.shuoming = New Label()
			Me.Timer_frm2 = New Timer(Me.m_ClientStatus)
			Me.shuoming2 = New Label()
			Me.Label_pd = New Label()
			Me.shuoming3 = New Label()
			MyBase.SuspendLayout()
			Me.Button2.Location = New Point(389, 17)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Size(82, 28)
			Me.Button2.TabIndex = 15
			Me.Button2.Text = "重启电脑"
			Me.Button2.UseVisualStyleBackColor = True
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label2.ForeColor = Color.DarkRed
			Me.Label2.Location = New Point(34, 65)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Size(0, 14)
			Me.Label2.TabIndex = 14
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label1.ForeColor = Color.White
			Me.Label1.Location = New Point(61, 23)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(119, 14)
			Me.Label1.TabIndex = 13
			Me.Label1.Text = "退出小助手密码："
			Me.TextBox1.Location = New Point(196, 19)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = "*"c
			Me.TextBox1.Size = New Size(104, 21)
			Me.TextBox1.TabIndex = 12
			Me.Button1.Location = New Point(311, 16)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Size(54, 27)
			Me.Button1.TabIndex = 11
			Me.Button1.Text = "确 定"
			Me.Button1.UseVisualStyleBackColor = True
			Me.shuoming.AutoSize = True
			Me.shuoming.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.shuoming.ForeColor = Color.Red
			Me.shuoming.Location = New Point(152, 299)
			Me.shuoming.Name = "shuoming"
			Me.shuoming.Size = New Size(1136, 35)
			Me.shuoming.TabIndex = 16
			Me.shuoming.Text = "你运行的软件危害电子教室运行！如有误判，请老师拍照与作者QQ联系。"
			Me.Timer_frm2.Interval = 1000
			Me.shuoming2.AutoSize = True
			Me.shuoming2.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.shuoming2.ForeColor = Color.Red
			Me.shuoming2.Location = New Point(152, 372)
			Me.shuoming2.Name = "shuoming2"
			Me.shuoming2.Size = New Size(33, 35)
			Me.shuoming2.TabIndex = 17
			Me.shuoming2.Text = " "
			Me.Label_pd.AutoSize = True
			Me.Label_pd.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label_pd.Location = New Point(1, 2)
			Me.Label_pd.Name = "Label_pd"
			Me.Label_pd.Size = New Size(51, 35)
			Me.Label_pd.TabIndex = 18
			Me.Label_pd.Text = "  "
			Me.shuoming3.AutoSize = True
			Me.shuoming3.Font = New Font("宋体", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.shuoming3.ForeColor = SystemColors.ActiveCaptionText
			Me.shuoming3.Location = New Point(669, 125)
			Me.shuoming3.Name = "shuoming3"
			Me.shuoming3.Size = New Size(409, 19)
			Me.shuoming3.TabIndex = 19
			Me.shuoming3.Text = "                                        "
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Highlight
			MyBase.ClientSize = New Size(1518, 1092)
			MyBase.Controls.Add(Me.shuoming3)
			MyBase.Controls.Add(Me.Label_pd)
			MyBase.Controls.Add(Me.shuoming2)
			MyBase.Controls.Add(Me.shuoming)
			MyBase.Controls.Add(Me.Button2)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Button1)
			MyBase.FormBorderStyle = FormBorderStyle.None
			MyBase.Name = "Form2"
			MyBase.ShowInTaskbar = False
			Me.Text = "Form2"
			MyBase.TopMost = True
			MyBase.WindowState = FormWindowState.Maximized
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000070 RID: 112 RVA: 0x0000258C File Offset: 0x0000078C
		' (set) Token: 0x06000071 RID: 113 RVA: 0x00007430 File Offset: 0x00005630
		Friend Overridable Property Button2 As Button
			<CompilerGenerated()>
			Get
				Return Me._WatcherStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.TestState
				Dim watcherStatus As Button = Me._WatcherStatus
				If watcherStatus IsNot Nothing Then
					RemoveHandler watcherStatus.Click, value2
				End If
				Me._WatcherStatus = value
				watcherStatus = Me._WatcherStatus
				If watcherStatus IsNot Nothing Then
					AddHandler watcherStatus.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000072 RID: 114 RVA: 0x00002594 File Offset: 0x00000794
		' (set) Token: 0x06000073 RID: 115 RVA: 0x0000259C File Offset: 0x0000079C
		Friend Overridable Property Label2 As Label

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000074 RID: 116 RVA: 0x000025A5 File Offset: 0x000007A5
		' (set) Token: 0x06000075 RID: 117 RVA: 0x000025AD File Offset: 0x000007AD
		Friend Overridable Property Label1 As Label

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000076 RID: 118 RVA: 0x000025B6 File Offset: 0x000007B6
		' (set) Token: 0x06000077 RID: 119 RVA: 0x000025BE File Offset: 0x000007BE
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000078 RID: 120 RVA: 0x000025C7 File Offset: 0x000007C7
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00007474 File Offset: 0x00005674
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me.serviceStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.ReflectState
				Dim button As Button = Me.serviceStatus
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me.serviceStatus = value
				button = Me.serviceStatus
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600007A RID: 122 RVA: 0x000025CF File Offset: 0x000007CF
		' (set) Token: 0x0600007B RID: 123 RVA: 0x000025D7 File Offset: 0x000007D7
		Friend Overridable Property shuoming As Label

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x0600007C RID: 124 RVA: 0x000025E0 File Offset: 0x000007E0
		' (set) Token: 0x0600007D RID: 125 RVA: 0x000074B8 File Offset: 0x000056B8
		Friend Overridable Property Timer_frm2 As Timer
			<CompilerGenerated()>
			Get
				Return Me.rulesStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.RunState
				Dim timer As Timer = Me.rulesStatus
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.rulesStatus = value
				timer = Me.rulesStatus
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x0600007E RID: 126 RVA: 0x000025E8 File Offset: 0x000007E8
		' (set) Token: 0x0600007F RID: 127 RVA: 0x000025F0 File Offset: 0x000007F0
		Friend Overridable Property shuoming2 As Label

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000080 RID: 128 RVA: 0x000025F9 File Offset: 0x000007F9
		' (set) Token: 0x06000081 RID: 129 RVA: 0x000074FC File Offset: 0x000056FC
		Friend Overridable Property Label_pd As Label
			<CompilerGenerated()>
			Get
				Return Me.m_TemplateStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.ChangeState
				Dim templateStatus As Label = Me.m_TemplateStatus
				If templateStatus IsNot Nothing Then
					RemoveHandler templateStatus.DoubleClick, value2
				End If
				Me.m_TemplateStatus = value
				templateStatus = Me.m_TemplateStatus
				If templateStatus IsNot Nothing Then
					AddHandler templateStatus.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x06000082 RID: 130 RVA: 0x00002601 File Offset: 0x00000801
		' (set) Token: 0x06000083 RID: 131 RVA: 0x00002609 File Offset: 0x00000809
		Friend Overridable Property shuoming3 As Label

		' Token: 0x06000084 RID: 132
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form2.RECT) As Integer

		' Token: 0x06000085 RID: 133
		Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

		' Token: 0x06000086 RID: 134 RVA: 0x00007540 File Offset: 0x00005740
		Private Sub ReflectState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
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
				Me.Label2.Text = "密码应该是6位以上的字母或数字，请重新输入！"
				IL_2F:
				num2 = 4
				Me.TextBox1.Text = ""
				GoTo IL_CD
				IL_46:
				num2 = 6
				Dim left As String = FilterStatus.DeleteState(Strings.Trim(Me.TextBox1.Text))
				IL_5E:
				num2 = 7
				Dim right As String = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software", "n", ""))
				IL_80:
				num2 = 8
				If Operators.CompareString(left, right, False) <> 0 Then
					GoTo IL_A7
				End If
				IL_8D:
				num2 = 9
				Me.Button1.Enabled = False
				IL_9C:
				num2 = 10
				Me.GetState()
				GoTo IL_CD
				IL_A7:
				num2 = 12
				Me.Label2.Text = "密码不正确，请重新输入！"
				IL_BA:
				num2 = 13
				Me.TextBox1.Text = ""
				IL_CD:
				GoTo IL_157
				IL_D2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_118:
				GoTo IL_14C
				IL_11A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_12A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_11A
			End Try
			IL_14C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_157:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000087 RID: 135 RVA: 0x000076C8 File Offset: 0x000058C8
		Private Sub RunState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				MyBase.TopMost = True
				IL_11:
				num2 = 3
				Dim lpRect As Form2.RECT
				lpRect.Left = 0
				IL_1B:
				num2 = 4
				lpRect.Top = 0
				IL_25:
				num2 = 5
				lpRect.Right = 800
				IL_33:
				num2 = 6
				lpRect.Bottom = 100
				IL_3E:
				num2 = 7
				Form2.ClipCursor(lpRect)
				IL_47:
				num2 = 8
				Me.m_InitializerStatus += 1
				IL_57:
				num2 = 9
				If Me.m_InitializerStatus < 5 Then
					GoTo IL_7E
				End If
				IL_63:
				num2 = 10
				Form2.Beep(2000L, 500L)
				IL_7E:
				GoTo IL_F2
				IL_80:
				GoTo IL_FC
				IL_82:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_D0
				IL_94:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_D0:
				GoTo IL_FC
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_82
			End Try
			IL_F2:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_FC:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x06000088 RID: 136 RVA: 0x000077EC File Offset: 0x000059EC
		Private Sub ChangeState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				GoTo IL_5F
				IL_0A:
				Dim num2 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_20:
				GoTo IL_54
				IL_22:
				Dim num4 As Integer
				num3 = num4
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_32:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_22
			End Try
			IL_54:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5F:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000089 RID: 137 RVA: 0x00007870 File Offset: 0x00005A70
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub GetState()
			Dim num As Integer
			Dim num7 As Integer
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
				Dim text2 As String = Conversions.ToString(FilterStatus.serializerStatus)
				Dim processesByName As Process()
				Do
					IL_48:
					num2 = 6
					IL_26:
					num2 = 7
					processesByName = Process.GetProcessesByName(text2)
					IL_32:
					num2 = 8
					processesByName(0).Kill()
					IL_3E:
					num2 = 9
				Loop While processesByName.Length <> 0
				IL_4D:
				num2 = 12
				Dim num3 As Integer = 10
				IL_55:
				num2 = 13
				num3 = num3 * 10 + 2
				IL_62:
				num2 = 14
				For Each process As Process In Process.GetProcesses()
					IL_7F:
					num2 = 15
					Dim num4 As Integer = Strings.Len(process.ProcessName)
					IL_91:
					num2 = 16
					If num4 >= 4 Then
						IL_9A:
						num2 = 18
						Dim num5 As Integer = num4
						Dim j As Integer = 1
						While j <= num5
							IL_A5:
							num2 = 19
							Dim num6 As Integer = Strings.Asc(Strings.Mid(process.ProcessName, j, 1))
							IL_BE:
							num2 = 20
							If num6 >= num3 Then
								IL_C8:
								num2 = 22
								If num6 <= num3 + 9 Then
									IL_D5:
									num2 = 24
									j += 1
									Continue While
								End If
							End If
							IL_FD:
							num2 = 25
							If j = num4 + 1 Then
								IL_E3:
								num2 = 26
								process.Kill()
								GoTo IL_EE
							End If
							GoTo IL_EE
						End While
						GoTo IL_FD
					End If
					IL_EE:
					num2 = 27
				Next
				IL_10A:
				num2 = 28
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_129:
				num2 = 29
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_13B:
				num2 = 30
				Thread.Sleep(3000)
				IL_149:
				num2 = 31
				Dim processesByName2 As Process() = Process.GetProcessesByName(text)
				IL_156:
				num2 = 32
				processesByName2(0).Kill()
				IL_163:
				num2 = 33
				Dim lpRect As Form2.RECT
				lpRect.Left = 0
				IL_16F:
				num2 = 34
				lpRect.Top = 0
				IL_17B:
				num2 = 35
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				IL_199:
				num2 = 36
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				IL_1B7:
				num2 = 37
				Form2.ClipCursor(lpRect)
				ProjectData.EndApp()
				IL_1C8:
				GoTo IL_2BC
				IL_1CD:
				GoTo IL_2C7
				IL_1D2:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_296
				IL_1E9:
				Dim num8 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_296:
				GoTo IL_2C7
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1D2
			End Try
			IL_2BC:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_2C7:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x0600008A RID: 138 RVA: 0x00002612 File Offset: 0x00000812
		Private Sub IncludeState(sender As Object, e As FormClosingEventArgs)
			e.Cancel = True
		End Sub

		' Token: 0x0600008B RID: 139 RVA: 0x00007B6C File Offset: 0x00005D6C
		Private Sub CallState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Me.Timer_frm2.Enabled = True
				IL_16:
				GoTo IL_6A
				IL_18:
				GoTo IL_74
				IL_1A:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_48
				IL_2C:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_48:
				GoTo IL_74
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1A
			End Try
			IL_6A:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_74:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x0600008C RID: 140 RVA: 0x00007C08 File Offset: 0x00005E08
		Private Sub TestState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Interaction.Shell("shutdown /r /f /t 0", AppWinStyle.MinimizedFocus, False, -1)
				IL_18:
				GoTo IL_73
				IL_1A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_34:
				GoTo IL_68
				IL_36:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_46:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_36
			End Try
			IL_68:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_73:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x04000084 RID: 132
		<CompilerGenerated()>
		<AccessedThroughProperty("Button2")>
		Private _WatcherStatus As Button

		' Token: 0x04000085 RID: 133
		<AccessedThroughProperty("Label2")>
		<CompilerGenerated()>
		Private strategyStatus As Label

		' Token: 0x04000086 RID: 134
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private m_DatabaseStatus As Label

		' Token: 0x04000087 RID: 135
		<AccessedThroughProperty("TextBox1")>
		<CompilerGenerated()>
		Private readerStatus As TextBox

		' Token: 0x04000088 RID: 136
		<AccessedThroughProperty("Button1")>
		<CompilerGenerated()>
		Private serviceStatus As Button

		' Token: 0x04000089 RID: 137
		<AccessedThroughProperty("shuoming")>
		<CompilerGenerated()>
		Private _EventStatus As Label

		' Token: 0x0400008A RID: 138
		<AccessedThroughProperty("Timer_frm2")>
		<CompilerGenerated()>
		Private rulesStatus As Timer

		' Token: 0x0400008B RID: 139
		<AccessedThroughProperty("shuoming2")>
		<CompilerGenerated()>
		Private structStatus As Label

		' Token: 0x0400008C RID: 140
		<AccessedThroughProperty("Label_pd")>
		<CompilerGenerated()>
		Private m_TemplateStatus As Label

		' Token: 0x0400008D RID: 141
		<CompilerGenerated()>
		<AccessedThroughProperty("shuoming3")>
		Private m_AlgoStatus As Label

		' Token: 0x0400008E RID: 142
		Private m_InitializerStatus As Integer

		' Token: 0x0200000E RID: 14
		Public Structure RECT
			' Token: 0x0400008F RID: 143
			Public Left As Integer

			' Token: 0x04000090 RID: 144
			Public Top As Integer

			' Token: 0x04000091 RID: 145
			Public Right As Integer

			' Token: 0x04000092 RID: 146
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
