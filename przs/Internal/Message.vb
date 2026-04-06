Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace przs.Internal

	Friend NotInheritable Module Message
	
		Private Declare Auto Function CryptAcquireContext Lib "advapi32.dll" (ByRef intptr_0 As IntPtr, string_0 As String, string_1 As String, int_0 As Integer, int_1 As Integer) As Boolean

	
		Private Declare Auto Function CryptCreateHash Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, intptr_1 As IntPtr, int_1 As Integer, ByRef intptr_2 As IntPtr) As Boolean

	
		Private Declare Auto Function CryptHashData Lib "advapi32.dll" (intptr_0 As IntPtr, byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Boolean

	
		Private Declare Auto Function CryptGetHashParam Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, byte_0 As Byte(), ByRef int_1 As Integer, int_2 As Integer) As Boolean

	
		Private Declare Function CryptDestroyHash Lib "advapi32.dll" (intptr_0 As IntPtr) As Boolean

	
		Private Declare Function CryptReleaseContext Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer) As Boolean

	
		Public Function CloneAttribute(string_0 As String) As String
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

	
		Public Function PrepareAttribute(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, Optional object_0 As Object = Nothing) As Object
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

	
		Public Sub ConnectAttribute(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, object_0 As Object, Optional registryValueKind_0 As RegistryValueKind = 1)
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

	
		Public Sub AssetAttribute(registryKey_0 As RegistryKey, string_0 As String, string_1 As String)
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

	
		Public Function NewAttribute(registryKey_0 As RegistryKey, string_0 As String) As Boolean
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

	
		Public Function ExcludeAttribute(registryKey_0 As RegistryKey, string_0 As String) As Boolean
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

	
		Public Sub FindAttribute(registryKey_0 As RegistryKey, string_0 As String)
			Try
				If Message.NewAttribute(registryKey_0, string_0) Then
					registryKey_0.DeleteSubKey(string_0)
				End If
			Catch ex As Exception
				Throw New Exception("删除注册表键时发生错误: " + ex.Message)
			End Try
		End Sub

	
		Public m_Parameter As Object

	
		Public m_Facade As Object

	
		Public _Role As String

	
		Public tokenizer As Boolean = False

	
		Public _Queue As String = "360安全浏览器下载"

	
		Public m_Page As String = "360极速浏览器下载"

	
		Private Const m_Status As Integer = 1

	
		Private Const _List As Integer = -268435456

	
		Private Const schema As Integer = 32771

	
		Private Const m_Account As Integer = 2
	End Module
End Namespace
