Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace przs.Internal

	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Class Attribute
		Inherits WindowsFormsApplicationBase

	
		<DebuggerHidden()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<STAThread()>
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Friend Shared Sub ReadAttribute(args As String())
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Value.SetAttribute.Run(args)
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
			MyBase.MainForm = Value.SetupAttribute.Form1
		End Sub
	End Class
End Namespace
