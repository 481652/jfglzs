Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports [set].Internal

Namespace WindowsApplication1

	<DesignerGenerated()>
	Public Partial Class load
		Inherits Form

	
		Public Sub New()
			AddHandler MyBase.Shown, AddressOf Me.CheckContext
			AddHandler MyBase.Load, AddressOf Me.InitContext
			Me.ConnectContext()
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub ConnectContext()
			Me.Label_pd = New Label()
			Me.Label1 = New Label()
			Me.Label3 = New Label()
			Me.TextBox1 = New TextBox()
			Me.Button1 = New Button()
			MyBase.SuspendLayout()
			Me.Label_pd.AutoSize = True
			Me.Label_pd.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label_pd.Location = New Point(356, 70)
			Me.Label_pd.Name = "Label_pd"
			Me.Label_pd.Size = New Size(69, 35)
			Me.Label_pd.TabIndex = 25
			Me.Label_pd.Text = "   "
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Color.Red
			Me.Label1.Location = New Point(52, 136)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(0, 12)
			Me.Label1.TabIndex = 24
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Label3.ForeColor = Color.DarkRed
			Me.Label3.Location = New Point(46, 82)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Size(119, 14)
			Me.Label3.TabIndex = 23
			Me.Label3.Text = "输入小助手密码："
			Me.TextBox1.Location = New Point(163, 78)
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.PasswordChar = "*"c
			Me.TextBox1.Size = New Size(122, 21)
			Me.TextBox1.TabIndex = 22
			Me.Button1.Location = New Point(296, 75)
			Me.Button1.Name = "Button1"
			Me.Button1.Size = New Size(54, 27)
			Me.Button1.TabIndex = 21
			Me.Button1.Text = "确 定"
			Me.Button1.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(534, 262)
			MyBase.Controls.Add(Me.Label_pd)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.Button1)
			MyBase.Name = "load"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "load"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

	
		' (get) Token: 0x060000CE RID: 206 RVA: 0x000028CC File Offset: 0x00000ACC
		' (set) Token: 0x060000CF RID: 207 RVA: 0x0000A800 File Offset: 0x00008A00
		Friend Overridable Property Label_pd As Label
			<CompilerGenerated()>
			Get
				Return Me.m_DispatcherCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.CancelContext
				Dim dispatcherCollection As Label = Me.m_DispatcherCollection
				If dispatcherCollection IsNot Nothing Then
					RemoveHandler dispatcherCollection.DoubleClick, value2
				End If
				Me.m_DispatcherCollection = value
				dispatcherCollection = Me.m_DispatcherCollection
				If dispatcherCollection IsNot Nothing Then
					AddHandler dispatcherCollection.DoubleClick, value2
				End If
			End Set
		End Property

	
		' (get) Token: 0x060000D0 RID: 208 RVA: 0x000028D4 File Offset: 0x00000AD4
		' (set) Token: 0x060000D1 RID: 209 RVA: 0x000028DC File Offset: 0x00000ADC
		Friend Overridable Property Label1 As Label

	
		' (get) Token: 0x060000D2 RID: 210 RVA: 0x000028E5 File Offset: 0x00000AE5
		' (set) Token: 0x060000D3 RID: 211 RVA: 0x000028ED File Offset: 0x00000AED
		Friend Overridable Property Label3 As Label

	
		' (get) Token: 0x060000D4 RID: 212 RVA: 0x000028F6 File Offset: 0x00000AF6
		' (set) Token: 0x060000D5 RID: 213 RVA: 0x000028FE File Offset: 0x00000AFE
		Friend Overridable Property TextBox1 As TextBox

	
		' (get) Token: 0x060000D6 RID: 214 RVA: 0x00002907 File Offset: 0x00000B07
		' (set) Token: 0x060000D7 RID: 215 RVA: 0x0000A844 File Offset: 0x00008A44
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me.m_ServerCollection
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.CloneContext
				Dim serverCollection As Button = Me.m_ServerCollection
				If serverCollection IsNot Nothing Then
					RemoveHandler serverCollection.Click, value2
				End If
				Me.m_ServerCollection = value
				serverCollection = Me.m_ServerCollection
				If serverCollection IsNot Nothing Then
					AddHandler serverCollection.Click, value2
				End If
			End Set
		End Property

	
		Private Sub CloneContext(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				If Strings.Len(Me.TextBox1.Text) >= 6 Then
				End If
				Me.Label1.Text = "密码应该是6位以上的字母或数字，请重新输入！"
				Me.TextBox1.Text = ""
				Dim left As String = MessageCollection.TestContext(Strings.Trim(Me.TextBox1.Text))
				Dim right As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software", "n", ""))
				If Operators.CompareString(left, right, False) <> 0 Then
				End If
				Me.Label1.Text = ""
				Me.Button1.Enabled = False
				MyBase.Hide()
				CandidateCollection.PrepareContext.Form1.Show()
				Me.Label1.Text = "密码不正确，请重新输入！"
				Me.TextBox1.Text = ""
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try

			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub CancelContext(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()
				Dim num2 As Integer = num3 + 1
					num3 = num4

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
		End Sub

	
		Private Sub CheckContext(sender As Object, e As EventArgs)
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim left As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software", "n", ""))
				If Operators.CompareString(left, "", False) <> 0 Then
				End If
				MyBase.Hide()
				CandidateCollection.PrepareContext.Form1.Show()
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

	
		Private Sub InitContext(sender As Object, e As EventArgs)
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
			MessageCollection.m_InfoCollection = text
			MessageCollection.m_SingletonCollection = text + ".exe"
			VBMath.Randomize(CDbl(num))
			Dim num6 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
			Dim text2 As String = ""
			Dim num7 As Integer = 1
			Do
				text2 = Conversions.ToString(Strings.Chr(CInt((num6 Mod 10L + 105L)))) + text2
				num6 /= 10L
				num7 += 1
			Loop While num7 <= 5
			MessageCollection.m_InfoCollection = text2
			MessageCollection.m_SingletonCollection = text2 + ".exe"
		End Sub

	
		<AccessedThroughProperty("Label_pd")>
		<CompilerGenerated()>
		Private m_DispatcherCollection As Label

	
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private creatorCollection As Label

	
		<AccessedThroughProperty("Label3")>
		<CompilerGenerated()>
		Private _RuleCollection As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("TextBox1")>
		Private _IdentifierCollection As TextBox

	
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private m_ServerCollection As Button
	End Class
End Namespace
