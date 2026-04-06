Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports uninstall.Internal

Namespace WindowsApplication1
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class Form2
		Inherits Form

		' Token: 0x0600002D RID: 45 RVA: 0x00002442 File Offset: 0x00000642
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.SearchConsumer
			AddHandler MyBase.Load, AddressOf Me.MoveConsumer
			Me.StopConsumer()
		End Sub

		' Token: 0x0600002F RID: 47 RVA: 0x00002D1C File Offset: 0x00000F1C
		<DebuggerStepThrough()>
		Private Sub StopConsumer()
			Me._Global = New Container()
			Me.Button2 = New Button()
			Me.Label1 = New Label()
			Me.TextBox1 = New TextBox()
			Me.Button1 = New Button()
			Me.Timer_frm2 = New Timer(Me._Global)
			Me.Label2 = New Label()
			Me.Label4 = New Label()
			Me.Label3 = New Label()
			Me.Label_pd = New Label()
			MyBase.SuspendLayout()
			Me.Button2.Location = New Point(397, 27)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Size(84, 26)
			Me.Button2.TabIndex = 19
			Me.Button2.Text = "重启电脑"
			Me.Button2.UseVisualStyleBackColor = True
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label1.ForeColor = Color.White
			Me.Label1.Location = New Point(39, 31)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(119, 14)
			Me.Label1.TabIndex = 18
			Me.Label1.Text = "卸载小助手密码："
			Me.TextBox1.Location = New Point(164, 29)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = "*"c
			Me.TextBox1.Size = New Size(104, 21)
			Me.TextBox1.TabIndex = 17
			Me.Button1.Location = New Point(284, 26)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Size(92, 27)
			Me.Button1.TabIndex = 16
			Me.Button1.Text = "确定(需10秒)"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Timer_frm2.Interval = 1000
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label2.ForeColor = Color.DarkRed
			Me.Label2.Location = New Point(32, 63)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Size(0, 14)
			Me.Label2.TabIndex = 20
			Me.Label4.AutoSize = True
			Me.Label4.Location = New Point(77, 135)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Size(299, 12)
			Me.Label4.TabIndex = 23
			Me.Label4.Text = "2、卸载后记得在硬盘保护系统中创建进度或保存系统。"
			Me.Label3.AutoSize = True
			Me.Label3.Location = New Point(40, 104)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Size(455, 12)
			Me.Label3.TabIndex = 24
			Me.Label3.Text = "提醒：1、软件有问题请联系QQ：1023411046，下载最新版本请访问：www.jfglzs.com"
			Me.Label_pd.AutoSize = True
			Me.Label_pd.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label_pd.Location = New Point(487, 26)
			Me.Label_pd.Name = "Label_pd"
			Me.Label_pd.Size = New Size(87, 35)
			Me.Label_pd.TabIndex = 25
			Me.Label_pd.Text = "    "
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Highlight
			MyBase.ClientSize = New Size(637, 407)
			MyBase.Controls.Add(Me.Label_pd)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Button2)
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

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000030 RID: 48 RVA: 0x00002474 File Offset: 0x00000674
		' (set) Token: 0x06000031 RID: 49 RVA: 0x00003238 File Offset: 0x00001438
		Friend Overridable Property Button2 As Button
			<CompilerGenerated()>
			Get
				Return Me._Producer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.InterruptConsumer
				Dim producer As Button = Me._Producer
				If producer IsNot Nothing Then
					RemoveHandler producer.Click, value2
				End If
				Me._Producer = value
				producer = Me._Producer
				If producer IsNot Nothing Then
					AddHandler producer.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000032 RID: 50 RVA: 0x0000247C File Offset: 0x0000067C
		' (set) Token: 0x06000033 RID: 51 RVA: 0x00002484 File Offset: 0x00000684
		Friend Overridable Property Label1 As Label

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000034 RID: 52 RVA: 0x0000248D File Offset: 0x0000068D
		' (set) Token: 0x06000035 RID: 53 RVA: 0x00002495 File Offset: 0x00000695
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000036 RID: 54 RVA: 0x0000249E File Offset: 0x0000069E
		' (set) Token: 0x06000037 RID: 55 RVA: 0x0000327C File Offset: 0x0000147C
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me.m_Proxy
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.RegisterConsumer
				Dim proxy As Button = Me.m_Proxy
				If proxy IsNot Nothing Then
					RemoveHandler proxy.Click, value2
				End If
				Me.m_Proxy = value
				proxy = Me.m_Proxy
				If proxy IsNot Nothing Then
					AddHandler proxy.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000038 RID: 56 RVA: 0x000024A6 File Offset: 0x000006A6
		' (set) Token: 0x06000039 RID: 57 RVA: 0x000032C0 File Offset: 0x000014C0
		Friend Overridable Property Timer_frm2 As Timer
			<CompilerGenerated()>
			Get
				Return Me.m_Config
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.AwakeConsumer
				Dim config As Timer = Me.m_Config
				If config IsNot Nothing Then
					RemoveHandler config.Tick, value2
				End If
				Me.m_Config = value
				config = Me.m_Config
				If config IsNot Nothing Then
					AddHandler config.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x0600003A RID: 58 RVA: 0x000024AE File Offset: 0x000006AE
		' (set) Token: 0x0600003B RID: 59 RVA: 0x000024B6 File Offset: 0x000006B6
		Friend Overridable Property Label2 As Label

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x0600003C RID: 60 RVA: 0x000024BF File Offset: 0x000006BF
		' (set) Token: 0x0600003D RID: 61 RVA: 0x000024C7 File Offset: 0x000006C7
		Friend Overridable Property Label4 As Label

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600003E RID: 62 RVA: 0x000024D0 File Offset: 0x000006D0
		' (set) Token: 0x0600003F RID: 63 RVA: 0x000024D8 File Offset: 0x000006D8
		Friend Overridable Property Label3 As Label

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x06000040 RID: 64 RVA: 0x000024E1 File Offset: 0x000006E1
		' (set) Token: 0x06000041 RID: 65 RVA: 0x00003304 File Offset: 0x00001504
		Friend Overridable Property Label_pd As Label
			<CompilerGenerated()>
			Get
				Return Me.consumerWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.FillConsumer
				Dim label As Label = Me.consumerWrapper
				If label IsNot Nothing Then
					RemoveHandler label.DoubleClick, value2
				End If
				Me.consumerWrapper = value
				label = Me.consumerWrapper
				If label IsNot Nothing Then
					AddHandler label.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x06000042 RID: 66
		Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (int_0 As Integer, int_1 As Integer, string_0 As String, int_2 As Integer) As Boolean

		' Token: 0x06000043 RID: 67
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form2.RECT) As Integer

		' Token: 0x06000044 RID: 68
		Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

		' Token: 0x06000045 RID: 69 RVA: 0x00003348 File Offset: 0x00001548
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub RegisterConsumer(sender As Object, e As EventArgs)
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
				GoTo IL_1CA
				IL_46:
				num2 = 6
				Dim left As String = DatabaseWrapper.FlushConsumer(Strings.Trim(Me.TextBox1.Text))
				IL_5E:
				num2 = 7
				Dim right As String = Conversions.ToString(DatabaseWrapper.TestConsumer(Registry.CurrentUser, "Software", "n", ""))
				IL_7F:
				num2 = 8
				If Operators.CompareString(left, right, False) = 0 Then
					GoTo IL_B6
				End If
				IL_8B:
				num2 = 9
				Me.Label2.Text = "密码不正确，请重新输入！"
				IL_9E:
				num2 = 10
				Me.TextBox1.Text = ""
				GoTo IL_1CA
				IL_B6:
				num2 = 12
				Me.Button1.Enabled = False
				IL_C5:
				num2 = 13
				Me.Label2.Text = ""
				IL_D8:
				num2 = 14
				Me.Cursor = Cursors.WaitCursor
				IL_E6:
				num2 = 15
				DatabaseWrapper.AssetConsumer()
				IL_EE:
				num2 = 16
				Me.Cursor = Cursors.[Default]
				IL_FC:
				num2 = 17
				Dim [string] As String
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
					[string] = Conversions.ToString(registryKey.GetValue("Wallpaper"))
				End Using
				IL_132:
				num2 = 18
				If Strings.InStr([string], "壁纸", CompareMethod.Binary) = 0 Then
					GoTo IL_15D
				End If
				IL_147:
				num2 = 19
				Dim string_ As String = "C:\Windows\Web\Wallpaper\Windows\img0.jpg"
				IL_151:
				num2 = 20
				Me.ManageConsumer(string_, Form2.WallpaperStyle.Stretched)
				IL_15D:
				num2 = 21
				Dim lpRect As Form2.RECT
				lpRect.Left = 0
				IL_168:
				num2 = 22
				lpRect.Top = 0
				IL_173:
				num2 = 23
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				IL_190:
				num2 = 24
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				IL_1AD:
				num2 = 25
				Form2.ClipCursor(lpRect)
				IL_1B8:
				num2 = 26
				Thread.Sleep(7000)
				ProjectData.EndApp()
				IL_1CA:
				GoTo IL_28C
				IL_1CF:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_24B:
				GoTo IL_281
				IL_24D:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_25E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_24D
			End Try
			IL_281:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_28C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000046 RID: 70 RVA: 0x00003620 File Offset: 0x00001820
		Private Sub FillConsumer(sender As Object, e As EventArgs)
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

		' Token: 0x06000047 RID: 71 RVA: 0x000036A4 File Offset: 0x000018A4
		Private Sub AwakeConsumer(sender As Object, e As EventArgs)
			MyBase.TopMost = True
			Dim lpRect As Form2.RECT
			lpRect.Left = 0
			lpRect.Top = 0
			lpRect.Right = 800
			lpRect.Bottom = 200
			Form2.ClipCursor(lpRect)
			Me._ImporterWrapper += 1
			If Me._ImporterWrapper >= 5 Then
				Form2.Beep(2000L, 500L)
			End If
		End Sub

		' Token: 0x06000048 RID: 72 RVA: 0x000024E9 File Offset: 0x000006E9
		Private Sub SearchConsumer(sender As Object, e As FormClosingEventArgs)
			e.Cancel = True
		End Sub

		' Token: 0x06000049 RID: 73 RVA: 0x000024F2 File Offset: 0x000006F2
		Private Sub MoveConsumer(sender As Object, e As EventArgs)
			Me.Timer_frm2.Enabled = True
		End Sub

		' Token: 0x0600004A RID: 74 RVA: 0x00003718 File Offset: 0x00001918
		Private Sub InterruptConsumer(sender As Object, e As EventArgs)
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

		' Token: 0x0600004B RID: 75 RVA: 0x00002500 File Offset: 0x00000700
		Private Sub RateConsumer(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("http://www.jfglzs.com")
		End Sub

		' Token: 0x0600004C RID: 76 RVA: 0x000037B8 File Offset: 0x000019B8
		Private Sub ManageConsumer(string_0 As String, wallpaperStyle_0 As Form2.WallpaperStyle)
			If Not File.Exists(string_0) Then
				Throw New ArgumentException("指定的图片文件不存在")
			End If
			Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
				registryKey.SetValue("Wallpaper", string_0)
				registryKey.SetValue("WallpaperStyle", "2")
			End Using
			If Not Form2.SystemParametersInfo(20, 0, string_0, 3) Then
				Throw New Win32Exception()
			End If
		End Sub

		' Token: 0x04000012 RID: 18
		<AccessedThroughProperty("Button2")>
		<CompilerGenerated()>
		Private _Producer As Button

		' Token: 0x04000013 RID: 19
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private collection As Label

		' Token: 0x04000014 RID: 20
		<AccessedThroughProperty("TextBox1")>
		<CompilerGenerated()>
		Private _Client As TextBox

		' Token: 0x04000015 RID: 21
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private m_Proxy As Button

		' Token: 0x04000016 RID: 22
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_frm2")>
		Private m_Config As Timer

		' Token: 0x04000017 RID: 23
		<CompilerGenerated()>
		<AccessedThroughProperty("Label2")>
		Private m_Issuer As Label

		' Token: 0x04000018 RID: 24
		<AccessedThroughProperty("Label4")>
		<CompilerGenerated()>
		Private _Iterator As Label

		' Token: 0x04000019 RID: 25
		<CompilerGenerated()>
		<AccessedThroughProperty("Label3")>
		Private m_Proc As Label

		' Token: 0x0400001A RID: 26
		<CompilerGenerated()>
		<AccessedThroughProperty("Label_pd")>
		Private consumerWrapper As Label

		' Token: 0x0400001B RID: 27
		Private Const _WrapperWrapper As Integer = 20

		' Token: 0x0400001C RID: 28
		Private Const contextWrapper As Integer = 1

		' Token: 0x0400001D RID: 29
		Private Const _ListWrapper As Integer = 2

		' Token: 0x0400001E RID: 30
		Private _ImporterWrapper As Integer

		' Token: 0x0200000D RID: 13
		Public Enum WallpaperStyle
			' Token: 0x04000020 RID: 32
			Tiled = 1
			' Token: 0x04000021 RID: 33
			Centered
			' Token: 0x04000022 RID: 34
			Stretched = 6
		End Enum

		' Token: 0x0200000E RID: 14
		Public Structure RECT
			' Token: 0x04000023 RID: 35
			Public Left As Integer

			' Token: 0x04000024 RID: 36
			Public Top As Integer

			' Token: 0x04000025 RID: 37
			Public Right As Integer

			' Token: 0x04000026 RID: 38
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
