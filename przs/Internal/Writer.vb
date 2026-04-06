Imports System
Imports System.Windows.Forms

Namespace przs.Internal
	' Token: 0x02000015 RID: 21
	Friend Class Writer
		' Token: 0x0600009E RID: 158 RVA: 0x00006D04 File Offset: 0x00004F04
		Friend Shared Sub smethod_0()
			If Not Writer._Rules Then
				Writer._Rules = True
				Try
					MessageBox.Show("This assembly is protected by an unregistered version of ""IntelliLock""!", "www.eziriz.com")
				Catch
					Writer.ConcatDefinition("<script language='javascript'>alert( ""This assembly is protected by an unregistered version of IntelliLock!"" );</script>")
				End Try
			End If
		End Sub

		' Token: 0x0600009F RID: 159 RVA: 0x00002721 File Offset: 0x00000921
		Friend Shared Sub ConcatDefinition(object_0 As Object)
		End Sub

		' Token: 0x04000058 RID: 88
		Private Shared _Rules As Boolean
	End Class
End Namespace
