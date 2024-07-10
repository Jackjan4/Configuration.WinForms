Imports System.Configuration
Imports System.Runtime.CompilerServices
Imports Microsoft.Extensions.Configuration

Namespace Extensions
    Public Module ConfigurationManagerExtensions

        <Extension()>
        Public Function AddWinFormsConfiguration(ByVal configBuilder As Microsoft.Extensions.Configuration.ConfigurationBuilder, settingsBase As ApplicationSettingsBase) As IConfigurationBuilder

            configBuilder.Add(New Providers.WinFormsConfigurationSource(settingsBase))
            Return configBuilder
        End Function
    End Module
End Namespace