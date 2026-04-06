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
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class Form4
		Inherits Form

		' Token: 0x060000A4 RID: 164 RVA: 0x00002678 File Offset: 0x00000878
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.RevertState
			AddHandler MyBase.Load, AddressOf Me.MoveStatus
			Me.ManageState()
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x00008304 File Offset: 0x00006504
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

		' Token: 0x17000029 RID: 41
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

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x060000A9 RID: 169 RVA: 0x000026B2 File Offset: 0x000008B2
		' (set) Token: 0x060000AA RID: 170 RVA: 0x000026BA File Offset: 0x000008BA
		Friend Overridable Property Label2 As Label

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x060000AB RID: 171 RVA: 0x000026C3 File Offset: 0x000008C3
		' (set) Token: 0x060000AC RID: 172 RVA: 0x000026CB File Offset: 0x000008CB
		Friend Overridable Property Label1 As Label

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x060000AD RID: 173 RVA: 0x000026D4 File Offset: 0x000008D4
		' (set) Token: 0x060000AE RID: 174 RVA: 0x000026DC File Offset: 0x000008DC
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x1700002D RID: 45
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

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x060000B1 RID: 177 RVA: 0x000026ED File Offset: 0x000008ED
		' (set) Token: 0x060000B2 RID: 178 RVA: 0x000026F5 File Offset: 0x000008F5
		Friend Overridable Property shuoming As Label

		' Token: 0x1700002F RID: 47
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

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x060000B5 RID: 181 RVA: 0x00002706 File Offset: 0x00000906
		' (set) Token: 0x060000B6 RID: 182 RVA: 0x0000270E File Offset: 0x0000090E
		Friend Overridable Property shuoming2 As Label

		' Token: 0x17000031 RID: 49
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

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x060000B9 RID: 185 RVA: 0x0000271F File Offset: 0x0000091F
		' (set) Token: 0x060000BA RID: 186 RVA: 0x00002727 File Offset: 0x00000927
		Friend Overridable Property shuoming3 As Label

		' Token: 0x060000BB RID: 187
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form4.RECT) As Integer

		' Token: 0x060000BC RID: 188
		Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

		' Token: 0x060000BD RID: 189 RVA: 0x00008A44 File Offset: 0x00006C44
		Private Sub ResetState(sender As Object, e As EventArgs)
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
				GoTo IL_101
				IL_46:
				num2 = 6
				Dim left As String = FilterStatus.DeleteState(Strings.Trim(Me.TextBox1.Text))
				IL_5F:
				num2 = 7
				Dim right As String = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software", "n", ""))
				IL_81:
				num2 = 8
				Dim right2 As String = Conversions.ToString(FilterStatus.SearchState(Registry.CurrentUser, "Software\jfglzs", "n2", ""))
				IL_A2:
				num2 = 9
				If Not(Operators.CompareString(left, right, False) = 0 Or Operators.CompareString(left, right2, False) = 0) Then
					GoTo IL_DB
				End If
				IL_C1:
				num2 = 10
				Me.Button1.Enabled = False
				IL_D0:
				num2 = 11
				Me.AddState()
				GoTo IL_101
				IL_DB:
				num2 = 13
				Me.Label2.Text = "密码不正确，请重新输入！"
				IL_EE:
				num2 = 14
				Me.TextBox1.Text = ""
				IL_101:
				GoTo IL_18F
				IL_106:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_150:
				GoTo IL_184
				IL_152:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_162:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_152
			End Try
			IL_184:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_18F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060000BE RID: 190 RVA: 0x00008C04 File Offset: 0x00006E04
		Private Sub PushState(sender As Object, e As EventArgs)
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
				Dim lpRect As Form4.RECT
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
				Form4.ClipCursor(lpRect)
				IL_47:
				num2 = 8
				Me.m_RecordToken += 1
				IL_57:
				num2 = 9
				If Me.m_RecordToken < 5 Then
					GoTo IL_7E
				End If
				IL_63:
				num2 = 10
				Form4.Beep(2000L, 500L)
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

		' Token: 0x060000BF RID: 191 RVA: 0x00008D28 File Offset: 0x00006F28
		Private Sub UpdateState(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				GoTo IL_58
				IL_0A:
				GoTo IL_62
				IL_0C:
				Dim num3 As Integer
				num2 = num3
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_36
				IL_1E:
				Dim num4 As Integer = num2 + 1
				num2 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_36:
				GoTo IL_62
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_0C
			End Try
			IL_58:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_62:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x060000C0 RID: 192 RVA: 0x00008DB4 File Offset: 0x00006FB4
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub AddState()
			Dim num As Integer
			Dim num9 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim text As String = "zmserv"
				IL_11:
				num2 = 3
				IL_13:
				num2 = 4
				Dim text2 As String = Conversions.ToString(FilterStatus.serializerStatus)
				Dim processesByName As Process()
				Do
					IL_42:
					num2 = 6
					IL_23:
					num2 = 7
					processesByName = Process.GetProcessesByName(text2)
					IL_2E:
					num2 = 8
					processesByName(0).Kill()
					IL_39:
					num2 = 9
				Loop While processesByName.Length <> 0
				IL_46:
				num2 = 12
				Dim num3 As Integer = 10
				IL_4D:
				num2 = 13
				num3 = num3 * 10 + 2
				IL_59:
				num2 = 14
				For Each process As Process In Process.GetProcesses()
					IL_78:
					num2 = 15
					Dim num4 As Integer = Strings.Len(process.ProcessName)
					IL_89:
					num2 = 16
					If num4 >= 4 Then
						IL_91:
						num2 = 18
						Dim num5 As Integer = num4
						Dim j As Integer = 1
						While j <= num5
							IL_9B:
							num2 = 19
							Dim num6 As Integer = Strings.Asc(Strings.Mid(process.ProcessName, j, 1))
							IL_B3:
							num2 = 20
							If num6 >= num3 Then
								IL_BC:
								num2 = 22
								If num6 <= num3 + 9 Then
									IL_C8:
									num2 = 24
									j += 1
									Continue While
								End If
							End If
							IL_ED:
							num2 = 25
							If j = num4 + 1 Then
								IL_D5:
								num2 = 26
								process.Kill()
								GoTo IL_DF
							End If
							GoTo IL_DF
						End While
						GoTo IL_ED
					End If
					IL_DF:
					num2 = 27
				Next
				IL_F9:
				num2 = 28
				Dim num7 As Integer = Conversions.ToInteger(FilterStatus.SearchState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", ""))
				IL_11C:
				num2 = 29
				If num7 <> 1 Then
					GoTo IL_180
				End If
				IL_124:
				num2 = 30
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_142:
				num2 = 31
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_153:
				num2 = 32
				Thread.Sleep(3000)
				IL_160:
				num2 = 33
				FilterStatus.ReadState(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 1, 4)
				GoTo IL_19E
				IL_180:
				num2 = 35
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_191:
				num2 = 36
				Thread.Sleep(3000)
				IL_19E:
				num2 = 37
				Dim processesByName2 As Process() = Process.GetProcessesByName(text)
				IL_1AA:
				num2 = 38
				processesByName2(0).Kill()
				IL_1B6:
				num2 = 39
				Dim lpRect As Form4.RECT
				lpRect.Left = 0
				IL_1C1:
				num2 = 40
				lpRect.Top = 0
				IL_1CC:
				num2 = 41
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				IL_1E9:
				num2 = 42
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				IL_206:
				num2 = 43
				Form4.ClipCursor(lpRect)
				ProjectData.EndApp()
				IL_216:
				GoTo IL_31C
				IL_21B:
				Dim num8 As Integer = num9 + 1
				num9 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_2DB:
				GoTo IL_311
				IL_2DD:
				num9 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2EE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2DD
			End Try
			IL_311:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_31C:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060000C1 RID: 193 RVA: 0x00009104 File Offset: 0x00007304
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

		' Token: 0x060000C2 RID: 194 RVA: 0x00009170 File Offset: 0x00007370
		Private Sub MoveStatus(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Me.Timer_frm4.Enabled = True
				IL_16:
				GoTo IL_71
				IL_18:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_32:
				GoTo IL_66
				IL_34:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_44:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_34
			End Try
			IL_66:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_71:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x00009208 File Offset: 0x00007408
		Private Sub PatchStatus(sender As Object, e As EventArgs)
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

		' Token: 0x040000A1 RID: 161
		<CompilerGenerated()>
		<AccessedThroughProperty("Button2")>
		Private statusToken As Button

		' Token: 0x040000A2 RID: 162
		<AccessedThroughProperty("Label2")>
		<CompilerGenerated()>
		Private _TokenToken As Label

		' Token: 0x040000A3 RID: 163
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private modelToken As Label

		' Token: 0x040000A4 RID: 164
		<AccessedThroughProperty("TextBox1")>
		<CompilerGenerated()>
		Private m_ManagerToken As TextBox

		' Token: 0x040000A5 RID: 165
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private m_CodeToken As Button

		' Token: 0x040000A6 RID: 166
		<AccessedThroughProperty("shuoming")>
		<CompilerGenerated()>
		Private issuerToken As Label

		' Token: 0x040000A7 RID: 167
		<AccessedThroughProperty("Timer_frm4")>
		<CompilerGenerated()>
		Private specificationToken As Timer

		' Token: 0x040000A8 RID: 168
		<CompilerGenerated()>
		<AccessedThroughProperty("shuoming2")>
		Private proccesorToken As Label

		' Token: 0x040000A9 RID: 169
		<CompilerGenerated()>
		<AccessedThroughProperty("Label_pd")>
		Private _CustomerToken As Label

		' Token: 0x040000AA RID: 170
		<CompilerGenerated()>
		<AccessedThroughProperty("shuoming3")>
		Private expressionToken As Label

		' Token: 0x040000AB RID: 171
		Private m_RecordToken As Integer

		' Token: 0x02000012 RID: 18
		Public Structure RECT
			' Token: 0x040000AC RID: 172
			Public Left As Integer

			' Token: 0x040000AD RID: 173
			Public Top As Integer

			' Token: 0x040000AE RID: 174
			Public Right As Integer

			' Token: 0x040000AF RID: 175
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
