Namespace WindowsApplication1
	' Token: 0x0200000B RID: 11
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000032 RID: 50 RVA: 0x00002B0C File Offset: 0x00000D0C
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.exporterWrapper IsNot Nothing Then
					Me.exporterWrapper.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x04000010 RID: 16
		Private exporterWrapper As Global.System.ComponentModel.IContainer
	End Class
End Namespace
