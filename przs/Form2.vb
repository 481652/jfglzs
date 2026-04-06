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

	' Token: 0x06000057 RID: 87 RVA: 0x0000258B File Offset: 0x0000078B
	Public Sub New()
		AddHandler MyBase.FormClosing, AddressOf Me.LoginAttribute
		AddHandler MyBase.Load, AddressOf Me.CustomizeAttribute
		Me.ValidateAttribute()
	End Sub

	' Token: 0x06000059 RID: 89 RVA: 0x00005648 File Offset: 0x00003848
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

	' Token: 0x1700001A RID: 26
	' (get) Token: 0x0600005A RID: 90 RVA: 0x000025BD File Offset: 0x000007BD
	' (set) Token: 0x0600005B RID: 91 RVA: 0x000025C5 File Offset: 0x000007C5
	Friend Overridable Property shuoming As Label

	' Token: 0x1700001B RID: 27
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

	' Token: 0x1700001C RID: 28
	' (get) Token: 0x0600005E RID: 94 RVA: 0x000025D6 File Offset: 0x000007D6
	' (set) Token: 0x0600005F RID: 95 RVA: 0x000025DE File Offset: 0x000007DE
	Friend Overridable Property Label2 As Label

	' Token: 0x1700001D RID: 29
	' (get) Token: 0x06000060 RID: 96 RVA: 0x000025E7 File Offset: 0x000007E7
	' (set) Token: 0x06000061 RID: 97 RVA: 0x000025EF File Offset: 0x000007EF
	Friend Overridable Property Label1 As Label

	' Token: 0x1700001E RID: 30
	' (get) Token: 0x06000062 RID: 98 RVA: 0x000025F8 File Offset: 0x000007F8
	' (set) Token: 0x06000063 RID: 99 RVA: 0x00002600 File Offset: 0x00000800
	Friend Overridable Property TextBox1 As TextBox

	' Token: 0x1700001F RID: 31
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

	' Token: 0x17000020 RID: 32
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

	' Token: 0x17000021 RID: 33
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

	' Token: 0x17000022 RID: 34
	' (get) Token: 0x0600006A RID: 106 RVA: 0x00002621 File Offset: 0x00000821
	' (set) Token: 0x0600006B RID: 107 RVA: 0x00002629 File Offset: 0x00000829
	Friend Overridable Property shuoming2 As Label

	' Token: 0x17000023 RID: 35
	' (get) Token: 0x0600006C RID: 108 RVA: 0x00002632 File Offset: 0x00000832
	' (set) Token: 0x0600006D RID: 109 RVA: 0x0000263A File Offset: 0x0000083A
	Friend Overridable Property shuoming3 As Label

	' Token: 0x0600006E RID: 110
	Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form2.RECT) As Integer

	' Token: 0x0600006F RID: 111
	Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

	' Token: 0x06000070 RID: 112 RVA: 0x00005D58 File Offset: 0x00003F58
	Private Sub InterruptAttribute(sender As Object, e As EventArgs)
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
			GoTo IL_E0
			IL_46:
			num2 = 6
			Dim left As String = przs.Internal.Message.CloneAttribute(Strings.Trim(Me.TextBox1.Text))
			IL_5E:
			num2 = 7
			Dim right As String = Conversions.ToString(przs.Internal.Message.PrepareAttribute(Registry.CurrentUser, "Software", "n", ""))
			IL_80:
			num2 = 8
			If Operators.CompareString(left, right, False) <> 0 Then
				GoTo IL_BA
			End If
			IL_8D:
			num2 = 9
			Me.Label2.Text = ""
			IL_A0:
			num2 = 10
			Me.Button1.Enabled = False
			IL_AF:
			num2 = 11
			Me.ResetAttribute()
			GoTo IL_E0
			IL_BA:
			num2 = 13
			Me.Label2.Text = "密码不正确，请重新输入！"
			IL_CD:
			num2 = 14
			Me.TextBox1.Text = ""
			IL_E0:
			GoTo IL_16E
			IL_E5:
			Dim num3 As Integer = num4 + 1
			num4 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
			IL_12F:
			GoTo IL_163
			IL_131:
			num4 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			IL_141:
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_131
		End Try
		IL_163:
		Throw ProjectData.CreateProjectError(-2146828237)
		IL_16E:
		If num4 <> 0 Then
			ProjectData.ClearProjectError()
		End If
	End Sub

	' Token: 0x06000071 RID: 113 RVA: 0x00005EF8 File Offset: 0x000040F8
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

	' Token: 0x06000072 RID: 114 RVA: 0x00005F68 File Offset: 0x00004168
	Private Sub ResolveAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj2 As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			Me.Label2.Text = "ngfxd568bdh158" + Conversions.ToString(Me.pc_num()) + "8bsdg45ybfdhg"
			IL_2F:
			num2 = 3
			Dim text As Object = Me.TextBox1.Text
			IL_3D:
			num2 = 4
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software", "dtmm", RuntimeHelpers.GetObjectValue(text), 1)
			IL_5A:
			num2 = 5
			Dim obj As Object = przs.Internal.Message.CloneAttribute("111111")
			IL_68:
			num2 = 6
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software", "czmm", RuntimeHelpers.GetObjectValue(obj), 1)
			IL_86:
			num2 = 7
			NewLateBinding.LateCall(Nothing, GetType(Process), "Start", New Object() { Operators.ConcatenateObject(przs.Internal.Message._Role, "\yz.exe") }, Nothing, Nothing, Nothing, True)
			IL_BB:
			GoTo IL_123
			IL_BD:
			GoTo IL_12D
			IL_BF:
			num3 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_101
			IL_D1:
			Dim num4 As Integer = num3 + 1
			num3 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
			IL_101:
			GoTo IL_12D
		Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj3, Exception)
			GoTo IL_BF
		End Try
		IL_123:
		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_12D:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x06000073 RID: 115 RVA: 0x000060CC File Offset: 0x000042CC
	<MethodImpl(MethodImplOptions.NoOptimization)>
	Private Sub ResetAttribute()
		Dim num As Integer
		Dim num4 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			Dim text As String = "zmserv"
			IL_10:
			num2 = 3
			IL_12:
			num2 = 4
			Dim text2 As String = "jfglzsn"
			While True
				IL_49:
				num2 = 6
				IL_1D:
				num2 = 7
				Dim processesByName As Process() = Process.GetProcessesByName(text2)
				IL_28:
				num2 = 8
				processesByName(0).Kill()
				IL_33:
				num2 = 9
				If processesByName.Length = 0 Then
					Exit For
				End If
				IL_3C:
				num2 = 11
				Thread.Sleep(500)
			End While
			IL_4D:
			num2 = 13
			przs.Internal.Message.ConnectAttribute(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
			IL_6B:
			num2 = 14
			Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
			IL_7C:
			num2 = 15
			Thread.Sleep(3000)
			IL_89:
			num2 = 16
			Dim processesByName2 As Process() = Process.GetProcessesByName(text)
			IL_94:
			num2 = 17
			processesByName2(0).Kill()
			IL_A0:
			num2 = 18
			Dim lpRect As Form2.RECT
			lpRect.Left = 0
			IL_AB:
			num2 = 19
			lpRect.Top = 0
			IL_B6:
			num2 = 20
			lpRect.Right = Screen.PrimaryScreen.Bounds.Width
			IL_D3:
			num2 = 21
			lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
			IL_F0:
			num2 = 22
			Form2.ClipCursor(lpRect)
			ProjectData.EndApp()
			IL_100:
			GoTo IL_1AE
			IL_105:
			Dim num3 As Integer = num4 + 1
			num4 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
			IL_16F:
			GoTo IL_1A3
			IL_171:
			num4 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			IL_181:
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_171
		End Try
		IL_1A3:
		Throw ProjectData.CreateProjectError(-2146828237)
		IL_1AE:
		If num4 <> 0 Then
			ProjectData.ClearProjectError()
		End If
	End Sub

	' Token: 0x06000074 RID: 116 RVA: 0x00002643 File Offset: 0x00000843
	Private Sub LoginAttribute(sender As Object, e As FormClosingEventArgs)
		e.Cancel = True
	End Sub

	' Token: 0x06000075 RID: 117 RVA: 0x0000264C File Offset: 0x0000084C
	Private Sub CustomizeAttribute(sender As Object, e As EventArgs)
		Me.Timer_frm2.Enabled = True
	End Sub

	' Token: 0x06000076 RID: 118 RVA: 0x000062AC File Offset: 0x000044AC
	Private Sub StartAttribute(sender As Object, e As EventArgs)
		Dim num As Integer
		Dim num3 As Integer
		Dim obj As Object
		Try
			IL_01:
			ProjectData.ClearProjectError()
			num = 1
			IL_08:
			Dim num2 As Integer = 2
			Interaction.Shell("shutdown /r /f /t 0", AppWinStyle.MinimizedFocus, False, -1)
			IL_18:
			GoTo IL_6C
			IL_1A:
			GoTo IL_76
			IL_1C:
			num3 = num2
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
			GoTo IL_4A
			IL_2E:
			Dim num4 As Integer = num3 + 1
			num3 = 0
			switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
			IL_4A:
			GoTo IL_76
		Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
			Dim ex As Exception = CType(obj2, Exception)
			GoTo IL_1C
		End Try
		IL_6C:
		If num3 <> 0 Then
			ProjectData.ClearProjectError()
		End If
		Return
		IL_76:
		Throw ProjectData.CreateProjectError(-2146828237)
	End Sub

	' Token: 0x06000077 RID: 119 RVA: 0x0000634C File Offset: 0x0000454C
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

	' Token: 0x04000032 RID: 50
	<CompilerGenerated()>
	<AccessedThroughProperty("shuoming")>
	Private _Descriptor As Label

	' Token: 0x04000033 RID: 51
	<CompilerGenerated()>
	<AccessedThroughProperty("Button2")>
	Private m_Manager As Button

	' Token: 0x04000034 RID: 52
	<CompilerGenerated()>
	<AccessedThroughProperty("Label2")>
	Private m_Creator As Label

	' Token: 0x04000035 RID: 53
	<CompilerGenerated()>
	<AccessedThroughProperty("Label1")>
	Private _Prototype As Label

	' Token: 0x04000036 RID: 54
	<AccessedThroughProperty("TextBox1")>
	<CompilerGenerated()>
	Private candidate As TextBox

	' Token: 0x04000037 RID: 55
	<CompilerGenerated()>
	<AccessedThroughProperty("Button1")>
	Private registry As Button

	' Token: 0x04000038 RID: 56
	<CompilerGenerated()>
	<AccessedThroughProperty("Timer_frm2")>
	Private _Reponse As Timer

	' Token: 0x04000039 RID: 57
	<CompilerGenerated()>
	<AccessedThroughProperty("Label_pd")>
	Private _Expression As Label

	' Token: 0x0400003A RID: 58
	<AccessedThroughProperty("shuoming2")>
	<CompilerGenerated()>
	Private _Policy As Label

	' Token: 0x0400003B RID: 59
	<CompilerGenerated()>
	<AccessedThroughProperty("shuoming3")>
	Private m_Exporter As Label

	' Token: 0x0400003C RID: 60
	Private m_Thread As Integer

	' Token: 0x0200000E RID: 14
	Public Structure RECT
		' Token: 0x0400003D RID: 61
		Public Left As Integer

		' Token: 0x0400003E RID: 62
		Public Top As Integer

		' Token: 0x0400003F RID: 63
		Public Right As Integer

		' Token: 0x04000040 RID: 64
		Public Bottom As Integer
	End Structure
End Class
