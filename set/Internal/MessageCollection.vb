Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace [set].Internal
	' Token: 0x02000010 RID: 16
	Friend NotInheritable Module MessageCollection
		' Token: 0x060000DC RID: 220
		Private Declare Auto Function CryptAcquireContext Lib "advapi32.dll" (ByRef intptr_0 As IntPtr, string_0 As String, string_1 As String, int_0 As Integer, int_1 As Integer) As Boolean

		' Token: 0x060000DD RID: 221
		Private Declare Auto Function CryptCreateHash Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, intptr_1 As IntPtr, int_1 As Integer, ByRef intptr_2 As IntPtr) As Boolean

		' Token: 0x060000DE RID: 222
		Private Declare Auto Function CryptHashData Lib "advapi32.dll" (intptr_0 As IntPtr, byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Boolean

		' Token: 0x060000DF RID: 223
		Private Declare Auto Function CryptGetHashParam Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, byte_0 As Byte(), ByRef int_1 As Integer, int_2 As Integer) As Boolean

		' Token: 0x060000E0 RID: 224
		Private Declare Function CryptDestroyHash Lib "advapi32.dll" (intptr_0 As IntPtr) As Boolean

		' Token: 0x060000E1 RID: 225
		Private Declare Function CryptReleaseContext Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer) As Boolean

		' Token: 0x060000E2 RID: 226 RVA: 0x0000AD1C File Offset: 0x00008F1C
		Public Function TestContext(string_0 As String) As String
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

		' Token: 0x060000E3 RID: 227 RVA: 0x0000290F File Offset: 0x00000B0F
		Public Sub ExcludeContext()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			CandidateCollection.PrepareContext.load.Show()
			Application.Run()
		End Sub

		' Token: 0x060000E4 RID: 228 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		Public Function VisitContext(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, Optional object_0 As Object = Nothing) As Object
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

		' Token: 0x060000E5 RID: 229 RVA: 0x0000AE68 File Offset: 0x00009068
		Public Sub RemoveContext(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, object_0 As Object, Optional registryValueKind_0 As RegistryValueKind = 1)
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

		' Token: 0x060000E6 RID: 230 RVA: 0x0000AF08 File Offset: 0x00009108
		Public Sub ListContext(registryKey_0 As RegistryKey, string_0 As String, string_1 As String)
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

		' Token: 0x060000E7 RID: 231 RVA: 0x0000AF74 File Offset: 0x00009174
		Public Function MoveContext(registryKey_0 As RegistryKey, string_0 As String) As Boolean
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

		' Token: 0x060000E8 RID: 232 RVA: 0x0000AFC8 File Offset: 0x000091C8
		Public Function FindContext(registryKey_0 As RegistryKey, string_0 As String) As Boolean
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

		' Token: 0x060000E9 RID: 233 RVA: 0x0000B04C File Offset: 0x0000924C
		Public Sub RegisterContext(registryKey_0 As RegistryKey, string_0 As String)
			Try
				If MessageCollection.MoveContext(registryKey_0, string_0) Then
					registryKey_0.DeleteSubKey(string_0)
				End If
			Catch ex As Exception
				Throw New Exception("删除注册表键时发生错误: " + ex.Message)
			End Try
		End Sub

		' Token: 0x0400006F RID: 111
		Public m_InfoCollection As String

		' Token: 0x04000070 RID: 112
		Public m_SingletonCollection As String

		' Token: 0x04000071 RID: 113
		Private Const _ProductCollection As Integer = 1

		' Token: 0x04000072 RID: 114
		Private Const issuerCollection As Integer = -268435456

		' Token: 0x04000073 RID: 115
		Private Const m_ThreadCollection As Integer = 32771

		' Token: 0x04000074 RID: 116
		Private Const testCollection As Integer = 2
	End Module
End Namespace
