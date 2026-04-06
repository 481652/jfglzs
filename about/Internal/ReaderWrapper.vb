Imports System
Imports System.Runtime.InteropServices

Namespace about.Internal

	<ComVisible(True)>
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	Friend NotInheritable Class ReaderWrapper
		Inherits Attribute

	
		Public Function SetWrapper() As Boolean
			Return Me.m_WriterWrapper
		End Function

	
		Public Sub RevertWrapper(bool_0 As Boolean)
			Me.m_WriterWrapper = bool_0
		End Sub

	
		Public Function DefineCode() As Boolean
			Return Me._MapperWrapper
		End Function

	
		Public Sub CalcCode(bool_0 As Boolean)
			Me._MapperWrapper = bool_0
		End Sub

	
		Public Function PostCode() As String
			Return Me.m_RepositoryWrapper
		End Function

	
		Public Sub FlushCode(string_0 As String)
			Me.m_RepositoryWrapper = string_0
		End Sub

	
		Public Function ConnectCode() As Boolean
			Return Me._ContainerWrapper
		End Function

	
		Public Sub DestroyCode(bool_0 As Boolean)
			Me._ContainerWrapper = bool_0
		End Sub

	
		Private m_WriterWrapper As Boolean = True

	
		Private _MapperWrapper As Boolean = True

	
		Private _ContainerWrapper As Boolean = True

	
		Private m_RepositoryWrapper As String = ""
	End Class
End Namespace
