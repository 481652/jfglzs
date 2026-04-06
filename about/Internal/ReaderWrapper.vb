Imports System
Imports System.Runtime.InteropServices

Namespace about.Internal
	' Token: 0x02000016 RID: 22
	<ComVisible(True)>
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	Friend NotInheritable Class ReaderWrapper
		Inherits Attribute

		' Token: 0x0600009B RID: 155 RVA: 0x0000267C File Offset: 0x0000087C
		Public Function SetWrapper() As Boolean
			Return Me.m_WriterWrapper
		End Function

		' Token: 0x0600009C RID: 156 RVA: 0x00002684 File Offset: 0x00000884
		Public Sub RevertWrapper(bool_0 As Boolean)
			Me.m_WriterWrapper = bool_0
		End Sub

		' Token: 0x0600009D RID: 157 RVA: 0x0000268D File Offset: 0x0000088D
		Public Function DefineCode() As Boolean
			Return Me._MapperWrapper
		End Function

		' Token: 0x0600009E RID: 158 RVA: 0x00002695 File Offset: 0x00000895
		Public Sub CalcCode(bool_0 As Boolean)
			Me._MapperWrapper = bool_0
		End Sub

		' Token: 0x0600009F RID: 159 RVA: 0x0000269E File Offset: 0x0000089E
		Public Function PostCode() As String
			Return Me.m_RepositoryWrapper
		End Function

		' Token: 0x060000A0 RID: 160 RVA: 0x000026A6 File Offset: 0x000008A6
		Public Sub FlushCode(string_0 As String)
			Me.m_RepositoryWrapper = string_0
		End Sub

		' Token: 0x060000A1 RID: 161 RVA: 0x000026AF File Offset: 0x000008AF
		Public Function ConnectCode() As Boolean
			Return Me._ContainerWrapper
		End Function

		' Token: 0x060000A2 RID: 162 RVA: 0x000026B7 File Offset: 0x000008B7
		Public Sub DestroyCode(bool_0 As Boolean)
			Me._ContainerWrapper = bool_0
		End Sub

		' Token: 0x0400003B RID: 59
		Private m_WriterWrapper As Boolean = True

		' Token: 0x0400003C RID: 60
		Private _MapperWrapper As Boolean = True

		' Token: 0x0400003D RID: 61
		Private _ContainerWrapper As Boolean = True

		' Token: 0x0400003E RID: 62
		Private m_RepositoryWrapper As String = ""
	End Class
End Namespace
