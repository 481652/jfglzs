Imports System
Imports System.Windows.Forms

Namespace zmserv.Internal

	Friend Class PublisherMock
	
		Friend Shared Sub smethod_0()
			If Not PublisherMock._ConfigurationMock Then
				PublisherMock._ConfigurationMock = True
				Try
					MessageBox.Show("This assembly is protected by an unregistered version of ""IntelliLock""!", "www.eziriz.com")
				Catch
					PublisherMock.StartClass("<script language='javascript'>alert( ""This assembly is protected by an unregistered version of IntelliLock!"" );</script>")
				End Try
			End If
		End Sub

	
		Friend Shared Sub StartClass(object_0 As Object)
		End Sub

	
		Private Shared _ConfigurationMock As Boolean
	End Class
End Namespace
