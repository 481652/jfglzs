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
	' Token: 0x02000008 RID: 8
	<HideModuleName()>
	<CompilerGenerated()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module ProccesorStatus
		' Token: 0x1700000A RID: 10
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

		' Token: 0x1700000B RID: 11
		' (set) Token: 0x06000024 RID: 36 RVA: 0x00002420 File Offset: 0x00000620
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				ProccesorStatus.resourceCulture = value
			End Set
		End Property

		' Token: 0x0400000C RID: 12
		Private resourceMan As ResourceManager

		' Token: 0x0400000D RID: 13
		Private resourceCulture As Object
	End Module
End Namespace
