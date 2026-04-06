Imports System
Imports System.Runtime.InteropServices

Namespace zmserv.Internal

	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class CodeMock
		Inherits Attribute

	
		Public Function GetClass() As Boolean
			Return Me._ParamsMock
		End Function

	
		Public Sub ComputeClass(bool_0 As Boolean)
			Me._ParamsMock = bool_0
		End Sub

	
		Public Function QueryClass() As Boolean
			Return Me.itemMock
		End Function

	
		Public Sub VerifyClass(bool_0 As Boolean)
			Me.itemMock = bool_0
		End Sub

	
		Public Function CancelClass() As String
			Return Me.observerMock
		End Function

	
		Public Sub CloneClass(string_0 As String)
			Me.observerMock = string_0
		End Sub

	
		Public Function InsertClass() As Boolean
			Return Me._MethodMock
		End Function

	
		Public Sub StopClass(bool_0 As Boolean)
			Me._MethodMock = bool_0
		End Sub

	
		Private _ParamsMock As Boolean = True

	
		Private itemMock As Boolean = True

	
		Private _MethodMock As Boolean = True

	
		Private observerMock As String = ""
	End Class
End Namespace
