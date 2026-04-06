Imports System
Imports System.Windows.Forms

Namespace WindowsApplication1.Internal

	Friend Class ValueToken
	
		Friend Shared Sub smethod_0()
			If Not ValueToken.m_ProcessToken Then
				ValueToken.m_ProcessToken = True
				Try
					MessageBox.Show("This assembly is protected by an unregistered version of ""IntelliLock""!", "www.eziriz.com")
				Catch
					ValueToken.LogoutStatus("<script language='javascript'>alert( ""This assembly is protected by an unregistered version of IntelliLock!"" );</script>")
				End Try
			End If
		End Sub

	
		Friend Shared Sub LogoutStatus(object_0 As Object)
		End Sub

	
		Private Shared m_ProcessToken As Boolean
	End Class
End Namespace
