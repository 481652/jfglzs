Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1

	<DesignerGenerated()>
	Public Partial Class Form3
		Inherits Form

	
		Public Sub New()
			Me.SetupState()
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub SetupState()
			Me.shuoming = New Label()
			Me.shuoming2 = New Label()
			Me.shuoming3 = New Label()
			MyBase.SuspendLayout()
			Me.shuoming.AutoSize = True
			Me.shuoming.Font = New Font("宋体", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.shuoming.ForeColor = Color.Red
			Me.shuoming.Location = New Point(72, 202)
			Me.shuoming.Name = "shuoming"
			Me.shuoming.Size = New Size(0, 21)
			Me.shuoming.TabIndex = 17
			Me.shuoming2.AutoSize = True
			Me.shuoming2.Font = New Font("宋体", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.shuoming2.ForeColor = Color.Red
			Me.shuoming2.Location = New Point(72, 266)
			Me.shuoming2.Name = "shuoming2"
			Me.shuoming2.Size = New Size(21, 21)
			Me.shuoming2.TabIndex = 18
			Me.shuoming2.Text = " "
			Me.shuoming3.AutoSize = True
			Me.shuoming3.Font = New Font("宋体", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.shuoming3.Location = New Point(76, 337)
			Me.shuoming3.Name = "shuoming3"
			Me.shuoming3.Size = New Size(0, 19)
			Me.shuoming3.TabIndex = 19
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Highlight
			MyBase.ClientSize = New Size(1260, 558)
			MyBase.Controls.Add(Me.shuoming3)
			MyBase.Controls.Add(Me.shuoming2)
			MyBase.Controls.Add(Me.shuoming)
			MyBase.Name = "Form3"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "警告"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

	
		' (get) Token: 0x06000090 RID: 144 RVA: 0x00002629 File Offset: 0x00000829
		' (set) Token: 0x06000091 RID: 145 RVA: 0x00002631 File Offset: 0x00000831
		Friend Overridable Property shuoming As Label

	
		' (get) Token: 0x06000092 RID: 146 RVA: 0x0000263A File Offset: 0x0000083A
		' (set) Token: 0x06000093 RID: 147 RVA: 0x00002642 File Offset: 0x00000842
		Friend Overridable Property shuoming2 As Label

	
		' (get) Token: 0x06000094 RID: 148 RVA: 0x0000264B File Offset: 0x0000084B
		' (set) Token: 0x06000095 RID: 149 RVA: 0x00002653 File Offset: 0x00000853
		Friend Overridable Property shuoming3 As Label

	
		<CompilerGenerated()>
		<AccessedThroughProperty("shuoming")>
		Private _ThreadStatus As Label

	
		<AccessedThroughProperty("shuoming2")>
		<CompilerGenerated()>
		Private _BaseStatus As Label

	
		<AccessedThroughProperty("shuoming3")>
		<CompilerGenerated()>
		Private writerStatus As Label
	End Class
End Namespace
