Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Namespace [set].Internal

	Friend Class WrapperCollection
	
		Shared Sub New()
			WrapperCollection.eventCollection = False
			WrapperCollection.policyCollection = New Byte(-1) {}
			WrapperCollection.m_ServiceCollection = New Byte(-1) {}
			WrapperCollection.reponseCollection = New Byte(-1) {}
			WrapperCollection.readerCollection = New Byte(-1) {}
			WrapperCollection._RoleCollection = IntPtr.Zero
			WrapperCollection.m_WriterCollection = IntPtr.Zero
			WrapperCollection._ClassCollection = New String(-1) {}
			WrapperCollection._HelperCollection = New Integer(-1) {}
			WrapperCollection._GlobalCollection = 1
			WrapperCollection.structCollection = 0L
			WrapperCollection.initializerCollection = 0
			WrapperCollection.processCollection = False
		End Sub

	
		Private Sub method_0()
		End Sub

	
		Friend Shared Function DestroyContext(object_0 As Object) As Byte()
			Dim array As UInteger() = New UInteger(15) {}
			Dim num As Integer = 448 - object_0.Length * 8 Mod 512
			Dim num2 As UInteger = CUInt(((num + 512) Mod 512))
			If num2 = 0UI Then
				num2 = 512UI
			End If
			Dim num3 As UInteger = CUInt((CLng(object_0.Length) + CLng(CULng((num2 / 8UI))) + 8L))
			Dim num4 As ULong = CULng((CLng(object_0.Length) * 8L))
			Dim array2 As Byte() = New Byte(num3 - 1) {}
			For i As Integer = 0 To object_0.Length - 1
				array2(i) = object_0(i)
			Next
			Dim array3 As Byte() = array2
			Dim num5 As Integer = object_0.Length
			array3(num5) = array3(num5) Or 128
			For j As Integer = 8 To 0 + 1 Step -1
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				array2(CInt((CType((CULng(num3) - CULng(CLng(j))), IntPtr)))) = CByte((num4 >> (8 - j) * 8 And 255UL))
			Next
			Dim num6 As UInteger = CUInt((array2.Length * 8 / 32))
			Dim num7 As UInteger = 1732584193UI
			Dim num8 As UInteger = 4023233417UI
			Dim num9 As UInteger = 2562383102UI
			Dim num10 As UInteger = 271733878UI
			For num11 As UInteger = 0UI To num6 / 16UI - 1
				Dim num12 As UInteger = num11 << 6
				For num13 As UInteger = 0UI To 61UI - 1 Step 4UI
					array(CInt(CType((num13 >> 2), UIntPtr))) = CUInt((CInt(array2(CInt(CType((num12 + (num13 + 3UI)), UIntPtr)))) << 24 Or CInt(array2(CInt(CType((num12 + (num13 + 2UI)), UIntPtr)))) << 16 Or CInt(array2(CInt(CType((num12 + (num13 + 1UI)), UIntPtr)))) << 8 Or CInt(array2(CInt(CType((num12 + num13), UIntPtr))))))
				Next
				Dim num14 As UInteger = num7
				Dim num15 As UInteger = num8
				Dim num16 As UInteger = num9
				Dim num17 As UInteger = num10
				WrapperCollection.ForgotContext(num7, num8, num9, num10, 0UI, 7US, 1UI, array)
				WrapperCollection.ForgotContext(num10, num7, num8, num9, 1UI, 12US, 2UI, array)
				WrapperCollection.ForgotContext(num9, num10, num7, num8, 2UI, 17US, 3UI, array)
				WrapperCollection.ForgotContext(num8, num9, num10, num7, 3UI, 22US, 4UI, array)
				WrapperCollection.ForgotContext(num7, num8, num9, num10, 4UI, 7US, 5UI, array)
				WrapperCollection.ForgotContext(num10, num7, num8, num9, 5UI, 12US, 6UI, array)
				WrapperCollection.ForgotContext(num9, num10, num7, num8, 6UI, 17US, 7UI, array)
				WrapperCollection.ForgotContext(num8, num9, num10, num7, 7UI, 22US, 8UI, array)
				WrapperCollection.ForgotContext(num7, num8, num9, num10, 8UI, 7US, 9UI, array)
				WrapperCollection.ForgotContext(num10, num7, num8, num9, 9UI, 12US, 10UI, array)
				WrapperCollection.ForgotContext(num9, num10, num7, num8, 10UI, 17US, 11UI, array)
				WrapperCollection.ForgotContext(num8, num9, num10, num7, 11UI, 22US, 12UI, array)
				WrapperCollection.ForgotContext(num7, num8, num9, num10, 12UI, 7US, 13UI, array)
				WrapperCollection.ForgotContext(num10, num7, num8, num9, 13UI, 12US, 14UI, array)
				WrapperCollection.ForgotContext(num9, num10, num7, num8, 14UI, 17US, 15UI, array)
				WrapperCollection.ForgotContext(num8, num9, num10, num7, 15UI, 22US, 16UI, array)
				WrapperCollection.DisableContext(num7, num8, num9, num10, 1UI, 5US, 17UI, array)
				WrapperCollection.DisableContext(num10, num7, num8, num9, 6UI, 9US, 18UI, array)
				WrapperCollection.DisableContext(num9, num10, num7, num8, 11UI, 14US, 19UI, array)
				WrapperCollection.DisableContext(num8, num9, num10, num7, 0UI, 20US, 20UI, array)
				WrapperCollection.DisableContext(num7, num8, num9, num10, 5UI, 5US, 21UI, array)
				WrapperCollection.DisableContext(num10, num7, num8, num9, 10UI, 9US, 22UI, array)
				WrapperCollection.DisableContext(num9, num10, num7, num8, 15UI, 14US, 23UI, array)
				WrapperCollection.DisableContext(num8, num9, num10, num7, 4UI, 20US, 24UI, array)
				WrapperCollection.DisableContext(num7, num8, num9, num10, 9UI, 5US, 25UI, array)
				WrapperCollection.DisableContext(num10, num7, num8, num9, 14UI, 9US, 26UI, array)
				WrapperCollection.DisableContext(num9, num10, num7, num8, 3UI, 14US, 27UI, array)
				WrapperCollection.DisableContext(num8, num9, num10, num7, 8UI, 20US, 28UI, array)
				WrapperCollection.DisableContext(num7, num8, num9, num10, 13UI, 5US, 29UI, array)
				WrapperCollection.DisableContext(num10, num7, num8, num9, 2UI, 9US, 30UI, array)
				WrapperCollection.DisableContext(num9, num10, num7, num8, 7UI, 14US, 31UI, array)
				WrapperCollection.DisableContext(num8, num9, num10, num7, 12UI, 20US, 32UI, array)
				WrapperCollection.PostContext(num7, num8, num9, num10, 5UI, 4US, 33UI, array)
				WrapperCollection.PostContext(num10, num7, num8, num9, 8UI, 11US, 34UI, array)
				WrapperCollection.PostContext(num9, num10, num7, num8, 11UI, 16US, 35UI, array)
				WrapperCollection.PostContext(num8, num9, num10, num7, 14UI, 23US, 36UI, array)
				WrapperCollection.PostContext(num7, num8, num9, num10, 1UI, 4US, 37UI, array)
				WrapperCollection.PostContext(num10, num7, num8, num9, 4UI, 11US, 38UI, array)
				WrapperCollection.PostContext(num9, num10, num7, num8, 7UI, 16US, 39UI, array)
				WrapperCollection.PostContext(num8, num9, num10, num7, 10UI, 23US, 40UI, array)
				WrapperCollection.PostContext(num7, num8, num9, num10, 13UI, 4US, 41UI, array)
				WrapperCollection.PostContext(num10, num7, num8, num9, 0UI, 11US, 42UI, array)
				WrapperCollection.PostContext(num9, num10, num7, num8, 3UI, 16US, 43UI, array)
				WrapperCollection.PostContext(num8, num9, num10, num7, 6UI, 23US, 44UI, array)
				WrapperCollection.PostContext(num7, num8, num9, num10, 9UI, 4US, 45UI, array)
				WrapperCollection.PostContext(num10, num7, num8, num9, 12UI, 11US, 46UI, array)
				WrapperCollection.PostContext(num9, num10, num7, num8, 15UI, 16US, 47UI, array)
				WrapperCollection.PostContext(num8, num9, num10, num7, 2UI, 23US, 48UI, array)
				WrapperCollection.PopContext(num7, num8, num9, num10, 0UI, 6US, 49UI, array)
				WrapperCollection.PopContext(num10, num7, num8, num9, 7UI, 10US, 50UI, array)
				WrapperCollection.PopContext(num9, num10, num7, num8, 14UI, 15US, 51UI, array)
				WrapperCollection.PopContext(num8, num9, num10, num7, 5UI, 21US, 52UI, array)
				WrapperCollection.PopContext(num7, num8, num9, num10, 12UI, 6US, 53UI, array)
				WrapperCollection.PopContext(num10, num7, num8, num9, 3UI, 10US, 54UI, array)
				WrapperCollection.PopContext(num9, num10, num7, num8, 10UI, 15US, 55UI, array)
				WrapperCollection.PopContext(num8, num9, num10, num7, 1UI, 21US, 56UI, array)
				WrapperCollection.PopContext(num7, num8, num9, num10, 8UI, 6US, 57UI, array)
				WrapperCollection.PopContext(num10, num7, num8, num9, 15UI, 10US, 58UI, array)
				WrapperCollection.PopContext(num9, num10, num7, num8, 6UI, 15US, 59UI, array)
				WrapperCollection.PopContext(num8, num9, num10, num7, 13UI, 21US, 60UI, array)
				WrapperCollection.PopContext(num7, num8, num9, num10, 4UI, 6US, 61UI, array)
				WrapperCollection.PopContext(num10, num7, num8, num9, 11UI, 10US, 62UI, array)
				WrapperCollection.PopContext(num9, num10, num7, num8, 2UI, 15US, 63UI, array)
				WrapperCollection.PopContext(num8, num9, num10, num7, 9UI, 21US, 64UI, array)
				num7 += num14
				num8 += num15
				num9 += num16
				num10 += num17
			Next
			Dim array4 As Byte() = New Byte(15) {}
			Array.Copy(BitConverter.GetBytes(num7), 0, array4, 0, 4)
			Array.Copy(BitConverter.GetBytes(num8), 0, array4, 4, 4)
			Array.Copy(BitConverter.GetBytes(num9), 0, array4, 8, 4)
			Array.Copy(BitConverter.GetBytes(num10), 0, array4, 12, 4)
			Return array4
		End Function

	
		Private Shared Sub ForgotContext(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WrapperCollection.AssetContext(uint_0 + ((uint_1 And uint_2) Or (Not uint_1 And uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + WrapperCollection.listCollection(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub DisableContext(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WrapperCollection.AssetContext(uint_0 + ((uint_1 And uint_3) Or (uint_2 And Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + WrapperCollection.listCollection(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub PostContext(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WrapperCollection.AssetContext(uint_0 + (uint_1 Xor uint_2 Xor uint_3) + object_0(CInt(CType(uint_4, UIntPtr))) + WrapperCollection.listCollection(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub PopContext(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WrapperCollection.AssetContext(uint_0 + (uint_2 Xor (uint_1 Or Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + WrapperCollection.listCollection(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Function AssetContext(uint_0 As UInteger, ushort_0 As UShort) As UInteger
			Return uint_0 >> CInt((32US - ushort_0)) Or uint_0 << CInt(ushort_0)
		End Function

	
		Friend Shared Function RevertContext() As Boolean
			If Not WrapperCollection.m_DicCollection Then
				WrapperCollection.SortCollection()
				WrapperCollection.m_DicCollection = True
			End If
			Return WrapperCollection.eventCollection
		End Function

	
		Friend Shared Sub SortCollection()
			Try
				WrapperCollection.eventCollection = CBool(GetType(RijndaelManaged).Assembly.[GetType]("System.Security.Cryptography.CryptoConfig", False).GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.[Static] Or BindingFlags.[Public]).Invoke(Nothing, New Object(-1) {}))
			Catch
			End Try
		End Sub

	
		Friend Shared Function InterruptCollection() As SymmetricAlgorithm
			Dim result As SymmetricAlgorithm = Nothing
			If WrapperCollection.RevertContext() Then
				Try
					Return New AesCryptoServiceProvider()
				Catch
					Return New RijndaelManaged()
				End Try
			End If
			result = New RijndaelManaged()
			Return result
		End Function

	
		Friend Shared Function PrintCollection(byte_0 As Byte()) As Byte()
			If Not WrapperCollection.RevertContext() Then
				Return New MD5CryptoServiceProvider().ComputeHash(byte_0)
			End If
			Return WrapperCollection.DestroyContext(byte_0)
		End Function

	
		Shared Function CalculateCollection(int_0 As Integer) As Boolean
			If WrapperCollection.m_ServiceCollection.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WrapperCollection).Assembly.GetManifestResourceStream("4b378505-5ac5-46a6-950d-1c301fe98533"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 176
				array2(0) = 133
				array2(0) = 100
				array2(0) = 42
				array2(1) = 154
				array2(1) = 104
				array2(1) = 128
				array2(1) = 77
				array2(2) = 134
				array2(2) = 208
				array2(2) = 165
				array2(2) = 49
				array2(2) = 98
				array2(3) = 212
				array2(3) = 142
				array2(3) = 163
				array2(3) = 162
				array2(3) = 124
				array2(4) = 96
				array2(4) = 136
				array2(4) = 114
				array2(5) = 128
				array2(5) = 110
				array2(5) = 120
				array2(5) = 184
				array2(5) = 240
				array2(6) = 128
				array2(6) = 144
				array2(6) = 170
				array2(6) = 149
				array2(6) = 77
				array2(7) = 157
				array2(7) = 145
				array2(7) = 64
				array2(8) = 116
				array2(8) = 119
				array2(8) = 120
				array2(8) = 132
				array2(8) = 146
				array2(8) = 165
				array2(9) = 110
				array2(9) = 117
				array2(9) = 77
				array2(10) = 206
				array2(10) = 140
				array2(10) = 196
				array2(10) = 148
				array2(10) = 104
				array2(10) = 177
				array2(11) = 126
				array2(11) = 112
				array2(11) = 59
				array2(11) = 172
				array2(11) = 170
				array2(12) = 87
				array2(12) = 95
				array2(12) = 213
				array2(13) = 131
				array2(13) = 175
				array2(13) = 95
				array2(13) = 74
				array2(13) = 24
				array2(14) = 212
				array2(14) = 149
				array2(14) = 100
				array2(14) = 138
				array2(14) = 112
				array2(14) = 37
				array2(15) = 104
				array2(15) = 112
				array2(15) = 132
				array2(15) = 187
				array2(15) = 166
				array2(15) = 70
				array2(16) = 112
				array2(16) = 86
				array2(16) = 114
				array2(16) = 70
				array2(17) = 141
				array2(17) = 100
				array2(17) = 81
				array2(17) = 139
				array2(17) = 54
				array2(18) = 121
				array2(18) = 128
				array2(18) = 89
				array2(18) = 104
				array2(19) = 84
				array2(19) = 135
				array2(19) = 95
				array2(19) = 170
				array2(19) = 94
				array2(19) = 58
				array2(20) = 179
				array2(20) = 104
				array2(20) = 118
				array2(20) = 174
				array2(21) = 185
				array2(21) = 156
				array2(21) = 77
				array2(22) = 126
				array2(22) = 120
				array2(22) = 176
				array2(23) = 158
				array2(23) = 67
				array2(23) = 112
				array2(23) = 178
				array2(23) = 159
				array2(23) = 98
				array2(24) = 144
				array2(24) = 115
				array2(24) = 158
				array2(24) = 162
				array2(24) = 165
				array2(25) = 59
				array2(25) = 104
				array2(25) = 92
				array2(25) = 164
				array2(25) = 165
				array2(25) = 41
				array2(26) = 59
				array2(26) = 157
				array2(26) = 204
				array2(27) = 136
				array2(27) = 142
				array2(27) = 153
				array2(27) = 202
				array2(27) = 130
				array2(27) = 177
				array2(28) = 175
				array2(28) = 90
				array2(28) = 167
				array2(28) = 102
				array2(28) = 79
				array2(28) = 1
				array2(29) = 91
				array2(29) = 114
				array2(29) = 118
				array2(29) = 90
				array2(29) = 51
				array2(29) = 28
				array2(30) = 190
				array2(30) = 102
				array2(30) = 87
				array2(30) = 43
				array2(31) = 130
				array2(31) = 126
				array2(31) = 114
				array2(31) = 158
				array2(31) = 132
				array2(31) = 0
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 125
				array4(0) = 109
				array4(0) = 17
				array4(1) = 93
				array4(1) = 203
				array4(1) = 91
				array4(1) = 72
				array4(2) = 116
				array4(2) = 208
				array4(2) = 139
				array4(2) = 108
				array4(2) = 40
				array4(2) = 93
				array4(3) = 137
				array4(3) = 116
				array4(3) = 162
				array4(3) = 144
				array4(3) = 195
				array4(4) = 136
				array4(4) = 71
				array4(4) = 140
				array4(4) = 138
				array4(4) = 127
				array4(4) = 48
				array4(5) = 66
				array4(5) = 179
				array4(5) = 236
				array4(5) = 149
				array4(5) = 154
				array4(5) = 103
				array4(6) = 130
				array4(6) = 25
				array4(6) = 37
				array4(7) = 123
				array4(7) = 156
				array4(7) = 144
				array4(7) = 135
				array4(7) = 48
				array4(8) = 146
				array4(8) = 84
				array4(8) = 82
				array4(8) = 166
				array4(8) = 148
				array4(8) = 94
				array4(9) = 196
				array4(9) = 148
				array4(9) = 128
				array4(9) = 126
				array4(10) = 132
				array4(10) = 98
				array4(10) = 111
				array4(11) = 144
				array4(11) = 63
				array4(11) = 67
				array4(11) = 160
				array4(11) = 161
				array4(11) = 220
				array4(12) = 131
				array4(12) = 114
				array4(12) = 106
				array4(12) = 150
				array4(12) = 135
				array4(12) = 2
				array4(13) = 138
				array4(13) = 120
				array4(13) = 211
				array4(14) = 152
				array4(14) = 132
				array4(14) = 187
				array4(14) = 115
				array4(15) = 160
				array4(15) = 92
				array4(15) = 58
				array4(15) = 50
				array4(15) = 107
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(WrapperCollection).Assembly.GetName().GetPublicKeyToken()
				If publicKeyToken IsNot Nothing AndAlso publicKeyToken.Length > 0 Then
					array5(1) = publicKeyToken(0)
					array5(3) = publicKeyToken(1)
					array5(5) = publicKeyToken(2)
					array5(7) = publicKeyToken(3)
					array5(9) = publicKeyToken(4)
					array5(11) = publicKeyToken(5)
					array5(13) = publicKeyToken(6)
					array5(15) = publicKeyToken(7)
				End If
				Dim symmetricAlgorithm As SymmetricAlgorithm = WrapperCollection.InterruptCollection()
				symmetricAlgorithm.Mode = 1
				Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.FlushFinalBlock()
				WrapperCollection.m_ServiceCollection = memoryStream.ToArray()
				memoryStream.Close()
				cryptoStream.Close()
				binaryReader.Close()
			End If
			If WrapperCollection.policyCollection.Length = 0 Then
				WrapperCollection.policyCollection = WrapperCollection.ComputeCollection(WrapperCollection.DeleteCollection(GetType(WrapperCollection).Assembly).ToString())
			End If
			Dim num As Integer = 0
			Try
				num = BitConverter.ToInt32(New Byte() { WrapperCollection.m_ServiceCollection(int_0), WrapperCollection.m_ServiceCollection(int_0 + 1), WrapperCollection.m_ServiceCollection(int_0 + 2), WrapperCollection.m_ServiceCollection(int_0 + 3) }, 0)
			Catch
			End Try
			Try
				If WrapperCollection.policyCollection(num) = 128 Then
					Return True
				End If
			Catch
			End Try
			Return False
		End Function

	
		Shared Function ReflectCollection(int_0 As Integer) As String
			If WrapperCollection.reponseCollection.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WrapperCollection).Assembly.GetManifestResourceStream("4b109a6f-94c5-4d4c-bae5-302725b9bc38"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 162
				array2(0) = 84
				array2(0) = 254
				array2(1) = 90
				array2(1) = 128
				array2(1) = 212
				array2(2) = 92
				array2(2) = 90
				array2(2) = 171
				array2(2) = 5
				array2(3) = 165
				array2(3) = 110
				array2(3) = 138
				array2(3) = 127
				array2(3) = 158
				array2(3) = 7
				array2(4) = 153
				array2(4) = 146
				array2(4) = 98
				array2(4) = 97
				array2(5) = 128
				array2(5) = 103
				array2(5) = 153
				array2(5) = 165
				array2(6) = 138
				array2(6) = 148
				array2(6) = 126
				array2(6) = 242
				array2(6) = 140
				array2(7) = 125
				array2(7) = 95
				array2(7) = 45
				array2(7) = 249
				array2(8) = 107
				array2(8) = 95
				array2(8) = 188
				array2(8) = 102
				array2(8) = 143
				array2(9) = 165
				array2(9) = 131
				array2(9) = 115
				array2(9) = 139
				array2(9) = 157
				array2(9) = 174
				array2(10) = 122
				array2(10) = 131
				array2(10) = 151
				array2(10) = 65
				array2(10) = 6
				array2(11) = 131
				array2(11) = 128
				array2(11) = 245
				array2(12) = 143
				array2(12) = 90
				array2(12) = 176
				array2(12) = 114
				array2(13) = 127
				array2(13) = 167
				array2(13) = 165
				array2(13) = 152
				array2(13) = 152
				array2(13) = 178
				array2(14) = 126
				array2(14) = 102
				array2(14) = 162
				array2(14) = 114
				array2(14) = 80
				array2(14) = 172
				array2(15) = 133
				array2(15) = 94
				array2(15) = 120
				array2(15) = 161
				array2(15) = 208
				array2(16) = 160
				array2(16) = 124
				array2(16) = 96
				array2(16) = 123
				array2(16) = 160
				array2(16) = 91
				array2(17) = 128
				array2(17) = 144
				array2(17) = 108
				array2(17) = 44
				array2(17) = 145
				array2(17) = 170
				array2(18) = 118
				array2(18) = 169
				array2(18) = 47
				array2(18) = 141
				array2(18) = 132
				array2(18) = 215
				array2(19) = 136
				array2(19) = 91
				array2(19) = 113
				array2(19) = 95
				array2(19) = 211
				array2(19) = 7
				array2(20) = 194
				array2(20) = 100
				array2(20) = 47
				array2(20) = 0
				array2(21) = 111
				array2(21) = 197
				array2(21) = 164
				array2(21) = 120
				array2(21) = 122
				array2(21) = 118
				array2(22) = 155
				array2(22) = 167
				array2(22) = 164
				array2(23) = 84
				array2(23) = 86
				array2(23) = 167
				array2(23) = 27
				array2(23) = 162
				array2(23) = 161
				array2(24) = 106
				array2(24) = 149
				array2(24) = 100
				array2(24) = 70
				array2(24) = 142
				array2(24) = 198
				array2(25) = 159
				array2(25) = 98
				array2(25) = 123
				array2(25) = 100
				array2(25) = 177
				array2(26) = 150
				array2(26) = 119
				array2(26) = 158
				array2(26) = 196
				array2(27) = 39
				array2(27) = 122
				array2(27) = 180
				array2(28) = 115
				array2(28) = 97
				array2(28) = 36
				array2(29) = 148
				array2(29) = 71
				array2(29) = 138
				array2(29) = 158
				array2(29) = 126
				array2(30) = 151
				array2(30) = 167
				array2(30) = 152
				array2(31) = 96
				array2(31) = 134
				array2(31) = 62
				array2(31) = 194
				array2(31) = 170
				array2(31) = 210
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 162
				array4(0) = 93
				array4(0) = 90
				array4(0) = 141
				array4(0) = 20
				array4(1) = 18
				array4(1) = 90
				array4(1) = 136
				array4(1) = 20
				array4(1) = 145
				array4(2) = 110
				array4(2) = 138
				array4(2) = 165
				array4(2) = 76
				array4(3) = 185
				array4(3) = 128
				array4(3) = 102
				array4(4) = 141
				array4(4) = 140
				array4(4) = 214
				array4(5) = 192
				array4(5) = 147
				array4(5) = 142
				array4(5) = 86
				array4(6) = 164
				array4(6) = 160
				array4(6) = 142
				array4(6) = 158
				array4(6) = 36
				array4(7) = 68
				array4(7) = 45
				array4(7) = 97
				array4(8) = 33
				array4(8) = 101
				array4(8) = 188
				array4(8) = 125
				array4(8) = 237
				array4(9) = 74
				array4(9) = 149
				array4(9) = 45
				array4(10) = 160
				array4(10) = 115
				array4(10) = 122
				array4(10) = 48
				array4(11) = 152
				array4(11) = 65
				array4(11) = 160
				array4(11) = 146
				array4(11) = 99
				array4(12) = 77
				array4(12) = 63
				array4(12) = 181
				array4(12) = 120
				array4(12) = 126
				array4(12) = 39
				array4(13) = 126
				array4(13) = 95
				array4(13) = 175
				array4(14) = 87
				array4(14) = 32
				array4(14) = 162
				array4(14) = 114
				array4(15) = 156
				array4(15) = 88
				array4(15) = 103
				array4(15) = 51
				array4(15) = 165
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(WrapperCollection).Assembly.GetName().GetPublicKeyToken()
				If publicKeyToken IsNot Nothing AndAlso publicKeyToken.Length > 0 Then
					array5(1) = publicKeyToken(0)
					array5(3) = publicKeyToken(1)
					array5(5) = publicKeyToken(2)
					array5(7) = publicKeyToken(3)
					array5(9) = publicKeyToken(4)
					array5(11) = publicKeyToken(5)
					array5(13) = publicKeyToken(6)
					array5(15) = publicKeyToken(7)
				End If
				For i As Integer = 0 To array5.Length - 1
					array3(i) = array3(i) Xor array5(i)
				Next
				If int_0 = -1 Then
					Dim symmetricAlgorithm As SymmetricAlgorithm = WrapperCollection.InterruptCollection()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					WrapperCollection.reponseCollection = memoryStream.ToArray()
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = WrapperCollection.reponseCollection
				End If
				Dim num As Integer = array.Length Mod 4
				Dim num2 As Integer = array.Length / 4
				Dim array6 As Byte() = New Byte(array.Length - 1) {}
				Dim num3 As Integer = array3.Length / 4
				Dim num4 As UInteger = 0UI
				If num > 0 Then
					num2 += 1
				End If
				For j As Integer = 0 To num2 - 1
					Dim num5 As Integer = j Mod num3
					Dim num6 As Integer = j * 4
					Dim num7 As UInteger = CUInt((num5 * 4))
					Dim num8 As UInteger = CUInt((CInt(array3(CInt(CType((num7 + 3UI), UIntPtr)))) << 24 Or CInt(array3(CInt(CType((num7 + 2UI), UIntPtr)))) << 16 Or CInt(array3(CInt(CType((num7 + 1UI), UIntPtr)))) << 8 Or CInt(array3(CInt(CType(num7, UIntPtr))))))
					Dim num9 As UInteger = 255UI
					Dim num10 As Integer = 0
					Dim num11 As UInteger
					If j = num2 - 1 AndAlso num > 0 Then
						num11 = 0UI
						num4 += num8
						For k As Integer = 0 To num - 1
							If k > 0 Then
								num11 <<= 8
							End If
							num11 = num11 Or CUInt(array(array.Length - (1 + k)))
						Next
					Else
						num4 += num8
						num7 = CUInt(num6)
						num11 = CUInt((CInt(array(CInt(CType((num7 + 3UI), UIntPtr)))) << 24 Or CInt(array(CInt(CType((num7 + 2UI), UIntPtr)))) << 16 Or CInt(array(CInt(CType((num7 + 1UI), UIntPtr)))) << 8 Or CInt(array(CInt(CType(num7, UIntPtr))))))
					End If
					Dim num12 As UInteger = num4
					num4 += 1UI
					Dim num13 As UInteger = num12
					Dim num14 As UInteger = num12
					num14 = num14 Xor num14 >> 25
					num14 += 1394801171UI
					num14 = num14 Xor num14 << 5
					num14 += 3248323196UI
					num14 = num14 Xor num14 >> 3
					num14 += 3677389094UI
					num14 = 1752432640UI + num14
					num12 = num13 + CUInt(num14)
					num4 = num12
					If j = num2 - 1 AndAlso num > 0 Then
						Dim num15 As UInteger = num4 Xor num11
						For l As Integer = 0 To num - 1
							If l > 0 Then
								num9 <<= 8
								num10 += 8
							End If
							array6(num6 + l) = CByte(((num15 And num9) >> num10))
						Next
					Else
						Dim num16 As UInteger = num4 Xor num11
						array6(num6) = CByte((num16 And 255UI))
						array6(num6 + 1) = CByte(((num16 And 65280UI) >> 8))
						array6(num6 + 2) = CByte(((num16 And 16711680UI) >> 16))
						array6(num6 + 3) = CByte(((num16 And 4278190080UI) >> 24))
					End If
				Next
				WrapperCollection.reponseCollection = array6
			End If
			Dim num17 As Integer = BitConverter.ToInt32(WrapperCollection.reponseCollection, int_0)
			Try
				Dim array7 As Byte() = New Byte(num17 - 1) {}
				Array.Copy(WrapperCollection.reponseCollection, int_0 + 4, array7, 0, num17)
				Return Encoding.Unicode.GetString(array7, 0, array7.Length)
			Catch
			End Try
			Return ""
		End Function

	
		Shared Function SetupCollection(int_0 As Integer) As String
			If WrapperCollection.readerCollection.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WrapperCollection).Assembly.GetManifestResourceStream("4b109a6f-94c5-4d4c-bae5-302725b9bc38"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 162
				array2(0) = 84
				array2(0) = 254
				array2(1) = 90
				array2(1) = 128
				array2(1) = 212
				array2(2) = 92
				array2(2) = 90
				array2(2) = 171
				array2(2) = 5
				array2(3) = 165
				array2(3) = 110
				array2(3) = 138
				array2(3) = 127
				array2(3) = 158
				array2(3) = 7
				array2(4) = 153
				array2(4) = 146
				array2(4) = 98
				array2(4) = 97
				array2(5) = 128
				array2(5) = 103
				array2(5) = 153
				array2(5) = 165
				array2(6) = 138
				array2(6) = 148
				array2(6) = 126
				array2(6) = 242
				array2(6) = 140
				array2(7) = 125
				array2(7) = 95
				array2(7) = 45
				array2(7) = 249
				array2(8) = 107
				array2(8) = 95
				array2(8) = 188
				array2(8) = 102
				array2(8) = 143
				array2(9) = 165
				array2(9) = 131
				array2(9) = 115
				array2(9) = 139
				array2(9) = 157
				array2(9) = 174
				array2(10) = 122
				array2(10) = 131
				array2(10) = 151
				array2(10) = 65
				array2(10) = 6
				array2(11) = 131
				array2(11) = 128
				array2(11) = 245
				array2(12) = 143
				array2(12) = 90
				array2(12) = 176
				array2(12) = 114
				array2(13) = 127
				array2(13) = 167
				array2(13) = 165
				array2(13) = 152
				array2(13) = 152
				array2(13) = 178
				array2(14) = 126
				array2(14) = 102
				array2(14) = 162
				array2(14) = 114
				array2(14) = 80
				array2(14) = 172
				array2(15) = 133
				array2(15) = 94
				array2(15) = 120
				array2(15) = 161
				array2(15) = 208
				array2(16) = 160
				array2(16) = 124
				array2(16) = 96
				array2(16) = 123
				array2(16) = 160
				array2(16) = 91
				array2(17) = 128
				array2(17) = 144
				array2(17) = 108
				array2(17) = 44
				array2(17) = 145
				array2(17) = 170
				array2(18) = 118
				array2(18) = 169
				array2(18) = 47
				array2(18) = 141
				array2(18) = 132
				array2(18) = 215
				array2(19) = 136
				array2(19) = 91
				array2(19) = 113
				array2(19) = 95
				array2(19) = 211
				array2(19) = 7
				array2(20) = 194
				array2(20) = 100
				array2(20) = 47
				array2(20) = 0
				array2(21) = 111
				array2(21) = 197
				array2(21) = 164
				array2(21) = 120
				array2(21) = 122
				array2(21) = 118
				array2(22) = 155
				array2(22) = 167
				array2(22) = 164
				array2(23) = 84
				array2(23) = 86
				array2(23) = 167
				array2(23) = 27
				array2(23) = 162
				array2(23) = 161
				array2(24) = 106
				array2(24) = 149
				array2(24) = 100
				array2(24) = 70
				array2(24) = 142
				array2(24) = 198
				array2(25) = 159
				array2(25) = 98
				array2(25) = 123
				array2(25) = 100
				array2(25) = 177
				array2(26) = 150
				array2(26) = 119
				array2(26) = 158
				array2(26) = 196
				array2(27) = 39
				array2(27) = 122
				array2(27) = 180
				array2(28) = 115
				array2(28) = 97
				array2(28) = 36
				array2(29) = 148
				array2(29) = 71
				array2(29) = 138
				array2(29) = 158
				array2(29) = 126
				array2(30) = 151
				array2(30) = 167
				array2(30) = 152
				array2(31) = 96
				array2(31) = 134
				array2(31) = 62
				array2(31) = 194
				array2(31) = 170
				array2(31) = 210
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 162
				array4(0) = 93
				array4(0) = 90
				array4(0) = 141
				array4(0) = 20
				array4(1) = 18
				array4(1) = 90
				array4(1) = 136
				array4(1) = 20
				array4(1) = 145
				array4(2) = 110
				array4(2) = 138
				array4(2) = 165
				array4(2) = 76
				array4(3) = 185
				array4(3) = 128
				array4(3) = 102
				array4(4) = 141
				array4(4) = 140
				array4(4) = 214
				array4(5) = 192
				array4(5) = 147
				array4(5) = 142
				array4(5) = 86
				array4(6) = 164
				array4(6) = 160
				array4(6) = 142
				array4(6) = 158
				array4(6) = 36
				array4(7) = 68
				array4(7) = 45
				array4(7) = 97
				array4(8) = 33
				array4(8) = 101
				array4(8) = 188
				array4(8) = 125
				array4(8) = 237
				array4(9) = 74
				array4(9) = 149
				array4(9) = 45
				array4(10) = 160
				array4(10) = 115
				array4(10) = 122
				array4(10) = 48
				array4(11) = 152
				array4(11) = 65
				array4(11) = 160
				array4(11) = 146
				array4(11) = 99
				array4(12) = 77
				array4(12) = 63
				array4(12) = 181
				array4(12) = 120
				array4(12) = 126
				array4(12) = 39
				array4(13) = 126
				array4(13) = 95
				array4(13) = 175
				array4(14) = 87
				array4(14) = 32
				array4(14) = 162
				array4(14) = 114
				array4(15) = 156
				array4(15) = 88
				array4(15) = 103
				array4(15) = 51
				array4(15) = 165
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(WrapperCollection).Assembly.GetName().GetPublicKeyToken()
				If publicKeyToken IsNot Nothing AndAlso publicKeyToken.Length > 0 Then
					array5(1) = publicKeyToken(0)
					array5(3) = publicKeyToken(1)
					array5(5) = publicKeyToken(2)
					array5(7) = publicKeyToken(3)
					array5(9) = publicKeyToken(4)
					array5(11) = publicKeyToken(5)
					array5(13) = publicKeyToken(6)
					array5(15) = publicKeyToken(7)
				End If
				For i As Integer = 0 To array5.Length - 1
					array3(i) = array3(i) Xor array5(i)
				Next
				If int_0 = -1 Then
					Dim symmetricAlgorithm As SymmetricAlgorithm = WrapperCollection.InterruptCollection()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					WrapperCollection.readerCollection = memoryStream.ToArray()
					If WrapperCollection.readerCollection.Length > 0 Then
						WrapperCollection._ClassCollection = New String(WrapperCollection.readerCollection.Length / 4 + 1 - 1) {}
						WrapperCollection._HelperCollection = New Integer(WrapperCollection.readerCollection.Length / 4 + 1 - 1) {}
					End If
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = WrapperCollection.readerCollection
				End If
				Dim num As Integer = array.Length Mod 4
				Dim num2 As Integer = array.Length / 4
				Dim array6 As Byte() = New Byte(array.Length - 1) {}
				Dim num3 As Integer = array3.Length / 4
				Dim num4 As UInteger = 0UI
				If num > 0 Then
					num2 += 1
				End If
				For j As Integer = 0 To num2 - 1
					Dim num5 As Integer = j Mod num3
					Dim num6 As Integer = j * 4
					Dim num7 As UInteger = CUInt((num5 * 4))
					Dim num8 As UInteger = CUInt((CInt(array3(CInt(CType((num7 + 3UI), UIntPtr)))) << 24 Or CInt(array3(CInt(CType((num7 + 2UI), UIntPtr)))) << 16 Or CInt(array3(CInt(CType((num7 + 1UI), UIntPtr)))) << 8 Or CInt(array3(CInt(CType(num7, UIntPtr))))))
					Dim num9 As UInteger = 255UI
					Dim num10 As Integer = 0
					Dim num11 As UInteger
					If j = num2 - 1 AndAlso num > 0 Then
						num11 = 0UI
						For k As Integer = 0 To num - 1
							If k > 0 Then
								num11 <<= 8
							End If
							num11 = num11 Or CUInt(array(array.Length - (1 + k)))
						Next
						num4 += num8
					Else
						num7 = CUInt(num6)
						num11 = CUInt((CInt(array(CInt(CType((num7 + 3UI), UIntPtr)))) << 24 Or CInt(array(CInt(CType((num7 + 2UI), UIntPtr)))) << 16 Or CInt(array(CInt(CType((num7 + 1UI), UIntPtr)))) << 8 Or CInt(array(CInt(CType(num7, UIntPtr))))))
						num4 += num8
					End If
					Dim num12 As UInteger = num4
					Dim num13 As UInteger = num4
					num13 = num13 Xor num13 >> 25
					num13 += 1394801171UI
					num13 = num13 Xor num13 << 5
					num13 += 3248323196UI
					num13 = num13 Xor num13 >> 3
					num13 += 3677389094UI
					num13 = 1752432640UI + num13
					num4 = num12 + CUInt(num13)
					If j = num2 - 1 AndAlso num > 0 Then
						Dim num14 As UInteger = num4 Xor num11
						For l As Integer = 0 To num - 1
							If l > 0 Then
								num9 <<= 8
								num10 += 8
							End If
							array6(num6 + l) = CByte(((num14 And num9) >> num10))
						Next
					Else
						Dim num15 As UInteger = num4 Xor num11
						array6(num6) = CByte((num15 And 255UI))
						array6(num6 + 1) = CByte(((num15 And 65280UI) >> 8))
						array6(num6 + 2) = CByte(((num15 And 16711680UI) >> 16))
						array6(num6 + 3) = CByte(((num15 And 4278190080UI) >> 24))
					End If
				Next
				WrapperCollection.readerCollection = array6
				If WrapperCollection.readerCollection.Length > 0 Then
					WrapperCollection._ClassCollection = New String(WrapperCollection.readerCollection.Length / 4 + 1 - 1) {}
					WrapperCollection._HelperCollection = New Integer(WrapperCollection.readerCollection.Length / 4 + 1 - 1) {}
				End If
				Dim assembly As Assembly = GetType(WrapperCollection).Assembly
				If IntPtr.Size = 4 Then
					WrapperCollection.initializerCollection = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt32()
				End If
				WrapperCollection.structCollection = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
			End If
			Dim num16 As Integer = int_0 / 4
			If WrapperCollection._HelperCollection(num16) > 0 Then
				Return CType(WrapperCollection._ClassCollection, String())(WrapperCollection._HelperCollection(num16))
			End If
			Dim num17 As Integer = BitConverter.ToInt32(WrapperCollection.readerCollection, int_0)
			If WrapperCollection._RoleCollection = IntPtr.Zero Then
				WrapperCollection._RoleCollection = WrapperCollection.OpenProcess(16UI, 1, CUInt(Process.GetCurrentProcess().Id))
			End If
			Dim array7 As Byte() = New Byte(3) {}
			If IntPtr.Size = 4 Then
				WrapperCollection.ReadProcessMemory(WrapperCollection._RoleCollection, New IntPtr(WrapperCollection.initializerCollection + num17), array7, 4UI, WrapperCollection.m_WriterCollection)
			Else
				WrapperCollection.ReadProcessMemory(WrapperCollection._RoleCollection, New IntPtr(WrapperCollection.structCollection + CLng(num17)), array7, 4UI, WrapperCollection.m_WriterCollection)
			End If
			Dim num18 As Integer = BitConverter.ToInt32(array7, 0)
			array7 = New Byte(num18 - 1) {}
			If IntPtr.Size = 4 Then
				WrapperCollection.ReadProcessMemory(WrapperCollection._RoleCollection, New IntPtr(WrapperCollection.initializerCollection + num17 + 4), array7, Convert.ToUInt32(num18), WrapperCollection.m_WriterCollection)
			Else
				WrapperCollection.ReadProcessMemory(WrapperCollection._RoleCollection, New IntPtr(WrapperCollection.structCollection + CLng(num17) + 4L), array7, Convert.ToUInt32(num18), WrapperCollection.m_WriterCollection)
			End If
			Dim array8 As Byte() = WrapperCollection.DefineCollection(array7)
			Dim [string] As String = Encoding.Unicode.GetString(array8, 0, array8.Length)
			WrapperCollection._HelperCollection(num16) = WrapperCollection._GlobalCollection
			CType(WrapperCollection._ClassCollection, String())(WrapperCollection._GlobalCollection) = [string]
			WrapperCollection._GlobalCollection += 1
			Return [string]
		End Function

	
		Friend Shared Function ConcatCollection(string_0 As String) As String
			Dim array As Byte() = Convert.FromBase64String(string_0)
			Return Encoding.Unicode.GetString(array, 0, array.Length)
		End Function

	
		Private Declare Function VirtualProtect Lib "kernel32.dll" (intptr_0 As IntPtr, int_0 As Integer, int_1 As Integer, ByRef int_2 As Integer) As Integer

	
		<WrapperCollection.PublisherCollection(GetType(WrapperCollection.PublisherCollection.PredicateCollection(Of Object)()))>
		Shared Sub CompareCollection()
			If Not WrapperCollection.processCollection Then
				WrapperCollection.processCollection = True
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WrapperCollection).Assembly.GetManifestResourceStream("04a07f78-7103-45a1-a69f-5bbc8a0e7e8c"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 122
				array2(0) = 140
				array2(0) = 131
				array2(0) = 164
				array2(0) = 122
				array2(1) = 86
				array2(1) = 25
				array2(1) = 155
				array2(1) = 167
				array2(1) = 119
				array2(1) = 86
				array2(2) = 132
				array2(2) = 156
				array2(2) = 90
				array2(2) = 121
				array2(2) = 132
				array2(3) = 132
				array2(3) = 110
				array2(3) = 177
				array2(3) = 221
				array2(3) = 92
				array2(3) = 138
				array2(3) = 132
				array2(4) = 1
				array2(4) = 138
				array2(4) = 49
				array2(4) = 1
				array2(5) = 114
				array2(5) = 99
				array2(5) = 120
				array2(5) = 173
				array2(5) = 18
				array2(5) = 114
				array2(6) = 85
				array2(6) = 187
				array2(6) = 132
				array2(6) = 130
				array2(6) = 23
				array2(6) = 140
				array2(6) = 85
				array2(7) = 217
				array2(7) = 161
				array2(7) = 145
				array2(7) = 217
				array2(8) = 24
				array2(8) = 120
				array2(8) = 132
				array2(8) = 24
				array2(9) = 150
				array2(9) = 100
				array2(9) = 83
				array2(9) = 125
				array2(9) = 119
				array2(9) = 150
				array2(10) = 45
				array2(10) = 181
				array2(10) = 136
				array2(10) = 141
				array2(10) = 45
				array2(11) = 90
				array2(11) = 120
				array2(11) = 168
				array2(11) = 170
				array2(11) = 79
				array2(11) = 90
				array2(12) = 79
				array2(12) = 148
				array2(12) = 144
				array2(12) = 144
				array2(12) = 132
				array2(12) = 192
				array2(12) = 79
				array2(13) = 204
				array2(13) = 214
				array2(13) = 92
				array2(13) = 144
				array2(13) = 96
				array2(13) = 204
				array2(14) = 227
				array2(14) = 123
				array2(14) = 136
				array2(14) = 110
				array2(14) = 126
				array2(14) = 35
				array2(14) = 227
				array2(15) = 143
				array2(15) = 111
				array2(15) = 129
				array2(15) = 96
				array2(15) = 94
				array2(15) = 90
				array2(15) = 143
				array2(16) = 245
				array2(16) = 126
				array2(16) = 31
				array2(16) = 159
				array2(16) = 126
				array2(16) = 137
				array2(16) = 245
				array2(17) = 240
				array2(17) = 50
				array2(17) = 152
				array2(17) = 118
				array2(17) = 84
				array2(17) = 240
				array2(18) = 183
				array2(18) = 181
				array2(18) = 114
				array2(18) = 183
				array2(19) = 237
				array2(19) = 155
				array2(19) = 170
				array2(19) = 85
				array2(19) = 237
				array2(20) = 191
				array2(20) = 90
				array2(20) = 75
				array2(20) = 191
				array2(21) = 123
				array2(21) = 52
				array2(21) = 94
				array2(21) = 95
				array2(21) = 123
				array2(22) = 76
				array2(22) = 128
				array2(22) = 24
				array2(22) = 126
				array2(22) = 76
				array2(23) = 246
				array2(23) = 165
				array2(23) = 133
				array2(23) = 111
				array2(23) = 246
				array2(24) = 195
				array2(24) = 130
				array2(24) = 132
				array2(24) = 195
				array2(25) = 68
				array2(25) = 156
				array2(25) = 172
				array2(25) = 185
				array2(25) = 112
				array2(25) = 93
				array2(25) = 68
				array2(26) = 186
				array2(26) = 109
				array2(26) = 92
				array2(26) = 165
				array2(26) = 179
				array2(26) = 90
				array2(26) = 186
				array2(27) = 63
				array2(27) = 109
				array2(27) = 136
				array2(27) = 144
				array2(27) = 207
				array2(27) = 63
				array2(28) = 49
				array2(28) = 186
				array2(28) = 156
				array2(28) = 130
				array2(28) = 126
				array2(28) = 68
				array2(28) = 49
				array2(29) = 228
				array2(29) = 126
				array2(29) = 36
				array2(29) = 197
				array2(29) = 228
				array2(30) = 116
				array2(30) = 86
				array2(30) = 158
				array2(30) = 116
				array2(31) = 35
				array2(31) = 114
				array2(31) = 89
				array2(31) = 114
				array2(31) = 152
				array2(31) = 90
				array2(31) = 35
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 140
				array4(0) = 131
				array4(0) = 164
				array4(0) = 98
				array4(0) = 19
				array4(0) = 233
				array4(1) = 167
				array4(1) = 119
				array4(1) = 157
				array4(1) = 156
				array4(1) = 90
				array4(1) = 146
				array4(2) = 124
				array4(2) = 117
				array4(2) = 158
				array4(2) = 12
				array4(3) = 199
				array4(3) = 135
				array4(3) = 126
				array4(3) = 62
				array4(3) = 108
				array4(4) = 144
				array4(4) = 85
				array4(4) = 147
				array4(4) = 146
				array4(4) = 181
				array4(5) = 141
				array4(5) = 114
				array4(5) = 138
				array4(5) = 132
				array4(5) = 109
				array4(5) = 211
				array4(6) = 96
				array4(6) = 97
				array4(6) = 81
				array4(7) = 157
				array4(7) = 142
				array4(7) = 89
				array4(7) = 57
				array4(8) = 129
				array4(8) = 171
				array4(8) = 221
				array4(9) = 80
				array4(9) = 155
				array4(9) = 134
				array4(9) = 137
				array4(9) = 136
				array4(9) = 140
				array4(10) = 115
				array4(10) = 94
				array4(10) = 97
				array4(11) = 154
				array4(11) = 133
				array4(11) = 205
				array4(12) = 12
				array4(12) = 148
				array4(12) = 137
				array4(12) = 222
				array4(13) = 148
				array4(13) = 140
				array4(13) = 162
				array4(13) = 162
				array4(13) = 103
				array4(14) = 144
				array4(14) = 24
				array4(14) = 238
				array4(15) = 132
				array4(15) = 99
				array4(15) = 136
				array4(15) = 141
				array4(15) = 75
				Dim array5 As Byte() = array4
				Array.Reverse(array5)
				Dim publicKeyToken As Byte() = GetType(WrapperCollection).Assembly.GetName().GetPublicKeyToken()
				If publicKeyToken IsNot Nothing AndAlso publicKeyToken.Length > 0 Then
					array5(1) = publicKeyToken(0)
					array5(3) = publicKeyToken(1)
					array5(5) = publicKeyToken(2)
					array5(7) = publicKeyToken(3)
					array5(9) = publicKeyToken(4)
					array5(11) = publicKeyToken(5)
					array5(13) = publicKeyToken(6)
					array5(15) = publicKeyToken(7)
					Array.Clear(publicKeyToken, 0, publicKeyToken.Length)
				End If
				For i As Integer = 0 To array5.Length - 1
					array3(i) = array3(i) Xor array5(i)
				Next
				Dim array6 As Byte() = array
				Dim num As Integer = array6.Length Mod 4
				Dim num2 As Integer = array6.Length / 4
				Dim array7 As Byte() = New Byte(array6.Length - 1) {}
				Dim num3 As Integer = array3.Length / 4
				Dim num4 As UInteger = 0UI
				If num > 0 Then
					num2 += 1
				End If
				For j As Integer = 0 To num2 - 1
					Dim num5 As Integer = j Mod num3
					Dim num6 As Integer = j * 4
					Dim num7 As UInteger = CUInt((num5 * 4))
					Dim num8 As UInteger = CUInt((CInt(array3(CInt(CType((num7 + 3UI), UIntPtr)))) << 24 Or CInt(array3(CInt(CType((num7 + 2UI), UIntPtr)))) << 16 Or CInt(array3(CInt(CType((num7 + 1UI), UIntPtr)))) << 8 Or CInt(array3(CInt(CType(num7, UIntPtr))))))
					Dim num9 As UInteger = 255UI
					Dim num10 As Integer = 0
					Dim num11 As UInteger
					If j = num2 - 1 AndAlso num > 0 Then
						num4 += num8
						num11 = 0UI
						For k As Integer = 0 To num - 1
							If k > 0 Then
								num11 <<= 8
							End If
							num11 = num11 Or CUInt(array6(array6.Length - (1 + k)))
						Next
					Else
						num7 = CUInt(num6)
						num4 += num8
						num11 = CUInt((CInt(array6(CInt(CType((num7 + 3UI), UIntPtr)))) << 24 Or CInt(array6(CInt(CType((num7 + 2UI), UIntPtr)))) << 16 Or CInt(array6(CInt(CType((num7 + 1UI), UIntPtr)))) << 8 Or CInt(array6(CInt(CType(num7, UIntPtr))))))
					End If
					num4 = num4
					Dim num12 As UInteger = num4
					Dim num13 As UInteger = num4
					num13 = num13 Xor num13 >> 25
					num13 += 1394801171UI
					num13 = num13 Xor num13 << 5
					num13 += 3248323196UI
					num13 = num13 Xor num13 >> 3
					num13 += 3677389094UI
					num13 = 1752432640UI + num13
					num4 = num12 + CUInt(num13)
					If j = num2 - 1 AndAlso num > 0 Then
						Dim num14 As UInteger = num4 Xor num11
						For l As Integer = 0 To num - 1
							If l > 0 Then
								num9 <<= 8
								num10 += 8
							End If
							array7(num6 + l) = CByte(((num14 And num9) >> num10))
						Next
					Else
						Dim num15 As UInteger = num4 Xor num11
						array7(num6) = CByte((num15 And 255UI))
						array7(num6 + 1) = CByte(((num15 And 65280UI) >> 8))
						array7(num6 + 2) = CByte(((num15 And 16711680UI) >> 16))
						array7(num6 + 3) = CByte(((num15 And 4278190080UI) >> 24))
					End If
				Next
				Dim buffer As Byte() = array7
				Array.Clear(array5, 0, array5.Length)
				binaryReader.Close()
				binaryReader = New BinaryReader(New MemoryStream(buffer))
				binaryReader.BaseStream.Position = 0L
				Dim intptr_ As IntPtr = IntPtr.Zero
				Dim assembly As Assembly = GetType(WrapperCollection).Assembly
				intptr_ = WrapperCollection.OpenProcess(56UI, 1, CUInt(Process.GetCurrentProcess().Id))
				WrapperCollection.structCollection = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
				Dim zero As IntPtr = IntPtr.Zero
				Dim int_ As Integer = 0
				Dim num16 As Integer = binaryReader.ReadInt32()
				binaryReader.ReadInt32()
				For m As Integer = 0 To num16 - 1
					Dim intPtr As IntPtr = New IntPtr(WrapperCollection.structCollection + CLng(binaryReader.ReadInt32()))
					WrapperCollection.VirtualProtect(intPtr, 4, 4, int_)
					If IntPtr.Size = 4 Then
						WrapperCollection.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					Else
						WrapperCollection.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					End If
					WrapperCollection.VirtualProtect(intPtr, 4, int_, int_)
				Next
				Try
					While binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L
						Dim num17 As Integer = binaryReader.ReadInt32()
						Dim intptr_2 As IntPtr = New IntPtr(WrapperCollection.structCollection + CLng(num17))
						Dim num18 As Integer = binaryReader.ReadInt32()
						WrapperCollection.VirtualProtect(intptr_2, num18 * 4, 4, int_)
						For n As Integer = 0 To num18 - 1
							Marshal.WriteInt32(New IntPtr(intptr_2.ToInt64() + CLng((n * 4))), binaryReader.ReadInt32())
						Next
						WrapperCollection.VirtualProtect(intptr_2, num18 * 4, int_, int_)
					End While
					WrapperCollection.CloseHandle(intptr_)
				Catch
				End Try
			End If
		End Sub

	
		Friend Shared Function DeleteCollection(assembly_0 As Assembly) As Object
			Try
				If File.Exists(CType(assembly_0, Assembly).Location) Then
					Return CType(assembly_0, Assembly).Location
				End If
			Catch
			End Try
			Try
				If File.Exists(CType(assembly_0, Assembly).GetName().CodeBase.ToString().Replace("file:///", "")) Then
					Return CType(assembly_0, Assembly).GetName().CodeBase.ToString().Replace("file:///", "")
				End If
			Catch
			End Try
			Try
				If File.Exists(assembly_0.[GetType]().GetProperty("Location").GetValue(assembly_0, New Object(-1) {}).ToString()) Then
					Return assembly_0.[GetType]().GetProperty("Location").GetValue(assembly_0, New Object(-1) {}).ToString()
				End If
			Catch
			End Try
			Return ""
		End Function

	
		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, <[In]()> <Out()> byte_0 As Byte(), uint_0 As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef intptr_2 As IntPtr) As Integer

	
		Private Declare Function ReadProcessMemory Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, <[In]()> <Out()> byte_0 As Byte(), uint_0 As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef intptr_2 As IntPtr) As Integer

	
		Private Declare Function OpenProcess Lib "kernel32.dll" (uint_0 As UInteger, int_0 As Integer, uint_1 As UInteger) As IntPtr

	
		Private Declare Function CloseHandle Lib "kernel32.dll" (intptr_0 As IntPtr) As Integer

	
		Private Shared Function ComputeCollection(string_0 As String) As Byte()
			Dim array As Byte()
			Using fileStream As FileStream = New FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read)
				Dim num As Integer = 0
				Dim length As Long = fileStream.Length
				Dim i As Integer = CInt(length)
				array = New Byte(i - 1) {}
				While i > 0
					Dim num2 As Integer = fileStream.Read(array, num, i)
					num += num2
					i -= num2
				End While
			End Using
			Return array
		End Function

	
		Private Shared Function DefineCollection(byte_0 As Byte()) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = WrapperCollection.InterruptCollection()
			symmetricAlgorithm.Key = New Byte() { 224, 119, 33, 90, 177, 67, 8, 78, 207, 171, 173, 158, 247, 19, 184, 140, 181, 245, 56, 142, 187, 93, 131, 1, 91, 149, 174, 112, 91, 125, 189, 31 }
			symmetricAlgorithm.IV = New Byte() { 158, 246, 191, 47, 71, 224, 116, 46, 106, 24, 166, 33, 138, 100, 54, 252 }
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), 1)
			cryptoStream.Write(byte_0, 0, byte_0.Length)
			cryptoStream.Close()
			Return memoryStream.ToArray()
		End Function

	
		Private Function PushCollection() As Byte()
			Return Nothing
		End Function

	
		Private Function CreateCollection() As Byte()
			Return Nothing
		End Function

	
		Private Function WriteCollection() As Byte()
			Return Nothing
		End Function

	
		Private Function ResolveCollection() As Byte()
			Return Nothing
		End Function

	
		Private Function StartCollection() As Byte()
			Return Nothing
		End Function

	
		Private Function GetCollection() As Byte()
			Return Nothing
		End Function

	
		Friend Function LogoutCollection() As Byte()
			Dim text As String = "{11111-22222-40001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function CustomizeCollection() As Byte()
			Dim text As String = "{11111-22222-40001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function RestartCollection() As Byte()
			Dim text As String = "{11111-22222-50001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function PublishCollection() As Byte()
			Dim text As String = "{11111-22222-50001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function FillCollection() As Byte()
			Dim text As String = "{11111-22222-60001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function FlushCollection() As Byte()
			Dim text As String = "{11111-22222-60001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Shared Function SearchCollection(string_0 As String, string_1 As String) As String
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(string_0)
			Dim array As Byte() = bytes
			Dim key As Byte() = New Byte() { 82, 102, 104, 110, 32, 77, 24, 34, 118, 181, 51, 17, 18, 51, 12, 109, 10, 32, 77, 24, 34, 158, 161, 41, 97, 28, 118, 181, 5, 25, 1, 88 }
			Dim iv As Byte() = WrapperCollection.PrintCollection(Encoding.Unicode.GetBytes(string_1))
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = WrapperCollection.InterruptCollection()
			symmetricAlgorithm.Key = key
			symmetricAlgorithm.IV = iv
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), 1)
			cryptoStream.Write(array, 0, array.Length)
			cryptoStream.Close()
			Return Convert.ToBase64String(memoryStream.ToArray())
		End Function

	
		Private Shared listCollection As UInteger() = New UInteger() { 3614090360UI, 3905402710UI, 606105819UI, 3250441966UI, 4118548399UI, 1200080426UI, 2821735955UI, 4249261313UI, 1770035416UI, 2336552879UI, 4294925233UI, 2304563134UI, 1804603682UI, 4254626195UI, 2792965006UI, 1236535329UI, 4129170786UI, 3225465664UI, 643717713UI, 3921069994UI, 3593408605UI, 38016083UI, 3634488961UI, 3889429448UI, 568446438UI, 3275163606UI, 4107603335UI, 1163531501UI, 2850285829UI, 4243563512UI, 1735328473UI, 2368359562UI, 4294588738UI, 2272392833UI, 1839030562UI, 4259657740UI, 2763975236UI, 1272893353UI, 4139469664UI, 3200236656UI, 681279174UI, 3936430074UI, 3572445317UI, 76029189UI, 3654602809UI, 3873151461UI, 530742520UI, 3299628645UI, 4096336452UI, 1126891415UI, 2878612391UI, 4237533241UI, 1700485571UI, 2399980690UI, 4293915773UI, 2240044497UI, 1873313359UI, 4264355552UI, 2734768916UI, 1309151649UI, 4149444226UI, 3174756917UI, 718787259UI, 3951481745UI }

	
		Private Shared m_WriterCollection As IntPtr

	
		Private Shared _HelperCollection As Integer()

	
		Private Shared structCollection As Long

	
		Private Shared _ClassCollection As String()

	
		Private Shared eventCollection As Boolean

	
		Private Shared reponseCollection As Byte()

	
		Private Shared policyCollection As Byte()

	
		Private Shared initializerCollection As Integer

	
		Private Shared _GlobalCollection As Integer

	
		Private Shared m_ServiceCollection As Byte()

	
		Private Shared readerCollection As Byte()

	
		Private Shared _RoleCollection As IntPtr

	
		Private Shared processCollection As Boolean

	
		Private Shared m_DicCollection As Boolean = False

	
		Friend Class PublisherCollection
			Inherits Attribute

		
			<WrapperCollection.PublisherCollection(GetType(WrapperCollection.PublisherCollection.PredicateCollection(Of Object)()))>
			Public Sub New(object_0 As Object)
			End Sub

		
			Friend Class PredicateCollection(Of T)
			End Class
		End Class

	
		<Flags()>
		Private Enum AccountCollection
		End Enum
	End Class
End Namespace
