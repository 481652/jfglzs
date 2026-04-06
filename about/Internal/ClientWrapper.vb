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

Namespace about.Internal

	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module ClientWrapper
	
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property CalcPolicy As ConfigWrapper
			<DebuggerHidden()>
			Get
				Return ClientWrapper._ExceptionWrapper.PrintPolicy()
			End Get
		End Property

	
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property PostPolicy As PolicyWrapper
			<DebuggerHidden()>
			Get
				Return ClientWrapper.m_IdentifierWrapper.PrintPolicy()
			End Get
		End Property

	
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		<HelpKeyword("My.User")>
		Friend ReadOnly Property AddPolicy As User
			<DebuggerHidden()>
			Get
				Return ClientWrapper.valueWrapper.PrintPolicy()
			End Get
		End Property

	
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property DestroyPolicy As ClientWrapper.SetterWrapper
			<DebuggerHidden()>
			Get
				Return ClientWrapper.stubWrapper.PrintPolicy()
			End Get
		End Property

	
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property UpdatePolicy As ClientWrapper.InterpreterWrapper
			<DebuggerHidden()>
			Get
				Return ClientWrapper.rulesWrapper.PrintPolicy()
			End Get
		End Property

	
		Private _ExceptionWrapper As ClientWrapper.RegWrapper(Of ConfigWrapper) = New ClientWrapper.RegWrapper(Of ConfigWrapper)()

	
		Private m_IdentifierWrapper As ClientWrapper.RegWrapper(Of PolicyWrapper) = New ClientWrapper.RegWrapper(Of PolicyWrapper)()

	
		Private valueWrapper As ClientWrapper.RegWrapper(Of User) = New ClientWrapper.RegWrapper(Of User)()

	
		Private stubWrapper As ClientWrapper.RegWrapper(Of ClientWrapper.SetterWrapper) = New ClientWrapper.RegWrapper(Of ClientWrapper.SetterWrapper)()

	
		Private rulesWrapper As ClientWrapper.RegWrapper(Of ClientWrapper.InterpreterWrapper) = New ClientWrapper.RegWrapper(Of ClientWrapper.InterpreterWrapper)()

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class SetterWrapper
		
			<DebuggerHidden()>
			Private Shared Function ResolvePolicy(Of T As{Form, New})(Instance As T) As T
				Dim result As T
				If Instance IsNot Nothing AndAlso Not Instance.IsDisposed Then
					result = Instance
				Else
					If ClientWrapper.SetterWrapper._MessageWrapper IsNot Nothing Then
						If ClientWrapper.SetterWrapper._MessageWrapper.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						ClientWrapper.SetterWrapper._MessageWrapper = New Hashtable()
					End If
					ClientWrapper.SetterWrapper._MessageWrapper.Add(GetType(T), Nothing)
					Try
						result = Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
					Finally
						ClientWrapper.SetterWrapper._MessageWrapper.Remove(GetType(T))
					End Try
				End If
				Return result
			End Function

		
			<DebuggerHidden()>
			Private Sub CreatePolicy(Of T As Form)(ByRef gparam_0 As T)
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
			Friend Function TestPolicy() As Type
				Return GetType(ClientWrapper.SetterWrapper)
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
			' (get) Token: 0x06000012 RID: 18 RVA: 0x000022C2 File Offset: 0x000004C2
			' (set) Token: 0x06000014 RID: 20 RVA: 0x000022F4 File Offset: 0x000004F4
			Public Property Form1 As Form1
				Get
					Me.m_BridgeWrapper = ClientWrapper.SetterWrapper.ResolvePolicy(Of Form1)(Me.m_BridgeWrapper)
					Return Me.m_BridgeWrapper
				End Get
				Set(value As Form1)
					If value IsNot Me.m_BridgeWrapper Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.CreatePolicy(Of Form1)(Me.m_BridgeWrapper)
					End If
				End Set
			End Property

		
			' (get) Token: 0x06000013 RID: 19 RVA: 0x000022DB File Offset: 0x000004DB
			' (set) Token: 0x06000015 RID: 21 RVA: 0x00002319 File Offset: 0x00000519
			Public Property Form3 As Form3
				Get
					Me.m_ServiceWrapper = ClientWrapper.SetterWrapper.ResolvePolicy(Of Form3)(Me.m_ServiceWrapper)
					Return Me.m_ServiceWrapper
				End Get
				Set(value As Form3)
					If value IsNot Me.m_ServiceWrapper Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.CreatePolicy(Of Form3)(Me.m_ServiceWrapper)
					End If
				End Set
			End Property

		
			<ThreadStatic()>
			Private Shared _MessageWrapper As Hashtable

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_BridgeWrapper As Form1

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ServiceWrapper As Form3
		End Class

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class InterpreterWrapper
		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function GetPolicy() As Type
				Return GetType(ClientWrapper.InterpreterWrapper)
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
			<DebuggerHidden()>
			Private Shared Function PopPolicy(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

		
			<DebuggerHidden()>
			Private Sub ReadPolicy(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class RegWrapper(Of T As New)
		
			<DebuggerHidden()>
			Friend Function PrintPolicy() As T
				If ClientWrapper.RegWrapper(Of T).issuerWrapper Is Nothing Then
					ClientWrapper.RegWrapper(Of T).issuerWrapper = Activator.CreateInstance(Of T)()
				End If
				Return ClientWrapper.RegWrapper(Of T).issuerWrapper
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

		
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared issuerWrapper As T
		End Class
	End Module
End Namespace
