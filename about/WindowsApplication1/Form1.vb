Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports about.Internal
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace WindowsApplication1

	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.VerifyPolicy
			Me.OrderPolicy()
		End Sub

	
		Private Sub AssetPolicy(sender As Object, e As EventArgs)
			If Operators.CompareString(Conversions.ToString(IteratorWrapper.DisablePolicy(Registry.CurrentUser, "Software", "n", "")), "", False) = 0 Then
				Process.Start(Application.StartupPath + "\set.exe")
				Return
			End If
			ClientWrapper.DestroyPolicy.Form3.Show()
		End Sub

	
		Private Sub PreparePolicy(sender As Object, e As EventArgs)
			Process.Start(Application.StartupPath + "\set.exe", Conversions.ToString(1))
		End Sub

	
		Private Sub LogoutPolicy(sender As Object, e As EventArgs)
			Process.Start("http://www.jfglzs.com/")
		End Sub

	
		Private Function RegisterPolicy(string_0 As String) As Boolean
			Return Process.GetProcessesByName(string_0).Length > 0
		End Function

	
		Private Sub ManagePolicy(sender As Object, e As EventArgs)
			If Not Me.RegisterPolicy("jfglzsn") Then
				Me.Label2.Text = "关 闭"
				Return
			End If
			Me.Label2.Text = "正在运行中。。。"
		End Sub

	
		Private Sub ComputePolicy(sender As Object, e As EventArgs)
			If Operators.CompareString(Conversions.ToString(IteratorWrapper.DisablePolicy(Registry.CurrentUser, "Software", "n", "")), "", False) = 0 Then
				Process.Start(Application.StartupPath + "\set.exe")
			Else
				Process.Start(Application.StartupPath + "\przs.exe")
				Process.Start(Application.StartupPath + "\jfglzsn.exe")
			End If
			Dim processesByName As Process() = Process.GetProcessesByName("explorer")
			For i As Integer = 0 To processesByName.Length - 1
				processesByName(i).Kill()
			Next
			Process.Start("explorer.exe")
		End Sub

	
		Private Sub FindPolicy(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("http://www.jfglzs.com")
		End Sub

	
		Private Sub RemovePolicy(sender As Object, e As ToolStripItemClickedEventArgs)
		End Sub

	
		Private Sub IncludePolicy(sender As Object, e As EventArgs)
			Process.Start(Application.StartupPath + "\更新器.exe")
		End Sub

	
		Private Sub CallPolicy(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("http://www.jfglzs.com/c1.html")
		End Sub

	
		Private Sub VerifyPolicy(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
			Dim num2 As Integer = num Mod 7
			Dim num3 As Integer = num Mod 9
			Dim num4 As Integer = num Mod 5
			Dim num5 As Integer = num Mod 3
			Dim text As String
			If num Mod 2 = 0 Then
				text = Conversions.ToString(Strings.Chr(97 + num2)) + Conversions.ToString(Strings.Chr(98 + num3)) + Conversions.ToString(Strings.Chr(101 + num4)) + Conversions.ToString(Strings.Chr(99 + num5))
			Else
				text = Conversions.ToString(Strings.Chr(97 + num3)) + Conversions.ToString(Strings.Chr(98 + num2)) + Conversions.ToString(Strings.Chr(101 + num5)) + Conversions.ToString(Strings.Chr(99 + num4))
			End If
			IteratorWrapper.eventWrapper = text
			IteratorWrapper.m_MockWrapper = text + ".exe"
			VBMath.Randomize(CDbl(num))
			Dim num6 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
			Dim text2 As String = ""
			Dim num7 As Integer = 1
			Do
				text2 = Conversions.ToString(Strings.Chr(CInt((num6 Mod 10L + 105L)))) + text2
				num6 /= 10L
				num7 += 1
			Loop While num7 <= 5
			IteratorWrapper.eventWrapper = text2
			IteratorWrapper.m_MockWrapper = text2 + ".exe"
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub OrderPolicy()
			Me.exporterWrapper = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
			Me.MenuStrip1 = New MenuStrip()
			Me.系统功能FToolStripMenuItem = New ToolStripMenuItem()
			Me.设置ToolStripMenuItem = New ToolStripMenuItem()
			Me.退出程序ToolStripMenuItem = New ToolStripMenuItem()
			Me.启动小助手ToolStripMenuItem = New ToolStripMenuItem()
			Me.访问官网ToolStripMenuItem = New ToolStripMenuItem()
			Me.Timer1 = New Timer(Me.exporterWrapper)
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.LinkLabel1 = New LinkLabel()
			Me.LinkLabel2 = New LinkLabel()
			Me.MenuStrip1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.MenuStrip1.Items.AddRange(New ToolStripItem() { Me.系统功能FToolStripMenuItem })
			Me.MenuStrip1.Location = New Point(0, 0)
			Me.MenuStrip1.Name = "MenuStrip1"
			Me.MenuStrip1.Size = New Size(682, 25)
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.系统功能FToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.设置ToolStripMenuItem, Me.退出程序ToolStripMenuItem, Me.启动小助手ToolStripMenuItem, Me.访问官网ToolStripMenuItem })
			Me.系统功能FToolStripMenuItem.Name = "系统功能FToolStripMenuItem"
			Me.系统功能FToolStripMenuItem.Size = New Size(98, 21)
			Me.系统功能FToolStripMenuItem.Text = "系统功能（F）"
			Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
			Me.设置ToolStripMenuItem.Size = New Size(124, 22)
			Me.设置ToolStripMenuItem.Text = "设  置"
			Me.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem"
			Me.退出程序ToolStripMenuItem.Size = New Size(124, 22)
			Me.退出程序ToolStripMenuItem.Text = "退出程序"
			Me.启动小助手ToolStripMenuItem.Name = "启动小助手ToolStripMenuItem"
			Me.启动小助手ToolStripMenuItem.Size = New Size(124, 22)
			Me.启动小助手ToolStripMenuItem.Text = "启动程序"
			Me.访问官网ToolStripMenuItem.Name = "访问官网ToolStripMenuItem"
			Me.访问官网ToolStripMenuItem.Size = New Size(124, 22)
			Me.访问官网ToolStripMenuItem.Text = "访问官网"
			Me.Timer1.Enabled = True
			Me.Timer1.Interval = 500
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Color.Transparent
			Me.Label2.ForeColor = Color.Red
			Me.Label2.Location = New Point(157, 413)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Size(41, 12)
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "Label2"
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Color.Transparent
			Me.Label1.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label1.ForeColor = Color.Blue
			Me.Label1.Location = New Point(39, 412)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(125, 12)
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "当前小助手工作状态："
			Me.LinkLabel1.AutoSize = True
			Me.LinkLabel1.BackColor = Color.Transparent
			Me.LinkLabel1.Location = New Point(538, 309)
			Me.LinkLabel1.Name = "LinkLabel1"
			Me.LinkLabel1.Size = New Size(71, 12)
			Me.LinkLabel1.TabIndex = 5
			Me.LinkLabel1.TabStop = True
			Me.LinkLabel1.Text = ">>>访问官网"
			Me.LinkLabel2.AutoSize = True
			Me.LinkLabel2.BackColor = Color.Transparent
			Me.LinkLabel2.Location = New Point(268, 412)
			Me.LinkLabel2.Name = "LinkLabel2"
			Me.LinkLabel2.Size = New Size(53, 12)
			Me.LinkLabel2.TabIndex = 6
			Me.LinkLabel2.TabStop = True
			Me.LinkLabel2.Text = "查看帮助"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackgroundImage = CType(componentResourceManager.GetObject("$this.BackgroundImage"), Image)
			MyBase.ClientSize = New Size(682, 486)
			MyBase.Controls.Add(Me.LinkLabel2)
			MyBase.Controls.Add(Me.LinkLabel1)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.MenuStrip1)
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Icon)
			MyBase.MainMenuStrip = Me.MenuStrip1
			MyBase.Name = "Form1"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "学生机房管理助手v12.99"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

	
		' (get) Token: 0x06000034 RID: 52 RVA: 0x000024A5 File Offset: 0x000006A5
		' (set) Token: 0x06000035 RID: 53 RVA: 0x00003100 File Offset: 0x00001300
		Friend Overridable Property MenuStrip1 As MenuStrip
			<CompilerGenerated()>
			Get
				Return Me._RegistryWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Dim value2 As ToolStripItemClickedEventHandler = AddressOf Me.RemovePolicy
				Dim registryWrapper As MenuStrip = Me._RegistryWrapper
				If registryWrapper IsNot Nothing Then
					RemoveHandler registryWrapper.ItemClicked, value2
				End If
				Me._RegistryWrapper = value
				registryWrapper = Me._RegistryWrapper
				If registryWrapper IsNot Nothing Then
					AddHandler registryWrapper.ItemClicked, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000036 RID: 54 RVA: 0x000024AD File Offset: 0x000006AD
		' (set) Token: 0x06000037 RID: 55 RVA: 0x000024B5 File Offset: 0x000006B5
		Friend Overridable Property 系统功能FToolStripMenuItem As ToolStripMenuItem

	
		' (get) Token: 0x06000038 RID: 56 RVA: 0x000024BE File Offset: 0x000006BE
		' (set) Token: 0x06000039 RID: 57 RVA: 0x00003144 File Offset: 0x00001344
		Friend Overridable Property 设置ToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me.dicWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PreparePolicy
				Dim toolStripMenuItem As ToolStripMenuItem = Me.dicWrapper
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me.dicWrapper = value
				toolStripMenuItem = Me.dicWrapper
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x0600003A RID: 58 RVA: 0x000024C6 File Offset: 0x000006C6
		' (set) Token: 0x0600003B RID: 59 RVA: 0x00003188 File Offset: 0x00001388
		Friend Overridable Property 退出程序ToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me.facadeWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.AssetPolicy
				Dim toolStripMenuItem As ToolStripMenuItem = Me.facadeWrapper
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, value2
				End If
				Me.facadeWrapper = value
				toolStripMenuItem = Me.facadeWrapper
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x0600003C RID: 60 RVA: 0x000024CE File Offset: 0x000006CE
		' (set) Token: 0x0600003D RID: 61 RVA: 0x000031CC File Offset: 0x000013CC
		Friend Overridable Property 访问官网ToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._WorkerWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.LogoutPolicy
				Dim workerWrapper As ToolStripMenuItem = Me._WorkerWrapper
				If workerWrapper IsNot Nothing Then
					RemoveHandler workerWrapper.Click, value2
				End If
				Me._WorkerWrapper = value
				workerWrapper = Me._WorkerWrapper
				If workerWrapper IsNot Nothing Then
					AddHandler workerWrapper.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x0600003E RID: 62 RVA: 0x000024D6 File Offset: 0x000006D6
		' (set) Token: 0x0600003F RID: 63 RVA: 0x00003210 File Offset: 0x00001410
		Friend Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me._PublisherWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ManagePolicy
				Dim publisherWrapper As Timer = Me._PublisherWrapper
				If publisherWrapper IsNot Nothing Then
					RemoveHandler publisherWrapper.Tick, value2
				End If
				Me._PublisherWrapper = value
				publisherWrapper = Me._PublisherWrapper
				If publisherWrapper IsNot Nothing Then
					AddHandler publisherWrapper.Tick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000040 RID: 64 RVA: 0x000024DE File Offset: 0x000006DE
		' (set) Token: 0x06000041 RID: 65 RVA: 0x000024E6 File Offset: 0x000006E6
		Friend Overridable Property Label2 As Label

	
		' (get) Token: 0x06000042 RID: 66 RVA: 0x000024EF File Offset: 0x000006EF
		' (set) Token: 0x06000043 RID: 67 RVA: 0x000024F7 File Offset: 0x000006F7
		Friend Overridable Property Label1 As Label

	
		' (get) Token: 0x06000044 RID: 68 RVA: 0x00002500 File Offset: 0x00000700
		' (set) Token: 0x06000045 RID: 69 RVA: 0x00003254 File Offset: 0x00001454
		Friend Overridable Property LinkLabel1 As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._ModelWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.FindPolicy
				Dim modelWrapper As LinkLabel = Me._ModelWrapper
				If modelWrapper IsNot Nothing Then
					RemoveHandler modelWrapper.LinkClicked, value2
				End If
				Me._ModelWrapper = value
				modelWrapper = Me._ModelWrapper
				If modelWrapper IsNot Nothing Then
					AddHandler modelWrapper.LinkClicked, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000046 RID: 70 RVA: 0x00002508 File Offset: 0x00000708
		' (set) Token: 0x06000047 RID: 71 RVA: 0x00003298 File Offset: 0x00001498
		Friend Overridable Property LinkLabel2 As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me.m_ObjectWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.CallPolicy
				Dim objectWrapper As LinkLabel = Me.m_ObjectWrapper
				If objectWrapper IsNot Nothing Then
					RemoveHandler objectWrapper.LinkClicked, value2
				End If
				Me.m_ObjectWrapper = value
				objectWrapper = Me.m_ObjectWrapper
				If objectWrapper IsNot Nothing Then
					AddHandler objectWrapper.LinkClicked, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x06000048 RID: 72 RVA: 0x00002510 File Offset: 0x00000710
		' (set) Token: 0x06000049 RID: 73 RVA: 0x000032DC File Offset: 0x000014DC
		Friend Overridable Property 启动小助手ToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me.m_MerchantWrapper
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ComputePolicy
				Dim merchantWrapper As ToolStripMenuItem = Me.m_MerchantWrapper
				If merchantWrapper IsNot Nothing Then
					RemoveHandler merchantWrapper.Click, value2
				End If
				Me.m_MerchantWrapper = value
				merchantWrapper = Me.m_MerchantWrapper
				If merchantWrapper IsNot Nothing Then
					AddHandler merchantWrapper.Click, value2
				End If
			End Set
		End Property

	
		Private m_ParameterWrapper As Long

	
		<AccessedThroughProperty("MenuStrip1")>
		<CompilerGenerated()>
		Private _RegistryWrapper As MenuStrip

	
		<CompilerGenerated()>
		<AccessedThroughProperty("系统功能FToolStripMenuItem")>
		Private methodWrapper As ToolStripMenuItem

	
		<AccessedThroughProperty("设置ToolStripMenuItem")>
		<CompilerGenerated()>
		Private dicWrapper As ToolStripMenuItem

	
		<AccessedThroughProperty("退出程序ToolStripMenuItem")>
		<CompilerGenerated()>
		Private facadeWrapper As ToolStripMenuItem

	
		<CompilerGenerated()>
		<AccessedThroughProperty("访问官网ToolStripMenuItem")>
		Private _WorkerWrapper As ToolStripMenuItem

	
		<AccessedThroughProperty("Timer1")>
		<CompilerGenerated()>
		Private _PublisherWrapper As Timer

	
		<AccessedThroughProperty("Label2")>
		<CompilerGenerated()>
		Private m_InfoWrapper As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label1")>
		Private m_CreatorWrapper As Label

	
		<AccessedThroughProperty("LinkLabel1")>
		<CompilerGenerated()>
		Private _ModelWrapper As LinkLabel

	
		<AccessedThroughProperty("LinkLabel2")>
		<CompilerGenerated()>
		Private m_ObjectWrapper As LinkLabel

	
		<AccessedThroughProperty("启动小助手ToolStripMenuItem")>
		<CompilerGenerated()>
		Private m_MerchantWrapper As ToolStripMenuItem
	End Class
End Namespace
