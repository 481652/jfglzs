Imports System
Imports System.Windows.Forms

Namespace zmserv.Internal
	' Token: 0x02000011 RID: 17
	Friend Class PublisherMock
		' Token: 0x0600004C RID: 76 RVA: 0x00006A80 File Offset: 0x00004C80
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

		' Token: 0x0600004D RID: 77 RVA: 0x0000235B File Offset: 0x0000055B
		Friend Shared Sub StartClass(object_0 As Object)
		End Sub

		' Token: 0x04000026 RID: 38
		Private Shared _ConfigurationMock As Boolean
	End Class
End Namespace
