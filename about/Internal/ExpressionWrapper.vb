Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace about.Internal
	' Token: 0x02000008 RID: 8
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<HideModuleName()>
	<CompilerGenerated()>
	Friend NotInheritable Module ExpressionWrapper
		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600001F RID: 31 RVA: 0x00002371 File Offset: 0x00000571
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(ExpressionWrapper.resourceMan, Nothing) Then
					ExpressionWrapper.resourceMan = New ResourceManager("WindowsApplication1.Resources", GetType(ExpressionWrapper).Assembly)
				End If
				Return ExpressionWrapper.resourceMan
			End Get
		End Property

		' Token: 0x17000009 RID: 9
		' (set) Token: 0x06000020 RID: 32 RVA: 0x000023A4 File Offset: 0x000005A4
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend WriteOnly Property Culture As CultureInfo
			Set(value As CultureInfo)
				ExpressionWrapper.resourceCulture = value
			End Set
		End Property

		' Token: 0x0400000A RID: 10
		Private resourceMan As ResourceManager

		' Token: 0x0400000B RID: 11
		Private resourceCulture As Object
	End Module
End Namespace
