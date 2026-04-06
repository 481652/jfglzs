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
	' Token: 0x02000008 RID: 8
	<HideModuleName()>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	Friend NotInheritable Module Configuration
		' Token: 0x1700000B RID: 11
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

		' Token: 0x1700000C RID: 12
		' (set) Token: 0x06000026 RID: 38 RVA: 0x0000245E File Offset: 0x0000065E
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				Configuration.resourceCulture = value
			End Set
		End Property

		' Token: 0x0400000D RID: 13
		Private resourceMan As ResourceManager

		' Token: 0x0400000E RID: 14
		Private resourceCulture As Object
	End Module
End Namespace
