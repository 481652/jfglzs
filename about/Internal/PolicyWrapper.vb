Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace about.Internal

	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Class PolicyWrapper
		Inherits WindowsFormsApplicationBase

	
		<STAThread()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerHidden()>
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Friend Shared Sub RunPolicy(args As String())
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			ClientWrapper.PostPolicy.Run(args)
		End Sub

	
		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			MyBase.IsSingleInstance = False
			MyBase.EnableVisualStyles = True
			MyBase.SaveMySettingsOnExit = True
			MyBase.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

	
		<DebuggerStepThrough()>
		Protected Overrides Sub OnCreateMainForm()
			MyBase.MainForm = ClientWrapper.DestroyPolicy.Form1
		End Sub
	End Class
End Namespace
