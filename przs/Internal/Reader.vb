Imports System
Imports System.Runtime.InteropServices

Namespace przs.Internal

	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class Reader
		Inherits Attribute

	
		Public Function AddDefinition() As Boolean
			Return Me._Observer
		End Function

	
		Public Sub InstantiateDefinition(bool_0 As Boolean)
			Me._Observer = bool_0
		End Sub

	
		Public Function SearchDefinition() As Boolean
			Return Me.m_Service
		End Function

	
		Public Sub LogoutDefinition(bool_0 As Boolean)
			Me.m_Service = bool_0
		End Sub

	
		Public Function WriteDefinition() As String
			Return Me._Struct
		End Function

	
		Public Sub DeleteDefinition(string_0 As String)
			Me._Struct = string_0
		End Sub

	
		Public Function EnableDefinition() As Boolean
			Return Me.field
		End Function

	
		Public Sub ChangeDefinition(bool_0 As Boolean)
			Me.field = bool_0
		End Sub

	
		Private _Observer As Boolean = True

	
		Private m_Service As Boolean = True

	
		Private field As Boolean = True

	
		Private _Struct As String = ""
	End Class
End Namespace
