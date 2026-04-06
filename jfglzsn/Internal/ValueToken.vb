Imports System
Imports System.Windows.Forms

Namespace WindowsApplication1.Internal
	' Token: 0x02000019 RID: 25
	Friend Class ValueToken
		' Token: 0x060000EE RID: 238 RVA: 0x0000D768 File Offset: 0x0000B968
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

		' Token: 0x060000EF RID: 239 RVA: 0x00002730 File Offset: 0x00000930
		Friend Shared Sub LogoutStatus(object_0 As Object)
		End Sub

		' Token: 0x040000C0 RID: 192
		Private Shared m_ProcessToken As Boolean
	End Class
End Namespace
