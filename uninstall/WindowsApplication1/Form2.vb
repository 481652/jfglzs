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

	<DesignerGenerated()>
	Public Partial Class Form2
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.SearchConsumer
			AddHandler MyBase.Load, AddressOf Me.MoveConsumer
			Me.StopConsumer()
		End Sub

	
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

	
		' (get) Token: 0x06000032 RID: 50 RVA: 0x0000247C File Offset: 0x0000067C
		' (set) Token: 0x06000033 RID: 51 RVA: 0x00002484 File Offset: 0x00000684
		Friend Overridable Property Label1 As Label

	
		' (get) Token: 0x06000034 RID: 52 RVA: 0x0000248D File Offset: 0x0000068D
		' (set) Token: 0x06000035 RID: 53 RVA: 0x00002495 File Offset: 0x00000695
		Friend Overridable Property TextBox1 As TextBox

	
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

	
		' (get) Token: 0x0600003A RID: 58 RVA: 0x000024AE File Offset: 0x000006AE
		' (set) Token: 0x0600003B RID: 59 RVA: 0x000024B6 File Offset: 0x000006B6
		Friend Overridable Property Label2 As Label

	
		' (get) Token: 0x0600003C RID: 60 RVA: 0x000024BF File Offset: 0x000006BF
		' (set) Token: 0x0600003D RID: 61 RVA: 0x000024C7 File Offset: 0x000006C7
		Friend Overridable Property Label4 As Label

	
		' (get) Token: 0x0600003E RID: 62 RVA: 0x000024D0 File Offset: 0x000006D0
		' (set) Token: 0x0600003F RID: 63 RVA: 0x000024D8 File Offset: 0x000006D8
		Friend Overridable Property Label3 As Label

	
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

	
		Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (int_0 As Integer, int_1 As Integer, string_0 As String, int_2 As Integer) As Boolean

	
		Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form2.RECT) As Integer

	
		Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub RegisterConsumer(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				If Strings.Len(Me.TextBox1.Text) >= 6 Then
				End If
				Me.Label2.Text = "密码应该是6位以上的字母或数字，请重新输入！"
				Me.TextBox1.Text = ""
				Dim left As String = DatabaseWrapper.FlushConsumer(Strings.Trim(Me.TextBox1.Text))
				Dim right As String = Conversions.ToString(DatabaseWrapper.TestConsumer(Registry.CurrentUser, "Software", "n", ""))
				If Operators.CompareString(left, right, False) = 0 Then
				End If
				Me.Label2.Text = "密码不正确，请重新输入！"
				Me.TextBox1.Text = ""
				Me.Button1.Enabled = False
				Me.Label2.Text = ""
				Me.Cursor = Cursors.WaitCursor
				DatabaseWrapper.AssetConsumer()
				Me.Cursor = Cursors.[Default]
				Dim [string] As String
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
					[string] = Conversions.ToString(registryKey.GetValue("Wallpaper"))
				End Using
				If Strings.InStr([string], "壁纸", CompareMethod.Binary) = 0 Then
				End If
				Dim string_ As String = "C:\Windows\Web\Wallpaper\Windows\img0.jpg"
				Me.ManageConsumer(string_, Form2.WallpaperStyle.Stretched)
				Dim lpRect As Form2.RECT
				lpRect.Left = 0
				lpRect.Top = 0
				lpRect.Right = Screen.PrimaryScreen.Bounds.Width
				lpRect.Bottom = Screen.PrimaryScreen.Bounds.Height
				Form2.ClipCursor(lpRect)
				Thread.Sleep(7000)
				ProjectData.EndApp()
				Dim num3 As Integer = num4 + 1
				num4 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Private Sub FillConsumer(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()
				Dim num2 As Integer = num3 + 1
					num3 = num4

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
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

	
		Private Sub SearchConsumer(sender As Object, e As FormClosingEventArgs)
			e.Cancel = True
		End Sub

	
		Private Sub MoveConsumer(sender As Object, e As EventArgs)
			Me.Timer_frm2.Enabled = True
		End Sub

	
		Private Sub InterruptConsumer(sender As Object, e As EventArgs)
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

	
		Private Sub RateConsumer(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("http://www.jfglzs.com")
		End Sub

	
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

	
		<AccessedThroughProperty("Button2")>
		<CompilerGenerated()>
		Private _Producer As Button

	
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private collection As Label

	
		<AccessedThroughProperty("TextBox1")>
		<CompilerGenerated()>
		Private _Client As TextBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private m_Proxy As Button

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer_frm2")>
		Private m_Config As Timer

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label2")>
		Private m_Issuer As Label

	
		<AccessedThroughProperty("Label4")>
		<CompilerGenerated()>
		Private _Iterator As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label3")>
		Private m_Proc As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label_pd")>
		Private consumerWrapper As Label

	
		Private Const _WrapperWrapper As Integer = 20

	
		Private Const contextWrapper As Integer = 1

	
		Private Const _ListWrapper As Integer = 2

	
		Private _ImporterWrapper As Integer

	
		Public Enum WallpaperStyle
		
			Tiled = 1
		
			Centered
		
			Stretched = 6
		End Enum

	
		Public Structure RECT
		
			Public Left As Integer

		
			Public Top As Integer

		
			Public Right As Integer

		
			Public Bottom As Integer
		End Structure
	End Class
End Namespace
