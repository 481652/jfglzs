Imports System
Imports System.Runtime.InteropServices

Namespace WindowsApplication1.Internal
	' Token: 0x0200001B RID: 27
	<ComVisible(True)>
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	Friend NotInheritable Class MethodToken
		Inherits Attribute

		' Token: 0x060000F6 RID: 246 RVA: 0x0000283C File Offset: 0x00000A3C
		Public Function ReadStatus() As Boolean
			Return Me._InfoToken
		End Function

		' Token: 0x060000F7 RID: 247 RVA: 0x00002844 File Offset: 0x00000A44
		Public Sub WriteStatus(bool_0 As Boolean)
			Me._InfoToken = bool_0
		End Sub

		' Token: 0x060000F8 RID: 248 RVA: 0x0000284D File Offset: 0x00000A4D
		Public Function ViewStatus() As Boolean
			Return Me.invocationToken
		End Function

		' Token: 0x060000F9 RID: 249 RVA: 0x00002855 File Offset: 0x00000A55
		Public Sub ComputeStatus(bool_0 As Boolean)
			Me.invocationToken = bool_0
		End Sub

		' Token: 0x060000FA RID: 250 RVA: 0x0000285E File Offset: 0x00000A5E
		Public Function VisitStatus() As String
			Return Me.roleToken
		End Function

		' Token: 0x060000FB RID: 251 RVA: 0x00002866 File Offset: 0x00000A66
		Public Sub ResetStatus(string_0 As String)
			Me.roleToken = string_0
		End Sub

		' Token: 0x060000FC RID: 252 RVA: 0x0000286F File Offset: 0x00000A6F
		Public Function UpdateStatus() As Boolean
			Return Me.ruleToken
		End Function

		' Token: 0x060000FD RID: 253 RVA: 0x00002877 File Offset: 0x00000A77
		Public Sub AddStatus(bool_0 As Boolean)
			Me.ruleToken = bool_0
		End Sub

		' Token: 0x040000C3 RID: 195
		Private _InfoToken As Boolean = True

		' Token: 0x040000C4 RID: 196
		Private invocationToken As Boolean = True

		' Token: 0x040000C5 RID: 197
		Private ruleToken As Boolean = True

		' Token: 0x040000C6 RID: 198
		Private roleToken As String = ""
	End Class
End Namespace
