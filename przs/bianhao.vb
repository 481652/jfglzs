Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports przs.Internal

' Token: 0x0200000B RID: 11
<DesignerGenerated()>
Public Partial Class bianhao
	Inherits Form

	Public Sub New()
		AddHandler MyBase.Load, AddressOf Me.PublishAttribute
		Me.StopAttribute()
	End Sub

	<DebuggerStepThrough()>
	Private Sub StopAttribute()
		Me.Label1 = New Label()
		Me.Label2 = New Label()
		MyBase.SuspendLayout()
		Me.Label1.AutoSize = True
		Me.Label1.Font = New Font("黑体", 65.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.Label1.ForeColor = Color.FromArgb(255, 128, 0)
		Me.Label1.Location = New Point(2, 2)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New Size(257, 87)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "stu30"
		Me.Label2.AutoSize = True
		Me.Label2.Font = New Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.Label2.Location = New Point(27, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New Size(0, 16)
		Me.Label2.TabIndex = 2
		MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
		MyBase.AutoScaleMode = AutoScaleMode.Font
		Me.BackColor = Color.FromArgb(192, 64, 0)
		MyBase.ClientSize = New Size(321, 97)
		MyBase.Controls.Add(Me.Label2)
		MyBase.Controls.Add(Me.Label1)
		MyBase.FormBorderStyle = FormBorderStyle.None
		MyBase.Name = "bianhao"
		MyBase.ShowInTaskbar = False
		MyBase.StartPosition = FormStartPosition.Manual
		Me.Text = "bianhao"
		MyBase.TransparencyKey = Color.FromArgb(192, 64, 0)
		MyBase.ResumeLayout(False)
		MyBase.PerformLayout()
	End Sub

	' (get) Token: 0x0600002F RID: 47 RVA: 0x000024D2 File Offset: 0x000006D2
	' (set) Token: 0x06000030 RID: 48 RVA: 0x00002B48 File Offset: 0x00000D48
	Friend Overridable Property Label1 As Label
		<CompilerGenerated()>
		Get
			Return Me.item
		End Get
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Set(value As Label)
			Dim value2 As EventHandler = AddressOf Me.CheckAttribute
			Dim value3 As EventHandler = AddressOf Me.ReflectAttribute
			Dim label As Label = Me.item
			If label IsNot Nothing Then
				RemoveHandler label.MouseHover, value2
				RemoveHandler label.MouseLeave, value3
			End If
			Me.item = value
			label = Me.item
			If label IsNot Nothing Then
				AddHandler label.MouseHover, value2
				AddHandler label.MouseLeave, value3
			End If
		End Set
	End Property

	' (get) Token: 0x06000031 RID: 49 RVA: 0x000024DA File Offset: 0x000006DA
	' (set) Token: 0x06000032 RID: 50 RVA: 0x000024E2 File Offset: 0x000006E2
	Friend Overridable Property Label2 As Label

	Private Sub PublishAttribute(sender As Object, e As EventArgs)
		' The following expression was wrapped in a checked-statement
		Dim num As Short = CShort(Screen.PrimaryScreen.Bounds.Width)
		MyBase.Left = CInt((num - 350S))
		MyBase.Top = 100
		Dim name As String = Value.PopAttribute.Name
		Me.Label1.Text = Strings.Right(name, 6)
	End Sub

	Private Sub CheckAttribute(sender As Object, e As EventArgs)
		Me.Label2.Text = "由机房管理助手自动生成"
	End Sub

	Private Sub ReflectAttribute(sender As Object, e As EventArgs)
		Me.Label2.Text = ""
	End Sub

	<AccessedThroughProperty("Label1")>
	<CompilerGenerated()>
	Private item As Label

	<AccessedThroughProperty("Label2")>
	<CompilerGenerated()>
	Private composer As Label
End Class
