Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1.My

	<HideModuleName()>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend NotInheritable Module MySettingsProperty
	
		' (get) Token: 0x06000027 RID: 39 RVA: 0x0000242F File Offset: 0x0000062F
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
