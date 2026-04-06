Namespace WindowsApplication1

	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form2
		Inherits Global.System.Windows.Forms.Form

	
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

	
		Private m_ClientStatus As Global.System.ComponentModel.IContainer
	End Class
End Namespace
