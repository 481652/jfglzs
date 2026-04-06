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

Namespace przs.Internal

	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module Value
	
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property PopAttribute As Definition
			<DebuggerHidden()>
			Get
				Return Value.m_Reg.DefineAttribute()
			End Get
		End Property

	
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property SetAttribute As Attribute
			<DebuggerHidden()>
			Get
				Return Value.attr.DefineAttribute()
			End Get
		End Property

	
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		<HelpKeyword("My.User")>
		Friend ReadOnly Property RemoveAttribute As User
			<DebuggerHidden()>
			Get
				Return Value.m_Method.DefineAttribute()
			End Get
		End Property

	
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property SetupAttribute As Value.Parser
			<DebuggerHidden()>
			Get
				Return Value._State.DefineAttribute()
			End Get
		End Property

	
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property FlushAttribute As Value.Connection
			<DebuggerHidden()>
			Get
				Return Value.code.DefineAttribute()
			End Get
		End Property

	
		Private m_Reg As Value.Mock(Of Definition) = New Value.Mock(Of Definition)()

	
		Private attr As Value.Mock(Of Attribute) = New Value.Mock(Of Attribute)()

	
		Private m_Method As Value.Mock(Of User) = New Value.Mock(Of User)()

	
		Private _State As Value.Mock(Of Value.Parser) = New Value.Mock(Of Value.Parser)()

	
		Private code As Value.Mock(Of Value.Connection) = New Value.Mock(Of Value.Connection)()

	
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class Parser
		
			<DebuggerHidden()>
			Private Shared Function RestartAttribute(Of T As{Form, New})(Instance As T) As T
				Dim result As T
				If Instance IsNot Nothing AndAlso Not Instance.IsDisposed Then
					result = Instance
				Else
					If Value.Parser._Setter IsNot Nothing Then
						If Value.Parser._Setter.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						Value.Parser._Setter = New Hashtable()
					End If
					Value.Parser._Setter.Add(GetType(T), Nothing)
					Try
						result = Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
					Finally
						Value.Parser._Setter.Remove(GetType(T))
					End Try
				End If
				Return result
			End Function

		
			<DebuggerHidden()>
			Private Sub TestAttribute(Of T As Form)(ByRef gparam_0 As T)
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
			Friend Function DisableAttribute() As Type
				Return GetType(Value.Parser)
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
			' (get) Token: 0x06000012 RID: 18 RVA: 0x000022C2 File Offset: 0x000004C2
			' (set) Token: 0x06000017 RID: 23 RVA: 0x0000233F File Offset: 0x0000053F
			Public Property bianhao As bianhao
				Get
					Me._Customer = Value.Parser.RestartAttribute(Of bianhao)(Me._Customer)
					Return Me._Customer
				End Get
				Set(value As bianhao)
					If value IsNot Me._Customer Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.TestAttribute(Of bianhao)(Me._Customer)
					End If
				End Set
			End Property

		
			' (get) Token: 0x06000013 RID: 19 RVA: 0x000022DB File Offset: 0x000004DB
			' (set) Token: 0x06000018 RID: 24 RVA: 0x00002364 File Offset: 0x00000564
			Public Property Form1 As Form1
				Get
					Me._Getter = Value.Parser.RestartAttribute(Of Form1)(Me._Getter)
					Return Me._Getter
				End Get
				Set(value As Form1)
					If value IsNot Me._Getter Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.TestAttribute(Of Form1)(Me._Getter)
					End If
				End Set
			End Property

		
			' (get) Token: 0x06000014 RID: 20 RVA: 0x000022F4 File Offset: 0x000004F4
			' (set) Token: 0x06000019 RID: 25 RVA: 0x00002389 File Offset: 0x00000589
			Public Property Form2 As Form2
				Get
					Me.server = Value.Parser.RestartAttribute(Of Form2)(Me.server)
					Return Me.server
				End Get
				Set(value As Form2)
					If value IsNot Me.server Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.TestAttribute(Of Form2)(Me.server)
					End If
				End Set
			End Property

		
			' (get) Token: 0x06000015 RID: 21 RVA: 0x0000230D File Offset: 0x0000050D
			' (set) Token: 0x0600001A RID: 26 RVA: 0x000023AE File Offset: 0x000005AE
			Public Property Form3 As Form3
				Get
					Me._Annotation = Value.Parser.RestartAttribute(Of Form3)(Me._Annotation)
					Return Me._Annotation
				End Get
				Set(value As Form3)
					If value IsNot Me._Annotation Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.TestAttribute(Of Form3)(Me._Annotation)
					End If
				End Set
			End Property

		
			' (get) Token: 0x06000016 RID: 22 RVA: 0x00002326 File Offset: 0x00000526
			' (set) Token: 0x0600001B RID: 27 RVA: 0x000023D3 File Offset: 0x000005D3
			Public Property Form4 As Form4
				Get
					Me._Listener = Value.Parser.RestartAttribute(Of Form4)(Me._Listener)
					Return Me._Listener
				End Get
				Set(value As Form4)
					If value IsNot Me._Listener Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.TestAttribute(Of Form4)(Me._Listener)
					End If
				End Set
			End Property

		
			<ThreadStatic()>
			Private Shared _Setter As Hashtable

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Customer As bianhao

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Getter As Form1

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public server As Form2

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Annotation As Form3

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Listener As Form4
		End Class

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class Connection
		
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
			Friend Function MapAttribute() As Type
				Return GetType(Value.Connection)
			End Function

		
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

		
			<DebuggerHidden()>
			Private Shared Function RunAttribute(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

		
			<DebuggerHidden()>
			Private Sub VerifyAttribute(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

	
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class Mock(Of T As New)
		
			<DebuggerHidden()>
			Friend Function DefineAttribute() As T
				If Value.Mock(Of T).m_Dic Is Nothing Then
					Value.Mock(Of T).m_Dic = Activator.CreateInstance(Of T)()
				End If
				Return Value.Mock(Of T).m_Dic
			End Function

		
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

		
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared m_Dic As T
		End Class
	End Module
End Namespace
