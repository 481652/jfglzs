Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Namespace uninstall.Internal

	Friend Class WatcherWrapper
	
		Shared Sub New()
			WatcherWrapper.utilsWrapper = False
			WatcherWrapper._ProccesorWrapper = False
			WatcherWrapper.annotationWrapper = New Byte(-1) {}
			WatcherWrapper.m_PredicateWrapper = New Byte(-1) {}
			WatcherWrapper._ClassWrapper = New Byte(-1) {}
			WatcherWrapper._StructWrapper = New Byte(-1) {}
			WatcherWrapper.observerWrapper = IntPtr.Zero
			WatcherWrapper._RoleWrapper = IntPtr.Zero
			WatcherWrapper.pageWrapper = New String(-1) {}
			WatcherWrapper._AttrWrapper = New Integer(-1) {}
			WatcherWrapper.m_DescriptorWrapper = 1
			WatcherWrapper.m_SchemaWrapper = 0L
			WatcherWrapper.interceptorWrapper = 0
			WatcherWrapper._IndexerWrapper = False
		End Sub

	
		Private Sub method_0()
		End Sub

	
		Friend Shared Function CalculateConsumer(object_0 As Object) As Byte()
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
				WatcherWrapper.ListConsumer(num7, num8, num9, num10, 0UI, 7US, 1UI, array)
				WatcherWrapper.ListConsumer(num10, num7, num8, num9, 1UI, 12US, 2UI, array)
				WatcherWrapper.ListConsumer(num9, num10, num7, num8, 2UI, 17US, 3UI, array)
				WatcherWrapper.ListConsumer(num8, num9, num10, num7, 3UI, 22US, 4UI, array)
				WatcherWrapper.ListConsumer(num7, num8, num9, num10, 4UI, 7US, 5UI, array)
				WatcherWrapper.ListConsumer(num10, num7, num8, num9, 5UI, 12US, 6UI, array)
				WatcherWrapper.ListConsumer(num9, num10, num7, num8, 6UI, 17US, 7UI, array)
				WatcherWrapper.ListConsumer(num8, num9, num10, num7, 7UI, 22US, 8UI, array)
				WatcherWrapper.ListConsumer(num7, num8, num9, num10, 8UI, 7US, 9UI, array)
				WatcherWrapper.ListConsumer(num10, num7, num8, num9, 9UI, 12US, 10UI, array)
				WatcherWrapper.ListConsumer(num9, num10, num7, num8, 10UI, 17US, 11UI, array)
				WatcherWrapper.ListConsumer(num8, num9, num10, num7, 11UI, 22US, 12UI, array)
				WatcherWrapper.ListConsumer(num7, num8, num9, num10, 12UI, 7US, 13UI, array)
				WatcherWrapper.ListConsumer(num10, num7, num8, num9, 13UI, 12US, 14UI, array)
				WatcherWrapper.ListConsumer(num9, num10, num7, num8, 14UI, 17US, 15UI, array)
				WatcherWrapper.ListConsumer(num8, num9, num10, num7, 15UI, 22US, 16UI, array)
				WatcherWrapper.ReflectConsumer(num7, num8, num9, num10, 1UI, 5US, 17UI, array)
				WatcherWrapper.ReflectConsumer(num10, num7, num8, num9, 6UI, 9US, 18UI, array)
				WatcherWrapper.ReflectConsumer(num9, num10, num7, num8, 11UI, 14US, 19UI, array)
				WatcherWrapper.ReflectConsumer(num8, num9, num10, num7, 0UI, 20US, 20UI, array)
				WatcherWrapper.ReflectConsumer(num7, num8, num9, num10, 5UI, 5US, 21UI, array)
				WatcherWrapper.ReflectConsumer(num10, num7, num8, num9, 10UI, 9US, 22UI, array)
				WatcherWrapper.ReflectConsumer(num9, num10, num7, num8, 15UI, 14US, 23UI, array)
				WatcherWrapper.ReflectConsumer(num8, num9, num10, num7, 4UI, 20US, 24UI, array)
				WatcherWrapper.ReflectConsumer(num7, num8, num9, num10, 9UI, 5US, 25UI, array)
				WatcherWrapper.ReflectConsumer(num10, num7, num8, num9, 14UI, 9US, 26UI, array)
				WatcherWrapper.ReflectConsumer(num9, num10, num7, num8, 3UI, 14US, 27UI, array)
				WatcherWrapper.ReflectConsumer(num8, num9, num10, num7, 8UI, 20US, 28UI, array)
				WatcherWrapper.ReflectConsumer(num7, num8, num9, num10, 13UI, 5US, 29UI, array)
				WatcherWrapper.ReflectConsumer(num10, num7, num8, num9, 2UI, 9US, 30UI, array)
				WatcherWrapper.ReflectConsumer(num9, num10, num7, num8, 7UI, 14US, 31UI, array)
				WatcherWrapper.ReflectConsumer(num8, num9, num10, num7, 12UI, 20US, 32UI, array)
				WatcherWrapper.SetConsumer(num7, num8, num9, num10, 5UI, 4US, 33UI, array)
				WatcherWrapper.SetConsumer(num10, num7, num8, num9, 8UI, 11US, 34UI, array)
				WatcherWrapper.SetConsumer(num9, num10, num7, num8, 11UI, 16US, 35UI, array)
				WatcherWrapper.SetConsumer(num8, num9, num10, num7, 14UI, 23US, 36UI, array)
				WatcherWrapper.SetConsumer(num7, num8, num9, num10, 1UI, 4US, 37UI, array)
				WatcherWrapper.SetConsumer(num10, num7, num8, num9, 4UI, 11US, 38UI, array)
				WatcherWrapper.SetConsumer(num9, num10, num7, num8, 7UI, 16US, 39UI, array)
				WatcherWrapper.SetConsumer(num8, num9, num10, num7, 10UI, 23US, 40UI, array)
				WatcherWrapper.SetConsumer(num7, num8, num9, num10, 13UI, 4US, 41UI, array)
				WatcherWrapper.SetConsumer(num10, num7, num8, num9, 0UI, 11US, 42UI, array)
				WatcherWrapper.SetConsumer(num9, num10, num7, num8, 3UI, 16US, 43UI, array)
				WatcherWrapper.SetConsumer(num8, num9, num10, num7, 6UI, 23US, 44UI, array)
				WatcherWrapper.SetConsumer(num7, num8, num9, num10, 9UI, 4US, 45UI, array)
				WatcherWrapper.SetConsumer(num10, num7, num8, num9, 12UI, 11US, 46UI, array)
				WatcherWrapper.SetConsumer(num9, num10, num7, num8, 15UI, 16US, 47UI, array)
				WatcherWrapper.SetConsumer(num8, num9, num10, num7, 2UI, 23US, 48UI, array)
				WatcherWrapper.RunConsumer(num7, num8, num9, num10, 0UI, 6US, 49UI, array)
				WatcherWrapper.RunConsumer(num10, num7, num8, num9, 7UI, 10US, 50UI, array)
				WatcherWrapper.RunConsumer(num9, num10, num7, num8, 14UI, 15US, 51UI, array)
				WatcherWrapper.RunConsumer(num8, num9, num10, num7, 5UI, 21US, 52UI, array)
				WatcherWrapper.RunConsumer(num7, num8, num9, num10, 12UI, 6US, 53UI, array)
				WatcherWrapper.RunConsumer(num10, num7, num8, num9, 3UI, 10US, 54UI, array)
				WatcherWrapper.RunConsumer(num9, num10, num7, num8, 10UI, 15US, 55UI, array)
				WatcherWrapper.RunConsumer(num8, num9, num10, num7, 1UI, 21US, 56UI, array)
				WatcherWrapper.RunConsumer(num7, num8, num9, num10, 8UI, 6US, 57UI, array)
				WatcherWrapper.RunConsumer(num10, num7, num8, num9, 15UI, 10US, 58UI, array)
				WatcherWrapper.RunConsumer(num9, num10, num7, num8, 6UI, 15US, 59UI, array)
				WatcherWrapper.RunConsumer(num8, num9, num10, num7, 13UI, 21US, 60UI, array)
				WatcherWrapper.RunConsumer(num7, num8, num9, num10, 4UI, 6US, 61UI, array)
				WatcherWrapper.RunConsumer(num10, num7, num8, num9, 11UI, 10US, 62UI, array)
				WatcherWrapper.RunConsumer(num9, num10, num7, num8, 2UI, 15US, 63UI, array)
				WatcherWrapper.RunConsumer(num8, num9, num10, num7, 9UI, 21US, 64UI, array)
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

	
		Private Shared Sub ListConsumer(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WatcherWrapper.PostConsumer(uint_0 + ((uint_1 And uint_2) Or (Not uint_1 And uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + WatcherWrapper.m_BroadcasterWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub ReflectConsumer(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WatcherWrapper.PostConsumer(uint_0 + ((uint_1 And uint_3) Or (uint_2 And Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + WatcherWrapper.m_BroadcasterWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub SetConsumer(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WatcherWrapper.PostConsumer(uint_0 + (uint_1 Xor uint_2 Xor uint_3) + object_0(CInt(CType(uint_4, UIntPtr))) + WatcherWrapper.m_BroadcasterWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Sub RunConsumer(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, object_0 As Object)
			uint_0 = uint_1 + WatcherWrapper.PostConsumer(uint_0 + (uint_2 Xor (uint_1 Or Not uint_3)) + object_0(CInt(CType(uint_4, UIntPtr))) + WatcherWrapper.m_BroadcasterWrapper(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

	
		Private Shared Function PostConsumer(uint_0 As UInteger, ushort_0 As UShort) As UInteger
			Return uint_0 >> CInt((32US - ushort_0)) Or uint_0 << CInt(ushort_0)
		End Function

	
		Friend Shared Function PrintConsumer() As Boolean
			If Not WatcherWrapper.utilsWrapper Then
				WatcherWrapper.MapConsumer()
				WatcherWrapper.utilsWrapper = True
			End If
			Return WatcherWrapper._ProccesorWrapper
		End Function

	
		Friend Shared Sub MapConsumer()
			Try
				WatcherWrapper._ProccesorWrapper = CBool(GetType(RijndaelManaged).Assembly.[GetType]("System.Security.Cryptography.CryptoConfig", False).GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.[Static] Or BindingFlags.[Public]).Invoke(Nothing, New Object(-1) {}))
			Catch
			End Try
		End Sub

	
		Friend Shared Function LogoutConsumer() As SymmetricAlgorithm
			Dim result As SymmetricAlgorithm = Nothing
			If WatcherWrapper.PrintConsumer() Then
				Try
					Return New AesCryptoServiceProvider()
				Catch
					Return New RijndaelManaged()
				End Try
			End If
			result = New RijndaelManaged()
			Return result
		End Function

	
		Friend Shared Function RestartConsumer(byte_0 As Byte()) As Byte()
			If Not WatcherWrapper.PrintConsumer() Then
				Return New MD5CryptoServiceProvider().ComputeHash(byte_0)
			End If
			Return WatcherWrapper.CalculateConsumer(byte_0)
		End Function

	
		Shared Function DestroyConsumer(int_0 As Integer) As Boolean
			If WatcherWrapper.m_PredicateWrapper.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WatcherWrapper).Assembly.GetManifestResourceStream("80bf5fac-f0b4-4952-bc21-bd021e3fec32"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 180
				array2(0) = 48
				array2(0) = 43
				array2(0) = 152
				array2(1) = 96
				array2(1) = 121
				array2(1) = 139
				array2(1) = 73
				array2(2) = 97
				array2(2) = 116
				array2(2) = 192
				array2(3) = 122
				array2(3) = 153
				array2(3) = 139
				array2(3) = 158
				array2(3) = 138
				array2(3) = 9
				array2(4) = 137
				array2(4) = 209
				array2(4) = 51
				array2(4) = 92
				array2(4) = 132
				array2(4) = 250
				array2(5) = 167
				array2(5) = 162
				array2(5) = 184
				array2(5) = 148
				array2(5) = 184
				array2(6) = 27
				array2(6) = 157
				array2(6) = 145
				array2(6) = 134
				array2(6) = 248
				array2(7) = 76
				array2(7) = 95
				array2(7) = 198
				array2(8) = 192
				array2(8) = 124
				array2(8) = 140
				array2(8) = 224
				array2(9) = 181
				array2(9) = 108
				array2(9) = 118
				array2(9) = 104
				array2(9) = 190
				array2(10) = 147
				array2(10) = 107
				array2(10) = 148
				array2(10) = 216
				array2(11) = 117
				array2(11) = 86
				array2(11) = 139
				array2(11) = 88
				array2(11) = 56
				array2(12) = 239
				array2(12) = 173
				array2(12) = 86
				array2(12) = 162
				array2(12) = 90
				array2(12) = 189
				array2(13) = 133
				array2(13) = 140
				array2(13) = 187
				array2(13) = 122
				array2(13) = 141
				array2(13) = 111
				array2(14) = 140
				array2(14) = 145
				array2(14) = 110
				array2(14) = 124
				array2(14) = 95
				array2(14) = 201
				array2(15) = 116
				array2(15) = 35
				array2(15) = 169
				array2(15) = 116
				array2(15) = 119
				array2(15) = 186
				array2(16) = 126
				array2(16) = 95
				array2(16) = 80
				array2(16) = 92
				array2(17) = 133
				array2(17) = 135
				array2(17) = 25
				array2(18) = 102
				array2(18) = 86
				array2(18) = 82
				array2(19) = 90
				array2(19) = 182
				array2(19) = 88
				array2(19) = 83
				array2(19) = 62
				array2(20) = 168
				array2(20) = 152
				array2(20) = 89
				array2(20) = 250
				array2(21) = 235
				array2(21) = 153
				array2(21) = 119
				array2(21) = 105
				array2(21) = 103
				array2(21) = 23
				array2(22) = 122
				array2(22) = 61
				array2(22) = 123
				array2(22) = 145
				array2(23) = 92
				array2(23) = 100
				array2(23) = 120
				array2(23) = 104
				array2(23) = 115
				array2(23) = 27
				array2(24) = 127
				array2(24) = 204
				array2(24) = 124
				array2(24) = 99
				array2(24) = 78
				array2(25) = 96
				array2(25) = 121
				array2(25) = 88
				array2(25) = 108
				array2(25) = 17
				array2(26) = 98
				array2(26) = 102
				array2(26) = 128
				array2(26) = 130
				array2(27) = 171
				array2(27) = 166
				array2(27) = 97
				array2(27) = 156
				array2(28) = 71
				array2(28) = 167
				array2(28) = 85
				array2(28) = 158
				array2(29) = 110
				array2(29) = 117
				array2(29) = 168
				array2(30) = 140
				array2(30) = 92
				array2(30) = 89
				array2(30) = 66
				array2(30) = 175
				array2(31) = 142
				array2(31) = 187
				array2(31) = 146
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 180
				array4(0) = 48
				array4(0) = 91
				array4(0) = 80
				array4(0) = 203
				array4(1) = 55
				array4(1) = 150
				array4(1) = 154
				array4(1) = 12
				array4(2) = 122
				array4(2) = 116
				array4(2) = 126
				array4(2) = 196
				array4(3) = 153
				array4(3) = 153
				array4(3) = 124
				array4(3) = 63
				array4(4) = 123
				array4(4) = 137
				array4(4) = 86
				array4(5) = 161
				array4(5) = 110
				array4(5) = 98
				array4(5) = 168
				array4(5) = 35
				array4(6) = 98
				array4(6) = 167
				array4(6) = 162
				array4(6) = 129
				array4(6) = 101
				array4(7) = 193
				array4(7) = 96
				array4(7) = 112
				array4(7) = 145
				array4(7) = 109
				array4(8) = 227
				array4(8) = 38
				array4(8) = 130
				array4(8) = 192
				array4(8) = 211
				array4(9) = 140
				array4(9) = 138
				array4(9) = 166
				array4(10) = 123
				array4(10) = 152
				array4(10) = 169
				array4(10) = 129
				array4(10) = 162
				array4(10) = 168
				array4(11) = 94
				array4(11) = 92
				array4(11) = 148
				array4(11) = 158
				array4(11) = 198
				array4(11) = 17
				array4(12) = 104
				array4(12) = 111
				array4(12) = 98
				array4(12) = 166
				array4(12) = 121
				array4(12) = 237
				array4(13) = 86
				array4(13) = 162
				array4(13) = 108
				array4(13) = 133
				array4(13) = 141
				array4(13) = 45
				array4(14) = 122
				array4(14) = 100
				array4(14) = 158
				array4(14) = 140
				array4(14) = 175
				array4(15) = 150
				array4(15) = 124
				array4(15) = 77
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(WatcherWrapper).Assembly.GetName().GetPublicKeyToken()
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
				Dim symmetricAlgorithm As SymmetricAlgorithm = WatcherWrapper.LogoutConsumer()
				symmetricAlgorithm.Mode = 1
				Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.FlushFinalBlock()
				WatcherWrapper.m_PredicateWrapper = memoryStream.ToArray()
				memoryStream.Close()
				cryptoStream.Close()
				binaryReader.Close()
			End If
			If WatcherWrapper.annotationWrapper.Length = 0 Then
				WatcherWrapper.annotationWrapper = WatcherWrapper.RevertConsumer(WatcherWrapper.InvokeConsumer(GetType(WatcherWrapper).Assembly).ToString())
			End If
			Dim num As Integer = 0
			Try
				num = BitConverter.ToInt32(New Byte() { WatcherWrapper.m_PredicateWrapper(int_0), WatcherWrapper.m_PredicateWrapper(int_0 + 1), WatcherWrapper.m_PredicateWrapper(int_0 + 2), WatcherWrapper.m_PredicateWrapper(int_0 + 3) }, 0)
			Catch
			End Try
			Try
				If WatcherWrapper.annotationWrapper(num) = 128 Then
					Return True
				End If
			Catch
			End Try
			Return False
		End Function

	
		Shared Function RemoveConsumer(int_0 As Integer) As String
			If WatcherWrapper._ClassWrapper.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WatcherWrapper).Assembly.GetManifestResourceStream("3a200808-4450-425b-a8e3-7481260ad564"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 71
				array2(0) = 216
				array2(0) = 153
				array2(0) = 45
				array2(1) = 146
				array2(1) = 126
				array2(1) = 182
				array2(1) = 152
				array2(1) = 115
				array2(1) = 155
				array2(2) = 51
				array2(2) = 66
				array2(2) = 200
				array2(3) = 92
				array2(3) = 159
				array2(3) = 63
				array2(3) = 213
				array2(4) = 100
				array2(4) = 85
				array2(4) = 26
				array2(4) = 225
				array2(5) = 120
				array2(5) = 170
				array2(5) = 106
				array2(5) = 118
				array2(5) = 175
				array2(5) = 44
				array2(6) = 30
				array2(6) = 149
				array2(6) = 128
				array2(6) = 19
				array2(6) = 155
				array2(6) = 172
				array2(7) = 142
				array2(7) = 19
				array2(7) = 108
				array2(7) = 175
				array2(8) = 168
				array2(8) = 145
				array2(8) = 159
				array2(8) = 72
				array2(9) = 89
				array2(9) = 142
				array2(9) = 100
				array2(9) = 170
				array2(9) = 91
				array2(10) = 125
				array2(10) = 134
				array2(10) = 92
				array2(10) = 181
				array2(10) = 173
				array2(10) = 116
				array2(11) = 128
				array2(11) = 115
				array2(11) = 252
				array2(12) = 144
				array2(12) = 122
				array2(12) = 16
				array2(13) = 108
				array2(13) = 97
				array2(13) = 118
				array2(13) = 144
				array2(14) = 114
				array2(14) = 237
				array2(14) = 103
				array2(15) = 120
				array2(15) = 101
				array2(15) = 171
				array2(16) = 116
				array2(16) = 126
				array2(16) = 15
				array2(16) = 108
				array2(16) = 104
				array2(16) = 240
				array2(17) = 105
				array2(17) = 186
				array2(17) = 106
				array2(17) = 26
				array2(18) = 90
				array2(18) = 95
				array2(18) = 0
				array2(19) = 129
				array2(19) = 86
				array2(19) = 114
				array2(19) = 51
				array2(20) = 111
				array2(20) = 142
				array2(20) = 129
				array2(21) = 81
				array2(21) = 51
				array2(21) = 167
				array2(21) = 120
				array2(22) = 169
				array2(22) = 85
				array2(22) = 134
				array2(22) = 211
				array2(23) = 189
				array2(23) = 89
				array2(23) = 93
				array2(23) = 21
				array2(24) = 125
				array2(24) = 132
				array2(24) = 85
				array2(24) = 101
				array2(24) = 150
				array2(24) = 192
				array2(25) = 169
				array2(25) = 23
				array2(25) = 119
				array2(25) = 54
				array2(26) = 135
				array2(26) = 151
				array2(26) = 164
				array2(26) = 170
				array2(26) = 250
				array2(27) = 121
				array2(27) = 111
				array2(27) = 144
				array2(27) = 117
				array2(27) = 87
				array2(27) = 51
				array2(28) = 79
				array2(28) = 80
				array2(28) = 95
				array2(28) = 148
				array2(28) = 132
				array2(28) = 3
				array2(29) = 102
				array2(29) = 127
				array2(29) = 96
				array2(29) = 53
				array2(29) = 244
				array2(30) = 156
				array2(30) = 111
				array2(30) = 161
				array2(30) = 169
				array2(30) = 237
				array2(31) = 192
				array2(31) = 78
				array2(31) = 86
				array2(31) = 29
				array2(31) = 95
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 88
				array4(0) = 114
				array4(0) = 138
				array4(0) = 217
				array4(1) = 91
				array4(1) = 90
				array4(1) = 155
				array4(1) = 150
				array4(1) = 197
				array4(1) = 72
				array4(2) = 51
				array4(2) = 110
				array4(2) = 96
				array4(3) = 30
				array4(3) = 214
				array4(3) = 134
				array4(3) = 33
				array4(3) = 85
				array4(3) = 254
				array4(4) = 86
				array4(4) = 134
				array4(4) = 138
				array4(4) = 168
				array4(5) = 124
				array4(5) = 98
				array4(5) = 122
				array4(5) = 146
				array4(5) = 157
				array4(5) = 121
				array4(6) = 86
				array4(6) = 126
				array4(6) = 136
				array4(6) = 84
				array4(6) = 102
				array4(7) = 152
				array4(7) = 99
				array4(7) = 59
				array4(7) = 19
				array4(8) = 88
				array4(8) = 149
				array4(8) = 1
				array4(9) = 154
				array4(9) = 142
				array4(9) = 113
				array4(10) = 92
				array4(10) = 108
				array4(10) = 105
				array4(10) = 132
				array4(10) = 161
				array4(11) = 143
				array4(11) = 171
				array4(11) = 146
				array4(11) = 14
				array4(12) = 173
				array4(12) = 143
				array4(12) = 156
				array4(12) = 93
				array4(12) = 144
				array4(12) = 15
				array4(13) = 82
				array4(13) = 90
				array4(13) = 108
				array4(13) = 241
				array4(14) = 35
				array4(14) = 99
				array4(14) = 111
				array4(14) = 116
				array4(14) = 140
				array4(15) = 113
				array4(15) = 146
				array4(15) = 124
				array4(15) = 100
				array4(15) = 15
				array4(15) = 228
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(WatcherWrapper).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = WatcherWrapper.LogoutConsumer()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					WatcherWrapper._ClassWrapper = memoryStream.ToArray()
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = WatcherWrapper._ClassWrapper
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
				WatcherWrapper._ClassWrapper = array6
			End If
			Dim num17 As Integer = BitConverter.ToInt32(WatcherWrapper._ClassWrapper, int_0)
			Try
				Dim array7 As Byte() = New Byte(num17 - 1) {}
				Array.Copy(WatcherWrapper._ClassWrapper, int_0 + 4, array7, 0, num17)
				Return Encoding.Unicode.GetString(array7, 0, array7.Length)
			Catch
			End Try
			Return ""
		End Function

	
		Shared Function EnableConsumer(int_0 As Integer) As String
			If WatcherWrapper._StructWrapper.Length = 0 Then
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WatcherWrapper).Assembly.GetManifestResourceStream("3a200808-4450-425b-a8e3-7481260ad564"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 71
				array2(0) = 216
				array2(0) = 153
				array2(0) = 45
				array2(1) = 146
				array2(1) = 126
				array2(1) = 182
				array2(1) = 152
				array2(1) = 115
				array2(1) = 155
				array2(2) = 51
				array2(2) = 66
				array2(2) = 200
				array2(3) = 92
				array2(3) = 159
				array2(3) = 63
				array2(3) = 213
				array2(4) = 100
				array2(4) = 85
				array2(4) = 26
				array2(4) = 225
				array2(5) = 120
				array2(5) = 170
				array2(5) = 106
				array2(5) = 118
				array2(5) = 175
				array2(5) = 44
				array2(6) = 30
				array2(6) = 149
				array2(6) = 128
				array2(6) = 19
				array2(6) = 155
				array2(6) = 172
				array2(7) = 142
				array2(7) = 19
				array2(7) = 108
				array2(7) = 175
				array2(8) = 168
				array2(8) = 145
				array2(8) = 159
				array2(8) = 72
				array2(9) = 89
				array2(9) = 142
				array2(9) = 100
				array2(9) = 170
				array2(9) = 91
				array2(10) = 125
				array2(10) = 134
				array2(10) = 92
				array2(10) = 181
				array2(10) = 173
				array2(10) = 116
				array2(11) = 128
				array2(11) = 115
				array2(11) = 252
				array2(12) = 144
				array2(12) = 122
				array2(12) = 16
				array2(13) = 108
				array2(13) = 97
				array2(13) = 118
				array2(13) = 144
				array2(14) = 114
				array2(14) = 237
				array2(14) = 103
				array2(15) = 120
				array2(15) = 101
				array2(15) = 171
				array2(16) = 116
				array2(16) = 126
				array2(16) = 15
				array2(16) = 108
				array2(16) = 104
				array2(16) = 240
				array2(17) = 105
				array2(17) = 186
				array2(17) = 106
				array2(17) = 26
				array2(18) = 90
				array2(18) = 95
				array2(18) = 0
				array2(19) = 129
				array2(19) = 86
				array2(19) = 114
				array2(19) = 51
				array2(20) = 111
				array2(20) = 142
				array2(20) = 129
				array2(21) = 81
				array2(21) = 51
				array2(21) = 167
				array2(21) = 120
				array2(22) = 169
				array2(22) = 85
				array2(22) = 134
				array2(22) = 211
				array2(23) = 189
				array2(23) = 89
				array2(23) = 93
				array2(23) = 21
				array2(24) = 125
				array2(24) = 132
				array2(24) = 85
				array2(24) = 101
				array2(24) = 150
				array2(24) = 192
				array2(25) = 169
				array2(25) = 23
				array2(25) = 119
				array2(25) = 54
				array2(26) = 135
				array2(26) = 151
				array2(26) = 164
				array2(26) = 170
				array2(26) = 250
				array2(27) = 121
				array2(27) = 111
				array2(27) = 144
				array2(27) = 117
				array2(27) = 87
				array2(27) = 51
				array2(28) = 79
				array2(28) = 80
				array2(28) = 95
				array2(28) = 148
				array2(28) = 132
				array2(28) = 3
				array2(29) = 102
				array2(29) = 127
				array2(29) = 96
				array2(29) = 53
				array2(29) = 244
				array2(30) = 156
				array2(30) = 111
				array2(30) = 161
				array2(30) = 169
				array2(30) = 237
				array2(31) = 192
				array2(31) = 78
				array2(31) = 86
				array2(31) = 29
				array2(31) = 95
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 88
				array4(0) = 114
				array4(0) = 138
				array4(0) = 217
				array4(1) = 91
				array4(1) = 90
				array4(1) = 155
				array4(1) = 150
				array4(1) = 197
				array4(1) = 72
				array4(2) = 51
				array4(2) = 110
				array4(2) = 96
				array4(3) = 30
				array4(3) = 214
				array4(3) = 134
				array4(3) = 33
				array4(3) = 85
				array4(3) = 254
				array4(4) = 86
				array4(4) = 134
				array4(4) = 138
				array4(4) = 168
				array4(5) = 124
				array4(5) = 98
				array4(5) = 122
				array4(5) = 146
				array4(5) = 157
				array4(5) = 121
				array4(6) = 86
				array4(6) = 126
				array4(6) = 136
				array4(6) = 84
				array4(6) = 102
				array4(7) = 152
				array4(7) = 99
				array4(7) = 59
				array4(7) = 19
				array4(8) = 88
				array4(8) = 149
				array4(8) = 1
				array4(9) = 154
				array4(9) = 142
				array4(9) = 113
				array4(10) = 92
				array4(10) = 108
				array4(10) = 105
				array4(10) = 132
				array4(10) = 161
				array4(11) = 143
				array4(11) = 171
				array4(11) = 146
				array4(11) = 14
				array4(12) = 173
				array4(12) = 143
				array4(12) = 156
				array4(12) = 93
				array4(12) = 144
				array4(12) = 15
				array4(13) = 82
				array4(13) = 90
				array4(13) = 108
				array4(13) = 241
				array4(14) = 35
				array4(14) = 99
				array4(14) = 111
				array4(14) = 116
				array4(14) = 140
				array4(15) = 113
				array4(15) = 146
				array4(15) = 124
				array4(15) = 100
				array4(15) = 15
				array4(15) = 228
				Dim array5 As Byte() = array4
				Dim publicKeyToken As Byte() = GetType(WatcherWrapper).Assembly.GetName().GetPublicKeyToken()
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
					Dim symmetricAlgorithm As SymmetricAlgorithm = WatcherWrapper.LogoutConsumer()
					symmetricAlgorithm.Mode = 1
					Dim cryptoTransform As ICryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, cryptoTransform, 1)
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.FlushFinalBlock()
					WatcherWrapper._StructWrapper = memoryStream.ToArray()
					If WatcherWrapper._StructWrapper.Length > 0 Then
						WatcherWrapper.pageWrapper = New String(WatcherWrapper._StructWrapper.Length / 4 + 1 - 1) {}
						WatcherWrapper._AttrWrapper = New Integer(WatcherWrapper._StructWrapper.Length / 4 + 1 - 1) {}
					End If
					memoryStream.Close()
					cryptoStream.Close()
					binaryReader.Close()
					array = WatcherWrapper._StructWrapper
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
				WatcherWrapper._StructWrapper = array6
				If WatcherWrapper._StructWrapper.Length > 0 Then
					WatcherWrapper.pageWrapper = New String(WatcherWrapper._StructWrapper.Length / 4 + 1 - 1) {}
					WatcherWrapper._AttrWrapper = New Integer(WatcherWrapper._StructWrapper.Length / 4 + 1 - 1) {}
				End If
				Dim assembly As Assembly = GetType(WatcherWrapper).Assembly
				If IntPtr.Size = 4 Then
					WatcherWrapper.interceptorWrapper = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt32()
				End If
				WatcherWrapper.m_SchemaWrapper = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
			End If
			Dim num16 As Integer = int_0 / 4
			If WatcherWrapper._AttrWrapper(num16) > 0 Then
				Return CType(WatcherWrapper.pageWrapper, String())(WatcherWrapper._AttrWrapper(num16))
			End If
			Dim num17 As Integer = BitConverter.ToInt32(WatcherWrapper._StructWrapper, int_0)
			If WatcherWrapper.observerWrapper = IntPtr.Zero Then
				WatcherWrapper.observerWrapper = WatcherWrapper.OpenProcess(16UI, 1, CUInt(Process.GetCurrentProcess().Id))
			End If
			Dim array7 As Byte() = New Byte(3) {}
			If IntPtr.Size = 4 Then
				WatcherWrapper.ReadProcessMemory(WatcherWrapper.observerWrapper, New IntPtr(WatcherWrapper.interceptorWrapper + num17), array7, 4UI, WatcherWrapper._RoleWrapper)
			Else
				WatcherWrapper.ReadProcessMemory(WatcherWrapper.observerWrapper, New IntPtr(WatcherWrapper.m_SchemaWrapper + CLng(num17)), array7, 4UI, WatcherWrapper._RoleWrapper)
			End If
			Dim num18 As Integer = BitConverter.ToInt32(array7, 0)
			array7 = New Byte(num18 - 1) {}
			If IntPtr.Size = 4 Then
				WatcherWrapper.ReadProcessMemory(WatcherWrapper.observerWrapper, New IntPtr(WatcherWrapper.interceptorWrapper + num17 + 4), array7, Convert.ToUInt32(num18), WatcherWrapper._RoleWrapper)
			Else
				WatcherWrapper.ReadProcessMemory(WatcherWrapper.observerWrapper, New IntPtr(WatcherWrapper.m_SchemaWrapper + CLng(num17) + 4L), array7, Convert.ToUInt32(num18), WatcherWrapper._RoleWrapper)
			End If
			Dim array8 As Byte() = WatcherWrapper.FindWrapper(array7)
			Dim [string] As String = Encoding.Unicode.GetString(array8, 0, array8.Length)
			WatcherWrapper._AttrWrapper(num16) = WatcherWrapper.m_DescriptorWrapper
			CType(WatcherWrapper.pageWrapper, String())(WatcherWrapper.m_DescriptorWrapper) = [string]
			WatcherWrapper.m_DescriptorWrapper += 1
			Return [string]
		End Function

	
		Friend Shared Function ExcludeConsumer(string_0 As String) As String
			Dim array As Byte() = Convert.FromBase64String(string_0)
			Return Encoding.Unicode.GetString(array, 0, array.Length)
		End Function

	
		Private Declare Function VirtualProtect Lib "kernel32.dll" (intptr_0 As IntPtr, int_0 As Integer, int_1 As Integer, ByRef int_2 As Integer) As Integer

	
		<WatcherWrapper.InstanceWrapper(GetType(WatcherWrapper.InstanceWrapper.TaskWrapper(Of Object)()))>
		Shared Sub LoginConsumer()
			If Not WatcherWrapper._IndexerWrapper Then
				WatcherWrapper._IndexerWrapper = True
				Dim binaryReader As BinaryReader = New BinaryReader(GetType(WatcherWrapper).Assembly.GetManifestResourceStream("4910eff8-0fb8-48c9-bc2b-3aeb635001d9"))
				binaryReader.BaseStream.Position = 0L
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				Dim array2 As Byte() = New Byte(31) {}
				array2(0) = 22
				array2(0) = 67
				array2(0) = 116
				array2(0) = 194
				array2(0) = 120
				array2(0) = 22
				array2(1) = 244
				array2(1) = 183
				array2(1) = 47
				array2(1) = 244
				array2(2) = 91
				array2(2) = 112
				array2(2) = 128
				array2(2) = 116
				array2(2) = 91
				array2(3) = 6
				array2(3) = 192
				array2(3) = 114
				array2(3) = 146
				array2(3) = 143
				array2(3) = 204
				array2(3) = 6
				array2(4) = 90
				array2(4) = 100
				array2(4) = 136
				array2(4) = 90
				array2(5) = 95
				array2(5) = 166
				array2(5) = 114
				array2(5) = 154
				array2(5) = 129
				array2(5) = 95
				array2(6) = 37
				array2(6) = 133
				array2(6) = 163
				array2(6) = 138
				array2(6) = 37
				array2(7) = 211
				array2(7) = 177
				array2(7) = 113
				array2(7) = 225
				array2(7) = 211
				array2(8) = 231
				array2(8) = 27
				array2(8) = 156
				array2(8) = 134
				array2(8) = 231
				array2(9) = 208
				array2(9) = 30
				array2(9) = 156
				array2(9) = 144
				array2(9) = 123
				array2(9) = 208
				array2(10) = 39
				array2(10) = 132
				array2(10) = 90
				array2(10) = 89
				array2(10) = 39
				array2(11) = 40
				array2(11) = 102
				array2(11) = 196
				array2(11) = 156
				array2(11) = 40
				array2(12) = 22
				array2(12) = 160
				array2(12) = 104
				array2(12) = 136
				array2(12) = 145
				array2(12) = 6
				array2(12) = 22
				array2(13) = 219
				array2(13) = 158
				array2(13) = 164
				array2(13) = 134
				array2(13) = 146
				array2(13) = 116
				array2(13) = 219
				array2(14) = 57
				array2(14) = 137
				array2(14) = 144
				array2(14) = 57
				array2(15) = 211
				array2(15) = 106
				array2(15) = 152
				array2(15) = 129
				array2(15) = 132
				array2(15) = 211
				array2(16) = 163
				array2(16) = 159
				array2(16) = 126
				array2(16) = 145
				array2(16) = 163
				array2(17) = 141
				array2(17) = 142
				array2(17) = 118
				array2(17) = 86
				array2(17) = 68
				array2(17) = 120
				array2(17) = 141
				array2(18) = 120
				array2(18) = 89
				array2(18) = 90
				array2(18) = 157
				array2(18) = 111
				array2(18) = 120
				array2(19) = 107
				array2(19) = 166
				array2(19) = 169
				array2(19) = 107
				array2(20) = 54
				array2(20) = 134
				array2(20) = 148
				array2(20) = 102
				array2(20) = 54
				array2(21) = 100
				array2(21) = 178
				array2(21) = 104
				array2(21) = 150
				array2(21) = 170
				array2(21) = 100
				array2(22) = 153
				array2(22) = 110
				array2(22) = 105
				array2(22) = 153
				array2(23) = 63
				array2(23) = 26
				array2(23) = 103
				array2(23) = 88
				array2(23) = 112
				array2(23) = 63
				array2(24) = 172
				array2(24) = 152
				array2(24) = 183
				array2(24) = 153
				array2(24) = 172
				array2(25) = 72
				array2(25) = 217
				array2(25) = 90
				array2(25) = 120
				array2(25) = 157
				array2(25) = 72
				array2(26) = 247
				array2(26) = 82
				array2(26) = 124
				array2(26) = 187
				array2(26) = 167
				array2(26) = 81
				array2(26) = 247
				array2(27) = 156
				array2(27) = 88
				array2(27) = 118
				array2(27) = 156
				array2(28) = 191
				array2(28) = 50
				array2(28) = 143
				array2(28) = 152
				array2(28) = 163
				array2(28) = 135
				array2(28) = 191
				array2(29) = 90
				array2(29) = 141
				array2(29) = 84
				array2(29) = 90
				array2(30) = 86
				array2(30) = 191
				array2(30) = 191
				array2(30) = 86
				array2(31) = 204
				array2(31) = 87
				array2(31) = 161
				array2(31) = 101
				array2(31) = 204
				Dim array3 As Byte() = array2
				Dim array4 As Byte() = New Byte(15) {}
				array4(0) = 67
				array4(0) = 116
				array4(0) = 149
				array4(0) = 122
				array4(0) = 138
				array4(1) = 89
				array4(1) = 185
				array4(1) = 112
				array4(1) = 243
				array4(2) = 112
				array4(2) = 128
				array4(2) = 192
				array4(3) = 61
				array4(3) = 192
				array4(3) = 138
				array4(3) = 164
				array4(3) = 59
				array4(4) = 135
				array4(4) = 100
				array4(4) = 126
				array4(5) = 118
				array4(5) = 138
				array4(5) = 162
				array4(5) = 132
				array4(5) = 221
				array4(6) = 133
				array4(6) = 106
				array4(6) = 54
				array4(6) = 172
				array4(7) = 113
				array4(7) = 152
				array4(7) = 150
				array4(7) = 127
				array4(7) = 145
				array4(7) = 8
				array4(8) = 27
				array4(8) = 156
				array4(8) = 134
				array4(8) = 124
				array4(8) = 61
				array4(9) = 117
				array4(9) = 166
				array4(9) = 144
				array4(9) = 101
				array4(10) = 57
				array4(10) = 132
				array4(10) = 23
				array4(11) = 117
				array4(11) = 158
				array4(11) = 157
				array4(11) = 100
				array4(11) = 80
				array4(12) = 150
				array4(12) = 163
				array4(12) = 136
				array4(12) = 227
				array4(13) = 104
				array4(13) = 136
				array4(13) = 176
				array4(13) = 86
				array4(13) = 85
				array4(13) = 64
				array4(14) = 169
				array4(14) = 106
				array4(14) = 213
				array4(15) = 169
				array4(15) = 83
				array4(15) = 144
				array4(15) = 148
				array4(15) = 104
				array4(15) = 177
				Dim array5 As Byte() = array4
				Array.Reverse(array5)
				Dim publicKeyToken As Byte() = GetType(WatcherWrapper).Assembly.GetName().GetPublicKeyToken()
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
				Dim assembly As Assembly = GetType(WatcherWrapper).Assembly
				intptr_ = WatcherWrapper.OpenProcess(56UI, 1, CUInt(Process.GetCurrentProcess().Id))
				WatcherWrapper.m_SchemaWrapper = Marshal.GetHINSTANCE(assembly.GetModules()(0)).ToInt64()
				Dim zero As IntPtr = IntPtr.Zero
				Dim int_ As Integer = 0
				Dim num16 As Integer = binaryReader.ReadInt32()
				binaryReader.ReadInt32()
				For m As Integer = 0 To num16 - 1
					Dim intPtr As IntPtr = New IntPtr(WatcherWrapper.m_SchemaWrapper + CLng(binaryReader.ReadInt32()))
					WatcherWrapper.VirtualProtect(intPtr, 4, 4, int_)
					If IntPtr.Size = 4 Then
						WatcherWrapper.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					Else
						WatcherWrapper.WriteProcessMemory(intptr_, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4UI, zero)
					End If
					WatcherWrapper.VirtualProtect(intPtr, 4, int_, int_)
				Next
				Try
					While binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L
						Dim num17 As Integer = binaryReader.ReadInt32()
						Dim intptr_2 As IntPtr = New IntPtr(WatcherWrapper.m_SchemaWrapper + CLng(num17))
						Dim num18 As Integer = binaryReader.ReadInt32()
						WatcherWrapper.VirtualProtect(intptr_2, num18 * 4, 4, int_)
						For n As Integer = 0 To num18 - 1
							Marshal.WriteInt32(New IntPtr(intptr_2.ToInt64() + CLng((n * 4))), binaryReader.ReadInt32())
						Next
						WatcherWrapper.VirtualProtect(intptr_2, num18 * 4, int_, int_)
					End While
					WatcherWrapper.CloseHandle(intptr_)
				Catch
				End Try
			End If
		End Sub

	
		Friend Shared Function InvokeConsumer(assembly_0 As Assembly) As Object
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

	
		Private Shared Function RevertConsumer(string_0 As String) As Byte()
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

	
		Private Shared Function FindWrapper(byte_0 As Byte()) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = WatcherWrapper.LogoutConsumer()
			symmetricAlgorithm.Key = New Byte() { 42, 199, 25, 248, 245, 25, 232, 49, 76, 151, 97, 186, 168, 137, 144, 157, 43, 132, 208, 56, 183, 100, 225, 44, 39, 118, 243, 60, 4, 2, 72, 25 }
			symmetricAlgorithm.IV = New Byte() { 253, 224, 82, 147, 234, 224, 55, 105, 165, 170, 106, 20, 42, 148, 26, 79 }
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), 1)
			cryptoStream.Write(byte_0, 0, byte_0.Length)
			cryptoStream.Close()
			Return memoryStream.ToArray()
		End Function

	
		Private Function DeleteWrapper() As Byte()
			Return Nothing
		End Function

	
		Private Function CountWrapper() As Byte()
			Return Nothing
		End Function

	
		Private Function CustomizeWrapper() As Byte()
			Return Nothing
		End Function

	
		Private Function CollectWrapper() As Byte()
			Return Nothing
		End Function

	
		Private Function StartWrapper() As Byte()
			Return Nothing
		End Function

	
		Private Function VisitWrapper() As Byte()
			Return Nothing
		End Function

	
		Friend Function PopWrapper() As Byte()
			Dim text As String = "{11111-22222-40001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function ResetWrapper() As Byte()
			Dim text As String = "{11111-22222-40001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function VerifyWrapper() As Byte()
			Dim text As String = "{11111-22222-50001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function ResolveWrapper() As Byte()
			Dim text As String = "{11111-22222-50001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function CallWrapper() As Byte()
			Dim text As String = "{11111-22222-60001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Function ReadWrapper() As Byte()
			Dim text As String = "{11111-22222-60001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

	
		Friend Shared Function CloneWrapper(string_0 As String, string_1 As String) As String
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(string_0)
			Dim array As Byte() = bytes
			Dim key As Byte() = New Byte() { 82, 102, 104, 110, 32, 77, 24, 34, 118, 181, 51, 17, 18, 51, 12, 109, 10, 32, 77, 24, 34, 158, 161, 41, 97, 28, 118, 181, 5, 25, 1, 88 }
			Dim iv As Byte() = WatcherWrapper.RestartConsumer(Encoding.Unicode.GetBytes(string_1))
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim symmetricAlgorithm As SymmetricAlgorithm = WatcherWrapper.LogoutConsumer()
			symmetricAlgorithm.Key = key
			symmetricAlgorithm.IV = iv
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), 1)
			cryptoStream.Write(array, 0, array.Length)
			cryptoStream.Close()
			Return Convert.ToBase64String(memoryStream.ToArray())
		End Function

	
		Private Shared utilsWrapper As Boolean

	
		Private Shared _ProccesorWrapper As Boolean

	
		Private Shared annotationWrapper As Byte()

	
		Private Shared interceptorWrapper As Integer

	
		Private Shared _IndexerWrapper As Boolean

	
		Private Shared _AttrWrapper As Integer()

	
		Private Shared _StructWrapper As Byte()

	
		Private Shared pageWrapper As String()

	
		Private Shared m_SchemaWrapper As Long

	
		Private Shared observerWrapper As IntPtr

	
		Private Shared m_DescriptorWrapper As Integer

	
		Private Shared _RoleWrapper As IntPtr

	
		Private Shared _ClassWrapper As Byte()

	
		Private Shared m_BroadcasterWrapper As UInteger() = New UInteger() { 3614090360UI, 3905402710UI, 606105819UI, 3250441966UI, 4118548399UI, 1200080426UI, 2821735955UI, 4249261313UI, 1770035416UI, 2336552879UI, 4294925233UI, 2304563134UI, 1804603682UI, 4254626195UI, 2792965006UI, 1236535329UI, 4129170786UI, 3225465664UI, 643717713UI, 3921069994UI, 3593408605UI, 38016083UI, 3634488961UI, 3889429448UI, 568446438UI, 3275163606UI, 4107603335UI, 1163531501UI, 2850285829UI, 4243563512UI, 1735328473UI, 2368359562UI, 4294588738UI, 2272392833UI, 1839030562UI, 4259657740UI, 2763975236UI, 1272893353UI, 4139469664UI, 3200236656UI, 681279174UI, 3936430074UI, 3572445317UI, 76029189UI, 3654602809UI, 3873151461UI, 530742520UI, 3299628645UI, 4096336452UI, 1126891415UI, 2878612391UI, 4237533241UI, 1700485571UI, 2399980690UI, 4293915773UI, 2240044497UI, 1873313359UI, 4264355552UI, 2734768916UI, 1309151649UI, 4149444226UI, 3174756917UI, 718787259UI, 3951481745UI }

	
		Private Shared m_PredicateWrapper As Byte()

	
		Friend Class InstanceWrapper
			Inherits Attribute

		
			<WatcherWrapper.InstanceWrapper(GetType(WatcherWrapper.InstanceWrapper.TaskWrapper(Of Object)()))>
			Public Sub New(object_0 As Object)
			End Sub

		
			Friend Class TaskWrapper(Of T)
			End Class
		End Class

	
		<Flags()>
		Private Enum VisitorWrapper
		End Enum
	End Class
End Namespace
