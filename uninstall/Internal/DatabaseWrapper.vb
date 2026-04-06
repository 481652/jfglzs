Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace uninstall.Internal
	' Token: 0x0200000F RID: 15
	Friend NotInheritable Module DatabaseWrapper
		' Token: 0x0600004E RID: 78 RVA: 0x00003834 File Offset: 0x00001A34
		Public Sub AssetConsumer()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_01:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(DatabaseWrapper.TestConsumer(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_2A:
				num2 = 3
				If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
					GoTo IL_5D
				End If
				IL_3B:
				num2 = 4
				objectValue = RuntimeHelpers.GetObjectValue(DatabaseWrapper.TestConsumer(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				IL_5D:
				num2 = 5
				Dim obj As Object = Strings.Mid(Conversions.ToString(objectValue), 1, Strings.Len(RuntimeHelpers.GetObjectValue(objectValue)) - 9)
				IL_7D:
				num2 = 6
				Dim text As String = "zmserv"
				IL_86:
				num2 = 7
				IL_88:
				num2 = 8
				Dim text2 As String = Conversions.ToString(DatabaseWrapper._ParserWrapper)
				IL_96:
				num2 = 9
				Dim text3 As String = "jfglzsn"
				Dim processesByName As Process()
				Dim processesByName2 As Process()
				Do
					IL_E6:
					num2 = 11
					IL_A2:
					num2 = 12
					processesByName = Process.GetProcessesByName(text2)
					IL_AE:
					num2 = 13
					processesByName(0).Kill()
					IL_BA:
					num2 = 14
					processesByName2 = Process.GetProcessesByName(text3)
					IL_C6:
					num2 = 15
					processesByName2(0).Kill()
					IL_D2:
					num2 = 16
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				IL_EB:
				num2 = 19
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat", FileAttributes.Normal)
				IL_107:
				num2 = 20
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\przs.dat", FileAttributes.Normal)
				IL_123:
				num2 = 21
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\zmserv.dat", FileAttributes.Normal)
				IL_13F:
				num2 = 22
				File.SetAttributes(DatabaseWrapper._ErrorWrapper, FileAttributes.Normal)
				IL_151:
				num2 = 23
				File.Delete(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat")
				IL_168:
				num2 = 24
				File.Delete(DatabaseWrapper._ErrorWrapper + "\przs.dat")
				IL_17F:
				num2 = 25
				File.Delete(DatabaseWrapper._ErrorWrapper + "\zmserv.dat")
				IL_196:
				num2 = 26
				Directory.Delete(DatabaseWrapper._ErrorWrapper)
				IL_1A3:
				num2 = 27
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")), FileAttributes.Normal)
				IL_1C1:
				num2 = 28
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")), FileAttributes.Normal)
				IL_1DF:
				num2 = 29
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")), FileAttributes.Normal)
				IL_1FD:
				num2 = 30
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")), FileAttributes.Normal)
				IL_21B:
				num2 = 31
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")))
				IL_234:
				num2 = 32
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")))
				IL_24D:
				num2 = 33
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")))
				IL_266:
				num2 = 34
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")))
				IL_27F:
				num2 = 35
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				IL_29D:
				num2 = 36
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, 4)
				IL_2BB:
				num2 = 37
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 0, 4)
				IL_2D9:
				num2 = 38
				Dim text4 As String = Conversions.ToString(DatabaseWrapper.TestConsumer(Registry.CurrentUser, "Software\jfglzs", "dzjs", ""))
				IL_2FC:
				num2 = 39
				Dim text5 As String = text4
				IL_303:
				num2 = 40
				Dim str As String = Strings.Mid(text5, 1, Strings.Len(text5) - 16)
				IL_31A:
				num2 = 41
				File.SetAttributes(str + "\SpecialSet.exe", FileAttributes.Normal)
				IL_333:
				num2 = 42
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				IL_344:
				num2 = 43
				Thread.Sleep(3000)
				IL_351:
				num2 = 44
				Dim processesByName3 As Process() = Process.GetProcessesByName(text)
				IL_35D:
				num2 = 45
				processesByName3(0).Kill()
				IL_369:
				num2 = 46
				Dim registryKey As RegistryKey = Template.CountConsumer.Registry.LocalMachine
				IL_37C:
				num2 = 47
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs")
				IL_393:
				num2 = 48
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn")
				IL_3AA:
				num2 = 49
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs")
				IL_3C1:
				num2 = 50
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn")
				IL_3D8:
				num2 = 51
				Interaction.Shell("cmd /c bcdedit /set {bootmgr} displaybootmenu yes", AppWinStyle.MinimizedFocus, False, -1)
				IL_3E9:
				num2 = 52
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 3, 4)
				IL_407:
				num2 = 53
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 3, 4)
				IL_425:
				num2 = 54
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 3, 4)
				IL_443:
				num2 = 55
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 3, 4)
				IL_461:
				num2 = 56
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableLockWorkstation", 0, 4)
				IL_47F:
				num2 = 57
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "software", "n")
				IL_496:
				num2 = 58
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "software", "dtmm")
				IL_4AD:
				num2 = 59
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "software", "czmm")
				IL_4C4:
				num2 = 60
				registryKey = Template.CountConsumer.Registry.CurrentUser
				IL_4D7:
				num2 = 61
				Dim registryKey2 As RegistryKey = registryKey.OpenSubKey("Software\jfglzs")
				IL_4E6:
				num2 = 62
				If registryKey2 Is Nothing Then
					GoTo IL_4FA
				End If
				IL_4EC:
				num2 = 63
				registryKey.DeleteSubKey("Software\jfglzs")
				IL_4FA:
				num2 = 64
				registryKey = Template.CountConsumer.Registry.LocalMachine
				IL_50D:
				num2 = 65
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\taskkill.exe")
				IL_51B:
				num2 = 66
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\ntsd.exe")
				IL_529:
				num2 = 67
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\sidebar.exe")
				IL_537:
				num2 = 68
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Chess.exe")
				IL_545:
				num2 = 69
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\FreeCell.exe")
				IL_553:
				num2 = 70
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Hearts.exe")
				IL_561:
				num2 = 71
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Minesweeper.exe")
				IL_56F:
				num2 = 72
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				IL_57D:
				num2 = 73
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Mahjong.exe")
				IL_58B:
				num2 = 74
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\SpiderSolitaire.exe")
				IL_599:
				num2 = 75
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\bckgzm.exe")
				IL_5A7:
				num2 = 76
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\chkrzm.exe")
				IL_5B5:
				num2 = 77
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\shvlzm.exe")
				IL_5C3:
				num2 = 78
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Solitaire.exe")
				IL_5D1:
				num2 = 79
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winmine")
				IL_5DF:
				num2 = 80
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				IL_5ED:
				num2 = 81
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Magnify.exe")
				IL_5FB:
				num2 = 82
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\sethc.exe")
				IL_609:
				num2 = 83
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\tasklist.exe")
				IL_617:
				num2 = 84
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\taskkill.exe")
				IL_625:
				num2 = 85
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\route.exe")
				IL_633:
				num2 = 86
				registryKey = Template.CountConsumer.Registry.LocalMachine
				IL_646:
				num2 = 87
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Google\Chrome")
				IL_655:
				num2 = 88
				If registryKey2 Is Nothing Then
					GoTo IL_669
				End If
				IL_65B:
				num2 = 89
				registryKey.DeleteSubKey("Software\Policies\Google\Chrome")
				IL_669:
				num2 = 90
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Microsoft\Edge")
				IL_678:
				num2 = 91
				If registryKey2 Is Nothing Then
					GoTo IL_68C
				End If
				IL_67E:
				num2 = 92
				registryKey.DeleteSubKey("Software\Policies\Microsoft\Edge")
				IL_68C:
				num2 = 93
				File.SetAttributes(DatabaseWrapper._CodeWrapper, FileAttributes.Normal)
				IL_69E:
				num2 = 94
				File.SetAttributes(DatabaseWrapper._InvocationWrapper, FileAttributes.Normal)
				IL_6B0:
				num2 = 95
				File.SetAttributes("C:\Windows\System32\drivers\etc", FileAttributes.Normal)
				IL_6C2:
				num2 = 96
				File.Copy(DatabaseWrapper._InvocationWrapper, DatabaseWrapper._CodeWrapper, True)
				IL_6D5:
				num2 = 97
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFolderOptions", 0, 4)
				IL_6F3:
				num2 = 98
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\Hidden\SHOWALL", "CheckedValue", 1, 4)
				IL_711:
				num2 = 99
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 0, 4)
				IL_72F:
				num2 = 100
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 0, 4)
				IL_74D:
				num2 = 101
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 0, 4)
				IL_76B:
				num2 = 102
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 0, 4)
				IL_789:
				num2 = 103
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 1, 4)
				IL_7A7:
				num2 = 104
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 0, 4)
				IL_7C5:
				num2 = 105
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 0, 4)
				IL_7E3:
				num2 = 106
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 1, 4)
				IL_801:
				num2 = 107
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 0, 4)
				IL_81F:
				num2 = 108
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 0, 4)
				IL_83D:
				num2 = 109
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 0, 4)
				IL_85B:
				num2 = 110
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 0, 4)
				IL_879:
				num2 = 111
				Interaction.Shell("sc delete zmserv", AppWinStyle.Hide, True, -1)
				IL_88A:
				num2 = 112
				File.Copy(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.wav")), Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.reg")), True)
				IL_8B5:
				num2 = 113
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("regedit.exe /s ", obj), "\huifu.reg")), AppWinStyle.Hide, True, -1)
				IL_8DC:
				num2 = 114
				Thread.Sleep(2000)
				IL_8E9:
				num2 = 115
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.reg")), FileAttributes.Normal)
				IL_907:
				num2 = 116
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.reg")))
				IL_920:
				num2 = 117
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.reg")), FileAttributes.Normal)
				IL_93E:
				num2 = 118
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.reg")))
				IL_957:
				num2 = 119
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayContextMenu", 0, 4)
				IL_975:
				num2 = 120
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton", 1, 4)
				IL_993:
				num2 = 121
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "Control Panel\Desktop", "AutoEndTasks")
				IL_9AA:
				num2 = 122
				File.SetAttributes("C:\Program Files\Microsoft Games", FileAttributes.Normal)
				IL_9BC:
				num2 = 123
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters", "DisabledComponents", 0, 4)
				Do
					IL_A29:
					num2 = 125
					IL_9DC:
					num2 = 126
					processesByName = Process.GetProcessesByName(text2)
					IL_9E8:
					num2 = 127
					processesByName(0).Kill()
					IL_9F4:
					num2 = 128
					processesByName2 = Process.GetProcessesByName(text3)
					IL_A03:
					num2 = 129
					processesByName2(0).Kill()
					IL_A12:
					num2 = 130
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				IL_A2E:
				num2 = 133
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat", FileAttributes.Normal)
				IL_A4D:
				num2 = 134
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\przs.dat", FileAttributes.Normal)
				IL_A6C:
				num2 = 135
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\zmserv.dat", FileAttributes.Normal)
				IL_A8B:
				num2 = 136
				File.SetAttributes(DatabaseWrapper._ErrorWrapper, FileAttributes.Normal)
				IL_AA0:
				num2 = 137
				File.Delete(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat")
				IL_ABA:
				num2 = 138
				File.Delete(DatabaseWrapper._ErrorWrapper + "\przs.dat")
				IL_AD4:
				num2 = 139
				File.Delete(DatabaseWrapper._ErrorWrapper + "\zmserv.dat")
				IL_AEE:
				num2 = 140
				Directory.Delete(DatabaseWrapper._ErrorWrapper)
				IL_AFE:
				num2 = 141
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")), FileAttributes.Normal)
				IL_B1F:
				num2 = 142
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")), FileAttributes.Normal)
				IL_B40:
				num2 = 143
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")), FileAttributes.Normal)
				IL_B61:
				num2 = 144
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")), FileAttributes.Normal)
				IL_B82:
				num2 = 145
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.wav")), FileAttributes.Normal)
				IL_BA3:
				num2 = 146
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")))
				IL_BBF:
				num2 = 147
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")))
				IL_BDB:
				num2 = 148
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")))
				IL_BF7:
				num2 = 149
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")))
				IL_C13:
				num2 = 150
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.wav")))
				IL_C2F:
				num2 = 151
				File.SetAttributes("C:\Windows\Microsoft.NET", FileAttributes.Normal)
				IL_C44:
				num2 = 152
				Thread.Sleep(3000)
				IL_C54:
				num2 = 153
				For Each process As Process In Process.GetProcessesByName("explorer")
					IL_C72:
					num2 = 154
					process.Kill()
					IL_C7F:
					num2 = 155
				Next
				IL_C93:
				num2 = 156
				Process.Start("explorer.exe")
				IL_CA4:
				GoTo IL_F6E
				IL_CA9:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_F2D:
				GoTo IL_F63
				IL_F2F:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F40:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_F2F
			End Try
			IL_F63:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F6E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600004F RID: 79
		Private Declare Auto Function CryptAcquireContext Lib "advapi32.dll" (ByRef intptr_0 As IntPtr, string_0 As String, string_1 As String, int_0 As Integer, int_1 As Integer) As Boolean

		' Token: 0x06000050 RID: 80
		Private Declare Auto Function CryptCreateHash Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, intptr_1 As IntPtr, int_1 As Integer, ByRef intptr_2 As IntPtr) As Boolean

		' Token: 0x06000051 RID: 81
		Private Declare Auto Function CryptHashData Lib "advapi32.dll" (intptr_0 As IntPtr, byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Boolean

		' Token: 0x06000052 RID: 82
		Private Declare Auto Function CryptGetHashParam Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, byte_0 As Byte(), ByRef int_1 As Integer, int_2 As Integer) As Boolean

		' Token: 0x06000053 RID: 83
		Private Declare Function CryptDestroyHash Lib "advapi32.dll" (intptr_0 As IntPtr) As Boolean

		' Token: 0x06000054 RID: 84
		Private Declare Function CryptReleaseContext Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer) As Boolean

		' Token: 0x06000055 RID: 85 RVA: 0x000047D4 File Offset: 0x000029D4
		Public Function FlushConsumer(string_0 As String) As String
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

		' Token: 0x06000056 RID: 86 RVA: 0x00004858 File Offset: 0x00002A58
		Public Function TestConsumer(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, Optional object_0 As Object = Nothing) As Object
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

		' Token: 0x06000057 RID: 87 RVA: 0x00004920 File Offset: 0x00002B20
		Public Sub CompareConsumer(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, object_0 As Object, Optional registryValueKind_0 As RegistryValueKind = 1)
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

		' Token: 0x06000058 RID: 88 RVA: 0x000049C0 File Offset: 0x00002BC0
		Public Sub ForgotConsumer(registryKey_0 As RegistryKey, string_0 As String, string_1 As String)
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

		' Token: 0x06000059 RID: 89 RVA: 0x00004A2C File Offset: 0x00002C2C
		Public Function PublishConsumer(registryKey_0 As RegistryKey, string_0 As String) As Boolean
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

		' Token: 0x0600005A RID: 90 RVA: 0x00004A80 File Offset: 0x00002C80
		Public Function CreateConsumer(registryKey_0 As RegistryKey, string_0 As String) As Boolean
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

		' Token: 0x0600005B RID: 91 RVA: 0x00004B04 File Offset: 0x00002D04
		Public Sub ConcatConsumer(registryKey_0 As RegistryKey, string_0 As String)
			Try
				If DatabaseWrapper.PublishConsumer(registryKey_0, string_0) Then
					registryKey_0.DeleteSubKey(string_0)
				End If
			Catch ex As Exception
				Throw New Exception("删除注册表键时发生错误: " + ex.Message)
			End Try
		End Sub

		' Token: 0x04000027 RID: 39
		Private _CodeWrapper As String = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts"

		' Token: 0x04000028 RID: 40
		Private _InvocationWrapper As String = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts-bak"

		' Token: 0x04000029 RID: 41
		Private _ErrorWrapper As String = "C:\windows\jf"

		' Token: 0x0400002A RID: 42
		Public _ParserWrapper As String

		' Token: 0x0400002B RID: 43
		Public propertyWrapper As String

		' Token: 0x0400002C RID: 44
		Public _TemplateWrapper As String

		' Token: 0x0400002D RID: 45
		Private Const attributeWrapper As Integer = 1

		' Token: 0x0400002E RID: 46
		Private Const m_AuthenticationWrapper As Integer = -268435456

		' Token: 0x0400002F RID: 47
		Private Const _CustomerWrapper As Integer = 32771

		' Token: 0x04000030 RID: 48
		Private Const _CandidateWrapper As Integer = 2
	End Module
End Namespace
