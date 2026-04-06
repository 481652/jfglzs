Imports System
Imports System.Runtime.InteropServices

Namespace [set].Internal
	' Token: 0x02000019 RID: 25
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class RepositoryCandidate
		Inherits Attribute

		' Token: 0x0600011C RID: 284 RVA: 0x00002A3C File Offset: 0x00000C3C
		Public Function ConnectCollection() As Boolean
			Return Me.m_InterceptorCandidate
		End Function

		' Token: 0x0600011D RID: 285 RVA: 0x00002A44 File Offset: 0x00000C44
		Public Sub CloneCollection(bool_0 As Boolean)
			Me.m_InterceptorCandidate = bool_0
		End Sub

		' Token: 0x0600011E RID: 286 RVA: 0x00002A4D File Offset: 0x00000C4D
		Public Function CheckCollection() As Boolean
			Return Me.m_ParamsCandidate
		End Function

		' Token: 0x0600011F RID: 287 RVA: 0x00002A55 File Offset: 0x00000C55
		Public Sub InitCollection(bool_0 As Boolean)
			Me.m_ParamsCandidate = bool_0
		End Sub

		' Token: 0x06000120 RID: 288 RVA: 0x00002A5E File Offset: 0x00000C5E
		Public Function StopCollection() As String
			Return Me.m_QueueCandidate
		End Function

		' Token: 0x06000121 RID: 289 RVA: 0x00002A66 File Offset: 0x00000C66
		Public Sub IncludeCollection(string_0 As String)
			Me.m_QueueCandidate = string_0
		End Sub

		' Token: 0x06000122 RID: 290 RVA: 0x00002A6F File Offset: 0x00000C6F
		Public Function UpdateCollection() As Boolean
			Return Me.m_PropertyCandidate
		End Function

		' Token: 0x06000123 RID: 291 RVA: 0x00002A77 File Offset: 0x00000C77
		Public Sub SelectCollection(bool_0 As Boolean)
			Me.m_PropertyCandidate = bool_0
		End Sub

		' Token: 0x04000088 RID: 136
		Private m_InterceptorCandidate As Boolean = True

		' Token: 0x04000089 RID: 137
		Private m_ParamsCandidate As Boolean = True

		' Token: 0x0400008A RID: 138
		Private m_PropertyCandidate As Boolean = True

		' Token: 0x0400008B RID: 139
		Private m_QueueCandidate As String = ""
	End Class
End Namespace
