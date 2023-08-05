Public Class Settings

    Private Const SETTINGS_NAME As String = "FexmanSettings.json"

    Public Property LastDeviceIndex As Integer
    Public Property LastDebugMode As Boolean
    Public Property LastPatchFilePath As String
    Public Property LastDevice As Enums.DeviceEnum
    Public Property Presets As List(Of String)

    Private Shared ReadOnly Property SettingsPath As String
        Get
            Return IO.Path.Combine(My.Application.Info.DirectoryPath, SETTINGS_NAME)
        End Get
    End Property

    Private Sub New()

    End Sub

    Public Shared Function GetInstance() As Settings
        Dim s As Settings = Nothing

        Try
            If IO.File.Exists(Settings.SettingsPath) Then
                s = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Settings)(IO.File.ReadAllText(Settings.SettingsPath))
            End If
        Catch

        End Try

        If s Is Nothing Then s = New Settings

        Return s
    End Function

    Public Sub Save()
        IO.File.WriteAllText(Settings.SettingsPath, Newtonsoft.Json.JsonConvert.SerializeObject(Me))
    End Sub

End Class
