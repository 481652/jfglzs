Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports [set].Internal

Namespace WindowsApplication1

	<DesignerGenerated()>
	Public Partial Class Form3
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ManageContext
			Me.NewContext()
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub NewContext()
			Me.Button2 = New Button()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			MyBase.SuspendLayout()
			Me.Button2.Location = New Point(348, 161)
			Me.Button2.Name = "Button2"
			Me.Button2.Size = New Size(78, 27)
			Me.Button2.TabIndex = 1
			Me.Button2.Text = "确  定"
			Me.Button2.UseVisualStyleBackColor = True
			Me.Label2.ForeColor = SystemColors.ControlText
			Me.Label2.Location = New Point(20, 20)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Size(406, 59)
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "请在硬盘保护系统中创建进度或者保存系统（此步可省略）。"
			Me.Label1.Location = New Point(20, 92)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(406, 55)
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "注：软件在重启电脑后自动运行。"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(457, 215)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Button2)
			MyBase.Name = "Form3"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "提醒"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
		End Sub

	
		' (get) Token: 0x060000C3 RID: 195 RVA: 0x00002870 File Offset: 0x00000A70
		' (set) Token: 0x060000C4 RID: 196 RVA: 0x0000A324 File Offset: 0x00008524
		Friend Overridable Property Button2 As Button
			<CompilerGenerated()>
			Get
				Return Me.m_FactoryCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.ValidateContext
				Dim factoryCollection As Button = Me.m_FactoryCollection
				If factoryCollection IsNot Nothing Then
					RemoveHandler factoryCollection.Click, value2
				End If
				Me.m_FactoryCollection = value
				factoryCollection = Me.m_FactoryCollection
				If factoryCollection IsNot Nothing Then
					AddHandler factoryCollection.Click, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x060000C5 RID: 197 RVA: 0x00002878 File Offset: 0x00000A78
		' (set) Token: 0x060000C6 RID: 198 RVA: 0x00002880 File Offset: 0x00000A80
		Friend Overridable Property Label2 As Label

	
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x00002889 File Offset: 0x00000A89
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x00002891 File Offset: 0x00000A91
		Friend Overridable Property Label1 As Label

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub ValidateContext(sender As Object, e As EventArgs)
			ProjectData.EndApp()
		End Sub

	
		Private Sub ManageContext(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(MessageCollection.VisitContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
				End If
				objectValue = RuntimeHelpers.GetObjectValue(MessageCollection.VisitContext(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
				End If
				Me.Label2.ForeColor = Color.Red
				Me.Label2.Text = "因权限不够设置不成功，请打开机房管理助手的安装文件夹（C盘j开头的文件夹），右击文件set.exe，选择 以管理员身份运行，再次设置。"
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
		Private m_FactoryCollection As Button

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Label2")>
		Private schemaCollection As Label

	
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private pageCollection As Label
	End Class
End Namespace
