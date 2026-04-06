Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace [set].Internal
	' Token: 0x02000008 RID: 8
	<HideModuleName()>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	Friend NotInheritable Module ParamsCollection
		' Token: 0x17000009 RID: 9
		' (get) Token: 0x06000021 RID: 33 RVA: 0x000023AF File Offset: 0x000005AF
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(ParamsCollection.resourceMan, Nothing) Then
					ParamsCollection.resourceMan = New ResourceManager("WindowsApplication1.Resources", GetType(ParamsCollection).Assembly)
				End If
				Return ParamsCollection.resourceMan
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (set) Token: 0x06000022 RID: 34 RVA: 0x000023E2 File Offset: 0x000005E2
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				ParamsCollection.resourceCulture = value
			End Set
		End Property

		' Token: 0x0400000B RID: 11
		Private resourceMan As ResourceManager

		' Token: 0x0400000C RID: 12
		Private resourceCulture As Object
	End Module
End Namespace
