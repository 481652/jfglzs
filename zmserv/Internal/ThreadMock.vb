Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace zmserv.Internal

	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<HideModuleName()>
	Friend NotInheritable Module ThreadMock
	
		' (get) Token: 0x06000011 RID: 17 RVA: 0x00002277 File Offset: 0x00000477
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(ThreadMock.resourceMan, Nothing) Then
					ThreadMock.resourceMan = New ResourceManager("zmserv.Resources", GetType(ThreadMock).Assembly)
				End If
				Return ThreadMock.resourceMan
			End Get
		End Property

	
		' (set) Token: 0x06000012 RID: 18 RVA: 0x000022AA File Offset: 0x000004AA
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				ThreadMock.resourceCulture = value
			End Set
		End Property

	
		Private resourceMan As ResourceManager

	
		Private resourceCulture As Object
	End Module
End Namespace
