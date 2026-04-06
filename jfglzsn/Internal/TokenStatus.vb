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

Namespace WindowsApplication1.Internal
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module TokenStatus
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000223E File Offset: 0x0000043E
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property StartState As StatusStatus
			<DebuggerHidden()>
			Get
				Return TokenStatus.modelStatus.PrepareStatus()
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000224A File Offset: 0x0000044A
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property RegisterState As StateStatus
			<DebuggerHidden()>
			Get
				Return TokenStatus._ManagerStatus.PrepareStatus()
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002256 File Offset: 0x00000456
		<HelpKeyword("My.User")>
		Friend ReadOnly Property RateState As User
			<DebuggerHidden()>
			Get
				Return TokenStatus.codeStatus.PrepareStatus()
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002262 File Offset: 0x00000462
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property DisableState As TokenStatus.AttributeToken
			<DebuggerHidden()>
			Get
				Return TokenStatus.m_IssuerStatus.PrepareStatus()
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000226E File Offset: 0x0000046E
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property CustomizeState As TokenStatus.ListToken
			<DebuggerHidden()>
			Get
				Return TokenStatus._SpecificationStatus.PrepareStatus()
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private modelStatus As TokenStatus.RequestToken(Of StatusStatus) = New TokenStatus.RequestToken(Of StatusStatus)()

		' Token: 0x04000002 RID: 2
		Private _ManagerStatus As TokenStatus.RequestToken(Of StateStatus) = New TokenStatus.RequestToken(Of StateStatus)()

		' Token: 0x04000003 RID: 3
		Private codeStatus As TokenStatus.RequestToken(Of User) = New TokenStatus.RequestToken(Of User)()

		' Token: 0x04000004 RID: 4
		Private m_IssuerStatus As TokenStatus.RequestToken(Of TokenStatus.AttributeToken) = New TokenStatus.RequestToken(Of TokenStatus.AttributeToken)()

		' Token: 0x04000005 RID: 5
		Private _SpecificationStatus As TokenStatus.RequestToken(Of TokenStatus.ListToken) = New TokenStatus.RequestToken(Of TokenStatus.ListToken)()

		' Token: 0x02000005 RID: 5
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class AttributeToken
			' Token: 0x0600000B RID: 11 RVA: 0x000028A8 File Offset: 0x00000AA8
			<DebuggerHidden()>
			Private Shared Function StartStatus(Of T As{Form, New})(Instance As T) As T
				Dim result As T
				If Instance IsNot Nothing AndAlso Not Instance.IsDisposed Then
					result = Instance
				Else
					If TokenStatus.AttributeToken.stubToken IsNot Nothing Then
						If TokenStatus.AttributeToken.stubToken.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						TokenStatus.AttributeToken.stubToken = New Hashtable()
					End If
					TokenStatus.AttributeToken.stubToken.Add(GetType(T), Nothing)
					Try
						result = Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
					Finally
						TokenStatus.AttributeToken.stubToken.Remove(GetType(T))
					End Try
				End If
				Return result
			End Function

			' Token: 0x0600000C RID: 12 RVA: 0x0000227A File Offset: 0x0000047A
			<DebuggerHidden()>
			Private Sub InvokeStatus(Of T As Form)(ByRef gparam_0 As T)
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
			Friend Function RegisterStatus() As Type
				Return GetType(TokenStatus.AttributeToken)
			End Function

			' Token: 0x06000011 RID: 17 RVA: 0x000022BA File Offset: 0x000004BA
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000006 RID: 6
			' (get) Token: 0x06000012 RID: 18 RVA: 0x000022C2 File Offset: 0x000004C2
			' (set) Token: 0x06000016 RID: 22 RVA: 0x00002326 File Offset: 0x00000526
			Public Property Form1 As Form1
				Get
					Me.m_PolicyToken = TokenStatus.AttributeToken.StartStatus(Of Form1)(Me.m_PolicyToken)
					Return Me.m_PolicyToken
				End Get
				Set(value As Form1)
					If value IsNot Me.m_PolicyToken Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.InvokeStatus(Of Form1)(Me.m_PolicyToken)
					End If
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x06000013 RID: 19 RVA: 0x000022DB File Offset: 0x000004DB
			' (set) Token: 0x06000017 RID: 23 RVA: 0x0000234B File Offset: 0x0000054B
			Public Property Form2 As Form2
				Get
					Me.authenticationToken = TokenStatus.AttributeToken.StartStatus(Of Form2)(Me.authenticationToken)
					Return Me.authenticationToken
				End Get
				Set(value As Form2)
					If value IsNot Me.authenticationToken Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.InvokeStatus(Of Form2)(Me.authenticationToken)
					End If
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x06000014 RID: 20 RVA: 0x000022F4 File Offset: 0x000004F4
			' (set) Token: 0x06000018 RID: 24 RVA: 0x00002370 File Offset: 0x00000570
			Public Property Form3 As Form3
				Get
					Me.m_SingletonToken = TokenStatus.AttributeToken.StartStatus(Of Form3)(Me.m_SingletonToken)
					Return Me.m_SingletonToken
				End Get
				Set(value As Form3)
					If value IsNot Me.m_SingletonToken Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.InvokeStatus(Of Form3)(Me.m_SingletonToken)
					End If
				End Set
			End Property

			' Token: 0x17000009 RID: 9
			' (get) Token: 0x06000015 RID: 21 RVA: 0x0000230D File Offset: 0x0000050D
			' (set) Token: 0x06000019 RID: 25 RVA: 0x00002395 File Offset: 0x00000595
			Public Property Form4 As Form4
				Get
					Me.comparatorToken = TokenStatus.AttributeToken.StartStatus(Of Form4)(Me.comparatorToken)
					Return Me.comparatorToken
				End Get
				Set(value As Form4)
					If value IsNot Me.comparatorToken Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.InvokeStatus(Of Form4)(Me.comparatorToken)
					End If
				End Set
			End Property

			' Token: 0x04000006 RID: 6
			<ThreadStatic()>
			Private Shared stubToken As Hashtable

			' Token: 0x04000007 RID: 7
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_PolicyToken As Form1

			' Token: 0x04000008 RID: 8
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public authenticationToken As Form2

			' Token: 0x04000009 RID: 9
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_SingletonToken As Form3

			' Token: 0x0400000A RID: 10
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public comparatorToken As Form4
		End Class

		' Token: 0x02000006 RID: 6
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class ListToken
			' Token: 0x0600001A RID: 26 RVA: 0x00002297 File Offset: 0x00000497
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(obj As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(obj))
			End Function

			' Token: 0x0600001B RID: 27 RVA: 0x000022A5 File Offset: 0x000004A5
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600001C RID: 28 RVA: 0x000023BA File Offset: 0x000005BA
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function PublishStatus() As Type
				Return GetType(TokenStatus.ListToken)
			End Function

			' Token: 0x0600001D RID: 29 RVA: 0x000022BA File Offset: 0x000004BA
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600001E RID: 30 RVA: 0x000029AC File Offset: 0x00000BAC
			<DebuggerHidden()>
			Private Shared Function LoginStatus(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x0600001F RID: 31 RVA: 0x000023C7 File Offset: 0x000005C7
			<DebuggerHidden()>
			Private Sub ForgotStatus(Of T)(ByRef gparam_0 As T)
				gparam_0 = Nothing
			End Sub

			' Token: 0x06000020 RID: 32 RVA: 0x0000228F File Offset: 0x0000048F
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class RequestToken(Of T As New)
			' Token: 0x06000021 RID: 33 RVA: 0x000023D0 File Offset: 0x000005D0
			<DebuggerHidden()>
			Friend Function PrepareStatus() As T
				If TokenStatus.RequestToken(Of T)._ObjectToken Is Nothing Then
					TokenStatus.RequestToken(Of T)._ObjectToken = Activator.CreateInstance(Of T)()
				End If
				Return TokenStatus.RequestToken(Of T)._ObjectToken
			End Function

			' Token: 0x06000022 RID: 34 RVA: 0x0000228F File Offset: 0x0000048F
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x0400000B RID: 11
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared _ObjectToken As T
		End Class
	End Module
End Namespace
