Imports System
Imports System.Windows.Forms

Namespace about.Internal

	Friend Class InitializerWrapper
	
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

	
		Friend Shared Sub InsertWrapper(object_0 As Object)
		End Sub

	
		Private Shared _CollectionWrapper As Boolean
	End Class
End Namespace
