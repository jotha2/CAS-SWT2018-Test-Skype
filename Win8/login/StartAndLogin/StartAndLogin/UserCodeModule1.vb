'
' Created by Ranorex
' User: Jörg
' Date: 06.12.2018
' Time: 05:09
' 
' To change this template use Tools > Options > Coding > Edit standard headers.
'
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Threading
Imports WinForms = System.Windows.Forms

Imports Ranorex
Imports Ranorex.Core
Imports Ranorex.Core.Testing

Namespace StartAndLogin
   ''' <summary>
   ''' Description of UserCodeModule1.
   ''' </summary>
   <TestModule("88F248A7-90BA-4983-A046-C9E89ABFAC75", ModuleType.UserCode, 1)> _
   Public Class UserCodeModule1
        Implements ITestModule

        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Public Sub New()
            ' Do not delete - a parameterless constructor is required!
        End Sub

        ''' <summary>
        ''' Performs the playback of actions in this module.
        ''' </summary>
        ''' <remarks>You should not call this method directly, instead pass the module
        ''' instance to the <see cref="TestModuleRunner.Run(Of ITestModule)"/> method
        ''' that will in turn invoke this method.</remarks>
        Sub Run() Implements ITestModule.Run
            Mouse.DefaultMoveTime = 300
            Keyboard.DefaultKeyPressTime = 100
            Delay.SpeedFactor = 1.0
        End Sub

    End Class
End Namespace
