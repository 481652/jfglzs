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
	' Token: 0x0200000E RID: 14
	<DesignerGenerated()>
	Public Partial Class Form3
		Inherits Form

		' Token: 0x060000C0 RID: 192 RVA: 0x00002850 File Offset: 0x00000A50
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ManageContext
			Me.NewContext()
		End Sub

		' Token: 0x060000C2 RID: 194 RVA: 0x0000A13C File Offset: 0x0000833C
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

		' Token: 0x1700004C RID: 76
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

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000C5 RID: 197 RVA: 0x00002878 File Offset: 0x00000A78
		' (set) Token: 0x060000C6 RID: 198 RVA: 0x00002880 File Offset: 0x00000A80
		Friend Overridable Property Label2 As Label

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x00002889 File Offset: 0x00000A89
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x00002891 File Offset: 0x00000A91
		Friend Overridable Property Label1 As Label

		' Token: 0x060000C9 RID: 201 RVA: 0x00002436 File Offset: 0x00000636
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub ValidateContext(sender As Object, e As EventArgs)
			ProjectData.EndApp()
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x0000A368 File Offset: 0x00008568
		Private Sub ManageContext(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(MessageCollection.VisitContext(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_29:
				num2 = 3
				If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
					GoTo IL_5A
				End If
				IL_39:
				num2 = 4
				objectValue = RuntimeHelpers.GetObjectValue(MessageCollection.VisitContext(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_5A:
				num2 = 5
				If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
					GoTo IL_8E
				End If
				IL_6A:
				num2 = 6
				Me.Label2.ForeColor = Color.Red
				IL_7C:
				num2 = 7
				Me.Label2.Text = "因权限不够设置不成功，请打开机房管理助手的安装文件夹（C盘j开头的文件夹），右击文件set.exe，选择 以管理员身份运行，再次设置。"
				IL_8E:
				GoTo IL_F6
				IL_90:
				GoTo IL_100
				IL_92:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_D4
				IL_A4:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_D4:
				GoTo IL_100
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_92
			End Try
			IL_F6:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_100:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x04000066 RID: 102
		<CompilerGenerated()>
		<AccessedThroughProperty("Button2")>
		Private m_FactoryCollection As Button

		' Token: 0x04000067 RID: 103
		<CompilerGenerated()>
		<AccessedThroughProperty("Label2")>
		Private schemaCollection As Label

		' Token: 0x04000068 RID: 104
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private pageCollection As Label
	End Class
End Namespace
