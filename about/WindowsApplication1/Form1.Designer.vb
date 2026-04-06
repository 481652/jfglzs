Namespace WindowsApplication1

	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

	
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

	
		Private exporterWrapper As Global.System.ComponentModel.IContainer
	End Class
End Namespace
