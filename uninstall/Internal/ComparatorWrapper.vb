Imports System
Imports System.Collections
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Namespace uninstall.Internal
	' Token: 0x02000017 RID: 23
	Friend Class ComparatorWrapper
		' Token: 0x06000089 RID: 137 RVA: 0x00008EE4 File Offset: 0x000070E4
		Friend Shared Sub smethod_0()
			If Not ComparatorWrapper._SingletonWrapper Then
				ComparatorWrapper._SingletonWrapper = True
				Dim currentDomain As AppDomain = AppDomain.CurrentDomain
				AddHandler currentDomain.AssemblyResolve, AddressOf ComparatorWrapper.WriteWrapper
			End If
		End Sub

		' Token: 0x0600008A RID: 138 RVA: 0x00008F18 File Offset: 0x00007118
		Private Shared Function WriteWrapper(object_0 As Object, resolveEventArgs_0 As ResolveEventArgs) As Assembly
			Dim flag As Boolean = False
			Dim result As Assembly
			Try
				Dim tokenWrapper As Hashtable = ComparatorWrapper.m_TokenWrapper
				Dim obj As Hashtable = tokenWrapper
				Monitor.Enter(tokenWrapper, flag)
				Dim text As String = resolveEventArgs_0.Name.Trim()
				Dim obj2 As Object = ComparatorWrapper.m_TokenWrapper(text)
				If obj2 Is Nothing Then
					Try
						RSACryptoServiceProvider.UseMachineKeyStore = True
						Dim text2 As String = ComparatorWrapper.NewWrapper(text)
						Dim bytes As Byte() = Encoding.Unicode.GetBytes(text2)
						Dim text3 As String = "b0494a1f-4bd3-" + Convert.ToBase64String(WatcherWrapper.RestartConsumer(bytes))
						Dim manifestResourceStream As Stream = GetType(ComparatorWrapper).Assembly.GetManifestResourceStream(text3)
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
									ComparatorWrapper.m_TokenWrapper.Add(text, assembly)
								Else
									ComparatorWrapper.m_TokenWrapper.Add(text, assembly)
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

		' Token: 0x0600008B RID: 139 RVA: 0x00009130 File Offset: 0x00007330
		Private Shared Function NewWrapper(string_0 As String) As String
			Dim text As String = string_0.Trim()
			Dim num As Integer = text.IndexOf(","c)
			If num >= 0 Then
				text = text.Substring(0, num)
			End If
			Return text
		End Function

		' Token: 0x04000042 RID: 66
		Private Shared m_TokenWrapper As Hashtable = New Hashtable()

		' Token: 0x04000043 RID: 67
		Private Shared _SingletonWrapper As Boolean = False
	End Class
End Namespace
