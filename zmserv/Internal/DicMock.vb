Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Namespace zmserv.Internal
	' Token: 0x0200000D RID: 13
	Friend Class DicMock
		' Token: 0x06000023 RID: 35 RVA: 0x0000282C File Offset: 0x00000A2C
		Shared Sub New()
			DicMock.watcherMock = False
			DicMock._InvocationMock = False
			DicMock.specificationMock = New Byte(-1) {}
			DicMock.modelMock = New Byte(-1) {}
			DicMock.expressionMock = New Byte(-1) {}
			DicMock.merchantMock = New Byte(-1) {}
			DicMock.identifierMock = IntPtr.Zero
			DicMock.registryMock = IntPtr.Zero
			DicMock._MapperMock = New String(-1) {}
			DicMock._ErrorMock = New Integer(-1) {}
			DicMock._ProxyMock = 1
			DicMock.m_SystemMock = 0L
			DicMock._TokenizerMock = 0
			DicMock.definitionMock = False
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x0000235B File Offset: 0x0000055B
		Private Sub method_0()
		End Sub

		' Token: 0x06000025 RID: 37 RVA: 0x000028D4 File Offset: 0x00000AD4
		Friend Shared Function DefineClass(object_0 As Object) As Byte()
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
				DicMock.CalcClass(num7, num8, num9, num10, 0UI, 7US, 1UI, array)
				DicMock.CalcClass(num10, num7, num8, num9, 1UI, 12US, 2UI, array)
				DicMock.CalcClass(num9, num10, num7, num8, 2UI, 17US, 3UI, array)
				DicMock.CalcClass(num8, num9, num10, num7, 3UI, 22US, 4UI, array)
				DicMock.CalcClass(num7, num8, num9, num10, 4UI, 7US, 5UI, array)
				DicMock.CalcClass(num10, num7, num8, num9, 5UI, 12US, 6UI, array)
				DicMock.CalcClass(num9, num10, num7, num8, 6UI, 17US, 7UI, array)
				DicMock.CalcClass(num8, num9, num10, num7, 7UI, 22US, 8UI, array)
				DicMock.CalcClass(num7, num8, num9, num10, 8UI, 7US, 9UI, array)
				DicMock.CalcClass(num10, num7, num8, num9, 9UI, 12US, 10UI, array)
				DicMock.CalcClass(num9, num10, num7, num8, 10UI, 17US, 11UI, array)
				DicMock.CalcClass(num8, num9, num10, num7, 11UI, 22US, 12UI, array)
				DicMock.CalcClass(num7, num8, num9, num10, 12UI, 7US, 13UI, array)
				DicMock.CalcClass(num10, num7, num8, num9, 13UI, 12US, 14UI, array)
				DicMock.CalcClass(num9, num10, num7, num8, 14UI, 17US, 15UI, array)
				DicMock.CalcClass(num8, num9, num10, num7, 15UI, 22US, 16UI, array)
				DicMock.InitClass(num7, num8, num9, num10, 1UI, 5US, 17UI, array)
				DicMock.InitClass(num10, num7, num8, num9, 6UI, 9US, 18UI, array)
				DicMock.InitClass(num9, num10, num7, num8, 11UI, 14US, 19UI, array)
				DicMock.InitClass(num8, num9, num10, num7, 0UI, 20US, 20UI, array)
				DicMock.InitClass(num7, num8, num9, num10, 5UI, 5US, 21UI, array)
				DicMock.InitClass(num10, num7, num8, num9, 10UI, 9US, 22UI, array)
				DicMock.InitClass(num9, num10, num7, num8, 15UI, 14US, 23UI, array)
				DicMock.InitClass(num8, num9, num10, num7, 4UI, 20US, 24UI, array)
				DicMock.InitClass(num7, num8, num9, num10, 9UI, 5US, 25UI, array)
				DicMock.InitClass(num10, num7, num8, num9, 14UI, 9US, 26UI, array)
				DicMock.InitClass(num9, num10, num7, num8, 3UI, 14US, 27UI, array)
				DicMock.InitClass(num8, num9, num10, num7, 8UI, 20US, 28UI, array)
				DicMock.InitClass(num7, num8, num9, num10, 13UI, 5US, 29UI, array)
				DicMock.InitClass(num10, num7, num8, num9, 2UI, 9US, 30UI, array)
				DicMock.InitClass(num9, num10, num7, num8, 7UI, 14US, 31UI, array)
				DicMock.InitClass(num8, num9, num10, num7, 12UI, 20US, 32UI, array)
				DicMock.UpdateClass(num7, num8, num9, num10, 5UI, 4US, 33UI, array)
				DicMock.UpdateClass(num10, num7, num8, num9, 8UI, 11US, 34UI, array)
				DicMock.UpdateClass(num9, num10, num7, num8, 11UI, 16US, 35UI, array)
				DicMock.UpdateClass(num8, num9, num10, num7, 14UI, 23US, 36UI, array)
				DicMock.UpdateClass(num7, num8, num9, num10, 1UI, 4US, 37UI, array)
				DicMock.UpdateClass(num10, num7, num8, num9, 4UI, 11US, 38UI, array)
				DicMock.UpdateClass(num9, num10, num7, num8, 7UI, 16US, 39UI, array)
				DicMock.UpdateClass(num8, num9, num10, num7, 10UI, 23US, 40UI, array)
				DicMock.UpdateClass(num7, num8, num9, num10, 13UI, 4US, 41UI, array)
				DicMock.UpdateClass(num10, num7, num8, num9, 0UI, 11US, 42UI, array)
				DicMock.UpdateClass(num9, num10, num7, num8, 3UI, 16US, 43UI, array)
				DicMock.UpdateClass(num8, num9, num10, num7, 6UI, 23US, 44UI, array)
				DicMock.UpdateClass(num7, num8, num9, num10, 9UI, 4US, 45UI, array)
				DicMock.UpdateClass(num10, num7, num8, num9, 12UI, 11US, 46UI, array)
				DicMock.UpdateClass(num9, num10, num7, num8, 15UI, 16US, 47UI, array)
				DicMock.UpdateClass(num8, num9, num10, num7, 2UI, 23US, 48UI, array)
				DicMock.ForgotClass(num7, num8, num9, num10, 0UI, 6US, 49UI, array)
				DicMock.ForgotClass(num10, num7, num8, num9, 7UI, 10US, 50UI, array)
				DicMock.ForgotClass(num9, num10, num7, num8, 14UI, 15US, 51UI, array)
				DicMock.ForgotClass(num8, num9, num10, num7, 5UI, 21US, 52UI, array)
				DicMock.ForgotClass(num7, num8, num9, num10, 12UI, 6US, 53UI, array)
				DicMock.ForgotClass(num10, num7, num8, num9, 3UI, 10US, 54UI, array)
				DicMock.ForgotClass(num9, num10, num7, num8, 10UI, 15US, 55UI, array)
				DicMock.ForgotClass(num8, num9, num10, num7, 1UI, 21US, 56UI, array)
				DicMock.ForgotClass(num7, num8, num9, num10, 8UI, 6US, 57UI, array)
				DicMock.ForgotClass(num10, num7, num8, num9, 15UI, 10US, 58UI, array)
				DicMock.ForgotClass(num9, num10, num7, num8, 6UI, 15US, 59UI, array)
				DicMock.ForgotClass(num8, num9, num10, num7, 13UI, 21US, 60UI, array)
				DicMock.ForgotClass(num7, num8, num9, num10, 4UI, 6US, 61UI, array)
				DicMock.ForgotClass(num10, num7, num8, num9, 11UI, 10US, 62UI, array)
				DicMock.ForgotClass(num9, num10, num7, num8, 2UI, 15US, 63UI, array)
				DicMock.ForgotClass(num8, num9, num10, num7, 9UI, 21US, 64UI, array)
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

		' Token: 0x06000026 RID: 38 RVA: 0x0000235D File Offset: 0x0000055D
		Private Shared Sub CalcClass(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + DicMock.ViewClass(uint_0 + ((uint_1 And uint_2) Or (Not uint_1 And uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + DicMock.decoratorMock(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x06000027 RID: 39 RVA: 0x00002388 File Offset: 0x00000588
		Private Shared Sub InitClass(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + DicMock.ViewClass(uint_0 + ((uint_1 And uint_3) Or (uint_2 And Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + DicMock.decoratorMock(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x06000028 RID: 40 RVA: 0x000023B3 File Offset: 0x000005B3
		Private Shared Sub UpdateClass(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + DicMock.ViewClass(uint_0 + (uint_1 Xor uint_2 Xor uint_3) + object_0(CInt(CType(uint_4, UIntPtr))) + DicMock.decoratorMock(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x000023DB File Offset: 0x000005DB
		Private Shared Sub ForgotClass(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + DicMock.ViewClass(uint_0 + (uint_2 Xor (uint_1 Or Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + DicMock.decoratorMock(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00002404 File Offset: 0x00000604
		Private Shared Function ViewClass(uint_0 As UInteger, ushort_0 As UShort) As UInteger
			Return uint_0 >> CInt((32US - ushort_0)) Or uint_0 << CInt(ushort_0)
		End Function

		' Token: 0x0600002B RID: 43 RVA: 0x00002416 File Offset: 0x00000616
		Friend Shared Function CollectClass() As Boolean
			If Not DicMock.watcherMock Then
				DicMock.CustomizeClass()
				DicMock.watcherMock = True
			End If
			Return DicMock._InvocationMock
		End Function

		' Token: 0x0600002C RID: 44 RVA: 0x00002F78 File Offset: 0x00001178
		Friend Shared Sub CustomizeClass()
			Try
				DicMock._InvocationMock = CBool(GetType(RijndaelManaged).Assembly.[GetType]("System.Security.Cryptography.CryptoConfig", False).GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.[Static] Or BindingFlags.[Public]).Invoke(Nothing, New Object(-1) {}))
			Catch
			End Try
		End Sub

		' Token: 0x0600002D RID: 45 RVA: 0x00002FD8 File Offset: 0x000011D8
		Friend Shared Function OrderClass() As SymmetricAlgorithm
			Dim result As SymmetricAlgorithm = Nothing
			If DicMock.CollectClass() Then
				Try
					Return New AesCryptoServiceProvider()
				Catch
					Return New RijndaelManaged()
				End Try
			End If
			result = New RijndaelManaged()
			Return result
		End Function

		' Token: 0x0600002E RID: 46 RVA: 0x0000242F File Offset: 0x0000062F
		Friend Shared Function LogoutClass(byte_0 As Byte()) As Byte()
			If Not DicMock.CollectClass() Then
				Return New MD5CryptoServiceProvider().ComputeHash(byte_0)
			End If
			Return DicMock.DefineClass(byte_0)
		End Function

		' Token: 0x0600002F RID: 47 RVA: 0x00003018 File Offset: 0x00001218
		Shared Function ListClass(int_0 As Integer) As Boolean
			If DicMock.modelMock.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(DicMock).Assembly.GetManifestResourceStream("065c4a4f-2a8a-4bd2-9556-820e81952a34"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 146
				array2(0) = 61
				array2(0) = 37
				array2(0) = 98
				array2(0) = 245
				array2(1) = 111
				array2(1) = 185
				array2(1) = 23
				array2(1) = 211
				array2(1) = 160
				array2(1) = 55
				array2(2) = 144
				array2(2) = 94
				array2(2) = 21
				array2(2) = 53
				array2(2) = 87
				array2(2) = 43
				array2(3) = 162
				array2(3) = 90
				array2(3) = 112
				array2(3) = 44
				array2(4) = 90
				array2(4) = 174
				array2(4) = 60
				array2(4) = 165
				array2(4) = 42
				array2(4) = 124
				array2(5) = 145
				array2(5) = 107
				array2(5) = 90
				array2(5) = 106
				array2(5) = 43
				array2(6) = 135
				array2(6) = 142
				array2(6) = 190
				array2(6) = 82
				array2(7) = 158
				array2(7) = 111
				array2(7) = 109
				array2(7) = 85
				array2(8) = 93
				array2(8) = 114
				array2(8) = 148
				array2(8) = 232
				array2(8) = 221
				array2(9) = 86
				array2(9) = 122
				array2(9) = 125
				array2(9) = 96
				array2(9) = 153
				array2(9) = 178
				array2(10) = 155
				array2(10) = 153
				array2(10) = 39
				array2(11) = 138
				array2(11) = 138
				array2(11) = 149
				array2(11) = 100
				array2(11) = 116
				array2(12) = 112
				array2(12) = 91
				array2(12) = 149
				array2(12) = 133
				array2(12) = 147
				array2(13) = 99
				array2(13) = 118
				array2(13) = 116
				array2(13) = 243
				array2(13) = 61
				array2(13) = 7
				array2(14) = 116
				array2(14) = 169
				array2(14) = 109
				array2(14) = 164
				array2(14) = 48
				array2(15) = 212
				array2(15) = 204
				array2(15) = 241
				array2(16) = 130
				array2(16) = 187
				array2(16) = 146
				array2(16) = 127
				array2(16) = 73
				array2(17) = 133
				array2(17) = 232
				array2(17) = 121
				array2(17) = 130
				array2(17) = 116
				array2(17) = 26
				array2(18) = 227
				array2(18) = 120
				array2(18) = 83
				array2(19) = 147
				array2(19) = 115
				array2(19) = 133
				array2(19) = 98
				array2(19) = 174
				array2(19) = 75
				array2(20) = 97
				array2(20) = 97
				array2(20) = 0
				array2(21) = 150
				array2(21) = 158
				array2(21) = 169
				array2(21) = 118
				array2(21) = 150
				array2(21) = 96
				array2(22) = 31
				array2(22) = 197
				array2(22) = 220
				array2(23) = 101
				array2(23) = 201
				array2(23) = 8
				array2(24) = 129
				array2(24) = 176
				array2(24) = 160
				array2(24) = 158
				array2(25) = 159
				array2(25) = 163
				array2(25) = 150
				array2(25) = 117
				array2(25) = 250
				array2(26) = 135
				array2(26) = 154
				array2(26) = 71
				array2(27) = 107
				array2(27) = 104
				array2(27) = 107
				array2(27) = 164
				array2(27) = 162
				array2(27) = 209
				array2(28) = 132
				array2(28) = 52
				array2(28) = 76
				array2(29) = 139
				array2(29) = 121
				array2(29) = 24
				array2(29) = 134
				array2(29) = 90
				array2(30) = 113
				array2(30) = 58
				array2(30) = 146
				array2(30) = 69
				array2(30) = 143
				array2(31) = 76
				array2(31) = 77
				array2(31) = 157
				array2(31) = 162
				array2(31) = 248
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 146
				array4(0) = 61
				array4(0) = 105
				array4(0) = 97
				array4(0) = 80
				array4(1) = 23
				array4(1) = 125
				array4(1) = 151
				array4(1) = 119
				array4(2) = 107
				array4(2) = 166
				array4(2) = 141
				array4(2) = 97
				array4(3) = 144
				array4(3) = 131
				array4(3) = 25
				array4(3) = 231
				array4(4) = 164
				array4(4) = 105
				array4(4) = 96
				array4(5) = 84
				array4(5) = 82
				array4(5) = 32
				array4(5) = 108
				array4(5) = 119
				array4(5) = 137
				array4(6) = 94
				array4(6) = 165
				array4(6) = 112
				array4(6) = 98
				array4(6) = 249
				array4(7) = 140
				array4(7) = 126
				array4(7) = 36
				array4(8) = 103
				array4(8) = 113
				array4(8) = 160
				array4(8) = 201
				array4(9) = 143
				array4(9) = 110
				array4(9) = 245
				array4(10) = 133
				array4(10) = 136
				array4(10) = 208
				array4(11) = 145
				array4(11) = 93
				array4(11) = 126
				array4(11) = 113
				array4(11) = 39
				array4(12) = 232
				array4(12) = 182
				array4(12) = 132
				array4(12) = 122
				array4(12) = 223
				array4(13) = 117
				array4(13) = 187
				array4(13) = 202
				array4(14) = 110
				array4(14) = 132
				array4(14) = 131
				array4(14) = 129
				array4(15) = 162
				array4(15) = 118
				array4(15) = 185
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(DicMock).Assembly.GetName().GetPublicKeyToken()
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
				Dim symmetricAlgorithm As SymmetricAlgorithm = DicMock.OrderClass()
				symmetricAlgorithm.Mode = 1
				Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.FlushFinalBlock()
				DicMock.modelMock = memoryStream.ToArray()
				memoryStream.Close()
				cryptoStream.Close()
				binaryReader.Close()
			End If
			If DicMock.specificationMock.Length = 0 Then
				DicMock.specificationMock = DicMock.PrintClass(DicMock.RestartClass(GetType(DicMock).Assembly).ToString())
			End If
			Dim num As Integer = 0
			Try
				num = BitConverter.ToInt32(New Byte() { DicMock.modelMock(int_0), DicMock.modelMock(int_0 + 1), DicMock.modelMock(int_0 + 2), DicMock.modelMock(int_0 + 3) }, 0)
			Catch
			End Try
			Try
				If DicMock.specificationMock(num) = 128 Then
					Return True
				End If
			Catch
			End Try
			Return False
		End Function

		' Token: 0x06000030 RID: 48 RVA: 0x00003AFC File Offset: 0x00001CFC
		Shared Function DisableClass(int_0 As Integer) As String
			If DicMock.expressionMock.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(DicMock).Assembly.GetManifestResourceStream("4de7c611-3aa3-4c4e-9157-9ebe415916cb"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 106
				array2(0) = 116
				array2(0) = 88
				array2(0) = 106
				array2(0) = 165
				array2(0) = 39
				array2(1) = 145
				array2(1) = 71
				array2(1) = 153
				array2(2) = 132
				array2(2) = 79
				array2(2) = 88
				array2(2) = 169
				array2(2) = 115
				array2(3) = 126
				array2(3) = 110
				array2(3) = 166
				array2(3) = 49
				array2(4) = 96
				array2(4) = 90
				array2(4) = 52
				array2(5) = 102
				array2(5) = 194
				array2(5) = 130
				array2(5) = 128
				array2(6) = 63
				array2(6) = 118
				array2(6) = 138
				array2(6) = 159
				array2(6) = 43
				array2(7) = 25
				array2(7) = 161
				array2(7) = 202
				array2(7) = 132
				array2(7) = 24
				array2(8) = 244
				array2(8) = 165
				array2(8) = 135
				array2(8) = 90
				array2(8) = 40
				array2(8) = 247
				array2(9) = 138
				array2(9) = 90
				array2(9) = 130
				array2(9) = 84
				array2(9) = 36
				array2(10) = 108
				array2(10) = 124
				array2(10) = 40
				array2(11) = 115
				array2(11) = 181
				array2(11) = 117
				array2(11) = 181
				array2(12) = 134
				array2(12) = 85
				array2(12) = 124
				array2(12) = 164
				array2(12) = 149
				array2(13) = 89
				array2(13) = 138
				array2(13) = 108
				array2(13) = 89
				array2(13) = 96
				array2(13) = 155
				array2(14) = 129
				array2(14) = 119
				array2(14) = 126
				array2(14) = 145
				array2(15) = 112
				array2(15) = 91
				array2(15) = 117
				array2(15) = 96
				array2(15) = 151
				array2(15) = 119
				array2(16) = 156
				array2(16) = 113
				array2(16) = 148
				array2(17) = 228
				array2(17) = 161
				array2(17) = 154
				array2(17) = 225
				array2(18) = 105
				array2(18) = 112
				array2(18) = 96
				array2(19) = 115
				array2(19) = 85
				array2(19) = 108
				array2(19) = 116
				array2(19) = 192
				array2(20) = 23
				array2(20) = 65
				array2(20) = 48
				array2(21) = 148
				array2(21) = 211
				array2(21) = 73
				array2(22) = 168
				array2(22) = 168
				array2(22) = 76
				array2(22) = 165
				array2(22) = 0
				array2(23) = 94
				array2(23) = 30
				array2(23) = 141
				array2(24) = 153
				array2(24) = 127
				array2(24) = 228
				array2(24) = 53
				array2(24) = 204
				array2(25) = 166
				array2(25) = 115
				array2(25) = 166
				array2(25) = 140
				array2(25) = 87
				array2(25) = 22
				array2(26) = 108
				array2(26) = 105
				array2(26) = 138
				array2(27) = 92
				array2(27) = 129
				array2(27) = 47
				array2(28) = 89
				array2(28) = 148
				array2(28) = 106
				array2(28) = 53
				array2(28) = 107
				array2(28) = 109
				array2(29) = 95
				array2(29) = 134
				array2(29) = 118
				array2(29) = 94
				array2(29) = 58
				array2(29) = 152
				array2(30) = 26
				array2(30) = 160
				array2(30) = 152
				array2(30) = 140
				array2(30) = 39
				array2(31) = 166
				array2(31) = 147
				array2(31) = 169
				array2(31) = 74
				array2(31) = 14
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 106
				array4(0) = 106
				array4(0) = 193
				array4(1) = 123
				array4(1) = 224
				array4(1) = 139
				array4(1) = 224
				array4(2) = 86
				array4(2) = 193
				array4(2) = 132
				array4(2) = 86
				array4(3) = 93
				array4(3) = 159
				array4(3) = 118
				array4(3) = 120
				array4(3) = 175
				array4(4) = 147
				array4(4) = 128
				array4(4) = 147
				array4(4) = 158
				array4(4) = 236
				array4(5) = 121
				array4(5) = 102
				array4(5) = 154
				array4(5) = 70
				array4(5) = 165
				array4(6) = 16
				array4(6) = 128
				array4(6) = 130
				array4(6) = 192
				array4(7) = 170
				array4(7) = 83
				array4(7) = 154
				array4(7) = 79
				array4(8) = 132
				array4(8) = 135
				array4(8) = 168
				array4(8) = 141
				array4(8) = 31
				array4(8) = 191
				array4(9) = 11
				array4(9) = 108
				array4(9) = 132
				array4(9) = 85
				array4(10) = 123
				array4(10) = 92
				array4(10) = 60
				array4(10) = 160
				array4(10) = 116
				array4(10) = 166
				array4(11) = 146
				array4(11) = 116
				array4(11) = 248
				array4(12) = 159
				array4(12) = 177
				array4(12) = 218
				array4(12) = 40
				array4(12) = 88
				array4(13) = 129
				array4(13) = 110
				array4(13) = 0
				array4(14) = 74
				array4(14) = 132
				array4(14) = 170
				array4(14) = 108
				array4(15) = 70
				array4(15) = 86
				array4(15) = 91
				array4(15) = 149
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(DicMock).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = DicMock.OrderClass()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					DicMock.expressionMock = memoryStream.ToArray()
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = DicMock.expressionMock
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
				DicMock.expressionMock = array6
			End If
			Dim num17 As Integer = BitConverter.ToInt32(DicMock.expressionMock, int_0)
			Try
				Dim array7 As Byte() = New Byte(num17 - 1) {}
				Array.Copy(DicMock.expressionMock, int_0 + 4, array7, 0, num17)
				Return Encoding.Unicode.GetString(array7, 0, array7.Length)
			Catch
			End Try
			Return ""
		End Function

		' Token: 0x06000031 RID: 49 RVA: 0x0000482C File Offset: 0x00002A2C
		Shared Function FillClass(int_0 As Integer) As String
			If DicMock.merchantMock.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(DicMock).Assembly.GetManifestResourceStream("4de7c611-3aa3-4c4e-9157-9ebe415916cb"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 106
				array2(0) = 116
				array2(0) = 88
				array2(0) = 106
				array2(0) = 165
				array2(0) = 39
				array2(1) = 145
				array2(1) = 71
				array2(1) = 153
				array2(2) = 132
				array2(2) = 79
				array2(2) = 88
				array2(2) = 169
				array2(2) = 115
				array2(3) = 126
				array2(3) = 110
				array2(3) = 166
				array2(3) = 49
				array2(4) = 96
				array2(4) = 90
				array2(4) = 52
				array2(5) = 102
				array2(5) = 194
				array2(5) = 130
				array2(5) = 128
				array2(6) = 63
				array2(6) = 118
				array2(6) = 138
				array2(6) = 159
				array2(6) = 43
				array2(7) = 25
				array2(7) = 161
				array2(7) = 202
				array2(7) = 132
				array2(7) = 24
				array2(8) = 244
				array2(8) = 165
				array2(8) = 135
				array2(8) = 90
				array2(8) = 40
				array2(8) = 247
				array2(9) = 138
				array2(9) = 90
				array2(9) = 130
				array2(9) = 84
				array2(9) = 36
				array2(10) = 108
				array2(10) = 124
				array2(10) = 40
				array2(11) = 115
				array2(11) = 181
				array2(11) = 117
				array2(11) = 181
				array2(12) = 134
				array2(12) = 85
				array2(12) = 124
				array2(12) = 164
				array2(12) = 149
				array2(13) = 89
				array2(13) = 138
				array2(13) = 108
				array2(13) = 89
				array2(13) = 96
				array2(13) = 155
				array2(14) = 129
				array2(14) = 119
				array2(14) = 126
				array2(14) = 145
				array2(15) = 112
				array2(15) = 91
				array2(15) = 117
				array2(15) = 96
				array2(15) = 151
				array2(15) = 119
				array2(16) = 156
				array2(16) = 113
				array2(16) = 148
				array2(17) = 228
				array2(17) = 161
				array2(17) = 154
				array2(17) = 225
				array2(18) = 105
				array2(18) = 112
				array2(18) = 96
				array2(19) = 115
				array2(19) = 85
				array2(19) = 108
				array2(19) = 116
				array2(19) = 192
				array2(20) = 23
				array2(20) = 65
				array2(20) = 48
				array2(21) = 148
				array2(21) = 211
				array2(21) = 73
				array2(22) = 168
				array2(22) = 168
				array2(22) = 76
				array2(22) = 165
				array2(22) = 0
				array2(23) = 94
				array2(23) = 30
				array2(23) = 141
				array2(24) = 153
				array2(24) = 127
				array2(24) = 228
				array2(24) = 53
				array2(24) = 204
				array2(25) = 166
				array2(25) = 115
				array2(25) = 166
				array2(25) = 140
				array2(25) = 87
				array2(25) = 22
				array2(26) = 108
				array2(26) = 105
				array2(26) = 138
				array2(27) = 92
				array2(27) = 129
				array2(27) = 47
				array2(28) = 89
				array2(28) = 148
				array2(28) = 106
				array2(28) = 53
				array2(28) = 107
				array2(28) = 109
				array2(29) = 95
				array2(29) = 134
				array2(29) = 118
				array2(29) = 94
				array2(29) = 58
				array2(29) = 152
				array2(30) = 26
				array2(30) = 160
				array2(30) = 152
				array2(30) = 140
				array2(30) = 39
				array2(31) = 166
				array2(31) = 147
				array2(31) = 169
				array2(31) = 74
				array2(31) = 14
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 106
				array4(0) = 106
				array4(0) = 193
				array4(1) = 123
				array4(1) = 224
				array4(1) = 139
				array4(1) = 224
				array4(2) = 86
				array4(2) = 193
				array4(2) = 132
				array4(2) = 86
				array4(3) = 93
				array4(3) = 159
				array4(3) = 118
				array4(3) = 120
				array4(3) = 175
				array4(4) = 147
				array4(4) = 128
				array4(4) = 147
				array4(4) = 158
				array4(4) = 236
				array4(5) = 121
				array4(5) = 102
				array4(5) = 154
				array4(5) = 70
				array4(5) = 165
				array4(6) = 16
				array4(6) = 128
				array4(6) = 130
				array4(6) = 192
				array4(7) = 170
				array4(7) = 83
				array4(7) = 154
				array4(7) = 79
				array4(8) = 132
				array4(8) = 135
				array4(8) = 168
				array4(8) = 141
				array4(8) = 31
				array4(8) = 191
				array4(9) = 11
				array4(9) = 108
				array4(9) = 132
				array4(9) = 85
				array4(10) = 123
				array4(10) = 92
				array4(10) = 60
				array4(10) = 160
				array4(10) = 116
				array4(10) = 166
				array4(11) = 146
				array4(11) = 116
				array4(11) = 248
				array4(12) = 159
				array4(12) = 177
				array4(12) = 218
				array4(12) = 40
				array4(12) = 88
				array4(13) = 129
				array4(13) = 110
				array4(13) = 0
				array4(14) = 74
				array4(14) = 132
				array4(14) = 170
				array4(14) = 108
				array4(15) = 70
				array4(15) = 86
				array4(15) = 91
				array4(15) = 149
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(DicMock).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = DicMock.OrderClass()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					DicMock.merchantMock = memoryStream.ToArray()
					If DicMock.merchantMock.Length > 0 Then
						DicMock._MapperMock = New String(DicMock.merchantMock.Length / 4 + 1 - 1) {}
						DicMock._ErrorMock = New Integer(DicMock.merchantMock.Length / 4 + 1 - 1) {}
					End If
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = DicMock.merchantMock
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
				DicMock.merchantMock = array6
				If DicMock.merchantMock.Length > 0 Then
					DicMock._MapperMock = New String(DicMock.merchantMock.Length / 4 + 1 - 1) {}
					DicMock._ErrorMock = New Integer(DicMock.merchantMock.Length / 4 + 1 - 1) {}
				End If
				Dim assembly As Assembly = GetType(DicMock).Assembly
				If IntPtr.Size = 4 Then
					DicMock._TokenizerMock = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt32()
				End If
				DicMock.m_SystemMock = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
			End If
			Dim num16 As Integer = int_0 / 4
			If DicMock._ErrorMock(num16) > 0 Then
				Return CType(DicMock._MapperMock, String())(DicMock._ErrorMock(num16))
			End If
			Dim num17 As Integer = BitConverter.ToInt32(DicMock.merchantMock, int_0)
			If DicMock.identifierMock = IntPtr.Zero Then
				DicMock.identifierMock = DicMock.OpenProcess(16UI, 1, CUInt(Process.GetCurrentProcess().Id))
			End If
			Dim array7 As Byte() = New Byte(3) {}
			If IntPtr.Size = 4 Then
				DicMock.ReadProcessMemory(DicMock.identifierMock, New IntPtr(DicMock._TokenizerMock + num17), array7, 4UI, DicMock.registryMock)
			Else
				DicMock.ReadProcessMemory(DicMock.identifierMock, New IntPtr(DicMock.m_SystemMock + CLng(num17)), array7, 4UI, DicMock.registryMock)
			End If
			Dim num18 As Integer = BitConverter.ToInt32(array7, 0)
			array7 = New Byte(num18 - 1) {}
			If IntPtr.Size = 4 Then
				DicMock.ReadProcessMemory(DicMock.identifierMock, New IntPtr(DicMock._TokenizerMock + num17 + 4), array7, Convert.ToUInt32(num18), DicMock.registryMock)
			Else
				DicMock.ReadProcessMemory(DicMock.identifierMock, New IntPtr(DicMock.m_SystemMock + CLng(num17) + 4L), array7, Convert.ToUInt32(num18), DicMock.registryMock)
			End If
			Dim array8 As Byte() = DicMock.FlushClass(array7)
			Dim [string] As String = Encoding.Unicode.GetString(array8, 0, array8.Length)
			DicMock._ErrorMock(num16) = DicMock._ProxyMock
			CType(DicMock._MapperMock, String())(DicMock._ProxyMock) = [string]
			DicMock._ProxyMock += 1
			Return [string]
		End Function

		' Token: 0x06000032 RID: 50 RVA: 0x00005690 File Offset: 0x00003890
		Friend Shared Function ResolveClass(string_0 As String) As String
			Dim array As Byte() = Convert.FromBase64String(string_0)
			Return Encoding.Unicode.GetString(array, 0, array.Length)
		End Function

		' Token: 0x06000033 RID: 51
		Private Declare Function VirtualProtect Lib "kernel32.dll" (intptr_0 As IntPtr, int_0 As Integer, int_1 As Integer, ByRef int_2 As Integer) As Integer

		' Token: 0x06000034 RID: 52 RVA: 0x000056B4 File Offset: 0x000038B4
		<DicMock.RoleMock(GetType(DicMock.RoleMock.ProducerMock(Of Object)()))>
		Shared Sub PostClass()
			If Not DicMock.definitionMock Then
				DicMock.definitionMock = True
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(DicMock).Assembly.GetManifestResourceStream("b160fd9c-b548-48af-8188-a8509f57c3d0"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 90
				array2(0) = 114
				array2(0) = 163
				array2(0) = 90
				array2(1) = 185
				array2(1) = 121
				array2(1) = 163
				array2(1) = 185
				array2(2) = 129
				array2(2) = 163
				array2(2) = 198
				array2(2) = 143
				array2(2) = 22
				array2(2) = 38
				array2(2) = 129
				array2(3) = 244
				array2(3) = 50
				array2(3) = 211
				array2(3) = 123
				array2(3) = 93
				array2(3) = 164
				array2(3) = 244
				array2(4) = 103
				array2(4) = 124
				array2(4) = 130
				array2(4) = 153
				array2(4) = 128
				array2(4) = 103
				array2(5) = 2
				array2(5) = 87
				array2(5) = 103
				array2(5) = 2
				array2(6) = 36
				array2(6) = 218
				array2(6) = 49
				array2(6) = 158
				array2(6) = 112
				array2(6) = 36
				array2(7) = 246
				array2(7) = 150
				array2(7) = 140
				array2(7) = 246
				array2(8) = 93
				array2(8) = 106
				array2(8) = 111
				array2(8) = 93
				array2(9) = 59
				array2(9) = 148
				array2(9) = 93
				array2(9) = 125
				array2(9) = 59
				array2(10) = 31
				array2(10) = 199
				array2(10) = 205
				array2(10) = 31
				array2(11) = 46
				array2(11) = 164
				array2(11) = 153
				array2(11) = 172
				array2(11) = 98
				array2(11) = 183
				array2(11) = 46
				array2(12) = 238
				array2(12) = 187
				array2(12) = 110
				array2(12) = 128
				array2(12) = 158
				array2(12) = 238
				array2(13) = 174
				array2(13) = 142
				array2(13) = 140
				array2(13) = 62
				array2(13) = 174
				array2(14) = 85
				array2(14) = 89
				array2(14) = 115
				array2(14) = 122
				array2(14) = 94
				array2(14) = 85
				array2(15) = 219
				array2(15) = 180
				array2(15) = 150
				array2(15) = 103
				array2(15) = 119
				array2(15) = 219
				array2(16) = 217
				array2(16) = 96
				array2(16) = 106
				array2(16) = 107
				array2(16) = 150
				array2(16) = 217
				array2(17) = 33
				array2(17) = 136
				array2(17) = 131
				array2(17) = 119
				array2(17) = 143
				array2(17) = 33
				array2(18) = 69
				array2(18) = 146
				array2(18) = 167
				array2(18) = 69
				array2(19) = 130
				array2(19) = 221
				array2(19) = 130
				array2(19) = 92
				array2(19) = 245
				array2(19) = 74
				array2(19) = 130
				array2(20) = 169
				array2(20) = 148
				array2(20) = 129
				array2(20) = 150
				array2(20) = 39
				array2(20) = 169
				array2(21) = 232
				array2(21) = 138
				array2(21) = 100
				array2(21) = 232
				array2(22) = 210
				array2(22) = 25
				array2(22) = 91
				array2(22) = 86
				array2(22) = 158
				array2(22) = 210
				array2(23) = 200
				array2(23) = 135
				array2(23) = 86
				array2(23) = 200
				array2(24) = 44
				array2(24) = 114
				array2(24) = 117
				array2(24) = 77
				array2(24) = 150
				array2(24) = 92
				array2(24) = 44
				array2(25) = 253
				array2(25) = 86
				array2(25) = 97
				array2(25) = 86
				array2(25) = 74
				array2(25) = 253
				array2(26) = 95
				array2(26) = 222
				array2(26) = 146
				array2(26) = 95
				array2(27) = 40
				array2(27) = 103
				array2(27) = 77
				array2(27) = 174
				array2(27) = 40
				array2(28) = 1
				array2(28) = 106
				array2(28) = 83
				array2(28) = 1
				array2(29) = 2
				array2(29) = 112
				array2(29) = 108
				array2(29) = 2
				array2(30) = 251
				array2(30) = 39
				array2(30) = 136
				array2(30) = 251
				array2(31) = 172
				array2(31) = 104
				array2(31) = 123
				array2(31) = 113
				array2(31) = 120
				array2(31) = 83
				array2(31) = 172
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 114
				array4(0) = 163
				array4(0) = 181
				array4(0) = 88
				array4(0) = 12
				array4(1) = 172
				array4(1) = 163
				array4(1) = 198
				array4(1) = 158
				array4(1) = 110
				array4(1) = 57
				array4(2) = 38
				array4(2) = 96
				array4(2) = 202
				array4(3) = 164
				array4(3) = 149
				array4(3) = 128
				array4(3) = 206
				array4(4) = 32
				array4(4) = 81
				array4(4) = 172
				array4(4) = 104
				array4(4) = 134
				array4(4) = 199
				array4(5) = 134
				array4(5) = 87
				array4(5) = 93
				array4(6) = 128
				array4(6) = 114
				array4(6) = 54
				array4(6) = 71
				array4(7) = 196
				array4(7) = 124
				array4(7) = 132
				array4(7) = 30
				array4(7) = 153
				array4(8) = 106
				array4(8) = 136
				array4(8) = 220
				array4(9) = 146
				array4(9) = 110
				array4(9) = 107
				array4(9) = 22
				array4(10) = 148
				array4(10) = 99
				array4(10) = 166
				array4(10) = 91
				array4(10) = 164
				array4(10) = 155
				array4(11) = 158
				array4(11) = 165
				array4(11) = 210
				array4(11) = 254
				array4(12) = 125
				array4(12) = 174
				array4(12) = 113
				array4(13) = 128
				array4(13) = 135
				array4(13) = 180
				array4(13) = 140
				array4(13) = 203
				array4(14) = 51
				array4(14) = 135
				array4(14) = 89
				array4(14) = 138
				array4(14) = 111
				array4(15) = 94
				array4(15) = 76
				array4(15) = 150
				array4(15) = 106
				Dim array5 As Byte() = array4
				Array.Reverse(array5)
				Dim publicKeyToken As Byte() = GetType(DicMock).Assembly.GetName().GetPublicKeyToken()
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
				Dim assembly As Assembly = GetType(DicMock).Assembly
				intptr_ = DicMock.OpenProcess(56UI, 1, CUInt(Process.GetCurrentProcess().Id))
				DicMock.m_SystemMock = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
				Dim zero As IntPtr = IntPtr.Zero
				Dim int_ As Integer = 0
				Dim num16 As Integer = binaryReader.ReadInt32()
				binaryReader.ReadInt32()
				For m As Integer = 0 To num16 - 1
					Dim intPtr As IntPtr = New IntPtr(DicMock.m_SystemMock + CLng(binaryReader.ReadInt32()))
					DicMock.VirtualProtect(intPtr, 4, 4, int_)
					If IntPtr.Size = 4 Then
						DicMock.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					Else
						DicMock.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					End If
					DicMock.VirtualProtect(intPtr, 4, int_, int_)
				Next
				Try
					While binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L
						Dim num17 As Integer = binaryReader.ReadInt32()
						Dim intptr_2 As IntPtr = New IntPtr(DicMock.m_SystemMock + CLng(num17))
						Dim num18 As Integer = binaryReader.ReadInt32()
						DicMock.VirtualProtect(intptr_2, num18 * 4, 4, int_)
						For n As Integer = 0 To num18 - 1
							Marshal.WriteInt32(New IntPtr(intptr_2.ToInt64() + CLng((n * 4))), binaryReader.ReadInt32())
						Next
						DicMock.VirtualProtect(intptr_2, num18 * 4, int_, int_)
					End While
					DicMock.CloseHandle(intptr_)
				Catch
				End Try
			End If
		End Sub

		' Token: 0x06000035 RID: 53 RVA: 0x00006688 File Offset: 0x00004888
		Friend Shared Function RestartClass(assembly_0 As Assembly) As Object
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

		' Token: 0x06000036 RID: 54
		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, <[In]()> <Out()> byte_0 As Byte(), uint_0 As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef intptr_2 As IntPtr) As Integer

		' Token: 0x06000037 RID: 55
		Private Declare Function ReadProcessMemory Lib "kernel32.dll" (intptr_0 As IntPtr, intptr_1 As IntPtr, <[In]()> <Out()> byte_0 As Byte(), uint_0 As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef intptr_2 As IntPtr) As Integer

		' Token: 0x06000038 RID: 56
		Private Declare Function OpenProcess Lib "kernel32.dll" (uint_0 As UInteger, int_0 As Integer, uint_1 As UInteger) As IntPtr

		' Token: 0x06000039 RID: 57
		Private Declare Function CloseHandle Lib "kernel32.dll" (intptr_0 As IntPtr) As Integer

		' Token: 0x0600003A RID: 58 RVA: 0x00006798 File Offset: 0x00004998
		Private Shared Function PrintClass(string_0 As String) As Byte()
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

		' Token: 0x0600003B RID: 59 RVA: 0x00006800 File Offset: 0x00004A00
		Private Shared Function FlushClass(byte_0 As Byte()) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = DicMock.OrderClass()
			symmetricAlgorithm.Key = New Byte() { 64, 107, 18, 142, 156, 80, 157, 141, 31, 249, 20, 206, 118, 185, 192, 77, 65, 243, 51, 20, 245, 230, 97, 7, 10, 9, 215, 59, 121, 241, 185, 105 }
			symmetricAlgorithm.IV = New Byte() { 240, 57, 20, 81, 228, 0, 53, 182, 2, 140, 140, 77, 33, 62, 237, 222 }
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), 1)
			cryptoStream.Write(byte_0, 0, byte_0.Length)
			cryptoStream.Close()
			Return memoryStream.ToArray()
		End Function

		' Token: 0x0600003C RID: 60 RVA: 0x0000244A File Offset: 0x0000064A
		Private Function TestClass() As Byte()
			Return Nothing
		End Function

		' Token: 0x0600003D RID: 61 RVA: 0x0000244A File Offset: 0x0000064A
		Private Function InstantiateClass() As Byte()
			Return Nothing
		End Function

		' Token: 0x0600003E RID: 62 RVA: 0x0000244A File Offset: 0x0000064A
		Private Function PublishClass() As Byte()
			Return Nothing
		End Function

		' Token: 0x0600003F RID: 63 RVA: 0x0000244A File Offset: 0x0000064A
		Private Function CountClass() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000040 RID: 64 RVA: 0x0000244A File Offset: 0x0000064A
		Private Function ManageClass() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000041 RID: 65 RVA: 0x0000244A File Offset: 0x0000064A
		Private Function ChangeClass() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000042 RID: 66 RVA: 0x00006870 File Offset: 0x00004A70
		Friend Function SearchClass() As Byte()
			Dim text As String = "{11111-22222-40001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000043 RID: 67 RVA: 0x000068B0 File Offset: 0x00004AB0
		Friend Function CreateClass() As Byte()
			Dim text As String = "{11111-22222-40001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000044 RID: 68 RVA: 0x000068F0 File Offset: 0x00004AF0
		Friend Function CalculateClass() As Byte()
			Dim text As String = "{11111-22222-50001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000045 RID: 69 RVA: 0x00006930 File Offset: 0x00004B30
		Friend Function SetupClass() As Byte()
			Dim text As String = "{11111-22222-50001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000046 RID: 70 RVA: 0x00006970 File Offset: 0x00004B70
		Friend Function SelectClass() As Byte()
			Dim text As String = "{11111-22222-60001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000047 RID: 71 RVA: 0x000069B0 File Offset: 0x00004BB0
		Friend Function WriteClass() As Byte()
			Dim text As String = "{11111-22222-60001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000048 RID: 72 RVA: 0x000069F0 File Offset: 0x00004BF0
		Friend Shared Function RunClass(string_0 As String, string_1 As String) As String
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(string_0)
			Dim array As Byte() = bytes
			Dim key As Byte() = New Byte() { 82, 102, 104, 110, 32, 77, 24, 34, 118, 181, 51, 17, 18, 51, 12, 109, 10, 32, 77, 24, 34, 158, 161, 41, 97, 28, 118, 181, 5, 25, 1, 88 }
			Dim iv As Byte() = DicMock.LogoutClass(Encoding.Unicode.GetBytes(string_1))
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = DicMock.OrderClass()
			symmetricAlgorithm.Key = key
			symmetricAlgorithm.IV = iv
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), 1)
			cryptoStream.Write(array, 0, array.Length)
			cryptoStream.Close()
			Return Convert.ToBase64String(memoryStream.ToArray())
		End Function

		' Token: 0x04000016 RID: 22
		Private Shared watcherMock As Boolean

		' Token: 0x04000017 RID: 23
		Private Shared specificationMock As Byte()

		' Token: 0x04000018 RID: 24
		Private Shared merchantMock As Byte()

		' Token: 0x04000019 RID: 25
		Private Shared registryMock As IntPtr

		' Token: 0x0400001A RID: 26
		Private Shared _ProxyMock As Integer

		' Token: 0x0400001B RID: 27
		Private Shared _TokenizerMock As Integer

		' Token: 0x0400001C RID: 28
		Private Shared m_SystemMock As Long

		' Token: 0x0400001D RID: 29
		Private Shared _ErrorMock As Integer()

		' Token: 0x0400001E RID: 30
		Private Shared _InvocationMock As Boolean

		' Token: 0x0400001F RID: 31
		Private Shared _MapperMock As String()

		' Token: 0x04000020 RID: 32
		Private Shared expressionMock As Byte()

		' Token: 0x04000021 RID: 33
		Private Shared identifierMock As IntPtr

		' Token: 0x04000022 RID: 34
		Private Shared modelMock As Byte()

		' Token: 0x04000023 RID: 35
		Private Shared decoratorMock As UInteger() = New UInteger() { 3614090360UI, 3905402710UI, 606105819UI, 3250441966UI, 4118548399UI, 1200080426UI, 2821735955UI, 4249261313UI, 1770035416UI, 2336552879UI, 4294925233UI, 2304563134UI, 1804603682UI, 4254626195UI, 2792965006UI, 1236535329UI, 4129170786UI, 3225465664UI, 643717713UI, 3921069994UI, 3593408605UI, 38016083UI, 3634488961UI, 3889429448UI, 568446438UI, 3275163606UI, 4107603335UI, 1163531501UI, 2850285829UI, 4243563512UI, 1735328473UI, 2368359562UI, 4294588738UI, 2272392833UI, 1839030562UI, 4259657740UI, 2763975236UI, 1272893353UI, 4139469664UI, 3200236656UI, 681279174UI, 3936430074UI, 3572445317UI, 76029189UI, 3654602809UI, 3873151461UI, 530742520UI, 3299628645UI, 4096336452UI, 1126891415UI, 2878612391UI, 4237533241UI, 1700485571UI, 2399980690UI, 4293915773UI, 2240044497UI, 1873313359UI, 4264355552UI, 2734768916UI, 1309151649UI, 4149444226UI, 3174756917UI, 718787259UI, 3951481745UI }

		' Token: 0x04000024 RID: 36
		Private Shared definitionMock As Boolean

		' Token: 0x0200000E RID: 14
		Friend Class RoleMock
			Inherits Attribute

			' Token: 0x0600004A RID: 74 RVA: 0x0000244D File Offset: 0x0000064D
			<DicMock.RoleMock(GetType(DicMock.RoleMock.ProducerMock(Of Object)()))>
			Public Sub New(object_0 As Object)
			End Sub

			' Token: 0x0200000F RID: 15
			Friend Class ProducerMock(Of T)
			End Class
		End Class

		' Token: 0x02000010 RID: 16
		<Flags()>
		Private Enum CandidateMock
		End Enum
	End Class
End Namespace
