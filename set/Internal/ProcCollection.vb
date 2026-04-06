Imports System
Imports System.Windows.Forms

Namespace [set].Internal
	' Token: 0x02000017 RID: 23
	Friend Class ProcCollection
		' Token: 0x06000114 RID: 276 RVA: 0x0000F50C File Offset: 0x0000D70C
		Friend Shared Sub smethod_0()
			If Not ProcCollection._ContextCandidate Then
				ProcCollection._ContextCandidate = True
				Try
					MessageBox.Show("This assembly is protected by an unregistered version of ""IntelliLock""!", "www.eziriz.com")
				Catch
					ProcCollection.NewCollection("<script language='javascript'>alert( ""This assembly is protected by an unregistered version of IntelliLock!"" );</script>")
				End Try
			End If
		End Sub

		' Token: 0x06000115 RID: 277 RVA: 0x00002930 File Offset: 0x00000B30
		Friend Shared Sub NewCollection(object_0 As Object)
		End Sub

		' Token: 0x04000085 RID: 133
		Private Shared _ContextCandidate As Boolean
	End Class
End Namespace
