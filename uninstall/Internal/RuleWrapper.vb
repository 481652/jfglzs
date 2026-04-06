Imports System
Imports System.Runtime.InteropServices

Namespace uninstall.Internal
	' Token: 0x02000018 RID: 24
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class RuleWrapper
		Inherits Attribute

		' Token: 0x0600008E RID: 142 RVA: 0x00002651 File Offset: 0x00000851
		Public Function RegisterWrapper() As Boolean
			Return Me._TestsWrapper
		End Function

		' Token: 0x0600008F RID: 143 RVA: 0x00002659 File Offset: 0x00000859
		Public Sub FillWrapper(bool_0 As Boolean)
			Me._TestsWrapper = bool_0
		End Sub

		' Token: 0x06000090 RID: 144 RVA: 0x00002662 File Offset: 0x00000862
		Public Function SearchWrapper() As Boolean
			Return Me._ManagerWrapper
		End Function

		' Token: 0x06000091 RID: 145 RVA: 0x0000266A File Offset: 0x0000086A
		Public Sub MoveWrapper(bool_0 As Boolean)
			Me._ManagerWrapper = bool_0
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x00002673 File Offset: 0x00000873
		Public Function RateWrapper() As String
			Return Me._ParamWrapper
		End Function

		' Token: 0x06000093 RID: 147 RVA: 0x0000267B File Offset: 0x0000087B
		Public Sub ManageWrapper(string_0 As String)
			Me._ParamWrapper = string_0
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x00002684 File Offset: 0x00000884
		Public Function InstantiateWrapper() As Boolean
			Return Me._ProcessWrapper
		End Function

		' Token: 0x06000095 RID: 149 RVA: 0x0000268C File Offset: 0x0000088C
		Public Sub CheckWrapper(bool_0 As Boolean)
			Me._ProcessWrapper = bool_0
		End Sub

		' Token: 0x04000044 RID: 68
		Private _TestsWrapper As Boolean = True

		' Token: 0x04000045 RID: 69
		Private _ManagerWrapper As Boolean = True

		' Token: 0x04000046 RID: 70
		Private _ProcessWrapper As Boolean = True

		' Token: 0x04000047 RID: 71
		Private _ParamWrapper As String = ""
	End Class
End Namespace
