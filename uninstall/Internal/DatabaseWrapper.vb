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

	Friend NotInheritable Module DatabaseWrapper
	
		Public Sub AssetConsumer()
			Dim obj2 As Object
			Try

				ProjectData.ClearProjectError()

				Dim num2 As Integer = 2
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(DatabaseWrapper.TestConsumer(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				If Not Operators.ConditionalCompareObjectEqual(objectValue, "", False) Then
				End If
				objectValue = RuntimeHelpers.GetObjectValue(DatabaseWrapper.TestConsumer(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs", ""))
				Dim obj As Object = Strings.Mid(Conversions.ToString(objectValue), 1, Strings.Len(RuntimeHelpers.GetObjectValue(objectValue)) - 9)
				Dim text As String = "zmserv"
				Dim text2 As String = Conversions.ToString(DatabaseWrapper._ParserWrapper)
				Dim text3 As String = "jfglzsn"
				Dim processesByName As Process()
				Dim processesByName2 As Process()
				Do
					processesByName = Process.GetProcessesByName(text2)
					processesByName(0).Kill()
					processesByName2 = Process.GetProcessesByName(text3)
					processesByName2(0).Kill()
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat", FileAttributes.Normal)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\przs.dat", FileAttributes.Normal)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\zmserv.dat", FileAttributes.Normal)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper, FileAttributes.Normal)
				File.Delete(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat")
				File.Delete(DatabaseWrapper._ErrorWrapper + "\przs.dat")
				File.Delete(DatabaseWrapper._ErrorWrapper + "\zmserv.dat")
				Directory.Delete(DatabaseWrapper._ErrorWrapper)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")), FileAttributes.Normal)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")), FileAttributes.Normal)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")), FileAttributes.Normal)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")), FileAttributes.Normal)
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")))
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")))
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")))
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")))
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 0, 4)
				Dim text4 As String = Conversions.ToString(DatabaseWrapper.TestConsumer(Registry.CurrentUser, "Software\jfglzs", "dzjs", ""))
				Dim text5 As String = text4
				Dim str As String = Strings.Mid(text5, 1, Strings.Len(text5) - 16)
				File.SetAttributes(str + "\SpecialSet.exe", FileAttributes.Normal)
				Interaction.Shell("net stop zmserv", AppWinStyle.Hide, True, -1)
				Thread.Sleep(3000)
				Dim processesByName3 As Process() = Process.GetProcessesByName(text)
				processesByName3(0).Kill()
				Dim registryKey As RegistryKey = Template.CountConsumer.Registry.LocalMachine
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs")
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn")
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "prozs")
				DatabaseWrapper.ForgotConsumer(Registry.LocalMachine, "SOFTWARE\WOW6432NODE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN", "jfglzsn")
				Interaction.Shell("cmd /c bcdedit /set {bootmgr} displaybootmenu yes", AppWinStyle.MinimizedFocus, False, -1)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\usbstor", "Start", 3, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\ControlSet001\Services\usbstor", "Start", 3, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\ControlSet002\Services\usbstor", "Start", 3, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\ControlSet003\Services\usbstor", "Start", 3, 4)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableLockWorkstation", 0, 4)
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "software", "n")
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "software", "dtmm")
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "software", "czmm")
				registryKey = Template.CountConsumer.Registry.CurrentUser
				Dim registryKey2 As RegistryKey = registryKey.OpenSubKey("Software\jfglzs")
				If registryKey2 Is Nothing Then
				End If
				registryKey.DeleteSubKey("Software\jfglzs")
				registryKey = Template.CountConsumer.Registry.LocalMachine
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\taskkill.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\ntsd.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\sidebar.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Chess.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\FreeCell.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Hearts.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Minesweeper.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Mahjong.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\SpiderSolitaire.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\bckgzm.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\chkrzm.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\shvlzm.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Solitaire.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winmine")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\PurblePlace.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\Magnify.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\sethc.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\tasklist.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\taskkill.exe")
				registryKey.DeleteSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\route.exe")
				registryKey = Template.CountConsumer.Registry.LocalMachine
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Google\Chrome")
				If registryKey2 Is Nothing Then
				End If
				registryKey.DeleteSubKey("Software\Policies\Google\Chrome")
				registryKey2 = registryKey.OpenSubKey("Software\Policies\Microsoft\Edge")
				If registryKey2 Is Nothing Then
				End If
				registryKey.DeleteSubKey("Software\Policies\Microsoft\Edge")
				File.SetAttributes(DatabaseWrapper._CodeWrapper, FileAttributes.Normal)
				File.SetAttributes(DatabaseWrapper._InvocationWrapper, FileAttributes.Normal)
				File.SetAttributes("C:\Windows\System32\drivers\etc", FileAttributes.Normal)
				File.Copy(DatabaseWrapper._InvocationWrapper, DatabaseWrapper._CodeWrapper, True)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFolderOptions", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Folder\Hidden\SHOWALL", "CheckedValue", 1, 4)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "2200", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DownloadRestrictions", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "SaveAs", 1, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Edge", "DeveloperToolsAvailability", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DownloadRestrictions", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "SaveAs", 1, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Google\Chrome", "DeveloperToolsAvailability", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DisableDownloads", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "BlockAboutDownloads", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SOFTWARE\Policies\Mozilla\Firefox", "DeveloperToolsAvailability", 0, 4)
				Interaction.Shell("sc delete zmserv", AppWinStyle.Hide, True, -1)
				File.Copy(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.wav")), Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.reg")), True)
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("regedit.exe /s ", obj), "\huifu.reg")), AppWinStyle.Hide, True, -1)
				Thread.Sleep(2000)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.reg")), FileAttributes.Normal)
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.reg")))
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.reg")), FileAttributes.Normal)
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.reg")))
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayContextMenu", 0, 4)
				DatabaseWrapper.CompareConsumer(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton", 1, 4)
				DatabaseWrapper.ForgotConsumer(Registry.CurrentUser, "Control Panel\Desktop", "AutoEndTasks")
				File.SetAttributes("C:\Program Files\Microsoft Games", FileAttributes.Normal)
				DatabaseWrapper.CompareConsumer(Registry.LocalMachine, "SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters", "DisabledComponents", 0, 4)
				Do
					processesByName = Process.GetProcessesByName(text2)
					processesByName(0).Kill()
					processesByName2 = Process.GetProcessesByName(text3)
					processesByName2(0).Kill()
				Loop While Not(processesByName.Length = 0 And processesByName2.Length = 0)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat", FileAttributes.Normal)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\przs.dat", FileAttributes.Normal)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper + "\zmserv.dat", FileAttributes.Normal)
				File.SetAttributes(DatabaseWrapper._ErrorWrapper, FileAttributes.Normal)
				File.Delete(DatabaseWrapper._ErrorWrapper + "\jfglzsn.dat")
				File.Delete(DatabaseWrapper._ErrorWrapper + "\przs.dat")
				File.Delete(DatabaseWrapper._ErrorWrapper + "\zmserv.dat")
				Directory.Delete(DatabaseWrapper._ErrorWrapper)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")), FileAttributes.Normal)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")), FileAttributes.Normal)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")), FileAttributes.Normal)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")), FileAttributes.Normal)
				File.SetAttributes(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.wav")), FileAttributes.Normal)
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\jfglzsn.exe")))
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\zmserv.exe")))
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\przs.exe")))
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\yl.wav")))
				File.Delete(Conversions.ToString(Operators.ConcatenateObject(obj, "\huifu.wav")))
				File.SetAttributes("C:\Windows\Microsoft.NET", FileAttributes.Normal)
				Thread.Sleep(3000)
				For Each process As Process In Process.GetProcessesByName("explorer")
					process.Kill()
				Next
				Process.Start("explorer.exe")
				Dim num3 As Integer = num4 + 1
				num4 = num2
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
			End Try
		End Sub

	
		Private Declare Auto Function CryptAcquireContext Lib "advapi32.dll" (ByRef intptr_0 As IntPtr, string_0 As String, string_1 As String, int_0 As Integer, int_1 As Integer) As Boolean

	
		Private Declare Auto Function CryptCreateHash Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, intptr_1 As IntPtr, int_1 As Integer, ByRef intptr_2 As IntPtr) As Boolean

	
		Private Declare Auto Function CryptHashData Lib "advapi32.dll" (intptr_0 As IntPtr, byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Boolean

	
		Private Declare Auto Function CryptGetHashParam Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer, byte_0 As Byte(), ByRef int_1 As Integer, int_2 As Integer) As Boolean

	
		Private Declare Function CryptDestroyHash Lib "advapi32.dll" (intptr_0 As IntPtr) As Boolean

	
		Private Declare Function CryptReleaseContext Lib "advapi32.dll" (intptr_0 As IntPtr, int_0 As Integer) As Boolean

	
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

	
		Public Function TestConsumer(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, Optional object_0 As Object = Nothing) As Object
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

	
		Public Sub CompareConsumer(registryKey_0 As RegistryKey, string_0 As String, string_1 As String, object_0 As Object, Optional registryValueKind_0 As RegistryValueKind = 1)
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

	
		Public Sub ConcatConsumer(registryKey_0 As RegistryKey, string_0 As String)
			Try
				If DatabaseWrapper.PublishConsumer(registryKey_0, string_0) Then
					registryKey_0.DeleteSubKey(string_0)
				End If
			Catch ex As Exception
				Throw New Exception("删除注册表键时发生错误: " + ex.Message)
			End Try
		End Sub

	
		Private _CodeWrapper As String = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts"

	
		Private _InvocationWrapper As String = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\drivers\etc\hosts-bak"

	
		Private _ErrorWrapper As String = "C:\windows\jf"

	
		Public _ParserWrapper As String

	
		Public propertyWrapper As String

	
		Public _TemplateWrapper As String

	
		Private Const attributeWrapper As Integer = 1

	
		Private Const m_AuthenticationWrapper As Integer = -268435456

	
		Private Const _CustomerWrapper As Integer = 32771

	
		Private Const _CandidateWrapper As Integer = 2
	End Module
End Namespace
