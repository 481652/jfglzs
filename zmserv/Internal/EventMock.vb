Imports System
Imports System.Collections
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Namespace zmserv.Internal
	' Token: 0x02000012 RID: 18
	Friend Class EventMock
		' Token: 0x0600004F RID: 79 RVA: 0x00006ACC File Offset: 0x00004CCC
		Friend Shared Sub smethod_0()
			If Not EventMock.m_CustomerMock Then
				EventMock.m_CustomerMock = True
				Dim currentDomain As AppDomain = AppDomain.CurrentDomain
				AddHandler currentDomain.AssemblyResolve, AddressOf EventMock.InvokeClass
			End If
		End Sub

		' Token: 0x06000050 RID: 80 RVA: 0x00006B00 File Offset: 0x00004D00
		Private Shared Function InvokeClass(object_0 As Object, resolveEventArgs_0 As ResolveEventArgs) As Assembly
			Dim flag As Boolean = False
			Dim result As Assembly
			Try
				Dim hashtable As Hashtable = EventMock.tokenMock
				Dim obj As Hashtable = hashtable
				Monitor.Enter(hashtable, flag)
				Dim text As String = resolveEventArgs_0.Name.Trim()
				Dim obj2 As Object = EventMock.tokenMock(text)
				If obj2 Is Nothing Then
					Try
						RSACryptoServiceProvider.UseMachineKeyStore = True
						Dim text2 As String = EventMock.VisitClass(text)
						Dim bytes As Byte() = Encoding.Unicode.GetBytes(text2)
						Dim text3 As String = "b0494a1f-4bd3-" + Convert.ToBase64String(DicMock.LogoutClass(bytes))
						Dim manifestResourceStream As Stream = GetType(EventMock).Assembly.GetManifestResourceStream(text3)
						If manifestResourceStream IsNot Nothing Then
							Try
								Dim binaryReader As BinaryReader = New BinaryReader(manifestResourceStream)
								binaryReader.BaseStream.Position = 0L
								Dim array As Byte() = New Byte(manifestResourceStream.Length - 1) {}
								binaryReader.Read(array, 0, array.Length)
								binaryReader.Close()
								Dim flag2 As Boolean = False
								Dim assembly As Assembly = Nothing
								Try
									assembly = Assembly.Load(array)
								Catch ex As FileLoadException
									flag2 = True
								Catch ex2 As BadImageFormatException
									flag2 = True
								End Try
								If flag2 Then
									Dim path As String = Path.Combine(Path.GetTempPath(), text3)
									Dim text4 As String = Path.Combine(path, text2 + ".dll")
									If Not File.Exists(text4) Then
										Directory.CreateDirectory(Path.GetDirectoryName(text4))
										Dim fileStream As FileStream = New FileStream(text4, FileMode.Create, FileAccess.Write)
										fileStream.Write(array, 0, array.Length)
										fileStream.Close()
									End If
									assembly = Assembly.LoadFile(text4)
									EventMock.tokenMock.Add(text, assembly)
								Else
									EventMock.tokenMock.Add(text, assembly)
								End If
								Return assembly
							Catch
							End Try
						End If
					Catch
					End Try
					result = Nothing
				Else
					result = CType(obj2, Assembly)
				End If
			Finally
				If flag Then
					Dim obj As Hashtable
					Monitor.[Exit](obj)
				End If
			End Try
			Return result
		End Function

		' Token: 0x06000051 RID: 81 RVA: 0x00006D18 File Offset: 0x00004F18
		Private Shared Function VisitClass(string_0 As String) As String
			Dim text As String = string_0.Trim()
			Dim num As Integer = text.IndexOf(","c)
			If num >= 0 Then
				text = text.Substring(0, num)
			End If
			Return text
		End Function

		' Token: 0x04000027 RID: 39
		Private Shared tokenMock As Hashtable = New Hashtable()

		' Token: 0x04000028 RID: 40
		Private Shared m_CustomerMock As Boolean = False
	End Class
End Namespace
