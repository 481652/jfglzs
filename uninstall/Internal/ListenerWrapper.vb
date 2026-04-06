Imports System
Imports System.Windows.Forms

Namespace uninstall.Internal

	Friend Class ListenerWrapper
	
		Friend Shared Sub smethod_0()
			If Not ListenerWrapper.m_FactoryWrapper Then
				ListenerWrapper.m_FactoryWrapper = True
				Try
					MessageBox.Show("This assembly is protected by an unregistered version of ""IntelliLock""!", "www.eziriz.com")
				Catch
					ListenerWrapper.StopWrapper("<script language='javascript'>alert( ""This assembly is protected by an unregistered version of IntelliLock!"" );</script>")
				End Try
			End If
		End Sub

	
		Friend Shared Sub StopWrapper(object_0 As Object)
		End Sub

	
		Private Shared m_FactoryWrapper As Boolean
	End Class
End Namespace
