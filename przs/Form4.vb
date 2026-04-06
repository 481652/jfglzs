Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports przs.Internal

' Token: 0x02000010 RID: 16
<DesignerGenerated()>
Public Partial Class Form4
	Inherits Form

	' Token: 0x06000081 RID: 129 RVA: 0x0000269B File Offset: 0x0000089B
	Public Sub New()
		AddHandler MyBase.Load, AddressOf Me.SearchAttribute
		AddHandler MyBase.FormClosing, AddressOf Me.LogoutAttribute
		Me.AddAttribute()
	End Sub

	' Token: 0x06000083 RID: 131 RVA: 0x0000665C File Offset: 0x0000485C
	<DebuggerStepThrough()>
	Private Sub AddAttribute()
		Me.m_Proccesor = New Container()
		Me.shuoming = New Label()
		Me.Timer_frm4 = New Timer(Me.m_Proccesor)
		Me.Label2 = New Label()
		MyBase.SuspendLayout()
		Me.shuoming.AutoSize = True
		Me.shuoming.Font = New Font("宋体", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.shuoming.ForeColor = Color.Red
		Me.shuoming.Location = New Point(95, 186)
		Me.shuoming.Name = "shuoming"
		Me.shuoming.Size = New Size(33, 35)
		Me.shuoming.TabIndex = 12
		Me.shuoming.Text = " "
		Me.Timer_frm4.Interval = 1000
		Me.Label2.AutoSize = True
		Me.Label2.Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.Label2.ForeColor = Color.DarkRed
		Me.Label2.Location = New Point(26, 83)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New Size(0, 14)
		Me.Label2.TabIndex = 16
		MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
		MyBase.AutoScaleMode = AutoScaleMode.Font
		Me.BackColor = SystemColors.Highlight
		MyBase.ClientSize = New Size(1023, 686)
		MyBase.Controls.Add(Me.Label2)
		MyBase.Controls.Add(Me.shuoming)
		MyBase.FormBorderStyle = FormBorderStyle.None
		MyBase.Name = "Form4"
		MyBase.ShowInTaskbar = False
		Me.Text = "Form4"
		MyBase.TopMost = True
		MyBase.WindowState = FormWindowState.Maximized
		MyBase.ResumeLayout(False)
		MyBase.PerformLayout()
	End Sub

	' Token: 0x17000027 RID: 39
	' (get) Token: 0x06000084 RID: 132 RVA: 0x000026CD File Offset: 0x000008CD
	' (set) Token: 0x06000085 RID: 133 RVA: 0x000026D5 File Offset: 0x000008D5
	Friend Overridable Property shuoming As Label

	' Token: 0x17000028 RID: 40
	' (get) Token: 0x06000086 RID: 134 RVA: 0x000026DE File Offset: 0x000008DE
	' (set) Token: 0x06000087 RID: 135 RVA: 0x00006864 File Offset: 0x00004A64
	Friend Overridable Property Timer_frm4 As Timer
		<CompilerGenerated()>
		Get
			Return Me.m_Serializer
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Timer)
			Dim value2 As EventHandler = AddressOf Me.PatchAttribute
			Dim serializer As Timer = Me.m_Serializer
			If serializer IsNot Nothing Then
				RemoveHandler serializer.Tick, value2
			End If
			Me.m_Serializer = value
			serializer = Me.m_Serializer
			If serializer IsNot Nothing Then
				AddHandler serializer.Tick, value2
			End If
		End Set
	End Property

	' Token: 0x17000029 RID: 41
	' (get) Token: 0x06000088 RID: 136 RVA: 0x000026E6 File Offset: 0x000008E6
	' (set) Token: 0x06000089 RID: 137 RVA: 0x000026EE File Offset: 0x000008EE
	Friend Overridable Property Label2 As Label

	' Token: 0x0600008A RID: 138
	Public Declare Ansi Function ClipCursor Lib "user32" (lpRect As Form4.RECT) As Integer

	' Token: 0x0600008B RID: 139
	Private Declare Ansi Function Beep Lib "kernel32" (long_0 As Long, long_1 As Long) As Long

	' Token: 0x0600008C RID: 140 RVA: 0x000068A8 File Offset: 0x00004AA8
	Private Sub PatchAttribute(sender As Object, e As EventArgs)
		MyBase.TopMost = True
		Dim lpRect As Form4.RECT
		lpRect.Left = 0
		lpRect.Top = 0
		lpRect.Right = 800
		lpRect.Bottom = 100
		Form4.ClipCursor(lpRect)
		Me._Param += 1
		If Me._Param >= 5 Then
			Form4.Beep(2000L, 500L)
		End If
	End Sub

	' Token: 0x0600008D RID: 141 RVA: 0x000026F7 File Offset: 0x000008F7
	Private Sub SearchAttribute(sender As Object, e As EventArgs)
		Me.Timer_frm4.Enabled = True
	End Sub

	' Token: 0x0600008E RID: 142 RVA: 0x00006918 File Offset: 0x00004B18
	Private Sub LogoutAttribute(sender As Object, e As FormClosingEventArgs)
		If przs.Internal.Message.tokenizer Then
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

	' Token: 0x04000046 RID: 70
	<CompilerGenerated()>
	<AccessedThroughProperty("shuoming")>
	Private _Dispatcher As Label

	' Token: 0x04000047 RID: 71
	<AccessedThroughProperty("Timer_frm4")>
	<CompilerGenerated()>
	Private m_Serializer As Timer

	' Token: 0x04000048 RID: 72
	<CompilerGenerated()>
	<AccessedThroughProperty("Label2")>
	Private m_Helper As Label

	' Token: 0x04000049 RID: 73
	Private _Param As Integer

	' Token: 0x02000011 RID: 17
	Public Structure RECT
		' Token: 0x0400004A RID: 74
		Public Left As Integer

		' Token: 0x0400004B RID: 75
		Public Top As Integer

		' Token: 0x0400004C RID: 76
		Public Right As Integer

		' Token: 0x0400004D RID: 77
		Public Bottom As Integer
	End Structure
End Class
