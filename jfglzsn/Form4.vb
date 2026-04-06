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
	Public Partial Class Form4
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.RevertState
			AddHandler MyBase.Load, AddressOf Me.MoveStatus
			Me.ManageState()
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub ManageState()
			Me.m_StateToken = New Container()
			Me.Button2 = New Button()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.TextBox1 = New TextBox()
			Me.Button1 = New Button()
			Me.shuoming = New Label()
			Me.Timer_frm4 = New Timer(Me.m_StateToken)
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
			Me.shuoming.Size = New Size(33, 35)
			Me.shuoming.TabIndex = 16
			Me.shuoming.Text = " "
			Me.Timer_frm4.Interval = 1000
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
			Me.Label_pd.Location = New Point(1, 3)
			Me.Label_pd.Name = "Label_pd"
			Me.Label_pd.Size = New Size(51, 35)
			Me.Label_pd.TabIndex = 18
			Me.Label_pd.Text = "  "
			Me.shuoming3.AutoSize = True
			Me.shuoming3.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.shuoming3.ForeColor = SystemColors.ActiveCaptionText
			Me.shuoming3.Location = New Point(922, 103)
			Me.shuoming3.Name = "shuoming3"
			Me.shuoming3.Size = New Size(245, 12)
			Me.shuoming3.TabIndex = 19
			Me.shuoming3.Text = "                                        "
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Highlight
			MyBase.ClientSize = New Size(1254, 729)
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
			MyBase.Name = "Form4"
			MyBase.ShowInTaskbar = False
			Me.Text = "Form2"
			MyBase.TopMost = True
			MyBase.WindowState = FormWindowState.Maximized
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

	
		' (get) Token: 0x060000A7 RID: 167 RVA: 0x000026AA File Offset: 0x000008AA
		' (set) Token: 0x060000A8 RID: 168 RVA: 0x00008934 File Offset: 0x00006B34
		Friend Overridable Property Button2 As Button
			<CompilerGenerated()>
			Get
				Return Me.statusToken
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.PatchStatus
				Dim button As Button = Me.statusToken
				If button IsNot Nothing Then
					RemoveHandler button.Click, value2
				End If
				Me.statusToken = value
				button = Me.statusToken
				If button IsNot Nothing Then
					AddHandler button.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x060000A9 RID: 169 RVA: 0x000026B2 File Offset: 0x000008B2
		' (set) Token: 0x060000AA RID: 170 RVA: 0x000026BA File Offset: 0x000008BA
		Friend Overridable Property Label2 As Label

	
		' (get) Token: 0x060000AB RID: 171 RVA: 0x000026C3 File Offset: 0x000008C3
		' (set) Token: 0x060000AC RID: 172 RVA: 0x000026CB File Offset: 0x000008CB
		Friend Overridable Property Label1 As Label

	
		' (get) Token: 0x060000AD RID: 173 RVA: 0x000026D4 File Offset: 0x000008D4
		' (set) Token: 0x060000AE RID: 174 RVA: 0x000026DC File Offset: 0x000008DC
		Friend Overridable Property TextBox1 As TextBox

	
		' (get) Token: 0x060000AF RID: 175 RVA: 0x000026E5 File Offset: 0x000008E5
		' (set) Token: 0x060000B0 RID: 176 RVA: 0x00008978 File Offset: 0x00006B78
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me.m_CodeToken
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.ResetState
				Dim codeToken As Button = Me.m_CodeToken
				If codeToken IsNot Nothing Then
					RemoveHandler codeToken.Click, value2
				End If
				Me.m_CodeToken = value
				codeToken = Me.m_CodeToken
				If codeToken IsNot Nothing Then
					AddHandler codeToken.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x060000B1 RID: 177 RVA: 0x000026ED File Offset: 0x000008ED
		' (set) Token: 0x060000B2 RID: 178 RVA: 0x000026F5 File Offset: 0x000008F5
		Friend Overridable Property shuoming As Label

	
		' (get) Token: 0x060000B3 RID: 179 RVA: 0x000026FE File Offset: 0x000008FE
		' (set) Token: 0x060000B4 RID: 180 RVA: 0x000089BC File Offset: 0x00006BBC
		Friend Overridable Property Timer_frm4 As Timer
			<CompilerGenerated()>
			Get
				Return Me.specificationToken
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.PushState
				Dim timer As Timer = Me.specificationToken
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.specificationToken = value
				timer = Me.specificationToken
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x060000B5 RID: 181 RVA: 0x00002706 File Offset: 0x00000906
		' (set) Token: 0x060000B6 RID: 182 RVA: 0x0000270E File Offset: 0x0000090E
		Friend Overridable Property shuoming2 As Label

	
		' (get) Token: 0x060000B7 RID: 183 RVA: 0x00002717 File Offset: 0x00000917
		' (set) Token: 0x060000B8 RID: 184 RVA: 0x00008A00 File Offset: 0x00006C00
		Friend Overridable Property Label_pd As Label
			<CompilerGenerated()>
			Get
				Return Me._CustomerToken
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.UpdateState
				Dim customerToken As Label = Me._CustomerToken
				If customerToken IsNot Nothing Then
					RemoveHandler customerToken.DoubleClick, value2
				End If
				Me._CustomerToken = value
				customerToken = Me._CustomerToken
				If customerToken IsNot Nothing Then
					AddHandler customerToken.DoubleClick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x060000B9 RID: 185 RVA: 0x0000271F File Offset: 0x0000091F
		' (set) Token: 0x060000BA RID: 186 RVA: 0x00002727 File Offset: 0x00000927
		Friend Overridable Property shuoming3 As Label

	
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form4.RECT) As Integer

	
		Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

	
		Private Sub ResetState(sender As Object, e As EventArgs)
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
				Dim right2 As String = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "n2", ""))
				If Not(Operators.CompareString(left, right, False) = 0 Or Operators.CompareString(left, right2, False) = 0) Then
				End If
				Me.Button1.Enabled = False
				Me.AddState()
				Me.Label2.Text = "密码不正确，请重新输入！"
				Me.TextBox1.Text = ""
				Dim num3 As Integer = num4 + 1
				num4 = num2

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try

			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub PushState(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				MyBase.TopMost = True
				Dim lpRect As Form4.RECT
				lpRect.Left = 0
				lpRect.Top = 0
				lpRect.Right = 800
				lpRect.Bottom = 100
				Form4.ClipCursor(lpRect)
				Me.m_RecordToken += 1
				If Me.m_RecordToken < 5 Then
				End If
				Form4.Beep(2000L, 500L)
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub UpdateState(sender As Object, e As EventArgs)
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num2 = num3
				Dim num4 As Integer = num2 + 1
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub AddState()
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
				Dim num7 As Integer = Conversions.ToInteger(FilterStatus.SearchState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", ""))
				If num7 <> 1 Then
				End If
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				Thread.Sleep(3000)
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 1, 4)
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				Thread.Sleep(3000)
				Dim processesByName2 As Process() = Process.GetProcessesByName(text)
				processesByName2(0).Kill()
				Dim lpRect As Form4.RECT
				lpRect.Left = 0
				lpRect.Top = 0
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				Form4.ClipCursor(lpRect)
				ProjectData.EndApp()
				Dim num8 As Integer = num9 + 1
				num9 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try

			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub RevertState(sender As Object, e As FormClosingEventArgs)
			If FilterStatus._GlobalStatus Then
				e.Cancel = True
				Return
			End If
			e.Cancel = False
			Dim lpRect As Form4.RECT
			lpRect.Left = 0
			lpRect.Top = 0
			lpRect.Right = Screen.PrimaryScreen.Bounds.Width
			lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
			Form4.ClipCursor(lpRect)
		End Sub

	
		Private Sub MoveStatus(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Me.Timer_frm4.Enabled = True
				Dim num3 As Integer = num4 + 1
				num4 = num2

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try

			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub PatchStatus(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Interaction.Shell("shutdown /r /f /t 0", AppWinStyle.MinimizedFocus, False, -1)
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button2")>
		Private statusToken As Button

	
		<AccessedThroughProperty("Label2")>
		<CompilerGenerated()>
		Private _TokenToken As Label

	
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private modelToken As Label

	
		<AccessedThroughProperty("TextBox1")>
		<CompilerGenerated()>
		Private m_ManagerToken As TextBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private m_CodeToken As Button

	
		<AccessedThroughProperty("shuoming")>
		<CompilerGenerated()>
		Private issuerToken As Label

	
		<AccessedThroughProperty("Timer_frm4")>
		<CompilerGenerated()>
		Private specificationToken As Timer

	
		<CompilerGenerated()>
		<AccessedThroughProperty("shuoming2")>
		Private proccesorToken As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label_pd")>
		Private _CustomerToken As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("shuoming3")>
		Private expressionToken As Label

	
		Private m_RecordToken As Integer

	
		Public Structure RECT
		
			Public Left As Integer

		
			Public Top As Integer

		
			Public Right As Integer

		
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
