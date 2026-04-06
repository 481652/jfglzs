Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace zmserv.Internal
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module ClassMock
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000004 RID: 4 RVA: 0x000021EE File Offset: 0x000003EE
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property MoveClass As ProcWrapper
			<DebuggerHidden()>
			Get
				Return ClassMock.m_WrapperMock.CompareClass()
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000005 RID: 5 RVA: 0x000021FA File Offset: 0x000003FA
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property ReflectClass As ConnectionWrapper
			<DebuggerHidden()>
			Get
				Return ClassMock._MockMock.CompareClass()
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000006 RID: 6 RVA: 0x00002206 File Offset: 0x00000406
		<HelpKeyword("My.User")>
		Friend ReadOnly Property RemoveClass As User
			<DebuggerHidden()>
			Get
				Return ClassMock.algoMock.CompareClass()
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000007 RID: 7 RVA: 0x00002212 File Offset: 0x00000412
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property AssetClass As ClassMock.ExporterMock
			<DebuggerHidden()>
			Get
				Return ClassMock.singletonMock.CompareClass()
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_WrapperMock As ClassMock.TestMock(Of ProcWrapper) = New ClassMock.TestMock(Of ProcWrapper)()

		' Token: 0x04000002 RID: 2
		Private _MockMock As ClassMock.TestMock(Of ConnectionWrapper) = New ClassMock.TestMock(Of ConnectionWrapper)()

		' Token: 0x04000003 RID: 3
		Private algoMock As ClassMock.TestMock(Of User) = New ClassMock.TestMock(Of User)()

		' Token: 0x04000004 RID: 4
		Private singletonMock As ClassMock.TestMock(Of ClassMock.ExporterMock) = New ClassMock.TestMock(Of ClassMock.ExporterMock)()

		' Token: 0x02000005 RID: 5
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class ExporterMock
			' Token: 0x06000008 RID: 8 RVA: 0x0000221E File Offset: 0x0000041E
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

			' Token: 0x06000009 RID: 9 RVA: 0x0000222C File Offset: 0x0000042C
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600000A RID: 10 RVA: 0x00002234 File Offset: 0x00000434
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function DestroyClass() As Type
				Return GetType(ClassMock.ExporterMock)
			End Function

			' Token: 0x0600000B RID: 11 RVA: 0x00002241 File Offset: 0x00000441
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600000C RID: 12 RVA: 0x000024D4 File Offset: 0x000006D4
			<DebuggerHidden()>
			Private Shared Function LoginClass(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x0600000D RID: 13 RVA: 0x00002249 File Offset: 0x00000449
			<DebuggerHidden()>
			Private Sub InterruptClass(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

			' Token: 0x0600000E RID: 14 RVA: 0x00002252 File Offset: 0x00000452
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000006 RID: 6
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class TestMock(Of T As New)
			' Token: 0x0600000F RID: 15 RVA: 0x0000225A File Offset: 0x0000045A
			<DebuggerHidden()>
			Friend Function CompareClass() As T
				If ClassMock.TestMock(Of T).m_AccountMock Is Nothing Then
					ClassMock.TestMock(Of T).m_AccountMock = Activator.CreateInstance(Of T)()
				End If
				Return ClassMock.TestMock(Of T).m_AccountMock
			End Function

			' Token: 0x06000010 RID: 16 RVA: 0x00002252 File Offset: 0x00000452
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x04000005 RID: 5
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_AccountMock As T
		End Class
	End Module
End Namespace
