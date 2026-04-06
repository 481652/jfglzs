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

Namespace uninstall.Internal

	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module Template
	
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property CountConsumer As Context
			<DebuggerHidden()>
			Get
				Return Template._Request.QueryConsumer()
			End Get
		End Property

	
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property CollectConsumer As Consumer
			<DebuggerHidden()>
			Get
				Return Template.m_Adapter.QueryConsumer()
			End Get
		End Property

	
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		<HelpKeyword("My.User")>
		Friend ReadOnly Property VisitConsumer As User
			<DebuggerHidden()>
			Get
				Return Template.m_Watcher.QueryConsumer()
			End Get
		End Property

	
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property ResetConsumer As Template.ItemWrapper
			<DebuggerHidden()>
			Get
				Return Template.broadcaster.QueryConsumer()
			End Get
		End Property

	
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property ResolveConsumer As Template.AdapterWrapper
			<DebuggerHidden()>
			Get
				Return Template.m_Factory.QueryConsumer()
			End Get
		End Property

	
		Private _Request As Template.ThreadWrapper(Of Context) = New Template.ThreadWrapper(Of Context)()

	
		Private m_Adapter As Template.ThreadWrapper(Of Consumer) = New Template.ThreadWrapper(Of Consumer)()

	
		Private m_Watcher As Template.ThreadWrapper(Of User) = New Template.ThreadWrapper(Of User)()

	
		Private broadcaster As Template.ThreadWrapper(Of Template.ItemWrapper) = New Template.ThreadWrapper(Of Template.ItemWrapper)()

	
		Private m_Factory As Template.ThreadWrapper(Of Template.AdapterWrapper) = New Template.ThreadWrapper(Of Template.AdapterWrapper)()

	
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ItemWrapper
		
			<DebuggerHidden()>
			Private Shared Function OrderConsumer(Of T As{Form, New})(Instance As T) As T
				Dim result As T
				If Instance IsNot Nothing AndAlso Not Instance.IsDisposed Then
					result = Instance
				Else
					If Template.ItemWrapper.m_AdvisorWrapper IsNot Nothing Then
						If Template.ItemWrapper.m_AdvisorWrapper.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						Template.ItemWrapper.m_AdvisorWrapper = New Hashtable()
					End If
					Template.ItemWrapper.m_AdvisorWrapper.Add(GetType(T), Nothing)
					Try
						result = Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
					Finally
						Template.ItemWrapper.m_AdvisorWrapper.Remove(GetType(T))
					End Try
				End If
				Return result
			End Function

		
			<DebuggerHidden()>
			Private Sub ChangeConsumer(Of T As Form)(ByRef gparam_0 As T)
				gparam_0.Dispose()
				gparam_0 = Nothing
			End Sub

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
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
			Friend Function ViewConsumer() As Type
				Return GetType(Template.ItemWrapper)
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
			' (get) Token: 0x06000012 RID: 18 RVA: 0x000022C2 File Offset: 0x000004C2
			' (set) Token: 0x06000014 RID: 20 RVA: 0x000022F4 File Offset: 0x000004F4
			Public Property Form1 As Form1
				Get
					Me._RequestWrapper = Template.ItemWrapper.OrderConsumer(Of Form1)(Me._RequestWrapper)
					Return Me._RequestWrapper
				End Get
				Set(value As Form1)
					If value IsNot Me._RequestWrapper Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.ChangeConsumer(Of Form1)(Me._RequestWrapper)
					End If
				End Set
			End Property

		
			' (get) Token: 0x06000013 RID: 19 RVA: 0x000022DB File Offset: 0x000004DB
			' (set) Token: 0x06000015 RID: 21 RVA: 0x00002319 File Offset: 0x00000519
			Public Property Form2 As Form2
				Get
					Me.serializerWrapper = Template.ItemWrapper.OrderConsumer(Of Form2)(Me.serializerWrapper)
					Return Me.serializerWrapper
				End Get
				Set(value As Form2)
					If value IsNot Me.serializerWrapper Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.ChangeConsumer(Of Form2)(Me.serializerWrapper)
					End If
				End Set
			End Property

		
			<ThreadStatic()>
			Private Shared m_AdvisorWrapper As Hashtable

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _RequestWrapper As Form1

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public serializerWrapper As Form2
		End Class

	
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class AdapterWrapper
		
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
			Friend Function DisableConsumer() As Type
				Return GetType(Template.AdapterWrapper)
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
			<DebuggerHidden()>
			Private Shared Function InitConsumer(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

		
			<DebuggerHidden()>
			Private Sub SetupConsumer(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

	
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadWrapper(Of T As New)
		
			<DebuggerHidden()>
			Friend Function QueryConsumer() As T
				If Template.ThreadWrapper(Of T).m_FieldWrapper Is Nothing Then
					Template.ThreadWrapper(Of T).m_FieldWrapper = Activator.CreateInstance(Of T)()
				End If
				Return Template.ThreadWrapper(Of T).m_FieldWrapper
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

		
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_FieldWrapper As T
		End Class
	End Module
End Namespace
