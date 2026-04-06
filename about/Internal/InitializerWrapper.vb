Imports System
Imports System.Windows.Forms

Namespace about.Internal
	' Token: 0x02000014 RID: 20
	Friend Class InitializerWrapper
		' Token: 0x06000093 RID: 147 RVA: 0x00008624 File Offset: 0x00006824
		Friend Shared Sub smethod_0()
			If Not InitializerWrapper._CollectionWrapper Then
				InitializerWrapper._CollectionWrapper = True
				Try
					MessageBox.Show("This assembly is protected by an unregistered version of ""IntelliLock""!", "www.eziriz.com")
				Catch
					InitializerWrapper.InsertWrapper("<script language='javascript'>alert( ""This assembly is protected by an unregistered version of IntelliLock!"" );</script>")
				End Try
			End If
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x0000247F File Offset: 0x0000067F
		Friend Shared Sub InsertWrapper(object_0 As Object)
		End Sub

		' Token: 0x04000038 RID: 56
		Private Shared _CollectionWrapper As Boolean
	End Class
End Namespace
