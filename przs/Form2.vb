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
Imports przs.Internal

' Token: 0x0200000D RID: 13
<DesignerGenerated()>
Public Partial Class Form2
	Inherits Form

	Public Sub New()
		AddHandler MyBase.FormClosing, AddressOf Me.LoginAttribute
		AddHandler MyBase.Load, AddressOf Me.CustomizeAttribute
		Me.ValidateAttribute()
	End Sub

	<DebuggerStepThrough()>
	Private Sub ValidateAttribute()
		Me._Rule = New Container()
		Me.shuoming = New Label()
		Me.Button2 = New Button()
		Me.Label2 = New Label()
		Me.Label1 = New Label()
		Me.TextBox1 = New TextBox()
		Me.Button1 = New Button()
		Me.Timer_frm2 = New Timer(Me._Rule)
		Me.Label_pd = New Label()
		Me.shuoming2 = New Label()
		Me.shuoming3 = New Label()
		MyBase.SuspendLayout()
		Me.shuoming.AutoSize = True
		Me.shuoming.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.shuoming.ForeColor = Color.Red
		Me.shuoming.Location = New Point(160, 221)
		Me.shuoming.Name = "shuoming"
		Me.shuoming.Size = New Size(33, 35)
		Me.shuoming.TabIndex = 11
		Me.shuoming.Text = " "
		Me.Button2.Location = New Point(382, 20)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New Size(82, 28)
		Me.Button2.TabIndex = 10
		Me.Button2.Text = "重启电脑"
		Me.Button2.UseVisualStyleBackColor = True
		Me.Label2.AutoSize = True
		Me.Label2.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.Label2.ForeColor = Color.DarkRed
		Me.Label2.Location = New Point(27, 68)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New Size(0, 14)
		Me.Label2.TabIndex = 9
		Me.Label1.AutoSize = True
		Me.Label1.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.Label1.ForeColor = Color.White
		Me.Label1.Location = New Point(54, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New Size(119, 14)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "退出小助手密码："
		Me.TextBox1.Location = New Point(189, 22)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.PasswordChar = "*"c
		Me.TextBox1.Size = New Size(104, 21)
		Me.TextBox1.TabIndex = 7
		Me.Button1.Location = New Point(304, 19)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New Size(54, 27)
		Me.Button1.TabIndex = 6
		Me.Button1.Text = "确 定"
		Me.Button1.UseVisualStyleBackColor = True
		Me.Timer_frm2.Interval = 1000
		Me.Label_pd.AutoSize = True
		Me.Label_pd.BackColor = SystemColors.Highlight
		Me.Label_pd.Font = New Font("宋体", 24F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.Label_pd.Location = New Point(470, 19)
		Me.Label_pd.Name = "Label_pd"
		Me.Label_pd.Size = New Size(95, 33)
		Me.Label_pd.TabIndex = 12
		Me.Label_pd.Text = "     "
		Me.shuoming2.AutoSize = True
		Me.shuoming2.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.shuoming2.ForeColor = Color.Red
		Me.shuoming2.Location = New Point(160, 301)
		Me.shuoming2.Name = "shuoming2"
		Me.shuoming2.Size = New Size(33, 35)
		Me.shuoming2.TabIndex = 18
		Me.shuoming2.Text = " "
		Me.shuoming3.AutoSize = True
		Me.shuoming3.Location = New Point(173, 431)
		Me.shuoming3.Name = "shuoming3"
		Me.shuoming3.Size = New Size(0, 12)
		Me.shuoming3.TabIndex = 22
		MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
		MyBase.AutoScaleMode = AutoScaleMode.Font
		Me.BackColor = SystemColors.Highlight
		MyBase.ClientSize = New Size(918, 727)
		MyBase.Controls.Add(Me.shuoming3)
		MyBase.Controls.Add(Me.shuoming2)
		MyBase.Controls.Add(Me.Label_pd)
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

	' (get) Token: 0x0600005A RID: 90 RVA: 0x000025BD File Offset: 0x000007BD
	' (set) Token: 0x0600005B RID: 91 RVA: 0x000025C5 File Offset: 0x000007C5
	Friend Overridable Property shuoming As Label

	' (get) Token: 0x0600005C RID: 92 RVA: 0x000025CE File Offset: 0x000007CE
	' (set) Token: 0x0600005D RID: 93 RVA: 0x00005C48 File Offset: 0x00003E48
	Friend Overridable Property Button2 As Button
		<CompilerGenerated()>
		Get
			Return Me.m_Manager
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Button)
			Dim value2 As EventHandler = AddressOf Me.StartAttribute
			Dim manager As Button = Me.m_Manager
			If manager IsNot Nothing Then
				RemoveHandler manager.Click, value2
			End If
			Me.m_Manager = value
			manager = Me.m_Manager
			If manager IsNot Nothing Then
				AddHandler manager.Click, value2
			End If
		End Set
	End Property

	' (get) Token: 0x0600005E RID: 94 RVA: 0x000025D6 File Offset: 0x000007D6
	' (set) Token: 0x0600005F RID: 95 RVA: 0x000025DE File Offset: 0x000007DE
	Friend Overridable Property Label2 As Label

	' (get) Token: 0x06000060 RID: 96 RVA: 0x000025E7 File Offset: 0x000007E7
	' (set) Token: 0x06000061 RID: 97 RVA: 0x000025EF File Offset: 0x000007EF
	Friend Overridable Property Label1 As Label

	' (get) Token: 0x06000062 RID: 98 RVA: 0x000025F8 File Offset: 0x000007F8
	' (set) Token: 0x06000063 RID: 99 RVA: 0x00002600 File Offset: 0x00000800
	Friend Overridable Property TextBox1 As TextBox

	' (get) Token: 0x06000064 RID: 100 RVA: 0x00002609 File Offset: 0x00000809
	' (set) Token: 0x06000065 RID: 101 RVA: 0x00005C8C File Offset: 0x00003E8C
	Friend Overridable Property Button1 As Button
		<CompilerGenerated()>
		Get
			Return Me.registry
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Button)
			Dim value2 As EventHandler = AddressOf Me.InterruptAttribute
			Dim button As Button = Me.registry
			If button IsNot Nothing Then
				RemoveHandler button.Click, value2
			End If
			Me.registry = value
			button = Me.registry
			If button IsNot Nothing Then
				AddHandler button.Click, value2
			End If
		End Set
	End Property

	' (get) Token: 0x06000066 RID: 102 RVA: 0x00002611 File Offset: 0x00000811
	' (set) Token: 0x06000067 RID: 103 RVA: 0x00005CD0 File Offset: 0x00003ED0
	Friend Overridable Property Timer_frm2 As Timer
		<CompilerGenerated()>
		Get
			Return Me._Reponse
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.AwakeAttribute
			Dim reponse As Timer = Me._Reponse
			If reponse IsNot Nothing Then
				RemoveHandler reponse.Tick, value2
			End If
			Me._Reponse = value
			reponse = Me._Reponse
			If reponse IsNot Nothing Then
				AddHandler reponse.Tick, value2
			End If
		End Set
	End Property

	' (get) Token: 0x06000068 RID: 104 RVA: 0x00002619 File Offset: 0x00000819
	' (set) Token: 0x06000069 RID: 105 RVA: 0x00005D14 File Offset: 0x00003F14
	Friend Overridable Property Label_pd As Label
		<CompilerGenerated()>
		Get
			Return Me._Expression
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Label)
			Dim value2 As EventHandler = AddressOf Me.ResolveAttribute
			Dim expression As Label = Me._Expression
			If expression IsNot Nothing Then
				RemoveHandler expression.DoubleClick, value2
			End If
			Me._Expression = value
			expression = Me._Expression
			If expression IsNot Nothing Then
				AddHandler expression.DoubleClick, value2
			End If
		End Set
	End Property

	' (get) Token: 0x0600006A RID: 106 RVA: 0x00002621 File Offset: 0x00000821
	' (set) Token: 0x0600006B RID: 107 RVA: 0x00002629 File Offset: 0x00000829
	Friend Overridable Property shuoming2 As Label

	' (get) Token: 0x0600006C RID: 108 RVA: 0x00002632 File Offset: 0x00000832
	' (set) Token: 0x0600006D RID: 109 RVA: 0x0000263A File Offset: 0x0000083A
	Friend Overridable Property shuoming3 As Label

	Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form2.RECT) As Integer

	Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

	Private Sub InterruptAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			If Strings.Len(Me.TextBox1.Text) >= 6 Then
			End If
			Me.Label2.Text = "密码应该是6位以上的字母或数字，请重新输入！"
			Me.TextBox1.Text = ""
			Dim left As String = przs.Internal.Message.CloneAttribute(Strings.Trim(Me.TextBox1.Text))
			Dim right As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software", "n", ""))
			If Operators.CompareString(left, right, False) <> 0 Then
			End If
			Me.Label2.Text = ""
			Me.Button1.Enabled = False
			Me.ResetAttribute()
			Me.Label2.Text = "密码不正确，请重新输入！"
			Me.TextBox1.Text = ""
			Dim num3 As Integer = num4 + 1
			num4 = num2

		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
	End Sub

	Private Sub AwakeAttribute(sender As Object, e As EventArgs)
		MyBase.TopMost = True
		Dim lpRect As Form2.RECT
		lpRect.Left = 0
		lpRect.Top = 0
		lpRect.Right = 500
		lpRect.Bottom = 100
		Form2.ClipCursor(lpRect)
		Me.m_Thread += 1
		If Me.m_Thread >= 5 Then
			Form2.Beep(2000L, 500L)
		End If
	End Sub

	Private Sub ResolveAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj2 As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			Me.Label2.Text = "ngfxd568bdh158" + Conversions.ToString(Me.pc_num()) + "8bsdg45ybfdhg"
			Dim text As Object = Me.TextBox1.Text
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software", "dtmm", RuntimeHelpers.GetObjectValue(text), 1)
			Dim obj As Object = przs.Internal.Message.CloneAttribute("111111")
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software", "czmm", RuntimeHelpers.GetObjectValue(obj), 1)
			NewLateBinding.LateCall(Nothing, GetType(Process), "Start", New Object() { Operators.ConcatenateObject(przs.Internal.Message._Role, "\yz.exe") }, Nothing, Nothing, Nothing, True)
		Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj3, Exception)
		End Try

		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	<MethodImpl(MethodImplOptions.NoOptimization)>
	Private Sub ResetAttribute()
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try

			ProjectData.ClearProjectError()

			Dim num2 As Integer = 2
			Dim text As String = "zmserv"
			Dim text2 As String = "jfglzsn"
			While True
				Dim processesByName As Process() = Process.GetProcessesByName(text2)
				processesByName(0).Kill()
				If processesByName.Length = 0 Then
					Exit For
				End If
				Thread.Sleep(500)
			End While
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
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
			Dim num3 As Integer = num4 + 1
			num4 = num2

		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
		End Try
	End Sub

	Private Sub LoginAttribute(sender As Object, e As FormClosingEventArgs)
		e.Cancel = True
	End Sub

	Private Sub CustomizeAttribute(sender As Object, e As EventArgs)
		Me.Timer_frm2.Enabled = True
	End Sub

	Private Sub StartAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
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

	<CompilerGenerated()>
	<AccessedThroughProperty("shuoming")>
	Private _Descriptor As Label

	<CompilerGenerated()>
	<AccessedThroughProperty("Button2")>
	Private m_Manager As Button

	<CompilerGenerated()>
	<AccessedThroughProperty("Label2")>
	Private m_Creator As Label

	<CompilerGenerated()>
	<AccessedThroughProperty("Label1")>
	Private _Prototype As Label

	<AccessedThroughProperty("TextBox1")>
	<CompilerGenerated()>
	Private candidate As TextBox

	<CompilerGenerated()>
	<AccessedThroughProperty("Button1")>
	Private registry As Button

	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_frm2")>
	Private _Reponse As Timer

	<CompilerGenerated()>
	<AccessedThroughProperty("Label_pd")>
	Private _Expression As Label

	<AccessedThroughProperty("shuoming2")>
	<CompilerGenerated()>
	Private _Policy As Label

	<CompilerGenerated()>
	<AccessedThroughProperty("shuoming3")>
	Private m_Exporter As Label

	Private m_Thread As Integer

	Public Structure RECT
	
		Public Left As Integer

	
		Public Top As Integer

	
		Public Right As Integer

	
		Public Bottom As Integer
	End Structure
End Class
