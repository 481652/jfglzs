Namespace WindowsApplication1
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form2
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600006E RID: 110 RVA: 0x00006DBC File Offset: 0x00004FBC
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.m_ClientStatus IsNot Nothing Then
					Me.m_ClientStatus.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x04000083 RID: 131
		Private m_ClientStatus As Global.System.ComponentModel.IContainer
	End Class
End Namespace
