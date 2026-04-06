Imports System
Imports System.Runtime.InteropServices

Namespace WindowsApplication1.Internal

	<ComVisible(True)>
	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	Friend NotInheritable Class MethodToken
		Inherits Attribute

	
		Public Function ReadStatus() As Boolean
			Return Me._InfoToken
		End Function

	
		Public Sub WriteStatus(bool_0 As Boolean)
			Me._InfoToken = bool_0
		End Sub

	
		Public Function ViewStatus() As Boolean
			Return Me.invocationToken
		End Function

	
		Public Sub ComputeStatus(bool_0 As Boolean)
			Me.invocationToken = bool_0
		End Sub

	
		Public Function VisitStatus() As String
			Return Me.roleToken
		End Function

	
		Public Sub ResetStatus(string_0 As String)
			Me.roleToken = string_0
		End Sub

	
		Public Function UpdateStatus() As Boolean
			Return Me.ruleToken
		End Function

	
		Public Sub AddStatus(bool_0 As Boolean)
			Me.ruleToken = bool_0
		End Sub

	
		Private _InfoToken As Boolean = True

	
		Private invocationToken As Boolean = True

	
		Private ruleToken As Boolean = True

	
		Private roleToken As String = ""
	End Class
End Namespace
