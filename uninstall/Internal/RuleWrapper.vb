Imports System
Imports System.Runtime.InteropServices

Namespace uninstall.Internal

	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class RuleWrapper
		Inherits Attribute

	
		Public Function RegisterWrapper() As Boolean
			Return Me._TestsWrapper
		End Function

	
		Public Sub FillWrapper(bool_0 As Boolean)
			Me._TestsWrapper = bool_0
		End Sub

	
		Public Function SearchWrapper() As Boolean
			Return Me._ManagerWrapper
		End Function

	
		Public Sub MoveWrapper(bool_0 As Boolean)
			Me._ManagerWrapper = bool_0
		End Sub

	
		Public Function RateWrapper() As String
			Return Me._ParamWrapper
		End Function

	
		Public Sub ManageWrapper(string_0 As String)
			Me._ParamWrapper = string_0
		End Sub

	
		Public Function InstantiateWrapper() As Boolean
			Return Me._ProcessWrapper
		End Function

	
		Public Sub CheckWrapper(bool_0 As Boolean)
			Me._ProcessWrapper = bool_0
		End Sub

	
		Private _TestsWrapper As Boolean = True

	
		Private _ManagerWrapper As Boolean = True

	
		Private _ProcessWrapper As Boolean = True

	
		Private _ParamWrapper As String = ""
	End Class
End Namespace
