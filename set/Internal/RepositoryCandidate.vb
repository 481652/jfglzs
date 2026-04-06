Imports System
Imports System.Runtime.InteropServices

Namespace [set].Internal

	<AttributeUsage(AttributeTargets.Assembly Or AttributeTargets.[Class] Or AttributeTargets.Struct Or AttributeTargets.[Enum] Or AttributeTargets.Method Or AttributeTargets.[Property] Or AttributeTargets.Field Or AttributeTargets.[Event] Or AttributeTargets.[Interface] Or AttributeTargets.Parameter Or AttributeTargets.[Delegate], AllowMultiple := True, Inherited := False)>
	<ComVisible(True)>
	Friend NotInheritable Class RepositoryCandidate
		Inherits Attribute

	
		Public Function ConnectCollection() As Boolean
			Return Me.m_InterceptorCandidate
		End Function

	
		Public Sub CloneCollection(bool_0 As Boolean)
			Me.m_InterceptorCandidate = bool_0
		End Sub

	
		Public Function CheckCollection() As Boolean
			Return Me.m_ParamsCandidate
		End Function

	
		Public Sub InitCollection(bool_0 As Boolean)
			Me.m_ParamsCandidate = bool_0
		End Sub

	
		Public Function StopCollection() As String
			Return Me.m_QueueCandidate
		End Function

	
		Public Sub IncludeCollection(string_0 As String)
			Me.m_QueueCandidate = string_0
		End Sub

	
		Public Function UpdateCollection() As Boolean
			Return Me.m_PropertyCandidate
		End Function

	
		Public Sub SelectCollection(bool_0 As Boolean)
			Me.m_PropertyCandidate = bool_0
		End Sub

	
		Private m_InterceptorCandidate As Boolean = True

	
		Private m_ParamsCandidate As Boolean = True

	
		Private m_PropertyCandidate As Boolean = True

	
		Private m_QueueCandidate As String = ""
	End Class
End Namespace
