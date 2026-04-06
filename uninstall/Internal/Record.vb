Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace uninstall.Internal

	<HideModuleName()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend NotInheritable Module Record
	
		' (get) Token: 0x0600001F RID: 31 RVA: 0x00002371 File Offset: 0x00000571
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Record.resourceMan, Nothing) Then
					Record.resourceMan = New ResourceManager("WindowsApplication1.Resources", GetType(Record).Assembly)
				End If
				Return Record.resourceMan
			End Get
		End Property

	
		' (set) Token: 0x06000020 RID: 32 RVA: 0x000023A4 File Offset: 0x000005A4
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				Record.resourceCulture = value
			End Set
		End Property

	
		Private resourceMan As ResourceManager

	
		Private resourceCulture As Object
	End Module
End Namespace
