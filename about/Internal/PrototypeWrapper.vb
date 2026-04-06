Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Namespace about.Internal
	' Token: 0x02000010 RID: 16
	Friend Class PrototypeWrapper
		' Token: 0x0600006A RID: 106 RVA: 0x000042AC File Offset: 0x000024AC
		Shared Sub New()
			PrototypeWrapper._StatusWrapper = False
			PrototypeWrapper.m_AlgoWrapper = False
			PrototypeWrapper.resolverWrapper = New Byte(-1) {}
			PrototypeWrapper._GetterWrapper = New Byte(-1) {}
			PrototypeWrapper.callbackWrapper = New Byte(-1) {}
			PrototypeWrapper.strategyWrapper = New Byte(-1) {}
			PrototypeWrapper.filterWrapper = IntPtr.Zero
			PrototypeWrapper.m_RefWrapper = IntPtr.Zero
			PrototypeWrapper._ComposerWrapper = New String(-1) {}
			PrototypeWrapper.m_AccountWrapper = New Integer(-1) {}
			PrototypeWrapper.baseWrapper = 1
			PrototypeWrapper.productWrapper = 0L
			PrototypeWrapper._ReponseWrapper = 0
			PrototypeWrapper.m_DispatcherWrapper = False
		End Sub

		' Token: 0x0600006B RID: 107 RVA: 0x0000247F File Offset: 0x0000067F
		Private Sub method_0()
		End Sub

		' Token: 0x0600006C RID: 108 RVA: 0x00004354 File Offset: 0x00002554
		Friend Shared Function SelectPolicy(object_0 As Object) As Byte()
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
				PrototypeWrapper.ListPolicy(num7, num8, num9, num10, 0UI, 7US, 1UI, array)
				PrototypeWrapper.ListPolicy(num10, num7, num8, num9, 1UI, 12US, 2UI, array)
				PrototypeWrapper.ListPolicy(num9, num10, num7, num8, 2UI, 17US, 3UI, array)
				PrototypeWrapper.ListPolicy(num8, num9, num10, num7, 3UI, 22US, 4UI, array)
				PrototypeWrapper.ListPolicy(num7, num8, num9, num10, 4UI, 7US, 5UI, array)
				PrototypeWrapper.ListPolicy(num10, num7, num8, num9, 5UI, 12US, 6UI, array)
				PrototypeWrapper.ListPolicy(num9, num10, num7, num8, 6UI, 17US, 7UI, array)
				PrototypeWrapper.ListPolicy(num8, num9, num10, num7, 7UI, 22US, 8UI, array)
				PrototypeWrapper.ListPolicy(num7, num8, num9, num10, 8UI, 7US, 9UI, array)
				PrototypeWrapper.ListPolicy(num10, num7, num8, num9, 9UI, 12US, 10UI, array)
				PrototypeWrapper.ListPolicy(num9, num10, num7, num8, 10UI, 17US, 11UI, array)
				PrototypeWrapper.ListPolicy(num8, num9, num10, num7, 11UI, 22US, 12UI, array)
				PrototypeWrapper.ListPolicy(num7, num8, num9, num10, 12UI, 7US, 13UI, array)
				PrototypeWrapper.ListPolicy(num10, num7, num8, num9, 13UI, 12US, 14UI, array)
				PrototypeWrapper.ListPolicy(num9, num10, num7, num8, 14UI, 17US, 15UI, array)
				PrototypeWrapper.ListPolicy(num8, num9, num10, num7, 15UI, 22US, 16UI, array)
				PrototypeWrapper.ViewPolicy(num7, num8, num9, num10, 1UI, 5US, 17UI, array)
				PrototypeWrapper.ViewPolicy(num10, num7, num8, num9, 6UI, 9US, 18UI, array)
				PrototypeWrapper.ViewPolicy(num9, num10, num7, num8, 11UI, 14US, 19UI, array)
				PrototypeWrapper.ViewPolicy(num8, num9, num10, num7, 0UI, 20US, 20UI, array)
				PrototypeWrapper.ViewPolicy(num7, num8, num9, num10, 5UI, 5US, 21UI, array)
				PrototypeWrapper.ViewPolicy(num10, num7, num8, num9, 10UI, 9US, 22UI, array)
				PrototypeWrapper.ViewPolicy(num9, num10, num7, num8, 15UI, 14US, 23UI, array)
				PrototypeWrapper.ViewPolicy(num8, num9, num10, num7, 4UI, 20US, 24UI, array)
				PrototypeWrapper.ViewPolicy(num7, num8, num9, num10, 9UI, 5US, 25UI, array)
				PrototypeWrapper.ViewPolicy(num10, num7, num8, num9, 14UI, 9US, 26UI, array)
				PrototypeWrapper.ViewPolicy(num9, num10, num7, num8, 3UI, 14US, 27UI, array)
				PrototypeWrapper.ViewPolicy(num8, num9, num10, num7, 8UI, 20US, 28UI, array)
				PrototypeWrapper.ViewPolicy(num7, num8, num9, num10, 13UI, 5US, 29UI, array)
				PrototypeWrapper.ViewPolicy(num10, num7, num8, num9, 2UI, 9US, 30UI, array)
				PrototypeWrapper.ViewPolicy(num9, num10, num7, num8, 7UI, 14US, 31UI, array)
				PrototypeWrapper.ViewPolicy(num8, num9, num10, num7, 12UI, 20US, 32UI, array)
				PrototypeWrapper.SetupPolicy(num7, num8, num9, num10, 5UI, 4US, 33UI, array)
				PrototypeWrapper.SetupPolicy(num10, num7, num8, num9, 8UI, 11US, 34UI, array)
				PrototypeWrapper.SetupPolicy(num9, num10, num7, num8, 11UI, 16US, 35UI, array)
				PrototypeWrapper.SetupPolicy(num8, num9, num10, num7, 14UI, 23US, 36UI, array)
				PrototypeWrapper.SetupPolicy(num7, num8, num9, num10, 1UI, 4US, 37UI, array)
				PrototypeWrapper.SetupPolicy(num10, num7, num8, num9, 4UI, 11US, 38UI, array)
				PrototypeWrapper.SetupPolicy(num9, num10, num7, num8, 7UI, 16US, 39UI, array)
				PrototypeWrapper.SetupPolicy(num8, num9, num10, num7, 10UI, 23US, 40UI, array)
				PrototypeWrapper.SetupPolicy(num7, num8, num9, num10, 13UI, 4US, 41UI, array)
				PrototypeWrapper.SetupPolicy(num10, num7, num8, num9, 0UI, 11US, 42UI, array)
				PrototypeWrapper.SetupPolicy(num9, num10, num7, num8, 3UI, 16US, 43UI, array)
				PrototypeWrapper.SetupPolicy(num8, num9, num10, num7, 6UI, 23US, 44UI, array)
				PrototypeWrapper.SetupPolicy(num7, num8, num9, num10, 9UI, 4US, 45UI, array)
				PrototypeWrapper.SetupPolicy(num10, num7, num8, num9, 12UI, 11US, 46UI, array)
				PrototypeWrapper.SetupPolicy(num9, num10, num7, num8, 15UI, 16US, 47UI, array)
				PrototypeWrapper.SetupPolicy(num8, num9, num10, num7, 2UI, 23US, 48UI, array)
				PrototypeWrapper.ClonePolicy(num7, num8, num9, num10, 0UI, 6US, 49UI, array)
				PrototypeWrapper.ClonePolicy(num10, num7, num8, num9, 7UI, 10US, 50UI, array)
				PrototypeWrapper.ClonePolicy(num9, num10, num7, num8, 14UI, 15US, 51UI, array)
				PrototypeWrapper.ClonePolicy(num8, num9, num10, num7, 5UI, 21US, 52UI, array)
				PrototypeWrapper.ClonePolicy(num7, num8, num9, num10, 12UI, 6US, 53UI, array)
				PrototypeWrapper.ClonePolicy(num10, num7, num8, num9, 3UI, 10US, 54UI, array)
				PrototypeWrapper.ClonePolicy(num9, num10, num7, num8, 10UI, 15US, 55UI, array)
				PrototypeWrapper.ClonePolicy(num8, num9, num10, num7, 1UI, 21US, 56UI, array)
				PrototypeWrapper.ClonePolicy(num7, num8, num9, num10, 8UI, 6US, 57UI, array)
				PrototypeWrapper.ClonePolicy(num10, num7, num8, num9, 15UI, 10US, 58UI, array)
				PrototypeWrapper.ClonePolicy(num9, num10, num7, num8, 6UI, 15US, 59UI, array)
				PrototypeWrapper.ClonePolicy(num8, num9, num10, num7, 13UI, 21US, 60UI, array)
				PrototypeWrapper.ClonePolicy(num7, num8, num9, num10, 4UI, 6US, 61UI, array)
				PrototypeWrapper.ClonePolicy(num10, num7, num8, num9, 11UI, 10US, 62UI, array)
				PrototypeWrapper.ClonePolicy(num9, num10, num7, num8, 2UI, 15US, 63UI, array)
				PrototypeWrapper.ClonePolicy(num8, num9, num10, num7, 9UI, 21US, 64UI, array)
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

		' Token: 0x0600006D RID: 109 RVA: 0x00002572 File Offset: 0x00000772
		Private Shared Sub ListPolicy(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + PrototypeWrapper.CalculatePolicy(uint_0 + ((uint_1 And uint_2) Or (Not uint_1 And uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + PrototypeWrapper.proxyWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x0600006E RID: 110 RVA: 0x0000259D File Offset: 0x0000079D
		Private Shared Sub ViewPolicy(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + PrototypeWrapper.CalculatePolicy(uint_0 + ((uint_1 And uint_3) Or (uint_2 And Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + PrototypeWrapper.proxyWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x0600006F RID: 111 RVA: 0x000025C8 File Offset: 0x000007C8
		Private Shared Sub SetupPolicy(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + PrototypeWrapper.CalculatePolicy(uint_0 + (uint_1 Xor uint_2 Xor uint_3) + object_0(CInt(CType(uint_4, UIntPtr))) + PrototypeWrapper.proxyWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x06000070 RID: 112 RVA: 0x000025F0 File Offset: 0x000007F0
		Private Shared Sub ClonePolicy(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + PrototypeWrapper.CalculatePolicy(uint_0 + (uint_2 Xor (uint_1 Or Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + PrototypeWrapper.proxyWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x06000071 RID: 113 RVA: 0x00002619 File Offset: 0x00000819
		Private Shared Function CalculatePolicy(uint_0 As UInteger, ushort_0 As UShort) As UInteger
			Return uint_0 >> CInt((32US - ushort_0)) Or uint_0 << CInt(ushort_0)
		End Function

		' Token: 0x06000072 RID: 114 RVA: 0x0000262B File Offset: 0x0000082B
		Friend Shared Function PublishPolicy() As Boolean
			If Not PrototypeWrapper._StatusWrapper Then
				PrototypeWrapper.InsertPolicy()
				PrototypeWrapper._StatusWrapper = True
			End If
			Return PrototypeWrapper.m_AlgoWrapper
		End Function

		' Token: 0x06000073 RID: 115 RVA: 0x000049F8 File Offset: 0x00002BF8
		Friend Shared Sub InsertPolicy()
			Try
				PrototypeWrapper.m_AlgoWrapper = CBool(GetType(RijndaelManaged).Assembly.[GetType]("System.Security.Cryptography.CryptoConfig", False).GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.[Static] Or BindingFlags.[Public]).Invoke(Nothing, New Object(-1) {}))
			Catch
			End Try
		End Sub

		' Token: 0x06000074 RID: 116 RVA: 0x00004A58 File Offset: 0x00002C58
		Friend Shared Function CheckPolicy() As SymmetricAlgorithm
			Dim result As SymmetricAlgorithm = Nothing
			If PrototypeWrapper.PublishPolicy() Then
				Try
					Return New AesCryptoServiceProvider()
				Catch
					Return New RijndaelManaged()
				End Try
			End If
			result = New RijndaelManaged()
			Return result
		End Function

		' Token: 0x06000075 RID: 117 RVA: 0x00002644 File Offset: 0x00000844
		Friend Shared Function StartPolicy(byte_0 As Byte()) As Byte()
			If Not PrototypeWrapper.PublishPolicy() Then
				Return New MD5CryptoServiceProvider().ComputeHash(byte_0)
			End If
			Return PrototypeWrapper.SelectPolicy(byte_0)
		End Function

		' Token: 0x06000076 RID: 118 RVA: 0x00004A98 File Offset: 0x00002C98
		Shared Function EnablePolicy(int_0 As Integer) As Boolean
			If PrototypeWrapper._GetterWrapper.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(PrototypeWrapper).Assembly.GetManifestResourceStream("50e256ac-44c9-478b-aa05-792542ad293e"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 114
				array2(0) = 49
				array2(0) = 156
				array2(0) = 94
				array2(0) = 73
				array2(1) = 91
				array2(1) = 73
				array2(1) = 131
				array2(1) = 228
				array2(2) = 43
				array2(2) = 147
				array2(2) = 35
				array2(3) = 59
				array2(3) = 125
				array2(3) = 96
				array2(3) = 146
				array2(3) = 230
				array2(4) = 166
				array2(4) = 113
				array2(4) = 150
				array2(4) = 165
				array2(4) = 163
				array2(5) = 92
				array2(5) = 146
				array2(5) = 88
				array2(5) = 200
				array2(6) = 166
				array2(6) = 50
				array2(6) = 177
				array2(7) = 61
				array2(7) = 86
				array2(7) = 72
				array2(7) = 114
				array2(7) = 115
				array2(7) = 75
				array2(8) = 119
				array2(8) = 168
				array2(8) = 168
				array2(8) = 108
				array2(8) = 157
				array2(8) = 23
				array2(9) = 74
				array2(9) = 117
				array2(9) = 158
				array2(9) = 218
				array2(10) = 181
				array2(10) = 49
				array2(10) = 80
				array2(11) = 91
				array2(11) = 88
				array2(11) = 70
				array2(11) = 151
				array2(12) = 177
				array2(12) = 228
				array2(12) = 163
				array2(13) = 84
				array2(13) = 57
				array2(13) = 150
				array2(13) = 112
				array2(13) = 250
				array2(14) = 115
				array2(14) = 146
				array2(14) = 53
				array2(14) = 155
				array2(15) = 27
				array2(15) = 199
				array2(15) = 120
				array2(15) = 196
				array2(16) = 154
				array2(16) = 159
				array2(16) = 163
				array2(16) = 135
				array2(16) = 238
				array2(17) = 118
				array2(17) = 129
				array2(17) = 150
				array2(17) = 154
				array2(17) = 84
				array2(17) = 99
				array2(18) = 195
				array2(18) = 114
				array2(18) = 148
				array2(18) = 205
				array2(18) = 35
				array2(19) = 156
				array2(19) = 21
				array2(19) = 130
				array2(19) = 79
				array2(19) = 210
				array2(20) = 48
				array2(20) = 70
				array2(20) = 150
				array2(20) = 241
				array2(21) = 191
				array2(21) = 126
				array2(21) = 77
				array2(21) = 96
				array2(21) = 96
				array2(22) = 169
				array2(22) = 136
				array2(22) = 115
				array2(22) = 234
				array2(23) = 129
				array2(23) = 116
				array2(23) = 146
				array2(24) = 101
				array2(24) = 179
				array2(24) = 125
				array2(24) = 115
				array2(24) = 52
				array2(24) = 236
				array2(25) = 199
				array2(25) = 116
				array2(25) = 103
				array2(25) = 103
				array2(25) = 113
				array2(25) = 120
				array2(26) = 175
				array2(26) = 114
				array2(26) = 109
				array2(26) = 146
				array2(26) = 56
				array2(27) = 94
				array2(27) = 86
				array2(27) = 158
				array2(27) = 253
				array2(28) = 166
				array2(28) = 111
				array2(28) = 185
				array2(29) = 111
				array2(29) = 167
				array2(29) = 91
				array2(30) = 131
				array2(30) = 119
				array2(30) = 154
				array2(30) = 57
				array2(30) = 210
				array2(31) = 97
				array2(31) = 142
				array2(31) = 98
				array2(31) = 163
				array2(31) = 117
				array2(31) = 103
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 114
				array4(0) = 49
				array4(0) = 156
				array4(0) = 18
				array4(0) = 91
				array4(0) = 51
				array4(1) = 158
				array4(1) = 171
				array4(1) = 157
				array4(1) = 108
				array4(1) = 215
				array4(1) = 251
				array4(2) = 98
				array4(2) = 137
				array4(2) = 53
				array4(2) = 192
				array4(3) = 160
				array4(3) = 113
				array4(3) = 210
				array4(3) = 117
				array4(3) = 87
				array4(4) = 42
				array4(4) = 88
				array4(4) = 132
				array4(4) = 155
				array4(4) = 158
				array4(4) = 245
				array4(5) = 118
				array4(5) = 157
				array4(5) = 88
				array4(5) = 86
				array4(5) = 167
				array4(6) = 108
				array4(6) = 163
				array4(6) = 121
				array4(7) = 119
				array4(7) = 146
				array4(7) = 174
				array4(7) = 234
				array4(8) = 94
				array4(8) = 112
				array4(8) = 150
				array4(8) = 222
				array4(9) = 102
				array4(9) = 189
				array4(9) = 18
				array4(10) = 89
				array4(10) = 105
				array4(10) = 84
				array4(10) = 87
				array4(10) = 126
				array4(10) = 147
				array4(11) = 159
				array4(11) = 156
				array4(11) = 228
				array4(11) = 197
				array4(12) = 104
				array4(12) = 164
				array4(12) = 254
				array4(13) = 118
				array4(13) = 145
				array4(13) = 154
				array4(13) = 146
				array4(13) = 174
				array4(14) = 118
				array4(14) = 143
				array4(14) = 132
				array4(14) = 141
				array4(15) = 120
				array4(15) = 143
				array4(15) = 175
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(PrototypeWrapper).Assembly.GetName().GetPublicKeyToken()
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
				Dim symmetricAlgorithm As SymmetricAlgorithm = PrototypeWrapper.CheckPolicy()
				symmetricAlgorithm.Mode = 1
				Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.FlushFinalBlock()
				PrototypeWrapper._GetterWrapper = memoryStream.ToArray()
				memoryStream.Close()
				cryptoStream.Close()
				binaryReader.Close()
			End If
			If PrototypeWrapper.resolverWrapper.Length = 0 Then
				PrototypeWrapper.resolverWrapper = PrototypeWrapper.DefineWrapper(PrototypeWrapper.RestartPolicy(GetType(PrototypeWrapper).Assembly).ToString())
			End If
			Dim num As Integer = 0
			Try
				num = BitConverter.ToInt32(New Byte() { PrototypeWrapper._GetterWrapper(int_0), PrototypeWrapper._GetterWrapper(int_0 + 1), PrototypeWrapper._GetterWrapper(int_0 + 2), PrototypeWrapper._GetterWrapper(int_0 + 3) }, 0)
			Catch
			End Try
			Try
				If PrototypeWrapper.resolverWrapper(num) = 128 Then
					Return True
				End If
			Catch
			End Try
			Return False
		End Function

		' Token: 0x06000077 RID: 119 RVA: 0x0000559C File Offset: 0x0000379C
		Shared Function CancelPolicy(int_0 As Integer) As String
			If PrototypeWrapper.callbackWrapper.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(PrototypeWrapper).Assembly.GetManifestResourceStream("f505fc1b-5fac-44f1-98d0-d5b134c65e47"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 136
				array2(0) = 153
				array2(0) = 226
				array2(0) = 116
				array2(0) = 94
				array2(0) = 126
				array2(1) = 120
				array2(1) = 41
				array2(1) = 204
				array2(2) = 111
				array2(2) = 122
				array2(2) = 42
				array2(3) = 192
				array2(3) = 160
				array2(3) = 49
				array2(4) = 155
				array2(4) = 147
				array2(4) = 35
				array2(5) = 135
				array2(5) = 104
				array2(5) = 175
				array2(5) = 65
				array2(5) = 170
				array2(6) = 95
				array2(6) = 212
				array2(6) = 252
				array2(7) = 186
				array2(7) = 110
				array2(7) = 136
				array2(7) = 132
				array2(7) = 73
				array2(7) = 70
				array2(8) = 103
				array2(8) = 100
				array2(8) = 22
				array2(9) = 135
				array2(9) = 125
				array2(9) = 134
				array2(9) = 152
				array2(9) = 226
				array2(10) = 146
				array2(10) = 132
				array2(10) = 141
				array2(10) = 165
				array2(10) = 31
				array2(10) = 93
				array2(11) = 189
				array2(11) = 156
				array2(11) = 73
				array2(11) = 180
				array2(11) = 0
				array2(12) = 118
				array2(12) = 186
				array2(12) = 125
				array2(13) = 138
				array2(13) = 140
				array2(13) = 125
				array2(13) = 215
				array2(14) = 137
				array2(14) = 82
				array2(14) = 188
				array2(14) = 103
				array2(14) = 65
				array2(15) = 140
				array2(15) = 116
				array2(15) = 164
				array2(15) = 137
				array2(16) = 128
				array2(16) = 83
				array2(16) = 152
				array2(16) = 105
				array2(16) = 92
				array2(17) = 100
				array2(17) = 145
				array2(17) = 139
				array2(17) = 142
				array2(18) = 160
				array2(18) = 153
				array2(18) = 181
				array2(18) = 121
				array2(19) = 84
				array2(19) = 97
				array2(19) = 147
				array2(19) = 127
				array2(19) = 125
				array2(19) = 150
				array2(20) = 86
				array2(20) = 195
				array2(20) = 138
				array2(20) = 146
				array2(20) = 217
				array2(21) = 166
				array2(21) = 142
				array2(21) = 126
				array2(21) = 70
				array2(22) = 109
				array2(22) = 78
				array2(22) = 114
				array2(22) = 119
				array2(22) = 237
				array2(23) = 124
				array2(23) = 135
				array2(23) = 149
				array2(23) = 148
				array2(23) = 113
				array2(23) = 131
				array2(24) = 147
				array2(24) = 79
				array2(24) = 90
				array2(24) = 164
				array2(24) = 94
				array2(24) = 171
				array2(25) = 86
				array2(25) = 149
				array2(25) = 85
				array2(26) = 98
				array2(26) = 62
				array2(26) = 162
				array2(26) = 93
				array2(26) = 38
				array2(27) = 207
				array2(27) = 152
				array2(27) = 14
				array2(28) = 45
				array2(28) = 206
				array2(28) = 155
				array2(28) = 219
				array2(28) = 118
				array2(28) = 171
				array2(29) = 121
				array2(29) = 175
				array2(29) = 121
				array2(29) = 171
				array2(30) = 161
				array2(30) = 122
				array2(30) = 105
				array2(30) = 26
				array2(31) = 122
				array2(31) = 128
				array2(31) = 193
				array2(31) = 177
				array2(31) = 118
				array2(31) = 229
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 86
				array4(0) = 93
				array4(0) = 168
				array4(0) = 66
				array4(0) = 99
				array4(0) = 73
				array4(1) = 41
				array4(1) = 133
				array4(1) = 102
				array4(1) = 122
				array4(1) = 124
				array4(1) = 105
				array4(2) = 134
				array4(2) = 111
				array4(2) = 64
				array4(3) = 201
				array4(3) = 147
				array4(3) = 110
				array4(4) = 101
				array4(4) = 149
				array4(4) = 150
				array4(4) = 166
				array4(4) = 81
				array4(5) = 51
				array4(5) = 95
				array4(5) = 100
				array4(6) = 201
				array4(6) = 186
				array4(6) = 94
				array4(6) = 45
				array4(7) = 38
				array4(7) = 135
				array4(7) = 73
				array4(8) = 79
				array4(8) = 128
				array4(8) = 152
				array4(9) = 135
				array4(9) = 125
				array4(9) = 134
				array4(9) = 122
				array4(9) = 86
				array4(9) = 106
				array4(10) = 100
				array4(10) = 84
				array4(10) = 222
				array4(11) = 128
				array4(11) = 32
				array4(11) = 188
				array4(11) = 165
				array4(11) = 9
				array4(12) = 143
				array4(12) = 128
				array4(12) = 142
				array4(12) = 140
				array4(12) = 95
				array4(12) = 180
				array4(13) = 102
				array4(13) = 240
				array4(13) = 189
				array4(14) = 169
				array4(14) = 100
				array4(14) = 102
				array4(14) = 188
				array4(14) = 110
				array4(15) = 142
				array4(15) = 72
				array4(15) = 164
				array4(15) = 96
				array4(15) = 133
				array4(15) = 28
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(PrototypeWrapper).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = PrototypeWrapper.CheckPolicy()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					PrototypeWrapper.callbackWrapper = memoryStream.ToArray()
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = PrototypeWrapper.callbackWrapper
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
				PrototypeWrapper.callbackWrapper = array6
			End If
			Dim num17 As Integer = BitConverter.ToInt32(PrototypeWrapper.callbackWrapper, int_0)
			Try
				Dim array7 As Byte() = New Byte(num17 - 1) {}
				Array.Copy(PrototypeWrapper.callbackWrapper, int_0 + 4, array7, 0, num17)
				Return Encoding.Unicode.GetString(array7, 0, array7.Length)
			Catch
			End Try
			Return ""
		End Function

		' Token: 0x06000078 RID: 120 RVA: 0x00006304 File Offset: 0x00004504
		Shared Function FillPolicy(int_0 As Integer) As String
			If PrototypeWrapper.strategyWrapper.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(PrototypeWrapper).Assembly.GetManifestResourceStream("f505fc1b-5fac-44f1-98d0-d5b134c65e47"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 136
				array2(0) = 153
				array2(0) = 226
				array2(0) = 116
				array2(0) = 94
				array2(0) = 126
				array2(1) = 120
				array2(1) = 41
				array2(1) = 204
				array2(2) = 111
				array2(2) = 122
				array2(2) = 42
				array2(3) = 192
				array2(3) = 160
				array2(3) = 49
				array2(4) = 155
				array2(4) = 147
				array2(4) = 35
				array2(5) = 135
				array2(5) = 104
				array2(5) = 175
				array2(5) = 65
				array2(5) = 170
				array2(6) = 95
				array2(6) = 212
				array2(6) = 252
				array2(7) = 186
				array2(7) = 110
				array2(7) = 136
				array2(7) = 132
				array2(7) = 73
				array2(7) = 70
				array2(8) = 103
				array2(8) = 100
				array2(8) = 22
				array2(9) = 135
				array2(9) = 125
				array2(9) = 134
				array2(9) = 152
				array2(9) = 226
				array2(10) = 146
				array2(10) = 132
				array2(10) = 141
				array2(10) = 165
				array2(10) = 31
				array2(10) = 93
				array2(11) = 189
				array2(11) = 156
				array2(11) = 73
				array2(11) = 180
				array2(11) = 0
				array2(12) = 118
				array2(12) = 186
				array2(12) = 125
				array2(13) = 138
				array2(13) = 140
				array2(13) = 125
				array2(13) = 215
				array2(14) = 137
				array2(14) = 82
				array2(14) = 188
				array2(14) = 103
				array2(14) = 65
				array2(15) = 140
				array2(15) = 116
				array2(15) = 164
				array2(15) = 137
				array2(16) = 128
				array2(16) = 83
				array2(16) = 152
				array2(16) = 105
				array2(16) = 92
				array2(17) = 100
				array2(17) = 145
				array2(17) = 139
				array2(17) = 142
				array2(18) = 160
				array2(18) = 153
				array2(18) = 181
				array2(18) = 121
				array2(19) = 84
				array2(19) = 97
				array2(19) = 147
				array2(19) = 127
				array2(19) = 125
				array2(19) = 150
				array2(20) = 86
				array2(20) = 195
				array2(20) = 138
				array2(20) = 146
				array2(20) = 217
				array2(21) = 166
				array2(21) = 142
				array2(21) = 126
				array2(21) = 70
				array2(22) = 109
				array2(22) = 78
				array2(22) = 114
				array2(22) = 119
				array2(22) = 237
				array2(23) = 124
				array2(23) = 135
				array2(23) = 149
				array2(23) = 148
				array2(23) = 113
				array2(23) = 131
				array2(24) = 147
				array2(24) = 79
				array2(24) = 90
				array2(24) = 164
				array2(24) = 94
				array2(24) = 171
				array2(25) = 86
				array2(25) = 149
				array2(25) = 85
				array2(26) = 98
				array2(26) = 62
				array2(26) = 162
				array2(26) = 93
				array2(26) = 38
				array2(27) = 207
				array2(27) = 152
				array2(27) = 14
				array2(28) = 45
				array2(28) = 206
				array2(28) = 155
				array2(28) = 219
				array2(28) = 118
				array2(28) = 171
				array2(29) = 121
				array2(29) = 175
				array2(29) = 121
				array2(29) = 171
				array2(30) = 161
				array2(30) = 122
				array2(30) = 105
				array2(30) = 26
				array2(31) = 122
				array2(31) = 128
				array2(31) = 193
				array2(31) = 177
				array2(31) = 118
				array2(31) = 229
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 86
				array4(0) = 93
				array4(0) = 168
				array4(0) = 66
				array4(0) = 99
				array4(0) = 73
				array4(1) = 41
				array4(1) = 133
				array4(1) = 102
				array4(1) = 122
				array4(1) = 124
				array4(1) = 105
				array4(2) = 134
				array4(2) = 111
				array4(2) = 64
				array4(3) = 201
				array4(3) = 147
				array4(3) = 110
				array4(4) = 101
				array4(4) = 149
				array4(4) = 150
				array4(4) = 166
				array4(4) = 81
				array4(5) = 51
				array4(5) = 95
				array4(5) = 100
				array4(6) = 201
				array4(6) = 186
				array4(6) = 94
				array4(6) = 45
				array4(7) = 38
				array4(7) = 135
				array4(7) = 73
				array4(8) = 79
				array4(8) = 128
				array4(8) = 152
				array4(9) = 135
				array4(9) = 125
				array4(9) = 134
				array4(9) = 122
				array4(9) = 86
				array4(9) = 106
				array4(10) = 100
				array4(10) = 84
				array4(10) = 222
				array4(11) = 128
				array4(11) = 32
				array4(11) = 188
				array4(11) = 165
				array4(11) = 9
				array4(12) = 143
				array4(12) = 128
				array4(12) = 142
				array4(12) = 140
				array4(12) = 95
				array4(12) = 180
				array4(13) = 102
				array4(13) = 240
				array4(13) = 189
				array4(14) = 169
				array4(14) = 100
				array4(14) = 102
				array4(14) = 188
				array4(14) = 110
				array4(15) = 142
				array4(15) = 72
				array4(15) = 164
				array4(15) = 96
				array4(15) = 133
				array4(15) = 28
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(PrototypeWrapper).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = PrototypeWrapper.CheckPolicy()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					PrototypeWrapper.strategyWrapper = memoryStream.ToArray()
					If PrototypeWrapper.strategyWrapper.Length > 0 Then
						PrototypeWrapper._ComposerWrapper = New String(PrototypeWrapper.strategyWrapper.Length / 4 + 1 - 1) {}
						PrototypeWrapper.m_AccountWrapper = New Integer(PrototypeWrapper.strategyWrapper.Length / 4 + 1 - 1) {}
					End If
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = PrototypeWrapper.strategyWrapper
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
				PrototypeWrapper.strategyWrapper = array6
				If PrototypeWrapper.strategyWrapper.Length > 0 Then
					PrototypeWrapper._ComposerWrapper = New String(PrototypeWrapper.strategyWrapper.Length / 4 + 1 - 1) {}
					PrototypeWrapper.m_AccountWrapper = New Integer(PrototypeWrapper.strategyWrapper.Length / 4 + 1 - 1) {}
				End If
				Dim assembly As Assembly = GetType(PrototypeWrapper).Assembly
				If IntPtr.Size = 4 Then
					PrototypeWrapper._ReponseWrapper = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt32()
				End If
				PrototypeWrapper.productWrapper = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
			End If
			Dim num16 As Integer = int_0 / 4
			If PrototypeWrapper.m_AccountWrapper(num16) > 0 Then
				Return CType(PrototypeWrapper._ComposerWrapper, String())(PrototypeWrapper.m_AccountWrapper(num16))
			End If
			Dim num17 As Integer = BitConverter.ToInt32(PrototypeWrapper.strategyWrapper, int_0)
			If PrototypeWrapper.filterWrapper = IntPtr.Zero Then
				PrototypeWrapper.filterWrapper = PrototypeWrapper.OpenProcess(16UI, 1, CUInt(Process.GetCurrentProcess().Id))
			End If
			Dim array7 As Byte() = New Byte(3) {}
			If IntPtr.Size = 4 Then
				PrototypeWrapper.ReadProcessMemory(PrototypeWrapper.filterWrapper, New IntPtr(PrototypeWrapper._ReponseWrapper + num17), array7, 4UI, PrototypeWrapper.m_RefWrapper)
			Else
				PrototypeWrapper.ReadProcessMemory(PrototypeWrapper.filterWrapper, New IntPtr(PrototypeWrapper.productWrapper + CLng(num17)), array7, 4UI, PrototypeWrapper.m_RefWrapper)
			End If
			Dim num18 As Integer = BitConverter.ToInt32(array7, 0)
			array7 = New Byte(num18 - 1) {}
			If IntPtr.Size = 4 Then
				PrototypeWrapper.ReadProcessMemory(PrototypeWrapper.filterWrapper, New IntPtr(PrototypeWrapper._ReponseWrapper + num17 + 4), array7, Convert.ToUInt32(num18), PrototypeWrapper.m_RefWrapper)
			Else
				PrototypeWrapper.ReadProcessMemory(PrototypeWrapper.filterWrapper, New IntPtr(PrototypeWrapper.productWrapper + CLng(num17) + 4L), array7, Convert.ToUInt32(num18), PrototypeWrapper.m_RefWrapper)
			End If
			Dim array8 As Byte() = PrototypeWrapper.SortWrapper(array7)
			Dim [string] As String = Encoding.Unicode.GetString(array8, 0, array8.Length)
			PrototypeWrapper.m_AccountWrapper(num16) = PrototypeWrapper.baseWrapper
			CType(PrototypeWrapper._ComposerWrapper, String())(PrototypeWrapper.baseWrapper) = [string]
			PrototypeWrapper.baseWrapper += 1
			Return [string]
		End Function

		' Token: 0x06000079 RID: 121 RVA: 0x00007198 File Offset: 0x00005398
		Friend Shared Function StopPolicy(string_0 As String) As String
			Dim array As Byte() = Convert.FromBase64String(string_0)
			Return Encoding.Unicode.GetString(array, 0, array.Length)
		End Function

		' Token: 0x0600007A RID: 122
		Private Declare Function VirtualProtect Lib "kernel32.dll" (intptr_0 As IntPtr, int_0 As Integer, int_1 As Integer, ByRef int_2 As Integer) As Integer

		' Token: 0x0600007B RID: 123 RVA: 0x000071BC File Offset: 0x000053BC
		<PrototypeWrapper.SpecificationWrapper(GetType(PrototypeWrapper.SpecificationWrapper.ConfigurationWrapper(Of Object)()))>
		Shared Sub VisitPolicy()
			If Not PrototypeWrapper.m_DispatcherWrapper Then
				PrototypeWrapper.m_DispatcherWrapper = True
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(PrototypeWrapper).Assembly.GetManifestResourceStream("97505ece-dd4a-420e-89a3-57c02462475d"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 173
				array2(0) = 104
				array2(0) = 130
				array2(0) = 86
				array2(0) = 144
				array2(0) = 75
				array2(0) = 173
				array2(1) = 44
				array2(1) = 132
				array2(1) = 105
				array2(1) = 106
				array2(1) = 44
				array2(2) = 65
				array2(2) = 169
				array2(2) = 163
				array2(2) = 106
				array2(2) = 65
				array2(3) = 75
				array2(3) = 162
				array2(3) = 167
				array2(3) = 45
				array2(3) = 88
				array2(3) = 82
				array2(3) = 75
				array2(4) = 164
				array2(4) = 160
				array2(4) = 121
				array2(4) = 164
				array2(5) = 40
				array2(5) = 118
				array2(5) = 117
				array2(5) = 151
				array2(5) = 40
				array2(6) = 71
				array2(6) = 156
				array2(6) = 150
				array2(6) = 114
				array2(6) = 71
				array2(7) = 60
				array2(7) = 142
				array2(7) = 108
				array2(7) = 146
				array2(7) = 109
				array2(7) = 60
				array2(8) = 54
				array2(8) = 84
				array2(8) = 141
				array2(8) = 54
				array2(9) = 59
				array2(9) = 112
				array2(9) = 84
				array2(9) = 133
				array2(9) = 137
				array2(9) = 59
				array2(10) = 34
				array2(10) = 144
				array2(10) = 141
				array2(10) = 164
				array2(10) = 104
				array2(10) = 34
				array2(11) = 88
				array2(11) = 79
				array2(11) = 100
				array2(11) = 100
				array2(11) = 146
				array2(11) = 152
				array2(11) = 88
				array2(12) = 229
				array2(12) = 86
				array2(12) = 215
				array2(12) = 169
				array2(12) = 138
				array2(12) = 36
				array2(12) = 229
				array2(13) = 87
				array2(13) = 109
				array2(13) = 112
				array2(13) = 90
				array2(13) = 138
				array2(13) = 127
				array2(13) = 87
				array2(14) = 22
				array2(14) = 41
				array2(14) = 126
				array2(14) = 22
				array2(15) = 14
				array2(15) = 63
				array2(15) = 126
				array2(15) = 168
				array2(15) = 107
				array2(15) = 14
				array2(16) = 23
				array2(16) = 92
				array2(16) = 193
				array2(16) = 125
				array2(16) = 23
				array2(17) = 130
				array2(17) = 156
				array2(17) = 215
				array2(17) = 94
				array2(17) = 130
				array2(18) = 177
				array2(18) = 18
				array2(18) = 154
				array2(18) = 174
				array2(18) = 13
				array2(18) = 128
				array2(18) = 177
				array2(19) = 160
				array2(19) = 104
				array2(19) = 96
				array2(19) = 167
				array2(19) = 189
				array2(19) = 160
				array2(20) = 43
				array2(20) = 86
				array2(20) = 137
				array2(20) = 92
				array2(20) = 166
				array2(20) = 43
				array2(21) = 29
				array2(21) = 107
				array2(21) = 112
				array2(21) = 101
				array2(21) = 29
				array2(22) = 251
				array2(22) = 110
				array2(22) = 155
				array2(22) = 251
				array2(23) = 28
				array2(23) = 95
				array2(23) = 168
				array2(23) = 126
				array2(23) = 34
				array2(23) = 28
				array2(24) = 171
				array2(24) = 147
				array2(24) = 81
				array2(24) = 162
				array2(24) = 162
				array2(24) = 147
				array2(24) = 171
				array2(25) = 237
				array2(25) = 110
				array2(25) = 96
				array2(25) = 141
				array2(25) = 154
				array2(25) = 237
				array2(26) = 235
				array2(26) = 107
				array2(26) = 131
				array2(26) = 75
				array2(26) = 88
				array2(26) = 235
				array2(27) = 252
				array2(27) = 21
				array2(27) = 108
				array2(27) = 148
				array2(27) = 252
				array2(28) = 178
				array2(28) = 177
				array2(28) = 99
				array2(28) = 130
				array2(28) = 100
				array2(28) = 127
				array2(28) = 178
				array2(29) = 0
				array2(29) = 147
				array2(29) = 130
				array2(29) = 140
				array2(29) = 133
				array2(29) = 0
				array2(30) = 161
				array2(30) = 131
				array2(30) = 97
				array2(30) = 163
				array2(30) = 123
				array2(30) = 142
				array2(30) = 161
				array2(31) = 193
				array2(31) = 13
				array2(31) = 149
				array2(31) = 146
				array2(31) = 193
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 104
				array4(0) = 170
				array4(0) = 124
				array4(0) = 118
				array4(0) = 130
				array4(0) = 58
				array4(1) = 132
				array4(1) = 105
				array4(1) = 63
				array4(1) = 189
				array4(1) = 128
				array4(1) = 218
				array4(2) = 158
				array4(2) = 102
				array4(2) = 148
				array4(2) = 160
				array4(3) = 116
				array4(3) = 148
				array4(3) = 135
				array4(3) = 88
				array4(3) = 148
				array4(4) = 163
				array4(4) = 118
				array4(4) = 190
				array4(5) = 74
				array4(5) = 106
				array4(5) = 3
				array4(6) = 114
				array4(6) = 114
				array4(6) = 113
				array4(6) = 128
				array4(6) = 118
				array4(6) = 110
				array4(7) = 102
				array4(7) = 143
				array4(7) = 84
				array4(7) = 188
				array4(7) = 164
				array4(8) = 85
				array4(8) = 110
				array4(8) = 12
				array4(9) = 114
				array4(9) = 196
				array4(9) = 122
				array4(9) = 88
				array4(9) = 185
				array4(10) = 163
				array4(10) = 66
				array4(10) = 139
				array4(10) = 248
				array4(11) = 101
				array4(11) = 122
				array4(11) = 93
				array4(11) = 109
				array4(11) = 191
				array4(12) = 126
				array4(12) = 132
				array4(12) = 98
				array4(12) = 90
				array4(12) = 110
				array4(12) = 190
				array4(13) = 45
				array4(13) = 107
				array4(13) = 189
				array4(14) = 127
				array4(14) = 119
				array4(14) = 76
				array4(14) = 111
				array4(14) = 207
				array4(15) = 93
				array4(15) = 88
				array4(15) = 97
				Dim array5 As Byte() = array4
				Array.Reverse(array5)
				Dim publicKeyToken As Byte() = GetType(PrototypeWrapper).Assembly.GetName().GetPublicKeyToken()
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
				Dim assembly As Assembly = GetType(PrototypeWrapper).Assembly
				intptr_ = PrototypeWrapper.OpenProcess(56UI, 1, CUInt(Process.GetCurrentProcess().Id))
				PrototypeWrapper.productWrapper = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
				Dim zero As IntPtr = IntPtr.Zero
				Dim int_ As Integer = 0
				Dim num16 As Integer = binaryReader.ReadInt32()
				binaryReader.ReadInt32()
				For m As Integer = 0 To num16 - 1
					Dim intPtr As IntPtr = New IntPtr(PrototypeWrapper.productWrapper + CLng(binaryReader.ReadInt32()))
					PrototypeWrapper.VirtualProtect(intPtr, 4, 4, int_)
					If IntPtr.Size = 4 Then
						PrototypeWrapper.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					Else
						PrototypeWrapper.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					End If
					PrototypeWrapper.VirtualProtect(intPtr, 4, int_, int_)
				Next
				Try
					While binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L
						Dim num17 As Integer = binaryReader.ReadInt32()
						Dim intptr_2 As IntPtr = New IntPtr(PrototypeWrapper.productWrapper + CLng(num17))
						Dim num18 As Integer = binaryReader.ReadInt32()
						PrototypeWrapper.VirtualProtect(intptr_2, num18 * 4, 4, int_)
						For n As Integer = 0 To num18 - 1
							Marshal.WriteInt32(New IntPtr(intptr_2.ToInt64() + CLng((n * 4))), binaryReader.ReadInt32())
						Next
						PrototypeWrapper.VirtualProtect(intptr_2, num18 * 4, int_, int_)
					End While
					PrototypeWrapper.CloseHandle(intptr_)
				Catch
				End Try
			End If
		End Sub

		' Token: 0x0600007C RID: 124 RVA: 0x0000822C File Offset: 0x0000642C
		Friend Shared Function RestartPolicy(assembly_0 As Assembly) As Object
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

		' Token: 0x0600007D RID: 125
		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, <[In]()> <Out()> byte_0 As Byte(), uint_0 As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef intptr_2 As IntPtr) As Integer

		' Token: 0x0600007E RID: 126
		Private Declare Function ReadProcessMemory Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, <[In]()> <Out()> byte_0 As Byte(), uint_0 As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef intptr_2 As IntPtr) As Integer

		' Token: 0x0600007F RID: 127
		Private Declare Function OpenProcess Lib "kernel32.dll" (uint_0 As UInteger, int_0 As Integer, uint_1 As UInteger) As IntPtr

		' Token: 0x06000080 RID: 128
		Private Declare Function CloseHandle Lib "kernel32.dll" (intptr_0 As IntPtr) As Integer

		' Token: 0x06000081 RID: 129 RVA: 0x0000833C File Offset: 0x0000653C
		Private Shared Function DefineWrapper(string_0 As String) As Byte()
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

		' Token: 0x06000082 RID: 130 RVA: 0x000083A4 File Offset: 0x000065A4
		Private Shared Function SortWrapper(byte_0 As Byte()) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = PrototypeWrapper.CheckPolicy()
			symmetricAlgorithm.Key = New Byte() { 246, 178, 2, 43, 81, 18, 101, 169, 70, 194, 102, 115, 76, 77, 71, 85, 90, 141, 34, 204, 158, 224, 143, 16, 191, 179, 61, 229, 240, 102, 41, 65 }
			symmetricAlgorithm.IV = New Byte() { 21, 201, 98, 6, 214, 234, 13, 227, 238, 89, 87, 44, 2, 186, 121, 78 }
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), 1)
			cryptoStream.Write(byte_0, 0, byte_0.Length)
			cryptoStream.Close()
			Return memoryStream.ToArray()
		End Function

		' Token: 0x06000083 RID: 131 RVA: 0x0000265F File Offset: 0x0000085F
		Private Function PostWrapper() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000084 RID: 132 RVA: 0x0000265F File Offset: 0x0000085F
		Private Function ConnectWrapper() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000085 RID: 133 RVA: 0x0000265F File Offset: 0x0000085F
		Private Function DestroyWrapper() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000086 RID: 134 RVA: 0x0000265F File Offset: 0x0000085F
		Private Function ValidateWrapper() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000087 RID: 135 RVA: 0x0000265F File Offset: 0x0000085F
		Private Function LogoutWrapper() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000088 RID: 136 RVA: 0x0000265F File Offset: 0x0000085F
		Private Function ComputeWrapper() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000089 RID: 137 RVA: 0x00008414 File Offset: 0x00006614
		Friend Function RemoveWrapper() As Byte()
			Dim text As String = "{11111-22222-40001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x0600008A RID: 138 RVA: 0x00008454 File Offset: 0x00006654
		Friend Function PatchWrapper() As Byte()
			Dim text As String = "{11111-22222-40001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x0600008B RID: 139 RVA: 0x00008494 File Offset: 0x00006694
		Friend Function MapWrapper() As Byte()
			Dim text As String = "{11111-22222-50001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x0600008C RID: 140 RVA: 0x000084D4 File Offset: 0x000066D4
		Friend Function InvokeWrapper() As Byte()
			Dim text As String = "{11111-22222-50001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x0600008D RID: 141 RVA: 0x00008514 File Offset: 0x00006714
		Friend Function ExcludeWrapper() As Byte()
			Dim text As String = "{11111-22222-60001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x0600008E RID: 142 RVA: 0x00008554 File Offset: 0x00006754
		Friend Function LoginWrapper() As Byte()
			Dim text As String = "{11111-22222-60001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x0600008F RID: 143 RVA: 0x00008594 File Offset: 0x00006794
		Friend Shared Function PrintWrapper(string_0 As String, string_1 As String) As String
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(string_0)
			Dim array As Byte() = bytes
			Dim key As Byte() = New Byte() { 82, 102, 104, 110, 32, 77, 24, 34, 118, 181, 51, 17, 18, 51, 12, 109, 10, 32, 77, 24, 34, 158, 161, 41, 97, 28, 118, 181, 5, 25, 1, 88 }
			Dim iv As Byte() = PrototypeWrapper.StartPolicy(Encoding.Unicode.GetBytes(string_1))
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = PrototypeWrapper.CheckPolicy()
			symmetricAlgorithm.Key = key
			symmetricAlgorithm.IV = iv
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), 1)
			cryptoStream.Write(array, 0, array.Length)
			cryptoStream.Close()
			Return Convert.ToBase64String(memoryStream.ToArray())
		End Function

		' Token: 0x04000028 RID: 40
		Private Shared _StatusWrapper As Boolean

		' Token: 0x04000029 RID: 41
		Private Shared _GetterWrapper As Byte()

		' Token: 0x0400002A RID: 42
		Private Shared callbackWrapper As Byte()

		' Token: 0x0400002B RID: 43
		Private Shared m_RefWrapper As IntPtr

		' Token: 0x0400002C RID: 44
		Private Shared m_DispatcherWrapper As Boolean

		' Token: 0x0400002D RID: 45
		Private Shared m_AccountWrapper As Integer()

		' Token: 0x0400002E RID: 46
		Private Shared proxyWrapper As UInteger() = New UInteger() { 3614090360UI, 3905402710UI, 606105819UI, 3250441966UI, 4118548399UI, 1200080426UI, 2821735955UI, 4249261313UI, 1770035416UI, 2336552879UI, 4294925233UI, 2304563134UI, 1804603682UI, 4254626195UI, 2792965006UI, 1236535329UI, 4129170786UI, 3225465664UI, 643717713UI, 3921069994UI, 3593408605UI, 38016083UI, 3634488961UI, 3889429448UI, 568446438UI, 3275163606UI, 4107603335UI, 1163531501UI, 2850285829UI, 4243563512UI, 1735328473UI, 2368359562UI, 4294588738UI, 2272392833UI, 1839030562UI, 4259657740UI, 2763975236UI, 1272893353UI, 4139469664UI, 3200236656UI, 681279174UI, 3936430074UI, 3572445317UI, 76029189UI, 3654602809UI, 3873151461UI, 530742520UI, 3299628645UI, 4096336452UI, 1126891415UI, 2878612391UI, 4237533241UI, 1700485571UI, 2399980690UI, 4293915773UI, 2240044497UI, 1873313359UI, 4264355552UI, 2734768916UI, 1309151649UI, 4149444226UI, 3174756917UI, 718787259UI, 3951481745UI }

		' Token: 0x0400002F RID: 47
		Private Shared baseWrapper As Integer

		' Token: 0x04000030 RID: 48
		Private Shared resolverWrapper As Byte()

		' Token: 0x04000031 RID: 49
		Private Shared _ComposerWrapper As String()

		' Token: 0x04000032 RID: 50
		Private Shared m_AlgoWrapper As Boolean

		' Token: 0x04000033 RID: 51
		Private Shared _ReponseWrapper As Integer

		' Token: 0x04000034 RID: 52
		Private Shared strategyWrapper As Byte()

		' Token: 0x04000035 RID: 53
		Private Shared filterWrapper As IntPtr

		' Token: 0x04000036 RID: 54
		Private Shared productWrapper As Long

		' Token: 0x02000011 RID: 17
		Friend Class SpecificationWrapper
			Inherits Attribute

			' Token: 0x06000091 RID: 145 RVA: 0x00002662 File Offset: 0x00000862
			<PrototypeWrapper.SpecificationWrapper(GetType(PrototypeWrapper.SpecificationWrapper.ConfigurationWrapper(Of Object)()))>
			Public Sub New(object_0 As Object)
			End Sub

			' Token: 0x02000012 RID: 18
			Friend Class ConfigurationWrapper(Of T)
			End Class
		End Class

		' Token: 0x02000013 RID: 19
		<Flags()>
		Private Enum VersionControlLabelDocumentSaveOptions
		End Enum
	End Class
End Namespace
