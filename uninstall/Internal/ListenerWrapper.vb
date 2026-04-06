Imports System
Imports System.Windows.Forms

Namespace uninstall.Internal
	' Token: 0x02000016 RID: 22
	Friend Class ListenerWrapper
		' Token: 0x06000086 RID: 134 RVA: 0x00008E98 File Offset: 0x00007098
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

		' Token: 0x06000087 RID: 135 RVA: 0x00002545 File Offset: 0x00000745
		Friend Shared Sub StopWrapper(object_0 As Object)
		End Sub

		' Token: 0x04000041 RID: 65
		Private Shared m_FactoryWrapper As Boolean
	End Class
End Namespace
