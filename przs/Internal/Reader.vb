Imports System
Imports System.Runtime.InteropServices

Namespace przs.Internal
	' Token: 0x02000016 RID: 22
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class Reader
		Inherits Attribute

		' Token: 0x060000A1 RID: 161 RVA: 0x00002723 File Offset: 0x00000923
		Public Function AddDefinition() As Boolean
			Return Me._Observer
		End Function

		' Token: 0x060000A2 RID: 162 RVA: 0x0000272B File Offset: 0x0000092B
		Public Sub InstantiateDefinition(bool_0 As Boolean)
			Me._Observer = bool_0
		End Sub

		' Token: 0x060000A3 RID: 163 RVA: 0x00002734 File Offset: 0x00000934
		Public Function SearchDefinition() As Boolean
			Return Me.m_Service
		End Function

		' Token: 0x060000A4 RID: 164 RVA: 0x0000273C File Offset: 0x0000093C
		Public Sub LogoutDefinition(bool_0 As Boolean)
			Me.m_Service = bool_0
		End Sub

		' Token: 0x060000A5 RID: 165 RVA: 0x00002745 File Offset: 0x00000945
		Public Function WriteDefinition() As String
			Return Me._Struct
		End Function

		' Token: 0x060000A6 RID: 166 RVA: 0x0000274D File Offset: 0x0000094D
		Public Sub DeleteDefinition(string_0 As String)
			Me._Struct = string_0
		End Sub

		' Token: 0x060000A7 RID: 167 RVA: 0x00002756 File Offset: 0x00000956
		Public Function EnableDefinition() As Boolean
			Return Me.field
		End Function

		' Token: 0x060000A8 RID: 168 RVA: 0x0000275E File Offset: 0x0000095E
		Public Sub ChangeDefinition(bool_0 As Boolean)
			Me.field = bool_0
		End Sub

		' Token: 0x04000059 RID: 89
		Private _Observer As Boolean = True

		' Token: 0x0400005A RID: 90
		Private m_Service As Boolean = True

		' Token: 0x0400005B RID: 91
		Private field As Boolean = True

		' Token: 0x0400005C RID: 92
		Private _Struct As String = ""
	End Class
End Namespace
