Imports System
Imports System.Runtime.InteropServices

Namespace zmserv.Internal
	' Token: 0x02000013 RID: 19
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class CodeMock
		Inherits Attribute

		' Token: 0x06000054 RID: 84 RVA: 0x00002467 File Offset: 0x00000667
		Public Function GetClass() As Boolean
			Return Me._ParamsMock
		End Function

		' Token: 0x06000055 RID: 85 RVA: 0x0000246F File Offset: 0x0000066F
		Public Sub ComputeClass(bool_0 As Boolean)
			Me._ParamsMock = bool_0
		End Sub

		' Token: 0x06000056 RID: 86 RVA: 0x00002478 File Offset: 0x00000678
		Public Function QueryClass() As Boolean
			Return Me.itemMock
		End Function

		' Token: 0x06000057 RID: 87 RVA: 0x00002480 File Offset: 0x00000680
		Public Sub VerifyClass(bool_0 As Boolean)
			Me.itemMock = bool_0
		End Sub

		' Token: 0x06000058 RID: 88 RVA: 0x00002489 File Offset: 0x00000689
		Public Function CancelClass() As String
			Return Me.observerMock
		End Function

		' Token: 0x06000059 RID: 89 RVA: 0x00002491 File Offset: 0x00000691
		Public Sub CloneClass(string_0 As String)
			Me.observerMock = string_0
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x0000249A File Offset: 0x0000069A
		Public Function InsertClass() As Boolean
			Return Me._MethodMock
		End Function

		' Token: 0x0600005B RID: 91 RVA: 0x000024A2 File Offset: 0x000006A2
		Public Sub StopClass(bool_0 As Boolean)
			Me._MethodMock = bool_0
		End Sub

		' Token: 0x04000029 RID: 41
		Private _ParamsMock As Boolean = True

		' Token: 0x0400002A RID: 42
		Private itemMock As Boolean = True

		' Token: 0x0400002B RID: 43
		Private _MethodMock As Boolean = True

		' Token: 0x0400002C RID: 44
		Private observerMock As String = ""
	End Class
End Namespace
