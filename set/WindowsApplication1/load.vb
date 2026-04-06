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
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public Partial Class load
		Inherits Form

		' Token: 0x060000CB RID: 203 RVA: 0x0000289A File Offset: 0x00000A9A
		Public Sub New()
			AddHandler MyBase.Shown, AddressOf Me.CheckContext
			AddHandler MyBase.Load, AddressOf Me.InitContext
			Me.ConnectContext()
		End Sub

		' Token: 0x060000CD RID: 205 RVA: 0x0000A4D0 File Offset: 0x000086D0
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

		' Token: 0x1700004F RID: 79
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

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000D0 RID: 208 RVA: 0x000028D4 File Offset: 0x00000AD4
		' (set) Token: 0x060000D1 RID: 209 RVA: 0x000028DC File Offset: 0x00000ADC
		Friend Overridable Property Label1 As Label

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000D2 RID: 210 RVA: 0x000028E5 File Offset: 0x00000AE5
		' (set) Token: 0x060000D3 RID: 211 RVA: 0x000028ED File Offset: 0x00000AED
		Friend Overridable Property Label3 As Label

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000D4 RID: 212 RVA: 0x000028F6 File Offset: 0x00000AF6
		' (set) Token: 0x060000D5 RID: 213 RVA: 0x000028FE File Offset: 0x00000AFE
		Friend Overridable Property TextBox1 As TextBox

		' Token: 0x17000053 RID: 83
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

		' Token: 0x060000D8 RID: 216 RVA: 0x0000A888 File Offset: 0x00008A88
		Private Sub CloneContext(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
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
				Me.Label1.Text = "密码应该是6位以上的字母或数字，请重新输入！"
				IL_2F:
				num2 = 4
				Me.TextBox1.Text = ""
				GoTo IL_F2
				IL_46:
				num2 = 6
				Dim left As String = MessageCollection.TestContext(Strings.Trim(Me.TextBox1.Text))
				IL_5E:
				num2 = 7
				Dim right As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software", "n", ""))
				IL_80:
				num2 = 8
				If Operators.CompareString(left, right, False) <> 0 Then
					GoTo IL_CC
				End If
				IL_8D:
				num2 = 9
				Me.Label1.Text = ""
				IL_A0:
				num2 = 10
				Me.Button1.Enabled = False
				IL_AF:
				num2 = 11
				MyBase.Hide()
				IL_B8:
				num2 = 12
				CandidateCollection.PrepareContext.Form1.Show()
				GoTo IL_F2
				IL_CC:
				num2 = 14
				Me.Label1.Text = "密码不正确，请重新输入！"
				IL_DF:
				num2 = 15
				Me.TextBox1.Text = ""
				IL_F2:
				GoTo IL_183
				IL_F7:
				GoTo IL_18D
				IL_FC:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_15E
				IL_10E:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_15E:
				GoTo IL_18D
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_FC
			End Try
			IL_183:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_18D:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x060000D9 RID: 217 RVA: 0x0000AA4C File Offset: 0x00008C4C
		Private Sub CancelContext(sender As Object, e As EventArgs)
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

		' Token: 0x060000DA RID: 218 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		Private Sub CheckContext(sender As Object, e As EventArgs)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim left As String = Conversions.ToString(MessageCollection.VisitContext(Registry.CurrentUser, "Software", "n", ""))
				IL_29:
				num2 = 3
				If Operators.CompareString(left, "", False) <> 0 Then
					GoTo IL_52
				End If
				IL_39:
				num2 = 4
				MyBase.Hide()
				IL_41:
				num2 = 5
				CandidateCollection.PrepareContext.Form1.Show()
				IL_52:
				GoTo IL_B2
				IL_54:
				GoTo IL_BC
				IL_56:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				GoTo IL_90
				IL_68:
				Dim num4 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_90:
				GoTo IL_BC
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_56
			End Try
			IL_B2:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return
			IL_BC:
			Throw ProjectData.CreateProjectError(-2146828237)
		End Sub

		' Token: 0x060000DB RID: 219 RVA: 0x0000ABB4 File Offset: 0x00008DB4
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

		' Token: 0x0400006A RID: 106
		<AccessedThroughProperty("Label_pd")>
		<CompilerGenerated()>
		Private m_DispatcherCollection As Label

		' Token: 0x0400006B RID: 107
		<AccessedThroughProperty("Label1")>
		<CompilerGenerated()>
		Private creatorCollection As Label

		' Token: 0x0400006C RID: 108
		<AccessedThroughProperty("Label3")>
		<CompilerGenerated()>
		Private _RuleCollection As Label

		' Token: 0x0400006D RID: 109
		<CompilerGenerated()>
		<AccessedThroughProperty("TextBox1")>
		Private _IdentifierCollection As TextBox

		' Token: 0x0400006E RID: 110
		<CompilerGenerated()>
		<AccessedThroughProperty("Button1")>
		Private m_ServerCollection As Button
	End Class
End Namespace
