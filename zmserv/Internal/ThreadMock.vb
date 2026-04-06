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
	' Token: 0x02000007 RID: 7
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<HideModuleName()>
	Friend NotInheritable Module ThreadMock
		' Token: 0x17000005 RID: 5
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

		' Token: 0x17000006 RID: 6
		' (set) Token: 0x06000012 RID: 18 RVA: 0x000022AA File Offset: 0x000004AA
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				ThreadMock.resourceCulture = value
			End Set
		End Property

		' Token: 0x04000006 RID: 6
		Private resourceMan As ResourceManager

		' Token: 0x04000007 RID: 7
		Private resourceCulture As Object
	End Module
End Namespace
