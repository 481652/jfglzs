Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports WindowsApplication1

Namespace [set].Internal
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module CandidateCollection
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property PrintContext As CollectionCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection.descriptorCollection.ViewContext()
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property CollectContext As ContextCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection.m_ConsumerCollection.ViewContext()
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		<HelpKeyword("My.User")>
		Friend ReadOnly Property SetupContext As User
			<DebuggerHidden()>
			Get
				Return CandidateCollection.methodCollection.ViewContext()
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property PrepareContext As CandidateCollection.ExceptionCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection._RepositoryCollection.ViewContext()
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property CompareContext As CandidateCollection.ExpressionCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection.interceptorCollection.ViewContext()
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private descriptorCollection As CandidateCollection.AlgoCollection(Of CollectionCollection) = New CandidateCollection.AlgoCollection(Of CollectionCollection)()

		' Token: 0x04000002 RID: 2
		Private m_ConsumerCollection As CandidateCollection.AlgoCollection(Of ContextCollection) = New CandidateCollection.AlgoCollection(Of ContextCollection)()

		' Token: 0x04000003 RID: 3
		Private methodCollection As CandidateCollection.AlgoCollection(Of User) = New CandidateCollection.AlgoCollection(Of User)()

		' Token: 0x04000004 RID: 4
		Private _RepositoryCollection As CandidateCollection.AlgoCollection(Of CandidateCollection.ExceptionCollection) = New CandidateCollection.AlgoCollection(Of CandidateCollection.ExceptionCollection)()

		' Token: 0x04000005 RID: 5
		Private interceptorCollection As CandidateCollection.AlgoCollection(Of CandidateCollection.ExpressionCollection) = New CandidateCollection.AlgoCollection(Of CandidateCollection.ExpressionCollection)()

		' Token: 0x02000005 RID: 5
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ExceptionCollection
			' Token: 0x0600000B RID: 11 RVA: 0x00002AA8 File Offset: 0x00000CA8
			<DebuggerHidden()>
			Private Shared Function ReadContext(Of T As{Form, New})(Instance As T) As T
				Dim result As T
				If Instance IsNot Nothing AndAlso Not Instance.IsDisposed Then
					result = Instance
				Else
					If CandidateCollection.ExceptionCollection._MappingCollection IsNot Nothing Then
						If CandidateCollection.ExceptionCollection._MappingCollection.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						CandidateCollection.ExceptionCollection._MappingCollection = New Hashtable()
					End If
					CandidateCollection.ExceptionCollection._MappingCollection.Add(GetType(T), Nothing)
					Try
						result = Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
					Finally
						CandidateCollection.ExceptionCollection._MappingCollection.Remove(GetType(T))
					End Try
				End If
				Return result
			End Function

			' Token: 0x0600000C RID: 12 RVA: 0x0000227A File Offset: 0x0000047A
			<DebuggerHidden()>
			Private Sub CallContext(Of T As Form)(ByRef gparam_0 As T)
				gparam_0.Dispose()
				gparam_0 = Nothing
			End Sub

			' Token: 0x0600000D RID: 13 RVA: 0x0000228F File Offset: 0x0000048F
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0600000E RID: 14 RVA: 0x00002297 File Offset: 0x00000497
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

			' Token: 0x0600000F RID: 15 RVA: 0x000022A5 File Offset: 0x000004A5
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000010 RID: 16 RVA: 0x000022AD File Offset: 0x000004AD
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function PatchContext() As Type
				Return GetType(CandidateCollection.ExceptionCollection)
			End Function

			' Token: 0x06000011 RID: 17 RVA: 0x000022BA File Offset: 0x000004BA
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000006 RID: 6
			' (get) Token: 0x06000012 RID: 18 RVA: 0x000022C2 File Offset: 0x000004C2
			' (set) Token: 0x06000015 RID: 21 RVA: 0x0000230D File Offset: 0x0000050D
			Public Property Form1 As Form1
				Get
					Me.requestCollection = CandidateCollection.ExceptionCollection.ReadContext(Of Form1)(Me.requestCollection)
					Return Me.requestCollection
				End Get
				Set(value As Form1)
					If value IsNot Me.requestCollection Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.CallContext(Of Form1)(Me.requestCollection)
					End If
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x06000013 RID: 19 RVA: 0x000022DB File Offset: 0x000004DB
			' (set) Token: 0x06000016 RID: 22 RVA: 0x00002332 File Offset: 0x00000532
			Public Property Form3 As Form3
				Get
					Me.m_BroadcasterCollection = CandidateCollection.ExceptionCollection.ReadContext(Of Form3)(Me.m_BroadcasterCollection)
					Return Me.m_BroadcasterCollection
				End Get
				Set(value As Form3)
					If value IsNot Me.m_BroadcasterCollection Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.CallContext(Of Form3)(Me.m_BroadcasterCollection)
					End If
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x06000014 RID: 20 RVA: 0x000022F4 File Offset: 0x000004F4
			' (set) Token: 0x06000017 RID: 23 RVA: 0x00002357 File Offset: 0x00000557
			Public Property load As load
				Get
					Me.paramCollection = CandidateCollection.ExceptionCollection.ReadContext(Of load)(Me.paramCollection)
					Return Me.paramCollection
				End Get
				Set(value As load)
					If value IsNot Me.paramCollection Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.CallContext(Of load)(Me.paramCollection)
					End If
				End Set
			End Property

			' Token: 0x04000006 RID: 6
			<ThreadStatic()>
			Private Shared _MappingCollection As Hashtable

			' Token: 0x04000007 RID: 7
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public requestCollection As Form1

			' Token: 0x04000008 RID: 8
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_BroadcasterCollection As Form3

			' Token: 0x04000009 RID: 9
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public paramCollection As load
		End Class

		' Token: 0x02000006 RID: 6
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class ExpressionCollection
			' Token: 0x06000018 RID: 24 RVA: 0x00002297 File Offset: 0x00000497
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

			' Token: 0x06000019 RID: 25 RVA: 0x000022A5 File Offset: 0x000004A5
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600001A RID: 26 RVA: 0x0000237C File Offset: 0x0000057C
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ResetContext() As Type
				Return GetType(CandidateCollection.ExpressionCollection)
			End Function

			' Token: 0x0600001B RID: 27 RVA: 0x000022BA File Offset: 0x000004BA
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600001C RID: 28 RVA: 0x00002BAC File Offset: 0x00000DAC
			<DebuggerHidden()>
			Private Shared Function AddContext(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x0600001D RID: 29 RVA: 0x00002389 File Offset: 0x00000589
			<DebuggerHidden()>
			Private Sub SetContext(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

			' Token: 0x0600001E RID: 30 RVA: 0x0000228F File Offset: 0x0000048F
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class AlgoCollection(Of T As New)
			' Token: 0x0600001F RID: 31 RVA: 0x00002392 File Offset: 0x00000592
			<DebuggerHidden()>
			Friend Function ViewContext() As T
				If CandidateCollection.AlgoCollection(Of T).connectionCollection Is Nothing Then
					CandidateCollection.AlgoCollection(Of T).connectionCollection = Activator.CreateInstance(Of T)()
				End If
				Return CandidateCollection.AlgoCollection(Of T).connectionCollection
			End Function

			' Token: 0x06000020 RID: 32 RVA: 0x0000228F File Offset: 0x0000048F
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0400000A RID: 10
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared connectionCollection As T
		End Class
	End Module
End Namespace
