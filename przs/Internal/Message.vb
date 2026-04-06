Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace przs.Internal
	' Token: 0x02000012 RID: 18
	Friend NotInheritable Module Message
		' Token: 0x06000090 RID: 144
		Private Declare Auto Function CryptAcquireContext Lib "advapi32.dll" (ByRef intptr_0 As IntPtr, string_0 As String, string_1 As String, int_0 As Integer, int_1 As Integer) As Boolean

		' Token: 0x06000091 RID: 145
		Private Declare Auto Function CryptCreateHash Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, intptr_1 As IntPtr, int_1 As Integer, ByRef intptr_2 As IntPtr) As Boolean

		' Token: 0x06000092 RID: 146
		Private Declare Auto Function CryptHashData Lib "advapi32.dll" (intptr_0 As IntPtr, byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Boolean

		' Token: 0x06000093 RID: 147
		Private Declare Auto Function CryptGetHashParam Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, byte_0 As Byte(), ByRef int_1 As Integer, int_2 As Integer) As Boolean

		' Token: 0x06000094 RID: 148
		Private Declare Function CryptDestroyHash Lib "advapi32.dll" (intptr_0 As IntPtr) As Boolean

		' Token: 0x06000095 RID: 149
		Private Declare Function CryptReleaseContext Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer) As Boolean

		' Token: 0x06000096 RID: 150 RVA: 0x00006984 File Offset: 0x00004B84
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

		' Token: 0x06000097 RID: 151 RVA: 0x00006A08 File Offset: 0x00004C08
		Public Function PrepareAttribute(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, Optional object_0 As Object = Nothing) As Object
			Dim num As Integer
			Dim result As Object
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Using registryKey As RegistryKey = registryKey_0.OpenSubKey(string_0)
					If registryKey IsNot Nothing Then
						result = registryKey.GetValue(string_1, RuntimeHelpers.GetObjectValue(object_0))
					Else
						result = object_0
					End If
				End Using
				IL_33:
				GoTo IL_92
				IL_35:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_51:
				GoTo IL_87
				IL_53:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_64:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_53
			End Try
			IL_87:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_92:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000098 RID: 152 RVA: 0x00006AD0 File Offset: 0x00004CD0
		Public Sub ConnectAttribute(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, object_0 As Object, Optional registryValueKind_0 As RegistryValueKind = 1)
			Try
				Using registryKey As RegistryKey = registryKey_0.OpenSubKey(string_0, True)
					If registryKey Is Nothing Then
						Using registryKey2 As RegistryKey = registryKey_0.CreateSubKey(string_0)
							registryKey2.SetValue(string_1, RuntimeHelpers.GetObjectValue(object_0), registryValueKind_0)
							GoTo IL_3F
						End Using
					End If
					registryKey.SetValue(string_1, RuntimeHelpers.GetObjectValue(object_0), registryValueKind_0)
					IL_3F:
				End Using
			Catch ex As Exception
				Throw New Exception("写入注册表值时发生错误: " + ex.Message)
			End Try
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x00006B70 File Offset: 0x00004D70
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

		' Token: 0x0600009A RID: 154 RVA: 0x00006BDC File Offset: 0x00004DDC
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

		' Token: 0x0600009B RID: 155 RVA: 0x00006C30 File Offset: 0x00004E30
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

		' Token: 0x0600009C RID: 156 RVA: 0x00006CB4 File Offset: 0x00004EB4
		Public Sub FindAttribute(registryKey_0 As RegistryKey, string_0 As String)
			Try
				If Message.NewAttribute(registryKey_0, string_0) Then
					registryKey_0.DeleteSubKey(string_0)
				End If
			Catch ex As Exception
				Throw New Exception("删除注册表键时发生错误: " + ex.Message)
			End Try
		End Sub

		' Token: 0x0400004E RID: 78
		Public m_Parameter As Object

		' Token: 0x0400004F RID: 79
		Public m_Facade As Object

		' Token: 0x04000050 RID: 80
		Public _Role As String

		' Token: 0x04000051 RID: 81
		Public tokenizer As Boolean = False

		' Token: 0x04000052 RID: 82
		Public _Queue As String = "360安全浏览器下载"

		' Token: 0x04000053 RID: 83
		Public m_Page As String = "360极速浏览器下载"

		' Token: 0x04000054 RID: 84
		Private Const m_Status As Integer = 1

		' Token: 0x04000055 RID: 85
		Private Const _List As Integer = -268435456

		' Token: 0x04000056 RID: 86
		Private Const schema As Integer = 32771

		' Token: 0x04000057 RID: 87
		Private Const m_Account As Integer = 2
	End Module
End Namespace
