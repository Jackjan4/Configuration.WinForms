# Configuration.WinForms
This is a [configuration provider](https://learn.microsoft.com/en-us/dotnet/core/extensions/configuration-providers) that adds support for the WinForms application settings.
These classic application settings are managed in the Settings.settings file in a WinForms project. During program runtime these settings are typically saved in the current users AppData folder (AppData/Local/ on Windows)

**Note that when using this configuration provider the settings are read only!**
