Imports System
Imports System.Collections
Imports System.IO
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Namespace about.Internal
	' Token: 0x02000015 RID: 21
	Friend Class TokenizerWrapper
		' Token: 0x06000096 RID: 150 RVA: 0x00008670 File Offset: 0x00006870
		Friend Shared Sub smethod_0()
			If Not TokenizerWrapper.producerWrapper Then
				TokenizerWrapper.producerWrapper = True
				Dim currentDomain As AppDomain = AppDomain.CurrentDomain
				AddHandler currentDomain.AssemblyResolve, AddressOf TokenizerWrapper.EnableWrapper
			End If
		End Sub

		' Token: 0x06000097 RID: 151 RVA: 0x000086A4 File Offset: 0x000068A4
		Private Shared Function EnableWrapper(object_0 As Object, resolveEventArgs_0 As ResolveEventArgs) As Assembly
			Dim flag As Boolean = False
			Dim result As Assembly
			Try
				Dim hashtable As Hashtable = TokenizerWrapper.systemWrapper
				Dim obj As Hashtable = hashtable
				Monitor.Enter(hashtable, flag)
				Dim text As String = resolveEventArgs_0.Name.Trim()
				Dim obj2 As Object = TokenizerWrapper.systemWrapper(text)
				If obj2 Is Nothing Then
					Try
						RSACryptoServiceProvider.UseMachineKeyStore = True
						Dim text2 As String = TokenizerWrapper.RestartWrapper(text)
						Dim bytes As Byte() = Encoding.Unicode.GetBytes(text2)
						Dim text3 As String = "b0494a1f-4bd3-" + Convert.ToBase64String(PrototypeWrapper.StartPolicy(bytes))
						Dim manifestResourceStream As Stream = GetType(TokenizerWrapper).Assembly.GetManifestResourceStream(text3)
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
									TokenizerWrapper.systemWrapper.Add(text, assembly)
								Else
									TokenizerWrapper.systemWrapper.Add(text, assembly)
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

		' Token: 0x06000098 RID: 152 RVA: 0x000088BC File Offset: 0x00006ABC
		Private Shared Function RestartWrapper(string_0 As String) As String
			Dim text As String = string_0.Trim()
			Dim num As Integer = text.IndexOf(","c)
			If num >= 0 Then
				text = text.Substring(0, num)
			End If
			Return text
		End Function

		' Token: 0x04000039 RID: 57
		Private Shared systemWrapper As Hashtable = New Hashtable()

		' Token: 0x0400003A RID: 58
		Private Shared producerWrapper As Boolean = False
	End Class
End Namespace
