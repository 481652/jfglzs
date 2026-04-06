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

	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module CandidateCollection
	
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property PrintContext As CollectionCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection.descriptorCollection.ViewContext()
			End Get
		End Property

	
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property CollectContext As ContextCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection.m_ConsumerCollection.ViewContext()
			End Get
		End Property

	
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		<HelpKeyword("My.User")>
		Friend ReadOnly Property SetupContext As User
			<DebuggerHidden()>
			Get
				Return CandidateCollection.methodCollection.ViewContext()
			End Get
		End Property

	
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property PrepareContext As CandidateCollection.ExceptionCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection._RepositoryCollection.ViewContext()
			End Get
		End Property

	
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property CompareContext As CandidateCollection.ExpressionCollection
			<DebuggerHidden()>
			Get
				Return CandidateCollection.interceptorCollection.ViewContext()
			End Get
		End Property

	
		Private descriptorCollection As CandidateCollection.AlgoCollection(Of CollectionCollection) = New CandidateCollection.AlgoCollection(Of CollectionCollection)()

	
		Private m_ConsumerCollection As CandidateCollection.AlgoCollection(Of ContextCollection) = New CandidateCollection.AlgoCollection(Of ContextCollection)()

	
		Private methodCollection As CandidateCollection.AlgoCollection(Of User) = New CandidateCollection.AlgoCollection(Of User)()

	
		Private _RepositoryCollection As CandidateCollection.AlgoCollection(Of CandidateCollection.ExceptionCollection) = New CandidateCollection.AlgoCollection(Of CandidateCollection.ExceptionCollection)()

	
		Private interceptorCollection As CandidateCollection.AlgoCollection(Of CandidateCollection.ExpressionCollection) = New CandidateCollection.AlgoCollection(Of CandidateCollection.ExpressionCollection)()

	
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ExceptionCollection
		
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

		
			<DebuggerHidden()>
			Private Sub CallContext(Of T As Form)(ByRef gparam_0 As T)
				gparam_0.Dispose()
				gparam_0 = Nothing
			End Sub

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function PatchContext() As Type
				Return GetType(CandidateCollection.ExceptionCollection)
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
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

		
			<ThreadStatic()>
			Private Shared _MappingCollection As Hashtable

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public requestCollection As Form1

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_BroadcasterCollection As Form3

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public paramCollection As load
		End Class

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class ExpressionCollection
		
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

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function ResetContext() As Type
				Return GetType(CandidateCollection.ExpressionCollection)
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
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

		
			<DebuggerHidden()>
			Private Sub SetContext(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class AlgoCollection(Of T As New)
		
			<DebuggerHidden()>
			Friend Function ViewContext() As T
				If CandidateCollection.AlgoCollection(Of T).connectionCollection Is Nothing Then
					CandidateCollection.AlgoCollection(Of T).connectionCollection = Activator.CreateInstance(Of T)()
				End If
				Return CandidateCollection.AlgoCollection(Of T).connectionCollection
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

		
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared connectionCollection As T
		End Class
	End Module
End Namespace
