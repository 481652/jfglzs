Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1.Internal

	<HideModuleName()>
	<CompilerGenerated()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module ProccesorStatus
	
		' (get) Token: 0x06000023 RID: 35 RVA: 0x000023ED File Offset: 0x000005ED
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(ProccesorStatus.resourceMan, Nothing) Then
					ProccesorStatus.resourceMan = New ResourceManager("WindowsApplication1.Resources", GetType(ProccesorStatus).Assembly)
				End If
				Return ProccesorStatus.resourceMan
			End Get
		End Property

	
		' (set) Token: 0x06000024 RID: 36 RVA: 0x00002420 File Offset: 0x00000620
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				ProccesorStatus.resourceCulture = value
			End Set
		End Property

	
		Private resourceMan As ResourceManager

	
		Private resourceCulture As Object
	End Module
End Namespace
