Imports System.Configuration
Imports Microsoft.Extensions.Configuration



Namespace Providers



    Public Class WinFormsConfigurationSource
        Implements IConfigurationSource

        Private _settingsBase As ApplicationSettingsBase



        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="settingsBase"></param>
        Public Sub New(settingsBase As ApplicationSettingsBase)
            _settingsBase = settingsBase
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="builder"></param>
        ''' <returns></returns>
        Public Function Build(builder As IConfigurationBuilder) As IConfigurationProvider Implements IConfigurationSource.Build
            Return new WinFormsConfigurationProvider(_settingsBase)
        End Function
    End Class
End NameSpace