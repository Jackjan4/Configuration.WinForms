Imports System.Configuration
Imports Microsoft.Extensions.Configuration



Namespace Providers



    Public Class WinFormsConfigurationProvider
        Inherits ConfigurationProvider



        Private ReadOnly _settingsBase As ApplicationSettingsBase



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
        Public Overrides Sub Load()
            Dim result = _settingsBase.Properties _
                    .Cast(Of SettingsProperty) _
                    .ToDictionary(Function(prop) prop.Name, Function(prop) _settingsBase(prop.Name).ToString())
            Data = result
        End Sub

    End Class
End Namespace