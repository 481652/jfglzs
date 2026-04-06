Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

' Token: 0x0200000F RID: 15
<DesignerGenerated()>
Public Partial Class Form3
	Inherits Form

	Public Sub New()
		Me.ConcatAttribute()
	End Sub

	<DebuggerStepThrough()>
	Private Sub ConcatAttribute()
		Me.shuoming2 = New Label()
		Me.shuoming = New Label()
		Me.shuoming3 = New Label()
		MyBase.SuspendLayout()
		Me.shuoming2.AutoSize = True
		Me.shuoming2.Font = New Font("宋体", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.shuoming2.ForeColor = Color.Red
		Me.shuoming2.Location = New Point(54, 193)
		Me.shuoming2.Name = "shuoming2"
		Me.shuoming2.Size = New Size(21, 21)
		Me.shuoming2.TabIndex = 20
		Me.shuoming2.Text = " "
		Me.shuoming.AutoSize = True
		Me.shuoming.Font = New Font("宋体", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134)
		Me.shuoming.ForeColor = Color.Red
		Me.shuoming.Location = New Point(54, 129)
		Me.shuoming.Name = "shuoming"
		Me.shuoming.Size = New Size(21, 21)
		Me.shuoming.TabIndex = 19
		Me.shuoming.Text = " "
		Me.shuoming3.AutoSize = True
		Me.shuoming3.Location = New Point(56, 279)
		Me.shuoming3.Name = "shuoming3"
		Me.shuoming3.Size = New Size(0, 12)
		Me.shuoming3.TabIndex = 21
		MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
		MyBase.AutoScaleMode = AutoScaleMode.Font
		Me.BackColor = SystemColors.Highlight
		MyBase.ClientSize = New Size(1248, 559)
		MyBase.Controls.Add(Me.shuoming3)
		MyBase.Controls.Add(Me.shuoming2)
		MyBase.Controls.Add(Me.shuoming)
		MyBase.Name = "Form3"
		MyBase.StartPosition = FormStartPosition.CenterScreen
		Me.Text = "提醒"
		MyBase.TopMost = True
		MyBase.ResumeLayout(False)
		MyBase.PerformLayout()
	End Sub

	' (get) Token: 0x0600007B RID: 123 RVA: 0x00002668 File Offset: 0x00000868
	' (set) Token: 0x0600007C RID: 124 RVA: 0x00002670 File Offset: 0x00000870
	Friend Overridable Property shuoming2 As Label

	' (get) Token: 0x0600007D RID: 125 RVA: 0x00002679 File Offset: 0x00000879
	' (set) Token: 0x0600007E RID: 126 RVA: 0x00002681 File Offset: 0x00000881
	Friend Overridable Property shuoming As Label

	' (get) Token: 0x0600007F RID: 127 RVA: 0x0000268A File Offset: 0x0000088A
	' (set) Token: 0x06000080 RID: 128 RVA: 0x00002692 File Offset: 0x00000892
	Friend Overridable Property shuoming3 As Label

	<CompilerGenerated()>
	<AccessedThroughProperty("shuoming2")>
	Private m_Stub As Label

	<AccessedThroughProperty("shuoming")>
	<CompilerGenerated()>
	Private _Interceptor As Label

	<CompilerGenerated()>
	<AccessedThroughProperty("shuoming3")>
	Private authentication As Label
End Class
