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

	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module ClassMock
	
		' (get) Token: 0x06000004 RID: 4 RVA: 0x000021EE File Offset: 0x000003EE
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property MoveClass As ProcWrapper
			<DebuggerHidden()>
			Get
				Return ClassMock.m_WrapperMock.CompareClass()
			End Get
		End Property

	
		' (get) Token: 0x06000005 RID: 5 RVA: 0x000021FA File Offset: 0x000003FA
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property ReflectClass As ConnectionWrapper
			<DebuggerHidden()>
			Get
				Return ClassMock._MockMock.CompareClass()
			End Get
		End Property

	
		' (get) Token: 0x06000006 RID: 6 RVA: 0x00002206 File Offset: 0x00000406
		<HelpKeyword("My.User")>
		Friend ReadOnly Property RemoveClass As User
			<DebuggerHidden()>
			Get
				Return ClassMock.algoMock.CompareClass()
			End Get
		End Property

	
		' (get) Token: 0x06000007 RID: 7 RVA: 0x00002212 File Offset: 0x00000412
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property AssetClass As ClassMock.ExporterMock
			<DebuggerHidden()>
			Get
				Return ClassMock.singletonMock.CompareClass()
			End Get
		End Property

	
		Private m_WrapperMock As ClassMock.TestMock(Of ProcWrapper) = New ClassMock.TestMock(Of ProcWrapper)()

	
		Private _MockMock As ClassMock.TestMock(Of ConnectionWrapper) = New ClassMock.TestMock(Of ConnectionWrapper)()

	
		Private algoMock As ClassMock.TestMock(Of User) = New ClassMock.TestMock(Of User)()

	
		Private singletonMock As ClassMock.TestMock(Of ClassMock.ExporterMock) = New ClassMock.TestMock(Of ClassMock.ExporterMock)()

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class ExporterMock
		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function DestroyClass() As Type
				Return GetType(ClassMock.ExporterMock)
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
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

		
			<DebuggerHidden()>
			Private Sub InterruptClass(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

	
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class TestMock(Of T As New)
		
			<DebuggerHidden()>
			Friend Function CompareClass() As T
				If ClassMock.TestMock(Of T).m_AccountMock Is Nothing Then
					ClassMock.TestMock(Of T).m_AccountMock = Activator.CreateInstance(Of T)()
				End If
				Return ClassMock.TestMock(Of T).m_AccountMock
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

		
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_AccountMock As T
		End Class
	End Module
End Namespace
