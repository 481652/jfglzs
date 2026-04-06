Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace przs.Internal

	<HideModuleName()>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	Friend NotInheritable Module Configuration
	
		' (get) Token: 0x06000025 RID: 37 RVA: 0x0000242B File Offset: 0x0000062B
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Configuration.resourceMan, Nothing) Then
					Configuration.resourceMan = New ResourceManager("Resources", GetType(Configuration).Assembly)
				End If
				Return Configuration.resourceMan
			End Get
		End Property

	
		' (set) Token: 0x06000026 RID: 38 RVA: 0x0000245E File Offset: 0x0000065E
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				Configuration.resourceCulture = value
			End Set
		End Property

	
		Private resourceMan As ResourceManager

	
		Private resourceCulture As Object
	End Module
End Namespace
