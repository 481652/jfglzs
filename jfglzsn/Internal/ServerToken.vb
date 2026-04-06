Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Namespace WindowsApplication1.Internal

	Friend Class ServerToken
	
		Shared Sub New()
			ServerToken.mapToken = False
			ServerToken.repositoryToken = New Byte(-1) {}
			ServerToken.m_AccountToken = New Byte(-1) {}
			ServerToken.classToken = New Byte(-1) {}
			ServerToken._ProductToken = New Byte(-1) {}
			ServerToken._DicToken = IntPtr.Zero
			ServerToken._RegistryToken = IntPtr.Zero
			ServerToken.predicateToken = New String(-1) {}
			ServerToken.m_AnnotationToken = New Integer(-1) {}
			ServerToken.orderToken = 1
			ServerToken._RefToken = 0L
			ServerToken._PoolToken = 0
			ServerToken.m_IndexerToken = False
		End Sub

	
		Private Sub method_0()
		End Sub

	
		Friend Shared Function StopStatus(object_0 As Object) As Byte()
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
				ServerToken.InitStatus(num7, num8, num9, num10, 0UI, 7US, 1UI, array)
				ServerToken.InitStatus(num10, num7, num8, num9, 1UI, 12US, 2UI, array)
				ServerToken.InitStatus(num9, num10, num7, num8, 2UI, 17US, 3UI, array)
				ServerToken.InitStatus(num8, num9, num10, num7, 3UI, 22US, 4UI, array)
				ServerToken.InitStatus(num7, num8, num9, num10, 4UI, 7US, 5UI, array)
				ServerToken.InitStatus(num10, num7, num8, num9, 5UI, 12US, 6UI, array)
				ServerToken.InitStatus(num9, num10, num7, num8, 6UI, 17US, 7UI, array)
				ServerToken.InitStatus(num8, num9, num10, num7, 7UI, 22US, 8UI, array)
				ServerToken.InitStatus(num7, num8, num9, num10, 8UI, 7US, 9UI, array)
				ServerToken.InitStatus(num10, num7, num8, num9, 9UI, 12US, 10UI, array)
				ServerToken.InitStatus(num9, num10, num7, num8, 10UI, 17US, 11UI, array)
				ServerToken.InitStatus(num8, num9, num10, num7, 11UI, 22US, 12UI, array)
				ServerToken.InitStatus(num7, num8, num9, num10, 12UI, 7US, 13UI, array)
				ServerToken.InitStatus(num10, num7, num8, num9, 13UI, 12US, 14UI, array)
				ServerToken.InitStatus(num9, num10, num7, num8, 14UI, 17US, 15UI, array)
				ServerToken.InitStatus(num8, num9, num10, num7, 15UI, 22US, 16UI, array)
				ServerToken.ConnectStatus(num7, num8, num9, num10, 1UI, 5US, 17UI, array)
				ServerToken.ConnectStatus(num10, num7, num8, num9, 6UI, 9US, 18UI, array)
				ServerToken.ConnectStatus(num9, num10, num7, num8, 11UI, 14US, 19UI, array)
				ServerToken.ConnectStatus(num8, num9, num10, num7, 0UI, 20US, 20UI, array)
				ServerToken.ConnectStatus(num7, num8, num9, num10, 5UI, 5US, 21UI, array)
				ServerToken.ConnectStatus(num10, num7, num8, num9, 10UI, 9US, 22UI, array)
				ServerToken.ConnectStatus(num9, num10, num7, num8, 15UI, 14US, 23UI, array)
				ServerToken.ConnectStatus(num8, num9, num10, num7, 4UI, 20US, 24UI, array)
				ServerToken.ConnectStatus(num7, num8, num9, num10, 9UI, 5US, 25UI, array)
				ServerToken.ConnectStatus(num10, num7, num8, num9, 14UI, 9US, 26UI, array)
				ServerToken.ConnectStatus(num9, num10, num7, num8, 3UI, 14US, 27UI, array)
				ServerToken.ConnectStatus(num8, num9, num10, num7, 8UI, 20US, 28UI, array)
				ServerToken.ConnectStatus(num7, num8, num9, num10, 13UI, 5US, 29UI, array)
				ServerToken.ConnectStatus(num10, num7, num8, num9, 2UI, 9US, 30UI, array)
				ServerToken.ConnectStatus(num9, num10, num7, num8, 7UI, 14US, 31UI, array)
				ServerToken.ConnectStatus(num8, num9, num10, num7, 12UI, 20US, 32UI, array)
				ServerToken.RemoveStatus(num7, num8, num9, num10, 5UI, 4US, 33UI, array)
				ServerToken.RemoveStatus(num10, num7, num8, num9, 8UI, 11US, 34UI, array)
				ServerToken.RemoveStatus(num9, num10, num7, num8, 11UI, 16US, 35UI, array)
				ServerToken.RemoveStatus(num8, num9, num10, num7, 14UI, 23US, 36UI, array)
				ServerToken.RemoveStatus(num7, num8, num9, num10, 1UI, 4US, 37UI, array)
				ServerToken.RemoveStatus(num10, num7, num8, num9, 4UI, 11US, 38UI, array)
				ServerToken.RemoveStatus(num9, num10, num7, num8, 7UI, 16US, 39UI, array)
				ServerToken.RemoveStatus(num8, num9, num10, num7, 10UI, 23US, 40UI, array)
				ServerToken.RemoveStatus(num7, num8, num9, num10, 13UI, 4US, 41UI, array)
				ServerToken.RemoveStatus(num10, num7, num8, num9, 0UI, 11US, 42UI, array)
				ServerToken.RemoveStatus(num9, num10, num7, num8, 3UI, 16US, 43UI, array)
				ServerToken.RemoveStatus(num8, num9, num10, num7, 6UI, 23US, 44UI, array)
				ServerToken.RemoveStatus(num7, num8, num9, num10, 9UI, 4US, 45UI, array)
				ServerToken.RemoveStatus(num10, num7, num8, num9, 12UI, 11US, 46UI, array)
				ServerToken.RemoveStatus(num9, num10, num7, num8, 15UI, 16US, 47UI, array)
				ServerToken.RemoveStatus(num8, num9, num10, num7, 2UI, 23US, 48UI, array)
				ServerToken.CompareStatus(num7, num8, num9, num10, 0UI, 6US, 49UI, array)
				ServerToken.CompareStatus(num10, num7, num8, num9, 7UI, 10US, 50UI, array)
				ServerToken.CompareStatus(num9, num10, num7, num8, 14UI, 15US, 51UI, array)
				ServerToken.CompareStatus(num8, num9, num10, num7, 5UI, 21US, 52UI, array)
				ServerToken.CompareStatus(num7, num8, num9, num10, 12UI, 6US, 53UI, array)
				ServerToken.CompareStatus(num10, num7, num8, num9, 3UI, 10US, 54UI, array)
				ServerToken.CompareStatus(num9, num10, num7, num8, 10UI, 15US, 55UI, array)
				ServerToken.CompareStatus(num8, num9, num10, num7, 1UI, 21US, 56UI, array)
				ServerToken.CompareStatus(num7, num8, num9, num10, 8UI, 6US, 57UI, array)
				ServerToken.CompareStatus(num10, num7, num8, num9, 15UI, 10US, 58UI, array)
				ServerToken.CompareStatus(num9, num10, num7, num8, 6UI, 15US, 59UI, array)
				ServerToken.CompareStatus(num8, num9, num10, num7, 13UI, 21US, 60UI, array)
				ServerToken.CompareStatus(num7, num8, num9, num10, 4UI, 6US, 61UI, array)
				ServerToken.CompareStatus(num10, num7, num8, num9, 11UI, 10US, 62UI, array)
				ServerToken.CompareStatus(num9, num10, num7, num8, 2UI, 15US, 63UI, array)
				ServerToken.CompareStatus(num8, num9, num10, num7, 9UI, 21US, 64UI, array)
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

	
		Private Shared Sub InitStatus(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + ServerToken.ValidateStatus(uint_0 + ((uint_1 And uint_2) Or (Not uint_1 And uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + ServerToken.getterToken(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub ConnectStatus(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + ServerToken.ValidateStatus(uint_0 + ((uint_1 And uint_3) Or (uint_2 And Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + ServerToken.getterToken(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub RemoveStatus(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + ServerToken.ValidateStatus(uint_0 + (uint_1 Xor uint_2 Xor uint_3) + object_0(CInt(CType(uint_4, UIntPtr))) + ServerToken.getterToken(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub CompareStatus(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + ServerToken.ValidateStatus(uint_0 + (uint_2 Xor (uint_1 Or Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + ServerToken.getterToken(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Function ValidateStatus(uint_0 As UInteger, ushort_0 As UShort) As UInteger
			Return uint_0 >> CInt((32US - ushort_0)) Or uint_0 << CInt(ushort_0)
		End Function

	
		Friend Shared Function SortStatus() As Boolean
			If Not ServerToken.m_PropertyToken Then
				ServerToken.ResolveStatus()
				ServerToken.m_PropertyToken = True
			End If
			Return ServerToken.mapToken
		End Function

	
		Friend Shared Sub ResolveStatus()
			Try
				ServerToken.mapToken = CBool(GetType(RijndaelManaged).Assembly.[GetType]("System.Security.Cryptography.CryptoConfig", False).GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.[Static] Or BindingFlags.[Public]).Invoke(Nothing, New Object(-1) {}))
			Catch
			End Try
		End Sub

	
		Friend Shared Function ExcludeStatus() As SymmetricAlgorithm
			Dim result As SymmetricAlgorithm = Nothing
			If ServerToken.SortStatus() Then
				Try
					Return New AesCryptoServiceProvider()
				Catch
					Return New RijndaelManaged()
				End Try
			End If
			result = New RijndaelManaged()
			Return result
		End Function

	
		Friend Shared Function CheckStatus(byte_0 As Byte()) As Byte()
			If Not ServerToken.SortStatus() Then
				Return New MD5CryptoServiceProvider().ComputeHash(byte_0)
			End If
			Return ServerToken.StopStatus(byte_0)
		End Function

	
		Shared Function InstantiateStatus(int_0 As Integer) As Boolean
			If ServerToken.m_AccountToken.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(ServerToken).Assembly.GetManifestResourceStream("22417a8b-1725-466b-a0be-8658beeef10b"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 150
				array2(0) = 63
				array2(0) = 81
				array2(0) = 152
				array2(0) = 109
				array2(0) = 159
				array2(1) = 122
				array2(1) = 154
				array2(1) = 159
				array2(1) = 101
				array2(1) = 154
				array2(1) = 82
				array2(2) = 177
				array2(2) = 141
				array2(2) = 152
				array2(2) = 216
				array2(2) = 47
				array2(3) = 199
				array2(3) = 197
				array2(3) = 45
				array2(4) = 86
				array2(4) = 73
				array2(4) = 35
				array2(5) = 111
				array2(5) = 93
				array2(5) = 67
				array2(6) = 147
				array2(6) = 77
				array2(6) = 142
				array2(6) = 135
				array2(6) = 95
				array2(7) = 86
				array2(7) = 33
				array2(7) = 36
				array2(8) = 93
				array2(8) = 166
				array2(8) = 92
				array2(8) = 148
				array2(8) = 237
				array2(9) = 154
				array2(9) = 158
				array2(9) = 134
				array2(9) = 137
				array2(9) = 201
				array2(10) = 87
				array2(10) = 156
				array2(10) = 97
				array2(11) = 150
				array2(11) = 144
				array2(11) = 137
				array2(12) = 144
				array2(12) = 91
				array2(12) = 93
				array2(12) = 123
				array2(12) = 141
				array2(12) = 97
				array2(13) = 113
				array2(13) = 102
				array2(13) = 41
				array2(13) = 86
				array2(14) = 64
				array2(14) = 156
				array2(14) = 149
				array2(14) = 22
				array2(15) = 133
				array2(15) = 167
				array2(15) = 27
				array2(15) = 178
				array2(15) = 115
				array2(15) = 44
				array2(16) = 118
				array2(16) = 106
				array2(16) = 122
				array2(16) = 114
				array2(16) = 196
				array2(16) = 36
				array2(17) = 115
				array2(17) = 131
				array2(17) = 153
				array2(17) = 124
				array2(17) = 219
				array2(17) = 234
				array2(18) = 153
				array2(18) = 162
				array2(18) = 93
				array2(18) = 127
				array2(18) = 126
				array2(18) = 156
				array2(19) = 168
				array2(19) = 88
				array2(19) = 251
				array2(20) = 121
				array2(20) = 157
				array2(20) = 221
				array2(21) = 131
				array2(21) = 128
				array2(21) = 33
				array2(22) = 197
				array2(22) = 160
				array2(22) = 174
				array2(22) = 120
				array2(22) = 74
				array2(22) = 91
				array2(23) = 178
				array2(23) = 122
				array2(23) = 192
				array2(23) = 139
				array2(23) = 13
				array2(24) = 124
				array2(24) = 212
				array2(24) = 113
				array2(25) = 104
				array2(25) = 163
				array2(25) = 201
				array2(25) = 194
				array2(25) = 101
				array2(25) = 186
				array2(26) = 124
				array2(26) = 126
				array2(26) = 164
				array2(26) = 157
				array2(26) = 180
				array2(26) = 223
				array2(27) = 154
				array2(27) = 140
				array2(27) = 188
				array2(28) = 199
				array2(28) = 120
				array2(28) = 156
				array2(28) = 118
				array2(28) = 154
				array2(28) = 240
				array2(29) = 157
				array2(29) = 142
				array2(29) = 42
				array2(30) = 130
				array2(30) = 89
				array2(30) = 130
				array2(30) = 37
				array2(30) = 88
				array2(30) = 113
				array2(31) = 12
				array2(31) = 130
				array2(31) = 237
				array2(31) = 150
				array2(31) = 148
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 134
				array4(0) = 126
				array4(0) = 91
				array4(0) = 152
				array4(0) = 98
				array4(1) = 47
				array4(1) = 118
				array4(1) = 154
				array4(1) = 215
				array4(1) = 165
				array4(1) = 231
				array4(2) = 112
				array4(2) = 147
				array4(2) = 148
				array4(2) = 10
				array4(3) = 108
				array4(3) = 213
				array4(3) = 124
				array4(3) = 110
				array4(3) = 174
				array4(3) = 247
				array4(4) = 121
				array4(4) = 86
				array4(4) = 73
				array4(4) = 155
				array4(4) = 113
				array4(5) = 142
				array4(5) = 184
				array4(5) = 153
				array4(5) = 17
				array4(6) = 178
				array4(6) = 135
				array4(6) = 111
				array4(6) = 130
				array4(7) = 99
				array4(7) = 112
				array4(7) = 105
				array4(7) = 164
				array4(7) = 76
				array4(7) = 250
				array4(8) = 182
				array4(8) = 158
				array4(8) = 114
				array4(8) = 106
				array4(8) = 204
				array4(9) = 146
				array4(9) = 120
				array4(9) = 193
				array4(9) = 111
				array4(9) = 248
				array4(10) = 97
				array4(10) = 160
				array4(10) = 81
				array4(10) = 83
				array4(10) = 17
				array4(10) = 23
				array4(11) = 147
				array4(11) = 156
				array4(11) = 119
				array4(12) = 111
				array4(12) = 105
				array4(12) = 146
				array4(12) = 116
				array4(12) = 160
				array4(12) = 158
				array4(13) = 105
				array4(13) = 97
				array4(13) = 103
				array4(13) = 90
				array4(13) = 186
				array4(14) = 79
				array4(14) = 211
				array4(14) = 4
				array4(15) = 92
				array4(15) = 158
				array4(15) = 136
				array4(15) = 122
				array4(15) = 62
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(ServerToken).Assembly.GetName().GetPublicKeyToken()
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
				Dim symmetricAlgorithm As SymmetricAlgorithm = ServerToken.ExcludeStatus()
				symmetricAlgorithm.Mode = 1
				Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.FlushFinalBlock()
				ServerToken.m_AccountToken = memoryStream.ToArray()
				memoryStream.Close()
				cryptoStream.Close()
				binaryReader.Close()
			End If
			If ServerToken.repositoryToken.Length = 0 Then
				ServerToken.repositoryToken = ServerToken.CalculateStatus(ServerToken.AssetStatus(GetType(ServerToken).Assembly).ToString())
			End If
			Dim num As Integer = 0
			Try
				num = BitConverter.ToInt32(New Byte() { ServerToken.m_AccountToken(int_0), ServerToken.m_AccountToken(int_0 + 1), ServerToken.m_AccountToken(int_0 + 2), ServerToken.m_AccountToken(int_0 + 3) }, 0)
			Catch
			End Try
			Try
				If ServerToken.repositoryToken(num) = 128 Then
					Return True
				End If
			Catch
			End Try
			Return False
		End Function

	
		Shared Function InsertStatus(int_0 As Integer) As String
			If ServerToken.classToken.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(ServerToken).Assembly.GetManifestResourceStream("a6f3c99d-eab0-45af-8f4a-79ba5e4091ed"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 134
				array2(0) = 90
				array2(0) = 182
				array2(0) = 194
				array2(1) = 96
				array2(1) = 150
				array2(1) = 163
				array2(1) = 97
				array2(1) = 7
				array2(2) = 103
				array2(2) = 164
				array2(2) = 48
				array2(3) = 106
				array2(3) = 96
				array2(3) = 201
				array2(3) = 142
				array2(3) = 164
				array2(4) = 130
				array2(4) = 173
				array2(4) = 55
				array2(5) = 130
				array2(5) = 87
				array2(5) = 125
				array2(5) = 134
				array2(5) = 153
				array2(5) = 178
				array2(6) = 208
				array2(6) = 122
				array2(6) = 168
				array2(6) = 84
				array2(6) = 241
				array2(7) = 149
				array2(7) = 131
				array2(7) = 123
				array2(7) = 196
				array2(7) = 114
				array2(7) = 191
				array2(8) = 60
				array2(8) = 159
				array2(8) = 43
				array2(8) = 84
				array2(8) = 105
				array2(9) = 174
				array2(9) = 127
				array2(9) = 205
				array2(9) = 96
				array2(9) = 166
				array2(10) = 172
				array2(10) = 168
				array2(10) = 188
				array2(10) = 128
				array2(10) = 200
				array2(11) = 97
				array2(11) = 161
				array2(11) = 98
				array2(11) = 75
				array2(12) = 146
				array2(12) = 157
				array2(12) = 108
				array2(12) = 94
				array2(13) = 95
				array2(13) = 141
				array2(13) = 212
				array2(14) = 112
				array2(14) = 126
				array2(14) = 91
				array2(14) = 98
				array2(14) = 147
				array2(14) = 225
				array2(15) = 114
				array2(15) = 160
				array2(15) = 111
				array2(15) = 52
				array2(15) = 157
				array2(15) = 178
				array2(16) = 118
				array2(16) = 30
				array2(16) = 239
				array2(17) = 165
				array2(17) = 135
				array2(17) = 160
				array2(17) = 173
				array2(17) = 44
				array2(17) = 144
				array2(18) = 207
				array2(18) = 96
				array2(18) = 146
				array2(18) = 113
				array2(19) = 198
				array2(19) = 152
				array2(19) = 93
				array2(19) = 218
				array2(19) = 154
				array2(19) = 225
				array2(20) = 98
				array2(20) = 15
				array2(20) = 170
				array2(20) = 119
				array2(20) = 46
				array2(21) = 111
				array2(21) = 61
				array2(21) = 87
				array2(21) = 152
				array2(21) = 154
				array2(21) = 227
				array2(22) = 200
				array2(22) = 109
				array2(22) = 238
				array2(22) = 160
				array2(22) = 111
				array2(22) = 46
				array2(23) = 124
				array2(23) = 141
				array2(23) = 49
				array2(23) = 155
				array2(24) = 130
				array2(24) = 35
				array2(24) = 221
				array2(24) = 98
				array2(24) = 67
				array2(25) = 160
				array2(25) = 120
				array2(25) = 156
				array2(25) = 156
				array2(26) = 85
				array2(26) = 110
				array2(26) = 183
				array2(26) = 122
				array2(26) = 86
				array2(27) = 109
				array2(27) = 33
				array2(27) = 107
				array2(27) = 110
				array2(27) = 106
				array2(28) = 72
				array2(28) = 171
				array2(28) = 147
				array2(28) = 142
				array2(28) = 159
				array2(28) = 251
				array2(29) = 132
				array2(29) = 102
				array2(29) = 153
				array2(29) = 140
				array2(29) = 41
				array2(30) = 128
				array2(30) = 86
				array2(30) = 153
				array2(30) = 105
				array2(30) = 145
				array2(30) = 166
				array2(31) = 86
				array2(31) = 162
				array2(31) = 149
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 86
				array4(0) = 137
				array4(0) = 89
				array4(0) = 132
				array4(0) = 162
				array4(0) = 94
				array4(1) = 115
				array4(1) = 56
				array4(1) = 41
				array4(1) = 136
				array4(1) = 119
				array4(1) = 131
				array4(2) = 96
				array4(2) = 168
				array4(2) = 132
				array4(2) = 196
				array4(3) = 134
				array4(3) = 120
				array4(3) = 241
				array4(4) = 122
				array4(4) = 118
				array4(4) = 140
				array4(4) = 99
				array4(4) = 22
				array4(5) = 122
				array4(5) = 166
				array4(5) = 162
				array4(5) = 91
				array4(6) = 122
				array4(6) = 238
				array4(6) = 78
				array4(6) = 139
				array4(6) = 222
				array4(7) = 166
				array4(7) = 174
				array4(7) = 138
				array4(7) = 83
				array4(7) = 45
				array4(8) = 163
				array4(8) = 93
				array4(8) = 59
				array4(8) = 247
				array4(9) = 151
				array4(9) = 150
				array4(9) = 127
				array4(9) = 142
				array4(9) = 96
				array4(10) = 155
				array4(10) = 172
				array4(10) = 168
				array4(10) = 159
				array4(11) = 141
				array4(11) = 141
				array4(11) = 24
				array4(12) = 90
				array4(12) = 133
				array4(12) = 164
				array4(12) = 138
				array4(13) = 146
				array4(13) = 135
				array4(13) = 94
				array4(13) = 168
				array4(13) = 85
				array4(13) = 42
				array4(14) = 92
				array4(14) = 117
				array4(14) = 58
				array4(15) = 140
				array4(15) = 139
				array4(15) = 168
				array4(15) = 131
				array4(15) = 171
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(ServerToken).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = ServerToken.ExcludeStatus()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					ServerToken.classToken = memoryStream.ToArray()
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = ServerToken.classToken
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
				ServerToken.classToken = array6
			End If
			Dim num17 As Integer = BitConverter.ToInt32(ServerToken.classToken, int_0)
			Try
				Dim array7 As Byte() = New Byte(num17 - 1) {}
				Array.Copy(ServerToken.classToken, int_0 + 4, array7, 0, num17)
				Return Encoding.Unicode.GetString(array7, 0, array7.Length)
			Catch
			End Try
			Return ""
		End Function

	
		Shared Function DefineStatus(int_0 As Integer) As String
			If ServerToken._ProductToken.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(ServerToken).Assembly.GetManifestResourceStream("a6f3c99d-eab0-45af-8f4a-79ba5e4091ed"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 134
				array2(0) = 90
				array2(0) = 182
				array2(0) = 194
				array2(1) = 96
				array2(1) = 150
				array2(1) = 163
				array2(1) = 97
				array2(1) = 7
				array2(2) = 103
				array2(2) = 164
				array2(2) = 48
				array2(3) = 106
				array2(3) = 96
				array2(3) = 201
				array2(3) = 142
				array2(3) = 164
				array2(4) = 130
				array2(4) = 173
				array2(4) = 55
				array2(5) = 130
				array2(5) = 87
				array2(5) = 125
				array2(5) = 134
				array2(5) = 153
				array2(5) = 178
				array2(6) = 208
				array2(6) = 122
				array2(6) = 168
				array2(6) = 84
				array2(6) = 241
				array2(7) = 149
				array2(7) = 131
				array2(7) = 123
				array2(7) = 196
				array2(7) = 114
				array2(7) = 191
				array2(8) = 60
				array2(8) = 159
				array2(8) = 43
				array2(8) = 84
				array2(8) = 105
				array2(9) = 174
				array2(9) = 127
				array2(9) = 205
				array2(9) = 96
				array2(9) = 166
				array2(10) = 172
				array2(10) = 168
				array2(10) = 188
				array2(10) = 128
				array2(10) = 200
				array2(11) = 97
				array2(11) = 161
				array2(11) = 98
				array2(11) = 75
				array2(12) = 146
				array2(12) = 157
				array2(12) = 108
				array2(12) = 94
				array2(13) = 95
				array2(13) = 141
				array2(13) = 212
				array2(14) = 112
				array2(14) = 126
				array2(14) = 91
				array2(14) = 98
				array2(14) = 147
				array2(14) = 225
				array2(15) = 114
				array2(15) = 160
				array2(15) = 111
				array2(15) = 52
				array2(15) = 157
				array2(15) = 178
				array2(16) = 118
				array2(16) = 30
				array2(16) = 239
				array2(17) = 165
				array2(17) = 135
				array2(17) = 160
				array2(17) = 173
				array2(17) = 44
				array2(17) = 144
				array2(18) = 207
				array2(18) = 96
				array2(18) = 146
				array2(18) = 113
				array2(19) = 198
				array2(19) = 152
				array2(19) = 93
				array2(19) = 218
				array2(19) = 154
				array2(19) = 225
				array2(20) = 98
				array2(20) = 15
				array2(20) = 170
				array2(20) = 119
				array2(20) = 46
				array2(21) = 111
				array2(21) = 61
				array2(21) = 87
				array2(21) = 152
				array2(21) = 154
				array2(21) = 227
				array2(22) = 200
				array2(22) = 109
				array2(22) = 238
				array2(22) = 160
				array2(22) = 111
				array2(22) = 46
				array2(23) = 124
				array2(23) = 141
				array2(23) = 49
				array2(23) = 155
				array2(24) = 130
				array2(24) = 35
				array2(24) = 221
				array2(24) = 98
				array2(24) = 67
				array2(25) = 160
				array2(25) = 120
				array2(25) = 156
				array2(25) = 156
				array2(26) = 85
				array2(26) = 110
				array2(26) = 183
				array2(26) = 122
				array2(26) = 86
				array2(27) = 109
				array2(27) = 33
				array2(27) = 107
				array2(27) = 110
				array2(27) = 106
				array2(28) = 72
				array2(28) = 171
				array2(28) = 147
				array2(28) = 142
				array2(28) = 159
				array2(28) = 251
				array2(29) = 132
				array2(29) = 102
				array2(29) = 153
				array2(29) = 140
				array2(29) = 41
				array2(30) = 128
				array2(30) = 86
				array2(30) = 153
				array2(30) = 105
				array2(30) = 145
				array2(30) = 166
				array2(31) = 86
				array2(31) = 162
				array2(31) = 149
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 86
				array4(0) = 137
				array4(0) = 89
				array4(0) = 132
				array4(0) = 162
				array4(0) = 94
				array4(1) = 115
				array4(1) = 56
				array4(1) = 41
				array4(1) = 136
				array4(1) = 119
				array4(1) = 131
				array4(2) = 96
				array4(2) = 168
				array4(2) = 132
				array4(2) = 196
				array4(3) = 134
				array4(3) = 120
				array4(3) = 241
				array4(4) = 122
				array4(4) = 118
				array4(4) = 140
				array4(4) = 99
				array4(4) = 22
				array4(5) = 122
				array4(5) = 166
				array4(5) = 162
				array4(5) = 91
				array4(6) = 122
				array4(6) = 238
				array4(6) = 78
				array4(6) = 139
				array4(6) = 222
				array4(7) = 166
				array4(7) = 174
				array4(7) = 138
				array4(7) = 83
				array4(7) = 45
				array4(8) = 163
				array4(8) = 93
				array4(8) = 59
				array4(8) = 247
				array4(9) = 151
				array4(9) = 150
				array4(9) = 127
				array4(9) = 142
				array4(9) = 96
				array4(10) = 155
				array4(10) = 172
				array4(10) = 168
				array4(10) = 159
				array4(11) = 141
				array4(11) = 141
				array4(11) = 24
				array4(12) = 90
				array4(12) = 133
				array4(12) = 164
				array4(12) = 138
				array4(13) = 146
				array4(13) = 135
				array4(13) = 94
				array4(13) = 168
				array4(13) = 85
				array4(13) = 42
				array4(14) = 92
				array4(14) = 117
				array4(14) = 58
				array4(15) = 140
				array4(15) = 139
				array4(15) = 168
				array4(15) = 131
				array4(15) = 171
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(ServerToken).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = ServerToken.ExcludeStatus()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					ServerToken._ProductToken = memoryStream.ToArray()
					If ServerToken._ProductToken.Length > 0 Then
						ServerToken.predicateToken = New String(ServerToken._ProductToken.Length / 4 + 1 - 1) {}
						ServerToken.m_AnnotationToken = New Integer(ServerToken._ProductToken.Length / 4 + 1 - 1) {}
					End If
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = ServerToken._ProductToken
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
				ServerToken._ProductToken = array6
				If ServerToken._ProductToken.Length > 0 Then
					ServerToken.predicateToken = New String(ServerToken._ProductToken.Length / 4 + 1 - 1) {}
					ServerToken.m_AnnotationToken = New Integer(ServerToken._ProductToken.Length / 4 + 1 - 1) {}
				End If
				Dim assembly As Assembly = GetType(ServerToken).Assembly
				If IntPtr.Size = 4 Then
					ServerToken._PoolToken = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt32()
				End If
				ServerToken._RefToken = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
			End If
			Dim num16 As Integer = int_0 / 4
			If ServerToken.m_AnnotationToken(num16) > 0 Then
				Return CType(ServerToken.predicateToken, String())(ServerToken.m_AnnotationToken(num16))
			End If
			Dim num17 As Integer = BitConverter.ToInt32(ServerToken._ProductToken, int_0)
			If ServerToken._DicToken = IntPtr.Zero Then
				ServerToken._DicToken = ServerToken.OpenProcess(16UI, 1, CUInt(Process.GetCurrentProcess().Id))
			End If
			Dim array7 As Byte() = New Byte(3) {}
			If IntPtr.Size = 4 Then
				ServerToken.ReadProcessMemory(ServerToken._DicToken, New IntPtr(ServerToken._PoolToken + num17), array7, 4UI, ServerToken._RegistryToken)
			Else
				ServerToken.ReadProcessMemory(ServerToken._DicToken, New IntPtr(ServerToken._RefToken + CLng(num17)), array7, 4UI, ServerToken._RegistryToken)
			End If
			Dim num18 As Integer = BitConverter.ToInt32(array7, 0)
			array7 = New Byte(num18 - 1) {}
			If IntPtr.Size = 4 Then
				ServerToken.ReadProcessMemory(ServerToken._DicToken, New IntPtr(ServerToken._PoolToken + num17 + 4), array7, Convert.ToUInt32(num18), ServerToken._RegistryToken)
			Else
				ServerToken.ReadProcessMemory(ServerToken._DicToken, New IntPtr(ServerToken._RefToken + CLng(num17) + 4L), array7, Convert.ToUInt32(num18), ServerToken._RegistryToken)
			End If
			Dim array8 As Byte() = ServerToken.QueryStatus(array7)
			Dim [string] As String = Encoding.Unicode.GetString(array8, 0, array8.Length)
			ServerToken.m_AnnotationToken(num16) = ServerToken.orderToken
			CType(ServerToken.predicateToken, String())(ServerToken.orderToken) = [string]
			ServerToken.orderToken += 1
			Return [string]
		End Function

	
		Friend Shared Function NewStatus(string_0 As String) As String
			Dim array As Byte() = Convert.FromBase64String(string_0)
			Return Encoding.Unicode.GetString(array, 0, array.Length)
		End Function

	
		Private Declare Function VirtualProtect Lib "kernel32.dll" (intptr_0 As IntPtr, int_0 As Integer, int_1 As Integer, ByRef int_2 As Integer) As Integer

	
		<ServerToken.CollectionToken(GetType(ServerToken.CollectionToken.BridgeToken(Of Object)()))>
		Shared Sub CreateStatus()
			If Not ServerToken.m_IndexerToken Then
				ServerToken.m_IndexerToken = True
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(ServerToken).Assembly.GetManifestResourceStream("ceeede88-cbaf-4dd5-9d97-b15b42a73a16"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 78
				array2(0) = 162
				array2(0) = 87
				array2(0) = 141
				array2(0) = 78
				array2(1) = 42
				array2(1) = 71
				array2(1) = 144
				array2(1) = 116
				array2(1) = 42
				array2(2) = 132
				array2(2) = 145
				array2(2) = 110
				array2(2) = 132
				array2(3) = 134
				array2(3) = 142
				array2(3) = 160
				array2(3) = 76
				array2(3) = 134
				array2(4) = 64
				array2(4) = 88
				array2(4) = 96
				array2(4) = 144
				array2(4) = 64
				array2(5) = 182
				array2(5) = 96
				array2(5) = 90
				array2(5) = 103
				array2(5) = 48
				array2(5) = 182
				array2(6) = 82
				array2(6) = 90
				array2(6) = 143
				array2(6) = 122
				array2(6) = 92
				array2(6) = 117
				array2(6) = 82
				array2(7) = 17
				array2(7) = 105
				array2(7) = 123
				array2(7) = 148
				array2(7) = 233
				array2(7) = 165
				array2(7) = 17
				array2(8) = 207
				array2(8) = 48
				array2(8) = 95
				array2(8) = 95
				array2(8) = 207
				array2(9) = 139
				array2(9) = 86
				array2(9) = 116
				array2(9) = 119
				array2(9) = 139
				array2(10) = 142
				array2(10) = 158
				array2(10) = 175
				array2(10) = 142
				array2(11) = 241
				array2(11) = 109
				array2(11) = 77
				array2(11) = 103
				array2(11) = 114
				array2(11) = 75
				array2(11) = 241
				array2(12) = 103
				array2(12) = 162
				array2(12) = 117
				array2(12) = 103
				array2(13) = 150
				array2(13) = 212
				array2(13) = 210
				array2(13) = 150
				array2(14) = 243
				array2(14) = 86
				array2(14) = 155
				array2(14) = 128
				array2(14) = 115
				array2(14) = 243
				array2(15) = 206
				array2(15) = 88
				array2(15) = 141
				array2(15) = 124
				array2(15) = 206
				array2(16) = 48
				array2(16) = 136
				array2(16) = 141
				array2(16) = 166
				array2(16) = 48
				array2(17) = 161
				array2(17) = 122
				array2(17) = 158
				array2(17) = 151
				array2(17) = 161
				array2(18) = 166
				array2(18) = 100
				array2(18) = 138
				array2(18) = 73
				array2(18) = 166
				array2(19) = 209
				array2(19) = 121
				array2(19) = 101
				array2(19) = 151
				array2(19) = 28
				array2(19) = 176
				array2(19) = 209
				array2(20) = 86
				array2(20) = 108
				array2(20) = 83
				array2(20) = 106
				array2(20) = 105
				array2(20) = 101
				array2(20) = 86
				array2(21) = 18
				array2(21) = 115
				array2(21) = 62
				array2(21) = 145
				array2(21) = 94
				array2(21) = 18
				array2(22) = 159
				array2(22) = 154
				array2(22) = 69
				array2(22) = 108
				array2(22) = 159
				array2(23) = 54
				array2(23) = 163
				array2(23) = 84
				array2(23) = 54
				array2(24) = 97
				array2(24) = 145
				array2(24) = 98
				array2(24) = 36
				array2(24) = 124
				array2(24) = 137
				array2(24) = 97
				array2(25) = 161
				array2(25) = 177
				array2(25) = 49
				array2(25) = 142
				array2(25) = 104
				array2(25) = 146
				array2(25) = 161
				array2(26) = 101
				array2(26) = 185
				array2(26) = 106
				array2(26) = 147
				array2(26) = 101
				array2(27) = 222
				array2(27) = 153
				array2(27) = 88
				array2(27) = 222
				array2(28) = 122
				array2(28) = 73
				array2(28) = 152
				array2(28) = 107
				array2(28) = 218
				array2(28) = 122
				array2(29) = 29
				array2(29) = 142
				array2(29) = 122
				array2(29) = 142
				array2(29) = 111
				array2(29) = 29
				array2(30) = 135
				array2(30) = 116
				array2(30) = 100
				array2(30) = 167
				array2(30) = 130
				array2(30) = 135
				array2(31) = 82
				array2(31) = 192
				array2(31) = 53
				array2(31) = 34
				array2(31) = 160
				array2(31) = 82
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 162
				array4(0) = 87
				array4(0) = 171
				array4(1) = 129
				array4(1) = 71
				array4(1) = 144
				array4(1) = 90
				array4(1) = 116
				array4(2) = 145
				array4(2) = 149
				array4(2) = 93
				array4(2) = 30
				array4(2) = 156
				array4(2) = 187
				array4(3) = 107
				array4(3) = 88
				array4(3) = 49
				array4(3) = 125
				array4(3) = 86
				array4(3) = 248
				array4(4) = 27
				array4(4) = 144
				array4(4) = 48
				array4(4) = 120
				array4(5) = 145
				array4(5) = 133
				array4(5) = 144
				array4(6) = 122
				array4(6) = 92
				array4(6) = 250
				array4(7) = 110
				array4(7) = 92
				array4(7) = 156
				array4(7) = 254
				array4(8) = 202
				array4(8) = 230
				array4(8) = 92
				array4(8) = 48
				array4(8) = 155
				array4(9) = 135
				array4(9) = 134
				array4(9) = 86
				array4(9) = 116
				array4(9) = 144
				array4(10) = 120
				array4(10) = 155
				array4(10) = 135
				array4(10) = 96
				array4(10) = 94
				array4(10) = 140
				array4(11) = 155
				array4(11) = 137
				array4(11) = 126
				array4(11) = 162
				array4(11) = 219
				array4(12) = 147
				array4(12) = 154
				array4(12) = 229
				array4(13) = 166
				array4(13) = 95
				array4(13) = 96
				array4(14) = 155
				array4(14) = 128
				array4(14) = 114
				array4(15) = 90
				array4(15) = 119
				array4(15) = 224
				Dim array5 As Byte() = array4
				Array.Reverse(array5)
				Dim publicKeyToken As Byte() = GetType(ServerToken).Assembly.GetName().GetPublicKeyToken()
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
				Dim assembly As Assembly = GetType(ServerToken).Assembly
				intptr_ = ServerToken.OpenProcess(56UI, 1, CUInt(Process.GetCurrentProcess().Id))
				ServerToken._RefToken = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
				Dim zero As IntPtr = IntPtr.Zero
				Dim int_ As Integer = 0
				Dim num16 As Integer = binaryReader.ReadInt32()
				binaryReader.ReadInt32()
				For m As Integer = 0 To num16 - 1
					Dim intPtr As IntPtr = New IntPtr(ServerToken._RefToken + CLng(binaryReader.ReadInt32()))
					ServerToken.VirtualProtect(intPtr, 4, 4, int_)
					If IntPtr.Size = 4 Then
						ServerToken.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					Else
						ServerToken.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					End If
					ServerToken.VirtualProtect(intPtr, 4, int_, int_)
				Next
				Try
					While binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L
						Dim num17 As Integer = binaryReader.ReadInt32()
						Dim intptr_2 As IntPtr = New IntPtr(ServerToken._RefToken + CLng(num17))
						Dim num18 As Integer = binaryReader.ReadInt32()
						ServerToken.VirtualProtect(intptr_2, num18 * 4, 4, int_)
						For n As Integer = 0 To num18 - 1
							Marshal.WriteInt32(New IntPtr(intptr_2.ToInt64() + CLng((n * 4))), binaryReader.ReadInt32())
						Next
						ServerToken.VirtualProtect(intptr_2, num18 * 4, int_, int_)
					End While
					ServerToken.CloseHandle(intptr_)
				Catch
				End Try
			End If
		End Sub

	
		Friend Shared Function AssetStatus(assembly_0 As Assembly) As Object
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

	
		Private Shared Function CalculateStatus(string_0 As String) As Byte()
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

	
		Private Shared Function QueryStatus(byte_0 As Byte()) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = ServerToken.ExcludeStatus()
			symmetricAlgorithm.Key = New Byte() { 4, 226, 8, 235, 22, 104, 51, 202, 40, 226, 2, 138, 123, 56, 23, 239, 173, 225, 100, 210, 179, 17, 231, 88, 157, 61, 176, 155, 83, 70, 232, 123 }
			symmetricAlgorithm.IV = New Byte() { 94, 187, 41, 231, 206, 82, 81, 5, 219, 159, 119, 171, 143, 164, 37, 4 }
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), 1)
			cryptoStream.Write(byte_0, 0, byte_0.Length)
			cryptoStream.Close()
			Return memoryStream.ToArray()
		End Function

	
		Private Function EnableStatus() As Byte()
			Return Nothing
		End Function

	
		Private Function ReflectStatus() As Byte()
			Return Nothing
		End Function

	
		Private Function RunStatus() As Byte()
			Return Nothing
		End Function

	
		Private Function ChangeStatus() As Byte()
			Return Nothing
		End Function

	
		Private Function GetStatus() As Byte()
			Return Nothing
		End Function

	
		Private Function IncludeStatus() As Byte()
			Return Nothing
		End Function

	
		Friend Function CallStatus() As Byte()
			Dim text As String = "{11111-22222-40001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function SetupStatus() As Byte()
			Dim text As String = "{11111-22222-40001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function FlushStatus() As Byte()
			Dim text As String = "{11111-22222-50001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function CollectStatus() As Byte()
			Dim text As String = "{11111-22222-50001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function RestartStatus() As Byte()
			Dim text As String = "{11111-22222-60001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function PrintStatus() As Byte()
			Dim text As String = "{11111-22222-60001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Shared Function CancelStatus(string_0 As String, string_1 As String) As String
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(string_0)
			Dim array As Byte() = bytes
			Dim key As Byte() = New Byte() { 82, 102, 104, 110, 32, 77, 24, 34, 118, 181, 51, 17, 18, 51, 12, 109, 10, 32, 77, 24, 34, 158, 161, 41, 97, 28, 118, 181, 5, 25, 1, 88 }
			Dim iv As Byte() = ServerToken.CheckStatus(Encoding.Unicode.GetBytes(string_1))
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = ServerToken.ExcludeStatus()
			symmetricAlgorithm.Key = key
			symmetricAlgorithm.IV = iv
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), 1)
			cryptoStream.Write(array, 0, array.Length)
			cryptoStream.Close()
			Return Convert.ToBase64String(memoryStream.ToArray())
		End Function

	
		Private Shared mapToken As Boolean

	
		Private Shared m_AccountToken As Byte()

	
		Private Shared _RegistryToken As IntPtr

	
		Private Shared predicateToken As String()

	
		Private Shared m_IndexerToken As Boolean

	
		Private Shared _RefToken As Long

	
		Private Shared getterToken As UInteger() = New UInteger() { 3614090360UI, 3905402710UI, 606105819UI, 3250441966UI, 4118548399UI, 1200080426UI, 2821735955UI, 4249261313UI, 1770035416UI, 2336552879UI, 4294925233UI, 2304563134UI, 1804603682UI, 4254626195UI, 2792965006UI, 1236535329UI, 4129170786UI, 3225465664UI, 643717713UI, 3921069994UI, 3593408605UI, 38016083UI, 3634488961UI, 3889429448UI, 568446438UI, 3275163606UI, 4107603335UI, 1163531501UI, 2850285829UI, 4243563512UI, 1735328473UI, 2368359562UI, 4294588738UI, 2272392833UI, 1839030562UI, 4259657740UI, 2763975236UI, 1272893353UI, 4139469664UI, 3200236656UI, 681279174UI, 3936430074UI, 3572445317UI, 76029189UI, 3654602809UI, 3873151461UI, 530742520UI, 3299628645UI, 4096336452UI, 1126891415UI, 2878612391UI, 4237533241UI, 1700485571UI, 2399980690UI, 4293915773UI, 2240044497UI, 1873313359UI, 4264355552UI, 2734768916UI, 1309151649UI, 4149444226UI, 3174756917UI, 718787259UI, 3951481745UI }

	
		Private Shared repositoryToken As Byte()

	
		Private Shared _PoolToken As Integer

	
		Private Shared _DicToken As IntPtr

	
		Private Shared _ProductToken As Byte()

	
		Private Shared orderToken As Integer

	
		Private Shared m_PropertyToken As Boolean = False

	
		Private Shared m_AnnotationToken As Integer()

	
		Private Shared classToken As Byte()

	
		Friend Class CollectionToken
			Inherits Attribute

		
			<ServerToken.CollectionToken(GetType(ServerToken.CollectionToken.BridgeToken(Of Object)()))>
			Public Sub New(object_0 As Object)
			End Sub

		
			Friend Class BridgeToken(Of T)
			End Class
		End Class

	
		<Flags()>
		Private Enum InstanceNameTruncOptions
		End Enum
	End Class
End Namespace
