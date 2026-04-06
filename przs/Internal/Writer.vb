Imports System
Imports System.Windows.Forms

Namespace przs.Internal

	Friend Class Writer
	
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

	
		Friend Shared Sub ConcatDefinition(object_0 As Object)
		End Sub

	
		Private Shared _Rules As Boolean
	End Class
End Namespace
