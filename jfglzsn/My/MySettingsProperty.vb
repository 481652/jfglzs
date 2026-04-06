Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1.My
	' Token: 0x0200000A RID: 10
	<CompilerGenerated()>
	<HideModuleName()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000029 RID: 41 RVA: 0x0000246D File Offset: 0x0000066D
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
