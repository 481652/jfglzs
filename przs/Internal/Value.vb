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
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module Value
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property PopAttribute As Definition
			<DebuggerHidden()>
			Get
				Return Value.m_Reg.DefineAttribute()
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property SetAttribute As Attribute
			<DebuggerHidden()>
			Get
				Return Value.attr.DefineAttribute()
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		<HelpKeyword("My.User")>
		Friend ReadOnly Property RemoveAttribute As User
			<DebuggerHidden()>
			Get
				Return Value.m_Method.DefineAttribute()
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property SetupAttribute As Value.Parser
			<DebuggerHidden()>
			Get
				Return Value._State.DefineAttribute()
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property FlushAttribute As Value.Connection
			<DebuggerHidden()>
			Get
				Return Value.code.DefineAttribute()
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_Reg As Value.Mock(Of Definition) = New Value.Mock(Of Definition)()

		' Token: 0x04000002 RID: 2
		Private attr As Value.Mock(Of Attribute) = New Value.Mock(Of Attribute)()

		' Token: 0x04000003 RID: 3
		Private m_Method As Value.Mock(Of User) = New Value.Mock(Of User)()

		' Token: 0x04000004 RID: 4
		Private _State As Value.Mock(Of Value.Parser) = New Value.Mock(Of Value.Parser)()

		' Token: 0x04000005 RID: 5
		Private code As Value.Mock(Of Value.Connection) = New Value.Mock(Of Value.Connection)()

		' Token: 0x02000005 RID: 5
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class Parser
			' Token: 0x0600000B RID: 11 RVA: 0x00002790 File Offset: 0x00000990
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

			' Token: 0x0600000C RID: 12 RVA: 0x0000227A File Offset: 0x0000047A
			<DebuggerHidden()>
			Private Sub TestAttribute(Of T As Form)(ByRef gparam_0 As T)
				gparam_0.Dispose()
				gparam_0 = Nothing
			End Sub

			' Token: 0x0600000D RID: 13 RVA: 0x0000228F File Offset: 0x0000048F
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
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
			Friend Function DisableAttribute() As Type
				Return GetType(Value.Parser)
			End Function

			' Token: 0x06000011 RID: 17 RVA: 0x000022BA File Offset: 0x000004BA
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000006 RID: 6
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

			' Token: 0x17000007 RID: 7
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

			' Token: 0x17000008 RID: 8
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

			' Token: 0x17000009 RID: 9
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

			' Token: 0x1700000A RID: 10
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

			' Token: 0x04000006 RID: 6
			<ThreadStatic()>
			Private Shared _Setter As Hashtable

			' Token: 0x04000007 RID: 7
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Customer As bianhao

			' Token: 0x04000008 RID: 8
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Getter As Form1

			' Token: 0x04000009 RID: 9
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public server As Form2

			' Token: 0x0400000A RID: 10
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Annotation As Form3

			' Token: 0x0400000B RID: 11
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public _Listener As Form4
		End Class

		' Token: 0x02000006 RID: 6
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class Connection
			' Token: 0x0600001C RID: 28 RVA: 0x00002297 File Offset: 0x00000497
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

			' Token: 0x0600001D RID: 29 RVA: 0x000022A5 File Offset: 0x000004A5
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600001E RID: 30 RVA: 0x000023F8 File Offset: 0x000005F8
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function MapAttribute() As Type
				Return GetType(Value.Connection)
			End Function

			' Token: 0x0600001F RID: 31 RVA: 0x000022BA File Offset: 0x000004BA
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x06000020 RID: 32 RVA: 0x00002894 File Offset: 0x00000A94
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

			' Token: 0x06000021 RID: 33 RVA: 0x00002405 File Offset: 0x00000605
			<DebuggerHidden()>
			Private Sub VerifyAttribute(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

			' Token: 0x06000022 RID: 34 RVA: 0x0000228F File Offset: 0x0000048F
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class Mock(Of T As New)
			' Token: 0x06000023 RID: 35 RVA: 0x0000240E File Offset: 0x0000060E
			<DebuggerHidden()>
			Friend Function DefineAttribute() As T
				If Value.Mock(Of T).m_Dic Is Nothing Then
					Value.Mock(Of T).m_Dic = Activator.CreateInstance(Of T)()
				End If
				Return Value.Mock(Of T).m_Dic
			End Function

			' Token: 0x06000024 RID: 36 RVA: 0x0000228F File Offset: 0x0000048F
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x0400000C RID: 12
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared m_Dic As T
		End Class
	End Module
End Namespace
