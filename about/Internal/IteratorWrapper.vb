Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace about.Internal

	Friend NotInheritable Module IteratorWrapper
	
		Private Declare Auto Function CryptAcquireContext Lib "advapi32.dll" (ByRef intptr_0 As IntPtr, string_0 As String, string_1 As String, int_0 As Integer, int_1 As Integer) As Boolean

	
		Private Declare Auto Function CryptCreateHash Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, intptr_1 As IntPtr, int_1 As Integer, ByRef intptr_2 As IntPtr) As Boolean

	
		Private Declare Auto Function CryptHashData Lib "advapi32.dll" (intptr_0 As IntPtr, byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Boolean

	
		Private Declare Auto Function CryptGetHashParam Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, byte_0 As Byte(), ByRef int_1 As Integer, int_2 As Integer) As Boolean

	
		Private Declare Function CryptDestroyHash Lib "advapi32.dll" (intptr_0 As IntPtr) As Boolean

	
		Private Declare Function CryptReleaseContext Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer) As Boolean

	
		Public Function ResetPolicy(string_0 As String) As String
			Dim result As String
			Using sha As SHA256 = SHA256.Create()
				Dim array As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(string_0 + "bfdshgs"))
				Dim stringBuilder As StringBuilder = New StringBuilder()
				For Each b As Byte In array
					stringBuilder.Append(b.ToString("x2"))
				Next
				result = stringBuilder.ToString()
			End Using
			Return result
		End Function

	
		Public Function DisablePolicy(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, Optional object_0 As Object = Nothing) As Object
			Dim result As Object
			Dim obj As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Using registryKey As RegistryKey = registryKey_0.OpenSubKey(string_0)
					If registryKey IsNot Nothing Then
						result = registryKey.GetValue(string_1, RuntimeHelpers.GetObjectValue(object_0))
					Else
						result = object_0
					End If
				End Using
				Dim num3 As Integer = num4 + 1
				num4 = num2

			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
			End Try
			Return result
		End Function

	
		Public Sub InterruptPolicy(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, object_0 As Object, Optional registryValueKind_0 As RegistryValueKind = 1)
			Try
				Using registryKey As RegistryKey = registryKey_0.OpenSubKey(string_0, True)
					If registryKey Is Nothing Then
						Using registryKey2 As RegistryKey = registryKey_0.CreateSubKey(string_0)
							registryKey2.SetValue(string_1, RuntimeHelpers.GetObjectValue(object_0), registryValueKind_0)
						End Using
					End If
					registryKey.SetValue(string_1, RuntimeHelpers.GetObjectValue(object_0), registryValueKind_0)
				End Using
			Catch ex As Exception
				Throw New Exception("写入注册表值时发生错误: " + ex.Message)
			End Try
		End Sub

	
		Public Sub ForgotPolicy(registryKey_0 As RegistryKey, string_0 As String, string_1 As String)
			Try
				Using registryKey As RegistryKey = registryKey_0.OpenSubKey(string_0, True)
					If registryKey IsNot Nothing Then
						registryKey.DeleteValue(string_1, False)
					End If
				End Using
			Catch ex As Exception
				Throw New Exception("删除注册表值时发生错误: " + ex.Message)
			End Try
		End Sub

	
		Public Function ExcludePolicy(registryKey_0 As RegistryKey, string_0 As String) As Boolean
			Dim result As Boolean
			Try
				Using registryKey As RegistryKey = registryKey_0.OpenSubKey(string_0)
					result = (registryKey IsNot Nothing)
				End Using
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

	
		Public Function InitPolicy(registryKey_0 As RegistryKey, string_0 As String) As Boolean
			Dim result As Boolean
			Try
				Using registryKey As RegistryKey = registryKey_0.OpenSubKey(string_0)
					If registryKey Is Nothing Then
						Using registryKey_0.CreateSubKey(string_0)
							Return True
						End Using
					End If
					result = True
				End Using
			Catch ex As Exception
				Throw New Exception("确保注册表键存在操作失败: " + ex.Message)
			End Try
			Return result
		End Function

	
		Public Sub QueryPolicy(registryKey_0 As RegistryKey, string_0 As String)
			Try
				If IteratorWrapper.ExcludePolicy(registryKey_0, string_0) Then
					registryKey_0.DeleteSubKey(string_0)
				End If
			Catch ex As Exception
				Throw New Exception("删除注册表键时发生错误: " + ex.Message)
			End Try
		End Sub

	
		Public eventWrapper As String

	
		Public m_MockWrapper As String

	
		Private Const m_QueueWrapper As Integer = 1

	
		Private Const mappingWrapper As Integer = -268435456

	
		Private Const helperWrapper As Integer = 32771

	
		Private Const _GlobalWrapper As Integer = 2
	End Module
End Namespace
