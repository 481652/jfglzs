Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace uninstall.Internal
	' Token: 0x02000002 RID: 2
	<EditorBrowsable(EditorBrowsableState.Never)>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend Class Consumer
		Inherits WindowsFormsApplicationBase

		' Token: 0x06000001 RID: 1 RVA: 0x000021B4 File Offset: 0x000003B4
		<DebuggerHidden()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<STAThread()>
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Friend Shared Sub FindConsumer(args As String())
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Template.CollectConsumer.Run(args)
		End Sub

		' Token: 0x06000002 RID: 2 RVA: 0x000021CB File Offset: 0x000003CB
		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			MyBase.IsSingleInstance = False
			MyBase.EnableVisualStyles = True
			MyBase.SaveMySettingsOnExit = True
			MyBase.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x000021F0 File Offset: 0x000003F0
		<DebuggerStepThrough()>
		Protected Overrides Sub OnCreateMainForm()
			MyBase.MainForm = Template.ResetConsumer.Form1
		End Sub
	End Class
End Namespace
