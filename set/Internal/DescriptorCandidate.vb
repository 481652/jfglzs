Imports System
Imports System.Collections
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Namespace [set].Internal
	' Token: 0x02000018 RID: 24
	Friend Class DescriptorCandidate
		' Token: 0x06000117 RID: 279 RVA: 0x0000F558 File Offset: 0x0000D758
		Friend Shared Sub smethod_0()
			If Not DescriptorCandidate.methodCandidate Then
				DescriptorCandidate.methodCandidate = True
				Dim currentDomain As AppDomain = AppDomain.CurrentDomain
				AddHandler currentDomain.AssemblyResolve, AddressOf DescriptorCandidate.ValidateCollection
			End If
		End Sub

		' Token: 0x06000118 RID: 280 RVA: 0x0000F58C File Offset: 0x0000D78C
		Private Shared Function ValidateCollection(object_0 As Object, resolveEventArgs_0 As ResolveEventArgs) As Assembly
			Dim flag As Boolean = False
			Dim result As Assembly
			Try
				Dim consumerCandidate As Hashtable = DescriptorCandidate.m_ConsumerCandidate
				Dim obj As Hashtable = consumerCandidate
				Monitor.Enter(consumerCandidate, flag)
				Dim text As String = resolveEventArgs_0.Name.Trim()
				Dim obj2 As Object = DescriptorCandidate.m_ConsumerCandidate(text)
				If obj2 Is Nothing Then
					Try
						RSACryptoServiceProvider.UseMachineKeyStore = True
						Dim text2 As String = DescriptorCandidate.ManageCollection(text)
						Dim bytes As Byte() = Encoding.Unicode.GetBytes(text2)
						Dim text3 As String = "b0494a1f-4bd3-" + Convert.ToBase64String(WrapperCollection.PrintCollection(bytes))
						Dim manifestResourceStream As Stream = GetType(DescriptorCandidate).Assembly.GetManifestResourceStream(text3)
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
									DescriptorCandidate.m_ConsumerCandidate.Add(text, assembly)
								Else
									DescriptorCandidate.m_ConsumerCandidate.Add(text, assembly)
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

		' Token: 0x06000119 RID: 281 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		Private Shared Function ManageCollection(string_0 As String) As String
			Dim text As String = string_0.Trim()
			Dim num As Integer = text.IndexOf(","c)
			If num >= 0 Then
				text = text.Substring(0, num)
			End If
			Return text
		End Function

		' Token: 0x04000086 RID: 134
		Private Shared m_ConsumerCandidate As Hashtable = New Hashtable()

		' Token: 0x04000087 RID: 135
		Private Shared methodCandidate As Boolean = False
	End Class
End Namespace
